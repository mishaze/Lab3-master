using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Lab3 prodcons = new Lab3();
        public string textproduser;
        public string textconsumer;
        
        System.Windows.Forms.Timer m_Timer;

        void timer_Tick(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        private void RefreshProcesses()
        {
            Buffer.Items.Clear();
            string[] temp = prodcons.q.getQueue();

            temp = prodcons.q.getQueue();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == null) temp[i] = " ";

            }  
                Buffer.Items.AddRange(temp);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           m_Timer = new System.Windows.Forms.Timer();
           RefreshProcesses();

           m_Timer.Interval = 100;
           m_Timer.Tick += timer_Tick;
            m_Timer.Start();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            //проверка на ввод в поле
            if (tb_produser_time.Text == "")
                return;
            //добавление потока и задание ему времени выполнения
            prodcons.ProducersTimeList.Add(Convert.ToInt32(tb_produser_time.Text));
            prodcons.produsers.Add(new Thread(prodcons.Producer));
            //запуск потока
            prodcons.produsers[prodcons.produsers.Count - 1].Start();
            //отображение
            textproduser = String.Format("Produser[{0}]", prodcons.produsers.Count, tb_produser_time.Text);
            Produsers.Items.Add(textproduser);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buffer.Items.Clear();
            //проверка на ввод в поле
            if (tb_consumer_time.Text == "")
                return;
            //добавление потока и задание ему времени выполнения
            prodcons.ConsumersTimeList.Add(Convert.ToInt32(tb_consumer_time.Text));
            prodcons.consumers.Add(new Thread(prodcons.Consumer));
            //запуск потока
            prodcons.consumers[prodcons.consumers.Count - 1].Start();
            //отображение
            textconsumer = String.Format("Consumers[{0}]", prodcons.consumers.Count);
            Consumers.Items.Add(textconsumer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tb_num.Text)-1;

            if (checkConsumer.Checked)
            {
              if (prodcons.consumers[num].ThreadState <= (ThreadState)32)
              {
                prodcons.consumers[num].Suspend();
              }
              else prodcons.consumers[num].Resume();
            }


            if (checkProduser.Checked)
            {
                if (prodcons.produsers[num].ThreadState <=(ThreadState)32)
                {
                    prodcons.produsers[num].Suspend();
                }
                else prodcons.produsers[num].Resume();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            checkProduser = checkBox;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Produsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_produser_time_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkConsumer_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            checkConsumer = checkBox;
        }

        private void btn_ChangeTime_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tb_num.Text) - 1;
            if (checkConsumer.Checked)
            {
                prodcons.ConsumersTimeList[num] = Convert.ToInt32(tb_changeTime.Text);
            }


            if (checkProduser.Checked)
            {
                prodcons.ProducersTimeList[num] = Convert.ToInt32(tb_changeTime.Text);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tb_num.Text);
            if (checkConsumer.Checked)
            {
                prodcons.ConsumersTimeList[num-1] = 0;
                Consumers.Items.Remove(String.Format("Consumer[{0}]", num));
                
            }

            if (checkProduser.Checked)
            {
                prodcons.ProducersTimeList[num-1] = 0;
                Produsers.Items.Remove(String.Format("Produser[{0}]", num));

            }
        }
    }

}



