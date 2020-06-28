using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcon
{
    public partial class Mcon : Form
    {
        public Mcon()
        {
            InitializeComponent();
        }

        private void Mcon_Load(object sender, EventArgs e)
        {
            Shadow.SetShadowForm(this);
        }
    }
}
