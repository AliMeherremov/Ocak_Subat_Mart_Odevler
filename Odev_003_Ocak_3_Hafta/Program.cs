/* 
1️-)Koşullu ifadeler (if-else) ne işe yarar? Gerçek hayattan bir örnek verin.
2️-)Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu bulan bir C# programı yazın.
3️-)Girilen bir sayının pozitif, negatif veya sıfır olup olmadığını belirleyen bir program yazın.
*/
/*
1)
*/

// 1) Öğrenci notu örneği yaptım

int not = 45; 

if (not >= 50)
{
    Console.WriteLine("Geçtiniz!");
}
else
{
    Console.WriteLine("Kaldınız!");
}

// 2)

Console.Write("Bir sayı girin: ");
int sayii= Convert.ToInt32(Console.ReadLine());

if (sayii % 2 == 0 )
{
    Console.WriteLine("Sayınız çift.");
}
else
{
    Console.WriteLine("Sayınız tek.");
}
// 3)
Console.Write("Bir sayı girin: ");
int sayi= Convert.ToInt32(Console.ReadLine());

if (sayi> 0)
{
    Console.WriteLine("Sayı pozitif.");
}
else if (sayi < 0)
{
    Console.WriteLine("Sayı negatif.");
}
else
{
    Console.WriteLine("Sayı sıfır.");
}
