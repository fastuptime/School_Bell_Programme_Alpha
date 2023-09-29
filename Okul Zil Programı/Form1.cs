using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Okul_Zil_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void updateTime(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            MessageBox.Show("Programı kullanabilmek için internet bağlantısı gerekmektedir. İnternet bağlantısı olmadan program çalışmayacaktır. Github: fastuptime", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        SoundPlayer player = new SoundPlayer();
        public void playMusic(string url)
        {
            try
            {
                player.Stop();
                player.SoundLocation = url;
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            playMusic("https://cdn.discordapp.com/attachments/839537395438583808/1156325183527854080/y2mate.is_-_Istiklal_Mars-Y75Km7dlt94-192k-1695759368.wav");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playMusic("https://cdn.discordapp.com/attachments/839537395438583808/1156714487043346492/Sayg_Durusu_ve_Istiklal_Mars.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playMusic("https://cdn.discordapp.com/attachments/839537395438583808/1156369014101123072/SIREN_SESI_9_05.wav");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            playMusic("https://cdn.discordapp.com/attachments/839537395438583808/1156368932282830909/1_DK_LIK_SAYGI_DURUSU.wav");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            playMusic("https://cdn.discordapp.com/attachments/839537395438583808/1156717531986399323/OGRETMEN_ZILI_Gokce_Tuttu_Frlatt.wav");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            playMusic("https://cdn.discordapp.com/attachments/839537395438583808/1156717769409175632/Okul_Zili_-_Ogrenci_Zil_Sesi_Cayr_Cimen_Geze_Geze.wav");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            playMusic("https://cdn.discordapp.com/attachments/839537395438583808/1156719756565561364/Okul_Zil_Sesi_Bilinmeyen_Muzigi_Cks_Zil.wav");
        }
    }
}
