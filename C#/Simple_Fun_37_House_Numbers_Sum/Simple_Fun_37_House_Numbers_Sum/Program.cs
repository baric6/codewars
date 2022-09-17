namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class Kata
    {
        public static int HouseNumbersSum(int[] inputArray)
        {
            HashSet<int> set = new HashSet<int>(inputArray);
        
            int sum = 0;
            foreach (int i in set)
            {
                if (i < 10)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            return sum;
        } 

        static public void Main(String[] args)
        {
            HouseNumbersSum(new int[] { 5, 1, 2, 3, 0, 1, 5, 0, 2 }); // 11
            HouseNumbersSum(new int[] { 4, 2, 1, 6, 0 }); // 13
            HouseNumbersSum(new int[] { 4, 1, 2, 3, 0, 10, 2 }); // 10

        }



    }
}
