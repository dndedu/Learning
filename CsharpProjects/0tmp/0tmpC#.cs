string number = "255";
byte b;

Console.WriteLine(byte.TryParse(number, out b));

Console.WriteLine(number.StartsWith("25"));