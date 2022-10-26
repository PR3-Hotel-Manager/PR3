namespace Hotel_Management__Beta_1._0_
{
    partial class LookUp_Form
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
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.result_TextBox = new System.Windows.Forms.RichTextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_TextBox.Location = new System.Drawing.Point(209, 28);
            this.Name_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(292, 27);
            this.Name_TextBox.TabIndex = 0;
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName_TextBox.Location = new System.Drawing.Point(209, 66);
            this.LastName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(292, 27);
            this.LastName_TextBox.TabIndex = 1;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.Location = new System.Drawing.Point(143, 32);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(52, 20);
            this.Name_Label.TabIndex = 2;
            this.Name_Label.Text = "Name:";
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName_Label.Location = new System.Drawing.Point(111, 69);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(82, 20);
            this.LastName_Label.TabIndex = 3;
            this.LastName_Label.Text = "Last Name:";
            // 
            // result_TextBox
            // 
            this.result_TextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_TextBox.Location = new System.Drawing.Point(22, 179);
            this.result_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result_TextBox.Name = "result_TextBox";
            this.result_TextBox.Size = new System.Drawing.Size(479, 162);
            this.result_TextBox.TabIndex = 4;
            this.result_TextBox.Text = "";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(209, 106);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(143, 30);
            this.Search_Button.TabIndex = 2;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(358, 106);
            this.Clear_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(143, 30);
            this.Clear_Button.TabIndex = 3;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(22, 106);
            this.progressBar.MarqueeAnimationSpeed = 40;
            this.progressBar.Maximum = 40;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(171, 30);
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // LookUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 367);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.result_TextBox);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "LookUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Look Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Name_TextBox;
        private TextBox LastName_TextBox;
        private Label Name_Label;
        private Label LastName_Label;
        private RichTextBox result_TextBox;
        private Button Search_Button;
        private Button Clear_Button;
        private Label label1;
        private ProgressBar progressBar;
    }
}