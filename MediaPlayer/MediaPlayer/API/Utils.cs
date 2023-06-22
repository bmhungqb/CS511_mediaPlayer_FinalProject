using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;
using xNet;
namespace MediaPlayer.API
{
    public class Utils
    {
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
        public string getSong(string data)
        {
            string urlSong = null;
            dynamic dataConvert = JsonConvert.DeserializeObject(data);
            JArray dataArray = dataConvert.data;
            if (dataArray != null && dataArray.Count > 0)
            {
                string audioUrl = dataArray[0]["128"].ToString();
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
        public Lyric getLyrics(string data)
        {
            Lyric lyrics = new Lyric();
            return lyrics;
        }
        public HomePage getHome(string data)
        {
//    public SectionDetail banner { get; set; }
//public SectionDetail newRelease { get; set; }
//public SectionDetail chill { get; set; }
//public SectionDetail artistPopular { get; set; }
//public SectionDetail energyPositive { get; set; }
            HomePage homePage = new HomePage();
            MessageBox.Show(data.ToString());
            dynamic dataConvert = JsonConvert.DeserializeObject(data);
            JArray dataArray = dataConvert.data;
            if (dataArray != null && dataArray.Count > 0)
            {
                foreach (JObject item in dataArray[0]["items"])
                {
                }
            }
            return homePage;
        }
    }
}
