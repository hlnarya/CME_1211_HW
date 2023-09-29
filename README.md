# CME_1211_HW1
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

# CME_1211_HW2
DEU Game
Write a C# program for a simple DEU game.
There are three arrays (A1, A2, and A3) with 15 in size. Initially, they are empty.
There are two players: player1 and player2.
The aim of the game is to make the "D-E-U" sequence (straight or reverse) among connected squares (horizontally or
vertically or diagonally).
The game turns alternate between players after each move. At each turn of the game, the program randomly inserts one of the three leters “D”, “E” or “U” to any array for a player. In other words, the program determines both the letter and target array randomly.
At the begging of the game, each player has a score of 120. At each turn, the score of the player decreases by 5 points.
 The game is over
- if a player succeeds in creating a ”DEU” pattern
or
- if all arrays are filled up and there is no any “DEU”.
The program must display all steps until the game is over.
There are two arrays to store a high score table:
(the winner is the player who made the first “DEU”) (the game is a draw (tie))
string[] names = {“Derya”, “Elife”, “Fatih”, “Ali”, “Azra”, “Sibel”, “Cem”, “Nazan”, “Mehmet”, “Nil”, “Can”, “Tarkan”} int[] scores = {100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 }
At the end of the game, the program must print the high score table. If the point of the winner exists in the score table, the player ID (Player1 or Player2) and his/her score are placed under the old one. First, insert the new element to the arrays, and then print the arrays.
Don’t take any input from the user.
If you want, you may write your own “procedure(s) and/or function(s)”.Sample outputs:
 
Sample output 1:
Player1:
A1 E
A2
A3
Player2: A1 E
(P1-115 P2-120)
(P1-115 P2-115)
Sample output 2:
Player1:
A1
A2 U
A3
Player2: A1
(P1-115 P2-120)
(P1-115 P2-115)
Sample output 3:
Player1:
A1
A2
A3 D
Player2: A1
(P1-115 P2-120)
(P1-115 P2-115)
A2 U A3
Player1:
A1 E
A2 U D
A3
Player2:
A1 E D
A2 U D
A3
Player1:
A1 E D
A2 U D E
A3
Player2:
A1 E D
A2 U D E
A3 D
Player1:
A1 E D
A2 U D E U
A3 D
(P1-110 P2-115)
(P1-110 P2-110)
(P1-105 P2-110)
(P1-105 P2-105)
(P1-100 P2-105)
winner: Player1
Name Score
Derya 100 Elife 100 Player1 100 Fatih 95 ...
A2 U A3 D
Player1:
A1 E
A2 U
A3 D
Player2:
A1 E
A2 U
A3 D U
Player1:
A1 E
A2 U E
A3 D U
Player2:
A1 E
A2 U E
A3 D U E
Player1:
A1 E
A2 U E
A3 D U E U
Player2:
A1 E
A2 U E U
A3 D U E U
Player1:
A1 E D
A2 U E U
A3 D U E U
(P1-110 P2-115)
(P1-110 P2-110)
(P1-105 P2-110)
(P1-105 P2-105)
(P1-100 P2-105)
(P1-100 P2-100)
(P1-95 P2-100)
winner: Player1
Name Score
Derya 100 Elife 100 Fatih 95 Player1 95 ...
A2 E A3 D
Player1:
A1
A2 E
A3 D D
Player2:
A1
A2 E
A3 D D
Player1:
A1
A2 E
A3 D D D
... ... ...
Player2:
A1 E U U E E D D U U U D U D D D
A2 E U U E E D D D U U E E E U E
A3 D D D E E U E E U U E E E U D
Tie
Name Score
Derya 100 Elife 100 Fatih 95 Ali 90 ...
(P1-110 P2-115)
(P1-110 P2-110)
(P1-105 P2-110)
(P1-... P2-...)


