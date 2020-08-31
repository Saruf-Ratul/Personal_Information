namespace Personal_Information
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.motherNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllInformationButton = new System.Windows.Forms.Button();
            this.showNameButton = new System.Windows.Forms.Button();
            this.showAddressButton = new System.Windows.Forms.Button();
            this.parentNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(293, 105);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(259, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Nane";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(293, 141);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(259, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mother\'s Name";
            // 
            // motherNameTextBox
            // 
            this.motherNameTextBox.Location = new System.Drawing.Point(293, 176);
            this.motherNameTextBox.Name = "motherNameTextBox";
            this.motherNameTextBox.Size = new System.Drawing.Size(259, 20);
            this.motherNameTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Father\'s name";
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(293, 212);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(259, 20);
            this.fatherNameTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(293, 250);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(259, 86);
            this.addressTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(293, 343);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllInformationButton
            // 
            this.showAllInformationButton.Location = new System.Drawing.Point(374, 343);
            this.showAllInformationButton.Name = "showAllInformationButton";
            this.showAllInformationButton.Size = new System.Drawing.Size(178, 23);
            this.showAllInformationButton.TabIndex = 3;
            this.showAllInformationButton.Text = "Show All Information";
            this.showAllInformationButton.UseVisualStyleBackColor = true;
            this.showAllInformationButton.Click += new System.EventHandler(this.showAllInformationButton_Click);
            // 
            // showNameButton
            // 
            this.showNameButton.Location = new System.Drawing.Point(293, 372);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(57, 23);
            this.showNameButton.TabIndex = 3;
            this.showNameButton.Text = "Name";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // showAddressButton
            // 
            this.showAddressButton.Location = new System.Drawing.Point(477, 372);
            this.showAddressButton.Name = "showAddressButton";
            this.showAddressButton.Size = new System.Drawing.Size(75, 23);
            this.showAddressButton.TabIndex = 3;
            this.showAddressButton.Text = "Address";
            this.showAddressButton.UseVisualStyleBackColor = true;
            this.showAddressButton.Click += new System.EventHandler(this.showAddressButton_Click);
            // 
            // parentNameButton
            // 
            this.parentNameButton.Location = new System.Drawing.Point(356, 372);
            this.parentNameButton.Name = "parentNameButton";
            this.parentNameButton.Size = new System.Drawing.Size(115, 23);
            this.parentNameButton.TabIndex = 3;
            this.parentNameButton.Text = "Parent\'s Name";
            this.parentNameButton.UseVisualStyleBackColor = true;
            this.parentNameButton.Click += new System.EventHandler(this.parentNameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 509);
            this.Controls.Add(this.showAllInformationButton);
            this.Controls.Add(this.parentNameButton);
            this.Controls.Add(this.showAddressButton);
            this.Controls.Add(this.showNameButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox motherNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllInformationButton;
        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Button showAddressButton;
        private System.Windows.Forms.Button parentNameButton;
    }
}

