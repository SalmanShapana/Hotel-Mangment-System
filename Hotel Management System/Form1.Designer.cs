namespace Hotel_Management_System
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
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signUp_button = new System.Windows.Forms.Button();
            this.signIn_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(360, 228);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(133, 21);
            this.username_textBox.TabIndex = 6;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(360, 295);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(133, 21);
            this.password_textBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // signUp_button
            // 
            this.signUp_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.signUp_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signUp_button.Location = new System.Drawing.Point(288, 432);
            this.signUp_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.signUp_button.Name = "signUp_button";
            this.signUp_button.Size = new System.Drawing.Size(105, 59);
            this.signUp_button.TabIndex = 10;
            this.signUp_button.Text = "Sign Up";
            this.signUp_button.UseVisualStyleBackColor = false;
            this.signUp_button.Visible = false;
            this.signUp_button.Click += new System.EventHandler(this.signUp_button_Click);
            // 
            // signIn_button
            // 
            this.signIn_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signIn_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signIn_button.Location = new System.Drawing.Point(288, 357);
            this.signIn_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.signIn_button.Name = "signIn_button";
            this.signIn_button.Size = new System.Drawing.Size(105, 59);
            this.signIn_button.TabIndex = 11;
            this.signIn_button.Text = "Sign In";
            this.signIn_button.UseVisualStyleBackColor = false;
            this.signIn_button.Click += new System.EventHandler(this.signIn_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee Sign In";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(680, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signIn_button);
            this.Controls.Add(this.signUp_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Employee Data Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signUp_button;
        private System.Windows.Forms.Button signIn_button;
        private System.Windows.Forms.Label label1;
    }
}

