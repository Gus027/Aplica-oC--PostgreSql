namespace CSh_Database
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
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmpregado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpregado)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(587, 206);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(116, 23);
            this.buttonLimpar.TabIndex = 0;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(11, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewEmpregado
            // 
            this.dataGridViewEmpregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpregado.Location = new System.Drawing.Point(12, 267);
            this.dataGridViewEmpregado.Name = "dataGridViewEmpregado";
            this.dataGridViewEmpregado.RowTemplate.Height = 25;
            this.dataGridViewEmpregado.Size = new System.Drawing.Size(691, 171);
            this.dataGridViewEmpregado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(11, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(11, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Endereço";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(587, 177);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(116, 23);
            this.buttonExcluir.TabIndex = 6;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(587, 148);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(116, 23);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(587, 119);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(116, 23);
            this.buttonPesquisar.TabIndex = 8;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.button4_Click);
            // 
            // textMatricula
            // 
            this.textMatricula.BackColor = System.Drawing.SystemColors.Window;
            this.textMatricula.Location = new System.Drawing.Point(90, 112);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.ReadOnly = true;
            this.textMatricula.Size = new System.Drawing.Size(172, 23);
            this.textMatricula.TabIndex = 9;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(90, 202);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(378, 23);
            this.textEndereco.TabIndex = 10;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(90, 173);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(378, 23);
            this.textNome.TabIndex = 11;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(90, 141);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(172, 23);
            this.textCpf.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(197, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "CADASTRO DE EMPREGADO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewEmpregado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLimpar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpregado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLimpar;
        private Label label1;
        private DataGridView dataGridViewEmpregado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonExcluir;
        private Button buttonSalvar;
        private Button buttonPesquisar;
        private TextBox textMatricula;
        private TextBox textEndereco;
        private TextBox textNome;
        private TextBox textCpf;
        private Label label5;
    }
}