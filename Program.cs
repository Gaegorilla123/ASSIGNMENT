//==========================================================
// Student Number : S10273066B
// Student Name : [Your Name]
// Partner Name : [Partner Name]
//==========================================================

using System;
using System.Collections.Generic;

namespace S10273066B_PRG2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load restaurants from CSV
            List<Restaurant> restaurants =
                DataLoader.LoadRestaurants("restaurants.csv");

            // Load food items and assign them to restaurants
            DataLoader.LoadFoodItems("fooditems - Copy.csv", restaurants);


        }
    }
}
