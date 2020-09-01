using System;
using System.Linq;

namespace PhoneNumberValidator
{
	//Please do not change the signature of class methods
	public class PhoneNumberValidator
	{
		public static void Main(string[] args)
		{
			// call the functions to validate phone number and display the status
			DisplayResult(ValidatePhoneNumber(GetInput()));
		}

		public static string GetInput()
		{
			// get phonenumber as input   
			string number = Console.ReadLine();
			return number;
		}

		public static void DisplayResult(int result)
		{
			// display status of phone number valid or invalid
			if (result == 1)
			{
				Console.WriteLine("Valid");
			}
			else
			{
				Console.WriteLine("Invalid");
			}
		}

		public static int ValidatePhoneNumber(string input)
		{
			// validate phone-number
			// for null or empty value, function should return -1
			// for invalid phone-number, function should return 0
			// for valid phone-number, function should return 1
			if (String.IsNullOrEmpty(input))
			{
				return -1;
			}

			const string digits = "0123456789";
			if (input.Any(x => !digits.Contains(x) && x != '-'))
			{
				return 0;
			}
			else
			{
				if (input.Where(x => digits.Contains(x)).ToList().Count == 10)
				{
					return 1;
				}
				else
				{
					return 0;
				}
			}

			return 0;
		}
	}
}