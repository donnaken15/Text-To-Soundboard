using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;
using System.Threading;

namespace Text_To_Soundboard
{
    public partial class ttsb : Form
    {
        string[] exampleText = new string[50];

        SpeechSynthesizer reader = new SpeechSynthesizer();

        public ttsb()
        {
            InitializeComponent();
            exampleText[0] = "Welcome to Text to Soundboard, the ultimate TTS engine made to make sentence mixing better.";
            exampleText[1] = "As you can see with the text provided, this engine works flawless! Have fun using this for yours or other's entertainment.";
            exampleText[2] = "Come join our board for the best sound packs available, or submit your own! http://texttosoundboard.boards.net/";
            exampleText[3] = "To get the soundpacks working, simply set the sounds directory to where you have downloaded or created the soundpack you want to use.";
            exampleText[4] = "";
            text.Text = exampleText[new Random().Next(0, 4)];
        }

        private void fontbtn_Click(object sender, EventArgs e)
        {
            font.ShowDialog();
            text.Font = font.Font;
        }

        private void selectDir(object sender, EventArgs e)
        {
            setdir.ShowDialog();
            snddir.Text = setdir.SelectedPath;
        }

        private void startTTSB_Click(object sender, EventArgs e)
        {
            foreach (string word in text.Text.Split(' '))
            {
                string origword = word;
                try
                {
                    SoundPlayer wav = new SoundPlayer(snddir.Text + "\\" + word.Replace(".", "").Replace("!", "").Replace(",", "").Replace("?", "").Replace(",", "").Replace(":", "").Replace("/", " slash").Replace("\\", " backslash") +".wav");
                    wav.PlaySync();
                }
                catch { reader.Speak(word); }
                if (origword.Contains(".") || origword.Contains("?") || origword.Contains("!"))
                {
                    Thread.Sleep(250);
                }
                else if (origword.Contains(",") || origword.Contains(":") || origword.Contains(";"))
                {
                    Thread.Sleep(125);
                }
            }
            GC.Collect();
        }
    }
}
