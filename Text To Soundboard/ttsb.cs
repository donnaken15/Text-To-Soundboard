using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Text_To_Soundboard
{
    public partial class ttsb : Form
    {
        string[] exampleText = new string[50];

        public ttsb()
        {
            InitializeComponent();
            exampleText[0] = "Welcome to Text to Soundboard, the ultimate TTS engine made to make sentence mixing better.";
            exampleText[1] = "As you can see with the text provided, this engine works flawless! Have fun using this for yours or other's entertainment.";
            exampleText[2] = "Come join our board for the best sound packs available, or submit your own! http://texttosoundboard.boards.net/";
            text.Text = exampleText[new Random().Next(0, 3)];
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
    }
}
