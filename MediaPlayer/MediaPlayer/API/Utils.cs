using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using xNet;
namespace MediaPlayer.API
{
    public class Utils
    {
        /*
         * function getImage()
         * Input: imageUrl
         * Output: Bitmap
         * Use: picture.Image = getImage(imageUrl);
        */
        public Bitmap getImage(string imageUrl)
        {
            Bitmap bmp = null;
            using (HttpRequest http = new HttpRequest())
            {
                try
                {
                    // Send a GET request to download the image
                    HttpResponse response = http.Get(imageUrl);

                    // Check if the request was successful
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // Read the image data into a memory stream
                        MemoryStream imageStream = new MemoryStream(response.ToBytes());

                        // Create a bitmap from the memory stream
                        Bitmap image = new Bitmap(imageStream);
                        return image;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            return bmp;
        } 
        /*
         * function getSong()
         * Input: data when call api GetSong(songId)
         * Ouput: string(url of tempfile save audiodata)
         * use: player.URL = getSong(data);
        */
        public string getSong(string data)
        {
            string urlSong = null;
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            if (jsonObject["err"].ToString() == "0")
            {
                JObject property1 = (JObject)jsonObject["data"];
                string audioUrl = property1["128"].ToString();
                using (HttpRequest http = new HttpRequest())
                {
                    try
                    {
                        // Send a GET request to download the audio
                        HttpResponse res = http.Get(audioUrl);

                        // Check if the request was successful
                        if (res.StatusCode == HttpStatusCode.OK)
                        {
                            // Retrieve the audio data as a byte array
                            byte[] audioData = res.ToBytes();

                            urlSong = Path.GetTempFileName();
                            // Save the audio data to the temporary file
                            File.WriteAllBytes(urlSong, audioData);
                            return urlSong;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }
            return urlSong;
        }
        public void handleDownloadSong(string data)
        {
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            JObject property1 = (JObject)jsonObject["data"];
            string audioUrl = property1["128"].ToString();
            SaveFileDialog saveFileRecord = new SaveFileDialog();
            using (HttpRequest http = new HttpRequest())
            {
                try
                {
                    // Send a GET request to download the audio
                    HttpResponse res = http.Get(audioUrl);

                    // Check if the request was successful
                    if (res.StatusCode == HttpStatusCode.OK)
                    {
                        // Retrieve the audio data as a byte array
                        byte[] audioData = res.ToBytes();
                        saveFileRecord.Filter = "(.mp3)|*.mp3";
                        saveFileRecord.ShowDialog();
                        // Save the audio data to the temporary file
                        File.WriteAllBytes(saveFileRecord.FileName, audioData);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
        /*
         * function getLyrics()
         * Input: data when call api GetLyric(songId);
         * Ouput: Lyric
         * use: Lyric lyric = getLyrics(data);
         */
        public Lyric getLyrics(string data)
        {
            Lyric lyrics = new Lyric();
            lyrics.sentences = new List<Sentence> { };
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            JObject res = (JObject)jsonObject["data"];
            foreach (var subitem in res.Properties())
            {
                if (subitem.Name == "sentences")
                {
                    foreach (JToken subsubitem in subitem.Value)
                    {
                        Sentence sen = new Sentence();
                        sen.sentence = new List<Word>{ };
                        foreach (JToken subsubsubitem in subsubitem["words"])
                        {
                            Word word = new Word();
                            JObject obj = (JObject)subsubsubitem;
                            word.data = obj["data"].ToString();
                            word.startTime = int.Parse(obj["startTime"].ToString());
                            word.endTime = int.Parse(obj["endTime"].ToString());
                            sen.sentence.Add(word);
                        }
                        lyrics.sentences.Add(sen);
                    }
                }
                else if (subitem.Name == "file")
                {
                    lyrics.file = subitem.Value.ToString();
                }
            }
            return lyrics;
        }
        /*
         * function getHome()
         * Input: data when call API GetHome()
         * Output: HomePage
         * Use: HomePage homepage = getHome(data);
         */
        public HomePage getHome(string data)
        {
            HomePage homePage = new HomePage();
            homePage.newRelease = new SectionDetail();
            homePage.chill = new SectionDetail();
            homePage.artistPopular = new SectionDetail();
            homePage.energyPositive = new SectionDetail();
            homePage.banner = new SectionDetail();
            homePage.banner.listBanners = new List<BannerItem> {};
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            JObject property1 = (JObject)jsonObject["data"];
            foreach (var item in property1.Properties())
            {
                if(item.Name == "items")
                {
                    foreach(JToken subitem in item.Value)
                    {
                        if (subitem["sectionType"].ToString() == "banner")
                        {
                            homePage.banner.sectionType = subitem["sectionType"].ToString();
                            foreach(JToken subsubitem in subitem["items"])
                            {
                                if (subsubitem["type"].ToString() == "1")
                                {
                                    BannerItem banner = new BannerItem();
                                    banner.banner = subsubitem["banner"].ToString();
                                    banner.songId = subsubitem["encodeId"].ToString();
                                    homePage.banner.listBanners.Add(banner);
                                }
                            }
                        }
                        else if (subitem["sectionType"].ToString() == "new-release" && subitem["title"].ToString() == "Mới phát hành")
                        {
                            homePage.newRelease = new SectionDetail();
                            homePage.newRelease.listSongs = new List<Song> { };
                            homePage.newRelease.title = subitem["title"].ToString();
                            homePage.newRelease.sectionType = subitem["sectionType"].ToString();
                            JObject obj = (JObject)subitem["items"];
                            foreach (var subsubitem in obj.Properties())
                            {
                                if (subsubitem.Name == "all")
                                {
                                    foreach(JToken subsubsubitem in subsubitem.Value)
                                    {
                                        Song song = new Song();
                                        song.songId = subsubsubitem["encodeId"].ToString();
                                        song.title = subsubsubitem["title"].ToString();
                                        song.alias = subsubsubitem["alias"].ToString();
                                        song.artistsNames = subsubsubitem["artistsNames"].ToString();
                                        song.thumbnail = subsubsubitem["thumbnail"].ToString();
                                        song.releaseDate = int.Parse(subsubsubitem["releaseDate"].ToString());
                                        homePage.newRelease.listSongs.Add(song);
                                    }
                                }
                            }
                        }
                        else if (subitem["sectionType"].ToString() == "playlist" && subitem["title"].ToString() == "Chill")
                        {
                            homePage.chill = new SectionDetail();
                            homePage.chill.listPlaylists = new List<Playlist> { };
                            homePage.chill.title = subitem["title"].ToString();
                            homePage.chill.sectionType = subitem["sectionType"].ToString();
                            foreach (JObject subsubitem in subitem["items"])
                            {
                                Playlist playlist = new Playlist();
                                playlist.playlistId = subsubitem["encodeId"].ToString();
                                playlist.thumbnailM = subsubitem["thumbnailM"].ToString();
                                playlist.sortDescription = subsubitem["sortDescription"].ToString();
                                homePage.chill.listPlaylists.Add(playlist);
                            }
                        }
                        else if (subitem["sectionType"].ToString() == "playlist" && subitem["title"].ToString() == "Nghệ sĩ thịnh hành")
                        {
                            homePage.artistPopular = new SectionDetail();
                            homePage.artistPopular.listPlaylists = new List<Playlist>{ };
                            homePage.artistPopular.title = subitem["title"].ToString();
                            homePage.artistPopular.sectionType = subitem["sectionType"].ToString();
                            foreach (JObject subsubitem in subitem["items"])
                            {
                                Playlist playlist = new Playlist();
                                playlist.playlistId = subsubitem["encodeId"].ToString();
                                playlist.thumbnailM = subsubitem["thumbnailM"].ToString();
                                playlist.sortDescription = subsubitem["sortDescription"].ToString();
                                homePage.artistPopular.listPlaylists.Add(playlist);
                            }
                        }
                        else if (subitem["sectionType"].ToString() == "playlist" && subitem["title"].ToString() == "Năng lượng tích cực")
                        {
                            homePage.energyPositive = new SectionDetail();
                            homePage.energyPositive.listPlaylists = new List<Playlist>{ };
                            homePage.energyPositive.title = subitem["title"].ToString();
                            homePage.energyPositive.sectionType = subitem["sectionType"].ToString();
                            foreach (JObject subsubitem in subitem["items"])
                            {
                                Playlist playlist = new Playlist();
                                playlist.playlistId = subsubitem["encodeId"].ToString();
                                playlist.thumbnailM = subsubitem["thumbnailM"].ToString();
                                playlist.sortDescription = subsubitem["sortDescription"].ToString();
                                homePage.energyPositive.listPlaylists.Add(playlist);
                            }
                        }
                    }
                }
            }
            return homePage;
        }
        /*
         * function getInfoSong()
         * Input: data when call API GetInfoSong(songId)
         * Output: Song
         * Use: Song song = getInfoSong(data)
         */
        public Song getInfoSong(string data)
        {
            Song song = new Song();
            song.artists = new List<Artist>{ };
            song.genres = new List<Genre>{ };
            song.album = new Album();
            song.lyric = new Lyric();
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            JObject res = (JObject)jsonObject["data"];

            song.songId = res["encodeId"].ToString();
            song.title = res["title"].ToString();
            song.alias = res["alias"].ToString();
            song.artistsNames = res["artistsNames"].ToString();
            song.thumbnail = res["thumbnail"].ToString();
            song.thumbnailM = res["thumbnailM"].ToString();
            song.duration = int.Parse(res["duration"].ToString());
            song.releaseDate = int.Parse(res["releaseDate"].ToString());
            song.totalLike = int.Parse(res["like"].ToString());
            song.totalListen = int.Parse(res["listen"].ToString());
            /*
             * Chưa lấy hết dữ liệu vì không dùng đến
             * Cần thì call API và lấy tiếp...
             */
            return song;
        }
        /*
         * funtion getArtist()
         * Input: data when call API GetArtist(aliasArtist)
         * Output: Artist
         * Use: Artist artist = getArtist(dataArtist)
         */
        public Artist getArtist(string dataArtist)
        {
            dynamic response = JsonConvert.DeserializeObject(dataArtist);
            JObject jsonObject = (JObject)response;
            JObject res = (JObject)jsonObject["data"];

            Artist artist = new Artist();
            artist.listSongs = new List<Song>{ };
            artist.listAlbums = new List<Album>{ };
            artist.artistId = res["id"].ToString();
            artist.name = res["name"].ToString();
            artist.alias = res["alias"].ToString();
            artist.playlistId = res["playlistId"].ToString();
            artist.thumbnail = res["thumbnail"].ToString();
            artist.thumbnailM = res["thumbnailM"].ToString();
            artist.realname = res["realname"].ToString();
            artist.birthday = res["birthday"].ToString();
            artist.cover = res["cover"].ToString();
            artist.national = res["national"].ToString();
            artist.totalFollow = int.Parse(res["totalFollow"].ToString());
            /*
             * When click artist => call API GetListArtistSong() to get all song.
             */
            return artist;
        }
        /*
         * function getListArtistSong()
         * Input: data when call API GetArtistSong(artistId,..)
         * Output: List<Song>
         * Use: List<Song> list = getListArtistSong(data)
         */
        public List<Song> getListArtistSong(string data) 
        {
            List<Song> list = new List<Song>{ };
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            JObject res = (JObject)jsonObject["data"];
            foreach (var item in res.Properties())
            {
                if (item.Name == "items")
                {
                    foreach (JToken subitem in item.Value)
                    {
                        Song song = new Song();
                        song.songId = subitem["encodeId"].ToString();
                        song.title = subitem["title"].ToString();
                        song.alias = subitem["alias"].ToString();
                        song.artistsNames = subitem["artistsNames"].ToString();
                        song.thumbnail = subitem["thumbnail"].ToString();
                        song.thumbnailM = subitem["thumbnailM"].ToString();
                        song.duration = int.Parse(subitem["duration"].ToString());
                        song.releaseDate = int.Parse(subitem["releaseDate"].ToString());
                        list.Add(song);
                    }
                }
            }
            return list;
        }
        /*
         * functtion getVideo()
         * Input: data when call API GetVideo(videoId)
         * Check if err == -1023 => Bài hát không có video
         * else if err == 0 => Bài hát có video
         * Output: Video 
         * Use: ....
         */
        public Video getVideo(string data)
        {
            Video video = new Video();
            string urlVideo = null;
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            var err = jsonObject["err"];
            if (err.ToString() == "-1023")
            {
                return null;
            }
            else if (err.ToString() == "0")
            {
                JObject property1 = (JObject)jsonObject["data"];
                video.videoId = property1["encodeId"].ToString();
                JObject property2 = (JObject)property1["streaming"];
                JObject property3 = (JObject)property2["mp4"];
                video.linkVideo = (property3["360p"]).ToString();

                using (HttpRequest http = new HttpRequest())
                {
                    try
                    {
                        // Send a GET request to download the audio
                        HttpResponse res = http.Get(video.linkVideo);

                        // Check if the request was successful
                        if (res.StatusCode == HttpStatusCode.OK)
                        {
                            // Retrieve the audio data as a byte array
                            byte[] videoData = res.ToBytes();

                            urlVideo = Path.GetTempFileName();
                            // Save the audio data to the temporary file
                            File.WriteAllBytes(urlVideo, videoData);
                            video.linkFileTempVideo = urlVideo;
                            return video;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }

            }
            return video;
        }
        public Genre getGenre(JToken dataGenre)
        {
            Genre genre = new Genre();
            // Handle add genre
            return genre;
        }
        public Album getAlbum(JToken dataAlbum)
        {
            Album album = new Album(); 
            return album;
        }
        public Playlist getPlaylist(string data)
        {
            Playlist playlist = new Playlist();
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            JObject res = (JObject)jsonObject["data"];
            playlist.playlistId = res["encodeId"].ToString();
            playlist.title = res["title"].ToString();
            playlist.thumbnail = res["thumbnail"].ToString();
            playlist.thumbnailM = res["thumbnailM"].ToString();
            playlist.sortDescription = res["sortDescription"].ToString();
            playlist.artistsNames = res["artistsNames"].ToString();
            playlist.artists = new List<Artist>{ };
            playlist.genres = new List<Genre>{ };
            playlist.totalLike = int.Parse(res["like"].ToString());
            playlist.totalListen = int.Parse(res["listen"].ToString());
            playlist.listSongs = new List<Song>{ };
            JObject obj = (JObject)res["song"];
            foreach (var subsubitem in obj.Properties())
            {
                if (subsubitem.Name == "items")
                {
                    foreach (JToken subsubsubitem in subsubitem.Value)
                    {
                        
                        Song song = new Song();
                        song.songId = subsubsubitem["encodeId"].ToString();
                        song.title = subsubsubitem["title"].ToString();
                        song.alias = subsubsubitem["alias"].ToString();
                        song.artistsNames = subsubsubitem["artistsNames"].ToString();
                        song.thumbnail = subsubsubitem["thumbnail"].ToString(); 
                        song.duration = int.Parse(subsubsubitem["duration"].ToString());
                        song.releaseDate = int.Parse(subsubsubitem["releaseDate"].ToString());
                        playlist.listSongs.Add(song);
                    }
                }
                else if(subsubitem.Name == "total")
                {
               playlist.totalSongs = int.Parse(subsubitem.Value.ToString());
                }
                else if(subsubitem.Name == "totalDuration")
                {
              playlist.totalDuration = int.Parse(subsubitem.Value.ToString());
                }
            }
            return playlist;
        }
        public Search handleSearch(string data)
        {
            Search search = new Search();
            search.listArtists = new List<Artist>{ };
            search.listSongs = new List<Song>{ };
            search.listVideos = new List<Video>{ };
            search.listPlaylists = new List<Playlist>{ };

            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            JObject property1 = (JObject)jsonObject["data"];
            foreach (var item in property1.Properties())
            {
                if (item.Name == "artists")
                {
                    foreach(JToken subitem in item.Value)
                    {
                        Artist artist = new Artist();
                        artist.name = subitem["name"].ToString();
                        artist.artistId = subitem["id"].ToString();
                        artist.alias = subitem["alias"].ToString();
                        artist.thumbnail = subitem["thumbnail"].ToString();
                        artist.thumbnailM = subitem["thumbnailM"].ToString();
                        artist.totalFollow = int.Parse(subitem["totalFollow"].ToString());
                        search.listArtists.Add(artist);
                    }    
                }
                else if(item.Name == "songs")
                {
                    foreach (JToken subitem in item.Value)
                    {
                        Song song = new Song();
                        song.songId = subitem["encodeId"].ToString();
                        song.title = subitem["title"].ToString();
                        song.alias = subitem["alias"].ToString();
                        song.artistsNames = subitem["artistsNames"].ToString();
                        song.thumbnail = subitem["thumbnail"].ToString();
                        song.thumbnailM = subitem["thumbnailM"].ToString();
                        song.duration = int.Parse(subitem["duration"].ToString());
                        song.releaseDate = int.Parse(subitem["releaseDate"].ToString());
                        search.listSongs.Add(song);
                    }
                }
                else if(item.Name == "videos")
                {
                    foreach (JToken subitem in item.Value)
                    {
                        Video video = new Video();
                        video.song = new Song();
                        video.videoId = subitem["encodeId"].ToString();
                        video.song.title = subitem["title"].ToString();
                        video.song.artistsNames = subitem["artistsNames"].ToString();
                        search.listVideos.Add(video);
                    }
                }
                else if(item.Name == "playlists")
                {
                    foreach (JToken subitem in item.Value)
                    {
                        Playlist playlist = new Playlist();
                        playlist.title = subitem["title"].ToString();
                        playlist.playlistId = subitem["encodeId"].ToString();
                        playlist.thumbnail = subitem["thumbnail"].ToString();
                        playlist.thumbnailM = subitem["thumbnailM"].ToString();
                        playlist.sortDescription = subitem["sortDescription"].ToString();
                        //playlist.artistsNames = subitem["artistsNames"].ToString();
                        search.listPlaylists.Add(playlist);
                    }
                }
            }
            return search;
        }
        public ChartHome getHomeChart(string data)
        {
            ChartHome chart = new ChartHome();
            chart.listSongs = new List<Song>{ };
            chart.chart = new Chart();
            chart.chart.top1 = new List<dataChart>{ };
            chart.chart.top2 = new List<dataChart>{ };
            chart.chart.top3 = new List<dataChart>{ };
            chart.chart.times = new List<string>();
            dynamic response = JsonConvert.DeserializeObject(data);
            JObject jsonObject = (JObject)response;
            JObject property1 = (JObject)jsonObject["data"];
            JObject property2 = (JObject)property1["RTChart"];
            foreach(var item in property2.Properties())
            {
                if (item.Name == "chart")
                {
                    JObject subtime = (JObject)item.Value;
                    foreach (var subsubitem in subtime.Properties())
                    {
                        if(subsubitem.Name == "times")
                        {
                            foreach(var subsubsubitem in subsubitem.Value)
                            {
                                chart.chart.times.Add(subsubsubitem["hour"].ToString());
                            }
                        }
                        else if(subsubitem.Name == "minScore")
                        {
                            chart.chart.minScore = float.Parse(subsubitem.Value.ToString());
                        }
                        else if(subsubitem.Name == "maxScore")
                        {
                            chart.chart.maxScore = float.Parse(subsubitem.Value.ToString());
                        }
                        else if( subsubitem.Name == "items")
                        {
                            int i = 1;
                            foreach(var subsubsubitem in subsubitem.Value)
                            {
                                List<dataChart> list = new List<dataChart>{ };
                                foreach(var subsubsubsubitem in subsubsubitem)
                                {
                                    foreach(JToken subsubsubsubsubitem in subsubsubsubitem)
                                    {
                                        dataChart it = new dataChart();
                                        it.time = subsubsubsubsubitem["hour"].ToString();
                                        it.counter = float.Parse(subsubsubsubsubitem["counter"].ToString());
                                        list.Add(it);
                                    }
                                }
                                if (i == 1)
                                {
                                    chart.chart.top1 = list;
                                }
                                else if(i == 2)
                                {
                                    chart.chart.top2 = list;
                                }
                                else if(i == 3)
                                {
                                    chart.chart.top3 = list;
                                }
                                i++;
                            }
                        }
                    }
                }
                else if(item.Name == "items")
                {
                    foreach (JToken subitem in item.Value)
                    {
                        Song song = new Song();
                        song.songId = subitem["encodeId"].ToString();
                        song.title = subitem["title"].ToString();
                        song.alias = subitem["alias"].ToString();
                        song.artistsNames = subitem["artistsNames"].ToString();
                        song.thumbnail = subitem["thumbnail"].ToString();
                        song.thumbnailM = subitem["thumbnailM"].ToString();
                        song.duration = int.Parse(subitem["duration"].ToString());
                        song.releaseDate = int.Parse(subitem["releaseDate"].ToString());
                        chart.listSongs.Add(song);
                    }
                }
            }
                return chart;
        }
    }
}
