namespace Hotel_Management_System
{
    partial class processSelectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reserve_room_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Type Of Process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "You Want To Make";
            // 
            // reserve_room_btn
            // 
            this.reserve_room_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.reserve_room_btn.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_room_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reserve_room_btn.Location = new System.Drawing.Point(335, 296);
            this.reserve_room_btn.Name = "reserve_room_btn";
            this.reserve_room_btn.Size = new System.Drawing.Size(229, 118);
            this.reserve_room_btn.TabIndex = 5;
            this.reserve_room_btn.Text = "Reserve Room";
            this.reserve_room_btn.UseVisualStyleBackColor = false;
            this.reserve_room_btn.Click += new System.EventHandler(this.reserve_room_btn_Click);
            // 
            // processSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(891, 538);
            this.Controls.Add(this.reserve_room_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "processSelectionForm";
            this.Text = "processSelectionForm";
            this.Load += new System.EventHandler(this.processSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reserve_room_btn;
    }
}