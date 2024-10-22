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
    public partial class Hill : Form
    {
        private int loaimatrix;
        private int[,] matrixkey;
        private string input;
        public Hill()
        {
            InitializeComponent();
            cb_luachon.SelectedIndex = 0;
            btn_tinh.Text = cb_luachon.Text;
            cb_loaimatrix.SelectedIndex = 0;
        }
        private void Hill_Load(object sender, EventArgs e)
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
            if(cb_loaimatrix.Text=="2x2")
            {
                txt_0_2.Visible = false;
                txt_1_2.Visible = false;
                txt_2_0.Visible = false;
                txt_2_1.Visible = false;
                txt_2_2.Visible = false;
            }
            if (cb_loaimatrix.Text == "3x3")
            {
                txt_0_2.Visible = true;
                txt_1_2.Visible = true;
                txt_2_0.Visible = true;
                txt_2_1.Visible = true;
                txt_2_2.Visible = true;
            }
        }
        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hill_Load(sender, e);
            btn_tinh.Text = cb_luachon.Text;
            txt_input.Text = txt_output.Text;
            lb_hienthi.Text = "Ma trận dùng để " + cb_luachon.Text;
            txt_output.Clear();
        }

        private void cb_loaimatrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hill_Load(sender, e);
        }
        public int GetChiSo(char c)
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
        public void MaHoa(int[,] matrix, string banro, int m)
        {
            ArrayList arrP = new ArrayList();
            string P = "";
            foreach (char c in banro)
            {
                if (char.IsLetter(c))
                {
                    P = P + c;
                }
            }
            while (true)
            {
                if (P.Length % m != 0)
                {
                    P = P + "X";
                }
                else
                {
                    break;
                }
            }
            foreach (char c in P)
            {
                if (char.IsLetter(c))
                {
                    arrP.Add(c);
                }
            }
            //Console.WriteLine("Ma trận khóa là : ");
            string hienthimatrix = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    hienthimatrix=hienthimatrix+ matrix[i,j]+"\t";
                }
                hienthimatrix = hienthimatrix + "\n";
            }
            rtb_text.Text = hienthimatrix;

            string banma = "";
            while (arrP.Count > 0)
            {
                Char[] mangP = new Char[m];
                for (int i = 0; i < m; i++)
                {
                    mangP[i] = (char)arrP[i];
                }
                for (int i = 0; i < m; i++)
                {
                    int tong = 0;
                    int chisoP1 = GetChiSo(mangP[i]);
                    for (int j = 0; j < m; j++)
                    {
                        int chisoP = GetChiSo(mangP[j]);
                        int kq = (int)((mangP[j] - chisoP) * matrix[j, i]);
                        tong = tong + kq;
                    }
                    char kytumahoa = (char)((tong % 26) + chisoP1);
                    banma = banma + kytumahoa;
                }
                arrP.RemoveRange(0, m);
            }
            txt_output.Text = banma;
        }
        
        
        public void NhanMatrix(int[,] matrix, int m, int Det)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    matrix[i, j] = matrix[i, j] * Det;
                }
            }
        }
        public void MatrixMod26(int[,] matrix, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int mod = (matrix[i, j] % 26);
                    if (mod < 0)
                    {
                        mod = mod + 26;
                    }
                    matrix[i, j] = mod;
                }
            }
        }
        public void TachMatrix(int[,] matrix3, int[,] matrix2, int m, int n)
        {
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != m && j != n)
                    {

                        if (index < 4)
                        {
                            switch (index)
                            {
                                case 0:
                                    matrix2[0, 0] = matrix3[i, j];
                                    index++;
                                    break;
                                case 1:
                                    matrix2[0, 1] = matrix3[i, j];
                                    index++;
                                    break;
                                case 2:
                                    matrix2[1, 0] = matrix3[i, j];
                                    index++;
                                    break;
                                case 3:
                                    matrix2[1, 1] = matrix3[i, j];
                                    index++;
                                    break;
                            }
                        }

                    }
                }
            }
        }
        public void TimMatrix_Ksao(int[,] matrix, int m)
        {
            if(m==3)
            {
                int[,] temp = new int[3, 3];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        int[,] matrix2 = new int[2, 2];
                        TachMatrix(matrix, matrix2, i, j);
                        int Det = TinhDet(matrix2, 2);
                        if ((i + j) % 2 != 0)
                        {
                            Det = Det * (-1);
                        }
                        temp[i, j] = Det;
                    }
                }
                for (int i = 0; i < m; ++i)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        matrix[i, j] = temp[i, j];
                    }
                }
            }    
        }
        public void Matrix_ChuyenVi(int[,] matrix, int m)
        {
            if (m == 3)
            {
                int temp;
                temp = matrix[0, 1];
                matrix[0, 1] = matrix[1, 0];
                matrix[1, 0] = temp;
                temp = matrix[0, 2];
                matrix[0, 2] = matrix[2, 0];
                matrix[2, 0] = temp;
                temp = matrix[1, 2];
                matrix[1, 2] = matrix[2, 1];
                matrix[2, 1] = temp;
            }

        }
        public int Tim_Detk_Mu_Tru1(int a)
        {
            //(DetK*Detk^-1)mod26=1
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
        public void DoiMatrix(int[,] matrix, int m)
        {
            if (m == 2)
            {
                int DetK = TinhDet(matrix, m);
                int DetK_MuTru1 = Tim_Detk_Mu_Tru1(DetK);
                int temp;
                temp = matrix[0, 0];
                matrix[0, 0] = matrix[1, 1];
                matrix[1, 1] = temp;
                matrix[0, 1] = matrix[0, 1] * (-1);
                matrix[1, 0] = matrix[1, 0] * (-1);
                MatrixMod26(matrix, m);
                NhanMatrix(matrix, m, DetK_MuTru1);
                MatrixMod26(matrix, m);
            }
            if (m == 3)
            {
                int DetK = TinhDet(matrix, m);
                int DetK_MuTru1 = Tim_Detk_Mu_Tru1(DetK);
                Matrix_ChuyenVi(matrix, m);
                TimMatrix_Ksao(matrix, m);
                MatrixMod26(matrix, m);
                NhanMatrix(matrix, m, DetK_MuTru1);
                MatrixMod26(matrix, m);
            }
        }
        public void GiaiMa(int[,] matrix, string banma, int m)
        {
            DoiMatrix(matrix, m);
            ArrayList arrC = new ArrayList();
            foreach (char c in banma)
            {
                if (char.IsLetter(c))
                {
                    arrC.Add(c);
                }
            }

            //Console.WriteLine("Ma trận khóa là : ");
            string hienthimatrix = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    hienthimatrix = hienthimatrix + matrix[i, j] + "\t";
                }
                hienthimatrix = hienthimatrix + "\n";
            }
            rtb_text.Text = hienthimatrix;

            string banro = "";
            while (arrC.Count > 0)
            {
                Char[] mangP = new Char[m];
                for (int i = 0; i < m; i++)
                {
                    mangP[i] = (char)arrC[i];
                }
                for (int i = 0; i < m; i++)
                {
                    int tong = 0;
                    int chisoP1 = GetChiSo(mangP[i]);
                    for (int j = 0; j < m; j++)
                    {
                        int chisoP = GetChiSo(mangP[j]);
                        int kq = (int)((mangP[j] - chisoP) * matrix[j, i]);
                        tong = tong + kq;
                    }
                    /*Console.WriteLine("SÓ CUỐI CÙNG LÀ : " + tong);*/
                    char kytugiaima = (char)((tong % 26) + chisoP1);
                    banro = banro + kytugiaima;
                    /*Console.WriteLine("=======================");*/
                }
                arrC.RemoveRange(0, m);
            }
            BophantuX(banro);
        }
        public void BophantuX(string s)
        {
            //Console.WriteLine("Bản rõ ban đầu là : " + s);
            while (true)
            {
                if (s[s.Length - 1].Equals('X'))
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    break;
                }
            }
            txt_output.Text = s;
            //Console.WriteLine("Bản rõ nhận được sau khi bỏ x là là : " + s);
        }
        public int UCLN(int a)
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
        public int TinhDet(int[,] matrix, int m)
        {
            int Det = 0;
            if (m == 2)
            {
                Det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            if (m == 3)
            {
                int a = matrix[0, 0];
                int b = matrix[0, 1];
                int c = matrix[0, 2];
                int d = matrix[1, 0];
                int e = matrix[1, 1];
                int f = matrix[1, 2];
                int g = matrix[2, 0];
                int h = matrix[2, 1];
                int i = matrix[2, 2];
                Det = a * e * i + b * f * g + c * d * h - c * e * g - b * d * i - a * f * h;
            }
            while (Det < 0)
            {
                Det = Det + 26;
            }
            return Det;
        }
        private bool Ktra_Matrixkey()
        {
            try
            {
                matrixkey = new int[loaimatrix, loaimatrix];
                for (int i = 0; i < loaimatrix; i++)
                {
                    for (int j = 0; j < loaimatrix; j++)
                    {
                        string name_textbox = "txt_" + i + "_" + j;
                        TextBox txt_temp = (TextBox)this.Controls.Find(name_textbox, true).FirstOrDefault();
                        matrixkey[i, j] = int.Parse(txt_temp.Text);
                    }
                }
                int Det = TinhDet(matrixkey, loaimatrix);
                if (Det != 0)
                {
                    if (UCLN(Det) == 1)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
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
            if(cb_loaimatrix.Text=="2x2")
            {
                loaimatrix = 2;
            }    
            if(cb_loaimatrix.Text=="3x3")
            {
                loaimatrix = 3;
            }   
            if(KtraEmpty(txt_input.Text))
            {
                if(Ktra_TiengViet(txt_input.Text))
                {
                    if (Ktra_Matrixkey())
                    {
                        input = txt_input.Text;
                        if(cb_luachon.Text=="Mã hóa")
                        {
                            MaHoa(matrixkey, input, loaimatrix);
                        }   
                        if(cb_luachon.Text=="Giải mã")
                        {
                            GiaiMa(matrixkey, input, loaimatrix);
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Key không hợp lệ!!!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chuỗi nhập vào không hợp lệ", "Thông báo");
                    txt_input.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo");
                txt_input.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_0_0.Clear();
            txt_0_1.Clear();
            txt_0_2.Clear();
            txt_1_0.Clear();
            txt_1_1.Clear();
            txt_1_2.Clear();
            txt_2_0.Clear();
            txt_2_1.Clear();
            txt_2_2.Clear();
            txt_input.Clear();
            txt_output.Clear();
            txt_input.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
