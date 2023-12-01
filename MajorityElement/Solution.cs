
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    internal class Solution
    {
        public int MajorityElement(int[] nums)
        {
            // 1st int - 
            Dictionary<int, int> dict = new Dictionary<int, int>();
            // SortedDictionary<int, int> dict = new SortedDictionary<int, int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));
            // SortedDictionary<int, int> dict = new SortedDictionary<int, int>().OrderBy();
            int lenghtDict = nums.Length / 2;
            foreach (int num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num] = dict[num]+1;
                    //if (dict[num] > lenghtDict)
                  //  {
                   //     return num;
                  //  }  
                }else
                {
                    dict[num] = 1;
                }

                if (dict[num] > lenghtDict)
                {
                    return num;
                }
            }

            //   int thenum = dict.Keys.ElementAt(0);
            //   var topMajorityNumber = dict.OrderByDescending(pair => pair.Value).Take(1).ToList();

            /*
            if (dict[thenum]> lenghtDict)
            {
                return thenum;
            }
            else
            {
                return -1;
            }
            */
            //   return -1;
            //  return topMajorityNumber[0].Key;
     
            return -1;
        }
    }
}
