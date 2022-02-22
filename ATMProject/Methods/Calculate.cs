using ATMProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject.Methods
{
    public class Calculate
    {
        public void HereketeBasla(Money money)
        {
            string ad = "Istifadeci adinizi daxil edin :";
            Console.WriteLine(ad);
            ad = Console.ReadLine();


            Console.WriteLine("Sifrenizi daxil edin :");
            string sifre = Console.ReadLine();
            decimal parol = Convert.ToDecimal(sifre);

            if (parol == 12345)
            {
                Console.WriteLine("Hesabiniza daxil oldunuz.");
            }
            else
            {
            Evvele:
                Console.WriteLine("Sifrenizi dogru deyil.");
                Console.WriteLine("Sifrenizi yeniden daxil edin :");
                string kod = Console.ReadLine();
                decimal kod2 = Convert.ToDecimal(kod);

                if (kod2 == 12345)
                {
                    Console.WriteLine("Hesabiniza daxil oldunuz.");
                }
                else
                {
                    goto Evvele;
                }
            }
        }

        public void BalansiGoster(Money money)
        {
            Console.WriteLine("Balans:" + " " + money.Balans);
        }

        public void HesabDeyis(Money money)
        {
            Console.WriteLine("Hesabdan cixmaq isteyirsiniz?");
            string cavab = Console.ReadLine();
            string beli = "beli";
            string xeyr = "xeyr";
            if (cavab == beli)
            {
                Console.WriteLine("Hesabdan cixis edildi");
                Console.WriteLine("Basqa hesaba daxil olmaq isteyirsinizmi?");
                string netice = Console.ReadLine();

                if (netice == beli)
                {
                    string ad = "Istifadeci adinizi daxil edin :";
                    Console.WriteLine(ad);
                    ad = Console.ReadLine();


                    Console.WriteLine("Sifrenizi daxil edin :");
                    string sifre = Console.ReadLine();
                    decimal parol = Convert.ToDecimal(sifre);

                    if (parol == 12345)
                    {
                        Console.WriteLine(ad + " " + "adli hesaba daxil oldunuz");
                    }
                    else
                    {
                    Evvele:
                        Console.WriteLine("Sifrenizi dogru deyil.");
                        Console.WriteLine("Sifrenizi yeniden daxil edin :");
                        string kod = Console.ReadLine();
                        decimal kod2 = Convert.ToDecimal(kod);

                        if (kod2 == 12345)
                        {
                            Console.WriteLine(ad + " " + "adli hesaba daxil oldunuz");
                        }
                        else
                        {
                            goto Evvele;
                        }
                    }
                }
                else if (netice == xeyr)
                {
                    Console.WriteLine("Hesabdan cixis edildi.");
                }
            }
            else if (cavab == xeyr)
            {
                Console.WriteLine("Hesabdan cixis edilmedi.");
            }

        }

        public void PulKocurme(Money money)
        {

            Console.WriteLine("Pul kocurtmek isteyirsiniz?");
            string beli = "beli";
            string xeyr = "xeyr";
            string cavab = Console.ReadLine();
            if (cavab == beli)
            {

                Console.WriteLine("Kocurtmek istediyiniz hesabin 16 reqemli nomresini daxil edin : ");
                string sifre = Console.ReadLine();
                decimal nomre = Convert.ToDecimal(sifre);
                if (sifre.Length == 16)
                {

                    Console.WriteLine("Pul kocurmek istediyiniz meblegi daxil edin :");
                    string pul = Console.ReadLine();
                    decimal mebleg = Convert.ToDecimal(pul);
                    if (mebleg > money.Balans)
                    {
                        Console.WriteLine("Hesabinizda kifayet qeder pul yoxdur.");
                        Console.WriteLine("Hesabinizi artirmaq isteyirsiniz?");
                        string cavab2 = Console.ReadLine();
                        if (cavab2 == beli)
                        {
                            Console.WriteLine("Elave etmek istediyiniz meblegi daxil edin :");
                            string pul1 = Console.ReadLine();
                            decimal mebleg1 = Convert.ToDecimal(pul1);
                            decimal hesab = money.Balans + mebleg1;
                            money.Balans = hesab;
                            Console.WriteLine("Balansiniz : " + hesab + " " + "oldu");
                            Console.WriteLine("Emeliyyata davam etmek isteyirsiniz?");
                            string cavab3 = Console.ReadLine();
                            if (cavab3 == beli)
                            {
                                Console.WriteLine("Pul kocurmek istediyiniz meblegi daxil edin :");
                                string pul2 = Console.ReadLine();
                                decimal mebleg2 = Convert.ToDecimal(pul2);
                                Console.WriteLine("Kocurulme heyata kecirildi.");
                            }
                            else if (cavab3 == xeyr)
                            {
                                Console.WriteLine("Emeliyyat sona catdi .");
                            }
                        }
                        else if (cavab2 == xeyr)
                        {
                            Console.WriteLine("Emeliyyat sona catdi.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kocurulme heyata kecirildi.");
                    }
                }
                else
                {
                    Console.WriteLine("Nomre 16 reqemli olmalidir.");
                    Console.WriteLine("Kocurtmek istediyiniz hesabin 16 reqemli nomresini daxil edin : ");
                    string sifre2 = Console.ReadLine();
                    decimal nomre2 = Convert.ToDecimal(sifre2);
                }

            }
            else if(cavab == xeyr)
            {
                Console.WriteLine("Kocurulme heyata kecirilmedi.");
            }
        }
    }
}
