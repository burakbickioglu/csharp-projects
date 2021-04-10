using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME
{
    class Program
    {

        static void Main(string[] args)
        {

            int can = 100, guc = 10, xp = 0, canavarcan, max, min, vurus, canavarvurus;
            string secim;
            Random rastgele = new Random();

            Console.WriteLine("Oyunuma hoşgeldiniz.");
        basadon:
            Console.WriteLine("Canın: " + can + " Gücün: " + guc + " Xp: " + xp + "\n");
            Console.WriteLine("1-Fare (İlk seviye için önerilir)");
            Console.WriteLine("2-Goblin (Orta seviye için önerilir)");
            Console.WriteLine("3-Ejderha (Önerilmez)");
            Console.WriteLine("Hangi düşmanla dövüşeceğini seç (1-3)");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.Clear();
                    canavarcan = 20;
                farebas:
                    Console.WriteLine("Fareyle karşı karşıyasın\n");
                    Console.WriteLine("Canavarın canı:" + canavarcan + " Canavarın gücü: 10");
                    Console.WriteLine("Canın: " + can + " Gücün: " + guc + " Xp: " + xp + "\n");
                    Console.WriteLine("1-Saldır");
                    Console.WriteLine("2-Kaç");
                    Console.WriteLine("Ne yapacaksın");
                    secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            Console.Clear();
                            max = guc + (guc / 5);
                            min = guc / 10;
                            vurus = rastgele.Next(min, max);
                            canavarvurus = rastgele.Next(5 , 15);
                            Console.WriteLine(vurus + " hasar verdin");
                            Console.WriteLine(canavarvurus + " hasar aldın");
                            can -= canavarvurus;
                            canavarcan -= vurus;
                            if (can > 0 && canavarcan > 0)
                            {
                                goto farebas;
                            }
                            else if (canavarcan <= 0)
                            {
                                Console.WriteLine("Canavarı öldürdün ve 25 xp kazandın.");
                                xp += 25;
                                can = 100 + (xp / 2);
                                guc += 10;
                                canavarcan = 20;
                                goto basadon;
                            }
                            else if (can <= 0)
                            {
                                Console.WriteLine("Olsun.Tekrar dene.");
                                can = 100;
                                goto basadon;
                            }
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Birdahaki sefere daha iyi dövüş.");
                            goto basadon;
                    }
                    break;


                case "2":               //GOBLİNGOBLİNGOBLİNGOBLİNGOBLİNAQ
                    Console.Clear();
                    canavarcan = 400;
                goblinbas:
                    Console.WriteLine("Goblinle karşı karşıyasın\n");
                    Console.WriteLine("Canavarın canı:" + canavarcan + " Canavarın gücü: 50");
                    Console.WriteLine("Canın: " + can + " Gücün: " + guc + " Xp: " + xp + "\n");
                    Console.WriteLine("1-Saldır");
                    Console.WriteLine("2-Kaç");
                    Console.WriteLine("Ne yapacaksın");
                    secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            Console.Clear();
                            max = guc + (guc / 3);
                            min = guc / 4;
                            vurus = rastgele.Next(min, max);
                            canavarvurus = rastgele.Next(25, 75);
                            Console.WriteLine(vurus + " hasar verdin");
                            Console.WriteLine(canavarvurus + " hasar aldın");
                            can -= canavarvurus;
                            canavarcan -= vurus;
                            if (can > 0 && canavarcan > 0)
                            {
                                goto goblinbas;
                            }
                            else if (canavarcan <= 0)
                            {
                                Console.WriteLine("Canavarı öldürdün ve 250 xp kazandın.");
                                xp += 250;
                                can = 100 + (xp / 2);
                                guc += 10;
                                canavarcan = 400;
                                goto basadon;
                            }
                            else if (can <= 0)
                            {
                                Console.WriteLine("Olsun.Tekrar dene.");
                                can = 100;
                                goto basadon;
                            }
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Birdahaki sefere daha iyi dövüş.");
                            goto basadon;
                    }
                    break;


                case "3":               //EJDERYAEJDERYAEJDERYAEJDERYAAQ
                    Console.Clear();
                    canavarcan = 2500;
                ejderhabas:
                    Console.WriteLine("Goblinle karşı karşıyasın\n");
                    Console.WriteLine("Canavarın canı:" + canavarcan + " Canavarın gücü: 400");
                    Console.WriteLine("Canın: " + can + " Gücün: " + guc + " Xp: " + xp + "\n");
                    Console.WriteLine("1-Saldır");
                    Console.WriteLine("2-Kaç");
                    Console.WriteLine("Ne yapacaksın");
                    secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            Console.Clear();
                            max = guc + (guc / 2);
                            min = guc / 3;
                            vurus = rastgele.Next(min, max);
                            canavarvurus = rastgele.Next(200, 500);
                            Console.WriteLine(vurus + " hasar verdin");
                            Console.WriteLine(canavarvurus + " hasar aldın");
                            can -= canavarvurus;
                            canavarcan -= vurus;
                            if (can > 0 && canavarcan > 0)
                            {
                                goto ejderhabas;
                            }
                            else if (canavarcan <= 0)
                            {
                                Console.WriteLine("Ejderhayı öldürdün! Artık özgürsün.");
                                Console.ReadKey();
                            }
                            else if (can <= 0)
                            {
                                Console.WriteLine("Olsun.Tekrar dene.");
                                can = 100;
                                goto basadon;
                            }
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Birdahaki sefere daha iyi dövüş.");
                            goto basadon;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
