string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string concatenated = "";

foreach (string item in values)
{
    int i;
    if (int.TryParse(item, out i))
    {

    }
    else
    {
        concatenated += item;
    }
}