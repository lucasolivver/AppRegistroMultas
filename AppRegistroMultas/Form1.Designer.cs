namespace AppRegistroMultas
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
            this.btConsulta = new System.Windows.Forms.Button();
            this.btCadastroMulta = new System.Windows.Forms.Button();
            this.btCadastroVeiculo = new System.Windows.Forms.Button();
            this.btAtualizaMulta = new System.Windows.Forms.Button();
            this.btDeletaMulta = new System.Windows.Forms.Button();
            this.btAtualizaVeiculo = new System.Windows.Forms.Button();
            this.btDeletaVeiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConsulta
            // 
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(45, 158);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(628, 36);
            this.btConsulta.TabIndex = 32;
            this.btConsulta.Text = "CONSULTA DE MULTAS";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btCadastroMulta
            // 
            this.btCadastroMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroMulta.Location = new System.Drawing.Point(45, 105);
            this.btCadastroMulta.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastroMulta.Name = "btCadastroMulta";
            this.btCadastroMulta.Size = new System.Drawing.Size(628, 36);
            this.btCadastroMulta.TabIndex = 31;
            this.btCadastroMulta.Text = "CADASTRO DE MULTAS";
            this.btCadastroMulta.UseVisualStyleBackColor = true;
            this.btCadastroMulta.Click += new System.EventHandler(this.btCadastroMulta_Click);
            // 
            // btCadastroVeiculo
            // 
            this.btCadastroVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroVeiculo.Location = new System.Drawing.Point(45, 48);
            this.btCadastroVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastroVeiculo.Name = "btCadastroVeiculo";
            this.btCadastroVeiculo.Size = new System.Drawing.Size(628, 36);
            this.btCadastroVeiculo.TabIndex = 30;
            this.btCadastroVeiculo.Text = "CADASTRAR VEÍCULOS";
            this.btCadastroVeiculo.UseVisualStyleBackColor = true;
            this.btCadastroVeiculo.Click += new System.EventHandler(this.btCadastroVeiculo_Click);
            // 
            // btAtualizaMulta
            // 
            this.btAtualizaMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizaMulta.Location = new System.Drawing.Point(45, 217);
            this.btAtualizaMulta.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizaMulta.Name = "btAtualizaMulta";
            this.btAtualizaMulta.Size = new System.Drawing.Size(628, 36);
            this.btAtualizaMulta.TabIndex = 33;
            this.btAtualizaMulta.Text = "ATUALIZAÇÃO DE MULTAS";
            this.btAtualizaMulta.UseVisualStyleBackColor = true;
            this.btAtualizaMulta.Click += new System.EventHandler(this.btAtualizaMulta_Click);
            // 
            // btDeletaMulta
            // 
            this.btDeletaMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletaMulta.Location = new System.Drawing.Point(45, 271);
            this.btDeletaMulta.Margin = new System.Windows.Forms.Padding(4);
            this.btDeletaMulta.Name = "btDeletaMulta";
            this.btDeletaMulta.Size = new System.Drawing.Size(628, 36);
            this.btDeletaMulta.TabIndex = 34;
            this.btDeletaMulta.Text = "EXCLUSÃO DE MULTAS";
            this.btDeletaMulta.UseVisualStyleBackColor = true;
            this.btDeletaMulta.Click += new System.EventHandler(this.btDeletaMulta_Click);
            // 
            // btAtualizaVeiculo
            // 
            this.btAtualizaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizaVeiculo.Location = new System.Drawing.Point(45, 327);
            this.btAtualizaVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizaVeiculo.Name = "btAtualizaVeiculo";
            this.btAtualizaVeiculo.Size = new System.Drawing.Size(628, 36);
            this.btAtualizaVeiculo.TabIndex = 35;
            this.btAtualizaVeiculo.Text = "ATUALIZAÇÃO DE VEÍCULO";
            this.btAtualizaVeiculo.UseVisualStyleBackColor = true;
            this.btAtualizaVeiculo.Click += new System.EventHandler(this.btAtualizaVeiculo_Click);
            // 
            // btDeletaVeiculo
            // 
            this.btDeletaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletaVeiculo.Location = new System.Drawing.Point(35, 383);
            this.btDeletaVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btDeletaVeiculo.Name = "btDeletaVeiculo";
            this.btDeletaVeiculo.Size = new System.Drawing.Size(628, 36);
            this.btDeletaVeiculo.TabIndex = 36;
            this.btDeletaVeiculo.Text = "EXCLUSÃO DE MULTAS";
            this.btDeletaVeiculo.UseVisualStyleBackColor = true;
            this.btDeletaVeiculo.Click += new System.EventHandler(this.btDeletaVeiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "ALUNOS: LUCAS OLIVEIRA E FELIPE NINK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "TURMA: 2A INFORMÁTICA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeletaVeiculo);
            this.Controls.Add(this.btAtualizaVeiculo);
            this.Controls.Add(this.btDeletaMulta);
            this.Controls.Add(this.btAtualizaMulta);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btCadastroMulta);
            this.Controls.Add(this.btCadastroVeiculo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btCadastroMulta;
        private System.Windows.Forms.Button btCadastroVeiculo;
        private System.Windows.Forms.Button btAtualizaMulta;
        private System.Windows.Forms.Button btDeletaMulta;
        private System.Windows.Forms.Button btAtualizaVeiculo;
        private System.Windows.Forms.Button btDeletaVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

