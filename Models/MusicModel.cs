namespace SoaCA1.Models
{
    public class MusicModel
    {
      public   enum MusicGenres
    { 
        Rock,
        Indie,
        Pop,
        Country,
        Blues,
        Jazz,
        Classical,
        Electronic,
        Reggae,
        Other,
        Unknown
    }

        public string Artist { get; set; }= "Unknown";
        public string Album { get; set; }= "Unknown";
        public MusicGenres Genres { get; set; }=MusicGenres.Unknown;
        
        //constructor
        public MusicModel(string artist, string album, MusicGenres genres)
        {
            Artist = artist;
            Album = album;
            Genres = genres;
        }
        public MusicModel()
        {
            
        }
    



    }


}
