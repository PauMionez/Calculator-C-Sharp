namespace calculator
{
    partial class Form1
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
            this.Percent_btn = new System.Windows.Forms.Button();
            this.cal_txt = new System.Windows.Forms.TextBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Divide_btn = new System.Windows.Forms.Button();
            this.Multiply_btn = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.Subtract_btn = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.Equal_btn = new System.Windows.Forms.Button();
            this.Dot_btn = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.Negative_btn = new System.Windows.Forms.Button();
            this.show_txt = new System.Windows.Forms.TextBox();
            this.ClearEnt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Percent_btn
            // 
            this.Percent_btn.BackColor = System.Drawing.Color.White;
            this.Percent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent_btn.Location = new System.Drawing.Point(12, 64);
            this.Percent_btn.Name = "Percent_btn";
            this.Percent_btn.Size = new System.Drawing.Size(67, 40);
            this.Percent_btn.TabIndex = 0;
            this.Percent_btn.Text = "%";
            this.Percent_btn.UseVisualStyleBackColor = false;
            this.Percent_btn.Click += new System.EventHandler(this.Percent_btn_Click);
            // 
            // cal_txt
            // 
            this.cal_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cal_txt.Enabled = false;
            this.cal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_txt.Location = new System.Drawing.Point(12, 29);
            this.cal_txt.Name = "cal_txt";
            this.cal_txt.Size = new System.Drawing.Size(262, 26);
            this.cal_txt.TabIndex = 1;
            this.cal_txt.Text = "0";
            this.cal_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cal_txt.TextChanged += new System.EventHandler(this.cal_txt_TextChanged);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.White;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(144, 64);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(67, 40);
            this.Clear_btn.TabIndex = 2;
            this.Clear_btn.Text = "C";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.White;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(210, 64);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(67, 40);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "←";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Divide_btn
            // 
            this.Divide_btn.BackColor = System.Drawing.Color.White;
            this.Divide_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide_btn.Location = new System.Drawing.Point(210, 107);
            this.Divide_btn.Name = "Divide_btn";
            this.Divide_btn.Size = new System.Drawing.Size(67, 40);
            this.Divide_btn.TabIndex = 7;
            this.Divide_btn.Text = "/";
            this.Divide_btn.UseVisualStyleBackColor = false;
            this.Divide_btn.Click += new System.EventHandler(this.Operation);
            // 
            // Multiply_btn
            // 
            this.Multiply_btn.BackColor = System.Drawing.Color.White;
            this.Multiply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_btn.Location = new System.Drawing.Point(210, 150);
            this.Multiply_btn.Name = "Multiply_btn";
            this.Multiply_btn.Size = new System.Drawing.Size(67, 40);
            this.Multiply_btn.TabIndex = 11;
            this.Multiply_btn.Text = "*";
            this.Multiply_btn.UseVisualStyleBackColor = false;
            this.Multiply_btn.Click += new System.EventHandler(this.Operation);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.White;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(144, 107);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(67, 40);
            this.btn_9.TabIndex = 6;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.numbers);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.White;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(78, 107);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(67, 40);
            this.btn_8.TabIndex = 5;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.numbers);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.White;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(12, 107);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(67, 40);
            this.btn_7.TabIndex = 4;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.numbers);
            // 
            // Subtract_btn
            // 
            this.Subtract_btn.BackColor = System.Drawing.Color.White;
            this.Subtract_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract_btn.Location = new System.Drawing.Point(210, 193);
            this.Subtract_btn.Name = "Subtract_btn";
            this.Subtract_btn.Size = new System.Drawing.Size(67, 40);
            this.Subtract_btn.TabIndex = 15;
            this.Subtract_btn.Text = "-";
            this.Subtract_btn.UseVisualStyleBackColor = false;
            this.Subtract_btn.Click += new System.EventHandler(this.Operation);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.White;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(144, 150);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(67, 40);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.numbers);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.White;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(78, 150);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(67, 40);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.numbers);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.White;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(12, 150);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(67, 40);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.numbers);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.White;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(210, 236);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(67, 40);
            this.Add_btn.TabIndex = 19;
            this.Add_btn.Text = "+";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Operation);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.White;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(144, 193);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(67, 40);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.numbers);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.White;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(78, 193);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(67, 40);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.numbers);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(12, 193);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(67, 40);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.numbers);
            // 
            // Equal_btn
            // 
            this.Equal_btn.BackColor = System.Drawing.Color.White;
            this.Equal_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Equal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_btn.Location = new System.Drawing.Point(12, 278);
            this.Equal_btn.Name = "Equal_btn";
            this.Equal_btn.Size = new System.Drawing.Size(265, 53);
            this.Equal_btn.TabIndex = 20;
            this.Equal_btn.Text = "=";
            this.Equal_btn.UseVisualStyleBackColor = false;
            this.Equal_btn.Click += new System.EventHandler(this.Equal_btn_Click);
            // 
            // Dot_btn
            // 
            this.Dot_btn.BackColor = System.Drawing.Color.White;
            this.Dot_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot_btn.Location = new System.Drawing.Point(144, 236);
            this.Dot_btn.Name = "Dot_btn";
            this.Dot_btn.Size = new System.Drawing.Size(67, 40);
            this.Dot_btn.TabIndex = 18;
            this.Dot_btn.Text = ".";
            this.Dot_btn.UseVisualStyleBackColor = false;
            this.Dot_btn.Click += new System.EventHandler(this.numbers);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.White;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(78, 236);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(67, 40);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.numbers);
            // 
            // Negative_btn
            // 
            this.Negative_btn.BackColor = System.Drawing.Color.White;
            this.Negative_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Negative_btn.Location = new System.Drawing.Point(12, 236);
            this.Negative_btn.Name = "Negative_btn";
            this.Negative_btn.Size = new System.Drawing.Size(67, 40);
            this.Negative_btn.TabIndex = 16;
            this.Negative_btn.Text = "+/-";
            this.Negative_btn.UseVisualStyleBackColor = false;
            this.Negative_btn.Click += new System.EventHandler(this.Negative_btn_Click);
            // 
            // show_txt
            // 
            this.show_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.show_txt.Enabled = false;
            this.show_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_txt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.show_txt.Location = new System.Drawing.Point(12, 12);
            this.show_txt.Name = "show_txt";
            this.show_txt.Size = new System.Drawing.Size(262, 17);
            this.show_txt.TabIndex = 21;
            this.show_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClearEnt_btn
            // 
            this.ClearEnt_btn.BackColor = System.Drawing.Color.White;
            this.ClearEnt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEnt_btn.Location = new System.Drawing.Point(78, 64);
            this.ClearEnt_btn.Name = "ClearEnt_btn";
            this.ClearEnt_btn.Size = new System.Drawing.Size(67, 40);
            this.ClearEnt_btn.TabIndex = 1;
            this.ClearEnt_btn.Text = "CE";
            this.ClearEnt_btn.UseVisualStyleBackColor = false;
            this.ClearEnt_btn.Click += new System.EventHandler(this.ClearEnt_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(287, 346);
            this.Controls.Add(this.ClearEnt_btn);
            this.Controls.Add(this.show_txt);
            this.Controls.Add(this.Equal_btn);
            this.Controls.Add(this.Dot_btn);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.Negative_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.Subtract_btn);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.Multiply_btn);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.Divide_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.cal_txt);
            this.Controls.Add(this.Percent_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Percent_btn;
        private System.Windows.Forms.TextBox cal_txt;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Divide_btn;
        private System.Windows.Forms.Button Multiply_btn;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button Subtract_btn;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button Equal_btn;
        private System.Windows.Forms.Button Dot_btn;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button Negative_btn;
        private System.Windows.Forms.TextBox show_txt;
        private System.Windows.Forms.Button ClearEnt_btn;
    }
}

