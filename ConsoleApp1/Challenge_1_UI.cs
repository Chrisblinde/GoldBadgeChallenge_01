using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Challenge_1_UI
    {
        private bool _isRunning = true;
        private readonly IConsole _console;
        private readonly Challenge_1_Repo _menuRepo = new Challenge_1_Repo();

        public Challenge_1_UI(IConsole console)
        {
            _console = console;
        }

        public void Start()
        {
            SeedMenu();
            RunMenu();
        }
        private void RunMenu()
        {
            while (_isRunning)
            {

                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }
        }

        private string GetMenuSelection()
        {
            _console.Clear();
            _console.WriteLine("Welcome To The Menu Manager!\n" +
                "Select Menu Item\n" +
                "1. Show All Menu Items\n" +
                "2. Create New Menu Items\n" +
                "3. Update Existing Menu Items\n" +
                "4. Remove Menu Items\n" +
                "5. Exit");
            string userInput = _console.ReadLine();
            return userInput;
        }
        private void OpenMenuItem(string userInput)
        {
            _console.Clear();
            switch (userInput)
            {
                case "1":
                    DisplayAllItems();
                    break;

                case "2":
                    CreateMenuItem();
                    break;
                case "3":
                    
                    break;
                case "4":
                    RemoveItem();
                    
                    break;
                case "5":
                    _isRunning = false;
                    return;
                 
                default:
                    return;
            }

            _console.WriteLine("Press any key to return to menu...");
            _console.ReadKey();
        }

        private void DisplayAllItems()
        {
            List<Challenge_1_Menu> listOfItems = _menuRepo.GetMenu();
            foreach (Challenge_1_Menu item in listOfItems)
            {
                DisplayItem(item);
            }
        }

        private void DisplayItem(Challenge_1_Menu item)
        {
            _console.WriteLine($"Meal #: {item.MealNumber}\n" +
                $"Name: {item.MealName}\n" +
                $"Description: {item.Description}\n" +
                $"Ingredients: {item.ListOfIngredients}\n" +
                $"Price: {item.Price}");
        }

        private void DisplayMealByName()
        {
            _console.WriteLine("Enter a Meal:");
            string mealName = _console.ReadLine();
            Challenge_1_Menu searchResult = _menuRepo.GetMealByName(mealName);
            if (searchResult != null)
            {
                DisplayItem(searchResult);
            }

            else
            {
                _console.WriteLine("Invalid Meal. Could not locate.");
            }
        }

        private void CreateMenuItem()
        {
            _console.WriteLine("Enter a number:");
            int mealNumber = int.Parse(Console.ReadLine());
            _console.WriteLine("Enter a name:");
            string mealName = _console.ReadLine();
            _console.WriteLine("Enter a description:");
            string description = _console.ReadLine();
            _console.WriteLine("Enter ingredients:");
            string listOfIngredients = _console.ReadLine();
            _console.WriteLine("Enter a price:");
            decimal price = decimal.Parse(_console.ReadLine());

            Challenge_1_Menu newMenuItem = new Challenge_1_Menu(mealNumber, mealName, description, listOfIngredients, price);
            _menuRepo.AddMealToMenu(newMenuItem);
        }

        private void SeedMenu()
        {
            Challenge_1_Menu spaghetti = new Challenge_1_Menu(1, "Spaghetti", "Noods and Sauce","tomatoes, wheat, water, garlic", 19.99m);
            Challenge_1_Menu steak = new Challenge_1_Menu(2, "Steak", "Cow", "Beef, mushrooms, potatoes, beef stock, butter, salt&pepper", 29.99m);
            _menuRepo.AddMealToMenu(spaghetti);
            _menuRepo.AddMealToMenu(steak);
        }

        private void RemoveItem()
        {
            _console.WriteLine("Enter meal name:");
            string mealName = _console.ReadLine();
            Challenge_1_Menu menuItem = _menuRepo.GetMealByName(mealName);
            if (mealName != null)
            {
                _menuRepo.DeleteMealByName(mealName);
            }   

        }

       
    }
}
     
                  
                   



