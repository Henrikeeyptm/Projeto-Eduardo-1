namespace Projeto_Eduardo_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            comboBoxCarros = new ComboBox();
            btnRemover = new Button();
            btnAdicionar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDias = new TextBox();
            txtKm = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1489, 649);
            panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 100);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(1489, 549);
            dataGridView2.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "Classe do Carro";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantos Dias ";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quilometros rodados";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor total";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 250;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1489, 549);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(comboBoxCarros);
            panel2.Controls.Add(btnRemover);
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtDias);
            panel2.Controls.Add(txtKm);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1489, 100);
            panel2.TabIndex = 0;
            // 
            // comboBoxCarros
            // 
            comboBoxCarros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarros.FormattingEnabled = true;
            comboBoxCarros.Items.AddRange(new object[] { "", "Popular", "Intermediário", "Premium" });
            comboBoxCarros.Location = new Point(340, 55);
            comboBoxCarros.Name = "comboBoxCarros";
            comboBoxCarros.Size = new Size(163, 23);
            comboBoxCarros.TabIndex = 8;
            comboBoxCarros.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Red;
            btnRemover.Location = new Point(1081, 26);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(125, 48);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover (-)";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Lime;
            btnAdicionar.Location = new Point(915, 26);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(125, 48);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar (+)";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(605, 18);
            label3.Name = "label3";
            label3.Size = new Size(224, 30);
            label3.TabIndex = 5;
            label3.Text = "Quilometros rodados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(339, 18);
            label2.Name = "label2";
            label2.Size = new Size(166, 30);
            label2.TabIndex = 4;
            label2.Text = "Classe do carro:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(206, 30);
            label1.TabIndex = 3;
            label1.Text = "Quantidade de dias:";
            label1.Click += label1_Click;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(32, 51);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(206, 23);
            txtDias.TabIndex = 1;
            txtDias.TextChanged += txtDias_TextChanged;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(605, 51);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(224, 23);
            txtKm.TabIndex = 0;
            txtKm.TextChanged += txtCarro_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 649);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtDias;
        private TextBox txtKm;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnRemover;
        private Button btnAdicionar;
        private ComboBox comboBoxCarros;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
