using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp4
{

    class Program
    {

        public static List<int> Merge(List<int> left_list, List<int> right_list)
        {
            List<int> sorted_list = new List<int>() { };

            while (left_list.Count > 0 && right_list.Count > 0)
            {
                if (left_list[0] > right_list[0])
                {
                    sorted_list.Add(right_list[0]);

                    if (right_list.Count > 1)
                    {
                        right_list = right_list.GetRange(1,right_list.Count-1);
                    }
                    else
                    {
                        right_list.Clear();
                        sorted_list.AddRange(left_list);
                    }

                }
                else
                {
                    sorted_list.Add(left_list[0]);

                    //Console.WriteLine(left_list[left_list.Count]);

                    if (left_list.Count > 1)
                    {
                        left_list = left_list.GetRange(1, left_list.Count-1);
                    }
                    else
                    {
                        left_list.Clear();
                        sorted_list.AddRange(right_list);
                        
                    }
                }   
            }

            return sorted_list;
        }


        public static List<int> mergeSort(List<int> total_list)
        {

            if (total_list.Count > 1)
            {
                int mid_val = (int) Math.Floor(total_list.Count / 2.0);
                List<int> left_list = mergeSort(total_list.GetRange(0,mid_val));
                List<int> right_list = mergeSort(total_list.GetRange(mid_val,total_list.Count-mid_val));

                return Merge(left_list, right_list);
            }
            else{
                return total_list;
            }

        }

            static void Main()
        {
            List<int> list1 = new List<int>() {31,22,14,10,11,2,13,9};

            var list3 = new List<int>();
            list3 = mergeSort(list1);

            foreach (int x in list3)
            {
                Console.WriteLine(x);
            }

        }
    }
}
