// See https://aka.ms/new-console-template for more information
int sayi = 1;
string programcininAdi;
Console.WriteLine("Adınızı yazar mısınız ? ");
programcininAdi = Convert.ToString(Console.ReadLine());
// sayi=10 olana kadar programcının adını 10 defa ekrana yazma
while (sayi<=10) 
{
    Console.WriteLine("Programcının Adı : " + programcininAdi);
    sayi++;
}
