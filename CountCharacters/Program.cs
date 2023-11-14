var range = 250;
var counts = new int[range];
int letterCount = 0;
string? text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    if (text == null) continue;
    foreach (var character in text.ToUpper() ?? string.Empty)
    {
        counts[(int)character]++;
        letterCount++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            int percentage = (int)Math.Round((double)counts[i] / letterCount * 100d);
            Console.WriteLine($"{character} - {counts[i]} - {percentage}%" );
        }
    }
}