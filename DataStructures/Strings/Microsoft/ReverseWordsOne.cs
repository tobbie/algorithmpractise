﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Strings.Microsoft
{
   public class ReverseWordsOne
    {
        public static string Reverse(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return word;

            if (word.Length == 1)
                return word;
            
            word = word.Trim();

            var wordArray = word.Split(' ').Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
            
            int leftPointer = 0;
            int rightPointer = wordArray.Length - 1;

            while(leftPointer < rightPointer)
            {
                Util.Swap(wordArray, leftPointer, rightPointer);
                leftPointer++;
                rightPointer--;
            }

            return string.Join(' ', wordArray);
        }

        
    }
}
