using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zita3
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
                var val = Enumerable.Repeat(a, 2);
                foreach (int res in val)
                {
                    v.Add(res);

                }
            }
            int m = 2 * n;
            for(int i=0;i<m;i++)
            {
                Console.Write(v[i] + " ");

            }
            Console.ReadKey();
        }
    }
}
