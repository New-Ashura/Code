using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormATTT
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
            cb_luachon.SelectedIndex = 0;
        }
        
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RSA_Load(object sender, EventArgs e)
        {
            if(cb_luachon.Text=="Mã hóa")
            {
                lb_key.Text = "KU = ";
                txt_input.ReadOnly = false;
            }    
            if(cb_luachon.Text=="Giải mã")
            {
                lb_key.Text = "KR = ";
                txt_input.ReadOnly=true;
            }    
        }

        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            RSA_Load(sender, e);
        }
        private int Euclide(int e, int phi)
        {
            int t1 = 0, t2 = 1;
            int r2 = e;
            int r1 = phi;

            while (r2 > 0)
            {
                int q = r1 / r2;
                int r = r1 - r2 * q;

                if (r == 0)
                {
                    break;
                }

                int t = t1 - t2 * q;
                r1 = r2;
                r2 = r;
                t1 = t2;
                t2 = t;
            }

            if (r2 > 1)
            {
                return 0;
            }

            if (t2 < 0)
            {
                t2 += phi;
            }

            return t2;
        }
        private int UCLN(int a, int b)
        {

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
            if(int.TryParse(s, out so) && so>0)
            {
                return true;
            }    
            return false;
        }
        private void btn_tao_Click(object sender, EventArgs e)
        {
            if(ktra_so(txt_p.Text) && ktra_so(txt_q.Text) && ktra_so(txt_e.Text))
            {
                int p = Convert.ToInt32(txt_p.Text);
                if(ktraSoNguyenTo(p))
                {
                    int q = Convert.ToInt32(txt_q.Text);
                    if(ktraSoNguyenTo(q))
                    {
                        int phi = (p - 1) * (q - 1);
                        int so_e = Convert.ToInt32(txt_e.Text);
                        if(so_e>1 && so_e<phi)
                        {
                            if(UCLN(phi,so_e)==1)
                            {
                                int n = p * q;
                                int d = Euclide(so_e, phi);
                                lb_KU.Text = "KU={" + so_e + "," + n + "}";
                                lb_KR.Text = "KR={" + d + "," + n + "}";
                            }
                            else
                            {
                                MessageBox.Show("Số e không hợp lệ ! Với p=" + p + " và q=" + q + " thì e phải là số có UCLN với "+phi+"=1", "Thông báo");
                                txt_e.Focus();  
                            }   
                        }
                        else
                        {
                            MessageBox.Show("Số e không hợp lệ ! Với p=" + p + " và q=" + q + " thì e phải là số nằm trong khoảng (1<e<" + phi + ")", "Thông báo");
                            txt_e.Focus();
                        } 
                    }
                    else
                    {
                        MessageBox.Show(" Số q không phải số nguyên tố  !!!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show(" Số p không phải số nguyên tố  !!!", "Thông báo");
                } 
                   
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên tố !!!", "Thông báo");
            }
        }
        private bool KtraEmpty(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }
            else
            {
                return true;
            }
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
        private bool Ktra_ChuoiCanGiaiMa(string S)
        {
            string s = S.Trim();
                
            string chuoiktra = "0123456789,";
            foreach (char c in s)
            {
                string ktr = "";
                ktr += c;
                if (!chuoiktra.Contains(ktr))
                {
                    return false;
                }
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Equals(','))
                {
                    if (s[i].Equals(s[i + 1]))
                    {
                        return false;
                    }
                }
            }
            return true;
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
        private void MaHoa(int[] KU, string banro /*int[] matrix*/)
        {
            /*string banma = "";*/
            int[] matrix = new int[banro.Length];
            int index = 0;
            foreach (char c in banro)
            {
                int so = c - 65;
                matrix[index] = tinhmod(so, KU[0], KU[1]);
                index++;
                /*char kytumahoa = (char)(tinhmod(so, KU[0], KU[1]));
                banma += kytumahoa;*/
            }
            string daysobanma = "";
            for(int i = 0; i < matrix.Length; i++)
            {
                daysobanma = daysobanma + matrix[i]+",";
            }   
            rtb_banma.Text = daysobanma;
            
        }
        
        private void GiaiMa(int[] KR, int[] matrix)
        {
            string banro = "";
            for (int i = 0; i < matrix.Length; i++)
            {
                int so = (tinhmod(matrix[i], KR[0], KR[1]));
                char kytugiaima = (char)(so + 65);
                banro += kytugiaima;
            }
            txt_output.Text = banro;
        }
        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            if(ktra_so(txt_k1.Text) && ktra_so(txt_k2.Text))
            {
                int k1 = Convert.ToInt32(txt_k1.Text);
                int k2 = Convert.ToInt32(txt_k2.Text);
                if (cb_luachon.Text == "Mã hóa")
                {
                    if(KtraEmpty(txt_input.Text))
                    {
                        if (Ktra_TiengViet(txt_input.Text))
                        {
                            string Input = txt_input.Text;
                            string banro = "";
                            foreach (char c in Input)
                            {
                                if (char.IsLetter(c))
                                {
                                    banro = banro + c;
                                }
                            }
                            banro = banro.ToUpper();
                            int[] KU = new int[2];
                            KU[0] = k1;
                            KU[1] = k2;
                            MaHoa(KU, banro);
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu không hợp lệ !! Tiếng việt không dấu  ", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập thông tin ô input ", "Thông báo");
                        txt_input.Focus();
                    }
                     
                }
                if (cb_luachon.Text == "Giải mã")
                {
                    if(Ktra_ChuoiCanGiaiMa(rtb_banma.Text))
                    {
                        string chuoicangiaima = rtb_banma.Text.Trim();
                        if (chuoicangiaima[chuoicangiaima.Length-1].Equals(','))
                        {
                            chuoicangiaima = chuoicangiaima.Substring(0, chuoicangiaima.Length - 1);
                        }    
                        string[] arrstr = chuoicangiaima.Split(',');
                        int[] matrix = new int[arrstr.Length];
                        for(int i = 0; i < arrstr.Length; i++)
                        {
                            matrix[i] = int.Parse(arrstr[i]);
                        }
                        int[] KR = new int[2];
                        KR[0] = k1;
                        KR[1] = k2;
                        GiaiMa(KR, matrix);
                    }
                    else
                    {
                        MessageBox.Show("Chuỗi cần giải mã không hợp lê !!\nYêu cần chỉ cố số và dấu phẩy", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập key là số!!!", "Thông báo");
            } 
              
        }
    }
}
