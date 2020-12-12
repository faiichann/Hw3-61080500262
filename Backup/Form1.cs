using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace howto_rgb_to_hls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The selected color.
        private Color SelectedColor;

        // Select the first color from the RGB controls.
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectRGBColor();
        }

        // True while we're setting the color.
        private bool IgnoreEvents = false;

        // Set a new RGB value.
        private void nudRGB_ValueChanged(object sender, EventArgs e)
        {
            SelectRGBColor();
        }

        // Happens when the user presses a key.
        private void nudRGB_KeyUp(object sender, KeyEventArgs e)
        {
            SelectRGBColor();
        }

        // Select a color from the RGB values.
        private void SelectRGBColor()
        {
            if (IgnoreEvents) return;
            IgnoreEvents = true;

            // Save the selected color and display a sample.
            int R = (int)nudR.Value;
            int G = (int)nudG.Value;
            int B = (int)nudB.Value;
            SelectedColor = Color.FromArgb(R, G, B);
            picSample.BackColor = SelectedColor;

            // Convert to HLS.
            double H, L, S;
            ColorStuff.RgbToHls(R, G, B, out H, out L, out S);

            // Display HLS values.
            txtH.Text = H.ToString("0.00");
            txtL.Text = L.ToString("0.00");
            txtS.Text = S.ToString("0.00");

            IgnoreEvents = false;
        }

        // Set a new HLS value.
        private void txtHLS_TextChanged(object sender, EventArgs e)
        {
            SelectHLSColor();
        }

        // Select a color from the HLS values.
        private void SelectHLSColor()
        {
            if (IgnoreEvents) return;
            IgnoreEvents = true;

            try
            {
                // Convert into RGB.
                double H = double.Parse(txtH.Text);
                double L = double.Parse(txtL.Text);
                double S = double.Parse(txtS.Text);
                int R, G, B;
                ColorStuff.HlsToRgb(H, L, S, out R, out G, out B);

                // Display RGB values.
                nudR.Value = (decimal)R;
                nudG.Value = (decimal)G;
                nudB.Value = (decimal)B;

                // Save the selected color and display a sample.
                SelectedColor = Color.FromArgb(
                    (int)nudR.Value,
                    (int)nudG.Value,
                    (int)nudB.Value);
                picSample.BackColor = SelectedColor;
            }
            catch
            {
            }
            IgnoreEvents = false;
        }
    }
}
