int eded = 4573;
int tersi = 0;


while (eded >0)
{
    int qaliq = eded % 10;
    tersi = (tersi * 10) + qaliq;
    eded /= 10;
}
Console.WriteLine($"4573 ededinin tersi = {tersi}");