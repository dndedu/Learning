/* string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

/* string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

/* string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
} */

/* string pangram = "The quick brown fox jumps over the lazy dog";

string[] parts = pangram.Split(" ");

foreach (string word in parts)
{
    // #1, works
    // Console.Write(String.Concat(word.Reverse()) + " ");

    // #2, works
    // Console.Write(String.Join("", word.Reverse()) + " ");

    // #3, works,
    // char[] c = word.ToCharArray();
    // Array.Reverse(c);
    // #3.1
    // Console.Write(c + " ");
    // #3.2
    // Console.Write(new String(c) + " ");

    // #4, works
    // char[] letters = word.ToCharArray();
    // Array.Reverse(letters);
    // Console.Write(new String(letters) + " ");
} */

/* string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] singleOrders = orderStream.Split(',');

Array.Sort(singleOrders);

foreach (string order in singleOrders)
{
    if (order.Length != 4)
        Console.WriteLine(order + "\t- Error");
    else
        Console.WriteLine(order);
} */

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

decimal tax = .12051m;
Console.WriteLine($"Tax rate: {tax}");