string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string contactMessage = "";

contactMessage = $"Dear {customerName},\n"
+ $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n"
+ $"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n\n"
+ $"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume your potential profit would be {newProfit:C}.\n\n";

Console.WriteLine(contactMessage);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage =
$"{currentProduct.PadRight(20)}" + String.Format("{0:P}", currentReturn).PadRight(10) + $"{currentProfit:C}\n"
+ $"{newProduct.PadRight(20)}" + String.Format("{0:P}", newReturn).PadRight(10) + $"{newProfit:C}";

Console.WriteLine(comparisonMessage);