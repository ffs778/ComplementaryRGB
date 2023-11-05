using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplementaryRGB
{
    public partial class AutoReleaseMessageBox : Form
    {
        public AutoReleaseMessageBox(string message)
        {
            InitializeComponent();
            message_lab.Text = message;
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
