using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeselayaFerma
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //Sound.play_start();
        }

        private void check_sound_CheckedChanged(object sender, EventArgs e)
        {
            
            
            if (check_sound.Checked)
            {
                Sound.sound_on();
              //  Sound.play_start();
                check_sound.Text = "Вкл";
                             
            }
            else
            {
                Sound.sound_off();
                check_sound.Text = "Выкл";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        private void start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            level1.ShowDialog();
        }
    }
}
