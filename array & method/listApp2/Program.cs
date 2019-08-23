using System;
using System.Collections.Generic;
using System.Linq;

namespace listApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqemler daxil edin: ");
            string [] str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                nums[i] = int.Parse(str[i]);

                
            }
            Console.WriteLine("En boyuk reqem: ");
            Console.WriteLine(nums.Max());
            Console.WriteLine("En kicik reqem: ");
            Console.WriteLine(nums.Min());
            Console.WriteLine("Reqemlerin cemi: ");
            Console.WriteLine(nums.Sum());
            Console.WriteLine("Reqemlerin tersi");
            Array.Reverse(nums);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }


        }
    }
}
