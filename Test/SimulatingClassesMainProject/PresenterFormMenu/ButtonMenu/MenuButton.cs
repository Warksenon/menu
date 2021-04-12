﻿using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Pizza
{
    public abstract class MenuButton : ILogic
    {
        protected Form1LoadSidesPresenter loadSidesToCheckedListBox;
        protected Form1LoadDishesPresenters loadDishesToListView;

        protected MenuButton( FormMenu form1 )
        {
            loadSidesToCheckedListBox = new Form1LoadSidesPresenter( form1 );
            loadDishesToListView = new Form1LoadDishesPresenters( form1 );
        }

        public abstract void LogicSettings();
    }
}
