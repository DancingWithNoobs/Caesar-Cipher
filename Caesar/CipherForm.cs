using System;
using System.Windows.Forms;

namespace Caesar
{
    public partial class CipherForm : Form
    {
        public CipherForm()
        {
            InitializeComponent();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string text = "";
            for (int i = 0; i <= 26; i++)
            {
                text += "" + i + '\t';
                foreach (char letter in plaintextBox.Text.ToCharArray())
                {
                    if (letter >= 97 && letter <= 122) // Lower case
                    {
                        if (letter + i > 122)
                        {
                            text += Convert.ToChar(letter - 26 + i);
                        }
                        else
                        {
                            text += Convert.ToChar(letter + i);
                        }
                    }
                    else if (letter >= 65 && letter <= 90) // Upper case
                    {
                        if (letter + i > 90)
                        {
                            text += Convert.ToChar(letter - 26 + i);
                        }
                        else
                        {
                            text += Convert.ToChar(letter + i);
                        }
                    }
                    else
                    {
                        text += Convert.ToChar(letter);
                    }
                }
                text += Environment.NewLine;
            }
            outBox.Text = text;
        }
    }
}
