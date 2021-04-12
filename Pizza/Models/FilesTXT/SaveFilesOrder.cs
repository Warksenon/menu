﻿using System;

using Pizza.Presenters;

namespace Pizza.Models.FilesTXT
{
    internal class SaveFilesOrder : Files, IAddOrder
    {
        private readonly Order order;

        public SaveFilesOrder( Order order )
        {
            this.order = order;
        }

        private void Save()
        {
            try
            {
                LoadHistoryToListOrder();
                listOrder.Add( order );
                SaveFilesHistoryOrder saveList = new SaveFilesHistoryOrder(listOrder);
                saveList.SaveHistoryOrders();
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save( Convert.ToString( ex ), "Save" );
            }
        }

        private void LoadHistoryToListOrder()
        {
            LoadingFilesTxt load = new LoadingFilesTxt();
            listOrder = load.LoadHistory();
        }

        public void AddOrder()
        {
            Save();
        }
    }
}
