using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace Number_of_even_and_odd_terms_in_an_array {  
    class Program {  
        static void Main(string[] args) {  
            int i, n, even = 0, odd = 0;  
            Console.WriteLine("Enter the number of elements to be inserted: ");  
            n = Convert.ToInt32(Console.ReadLine());  
            int[] a = new int[n];  
            Console.WriteLine("Enter the array elements:");  
            for (i = 0; i < n; i++) {  
                a[i] = Convert.ToInt32(Console.ReadLine());  
            }  
            for (i = 0; i < n; i++) {  
                if (a[i] % 2 == 0) {  
                    even = even;  
                    even++;  
                } else {  
                    odd = odd;  
                    odd++;  
                }  
            }  
            Console.WriteLine("Number of even terms are: " + even);  
            Console.WriteLine("Number of odd terms are: " + odd);  
            Console.ReadLine();  
        }  
    }  
}  