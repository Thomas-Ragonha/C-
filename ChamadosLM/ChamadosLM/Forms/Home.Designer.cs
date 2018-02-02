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
            this.components = new System.ComponentModel.Container();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.gridChamados = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.chamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoChamadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolucaoChamadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoChamadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFechamentoChamadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusChamadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerChamado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluirChamado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColocarEmAtendimento = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IncluirResolucao = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridChamados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadoBindingSource)).BeginInit();
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
            // gridChamados
            // 
            this.gridChamados.AllowUserToAddRows = false;
            this.gridChamados.AllowUserToDeleteRows = false;
            this.gridChamados.AutoGenerateColumns = false;
            this.gridChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descricaoChamadoDataGridViewTextBoxColumn,
            this.resolucaoChamadoDataGridViewTextBoxColumn,
            this.dataCriacaoChamadoDataGridViewTextBoxColumn,
            this.dataFechamentoChamadoDataGridViewTextBoxColumn,
            this.statusChamadoDataGridViewTextBoxColumn,
            this.btnVerChamado,
            this.btnExcluirChamado,
            this.ColocarEmAtendimento,
            this.IncluirResolucao});
            this.gridChamados.DataSource = this.chamadoBindingSource;
            this.gridChamados.Location = new System.Drawing.Point(13, 42);
            this.gridChamados.Name = "gridChamados";
            this.gridChamados.ReadOnly = true;
            this.gridChamados.Size = new System.Drawing.Size(1131, 385);
            this.gridChamados.TabIndex = 1;
            this.gridChamados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChamados_CellContentClick);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1054, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // chamadoBindingSource
            // 
            this.chamadoBindingSource.DataSource = typeof(ChamadosLM.Classes.Chamado);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // descricaoChamadoDataGridViewTextBoxColumn
            // 
            this.descricaoChamadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.descricaoChamadoDataGridViewTextBoxColumn.DataPropertyName = "DescricaoChamado";
            this.descricaoChamadoDataGridViewTextBoxColumn.HeaderText = "DescricaoChamado";
            this.descricaoChamadoDataGridViewTextBoxColumn.Name = "descricaoChamadoDataGridViewTextBoxColumn";
            this.descricaoChamadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoChamadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // resolucaoChamadoDataGridViewTextBoxColumn
            // 
            this.resolucaoChamadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.resolucaoChamadoDataGridViewTextBoxColumn.DataPropertyName = "ResolucaoChamado";
            this.resolucaoChamadoDataGridViewTextBoxColumn.HeaderText = "ResolucaoChamado";
            this.resolucaoChamadoDataGridViewTextBoxColumn.Name = "resolucaoChamadoDataGridViewTextBoxColumn";
            this.resolucaoChamadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.resolucaoChamadoDataGridViewTextBoxColumn.Width = 128;
            // 
            // dataCriacaoChamadoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoChamadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataCriacaoChamadoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacaoChamado";
            this.dataCriacaoChamadoDataGridViewTextBoxColumn.HeaderText = "DataCriacaoChamado";
            this.dataCriacaoChamadoDataGridViewTextBoxColumn.Name = "dataCriacaoChamadoDataGridViewTextBoxColumn";
            this.dataCriacaoChamadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCriacaoChamadoDataGridViewTextBoxColumn.Width = 136;
            // 
            // dataFechamentoChamadoDataGridViewTextBoxColumn
            // 
            this.dataFechamentoChamadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataFechamentoChamadoDataGridViewTextBoxColumn.DataPropertyName = "DataFechamentoChamado";
            this.dataFechamentoChamadoDataGridViewTextBoxColumn.HeaderText = "DataFechamentoChamado";
            this.dataFechamentoChamadoDataGridViewTextBoxColumn.Name = "dataFechamentoChamadoDataGridViewTextBoxColumn";
            this.dataFechamentoChamadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataFechamentoChamadoDataGridViewTextBoxColumn.Width = 159;
            // 
            // statusChamadoDataGridViewTextBoxColumn
            // 
            this.statusChamadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.statusChamadoDataGridViewTextBoxColumn.DataPropertyName = "StatusChamado";
            this.statusChamadoDataGridViewTextBoxColumn.HeaderText = "StatusChamado";
            this.statusChamadoDataGridViewTextBoxColumn.Name = "statusChamadoDataGridViewTextBoxColumn";
            this.statusChamadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusChamadoDataGridViewTextBoxColumn.Width = 107;
            // 
            // btnVerChamado
            // 
            this.btnVerChamado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnVerChamado.HeaderText = "Ver Chamado";
            this.btnVerChamado.Name = "btnVerChamado";
            this.btnVerChamado.ReadOnly = true;
            this.btnVerChamado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVerChamado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnVerChamado.Text = "Ver Chamado";
            this.btnVerChamado.UseColumnTextForButtonValue = true;
            this.btnVerChamado.Width = 96;
            // 
            // btnExcluirChamado
            // 
            this.btnExcluirChamado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnExcluirChamado.HeaderText = "Excluir Chamado";
            this.btnExcluirChamado.Name = "btnExcluirChamado";
            this.btnExcluirChamado.ReadOnly = true;
            this.btnExcluirChamado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluirChamado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnExcluirChamado.Text = "Excluir Chamado";
            this.btnExcluirChamado.UseColumnTextForButtonValue = true;
            // 
            // ColocarEmAtendimento
            // 
            this.ColocarEmAtendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColocarEmAtendimento.HeaderText = "Atender";
            this.ColocarEmAtendimento.Name = "ColocarEmAtendimento";
            this.ColocarEmAtendimento.ReadOnly = true;
            this.ColocarEmAtendimento.Text = "Atender";
            this.ColocarEmAtendimento.UseColumnTextForButtonValue = true;
            this.ColocarEmAtendimento.Width = 50;
            // 
            // IncluirResolucao
            // 
            this.IncluirResolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IncluirResolucao.HeaderText = "Incluir Resolução";
            this.IncluirResolucao.Name = "IncluirResolucao";
            this.IncluirResolucao.ReadOnly = true;
            this.IncluirResolucao.Text = "Incluir Resolução";
            this.IncluirResolucao.UseColumnTextForButtonValue = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 439);
            this.Controls.Add(this.gridChamados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovoChamado);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.gridChamados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.DataGridView gridChamados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.BindingSource chamadoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoChamadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolucaoChamadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoChamadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFechamentoChamadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusChamadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnVerChamado;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluirChamado;
        private System.Windows.Forms.DataGridViewButtonColumn ColocarEmAtendimento;
        private System.Windows.Forms.DataGridViewButtonColumn IncluirResolucao;
    }
}