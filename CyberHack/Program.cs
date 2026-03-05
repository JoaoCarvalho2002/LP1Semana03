using System;

namespace CyberHack
{
    public class Program
    {
        public enum HackTool
        {
            BruteForce,
            Phishing,
            Backdoor,
            ZeroDay,
            AIOverride,
            QuantumExploit
        }
        public enum SystemType
        {
            CorporateServer,
            BankDatabase,
            SmartCityCore,
            MilitaryAI
        }
        private static void Main(string[] args)
        {
            //SystemType myclass;
            //myclass=SystemType.CorporateServer;

            string tsa="";
            string hack1="";
            string hack2="";
            
            Console.WriteLine();
            tsa= Console.ReadLine();
            Console.WriteLine();
            hack1= Console.ReadLine();
            Console.WriteLine();
            hack2= Console.ReadLine();
            
            if(tsa=="CorporateServer")
            {
                Console.WriteLine();
                if(hack1=="Phishing" || hack1 == "Backdoor" && hack2 == "BruteForce" || hack2 == "ZeroDay")
                {
                    Console.WriteLine("System Hacked");
                }
                else
                {
                    Console.WriteLine("System Secure");
                }
            }
            if(tsa=="BankDatabase")
            {
                
            }
            if(tsa=="SmartCityCore")
            {
                
            }
            if(tsa=="MilitaryAI")
            {
                
            }
            
            
        }
    }
}
