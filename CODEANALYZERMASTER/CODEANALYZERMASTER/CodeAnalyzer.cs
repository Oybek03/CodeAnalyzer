using CODEANALYZERMASTER.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace CODEANALYZERMASTER
{
    public partial class CodeAnalyzer : Form
    {
        public CodeAnalyzer()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName);
            }
        }

        private void openFile(string filename)
        {

            LLOC2 result = new LLOC2();
            ProcessFile(filename, result);
            this.propertyGrid1.SelectedObject = result;
            this.propertyGrid1.Refresh();

           


            string[] seriesArray = { "LOC", "BLOC", "CLOC", "SCLOC", "NCLOC" };
            int[] pointsArray = { result.LOC, result.BLOC, result.CLOC, result.SCLOC, result.NCLOC };

            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
            }

        }

        private static void ProcessFile(string filename, LLOC2 result)
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (var line in lines)
            {
                string trimedLine = line.Trim();
                result.OnCodeLine(trimedLine);
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {

            string fileName = Settings.Default.FolderName;
            if (fileName == string.Empty)
            {
                MessageBox.Show("folder is empty");
                return;
            }
            else {
                try
                {
                    var files = Directory.GetFiles(fileName, "*", SearchOption.AllDirectories);
                    LLOC2 result = new LLOC2();
                    foreach (var filename in files)
                    {
                        FileInfo fileInfo = new FileInfo(filename);
                        if (fileInfo.Extension == ".cs" || fileInfo.Extension == ".java")
                        {
                            ProcessFile(filename, result);
                        }
                    }
                    this.propertyGrid1.SelectedObject = result;
                    this.propertyGrid1.Refresh();

                    //   this.chart1.Titles.Add("CA");


                    string[] seriesArray = { "LOC", "BLOC", "CLOC", "SCLOC", "NCLOC" };
                    int[] pointsArray = { result.LOC, result.BLOC, result.CLOC, result.SCLOC, result.NCLOC };

                    for (int i = 0; i < seriesArray.Length; i++)
                    {
                        // Add series.
                        Series series = this.chart1.Series.Add(seriesArray[i]);

                        // Add point.
                        series.Points.Add(pointsArray[i]);
                    }

                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.FolderName = this.folderBrowserDialog1.SelectedPath;
                Settings.Default.Save();
                this.txtFolderName.Text = Settings.Default.FolderName;
            }
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtFolderName.Text = Settings.Default.FolderName;
        }

        

      
    }
}
