﻿namespace IvanAgencyViewAdmin
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.турыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПутешествийWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cписокПутешествийExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправкаПисемКлиентуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.турыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.клиентыToolStripMenuItem.Text = "Заказчики";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // турыToolStripMenuItem
            // 
            this.турыToolStripMenuItem.Name = "турыToolStripMenuItem";
            this.турыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.турыToolStripMenuItem.Text = "Туры";
            this.турыToolStripMenuItem.Click += new System.EventHandler(this.турыToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПутешествийWordToolStripMenuItem,
            this.cписокПутешествийExcelToolStripMenuItem,
            this.отправкаПисемКлиентуToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // списокПутешествийWordToolStripMenuItem
            // 
            this.списокПутешествийWordToolStripMenuItem.Name = "списокПутешествийWordToolStripMenuItem";
            this.списокПутешествийWordToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.списокПутешествийWordToolStripMenuItem.Text = "Список путешествий Word";
            this.списокПутешествийWordToolStripMenuItem.Click += new System.EventHandler(this.списокПутешествийWordToolStripMenuItem_Click);
            // 
            // cписокПутешествийExcelToolStripMenuItem
            // 
            this.cписокПутешествийExcelToolStripMenuItem.Name = "cписокПутешествийExcelToolStripMenuItem";
            this.cписокПутешествийExcelToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cписокПутешествийExcelToolStripMenuItem.Text = "Cписок путешествий Excel";
            this.cписокПутешествийExcelToolStripMenuItem.Click += new System.EventHandler(this.cписокПутешествийExcelToolStripMenuItem_Click);
            // 
            // отправкаПисемКлиентуToolStripMenuItem
            // 
            this.отправкаПисемКлиентуToolStripMenuItem.Name = "отправкаПисемКлиентуToolStripMenuItem";
            this.отправкаПисемКлиентуToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.отправкаПисемКлиентуToolStripMenuItem.Text = "Отправка писем клиенту";
            this.отправкаПисемКлиентуToolStripMenuItem.Click += new System.EventHandler(this.отправкаПисемКлиентуToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 242);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Туристическое агенство";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem турыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПутешествийWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cписокПутешествийExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправкаПисемКлиентуToolStripMenuItem;
    }
}
