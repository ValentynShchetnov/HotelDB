namespace HotelDB
{
    partial class AddCustomer
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
            RemoveBox = new TextBox();
            RemoveButton = new Button();
            FirstNameBox = new TextBox();
            LastNameBox = new TextBox();
            RoomIDBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ApplyButton = new Button();
            PhoneNumberBox = new TextBox();
            EmailBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DaysBox = new TextBox();
            SuspendLayout();
            // 
            // RemoveBox
            // 
            RemoveBox.Location = new Point(360, 112);
            RemoveBox.Name = "RemoveBox";
            RemoveBox.Size = new Size(100, 23);
            RemoveBox.TabIndex = 0;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(351, 154);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(120, 23);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove Customer";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(152, 35);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(100, 23);
            FirstNameBox.TabIndex = 2;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(152, 86);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(100, 23);
            LastNameBox.TabIndex = 3;
            // 
            // RoomIDBox
            // 
            RoomIDBox.Location = new Point(152, 142);
            RoomIDBox.Name = "RoomIDBox";
            RoomIDBox.Size = new Size(100, 23);
            RoomIDBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 77);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 5;
            label1.Text = "Customer First and Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 35);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 86);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 142);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "RoomID";
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(166, 347);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(75, 23);
            ApplyButton.TabIndex = 9;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(152, 196);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(100, 23);
            PhoneNumberBox.TabIndex = 10;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(152, 250);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(100, 23);
            EmailBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 196);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 12;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 250);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 304);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 14;
            label7.Text = "Days";
            // 
            // DaysBox
            // 
            DaysBox.Location = new Point(152, 304);
            DaysBox.Name = "DaysBox";
            DaysBox.Size = new Size(100, 23);
            DaysBox.TabIndex = 15;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 382);
            Controls.Add(DaysBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EmailBox);
            Controls.Add(PhoneNumberBox);
            Controls.Add(ApplyButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RoomIDBox);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(RemoveButton);
            Controls.Add(RemoveBox);
            Name = "AddCustomer";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RemoveBox;
        private Button RemoveButton;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private TextBox RoomIDBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ApplyButton;
        private TextBox PhoneNumberBox;
        private TextBox EmailBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox DaysBox;
    }
}