using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Trendyol_Süper_Lig
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer mars = new SoundPlayer();
            Random rastgele = new Random();
            Console.WriteLine("***** Trendyol Süper Lig *****");
            Console.ReadLine();
            int fenerbahce, galatasaray, besiktas, trabzonspor, sayac;
            fenerbahce = 0;
            galatasaray = 0;
            besiktas = 0;
            trabzonspor = 0;
            sayac = 1;

            int fb1, fb2, fb3;
            int gs1, gs2, gs3;
            int bjk1, bjk2, bjk3;
            int ts1, ts2, ts3;

            int fbskor = 0;
            int gsskor = 0;
            int bjkskor = 0;
            int tsskor = 0;

            if (sayac == 1)
            {
                fb1 = rastgele.Next(0, 6);
                gs1 = rastgele.Next(0, 6);
                bjk1 = rastgele.Next(0, 6);
                ts1 = rastgele.Next(0, 6);
                Console.WriteLine("1. Hafta Skorları");
                Console.WriteLine("-----------------");
                Console.WriteLine("Fenerbahçe " + fb1 + "-" + gs1 + " Galatasaray");
                Console.WriteLine("Beşiktaş " + bjk1 + "-" + ts1 + " Trabzonspor");
                sayac++;

                if (fb1 > gs1)
                {
                    fenerbahce = fenerbahce + 3;
                }
                else if (gs1 > fb1)
                {
                    galatasaray = galatasaray + 3;
                }
                else
                {
                    fenerbahce++;
                    galatasaray++;
                }
                if (bjk1 > ts1)
                {
                    besiktas = besiktas + 3;
                }
                else if (ts1 > bjk1)
                {
                    trabzonspor = trabzonspor + 3;
                }
                else
                {
                    besiktas++;
                    trabzonspor++;
                }

                fbskor = fbskor + fb1;
                gsskor = gsskor + gs1;
                bjkskor = bjkskor + bjk1;
                tsskor = tsskor + ts1;

                Console.ReadLine();
            }
            
            if (sayac == 2)
            {
                fb2 = rastgele.Next(0, 6);
                gs2 = rastgele.Next(0, 6);
                bjk2 = rastgele.Next(0, 6);
                ts2 = rastgele.Next(0, 6);
                Console.WriteLine("2. Hafta Skorları");
                Console.WriteLine("-----------------");
                Console.WriteLine("Fenerbahçe " + fb2 + "-" + bjk2 + " Beşiktaş");
                Console.WriteLine("Galatasaray " + gs2 + "-" + ts2 + " Trabzonspor");
                sayac++;

                if (fb2 > bjk2)
                {
                    fenerbahce = fenerbahce + 3;
                }
                else if (bjk2 > fb2)
                {
                    besiktas = besiktas + 3;
                }
                else
                {
                    fenerbahce++;
                    besiktas++;
                }
                if (gs2 > ts2)
                {
                    galatasaray = galatasaray + 3;
                }
                else if (ts2 > gs2)
                {
                    trabzonspor = trabzonspor + 3;
                }
                else
                {
                    trabzonspor++;
                    galatasaray++;
                }

                fbskor = fbskor + fb2;
                gsskor = gsskor + gs2;
                bjkskor = bjkskor + bjk2;
                tsskor = tsskor + ts2;

                Console.ReadLine();
            }

            if (sayac == 3)
            {
                fb3 = rastgele.Next(0, 6);
                gs3 = rastgele.Next(0, 6);
                bjk3 = rastgele.Next(0, 6);
                ts3 = rastgele.Next(0, 6);
                Console.WriteLine("3. Hafta Skorları");
                Console.WriteLine("-----------------");
                Console.WriteLine("Fenerbahçe " + fb3 + "-" + ts3 + " Trabzonspor");
                Console.WriteLine("Galatasaray " + gs3 + "-" + bjk3 + " Beşiktaş");
                sayac++;

                if (fb3 > ts3)
                {
                    fenerbahce = fenerbahce + 3;
                }
                else if (ts3 > fb3)
                {
                    trabzonspor = trabzonspor + 3;
                }
                else
                {
                    fenerbahce++;
                    trabzonspor++;
                }
                if (gs3 > bjk3)
                {
                    galatasaray = galatasaray + 3;
                }
                else if (bjk3 > gs3)
                {
                    besiktas = besiktas + 3;
                }
                else
                {
                    besiktas++;
                    galatasaray++;
                }

                fbskor = fbskor + fb3;
                gsskor = gsskor + gs3;
                bjkskor = bjkskor + bjk3;
                tsskor = tsskor + ts3;

                Console.ReadLine();
            }

            if (sayac == 4)
            {
                Console.WriteLine("Puan Tablosu");
                Console.WriteLine("-------------");
                Console.WriteLine("Fenerbahçe: " + fenerbahce);
                Console.WriteLine("Galatasaray: " + galatasaray);
                Console.WriteLine("Beşiktaş: " + besiktas);
                Console.WriteLine("Trabzonspor: " + trabzonspor);
                sayac++;
                Console.ReadLine();
            }
            
            if (sayac == 5)
            {
                if (fenerbahce > galatasaray && fenerbahce > besiktas && fenerbahce > trabzonspor)
                {
                    Console.WriteLine("ŞAMPİYON FENERBAHÇE!!!");
                    string fbmars;
                    fbmars = @"C:\Users\berka\Downloads\Fenerbahce-100-Yil-Marsi.wav";
                    mars.SoundLocation = fbmars;
                    mars.Play();
                }
                else if (galatasaray > fenerbahce && galatasaray > besiktas && galatasaray > trabzonspor)
                {
                    Console.WriteLine("ŞAMPİYON GALATASARAY!!!");
                    string gsmars;
                    gsmars = @"C:\Users\berka\Downloads\Galatasaray-Askin-Olayim-Icardi-80.wav";
                    mars.SoundLocation = gsmars;
                    mars.Play();
                }
                else if (besiktas > trabzonspor && besiktas > fenerbahce && besiktas > galatasaray)
                {
                    Console.WriteLine("ŞAMPİYON BEŞİKTAŞ!!!");
                    string bjkmars;
                    bjkmars = @"C:\Users\berka\Downloads\Besiktas-Gucune-Guc-Katmaya-Geldik.wav";
                    mars.SoundLocation = bjkmars;
                    mars.Play();
                }
                else if(trabzonspor > fenerbahce && trabzonspor > galatasaray && trabzonspor > besiktas)
                {
                    Console.WriteLine("ŞAMPİYON TRABZONSPOR!!!");
                    string tsmars;
                    tsmars = @"C:\Users\berka\Downloads\Yasin-Aydin-Trabzon-Kolbastisi-15.wav";
                    mars.SoundLocation = tsmars;
                    mars.Play();
                }
                else if (fenerbahce == galatasaray || fenerbahce == besiktas || fenerbahce == trabzonspor)
                {
                    if (fbskor > gsskor && fbskor > bjkskor && fbskor > tsskor)
                    {
                        Console.WriteLine("Averaj farkıyla ŞAMPİYON FENERBAHÇE!!!");
                        string fbmars;
                        fbmars = @"C:\Users\berka\Downloads\Fenerbahce-100-Yil-Marsi.wav";
                        mars.SoundLocation = fbmars;
                        mars.Play();
                    }
                }
                else if (galatasaray == fenerbahce || galatasaray == besiktas || galatasaray == trabzonspor)
                {
                    if (gsskor > fbskor && gsskor > bjkskor && gsskor > tsskor)
                    {
                        Console.WriteLine("Averaj farkıyla ŞAMPİYON GALATASARAY!!!");
                        string gsmars;
                        gsmars = @"C:\Users\berka\Downloads\Galatasaray-Askin-Olayim-Icardi-80.wav";
                        mars.SoundLocation = gsmars;
                        mars.Play();
                    }
                }
                else if (trabzonspor == galatasaray || trabzonspor == besiktas || trabzonspor == fenerbahce)
                {
                    if (tsskor > gsskor && tsskor > bjkskor && tsskor > fbskor)
                    {
                        Console.WriteLine("Averaj farkıyla ŞAMPİYON TRABZONSPOR!!!");
                        string tsmars;
                        tsmars = @"C:\Users\berka\Downloads\Yasin-Aydin-Trabzon-Kolbastisi-15.wav";
                        mars.SoundLocation = tsmars;
                        mars.Play();
                    }
                }
                else if (besiktas == fenerbahce || besiktas == galatasaray || besiktas == trabzonspor)
                {
                    if (bjkskor > fbskor && bjkskor > gsskor && bjkskor > tsskor)
                    {
                        Console.WriteLine("Averaj farkıyla ŞAMPİYON BEŞİKTAŞ!!!");
                        string bjkmars;
                        bjkmars = @"C:\Users\berka\Downloads\Besiktas-Gucune-Guc-Katmaya-Geldik.wav";
                        mars.SoundLocation = bjkmars;
                        mars.Play();
                    }
                }
            }
            Console.ReadKey();
        }

    }

    
}
