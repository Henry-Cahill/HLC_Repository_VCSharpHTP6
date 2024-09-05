// See https://aka.ms/new-console-template for more information

//Figure 3.27: Prompt27.cs
//(Integer Equivalent of a Character)
//Here's another peek ahead. In this chapter, you have learned about integers and the type int. C# can represent uppercase letters, lowercase letters and a considerable variety of special symbols. Every character has a corresponding integer representation. The set of characters a computer uses and the corresponding integer representations for those characters is called that computer's character set. You can indicate a character value in an app simply by enclosing that character in single quotes, as in 'A'.
//You can determine the integer equivalent of a character by preceding that character with (int), as in

// (int) 'A'

//The keyword int in parentheses is known as a cast operator, and the entire expression is called a cast expression. (You'll learn about casr operators in Chapter 5.) The following statement outputs a character and its integer equivalent:

// Console.WriteLine($"The character {'A'} has the value {(int) 'A'}");

// When the preceding statement executes it displays the character A and the value 65 as part of the string. See Appendix C for a list of Characters and their integer equivalents.
// Using statements similar to the one shown earlier in this exercise, write an app that displays the integer equivalents of some uppercase letters, lowercase letters, digits and special symbols. Display the integer equivalents of the following: A B C a b c 0 1 2 $ * + / and the space character.





using System;
using System.Numerics;

class Prompt27
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      Console.WriteLine($"The character {'A'} has the value {(int)'A'}");
      Console.WriteLine($"The character {'B'} has the value {(int)'B'}");
      Console.WriteLine($"The character {'C'} has the value {(int)'C'}");
      Console.WriteLine($"The character {'a'} has the value {(int)'a'}");
      Console.WriteLine($"The character {'b'} has the value {(int)'b'}");
      Console.WriteLine($"The character {'c'} has the value {(int)'c'}");
      Console.WriteLine($"The character {'0'} has the value {(int)'0'}");
      Console.WriteLine($"The character {'1'} has the value {(int)'1'}");
      Console.WriteLine($"The character {'2'} has the value {(int)'2'}");
      Console.WriteLine($"The character {'$'} has the value {(int)'$'}");
      Console.WriteLine($"The character {'*'} has the value {(int)'*'}");
      Console.WriteLine($"The character {'+'} has the value {(int)'+'}");
      Console.WriteLine($"The character {'/'} has the value {(int)'/'}");
      Console.WriteLine($"The character {' '} has the value {(int)' '}");
   }//end Main
}//end class Prompt27