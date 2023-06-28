string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
int total = 0;

foreach (string item in values)
{
    int i;
    if (int.TryParse(item, out i))
    {
        total += i;
    }
    else
    {
        message += item;
    }
}