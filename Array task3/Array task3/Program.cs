int[] numbersA = { 4, 6, -3, 44, -5 };
int[] numbersB = { 9, 16, 100, 11, -20 };


int maxA = numbersA[0];
int minB = numbersB[0];

for (int i = 1; i < numbersA.Length; i++)
{
    if (numbersA[i] > maxA)
    {
        maxA = numbersA[i];
    }
}

for (int i = 1; i < numbersB.Length; i++)
{
    if (numbersB[i] < minB)
    {
        minB = numbersB[i];
    }
}


for (int i = 0; i < numbersA.Length; i++)
{
    if (numbersA[i] == maxA)
    {
        numbersA[i] = minB;
    }
}

for (int i = 0; i < numbersB.Length; i++)
{
    if (numbersB[i] == minB)
    {
        numbersB[i] = maxA;
    }
}


Console.WriteLine("NumbersA: " + string.Join(", ", numbersA));
Console.WriteLine("NumbersB: " + string.Join(", ", numbersB));