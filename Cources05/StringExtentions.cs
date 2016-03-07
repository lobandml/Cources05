using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources05
{
   static class StringExtentions
    {
       public static string LocalSubstring(this string str, int firstposition, int length)
       {
           StringBuilder result = new StringBuilder();
           if (firstposition < 0 || firstposition + length >= str.Length)
           {
               throw new Exception("Выход за пределы области");
           }
           for (int i = firstposition; i < firstposition + length; i++)
           {
               result.Append(str[i]);
           }
           return result.ToString();
       }
       
       public static int LocalIndexOf(this string str, string pattern)
       {
           //Наивный алгоритм
           int result = -1;
           int counter=0;
           for (int i = 0; i < str.Length-pattern.Length; i++)
           {
               counter=0;
               for (int j = 0; j < pattern.Length; j++)
               {
                   if (str[i + j] == pattern[j]) counter++;
               }
               if (counter == pattern.Length)
               {
                   return i;
               }
           }
           return result;
       }

       
       public static string LocalReplace(this string str, string oldvalue, string newvalue)
       {
          
           
           if (oldvalue.Length == 0)
           {
               throw new ArgumentException("Парметром не может быть пустая строка");
           }

            StringBuilder sb = new StringBuilder(str);
           int pos=str.IndexOf(oldvalue);
           int len = oldvalue.Length;

           while (pos != -1)
           {
               sb.Remove(pos,len);
               sb.Insert(pos, newvalue);
               
                  
               pos = sb.ToString().IndexOf(oldvalue);
           }

           return sb.ToString();
       }
    }
}
