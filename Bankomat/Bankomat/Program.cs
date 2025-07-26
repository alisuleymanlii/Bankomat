using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Qeydiyyatdan kec");
Console.Write("Adinizi Girin: ");
string ad = Console.ReadLine();
Console.Write("Yasinizi Girin: ");
string sifre = Console.ReadLine();

Console.WriteLine("Qeydiyyatdan kecdin!");
Console.WriteLine("Giris ele!");

int girisdeneme = 3;
while (girisdeneme > 0)
{
    Console.Write("Adinizi Girin: ");
    string adgiris = Console.ReadLine();
    Console.Write("Yasinizi Girin: ");
    string sifregiris = Console.ReadLine();


    if (ad == adgiris && sifre == sifregiris)
    {
        Console.WriteLine("Ugurla giris etdiniz!");
        girisbasladi();
        break;
    }
    else
    {
        girisdeneme--;
        Console.WriteLine("Ad veya Sifre sehvdir!");
        Console.WriteLine("Qalan Sansiniz " + girisdeneme);
    }

    if (girisdeneme == 0)
    {
        Console.WriteLine("Sansiniz qalmadi");
        break;
    }

    static void girisbasladi()
    {
        int secme = 0;
        int balans = 0;
        do
        {
            Console.WriteLine("------------------");
            Console.WriteLine("1-Balans\n2-Daxil Et\n3-Cixart\n4-Cikis");
            Console.WriteLine("------------------");
            secme = Convert.ToInt32(Console.ReadLine());
            if (secme == 1)
            {
                Console.WriteLine("Kartinizdaki pul miqdari: " + balans);
            }
            else if (secme == 2)
            {
                Console.Write("Daxil etmek istediyiniz miktar: ");
                int pul = Convert.ToInt32(Console.ReadLine());
                balans = balans + pul;
                Console.WriteLine("Kartinizdaki pul miqdari: " + balans);
            }
            else if (secme == 3)
            {
                Console.Write("Cixartmaq istediyiniz miktar: ");
                int pul = Convert.ToInt32(Console.ReadLine());
                if (balans >= pul)
                {
                    balans = balans - pul;
                }
                else
                {
                    Console.WriteLine("Kartinizda bu qeder pul yoxdur!");
                }

                Console.WriteLine("Kartinizdaki pul miqdari: " + balans);
            }
            else if (secme == 4)
            {
                Console.WriteLine("Ugurla cixis etdiniz!");
                break;
            }

        } while (true);

    }



}

