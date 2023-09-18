using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowOldAmI
{

    internal class AgeCalculator
    {
        public string FinalAge { get; set;}

        public AgeCalculator(DateTime selecteddate)
        {
            CalculateAge(selecteddate);
        }
        
        private void CalculateAge(DateTime selecteddate)
        {
            DateTime today = DateTime.Now;

            TimeSpan difference = today.Subtract(selecteddate);

            FinalAge = $"{difference.Days / 365} Years, {difference.Days - ((difference.Days /365)*365)} Days, {difference.Hours} Hours, {difference.Minutes} Minutes, {difference.Seconds} Seconds.";
        }
    }
}
