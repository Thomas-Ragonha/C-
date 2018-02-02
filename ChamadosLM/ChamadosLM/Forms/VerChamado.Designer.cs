namespace ChamadosLM.Forms
{
    partial class VerChamado
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
            this.rtxtDescricaoChamado = new System.Windows.Forms.RichTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtDescricaoChamado
            // 
            this.rtxtDescricaoChamado.Location = new System.Drawing.Point(12, 12);
            this.rtxtDescricaoChamado.Name = "rtxtDescricaoChamado";
            this.rtxtDescricaoChamado.ReadOnly = true;
            this.rtxtDescricaoChamado.Size = new System.Drawing.Size(660, 236);
            this.rtxtDescricaoChamado.TabIndex = 0;
            this.rtxtDescricaoChamado.Text = "";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(597, 254);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar!";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // VerChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 289);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.rtxtDescricaoChamado);
            this.Name = "VerChamado";
            this.Text = "Ver Chamado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDescricaoChamado;
        private System.Windows.Forms.Button btnVoltar;
    }
}