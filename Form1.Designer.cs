namespace SpaceCeption
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FontBox = new System.Windows.Forms.TextBox();
            this.FontSizeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputText.Location = new System.Drawing.Point(12, 85);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(1127, 53);
            this.InputText.TabIndex = 0;
            // 
            // OutputText
            // 
            this.OutputText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputText.Location = new System.Drawing.Point(12, 236);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(1300, 53);
            this.OutputText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert line to be formatted below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copy the fitted line below";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1165, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fit Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1127, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hair Space";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(748, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Thin Space";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.button4.Location = new System.Drawing.Point(357, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 58);
            this.button4.TabIndex = 10;
            this.button4.Text = "Thick Space";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 58);
            this.button5.TabIndex = 11;
            this.button5.Text = "Em Space";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(792, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Click any of the buttons below to copy it to your clipboard";
            // 
            // FontBox
            // 
            this.FontBox.Location = new System.Drawing.Point(961, 18);
            this.FontBox.Name = "FontBox";
            this.FontBox.ReadOnly = true;
            this.FontBox.Size = new System.Drawing.Size(267, 47);
            this.FontBox.TabIndex = 13;
            this.FontBox.Text = "Times New Roman";
            this.FontBox.Visible = false;
            // 
            // FontSizeBox
            // 
            this.FontSizeBox.Location = new System.Drawing.Point(1253, 18);
            this.FontSizeBox.Name = "FontSizeBox";
            this.FontSizeBox.ReadOnly = true;
            this.FontSizeBox.Size = new System.Drawing.Size(59, 47);
            this.FontSizeBox.TabIndex = 14;
            this.FontSizeBox.Text = "12";
            this.FontSizeBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1334, 477);
            this.Controls.Add(this.FontSizeBox);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InputText);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OPR Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputText;
        private TextBox OutputText;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private TextBox FontBox;
        private TextBox FontSizeBox;
    }
}