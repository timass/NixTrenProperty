﻿using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
    public class Apartment : Room
    {       
        public bool KitchenWithRoom { get; set; }       
        public double AreaOfKitchen { get; set; }        
        public Apartment(bool electricity, bool gas, bool plumbing, bool sewerage,
            int objectId, string city, string address, double area,
            string describe, string photos, int rooms,
            int floor, bool kitchenWithRoom, double areaOfKitchen)           
        {
            Electricity = electricity; Gas = gas; Plumbing = plumbing; Sewerage = sewerage;
            ObjectId = objectId; City = city; Address = address; Area = area; Describe = describe;
            Photos = photos; Rooms = rooms; Floor = floor; KitchenWithRoom = kitchenWithRoom; AreaOfKitchen = areaOfKitchen;
        }
    }    
}
