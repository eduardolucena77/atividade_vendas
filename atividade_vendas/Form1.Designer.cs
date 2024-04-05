namespace atividade_vendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCLIENTE = new System.Windows.Forms.Label();
            this.labelFUNCIONARIO = new System.Windows.Forms.Label();
            this.buttonVENDA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelTOTAL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda:";
            // 
            // labelCLIENTE
            // 
            this.labelCLIENTE.AutoSize = true;
            this.labelCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCLIENTE.Location = new System.Drawing.Point(244, 105);
            this.labelCLIENTE.Name = "labelCLIENTE";
            this.labelCLIENTE.Size = new System.Drawing.Size(57, 18);
            this.labelCLIENTE.TabIndex = 1;
            this.labelCLIENTE.Text = "Cliente:";
            // 
            // labelFUNCIONARIO
            // 
            this.labelFUNCIONARIO.AutoSize = true;
            this.labelFUNCIONARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFUNCIONARIO.Location = new System.Drawing.Point(211, 149);
            this.labelFUNCIONARIO.Name = "labelFUNCIONARIO";
            this.labelFUNCIONARIO.Size = new System.Drawing.Size(90, 18);
            this.labelFUNCIONARIO.TabIndex = 2;
            this.labelFUNCIONARIO.Text = "Funcionário:";
            // 
            // buttonVENDA
            // 
            this.buttonVENDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVENDA.Location = new System.Drawing.Point(40, 12);
            this.buttonVENDA.Name = "buttonVENDA";
            this.buttonVENDA.Size = new System.Drawing.Size(551, 54);
            this.buttonVENDA.TabIndex = 3;
            this.buttonVENDA.Text = "Nova Venda";
            this.buttonVENDA.UseVisualStyleBackColor = true;
            this.buttonVENDA.Click += new System.EventHandler(this.buttonVENDA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 142);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 25);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 25);
            this.textBox2.TabIndex = 5;
            // 
            // labelTOTAL
            // 
            this.labelTOTAL.AutoSize = true;
            this.labelTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOTAL.Location = new System.Drawing.Point(42, 236);
            this.labelTOTAL.Name = "labelTOTAL";
            this.labelTOTAL.Size = new System.Drawing.Size(48, 20);
            this.labelTOTAL.TabIndex = 6;
            this.labelTOTAL.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(656, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTOTAL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonVENDA);
            this.Controls.Add(this.labelFUNCIONARIO);
            this.Controls.Add(this.labelCLIENTE);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCLIENTE;
        private System.Windows.Forms.Label labelFUNCIONARIO;
        private System.Windows.Forms.Button buttonVENDA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelTOTAL;
        private System.Windows.Forms.Label label5;
    }
}

