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
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоВыполненнымУслугамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоКлиентамИИхСчетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчтеССотрудникамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБекапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.создатьБекапToolStripMenuItem,
            this.графикиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem});
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(371, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы банкрот";
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.графикиToolStripMenuItem.Text = "Графики";
            this.графикиToolStripMenuItem.Click += new System.EventHandler(this.графикиToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BankView.Properties.Resources.bank_ekv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Банк";
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
        private System.Windows.Forms.ToolStripMenuItem отчетПоВыполненнымУслугамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоКлиентамИИхСчетуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьБекапToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
    }
}