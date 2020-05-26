namespace BankView
{
    partial class FormCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWorkerFIO = new System.Windows.Forms.ComboBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.comboBoxClientFIO = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Услуга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО клинта";
            // 
            // comboBoxWorkerFIO
            // 
            this.comboBoxWorkerFIO.FormattingEnabled = true;
            this.comboBoxWorkerFIO.Location = new System.Drawing.Point(177, 25);
            this.comboBoxWorkerFIO.Name = "comboBoxWorkerFIO";
            this.comboBoxWorkerFIO.Size = new System.Drawing.Size(503, 24);
            this.comboBoxWorkerFIO.TabIndex = 3;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(177, 69);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(503, 24);
            this.comboBoxService.TabIndex = 4;
            // 
            // comboBoxClientFIO
            // 
            this.comboBoxClientFIO.FormattingEnabled = true;
            this.comboBoxClientFIO.Location = new System.Drawing.Point(177, 112);
            this.comboBoxClientFIO.Name = "comboBoxClientFIO";
            this.comboBoxClientFIO.Size = new System.Drawing.Size(503, 24);
            this.comboBoxClientFIO.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(294, 156);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(171, 41);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(505, 156);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 41);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 213);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxClientFIO);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.comboBoxWorkerFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreate";
            this.Text = "FormCreate";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWorkerFIO;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.ComboBox comboBoxClientFIO;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}