namespace FormATTT
{
    partial class Thaythe
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lb_input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Thay Thế";
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(648, 200);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(89, 61);
            this.btn_tinh.TabIndex = 35;
            this.btn_tinh.Text = "Thực hiện";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Lựa chọn";
            // 
            // cb_luachon
            // 
            this.cb_luachon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Items.AddRange(new object[] {
            "Mã hóa",
            "Giải mã"});
            this.cb_luachon.Location = new System.Drawing.Point(635, 150);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.Size = new System.Drawing.Size(121, 24);
            this.cb_luachon.TabIndex = 33;
            this.cb_luachon.SelectedIndexChanged += new System.EventHandler(this.cb_luachon_SelectedIndexChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(715, 302);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 54);
            this.btn_thoat.TabIndex = 32;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(604, 303);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(89, 52);
            this.btn_clear.TabIndex = 31;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(174, 339);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(404, 97);
            this.txt_output.TabIndex = 30;
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output.Location = new System.Drawing.Point(29, 376);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(106, 25);
            this.lb_output.TabIndex = 29;
            this.lb_output.Text = "Cipher text";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(174, 253);
            this.txt_key.Multiline = true;
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(404, 32);
            this.txt_key.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Key";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(174, 64);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(404, 135);
            this.txt_input.TabIndex = 26;
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input.Location = new System.Drawing.Point(31, 124);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(91, 25);
            this.lb_input.TabIndex = 25;
            this.lb_input.Text = "Plain text";
            // 
            // Thaythe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 500);
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
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.label1);
            this.Name = "Thaythe";
            this.Text = "Thaythe";
            this.Load += new System.EventHandler(this.Thaythe_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lb_input;
    }
}