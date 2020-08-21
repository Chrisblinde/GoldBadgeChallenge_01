using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
   public class Challenge_1_Repo
    {
        private readonly List<Challenge_1_Menu> _menuDirectory = new List<Challenge_1_Menu>();

        public void AddMealToMenu(Challenge_1_Menu menuItem)
        {
            _menuDirectory.Add(menuItem);
        }

        public List<Challenge_1_Menu>GetMenu()
        {
            return _menuDirectory;
        }

        public Challenge_1_Menu GetMealByName(string mealName)
        {
            foreach(Challenge_1_Menu option in _menuDirectory)
            {
                if (option.MealName.ToLower() == mealName.ToLower())
                {
                    return option;
                }

            }
            return null;
        }

        public bool UpdateMenu(Challenge_1_Menu updatedMenu, string originalMenu)
        {
            foreach(Challenge_1_Menu option in _menuDirectory)
            {
                if(option.MealName.ToLower()  == originalMenu.ToLower())
                {
                    option.MealNumber = updatedMenu.MealNumber;
                    option.MealName = updatedMenu.MealName;
                    option.Description = updatedMenu.Description;
                    option.ListOfIngredients = updatedMenu.ListOfIngredients;
                    option.Price = updatedMenu.Price;

                    int itemIndex = _menuDirectory.IndexOf(option);
                    _menuDirectory[itemIndex] = updatedMenu;
                    return true;
                }
            }
            return false;
        }
   
        public bool RemoveMenuItem(Challenge_1_Menu menuItem)
        {
            bool wasRemoved = _menuDirectory.Remove(menuItem);
            return wasRemoved;
        }
        public bool DeleteMealByName(string mealName)
        {
            Challenge_1_Menu targetMeal = GetMealByName(mealName);
            return RemoveMenuItem(targetMeal);
        }

    
    
    }
}
