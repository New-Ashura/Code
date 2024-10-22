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
    public partial class Thaythe : Form
    {
        ArrayList K = new ArrayList();
        private string input;
        
        private char[] key = new char[26];
        public Thaythe()
        {
            InitializeComponent();
            cb_luachon.SelectedIndex = 0;
            btn_tinh.Text = cb_luachon.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thaythe_Load(sender, e);
            btn_tinh.Text = cb_luachon.Text;
            txt_input.Text = txt_output.Text;
            txt_output.Clear();
        }

        private void Thaythe_Load(object sender, EventArgs e)
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
        private void MaHoa(string INPUT, ArrayList key)
        {
            string thongtinmahoa = "";
            foreach (char c in INPUT)
            {
                if (!char.IsLetter(c))
                {
                    thongtinmahoa += c;
                }
                else
                {
                    if (char.IsUpper(c))
                    {
                        int i = (int)((c - 65) % 26);
                        char kytumahoa = (char)key[i];
                        thongtinmahoa += kytumahoa;
                    }
                    else
                    {
                        int i = (int)((c - 97) % 26);
                        char kytumahoa = char.ToLower((char)key[i]);
                        thongtinmahoa += kytumahoa;
                    }

                }
            }
            /*Console.WriteLine(test);*/
            /*Console.WriteLine("Bản mã tương ứng là : " + thongtinmahoa);*/
            txt_output.Text = thongtinmahoa;
        }
        private void GiaiMa(string INPUT, ArrayList key)
        {
            string thongtingiaima = "";
            foreach (char c in INPUT)
            {
                if (!char.IsLetter(c))
                {
                    thongtingiaima += c;
                }
                else
                {
                    if (char.IsUpper(c))
                    {
                        for (int j = 0; j < key.Count; j++)
                        {
                            if (key[j].Equals(c))
                            {
                                char kytugiaima = (char)(j + 65);
                                thongtingiaima += kytugiaima;
                            }
                        }
                    }
                    else
                    {
                        char chu = char.ToUpper(c);
                        for (int j = 0; j < key.Count; j++)
                        {
                            if (key[j].Equals(chu))
                            {
                                char kytugiaima = (char)(j + 97);
                                thongtingiaima += kytugiaima;
                            }
                        }
                    }

                }
            }
            /*Console.WriteLine("Thông tin đã được giải mã: " + thongtingiaima);*/
            txt_output.Text = thongtingiaima;
        }
        private bool Ktra_Key()
        {
            K.Clear();
            foreach(char c in txt_key.Text)
            {
                
                if(char.IsLetter(c))
                {
                    K.Add(c);
                }    
            }
            for (int i = 0; i < K.Count-1;i++)
            {
                for(int j = i+1; j < K.Count;j++)
                {
                    if (K[i].Equals(K[j]))
                    {
                        K.RemoveAt(j);
                        j--;
                    }    
                }    
            }
            if(K.Count == 26)
            {
                return true;
            }
            else
            {
                return false;
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
            foreach(char c in S)
            {
                if(char.IsLetter(c))
                {
                    s = s + c;
                }    
            }    
            string bcc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            s=s.ToUpper();
            foreach (char c in s )
            {
                string ktr = "";
                ktr += c;
                if(!bcc.Contains(ktr))
                {
                    return false;
                }    
            }
            
            return true;
        }
        private void btn_tinh_Click(object sender, EventArgs e)
        {
            if(KtraEmpty(txt_input.Text)&&KtraEmpty(txt_key.Text))
            {
                if (Ktra_TiengViet(txt_input.Text) && Ktra_TiengViet(txt_key.Text))
                {
                    if (Ktra_Key())
                    {
                        try
                        {
                            input = txt_input.Text;
                            if (cb_luachon.Text == "Mã hóa")
                            {
                                MaHoa(input, K);
                            }
                            if (cb_luachon.Text == "Giải mã")
                            {
                                GiaiMa(input, K);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin nhập không hợp lệ!!!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Key không hợp lệ !!!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chuỗi nhập vào chứa ký tự không hợp lệ !!!", "Thông báo");
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống thông tin !!!", "Thông báo");
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
