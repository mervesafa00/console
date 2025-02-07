namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Bir sayı giriniz: ");
           int sayi1 = Convert.ToInt32(Console.ReadLine());
           Console.Write("Bir sayı daha giriniz: ");
           int sayi2 = Convert.ToInt32(Console.ReadLine());
           int toplam = sayi1 + sayi2;
           Console.WriteLine("Sayıların toplamı: " + toplam);
        }
    }
}
