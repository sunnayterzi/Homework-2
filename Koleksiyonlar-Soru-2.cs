// See https://aka.ms/new-console-template for more information
using System.Collections;

class Question1{

    static void Main(String [] args) {
        int [] arr = new int[7];

        Console.WriteLine("20 adet tam sayı giriniz");
        for(int i = 0; i<7; i++) {
            int n = Convert.ToInt32(Console.ReadLine());
            arr[i]=n;
        }
        Array.Sort(arr);
        
        int [] max3= new int[3];
        int [] min3 = new int[3];
       
        min3[0]=arr[0];
        min3[1]=arr[1];
        min3[2]=arr[2];

        max3[0]=arr[arr.Length-1];
        max3[1]=arr[arr.Length-2];
        max3[2]=arr[arr.Length-3];

        int minSum = 0;
        int maxSum = 0;

        for(int i = 0; i<3; i++){
            Console.WriteLine("min "+min3[i]);
            minSum += min3[i]; 
            Console.WriteLine("max "+max3[i]);
            maxSum += max3[i];

        }
        
        Console.WriteLine("max mean " + ((float)maxSum/(float)max3.Length));
        Console.WriteLine("min mean " + ((float)minSum/(float)min3.Length));
        Console.WriteLine("max mean + min mean: " + (((float)maxSum/(float)max3.Length) + ((float)minSum/(float)min3.Length)));

        }
        

        }






