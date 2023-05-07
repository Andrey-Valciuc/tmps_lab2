using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public class Song : ICloneable
     {
          public string Title { get; set; }
          public string Artist { get; set; }
          public int Year { get; set; }

          public object Clone()
          {
               return MemberwiseClone();
          }
     }


}
