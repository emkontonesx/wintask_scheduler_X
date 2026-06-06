namespace wintask_scheduler_X
{
    partial class TSX
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TSX));
            this.dosya_yolu_orjinal_program = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_dosya_yolu = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_ack = new System.Windows.Forms.Label();
            this.btn_active = new System.Windows.Forms.Button();
            this.rb_oturum_acildiginda = new System.Windows.Forms.RadioButton();
            this.rb_her_durumda = new System.Windows.Forms.RadioButton();
            this.cb_en_yuksek_ayricalik = new System.Windows.Forms.CheckBox();
            this.cb_gizli = new System.Windows.Forms.CheckBox();
            this.num_gecikme_dk = new System.Windows.Forms.NumericUpDown();
            this.cb_ag_baglantisi = new System.Windows.Forms.CheckBox();
            this.num_bos_sure = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.info_1 = new System.Windows.Forms.Label();
            this.info_pc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_gecikme_dk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bos_sure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // dosya_yolu_orjinal_program
            // 
            this.dosya_yolu_orjinal_program.Location = new System.Drawing.Point(11, 33);
            this.dosya_yolu_orjinal_program.Name = "dosya_yolu_orjinal_program";
            this.dosya_yolu_orjinal_program.Size = new System.Drawing.Size(302, 20);
            this.dosya_yolu_orjinal_program.TabIndex = 0;
            this.dosya_yolu_orjinal_program.TextChanged += new System.EventHandler(this.dosya_yolu_orjinal_program_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 90);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbl_dosya_yolu
            // 
            this.lbl_dosya_yolu.AutoSize = true;
            this.lbl_dosya_yolu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dosya_yolu.ForeColor = System.Drawing.Color.Red;
            this.lbl_dosya_yolu.Location = new System.Drawing.Point(12, 14);
            this.lbl_dosya_yolu.Name = "lbl_dosya_yolu";
            this.lbl_dosya_yolu.Size = new System.Drawing.Size(78, 16);
            this.lbl_dosya_yolu.TabIndex = 3;
            this.lbl_dosya_yolu.Text = "Dosya Yolu";
            this.lbl_dosya_yolu.Click += new System.EventHandler(this.lbl_dosya_yolu_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(11, 61);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(34, 16);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "İsim";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_ack
            // 
            this.lbl_ack.AutoSize = true;
            this.lbl_ack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ack.ForeColor = System.Drawing.Color.Red;
            this.lbl_ack.Location = new System.Drawing.Point(10, 108);
            this.lbl_ack.Name = "lbl_ack";
            this.lbl_ack.Size = new System.Drawing.Size(65, 16);
            this.lbl_ack.TabIndex = 5;
            this.lbl_ack.Text = "Açıklama";
            this.lbl_ack.Click += new System.EventHandler(this.lbl_ack_Click);
            // 
            // btn_active
            // 
            this.btn_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_active.Location = new System.Drawing.Point(338, 159);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(75, 23);
            this.btn_active.TabIndex = 6;
            this.btn_active.Text = "Tanımla";
            this.btn_active.UseVisualStyleBackColor = true;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // rb_oturum_acildiginda
            // 
            this.rb_oturum_acildiginda.AutoSize = true;
            this.rb_oturum_acildiginda.ForeColor = System.Drawing.Color.Red;
            this.rb_oturum_acildiginda.Location = new System.Drawing.Point(338, 103);
            this.rb_oturum_acildiginda.Name = "rb_oturum_acildiginda";
            this.rb_oturum_acildiginda.Size = new System.Drawing.Size(110, 17);
            this.rb_oturum_acildiginda.TabIndex = 7;
            this.rb_oturum_acildiginda.TabStop = true;
            this.rb_oturum_acildiginda.Text = "oturum acildiginda";
            this.rb_oturum_acildiginda.UseVisualStyleBackColor = true;
            this.rb_oturum_acildiginda.CheckedChanged += new System.EventHandler(this.rb_oturum_acildiginda_CheckedChanged);
            // 
            // rb_her_durumda
            // 
            this.rb_her_durumda.AutoSize = true;
            this.rb_her_durumda.ForeColor = System.Drawing.Color.Red;
            this.rb_her_durumda.Location = new System.Drawing.Point(338, 127);
            this.rb_her_durumda.Name = "rb_her_durumda";
            this.rb_her_durumda.Size = new System.Drawing.Size(84, 17);
            this.rb_her_durumda.TabIndex = 8;
            this.rb_her_durumda.TabStop = true;
            this.rb_her_durumda.Text = "her durumda";
            this.rb_her_durumda.UseVisualStyleBackColor = true;
            this.rb_her_durumda.CheckedChanged += new System.EventHandler(this.rb_her_durumda_CheckedChanged);
            // 
            // cb_en_yuksek_ayricalik
            // 
            this.cb_en_yuksek_ayricalik.AutoSize = true;
            this.cb_en_yuksek_ayricalik.ForeColor = System.Drawing.Color.Red;
            this.cb_en_yuksek_ayricalik.Location = new System.Drawing.Point(338, 80);
            this.cb_en_yuksek_ayricalik.Name = "cb_en_yuksek_ayricalik";
            this.cb_en_yuksek_ayricalik.Size = new System.Drawing.Size(87, 17);
            this.cb_en_yuksek_ayricalik.TabIndex = 9;
            this.cb_en_yuksek_ayricalik.Text = "Yüksek yetki";
            this.cb_en_yuksek_ayricalik.UseVisualStyleBackColor = true;
            this.cb_en_yuksek_ayricalik.CheckedChanged += new System.EventHandler(this.cb_en_yuksek_ayricalik_CheckedChanged);
            // 
            // cb_gizli
            // 
            this.cb_gizli.AutoSize = true;
            this.cb_gizli.ForeColor = System.Drawing.Color.Red;
            this.cb_gizli.Location = new System.Drawing.Point(338, 33);
            this.cb_gizli.Name = "cb_gizli";
            this.cb_gizli.Size = new System.Drawing.Size(45, 17);
            this.cb_gizli.TabIndex = 10;
            this.cb_gizli.Text = "Gizli";
            this.cb_gizli.UseVisualStyleBackColor = true;
            this.cb_gizli.CheckedChanged += new System.EventHandler(this.cb_gizli_CheckedChanged);
            // 
            // num_gecikme_dk
            // 
            this.num_gecikme_dk.Location = new System.Drawing.Point(9, 251);
            this.num_gecikme_dk.Name = "num_gecikme_dk";
            this.num_gecikme_dk.Size = new System.Drawing.Size(303, 20);
            this.num_gecikme_dk.TabIndex = 11;
            // 
            // cb_ag_baglantisi
            // 
            this.cb_ag_baglantisi.AutoSize = true;
            this.cb_ag_baglantisi.ForeColor = System.Drawing.Color.Red;
            this.cb_ag_baglantisi.Location = new System.Drawing.Point(338, 56);
            this.cb_ag_baglantisi.Name = "cb_ag_baglantisi";
            this.cb_ag_baglantisi.Size = new System.Drawing.Size(134, 17);
            this.cb_ag_baglantisi.TabIndex = 12;
            this.cb_ag_baglantisi.Text = "Ağ Bağlantısı kontrol et";
            this.cb_ag_baglantisi.UseVisualStyleBackColor = true;
            this.cb_ag_baglantisi.CheckedChanged += new System.EventHandler(this.cb_ag_baglantisi_CheckedChanged);
            // 
            // num_bos_sure
            // 
            this.num_bos_sure.Location = new System.Drawing.Point(9, 314);
            this.num_bos_sure.Name = "num_bos_sure";
            this.num_bos_sure.Size = new System.Drawing.Size(303, 20);
            this.num_bos_sure.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Başlatma Gecikmesi(dakika)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Boşta kalma gecikmesi(dakika)";
            // 
            // info_1
            // 
            this.info_1.AutoSize = true;
            this.info_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_1.ForeColor = System.Drawing.Color.Red;
            this.info_1.Location = new System.Drawing.Point(318, 254);
            this.info_1.Name = "info_1";
            this.info_1.Size = new System.Drawing.Size(179, 80);
            this.info_1.TabIndex = 16;
            this.info_1.Text = "Başlatma ve \r\nboşta kalma\r\ngecikmesi Eğer 0 ise \r\nkapalı olucaktır.\r\n";
            // 
            // info_pc
            // 
            this.info_pc.Image = global::wintask_scheduler_X.Properties.Resources.icons8_info_480;
            this.info_pc.Location = new System.Drawing.Point(430, 254);
            this.info_pc.Name = "info_pc";
            this.info_pc.Size = new System.Drawing.Size(42, 39);
            this.info_pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info_pc.TabIndex = 17;
            this.info_pc.TabStop = false;
            // 
            // TSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(505, 352);
            this.Controls.Add(this.info_pc);
            this.Controls.Add(this.info_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_bos_sure);
            this.Controls.Add(this.cb_ag_baglantisi);
            this.Controls.Add(this.num_gecikme_dk);
            this.Controls.Add(this.cb_gizli);
            this.Controls.Add(this.cb_en_yuksek_ayricalik);
            this.Controls.Add(this.rb_her_durumda);
            this.Controls.Add(this.rb_oturum_acildiginda);
            this.Controls.Add(this.btn_active);
            this.Controls.Add(this.lbl_ack);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_dosya_yolu);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dosya_yolu_orjinal_program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "task scheduler x";
            this.Load += new System.EventHandler(this.TSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_gecikme_dk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bos_sure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dosya_yolu_orjinal_program;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_dosya_yolu;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ack;
        private System.Windows.Forms.Button btn_active;
        private System.Windows.Forms.RadioButton rb_oturum_acildiginda;
        private System.Windows.Forms.RadioButton rb_her_durumda;
        private System.Windows.Forms.CheckBox cb_en_yuksek_ayricalik;
        private System.Windows.Forms.CheckBox cb_gizli;
        private System.Windows.Forms.NumericUpDown num_gecikme_dk;
        private System.Windows.Forms.CheckBox cb_ag_baglantisi;
        private System.Windows.Forms.NumericUpDown num_bos_sure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label info_1;
        private System.Windows.Forms.PictureBox info_pc;
    }
}

