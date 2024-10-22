namespace FormATTT
{
    partial class Diffie_Hellman
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
            this.txt_q = new System.Windows.Forms.TextBox();
            this.txt_alpha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_khoachung = new System.Windows.Forms.TextBox();
            this.txt_khoarieng = new System.Windows.Forms.TextBox();
            this.txt_ycuaminh = new System.Windows.Forms.TextBox();
            this.txt_ycuaban = new System.Windows.Forms.TextBox();
            this.btn_timkhoacongkhai = new System.Windows.Forms.Button();
            this.btn_khoachung = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khóa chung bí mật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khóa công khai(Y) của đối phương";
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(253, 44);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(71, 22);
            this.txt_q.TabIndex = 2;
            // 
            // txt_alpha
            // 
            this.txt_alpha.Location = new System.Drawing.Point(253, 88);
            this.txt_alpha.Name = "txt_alpha";
            this.txt_alpha.Size = new System.Drawing.Size(71, 22);
            this.txt_alpha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số alpha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Khóa công khai(Y) của mình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Khóa riêng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_timkhoacongkhai);
            this.groupBox1.Controls.Add(this.txt_ycuaban);
            this.groupBox1.Controls.Add(this.txt_ycuaminh);
            this.groupBox1.Controls.Add(this.txt_q);
            this.groupBox1.Controls.Add(this.txt_alpha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(44, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 290);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin public";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_khoachung);
            this.groupBox2.Controls.Add(this.txt_khoarieng);
            this.groupBox2.Controls.Add(this.txt_khoachung);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(444, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 219);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin private";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Diffie-Hellman";
            // 
            // txt_khoachung
            // 
            this.txt_khoachung.Location = new System.Drawing.Point(132, 99);
            this.txt_khoachung.Name = "txt_khoachung";
            this.txt_khoachung.ReadOnly = true;
            this.txt_khoachung.Size = new System.Drawing.Size(71, 22);
            this.txt_khoachung.TabIndex = 8;
            // 
            // txt_khoarieng
            // 
            this.txt_khoarieng.Location = new System.Drawing.Point(132, 35);
            this.txt_khoarieng.Name = "txt_khoarieng";
            this.txt_khoarieng.Size = new System.Drawing.Size(71, 22);
            this.txt_khoarieng.TabIndex = 9;
            // 
            // txt_ycuaminh
            // 
            this.txt_ycuaminh.Location = new System.Drawing.Point(253, 131);
            this.txt_ycuaminh.Name = "txt_ycuaminh";
            this.txt_ycuaminh.ReadOnly = true;
            this.txt_ycuaminh.Size = new System.Drawing.Size(71, 22);
            this.txt_ycuaminh.TabIndex = 11;
            // 
            // txt_ycuaban
            // 
            this.txt_ycuaban.Location = new System.Drawing.Point(253, 230);
            this.txt_ycuaban.Name = "txt_ycuaban";
            this.txt_ycuaban.Size = new System.Drawing.Size(71, 22);
            this.txt_ycuaban.TabIndex = 12;
            // 
            // btn_timkhoacongkhai
            // 
            this.btn_timkhoacongkhai.Location = new System.Drawing.Point(169, 170);
            this.btn_timkhoacongkhai.Name = "btn_timkhoacongkhai";
            this.btn_timkhoacongkhai.Size = new System.Drawing.Size(155, 23);
            this.btn_timkhoacongkhai.TabIndex = 13;
            this.btn_timkhoacongkhai.Text = "Tìm khóa công khai";
            this.btn_timkhoacongkhai.UseVisualStyleBackColor = true;
            this.btn_timkhoacongkhai.Click += new System.EventHandler(this.btn_timkhoacongkhai_Click);
            // 
            // btn_khoachung
            // 
            this.btn_khoachung.Location = new System.Drawing.Point(36, 139);
            this.btn_khoachung.Name = "btn_khoachung";
            this.btn_khoachung.Size = new System.Drawing.Size(167, 23);
            this.btn_khoachung.TabIndex = 14;
            this.btn_khoachung.Text = "Tìm khóa bí mật chung";
            this.btn_khoachung.UseVisualStyleBackColor = true;
            this.btn_khoachung.Click += new System.EventHandler(this.btn_khoachung_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(504, 367);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Diffie_Hellman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 420);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Diffie_Hellman";
            this.Text = "Diffie_Hellman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.TextBox txt_alpha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ycuaban;
        private System.Windows.Forms.TextBox txt_ycuaminh;
        private System.Windows.Forms.TextBox txt_khoarieng;
        private System.Windows.Forms.TextBox txt_khoachung;
        private System.Windows.Forms.Button btn_timkhoacongkhai;
        private System.Windows.Forms.Button btn_khoachung;
        private System.Windows.Forms.Button btn_thoat;
    }
}