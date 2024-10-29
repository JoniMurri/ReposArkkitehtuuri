
using System;
using AppLogger;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string text = "APP";
            string message = "Humanized_Metodin_Tutustuminen";
            Logger.Log("log metodi: " + text); // Kutsutaan Log-metodia

            Logger.LogHumanized("Humanized metodi: " + message);
            
        }
    }
}