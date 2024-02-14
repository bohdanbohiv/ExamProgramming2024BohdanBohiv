using Utilities;


Console.WriteLine(StringUtilities.LongWordsCount("Marcin Jagiela"));
Console.WriteLine(StringUtilities.LongWordsCount("The lord of the rings"));
Console.WriteLine(StringUtilities.ToSpinalCase("Marcin Jagiela"));
Console.WriteLine(StringUtilities.ToSpinalCase("the LorD OF thE Rings"));
Console.WriteLine("Marcin Jagiela".ToPascalCase());
Console.WriteLine("the LorD OF thE Rings".ToPascalCase());

Console.ReadLine();
