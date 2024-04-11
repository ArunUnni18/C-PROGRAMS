
using ConsoleApp1;
using System;

class test()
{
    public static void Main()
    {
        //RepeatValue();
        //  ConsoleApp1.Dictionary.UsingDictionary();
        //Palindrome.PalindromeCheck();
       Matrix.MatrixAddition();


    }
        public static void RepeatValue()
        { 
        //int a = 6;
       // Console.WriteLine(a);
        int[] num = [ 1, 3, 3 ,1,1,3,3];
        int maxcount=0;
        int repeatvalue = 0;
        for (int i = 0; i < num.Length; i++)
        {
           int currentcount = 1;
            for (int j = i+1; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    currentcount++;
                    

                }
               
            }
            if (currentcount > maxcount)
            {
                repeatvalue = num[i];
                maxcount= currentcount; 
                
            }
        }
        Console.WriteLine("most repeated value= "+ repeatvalue);
        Console.WriteLine($"{maxcount} REPEATED");
    }
}
