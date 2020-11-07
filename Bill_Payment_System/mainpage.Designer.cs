namespace Bill_Payment_System
{
    partial class mainpage
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
            this.foter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.foter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // foter
            // 
            this.foter.BackColor = System.Drawing.Color.Teal;
            this.foter.Controls.Add(this.label1);
            this.foter.Location = new System.Drawing.Point(0, 425);
            this.foter.Name = "foter";
            this.foter.Size = new System.Drawing.Size(809, 30);
            this.foter.TabIndex = 0;
            this.foter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed by : GROUP-8";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.header);
            this.panel2.Location = new System.Drawing.Point(6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 70);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.SystemColors.Window;
            this.header.Location = new System.Drawing.Point(214, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(377, 42);
            this.header.TabIndex = 0;
            this.header.Text = "Bill Payment System";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(123, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "RETAILER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(453, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 72);
            this.button2.TabIndex = 3;
            this.button2.Text = "DEALER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(326, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Type";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.foter);
            this.Name = "mainpage";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.mainpage_Load);
            this.foter.ResumeLayout(false);
            this.foter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel foter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

