namespace App_Practica_de_vlc
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.Archivo = new System.Windows.Forms.Button();
            this.Organizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxArchivos = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.Thistle;
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Location = new System.Drawing.Point(830, 560);
            this.trackBar2.Maximum = 22;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(336, 24);
            this.trackBar2.TabIndex = 11;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // vlcControl1
            // 
            this.vlcControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(237, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(941, 515);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 9;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // Archivo
            // 
            this.Archivo.BackColor = System.Drawing.Color.Plum;
            this.Archivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archivo.Location = new System.Drawing.Point(21, 207);
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(159, 64);
            this.Archivo.TabIndex = 4;
            this.Archivo.Text = "Archivo";
            this.Archivo.UseVisualStyleBackColor = false;
            this.Archivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Organizar
            // 
            this.Organizar.BackColor = System.Drawing.Color.Plum;
            this.Organizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Organizar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Organizar.Location = new System.Drawing.Point(21, 137);
            this.Organizar.Name = "Organizar";
            this.Organizar.Size = new System.Drawing.Size(159, 64);
            this.Organizar.TabIndex = 2;
            this.Organizar.Text = "Organizar";
            this.Organizar.UseVisualStyleBackColor = false;
            this.Organizar.Click += new System.EventHandler(this.Organizar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Archivo);
            this.panel1.Controls.Add(this.Organizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 635);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxArchivos);
            this.groupBox1.Location = new System.Drawing.Point(1, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 299);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rutas:";
            // 
            // listBoxArchivos
            // 
            this.listBoxArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxArchivos.DisplayMember = "\"Name\"";
            this.listBoxArchivos.FormattingEnabled = true;
            this.listBoxArchivos.Location = new System.Drawing.Point(3, 16);
            this.listBoxArchivos.MultiColumn = true;
            this.listBoxArchivos.Name = "listBoxArchivos";
            this.listBoxArchivos.Size = new System.Drawing.Size(203, 280);
            this.listBoxArchivos.TabIndex = 14;
            this.listBoxArchivos.SelectedIndexChanged += new System.EventHandler(this.listBoxArchivos_SelectedIndexChanged);
            this.listBoxArchivos.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 115);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-2, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 10);
            this.label1.TabIndex = 2;
            this.label1.Text = "_____________________________";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(69, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Reproductor y Organizador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::App_Practica_de_vlc.Properties.Resources.reproductor_de_video;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Thistle;
            this.btnNext.BackgroundImage = global::App_Practica_de_vlc.Properties.Resources.siguiente1;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(456, 551);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 49);
            this.btnNext.TabIndex = 16;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.Color.Thistle;
            this.btnRegresar.BackgroundImage = global::App_Practica_de_vlc.Properties.Resources.atras;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(319, 550);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 50);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::App_Practica_de_vlc.Properties.Resources.alto_volumen;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(768, 551);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 44);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Thistle;
            this.button4.BackgroundImage = global::App_Practica_de_vlc.Properties.Resources.pausa__1_;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Thistle;
            this.button4.Location = new System.Drawing.Point(399, 550);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 52);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnstop
            // 
            this.btnstop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstop.BackgroundImage = global::App_Practica_de_vlc.Properties.Resources.boton_detener;
            this.btnstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.ForeColor = System.Drawing.Color.Thistle;
            this.btnstop.Location = new System.Drawing.Point(536, 546);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(53, 60);
            this.btnstop.TabIndex = 6;
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnplay
            // 
            this.btnplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnplay.BackColor = System.Drawing.Color.Thistle;
            this.btnplay.BackgroundImage = global::App_Practica_de_vlc.Properties.Resources.tocar;
            this.btnplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplay.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.ForeColor = System.Drawing.Color.Thistle;
            this.btnplay.Location = new System.Drawing.Point(409, 550);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(53, 52);
            this.btnplay.TabIndex = 5;
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1204, 635);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBar2;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button Archivo;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button Organizar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBoxArchivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnNext;
    }
}

