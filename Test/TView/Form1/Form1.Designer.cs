﻿using System;

namespace Test
{
    partial class Form1Test
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.lMenuInfo = new System.Windows.Forms.Label();
            this.bPizza = new System.Windows.Forms.Button();
            this.bMainDish = new System.Windows.Forms.Button();
            this.bSoups = new System.Windows.Forms.Button();
            this.textBoxQuantityDishes = new System.Windows.Forms.TextBox();
            this.bAddDish = new System.Windows.Forms.Button();
            this.bRemoveAllListBox = new System.Windows.Forms.Button();
            this.panelDania = new System.Windows.Forms.Panel();
            this.listViewDish = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chListBoxSideDishes = new System.Windows.Forms.CheckedListBox();
            this.bRemoveListBox = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.Danie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dodatki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cenal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lPrice = new System.Windows.Forms.Label();
            this.tComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bDrinks = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bOrder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelDania.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lMenuInfo
            // 
            this.lMenuInfo.AutoSize = true;
            this.lMenuInfo.Location = new System.Drawing.Point(11, 7);
            this.lMenuInfo.Name = "lMenuInfo";
            this.lMenuInfo.Size = new System.Drawing.Size(32, 13);
            this.lMenuInfo.TabIndex = 0;
            this.lMenuInfo.Text = "Pizza";
            // 
            // bPizza
            // 
            this.bPizza.Location = new System.Drawing.Point(5, 5);
            this.bPizza.Name = "bPizza";
            this.bPizza.Size = new System.Drawing.Size(123, 59);
            this.bPizza.TabIndex = 14;
            this.bPizza.Text = "Pizza";
            this.bPizza.UseVisualStyleBackColor = true;
       
            // 
            // bMainDish
            // 
            this.bMainDish.Location = new System.Drawing.Point(5, 70);
            this.bMainDish.Name = "bMainDish";
            this.bMainDish.Size = new System.Drawing.Size(123, 54);
            this.bMainDish.TabIndex = 15;
            this.bMainDish.Text = "Dania główne";
            this.bMainDish.UseVisualStyleBackColor = true;
      
            // 
            // bSoups
            // 
            this.bSoups.Location = new System.Drawing.Point(5, 130);
            this.bSoups.Name = "bSoups";
            this.bSoups.Size = new System.Drawing.Size(123, 58);
            this.bSoups.TabIndex = 16;
            this.bSoups.Text = "Zupy";
            this.bSoups.UseVisualStyleBackColor = true;
         
            // 
            // textBoxQuantityDishes
            // 
            this.textBoxQuantityDishes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuantityDishes.Location = new System.Drawing.Point(14, 201);
            this.textBoxQuantityDishes.Name = "textBoxQuantityDishes";
            this.textBoxQuantityDishes.Size = new System.Drawing.Size(75, 20);
            this.textBoxQuantityDishes.TabIndex = 17;
            // 
            // bAddDish
            // 
            this.bAddDish.Location = new System.Drawing.Point(95, 199);
            this.bAddDish.Name = "bAddDish";
            this.bAddDish.Size = new System.Drawing.Size(241, 22);
            this.bAddDish.TabIndex = 25;
            this.bAddDish.Text = "ok";
            this.bAddDish.UseVisualStyleBackColor = true;
    
            // 
            // bRemoveAllListBox
            // 
            this.bRemoveAllListBox.Location = new System.Drawing.Point(304, 232);
            this.bRemoveAllListBox.Name = "bRemoveAllListBox";
            this.bRemoveAllListBox.Size = new System.Drawing.Size(280, 28);
            this.bRemoveAllListBox.TabIndex = 34;
            this.bRemoveAllListBox.Text = "Usuń wszystko";
            this.bRemoveAllListBox.UseVisualStyleBackColor = true;
   
            // 
            // panelDania
            // 
            this.panelDania.Controls.Add(this.listViewDish);
            this.panelDania.Controls.Add(this.chListBoxSideDishes);
            this.panelDania.Controls.Add(this.bAddDish);
            this.panelDania.Controls.Add(this.textBoxQuantityDishes);
            this.panelDania.Controls.Add(this.lMenuInfo);
            this.panelDania.Location = new System.Drawing.Point(173, 0);
            this.panelDania.Name = "panelDania";
            this.panelDania.Size = new System.Drawing.Size(696, 246);
            this.panelDania.TabIndex = 35;
            // 
            // listViewDish
            // 
            this.listViewDish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDish.HideSelection = false;
            this.listViewDish.Location = new System.Drawing.Point(14, 33);
            this.listViewDish.Name = "listViewDish";
            this.listViewDish.Size = new System.Drawing.Size(322, 154);
            this.listViewDish.TabIndex = 34;
            this.listViewDish.UseCompatibleStateImageBehavior = false;
            this.listViewDish.View = System.Windows.Forms.View.Details;
      
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Danie";
            this.columnHeader1.Width = 205;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cena";
            this.columnHeader2.Width = 112;
            // 
            // chListBoxSideDishes
            // 
            this.chListBoxSideDishes.FormattingEnabled = true;
            this.chListBoxSideDishes.Location = new System.Drawing.Point(362, 33);
            this.chListBoxSideDishes.Name = "chListBoxSideDishes";
            this.chListBoxSideDishes.Size = new System.Drawing.Size(290, 154);
            this.chListBoxSideDishes.TabIndex = 33;
            // 
            // bRemoveListBox
            // 
            this.bRemoveListBox.Location = new System.Drawing.Point(17, 232);
            this.bRemoveListBox.Name = "bRemoveListBox";
            this.bRemoveListBox.Size = new System.Drawing.Size(280, 28);
            this.bRemoveListBox.TabIndex = 38;
            this.bRemoveListBox.Text = "Usuń";
            this.bRemoveListBox.UseVisualStyleBackColor = true;
        
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewOrder);
            this.panel3.Controls.Add(this.lPrice);
            this.panel3.Controls.Add(this.bRemoveListBox);
            this.panel3.Controls.Add(this.bRemoveAllListBox);
            this.panel3.Location = new System.Drawing.Point(266, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 282);
            this.panel3.TabIndex = 40;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Danie,
            this.Dodatki,
            this.Cenal});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(17, 28);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(567, 184);
            this.listViewOrder.TabIndex = 40;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
        
            // 
            // Danie
            // 
            this.Danie.Text = "Danie";
            this.Danie.Width = 187;
            // 
            // Dodatki
            // 
            this.Dodatki.Text = "Dodatki";
            this.Dodatki.Width = 223;
            // 
            // Cenal
            // 
            this.Cenal.Text = "Cena";
            this.Cenal.Width = 333;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(14, 12);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(53, 13);
            this.lPrice.TabIndex = 39;
            this.lPrice.Text = "Cena: 0zł";
            // 
            // tComments
            // 
            this.tComments.Location = new System.Drawing.Point(15, 40);
            this.tComments.Multiline = true;
            this.tComments.Name = "tComments";
            this.tComments.Size = new System.Drawing.Size(217, 174);
            this.tComments.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Uwagi do zmówienia";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tComments);
            this.panel4.Location = new System.Drawing.Point(12, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 236);
            this.panel4.TabIndex = 43;
            // 
            // bDrinks
            // 
            this.bDrinks.BackColor = System.Drawing.SystemColors.Control;
            this.bDrinks.Location = new System.Drawing.Point(5, 194);
            this.bDrinks.Name = "bDrinks";
            this.bDrinks.Size = new System.Drawing.Size(123, 53);
            this.bDrinks.TabIndex = 44;
            this.bDrinks.Text = "Napoje";
            this.bDrinks.UseVisualStyleBackColor = false;
          
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bDrinks);
            this.panel5.Controls.Add(this.bSoups);
            this.panel5.Controls.Add(this.bMainDish);
            this.panel5.Controls.Add(this.bPizza);
            this.panel5.Location = new System.Drawing.Point(12, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 259);
            this.panel5.TabIndex = 45;
            // 
            // bOrder
            // 
            this.bOrder.BackColor = System.Drawing.SystemColors.Control;
            this.bOrder.Location = new System.Drawing.Point(12, 540);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(857, 68);
            this.bOrder.TabIndex = 46;
            this.bOrder.Text = "Złóż zamówienie";
            this.bOrder.UseVisualStyleBackColor = false;
      
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressEmailToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // addressEmailToolStripMenuItem
            // 
  
            // 
         
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // backgroundWorker1
            // 

            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 619);
            this.Controls.Add(this.bOrder);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDania);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDania.ResumeLayout(false);
            this.panelDania.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        public System.Windows.Forms.Label lMenuInfo;
        public System.Windows.Forms.Button bPizza;
        public System.Windows.Forms.Button bMainDish;
        public System.Windows.Forms.Button bSoups;
        public System.Windows.Forms.TextBox textBoxQuantityDishes;
        public System.Windows.Forms.Button bAddDish;
        public System.Windows.Forms.Button bRemoveAllListBox;
        public System.Windows.Forms.Panel panelDania;
        public System.Windows.Forms.Button bRemoveListBox;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox tComments;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button bDrinks;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Button bOrder;
        public System.Windows.Forms.Label lPrice;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addressEmailToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        public System.Windows.Forms.ListView listViewOrder;
        public System.Windows.Forms.ColumnHeader Danie;
        public System.Windows.Forms.ColumnHeader Dodatki;
        public System.Windows.Forms.ColumnHeader Cenal;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ListView listViewDish;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.CheckedListBox chListBoxSideDishes;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

