using System;
using System.Collections;
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
    public partial class Playfair : Form
    {
        private char[,] matrix = new char[5, 5];
        ArrayList arrInPut = new ArrayList();
        public Playfair()
        {
            InitializeComponent();
            cb_luachon.SelectedIndex = 0;
            btn_tinh.Text = cb_luachon.Text;
        }

        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Playfair_Load(sender, e);
            btn_tinh.Text = cb_luachon.Text;
            txt_input.Text = txt_output.Text;
            txt_output.Clear();
        }

        private void Playfair_Load(object sender, EventArgs e)
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
        private int LayHang(char[,] mtrx, char c)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mtrx[i, j].Equals(c))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private int LayCot(char[,] mtrx, char c)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mtrx[i, j].Equals(c))
                    {
                        return j;
                    }
                }
            }
            return -1;
        }
        private void MaHoa(char[,] mtrx, ArrayList p)
        {
            string str = "";
            //Console.Write("Ta chia chuỗi mã hóa thành các cặp ký tự có 2 ký tự là : ");
            while (p.Count != 0)
            {
                char so1 = (char)p[0];
                char so2 = (char)p[1];
                string kytu = "" + so1 + so2;
                //Console.Write(kytu + "\t");
                int hso1 = LayHang(mtrx, so1);
                int cso1 = LayCot(mtrx, so1);
                int hso2 = LayHang(mtrx, so2);
                int cso2 = LayCot(mtrx, so2);
                if (hso1 == hso2 && cso1 != cso2)
                {
                    char kytumahoa1 = mtrx[hso1, (cso1 + 1) % 5];
                    char kytumahoa2 = mtrx[hso2, (cso2 + 1) % 5];
                    str = str + kytumahoa1 + kytumahoa2;
                }
                else if (hso1 != hso2 && cso1 == cso2)
                {
                    char kytumahoa1 = mtrx[(hso1 + 1) % 5, cso1];
                    char kytumahoa2 = mtrx[(hso2 + 1) % 5, cso2];
                    str = str + kytumahoa1 + kytumahoa2;
                }
                else if (hso1 != hso2 && cso1 != cso2)
                {
                    char Kytumahoa1 = mtrx[hso1, cso2];
                    char Kytumahoa2 = mtrx[hso2, cso1];
                    str = str + Kytumahoa1 + Kytumahoa2;
                }
                p.RemoveRange(0, 2);
            }
            txt_output.Text = str;
            /*Console.WriteLine();
            Console.WriteLine("Chuỗi sau khi mã hóa là : " + str);*/
        }
        private void GiaiMa(char[,] mtrx, ArrayList p)
        {
            string str = "";
            //Console.Write("Ta chia chuỗi giải mã thành các cặp ký tự có 2 ký tự là : ");
            while (p.Count != 0)
            {
                char so1 = (char)p[0];
                char so2 = (char)p[1];
                string kytu = "" + so1 + so2;
                //Console.Write(kytu + "\t");
                int hso1 = LayHang(mtrx, so1);
                int cso1 = LayCot(mtrx, so1);
                int hso2 = LayHang(mtrx, so2);
                int cso2 = LayCot(mtrx, so2);
                if (hso1 == hso2 && cso1 != cso2)
                {
                    char kytumahoa1 = mtrx[hso1, (cso1 - 1 + 5) % 5];
                    char kytumahoa2 = mtrx[hso2, (cso2 - 1 + 5) % 5];
                    str = str + kytumahoa1 + kytumahoa2;
                }
                else if (hso1 != hso2 && cso1 == cso2)
                {
                    char kytumahoa1 = mtrx[(hso1 - 1 + 5) % 5, cso1];
                    char kytumahoa2 = mtrx[(hso2 - 1 + 5) % 5, cso2];
                    str = str + kytumahoa1 + kytumahoa2;
                }
                else if (hso1 != hso2 && cso1 != cso2)
                {
                    char Kytumahoa1 = mtrx[hso1, cso2];
                    char Kytumahoa2 = mtrx[hso2, cso1];
                    str = str + Kytumahoa1 + Kytumahoa2;
                }
                p.RemoveRange(0, 2);
            }
            //Console.WriteLine();
            XoaX(str);
        }
        private void XoaX(string str)
        {
            //Console.WriteLine("Chuỗi sau khi giải mã là : " + str);
            ArrayList ketqua = new ArrayList();
            for (int i = 0; i < str.Length; i++)
            {
                ketqua.Add(str[i]);
            }
            /*Console.WriteLine("Độ dài bản rõ là : "+(ketqua.Count-1)) ;*/
            for (int i = ketqua.Count - 2; i > 0; i--)
            {
                /*Console.WriteLine("Phần tử thứ " + i + " là : "+ketqua[i]);*/
                if (ketqua[i - 1].Equals(ketqua[i + 1]) && ketqua[i].Equals('X') && i % 2 != 0)
                {
                    ketqua.RemoveAt(i);
                    /*i--;*/
                }
            }
            int dem = ketqua.Count - 1;
            if (ketqua[dem].Equals('X'))
            {
                ketqua.RemoveAt(dem);
            }
            str = "";
            for (int i = 0; i < ketqua.Count; i++)
            {
                str += ketqua[i];
            }
            txt_output.Text = str;
            //Console.WriteLine("Bản rõ là : " + str);
        }
        
        private void TaoMatrix5x5()
        {
            string[,] bangkey = new string[5, 5];
            //Console.WriteLine("Mời nhập key : ");
            string key = txt_key.Text;
            key = key.ToUpper();


            ArrayList bcc = new ArrayList();
            for (int i = 0; i < 26; i++)
            {
                bcc.Add((char)('A' + i));
            }
            for (int i = 0; i < bcc.Count; i++)
            {
                if (bcc[i].Equals('J'))
                {
                    bcc.RemoveAt(i);
                }
            }
 
            List<char> list = new List<char>();


            list.AddRange(key);

            for (int i = 0; i < list.Count - 1; i++)
            {
                char ktra = list[i];
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (ktra.Equals(list[j]))
                    {
                        list.RemoveAt(j);
                        j--;
                    }
                }
            }
 

            char[] arrkey1 = new char[list.Count];
            list.CopyTo(arrkey1, 0);

            //Xóa phần tử đã có trong key của bảng chữ cái
            for (int i = 0; i < bcc.Count; i++)
            {
                char ktra = (char)bcc[i];
                for (int j = 0; j < list.Count; j++)
                {
                    if (ktra.Equals(list[j]))
                    {
                        bcc.RemoveAt(i);
                        i--;
                    }
                }
            }

            
            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
                str = str + list[i];
            }
            for (int i = 0; i < bcc.Count; i++)
            {
                str = str + bcc[i];
            }

            /*Console.WriteLine("Chuỗi mới là : ");
            foreach(char c in str)
            {
                Console.WriteLine(c);
            }*/


            // đưa chuỗi 25 phần tử vào ma trận 5x5
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = str[index];
                    index++;
                }
            }
            /*Console.WriteLine();
            Console.WriteLine("Ma trận có là : ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }*/
            string p2 = txt_input.Text;
            string p1 = "";
            foreach (char c in p2)
            {
                if (char.IsLetter(c))
                {
                    p1 = p1 + c;
                }
            }
            string p = p1.ToUpper();
            //ArrayList arrP = new ArrayList();
            foreach (char c in p)
            {
                arrInPut.Add(c);
            }
            if (cb_luachon.Text=="Mã hóa")
            {
                


                for (int i = 0; i < arrInPut.Count - 1; i = i + 2)
                {
                    int k = i + 1;
                    if (arrInPut[i].Equals(arrInPut[k]))
                    {
                        arrInPut.Insert(k, 'X');
                    }
                }

                int dem = arrInPut.Count;
                if (dem % 2 != 0)
                {
                    arrInPut.Insert(dem, 'X');
                }
            }  
            /*if( cb_luachon.Text=="Giải mã")
            {
                
                string ma2 = txt_input.Text;
                string ma1 = "";
                foreach (char c in ma2)
                {
                    if (char.IsLetter(c))
                    {
                        ma1 = ma1 + c;
                    }
                }
                string ma = ma1.ToUpper();
                foreach (char c in ma)
                {
                    arrInPut.Add(c);
                }
                Console.WriteLine();
                GiaiMa(matrix, arrInPut);
                Console.ReadKey();
            } */   
            
            /*Console.WriteLine();
            Console.Write("chuỗi cần mã hóa là : ");
            for (int i = 0; i < arrP.Count; i++)
            {
                Console.Write(arrP[i]);
            }
            Console.WriteLine();*/
            //MaHoa(matrix, arrP);
            //Console.ReadKey();
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
        private void btn_tinh_Click(object sender, EventArgs e)
        {
            if(KtraEmpty(txt_input.Text)&&KtraEmpty(txt_key.Text))
            {
                TaoMatrix5x5();
                if(cb_luachon.Text=="Mã hóa")
                {
                    MaHoa(matrix, arrInPut);
                }    
                if(cb_luachon.Text=="Giải mã")
                {
                    GiaiMa(matrix, arrInPut);
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống thông tin !!!", "Thông báo");
            }    
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
            txt_input.Clear();
            txt_key.Clear();
            txt_input.Focus();
        }
    }
}
