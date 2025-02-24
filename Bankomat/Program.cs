using System;
using System.Reflection.Metadata.Ecma335;

namespace Bankomat
{
    class Program
    {
       static void Main(string[] args)

       {       
            // Bankomat => kartani balansi, parol, 
            // bankomatta qanchapul bor, pul chiqarvolish, 
            //tranzaksiyalar tarixi istoriya, chek chiqarish,
            //ovoz qoshsa boladi, parolni to'g'rilikga 
            //tekshirish, telfon raqamga sms habarnoma ulash.

            int bmablag = 10000000, kmablag = 1000000, kod = 1111;
            Console.WriteLine("Salom Xush kelibsiz!");
            Console.WriteLine("  Tilni tanlang: ");
            Console.WriteLine("1.UZB ");
            Console.WriteLine("2.RUS ");
            Console.WriteLine("3.ENG ");
            int k=int.Parse(Console.ReadLine());
            
            switch(k)
            {
                case 1:
                    
                        Console.Clear();
                        Console.WriteLine("Karta Parolini kiriting: ");
                        int key = int.Parse(Console.ReadLine());

                        while (true)
                        {

                            if (key == kod)
                            {


                                Console.Clear();
                                Console.WriteLine("    MENYU");
                                Console.WriteLine("1. Balansni tekshirish.");
                                Console.WriteLine("2. Mobil aloqa tulovlari.");
                                Console.WriteLine("3. Kommunal to'lovlar.");
                                Console.WriteLine("4. Naqd pul yechish.");
                                Console.WriteLine("5. Sms xabarnoma ulash.");
                            }
                            else
                            {
                                Console.Write("Parol xato qaytadan urinib ko'ring!!!");
                            return;
                            }
                        
                          int menyu = int.Parse(Console.ReadLine());
                          switch (menyu)
                          {
                            case 1:
                                Console.Clear();
                                Console.Write($"Sizning balansingiz-> {kmablag}");
                                Console.WriteLine("Boshqa amal bajarasizmi");
                                Console.WriteLine("1. Ha");
                                Console.WriteLine("2. Yo'q");
                                int amal = int.Parse(Console.ReadLine());
                                if (amal == 1)
                                {
                                    continue;
                                }
                                else if (amal == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Tashrifingiz uchun raxmat!");
                                    return ;
                                }
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("1.UCELL");
                                Console.WriteLine("2.BEELINE");
                                Console.WriteLine("3.UMS");
                                Console.WriteLine("4.HUMANS");
                                int mobile = int.Parse(Console.ReadLine());
                                switch (mobile)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.Write("Telefon raqam kiriting-> +998 ");
                                        int tel=int.Parse(Console.ReadLine());
                                        if (tel/100000000==9 && tel%100000000/10000000==4 ||
                                            tel/100000000==9 && tel%100000000/10000000==3 ||
                                            tel/100000000==5 && tel%100000000/10000000==0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Summa kiriting!");
                                            int tsum=int.Parse(Console.ReadLine());
                                            if (tsum < kmablag)
                                            {
                                                Console.WriteLine("Muvaffaqqiyatli bajarildi!");
                                                Console.WriteLine("Qoldiq summa-> {0}",kmablag-tsum,bmablag-tsum);
                                                Console.WriteLine("Boshqa amal bajarasizmi?");
                                                Console.WriteLine("1. Ha");
                                                Console.WriteLine("2. Yo'q");
                                                int amal1 = int.Parse(Console.ReadLine());
                                                if (amal1 == 1)
                                                {
                                                    continue;
                                                }
                                                else if (amal1 == 2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Tashrifingiz uchun raxmat!");
                                                    return;
                                                }
                                            }else if(tsum>kmablag)
                                            {
                                                Console.WriteLine("Kartada yetarli mablag' yo'q!!!");
                                                Console.WriteLine("1. Orqaga qaytish!");
                                                Console.WriteLine("2. Chiqish!");
                                                int back=int.Parse(Console.ReadLine());
                                                if (back == 1)
                                                    continue;
                                                else
                                                    return;
                                               
                                            }else if(tsum>bmablag)
                                            {
                                                Console.WriteLine("Yetarli mablag' yo'q!!");
                                                Console.WriteLine("1. Orqaga qaytish!");
                                                Console.WriteLine("2. Chiqish!");
                                                int back = int.Parse(Console.ReadLine());
                                                if (back == 1)
                                                    continue;
                                                else
                                                    return;
                                            }

                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Telefon raqam xato!!!/n" +
                                                "Qaytadan urinib ko'ring.");
                                            Console.WriteLine("0. Orqaga.");
                                            int back = int.Parse(Console.ReadLine());
                                            if (back == 0)
                                                continue;
                                        }
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.Write("Telefon raqam kiriting-> +998 ");
                                        int tel1 = int.Parse(Console.ReadLine());
                                        if (tel1 / 100000000 == 9 && tel1 % 100000000 / 10000000 == 0 ||
                                            tel1 / 100000000 == 9 && tel1 % 100000000 / 10000000 == 1)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Summa kiriting!");
                                            int tsum = int.Parse(Console.ReadLine());
                                            if (tsum < kmablag)
                                            {
                                                Console.WriteLine("Muvaffaqqiyatli bajarildi!");
                                                Console.WriteLine("Qoldiq summa-> {0}", kmablag - tsum, bmablag - tsum);
                                                Console.WriteLine("Boshqa amal bajarasizmi?");
                                                Console.WriteLine("1. Ha");
                                                Console.WriteLine("2. Yo'q");
                                                int amal1 = int.Parse(Console.ReadLine());
                                                if (amal1 == 1)
                                                {
                                                    continue;
                                                }
                                                else if (amal1 == 2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Tashrifingiz uchun raxmat!");
                                                    return;
                                                }
                                            }
                                            else if (tsum > kmablag)
                                            {
                                                Console.WriteLine("Kartada yetarli mablag' yo'q!!!");
                                                Console.WriteLine("1. Orqaga qaytish!");
                                                Console.WriteLine("2. Chiqish!");
                                                int back = int.Parse(Console.ReadLine());
                                                if (back == 1)
                                                    continue;
                                                else
                                                    return;

                                            }
                                            else if (tsum > bmablag)
                                            {
                                                Console.WriteLine("Yetarli mablag' yo'q!!");
                                                Console.WriteLine("1. Orqaga qaytish!");
                                                Console.WriteLine("2. Chiqish!");
                                                int back = int.Parse(Console.ReadLine());
                                                if (back == 1)
                                                    continue;
                                                else
                                                    return;
                                            }

                                        }
                                        else
                                        {
                                            Console.Clear ();
                                            Console.WriteLine("Telefon raqam xato!!!/n" +
                                                "Qaytadan urinib ko'ring.");
                                            Console.WriteLine("0. Orqaga.");
                                            int  back=int.Parse(Console.ReadLine());
                                            if(back==0)
                                                continue;
                                        }
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.Write("Telefon raqam kiriting-> +998 ");
                                        int tel2 = int.Parse(Console.ReadLine());
                                        if (tel2 / 100000000 == 9 && tel2 % 100000000 / 10000000 == 7 ||
                                            tel2 / 100000000 == 8 && tel2 % 100000000 / 10000000 == 8)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Summa kiriting!");
                                            int tsum = int.Parse(Console.ReadLine());
                                            if (tsum < kmablag)
                                            {
                                                Console.WriteLine("Muvaffaqqiyatli bajarildi!");
                                                Console.WriteLine("Qoldiq summa-> {0}", kmablag - tsum, bmablag - tsum);
                                                Console.WriteLine("Boshqa amal bajarasizmi?");
                                                Console.WriteLine("1. Ha");
                                                Console.WriteLine("2. Yo'q");
                                                int amal1 = int.Parse(Console.ReadLine());
                                                if (amal1 == 1)
                                                {
                                                    continue;
                                                }
                                                else if (amal1 == 2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Tashrifingiz uchun raxmat!");
                                                    return;
                                                }
                                            }
                                            else if (tsum > kmablag)
                                            {
                                                Console.WriteLine("Kartada yetarli mablag' yo'q!!!");
                                                Console.WriteLine("1. Orqaga qaytish!");
                                                Console.WriteLine("2. Chiqish!");
                                                int back = int.Parse(Console.ReadLine());
                                                if (back == 1)
                                                    continue;
                                                else
                                                    return;

                                            }
                                            else if (tsum > bmablag)
                                            {
                                                Console.WriteLine("Yetarli mablag' yo'q!!");
                                                Console.WriteLine("1. Orqaga qaytish!");
                                                Console.WriteLine("2. Chiqish!");
                                                int back = int.Parse(Console.ReadLine());
                                                if (back == 1)
                                                    continue;
                                                else
                                                    return;
                                            }

                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Telefon raqam xato!!!/n" +
                                                "Qaytadan urinib ko'ring.");
                                            Console.WriteLine("0. Orqaga.");
                                            int back = int.Parse(Console.ReadLine());
                                            if (back == 0)
                                                continue;
                                        }
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.Write("Telefon raqam kiriting-> +998 ");
                                        int tel3 = int.Parse(Console.ReadLine());
                                        if (tel3 / 100000000 == 3 && tel3 % 100000000 / 10000000 == 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Summa kiriting!");
                                            int tsum = int.Parse(Console.ReadLine());
                                            if (tsum < kmablag)
                                            {
                                                Console.WriteLine("Muvaffaqqiyatli bajarildi!");
                                                Console.WriteLine("Qoldiq summa-> {0}", kmablag - tsum, bmablag - tsum);
                                                Console.WriteLine("Boshqa amal bajarasizmi?");
                                                Console.WriteLine("1. Ha");
                                                Console.WriteLine("2. Yo'q");
                                                int amal1 = int.Parse(Console.ReadLine());
                                                if (amal1 == 1)
                                                {
                                                    continue;
                                                }
                                                else if (amal1 == 2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Tashrifingiz uchun raxmat!");
                                                    return;
                                                }
                                            }
                                            else if (tsum > kmablag)
                                            {
                                                Console.WriteLine("Kartada yetarli mablag' yo'q!!!");
                                                Console.WriteLine("1. Orqaga qaytish!");
                                                Console.WriteLine("2. Chiqish!");
                                                int back = int.Parse(Console.ReadLine());
                                                if (back == 1)
                                                    continue;
                                                else
                                                    return;

                                            }
                                            else if (tsum > bmablag)
                                            {
                                                Console.WriteLine("Yetarli mablag' yo'q!!");
                                                Console.WriteLine("1. Orqaga qaytish!");
                                                Console.WriteLine("2. Chiqish!");
                                                int back = int.Parse(Console.ReadLine());
                                                if (back == 1)
                                                    continue;
                                                else
                                                    return;
                                            }

                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Telefon raqam xato!!!/n" +
                                                "Qaytadan urinib ko'ring.");
                                            Console.WriteLine("0. Orqaga.");
                                            int back = int.Parse(Console.ReadLine());
                                            if (back == 0)
                                                continue;
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("Kommunal To'lovlar!");
                                Console.WriteLine("1. Suv taminoti");
                                Console.WriteLine("2. Gaz taminoti");
                                Console.WriteLine("3. Elektr energiyasi");
                                break;
                            case 4:
                                Console.WriteLine("1. 50 000");
                                Console.WriteLine("2. 100 000");
                                Console.WriteLine("3. 150 000");
                                Console.WriteLine("4. 200 000");
                                Console.WriteLine("5. 300 000");
                                Console.WriteLine("6. Boshqa summa");
                                int summ = int.Parse(Console.ReadLine());
                                switch (summ)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Pulni olishingiz mumkin!");
                                        Console.WriteLine("Kartadagi qoldiq summa-> {0}", kmablag - 50000);
                                        Console.WriteLine("Boshqa amal bajarasizmi?");
                                        Console.WriteLine("1. Ha");
                                        Console.WriteLine("2. Yo'q");
                                        int amal1 = int.Parse(Console.ReadLine());
                                        if (amal1 == 1)
                                        {
                                            continue;
                                        }
                                        else if (amal1 == 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tashrifingiz uchun raxmat!");
                                            return;
                                        }
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("Pulni olishingiz mumkin!");
                                        Console.WriteLine("Kartadagi qoldiq summa-> {0}", kmablag - 100000);
                                        Console.WriteLine("Boshqa amal bajarasizmi");
                                        Console.WriteLine("1. Ha");
                                   
                                        int amal2 = int.Parse(Console.ReadLine());
                                        if (amal2 == 1)
                                        {
                                            continue;
                                        }
                                        else if (amal2 == 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tashrifingiz uchun raxmat!");
                                            return;
                                        }
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("Pulni olishingiz mumkin!");
                                        Console.WriteLine("Kartadagi qoldiq summa-> {0}", kmablag - 150000);
                                        Console.WriteLine("Boshqa amal bajarasizmi?");
                                        Console.WriteLine("1. Ha");
                                        Console.WriteLine("2. Yo'q");
                                        int amal3 = int.Parse(Console.ReadLine());
                                        if (amal3 == 1) 
                                        {
                                            continue;
                                        }else
                                         {
                                            Console.Clear();
                                            Console.WriteLine("Tashrifingiz uchun raxmat!");
                                            return;
                                         }
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("Pulni olishingiz mumkin!");
                                        Console.WriteLine("Kartadagi qoldiq summa-> {0}", kmablag - 200000);
                                        Console.WriteLine("Boshqa amal bajarasizmi?");
                                        Console.WriteLine("1. Ha");
                                        Console.WriteLine("2. Yo'q");
                                        int amal4 = int.Parse(Console.ReadLine());
                                        if (amal4 == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tashrifingiz uchun raxmat!");
                                            return;
                                        }
                                        break;
                                    case 5:
                                        Console.Clear();
                                        Console.WriteLine("Pulni olishingiz mumkin!");
                                        Console.WriteLine("Kartadagi qoldiq summa-> {0}", kmablag - 300000);
                                        Console.WriteLine("Boshqa amal bajarasizmi?");
                                        Console.WriteLine("1. Ha");
                                        Console.WriteLine("2. Yo'q");
                                        int amal5 = int.Parse(Console.ReadLine());
                                        if (amal5 == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tashrifingiz uchun raxmat!");
                                            return;
                                        }
                                        break;
                                    case 6:
                                        Console.Clear();
                                        Console.Write("Summa kiriting: ");
                                        int boshqa = int.Parse(Console.ReadLine());
                                        if (boshqa < kmablag && boshqa < bmablag)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Pulni olishingiz mumkin!");
                                            Console.WriteLine("Kartadagi qoldiq summa-> {0}", kmablag - boshqa);
                                            Console.WriteLine("Boshqa amal bajarasizmi?");
                                            Console.WriteLine("1. Ha");
                                            Console.WriteLine("2. Yo'q");
                                            int amal6 = int.Parse(Console.ReadLine());
                                            if (amal6 == 1)
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Tashrifingiz uchun raxmat!");
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Pul yetarli emas!!!");
                                            Console.WriteLine("Boshqa amal bajarasizmi?");
                                            Console.WriteLine("1. Ha");
                                            Console.WriteLine("2. Yo'q");
                                            int amal7 = int.Parse(Console.ReadLine());
                                            if (amal7 == 1)
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Tashrifingiz uchun raxmat!");
                                                return;
                                            }
                                        }
                                            break;
                                }
                                break;
                            case 5:
                                Console.Clear();
                                Console.Write("Telefon raqam kiriting!!!" + " +998 ");
                                string tel0 = Console.ReadLine();
                                if (tel0.Length == 9 && tel0.StartsWith("9"))
                                {
                                    string kod1 = tel0.Substring(0, 2);
                                    if (kod1 == "90" || kod1 == "91" || kod1 == "93" || kod1 == "94" || kod1 == "95" || kod1 == "97" || kod1 == "98" || kod1 == "33")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Kod sms tarzda jo'natildi, kiriting!");
                                        Random random = new Random();
                                        int[] sms = new int[5];
                                        for (int i = 0; i < sms.Length; i++)
                                        {
                                            sms[i] = random.Next(1000, 10000);
                                            Console.WriteLine("SMS keldi!-> " + sms[i]);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Telefon raqam xato!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Telefon raqam noto'g'ri formatda!");
                                    Console.WriteLine("Chopildiz !!!");
                                }
                                break;

                          }

                        }
                break;
                        case 2:
                    break;
                    
                        
                    

                    break;
                        case 3:
                            break;
            }
            

       }
        
    }
}

