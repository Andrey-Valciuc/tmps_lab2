using System;

namespace MusicLibrary
{
     class Program
     {
          static void Main(string[] args)
          {
             
               var singleton = Singleton.Instance;
               var musicLibraryFactory = singleton.GetMusicLibraryFactory();

            
               var musicLibrary = musicLibraryFactory.CreateMusicLibrary();


               var songBuilder = new SongBuilder();
               var song1 = songBuilder.SetTitle("Song 1").SetArtist("Artist 1").SetYear(2021).Build();
               var song2 = songBuilder.SetTitle("Song 2").SetArtist("Artist 2").SetYear(2022).Build();

        
               var song3 = song1.Clone() as Song;
               song3.Title = "Song 3";

           
               musicLibrary.AddSong(song1);
               musicLibrary.AddSong(song2);
               musicLibrary.AddSong(song3);
               musicLibrary.ListSongs();
               musicLibrary.RemoveSong(song2);
               musicLibrary.ListSongs();

               Console.ReadKey();
          }
     }

     public class SongBuilder
     {
          private Song _song = new Song();

          public SongBuilder SetTitle(string title)
          {
               _song.Title = title;
               return this;
          }

          public SongBuilder SetArtist(string artist)
          {
               _song.Artist = artist;
               return this;
          }

          public SongBuilder SetYear(int year)
          {
               _song.Year = year;
               return this;
          }

          public Song Build()
          {
               return _song;
          }
     }

}
