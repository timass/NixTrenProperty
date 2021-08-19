using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core;

namespace OnionApp.Infrastructure.Data
{
   
        public static class SampleData
        {
            public static void Initialize(SellerContext context)
            {
                if (!context.Sellers.Any())
                {
                Seller sel1 = new Seller()
                {
                    Name = "Vania",
                    Email = "1@3",
                    Password = "qwerty",
                    Telephone = "123"
                };
                Seller sel2 = new Seller
                {
                    Name = "Oleg",
                    Email = "2@3",
                    Password = "qwerty",
                    Telephone = "1234",
                };
                Seller sel3 = new Seller
                {
                    Name = "Vitia",
                    Email = "3@3",
                    Password = "qwerty",
                    Telephone = "12345",
                };
                context.Sellers.AddRange(sel1, sel2, sel3);                
                    context.Statistics.AddRange(
                     new Statistic
                     {
                     AverageDifPrice = 15.6,
                     AverageTimeOfDeal = "7",
                     Sel = sel1
                     },
                     new Statistic
                     {
                         AverageDifPrice = 20.5,
                         AverageTimeOfDeal = "4",
                         Sel = sel2
                     },
                     new Statistic
                     {
                         AverageDifPrice = 171,
                         AverageTimeOfDeal = "6.5",
                         Sel = sel3
                     }

                );
                    context.SaveChanges();
                }

            }
        }
    
}
