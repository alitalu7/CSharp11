
Console.WriteLine("Metodlar ile ilgili bir örnek");
EkranaYaz();
Console.WriteLine("Toplam metodu çalıştı ve sonuç = " + Toplam(3, 2));



static void EkranaYaz()
{
    Console.WriteLine("EkranaYaz metodu çalıştı...");
}

static int Toplam(int a, int b)
{
    return a+ b;
}