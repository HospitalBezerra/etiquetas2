namespace etiquetas2
{
	partial class TSCPrint
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNomePaciente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumeroProntuario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNomeMae = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDataNascimento = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(83, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(210, 53);
			this.button1.TabIndex = 5;
			this.button1.Text = "Imprimir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(45, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Impressões de Pulseiras - Exemplo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nome do Paciente:";
			// 
			// txtNomePaciente
			// 
			this.txtNomePaciente.Location = new System.Drawing.Point(131, 55);
			this.txtNomePaciente.Name = "txtNomePaciente";
			this.txtNomePaciente.Size = new System.Drawing.Size(240, 20);
			this.txtNomePaciente.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Número do Prontuário:";
			// 
			// txtNumeroProntuario
			// 
			this.txtNumeroProntuario.Location = new System.Drawing.Point(131, 91);
			this.txtNumeroProntuario.Name = "txtNumeroProntuario";
			this.txtNumeroProntuario.Size = new System.Drawing.Size(100, 20);
			this.txtNumeroProntuario.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Nome da Mãe:";
			// 
			// txtNomeMae
			// 
			this.txtNomeMae.Location = new System.Drawing.Point(131, 123);
			this.txtNomeMae.Name = "txtNomeMae";
			this.txtNomeMae.Size = new System.Drawing.Size(100, 20);
			this.txtNomeMae.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 161);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Data de nascimento:";
			// 
			// txtDataNascimento
			// 
			this.txtDataNascimento.Location = new System.Drawing.Point(131, 154);
			this.txtDataNascimento.Name = "txtDataNascimento";
			this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
			this.txtDataNascimento.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.LightGray;
			this.label6.Location = new System.Drawing.Point(90, 234);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(215, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Obs: O nome da impressora deve ser \"TSC\"";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(144, 198);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Calibrar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// TSCPrint
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 353);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDataNascimento);
			this.Controls.Add(this.txtNomeMae);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNumeroProntuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNomePaciente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "TSCPrint";
			this.Text = "Impressões de Pulseiras";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNomePaciente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNumeroProntuario;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNomeMae;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDataNascimento;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
	}
}

