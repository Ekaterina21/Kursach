using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace VeselayaFerma
{
    static class Sound
    {
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.sound_start);

        static bool sound_enabled = true;


        public static void sound_on()
        {
            sound_enabled = true;
        }

        public static void sound_off()
        {
            sound_enabled = false;
        }
        public static void play_start()
        {
            if (sound_enabled)
            sound_start.Play();
        }

    }
}

