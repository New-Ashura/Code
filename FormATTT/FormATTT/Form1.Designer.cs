namespace FormATTT
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mãHóaCổĐiểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ceasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayThếĐơnBảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playfairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoánVịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vigenereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mãHóaHiệnĐạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diffieHellmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mãHóaCổĐiểnToolStripMenuItem,
            this.mãHóaHiệnĐạiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mãHóaCổĐiểnToolStripMenuItem
            // 
            this.mãHóaCổĐiểnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ceasarToolStripMenuItem,
            this.thayThếĐơnBảngToolStripMenuItem,
            this.playfairToolStripMenuItem,
            this.hoánVịToolStripMenuItem,
            this.vigenereToolStripMenuItem,
            this.affineToolStripMenuItem,
            this.hillToolStripMenuItem});
            this.mãHóaCổĐiểnToolStripMenuItem.Name = "mãHóaCổĐiểnToolStripMenuItem";
            this.mãHóaCổĐiểnToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.mãHóaCổĐiểnToolStripMenuItem.Text = "Mã hóa cổ điển";
            // 
            // ceasarToolStripMenuItem
            // 
            this.ceasarToolStripMenuItem.Name = "ceasarToolStripMenuItem";
            this.ceasarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ceasarToolStripMenuItem.Text = "Ceasar";
            this.ceasarToolStripMenuItem.Click += new System.EventHandler(this.ceasarToolStripMenuItem_Click);
            // 
            // thayThếĐơnBảngToolStripMenuItem
            // 
            this.thayThếĐơnBảngToolStripMenuItem.Name = "thayThếĐơnBảngToolStripMenuItem";
            this.thayThếĐơnBảngToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.thayThếĐơnBảngToolStripMenuItem.Text = "Thay thế đơn bảng";
            this.thayThếĐơnBảngToolStripMenuItem.Click += new System.EventHandler(this.thayThếĐơnBảngToolStripMenuItem_Click);
            // 
            // playfairToolStripMenuItem
            // 
            this.playfairToolStripMenuItem.Name = "playfairToolStripMenuItem";
            this.playfairToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.playfairToolStripMenuItem.Text = " Playfair";
            this.playfairToolStripMenuItem.Click += new System.EventHandler(this.playfairToolStripMenuItem_Click);
            // 
            // hoánVịToolStripMenuItem
            // 
            this.hoánVịToolStripMenuItem.Name = "hoánVịToolStripMenuItem";
            this.hoánVịToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.hoánVịToolStripMenuItem.Text = "Hoán vị";
            this.hoánVịToolStripMenuItem.Click += new System.EventHandler(this.hoánVịToolStripMenuItem_Click);
            // 
            // vigenereToolStripMenuItem
            // 
            this.vigenereToolStripMenuItem.Name = "vigenereToolStripMenuItem";
            this.vigenereToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.vigenereToolStripMenuItem.Text = "Vigenere";
            this.vigenereToolStripMenuItem.Click += new System.EventHandler(this.vigenereToolStripMenuItem_Click);
            // 
            // affineToolStripMenuItem
            // 
            this.affineToolStripMenuItem.Name = "affineToolStripMenuItem";
            this.affineToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.affineToolStripMenuItem.Text = "Affine";
            this.affineToolStripMenuItem.Click += new System.EventHandler(this.affineToolStripMenuItem_Click);
            // 
            // hillToolStripMenuItem
            // 
            this.hillToolStripMenuItem.Name = "hillToolStripMenuItem";
            this.hillToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.hillToolStripMenuItem.Text = "Hill";
            this.hillToolStripMenuItem.Click += new System.EventHandler(this.hillToolStripMenuItem_Click);
            // 
            // mãHóaHiệnĐạiToolStripMenuItem
            // 
            this.mãHóaHiệnĐạiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSAToolStripMenuItem,
            this.diffieHellmanToolStripMenuItem});
            this.mãHóaHiệnĐạiToolStripMenuItem.Name = "mãHóaHiệnĐạiToolStripMenuItem";
            this.mãHóaHiệnĐạiToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mãHóaHiệnĐạiToolStripMenuItem.Text = "Mã hóa hiện đại";
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // diffieHellmanToolStripMenuItem
            // 
            this.diffieHellmanToolStripMenuItem.Name = "diffieHellmanToolStripMenuItem";
            this.diffieHellmanToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.diffieHellmanToolStripMenuItem.Text = "Diffie-Hellman";
            this.diffieHellmanToolStripMenuItem.Click += new System.EventHandler(this.diffieHellmanToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "THỰC TẬP AN TOÀN THÔNG TIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhóm 5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giảng viên hướng dẫn : Doãn Thị Thuý Hiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thành viên nhóm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(317, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "An Đình Đại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(317, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đỗ Minh Hiếu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(289, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nguyễn Thế Thắng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mãHóaCổĐiểnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ceasarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayThếĐơnBảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playfairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoánVịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vigenereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mãHóaHiệnĐạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diffieHellmanToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

