namespace RentVehicle.Forms.ForAdmin.Contracts
{
    partial class AddContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContractForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientsComboBox = new System.Windows.Forms.ComboBox();
            this.employeesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.finalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.clientsComboBox);
            this.panel1.Controls.Add(this.employeesComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.finalPriceTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.serialNumberTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 309);
            this.panel1.TabIndex = 15;
            // 
            // clientsComboBox
            // 
            this.clientsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.clientsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientsComboBox.ForeColor = System.Drawing.Color.White;
            this.clientsComboBox.IntegralHeight = false;
            this.clientsComboBox.ItemHeight = 22;
            this.clientsComboBox.Location = new System.Drawing.Point(24, 99);
            this.clientsComboBox.Name = "clientsComboBox";
            this.clientsComboBox.Size = new System.Drawing.Size(265, 30);
            this.clientsComboBox.TabIndex = 25;
            // 
            // employeesComboBox
            // 
            this.employeesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.employeesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeesComboBox.ForeColor = System.Drawing.Color.White;
            this.employeesComboBox.Location = new System.Drawing.Point(24, 42);
            this.employeesComboBox.Name = "employeesComboBox";
            this.employeesComboBox.Size = new System.Drawing.Size(265, 30);
            this.employeesComboBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Итоговая Цена";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(96, 256);
            this.addButton.Margin = new System.Windows.Forms.Padding(38, 10, 10, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 30);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // finalPriceTextBox
            // 
            this.finalPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.finalPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalPriceTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalPriceTextBox.ForeColor = System.Drawing.Color.White;
            this.finalPriceTextBox.Location = new System.Drawing.Point(24, 213);
            this.finalPriceTextBox.MaxLength = 20;
            this.finalPriceTextBox.Multiline = true;
            this.finalPriceTextBox.Name = "finalPriceTextBox";
            this.finalPriceTextBox.Size = new System.Drawing.Size(265, 30);
            this.finalPriceTextBox.TabIndex = 17;
            this.finalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalPriceTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.finalPriceTextBox_MouseClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Серийный Номер ТС";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.serialNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serialNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serialNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.serialNumberTextBox.Location = new System.Drawing.Point(24, 156);
            this.serialNumberTextBox.MaxLength = 20;
            this.serialNumberTextBox.Multiline = true;
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(265, 30);
            this.serialNumberTextBox.TabIndex = 15;
            this.serialNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Клиент";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сотрудник";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(377, 331);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление Контракта";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button addButton;
        private TextBox finalPriceTextBox;
        private Label label4;
        private TextBox serialNumberTextBox;
        private Label label3;
        private Label label2;
        private ComboBox employeesComboBox;
        private ComboBox clientsComboBox;
    }
}