using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        


        public int GetDiffrenceInDaysBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);

            int differenceBetweenTwoDates = (int)(endDate - startDate).TotalDays;

            return differenceBetweenTwoDates;

        }
    }
}
