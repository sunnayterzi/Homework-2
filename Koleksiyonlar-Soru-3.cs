// See https://aka.ms/new-console-template for more information
using System.Collections;

class Question1{

    static void Main(String [] args) {
        ArrayList list = new ArrayList();

        Console.WriteLine("Bir cumle giriniz");
        String str = Console.ReadLine();
        
            
        for(int i = 0; i<str.Length;i++){
            if(str[i] =='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u' || str[i]=='A' || str[i]=='E' || str[i]=='I' || str[i]=='O' || str[i]=='U') 
                list.Add(str[i]);
        }

        list.Sort();
        foreach(var item in list){
            Console.WriteLine(item);
        }
    }
        

}






