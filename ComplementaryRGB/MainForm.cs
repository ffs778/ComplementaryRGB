using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
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
                originRGB_lab.Text = $"{originRGB.R },{originRGB.G},{originRGB.B }";
                origin_picb.BackColor = originRGB;
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
            BindMouseClick(originRGB_lab,e);
        }

        private void complementaryRGB_lab_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetRGB(complementaryRGB_lab.Text);
            }
        }
        /// <summary>
        /// 鼠标左键复制，右键粘贴
        /// </summary>
        /// <param name="control"></param>
        /// <param name="e"></param>
        public void BindMouseClick(Control control, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetRGB(control.Text);
            }
            if (e.Button == MouseButtons.Right)
            {
                control.Text = GetRGB();
            }
        }
        #endregion
        /// <summary>
        /// 将RGB值保存到
        /// </summary>
        /// <param name="text"></param>
        private void SetRGB(string text)
        {
            Clipboard.SetText(text);
            ControlEx.ShowMessage(this,"已复制");
        }
        /// <summary>
        /// 读取剪切板中的RGB值
        /// </summary>
        /// <returns></returns>
        private static string GetRGB()
        {
            return Clipboard.GetText();
        }
        /// <summary>
        /// 原始颜色RGB值更改，原始颜色自动更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void originRGB_lab_TextChanged(object sender, EventArgs e)
        {
            var r = Convert.ToByte(originRGB_lab.Text.Trim().Split(",")[0]);
            var g = Convert.ToByte(originRGB_lab.Text.Trim().Split(",")[1]);
            var b = Convert.ToByte(originRGB_lab.Text.Trim().Split(",")[2]);
            if (r != origin_picb.BackColor.R || g != origin_picb.BackColor.G || b != origin_picb.BackColor.B)
            {
                origin_picb.BackColor = Color.FromArgb(r, g, b);
            }
        }
        /// <summary>
        /// 原始颜色更改，互补色自动更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void origin_picb_BackColorChanged(object sender, EventArgs e)
        {
            var complementaryRGB = GetComplementaryRGB(origin_picb.BackColor);
            complementaryRGB_lab.Text = $"{complementaryRGB.R},{complementaryRGB.G},{complementaryRGB.B}";
            complementary_picb.BackColor = complementaryRGB;
        }
    }
}
