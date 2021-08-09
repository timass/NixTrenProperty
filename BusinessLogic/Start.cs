using System;
using System.Text.Json;
using OnionApp.Domain.Core;
using System.IO;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class Start<O, S>
        where O : ObjectS
        where S : Seller
    {
        static async Task Main(string[] args)
        {

            Saver<Apartment, Seller> start;
            if (File.Exists(@"C:\NixTren\save.json")) //Loading
            {
                using (FileStream fs = new FileStream(@"C:\NixTren\save.json", FileMode.OpenOrCreate))
                {
                    start = await JsonSerializer.DeserializeAsync<Saver<Apartment, Seller>>(fs);
                }
            }
            else
            {
                start = new Saver<Apartment, Seller>();
            }
                      
            while (true)
            {
                UsingServer<O, S> us = new UsingServer<O, S>();
                Console.WriteLine(@"If you have not account and you wont to add advert,
                                    you must create it first");               
                Console.WriteLine(@"What you want to do? 
                                   0 - Create account; 1 - Create advert for rent appartment, 3 - View adverts, esc - any key");
                char choose = Convert.ToChar(Console.ReadLine());
                if (choose == '0')
                us.CreateSeller();               
                else if (choose == '1')
                {
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter passport");
                    string pass = Console.ReadLine();
                    Console.WriteLine("If sale choose '1', rent - '2'");
                    char ch  = Convert.ToChar(Console.ReadLine());
                    bool rentOrSale;
                    if (ch == '2') rentOrSale = true;
                    else if (ch == '1') rentOrSale = false;
                    else break;
                        us.CreateAdvert(name, pass, rentOrSale);
                }
                else if (choose == '2')               
                us.ViewingAdvert();
                else break;
            }
            string path = @"C:\NixTren\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            using (FileStream sr2 = new FileStream(@"C:\NixTren\save.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(sr2, start);
                Console.WriteLine("Data saved");
            }
        }
    }
}

