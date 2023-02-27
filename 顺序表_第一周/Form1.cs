using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 顺序表_第一周
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        int[]prime = new int[50];

        public void fun_prime(int[] index)
        {
            //int m = 200;  // 输入的整数 
            int i;  // 循环次数
            int j = 0;
            int k;  // m 的平方根 

            // 求平方根，注意sqrt()的参数为 double 类型，这里要强制转换m的类型 
            for (int m = 1; m < 200; m++)
            {
                k = (int)Math.Sqrt(m);
                for (i = 2; i <= k; i++)
                {
                    if (m % i == 0)
                        break;
                }

                if (i > k)
                {
                    index[j] = m;
                    j++;
                }
            }
            // 如果完成所有循环，那么m为素数
            // 注意最后一次循环，会执行i++，此时 i=k+1，所以有i>k 
        }
        public int fun_ran(int id, int[] index)
        {                  
            //获取到随机数
            int p = ran.Next(id) + 1;

            //判断是否获取到相同的随机数
            for (int q = 0; q < index.Length; q++)
            {
                if (p == index[q])
                {
                    //如果获取的数重复重新获取
                    return fun_ran(id, index);
                }
            }
            return p;
        }
        
        int m_createmaxno;
        private CSeqList<int> m_seqlist; //定义“顺序表”类的对象成员


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_maxcount.Text = "100";
            tb_count.Text = "20";
            tb_modify_no.Text = "15";
            tb_modify_dt.Text = "1000";
            rb_datasx1.Checked = true;
            rb_second.Checked = true;

        }

        // 初始化
        private void btn_create_Click(object sender, EventArgs e)
        {
            m_createmaxno = Convert.ToInt16(tb_maxcount.Text);
            int m_createno = Convert.ToInt16(tb_count.Text);
            int[] dt = new int[m_createno];
            Random ran = new Random();
            for (int i = 0; i < m_createno; i++)
            {
                if (rb_datasx1.Checked == true)
                    dt[i] = i + 1;
                else
                    dt[i] = ran.Next(m_createno) + 1;
            }
            if (m_createno <= m_createmaxno && m_createno >= 1)
            {
                m_seqlist = new CSeqList<int>(m_createmaxno, dt, m_createno);
                string str = m_seqlist.MyPrint();
                richTextBox1.Text = str;
            }
        }

        // 清空
        private void btn_clear_Click(object sender, EventArgs e)
        {
            //int m_createmaxno = Convert.ToInt16(tb_maxcount.Text);         
            //if (m_createmaxno >= 1)
            //{
            //    m_seqlist = new CSeqList<int>(m_createmaxno);
            //    string str = m_seqlist.MyPrint();
            //    richTextBox1.Text = str;
            //}
            m_seqlist.MakeEmpty();
            string str = m_seqlist.MyPrint();
            richTextBox1.Text = str;
        }

        // 插入
        private void btn_insert_Click(object sender, EventArgs e)
        {
            int k, dt;
            if(rb_first.Checked == true)
            {
                k = 1;
            }
            else if(rb_last.Checked == true)
            {
                k = m_seqlist.DataSize + 1;
            }
            else
            {
                k = Convert.ToInt16(tb_modify_no.Text);
            }
            
            dt = Convert.ToInt16(tb_modify_dt.Text);
            if (m_seqlist.Inset(k, dt))
            {
                string str = m_seqlist.MyPrint();
                richTextBox1.Text = str;
            }
            else
            {
                MessageBox.Show("插入的节点位置错误 !");
            }

        }

        // 删除
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int k;
            if (rb_first.Checked == true)
            {
                k = 1;
            }
            else if (rb_last.Checked == true)
            {
                k = m_seqlist.DataSize;
            }
            else
            {
                k = Convert.ToInt16(tb_modify_no.Text);
            }
     
            if (m_seqlist.Delete(k))
            {
                string str = m_seqlist.MyPrint();
                richTextBox1.Text = str;
            }
            else
            {
                MessageBox.Show("删除的节点位置错误 !");
            }

        }

        // 修改
        private void btn_change_Click(object sender, EventArgs e)
        {
            int k, dt;
            if (rb_first.Checked == true)
            {
                k = 1;
            }
            else if (rb_last.Checked == true)
            {
                k = m_seqlist.DataSize;
            }
            else
            {
                k = Convert.ToInt16(tb_modify_no.Text);
            }

            dt = Convert.ToInt16(tb_modify_dt.Text);
            if (m_seqlist.Update(k, dt))
            {
                string str = m_seqlist.MyPrint();
                richTextBox1.Text = str;
            }
            else
            {
                MessageBox.Show("修改的节点位置错误 !");
            }
        }

        // 退出
        private void btn_exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            //m_seqlist.reverse();
            //string str = m_seqlist.MyPrint();
            //richTextBox1.Text = str;
            Application.Exit();
        }

        // n个不同随机数
        private void bt_rand_Click(object sender, EventArgs e) 
        {
            m_createmaxno = Convert.ToInt16(tb_maxcount.Text);
            int m_createno = Convert.ToInt16(tb_count.Text);
            int[] dt = new int[m_createno];         
            for (int i = 0; i < m_createno; i++)
            {
                dt[i] = fun_ran(m_createno , dt);                
            }
            if (m_createno <= m_createmaxno && m_createno >= 1)
            {
                m_seqlist = new CSeqList<int>(m_createmaxno, dt, m_createno);
                string str = m_seqlist.MyPrint();
                richTextBox1.Text = str;
            }

        }

        // n个素数
        private void bt_prime_Click(object sender, EventArgs e)
        {
            m_createmaxno = Convert.ToInt16(tb_maxcount.Text);
            int m_createno = Convert.ToInt16(tb_count.Text);
            int[] dt = new int[m_createno];
            fun_prime(prime);
            for (int i = 0; i < m_createno; i++)
            {
                dt[i] = prime[i];
            }
            if (m_createno <= m_createmaxno && m_createno >= 1)
            {
                m_seqlist = new CSeqList<int>(m_createmaxno, dt, m_createno);
                string str = m_seqlist.MyPrint();
                richTextBox1.Text = str;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // 元素逆转
        private void btn_reverse_Click(object sender, EventArgs e)
        {
            try
            {
                m_seqlist.reverse();
                this.richTextBox1.Text = m_seqlist.MyPrint();
            }
            catch(Exception error)
            {
                MessageBox.Show("发生了错误：" + error.Message);
            }
        }

        // 元素查找
        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                int element = Convert.ToInt32(tb_find.Text);
                MessageBox.Show($"元素{element.ToString()}在表中第一次出现的位置是第" +
                    $"{m_seqlist.Find(element).ToString()}位。" +
                    $" (1-{m_seqlist.DataSize.ToString()})");                    
            }
            catch(FormatException)
            {
                MessageBox.Show("发生了错误；请在下面的输入框中输入整数！");
            }
            catch(Exception error)
            {
                MessageBox.Show("发生了错误；"+error.Message);
            }
        }
    }
}
