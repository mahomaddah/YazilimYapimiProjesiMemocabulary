﻿namespace Memocabulary
{
    partial class Kelime_Ekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.textBoxTurk = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCumle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce Kelimeyi Giriniz:";
            // 
            // textBoxEng
            // 
            this.textBoxEng.Location = new System.Drawing.Point(33, 45);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(474, 20);
            this.textBoxEng.TabIndex = 1;
            // 
            // textBoxTurk
            // 
            this.textBoxTurk.Location = new System.Drawing.Point(33, 121);
            this.textBoxTurk.Name = "textBoxTurk";
            this.textBoxTurk.Size = new System.Drawing.Size(474, 20);
            this.textBoxTurk.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Noun",
            "Verb",
            "Adjective",
            "Adverb",
            "Preposition",
            "Pronoun",
            "Conjuction"});
            this.listBox1.Location = new System.Drawing.Point(33, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 95);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kelime Anlamını Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelime Türünü Seçiniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Örnek Cümle Giriniz (Opsiyonel) :";
            // 
            // textBoxCumle
            // 
            this.textBoxCumle.Location = new System.Drawing.Point(33, 328);
            this.textBoxCumle.Name = "textBoxCumle";
            this.textBoxCumle.Size = new System.Drawing.Size(474, 20);
            this.textBoxCumle.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(474, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kelime Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kelime_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCumle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxTurk);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.label1);
            this.Name = "Kelime_Ekle";
            this.Text = "Kelime_Ekle";
            this.Load += new System.EventHandler(this.Kelime_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.TextBox textBoxTurk;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCumle;
        private System.Windows.Forms.Button button1;
    }
}