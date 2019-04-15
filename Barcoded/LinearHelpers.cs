﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Barcoded
{
    internal static class LinearHelpers
    {
        /// <summary>
        /// Returns a string containing only ASCII characters.
        /// Non ASCII are converted to space character
        /// </summary>
        /// <param name="text">Text to remove non ASCII from.</param>
        /// <returns>ASCII only version of input text.</returns>
        internal static string GetOnlyASCII(string text)
        {
            string returnString = "";

            if(String.IsNullOrEmpty(text))
            {
                return returnString;
            }

            int ASCIICode;
            for (int position = 0; position <= text.Length - 1; position++)
            {
                ASCIICode = text[position];
                if (ASCIICode > 127)
                {
                    returnString += " ";
                }
                else
                {
                    returnString += text.Substring(position, 1);
                }
            }
            return returnString;
        }

        /// <summary>
        /// Returns a string containing only numeric (0-9) characters.
        /// Non numeric characters are removed from the string
        /// </summary>
        /// <param name="text">Text to remove non numeric from.</param>
        /// <returns>Numeric only version of input text.</returns>
        internal static string GetOnlyNumeric(string text)
        {
            string returnString = "";

            if (String.IsNullOrEmpty(text))
            {
                return returnString;
            }

            int ASCIICode;
            for (int position = 0; position <= text.Length - 1; position++)
            {
                ASCIICode = text[position];
                if (ASCIICode >= 48 && ASCIICode <= 57)
                {
                    returnString += text.Substring(position, 1);
                }
            }
            return returnString;
        }

        /// <summary>
        /// Returns a string containing only an even number of 
        /// numeric (0-9) characters.
        /// Non numeric characters are removed from the string
        /// and "0" prefixed to odd numbered numeric strings.
        /// </summary>
        /// <param name="text">Text to remove non numeric from and make even character count.</param>
        /// <returns>Even numbered character count, numeric only version of input text.</returns>
        internal static string GetEvenNumeric(string text)
        {
            string returnString = GetOnlyNumeric(text);

            if (returnString.Length % 2 == 1)
            {
                returnString = "0" + returnString;
            }

            return returnString;
        }
    }
}
