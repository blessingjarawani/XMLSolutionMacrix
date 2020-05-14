using System;
using System.Collections.Generic;
using System.Text;

namespace XMLSolutionMatrics.BLL.Infrastructure.Util
{
    public class Age
    {
        public int Years;
        public int Months;
        public int Days;

        public Age(DateTime dob)
        {
            this.Count(dob);
        }

        public Age(DateTime dob, DateTime currentDate)
        {
            this.Count(dob, currentDate);
        }

        public Age Count(DateTime dob)
        {
            return this.Count(dob, DateTime.Today);
        }

        public Age Count(DateTime bob, DateTime currentdate)
        {
            if ((currentdate.Year - bob.Year) > 0 ||
                (((currentdate.Year - bob.Year) == 0) && ((bob.Month < currentdate.Month) ||
                  ((bob.Month == currentdate.Month) && (bob.Day <= currentdate.Day)))))
            {
                int DaysInBdayMonth = DateTime.DaysInMonth(bob.Year, bob.Month);
                int DaysRemain = currentdate.Day + (DaysInBdayMonth - bob.Day);

                if (currentdate.Month > bob.Month)
                {
                    this.Years = currentdate.Year - bob.Year;
                    this.Months = currentdate.Month - (bob.Month + 1) + Math.Abs(DaysRemain / DaysInBdayMonth);
                    this.Days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                }
                else if (currentdate.Month == bob.Month)
                {
                    if (currentdate.Day >= bob.Day)
                    {
                        this.Years = currentdate.Year - bob.Year;
                        this.Months = 0;
                        this.Days = currentdate.Day - bob.Day;
                    }
                    else
                    {
                        this.Years = (currentdate.Year - 1) - bob.Year;
                        this.Months = 11;
                        this.Days = DateTime.DaysInMonth(bob.Year, bob.Month) - (bob.Day - currentdate.Day);
                    }
                }
                else
                {
                    this.Years = (currentdate.Year - 1) - bob.Year;
                    this.Months = currentdate.Month + (11 - bob.Month) + Math.Abs(DaysRemain / DaysInBdayMonth);
                    this.Days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                }
            }
            else
            {
                throw new ArgumentException("Birthday date must be earlier than current date");
            }
            return this;
        }
    }

}
