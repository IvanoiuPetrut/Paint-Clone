using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint_in_retea
{
    public partial class fPaint : Form
    {
        Stopwatch sw = new Stopwatch();
        static TcpClient client;
        static NetworkStream stream;

        public Bitmap surface;
        public Graphics g;

        public bool apasat = false;
        public bool brushOnOf = false;
        public bool eraserOnOf = false;
        public bool triangleOnOf = false;
        public bool HexOnOf = false;
        public bool eclipseOnOf = false;
        public bool inserareTextOnOf = false;
        public bool fillOnOf = false;
        public bool rakeOnOf = false;
        public bool symOrizOnOf = false;
        public bool symVerOnOf = false;

        public Random rand = new Random();

        public fText newTextPanel;

        figura elipsa;
        figura fill;
        figura creion;
        figura rake;
        figura triunghi;
        figura hex;
        figura eraser;
        public fPaint()
        {
               

            InitializeComponent();
            

            surface = new Bitmap(spatiuDesen.Width, spatiuDesen.Height);
            g = Graphics.FromImage(surface);
            spatiuDesen.Image = surface;        
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursor(9);

            elipsa = new elipsa(this);
            fill = new fill(this);
            creion = new figura(this);
            rake = new rake(this);
            triunghi = new triunghi(this);
            hex = new hexagon(this);
            eraser = new eraser(this);

            newTextPanel = new fText(this);

            creion.capRotund();
            rake.capRotund();
            eraser.capRotund();
        }

        private void turnOfAll()
        {
            brushOnOf = false;
            eraserOnOf = false;
            triangleOnOf = false;
            HexOnOf = false;
            eclipseOnOf = false;
            fillOnOf = false;
            rakeOnOf = false;
            inserareTextOnOf = false;
            btBrush.ForeColor = Color.White;
            btEraser.ForeColor = Color.White;
            btTriangle.ForeColor = Color.White;
            btHexagon.ForeColor = Color.White;
            btEclipse.ForeColor = Color.White;
            btFillBrush.ForeColor = Color.White;
            btRake.ForeColor = Color.White;
            btInsertText.ForeColor = Color.White;

            btBrush.Image = Image.FromFile("brushOF.png");
            btEraser.Image = Image.FromFile("eraserOF.png");
            btTriangle.Image = Image.FromFile("triOF.png");
            btHexagon.Image = Image.FromFile("hexOF.png");
            btEclipse.Image = Image.FromFile("elipseOF.png");
        }

        private void schimbaCuloareText(int r, int g, int b)
        {
            labelR.Text = Convert.ToString(r);
            labelG.Text = Convert.ToString(g);
            labelB.Text = Convert.ToString(b);
            pictureCuloarePreview.BackColor = Color.FromArgb(r, g, b);
        }

        private void schimbaCuloare()
        {
            creion.modificare_penColor(sliderR.Value, sliderG.Value, sliderB.Value);
            rake.modificare_penColor(sliderR.Value, sliderG.Value, sliderB.Value);
            triunghi.modificare_penColor(sliderR.Value, sliderG.Value, sliderB.Value);
            hex.modificare_penColor(sliderR.Value, sliderG.Value, sliderB.Value);
            elipsa.modificare_penColor(sliderR.Value, sliderG.Value, sliderB.Value);
            fill.modificare_penColor(sliderR.Value, sliderG.Value, sliderB.Value);
            newTextPanel.text.modificare_penColor(sliderR.Value, sliderG.Value, sliderB.Value);
        }

        private void cursor(int marime)
        {
            using (Bitmap bmpCursor = new Bitmap(marime + 1, marime + 1))
            {
                using (Graphics grf = Graphics.FromImage(bmpCursor))
                {
                    using (Pen brsh = new Pen(Color.Black, 1))
                    {
                        grf.DrawEllipse(brsh, 0, 0, marime, marime);
                        spatiuDesen.Cursor = new Cursor(bmpCursor.GetHicon());
                    }
                }
            }
        }

        private void btBrush_Click(object sender, EventArgs e)
        {
            turnOfAll();
            brushOnOf = true;
            btBrush.Image = Image.FromFile("brushON.png");
            btBrush.ForeColor = Color.FromArgb(108, 94, 221);
        }

        private void spatiuDesen_MouseDown(object sender, MouseEventArgs e)
        {
            apasat = true;

            elipsa.getCurrent(e.Location);
            triunghi.getCurrent(e.Location);
            hex.getCurrent(e.Location);

            fill.getCurrent(e.Location);
            creion.getCurrent(e.Location);
            rake.getCurrent(e.Location);
            eraser.getCurrent(e.Location);
        }

        private void spatiuDesen_MouseMove(object sender, MouseEventArgs e)
        {
            if (sliderHueJitter.Value > 0)
            {
                if(brushOnOf)
                    creion.modificare_penColor((sliderR.Value + rand.Next(0, sliderHueJitter.Value)) % 255, (sliderG.Value + rand.Next(0, sliderHueJitter.Value)) % 255, (sliderB.Value + rand.Next(0, sliderHueJitter.Value)) % 250);
                if(fillOnOf)
                    fill.modificare_penColor((sliderR.Value + rand.Next(0, sliderHueJitter.Value)) % 255, (sliderG.Value + rand.Next(0, sliderHueJitter.Value)) % 255, (sliderB.Value + rand.Next(0, sliderHueJitter.Value)) % 250);
                if(rakeOnOf)
                    rake.modificare_penColor((sliderR.Value + rand.Next(0, sliderHueJitter.Value)) % 255, (sliderG.Value + rand.Next(0, sliderHueJitter.Value)) % 255, (sliderB.Value + rand.Next(0, sliderHueJitter.Value)) % 250);
            }

            creion.getNou(e.Location);
            creion.deseneaza();
            creion.deseneazaSimVer(spatiuDesen.Width);
            creion.deseneazaSimOrz(spatiuDesen.Height);

            fill.getNou(e.Location);
            fill.deseneaza();

            rake.getNou(e.Location);
            rake.deseneaza();

           
            eraser.getNou(e.Location);
            if (eraserOnOf)
                eraser.modificare_penColor(spatiuDesen.BackColor);
            eraser.deseneaza();

            spatiuDesen.Refresh();
        }

        private void spatiuDesen_MouseUp(object sender, MouseEventArgs e)
        {
            elipsa.getNou(e.Location);
            triunghi.getNou(e.Location);
            hex.getNou(e.Location);
            newTextPanel.text.getCurrent(e.Location);

            elipsa.deseneaza();
            triunghi.deseneaza();
            hex.deseneaza();
            newTextPanel.text.inserareText();

            apasat = false;
        }

        private void btEraser_Click(object sender, EventArgs e)
        {
            turnOfAll();
            eraserOnOf = true;
            btEraser.Image = Image.FromFile("eraserON.png");
            btEraser.ForeColor = Color.FromArgb(108, 94, 221);
        }

        private void sliderR_Scroll(object sender, EventArgs e)
        {
            schimbaCuloare();
            schimbaCuloareText(sliderR.Value, sliderG.Value, sliderB.Value);
        }

        private void sliderG_Scroll(object sender, EventArgs e)
        {
            schimbaCuloare();
            schimbaCuloareText(sliderR.Value, sliderG.Value, sliderB.Value);
        }

        private void sliderB_Scroll(object sender, EventArgs e)
        {
            schimbaCuloare();
            schimbaCuloareText(sliderR.Value, sliderG.Value, sliderB.Value);
        }

        private void btFill_Click(object sender, EventArgs e)            //fillBG
        {
            g.Clear(Color.FromArgb(sliderR.Value, sliderG.Value, sliderB.Value));
            spatiuDesen.BackColor = Color.FromArgb(sliderR.Value, sliderG.Value, sliderB.Value);
            spatiuDesen.Refresh();
        }

        private void sliderWidthBrush_Scroll(object sender, EventArgs e)
        {
            eraser.modificare_penWidth(sliderWidthBrush.Value);
            creion.modificare_penWidth(sliderWidthBrush.Value);
            rake.modificare_penWidth(sliderWidthBrush.Value);
            triunghi.modificare_penWidth(sliderWidthBrush.Value);
            hex.modificare_penWidth(sliderWidthBrush.Value);
            elipsa.modificare_penWidth(sliderWidthBrush.Value);
            fill.modificare_penWidth(sliderWidthBrush.Value);
            labelPenWidth.Text = Convert.ToString(sliderWidthBrush.Value);
            cursor(sliderWidthBrush.Value);
        }

        private void btClear_Click(object sender, EventArgs e)             //clear
        {
            g.Clear(spatiuDesen.BackColor);
            spatiuDesen.Refresh();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Png files (*png) | *.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Rectangle rect = new Rectangle(0, 0, spatiuDesen.Width, spatiuDesen.Height);
                spatiuDesen.DrawToBitmap(surface, rect);
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Png files (*png) | *.png";
            ofd.DefaultExt = "png";
            ofd.AddExtension = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Rectangle rect = new Rectangle(0, 0, spatiuDesen.Width, spatiuDesen.Height);
                Size size = new Size(spatiuDesen.Width, spatiuDesen.Height);

                Bitmap img = new Bitmap(ofd.FileName);
                Graphics g = Graphics.FromImage((System.Drawing.Image)surface);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, rect);
                g.Dispose();
                spatiuDesen.Image = surface;
            }
        }

        private void btEclipse_Click(object sender, EventArgs e)
        {
            turnOfAll();
            eclipseOnOf = true;
            btEclipse.Image = Image.FromFile("elipseON.png");
            btEclipse.ForeColor = Color.FromArgb(108, 94, 221);
        }

        private void btFlipHor_Click(object sender, EventArgs e)
        {
               surface.RotateFlip(RotateFlipType.RotateNoneFlipX);
               spatiuDesen.Image = surface;
        }

        private void btFlipVer_Click(object sender, EventArgs e)
        {
            surface.RotateFlip(RotateFlipType.RotateNoneFlipY);
            spatiuDesen.Image = surface;
        }

        private void btText_Click(object sender, EventArgs e)
        {
            newTextPanel.Show();
        }

        private void btInsertText_Click(object sender, EventArgs e)
        {
            turnOfAll();
                inserareTextOnOf = true;
                btInsertText.ForeColor = Color.FromArgb(108, 94, 221);           
        }

        private void btFillBrush_Click(object sender, EventArgs e)
        {
            turnOfAll();
            fillOnOf = true;
            btFillBrush.ForeColor = Color.FromArgb(108, 94, 221);
        }

        private void btRake_Click(object sender, EventArgs e)
        {
            turnOfAll();
            rakeOnOf = true;
            btRake.ForeColor = Color.FromArgb(108, 94, 221);
        }

        private void btTriangle_Click(object sender, EventArgs e)
        {
            turnOfAll();
            triangleOnOf = true;
            btTriangle.Image = Image.FromFile("triON.png");
            btTriangle.ForeColor = Color.FromArgb(108, 94, 221);
        }

        private void btSymVer_Click(object sender, EventArgs e)
        {
            if (symVerOnOf)
            {
                symVerOnOf = false;
                btSymVer.ForeColor = Color.White;
            }
            else
            {
                symVerOnOf = true;
                btSymVer.ForeColor = Color.FromArgb(108, 94, 221);
            }
        }

        private void btSimHor_Click(object sender, EventArgs e)
        {
            if (symOrizOnOf)
            {
                symOrizOnOf = false;
                btSimHor.ForeColor = Color.White;
            }
            else
            {
                symOrizOnOf = true;
                btSimHor.ForeColor = Color.FromArgb(108, 94, 221);
            }
        }

        private void btSquareHead_Click(object sender, EventArgs e)
        {
            creion.capPatrat();
            rake.capPatrat();
            eraser.capPatrat();
        }

        private void btRoundHead_Click(object sender, EventArgs e)
        {
            creion.capRotund();
            rake.capRotund();
            eraser.capRotund();
        }

        private void btHexagon_Click(object sender, EventArgs e)
        {
            turnOfAll();
            HexOnOf = true;
            btHexagon.Image = Image.FromFile("hexON.png");
            btHexagon.ForeColor = Color.FromArgb(108, 94, 221);
        }

        private void sliderHueJitter_Scroll(object sender, EventArgs e)
        {
            Random rand = new Random();
            labelJitterValue.Text = Convert.ToString(sliderHueJitter.Value);
            creion.modificare_penColor(sliderR.Value+rand.Next(sliderHueJitter.Value), sliderG.Value + rand.Next(sliderHueJitter.Value), sliderB.Value + rand.Next(sliderHueJitter.Value));
        }
    }
}
