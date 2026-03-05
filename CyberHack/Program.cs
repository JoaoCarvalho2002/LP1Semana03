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

            Enum.TryParse("Active", out SystemType myStatus);
            
            /*
            if(tsa=="CorporateServer")
            {
                if(hack1=="Phishing")OR(hack1 == "Backdoor")AND(hack2 == "BruteForce")OR(hack2 == "ZeroDay")
                {
                    Console.WriteLine("HERE");
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
            */
            
        }
    }
}
