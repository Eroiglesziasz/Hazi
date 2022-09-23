Console.WriteLine("Adj meg két számot");
Console.Write("Első szám: "); int szam1 = int.Parse(Console.ReadLine());
Console.Write("Második szám: "); int szam2 = int.Parse(Console.ReadLine());

if (szam1 > szam2)
{
    Console.WriteLine(szam1);
}
else
{
    Console.WriteLine(szam2);
}
Console.ReadKey();
