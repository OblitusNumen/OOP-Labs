// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine(new SuffixDateTimeDecorator(new PrefixDateTimeDecorator(new AmericanStyleDateTime())).GetDateTime());
Console.WriteLine(new PrefixDateTimeDecorator(new PrefixDateTimeDecorator(new EuropeanStyleDateTime())).GetDateTime());