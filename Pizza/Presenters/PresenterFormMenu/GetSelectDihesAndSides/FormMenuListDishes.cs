﻿using System.Collections.Generic;

namespace Pizza.Presenters.PresenterFormMenu.GetDishesAndSideDishForm1
{
    public class FormMenuListDishes : FormMenuQuantity
    {
        public FormMenuListDishes( FormMenu form ) : base( form ) { }

        public List<Dish> GetListSelektedDishes()
        {
            List<Dish> list = new List<Dish>();
            int numbersRepetitions = CheckNumberTextViewDishes();
            if (numbersRepetitions > 0)
            {
                int x = CheckListDishesSelectedItem();
                for (int i = 0; i < numbersRepetitions; i++)
                {
                    Dish dish = new Dish
                    {
                        Name = form.ListViewDishes.Items[x].SubItems[0].Text,
                        Price = form.ListViewDishes.Items[x].SubItems[1].Text
                    };
                    list.Add( dish );
                }
            }

            return list;
        }

        private int CheckListDishesSelectedItem()
        {
            return form.ListViewDishes.FocusedItem.Index;
        }

    }
}