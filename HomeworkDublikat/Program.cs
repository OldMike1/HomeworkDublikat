using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDublikat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listarray = new List<int>()
            {
                1,2,3,3,7,4,4,5,5
            };
            for (int i = 0; i < listarray.Count; i++)
            {
                for (int j = i+1; j < listarray.Count; j++)
                {
                    if (listarray[i] == listarray[j])
                    {
                        listarray.RemoveRange(j, 1);
                    }
                }
                Console.WriteLine(listarray[i]);
            }
            
        }
    }
}
