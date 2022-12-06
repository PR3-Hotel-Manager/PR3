namespace Hotel_Management__Beta_1._0_
{
    partial class Estimate_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.StayLength_Selector_Estimate = new System.Windows.Forms.NumericUpDown();
            this.StayLength_Label = new System.Windows.Forms.Label();
            this.Bed_Selector = new System.Windows.Forms.NumericUpDown();
            this.Room_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Estimate_Price_Label = new System.Windows.Forms.Label();
            this.Estimate_Price_Placeholder = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.GuestInfo_Label = new System.Windows.Forms.Label();
            this.Guest_Icon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StayLength_Selector_Estimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bed_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(506, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 45);
            this.label4.TabIndex = 32;
            this.label4.Text = "Night(s)";
            // 
            // StayLength_Selector_Estimate
            // 
            this.StayLength_Selector_Estimate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StayLength_Selector_Estimate.Location = new System.Drawing.Point(343, 317);
            this.StayLength_Selector_Estimate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StayLength_Selector_Estimate.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.StayLength_Selector_Estimate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StayLength_Selector_Estimate.Name = "StayLength_Selector_Estimate";
            this.StayLength_Selector_Estimate.Size = new System.Drawing.Size(150, 51);
            this.StayLength_Selector_Estimate.TabIndex = 29;
            this.StayLength_Selector_Estimate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StayLength_Selector_Estimate.ValueChanged += new System.EventHandler(this.StayLength_Selector_Estimate_ValueChanged);
            // 
            // StayLength_Label
            // 
            this.StayLength_Label.AutoSize = true;
            this.StayLength_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StayLength_Label.Location = new System.Drawing.Point(118, 320);
            this.StayLength_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StayLength_Label.Name = "StayLength_Label";
            this.StayLength_Label.Size = new System.Drawing.Size(88, 45);
            this.StayLength_Label.TabIndex = 31;
            this.StayLength_Label.Text = "Stay:";
            // 
            // Bed_Selector
            // 
            this.Bed_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bed_Selector.Location = new System.Drawing.Point(343, 445);
            this.Bed_Selector.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Bed_Selector.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Bed_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Bed_Selector.Name = "Bed_Selector";
            this.Bed_Selector.Size = new System.Drawing.Size(150, 51);
            this.Bed_Selector.TabIndex = 28;
            this.Bed_Selector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Bed_Selector.ValueChanged += new System.EventHandler(this.Bed_Selector_ValueChanged);
            // 
            // Room_Label
            // 
            this.Room_Label.AutoSize = true;
            this.Room_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Room_Label.Location = new System.Drawing.Point(120, 453);
            this.Room_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Room_Label.Name = "Room_Label";
            this.Room_Label.Size = new System.Drawing.Size(111, 45);
            this.Room_Label.TabIndex = 30;
            this.Room_Label.Text = "Bed #:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 57);
            this.label1.TabIndex = 0;
            // 
            // Estimate_Price_Label
            // 
            this.Estimate_Price_Label.AutoSize = true;
            this.Estimate_Price_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Estimate_Price_Label.Location = new System.Drawing.Point(39, 630);
            this.Estimate_Price_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Estimate_Price_Label.Name = "Estimate_Price_Label";
            this.Estimate_Price_Label.Size = new System.Drawing.Size(373, 72);
            this.Estimate_Price_Label.TabIndex = 33;
            this.Estimate_Price_Label.Text = "Price Estimate:";
            // 
            // Estimate_Price_Placeholder
            // 
            this.Estimate_Price_Placeholder.AutoSize = true;
            this.Estimate_Price_Placeholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Estimate_Price_Placeholder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Estimate_Price_Placeholder.Location = new System.Drawing.Point(409, 626);
            this.Estimate_Price_Placeholder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Estimate_Price_Placeholder.Name = "Estimate_Price_Placeholder";
            this.Estimate_Price_Placeholder.Size = new System.Drawing.Size(174, 74);
            this.Estimate_Price_Placeholder.TabIndex = 34;
            this.Estimate_Price_Placeholder.Text = "label3";
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(217, 808);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(289, 74);
            this.OK_Button.TabIndex = 35;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // GuestInfo_Label
            // 
            this.GuestInfo_Label.Location = new System.Drawing.Point(0, 0);
            this.GuestInfo_Label.Name = "GuestInfo_Label";
            this.GuestInfo_Label.Size = new System.Drawing.Size(100, 23);
            this.GuestInfo_Label.TabIndex = 0;
            // 
            // Guest_Icon
            // 
            this.Guest_Icon.Image = global::Hotel_Management__Beta_1._0_.Properties.Resources.User;
            this.Guest_Icon.Location = new System.Drawing.Point(74, 55);
            this.Guest_Icon.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Guest_Icon.Name = "Guest_Icon";
            this.Guest_Icon.Size = new System.Drawing.Size(219, 187);
            this.Guest_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Guest_Icon.TabIndex = 36;
            this.Guest_Icon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(248, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 57);
            this.label2.TabIndex = 37;
            this.label2.Text = "Guest Estimate Page";
            // 
            // Estimate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 950);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuestInfo_Label);
            this.Controls.Add(this.Guest_Icon);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Estimate_Price_Placeholder);
            this.Controls.Add(this.Estimate_Price_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StayLength_Selector_Estimate);
            this.Controls.Add(this.StayLength_Label);
            this.Controls.Add(this.Bed_Selector);
            this.Controls.Add(this.Room_Label);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Estimate_Form";
            this.Text = "Estimate_Form";
            this.Load += new System.EventHandler(this.Estimate_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StayLength_Selector_Estimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bed_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private NumericUpDown StayLength_Selector_Estimate;
        private Label StayLength_Label;
        private NumericUpDown Bed_Selector;
        private Label Room_Label;
        private Label label1;
        private Label Estimate_Price_Label;
        private Label Estimate_Price_Placeholder;
        private Button OK_Button;
        private Label GuestInfo_Label;
        private PictureBox Guest_Icon;
        private Label label2;
    }
}