

using AistAlgo.Algos;

//bool @case1 = Palindrome.IsPalindrome(121);
//bool @case2 = Palindrome.IsPalindrome("madam");

//Console.WriteLine(case1);   
//Console.WriteLine(case2);   


var prime1 = Mirror.IsPrime(2);
var prime2 = Mirror.IsPrime(3);
var prime3 = Mirror.IsPrime(4);
var prime4 = Mirror.IsPrime(5);
var prime5 = Mirror.IsPrime(6);
var prime6 = Mirror.IsPrime(16);
var prime7 = Mirror.IsPrime(18);


//Console.WriteLine(prime1);
//Console.WriteLine(prime2);
//Console.WriteLine(prime3);
//Console.WriteLine(prime4);
//Console.WriteLine(prime5);
//Console.WriteLine(prime6);
//Console.WriteLine(prime7);


var reversed = Mirror.Reversed(12);

List<int> result = Mirror.Mirrors();
foreach (int number in result)
{
    Console.WriteLine(number);

}

