
namespace SELTEM_Kütüphane_Otomasyonu_
{
    partial class ödünçkitaplar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ödünçkitaplar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.acbutton = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.kitapsectext = new System.Windows.Forms.TextBox();
            this.üyesectext = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.kitapalbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.üyedtgw = new System.Windows.Forms.DataGridView();
            this.dtgw1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.kitapdtgw = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panelkitap = new System.Windows.Forms.Panel();
            this.paneluye = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.üyedtgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdtgw)).BeginInit();
            this.panelkitap.SuspendLayout();
            this.paneluye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new System.Drawing.Point(150, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            dateTimePicker1.TabIndex = 106;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.acbutton);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 43);
            this.panel1.TabIndex = 99;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(989, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 36);
            this.button1.TabIndex = 103;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acbutton
            // 
            this.acbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.acbutton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.acbutton.FlatAppearance.BorderSize = 2;
            this.acbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.acbutton.Image = ((System.Drawing.Image)(resources.GetObject("acbutton.Image")));
            this.acbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acbutton.Location = new System.Drawing.Point(9, 4);
            this.acbutton.Name = "acbutton";
            this.acbutton.Size = new System.Drawing.Size(190, 36);
            this.acbutton.TabIndex = 0;
            this.acbutton.Text = "Ödünç İşlemlerini Aç";
            this.acbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acbutton.UseVisualStyleBackColor = true;
            this.acbutton.Click += new System.EventHandler(this.acbutton_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.kitapsectext);
            this.groupbox1.Controls.Add(this.üyesectext);
            this.groupbox1.Controls.Add(this.button6);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.dateTimePicker2);
            this.groupbox1.Controls.Add(this.kitapalbtn);
            this.groupbox1.Controls.Add(dateTimePicker1);
            this.groupbox1.Controls.Add(this.button2);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Location = new System.Drawing.Point(12, 65);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(394, 228);
            this.groupbox1.TabIndex = 104;
            this.groupbox1.TabStop = false;
            // 
            // kitapsectext
            // 
            this.kitapsectext.Location = new System.Drawing.Point(150, 45);
            this.kitapsectext.Name = "kitapsectext";
            this.kitapsectext.Size = new System.Drawing.Size(176, 20);
            this.kitapsectext.TabIndex = 112;
            this.kitapsectext.Click += new System.EventHandler(this.kitapsectxt_Click);
            this.kitapsectext.TextChanged += new System.EventHandler(this.kitapsectxt_TextChanged);
            // 
            // üyesectext
            // 
            this.üyesectext.Location = new System.Drawing.Point(150, 18);
            this.üyesectext.Name = "üyesectext";
            this.üyesectext.Size = new System.Drawing.Size(176, 20);
            this.üyesectext.TabIndex = 111;
            this.üyesectext.Click += new System.EventHandler(this.üyesectext_Click);
            this.üyesectext.TextChanged += new System.EventHandler(this.üyesectext_TextChanged);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(150, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 34);
            this.button6.TabIndex = 110;
            this.button6.Text = "Temizle";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 109;
            this.label4.Text = "Teslim Edeceği Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 108;
            this.label3.Text = "Alış Tarihi:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(150, 97);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker2.TabIndex = 107;
            this.dateTimePicker2.Value = new System.DateTime(2022, 9, 28, 0, 0, 0, 0);
            // 
            // kitapalbtn
            // 
            this.kitapalbtn.Image = ((System.Drawing.Image)(resources.GetObject("kitapalbtn.Image")));
            this.kitapalbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapalbtn.Location = new System.Drawing.Point(253, 136);
            this.kitapalbtn.Name = "kitapalbtn";
            this.kitapalbtn.Size = new System.Drawing.Size(97, 36);
            this.kitapalbtn.TabIndex = 107;
            this.kitapalbtn.Text = "Kitap Al";
            this.kitapalbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kitapalbtn.UseVisualStyleBackColor = true;
            this.kitapalbtn.Click += new System.EventHandler(this.kitapalbtn_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(47, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 106;
            this.button2.Text = "Kitap Ver";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 105;
            this.label2.Text = "Kitap Seç:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 104;
            this.label1.Text = "Üye Seç:";
            // 
            // üyedtgw
            // 
            this.üyedtgw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.üyedtgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.üyedtgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.üyedtgw.Location = new System.Drawing.Point(615, 57);
            this.üyedtgw.Name = "üyedtgw";
            this.üyedtgw.Size = new System.Drawing.Size(452, 114);
            this.üyedtgw.TabIndex = 105;
            this.üyedtgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgw2_CellContentClick);
            // 
            // dtgw1
            // 
            this.dtgw1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw1.Location = new System.Drawing.Point(12, 299);
            this.dtgw1.Name = "dtgw1";
            this.dtgw1.Size = new System.Drawing.Size(1049, 256);
            this.dtgw1.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 26);
            this.label5.TabIndex = 106;
            this.label5.Text = "Lütfen üye no seçmek için üye no \r\nadlı kolona çift tıklayınız.";
            // 
            // kitapdtgw
            // 
            this.kitapdtgw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kitapdtgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapdtgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapdtgw.Location = new System.Drawing.Point(615, 171);
            this.kitapdtgw.Name = "kitapdtgw";
            this.kitapdtgw.Size = new System.Drawing.Size(452, 114);
            this.kitapdtgw.TabIndex = 107;
            this.kitapdtgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitapdtgw_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 39);
            this.label6.TabIndex = 108;
            this.label6.Text = "Lütfen kitap barkod\r\nseçmek için kitap barkod \r\nadlı kolona çift tıklayınız.";
            // 
            // panelkitap
            // 
            this.panelkitap.Controls.Add(this.label6);
            this.panelkitap.Location = new System.Drawing.Point(421, 171);
            this.panelkitap.Name = "panelkitap";
            this.panelkitap.Size = new System.Drawing.Size(188, 82);
            this.panelkitap.TabIndex = 109;
            // 
            // paneluye
            // 
            this.paneluye.Controls.Add(this.label5);
            this.paneluye.Location = new System.Drawing.Point(421, 57);
            this.paneluye.Name = "paneluye";
            this.paneluye.Size = new System.Drawing.Size(188, 82);
            this.paneluye.TabIndex = 110;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ödünçkitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 567);
            this.Controls.Add(this.paneluye);
            this.Controls.Add(this.panelkitap);
            this.Controls.Add(this.kitapdtgw);
            this.Controls.Add(this.üyedtgw);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgw1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ödünçkitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ödünç İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ödünçkitaplar_Load);
            this.panel1.ResumeLayout(false);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.üyedtgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdtgw)).EndInit();
            this.panelkitap.ResumeLayout(false);
            this.panelkitap.PerformLayout();
            this.paneluye.ResumeLayout(false);
            this.paneluye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button acbutton;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button kitapalbtn;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.TextBox kitapsectext;
        public System.Windows.Forms.TextBox üyesectext;
        private System.Windows.Forms.DataGridView üyedtgw;
        private System.Windows.Forms.DataGridView dtgw1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView kitapdtgw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelkitap;
        private System.Windows.Forms.Panel paneluye;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}