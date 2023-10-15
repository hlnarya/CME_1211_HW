using System;

namespace word_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, pattern, textin; 
            bool flag = false;
            bool repeatflag = false; //to avoid wrtiting repeated words
            
            Console.WriteLine("please enter a text: ");
            do
            {
                textin = Console.ReadLine();
                textin = textin.Replace(",", " ");
                textin = textin.Replace(".", " ");
                text = textin.ToLower(); // keeping text input because the output should involve uppercase character

                for (int i = 0; i < text.Length; i++) //controling input format and validity
                {
                    if ((text[i] >= 'a' && text[i] <= 'z') || text[i] == ' ' || text[i] == ',' || text[i] == '.')
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("please enter a text including letters or , or .");
                        flag = false;
                        break;
                    }
                }

            } while (flag == false);

            string[] words = text.Split(' ');
            string[] wordsout = textin.Split(' ');
            string[] repeatcontrol = new string[wordsout.Length];
            flag = false;

            Console.WriteLine("please enter a pattern: ");
            do //controling patern validity
            {
                pattern = Console.ReadLine();

                pattern = pattern.ToLower();
                for (int i = 0; i < pattern.Length; i++)
                {
                    if ((pattern[i] >= 'a' && pattern[i] <= 'z') || pattern[i] == '*' || pattern[i] == '-')
                    {
                        flag = true;

                    }
                    else
                    {
                        Console.WriteLine("please enter a valid pattern");
                        flag = false;
                        break;
                    }
                }
                if (pattern.Contains('-') == pattern.Contains('*'))
                {
                    if (flag == true)
                        Console.WriteLine("please enter a valid pattern");
                    flag = false;
                }
            } while (flag == false);
            if (pattern.Contains('*')) // searching for  patterns containing *
            {
                int count = 0;
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (pattern[i] == '*')
                    {
                        count++;
                    }
                }
                int count2 = 0;
                int[] starposision = new int[count];
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (pattern[i] == '*')
                    {
                        starposision[count2] = i;                        
                        count2++;
                    }
                }
                if(count==1)
                {
                    if(pattern.Length==1) //separating 1 and 2 stared patterns because they won't match the algorithm
                    { 
                    for(int i = 0; i < words.Length; i++)
                    {
                            for (int m = 0; m < wordsout.Length; m++)
                            {

                                if (wordsout[i] == repeatcontrol[m])
                                {
                                    repeatflag = true;
                                    break;
                                }
                                else
                                    repeatflag = false;


                            }
                            if (repeatflag == false)
                            {
                                Console.WriteLine(wordsout[i]);

                            }
                            repeatcontrol[i] = wordsout[i];

                        }
                    }
                    else
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            if(starposision[0]==0)
                            { 
                            if (words[i].Contains(pattern.Substring(starposision[0]+1, pattern.Length-1)))
                            {
                                    for (int m = 0; m < wordsout.Length; m++)
                                    {

                                        if (wordsout[i] == repeatcontrol[m])
                                        {
                                            repeatflag = true;
                                            break;
                                        }
                                        else
                                            repeatflag = false;


                                    }
                                    if (repeatflag == false)
                                    {
                                        Console.WriteLine(wordsout[i]);

                                    }
                                    repeatcontrol[i] = wordsout[i];
                                }
                            }
                            else if(starposision[0] == pattern.Length-1)
                                    {
                                if (words[i].Contains(pattern.Substring(0, pattern.Length - 1)))
                                {
                                    for (int m = 0; m < wordsout.Length; m++)
                                    {

                                        if (wordsout[i] == repeatcontrol[m])
                                        {
                                            repeatflag = true;
                                            break;
                                        }
                                        else
                                            repeatflag = false;


                                    }
                                    if (repeatflag == false)
                                    {
                                        Console.WriteLine(wordsout[i]);

                                    }
                                    repeatcontrol[i] = wordsout[i];
                                }
                            }
                            else
                            {
                                if (words[i].Contains(pattern.Substring(0, starposision[0]))&& words[i].Contains(pattern.Substring(starposision[0]+1,pattern.Length - starposision[0]-1)))
                                {
                                    for (int m = 0; m < wordsout.Length; m++)
                                    {

                                        if (wordsout[i] == repeatcontrol[m])
                                        {
                                            repeatflag = true;
                                            break;
                                        }
                                        else
                                            repeatflag = false;


                                    }
                                    if (repeatflag == false)
                                    {
                                        Console.WriteLine(wordsout[i]);

                                    }
                                    repeatcontrol[i] = wordsout[i];
                                }
                            }
                        }
                    }
                }
                else if(count==2) //separating 1 and 2 stared patterns because they won't match the algorithm
                {
                    for (int i = 0; i < words.Length; i++)

                    {

                        if (starposision[0] == 0)
                        {
                            if (starposision[1] == pattern.Length - 1)
                            {
                                if (words[i].Contains(pattern.Substring(1,pattern.Length-2)))
                                {
                                    for (int m = 0; m < wordsout.Length; m++)
                                    {

                                        if (wordsout[i] == repeatcontrol[m])
                                        {
                                            repeatflag = true;
                                            break;
                                        }
                                        else
                                            repeatflag = false;


                                    }
                                    if (repeatflag == false)
                                    {
                                        Console.WriteLine(wordsout[i]);

                                    }
                                    repeatcontrol[i] = wordsout[i];
                                }
                                    
                            }
                            else
                            {
                                
                                    if (words[i].Contains(pattern.Substring(1, pattern.Length - 2))&& words[i].Contains(pattern.Substring(starposision[1]+1, pattern.Length - starposision[1]-1)))
                                {
                                    for (int m = 0; m < wordsout.Length; m++)
                                    {

                                        if (wordsout[i] == repeatcontrol[m])
                                        {
                                            repeatflag = true;
                                            break;
                                        }
                                        else
                                            repeatflag = false;


                                    }
                                    if (repeatflag == false)
                                    {
                                        Console.WriteLine(wordsout[i]);

                                    }
                                    repeatcontrol[i] = wordsout[i];
                                }
                                    
                            }
                        }
                        else
                        {
                            if (starposision[count - 1] == pattern.Length-1)
                            {
                                
                                    if (words[i].Contains(pattern.Substring(0, starposision[0])) && words[i].Contains(pattern.Substring(starposision[0]+1, starposision[1]-starposision[0]-1)))
                                {
                                    for (int m = 0; m < wordsout.Length; m++)
                                    {

                                        if (wordsout[i] == repeatcontrol[m])
                                        {
                                            repeatflag = true;
                                            break;
                                        }
                                        else
                                            repeatflag = false;


                                    }
                                    if (repeatflag == false)
                                    {
                                        Console.WriteLine(wordsout[i]);

                                    }
                                    repeatcontrol[i] = wordsout[i];
                                }
                                    
                            }
                            else
                            {

                                if (words[i].Contains(pattern.Substring(0, starposision[0])) && words[i].Contains(pattern.Substring(starposision[0] + 1, starposision[1] - starposision[0] - 1))&& words[i].Contains(pattern.Substring(starposision[1]+1, pattern.Length-starposision[1]-1)))
                                {
                                    for (int m = 0; m < wordsout.Length; m++)
                                    {

                                        if (wordsout[i] == repeatcontrol[m])
                                        {
                                            repeatflag = true;
                                            break;
                                        }
                                        else
                                            repeatflag = false;


                                    }
                                    if (repeatflag == false)
                                    {
                                        Console.WriteLine(wordsout[i]);

                                    }
                                    repeatcontrol[i] = wordsout[i];
                                }
                                    
                            }
                        }
                    }
                }
                else //for unlimited * count more than 2
                {

                for (int i = 0; i < words.Length; i++)

                {
                    flag = true;
                    if (pattern.Length <= words[i].Length)
                    {
                        if (starposision[0] == 0) //there are 4 types of pattern depending on * being or not being fist or last : BFNL BFBL NFBL NFNL
                        {
                            if (starposision[count - 1] == pattern.Length - 1)//there are 4 types of pattern depending on * being or not being fist or last : BFNL BFBL NFBL NFNL
                                {
                                for (int j = 0; j < count - 2; j++)
                                {                                 

                                    if (!(words[i].IndexOf(pattern.Substring((starposision[j] + 1), (starposision[j + 1] - starposision[j] - 1))) + (starposision[j + 1] - starposision[j] - 1) < words[i].IndexOf(pattern.Substring((starposision[j + 1] + 1), (starposision[j + 2] - starposision[j + 1] - 1)))))
                                        flag = false;
                                }
                                if (flag == true)
                                    {
                                        for (int m = 0; m < wordsout.Length; m++)
                                        {

                                            if (wordsout[i] == repeatcontrol[m])
                                            {
                                                repeatflag = true;
                                                break;
                                            }
                                            else
                                                repeatflag = false;


                                        }
                                        if (repeatflag == false)
                                        {
                                            Console.WriteLine(wordsout[i]);

                                        }
                                        repeatcontrol[i] = wordsout[i];

                                    }
                                   

                            }
                                else //there are 4 types of pattern depending on * being or not being fist or last : BFNL BFBL NFBL NFNL
                                {
                                for (int j = 0; j < count - 2; j++)
                                {
                                    if (!(words[i].IndexOf(pattern.Substring((starposision[j] + 1), (starposision[j + 1] - starposision[j] - 1))) + (starposision[j + 1] - starposision[j] - 1) < words[i].IndexOf(pattern.Substring((starposision[j + 1] + 1), (starposision[j + 2] - starposision[j + 1] - 1)))))
                                        flag = false;
                                }
                                if (flag == true && words[i].Contains(pattern.Substring((starposision[count - 1] + 1), (pattern.Length - starposision[count - 1] - 1))))
                                    {
                                        for (int m = 0; m < wordsout.Length; m++)
                                        {

                                            if (wordsout[i] == repeatcontrol[m])
                                            {
                                                repeatflag = true;
                                                break;
                                            }
                                            else
                                                repeatflag = false;


                                        }
                                        if (repeatflag == false)
                                        {
                                            Console.WriteLine(wordsout[i]);

                                        }
                                        repeatcontrol[i] = wordsout[i];
                                    }
                                    
                                }
                        }
                            else //there are 4 types of pattern depending on * being or not being fist or last : BFNL BFBL NFBL NFNL
                            {
                            if (starposision[count - 1] == pattern.Length-1) //there are 4 types of pattern depending on * being or not being fist or last : BFNL BFBL NFBL NFNL
                                {
                                for (int j = 0; j < count - 2; j++)
                                {
                                    if (!(words[i].IndexOf(pattern.Substring((starposision[j] + 1), (starposision[j + 1] - starposision[j] - 1))) + (starposision[j + 1] - starposision[j] - 1) < words[i].IndexOf(pattern.Substring((starposision[j + 1] + 1), (starposision[j + 2] - starposision[j + 1] - 1)))))
                                        flag = false;
                                }
                                if (flag == true && words[i].Contains(pattern.Substring(0, starposision[0])))
                                    {
                                        for (int m = 0; m < wordsout.Length; m++)
                                        {

                                            if (wordsout[i] == repeatcontrol[m])
                                            {
                                                repeatflag = true;
                                                break;
                                            }
                                            else
                                                repeatflag = false;


                                        }
                                        if (repeatflag == false)
                                        {
                                            Console.WriteLine(wordsout[i]);

                                        }
                                        repeatcontrol[i] = wordsout[i];
                                    }
                                    


                            }
                                else //there are 4 types of pattern depending on * being or not being fist or last : BFNL BFBL NFBL NFNL
                                {
                                for (int j = 0; j < count - 2; j++)
                                {
                                    if (!(words[i].IndexOf(pattern.Substring((starposision[j] + 1), (starposision[j + 1] - starposision[j] - 1))) + (starposision[j + 1] - starposision[j] - 1) < words[i].IndexOf(pattern.Substring((starposision[j + 1] + 1), (starposision[j + 2] - starposision[j + 1] - 1)))))
                                        flag = false;
                                }
                                if (flag == true && words[i].Contains(pattern.Substring((starposision[count - 1] + 1), (pattern.Length - starposision[count - 1] - 1))) && words[i].Contains(pattern.Substring(0, starposision[0])))
                                    {
                                        for (int m = 0; m < wordsout.Length; m++)
                                        {

                                            if (wordsout[i] == repeatcontrol[m])
                                            {
                                                repeatflag = true;
                                                break;
                                            }
                                            else
                                                repeatflag = false;


                                        }
                                        if (repeatflag == false)
                                        {
                                            Console.WriteLine(wordsout[i]);

                                        }
                                        repeatcontrol[i] = wordsout[i];
                                    }
                                    
                                }
                        }
                    }
                }
                }
            }
            else //Searching and writing patterns containing '-'
            {
                
                string wordstemp;
                for(int i=0;i<words.Length;i++)
                {                    
                    flag = true;
                    wordstemp = words[i];                   
                    if(wordstemp.Length==pattern.Length)
                    {
                        for(int j=0;j<wordstemp.Length;j++)
                        {
                            if (wordstemp[j] == pattern[j]||pattern[j]=='-')
                            {
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                                break;

                            }
                                
                        }
                        if (flag == true)
                        {
                            
                            repeatflag = true;

                            for (int m = 0; m < wordsout.Length; m++)
                            {
                                
                                if (wordsout[i] == repeatcontrol[m])
                                {
                                    repeatflag = true;
                                    break;
                                }                                    
                                else
                                    repeatflag = false;
                                

                            }
                            if (repeatflag == false)
                            {
                                Console.WriteLine(wordsout[i]);

                            }
                            repeatcontrol[i] = wordsout[i];



                        }
                            
                    }
                   
                }

         
            
            }


            Console.ReadLine();
        }

    }
}





