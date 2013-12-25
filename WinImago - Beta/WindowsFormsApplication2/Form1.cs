using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Drawing.Imaging;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string filename,ext,dff,dfs;
       
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void setFilePath(object sender, EventArgs e)
        {
            try
            {
                filename = filepath.Text;
                pictureBox1.ImageLocation = filepath.Text;
                pictureBox2.ImageLocation = filepath.Text;
                ext = filepath.Text.Substring((filepath.Text.LastIndexOf('.') + 1), (filepath.Text.Length) - (filepath.Text.LastIndexOf('.') + 1));
                //MessageBox.Show(filepath.Text.Substring(0, filepath.Text.LastIndexOf('.') + 1) + ext);
                t2Imagestatus.Text = "You have selected this image - Now specify a task";
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this","Violation of Rules",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
        }

        private void t2Copy_Click(object sender, EventArgs e)
        {
            try
            {
            FileStream fs = new FileStream(filepath.Text, FileMode.Open);
            FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'),"_new"), FileMode.Create);
            int n;
            n = (int)fs.Length;
            byte i;
            for (int j = 0; j < n; j++)
            {
                i = (byte)fs.ReadByte();
                fo.WriteByte((byte)i);
            }
            fo.Flush();
            fo.Close();
            MessageBox.Show("Image copied to that folder, Exit now ?","Current Status",MessageBoxButtons.OK,MessageBoxIcon.Question);
            WindowsFormsApplication2.Form1.ActiveForm.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this","Violation of Rules",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }        }

        private void t2Move_Click(object sender, EventArgs e)
        {
            try
            {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            FileStream fs = new FileStream(filepath.Text, FileMode.Open);
            FileStream fo = new FileStream(fd.SelectedPath+"/"+filepath.Text.Substring(filepath.Text.LastIndexOf('/')) , FileMode.Create);
            int n;
            n = (int)fs.Length;
            byte i;
            for (int j = 0; j < n; j++)
            {
                i = (byte)fs.ReadByte();
                fo.WriteByte((byte)i);
            }
            fo.Flush();
            fo.Close();
            filename = filepath.Text;
            pictureBox1.ImageLocation = fo.Name;
            pictureBox2.ImageLocation = fo.Name;
            t2Imagestatus.Text = "Image is now moved to selected folder - Try other images...";
        }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this","Violation of Rules",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
        }

        private void t2Grayscale_Click(object sender, EventArgs e)
        {
            if (ext != "bmp" && ext != "BMP")
            {
                try
                {
                    bmpFileToolStripMenuItem_Click(sender, e);
                    filepath.Text = filepath.Text.Substring(0, filepath.Text.LastIndexOf('.')) + "_cpy" + ".bmp";
                    FileStream fs = new FileStream(filepath.Text, FileMode.Open);
                    FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'), "_temp"), FileMode.Create);
                    int n;
                    n = (int)fs.Length;
                    byte i;
                    for (int j = 0; j < n; j++)
                    {
                        if (j < 54)
                        {
                            i = (byte)fs.ReadByte();
                            fo.WriteByte((byte)i);
                        }
                        else
                        {
                            int s = 0;
                            for (int k = 0; k < 3; k++)
                            {
                                s = s + (byte)fs.ReadByte();
                            }
                            i = (byte)(s / 3);
                            for (int k = 0; k < 3; k++)
                            {
                                fo.WriteByte((byte)i);
                            }
                            j = j + 2;

                        }
                    }
                    fo.Flush();
                    fo.Close();
                    filename = filepath.Text;
                    pictureBox2.ImageLocation = fo.Name;
                    filename = fo.Name;
                    if (ext == "jpg" || ext == "JPG")
                        jpgFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "png" || ext == "PNG")
                        pngFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "tiff" || ext == "TIFF")
                        tIFFFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "gif" || ext == "GIF")
                        gifToolStripMenuItem_Click(sender, e);
                    negativeToolStripMenuItem.Enabled = false;
                    falseColorsToolStripMenuItem.Enabled = false;
                    grayscaleToolStripMenuItem.Enabled = false;
                    t2Grayscale.Enabled = false;
                    t2Falsecolors.Enabled = false;
                    t2Negative.Enabled = false;
                    fs.Flush();
                    fs.Close();
                    File.Delete(fs.Name);
                    t2Imagestatus.Text = "Image is now Black n White";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            
            else
            {
                try
                {
                    FileStream fs = new FileStream(filepath.Text, FileMode.Open);
                    FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'), "_temp"), FileMode.Create);
                    int n;
                    n = (int)fs.Length;
                    byte i;
                    for (int j = 0; j < n; j++)
                    {
                        if (j < 54)
                        {
                            i = (byte)fs.ReadByte();
                            fo.WriteByte((byte)i);
                        }
                        else
                        {
                            int s = 0;
                            for (int k = 0; k < 3; k++)
                            {
                                s = s + (byte)fs.ReadByte();
                            }
                            i = (byte)(s / 3);
                            for (int k = 0; k < 3; k++)
                            {
                                fo.WriteByte((byte)i);
                            }
                            j = j + 2;

                        }
                    }
                    fo.Flush();
                    fo.Close();
                    filename = filepath.Text;
                    pictureBox2.ImageLocation = fo.Name;
                    t2Imagestatus.Text = "Image is now in grayscale";
                    dff = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
        }
        }

        private void t2Falsecolors_Click(object sender, EventArgs e)
        {
            try
            {
                if (ext != "bmp" && ext != "BMP")
                {
                    bmpFileToolStripMenuItem_Click(sender, e);
                    filepath.Text = filepath.Text.Substring(0, filepath.Text.LastIndexOf('.')) + "_cpy" + ".bmp";
                    FileStream fs = new FileStream(filepath.Text, FileMode.Open);
                    FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'), "_temp"), FileMode.Create);
                    int n;
                    n = (int)fs.Length;
                    byte i;
                    for (int j = 0; j < 54; j++)
                    {
                        i = (byte)fs.ReadByte();
                        fo.WriteByte((byte)i);
                    }
                    byte a, b, c;
                    for (int j = 54; j <= n; j = j + 3)
                    {
                        a = (byte)fs.ReadByte();
                        b = (byte)fs.ReadByte();
                        c = (byte)fs.ReadByte();
                        fo.WriteByte((byte)((c + a) / 2));
                        fo.WriteByte((byte)((b + a) / 2));
                        fo.WriteByte((byte)((c + b) / 2));
                    }
                    fo.Flush();
                    fo.Close();
                    filename = filepath.Text;
                    pictureBox2.ImageLocation = fo.Name;
                    filename = fo.Name;
                    if (ext == "jpg" || ext == "JPG")
                        jpgFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "png" || ext == "PNG")
                        pngFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "tiff" || ext == "TIFF")
                        tIFFFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "gif" || ext == "GIF")
                        gifToolStripMenuItem_Click(sender, e);
                    negativeToolStripMenuItem.Enabled = false;
                    falseColorsToolStripMenuItem.Enabled = false;
                    grayscaleToolStripMenuItem.Enabled = false;
                    t2Grayscale.Enabled = false;
                    t2Falsecolors.Enabled = false;
                    t2Negative.Enabled = false;
                    fs.Flush();
                    fs.Close();
                    File.Delete(fs.Name);
                    t2Imagestatus.Text = "Image is now in False colors";

                }

                else
                {
                    FileStream fs = new FileStream(filepath.Text, FileMode.Open);
                    FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'), "_temp"), FileMode.Create);
                    int n;
                    n = (int)fs.Length;
                    byte i;
                    for (int j = 0; j < 54; j++)
                    {
                        i = (byte)fs.ReadByte();
                        fo.WriteByte((byte)i);
                    }
                    byte a, b, c;
                    for (int j = 54; j <= n; j = j + 3)
                    {
                        a = (byte)fs.ReadByte();
                        b = (byte)fs.ReadByte();
                        c = (byte)fs.ReadByte();
                        fo.WriteByte((byte)((c + a) / 2));
                        fo.WriteByte((byte)((b + a) / 2));
                        fo.WriteByte((byte)((c + b) / 2));
                    }
                    fo.Flush();
                    fo.Close();
                    filename = filepath.Text;
                    pictureBox2.ImageLocation = fo.Name;
                    t2Imagestatus.Text = "Image now contains false colors";
                    dff = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void t2Negative_Click(object sender, EventArgs e)
        {
            try
            {
                if (ext != "bmp" && ext != "BMP")
                {
                    bmpFileToolStripMenuItem_Click(sender, e);
                    filepath.Text = filepath.Text.Substring(0, filepath.Text.LastIndexOf('.')) + "_cpy" + ".bmp";
                    FileStream fs = new FileStream(filepath.Text, FileMode.Open);
                    FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'), "_temp"), FileMode.Create);
                    int n;
                    n = (int)fs.Length;
                    byte i;
                    for (int j = 0; j < n; j++)
                    {
                        i = (byte)fs.ReadByte();
                        if (j < 54)
                            fo.WriteByte((byte)i);
                        else
                            fo.WriteByte((byte)(255 - i));
                    }
                    fo.Flush();
                    fo.Close();
                    filename = filepath.Text;
                    pictureBox2.ImageLocation = fo.Name;
                    filename = fo.Name;
                    if (ext == "jpg" || ext == "JPG")
                        jpgFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "png" || ext == "PNG")
                        pngFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "tiff" || ext == "TIFF")
                        tIFFFileToolStripMenuItem_Click(sender, e);
                    else if (ext == "gif" || ext == "GIF")
                        gifToolStripMenuItem_Click(sender, e);
                    dff = fs.Name;
                    dfs = fo.Name;
                    fs.Flush();
                    fs.Close();
                    negativeToolStripMenuItem.Enabled = false;
                    falseColorsToolStripMenuItem.Enabled = false;
                    grayscaleToolStripMenuItem.Enabled = false;
                    t2Grayscale.Enabled = false;
                    t2Falsecolors.Enabled = false;
                    t2Negative.Enabled = false;
                    t2Imagestatus.Text = "Image is now negative";
                    File.Delete(dff);
                }
                else
                {
                    FileStream fs = new FileStream(filepath.Text, FileMode.Open);
                    FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'), "_temp"), FileMode.Create);
                    int n;


                    n = (int)fs.Length;
                    byte i;
                    for (int j = 0; j < n; j++)
                    {
                        i = (byte)fs.ReadByte();
                        if (j < 54)
                            fo.WriteByte((byte)i);
                        else
                            fo.WriteByte((byte)(255 - i));
                    }
                    fo.Flush();
                    fo.Close();
                    filename = filepath.Text;
                    pictureBox2.ImageLocation = fo.Name;
                    t2Imagestatus.Text = "Image is now negative";
                    dff = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void t2Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(filepath.Text, FileMode.Open);
                FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'), "_en"), FileMode.Create);
                int n;
                n = (int)fs.Length;
                byte i;
                for (int j = 0; j < n; j++)
                {
                    i = (byte)fs.ReadByte();
                    if (j < 54)
                        fo.WriteByte((byte)(i + 1));
                    else
                        fo.WriteByte((byte)i);
                }
                fo.Flush();
                fo.Close();
                filename = filepath.Text;
                pictureBox2.ImageLocation = fo.Name;
                t2Imagestatus.Text = "Image is now in Encrypted - Now you can delete original image";
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }


        private void t2Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(filepath.Text, FileMode.Open);
                FileStream fo = new FileStream(filepath.Text.Insert(filepath.Text.LastIndexOf('.'), "_dc"), FileMode.Create);
                int n;
                n = (int)fs.Length;
                byte i;
                for (int j = 0; j < n; j++)
                {
                    i = (byte)fs.ReadByte();
                    if (j < 54)
                        fo.WriteByte((byte)(i - 1));
                    else
                        fo.WriteByte((byte)i);
                }
                fo.Flush();
                fo.Close();
                filename = filepath.Text;
                pictureBox2.ImageLocation = fo.Name;
                t2Imagestatus.Text = "Image is successfully decrypted";
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void savenexit_Click(object sender, EventArgs e)
        {
            try
            {
                if (filepath.Text == "")
                {
                    MessageBox.Show("You are not playing by rules, You can' do this....Exit WinImago", "Violation of Rules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    exit_Click(sender, e);
                }
                    string sts = MessageBox.Show("Original file will be lost !", "Important Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (sts == "Yes")
                {
                    FileSystem.DeleteFile(filename);
                    WindowsFormsApplication2.Form1.ActiveForm.Close();
                }
                else
                    WindowsFormsApplication2.Form1.ActiveForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            }

        private void exit_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.Form1.ActiveForm.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "BMP Files (*.bmp)|*.bmp|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|TIFF Files (*.tiff)|*.tiff";
                ofd.ShowDialog();
                ofd.FileName = ofd.FileName.Replace('\\', '/');
                filepath.Text = ofd.FileName;
                setFilePath(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void setPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //   Application.Run(new Form1());
              ShowDialog(Form1.ActiveForm);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_Click(sender, e);
        }



        private void jpgFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            Image Dummy = Image.FromFile(filename);
            Dummy.Save(filepath.Text.Substring(0, filepath.Text.LastIndexOf('.'))+"_cpy" + ".jpg", ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this","Violation of Rules",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }   
        }

        private void pngFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            Image Dummy = Image.FromFile(filename);
            Dummy.Save(filepath.Text.Substring(0, filepath.Text.LastIndexOf('.')) + "_cpy" + ".png", ImageFormat.Png);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this","Violation of Rules",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
        }

        private void tIFFFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            Image Dummy = Image.FromFile(filename);
            Dummy.Save(filepath.Text.Substring(0, filepath.Text.LastIndexOf('.')) + "_cpy" + ".tiff", ImageFormat.Tiff);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this","Violation of Rules",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
        }



        private void bmpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            Image Dummy = Image.FromFile(filename);
            Dummy.Save(filepath.Text.Substring(0, filepath.Text.LastIndexOf('.')) + "_cpy" + ".bmp", ImageFormat.Bmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this","Violation of Rules",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
        }

        private void gifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Image Dummy = Image.FromFile(filename);
                Dummy.Save(filepath.Text.Substring(0, filepath.Text.LastIndexOf('.')) + "_cpy" + ".gif", ImageFormat.Gif);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not playing by rules, You can' do this", "Violation of Rules", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void howToUseWinImagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application solves the purpose for image encryption, it also provides a bit of image manipulation, You just need to click on the task you want to apply on your image , never forget to click 'Save n Exit' button before you leave ... Well, we recommend you to use .bmp image files for lossless image quality and better effects ","How to use WinImago",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void howToEncryptAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WinImago makes it easier for you to encrypt image file, just press Encrypt button from toolbar or select it from Menu Bar , Press 'Save n Exit'.","How to Encrypt a file", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void howToDecryptAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WinImago can decrypt your image file , First choose one encrypted file and then press Decrypt button from ToolBar, You can also do this if you select this option from Menubar. Finally Press 'Save n Exit' Button","How to Decrypt a file", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void winImagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WinImago is a freeware application , You can use this application without any license or key, WinImago is a light weight application which you can use to encrypt your personal and confidential images. WinImago also provides you some basic image editing tools like grayscale, false colors and negative conversion of images. You can also use WinImago to copy and move Image Files as well as to change their image formats , With WinImago you can easily save your image files into other image file format ","About - WinImago (My Personal App)");
        }
  

    }
}
