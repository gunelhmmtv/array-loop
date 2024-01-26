int[] numbers = new int[5];
int cem = 0;
int hasil = 1;
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i+1}. ededi daxil edin:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Daxil etdiyiniz ededler:");
foreach (int number in numbers)
{
    Console.WriteLine(number + "  ");
}
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        cem = cem + number;
    }
}
Console.WriteLine($"Cut olanlarin cemi={cem}");

foreach (int number in numbers)
{
    if (number%2==1) 
    {
        hasil = hasil * number;
    }
}
Console.WriteLine($"Tek olanlarin hasili={hasil}");