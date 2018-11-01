namespace AddressArray
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.namevlidLable = new System.Windows.Forms.Label();
            this.contactVlidLable = new System.Windows.Forms.Label();
            this.cityValidLable = new System.Windows.Forms.Label();
            this.countryVlidLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Country";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(228, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(228, 70);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactNoTextBox.TabIndex = 1;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Dhaka",
            "Colcata",
            "Koraci",
            "Sidny"});
            this.cityComboBox.Location = new System.Drawing.Point(228, 112);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 2;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Bangladesh",
            "India",
            "Pakistan",
            "Australiya"});
            this.countryComboBox.Location = new System.Drawing.Point(228, 166);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(121, 21);
            this.countryComboBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(96, 225);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(258, 225);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // namevlidLable
            // 
            this.namevlidLable.AutoSize = true;
            this.namevlidLable.Location = new System.Drawing.Point(228, 49);
            this.namevlidLable.Name = "namevlidLable";
            this.namevlidLable.Size = new System.Drawing.Size(0, 13);
            this.namevlidLable.TabIndex = 4;
            // 
            // contactVlidLable
            // 
            this.contactVlidLable.AutoSize = true;
            this.contactVlidLable.Location = new System.Drawing.Point(228, 93);
            this.contactVlidLable.Name = "contactVlidLable";
            this.contactVlidLable.Size = new System.Drawing.Size(0, 13);
            this.contactVlidLable.TabIndex = 4;
            // 
            // cityValidLable
            // 
            this.cityValidLable.AutoSize = true;
            this.cityValidLable.Location = new System.Drawing.Point(228, 136);
            this.cityValidLable.Name = "cityValidLable";
            this.cityValidLable.Size = new System.Drawing.Size(0, 13);
            this.cityValidLable.TabIndex = 4;
            // 
            // countryVlidLable
            // 
            this.countryVlidLable.AutoSize = true;
            this.countryVlidLable.Location = new System.Drawing.Point(225, 190);
            this.countryVlidLable.Name = "countryVlidLable";
            this.countryVlidLable.Size = new System.Drawing.Size(35, 13);
            this.countryVlidLable.TabIndex = 4;
            this.countryVlidLable.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 328);
            this.Controls.Add(this.countryVlidLable);
            this.Controls.Add(this.cityValidLable);
            this.Controls.Add(this.contactVlidLable);
            this.Controls.Add(this.namevlidLable);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.contactNoTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label namevlidLable;
        private System.Windows.Forms.Label contactVlidLable;
        private System.Windows.Forms.Label cityValidLable;
        private System.Windows.Forms.Label countryVlidLable;
    }
}

