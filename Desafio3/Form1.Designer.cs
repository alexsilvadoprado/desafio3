namespace Desafio3
{
    partial class frmInvertChar
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
            this.lblFraseEntrada = new System.Windows.Forms.Label();
            this.txbFraseEntrada = new System.Windows.Forms.TextBox();
            this.lblFraseSaida = new System.Windows.Forms.Label();
            this.txbFraseSaida = new System.Windows.Forms.TextBox();
            this.btnInverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFraseEntrada
            // 
            this.lblFraseEntrada.AutoSize = true;
            this.lblFraseEntrada.Location = new System.Drawing.Point(13, 13);
            this.lblFraseEntrada.Name = "lblFraseEntrada";
            this.lblFraseEntrada.Size = new System.Drawing.Size(107, 13);
            this.lblFraseEntrada.TabIndex = 0;
            this.lblFraseEntrada.Text = "Entre com uma frase:";
            // 
            // txbFraseEntrada
            // 
            this.txbFraseEntrada.Location = new System.Drawing.Point(126, 10);
            this.txbFraseEntrada.Name = "txbFraseEntrada";
            this.txbFraseEntrada.Size = new System.Drawing.Size(442, 20);
            this.txbFraseEntrada.TabIndex = 1;
            this.txbFraseEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbFraseEntrada_KeyDown);
            // 
            // lblFraseSaida
            // 
            this.lblFraseSaida.AutoSize = true;
            this.lblFraseSaida.Location = new System.Drawing.Point(13, 48);
            this.lblFraseSaida.Name = "lblFraseSaida";
            this.lblFraseSaida.Size = new System.Drawing.Size(81, 13);
            this.lblFraseSaida.TabIndex = 2;
            this.lblFraseSaida.Text = "Frase de saída:";
            // 
            // txbFraseSaida
            // 
            this.txbFraseSaida.Location = new System.Drawing.Point(126, 45);
            this.txbFraseSaida.Name = "txbFraseSaida";
            this.txbFraseSaida.ReadOnly = true;
            this.txbFraseSaida.Size = new System.Drawing.Size(442, 20);
            this.txbFraseSaida.TabIndex = 3;
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(248, 81);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(75, 23);
            this.btnInverter.TabIndex = 4;
            this.btnInverter.Text = "Inverter";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // frmInvertChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 113);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.txbFraseSaida);
            this.Controls.Add(this.lblFraseSaida);
            this.Controls.Add(this.txbFraseEntrada);
            this.Controls.Add(this.lblFraseEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvertChar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inverter Caracteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFraseEntrada;
        private System.Windows.Forms.TextBox txbFraseEntrada;
        private System.Windows.Forms.Label lblFraseSaida;
        private System.Windows.Forms.TextBox txbFraseSaida;
        private System.Windows.Forms.Button btnInverter;
    }
}

