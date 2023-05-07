using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public interface IMusicLibrary
     {
          void AddSong(Song song);
          void RemoveSong(Song song);
          void ListSongs();
     }

}
