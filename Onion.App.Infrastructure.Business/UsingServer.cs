using System;
using System.Text.RegularExpressions;
using OnionApp.Domain.Core;
using System.Linq;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class UsingServer
    { }
    //{
    //    public void CheckAdversDate(Saver<O, S> save)
    //    {
    //       if(DateTime.Today.CompareTo(Saver<O, S>.ControlNewDay) <0)
    //            for (int i = 0; i < Saver<O, S>.Advlist.Count; i++)
    //            {
    //                DeleteAdvert<O, S>.DeleteAdvertAfterOneYear(Saver<O, S>.Advlist[i]);
    //            }                
    //    }
    //    public void ViewingAdvert()
    //    {
    //        Console.WriteLine("Apartment with 1 room withaut gas in Kharkiv for Rent");
    //        Advert<Apartment, Rieltor>[] chose = Saver<Apartment, Rieltor>.Advlist.Where(r => r.Obj.Rooms == 1 && r.Obj.Gas == false
    //        && r.Obj.City == "Kharkiv" && r.RentOrSeal == true).ToArray();
    //        foreach (Advert<Apartment, Rieltor> item in chose)
    //        {
    //            Console.WriteLine($"Address: {item.Obj.City}, Price {item.Price}, Price for one square meter: {item.PriceForMeter}");
    //        }            
    //    }
    //    public void CreateSeller()
    //    {
    //        Console.WriteLine("Enter your name and surname");
    //        string name = Console.ReadLine();
    //        string patternName = @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$";
    //        if (!Regex.IsMatch(name, patternName))
    //        {
    //            throw new Exception("Incorrect name");
    //        }
    //        bool nameExist = false;
    //        nameExist = Saver<O, S>.Slist.Any(n => n.Name == name); //Linq
    //        nameExist = Saver<O, S>.Rlist.Any(n => n.Name == name);
    //        if(nameExist)
    //        {
    //            throw new Exception("This name already exist");
    //        }  
    //        string patternEmail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
    //            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
    //        string email;
    //        while (true)
    //        {
    //            Console.WriteLine("Enter your email");
    //            email = Console.ReadLine();

    //            if (Regex.IsMatch(email, patternEmail, RegexOptions.IgnoreCase))
    //            {
    //                Console.WriteLine("Email confirm");
    //                break;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Incorrect email");
    //            }
    //        }
    //        Saver<O, S>.Slist.Add(new Seller(Saver<O, S>.IdList[typeof(Seller)]++, name, email, "qwerty", "0660000000", "AA1111"));//test
    //    }
    //    public void CreateAdvert(string name, string passport, bool rentOfSale)
    //    {            
    //        Seller[] selector = Saver<O, S>.Slist.Where(s => s.Name == name && s.Passport == passport).ToArray(); //Linq
    //        if (selector.Length == 1)
    //        {
    //            if (Saver<O, S>.Alist.Count > 0)
    //            {
    //                CreateObject();
    //                Advert<Apartment, Seller> adv = new Advert<Apartment, Seller>
    //                {
    //                    AdvertId = Saver<O, S>.IdList[typeof(Advert<O, S>)]++,
    //                    RentOrSeal = rentOfSale,
    //                    Obj = Saver<O, S>.Alist[Saver<O, S>.Alist.Count - 1],
    //                    Sel = selector[0],
    //                    FirstPrice = 25000.0M
    //                };
    //            }
    //        }
    //        else
    //        {
    //            Rieltor[] selector2 = Saver<O, S>.Rlist.Where(s => s.Name == name && s.Passport == passport).ToArray();
    //            if (selector2.Length == 1)
    //            {
    //                CreateObject();
    //                Advert<Apartment, Rieltor> adv = new Advert<Apartment, Rieltor>
    //                {
    //                    AdvertId = Saver<O, S>.IdList[typeof(Advert<O, S>)]++,
    //                    RentOrSeal = rentOfSale,
    //                    Obj = Saver<O, S>.Alist[Saver<O, S>.Alist.Count - 1],
    //                    Sel = selector2[0],
    //                    FirstPrice = 25000.0M
    //                };
    //            }
    //            else Console.WriteLine("Create account first");
    //        }  
    //    }        
    //    /*public static void CreateBuyer()
    //    {
    //        BuyerOrSeekerRieltor buy = new BuyerOrSeekerRieltor(IdSaver<O, S>.IdList[typeof(BuyerOrSeekerRieltor)]++, "Vanija", "Vanija@gmail.com", "0660000000");
    //    }*/
    //    /* public static void SearchRieltor(object buyer)
    //     {
    //         //if (buyer != null)
    //         // Search for Rieltors according to statistics
    //     }*/
    //    public void  CreateObject()
    //    {
    //        Console.WriteLine("Select type of property: ");
    //        char chose = Convert.ToChar(Console.ReadLine());
    //        if (chose == '1')
    //        {
    //            Plot obj = new Plot(true, true, true, true, Saver<O, S>.IdList[typeof(Plot)]++, "Kharkiv", "Pushkinskiia str. 1", "Good flat", ".jpg", 600.0);
                
    //        }
    //        else if (chose == '2')
    //        {
    //            House obj = new House(true, true, true, true, Saver<O, S>.IdList[typeof(House)]++, "Kharkiv", "Pushkinskiia str.", 120.0, "Good flat", ".jpg", 1200.0, 5, 12.0, false);
                
    //        }
    //        else if (chose == '3')
    //        {
    //            ParkingPlace obj = new ParkingPlace(true, true, true, true, Saver<O, S>.IdList[typeof(ParkingPlace)]++, "Kharkiv", "Pushkinskiia str.", 15.0, "Good flat", ".jpg", true);
               
    //        }
    //        else if (chose == '4')
    //        {
    //            Garage obj = new Garage(true, true, true, true, Saver<O, S>.IdList[typeof(Garage)]++, "Kharkiv", "Pushkinskiia str.", 20, "Good flat", ".jpg", true, true, true);
                
    //        }
    //        else if (chose == '5')
    //        {
    //            Apartment obj = new Apartment(true, true, true, true, Saver<O, S>.IdList[typeof(Apartment)]++, "Kharkiv", "Pushkinskiia str.", 80, "Good flat", ".jpg", 3, 8, false, 12.0);//test
    //            Saver<O, S>.Alist.Add(obj);
              
    //        }
    //        else if (chose == '6')
    //        {
    //            ManyLevelsApartment obj = new ManyLevelsApartment(true, true, true, true, Saver<O, S>.IdList[typeof(ManyLevelsApartment)]++, "Kharkiv", "Pushkinskiia str.", 150, "Good flat", ".jpg", 3, 8, false, 12.0, 2, true);
               
    //        }
    //        else if (chose == '7')
    //        {
    //            RoomInFlat obj = new RoomInFlat(true, true, true, true, Saver<O, S>.IdList[typeof(RoomInFlat)]++, "Kharkiv", "Pushkinskiia str.", 15.0, "Good flat", ".jpg", 9, 3);
              
    //        }
    //        else if (chose == '8')
    //        {
    //            RoomIndividual obj = new RoomIndividual(true, true, true, true, Saver<O, S>.IdList[typeof(RoomIndividual)]++, "Kharkiv", "Pushkinskiia str.", 15.0, "Good flat", ".jpg", 9, true, true);
               
    //        }
    //        else throw new Exception(" Wrong chose");  
    //    } 
    //    public void Confirm(int advertId, string sellerName, string parol)
    //    {
    //        for (int i = 0; i < Saver<O, S>.Advlist.Count; i++)
    //        {
    //            if (Saver<O, S>.Advlist[i].AdvertId == advertId && Saver<O, S>.Advlist[i].Sel.Name == sellerName
    //                && Saver<O, S>.Advlist[i].Sel.Parol == parol)
    //            {
    //                Saver<O, S>.Advlist[i].DateOfActual = DateTime.Now;
    //                Console.WriteLine($"Advert {advertId} confirm");
    //                break;
    //            }
    //        }
    //        Console.WriteLine("Wrong data");
    //    }
    //    public void EditPrice(int advertId, string sellerName, string parol, decimal newPrice)
    //    {
    //        for (int i = 0; i < Saver<O, S>.Advlist.Count; i++)
    //        {
    //            if (Saver<O, S>.Advlist[i].AdvertId == advertId && Saver<O, S>.Advlist[i].Sel.Name == sellerName
    //                && Saver<O, S>.Advlist[i].Sel.Parol == parol)
    //            {
    //                Saver<O, S>.Advlist[i].DateOfActual = DateTime.Now;
    //                Saver<O, S>.Advlist[i].Price = newPrice;
    //                Console.WriteLine($"Price changed and advert {advertId} confirm");
    //                break;
    //            }
    //        }
    //        Console.WriteLine("Wrong data");
    //    }
    //    public void DeleteAdvertObject(int advertId, string sellerName, string parol)
    //    {
    //        for (int i = 0; i < Saver<O, S>.Advlist.Count; i++)
    //        {
    //            if (Saver<O, S>.Advlist[i].AdvertId == advertId && Saver<O, S>.Advlist[i].Sel.Name == sellerName
    //                && Saver<O, S>.Advlist[i].Sel.Parol == parol)
    //            {
    //                Saver<O, S>.Advlist.RemoveAt(i);
    //                for (int k = 0; k < Saver<O, S>.Alist.Count; k++)
    //                {
    //                    if (Saver<O, S>.Alist[i].ObjectId == Saver<O, S>.Alist[k].ObjectId)
    //                    {
    //                        Saver<O, S>.Alist.RemoveAt(k);
    //                    }
    //                }
    //                Console.WriteLine("AdvertDelete");
    //                break;
    //            }
    //        }
    //        Console.WriteLine("Wrong data");
    //    }
    //    public void DeleteSellerRieltor(string userName, string userParol)
    //    {
    //        for (int i = 0; i < Saver<O, S>.Slist.Count; i++)
    //        {
    //            if (Saver<O, S>.Slist[i].Name == userName && Saver<O, S>.Slist[i].Parol == userParol)
    //            {
    //                Saver<O, S>.Slist.RemoveAt(i);
    //                Console.WriteLine($"User {userName} delete");
    //                break;
    //            }
    //        }
    //        for (int i = 0; i < Saver<O, S>.Rlist.Count; i++)
    //        {
    //            if (Saver<O, S>.Rlist[i].Name == userName && Saver<O, S>.Rlist[i].Parol == userParol)
    //            {
    //                Saver<O, S>.Rlist.RemoveAt(i);
    //                Console.WriteLine($"User {userName} delete");
    //                break;
    //            }
    //        }
    //        Console.WriteLine("Wrong data");
    //    }
        
   // }
    
}
