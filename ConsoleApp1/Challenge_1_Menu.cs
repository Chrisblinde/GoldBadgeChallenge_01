using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Challenge_1_Menu
    {
        public Challenge_1_Menu() { }
        public Challenge_1_Menu(int mealNumber, string mealName, string description, string listOfIngredients, decimal price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            ListOfIngredients = listOfIngredients;
            Price = price;
        }

        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string ListOfIngredients { get; set; }
        public decimal Price { get; set; }

   // public ListOfIngredients Ingredients { get; set; }
    
    }
        /*public enum ListOfIngredients
        {
         Spices = 1,
         liquids,
         Proteins
         }*/



   } 










/*
A meal number, so customers can say "I'll have the #5"
A meal name
A description
A list of ingredients,
A price*/