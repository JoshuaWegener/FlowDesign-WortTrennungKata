using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WortTrennung
{
    public partial class WortTrennungForm : Form
    {
        public WortTrennungForm() => InitializeComponent();

        private void Ctrl_TextTransformieren_Click(object sender, EventArgs e)
        {
            var spaltenBreite = SpaltenbreiteOderNull(Ctrl_SpaltenBreite.Text);

            if (spaltenBreite <= 0)
            {
                MessageBox.Show(@"Spaltenbreite nicht korrekt!", @"Fehler!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var originalerText = Ctrl_OriginalerText.Text;
            var textAlsArray = originalerText.Split(' ');

            var ergebnisText = TransformiereText(textAlsArray, spaltenBreite);

            Ctrl_AngepassterText.Text = ergebnisText;
        }

        private static int SpaltenbreiteOderNull(string spaltenBreiteAlsString)
        {
            try
            {
                return Convert.ToInt32(spaltenBreiteAlsString);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        private static string TransformiereText(IEnumerable<string> textAlsArray, int spaltenBreite)
        {
            var zeilenLaenge = 0;
            var ergebnisText = new StringBuilder();

            foreach (var wort in textAlsArray)
            {
                zeilenLaenge += wort.Length;

                if (zeilenLaenge <= spaltenBreite)
                {
                    ergebnisText.Append(wort + " ");
                    zeilenLaenge++;
                }
                else
                {
                    ergebnisText.AppendLine(string.Empty);
                    ergebnisText.Append(wort + " ");
                    zeilenLaenge = wort.Length + 1;
                }
            }

            ergebnisText.Length--;

            return ergebnisText.ToString();
        }
    }
}