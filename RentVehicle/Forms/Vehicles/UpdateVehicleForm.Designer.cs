namespace RentVehicle.Forms.ForAdmin.Vehicles
{
    partial class UpdateVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVehicleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rentalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lifeTimeTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.modelTypeComboBox);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rentalPriceTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lifeTimeTextBox);
            this.panel1.Location = new System.Drawing.Point(34, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 241);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 18);
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
            this.modelTypeComboBox.Location = new System.Drawing.Point(24, 42);
            this.modelTypeComboBox.Name = "modelTypeComboBox";
            this.modelTypeComboBox.Size = new System.Drawing.Size(221, 30);
            this.modelTypeComboBox.TabIndex = 22;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(77, 199);
            this.updateButton.Margin = new System.Windows.Forms.Padding(38, 10, 10, 10);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 30);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 132);
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
            this.rentalPriceTextBox.Location = new System.Drawing.Point(24, 156);
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
            this.label5.Location = new System.Drawing.Point(24, 75);
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
            this.lifeTimeTextBox.Location = new System.Drawing.Point(24, 99);
            this.lifeTimeTextBox.MaxLength = 20;
            this.lifeTimeTextBox.Multiline = true;
            this.lifeTimeTextBox.Name = "lifeTimeTextBox";
            this.lifeTimeTextBox.Size = new System.Drawing.Size(221, 30);
            this.lifeTimeTextBox.TabIndex = 17;
            this.lifeTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(196)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(330, 266);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление ТС";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        public ComboBox modelTypeComboBox;
        private Button updateButton;
        private Label label6;
        public TextBox rentalPriceTextBox;
        private Label label5;
        public TextBox lifeTimeTextBox;
    }
}