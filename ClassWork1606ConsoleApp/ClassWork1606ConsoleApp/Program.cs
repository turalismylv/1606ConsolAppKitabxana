using System;

namespace ClassWork1606ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Libray libray = new Libray("Kitabxana");
            while (true)
            {
                Console.WriteLine("1.Kitabxanaya isci elave et 2.Kitabxanaya kitab elave et 3.Kitabxanadan isci sil 4.Kitabxanadan kitab sil");
               
                string numm = Console.ReadLine();
                bool isInt = int.TryParse(numm, out int menu);
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("iscinin adi");
                        string ename = Console.ReadLine();
                        Console.WriteLine("Iscin soyadi");
                        string esname = Console.ReadLine();
                        AGE:
                        Console.WriteLine("Iscinin yasi");
                        string eage = Console.ReadLine();
                        bool isAge = int.TryParse(eage, out int age);
                        if (!isAge)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa Duzgun daxil edin");
                            goto AGE;
                        }
                        Employe employe = new Employe(ename, esname, age);
                        libray.employes.Add(employe);
                        Console.WriteLine($"{ename} adli isci elave olundu ");
                        break;
                    case 2:
                        Console.WriteLine("Kitabin adi");
                        string kname = Console.ReadLine();
                        year:
                        Console.WriteLine("Kitabin ili");
                        string kyear = Console.ReadLine();
                        bool isYear = int.TryParse(kyear, out int year);
                        if (!isYear)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa Duzgun daxil edin");
                            goto year;
                           
                        }
                        Books book = new Books(kname, year);
                        libray.books.Add(book);
                        Console.WriteLine($"{kname} adli kitab elave olundu ");

                        break;
                    case 3:
                        foreach (var item in libray.employes)
                        {
                            Console.WriteLine($"ID--{item.Id}  AD--{item.Name}");
                        }
                        idd:
                        Console.WriteLine("Silmek istediyiniz iscinin ID qeyd edin");
                        string did = Console.ReadLine();
                        bool isid = int.TryParse(did, out int _id);
                        if (!isid)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa Duzgun daxil edin");
                            goto idd;
                        }
                        foreach (var item in libray.employes)
                        {
                            if (item.Id==_id)
                            {
                                libray.employes.Remove(item);
                                Console.WriteLine($"{item.Name} adli isci silindi");
                                break;
                            }
                        }
                        break;
                    case 4:
                        foreach (var item in libray.books)
                        {
                            Console.WriteLine($"id --{item.Id}  AD--{item.Name}");
                        }
                        iddd:
                        Console.WriteLine("Silmek istediyiniz kitabin ID qeyd edin");
                        string kid = Console.ReadLine();
                        bool isidk = int.TryParse(kid, out int __id);
                        if (!isidk)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa Duzgun daxil edin");
                            goto iddd;
                        }
                        foreach (var item in libray.books)
                        {
                            if (item.Id == __id)
                            {
                                libray.books.Remove(item);
                                Console.WriteLine($"{item.Name} adli kitab silindi");
                                break;
                            }
                        }

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
