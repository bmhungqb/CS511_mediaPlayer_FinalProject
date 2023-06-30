using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WMPLib;

namespace MediaPlayer.API
{
    public class Artist
    {
        public string artistId {  get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string playlistId { get; set; }
        public string cover { get; set; }
        public string thumbnail { get; set; }
        public string thumbnailM { get; set; }
        public string national { get; set; }   
        public string birthday { get; set; }
        public string realname { get; set; }
        public int totalFollow { get; set; }
        public List<Song> listSongs { get; set; }
        public List<Album> listAlbums { get; set; }
    }
    public class Genre
    {
        public string genreId { get; set; } 
        public string name { get; set; }
        public string alias { get; set; }
    }
    public class Album
    {
        public string albumId { get; set; } 
        public string title { get; set; }
        public string thumbnail { get; set; }
        public string releaseDate { get; set; }
        public string artistsNames { get; set; }
        public List<Artist> artists { get; set; }
    }
    public class Lyric
    {
        public List<Sentence> sentences { get; set; }
        public string file { get; set; }   
    }
    public class Sentence
    {
        public List<Word> sentence { get; set; }
    }
    public class Word
    {
        public int startTime { get; set; }
        public int endTime { get; set; }
        public string data { get; set; }
    }
    public class Song
    {
        public string songId {  get; set; }
        public string title {  get; set; }
        public string alias {  get; set; }
        public string artistsNames {  get; set; }
        public List<Artist> artists {  get; set; }
        public List<Genre> genres {  get; set; }
        public Album album {  get; set; }
        public Lyric lyric {  get; set; }
        public int totalLike {  get; set; }
        public int totalListen {  get; set; }
        public int releaseDate {  get; set; }
        public int duration {  get; set; }
        public string thumbnailM {  get; set; }
        public string thumbnail {  get; set; }
        public int score { get; set; }
        public Video video { get; set; }
        public bool isRecord { get; set; } = false;
        public string filePathRecord { get;set; }
    }
    public class Playlist
    {
        public string playlistId { get; set; }
        public string title { get; set; }
        public string thumbnail { get; set; }
        public string thumbnailM { get; set; }
        public string sortDescription { get; set; }
        public string artistsNames { get; set; }
        public List<Artist> artists { get; set; }
        public List<Genre> genres { get; set; }
        public List<Song> listSongs { get; set; }
        public int totalSongs { get; set; } 
        public int totalDuration { get; set; }
        public int totalLike { get; set; }
        public int totalListen { get; set; }
    }
    public class SectionDetail
    {
        public string title { get; set; }
        public string sectionType { get; set; }
        public List<Song> listSongs { get; set; }
        public List<Playlist> listPlaylists { get; set; }
        public List<BannerItem> listBanners { get; set; }
    }
    public class BannerItem
    {
        public string banner { get; set; }
        public string songId { get; set; }
    }
    public class HomePage
    {
        public SectionDetail banner { get; set; }
        public SectionDetail newRelease { get; set; }
        public SectionDetail chill { get; set; }
        public SectionDetail artistPopular { get; set; }
        public SectionDetail energyPositive { get;set; }
    }

    public class ChartHome
    {
        public List<Song> listSongs { get; set; }
        public Chart chart { get; set; }    
    }
    public class Chart
    {
        public List<string> times { get; set; }
        public float minScore { get; set; }
        public float maxScore { get; set; }
        public List<dataChart> top1 { get; set; }
        public List<dataChart> top2 { get; set; }
        public List<dataChart> top3 { get; set; }
    }
    public class dataChart
    {
        public float counter { get; set; }
        public string time { get; set; }
    }
    public class Search
    {
        public List<Artist> listArtists { get; set; }
        public List<Song> listSongs { get; set; }
        public List<Video> listVideos { get; set; }
        public List<Playlist> listPlaylists { get; set; }
    }
    public class Video
    {
        public Song song { get; set; }
        public Artist artist { get; set; }
        public string linkVideo { get; set; }
        public string linkFileTempVideo { get; set; }
        public string videoId { get; set; }
        public int totalLike { get; set; }
        public int totalListen { get; set; }
    }
}
