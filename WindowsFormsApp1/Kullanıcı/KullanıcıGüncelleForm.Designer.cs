
namespace WinFormProje
{
    partial class KullanıcıGüncelleForm
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
            this.radioK = new System.Windows.Forms.RadioButton();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.KullaniciTeltxt = new System.Windows.Forms.TextBox();
            this.KullaniciNotxt = new System.Windows.Forms.TextBox();
            this.KullaniciSoyadtxt = new System.Windows.Forms.TextBox();
            this.KullaniciAdtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioK
            // 
            this.radioK.AutoSize = true;
            this.radioK.Location = new System.Drawing.Point(216, 233);
            this.radioK.Name = "radioK";
            this.radioK.Size = new System.Drawing.Size(38, 21);
            this.radioK.TabIndex = 23;
            this.radioK.TabStop = true;
            this.radioK.Text = "K";
            this.radioK.UseVisualStyleBackColor = true;
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Location = new System.Drawing.Point(135, 232);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(38, 21);
            this.radioE.TabIndex = 22;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.UseVisualStyleBackColor = true;
            // 
            // KullaniciTeltxt
            // 
            this.KullaniciTeltxt.Location = new System.Drawing.Point(135, 191);
            this.KullaniciTeltxt.Name = "KullaniciTeltxt";
            this.KullaniciTeltxt.Size = new System.Drawing.Size(119, 22);
            this.KullaniciTeltxt.TabIndex = 21;
            // 
            // KullaniciNotxt
            // 
            this.KullaniciNotxt.Location = new System.Drawing.Point(135, 153);
            this.KullaniciNotxt.Name = "KullaniciNotxt";
            this.KullaniciNotxt.Size = new System.Drawing.Size(119, 22);
            this.KullaniciNotxt.TabIndex = 20;
            // 
            // KullaniciSoyadtxt
            // 
            this.KullaniciSoyadtxt.Location = new System.Drawing.Point(135, 117);
            this.KullaniciSoyadtxt.Name = "KullaniciSoyadtxt";
            this.KullaniciSoyadtxt.Size = new System.Drawing.Size(119, 22);
            this.KullaniciSoyadtxt.TabIndex = 19;
            // 
            // KullaniciAdtxt
            // 
            this.KullaniciAdtxt.Location = new System.Drawing.Point(135, 81);
            this.KullaniciAdtxt.Name = "KullaniciAdtxt";
            this.KullaniciAdtxt.Size = new System.Drawing.Size(119, 22);
            this.KullaniciAdtxt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(840, 569);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KullanıcıGüncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioK);
            this.Controls.Add(this.radioE);
            this.Controls.Add(this.KullaniciTeltxt);
            this.Controls.Add(this.KullaniciNotxt);
            this.Controls.Add(this.KullaniciSoyadtxt);
            this.Controls.Add(this.KullaniciAdtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "KullanıcıGüncelleForm";
            this.Text = "KullanıcıGüncelleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullanıcıGüncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioK;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.TextBox KullaniciTeltxt;
        private System.Windows.Forms.TextBox KullaniciNotxt;
        private System.Windows.Forms.TextBox KullaniciSoyadtxt;
        private System.Windows.Forms.TextBox KullaniciAdtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}