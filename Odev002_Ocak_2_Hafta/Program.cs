/* 
1️-)C#’ta kullanılan temel veri tipleri nelerdir? (int, double, string vb.)
2️-)Aşağıdaki değişkenlerin bellek kullanımını karşılaştırın:
•	int x = 5;
•	double y = 5.2;
•	string name = "Mehmet";

3️-)Kullanıcıdan iki sayı alıp toplamını ekrana yazdıran bir program yazın.
*/
/*
 1) int: Tam sayılar
double: Ondalıklı sayılar
string: Karakter dizileri
char: Tek karakter 
bool: Mantıksal değerler
float: Düşük ondalıklı sayılar
decimal: Yüksek ondalıklı sayılar
long: Büyük tam sayılar
short: Küçük tam sayılar
2) int x = 5; Bellek kullanımı 32 bit 4 byte 
double y = 5.2; Bellek kullanımı 64 bit 8 byte
string name = "Mehmet"; Bellek kullanımı 7*2 = 14 byte ( her karakter 2 byte)
3) 
*/
Console.Write("Birinci sayıyı girin: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int toplam = num1 + num2;

Console.WriteLine("Toplam: " + toplam);