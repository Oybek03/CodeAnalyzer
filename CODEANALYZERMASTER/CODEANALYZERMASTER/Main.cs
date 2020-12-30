using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEANALYZERMASTER
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            CodeAnalyzer f1 = new CodeAnalyzer();
            f1.Show();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            CosineSimilarity f2 = new CosineSimilarity();
            f2.Show();
        }
    }
}
