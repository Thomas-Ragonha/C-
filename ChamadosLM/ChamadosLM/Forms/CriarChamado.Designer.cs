namespace ChamadosLM.Forms
{
    partial class CriarChamado
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
            this.lblDescChamado = new System.Windows.Forms.Label();
            this.rtxtDescricaoChamado = new System.Windows.Forms.RichTextBox();
            this.btnAdicionarChamado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescChamado
            // 
            this.lblDescChamado.AutoSize = true;
            this.lblDescChamado.Location = new System.Drawing.Point(12, 9);
            this.lblDescChamado.Name = "lblDescChamado";
            this.lblDescChamado.Size = new System.Drawing.Size(111, 13);
            this.lblDescChamado.TabIndex = 0;
            this.lblDescChamado.Text = "Descreva o problema:";
            // 
            // rtxtDescricaoChamado
            // 
            this.rtxtDescricaoChamado.Location = new System.Drawing.Point(15, 25);
            this.rtxtDescricaoChamado.Name = "rtxtDescricaoChamado";
            this.rtxtDescricaoChamado.Size = new System.Drawing.Size(785, 189);
            this.rtxtDescricaoChamado.TabIndex = 1;
            this.rtxtDescricaoChamado.Text = "";
            // 
            // btnAdicionarChamado
            // 
            this.btnAdicionarChamado.Location = new System.Drawing.Point(667, 220);
            this.btnAdicionarChamado.Name = "btnAdicionarChamado";
            this.btnAdicionarChamado.Size = new System.Drawing.Size(133, 25);
            this.btnAdicionarChamado.TabIndex = 2;
            this.btnAdicionarChamado.Text = "Criar Chamado";
            this.btnAdicionarChamado.UseVisualStyleBackColor = true;
            this.btnAdicionarChamado.Click += new System.EventHandler(this.btnAdicionarChamado_Click);
            // 
            // CriarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 257);
            this.Controls.Add(this.btnAdicionarChamado);
            this.Controls.Add(this.rtxtDescricaoChamado);
            this.Controls.Add(this.lblDescChamado);
            this.Name = "CriarChamado";
            this.Text = "Criar Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescChamado;
        private System.Windows.Forms.RichTextBox rtxtDescricaoChamado;
        private System.Windows.Forms.Button btnAdicionarChamado;
    }
}