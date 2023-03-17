using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero : ");
            int LV =Convert.ToInt32(Console.ReadLine());

           

            int[ , ] matrix = new int[ LV , LV ] ;
            for (int i = 0; i<matrix.GetLength(0);i++){
                
                for (int j = 0; j<matrix.GetLength(1);j++){
                    Console.WriteLine("Numero da posição ("+i+","+j+")");
                    int nCL=Console.Read();
                    
                   // Console.Write(matrix[i,j]+" ");
                   
                }
                Console.WriteLine();
            }
            
        }
    }
}
