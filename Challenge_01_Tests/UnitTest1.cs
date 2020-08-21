using System;
using System.Collections.Generic;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_01_Tests
{
    [TestClass]
    public class MenuTests
    {
        private Challenge_1_Repo _repo;
        private Challenge_1_Menu _meal;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new Challenge_1_Repo();
            _meal = new Challenge_1_Menu(1, "Spaghetti", "Noods and Sauce", "tomatoes, wheat, water, garlic", 19.99m);
            _repo.AddMealToMenu(_meal);
        }
        [TestMethod]
        public void GetMenu_ShouldReturnCorrectMenu()
        {
            Challenge_1_Repo repo = new Challenge_1_Repo();
            Challenge_1_Menu meal = new Challenge_1_Menu();
            repo.AddMealToMenu(meal);
            List<Challenge_1_Menu> menu = repo.GetMenu();
            bool menuHasMeal = menu.Contains(meal);
            Assert.IsTrue(menuHasMeal);

        }
        
        [TestMethod]
        public void RemoveMenuItem_ShouldReturnTrue()
        {
            bool wasRemoved = _repo.RemoveMenuItem(_meal);
            Assert.IsTrue(wasRemoved);
        }

        [DataTestMethod]
        [DataRow("Spaghetti", true)]
        [DataRow("Steak", false)]
        public void DeleteMealByName_ShouldReturnCorrectBool(string name, bool expectedResult)
        {
            bool actualResult = _repo.DeleteMealByName(name);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
        

        

