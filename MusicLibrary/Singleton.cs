using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public sealed class Singleton
     {
          private static Singleton _instance = null;
          private static readonly object _padlock = new object();
          private IMusicLibraryFactory _musicLibraryFactory;

          Singleton()
          {
               _musicLibraryFactory = new MusicLibraryFactory();
          }

          public static Singleton Instance
          {
               get
               {
                    lock (_padlock)
                    {
                         if (_instance == null)
                         {
                              _instance = new Singleton();
                         }
                         return _instance;
                    }
               }
          }

          public IMusicLibraryFactory GetMusicLibraryFactory()
          {
               return _musicLibraryFactory;
          }
     }

}
