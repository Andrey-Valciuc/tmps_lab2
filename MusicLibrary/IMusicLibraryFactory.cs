using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public interface IMusicLibraryFactory
     {
          IMusicLibrary CreateMusicLibrary();
     }

     public class MusicLibraryFactory : IMusicLibraryFactory
     {
          public IMusicLibrary CreateMusicLibrary()
          {
               Console.WriteLine("Creating music library using Abstract Factory.");
               return MusicLibrary.Create();
          }
     }

}
