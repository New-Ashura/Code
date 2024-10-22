namespace FormATTT
{
    partial class RSA
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
            this.label6 = new System.Windows.Forms.Label();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.btn_thuchien = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lb_output = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_banma = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_KR = new System.Windows.Forms.Label();
            this.lb_KU = new System.Windows.Forms.Label();
            this.btn_tao = new System.Windows.Forms.Button();
            this.lb_key = new System.Windows.Forms.Label();
            this.txt_k1 = new System.Windows.Forms.TextBox();
            this.txt_k2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Lựa chọn";
            // 
            // cb_luachon
            // 
            this.cb_luachon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Items.AddRange(new object[] {
            "Mã hóa",
            "Giải mã"});
            this.cb_luachon.Location = new System.Drawing.Point(446, 271);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.Size = new System.Drawing.Size(121, 24);
            this.cb_luachon.TabIndex = 24;
            this.cb_luachon.SelectedIndexChanged += new System.EventHandler(this.cb_luachon_SelectedIndexChanged);
            // 
            // btn_thuchien
            // 
            this.btn_thuchien.Location = new System.Drawing.Point(601, 260);
            this.btn_thuchien.Name = "btn_thuchien";
            this.btn_thuchien.Size = new System.Drawing.Size(87, 36);
            this.btn_thuchien.TabIndex = 23;
            this.btn_thuchien.Text = "Thực hiện";
            this.btn_thuchien.UseVisualStyleBackColor = true;
            this.btn_thuchien.Click += new System.EventHandler(this.btn_thuchien_Click);
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output.Location = new System.Drawing.Point(187, 516);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(582, 76);
            this.txt_output.TabIndex = 22;
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(187, 339);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(582, 76);
            this.txt_input.TabIndex = 21;
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output.Location = new System.Drawing.Point(28, 567);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(115, 25);
            this.lb_output.TabIndex = 20;
            this.lb_output.Text = "Output Text";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(486, 619);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(96, 36);
            this.btn_thoat.TabIndex = 19;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(187, 619);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 36);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-43, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Key";
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input.Location = new System.Drawing.Point(28, 390);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(99, 25);
            this.lb_input.TabIndex = 15;
            this.lb_input.Text = "Input Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "RSA";
            // 
            // rtb_banma
            // 
            this.rtb_banma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_banma.Location = new System.Drawing.Point(187, 432);
            this.rtb_banma.Name = "rtb_banma";
            this.rtb_banma.Size = new System.Drawing.Size(582, 78);
            this.rtb_banma.TabIndex = 27;
            this.rtb_banma.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_KU);
            this.groupBox1.Controls.Add(this.lb_KR);
            this.groupBox1.Controls.Add(this.btn_tao);
            this.groupBox1.Controls.Add(this.txt_q);
            this.groupBox1.Controls.Add(this.txt_e);
            this.groupBox1.Controls.Add(this.txt_p);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 145);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo Key (KU và KR)";
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(280, 41);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(100, 22);
            this.txt_q.TabIndex = 5;
            // 
            // txt_e
            // 
            this.txt_e.Location = new System.Drawing.Point(89, 94);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(100, 22);
            this.txt_e.TabIndex = 4;
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(89, 41);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(100, 22);
            this.txt_p.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "p";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 78);
            this.label7.TabIndex = 29;
            this.label7.Text = "Các số trong bản mã";
            // 
            // lb_KR
            // 
            this.lb_KR.AutoSize = true;
            this.lb_KR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KR.Location = new System.Drawing.Point(430, 82);
            this.lb_KR.Name = "lb_KR";
            this.lb_KR.Size = new System.Drawing.Size(32, 19);
            this.lb_KR.TabIndex = 30;
            this.lb_KR.Text = "KR";
            // 
            // lb_KU
            // 
            this.lb_KU.AutoSize = true;
            this.lb_KU.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KU.Location = new System.Drawing.Point(430, 45);
            this.lb_KU.Name = "lb_KU";
            this.lb_KU.Size = new System.Drawing.Size(33, 19);
            this.lb_KU.TabIndex = 31;
            this.lb_KU.Text = "KU";
            // 
            // btn_tao
            // 
            this.btn_tao.Location = new System.Drawing.Point(280, 88);
            this.btn_tao.Name = "btn_tao";
            this.btn_tao.Size = new System.Drawing.Size(75, 23);
            this.btn_tao.TabIndex = 32;
            this.btn_tao.Text = "Tạo";
            this.btn_tao.UseVisualStyleBackColor = true;
            this.btn_tao.Click += new System.EventHandler(this.btn_tao_Click);
            // 
            // lb_key
            // 
            this.lb_key.AutoSize = true;
            this.lb_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_key.Location = new System.Drawing.Point(57, 271);
            this.lb_key.Name = "lb_key";
            this.lb_key.Size = new System.Drawing.Size(47, 25);
            this.lb_key.TabIndex = 30;
            this.lb_key.Text = "Key";
            // 
            // txt_k1
            // 
            this.txt_k1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k1.Location = new System.Drawing.Point(176, 269);
            this.txt_k1.Name = "txt_k1";
            this.txt_k1.Size = new System.Drawing.Size(63, 27);
            this.txt_k1.TabIndex = 31;
            // 
            // txt_k2
            // 
            this.txt_k2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k2.Location = new System.Drawing.Point(269, 269);
            this.txt_k2.Name = "txt_k2";
            this.txt_k2.Size = new System.Drawing.Size(63, 27);
            this.txt_k2.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(250, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = ",";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(143, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "{";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(353, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 19);
            this.label10.TabIndex = 37;
            this.label10.Text = "}";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 667);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_k2);
            this.Controls.Add(this.txt_k1);
            this.Controls.Add(this.lb_key);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtb_banma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_luachon);
            this.Controls.Add(this.btn_thuchien);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.label1);
            this.Name = "RSA";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.RSA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Button btn_thuchien;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_banma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_KU;
        private System.Windows.Forms.Label lb_KR;
        private System.Windows.Forms.Button btn_tao;
        private System.Windows.Forms.Label lb_key;
        private System.Windows.Forms.TextBox txt_k1;
        private System.Windows.Forms.TextBox txt_k2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}