using System;
using System.Collections.Generic;
using System.Linq;

namespace LOC.Core.Extension
{
    static class StringExtension
    {
        /// <summary>
        /// split string to list of int
        /// </summary>
        /// <param name="sl"></param>
        /// <returns></returns>
        public static List<int> Split2Int(this string sl, char spliter = ',')
        {
            string[] temp;
            temp = sl.Split(spliter);
            List<int> arr = Array.ConvertAll(temp, int.Parse).ToList<int>();
            arr.Sort();

            return arr;
        }
    }
}
