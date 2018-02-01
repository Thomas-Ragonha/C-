namespace ChamadosLM.Forms
{
    partial class Home
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
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecharChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.Location = new System.Drawing.Point(12, 12);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(104, 23);
            this.btnNovoChamado.TabIndex = 0;
            this.btnNovoChamado.Text = "Novo Chamado!";
            this.btnNovoChamado.UseVisualStyleBackColor = true;
            this.btnNovoChamado.Click += new System.EventHandler(this.btnNovoChamado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescChamado,
            this.StatusChamado,
            this.VerChamado,
            this.FecharChamado});
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(747, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // DescChamado
            // 
            this.DescChamado.HeaderText = "Descrição Chamado";
            this.DescChamado.Name = "DescChamado";
            this.DescChamado.ReadOnly = true;
            // 
            // StatusChamado
            // 
            this.StatusChamado.HeaderText = "Status do Chamado";
            this.StatusChamado.Name = "StatusChamado";
            this.StatusChamado.ReadOnly = true;
            // 
            // VerChamado
            // 
            this.VerChamado.HeaderText = "Ver Chamado";
            this.VerChamado.Name = "VerChamado";
            this.VerChamado.ReadOnly = true;
            // 
            // FecharChamado
            // 
            this.FecharChamado.HeaderText = "Fechar Chamado";
            this.FecharChamado.Name = "FecharChamado";
            this.FecharChamado.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(670, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 253);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNovoChamado);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecharChamado;
        private System.Windows.Forms.Button btnSair;
    }
}