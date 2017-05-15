using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FærdighedstestSix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                using (StreamReader file = File.OpenText(openFileDialog1.FileName))
                {
                    textBox1.Text = file.ReadToEnd();
                }
            }
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            DialogResult dResult = openFileDialog1.ShowDialog();
            
            if (dResult == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                File.WriteAllText(path, textBox1.Text);
            }
        }
    }
}
