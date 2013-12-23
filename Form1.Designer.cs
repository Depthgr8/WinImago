namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bmpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pngFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIFFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falseColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptWithWinImagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptWithWinImagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseWinImagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToEncryptAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToDecryptAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winImagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duoVisionInfotechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cEOLokeshAgrawalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pojectManagerDeepakSharmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsDesignerFaisalQuereshiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.t2Move = new System.Windows.Forms.ToolStripButton();
            this.t2Copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.t2Grayscale = new System.Windows.Forms.ToolStripButton();
            this.t2Falsecolors = new System.Windows.Forms.ToolStripButton();
            this.t2Negative = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.t2Encrypt = new System.Windows.Forms.ToolStripButton();
            this.t2Decrypt = new System.Windows.Forms.ToolStripButton();
            this.filepath = new System.Windows.Forms.ToolStripTextBox();
            this.t2Go = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.t2Imagestatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savenexit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.taToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.savenexit_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpgFileToolStripMenuItem,
            this.bmpFileToolStripMenuItem,
            this.pngFileToolStripMenuItem,
            this.tIFFFileToolStripMenuItem,
            this.gifToolStripMenuItem});
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            // 
            // jpgFileToolStripMenuItem
            // 
            this.jpgFileToolStripMenuItem.Name = "jpgFileToolStripMenuItem";
            this.jpgFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.jpgFileToolStripMenuItem.Text = ".JPG File";
            this.jpgFileToolStripMenuItem.Click += new System.EventHandler(this.jpgFileToolStripMenuItem_Click);
            // 
            // bmpFileToolStripMenuItem
            // 
            this.bmpFileToolStripMenuItem.Name = "bmpFileToolStripMenuItem";
            this.bmpFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.bmpFileToolStripMenuItem.Text = ".BMP File";
            this.bmpFileToolStripMenuItem.Click += new System.EventHandler(this.bmpFileToolStripMenuItem_Click);
            // 
            // pngFileToolStripMenuItem
            // 
            this.pngFileToolStripMenuItem.Name = "pngFileToolStripMenuItem";
            this.pngFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.pngFileToolStripMenuItem.Text = ".PNG File";
            this.pngFileToolStripMenuItem.Click += new System.EventHandler(this.pngFileToolStripMenuItem_Click);
            // 
            // tIFFFileToolStripMenuItem
            // 
            this.tIFFFileToolStripMenuItem.Name = "tIFFFileToolStripMenuItem";
            this.tIFFFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.tIFFFileToolStripMenuItem.Text = ".TIFF File";
            this.tIFFFileToolStripMenuItem.Click += new System.EventHandler(this.tIFFFileToolStripMenuItem_Click);
            // 
            // gifToolStripMenuItem
            // 
            this.gifToolStripMenuItem.Name = "gifToolStripMenuItem";
            this.gifToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.gifToolStripMenuItem.Text = ".GIF File";
            this.gifToolStripMenuItem.Click += new System.EventHandler(this.gifToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.falseColorsToolStripMenuItem,
            this.negativeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Icon_23;
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.t2Grayscale_Click);
            // 
            // falseColorsToolStripMenuItem
            // 
            this.falseColorsToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Icon_23;
            this.falseColorsToolStripMenuItem.Name = "falseColorsToolStripMenuItem";
            this.falseColorsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.falseColorsToolStripMenuItem.Text = "False colors";
            this.falseColorsToolStripMenuItem.Click += new System.EventHandler(this.t2Falsecolors_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Icon_23;
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.t2Negative_Click);
            // 
            // taToolStripMenuItem
            // 
            this.taToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptWithWinImagoToolStripMenuItem,
            this.decryptWithWinImagoToolStripMenuItem});
            this.taToolStripMenuItem.Name = "taToolStripMenuItem";
            this.taToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.taToolStripMenuItem.Text = "Task";
            // 
            // encryptWithWinImagoToolStripMenuItem
            // 
            this.encryptWithWinImagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("encryptWithWinImagoToolStripMenuItem.Image")));
            this.encryptWithWinImagoToolStripMenuItem.Name = "encryptWithWinImagoToolStripMenuItem";
            this.encryptWithWinImagoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.encryptWithWinImagoToolStripMenuItem.Text = "Encrypt with WinImago";
            this.encryptWithWinImagoToolStripMenuItem.Click += new System.EventHandler(this.t2Encrypt_Click);
            // 
            // decryptWithWinImagoToolStripMenuItem
            // 
            this.decryptWithWinImagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decryptWithWinImagoToolStripMenuItem.Image")));
            this.decryptWithWinImagoToolStripMenuItem.Name = "decryptWithWinImagoToolStripMenuItem";
            this.decryptWithWinImagoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.decryptWithWinImagoToolStripMenuItem.Text = "Decrypt with WinImago";
            this.decryptWithWinImagoToolStripMenuItem.Click += new System.EventHandler(this.t2Decrypt_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseWinImagoToolStripMenuItem,
            this.howToEncryptAFileToolStripMenuItem,
            this.howToDecryptAFileToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseWinImagoToolStripMenuItem
            // 
            this.howToUseWinImagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("howToUseWinImagoToolStripMenuItem.Image")));
            this.howToUseWinImagoToolStripMenuItem.Name = "howToUseWinImagoToolStripMenuItem";
            this.howToUseWinImagoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.howToUseWinImagoToolStripMenuItem.Text = "How to Use WinImago";
            this.howToUseWinImagoToolStripMenuItem.Click += new System.EventHandler(this.howToUseWinImagoToolStripMenuItem_Click);
            // 
            // howToEncryptAFileToolStripMenuItem
            // 
            this.howToEncryptAFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("howToEncryptAFileToolStripMenuItem.Image")));
            this.howToEncryptAFileToolStripMenuItem.Name = "howToEncryptAFileToolStripMenuItem";
            this.howToEncryptAFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.howToEncryptAFileToolStripMenuItem.Text = "How to Encrypt a file";
            this.howToEncryptAFileToolStripMenuItem.Click += new System.EventHandler(this.howToEncryptAFileToolStripMenuItem_Click);
            // 
            // howToDecryptAFileToolStripMenuItem
            // 
            this.howToDecryptAFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("howToDecryptAFileToolStripMenuItem.Image")));
            this.howToDecryptAFileToolStripMenuItem.Name = "howToDecryptAFileToolStripMenuItem";
            this.howToDecryptAFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.howToDecryptAFileToolStripMenuItem.Text = "How to Decrypt a file";
            this.howToDecryptAFileToolStripMenuItem.Click += new System.EventHandler(this.howToDecryptAFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winImagoToolStripMenuItem,
            this.duoVisionInfotechToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // winImagoToolStripMenuItem
            // 
            this.winImagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("winImagoToolStripMenuItem.Image")));
            this.winImagoToolStripMenuItem.Name = "winImagoToolStripMenuItem";
            this.winImagoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.winImagoToolStripMenuItem.Text = "WinImago";
            this.winImagoToolStripMenuItem.Click += new System.EventHandler(this.winImagoToolStripMenuItem_Click);
            // 
            // duoVisionInfotechToolStripMenuItem
            // 
            this.duoVisionInfotechToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pojectManagerDeepakSharmaToolStripMenuItem,
            this.cEOLokeshAgrawalToolStripMenuItem,
            this.graphicsDesignerFaisalQuereshiToolStripMenuItem});
            this.duoVisionInfotechToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("duoVisionInfotechToolStripMenuItem.Image")));
            this.duoVisionInfotechToolStripMenuItem.Name = "duoVisionInfotechToolStripMenuItem";
            this.duoVisionInfotechToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.duoVisionInfotechToolStripMenuItem.Text = "Duo Vision Infotech Ltd.";
            // 
            // cEOLokeshAgrawalToolStripMenuItem
            // 
            this.cEOLokeshAgrawalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cEOLokeshAgrawalToolStripMenuItem.Image")));
            this.cEOLokeshAgrawalToolStripMenuItem.Name = "cEOLokeshAgrawalToolStripMenuItem";
            this.cEOLokeshAgrawalToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.cEOLokeshAgrawalToolStripMenuItem.Text = "CEO                                +91-9460140555";
            // 
            // pojectManagerDeepakSharmaToolStripMenuItem
            // 
            this.pojectManagerDeepakSharmaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pojectManagerDeepakSharmaToolStripMenuItem.Image")));
            this.pojectManagerDeepakSharmaToolStripMenuItem.Name = "pojectManagerDeepakSharmaToolStripMenuItem";
            this.pojectManagerDeepakSharmaToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.pojectManagerDeepakSharmaToolStripMenuItem.Text = "Poject Developer    --   depthgr8@gmail.com ";
            // 
            // graphicsDesignerFaisalQuereshiToolStripMenuItem
            // 
            this.graphicsDesignerFaisalQuereshiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("graphicsDesignerFaisalQuereshiToolStripMenuItem.Image")));
            this.graphicsDesignerFaisalQuereshiToolStripMenuItem.Name = "graphicsDesignerFaisalQuereshiToolStripMenuItem";
            this.graphicsDesignerFaisalQuereshiToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.graphicsDesignerFaisalQuereshiToolStripMenuItem.Text = "Graphics Designer        +91-9461969473";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t2Move,
            this.t2Copy,
            this.toolStripButton3,
            this.t2Grayscale,
            this.t2Falsecolors,
            this.t2Negative,
            this.toolStripSeparator1,
            this.t2Encrypt,
            this.t2Decrypt,
            this.filepath,
            this.t2Go});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(688, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // t2Move
            // 
            this.t2Move.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t2Move.Image = ((System.Drawing.Image)(resources.GetObject("t2Move.Image")));
            this.t2Move.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t2Move.Name = "t2Move";
            this.t2Move.Size = new System.Drawing.Size(23, 22);
            this.t2Move.Text = "toolStripButton1";
            this.t2Move.ToolTipText = "Move";
            this.t2Move.Click += new System.EventHandler(this.t2Move_Click);
            // 
            // t2Copy
            // 
            this.t2Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t2Copy.Image = ((System.Drawing.Image)(resources.GetObject("t2Copy.Image")));
            this.t2Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t2Copy.Name = "t2Copy";
            this.t2Copy.Size = new System.Drawing.Size(23, 22);
            this.t2Copy.Text = "toolStripButton2";
            this.t2Copy.ToolTipText = "Copy";
            this.t2Copy.Click += new System.EventHandler(this.t2Copy_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(6, 25);
            // 
            // t2Grayscale
            // 
            this.t2Grayscale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t2Grayscale.Image = ((System.Drawing.Image)(resources.GetObject("t2Grayscale.Image")));
            this.t2Grayscale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t2Grayscale.Name = "t2Grayscale";
            this.t2Grayscale.Size = new System.Drawing.Size(23, 22);
            this.t2Grayscale.Text = "toolStripButton4";
            this.t2Grayscale.ToolTipText = "Grayscale";
            this.t2Grayscale.Click += new System.EventHandler(this.t2Grayscale_Click);
            // 
            // t2Falsecolors
            // 
            this.t2Falsecolors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t2Falsecolors.Image = ((System.Drawing.Image)(resources.GetObject("t2Falsecolors.Image")));
            this.t2Falsecolors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t2Falsecolors.Name = "t2Falsecolors";
            this.t2Falsecolors.Size = new System.Drawing.Size(23, 22);
            this.t2Falsecolors.Text = "toolStripButton5";
            this.t2Falsecolors.ToolTipText = "False Colors";
            this.t2Falsecolors.Click += new System.EventHandler(this.t2Falsecolors_Click);
            // 
            // t2Negative
            // 
            this.t2Negative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t2Negative.Image = ((System.Drawing.Image)(resources.GetObject("t2Negative.Image")));
            this.t2Negative.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t2Negative.Name = "t2Negative";
            this.t2Negative.Size = new System.Drawing.Size(23, 22);
            this.t2Negative.Text = "toolStripButton6";
            this.t2Negative.ToolTipText = "Negative";
            this.t2Negative.Click += new System.EventHandler(this.t2Negative_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // t2Encrypt
            // 
            this.t2Encrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t2Encrypt.Image = ((System.Drawing.Image)(resources.GetObject("t2Encrypt.Image")));
            this.t2Encrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t2Encrypt.Name = "t2Encrypt";
            this.t2Encrypt.Size = new System.Drawing.Size(23, 22);
            this.t2Encrypt.Text = "toolStripButton7";
            this.t2Encrypt.ToolTipText = "Encrypt";
            this.t2Encrypt.Click += new System.EventHandler(this.t2Encrypt_Click);
            // 
            // t2Decrypt
            // 
            this.t2Decrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t2Decrypt.Image = ((System.Drawing.Image)(resources.GetObject("t2Decrypt.Image")));
            this.t2Decrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t2Decrypt.Name = "t2Decrypt";
            this.t2Decrypt.Size = new System.Drawing.Size(23, 22);
            this.t2Decrypt.Text = "toolStripButton8";
            this.t2Decrypt.ToolTipText = "Decrypt";
            this.t2Decrypt.Click += new System.EventHandler(this.t2Decrypt_Click);
            // 
            // filepath
            // 
            this.filepath.BackColor = System.Drawing.SystemColors.Menu;
            this.filepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filepath.Name = "filepath";
            this.filepath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filepath.Size = new System.Drawing.Size(300, 25);
            this.filepath.ToolTipText = "Set Input file path here";
            // 
            // t2Go
            // 
            this.t2Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t2Go.Image = ((System.Drawing.Image)(resources.GetObject("t2Go.Image")));
            this.t2Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t2Go.Name = "t2Go";
            this.t2Go.Size = new System.Drawing.Size(23, 22);
            this.t2Go.Text = "toolStripButton9";
            this.t2Go.ToolTipText = "Go";
            this.t2Go.Click += new System.EventHandler(this.setFilePath);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t2Imagestatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // t2Imagestatus
            // 
            this.t2Imagestatus.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.t2Imagestatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2Imagestatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t2Imagestatus.Name = "t2Imagestatus";
            this.t2Imagestatus.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.t2Imagestatus.Size = new System.Drawing.Size(383, 18);
            this.t2Imagestatus.Text = "Choose one image to Edit or Encrypt";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 368);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.savenexit);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(341, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 333);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "After";
            // 
            // savenexit
            // 
            this.savenexit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savenexit.Location = new System.Drawing.Point(76, 298);
            this.savenexit.Name = "savenexit";
            this.savenexit.Size = new System.Drawing.Size(197, 29);
            this.savenexit.TabIndex = 9;
            this.savenexit.Text = "Save and Exit";
            this.savenexit.UseVisualStyleBackColor = true;
            this.savenexit.Click += new System.EventHandler(this.savenexit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 273);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 333);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Before";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(18, 296);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(222, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Let\'s do something";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "After";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(688, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(704, 478);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinImago - Your Personal App.";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winImagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duoVisionInfotechToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton t2Move;
        private System.Windows.Forms.ToolStripButton t2Copy;
        private System.Windows.Forms.ToolStripButton t2Grayscale;
        private System.Windows.Forms.ToolStripButton t2Falsecolors;
        private System.Windows.Forms.ToolStripButton t2Negative;
        private System.Windows.Forms.ToolStripSeparator toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton t2Encrypt;
        private System.Windows.Forms.ToolStripButton t2Decrypt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpgFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bmpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pngFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem falseColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptWithWinImagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptWithWinImagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseWinImagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToEncryptAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToDecryptAFileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem cEOLokeshAgrawalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pojectManagerDeepakSharmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicsDesignerFaisalQuereshiToolStripMenuItem;
        private System.Windows.Forms.Button savenexit;
        private System.Windows.Forms.ToolStripTextBox filepath;
        private System.Windows.Forms.ToolStripButton t2Go;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel t2Imagestatus;
        private System.Windows.Forms.ToolStripMenuItem tIFFFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gifToolStripMenuItem;
    }
}

