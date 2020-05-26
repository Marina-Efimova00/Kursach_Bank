namespace BankView
{
    partial class FormService
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
            this.buttonReady = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(750, 417);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(784, 28);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(196, 49);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать услугу";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonTakeOrderInWork
            // 
            this.buttonTakeOrderInWork.Location = new System.Drawing.Point(784, 110);
            this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
            this.buttonTakeOrderInWork.Size = new System.Drawing.Size(196, 49);
            this.buttonTakeOrderInWork.TabIndex = 2;
            this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
            this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
            // 
            // buttonReady
            // 
            this.buttonReady.Location = new System.Drawing.Point(784, 200);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(196, 49);
            this.buttonReady.TabIndex = 3;
            this.buttonReady.Text = "Готово";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 457);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.buttonTakeOrderInWork);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormService";
            this.Text = "FormService";
            this.Load += new System.EventHandler(this.FormService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonTakeOrderInWork;
        private System.Windows.Forms.Button buttonReady;
    }
}