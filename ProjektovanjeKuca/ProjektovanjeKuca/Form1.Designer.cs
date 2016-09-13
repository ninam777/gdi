namespace ProjektovanjeKuca
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
            this.radnaPovrsina = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDuzina = new System.Windows.Forms.TextBox();
            this.tbSirina = new System.Windows.Forms.TextBox();
            this.pbProstorija = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.radnaPovrsina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProstorija)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radnaPovrsina
            // 
            this.radnaPovrsina.BackColor = System.Drawing.Color.DarkGray;
            this.radnaPovrsina.Location = new System.Drawing.Point(155, 42);
            this.radnaPovrsina.Name = "radnaPovrsina";
            this.radnaPovrsina.Size = new System.Drawing.Size(565, 444);
            this.radnaPovrsina.TabIndex = 0;
            this.radnaPovrsina.TabStop = false;
            this.radnaPovrsina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radnaPovrsina_MouseDown);
            this.radnaPovrsina.MouseMove += new System.Windows.Forms.MouseEventHandler(this.radnaPovrsina_MouseMove);
            this.radnaPovrsina.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radnaPovrsina_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prostorija";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dužina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Širina";
            // 
            // tbDuzina
            // 
            this.tbDuzina.Location = new System.Drawing.Point(60, 60);
            this.tbDuzina.Name = "tbDuzina";
            this.tbDuzina.Size = new System.Drawing.Size(76, 20);
            this.tbDuzina.TabIndex = 4;
            // 
            // tbSirina
            // 
            this.tbSirina.Location = new System.Drawing.Point(60, 81);
            this.tbSirina.Name = "tbSirina";
            this.tbSirina.Size = new System.Drawing.Size(76, 20);
            this.tbSirina.TabIndex = 5;
            // 
            // pbProstorija
            // 
            this.pbProstorija.BackColor = System.Drawing.Color.Black;
            this.pbProstorija.Location = new System.Drawing.Point(16, 112);
            this.pbProstorija.Name = "pbProstorija";
            this.pbProstorija.Size = new System.Drawing.Size(29, 19);
            this.pbProstorija.TabIndex = 6;
            this.pbProstorija.TabStop = false;
            this.pbProstorija.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbProstorija_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "tsbProstorija";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 487);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbProstorija);
            this.Controls.Add(this.tbSirina);
            this.Controls.Add(this.tbDuzina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radnaPovrsina);
            this.Name = "Form1";
            this.Text = "Projektovanje kuća ";
            ((System.ComponentModel.ISupportInitialize)(this.radnaPovrsina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProstorija)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox radnaPovrsina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDuzina;
        private System.Windows.Forms.TextBox tbSirina;
        private System.Windows.Forms.PictureBox pbProstorija;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

