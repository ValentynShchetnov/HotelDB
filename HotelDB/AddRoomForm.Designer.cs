using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBHotel
{
    partial class AddRoomForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TVCheckbox = new CheckBox();
            FridgeCheckbox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ClearButton = new Button();
            ApplyButton = new Button();
            RoomNumber = new TextBox();
            SleepingPlaces = new TextBox();
            FloorNumber = new TextBox();
            Class = new TextBox();
            Price = new TextBox();
            SuspendLayout();
            // 
            // TVCheckbox
            // 
            TVCheckbox.AutoSize = true;
            TVCheckbox.Location = new Point(139, 163);
            TVCheckbox.Name = "TVCheckbox";
            TVCheckbox.Size = new Size(39, 19);
            TVCheckbox.TabIndex = 0;
            TVCheckbox.Text = "TV";
            TVCheckbox.UseVisualStyleBackColor = true;
            // 
            // FridgeCheckbox
            // 
            FridgeCheckbox.AutoSize = true;
            FridgeCheckbox.Location = new Point(139, 188);
            FridgeCheckbox.Name = "FridgeCheckbox";
            FridgeCheckbox.Size = new Size(59, 19);
            FridgeCheckbox.TabIndex = 1;
            FridgeCheckbox.Text = "Fridge";
            FridgeCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 7;
            label1.Text = "Number of rooms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "Sleeping places";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 79);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 9;
            label3.Text = "Floor number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 108);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 10;
            label4.Text = "Class";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 137);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 11;
            label5.Text = "Price";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(44, 236);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 12;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(139, 236);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(75, 23);
            ApplyButton.TabIndex = 13;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // RoomNumber
            // 
            RoomNumber.Location = new Point(139, 18);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(100, 23);
            RoomNumber.TabIndex = 15;
            // 
            // SleepingPlaces
            // 
            SleepingPlaces.Location = new Point(139, 47);
            SleepingPlaces.Name = "SleepingPlaces";
            SleepingPlaces.Size = new Size(100, 23);
            SleepingPlaces.TabIndex = 16;
            // 
            // FloorNumber
            // 
            FloorNumber.Location = new Point(139, 76);
            FloorNumber.Name = "FloorNumber";
            FloorNumber.Size = new Size(100, 23);
            FloorNumber.TabIndex = 17;
            // 
            // Class
            // 
            Class.Location = new Point(139, 105);
            Class.Name = "Class";
            Class.Size = new Size(100, 23);
            Class.TabIndex = 18;
            // 
            // Price
            // 
            Price.Location = new Point(139, 134);
            Price.Name = "Price";
            Price.Size = new Size(100, 23);
            Price.TabIndex = 19;
            // 
            // AddRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 269);
            Controls.Add(Price);
            Controls.Add(Class);
            Controls.Add(FloorNumber);
            Controls.Add(SleepingPlaces);
            Controls.Add(RoomNumber);
            Controls.Add(ApplyButton);
            Controls.Add(ClearButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FridgeCheckbox);
            Controls.Add(TVCheckbox);
            Name = "AddRoomForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox TVCheckbox;
        private CheckBox FridgeCheckbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button ClearButton;
        private Button ApplyButton;
        private TextBox RoomNumber;
        private TextBox SleepingPlaces;
        private TextBox FloorNumber;
        private TextBox Class;
        private TextBox Price;
    }
}
