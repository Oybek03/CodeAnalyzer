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
    public partial class CosineSimilarity : Form
    {

        public string[] word1;
        public string[] word2;


        public CosineSimilarity()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.word1=openFile(openFileDialog1.FileName);
            }
        }


        private String[] openFile(string filename)
        {
            
            string[] words1 = Cos.EatWhiteChar(Cos.FromSource(filename));
            return words1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.word2=openFile(openFileDialog2.FileName);
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            Dictionary<string, double> frequencyTable1 = Cos.PrepareFrequency(this.word1);
            Dictionary<string, double> frequencyTable2 = Cos.PrepareFrequency(this.word2);

            //foreach (KeyValuePair<string, double> kv in frequencyTable1)
            //{
            //    Console.WriteLine("The word : {0} has repeated {1}", kv.Key, kv.Value);
            //}

            Dictionary<string, double> tfTable1 = Cos.TfFactorized(frequencyTable1);
            Dictionary<string, double> tfTable2 = Cos.TfFactorized(frequencyTable2);


            //foreach (KeyValuePair<string, double> kv in tfTable1)
            //{
            //    Console.WriteLine("The word : {0} has repeated {1}", kv.Key, kv.Value);
            //}

            //PrepareAllHashTables(tfTable1, tfTable2);
            //Console.WriteLine(CosineSimilarity(tfTable1, tfTable2));


            Dictionary<string, double>[] tables = new Dictionary<string, double>[2];
            tables[0] = tfTable1;
            tables[1] = tfTable2;

            Cos.PrepareAllHashTables(tables);

            Console.WriteLine(Cos.CosineSimilarity(tfTable1, tfTable2));
            MessageBox.Show(""+ Cos.CosineSimilarity(tfTable1, tfTable2));
            tables = Cos.GetPreparedTFIDFTables(Cos.IDFDocumentTable(tables), tables);


            Console.WriteLine(Cos.CosineSimilarity(tables[0], tables[1]));
            MessageBox.Show("" + Cos.CosineSimilarity(tables[0], tables[1]));
        }
    }
}
