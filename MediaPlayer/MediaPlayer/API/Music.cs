using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Media;
using System.IO;
using xNet;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Security.Policy;
using System.Data;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Web.UI.WebControls;

namespace MediaPlayer.API
{
    public class DS_SearchMusic
    {
        public List<Song> Songs { get; set; }
        public List<Artist> Artists { get; set; }
    }
    public class Song
    {
        public string position { get; set; }
        public string id { get; set; }  
        public string artist { get; set; }
        public string name { get; set; }
        public string duration { get; set; }
        public string albumName { get; set; }
        public string thumb { get; set; }
        public string lyric { get; set; }
    }
    public class Artist
    {
        public string name { get; set; }
        public string thumb { get; set; }
        public string id { get; set; }
    }

    public class APIMusic
    {
        #region
        // use to search: http://ac.mp3.zing.vn/complete?type=artist,song,key,code&num=5&query=cuối tuầ
        string url_search = "http://ac.mp3.zing.vn/complete";
        string url_get_thumb = "https://photo-resize-zmp3.zmdcdn.me/w240_r1x1_jpeg";
        #endregion
        public DS_SearchMusic searchMusic(string content, string type= "artist,song,key,code", int num=10)
        {
            List<Song> songList = new List<Song>();
            List<Artist> artistList = new List<Artist>();

            HttpRequest http = new HttpRequest();
            string url = $"http://ac.mp3.zing.vn/complete?type={type}&num={num}&query={content}";
            string json = http.Get(url).ToString();
            dynamic response = JsonConvert.DeserializeObject(json);

            JArray dataArray = response.data;
            if (dataArray.Count > 0 && dataArray[0] is JObject firstDataObject && firstDataObject.ContainsKey("song"))
            {
                foreach (JObject item in dataArray[0]["song"])
                {
                    Song song = new Song
                    {
                        id = item["id"].ToString(),
                        name = item["name"].ToString(),
                        artist = item["artist"].ToString(),
                        duration = item["duration"].ToString(),
                        thumb = item["thumb"].ToString(),
                    };
                    songList.Add(song);
                }
            }
            if (dataArray.Count > 1 && dataArray[1] is JObject secondDataObject && secondDataObject.ContainsKey("artist"))
            {
                foreach (JObject item in dataArray[1]["artist"])
                {
                    artistList.Add(new Artist
                    {
                        name = item["name"].ToString(),
                        thumb = item["thumb"].ToString(),
                        id = item["id"].ToString()
                    });
                }
            }
            DS_SearchMusic dS_SearchMusic = new DS_SearchMusic
            { 
                Songs = songList,
                Artists = artistList
            };
            return dS_SearchMusic;
        }

        public Bitmap getImage(string id)
        {
            string imageUrl = $"https://photo-resize-zmp3.zmdcdn.me/w240_r1x1_jpeg/{id}";
            Bitmap bmp = null;
            if (id == "") return bmp;
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

        public string getAudio(string MusicId,int quality = 320)
        {
            string audioUrl = $"http://api.mp3.zing.vn/api/streaming/audio/{MusicId}/{quality}";
            string urlAudio = null;
            using (HttpRequest http = new HttpRequest())
            {
                try
                {
                    // Send a GET request to download the audio
                    HttpResponse response = http.Get(audioUrl);

                    // Check if the request was successful
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // Retrieve the audio data as a byte array
                        byte[] audioData = response.ToBytes();

                        urlAudio = Path.GetTempFileName();
                        // Save the audio data to the temporary file
                        File.WriteAllBytes(urlAudio, audioData);
                        return urlAudio;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            return urlAudio;
        }

        public List<Song> getChartRealtime()
        {
            string url_chart = "http://mp3.zing.vn/xhr/chart-realtime";
            List<Song> songList = new List<Song>();

            HttpRequest http = new HttpRequest();
            string json = http.Get(url_chart).ToString();
            dynamic response = JsonConvert.DeserializeObject(json);

            JArray dataArray = response.data;
            if (dataArray.Count > 0 && dataArray[0] is JObject firstDataObject && firstDataObject.ContainsKey("song"))
            {
                foreach (JObject item in dataArray[0]["song"])
                {
                    Song song = new Song
                    {
                        id = item["id"].ToString(),
                        name = item["name"].ToString(),
                        artist = item["artist"]["name"].ToString(),
                        duration = item["duration"].ToString(),
                        thumb = item["thumbnail"].ToString(),
                        lyric = item["lyric"].ToString(),
                        position = item["position"].ToString(),
                    };
                    if(item.ContainsKey("album"))
                    {
                        song.albumName = item["album"]["name"].ToString();
                    }
                    songList.Add(song);
                }
            }
            return songList;
        }
    }
}
