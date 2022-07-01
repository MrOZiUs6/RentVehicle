namespace RentVehicle.Forms.ForAdmin.Vehicles
{
    partial class AddVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rentalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lifeTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.modelTypeComboBox);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rentalPriceTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lifeTimeTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.serialNumberTextBox);
            this.panel1.Location = new System.Drawing.Point(34, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 300);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Тип Модели";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelTypeComboBox
            // 
            this.modelTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.modelTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelTypeComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modelTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.modelTypeComboBox.Location = new System.Drawing.Point(24, 106);
            this.modelTypeComboBox.Name = "modelTypeComboBox";
            this.modelTypeComboBox.Size = new System.Drawing.Size(221, 30);
            this.modelTypeComboBox.TabIndex = 22;
            this.modelTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.modelTypeComboBox_SelectedIndexChanged);
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
            this.addButton.Location = new System.Drawing.Point(74, 263);
            this.addButton.Margin = new System.Windows.Forms.Padding(38, 10, 10, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 30);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Цена Аренды";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentalPriceTextBox
            // 
            this.rentalPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.rentalPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rentalPriceTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentalPriceTextBox.ForeColor = System.Drawing.Color.White;
            this.rentalPriceTextBox.Location = new System.Drawing.Point(24, 220);
            this.rentalPriceTextBox.MaxLength = 20;
            this.rentalPriceTextBox.Multiline = true;
            this.rentalPriceTextBox.Name = "rentalPriceTextBox";
            this.rentalPriceTextBox.Size = new System.Drawing.Size(221, 30);
            this.rentalPriceTextBox.TabIndex = 19;
            this.rentalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Срок Службы";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lifeTimeTextBox
            // 
            this.lifeTimeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.lifeTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lifeTimeTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lifeTimeTextBox.ForeColor = System.Drawing.Color.White;
            this.lifeTimeTextBox.Location = new System.Drawing.Point(24, 163);
            this.lifeTimeTextBox.MaxLength = 20;
            this.lifeTimeTextBox.Multiline = true;
            this.lifeTimeTextBox.Name = "lifeTimeTextBox";
            this.lifeTimeTextBox.Size = new System.Drawing.Size(221, 30);
            this.lifeTimeTextBox.TabIndex = 17;
            this.lifeTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Серийный Номер";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.serialNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serialNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serialNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.serialNumberTextBox.Location = new System.Drawing.Point(24, 49);
            this.serialNumberTextBox.Margin = new System.Windows.Forms.Padding(20, 20, 20, 3);
            this.serialNumberTextBox.MaxLength = 20;
            this.serialNumberTextBox.Multiline = true;
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(221, 30);
            this.serialNumberTextBox.TabIndex = 11;
            this.serialNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(326, 323);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление ТС";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox modelTypeComboBox;
        private Button addButton;
        private Label label6;
        private TextBox rentalPriceTextBox;
        private Label label5;
        private TextBox lifeTimeTextBox;
        private Label label2;
        private TextBox serialNumberTextBox;
    }
}