namespace ProjetoMVCC18
{
    partial class Form1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblCpfC18 = new System.Windows.Forms.Label();
            this.lblNomeC18 = new System.Windows.Forms.Label();
            this.lblNomeMaeC18 = new System.Windows.Forms.Label();
            this.txtCpfC18 = new System.Windows.Forms.TextBox();
            this.txtNomeC18 = new System.Windows.Forms.TextBox();
            this.txtNomeMaeC18 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(60, 256);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(138, 49);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblCpfC18
            // 
            this.lblCpfC18.AutoSize = true;
            this.lblCpfC18.Location = new System.Drawing.Point(25, 20);
            this.lblCpfC18.Name = "lblCpfC18";
            this.lblCpfC18.Size = new System.Drawing.Size(27, 13);
            this.lblCpfC18.TabIndex = 1;
            this.lblCpfC18.Text = "CPF";
            // 
            // lblNomeC18
            // 
            this.lblNomeC18.AutoSize = true;
            this.lblNomeC18.Location = new System.Drawing.Point(25, 91);
            this.lblNomeC18.Name = "lblNomeC18";
            this.lblNomeC18.Size = new System.Drawing.Size(81, 13);
            this.lblNomeC18.TabIndex = 2;
            this.lblNomeC18.Text = "Nome completo";
            // 
            // lblNomeMaeC18
            // 
            this.lblNomeMaeC18.AutoSize = true;
            this.lblNomeMaeC18.Location = new System.Drawing.Point(25, 167);
            this.lblNomeMaeC18.Name = "lblNomeMaeC18";
            this.lblNomeMaeC18.Size = new System.Drawing.Size(73, 13);
            this.lblNomeMaeC18.TabIndex = 3;
            this.lblNomeMaeC18.Text = "Nome da mãe";
            // 
            // txtCpfC18
            // 
            this.txtCpfC18.Location = new System.Drawing.Point(28, 49);
            this.txtCpfC18.Name = "txtCpfC18";
            this.txtCpfC18.Size = new System.Drawing.Size(211, 20);
            this.txtCpfC18.TabIndex = 4;
            // 
            // txtNomeC18
            // 
            this.txtNomeC18.Location = new System.Drawing.Point(28, 124);
            this.txtNomeC18.Name = "txtNomeC18";
            this.txtNomeC18.Size = new System.Drawing.Size(211, 20);
            this.txtNomeC18.TabIndex = 5;
            // 
            // txtNomeMaeC18
            // 
            this.txtNomeMaeC18.Location = new System.Drawing.Point(28, 194);
            this.txtNomeMaeC18.Name = "txtNomeMaeC18";
            this.txtNomeMaeC18.Size = new System.Drawing.Size(211, 20);
            this.txtNomeMaeC18.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 338);
            this.Controls.Add(this.txtNomeMaeC18);
            this.Controls.Add(this.txtNomeC18);
            this.Controls.Add(this.txtCpfC18);
            this.Controls.Add(this.lblNomeMaeC18);
            this.Controls.Add(this.lblNomeC18);
            this.Controls.Add(this.lblCpfC18);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblCpfC18;
        private System.Windows.Forms.Label lblNomeC18;
        private System.Windows.Forms.Label lblNomeMaeC18;
        private System.Windows.Forms.TextBox txtCpfC18;
        private System.Windows.Forms.TextBox txtNomeC18;
        private System.Windows.Forms.TextBox txtNomeMaeC18;
    }
}

