//FizzBuzz - Print integers 1 to 100,
//but print “Fizz” if an integer is divisible by 3,
//“Buzz” if an integer is divisible by 5,
//and “FizzBuzz” if an integer is divisible by both 3 and 5.

for (int i = 1; i <= 100; i++)
{
    bool divisibleBy3 = (i % 3 == 0);
    bool divisibleBy5 = (i % 5 == 0);
    if (divisibleBy3 && divisibleBy5)
    {
        //Divides by both 3 and 5, add FizzBuzz
        Console.WriteLine("FizzBuzz");
    }
    else if (divisibleBy3)
    {
        //Divides by 3, add Fizz
        Console.WriteLine("Fizz");
    }
    else if (divisibleBy5)
    {
        //Divides  by 5, add Buzz
        Console.WriteLine("Buzz");
    }
    else
    {
        //Not divisible by 3 or 5, add the  number
        Console.WriteLine(i);
    }
}