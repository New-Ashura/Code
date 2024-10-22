namespace FormATTT
{
    partial class Hoanvi
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
            this.lb_input = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_thuchien = new System.Windows.Forms.Button();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hoán Vị";
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input.Location = new System.Drawing.Point(31, 87);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(99, 25);
            this.lb_input.TabIndex = 1;
            this.lb_input.Text = "Input Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Key";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(136, 220);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(279, 22);
            this.txt_key.TabIndex = 4;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(725, 303);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 36);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(859, 303);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(96, 36);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output.Location = new System.Drawing.Point(15, 394);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(115, 25);
            this.lb_output.TabIndex = 8;
            this.lb_output.Text = "Output Text";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(136, 54);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(552, 126);
            this.txt_input.TabIndex = 9;
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output.Location = new System.Drawing.Point(136, 325);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(552, 126);
            this.txt_output.TabIndex = 10;
            // 
            // btn_thuchien
            // 
            this.btn_thuchien.Location = new System.Drawing.Point(784, 238);
            this.btn_thuchien.Name = "btn_thuchien";
            this.btn_thuchien.Size = new System.Drawing.Size(87, 36);
            this.btn_thuchien.TabIndex = 11;
            this.btn_thuchien.Text = "Thực hiện";
            this.btn_thuchien.UseVisualStyleBackColor = true;
            this.btn_thuchien.Click += new System.EventHandler(this.btn_thuchien_Click);
            // 
            // cb_luachon
            // 
            this.cb_luachon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Items.AddRange(new object[] {
            "Mã hóa",
            "Giải mã"});
            this.cb_luachon.Location = new System.Drawing.Point(765, 198);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.Size = new System.Drawing.Size(121, 24);
            this.cb_luachon.TabIndex = 12;
            this.cb_luachon.SelectedIndexChanged += new System.EventHandler(this.cb_luachon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lụa chọn";
            // 
            // Hoanvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 606);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_luachon);
            this.Controls.Add(this.btn_thuchien);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.label1);
            this.Name = "Hoanvi";
            this.Text = "Hoanvi";
            this.Load += new System.EventHandler(this.Hoanvi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_thuchien;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Label label6;
    }
}