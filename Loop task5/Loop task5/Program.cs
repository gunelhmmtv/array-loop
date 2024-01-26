
int limit = 0;

while (limit < 3)
{
Console.WriteLine("Logini daxil edin:");
string login = Console.ReadLine();
Console.WriteLine("Passwordu daxil edin:");
string  password = Console.ReadLine();
    if (login != "booleanteach" && password == "booleanms13")
    {
        Console.WriteLine("Login sevhdir!");
        
    }
    else if (login== "booleanteach" && password != "booleanms13")
    {
        Console.WriteLine("Password sehvdir!");
        
    }
    else if (login != "booleanteach" && password != "booleanms13")
    {
        Console.WriteLine("Her ikisi de sehvdir!");
        
    }
    else
    {
        Console.WriteLine("Sisteme daxil oldunuz!");
        break;
    }
        


    limit++;    
}
if (limit == 3)
{
    Console.WriteLine("Sistem bloklanmisdir!");
}