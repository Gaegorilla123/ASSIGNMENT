//==========================================================
// Student Number : S10273066B
// Student Name : [Your Name]
// Partner Name : [Partner Name]
//==========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10273066B_PRG2Assignment
{
    class Menu //MENU stores multiple FOODITEM objects, create a fooditem list to store fooditem objects
    {
        public string MenuId { get; set; }
        public string MenuName { get; set; }

        public List<FoodItem> FoodItemList { get; set; } = new List<FoodItem>(); 

        public void AddFoodItem(FoodItem foodItem)
        {
            FoodItemList.Add(foodItem);
        }

        public bool RemoveFoodItem(FoodItem foodItem)
        {
            return FoodItemList.Remove(foodItem);
        }

        public void DisplayFoodItems()
        {
            foreach (FoodItem obj in FoodItemList)
            {
                Console.WriteLine(obj);
            }
        }

        public override string ToString()
        {
            return $"Menu ID: {MenuId}\nMenu Name: {MenuName}";
        }

              // Constructor
        public Menu(string menuId, string menuName)
        {
            MenuId = menuId;
            MenuName = menuName;
        }
    }
}
