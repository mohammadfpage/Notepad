using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "باز کردن فایل";
                openDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read))
                        using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                        {
                            richTextBox1.Text = reader.ReadToEnd();
                        }

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطا در باز کردن فایل: " + ex.Message);
                    }
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "ذخیره فایل";
                saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveDialog.DefaultExt = "txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                        using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                        {
                            writer.Write(richTextBox1.Text);
                        }

                        MessageBox.Show("فایل با موفقیت ذخیره شد.", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطا در ذخیره فایل: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
