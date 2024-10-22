using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormATTT
{
    public partial class Hoanvi : Form
    {
        private string input;
        private string key;
        public Hoanvi()
        {
            InitializeComponent();
            cb_luachon.SelectedIndex = 0;
        }
        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_input.Text=txt_output.Text;
            btn_thuchien.Text = cb_luachon.Text;
            txt_output.Clear();
            Hoanvi_Load(sender,e);
        }
        private void MaHoa(string key, string p)
        {
            int col = key.Length;
            int row = (p.Length) / col + 2;
            string[,] matrix = new string[row, col];
            int index = 0;
            int index1 = 0;
            for (int i = 0; i < row; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < col; j++)
                    {
                        string str = "" + key[index1];
                        matrix[i, j] = str;
                        index1++;
                    }
                }
                else
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (index < p.Length)
                        {
                            matrix[i, j] = "" + p[index];
                            index++;
                        }
                    }
                }
            }
            /*Console.WriteLine("Ma trận có được là : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("==================");*/
            int stt = 1;
            string kytumahoa = "";
            while (stt <= key.Length)
            {
                for (int i = 0; i < col; i++)
                {
                    string sosanh = "" + stt;
                    if (matrix[0, i].Equals(sosanh))
                    {

                        for (int j = 1; j < row; j++)
                        {
                            kytumahoa = kytumahoa + matrix[j, i];
                        }
                        stt++;
                    }
                }
            }
            txt_output.Text = kytumahoa;
            //Console.WriteLine("Chuỗi sau khi mã hóa là : " + kytumahoa);
        }
        private void GiaiMa(string key, string banma)
        {
            int col = key.Length;
            int row = (banma.Length) / col + 2;
            string[,] matrix2 = new string[row, col];
            int phandu = banma.Length % col;
            for (int i = 0; i < col; i++)
            {
                matrix2[0, i] = "" + key[i];
            }
            int chiso = 1;
            int index3 = 0;
            while (chiso <= key.Length)
            {
                string sosanh = "" + chiso;
                for (int i = 0; i < col; i++)
                {
                    if (matrix2[0, i].Equals(sosanh))
                    {
                        if (i < phandu)
                        {
                            for (int j = 1; j < row; j++)
                            {
                                matrix2[j, i] = "" + banma[index3];
                                index3++;
                            }
                        }
                        else
                        {


                            for (int j = 1; j < row - 1; j++)
                            {
                                matrix2[j, i] = "" + banma[index3];
                                index3++;
                            }
                        }
                    }
                }
                chiso++;
            }
            /*Console.WriteLine("Ta có ma trận : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix2[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("====================");*/
            int ktra = 0;
            string kytugiaima = "";
            for (int i = 1; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (ktra < banma.Length)
                    {
                        kytugiaima += matrix2[i, j];
                    }
                }
            }
            txt_output.Text = kytugiaima;
            //Console.WriteLine("Bản rõ sau khi giải mã là : " + kytugiaima);
        }
        private bool Ktra_Key()
        {
            int max = 0;
            key = txt_key.Text.Trim();
            foreach(char c in key)
            {
                if(c.Equals(' '))
                if(char.IsLetter(c))
                {
                    return false;
                }  
                if(char.IsDigit(c))
                {
                    if(max< int.Parse(c.ToString()))
                    {
                        max = int.Parse(c.ToString());
                    }    
                }    
            }
            for (int i = 0; i < key.Length - 1; i++)
            {
                for (int j = i + 1; j < key.Length; j++)
                {
                    if (key[i].Equals(key[j]))
                    {
                        key = key.Substring(0, j) + key.Substring(j + 1);
                        j--;
                    }
                    
                }
            }
            if(key.Contains("0"))
            {
                return false;
            }    
            for (int  i = 1; i <= max;i++)
            {
                if (!key.Contains(i.ToString()))
                {
                    return false;
                }
            }
            return true;
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
        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            if(KtraEmpty(txt_input.Text) && KtraEmpty(txt_key.Text))
            {
                if(Ktra_TiengViet(txt_input.Text))
                {
                    if (Ktra_Key())
                    {
                        input = txt_input.Text;
                        if (cb_luachon.Text == "Mã hóa") 
                        {
                            MaHoa(key, input);
                        }
                        if (cb_luachon.Text == "Giải mã")
                        {
                            GiaiMa(key, input);
                        }        
                    }
                    else
                    {
                        MessageBox.Show("Ko hợp lệ !!!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập input là tiếng việt không dấu", "Thông báo");
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
            txt_key.Clear();
            txt_input.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hoanvi_Load(object sender, EventArgs e)
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
    }
}
