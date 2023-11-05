using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComplementaryRGB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void origin_picb_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var originRGB = colorDialog1.Color;
                var complementaryRGB = GetComplementaryRGB(originRGB);
                originRGB_lab.Text = $"{originRGB.R }，{originRGB.G}，{originRGB.B }";
                complementaryRGB_lab.Text = $"{complementaryRGB.R},{complementaryRGB.G},{complementaryRGB.B}";
                origin_picb.BackColor = originRGB;
                complementary_picb.BackColor = complementaryRGB;
            };
        }
        private Color GetComplementaryRGB(Color orginRGB)
        {
            var r = (byte)(255 - orginRGB.R);
            var g = (byte)(255 - orginRGB.G);
            var b = (byte)(255 - orginRGB.B);
            return Color.FromArgb(r, g, b);
        }

        #region 鼠标左键复制，右键粘贴
        private void originRGB_lab_MouseClick(object sender, MouseEventArgs e)
        {
            originRGB_lab.BindMouseClick(e);
        }

        private void complementaryRGB_lab_MouseClick(object sender, MouseEventArgs e)
        {
            complementaryRGB_lab.BindMouseClick(e);
        }
        #endregion
    }
}
