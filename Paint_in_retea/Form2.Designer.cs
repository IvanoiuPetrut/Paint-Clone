
namespace Paint_in_retea
{
    partial class fPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPaint));
            this.btTriangle = new System.Windows.Forms.Button();
            this.btEclipse = new System.Windows.Forms.Button();
            this.btHexagon = new System.Windows.Forms.Button();
            this.sliderR = new System.Windows.Forms.TrackBar();
            this.sliderG = new System.Windows.Forms.TrackBar();
            this.sliderB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.sliderWidthBrush = new System.Windows.Forms.TrackBar();
            this.labelPenWidth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelJitterValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sliderHueJitter = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSquareHead = new System.Windows.Forms.Button();
            this.btRoundHead = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btFlipHor = new System.Windows.Forms.Button();
            this.btFlipVer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btText = new System.Windows.Forms.Button();
            this.btInsertText = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btFillBrush = new System.Windows.Forms.Button();
            this.btRake = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btSimHor = new System.Windows.Forms.Button();
            this.btSymVer = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btFill = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.spatiuDesen = new System.Windows.Forms.PictureBox();
            this.btEraser = new System.Windows.Forms.Button();
            this.btBrush = new System.Windows.Forms.Button();
            this.pictureCuloarePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderWidthBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderHueJitter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatiuDesen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCuloarePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btTriangle
            // 
            this.btTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTriangle.ForeColor = System.Drawing.Color.White;
            this.btTriangle.Image = global::Paint_in_retea.Properties.Resources.triOF;
            this.btTriangle.Location = new System.Drawing.Point(501, 36);
            this.btTriangle.Name = "btTriangle";
            this.btTriangle.Size = new System.Drawing.Size(75, 75);
            this.btTriangle.TabIndex = 4;
            this.btTriangle.Text = "Triangle";
            this.btTriangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTriangle.UseVisualStyleBackColor = false;
            this.btTriangle.Click += new System.EventHandler(this.btTriangle_Click);
            // 
            // btEclipse
            // 
            this.btEclipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btEclipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEclipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEclipse.ForeColor = System.Drawing.Color.White;
            this.btEclipse.Image = global::Paint_in_retea.Properties.Resources.elipseOF;
            this.btEclipse.Location = new System.Drawing.Point(669, 36);
            this.btEclipse.Name = "btEclipse";
            this.btEclipse.Size = new System.Drawing.Size(75, 75);
            this.btEclipse.TabIndex = 5;
            this.btEclipse.Text = "Ellipse";
            this.btEclipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEclipse.UseVisualStyleBackColor = false;
            this.btEclipse.Click += new System.EventHandler(this.btEclipse_Click);
            // 
            // btHexagon
            // 
            this.btHexagon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btHexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHexagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHexagon.ForeColor = System.Drawing.Color.White;
            this.btHexagon.Image = global::Paint_in_retea.Properties.Resources.hexOF;
            this.btHexagon.Location = new System.Drawing.Point(585, 36);
            this.btHexagon.Name = "btHexagon";
            this.btHexagon.Size = new System.Drawing.Size(75, 75);
            this.btHexagon.TabIndex = 6;
            this.btHexagon.Text = "Hexagon";
            this.btHexagon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHexagon.UseVisualStyleBackColor = false;
            this.btHexagon.Click += new System.EventHandler(this.btHexagon_Click);
            // 
            // sliderR
            // 
            this.sliderR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.sliderR.Location = new System.Drawing.Point(114, 37);
            this.sliderR.Maximum = 255;
            this.sliderR.Name = "sliderR";
            this.sliderR.Size = new System.Drawing.Size(176, 45);
            this.sliderR.TabIndex = 8;
            this.sliderR.Scroll += new System.EventHandler(this.sliderR_Scroll);
            // 
            // sliderG
            // 
            this.sliderG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.sliderG.Location = new System.Drawing.Point(114, 66);
            this.sliderG.Maximum = 255;
            this.sliderG.Name = "sliderG";
            this.sliderG.Size = new System.Drawing.Size(176, 45);
            this.sliderG.TabIndex = 9;
            this.sliderG.Scroll += new System.EventHandler(this.sliderG_Scroll);
            // 
            // sliderB
            // 
            this.sliderB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.sliderB.Location = new System.Drawing.Point(114, 95);
            this.sliderB.Maximum = 255;
            this.sliderB.Name = "sliderB";
            this.sliderB.Size = new System.Drawing.Size(176, 45);
            this.sliderB.TabIndex = 10;
            this.sliderB.Scroll += new System.EventHandler(this.sliderB_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(100, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(101, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "B";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.ForeColor = System.Drawing.Color.Transparent;
            this.labelR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelR.Location = new System.Drawing.Point(284, 37);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(18, 20);
            this.labelR.TabIndex = 14;
            this.labelR.Text = "0";
            this.labelR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG.ForeColor = System.Drawing.Color.Transparent;
            this.labelG.Location = new System.Drawing.Point(284, 66);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(18, 20);
            this.labelG.TabIndex = 15;
            this.labelG.Text = "0";
            this.labelG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.Color.Transparent;
            this.labelB.Location = new System.Drawing.Point(284, 96);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(18, 20);
            this.labelB.TabIndex = 16;
            this.labelB.Text = "0";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sliderWidthBrush
            // 
            this.sliderWidthBrush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.sliderWidthBrush.Location = new System.Drawing.Point(114, 102);
            this.sliderWidthBrush.Maximum = 100;
            this.sliderWidthBrush.Name = "sliderWidthBrush";
            this.sliderWidthBrush.Size = new System.Drawing.Size(164, 45);
            this.sliderWidthBrush.TabIndex = 17;
            this.sliderWidthBrush.Value = 10;
            this.sliderWidthBrush.Scroll += new System.EventHandler(this.sliderWidthBrush_Scroll);
            // 
            // labelPenWidth
            // 
            this.labelPenWidth.AutoSize = true;
            this.labelPenWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.labelPenWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenWidth.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPenWidth.Location = new System.Drawing.Point(280, 133);
            this.labelPenWidth.Name = "labelPenWidth";
            this.labelPenWidth.Size = new System.Drawing.Size(27, 20);
            this.labelPenWidth.TabIndex = 18;
            this.labelPenWidth.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Width";
            // 
            // labelJitterValue
            // 
            this.labelJitterValue.AutoSize = true;
            this.labelJitterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.labelJitterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJitterValue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJitterValue.Location = new System.Drawing.Point(274, 137);
            this.labelJitterValue.Name = "labelJitterValue";
            this.labelJitterValue.Size = new System.Drawing.Size(18, 20);
            this.labelJitterValue.TabIndex = 20;
            this.labelJitterValue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(16, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hue Jitter";
            // 
            // sliderHueJitter
            // 
            this.sliderHueJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.sliderHueJitter.Location = new System.Drawing.Point(110, 132);
            this.sliderHueJitter.Maximum = 25;
            this.sliderHueJitter.Name = "sliderHueJitter";
            this.sliderHueJitter.Size = new System.Drawing.Size(168, 45);
            this.sliderHueJitter.TabIndex = 22;
            this.sliderHueJitter.Scroll += new System.EventHandler(this.sliderHueJitter_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btSquareHead);
            this.panel1.Controls.Add(this.btRoundHead);
            this.panel1.Location = new System.Drawing.Point(326, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 86);
            this.panel1.TabIndex = 25;
            // 
            // btSquareHead
            // 
            this.btSquareHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btSquareHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSquareHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSquareHead.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSquareHead.Location = new System.Drawing.Point(424, 50);
            this.btSquareHead.Name = "btSquareHead";
            this.btSquareHead.Size = new System.Drawing.Size(65, 30);
            this.btSquareHead.TabIndex = 29;
            this.btSquareHead.Text = "Square";
            this.btSquareHead.UseVisualStyleBackColor = false;
            this.btSquareHead.Click += new System.EventHandler(this.btSquareHead_Click);
            // 
            // btRoundHead
            // 
            this.btRoundHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btRoundHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRoundHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRoundHead.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRoundHead.Location = new System.Drawing.Point(424, 7);
            this.btRoundHead.Name = "btRoundHead";
            this.btRoundHead.Size = new System.Drawing.Size(65, 30);
            this.btRoundHead.TabIndex = 28;
            this.btRoundHead.Text = "Round";
            this.btRoundHead.UseVisualStyleBackColor = false;
            this.btRoundHead.Click += new System.EventHandler(this.btRoundHead_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.sliderHueJitter);
            this.panel2.Controls.Add(this.sliderWidthBrush);
            this.panel2.Controls.Add(this.labelJitterValue);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 180);
            this.panel2.TabIndex = 26;
            // 
            // btFlipHor
            // 
            this.btFlipHor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btFlipHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFlipHor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFlipHor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFlipHor.Location = new System.Drawing.Point(7, 7);
            this.btFlipHor.Name = "btFlipHor";
            this.btFlipHor.Size = new System.Drawing.Size(80, 30);
            this.btFlipHor.TabIndex = 27;
            this.btFlipHor.Text = "Flip hor";
            this.btFlipHor.UseVisualStyleBackColor = false;
            this.btFlipHor.Click += new System.EventHandler(this.btFlipHor_Click);
            // 
            // btFlipVer
            // 
            this.btFlipVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btFlipVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFlipVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFlipVer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFlipVer.Location = new System.Drawing.Point(7, 49);
            this.btFlipVer.Name = "btFlipVer";
            this.btFlipVer.Size = new System.Drawing.Size(80, 30);
            this.btFlipVer.TabIndex = 28;
            this.btFlipVer.Text = "Flip ver";
            this.btFlipVer.UseVisualStyleBackColor = false;
            this.btFlipVer.Click += new System.EventHandler(this.btFlipVer_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.btFlipHor);
            this.panel3.Controls.Add(this.btFlipVer);
            this.panel3.Location = new System.Drawing.Point(728, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 86);
            this.panel3.TabIndex = 26;
            // 
            // btText
            // 
            this.btText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btText.Location = new System.Drawing.Point(7, 7);
            this.btText.Name = "btText";
            this.btText.Size = new System.Drawing.Size(80, 30);
            this.btText.TabIndex = 29;
            this.btText.Text = "Text";
            this.btText.UseVisualStyleBackColor = false;
            this.btText.Click += new System.EventHandler(this.btText_Click);
            // 
            // btInsertText
            // 
            this.btInsertText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btInsertText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btInsertText.Location = new System.Drawing.Point(7, 49);
            this.btInsertText.Name = "btInsertText";
            this.btInsertText.Size = new System.Drawing.Size(80, 30);
            this.btInsertText.TabIndex = 30;
            this.btInsertText.Text = "Insert";
            this.btInsertText.UseVisualStyleBackColor = false;
            this.btInsertText.Click += new System.EventHandler(this.btInsertText_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.btText);
            this.panel4.Controls.Add(this.btInsertText);
            this.panel4.Location = new System.Drawing.Point(528, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 86);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel5.Controls.Add(this.btFillBrush);
            this.panel5.Controls.Add(this.btRake);
            this.panel5.Location = new System.Drawing.Point(428, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(93, 86);
            this.panel5.TabIndex = 31;
            // 
            // btFillBrush
            // 
            this.btFillBrush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btFillBrush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFillBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFillBrush.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFillBrush.Location = new System.Drawing.Point(7, 7);
            this.btFillBrush.Name = "btFillBrush";
            this.btFillBrush.Size = new System.Drawing.Size(80, 30);
            this.btFillBrush.TabIndex = 29;
            this.btFillBrush.Text = "Fill";
            this.btFillBrush.UseVisualStyleBackColor = false;
            this.btFillBrush.Click += new System.EventHandler(this.btFillBrush_Click);
            // 
            // btRake
            // 
            this.btRake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btRake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRake.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRake.Location = new System.Drawing.Point(7, 49);
            this.btRake.Name = "btRake";
            this.btRake.Size = new System.Drawing.Size(80, 30);
            this.btRake.TabIndex = 30;
            this.btRake.Text = "Rake";
            this.btRake.UseVisualStyleBackColor = false;
            this.btRake.Click += new System.EventHandler(this.btRake_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel6.Controls.Add(this.btSimHor);
            this.panel6.Controls.Add(this.btSymVer);
            this.panel6.Location = new System.Drawing.Point(628, 125);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(93, 86);
            this.panel6.TabIndex = 32;
            // 
            // btSimHor
            // 
            this.btSimHor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btSimHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimHor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimHor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSimHor.Location = new System.Drawing.Point(7, 7);
            this.btSimHor.Name = "btSimHor";
            this.btSimHor.Size = new System.Drawing.Size(80, 30);
            this.btSimHor.TabIndex = 29;
            this.btSimHor.Text = "SymmetryOR";
            this.btSimHor.UseVisualStyleBackColor = false;
            this.btSimHor.Click += new System.EventHandler(this.btSimHor_Click);
            // 
            // btSymVer
            // 
            this.btSymVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btSymVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSymVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSymVer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSymVer.Location = new System.Drawing.Point(7, 49);
            this.btSymVer.Name = "btSymVer";
            this.btSymVer.Size = new System.Drawing.Size(80, 30);
            this.btSymVer.TabIndex = 30;
            this.btSymVer.Text = "SymmetryVE";
            this.btSymVer.UseVisualStyleBackColor = false;
            this.btSymVer.Click += new System.EventHandler(this.btSymVer_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel7.Controls.Add(this.btFill);
            this.panel7.Controls.Add(this.btClear);
            this.panel7.Location = new System.Drawing.Point(327, 125);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(93, 86);
            this.panel7.TabIndex = 32;
            // 
            // btFill
            // 
            this.btFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFill.Location = new System.Drawing.Point(7, 6);
            this.btFill.Name = "btFill";
            this.btFill.Size = new System.Drawing.Size(80, 31);
            this.btFill.TabIndex = 3;
            this.btFill.Text = "Fill BG";
            this.btFill.UseVisualStyleBackColor = false;
            this.btFill.Click += new System.EventHandler(this.btFill_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClear.Location = new System.Drawing.Point(7, 49);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(80, 30);
            this.btClear.TabIndex = 23;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // spatiuDesen
            // 
            this.spatiuDesen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.spatiuDesen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spatiuDesen.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.spatiuDesen.Location = new System.Drawing.Point(12, 223);
            this.spatiuDesen.Name = "spatiuDesen";
            this.spatiuDesen.Size = new System.Drawing.Size(810, 754);
            this.spatiuDesen.TabIndex = 7;
            this.spatiuDesen.TabStop = false;
            this.spatiuDesen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spatiuDesen_MouseDown);
            this.spatiuDesen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spatiuDesen_MouseMove);
            this.spatiuDesen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spatiuDesen_MouseUp);
            // 
            // btEraser
            // 
            this.btEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEraser.ForeColor = System.Drawing.Color.White;
            this.btEraser.Image = global::Paint_in_retea.Properties.Resources.eraserOF;
            this.btEraser.Location = new System.Drawing.Point(417, 37);
            this.btEraser.Name = "btEraser";
            this.btEraser.Size = new System.Drawing.Size(75, 75);
            this.btEraser.TabIndex = 2;
            this.btEraser.Text = "Eraser";
            this.btEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEraser.UseVisualStyleBackColor = false;
            this.btEraser.Click += new System.EventHandler(this.btEraser_Click);
            // 
            // btBrush
            // 
            this.btBrush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btBrush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrush.ForeColor = System.Drawing.Color.White;
            this.btBrush.Image = global::Paint_in_retea.Properties.Resources.brushOF;
            this.btBrush.Location = new System.Drawing.Point(333, 37);
            this.btBrush.Name = "btBrush";
            this.btBrush.Size = new System.Drawing.Size(75, 75);
            this.btBrush.TabIndex = 1;
            this.btBrush.Text = "Brush";
            this.btBrush.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBrush.UseVisualStyleBackColor = false;
            this.btBrush.Click += new System.EventHandler(this.btBrush_Click);
            // 
            // pictureCuloarePreview
            // 
            this.pictureCuloarePreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureCuloarePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCuloarePreview.Location = new System.Drawing.Point(20, 38);
            this.pictureCuloarePreview.Name = "pictureCuloarePreview";
            this.pictureCuloarePreview.Size = new System.Drawing.Size(80, 80);
            this.pictureCuloarePreview.TabIndex = 0;
            this.pictureCuloarePreview.TabStop = false;
            // 
            // fPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(834, 989);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPenWidth);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sliderB);
            this.Controls.Add(this.sliderG);
            this.Controls.Add(this.sliderR);
            this.Controls.Add(this.spatiuDesen);
            this.Controls.Add(this.btHexagon);
            this.Controls.Add(this.btEclipse);
            this.Controls.Add(this.btTriangle);
            this.Controls.Add(this.btEraser);
            this.Controls.Add(this.btBrush);
            this.Controls.Add(this.pictureCuloarePreview);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint in retea";
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderWidthBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderHueJitter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatiuDesen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCuloarePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBrush;
        private System.Windows.Forms.Button btEraser;
        private System.Windows.Forms.Button btTriangle;
        private System.Windows.Forms.Button btEclipse;
        private System.Windows.Forms.Button btHexagon;
        private System.Windows.Forms.PictureBox spatiuDesen;
        private System.Windows.Forms.TrackBar sliderR;
        private System.Windows.Forms.TrackBar sliderG;
        private System.Windows.Forms.TrackBar sliderB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureCuloarePreview;
        public System.Windows.Forms.Label labelR;
        public System.Windows.Forms.Label labelG;
        public System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TrackBar sliderWidthBrush;
        public System.Windows.Forms.Label labelPenWidth;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelJitterValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar sliderHueJitter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btFlipHor;
        private System.Windows.Forms.Button btFlipVer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btText;
        private System.Windows.Forms.Button btInsertText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btFillBrush;
        private System.Windows.Forms.Button btRake;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btSimHor;
        private System.Windows.Forms.Button btSymVer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btFill;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRoundHead;
        private System.Windows.Forms.Button btSquareHead;
    }
}