using System;
using System.Collections;
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
    public partial class Vigenere : Form
    {
        /*static ArrayList arrinput = new ArrayList();
         static ArrayList arrkey = new ArrayList();*/
        private string input;
        private string k;
        public Vigenere()
        {
            InitializeComponent();
            cb_luachon.SelectedIndex = 0;
            btn_tinh.Text = cb_luachon.Text;
        }

        private void Vigenere_Load(object sender, EventArgs e)
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



        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vigenere_Load(sender, e);
            btn_tinh.Text = cb_luachon.Text;
            txt_input.Text = txt_output.Text;
            txt_output.Clear();
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
        public  int Getchiso(char c)
        {
            if (char.IsDigit(c))
            {
                return 47;
            }
            else if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                {
                    return 54;
                }
                else
                {
                    return 60;
                }
            }
            else
            {
                return 32;
            }
        }
        public  int Getchiso2(int n)
        {
            if (n > 0 && n <= 10)
            {
                return 47;
            }
            else if (n > 10 && n <= 36)
            {
                return 54;
            }
            else if (n > 36 && n <= 62)
            {
                return 60;
            }
            else
            {
                return 32;
            }
        }
        private  void MaHoa(string banro, string key)
        {
            ArrayList arrinput = new ArrayList();
            foreach (char c in banro)
            {
                /*           if (char.IsLetter(c))
                           {*/
                arrinput.Add(c);
                /*            }*/
            }
            ArrayList arrkey = new ArrayList();
            if (arrinput.Count < key.Length)
            {
                foreach (char c in key)
                {
                    arrkey.Add(c);
                }
                arrkey.RemoveRange((arrinput.Count), (arrkey.Count - arrinput.Count));
            }
            else
            {
                int n = (arrinput.Count / key.Length) + 1;
                for (int i = 0; i < n; i++)
                {
                    foreach (char c in key)
                    {
                        arrkey.Add(c);
                    }
                }
                /*Console.WriteLine("key chưa xóa là : ");
                foreach (char c in arrkey)
                {
                    Console.Write(c);
                }
                Console.WriteLine();*/
                arrkey.RemoveRange((arrinput.Count), (arrkey.Count - arrinput.Count));
            }
            /* Console.WriteLine("key là : ");
             foreach (char c in arrkey)
             {
                 Console.Write(c);
             }    
             Console.WriteLine();*/
            string banma = "";
            int index = 0;
            foreach (char c in banro)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c) && !c.Equals(' '))
                {
                    banma = banma + c;
                }
                else
                {
                    int chisoP = Getchiso(c);
                    int chisoKey = Getchiso((char)arrkey[index]);
                    int chisove = Getchiso2((((c - chisoP) + ((char)arrkey[index] - chisoKey)) % 63));

                    /*Console.WriteLine("====================================");
                    Console.WriteLine("\nChi so ban dau : " + (((c - chisoP) + ((char)arrkey[index] - chisoKey)) % 63));
                    Console.WriteLine("\nChi so ve : " + chisove);
                    Console.WriteLine("====================================");*/

                    char kytumahoa = (char)((((c - chisoP) + ((char)arrkey[index] - chisoKey)) % 63) + chisove);
                    index++;
                    banma = banma + kytumahoa;
                }
            }
            txt_output.Text = banma;
            /*Console.WriteLine("Bản mã nhận được là : " + banma);*/
        }
        private void GiaiMa(string banma, string key)
        {
            ArrayList arrinput = new ArrayList();
            foreach (char c in banma)
            {
                /*if (char.IsLetter(c))
                {*/
                arrinput.Add(c);
                /*}*/
            }
            ArrayList arrkey = new ArrayList();
            if (arrinput.Count < key.Length)
            {
                foreach (char c in key)
                {
                    arrkey.Add(c);
                }
                arrkey.RemoveRange((arrinput.Count), (arrkey.Count - arrinput.Count));
            }
            else
            {
                int m = (arrinput.Count / key.Length) + 1;
                for (int i = 0; i < m; i++)
                {
                    foreach (char c in key)
                    {
                        arrkey.Add(c);
                    }
                }
                arrkey.RemoveRange((arrinput.Count), (arrkey.Count - arrinput.Count));
            }

            string bangro = "";
            int index2 = 0;
            foreach (char c in banma)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c) && !c.Equals(' '))
                {
                    bangro = bangro + c;
                }
                else
                {
                    int chisoC = Getchiso(c);
                    int chisoKhoa = Getchiso((char)arrkey[index2]);
                    int chisove = Getchiso2(((((c - chisoC) - ((char)arrkey[index2] - chisoKhoa)) + 63) % 63));

                    char kytumahoa = (char)(((((c - chisoC) - ((char)arrkey[index2] - chisoKhoa)) + 63) % 63) + chisove);
                    index2++;
                    bangro = bangro + kytumahoa;
                }
            }
            txt_output.Text = bangro;
            /*Console.WriteLine("Bản rõ nhận được là : " + bangiaima);*/
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
        private void btn_tinh_Click(object sender, EventArgs e)
        {
            if(KtraEmpty(txt_input.Text) && KtraEmpty(txt_key.Text))
            {
                if(Ktra_TiengViet(txt_input.Text) && Ktra_TiengViet(txt_key.Text))
                {
                    input=txt_input.Text;
                    k=txt_key.Text;
                    if(cb_luachon.Text=="Mã hóa")
                    {
                        MaHoa(input, k);
                    }    
                    if(cb_luachon.Text=="Giải mã")
                    {
                        GiaiMa(input, k);
                    }    
                }
                else
                {
                    MessageBox.Show("chuỗi nhập vào không hợp lệ", "Thông báo");
                } 
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo");
            } 
        }
    }
}
