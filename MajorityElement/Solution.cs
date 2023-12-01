
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    public class Solution
    {
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
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
