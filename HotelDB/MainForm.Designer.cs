using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBHotel
{
    partial class MainForm
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            AddCustomerButton = new Button();
            EditRoomButton = new Button();
            AddRoomButton = new Button();
            OccupiedCheckbox = new CheckBox();
            FindButton = new Button();
            label4 = new Label();
            FridgeCheckbox = new CheckBox();
            TVCheckbox = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Number = new Label();
            CostBox = new TextBox();
            ClassBox = new TextBox();
            SleepingPlaces = new TextBox();
            RoomNumbers = new TextBox();
            Customers = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 426);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(488, 426);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Customers);
            panel2.Controls.Add(AddCustomerButton);
            panel2.Controls.Add(EditRoomButton);
            panel2.Controls.Add(AddRoomButton);
            panel2.Controls.Add(OccupiedCheckbox);
            panel2.Controls.Add(FindButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(FridgeCheckbox);
            panel2.Controls.Add(TVCheckbox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Number);
            panel2.Controls.Add(CostBox);
            panel2.Controls.Add(ClassBox);
            panel2.Controls.Add(SleepingPlaces);
            panel2.Controls.Add(RoomNumbers);
            panel2.Location = new Point(506, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 426);
            panel2.TabIndex = 1;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Location = new Point(177, 367);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(95, 23);
            AddCustomerButton.TabIndex = 16;
            AddCustomerButton.Text = "AddCustomer";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // EditRoomButton
            // 
            EditRoomButton.Location = new Point(96, 367);
            EditRoomButton.Name = "EditRoomButton";
            EditRoomButton.Size = new Size(75, 23);
            EditRoomButton.TabIndex = 15;
            EditRoomButton.Text = "EditRoom";
            EditRoomButton.UseVisualStyleBackColor = true;
            EditRoomButton.Click += EditRoomButton_Click;
            // 
            // AddRoomButton
            // 
            AddRoomButton.Location = new Point(15, 367);
            AddRoomButton.Name = "AddRoomButton";
            AddRoomButton.Size = new Size(75, 23);
            AddRoomButton.TabIndex = 14;
            AddRoomButton.Text = "AddRoom";
            AddRoomButton.UseVisualStyleBackColor = true;
            AddRoomButton.Click += AddRoomButton_Click;
            // 
            // OccupiedCheckbox
            // 
            OccupiedCheckbox.AutoSize = true;
            OccupiedCheckbox.Location = new Point(152, 292);
            OccupiedCheckbox.Name = "OccupiedCheckbox";
            OccupiedCheckbox.Size = new Size(100, 19);
            OccupiedCheckbox.TabIndex = 13;
            OccupiedCheckbox.Text = "Not Occupied";
            OccupiedCheckbox.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(63, 333);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(148, 28);
            FindButton.TabIndex = 12;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            label4.Location = new Point(116, 14);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 11;
            label4.Text = "Filters";
            // 
            // FridgeCheckbox
            // 
            FridgeCheckbox.AutoSize = true;
            FridgeCheckbox.Location = new Point(152, 256);
            FridgeCheckbox.Name = "FridgeCheckbox";
            FridgeCheckbox.Size = new Size(59, 19);
            FridgeCheckbox.TabIndex = 10;
            FridgeCheckbox.Text = "Fridge";
            FridgeCheckbox.UseVisualStyleBackColor = true;
            // 
            // TVCheckbox
            // 
            TVCheckbox.AutoSize = true;
            TVCheckbox.Location = new Point(152, 222);
            TVCheckbox.Name = "TVCheckbox";
            TVCheckbox.Size = new Size(39, 19);
            TVCheckbox.TabIndex = 9;
            TVCheckbox.Text = "TV";
            TVCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 184);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Cost limit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 144);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 7;
            label2.Text = "Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 106);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 6;
            label1.Text = "Sleeping places";
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Location = new Point(31, 66);
            Number.Name = "Number";
            Number.Size = new Size(84, 15);
            Number.TabIndex = 5;
            Number.Text = "Room number";
            // 
            // CostBox
            // 
            CostBox.Location = new Point(152, 181);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(100, 23);
            CostBox.TabIndex = 3;
            // 
            // ClassBox
            // 
            ClassBox.Location = new Point(152, 141);
            ClassBox.Name = "ClassBox";
            ClassBox.Size = new Size(100, 23);
            ClassBox.TabIndex = 2;
            // 
            // SleepingPlaces
            // 
            SleepingPlaces.Location = new Point(152, 103);
            SleepingPlaces.Name = "SleepingPlaces";
            SleepingPlaces.Size = new Size(100, 23);
            SleepingPlaces.TabIndex = 1;
            // 
            // RoomNumbers
            // 
            RoomNumbers.Location = new Point(152, 63);
            RoomNumbers.Name = "RoomNumbers";
            RoomNumbers.Size = new Size(100, 23);
            RoomNumbers.TabIndex = 0;
            // 
            // Customers
            // 
            Customers.Location = new Point(96, 396);
            Customers.Name = "Customers";
            Customers.Size = new Size(75, 23);
            Customers.TabIndex = 17;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            Customers.Click += Customers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox RoomNumbers;
        private Label label1;
        private Label Number;
        private TextBox CostBox;
        private TextBox ClassBox;
        private TextBox SleepingPlaces;
        private Label label2;
        private Label label3;
        private CheckBox TVCheckbox;
        private CheckBox FridgeCheckbox;
        private Button FindButton;
        private Label label4;
        private DataGridView dataGridView1;
        private CheckBox OccupiedCheckbox;
        private Button AddRoomButton;
        private Button EditRoomButton;
        private Button AddCustomerButton;
        private Button Customers;
    }
}