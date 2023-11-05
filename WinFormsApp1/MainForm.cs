using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private static object lockObject = new object();
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
    public static class ControlEx
    {
        public static void BindMouseClick(this Control control, MouseEventArgs e)
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
        private static void SetRGB(string text)
        {
            Clipboard.SetText(text);
            ShowMessage("已复制");
        }
        private static string GetRGB()
        {
            return Clipboard.GetText();
        }
        private static void ShowMessage(string message)
        {
            var taskShowBox = Task.Run(() =>
              {
                  var box = new AutoReleaseMessageBox(message);
                  box.Show();
                  Thread.Sleep(3000);
                  box.Close();
              });
        }
    }
}
