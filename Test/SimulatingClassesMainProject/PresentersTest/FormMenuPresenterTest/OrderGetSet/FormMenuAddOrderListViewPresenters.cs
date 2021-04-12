﻿using System.Collections.Generic;
using System.Windows.Forms;

using Pizza.Presenters.PresenterFormMenu.GetDishesAndSideDishForm1;
using Pizza.Presenters.PresenterFormMenu.OrderGetSet;

namespace Pizza.Presenters
{
    internal class FormMenuAddOrderListViewPresenters : Form1ListViewOrder, ILogic
    {
        private readonly Form1ListDishes lvDishes;
        private readonly Form1SidesDish chblSides;

        public FormMenuAddOrderListViewPresenters( FormMenu form1 ) : base( form1 )
        {
            lvDishes = new Form1ListDishes( form1 );
            chblSides = new Form1SidesDish( form1 );
        }


        public void LogicSettings()
        {
            AddOrderToListView();
        }

        private void AddOrderToListView()
        {
            List<Dish> listDishes = lvDishes.GetListSelektedDishes();
            List<string> listSides = chblSides.GetListCheckedSides();
            string allSidesToGether = AddAllSides(listSides);

            foreach (var dish in listDishes)
            {
                ListViewItem lvi;
                if (HelpFinding.CheckStringIsEmpty( allSidesToGether ))
                {
                    lvi = new ListViewItem( dish.Name );
                    lvi.SubItems.Add( allSidesToGether );
                    lvi.SubItems.Add( dish.Price );
                }
                else
                {
                    string priceAll = AddPriceDisheAndSide(listDishes, listSides);
                    lvi = new ListViewItem( dish.Name + " - " + dish.Price );
                    lvi.SubItems.Add( allSidesToGether );
                    lvi.SubItems.Add( priceAll );
                }

                form.ListViewOrder.Items.Add( lvi );
            }
        }

        private string AddAllSides( List<string> listSides )
        {
            string allSidesToGether = "";
            for (int i = 0; i < listSides.Count; i++)
            {
                allSidesToGether += listSides [i];
                if (i == listSides.Count)
                {
                    allSidesToGether += ".";
                }
                else
                {
                    allSidesToGether += ",";
                }
            }

            return allSidesToGether;
        }

        private string AddPriceDisheAndSide( List<Dish> listDishes, List<string> listSides )
        {
            double priceSides = 0;
            double price;

            foreach (var side in listSides)
            {
                string textPrice = side;
                price = FindPrice( textPrice );
                priceSides += price;
            }

            double priceDish = FindPrice(listDishes[0].Price);
            double priceAll = priceDish + priceSides;
            return priceAll + " zł";
        }
    }
}
