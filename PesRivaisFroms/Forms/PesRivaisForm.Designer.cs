namespace PesRivaisForms
{
    partial class PesRivaisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.golProLabel = new System.Windows.Forms.Label();
            this.golContraLabel = new System.Windows.Forms.Label();
            this.pontosCb = new System.Windows.Forms.ComboBox();
            this.pontosLabel = new System.Windows.Forms.Label();
            this.particpantesCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.golProCb = new System.Windows.Forms.ComboBox();
            this.golContraCb = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxPontuacao = new System.Windows.Forms.GroupBox();
            this.pontosGridView = new System.Windows.Forms.DataGridView();
            this.ColumnParticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewTop3 = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.groupBoxPontuacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pontosGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // golProLabel
            // 
            this.golProLabel.AutoSize = true;
            this.golProLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golProLabel.Location = new System.Drawing.Point(233, 124);
            this.golProLabel.Name = "golProLabel";
            this.golProLabel.Size = new System.Drawing.Size(63, 23);
            this.golProLabel.TabIndex = 3;
            this.golProLabel.Text = "Gol Pró";
            // 
            // golContraLabel
            // 
            this.golContraLabel.AutoSize = true;
            this.golContraLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golContraLabel.Location = new System.Drawing.Point(349, 124);
            this.golContraLabel.Name = "golContraLabel";
            this.golContraLabel.Size = new System.Drawing.Size(88, 23);
            this.golContraLabel.TabIndex = 5;
            this.golContraLabel.Text = "Gol Contra";
            // 
            // pontosCb
            // 
            this.pontosCb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pontosCb.Enabled = false;
            this.pontosCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pontosCb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosCb.FormattingEnabled = true;
            this.pontosCb.Location = new System.Drawing.Point(109, 150);
            this.pontosCb.Name = "pontosCb";
            this.pontosCb.Size = new System.Drawing.Size(114, 31);
            this.pontosCb.TabIndex = 6;
            this.pontosCb.Text = "Selecione";
            this.pontosCb.SelectedIndexChanged += new System.EventHandler(this.pontosCb_SelectedIndexChanged);
            // 
            // pontosLabel
            // 
            this.pontosLabel.AutoSize = true;
            this.pontosLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosLabel.Location = new System.Drawing.Point(108, 124);
            this.pontosLabel.Name = "pontosLabel";
            this.pontosLabel.Size = new System.Drawing.Size(81, 23);
            this.pontosLabel.TabIndex = 7;
            this.pontosLabel.Text = "Resultado";
            // 
            // particpantesCb
            // 
            this.particpantesCb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.particpantesCb.Cursor = System.Windows.Forms.Cursors.Default;
            this.particpantesCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.particpantesCb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.particpantesCb.FormattingEnabled = true;
            this.particpantesCb.Location = new System.Drawing.Point(109, 90);
            this.particpantesCb.Name = "particpantesCb";
            this.particpantesCb.Size = new System.Drawing.Size(149, 31);
            this.particpantesCb.TabIndex = 8;
            this.particpantesCb.Text = "Selecione";
            this.particpantesCb.SelectedIndexChanged += new System.EventHandler(this.particpantesCb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Participantes";
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Enabled = false;
            this.adicionarBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarBtn.Location = new System.Drawing.Point(465, 150);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(168, 31);
            this.adicionarBtn.TabIndex = 10;
            this.adicionarBtn.Text = "Adicionar";
            this.adicionarBtn.UseVisualStyleBackColor = true;
            this.adicionarBtn.Click += new System.EventHandler(this.adicionarBtn_Click);
            // 
            // golProCb
            // 
            this.golProCb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.golProCb.Enabled = false;
            this.golProCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.golProCb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golProCb.FormattingEnabled = true;
            this.golProCb.Location = new System.Drawing.Point(237, 150);
            this.golProCb.Name = "golProCb";
            this.golProCb.Size = new System.Drawing.Size(97, 31);
            this.golProCb.TabIndex = 11;
            this.golProCb.Text = "Selecione";
            this.golProCb.SelectedIndexChanged += new System.EventHandler(this.golProCb_SelectedIndexChanged);
            // 
            // golContraCb
            // 
            this.golContraCb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.golContraCb.Enabled = false;
            this.golContraCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.golContraCb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golContraCb.FormattingEnabled = true;
            this.golContraCb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.golContraCb.Location = new System.Drawing.Point(353, 150);
            this.golContraCb.Name = "golContraCb";
            this.golContraCb.Size = new System.Drawing.Size(95, 31);
            this.golContraCb.TabIndex = 12;
            this.golContraCb.Text = "Selecione";
            this.golContraCb.SelectedIndexChanged += new System.EventHandler(this.golContraCb_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel1.Text = "PES RIVAIS";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 186);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top 3";
            // 
            // groupBoxPontuacao
            // 
            this.groupBoxPontuacao.Controls.Add(this.pontosGridView);
            this.groupBoxPontuacao.Controls.Add(this.groupBox1);
            this.groupBoxPontuacao.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPontuacao.Location = new System.Drawing.Point(97, 199);
            this.groupBoxPontuacao.Name = "groupBoxPontuacao";
            this.groupBoxPontuacao.Size = new System.Drawing.Size(1051, 254);
            this.groupBoxPontuacao.TabIndex = 16;
            this.groupBoxPontuacao.TabStop = false;
            this.groupBoxPontuacao.Text = "Pontuação";
            // 
            // pontosGridView
            // 
            this.pontosGridView.AllowUserToAddRows = false;
            this.pontosGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pontosGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pontosGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pontosGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.pontosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pontosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnParticipante,
            this.ColumnP,
            this.ColumnJ,
            this.ColumnV,
            this.ColumnE,
            this.ColumnD,
            this.ColumnGP,
            this.ColumnGC,
            this.ColumnSG});
            this.pontosGridView.EnableHeadersVisualStyles = false;
            this.pontosGridView.Location = new System.Drawing.Point(16, 22);
            this.pontosGridView.Name = "pontosGridView";
            this.pontosGridView.ReadOnly = true;
            this.pontosGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pontosGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.pontosGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent;
            this.pontosGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosGridView.Size = new System.Drawing.Size(1024, 213);
            this.pontosGridView.TabIndex = 16;
            // 
            // ColumnParticipante
            // 
            this.ColumnParticipante.HeaderText = "Participante";
            this.ColumnParticipante.Name = "ColumnParticipante";
            this.ColumnParticipante.ReadOnly = true;
            // 
            // ColumnP
            // 
            this.ColumnP.HeaderText = "P";
            this.ColumnP.Name = "ColumnP";
            this.ColumnP.ReadOnly = true;
            this.ColumnP.Width = 115;
            // 
            // ColumnJ
            // 
            this.ColumnJ.HeaderText = "J";
            this.ColumnJ.Name = "ColumnJ";
            this.ColumnJ.ReadOnly = true;
            this.ColumnJ.Width = 115;
            // 
            // ColumnV
            // 
            this.ColumnV.HeaderText = "V";
            this.ColumnV.Name = "ColumnV";
            this.ColumnV.ReadOnly = true;
            this.ColumnV.Width = 115;
            // 
            // ColumnE
            // 
            this.ColumnE.HeaderText = "E";
            this.ColumnE.Name = "ColumnE";
            this.ColumnE.ReadOnly = true;
            this.ColumnE.Width = 115;
            // 
            // ColumnD
            // 
            this.ColumnD.HeaderText = "D";
            this.ColumnD.Name = "ColumnD";
            this.ColumnD.ReadOnly = true;
            this.ColumnD.Width = 115;
            // 
            // ColumnGP
            // 
            this.ColumnGP.HeaderText = "GP";
            this.ColumnGP.Name = "ColumnGP";
            this.ColumnGP.ReadOnly = true;
            this.ColumnGP.Width = 115;
            // 
            // ColumnGC
            // 
            this.ColumnGC.HeaderText = "GC";
            this.ColumnGC.Name = "ColumnGC";
            this.ColumnGC.ReadOnly = true;
            this.ColumnGC.Width = 115;
            // 
            // ColumnSG
            // 
            this.ColumnSG.HeaderText = "SG";
            this.ColumnSG.Name = "ColumnSG";
            this.ColumnSG.ReadOnly = true;
            this.ColumnSG.Width = 115;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(97, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 146);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewTop3);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(97, 459);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 135);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Top 3";
            // 
            // listViewTop3
            // 
            this.listViewTop3.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewTop3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listViewTop3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTop3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewTop3.Location = new System.Drawing.Point(22, 22);
            this.listViewTop3.Name = "listViewTop3";
            this.listViewTop3.Size = new System.Drawing.Size(215, 99);
            this.listViewTop3.TabIndex = 0;
            this.listViewTop3.UseCompatibleStateImageBehavior = false;
            this.listViewTop3.View = System.Windows.Forms.View.List;
            // 
            // PesRivaisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.golContraCb);
            this.Controls.Add(this.golProCb);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.particpantesCb);
            this.Controls.Add(this.pontosLabel);
            this.Controls.Add(this.pontosCb);
            this.Controls.Add(this.golContraLabel);
            this.Controls.Add(this.golProLabel);
            this.Controls.Add(this.groupBoxPontuacao);
            this.Controls.Add(this.groupBox2);
            this.Name = "PesRivaisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "PES RIVAIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PesRivaisForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxPontuacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pontosGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label golProLabel;
        private System.Windows.Forms.Label golContraLabel;
        private System.Windows.Forms.ComboBox pontosCb;
        private System.Windows.Forms.Label pontosLabel;
        private System.Windows.Forms.ComboBox particpantesCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.ComboBox golProCb;
        private System.Windows.Forms.ComboBox golContraCb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPontuacao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewTop3;
        private System.Windows.Forms.DataGridView pontosGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSG;
    }
}

