using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class VoterCheck
    {
        public static List<People> where(People[] people, EligibilityCheck del)
        {
            List<People> voters = new List<People>();
            foreach( People p in people)
            {
                if (del(p))
                {
                    voters.Add(p);
                }
            }
            return voters;
        }
    }
}
