using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplementaryRGB
{
    public static class ControlEx
    {
        /// <summary>
        /// 弹出自动关闭的弹窗。
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        public static void ShowMessage(Control parent, string message)
        {
            Task.Run(() =>
            {
                var box = new AutoReleaseMessageBox(message);
                parent.Invoke(new Action(() =>
                {
                    box.Show(); // 直接show会导致显示不全。
                }));
                Thread.Sleep(1000); // 等待1s后自动关闭
                parent.Invoke(new Action(() =>
                {
                    box.Close();
                    box.Dispose();
                }));
            });
        }
    }
}
