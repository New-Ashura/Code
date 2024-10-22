using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormATTT
{
    public partial class Affine : Form
    {
        private int soa;
        private int sob;
        public Affine()
        {
            InitializeComponent();
            cb_luachon.SelectedIndex = 0;
            btn_tinh.Text = cb_luachon.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Affine_Load(sender, e);
            btn_tinh.Text = cb_luachon.Text;
            txt_input.Text = txt_output.Text;
            txt_output.Clear();
        }

        private void Affine_Load(object sender, EventArgs e)
        {
            if (cb_luachon.SelectedItem == "Mã hóa")
            {
                lb_input.Text = "Bản rõ";
                lb_output.Text = "Bản mã";
            }
            if (cb_luachon.SelectedItem == "Giải mã")
            {
                lb_input.Text = "Bản mã";
                lb_output.Text = "Bản rõ";
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int TimSo(int a)
        {
            //(a*a^-1)mod26=1
            bool ktra = true;
            int dem = 1;
            while (ktra)
            {
                /*Console.WriteLine("Lần thứ "+dem);*/
                int so = (a * dem) % 26;
                if (so == 1)
                {
                    ktra = false;
                }
                else
                {
                    dem++;
                }
            }
            return dem;
        }
        private int Tinhchisomahoa(int a, int b, char c)
        {
            //(ax+b)mod26
            int so = c - GetBase(c);
            int ketqua = (a * so + b) % 26;
            return ketqua;
        }

        private int Tinhchisogiaima(int a, int b, char c)
        {
            //a^-1*(y-b)mod26
            int k = TimSo(a);
            int so = c - GetBase(c);
            int ketqua = (k * (so - b + 26)) % 26;
            return ketqua;
        }
        private int GetBase(char c)
        {
            if (char.IsUpper(c))
            {
                return 65;
            }
            else
            {
                return 97;
            }
        }
        private int UCLN(int a)
        {
            int b = 26;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else if (a < b)
                {
                    b = b - a;
                }
            }
            return b;
        }
        private void MaHoa(string p, int a, int b)
        {
            string banma = "";
            foreach (char c in p)
            {
                if (!char.IsLetter(c))
                {
                    banma += c;
                }
                else
                {
                    int chiso = GetBase(c);
                    char kytumahoa = (char)(Tinhchisomahoa(a, b, c) + chiso);
                    banma = banma + kytumahoa;
                }
            }
            txt_output.Text = banma;
        }
        private void GiaiMa(string C, int a, int b)
        {
            string banro = "";
            foreach (char c in C)
            {
                if (!char.IsLetter(c))
                {
                    banro += c;
                }
                else
                {
                    int chiso = GetBase(c);
                    char kytugiaima = (char)(Tinhchisogiaima(a, b, c) + chiso);
                    banro = banro + kytugiaima;
                }
            }
            txt_output.Text= banro;
            
            Console.WriteLine("Bản rõ nhận được là : " + banro);
        }
        /*private bool KtraSo(string s)
        {
            int so;
            if(int.TryParse(s, out so) && so>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        private bool KtraEmpty(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool Ktra_a(string txt_a)
        {
            try
            {
                soa= int.Parse(txt_a);
                if(UCLN(soa)==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        private bool Ktra_b(string txt_b)
        {
            try
            {
                sob = int.Parse(txt_b);
                if (sob>0 && sob<26)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        private void btn_tinh_Click(object sender, EventArgs e)
        {
            if(KtraEmpty(txt_input.Text)&&KtraEmpty(txt_a.Text)&&KtraEmpty(txt_b.Text))
            {
                if(Ktra_a(txt_a.Text))
                {
                    if(Ktra_b(txt_b.Text))
                    {
                        if(cb_luachon.Text=="Mã hóa")
                        {
                            MaHoa(txt_input.Text, soa, sob);
                        }    
                        if(cb_luachon.Text=="Giải mã")
                        {
                            GiaiMa(txt_input.Text, soa, sob);
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập b là một số từ 1 đến 25 !!!", "Thông báo");
                        txt_b.Clear();
                        txt_b.Focus();
                    }  
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập a là một số lẻ khác 13!!!", "Thông báo");
                    txt_a.Clear();
                    txt_a.Focus();
                }  
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống thông tin", "Thông báo");
            }
             
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
            txt_input.Clear();
            txt_a.Clear();
            txt_b.Clear();
            txt_input.Focus();
        }
    }
}
