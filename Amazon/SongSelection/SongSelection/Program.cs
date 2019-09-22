using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> SongsCollecation = new List<int>();
            SongsCollecation.Add(20);
            SongsCollecation.Add(70);
            SongsCollecation.Add(90);
            SongsCollecation.Add(30);
            SongsCollecation.Add(60);
            SongsCollecation.Add(110);
            idOFsONG(110, SongsCollecation);
        }

        public static List<int>  idOFsONG(int rideDuration, List<int> songDurations)
        {
         
            Dictionary<int, int> res1 = new Dictionary<int, int>();
           
            for (int j = 0; j < songDurations.Count; j++)
            {
                if (songDurations[j] != rideDuration)
                {
                    for (int i = j+1; i <= songDurations.Count-1; i++)
                    {
                        if (songDurations[i] != rideDuration)
                        {
                            if (songDurations[j] + songDurations[i] + 30 == rideDuration)
                            {
                                res1.Add(i, songDurations[i]);
                                res1.Add(j, songDurations[j]);
                               
                            }
                        }
                        else
                        {

                        }
                    }
                }
            }
            List<int> retres = new List<int>();
            
            var Key = from x in res1 where x.Value == res1.Max(v => v.Value) select x.Key;
            retres.Add(Convert.ToInt32(Key.FirstOrDefault()));
            int result;

            if (res1.TryGetValue((retres[0]), out result))
            {
                Console.WriteLine(result);
            }
            foreach (var item in res1)
            {
                if(result+item.Value+30== rideDuration)
                {
                    retres.Add(item.Key);
                }
            }
           
            return retres;
        }
    }
   
}
