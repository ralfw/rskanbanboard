using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rskb.boardportal
{
    public partial class NewCardDialog : Form
    {
        public NewCardDialog()
        {
            InitializeComponent();
        }

        public string Description
        {
            get 
            {
                return this.textBox1.Text;
            }
        }
    }
}
