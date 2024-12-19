namespace HotelDB
{
    partial class Clients
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
            ClientsView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ClientsView).BeginInit();
            SuspendLayout();
            // 
            // ClientsView
            // 
            ClientsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientsView.Location = new Point(3, 12);
            ClientsView.Name = "ClientsView";
            ClientsView.Size = new Size(794, 426);
            ClientsView.TabIndex = 0;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClientsView);
            Name = "Clients";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ClientsView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ClientsView;
    }
}