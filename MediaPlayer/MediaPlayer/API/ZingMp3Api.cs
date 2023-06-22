using System;
using System.Text;
using System.Threading.Tasks;
using xNet;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace MediaPlayer.API
{
    public class ZingMp3Api
    {
        private string VERSION;
        private string URL;
        private string SECRET_KEY;
        private string API_KEY;
        private string CTIME;

        public ZingMp3Api(string VERSION, string URL, string SECRET_KEY, string API_KEY, string CTIME)
        {
            this.VERSION = VERSION;
            this.URL = URL;
            this.SECRET_KEY = SECRET_KEY;
            this.API_KEY = API_KEY;
            this.CTIME = CTIME;
        }

        private string GetHash256(string str)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private string GetHmac512(string str, string key)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(System.Text.Encoding.UTF8.GetBytes(key)))
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
                byte[] hashBytes = hmac.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private string HashParamNoId(string path)
        {
            string hash = GetHash256($"ctime={CTIME}version={VERSION}");
            string concatenated = path + hash;
            return GetHmac512(concatenated, SECRET_KEY);
        }

        private string HashParam(string path, string id)
        {
            string hash = GetHash256($"ctime={CTIME}id={id}version={VERSION}");
            string concatenated = path + hash;
            return GetHmac512(concatenated, SECRET_KEY);
        }

        private string HashParamHome(string path)
        {
            string hash = GetHash256($"count=30ctime={CTIME}page=1version={VERSION}");
            string concatenated = path + hash;
            return GetHmac512(concatenated, SECRET_KEY);
        }

        private string HashCategoryMV(string path, string id, string type)
        {
            string hash = GetHash256($"ctime={CTIME}id={id}type={type}version={VERSION}");
            string concatenated = path + hash;
            return GetHmac512(concatenated, SECRET_KEY);
        }

        private string HashListMV(string path, string id, string type, string page, string count)
        {
            string hash = GetHash256($"count={count}ctime={CTIME}id={id}page={page}type={type}version={VERSION}");
            string concatenated = path + hash;
            return GetHmac512(concatenated, SECRET_KEY);
        }

        private async Task<string> GetCookie()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.Headers.TryGetValues("Set-Cookie", out var setCookieValues))
                {
                    string cookie = null;

                    if (setCookieValues.Any())
                    {
                        cookie = setCookieValues.First();
                    }

                    return cookie;
                }
            }

            return null;
        }

        private async Task<string> RequestZingMp3(string path, object qs)
        {
            using (HttpClient client = new HttpClient())
            {
                string cookie = await GetCookie();

                var queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
                queryString["ctime"] = CTIME;
                queryString["version"] = VERSION;
                queryString["apiKey"] = API_KEY;

                foreach (var property in qs.GetType().GetProperties())
                {
                    queryString[property.Name] = property.GetValue(qs).ToString();
                }

                string url = $"{URL}{path}?{queryString}";
                Console.WriteLine(url);
                client.DefaultRequestHeaders.Add("Cookie", cookie);
                HttpResponseMessage response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }

        //Get song
        public async Task<dynamic> GetSong(string songId)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/song/get/streaming", 
                    new { 
                        id = songId, 
                        sig = HashParam("/api/v2/song/get/streaming", songId) 
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get Detail Playlist
        public async Task<dynamic> GetDetailPlaylist(string playlistId)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/page/get/playlist",
                    new { 
                        id = playlistId,
                        sig = HashParam("/api/v2/page/get/playlist", playlistId) 
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get Home 
        public async Task<dynamic> GetHome()
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/page/get/home",
                    new { 
                        page = 1,
                        segmentId = "-1",
                        count = "30",
                        sig = HashParamHome("/api/v2/page/get/home")
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get Top 100
        public async Task<dynamic> GetTop100()
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/page/get/top-100",
                    new
                    {
                        sig = HashParamNoId("/api/v2/page/get/top-100")
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get Chart Home
        public async Task<dynamic> GetChartHome()
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/page/get/chart-home",
                    new
                    {
                        sig = HashParamNoId("/api/v2/page/get/chart-home")
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get new Release Chart
        public async Task<dynamic> GetNewReleaseChart()
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/page/get/newrelease-chart",
                    new
                    {
                        sig = HashParamNoId("/api/v2/page/get/newrelease-chart")
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get Info Song
        public async Task<dynamic> GetInfoSong(string songId)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/song/get/info",
                    new
                    {
                        id = songId,
                        sig = HashParam("/api/v2/song/get/info",songId)
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get List Artist Song
        public async Task<dynamic> GetListArtistSong(string artistId,string page,string count)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/song/get/list",
                    new
                    {
                        id = artistId,
                        type = "artist",
                        page = page,
                        count = count,
                        sort = "new",
                        sectionId = "aSong",
                        sig = HashListMV("/api/v2/song/get/list", artistId,"artist",page,count)
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get Artist
        public async Task<dynamic> GetArtist(string name)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/page/get/artist",
                    new
                    {
                        alias = name,
                        sig = HashParamNoId("/api/v2/page/get/artist")
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get lyric
        public async Task<dynamic> GetLyric(string songId)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/lyric/get/lyric",
                    new { 
                        id = songId,
                        sig = HashParam("/api/v2/lyric/get/lyric", songId) 
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Search
        public async Task<dynamic> Search(string name)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/search/multi",
                    new { 
                        q = name, 
                        sig = HashParamNoId("/api/v2/search/multi") 
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get List MV
        public async Task<dynamic> GetListMV(string id,string page,string count)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/video/get/list",
                    new
                    {
                        id = id,
                        type = "genre",
                        page = page,
                        count = count,
                        sort = "listen",
                        sig = HashListMV("/api/v2/video/get/list", id, "genre", page, count),
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get Category MV
        public async Task<dynamic> GetCategoryMV(string id)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/genre/get/info",
                    new
                    {
                        id = id,
                        type = "video",
                        sig = HashCategoryMV("/api/v2/genre/get/info", id, "video"),
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get video
        public async Task<dynamic> GetVideo(string videoId)
        {
            try
            {
                string res = await RequestZingMp3("/api/v2/page/get/video",
                    new
                    {
                        id = videoId,
                        sig = HashParam("/api/v2/page/get/video", videoId),
                    });
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
