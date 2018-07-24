using System;
using System.Media;
using System.Speech.Synthesis;
using System.Threading;

namespace Text_To_Soundboard_CMD
{
    class Program
    {
        static string text;

        static SpeechSynthesizer reader = new SpeechSynthesizer();

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                for (int i = 1; i < args.Length; i++)
                {
                    text += args[i]+" ";
                }
                foreach (string word in text.Split(' '))
                {
                    string origword = word;
                    try
                    {
                        SoundPlayer wav = new SoundPlayer(args[0] + "\\" + word.Replace(".", "").Replace("!", "").Replace(",", "").Replace("?", "").Replace(",", "").Replace(":", "").Replace("/", " slash").Replace("\\", " backslash") + ".wav");
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
            else
            {
                Console.WriteLine("ttsb_cmd.exe [sounds directory] [text]");
            }
        }
    }
}
