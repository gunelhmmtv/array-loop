int hasil = 1;
int i = 1;

while (i <= 50)
{
    Console.WriteLine(i);
    i += 3;
    hasil *= i;
}


Console.WriteLine($"1den 50 qeder 3 artim ile ededlerin hasili={hasil}");