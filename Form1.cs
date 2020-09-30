using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encryptie
{
    public partial class Form1 : Form
    {
        byte[] abc;
        byte[,] table;

        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK) ;
            {
                tbPath.Text = od.FileName; 
            }
        }

        private void rbEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEncrypt.Checked)
            {
                rbDecrypt.Checked = false;
            }
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecrypt.Checked)
            {
                rbEncrypt.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbEncrypt.Checked = true;
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);
            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];

                }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbPath.Text))
            {
                MessageBox.Show("Het bestand bestaat niet.");
                return;
            }
            if(String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Leeg wachtwoord. Type je wachtwoord");
                return;
            }
            try
            {
                byte[] fileContent = File.ReadAllBytes(tbPath.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(tbPassword.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];

                byte[] result = new byte[fileContent.Length];

                if (rbEncrypt.Checked)
                {
                    for(int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, KeyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if(abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for(int j = 0; j < 256; j++)
                            if(abc[j] == key)
                            {
                                KeyIndex = j;
                                break;
                            }
                        result[i] = table[KeyIndex, valueIndex];
                    }
                }
                else
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, KeyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                KeyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (table[KeyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                }
                String fileExt = Path.GetExtension(tbPath.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (" + fileExt + ") | *" + fileExt;
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
            }
            catch
            {
                MessageBox.Show("Bestand is in gebruik. Kies een ander bestand of sluit het bestand dat je wilt open");
                return;
            }
        }
    }
}
