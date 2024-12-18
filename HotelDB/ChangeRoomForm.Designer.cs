namespace DBHotel
{
    partial class ChangeRoomForm
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
            FindButton = new Button();
            ApplyButton = new Button();
            DeleteButton = new Button();
            NumberText = new TextBox();
            label1 = new Label();
            Fridge = new CheckBox();
            TV = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            CostBox = new TextBox();
            ClassBox = new TextBox();
            SleepingPlaces = new TextBox();
            Number = new Label();
            RoomNumbers = new TextBox();
            SuspendLayout();
            // 
            // FindButton
            // 
            FindButton.Location = new Point(22, 114);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(100, 30);
            FindButton.TabIndex = 0;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(53, 301);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(100, 30);
            ApplyButton.TabIndex = 1;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(289, 301);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(100, 30);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // NumberText
            // 
            NumberText.Location = new Point(22, 76);
            NumberText.Name = "NumberText";
            NumberText.Size = new Size(100, 23);
            NumberText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 4;
            label1.Text = "Number";
            // 
            // Fridge
            // 
            Fridge.AutoSize = true;
            Fridge.Location = new Point(298, 207);
            Fridge.Name = "Fridge";
            Fridge.Size = new Size(59, 19);
            Fridge.TabIndex = 21;
            Fridge.Text = "Fridge";
            Fridge.UseVisualStyleBackColor = true;
            // 
            // TV
            // 
            TV.AutoSize = true;
            TV.Location = new Point(298, 173);
            TV.Name = "TV";
            TV.Size = new Size(39, 19);
            TV.TabIndex = 20;
            TV.Text = "TV";
            TV.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 135);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 19;
            label3.Text = "Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 95);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 18;
            label2.Text = "Class";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 57);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 17;
            label4.Text = "Sleeping places";
            // 
            // CostBox
            // 
            CostBox.Location = new Point(298, 132);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(100, 23);
            CostBox.TabIndex = 16;
            // 
            // ClassBox
            // 
            ClassBox.Location = new Point(298, 92);
            ClassBox.Name = "ClassBox";
            ClassBox.Size = new Size(100, 23);
            ClassBox.TabIndex = 15;
            // 
            // SleepingPlaces
            // 
            SleepingPlaces.Location = new Point(298, 54);
            SleepingPlaces.Name = "SleepingPlaces";
            SleepingPlaces.Size = new Size(100, 23);
            SleepingPlaces.TabIndex = 14;
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Location = new Point(177, 19);
            Number.Name = "Number";
            Number.Size = new Size(84, 15);
            Number.TabIndex = 24;
            Number.Text = "Room number";
            // 
            // RoomNumbers
            // 
            RoomNumbers.Location = new Point(298, 16);
            RoomNumbers.Name = "RoomNumbers";
            RoomNumbers.Size = new Size(100, 23);
            RoomNumbers.TabIndex = 23;
            // 
            // ChangeRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 345);
            Controls.Add(Number);
            Controls.Add(RoomNumbers);
            Controls.Add(Fridge);
            Controls.Add(TV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(CostBox);
            Controls.Add(ClassBox);
            Controls.Add(SleepingPlaces);
            Controls.Add(label1);
            Controls.Add(NumberText);
            Controls.Add(DeleteButton);
            Controls.Add(ApplyButton);
            Controls.Add(FindButton);
            Name = "ChangeRoomForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FindButton;
        private Button ApplyButton;
        private Button DeleteButton;
        private TextBox NumberText;
        private Label label1;
        private CheckBox Fridge;
        private CheckBox TV;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox CostBox;
        private TextBox ClassBox;
        private TextBox SleepingPlaces;
        private Label Number;
        private TextBox RoomNumbers;
    }
}

