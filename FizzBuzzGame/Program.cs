Console.WriteLine("Health Partner Challenge");
Console.WriteLine("------------------------");
Console.WriteLine();

Console.WriteLine("Conventional class implementation");
var fizzBuzzGame = new Game<ulong, IEnumerable<string>>(new FizzBuzzProcessor(), new FizzBuzzDisplay());
fizzBuzzGame.Run(1, 100);
Console.WriteLine("------------------------");
Console.WriteLine();
Console.WriteLine("Reflection based implementation");
var fizzBuzz = new ReflectionGame<ulong, IEnumerable<string>>();
fizzBuzz.Run(1, 100);