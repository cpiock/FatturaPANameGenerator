using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatturaPANameGenerator
{
    public class SequenceGenerator
    {        
        char[] numberSequence = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] charSequence = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public string NextCode(string value)
        {
            char[] chars = value.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                int index = Array.IndexOf(numberSequence, chars[i]);
                //if not last int
                if (index >= 0)
                {
                    if (index < numberSequence.Length-1)
                    {
                        //get next valid int
                        chars[i] = numberSequence[index + 1];
                        break;
                    }
                    //if maximum int
                    else
                    {
                        //if not the first char in given string
                        if (i > 0)
                        {
                            index = Array.IndexOf(numberSequence, chars[i - 1]);
                            if (index <= numberSequence.Length - 1)
                            {
                                //set first int
                                chars[i] = numberSequence[0];
                            }
                        }
                        else
                        {      
                            //check if it is a char                      
                            int charIndex = Array.IndexOf(charSequence, chars[i]);
                            if (charIndex >= 0)
                            {
                                //is the next char not the last char
                                if (charIndex < charSequence.Length - 1)
                                {
                                    chars[i] = charSequence[charIndex + 1];
                                    break;
                                }
                                else
                                {
                                    //is the next char the last char then restart by the first
                                    index = Array.IndexOf(charSequence, chars[i - 1]);
                                    if (index < charSequence.Length - 1)
                                    {
                                        chars[i] = charSequence[0];
                                    }
                                }
                            }
                            else
                            {
                                //if not take the first char
                                chars[i] = charSequence[0];
                            }
                        }
                    }
                }
                else
                {
                    int charIndex = Array.IndexOf(charSequence, chars[i]);
                    if (charIndex >= 0)
                    {
                        //if it's not the last char
                        if (charIndex < charSequence.Length-1)
                        {
                            //get the next char
                            chars[i] = charSequence[charIndex + 1];
                            break;
                        }
                        else
                        {
                            //if it is not the first char in string
                            if (i > 0)
                            {
                                index = Array.IndexOf(charSequence, chars[i - 1]);
                                if (index < charSequence.Length - 1)
                                {
                                    //set the first char
                                    chars[i] = charSequence[0];
                                }
                                else
                                {
                                    //set the first char in the next position of the string
                                    chars[i + 1] = charSequence[0];
                                    break;
                                }
                            }
                            else
                            {
                                //set the first char in the next position of the string
                                chars[i+1] = charSequence[0];
                            }
                        }
                    }

                }
            }
            return new string(chars);
        }
    }
}
