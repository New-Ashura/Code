namespace FormATTT
{
    partial class Vigenere
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
            this.btn_tinh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lb_output = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lb_input = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Vigenere";
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(577, 256);
            this.btn_tinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(86, 48);
            this.btn_tinh.TabIndex = 45;
            this.btn_tinh.Text = "Thực hiện";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Lựa chọn";
            // 
            // cb_luachon
            // 
            this.cb_luachon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Items.AddRange(new object[] {
            "Mã hóa",
            "Giải mã"});
            this.cb_luachon.Location = new System.Drawing.Point(562, 200);
            this.cb_luachon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.Size = new System.Drawing.Size(151, 23);
            this.cb_luachon.TabIndex = 43;
            this.cb_luachon.SelectedIndexChanged += new System.EventHandler(this.cb_luachon_SelectedIndexChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(740, 188);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(87, 45);
            this.btn_thoat.TabIndex = 42;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(675, 256);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(74, 46);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(193, 336);
            this.txt_output.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(491, 74);
            this.txt_output.TabIndex = 40;
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output.Location = new System.Drawing.Point(50, 365);
            this.lb_output.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(106, 25);
            this.lb_output.TabIndex = 39;
            this.lb_output.Text = "Cipher text";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(187, 256);
            this.txt_key.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_key.Multiline = true;
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(298, 38);
            this.txt_key.TabIndex = 38;
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(193, 126);
            this.txt_input.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(292, 60);
            this.txt_input.TabIndex = 37;
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input.Location = new System.Drawing.Point(50, 126);
            this.lb_input.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(91, 25);
            this.lb_input.TabIndex = 36;
            this.lb_input.Text = "Plain text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Key";
            // 
            // Vigenere
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(849, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_luachon);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Vigenere";
            this.Text = "Vigenere";
            this.Load += new System.EventHandler(this.Vigenere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Label label2;
    }
}