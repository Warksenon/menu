﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using Pizza.Models.Menu;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Test.Menu.Dishes
{
    [TestClass]
    public class TestListSoups
    {
        [TestMethod]
        public void TestDishes()
        {
            IForm1Dishes list = new ListSoups();
            List<Dish> listPizza = list.GetDishes();

            Assert.AreEqual("Pomidorowa", listPizza[0].Name);
            Assert.AreEqual("12zł", listPizza[0].Price);

            Assert.AreEqual("Rosół", listPizza[1].Name);
            Assert.AreEqual("10zł", listPizza[1].Price);

        }
    }
}