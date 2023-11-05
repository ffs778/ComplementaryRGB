using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplementaryRGB
{
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
                Thread.Sleep(3000);   // 3秒后自动关闭窗口
                box.Close();
            });
        }
    }
}
