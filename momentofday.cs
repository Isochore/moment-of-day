using System;

namespace MomentOfTheDay
{
    public class Program
    {	
        public static void Main()
        {
            Console.WriteLine(GetGreeting() + " nous sommes " + GetDay() + " " + GetMomentOfDay());
        }

        public static class Globals 
        {
            public static DateTime date = DateTime.Now;
            public static int hour = DateTime.Now.Hour;
            public static DayOfWeek day = DateTime.Now.DayOfWeek;
        }

        public static String GetGreeting()
        {
            if(GetMomentOfDay() == "matin" || GetMomentOfDay() == "après-midi") 
            {
                return "Bonjour";
            }  
            else
            {
                return "Bonsoir";
            }  
        }

        public static String GetMomentOfDay()
        {
            String momentValue = "";
            if(Globals.hour >= 0 && Globals.hour <= 5) 
            {
                momentValue = "nuit";
            }  
            else if (Globals.hour >= 6 && Globals.hour <= 11) 
            {
                momentValue = "matin";
            }  
            else if (Globals.hour >= 12 && Globals.hour <= 17) 
            {
                momentValue = "après-midi";
            }  
            else 
            {
                momentValue = "soir";
            }
            return momentValue;
        }

        public static String GetDay()
        {
            String dayValue = "";
            switch (Globals.day)
            {
                case DayOfWeek.Monday:
                    dayValue = "lundi";
                    break;
                case DayOfWeek.Tuesday:
                    dayValue = "mardi";
                    break;
                case DayOfWeek.Wednesday:
                    dayValue = "mercredi";
                    break;
                case DayOfWeek.Thursday:
                    dayValue = "jeudi";
                    break;
                case DayOfWeek.Friday:
                    dayValue = "vendredi";
                    break;
                case DayOfWeek.Saturday:
                    dayValue = "samedi";
                    break;
                default:
                    dayValue = "dimanche";
                    break;
            }
            return dayValue;
        }
    }
}