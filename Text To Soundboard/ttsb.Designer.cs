namespace Text_To_Soundboard
{
    partial class ttsb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ttsb));
            this.textlbl = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.snddirlbl = new System.Windows.Forms.Label();
            this.snddir = new System.Windows.Forms.TextBox();
            this.snddirsel = new System.Windows.Forms.Button();
            this.startTTSB = new System.Windows.Forms.Button();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.fontbtn = new System.Windows.Forms.Button();
            this.font = new System.Windows.Forms.FontDialog();
            this.setdir = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textlbl
            // 
            this.textlbl.AutoSize = true;
            this.textlbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textlbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlbl.Location = new System.Drawing.Point(2, -3);
            this.textlbl.Name = "textlbl";
            this.textlbl.Size = new System.Drawing.Size(96, 34);
            this.textlbl.TabIndex = 0;
            this.textlbl.Text = "TEXT:";
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.Location = new System.Drawing.Point(2, 28);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(278, 158);
            this.text.TabIndex = 1;
            // 
            // snddirlbl
            // 
            this.snddirlbl.AutoSize = true;
            this.snddirlbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.snddirlbl.Location = new System.Drawing.Point(5, 191);
            this.snddirlbl.Name = "snddirlbl";
            this.snddirlbl.Size = new System.Drawing.Size(89, 13);
            this.snddirlbl.TabIndex = 2;
            this.snddirlbl.Text = "Sounds directory:";
            // 
            // snddir
            // 
            this.snddir.Location = new System.Drawing.Point(95, 189);
            this.snddir.Name = "snddir";
            this.snddir.Size = new System.Drawing.Size(114, 20);
            this.snddir.TabIndex = 3;
            // 
            // snddirsel
            // 
            this.snddirsel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.snddirsel.Location = new System.Drawing.Point(211, 189);
            this.snddirsel.Name = "snddirsel";
            this.snddirsel.Size = new System.Drawing.Size(25, 20);
            this.snddirsel.TabIndex = 4;
            this.snddirsel.Text = "...";
            this.snddirsel.UseVisualStyleBackColor = true;
            this.snddirsel.Click += new System.EventHandler(this.selectDir);
            // 
            // startTTSB
            // 
            this.startTTSB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startTTSB.Location = new System.Drawing.Point(238, 189);
            this.startTTSB.Name = "startTTSB";
            this.startTTSB.Size = new System.Drawing.Size(42, 39);
            this.startTTSB.TabIndex = 5;
            this.startTTSB.Text = "Say";
            this.startTTSB.UseVisualStyleBackColor = true;
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.copyrightlabel.Location = new System.Drawing.Point(2, 214);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(235, 13);
            this.copyrightlabel.TabIndex = 6;
            this.copyrightlabel.Text = "the TTSB engine is (c) of Wesley Kennedy 2018";
            // 
            // fontbtn
            // 
            this.fontbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fontbtn.Location = new System.Drawing.Point(204, 2);
            this.fontbtn.Name = "fontbtn";
            this.fontbtn.Size = new System.Drawing.Size(75, 23);
            this.fontbtn.TabIndex = 7;
            this.fontbtn.Text = "change font";
            this.fontbtn.UseVisualStyleBackColor = true;
            this.fontbtn.Click += new System.EventHandler(this.fontbtn_Click);
            // 
            // setdir
            // 
            this.setdir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ttsb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 230);
            this.Controls.Add(this.fontbtn);
            this.Controls.Add(this.startTTSB);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.snddirsel);
            this.Controls.Add(this.snddir);
            this.Controls.Add(this.snddirlbl);
            this.Controls.Add(this.text);
            this.Controls.Add(this.textlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ttsb";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text to Soundboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textlbl;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label snddirlbl;
        private System.Windows.Forms.TextBox snddir;
        private System.Windows.Forms.Button snddirsel;
        private System.Windows.Forms.Button startTTSB;
        private System.Windows.Forms.Label copyrightlabel;
        private System.Windows.Forms.Button fontbtn;
        private System.Windows.Forms.FontDialog font;
        private System.Windows.Forms.FolderBrowserDialog setdir;
    }
}

