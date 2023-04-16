using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PokeBattle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ourhp2 = ourhp;
        }
        int thp = 100;
        int tspeed = 30;
        int tdef = 10;
        int tatk;
        int ourhp = 100;
        int ourhp2;
        int ourspeed = 50;
        int ourdef = 10;
        int ouratk;
        int Seconds;
        Random r = new Random();


        private void btnAtk_Click(object sender, EventArgs e)
        {
            if (panelatk.Visible)
            {
                panelatk.Visible = false;
            }
            else
            {
                panelatk.Visible = true;
            }

        }
        
        public void theirPm_atk()
        {
       
            int atk=r.Next(1,11);
            switch (atk)
            {
                case 1:
                case 2:
                case 3:
                    tatk = 10;
                    ourhp2 = ourhp2 - tatk < 0 ? 0 : ourhp2 - tatk;
                    break;
                case 4:
                case 5:
                    tatk = 20;
                    ourhp2 = ourhp2 - tatk < 0 ? 0 : ourhp2 - tatk;
                    break;
                case 6:
                case 7:
                    tatk = 0;
                    ourhp2 = ourhp2 - tatk;
                    break;
                case 8:
                case 9:
                case 10:
                    tatk = 5;
                    ourhp2 = ourhp2 - 5 < 0 ? 0 : ourhp2 - tatk;
                    thp = (thp + 5) > 100 ? 100 : (thp + 5);
                    break;
            }
            if (ourhp2 <= 0)
            {
                timer1.Enabled = false;
                label1.Text = $"超音蝠擊敗了皮卡丘!!";
                MessageBox.Show("你輸了這次挑戰!");
                Close();
            }
            else
            {
                if (tatk > 5)
                    label1.Text = $"超音蝠造成皮卡丘{tatk}點傷害!!";
                else if (tatk == 5)
                    label1.Text = $"超音蝠吸取皮卡丘{tatk}點血，並恢復HP{tatk}點!!";
                else if (tatk == 0)
                    label1.Text = $"超音蝠攻擊失誤，未能命中皮卡丘。";
            }
            labHpVal.Text = $"{ourhp2}/{ourhp}";
            progressBar1.Value = ourhp2;
            progressBar2.Value = thp;
            pictureBox2.Location = new Point(334, 21);
        }

        public void ourPm_atk()
        {
           
            int miss = r.Next(1, 11);
            if (miss < 8)
            {
                thp = thp - (ouratk - tdef) < 0 ? 0 : thp - (ouratk - tdef);
                progressBar2.Value = thp;
                if (thp <= 0)
                {
                    timer1.Enabled = false;
                    label1.Text = "皮卡丘擊倒了超音蝠!!";
                    MessageBox.Show("恭喜您獲得此次勝利!!");
                    Close();
                }
                else
                    label1.Text = $"皮卡丘造成超音蝠{ouratk - tdef}點傷害!!";
            }
            else
                label1.Text = $"皮卡丘攻擊失誤，未能命中超音蝠。";
            progressBar2.Value = thp;
            pictureBox1.Location = new Point(73,206) ;
        }

        public void speed()
        {
        }
        public void atktime()
        {

        }

        private void btnatk1_Click(object sender, EventArgs e)
        {
            ouratk =20;
            panelatk.Visible = false;
            label1.Visible = true;
            timer1.Enabled = true;
            
        }

        private void btnatk2_Click(object sender, EventArgs e)
        {
            ouratk =30;
            panelatk.Visible = false;
            label1.Visible = true;
            timer1.Enabled = true;

        }

        private void btnatk3_Click(object sender, EventArgs e)
        {
            tdef = tdef / 2;
            panelatk.Visible = false;
            label1.Visible = true;
            label1.Text = $"超音蝠的防禦下降至{tdef}!!";
            Seconds = 2;
            timer1.Enabled= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Seconds++;
            if (Seconds == 1)
            {
                ourPm_atk();
            }
            else if (Seconds == 2)
            {
                pictureBox1.Location = new Point(53, 206);
            }
            else if (Seconds == 3)
            {
                theirPm_atk();
            }
            else if (Seconds == 4)
            {
                pictureBox2.Location = new Point(354, 21);
            }

            else
            {
                timer1.Enabled = false;
                label1.Visible = false;
                Seconds = 0;
                label1.Text = "";
            }
        }
    }

}

