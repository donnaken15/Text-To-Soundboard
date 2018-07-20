using System;
using System.Windows.Forms;

namespace Text_To_Soundboard
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new ttsb());
        }
    }
}
