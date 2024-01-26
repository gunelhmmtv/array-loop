string[] telebe = new string[5];
for  (int i = 0; i < telebe.Length; i++)
{
    Console.WriteLine($"{i + 1}. telebenin adini daxil edin:");
    telebe[i] = Console.ReadLine();
}
Console.WriteLine("Telebelerin adi :");
foreach (  string telebeler in telebe )
{
    Console.WriteLine(telebeler);
}