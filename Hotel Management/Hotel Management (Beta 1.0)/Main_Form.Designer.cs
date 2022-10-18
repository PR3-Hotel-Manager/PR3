namespace Hotel_Management__Beta_1._0_
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Title_Holder = new System.Windows.Forms.PictureBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.CheckIn_Button = new System.Windows.Forms.Button();
            this.CheckOut_Button = new System.Windows.Forms.Button();
            this.Capacity_Button = new System.Windows.Forms.Button();
            this.LookUp_Button = new System.Windows.Forms.Button();
            this.Report_Button = new System.Windows.Forms.Button();
            this.Quit_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectionStatus_Label = new System.Windows.Forms.Label();
            this.databaseConnectionStatus_Panel = new System.Windows.Forms.Panel();
            this.RetryConnecting_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Holder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.databaseConnectionStatus_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Holder
            // 
            this.Title_Holder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title_Holder.Image = ((System.Drawing.Image)(resources.GetObject("Title_Holder.Image")));
            this.Title_Holder.Location = new System.Drawing.Point(-2, -1);
            this.Title_Holder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Title_Holder.Name = "Title_Holder";
            this.Title_Holder.Size = new System.Drawing.Size(604, 46);
            this.Title_Holder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title_Holder.TabIndex = 0;
            this.Title_Holder.TabStop = false;
            this.Title_Holder.Click += new System.EventHandler(this.Title_Holder_Click);
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.BackColor = System.Drawing.Color.Azure;
            this.Title_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title_Label.Location = new System.Drawing.Point(16, 11);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(143, 21);
            this.Title_Label.TabIndex = 1;
            this.Title_Label.Text = "Hotel Management";
            // 
            // CheckIn_Button
            // 
            this.CheckIn_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CheckIn_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckIn_Button.BackgroundImage")));
            this.CheckIn_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckIn_Button.Enabled = false;
            this.CheckIn_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckIn_Button.Location = new System.Drawing.Point(28, 68);
            this.CheckIn_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckIn_Button.Name = "CheckIn_Button";
            this.CheckIn_Button.Size = new System.Drawing.Size(159, 151);
            this.CheckIn_Button.TabIndex = 2;
            this.CheckIn_Button.TabStop = false;
            this.CheckIn_Button.UseVisualStyleBackColor = false;
            this.CheckIn_Button.Click += new System.EventHandler(this.CheckIn_Button_Click);
            // 
            // CheckOut_Button
            // 
            this.CheckOut_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckOut_Button.BackgroundImage")));
            this.CheckOut_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckOut_Button.Enabled = false;
            this.CheckOut_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckOut_Button.Location = new System.Drawing.Point(220, 69);
            this.CheckOut_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckOut_Button.Name = "CheckOut_Button";
            this.CheckOut_Button.Size = new System.Drawing.Size(159, 151);
            this.CheckOut_Button.TabIndex = 3;
            this.CheckOut_Button.TabStop = false;
            this.CheckOut_Button.UseVisualStyleBackColor = true;
            this.CheckOut_Button.Click += new System.EventHandler(this.CheckOut_Button_Click);
            // 
            // Capacity_Button
            // 
            this.Capacity_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Capacity_Button.BackgroundImage")));
            this.Capacity_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Capacity_Button.Enabled = false;
            this.Capacity_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Capacity_Button.Location = new System.Drawing.Point(409, 69);
            this.Capacity_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Capacity_Button.Name = "Capacity_Button";
            this.Capacity_Button.Size = new System.Drawing.Size(159, 151);
            this.Capacity_Button.TabIndex = 4;
            this.Capacity_Button.TabStop = false;
            this.Capacity_Button.UseVisualStyleBackColor = true;
            this.Capacity_Button.Click += new System.EventHandler(this.Capacity_Button_Click);
            // 
            // LookUp_Button
            // 
            this.LookUp_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LookUp_Button.BackgroundImage")));
            this.LookUp_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LookUp_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LookUp_Button.Location = new System.Drawing.Point(28, 239);
            this.LookUp_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LookUp_Button.Name = "LookUp_Button";
            this.LookUp_Button.Size = new System.Drawing.Size(159, 151);
            this.LookUp_Button.TabIndex = 5;
            this.LookUp_Button.TabStop = false;
            this.LookUp_Button.UseVisualStyleBackColor = true;
            this.LookUp_Button.Click += new System.EventHandler(this.LookUp_Button_Click);
            // 
            // Report_Button
            // 
            this.Report_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Report_Button.BackgroundImage")));
            this.Report_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Report_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Report_Button.Location = new System.Drawing.Point(220, 239);
            this.Report_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Report_Button.Name = "Report_Button";
            this.Report_Button.Size = new System.Drawing.Size(159, 151);
            this.Report_Button.TabIndex = 6;
            this.Report_Button.TabStop = false;
            this.Report_Button.UseVisualStyleBackColor = true;
            this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
            // 
            // Quit_Button
            // 
            this.Quit_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Quit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quit_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quit_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Quit_Button.Location = new System.Drawing.Point(552, 11);
            this.Quit_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Quit_Button.Name = "Quit_Button";
            this.Quit_Button.Size = new System.Drawing.Size(32, 22);
            this.Quit_Button.TabIndex = 7;
            this.Quit_Button.TabStop = false;
            this.Quit_Button.Text = "X";
            this.Quit_Button.UseVisualStyleBackColor = false;
            this.Quit_Button.Click += new System.EventHandler(this.Quit_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // connectionStatus_Label
            // 
            this.connectionStatus_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionStatus_Label.Location = new System.Drawing.Point(125, 64);
            this.connectionStatus_Label.Name = "connectionStatus_Label";
            this.connectionStatus_Label.Size = new System.Drawing.Size(185, 19);
            this.connectionStatus_Label.TabIndex = 9;
            this.connectionStatus_Label.Text = "Connecting to Database";
            this.connectionStatus_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // databaseConnectionStatus_Panel
            // 
            this.databaseConnectionStatus_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.databaseConnectionStatus_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseConnectionStatus_Panel.Controls.Add(this.RetryConnecting_Button);
            this.databaseConnectionStatus_Panel.Controls.Add(this.pictureBox1);
            this.databaseConnectionStatus_Panel.Controls.Add(this.connectionStatus_Label);
            this.databaseConnectionStatus_Panel.Location = new System.Drawing.Point(1, 270);
            this.databaseConnectionStatus_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.databaseConnectionStatus_Panel.Name = "databaseConnectionStatus_Panel";
            this.databaseConnectionStatus_Panel.Size = new System.Drawing.Size(595, 148);
            this.databaseConnectionStatus_Panel.TabIndex = 10;
            this.databaseConnectionStatus_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.databaseConnectionStatus_Panel_Paint);
            // 
            // RetryConnecting_Button
            // 
            this.RetryConnecting_Button.Enabled = false;
            this.RetryConnecting_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RetryConnecting_Button.Location = new System.Drawing.Point(372, 57);
            this.RetryConnecting_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RetryConnecting_Button.Name = "RetryConnecting_Button";
            this.RetryConnecting_Button.Size = new System.Drawing.Size(179, 36);
            this.RetryConnecting_Button.TabIndex = 10;
            this.RetryConnecting_Button.Text = "Retry";
            this.RetryConnecting_Button.UseVisualStyleBackColor = true;
            this.RetryConnecting_Button.Click += new System.EventHandler(this.RetryConnecting_Button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(595, 417);
            this.Controls.Add(this.databaseConnectionStatus_Panel);
            this.Controls.Add(this.Quit_Button);
            this.Controls.Add(this.Report_Button);
            this.Controls.Add(this.LookUp_Button);
            this.Controls.Add(this.Capacity_Button);
            this.Controls.Add(this.CheckOut_Button);
            this.Controls.Add(this.CheckIn_Button);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.Title_Holder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Title_Holder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.databaseConnectionStatus_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Title_Holder;
        private Label Title_Label;
        private Button CheckIn_Button;
        private Button CheckOut_Button;
        private Button Capacity_Button;
        private Button LookUp_Button;
        private Button Report_Button;
        private Button Quit_Button;
        private PictureBox pictureBox1;
        private Label connectionStatus_Label;
        private Panel databaseConnectionStatus_Panel;
        private Button RetryConnecting_Button;
    }
}