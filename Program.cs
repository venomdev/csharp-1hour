/**
 * C# Tutorial: Learn C# in 1 Hour
 *
 * A small application based on the C# tutorial by Mosh Hamedani
 *
 * YouTube Channel: Programming with Mosh (https://www.youtube.com/@programmingwithmosh)
 * Video url: https://www.youtube.com/watch?v=gfkTfcpWqAY
 */
using System;

public class Application
{

	/**
	 * Main program entry
	 */
	static public void Main(String[] args)
	{
		System.Console.WriteLine("Programming with Mosh - Learn C# Basics in 1 Hour\n");
		Variables();
		VariableRanges();
		Constants();
		TypeConversion();
		Operators();
	}

	/**
	 * Using constants
	 */
	static private void Constants()
	{
		const float Pi = 3.14f;
		// Pi = 1;	// Generates an error

		System.Console.WriteLine("Constant variables");
		System.Console.WriteLine("Pi: {0}", Pi);

		System.Console.WriteLine();
	}

	/**
	 * Using operators
	 */
	static private void Operators()
	{
		var a = 3;
		var b = 2;
		var c = 5;

		System.Console.WriteLine("Operators");
		System.Console.WriteLine("{0} / {1} = {2}", a, b, (float)a / (float)b);
		System.Console.WriteLine("{0} + {1} * {2} = {3}", a, b, c, a + b * c);
		System.Console.WriteLine("({0} + {1}) * {2} = {3}", a, b, c, (a + b) * c);
		System.Console.WriteLine("{0} > {1} ? {2}", a, b, a > b);
		System.Console.WriteLine("{0} == {1} ? {2}", a, b, a == b);
		System.Console.WriteLine("{0} != {1} ? {2}", a, b, a != b);
		System.Console.WriteLine("!({0} != {1}) ? {2}", a, b, !(a != b));
		System.Console.WriteLine("{0} > {1} && {0} > {2} ? {3}", c, a, b, c > a && c > b);
		System.Console.WriteLine("{0} > {1} && {0} == {2} ? {3}", c, a, b, c > a && c == b);
		System.Console.WriteLine("{0} > {1} || {0} == {2} ? {3}", c, a, b, c > a || c == b);
		System.Console.WriteLine("!({0} > {1} || {0} == {2}) ? {3}", c, a, b, !(c > a || c == b));

		System.Console.WriteLine();
	}

	/**
	 * Type conversion
	 */
	static private void TypeConversion()
	{
		byte b = 1;
		int i = b;

		int b2 = 1000;   // Data loss example
		byte i2 = (byte)b2;

		string number = "1234";
		// int i3 = (int)number; // Invalid cast example, use convert
		int i3 = Convert.ToInt32(number);

		System.Console.WriteLine("Type conversion");
		System.Console.WriteLine("byte to int: {0}", i);
		System.Console.WriteLine("int cast to byte: {0}", i2);
		System.Console.WriteLine("string convert to int: {0}", i3);

		try
		{

			int b3 = Convert.ToByte(number); // Overflow exception

			System.Console.WriteLine("string convert to byte: {0}", b3);

		}
		catch (Exception)
		{
			System.Console.WriteLine("Overflow Exception: string convert to byte: {0}", number);
		}

		string boolStr = "true";
		bool bool1 = Convert.ToBoolean(boolStr);

		System.Console.WriteLine("string to boolean: {0}", bool1);

		System.Console.WriteLine();
	}

	/**
	 * Using variables
	 */
	static private void Variables()
	{
		byte number = 2;
		int count = 10;
		float totalPrice = 20.95f;
		char character = 'A';
		string firstName = "Dan";
		bool isWorking = true;
		var varString = "Hello";

		System.Console.WriteLine("Variable types");
		System.Console.WriteLine("byte: {0}", number);
		System.Console.WriteLine("int: {0}", count);
		System.Console.WriteLine("float: {0}", totalPrice);
		System.Console.WriteLine("char: {0}", character);
		System.Console.WriteLine("string: {0}", firstName);
		System.Console.WriteLine("bool: {0}", isWorking);
		System.Console.WriteLine("var: {0}", varString);

		System.Console.WriteLine();

	}

	/**
	 * Variable ranges
	 */
	static private void VariableRanges()
	{
		System.Console.WriteLine("Variable Ranges");
		System.Console.WriteLine("byte: {0} {1}", byte.MinValue, byte.MaxValue);
		System.Console.WriteLine("float: {0} {1}", float.MinValue, float.MaxValue);

		System.Console.WriteLine();
	}
}
