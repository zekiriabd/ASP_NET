using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LemonwayWebservice.Services
{
    public class FibonacciService : IFibonacciService
    {
        public async Task<int?> FibonacciAsync(int n)
        {
            await Task.Delay(2000);
            int Fib(int x)
            {
                int[] f = new int[x + 2];
                int i;
                f[0] = 0;
                f[1] = 1;
                for (i = 2; i <= x; i++)
                {
                    f[i] = f[i - 1] + f[i - 2];
                }
                return f[x];
            }

            if (n < 1 || n >= 100)
            {
                return -1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}