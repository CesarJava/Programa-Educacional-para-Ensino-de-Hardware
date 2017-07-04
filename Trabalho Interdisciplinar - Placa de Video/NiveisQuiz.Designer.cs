namespace Trabalho_Interdisciplinar___Placa_de_Video
{
    partial class NiveisQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NiveisQuiz));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnDificil = new System.Windows.Forms.RadioButton();
            this.rbtnFacil = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolha um nível para começar a jogar:";
            // 
            // rbtnDificil
            // 
            this.rbtnDificil.AutoSize = true;
            this.rbtnDificil.BackColor = System.Drawing.Color.Transparent;
            this.rbtnDificil.Location = new System.Drawing.Point(155, 34);
            this.rbtnDificil.Name = "rbtnDificil";
            this.rbtnDificil.Size = new System.Drawing.Size(52, 17);
            this.rbtnDificil.TabIndex = 6;
            this.rbtnDificil.TabStop = true;
            this.rbtnDificil.Text = "Difícil";
            this.rbtnDificil.UseVisualStyleBackColor = false;
            // 
            // rbtnFacil
            // 
            this.rbtnFacil.AutoSize = true;
            this.rbtnFacil.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFacil.Location = new System.Drawing.Point(102, 34);
            this.rbtnFacil.Name = "rbtnFacil";
            this.rbtnFacil.Size = new System.Drawing.Size(47, 17);
            this.rbtnFacil.TabIndex = 4;
            this.rbtnFacil.TabStop = true;
            this.rbtnFacil.Text = "Fácil";
            this.rbtnFacil.UseVisualStyleBackColor = false;
            this.rbtnFacil.CheckedChanged += new System.EventHandler(this.rbtnFacil_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(3, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Voltar ao menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(113, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Como jogar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(220, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Jogar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NiveisQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(320, 106);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnDificil);
            this.Controls.Add(this.rbtnFacil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NiveisQuiz";
            this.Text = "SoftVideo - Quiz - Níveis";
            this.Load += new System.EventHandler(this.NiveisQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDificil;
        private System.Windows.Forms.RadioButton rbtnFacil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}