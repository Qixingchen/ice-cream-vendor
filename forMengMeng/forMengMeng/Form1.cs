using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forMengMeng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            String text = "";
            Boolean isCheckOK = false;
            try
            {
                text += GetCheckedRadio(groupBox1).Text;
                text += "口味  ";
                text += GetCheckedRadio(groupBox2).Text;
                text += "  ";
                text += GetCheckedRadio(groupBox3).Text;
                isCheckOK = true;
            }
            catch (NullReferenceException e1)
            {
                text = "你还没有选择完成><";
                textBox1.Text = text;
                return;
            }
            textBox1.Text = "您选择了" + text;
            int price = 5;
            if (isCheckOK)
            {
                price += GetCheckedRadio(groupBox2).TabIndex - 9;
                if (GetCheckedRadio(groupBox3).TabIndex != 13)
                {
                    price += 2;
                }
            }
            textBox1.Text += System.Environment.NewLine;
            textBox1.Text += "合计￥" + price + "元";
        }

        RadioButton GetCheckedRadio(GroupBox groupBox)
        {
            foreach (var control in groupBox.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }

            return null;
        }

    }
}
