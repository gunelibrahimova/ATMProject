using ATMProject.Methods;
using ATMProject.Models;

Calculate start = new Calculate();


Money money = new Money()
{
    Id = 1,
    Balans = 500M,
    Sifre = 12345
};

Evvele:
Console.WriteLine("1.Adinizi ve sifrenizi daxil edin.");
Console.WriteLine("2.Balansiniza baxin.");
Console.WriteLine("3.Hesab deyisdirin.");
Console.WriteLine("4.Pul kocurdun.");


string daxilEdilenReqem = Console.ReadLine();

switch (Convert.ToInt32(daxilEdilenReqem))
{
    case 1:
        start.HereketeBasla(money);
        goto Evvele;
        break;
    case 2:
        start.BalansiGoster(money);
        goto Evvele;
        break;
    case 3:
        start.HesabDeyis(money);
        goto Evvele;
        break;
    case 4:
        start.PulKocurme(money);
        goto Evvele;
        break;
}
