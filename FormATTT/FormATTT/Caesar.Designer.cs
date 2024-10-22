namespace FormATTT
{
    partial class Caesar
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
            this.input_lb = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.lb_output = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Caesar";
            // 
            // input_lb
            // 
            this.input_lb.AutoSize = true;
            this.input_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_lb.Location = new System.Drawing.Point(111, 155);
            this.input_lb.Name = "input_lb";
            this.input_lb.Size = new System.Drawing.Size(91, 25);
            this.input_lb.TabIndex = 1;
            this.input_lb.Text = "Plain text";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(254, 95);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(404, 135);
            this.txt_input.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Key";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(254, 284);
            this.txt_key.Multiline = true;
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(239, 32);
            this.txt_key.TabIndex = 4;
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output.Location = new System.Drawing.Point(109, 407);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(106, 25);
            this.lb_output.TabIndex = 5;
            this.lb_output.Text = "Cipher text";
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output.Location = new System.Drawing.Point(254, 370);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(404, 97);
            this.txt_output.TabIndex = 6;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(684, 334);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(89, 52);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(795, 333);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 54);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cb_luachon
            // 
            this.cb_luachon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Items.AddRange(new object[] {
            "Mã hóa",
            "Giải mã"});
            this.cb_luachon.Location = new System.Drawing.Point(715, 181);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.Size = new System.Drawing.Size(121, 24);
            this.cb_luachon.TabIndex = 11;
            this.cb_luachon.SelectedIndexChanged += new System.EventHandler(this.cb_luachon_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lựa chọn";
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(728, 231);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(89, 61);
            this.btn_tinh.TabIndex = 13;
            this.btn_tinh.Text = "Thực hiện";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // Caesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 538);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_luachon);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.input_lb);
            this.Controls.Add(this.label1);
            this.Name = "Caesar";
            this.Text = "Caesar";
            this.Load += new System.EventHandler(this.Ceasar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label input_lb;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_tinh;
    }
}