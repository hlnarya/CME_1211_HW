using System;

namespace Calendar_1
{
    class Program
    {

        public static void Main(string[] args)
        {

            int day1 = 1, day2 = 1, year1 = 2015, year2 = 2015, monthint1 = 1, monthint2 = 1, maxday1 = 2, maxday2 = 2, daten1, daten2, n;
            //daten = the numbers of date from given date untill 01.01.2015
            //maxday=max day for each month
            //numtos=number to season
            bool leapcontrol1, leapcontrol2;
            string month1, month2;
            bool cws;//cotrols writing the first season
            do
            {
                if (year1 < 2015)
                    Console.WriteLine("Year must be after 2014");
                if (monthint1 == 0)
                    Console.WriteLine("Month is wrong");
                if (day1 < 1 || day1 > maxday1)
                    Console.WriteLine("Day is wrong");

                Console.Write("Please enter your first date(e.g. 14 May 2021)\nDay1: ");
                int.TryParse(Console.ReadLine(), out day1);
                Console.Write("Month1: ");
                month1 = Console.ReadLine().ToLower();
                Console.Write("Year1: ");
                int.TryParse(Console.ReadLine(), out year1);
                if (year1 % 4 == 0)
                    leapcontrol1 = true;
                else
                    leapcontrol1 = false;
                if (year1 % 100 == 0)
                    leapcontrol1 = false;
                if (year1 % 400 == 0)
                    leapcontrol1 = true;

                if (leapcontrol1 == false)
                {
                    switch (month1)
                    {
                        case "january": monthint1 = 1; maxday1 = 31; break;
                        case "february": monthint1 = 2; maxday1 = 28; break;
                        case "march": monthint1 = 3; maxday1 = 31; break;
                        case "april": monthint1 = 4; maxday1 = 30; break;
                        case "may": monthint1 = 5; maxday1 = 31; break;
                        case "june": monthint1 = 6; maxday1 = 30; break;
                        case "july": monthint1 = 7; maxday1 = 31; break;
                        case "august": monthint1 = 8; maxday1 = 31; break;
                        case "september": monthint1 = 9; maxday1 = 30; break;
                        case "october": monthint1 = 10; maxday1 = 31; break;
                        case "november": monthint1 = 11; maxday1 = 30; break;
                        case "december": monthint1 = 12; maxday1 = 31; break;
                        default: monthint1 = 0; maxday1 = 31; break;
                    }
                }
                else
                {
                    switch (month1)
                    {
                        case "january": monthint1 = 1; maxday1 = 31; break;
                        case "february": monthint1 = 2; maxday1 = 29; break;
                        case "march": monthint1 = 3; maxday1 = 31; break;
                        case "april": monthint1 = 4; maxday1 = 30; break;
                        case "may": monthint1 = 5; maxday1 = 31; break;
                        case "june": monthint1 = 6; maxday1 = 30; break;
                        case "july": monthint1 = 7; maxday1 = 31; break;
                        case "august": monthint1 = 8; maxday1 = 31; break;
                        case "september": monthint1 = 9; maxday1 = 30; break;
                        case "october": monthint1 = 10; maxday1 = 31; break;
                        case "november": monthint1 = 11; maxday1 = 30; break;
                        case "december": monthint1 = 12; maxday1 = 31; break;
                        default: monthint1 = 0; maxday1 = 31; break;
                    }
                }
            } while (day1 < 1 || day1 > maxday1 || monthint1 == 0 || year1 < 2015);

            daten1 = datetonum(day1, monthint1, year1);

            do
            {
                if (year2 < 2015)
                    Console.WriteLine("Year must be after 2014");
                if (monthint2 == 0)
                    Console.WriteLine("Month is wrong");
                if (day2 < 1 || day2 > maxday2)
                    Console.WriteLine("Day is wrong");

                Console.Write("Please enter your second date(e.g. 14 May 2021)\nDay2: ");
                int.TryParse(Console.ReadLine(), out day2);
                Console.Write("Month2: ");
                month2 = Console.ReadLine().ToLower();
                Console.Write("Year2: ");
                int.TryParse(Console.ReadLine(), out year2);
                if (year2 % 4 == 0)
                    leapcontrol2 = true;
                else
                    leapcontrol2 = false;

                if (leapcontrol2 == false)
                {
                    switch (month2)
                    {
                        case "january": monthint2 = 1; maxday2 = 31; break;
                        case "february": monthint2 = 2; maxday2 = 28; break;
                        case "march": monthint2 = 3; maxday2 = 31; break;
                        case "april": monthint2 = 4; maxday2 = 30; break;
                        case "may": monthint2 = 5; maxday2 = 31; break;
                        case "june": monthint2 = 6; maxday2 = 30; break;
                        case "july": monthint2 = 7; maxday2 = 31; break;
                        case "august": monthint2 = 8; maxday2 = 31; break;
                        case "september": monthint2 = 9; maxday2 = 30; break;
                        case "october": monthint2 = 10; maxday2 = 31; break;
                        case "november": monthint2 = 11; maxday2 = 30; break;
                        case "december": monthint2 = 12; maxday2 = 31; break;
                        default: monthint2 = 0; maxday2 = 31; break;
                    }
                }
                else
                {
                    switch (month2)
                    {
                        case "january": monthint2 = 1; maxday2 = 31; break;
                        case "february": monthint2 = 2; maxday2 = 29; break;
                        case "march": monthint2 = 3; maxday2 = 31; break;
                        case "april": monthint2 = 4; maxday2 = 30; break;
                        case "may": monthint2 = 5; maxday2 = 31; break;
                        case "june": monthint2 = 6; maxday2 = 30; break;
                        case "july": monthint2 = 7; maxday2 = 31; break;
                        case "august": monthint2 = 8; maxday2 = 31; break;
                        case "september": monthint2 = 9; maxday2 = 30; break;
                        case "october": monthint2 = 10; maxday2 = 31; break;
                        case "november": monthint2 = 11; maxday2 = 30; break;
                        case "december": monthint2 = 12; maxday2 = 31; break;
                        default: monthint2 = 0; maxday2 = 31; break;
                    }
                }
            } while (day2 < 1 || day2 > maxday2 || monthint2 == 0 || year2 < 2015);

            daten2 = datetonum(day2, monthint2, year2);

            Console.Write("Please enter a positive number:\nn=");
            n = Convert.ToInt32(Console.ReadLine());

            if (daten1 <= daten2)
            {
                cws = true;
                do
                {
                    if (numtoseason(daten1) != numtoseason(daten1 - n) || cws == true)
                    {
                        switch (numtoseason(daten1))
                        {
                            case 1: Console.Write("Winter\n"); break;
                            case 2: Console.Write("Spring\n"); break;
                            case 3: Console.Write("Summer\n"); break;
                            case 4: Console.Write("Autumn\n"); break;
                        }
                        cws = false;
                    }
                    numtodate(daten1);
                    daten1 += n;

                } while (daten1 <= daten2);
            }
            else
            {
                int a = daten2;
                cws = true;
                do
                {
                    if (numtoseason(a) != numtoseason(a - n) || cws == true)
                    {
                        switch (numtoseason(a))
                        {
                            case 1: Console.Write("Winter\n"); break;
                            case 2: Console.Write("Spring\n"); break;
                            case 3: Console.Write("Summer\n"); break;
                            case 4: Console.Write("Autumn\n"); break;
                        }
                        cws = false;
                    }
                    numtodate(a);
                    a += n;
                } while (a <= daten1);
            }
            Console.ReadLine();


            //functions:
        }
        public static int datetonum(int d, int m, int y) //change given date to an  int number(up to 2015)
        {
            int dayfrom;
            int daysinyear = 0;//included the days in year
            int y_in_while = y;// year in while_loop

            while (y_in_while > 2015)
            {
                if (y_in_while % 4 == 1 && m < 3)
                    daysinyear = daysinyear + 366;
                //every 4 year and every 100 year is a leap year
                else if (y_in_while % 4 == 0 && m > 2)
                    daysinyear = daysinyear + 366;
                else
                    daysinyear = daysinyear + 365;
                if (y_in_while % 100 == 1 && m < 3)
                    daysinyear = daysinyear - 1;
                //every 4 year and every 100 year is a leap year
                else if (y_in_while % 100 == 0 && m > 2)
                    daysinyear = daysinyear - 1;
                if (y_in_while % 400 == 1 && m < 3)
                    daysinyear = daysinyear + 1;
                //every 4 year and every 100 year is a leap year
                else if (y_in_while % 400 == 0 && m > 2)
                    daysinyear = daysinyear + 1;
                y_in_while = y_in_while - 1;
            }

            switch (m)
            {
                case 1: dayfrom = (daysinyear + d); break;
                case 2: dayfrom = (daysinyear + 31 + d); break;
                case 3: dayfrom = (daysinyear + 28 + 31 + d); break;
                case 4: dayfrom = (daysinyear + 31 + 28 + 31 + d); break;
                case 5: dayfrom = (daysinyear + 30 + 31 + 28 + 31 + d); break;
                case 6: dayfrom = (daysinyear + 31 + 30 + 31 + 28 + 31 + d); break;
                case 7: dayfrom = (daysinyear + 30 + 31 + 30 + 31 + 28 + 31 + d); break;
                case 8: dayfrom = (daysinyear + 31 + 30 + 31 + 30 + 31 + 28 + 31 + d); break;
                case 9: dayfrom = (daysinyear + 31 + 31 + 30 + 31 + 30 + 31 + 28 + 31 + d); break;
                case 10: dayfrom = (daysinyear + 30 + 31 + 31 + 30 + 31 + 30 + 31 + 28 + 31 + d); break;
                case 11: dayfrom = (daysinyear + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31 + 28 + 31 + d); break;
                case 12: dayfrom = (daysinyear + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31 + 28 + 31 + d); break;
                default: dayfrom = 0; break;
            }
            return dayfrom;
        }
        public static void numtodate(int n)
        {
            int weekday = n % 7;
            int year = 2015;
            int month = 13;

            while (n > 365)
            {
                if (year % 4 == 0)
                {
                    year = year + 1;
                    n = n - 366;
                }
                else
                {
                    year = year + 1;
                    n = n - 365;
                }
                if (year % 100 == 0)
                    n = n + 1;
                if (year % 400 == 0)
                    n = n - 1;

            }
            if (year % 4 == 0)

            {
                if (year % 100 != 0)
                {
                    if (n <= 31)
                        month = 1;
                    else if (n >= 32 && n <= 60)
                    {
                        month = 2;
                        n = n - 31;
                    }
                    else if (n >= 61 && n <= 91)
                    {
                        month = 3;
                        n = n - 60;
                    }
                    else if (n >= 92 && n <= 121)
                    {
                        month = 4;
                        n = n - 91;
                    }
                    else if (n >= 122 && n <= 152)
                    {
                        month = 5;
                        n = n - 121;
                    }
                    else if (n >= 153 && n <= 182)
                    {
                        month = 6;
                        n = n - 152;
                    }
                    else if (n >= 183 && n <= 213)
                    {
                        month = 7;
                        n = n - 182;
                    }
                    else if (n >= 214 && n <= 244)
                    {
                        month = 8;
                        n = n - 213;
                    }
                    else if (n >= 245 && n <= 274)
                    {
                        month = 9;
                        n = n - 244;
                    }
                    else if (n >= 275 && n <= 305)
                    {
                        month = 10;
                        n = n - 274;
                    }
                    else if (n >= 306 && n <= 335)
                    {
                        month = 11;
                        n = n - 305;
                    }
                    else if (n >= 336 && n < 367)
                    {
                        month = 12;
                        n = n - 335;
                    }
                }
                else if (year % 400 == 0)
                {
                    if (n <= 31)
                        month = 1;
                    else if (n >= 32 && n <= 60)
                    {
                        month = 2;
                        n = n - 31;
                    }
                    else if (n >= 61 && n <= 91)
                    {
                        month = 3;
                        n = n - 60;
                    }
                    else if (n >= 92 && n <= 121)
                    {
                        month = 4;
                        n = n - 91;
                    }
                    else if (n >= 122 && n <= 152)
                    {
                        month = 5;
                        n = n - 121;
                    }
                    else if (n >= 153 && n <= 182)
                    {
                        month = 6;
                        n = n - 152;
                    }
                    else if (n >= 183 && n <= 213)
                    {
                        month = 7;
                        n = n - 182;
                    }
                    else if (n >= 214 && n <= 244)
                    {
                        month = 8;
                        n = n - 213;
                    }
                    else if (n >= 245 && n <= 274)
                    {
                        month = 9;
                        n = n - 244;
                    }
                    else if (n >= 275 && n <= 305)
                    {
                        month = 10;
                        n = n - 274;
                    }
                    else if (n >= 306 && n <= 335)
                    {
                        month = 11;
                        n = n - 305;
                    }
                    else if (n >= 336 && n < 367)
                    {
                        month = 12;
                        n = n - 335;
                    }
                }
                else
                {
                    if (n <= 31)
                        month = 1;
                    else if (n >= 32 && n <= 59)
                    {
                        month = 2;
                        n = n - 31;
                    }
                    else if (n >= 60 && n <= 90)
                    {
                        month = 3;
                        n = n - 59;
                    }
                    else if (n >= 91 && n <= 120)
                    {
                        month = 4;
                        n = n - 90;
                    }
                    else if (n >= 121 && n <= 151)
                    {
                        month = 5;
                        n = n - 120;
                    }
                    else if (n >= 152 && n <= 181)
                    {
                        month = 6;
                        n = n - 151;
                    }
                    else if (n >= 182 && n <= 212)
                    {
                        month = 7;
                        n = n - 181;
                    }
                    else if (n >= 213 && n <= 243)
                    {
                        month = 8;
                        n = n - 212;
                    }
                    else if (n >= 244 && n <= 273)
                    {
                        month = 9;
                        n = n - 243;
                    }
                    else if (n >= 274 && n <= 304)
                    {
                        month = 10;
                        n = n - 273;
                    }
                    else if (n >= 305 && n <= 334)
                    {
                        month = 11;
                        n = n - 304;
                    }
                    else if (n >= 335 && n < 366)
                    {
                        month = 12;
                        n = n - 334;
                    }
                }

            }
            else
            {
                if (n <= 31)
                    month = 1;
                else if (n >= 32 && n <= 59)
                {
                    month = 2;
                    n = n - 31;
                }
                else if (n >= 60 && n <= 90)
                {
                    month = 3;
                    n = n - 59;
                }
                else if (n >= 91 && n <= 120)
                {
                    month = 4;
                    n = n - 90;
                }
                else if (n >= 121 && n <= 151)
                {
                    month = 5;
                    n = n - 120;
                }
                else if (n >= 152 && n <= 181)
                {
                    month = 6;
                    n = n - 151;
                }
                else if (n >= 182 && n <= 212)
                {
                    month = 7;
                    n = n - 181;
                }
                else if (n >= 213 && n <= 243)
                {
                    month = 8;
                    n = n - 212;
                }
                else if (n >= 244 && n <= 273)
                {
                    month = 9;
                    n = n - 243;
                }
                else if (n >= 274 && n <= 304)
                {
                    month = 10;
                    n = n - 273;
                }
                else if (n >= 305 && n <= 334)
                {
                    month = 11;
                    n = n - 304;
                }
                else if (n >= 335 && n < 366)
                {
                    month = 12;
                    n = n - 334;
                }
            }
            Console.Write(n);
            switch (month)
            {
                case 1: Console.Write("  January  "); break;
                case 2: Console.Write("  February  "); break;
                case 3: Console.Write("  March  "); break;
                case 4: Console.Write("  April  "); break;
                case 5: Console.Write("  May  "); break;
                case 6: Console.Write("  June  "); break;
                case 7: Console.Write("  July  "); break;
                case 8: Console.Write("  August  "); break;
                case 9: Console.Write("  September  "); break;
                case 10: Console.Write("  October  "); break;
                case 11: Console.Write("  November  "); break;
                case 12: Console.Write("  December  "); break;
            }
            Console.Write(year);
            switch (weekday)
            {
                case 0: Console.Write("  Wednseday\n"); break;
                case 1: Console.Write("  Thursday\n"); break;
                case 2: Console.Write("  Friday\n"); break;
                case 3: Console.Write("  Saturday\n"); break;
                case 4: Console.Write("  Sunday\n"); break;
                case 5: Console.Write("  Monday\n"); break;
                case 6: Console.Write("  Tuesday\n"); break;
            }
        }
        public static int numtoseason(int dn)//dn=date number
        {
            int fc=0;//fc= four hundred control
            while(dn>36526)
            {
                if (fc == 0)
                    dn = dn + 1;
                dn = dn - 36524;
                fc = fc + 1;
                if (fc % 4 == 0)
                    dn = dn + 1;
            }

            int n = dn % 1461;
            int season = 0;

            if (n >= 1 && n < 60)
                season = 1;
            if (n >= 60 && n < 152)
                season = 2;
            if (n >= 152 && n < 244)
                season = 3;
            if (n >= 244 && n < 335)
                season = 4;
            if (n >= 335 && n < 426)
                season = 1;
            if (n >= 426 && n < 518)
                season = 2;
            if (n >= 518 && n < 610)
                season = 3;
            if (n >= 610 && n < 701)
                season = 4;
            if (n >= 701 && n < 791)
                season = 1;
            if (n >= 791 && n < 883)
                season = 2;
            if (n >= 883 && n < 975)
                season = 3;
            if (n >= 975 && n < 1066)
                season = 4;
            if (n >= 1066 && n < 1156)
                season = 1;
            if (n >= 1156 && n < 1248)
                season = 2;
            if (n >= 1248 && n < 1340)
                season = 3;
            if (n >= 1340 && n < 1431)
                season = 4;
            if (n >= 1431 && n <= 1461)
                season = 1;
            return season;
        }
    }
}
