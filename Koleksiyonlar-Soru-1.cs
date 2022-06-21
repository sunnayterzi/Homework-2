// See https://aka.ms/new-console-template for more information
using System.Collections;

class Question1{

    static void Main(String [] args) {
        ArrayList numbers = new ArrayList();
        ArrayList prime = new ArrayList();
        ArrayList nonPrime = new ArrayList();

        Console.WriteLine("20 adet pozitif tam sayı giriniz");
        for(int i = 0; i<5; i++) {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<0) {
                Console.WriteLine("Negatif sayı girdiniz. Program sonlandırılıyor");
                Environment.Exit(0);
        }
            else numbers.Add(n);

    
        }

        foreach (int item in numbers)
        {
            
                if(IsPrime(item)){
                    prime.Add(item);
                    
                }
            
    
        }
        
        foreach (var item in numbers)
        {
            if(!prime.Contains(item)){
                nonPrime.Add(item);

            }
        }



        Console.WriteLine("Prime numbers");
        prime.Sort();
        int sumPrime = 0;
        foreach (int item in prime)
        {
            Console.WriteLine(item);
            sumPrime+=item;
    
        }

        Console.WriteLine("Non-Prime numbers");
        nonPrime.Sort();
        int sumNonPrime=0;
        foreach (int item in nonPrime)
        {
            Console.WriteLine(item);
            sumNonPrime+=item;

    
        }

        Console.WriteLine("Prime Count: " + prime.Count);
        Console.WriteLine("Non-Prime Count: " + nonPrime.Count);
        Console.WriteLine("Prime mean: " + (float)(sumPrime/prime.Count));
        Console.WriteLine("Non-Prime mean: " + (float)(sumNonPrime/nonPrime.Count));


    }

    static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

}




