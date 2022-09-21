namespace Tembel_Cellat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0, sagKalan, olecekKisi, kacKisiYasayacak, kural;
            Console.WriteLine("toplam mahkum sayısı");
            olecekKisi = Convert.ToInt32(Console.ReadLine());//toplam mahkum sayısı
            int[] dizi = new int[olecekKisi];
            Console.WriteLine("kaç kişi yaşayacak");
            kacKisiYasayacak = Convert.ToInt32(Console.ReadLine());//sonda hayatta kalacak kişi sayısı
            Console.WriteLine("kaç kişi atlayarak ölecekler");
            kural = Convert.ToInt32(Console.ReadLine());//kaç kişi atlayarak ölecek
            sagKalan = dizi.Length;
            for (int i = 0; i < dizi.Length; i++)//diziye atanacak elemanlar
            {
                dizi[i] = (i + 1);
            }
            for (int i = 0; i <= dizi.Length; i++)
            {
                if (dizi[i] != 0)//dizinin i indikli elemanı 0 mı kontrol ediyor  0 sa şart koşuluna giriyor
                {
                    s++;
                    if (s == kural + 1)//matematiksel formülün çözümü
                    {
                        dizi[i] = 0;
                        s = 0;
                        sagKalan--;
                    }
                }
                Console.WriteLine(dizi[i]);
                if (i >= dizi.Length - 1)// döngünün tekrar başa dönmesi için bi nevi sonsuz döngü yaratıyoruz
                {
                    i = -1;// -1den başlamasının sebebi for göngüsünün çalışma mantığından dolayı
                }
                if (sagKalan == kacKisiYasayacak)// döngüyü kırmak için yapılan şart koşulu
                {
                    break;
                }
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("sağ kalanlar");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] != 0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }
        }
    }
}