﻿using Pizza.Presenters;

namespace Pizza
{
    class SaveHistory
    {
        public void SaveList(ISaveHistory save)
        {
            save.SaveHistoryOrders();
        }
    }
}