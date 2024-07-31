Console.WriteLine("1 -> Geriye Değer Döndürmeyen Bir void metot.\nEkrana sevdiğiniz bir şarkı sözünü yazdırsın.\n");
void Lyrics()
{
    Console.WriteLine("Kıskanır rengini baharda yeşiller\r\nSevda büyüsü gibisin sen Firuze");
}
Lyrics();
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("2 -> Geriye Tamsayı Döndüren Bir metot.\nRastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.\n");
int Remaining()
{ 
    Random rnd = new Random();
    int randomNumber = rnd.Next();
    int result = randomNumber % 2;
    Console.WriteLine("Rastgele üretilen sayı "+randomNumber+" için 2'ye bölümünden geri kalanı --> "+result);
    return result;
}
Remaining();
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("3 -> Parametre Alan ve Geriye Değer Döndüren Bir Metot\nParametre olarak aldığı iki sayının çarpımını geriye dönsün.\n");
int Product(int a,int b)
{
    int total = a * b;
    Console.WriteLine("İletilen iki sayının çarpımı ---> "+ total);
    return total;
}

Console.Write("Birinci sayı giriniz ---> ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("İkinci sayı giriniz ---> ");
int number2 = Convert.ToInt32(Console.ReadLine());
Product(number1, number2);

Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("4 -> Parametre Alan ve Geriye Değer Döndürmeyen bir Metot\nParametre olarak isim ve soyisim bilgilerini alıp \" Hoş Geldiniz {isim} {soyisim} \" şeklinde ekrana bassın.\n");
void Welcome(string name,string surname)
{
    Console.WriteLine($"Hoş geldiniz {name} {surname}");
}
Console.WriteLine("İsminizi giriniz ");
var name = Console.ReadLine();
Console.WriteLine("Soyadınızı giriniz ");
var surname = Console.ReadLine();

Welcome(name, surname);








