﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;
using Pizza.View.Form1View;

namespace Pizza
{
    public class Form1LoadDishesPresenters : ViewFormMenu
    {
        public Form1LoadDishesPresenters( FormMenu form1 ) : base( form1 ) { }

        public void LoadPizza()
        {
            AddDishesToListView( new ListPizza() );
        }

        public void LoadMainDish()
        {
            AddDishesToListView( new ListMainDishes() );
        }

        public void LoadSoups()
        {
            AddDishesToListView( new ListSoups() );
        }

        public void LoadDrinks()
        {
            AddDishesToListView( new ListDrinks() );
        }

        private void AddDishesToListView( IForm1Dishes loadList )
        {
            List<Dish> listDisch = loadList.GetDishes();
            form.ListViewDishes.Items.Clear();
            foreach (var disch in listDisch)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(disch.Name));
                lvi.SubItems.Add( disch.Price );
                form.ListViewDishes.Items.Add( lvi );
            }
        }

    }
}
