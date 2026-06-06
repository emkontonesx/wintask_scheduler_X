using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wintask_scheduler_X
{
    public partial class TSX : Form
    {
        public TSX()
        {
            InitializeComponent();
        }

        private void dosya_yolu_orjinal_program_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(dosya_yolu_orjinal_program.Text))
                lbl_dosya_yolu.ForeColor = Color.Green;
            else
                lbl_dosya_yolu.ForeColor = Color.Red;
        }

        private void lbl_dosya_yolu_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbl_name.ForeColor = string.IsNullOrWhiteSpace(textBox1.Text) ? Color.Red : Color.Green;

        }

        private void lbl_ack_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lbl_ack.ForeColor = string.IsNullOrWhiteSpace(richTextBox1.Text) ? Color.Yellow : Color.Green;
        
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            // Temel doğrulamalar
            if (!File.Exists(dosya_yolu_orjinal_program.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen geçerli bir dosya yolu ve görev adı girin!");
                return;
            }

            string gorevAdi = textBox1.Text;

            using (TaskService ts = new TaskService())
            {
                // ÇÖZÜM 1: 'Task' yerine 'var' kullanarak isim çakışmasını önledik
                var varOlanGorev = ts.GetTask(gorevAdi);
                if (varOlanGorev != null)
                {
                    DialogResult cevap = MessageBox.Show($"'{gorevAdi}' adında bir görev zaten mevcut.\nYine de ekleyip üzerine yazmak ister misiniz?",
                                                         "Görev Zaten Var",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                    if (cevap == DialogResult.No)
                    {
                        return;
                    }
                }

                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = richTextBox1.Text;

                // --- GENEL AYARLAR ---
                td.Settings.Hidden = cb_gizli.Checked;

                if (cb_en_yuksek_ayricalik.Checked)
                    td.Principal.RunLevel = TaskRunLevel.Highest;

                if (rb_her_durumda.Checked)
                    td.Principal.LogonType = TaskLogonType.Password;
                else
                    td.Principal.LogonType = TaskLogonType.InteractiveToken;

                // --- ARKA PLANDA SABİT OLAN AYARLAR ---
                // ÇÖZÜM 2: StopOnIdleEnd ayarını IdleSettings'in içine aldık
                td.Settings.IdleSettings.StopOnIdleEnd = false;

                td.Settings.DisallowStartIfOnBatteries = false;
                td.Settings.StopIfGoingOnBatteries = false;

                // --- TETİKLEYİCİLER ---
                BootTrigger bTrigger = new BootTrigger();
                if (num_gecikme_dk.Value > 0)
                {
                    bTrigger.Delay = TimeSpan.FromMinutes((double)num_gecikme_dk.Value);
                }
                td.Triggers.Add(bTrigger);

                // --- KOŞULLAR ---
                td.Settings.RunOnlyIfNetworkAvailable = cb_ag_baglantisi.Checked;

                if (num_bos_sure.Value > 0)
                {
                    td.Settings.RunOnlyIfIdle = true;
                    td.Settings.IdleSettings.IdleDuration = TimeSpan.FromMinutes((double)num_bos_sure.Value);
                }
                else
                {
                    td.Settings.RunOnlyIfIdle = false;
                }

                // --- EYLEMLER ---
                td.Actions.Add(new ExecAction(dosya_yolu_orjinal_program.Text, null, null));

                ts.RootFolder.RegisterTaskDefinition(gorevAdi, td);

                MessageBox.Show("Görev başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cb_gizli_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gizli.Checked)
            {
                cb_gizli.ForeColor = Color.LimeGreen;
            }
            else
            {
                cb_gizli.ForeColor = Color.Red;
            }
        }

        private void cb_ag_baglantisi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ag_baglantisi.Checked)
            {
                cb_ag_baglantisi.ForeColor = Color.LimeGreen;
            }
            else
            {
                cb_ag_baglantisi.ForeColor = Color.Red;
            }
        }

        private void rb_oturum_acildiginda_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_oturum_acildiginda.Checked)
            {
                rb_oturum_acildiginda.ForeColor = Color.LimeGreen;
            }
            else
            {
                rb_oturum_acildiginda.ForeColor = Color.LimeGreen;
            }
        }

        private void cb_en_yuksek_ayricalik_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_en_yuksek_ayricalik.Checked)
            {
                cb_en_yuksek_ayricalik.ForeColor = Color.LimeGreen;
            }
            else
            {
                cb_en_yuksek_ayricalik.ForeColor = Color.Red;
            }
        }

        private void rb_her_durumda_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_her_durumda.Checked)
            {
                rb_her_durumda.ForeColor = Color.LimeGreen;
            }
            else
            {
                rb_her_durumda.ForeColor= Color.Red;
            }
        }

        private void TSX_Load(object sender, EventArgs e)
        {

        }
    }
}
