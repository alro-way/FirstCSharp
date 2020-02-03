using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            Console.WriteLine($"Hello, {place}!");
            // with static:
            //    print_1_255();
            // without static:
            Program pro1 = new Program();
            // pro1.print_1_255();
            // pro1.print_odds_1_255();
            // pro1.print_ints_sum_0_255();
            int[] arr = {1,6,100,2,3,4};
            // pro1.iter_print_array(arr);
            // pro1.print_max(arr);
            // pro1.print_avg(arr);
            pro1.iter_print_array(pro1.create_odd_arr());
            
        }

    
// // without static:
//         public void print_1_255()
//         {
//             for(int i = 1; i<=255; i++)
//             {
//                 Console.WriteLine(i);
//             }
//         }
// print odds:
        // public void print_odds_1_255()
        // {
        //     for(int i = 1; i<=255; i++)
        //     {
        //         if (i%2 == 1)
        //         {
        //         Console.WriteLine(i);
        //         }
        //     }
        // }
// print ints and sum 0-255:
        // public void print_ints_sum_0_255()
        // {
        //     int sum = 0;
        //     for(int i = 0; i<=255; i++)
        //     {
        //         sum = sum + i;
        //         Console.WriteLine($"{i}->{sum}");
        //     }
        // }
// print array:
        public void iter_print_array(int[] arr)
        {
           int len = arr.Length;
           for (int i = 0; i < len; i++) {
               Console.Write($"{arr[i]} ");
           }
        }
    // print max:
        // public void print_max(int[] arr)
        // {
        //     int max = arr[0];
        //     int len = arr.Length;
        //     for (int i = 0; i < len; i++) {
        //         if (arr[i] > max)
        //         {
        //             max = arr[i];
        //         }
        //    }
        //    Console.Write($"{max} ");
        // }
    // print avarage:
        // public void print_avg(int[] arr)
        // {
        //     int sum = 0;
        //     int avg = 0;
        //     int len = arr.Length;
        //     for (int i = 0; i < len; i++) {

        //         sum = sum + arr[i];

        //    }
        //    avg = sum / len;
        //    Console.Write($"{avg} ");
        // }

        // create array:

        private static int count_arr_255(){
            int count = 0;
            for (int i = 1; i <= 255;i++) {
               if (i % 2 != 0) {
                   count++;
               }
            }
            return count - 1;
        }
        public int[] create_odd_arr()
        {
            int[] result = new int[count_arr_255()];
            Console.WriteLine($"length is {count_arr_255()}");
            int count = 0;
            for(int i = 0; i<255; i++)
            {
                if (i%2 == 1)
                {
                   result[count] = i;
                   count++;
                }
            }
            return result;



        }









    }
}
