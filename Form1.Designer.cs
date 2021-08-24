
namespace WindowsFormsCadastro
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.textFone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textObjetivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Objetivo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(44, 2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(183, 20);
            this.textNome.TabIndex = 5;
            // 
            // textIdade
            // 
            this.textIdade.Location = new System.Drawing.Point(44, 32);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(100, 20);
            this.textIdade.TabIndex = 6;
            // 
            // textFone
            // 
            this.textFone.Location = new System.Drawing.Point(44, 55);
            this.textFone.Name = "textFone";
            this.textFone.Size = new System.Drawing.Size(100, 20);
            this.textFone.TabIndex = 7;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(44, 86);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(183, 20);
            this.textEmail.TabIndex = 8;
            // 
            // textObjetivo
            // 
            this.textObjetivo.Location = new System.Drawing.Point(57, 113);
            this.textObjetivo.Name = "textObjetivo";
            this.textObjetivo.Size = new System.Drawing.Size(170, 20);
            this.textObjetivo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "GRAVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textObjetivo);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textFone);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.TextBox textFone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textObjetivo;
        private System.Windows.Forms.Button button1;
    }
}

