using System.Security.Cryptography.X509Certificates;

namespace BİLGİ_YARİSMASİ_OYUNU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("Yarışmaya Hoş Geldiniz.");
            Console.Title=("Bilgi Yarışması");
            Random sorular= new Random();
            int rastgele=sorular.Next(1,10);

            string ad, soyad;
            Console.WriteLine("Adınız:");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            soyad= Console.ReadLine();

            Console.WriteLine("Yarışma Başlıyor, Enter Tuşuna Basın...");
            Console.WriteLine("Her yanıttan sonra Enter tuşuna basmayı unutmayın...");
            Console.WriteLine("Cevapları BÜYÜK HARFLERLE verin...");
            Console.ReadLine();
            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para = 0;

            string soru1;
            Console.WriteLine("Soru 1: İlk Çağ Uygarlıklarından Hangisi Yazıyı İcat Etmiştir.  ");
            soru1 = Console.ReadLine();
            string cevap1;
            Console.WriteLine("A)Hitiler\n B)ELamlar\n C)Sümerler\n D)Urartular\n CEVABINIZ:");
            cevap1 = Console.ReadLine();
            if(cevap1=="C")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru, Devam Etmek İçin Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Cevap Yanlış Enter Tuşuna Basın Lütfen");
                Console.ReadLine();
            }
            string soru2;
            Console.WriteLine("Soru 2: 2003 Yılında Euro Vizyon Şarkı Yarısmasında Ülkemizi Temsil Eden Ve Yarışmada Birinci Gelen Sanatçımız Kimdir  ");
            soru2 = Console.ReadLine();
            string cevap2;
            Console.WriteLine("A)Grup Athena\n B)Sertap Erener \n C)Şebnem Paker\n D)Ajda Pekkan\nCEVABINIZ:");
            cevap2= Console.ReadLine();
            if(cevap2=="B")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Bildiniz Devam Etmek için Enter, a Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
            }
            string soru3;
            Console.WriteLine("Tsunam Felaketinde En Fazla Zarar Gören Güney Asya Ülkesi Hangisidir?");
            soru3 = Console.ReadLine();
            string cevap3;
            Console.WriteLine("A)Endonezya\n B)Srilanka\n C)Talyand\n D)Hindistan\nCEVABINIZ");
            cevap3 = Console.ReadLine();
            if(cevap3=="A")
            {
                dogru++;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru Devam Etmek İçin Enter Tuşuna Basın");
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
            }
            string soru4;
            Console.WriteLine("Mustafa Kemal Atatürk`ün Nüfusa Kyıtlı Olduğu İl Hnagisidir?");
            soru4 = Console.ReadLine();
            string cevap4;
            Console.WriteLine("A)Bursa\n B)Ankara\n C)İstanbul\n D)Gaziantep\nCEVABINIZ");
            cevap4 = Console.ReadLine();
            if (cevap4 == "D")
            {
                dogru++;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru Devam Etmek İçin Enter Tuşuna Basın");
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
            }
            string soru5;
            Console.WriteLine("Sinekli Bakkal Romanının Yazarı Aşağıdakilerden Hnagisidir?");
            soru3 = Console.ReadLine();
            string cevap5;
            Console.WriteLine("A)Reşat Nuri Güntekin\n B)Halide Edip Adıvar\n C)Ziya Gökalp\n D)Yakup Kadri Karaosmanoğlu\nCEVABINIZ");
            cevap5 = Console.ReadLine();
            if (cevap5 == "B")
            {
                dogru++;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru Devam Etmek İçin Enter Tuşuna Basın");
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
            }
            string soru6;
            Console.WriteLine("Hangisi Dünya Sağlık Örgütünün Kısaltılmış Adıdır?");
            soru6 = Console.ReadLine();
            string cevap6;
            Console.WriteLine("A)UHW\n B)UNİCEF\n C)WHO\n D)NATO\nCEVABINIZ");
            cevap6 = Console.ReadLine();
            if (cevap6 == "C")
            {
                dogru++;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru Devam Etmek İçin Enter Tuşuna Basın");
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
            }
            string soru7;
            Console.WriteLine("İlk Evcilleştirilmiş Hayvan Hangisidir? ");
            soru7 = Console.ReadLine();
            string cevap7;
            Console.WriteLine("A)Köpek\n B)Koyun\n C)Tavuk\n D)Kedi\nCEVABINIZ");
            cevap7 = Console.ReadLine();
            if (cevap7 == "A")
            {
                dogru++;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru Devam Etmek İçin Enter Tuşuna Basın");
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
            }
            string soru8;
            Console.WriteLine("Aşağıdakilerden Hangisi Çocuk Hastalığıdır?");
            soru8 = Console.ReadLine();
            string cevap8;
            Console.WriteLine("A)Kabakulak\n B)Nezle\n C)Covid19\n D)Kuş Gribi\nCEVABINIZ");
            cevap8 = Console.ReadLine();
            if (cevap8 == "A")
            {
                dogru++;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru Devam Etmek İçin Enter Tuşuna Basın");
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
            }
            string soru9;
            Console.WriteLine("Aşağıdaki İllerin Hangisinde Akdeniz İklimi Bulunur?");
            soru9 = Console.ReadLine();
            string cevap9;
            Console.WriteLine("A)Aydın\n B)Aksaray\n C)Mersin\n D)Balıkkesir\nCEVABINIZ");
            cevap9 = Console.ReadLine();
            if (cevap9 == "C")
            {
                dogru++;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru Devam Etmek İçin Enter Tuşuna Basın");
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
            }
            string soru10;
            Console.WriteLine("Fatih Sultan Mehmet`in Babası Kimdir?");
            soru10 = Console.ReadLine();
            string cevap10;
            Console.WriteLine("A)Yıldırım Beyazıt\n B) I.Mehmet\n C)Kanuni Sultan Süleyman\n D)II.Murat\nCEVABINIZ");
            cevap10 = Console.ReadLine();
            if (cevap10 == "D")
            {
                dogru++;
                para += 1000;
                Console.WriteLine("Tebrikler Cevap Doğru Devam Etmek İçin Enter Tuşuna Basın");
                Console.BackgroundColor= ConsoleColor.Green;
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Yanlış Cevap Enter`a basın Lütfen");
                Console.BackgroundColor= ConsoleColor.Red;
            }
            Console.WriteLine("Adınız:" + ad);
            Console.WriteLine("Soyadınız:" + soyad);
            Console.WriteLine("Doğru sayısı" + dogru );
            Console.WriteLine("Yanlış sayısı:" + yanlis);
            Console.WriteLine("Toplam kazandığınız para:" + para + "Türk Lirasıdır.");
            Console.WriteLine("Yarışma Bitmiştir");
            Console.Read();
        }
    }
}