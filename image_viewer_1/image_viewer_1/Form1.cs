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

namespace image_viewer_1
{
    public partial class Form1 : Form
    {
        List<string> fileNames = new List<string>();
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        public bool Multiselect { get; private set; }
        public bool ValidateNames { get; private set; }
        public string Filter { get; private set; }
        public object DiaglogResult { get; private set; }

        private void btnopen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames=true, Filter="JPEG|*.jpg"})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileNames.Clear();
                    listViewFile.Items.Clear();
                    foreach (string filename in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        fileNames.Add(fi.FullName);
                        listViewFile.Items.Add(fi.Name, 0);

                    }
                }
                
            }
        }

        private void listViewFile_ItemActivate(object sender, EventArgs e)
        {
            if (listViewFile.FocusedItem!= null)
            {
                using(Form2 frm = new Form2())
                {
                    Image img = Image.FromFile(fileNames[listViewFile.FocusedItem.Index]);
                    frm.ImageBox = img;
                    frm.ShowDialog();

                }

            }
        }
    }
}
