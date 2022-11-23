namespace Hotel_Management__Beta_1._0_
{
    partial class Rooms_Form
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
            this.OK_Button = new System.Windows.Forms.Button();
            this.AvailableRooms_Label = new System.Windows.Forms.Label();
            this.Occupied_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Empty_richTextBox = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(1078, 815);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(308, 82);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // AvailableRooms_Label
            // 
            this.AvailableRooms_Label.AutoSize = true;
            this.AvailableRooms_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailableRooms_Label.Location = new System.Drawing.Point(51, 828);
            this.AvailableRooms_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AvailableRooms_Label.Name = "AvailableRooms_Label";
            this.AvailableRooms_Label.Size = new System.Drawing.Size(292, 50);
            this.AvailableRooms_Label.TabIndex = 1;
            this.AvailableRooms_Label.Text = "Available rooms:";
            // 
            // Occupied_RichTextBox
            // 
            this.Occupied_RichTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Occupied_RichTextBox.Location = new System.Drawing.Point(58, 134);
            this.Occupied_RichTextBox.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Occupied_RichTextBox.Name = "Occupied_RichTextBox";
            this.Occupied_RichTextBox.Size = new System.Drawing.Size(594, 600);
            this.Occupied_RichTextBox.TabIndex = 2;
            this.Occupied_RichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Occupied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(780, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empty:";
            // 
            // Empty_richTextBox
            // 
            this.Empty_richTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empty_richTextBox.Location = new System.Drawing.Point(780, 134);
            this.Empty_richTextBox.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Empty_richTextBox.Name = "Empty_richTextBox";
            this.Empty_richTextBox.Size = new System.Drawing.Size(594, 600);
            this.Empty_richTextBox.TabIndex = 6;
            this.Empty_richTextBox.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(549, 815);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(486, 82);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // Rooms_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 924);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Empty_richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Occupied_RichTextBox);
            this.Controls.Add(this.AvailableRooms_Label);
            this.Controls.Add(this.OK_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rooms_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OK_Button;
        private Label AvailableRooms_Label;
        private RichTextBox Occupied_RichTextBox;
        private Label label1;
        private Label label2;
        private RichTextBox Empty_richTextBox;
        private ProgressBar progressBar1;
    }
}