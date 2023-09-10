# CME_1211_HW
DEU CME 1211 Algorithms and Programming I Homework
CME 1211 Algorithms and Programming I Homework 1
Calendar
Write a C# program that takes the followings from the user separately: - two dates (day, month, and year) later than 01.01.2015
- a positive number (n)
and then prints each nth day between given dates.
The program must also print the day of the week (i.e., Monday) and the season (Winter, Spring, Summer, or Autumn).
The first date can be before or after the second date.
The program should control all possible invalid user inputs and give an approriate error message.
Examples:
 Inputs: day = 31
         month = ApriL
         year = 2021
 Output: day is wrong
Inputs: day =  -2
        month = programming
year = 2021
Output: day is wrong
         month is wrong
Inputs: day = 29
        month = february
        year = 2017
Output: day is wrong
The program may use one of the following methods to determine the day of the week: - Zeller’s algorithm
- Gauss's algorithm
- Tomohiko Sakamoto's algorithm
- Schwerdtfeger's method
- or others https://en.wikipedia.org/wiki/Determination_of_the_day_of_the_week
Don’t use any Date related command, library, and data type such as DayOfWeek(), AddDays(), DateTime, etc. Don’t use “array” data structure.
If you want, you may write your own “procedure(s) and/or function(s)”.

Example:
Inputs: D1=10  M1=MAY      Y1=2019
        D2=18  M2=January  Y2=2020
n = 10 Output:
 Spring
 10 May 2019 Friday
 20 May 2019 Monday
 30 May 2019 Thursday
 Summer
 9 June 2019 Sunday
 19 June 2019 Wednesday
 29 June 2019 Saturday
 9 July 2019 Tuesday
 19 July 2019 Friday
 29 July 2019 Monday
 8 August 2019 Thursday
 18 August 2019 Sunday
 28 August 2019 Wednesday
Example:
Inputs: D1=17  M1=november  Y1=2021
        D2=10  M2=October
n= 3 Output:
 Autumn
 10 October 2021 Sunday
 13 October 2021 Wednesday
 16 October 2021 Saturday
 19 October 2021 Tuesday
 22 October 2021 Friday
 25 October 2021 Monday
 28 October 2021 Thursday
 31 October 2021 Sunday
 3 November 2021 Wednesday
 6 November 2021 Saturday
 9 November 2021 Tuesday
 12 November 2021 Friday
 15 November 2021 Monday
Y2=2021
Autumn
7 September 2019 Saturday
17 September 2019 Tuesday
27 September 2019 Friday
7 October 2019 Monday
17 October 2019 Thursday
27 October 2019 Sunday
6 November 2019 Wednesday
16 November 2019 Saturday
26 November 2019 Tuesday
Winter
6 December 2019 Friday
16 December 2019 Monday
26 December 2019 Thursday
7 January 2020 Tuesday
17 January 2020 Friday
