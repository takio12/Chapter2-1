using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var first = new Song("ss","as",1 );
             var songs = new Song[10];

             for (int i = 0; i < 10; ++i)
                 songs[i] = new Song("ss","aa",1);
             */

            var songs = new Song[]
            {
               new Song("君の名は","米津健司",1),
               new Song("あなたに","米倉真紀子",2)
            };

            foreach(var s in songs)
            {                              //時間間隔の区切り記号の文法が定義されていないため、\がいる。
                Console.WriteLine(@"{0}{1}{2:m\:ss}",s.Title,s.ArtistName,TimeSpan.FromSeconds(s.Length));
            }

        }
    }
}
