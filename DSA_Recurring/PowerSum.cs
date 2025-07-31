using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Recurring
{
    public class PowerSum
    {
        public static double powerSumRec(Object[] array , int power =1)
        {

            double sum = 0;

            foreach(var item in array)
            {
                if(item is object[] nestedArray)
                {
                    sum += powerSumRec(nestedArray, power + 1); 
                }

                else if (item is int number)
                {
                    sum += number; 
                }
            }

            return Math.Pow(sum, power);

        }
    }
}
