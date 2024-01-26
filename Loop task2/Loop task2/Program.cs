int eded = -30;
int cem = 0;
int hasil = 0;
int tek_eded_sayi = 0;

while (eded<=28)
{
    if (eded % 3 == 0 && eded % 6 == 0)
    {
        cem += eded;
    }
    else if (eded % 5 == 0 || eded %2  == 0)
    {
        hasil *= eded;
    }
    else if (eded%2 == 1)
    {
        tek_eded_sayi++;
    }
    eded++;
}
Console.WriteLine($"Cem={cem}");
Console.WriteLine($"Hasil={hasil}");
Console.WriteLine($"Tek ededlerin sayi={tek_eded_sayi}");
