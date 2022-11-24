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
            ((System.ComponentModel.ISupportInitialize)(this.StayLength_Selector_Estimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bed_Selector)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(461, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Night(s)";
            // 
            // StayLength_Selector_Estimate
            // 
            this.StayLength_Selector_Estimate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StayLength_Selector_Estimate.Location = new System.Drawing.Point(383, 186);
            this.StayLength_Selector_Estimate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.StayLength_Selector_Estimate.Size = new System.Drawing.Size(70, 27);
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
            this.StayLength_Label.Location = new System.Drawing.Point(278, 187);
            this.StayLength_Label.Name = "StayLength_Label";
            this.StayLength_Label.Size = new System.Drawing.Size(40, 20);
            this.StayLength_Label.TabIndex = 31;
            this.StayLength_Label.Text = "Stay:";
            // 
            // Bed_Selector
            // 
            this.Bed_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bed_Selector.Location = new System.Drawing.Point(383, 238);
            this.Bed_Selector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bed_Selector.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Bed_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Bed_Selector.Name = "Bed_Selector";
            this.Bed_Selector.Size = new System.Drawing.Size(70, 27);
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
            this.Room_Label.Location = new System.Drawing.Point(279, 241);
            this.Room_Label.Name = "Room_Label";
            this.Room_Label.Size = new System.Drawing.Size(51, 20);
            this.Room_Label.TabIndex = 30;
            this.Room_Label.Text = "Bed #:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Estimate_Price_Label
            // 
            this.Estimate_Price_Label.AutoSize = true;
            this.Estimate_Price_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Estimate_Price_Label.Location = new System.Drawing.Point(241, 313);
            this.Estimate_Price_Label.Name = "Estimate_Price_Label";
            this.Estimate_Price_Label.Size = new System.Drawing.Size(167, 32);
            this.Estimate_Price_Label.TabIndex = 33;
            this.Estimate_Price_Label.Text = "Price Estimate:";
            // 
            // Estimate_Price_Placeholder
            // 
            this.Estimate_Price_Placeholder.AutoSize = true;
            this.Estimate_Price_Placeholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Estimate_Price_Placeholder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Estimate_Price_Placeholder.Location = new System.Drawing.Point(414, 311);
            this.Estimate_Price_Placeholder.Name = "Estimate_Price_Placeholder";
            this.Estimate_Price_Placeholder.Size = new System.Drawing.Size(80, 34);
            this.Estimate_Price_Placeholder.TabIndex = 34;
            this.Estimate_Price_Placeholder.Text = "label3";
            // 
            // Estimate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Estimate_Price_Placeholder);
            this.Controls.Add(this.Estimate_Price_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StayLength_Selector_Estimate);
            this.Controls.Add(this.StayLength_Label);
            this.Controls.Add(this.Bed_Selector);
            this.Controls.Add(this.Room_Label);
            this.Name = "Estimate_Form";
            this.Text = "Estimate_Form";
            ((System.ComponentModel.ISupportInitialize)(this.StayLength_Selector_Estimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bed_Selector)).EndInit();
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
    }
}