// See https://aka.ms/new-console-template for more information
int sayi = 1;
string programcininAdi;
Console.WriteLine("Adınızı yazar mısınız ? ");
programcininAdi = Convert.ToString(Console.ReadLine());
//aynı ismi yazacak 10 defa  sayi 10 a eşit olana kadar
while (sayi<=10) 
{
    Console.WriteLine("Programcının Adı : " + programcininAdi);
    sayi++;
}
