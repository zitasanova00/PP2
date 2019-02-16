using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZITA1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> v = new List<int>();
            string[] arr = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {

                int a = int.Parse(arr[i]);
                int prime = 0;
                for (int j = (int)(Math.Sqrt(a)); j > 1 && prime == 0; j--)
                    if (a % j == 0)
                        prime = 1;

                if (prime == 0 && a != 1)
                    v.Add(a);
            }
            Console.WriteLine(v.Count);
            for (int i = 0; i < v.Count; i++)
                Console.WriteLine(v[i] + " ");
            Console.ReadKey();
     

            }
    }
}
