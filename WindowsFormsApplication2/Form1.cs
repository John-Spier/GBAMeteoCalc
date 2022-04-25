using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        double KiloSize = 6144;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            //DialogResult shit = MessageBox.Show("."+mskLength.Text+" "+mskCustomKilos.Text+" "+KiloSize.ToString()+".");
            char ColonDelim = ':';
            string MinsSecs = mskLength.Text.ToString();
            string[] SecondsArray = MinsSecs.Split(ColonDelim);
            double UnroundMinutes;
            double UnroundSeconds;
            double UnroundBitrate;
            //double RoundBitrate;
            double.TryParse(SecondsArray[0], out UnroundMinutes);
            double.TryParse(SecondsArray[1], out UnroundSeconds);
            UnroundBitrate = (KiloSize / ((UnroundMinutes * 60) + UnroundSeconds)) - 10;
            double RoundBitrt = Math.Round(UnroundBitrate);
            double NotBytesRate = RoundBitrt * 8;
            //String FuckOffAsshole = NotBytesRate.ToString();
            lblAvBitrate.Text = (NotBytesRate.ToString() + " kbps video, 80 kbps audio");
            lblNoRounding.Text = (UnroundBitrate.ToString());
            lblBittrateToUse.Text = (RoundBitrt.ToString());
        }

        private void rbThirtytwo_CheckedChanged(object sender, EventArgs e)
        {
            KiloSize = 32768;
        }

        private void rbTwentyfour_CheckedChanged(object sender, EventArgs e)
        {
            KiloSize = 24576;
        }

        private void rbSixteen_CheckedChanged(object sender, EventArgs e)
        {
            KiloSize = 16384;
        }

        private void rbTwelve_CheckedChanged(object sender, EventArgs e)
        {
            KiloSize = 12288;
        }

        private void rbEight_CheckedChanged(object sender, EventArgs e)
        {
            KiloSize = 8192;
        }

        private void mskCustomKilos_TextChanged(object sender, EventArgs e)
        {
            if (rbKilobytes.Checked)
            {
                double.TryParse(mskCustomKilos.Text, out KiloSize);
            }
        }

        private void rbKilobytes_CheckedChanged(object sender, EventArgs e)
        {
            double.TryParse(mskCustomKilos.Text, out KiloSize);
        }
    }
}
