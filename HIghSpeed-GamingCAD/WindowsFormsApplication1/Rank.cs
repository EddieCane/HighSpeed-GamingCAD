using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public class Rank
    {
        public int rankID;
        public string rankTitle;
        public static List<Rank> RankList = new List<Rank>();

        public Rank(int v1, string v2)
        {
            this.rankID = v1;
            this.rankTitle = v2;
            RankList.Add(this);
            foreach (Rank rank in RankList)
            {
                Debug.WriteLine(rank.rankID + " " + rank.rankTitle);
                //Console.WriteLine(rank.rankID + " " + rank.rankTitle);
            }
        }
        public Rank()
        {

        }
    }
}
