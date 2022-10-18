namespace Hotel_Management__Beta_1._0_
{
    partial class CheckIn_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn_Form));
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Guest_Icon = new System.Windows.Forms.PictureBox();
            this.GuestInfo_Label = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.Age_Selector = new System.Windows.Forms.NumericUpDown();
            this.Age_Label = new System.Windows.Forms.Label();
            this.BedConfig_Label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Room_Label = new System.Windows.Forms.Label();
            this.BedConfig_Selector = new System.Windows.Forms.NumericUpDown();
            this.Price_Selector = new System.Windows.Forms.NumericUpDown();
            this.Room_Selector = new System.Windows.Forms.NumericUpDown();
            this.Payment_Label = new System.Windows.Forms.Label();
            this.CreditDebit_RadioButton = new System.Windows.Forms.RadioButton();
            this.Cash_RadioButton = new System.Windows.Forms.RadioButton();
            this.CreditDebit_Icon = new System.Windows.Forms.PictureBox();
            this.Cash_Icon = new System.Windows.Forms.PictureBox();
            this.StayLength_Label = new System.Windows.Forms.Label();
            this.StayLength_Selector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedConfig_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDebit_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cash_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StayLength_Selector)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(290, 468);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(135, 30);
            this.Cancel_Button.TabIndex = 10;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(149, 468);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(135, 30);
            this.OK_Button.TabIndex = 9;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Guest_Icon
            // 
            this.Guest_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Guest_Icon.Image")));
            this.Guest_Icon.Location = new System.Drawing.Point(96, 12);
            this.Guest_Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Guest_Icon.Name = "Guest_Icon";
            this.Guest_Icon.Size = new System.Drawing.Size(102, 76);
            this.Guest_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guest_Icon.TabIndex = 2;
            this.Guest_Icon.TabStop = false;
            // 
            // GuestInfo_Label
            // 
            this.GuestInfo_Label.AutoSize = true;
            this.GuestInfo_Label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestInfo_Label.Location = new System.Drawing.Point(191, 38);
            this.GuestInfo_Label.Name = "GuestInfo_Label";
            this.GuestInfo_Label.Size = new System.Drawing.Size(164, 25);
            this.GuestInfo_Label.TabIndex = 3;
            this.GuestInfo_Label.Text = "Guest Information";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.AcceptsReturn = true;
            this.Name_TextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_TextBox.Location = new System.Drawing.Point(128, 110);
            this.Name_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(293, 27);
            this.Name_TextBox.TabIndex = 0;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.Location = new System.Drawing.Point(22, 112);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(52, 20);
            this.Name_Label.TabIndex = 5;
            this.Name_Label.Text = "Name:";
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName_Label.Location = new System.Drawing.Point(23, 148);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(82, 20);
            this.LastName_Label.TabIndex = 6;
            this.LastName_Label.Text = "Last Name:";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName_TextBox.Location = new System.Drawing.Point(128, 146);
            this.LastName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(293, 27);
            this.LastName_TextBox.TabIndex = 1;
            // 
            // Age_Selector
            // 
            this.Age_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Age_Selector.Location = new System.Drawing.Point(128, 184);
            this.Age_Selector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Age_Selector.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Age_Selector.Name = "Age_Selector";
            this.Age_Selector.Size = new System.Drawing.Size(53, 27);
            this.Age_Selector.TabIndex = 2;
            this.Age_Selector.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Age_Label.Location = new System.Drawing.Point(23, 187);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(39, 20);
            this.Age_Label.TabIndex = 9;
            this.Age_Label.Text = "Age:";
            // 
            // BedConfig_Label
            // 
            this.BedConfig_Label.AutoSize = true;
            this.BedConfig_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BedConfig_Label.Location = new System.Drawing.Point(23, 226);
            this.BedConfig_Label.Name = "BedConfig_Label";
            this.BedConfig_Label.Size = new System.Drawing.Size(54, 20);
            this.BedConfig_Label.TabIndex = 10;
            this.BedConfig_Label.Text = "Bed(s):";
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_Label.Location = new System.Drawing.Point(23, 264);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(92, 20);
            this.Price_Label.TabIndex = 11;
            this.Price_Label.Text = "Price:          $";
            // 
            // Room_Label
            // 
            this.Room_Label.AutoSize = true;
            this.Room_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Room_Label.Location = new System.Drawing.Point(24, 304);
            this.Room_Label.Name = "Room_Label";
            this.Room_Label.Size = new System.Drawing.Size(65, 20);
            this.Room_Label.TabIndex = 12;
            this.Room_Label.Text = "Room #:";
            // 
            // BedConfig_Selector
            // 
            this.BedConfig_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BedConfig_Selector.Location = new System.Drawing.Point(128, 224);
            this.BedConfig_Selector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BedConfig_Selector.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.BedConfig_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BedConfig_Selector.Name = "BedConfig_Selector";
            this.BedConfig_Selector.Size = new System.Drawing.Size(53, 27);
            this.BedConfig_Selector.TabIndex = 3;
            this.BedConfig_Selector.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Price_Selector
            // 
            this.Price_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_Selector.Location = new System.Drawing.Point(128, 262);
            this.Price_Selector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Price_Selector.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Price_Selector.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Price_Selector.Name = "Price_Selector";
            this.Price_Selector.Size = new System.Drawing.Size(53, 27);
            this.Price_Selector.TabIndex = 4;
            this.Price_Selector.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Room_Selector
            // 
            this.Room_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Room_Selector.Location = new System.Drawing.Point(128, 301);
            this.Room_Selector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Room_Selector.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Room_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Room_Selector.Name = "Room_Selector";
            this.Room_Selector.Size = new System.Drawing.Size(53, 27);
            this.Room_Selector.TabIndex = 5;
            this.Room_Selector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Payment_Label
            // 
            this.Payment_Label.AutoSize = true;
            this.Payment_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_Label.Location = new System.Drawing.Point(24, 387);
            this.Payment_Label.Name = "Payment_Label";
            this.Payment_Label.Size = new System.Drawing.Size(68, 20);
            this.Payment_Label.TabIndex = 16;
            this.Payment_Label.Text = "Payment:";
            // 
            // CreditDebit_RadioButton
            // 
            this.CreditDebit_RadioButton.AutoSize = true;
            this.CreditDebit_RadioButton.Checked = true;
            this.CreditDebit_RadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreditDebit_RadioButton.Location = new System.Drawing.Point(170, 420);
            this.CreditDebit_RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreditDebit_RadioButton.Name = "CreditDebit_RadioButton";
            this.CreditDebit_RadioButton.Size = new System.Drawing.Size(102, 23);
            this.CreditDebit_RadioButton.TabIndex = 7;
            this.CreditDebit_RadioButton.TabStop = true;
            this.CreditDebit_RadioButton.Text = "Credit/Debit";
            this.CreditDebit_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Cash_RadioButton
            // 
            this.Cash_RadioButton.AutoSize = true;
            this.Cash_RadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cash_RadioButton.Location = new System.Drawing.Point(334, 420);
            this.Cash_RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cash_RadioButton.Name = "Cash_RadioButton";
            this.Cash_RadioButton.Size = new System.Drawing.Size(57, 23);
            this.Cash_RadioButton.TabIndex = 8;
            this.Cash_RadioButton.Text = "Cash";
            this.Cash_RadioButton.UseVisualStyleBackColor = true;
            // 
            // CreditDebit_Icon
            // 
            this.CreditDebit_Icon.Image = ((System.Drawing.Image)(resources.GetObject("CreditDebit_Icon.Image")));
            this.CreditDebit_Icon.Location = new System.Drawing.Point(189, 357);
            this.CreditDebit_Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreditDebit_Icon.Name = "CreditDebit_Icon";
            this.CreditDebit_Icon.Size = new System.Drawing.Size(61, 58);
            this.CreditDebit_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CreditDebit_Icon.TabIndex = 19;
            this.CreditDebit_Icon.TabStop = false;
            // 
            // Cash_Icon
            // 
            this.Cash_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Cash_Icon.Image")));
            this.Cash_Icon.Location = new System.Drawing.Point(324, 360);
            this.Cash_Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cash_Icon.Name = "Cash_Icon";
            this.Cash_Icon.Size = new System.Drawing.Size(68, 58);
            this.Cash_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cash_Icon.TabIndex = 20;
            this.Cash_Icon.TabStop = false;
            // 
            // StayLength_Label
            // 
            this.StayLength_Label.AutoSize = true;
            this.StayLength_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StayLength_Label.Location = new System.Drawing.Point(258, 189);
            this.StayLength_Label.Name = "StayLength_Label";
            this.StayLength_Label.Size = new System.Drawing.Size(166, 20);
            this.StayLength_Label.TabIndex = 21;
            this.StayLength_Label.Text = "Stay:                   night(s)";
            // 
            // StayLength_Selector
            // 
            this.StayLength_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StayLength_Selector.Location = new System.Drawing.Point(320, 186);
            this.StayLength_Selector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StayLength_Selector.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.StayLength_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StayLength_Selector.Name = "StayLength_Selector";
            this.StayLength_Selector.Size = new System.Drawing.Size(39, 27);
            this.StayLength_Selector.TabIndex = 6;
            this.StayLength_Selector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 507);
            this.Controls.Add(this.StayLength_Selector);
            this.Controls.Add(this.StayLength_Label);
            this.Controls.Add(this.Cash_RadioButton);
            this.Controls.Add(this.CreditDebit_RadioButton);
            this.Controls.Add(this.Payment_Label);
            this.Controls.Add(this.Room_Selector);
            this.Controls.Add(this.Price_Selector);
            this.Controls.Add(this.BedConfig_Selector);
            this.Controls.Add(this.Room_Label);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.BedConfig_Label);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.Age_Selector);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.GuestInfo_Label);
            this.Controls.Add(this.Guest_Icon);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.CreditDebit_Icon);
            this.Controls.Add(this.Cash_Icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.CheckIn_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Guest_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedConfig_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDebit_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cash_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StayLength_Selector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel_Button;
        private Button OK_Button;
        private PictureBox Guest_Icon;
        private Label GuestInfo_Label;
        private TextBox Name_TextBox;
        private Label Name_Label;
        private Label LastName_Label;
        private TextBox LastName_TextBox;
        private NumericUpDown Age_Selector;
        private Label Age_Label;
        private Label BedConfig_Label;
        private Label Price_Label;
        private Label Room_Label;
        private NumericUpDown BedConfig_Selector;
        private NumericUpDown Price_Selector;
        private NumericUpDown Room_Selector;
        private Label Payment_Label;
        private RadioButton CreditDebit_RadioButton;
        private RadioButton Cash_RadioButton;
        private PictureBox CreditDebit_Icon;
        private PictureBox Cash_Icon;
        private Label StayLength_Label;
        private NumericUpDown StayLength_Selector;
    }
}