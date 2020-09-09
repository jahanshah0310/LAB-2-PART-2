using System;

class MainClass {
  public static void Main (string[] args) {
    int number1; 
    int number2;
    int sum;
    int diff;
    int product;
    int quotient;
    int remainder;

    Console.Write( "Enter first integer: " );
    number1 = Convert.ToInt32( Console.ReadLine() );

    Console.Write( "Enter second integer: " );
    number2 = Convert.ToInt32( Console.ReadLine() );
    
    sum = number1 + number2;
    Console.WriteLine( "Sum is {0}", sum );
    
    diff = number1 - number2;
    Console.WriteLine("diff is {0}", diff);

    product = number1 * number2;
    Console.WriteLine("product is {0}", product);

    quotient = number1 / number2;
    Console.WriteLine("quotient is {0}", quotient);

    remainder = number1 % number2;
    Console.WriteLine("remainder is {0}", remainder);
    

  }
}