using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public class MusicLibrary : IMusicLibrary
     {
          private List<Song> _songs = new List<Song>();

          public void AddSong(Song song)
          {
               _songs.Add(song);
               Console.WriteLine("Song added to library.");
          }

          public void RemoveSong(Song song)
          {
               _songs.Remove(song);
               Console.WriteLine("Song removed from library.");
          }

          public void ListSongs()
          {
               Console.WriteLine("Songs in library:");
               foreach (var song in _songs)
               {
                    Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}, Year: {song.Year}");
               }
          }

          public static MusicLibrary Create()
          {
               Console.WriteLine("Creating music library.");
               return new MusicLibrary();
          }
     }

}
