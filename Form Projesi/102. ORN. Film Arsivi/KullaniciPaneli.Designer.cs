namespace _102.ORN.Film_Arsivi
{
    partial class KullaniciPaneli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFilmveDizi = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblIMDB = new System.Windows.Forms.Label();
            this.lblyonetmen = new System.Windows.Forms.Label();
            this.lblcikis = new System.Windows.Forms.Label();
            this.lbltur = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblizlendimi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film ve Dizi Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(513, 513);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label10.Location = new System.Drawing.Point(34, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Kullanıcı Sayfası";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(616, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Film veya Dizi Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(612, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Film veya Dizi Tur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(560, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Film veya Dizi Yönetmen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(603, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Film veya Dizi Çıkış:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label5.Location = new System.Drawing.Point(612, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Film mi?, Dizi mi?:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label6.Location = new System.Drawing.Point(599, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Film veya Dizi Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label7.Location = new System.Drawing.Point(591, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Film veya Dizi Resim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label8.Location = new System.Drawing.Point(593, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Film veya Dizi IMDB:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label9.Location = new System.Drawing.Point(537, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Film veya Dizi\'yi İzledin mi?:";
            // 
            // lblFilmveDizi
            // 
            this.lblFilmveDizi.AutoSize = true;
            this.lblFilmveDizi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblFilmveDizi.Location = new System.Drawing.Point(766, 524);
            this.lblFilmveDizi.Name = "lblFilmveDizi";
            this.lblFilmveDizi.Size = new System.Drawing.Size(50, 23);
            this.lblFilmveDizi.TabIndex = 39;
            this.lblFilmveDizi.Text = "NULL";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbltarih.Location = new System.Drawing.Point(766, 486);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(50, 23);
            this.lbltarih.TabIndex = 38;
            this.lbltarih.Text = "NULL";
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblIMDB.Location = new System.Drawing.Point(766, 279);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(50, 23);
            this.lblIMDB.TabIndex = 36;
            this.lblIMDB.Text = "NULL";
            // 
            // lblyonetmen
            // 
            this.lblyonetmen.AutoSize = true;
            this.lblyonetmen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblyonetmen.Location = new System.Drawing.Point(766, 241);
            this.lblyonetmen.Name = "lblyonetmen";
            this.lblyonetmen.Size = new System.Drawing.Size(50, 23);
            this.lblyonetmen.TabIndex = 35;
            this.lblyonetmen.Text = "NULL";
            // 
            // lblcikis
            // 
            this.lblcikis.AutoSize = true;
            this.lblcikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblcikis.Location = new System.Drawing.Point(766, 203);
            this.lblcikis.Name = "lblcikis";
            this.lblcikis.Size = new System.Drawing.Size(50, 23);
            this.lblcikis.TabIndex = 34;
            this.lblcikis.Text = "NULL";
            // 
            // lbltur
            // 
            this.lbltur.AutoSize = true;
            this.lbltur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbltur.Location = new System.Drawing.Point(766, 165);
            this.lbltur.Name = "lbltur";
            this.lbltur.Size = new System.Drawing.Size(50, 23);
            this.lbltur.TabIndex = 33;
            this.lbltur.Text = "NULL";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblad.Location = new System.Drawing.Point(766, 127);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(50, 23);
            this.lblad.TabIndex = 32;
            this.lblad.Text = "NULL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label14.Location = new System.Drawing.Point(537, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(429, 46);
            this.label14.TabIndex = 41;
            this.label14.Text = "Filminizin veya Dizinizin Ayrıntılı Bilgilerini Görmek İçin \r\nListedeki İsmine Tı" +
    "klayınız!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(537, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 1);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(766, 319);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.radioButton1.Location = new System.Drawing.Point(766, 558);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 27);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evet";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.radioButton2.Location = new System.Drawing.Point(833, 558);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 27);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hayır";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 46;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblid.Location = new System.Drawing.Point(955, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(42, 23);
            this.lblid.TabIndex = 47;
            this.lblid.Text = "lblid";
            this.lblid.Visible = false;
            // 
            // lblizlendimi
            // 
            this.lblizlendimi.AutoSize = true;
            this.lblizlendimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblizlendimi.Location = new System.Drawing.Point(853, 9);
            this.lblizlendimi.Name = "lblizlendimi";
            this.lblizlendimi.Size = new System.Drawing.Size(96, 23);
            this.lblizlendimi.TabIndex = 48;
            this.lblizlendimi.Text = "lblizlendimi";
            this.lblizlendimi.Visible = false;
            // 
            // KullaniciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(999, 603);
            this.Controls.Add(this.lblizlendimi);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblFilmveDizi);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.lblyonetmen);
            this.Controls.Add(this.lblcikis);
            this.Controls.Add(this.lbltur);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KullaniciPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPaneli";
            this.Load += new System.EventHandler(this.KullaniciPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFilmveDizi;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lblIMDB;
        private System.Windows.Forms.Label lblyonetmen;
        private System.Windows.Forms.Label lblcikis;
        private System.Windows.Forms.Label lbltur;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblizlendimi;
    }
}