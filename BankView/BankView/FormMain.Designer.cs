﻿namespace BankView
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоВыполненнымУслугамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоКлиентамИИхСчетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчтеССотрудникамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБекапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.расчтеССотрудникамиToolStripMenuItem,
            this.создатьБекапToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетПоВыполненнымУслугамToolStripMenuItem,
            this.отчетПоКлиентамИИхСчетуToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетПоВыполненнымУслугамToolStripMenuItem
            // 
            this.отчетПоВыполненнымУслугамToolStripMenuItem.Name = "отчетПоВыполненнымУслугамToolStripMenuItem";
            this.отчетПоВыполненнымУслугамToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.отчетПоВыполненнымУслугамToolStripMenuItem.Text = "Отчет по выполненным услугам";
            this.отчетПоВыполненнымУслугамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоВыполненнымУслугамToolStripMenuItem_Click);
            // 
            // отчетПоКлиентамИИхСчетуToolStripMenuItem
            // 
            this.отчетПоКлиентамИИхСчетуToolStripMenuItem.Name = "отчетПоКлиентамИИхСчетуToolStripMenuItem";
            this.отчетПоКлиентамИИхСчетуToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.отчетПоКлиентамИИхСчетуToolStripMenuItem.Text = "Отчет по клиентам и их счету";
            this.отчетПоКлиентамИИхСчетуToolStripMenuItem.Click += new System.EventHandler(this.отчетПоКлиентамИИхСчетуToolStripMenuItem_Click);
            // 
            // расчтеССотрудникамиToolStripMenuItem
            // 
            this.расчтеССотрудникамиToolStripMenuItem.Name = "расчтеССотрудникамиToolStripMenuItem";
            this.расчтеССотрудникамиToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.расчтеССотрудникамиToolStripMenuItem.Text = "Расчет с сотрудниками";
            this.расчтеССотрудникамиToolStripMenuItem.Click += new System.EventHandler(this.расчтеССотрудникамиToolStripMenuItem_Click);
            // 
            // создатьБекапToolStripMenuItem
            // 
            this.создатьБекапToolStripMenuItem.Name = "создатьБекапToolStripMenuItem";
            this.создатьБекапToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.создатьБекапToolStripMenuItem.Text = "Создать бекап";
            this.создатьБекапToolStripMenuItem.Click += new System.EventHandler(this.создатьБекапToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчтеССотрудникамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоВыполненнымУслугамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоКлиентамИИхСчетуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьБекапToolStripMenuItem;
    }
}