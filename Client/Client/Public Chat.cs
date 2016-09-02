using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Public_Chat : Form
    {
        Private_Chat privateChatWindow;

        public Public_Chat()
        {
            InitializeComponent();
        }

        private void privateChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            privateChatWindow = new Private_Chat();
        }


    }
}
