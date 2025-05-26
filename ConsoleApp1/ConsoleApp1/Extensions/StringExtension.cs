using System;

// class must be static to be an extension 
public static class StringExtensions
{
    // method must be static
	// take 'this' and type as first parameter
	
    public static int CountLines(this string input) => 
		input.Split(Environment.NewLine).Length;
	{
	}
}
