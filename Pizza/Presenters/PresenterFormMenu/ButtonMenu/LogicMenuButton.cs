﻿using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Pizza
{
    public class LogicMenuButton : ILogic
    {
        private readonly Form1LoadSidesPresenter loadSidesToCheckedListBox;
        private readonly Form1LoadDishesPresenters loadDishesToListView;
        private readonly ButtonLoadMenu buttonMenu;

        public LogicMenuButton( FormMenu form1, ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
            loadSidesToCheckedListBox = new Form1LoadSidesPresenter( form1 );
            loadDishesToListView = new Form1LoadDishesPresenters( form1 );
        }

        public void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadCheckListBoxSideDishe( new ListSidesFactory( buttonMenu ) );
            loadDishesToListView.AddDishesToListView( new ListDishesFactory( buttonMenu ) );
        }
    }
}
