using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormATTT
{
    public partial class Caesar : Form
    {
        public Caesar()
        {
            InitializeComponent();
            cb_luachon.SelectedIndex = 0;
            btn_tinh.Text = cb_luachon.Text;
        }

        private void Ceasar_Load(object sender, EventArgs e)
        {
            if(cb_luachon.SelectedItem == "Mã hóa")
            {
                input_lb.Text = "Bản rõ";
                lb_output.Text = "Bản mã";
            }
            if (cb_luachon.SelectedItem == "Giải mã")
            {
                input_lb.Text = "Bản mã";
                lb_output.Text = "Bản rõ";
            }
        }
        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ceasar_Load(sender, e);
            btn_tinh.Text=cb_luachon.Text;
            txt_input.Text = txt_output.Text;
            txt_output.Clear();
            
        }
        private string MaHoa(string input, int key)
        {
            string thongtinmahoa = "";
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    thongtinmahoa += c;
                }
                else
                {
                    char str = char.IsUpper(c) ? 'A' : 'a';
                    char kytumahoa = (char)(((c + key) - str) % 26 + str);
                    thongtinmahoa += kytumahoa;
                }
            }
            return thongtinmahoa;
        }
        private string GiaiMa(string output, int key)
        {
            string thongtingiaima = "";
            foreach (char c in output)
            {
                if (!char.IsLetter(c))
                {
                    thongtingiaima += c;
                }
                else
                {
                    char str = char.IsUpper(c) ? 'A' : 'a';
                    char kytugiaima = (char)(((c - key) - str + 26) % 26 + str);
                    thongtingiaima += kytugiaima;
                }
            }
            return thongtingiaima;
        }
        private bool Ktra_TiengViet(string S)
        {
            string s = "";
            foreach (char c in S)
            {
                if (char.IsLetter(c))
                {
                    s = s + c;
                }
            }
            string bcc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            s = s.ToUpper();
            foreach (char c in s)
            {
                string ktr = "";
                ktr += c;
                if (!bcc.Contains(ktr))
                {
                    return false;
                }
            }
            return true;
        }
        private void btn_tinh_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_input.Text) && !string.IsNullOrWhiteSpace(txt_key.Text))
            {
                if(Ktra_TiengViet(txt_input.Text))
                {
                    int key;
                    string input = txt_input.Text;
                    string INPUT = "";
                    foreach (char c in input)
                    {
                        if (char.IsLetter(c))
                        {
                            INPUT = INPUT + c;
                        }
                    }
                    if (int.TryParse(txt_key.Text, out key) && key > 0)
                    {
                        if (cb_luachon.SelectedItem == "Mã hóa")
                        {
                            txt_output.Text = MaHoa(INPUT, key);
                        }
                        if (cb_luachon.SelectedItem == "Giải mã")
                        {
                            txt_output.Text = GiaiMa(INPUT, key);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Key vui lòng nhập số lớn hơn 0", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Input vui lòng nhập tiếng việt không dấu", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống Input và key!!!", "Thông báo");
            }    
                
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
            txt_input.Clear();
            txt_key.Clear();
            txt_input.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
