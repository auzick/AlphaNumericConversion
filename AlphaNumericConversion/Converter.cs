using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaNumeric
{
	// inspired by http://quashnick.net/geek_stuff/HEX2DEC.html

	public static class Converter
	{

        internal static List<char> Digits = new List<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray());
        internal static int DigitsLength = 62;

        //internal static List<char> Digits = new List<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray());
        //internal static int DigitsLength = 36;

    internal static ulong ToNumber(String Text)
		{
			if (String.IsNullOrEmpty(Text))
			{
				throw new ArgumentException("String must not be null or empty.");
			}

			char[] chars = Text.ToCharArray();

			Array.Reverse(chars);

      ulong register = 0;
      for (int i = 0; i < chars.Length; i++)
			{
				int val = Digits.FindIndex(d => d.Equals(chars[i]));
				if (val < 0)
				{
					throw new ArgumentException("String must contain only alpha-numeric characters.");
				}
        register += ((ulong)val * (ulong)Math.Pow(DigitsLength, i));
			}
			return register;
		}

		internal static string ToAlphaDecimal(ulong Number)
		{
			if (Number == 0)
			{
				return "0";
			}
			List<char> register = new List<char>();
			ulong quotient = Number;
		  while (quotient > 0)
		  {
		    long remainder = 0;
		    quotient = (ulong)Math.DivRem((long)quotient, DigitsLength, out remainder);
		    if (remainder < 0)
		    {
		      throw new OverflowException();
		    }
		    register.Add(Digits[(int)remainder]);
		  }
		  register.Reverse();
			return new string(register.ToArray());
		}
	}
}
