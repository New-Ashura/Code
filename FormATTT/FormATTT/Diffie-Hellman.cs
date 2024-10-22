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
    public partial class Diffie_Hellman : Form
    {
        public Diffie_Hellman()
        {
            InitializeComponent();
        }
        private bool ktraSoNguyenTo(int a)
        {
            if (a <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private bool ktra_so(string s)
        {
            int so;
            if (int.TryParse(s, out so) && so > 0)
            {
                return true;
            }
            return false;
        }
        private int tinhmod(int so, int mu, int mod)
        {
            int kq = 1;
            int dem = mu / 2;
            if (mu % 2 == 0)
            {
                for (int i = 0; i < dem; i++)
                {
                    int temp = (int)Math.Pow(so, 2);
                    kq = kq * temp % mod;
                }
                kq = kq % mod;
            }
            else
            {
                for (int i = 0; i < dem; i++)
                {
                    int temp = (int)Math.Pow(so, 2);
                    kq = kq * temp % mod;
                }
                int temp2 = (int)Math.Pow(so, 1);
                kq = kq * temp2 % mod;
                kq = kq % mod;
            }

            return kq;
        }
        private void btn_timkhoacongkhai_Click(object sender, EventArgs e)
        {
            if(ktra_so(txt_q.Text) && ktra_so(txt_alpha.Text) && ktra_so(txt_khoarieng.Text))
            {
                int q = Convert.ToInt32(txt_q.Text);
                int alpha = Convert.ToInt32(txt_alpha.Text);
                if(ktraSoNguyenTo(q) && ktraSoNguyenTo(alpha))
                {
                    int X = Convert.ToInt32(txt_khoarieng.Text);
                    if(X<q)
                    {
                        int Y = tinhmod(alpha, X, q);
                        txt_ycuaminh.Text=Y.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn khóa riêng bé hơn số q", "Thông báo");
                        txt_khoarieng.Focus();
                    }  
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên tố","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số !!!", "Thông báo");
            } 
        }

        private void btn_khoachung_Click(object sender, EventArgs e)
        {
            if (ktra_so(txt_ycuaban.Text) && ktra_so(txt_q.Text) && ktra_so(txt_khoarieng.Text))
            {
                int q = Convert.ToInt32(txt_q.Text);
                if (ktraSoNguyenTo(q))
                {
                    int X = Convert.ToInt32(txt_khoarieng.Text);
                    int Y = Convert.ToInt32(txt_ycuaban.Text);
                    if (X < q)
                    {
                        int K = tinhmod(Y, X, q);
                        txt_khoachung.Text = K.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn khóa riêng bé hơn số q", "Thông báo");
                        txt_khoarieng.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên tố", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số !!!", "Thông báo");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
