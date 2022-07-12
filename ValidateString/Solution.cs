using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ValidateString
{
	public class Solution
	{
		public static bool ValidateString(String toValidate)
		{
			Stack<char> stack = new Stack<char>();

			foreach (char c in toValidate)
			{
				if (IsOpeningBracket(c))		
					stack.Push(c);
				else
				{
					if (stack.Count == 0)
						return false;
					char stackOpenBracket = stack.Pop();
					if (MatchBracket(stackOpenBracket, c))
						continue;
					else
						return false;
				}
			}
			if (stack.Count == 0)
				return true;
			return false;
		}

		public static bool IsOpeningBracket(char c)
		{
			if (c.Equals('(') | c.Equals('[') | c.Equals('{'))
				return true;
			return false;
		}

		public static bool MatchBracket(char openBracket, char closedBracket)
		{
			if (closedBracket.Equals(')') && openBracket.Equals('('))
				return true;
			if (closedBracket.Equals(']') && openBracket.Equals('['))
				return true;
			if (closedBracket.Equals('}') && openBracket.Equals('{'))
				return true;
			return false;
		}
	}
}