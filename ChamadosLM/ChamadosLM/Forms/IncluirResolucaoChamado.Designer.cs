namespace ChamadosLM.Forms
{
    partial class IncluirResolucaoChamado
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
            this.rtxtResolucaoChamado = new System.Windows.Forms.RichTextBox();
            this.btnAdicionarResolucao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtResolucaoChamado
            // 
            this.rtxtResolucaoChamado.Location = new System.Drawing.Point(12, 12);
            this.rtxtResolucaoChamado.Name = "rtxtResolucaoChamado";
            this.rtxtResolucaoChamado.Size = new System.Drawing.Size(736, 280);
            this.rtxtResolucaoChamado.TabIndex = 0;
            this.rtxtResolucaoChamado.Text = "";
            // 
            // btnAdicionarResolucao
            // 
            this.btnAdicionarResolucao.Location = new System.Drawing.Point(609, 298);
            this.btnAdicionarResolucao.Name = "btnAdicionarResolucao";
            this.btnAdicionarResolucao.Size = new System.Drawing.Size(139, 23);
            this.btnAdicionarResolucao.TabIndex = 1;
            this.btnAdicionarResolucao.Text = "Adicionar Resolução";
            this.btnAdicionarResolucao.UseVisualStyleBackColor = true;
            this.btnAdicionarResolucao.Click += new System.EventHandler(this.btnAdicionarResolucao_Click);
            // 
            // IncluirResolucaoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 331);
            this.Controls.Add(this.btnAdicionarResolucao);
            this.Controls.Add(this.rtxtResolucaoChamado);
            this.Name = "IncluirResolucaoChamado";
            this.Text = "IncluirResolucaoChamado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtResolucaoChamado;
        private System.Windows.Forms.Button btnAdicionarResolucao;
    }
}