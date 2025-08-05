using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Recurring
{
    public class Fibonacci
    {
        Dictionary<int, int> Memo = new Dictionary<int, int>(); 

        public int Fib (int n)
        {
            if(n == 0 ) return 0;
            if(n == 1 ) return 1;
        
            if(Memo.ContainsKey(n)) return Memo[n];

            Memo[n] = Fib(n - 2) + Fib(n - 1);
            return Memo[n]; 
        
        }
    }
}
