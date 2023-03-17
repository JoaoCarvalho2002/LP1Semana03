using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something!");

            string S=Console.ReadLine();

            Console.WriteLine("Write the character to be removed!");

            string C=Console.ReadLine();
        
            char C2=Convert.ToChar(C);

            for(int i =0;i<S.Length;i++){
                if (S[i]!=C2){
                    Console.Write(S[i]);

                }
                

            } 
        }
    }
}
