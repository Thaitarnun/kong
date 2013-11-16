using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = ("ผลลัพธ์" + Environment.NewLine);
    //เพศ
            if (radioButton1.Checked == true)
            {
                ans = ans + "เพศ : ชาย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "เพศ : หญิง" + Environment.NewLine;
            }
    //อายุ
            if (radioButton3.Checked == true)
            {
                ans = ans + "อายุ : 10-20 ปี" + Environment.NewLine;
            }
            else if (radioButton4.Checked == true)
            {
                ans = ans + "อายุ : 20-30 ปี" + Environment.NewLine;
            }
            else 
            {
                ans = ans + "อายุ : มากกว่า 30 ปี" + Environment.NewLine;
            }
    //ชนิดของการออกกำลังกาย
            if (radioButton6.Checked == true)
            {
                ans = ans + "ชนิดของการออกกำลังกาย : วิ่ง" + Environment.NewLine;
            }
            else if (radioButton7.Checked == true)
            {
                ans = ans + "ชนิดของการออกกำลังกาย : ว่ายน้ำ" + Environment.NewLine;
            }
            else if (radioButton8.Checked == true)
            {
                ans = ans + "ชนิดของการออกกำลังกาย : ปั่นจักรยาน" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ชนิดของการออกกำลังกาย : เดิน" + Environment.NewLine;
            }
    //สถานที่ออกกำาลังกาย
            ans = ans + "สถานที่ออกกำาลังกาย : ";
            if (radioButton10.Checked == true)
            {
                ans = ans + "บ้าน" + Environment.NewLine;
            }
            else if (radioButton11.Checked == true)
            {
                ans = ans + "ลานกีฬาหมู่บ้าน" + Environment.NewLine;
            }
            else
            {
                ans = ans + "อื่นๆ" + Environment.NewLine;
            }
    //เวลาในการออกกำลังกาย
            ans = ans + "เวลาในการออกกำลังกาย : ";
            if (radioButton13.Checked == true)
            {
                ans = ans + "ต่ำกว่า 10 นาที" + Environment.NewLine;
            }
            else if (radioButton14.Checked == true)
            {
                ans = ans + "10 - 20 นาที" + Environment.NewLine;
            }
            else if (radioButton15.Checked == true)
            {
                ans = ans + "20 - 30 นาที" + Environment.NewLine;
            }
            else
            {
                ans = ans + "มากกว่า 30 นาที" + Environment.NewLine;
            }

             MessageBox.Show(ans,"รายการที่เลือก");

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
