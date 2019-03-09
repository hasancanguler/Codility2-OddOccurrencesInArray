using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution( new int[] { 5, 4, 1, 4, 1, 4, 1 }));
            Console.ReadLine();
        }
        static int solution(int[] A)
        {
            int OddVAlue = 0;
            int FirstValue = A[0];
            int SecondValue = A[1];
            for (int index = 2; index < A.Length; index++)
            {
                if ((index % 2) == 0)
                {
                    if (FirstValue != A[index])
                        OddVAlue = A[index];
                }
                else
                {
                    if (SecondValue != A[index])
                        OddVAlue = A[index];
                }
            }
            return OddVAlue;
        }
    }
}
