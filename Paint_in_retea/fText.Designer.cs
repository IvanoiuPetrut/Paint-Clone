
namespace Paint_in_retea
{
    partial class fText
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
            this.textInserare = new System.Windows.Forms.RichTextBox();
            this.textDimWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTextFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDimHeight = new System.Windows.Forms.TextBox();
            this.btApplyDim = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textFontSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textInserare
            // 
            this.textInserare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.textInserare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textInserare.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInserare.ForeColor = System.Drawing.Color.White;
            this.textInserare.Location = new System.Drawing.Point(12, 103);
            this.textInserare.Name = "textInserare";
            this.textInserare.Size = new System.Drawing.Size(320, 110);
            this.textInserare.TabIndex = 0;
            this.textInserare.Text = "";
            // 
            // textDimWidth
            // 
            this.textDimWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.textDimWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDimWidth.ForeColor = System.Drawing.Color.White;
            this.textDimWidth.Location = new System.Drawing.Point(348, 12);
            this.textDimWidth.Name = "textDimWidth";
            this.textDimWidth.Size = new System.Drawing.Size(60, 29);
            this.textDimWidth.TabIndex = 1;
            this.textDimWidth.Text = "320";
            this.textDimWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font";
            // 
            // comboTextFont
            // 
            this.comboTextFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.comboTextFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTextFont.ForeColor = System.Drawing.Color.White;
            this.comboTextFont.FormattingEnabled = true;
            this.comboTextFont.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Calibri",
            "Verdana",
            "Century",
            "Impact"});
            this.comboTextFont.Location = new System.Drawing.Point(71, 11);
            this.comboTextFont.Name = "comboTextFont";
            this.comboTextFont.Size = new System.Drawing.Size(140, 32);
            this.comboTextFont.TabIndex = 3;
            this.comboTextFont.Text = "Arial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dimensiune";
            // 
            // textDimHeight
            // 
            this.textDimHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.textDimHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDimHeight.ForeColor = System.Drawing.Color.White;
            this.textDimHeight.Location = new System.Drawing.Point(421, 12);
            this.textDimHeight.Name = "textDimHeight";
            this.textDimHeight.Size = new System.Drawing.Size(60, 29);
            this.textDimHeight.TabIndex = 5;
            this.textDimHeight.Text = "110";
            this.textDimHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btApplyDim
            // 
            this.btApplyDim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btApplyDim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApplyDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApplyDim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btApplyDim.Location = new System.Drawing.Point(684, 13);
            this.btApplyDim.Name = "btApplyDim";
            this.btApplyDim.Size = new System.Drawing.Size(65, 30);
            this.btApplyDim.TabIndex = 30;
            this.btApplyDim.Text = "Apply";
            this.btApplyDim.UseVisualStyleBackColor = false;
            this.btApplyDim.Click += new System.EventHandler(this.btApplyDim_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancel.Location = new System.Drawing.Point(755, 13);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(65, 30);
            this.btCancel.TabIndex = 32;
            this.btCancel.Text = "Close";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Font Size";
            // 
            // textFontSize
            // 
            this.textFontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.textFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFontSize.ForeColor = System.Drawing.Color.White;
            this.textFontSize.Location = new System.Drawing.Point(107, 55);
            this.textFontSize.Name = "textFontSize";
            this.textFontSize.Size = new System.Drawing.Size(104, 29);
            this.textFontSize.TabIndex = 34;
            this.textFontSize.Text = "12";
            this.textFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.textFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApplyDim);
            this.Controls.Add(this.textDimHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTextFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDimWidth);
            this.Controls.Add(this.textInserare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fText";
            this.Text = "fText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textDimWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTextFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDimHeight;
        private System.Windows.Forms.Button btApplyDim;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFontSize;
        public System.Windows.Forms.RichTextBox textInserare;
    }
}