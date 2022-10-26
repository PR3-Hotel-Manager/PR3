namespace Hotel_Management__Beta_1._0_
{
    partial class CheckInConfirmation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInConfirmation_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfirmationNumber_Label = new System.Windows.Forms.Label();
            this.PlaceHolder_Label = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmationNumber_Label
            // 
            this.ConfirmationNumber_Label.AutoSize = true;
            this.ConfirmationNumber_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationNumber_Label.Location = new System.Drawing.Point(218, 196);
            this.ConfirmationNumber_Label.Name = "ConfirmationNumber_Label";
            this.ConfirmationNumber_Label.Size = new System.Drawing.Size(79, 25);
            this.ConfirmationNumber_Label.TabIndex = 1;
            this.ConfirmationNumber_Label.Text = "number";
            // 
            // PlaceHolder_Label
            // 
            this.PlaceHolder_Label.AutoSize = true;
            this.PlaceHolder_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceHolder_Label.Location = new System.Drawing.Point(90, 196);
            this.PlaceHolder_Label.Name = "PlaceHolder_Label";
            this.PlaceHolder_Label.Size = new System.Drawing.Size(127, 25);
            this.PlaceHolder_Label.TabIndex = 2;
            this.PlaceHolder_Label.Text = "Confirmation:";
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(179, 247);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(153, 42);
            this.OK_Button.TabIndex = 3;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // CheckInConfirmation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 301);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.PlaceHolder_Label);
            this.Controls.Add(this.ConfirmationNumber_Label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInConfirmation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CheckInConfirmation_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label ConfirmationNumber_Label;
        private Label PlaceHolder_Label;
        private Button OK_Button;
    }
}