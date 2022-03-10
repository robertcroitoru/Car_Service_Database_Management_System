
namespace Gestiune_Lucrari_Service
{
    partial class Lucrari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textStare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPiese = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMasina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textAngajat = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textStare
            // 
            this.textStare.Location = new System.Drawing.Point(109, 145);
            this.textStare.Name = "textStare";
            this.textStare.Size = new System.Drawing.Size(100, 20);
            this.textStare.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Stare";
            // 
            // textPiese
            // 
            this.textPiese.Location = new System.Drawing.Point(109, 119);
            this.textPiese.Name = "textPiese";
            this.textPiese.Size = new System.Drawing.Size(100, 20);
            this.textPiese.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Piese necesare";
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(109, 93);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nume lucrare";
            // 
            // textMasina
            // 
            this.textMasina.Location = new System.Drawing.Point(109, 64);
            this.textMasina.Name = "textMasina";
            this.textMasina.Size = new System.Drawing.Size(100, 20);
            this.textMasina.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "MasinaID";
            // 
            // textClient
            // 
            this.textClient.Location = new System.Drawing.Point(109, 38);
            this.textClient.Name = "textClient";
            this.textClient.Size = new System.Drawing.Size(100, 20);
            this.textClient.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ClientID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "AngajatID";
            // 
            // textAngajat
            // 
            this.textAngajat.Location = new System.Drawing.Point(109, 12);
            this.textAngajat.Name = "textAngajat";
            this.textAngajat.Size = new System.Drawing.Size(100, 20);
            this.textAngajat.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(320, 33);
            this.button4.TabIndex = 33;
            this.button4.Text = "Numele angajatilor care au lucrare cu starea X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(341, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(320, 35);
            this.button5.TabIndex = 34;
            this.button5.Text = "Numele si prenumele clientilor care au lucrari nefinalizate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(341, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(320, 35);
            this.button6.TabIndex = 35;
            this.button6.Text = "Numele si prenumele angajatilor care nu si-au terminat lucrarile";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(341, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(320, 35);
            this.button7.TabIndex = 36;
            this.button7.Text = "Lucrarile care sunt desfasurate doar de mecanici\r\n";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Lucrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textStare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPiese);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMasina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAngajat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lucrari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucrari";
            this.Load += new System.EventHandler(this.Lucrari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textStare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPiese;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMasina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAngajat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}