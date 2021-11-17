
namespace ProjAtendimento
{
    partial class AtendimentoForm
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblGuiche = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.btnChamar = new System.Windows.Forms.Button();
            this.listAtendimentos = new System.Windows.Forms.ListBox();
            this.listSenhas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 16);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(204, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblGuiche
            // 
            this.lblGuiche.AutoSize = true;
            this.lblGuiche.Location = new System.Drawing.Point(347, 19);
            this.lblGuiche.Name = "lblGuiche";
            this.lblGuiche.Size = new System.Drawing.Size(47, 15);
            this.lblGuiche.TabIndex = 1;
            this.lblGuiche.Text = "Guiche:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(400, 16);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(70, 23);
            this.txtGuiche.TabIndex = 2;
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(476, 15);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 3;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // listAtendimentos
            // 
            this.listAtendimentos.FormattingEnabled = true;
            this.listAtendimentos.ItemHeight = 15;
            this.listAtendimentos.Location = new System.Drawing.Point(347, 45);
            this.listAtendimentos.Name = "listAtendimentos";
            this.listAtendimentos.Size = new System.Drawing.Size(204, 139);
            this.listAtendimentos.TabIndex = 5;
            // 
            // listSenhas
            // 
            this.listSenhas.FormattingEnabled = true;
            this.listSenhas.ItemHeight = 15;
            this.listSenhas.Location = new System.Drawing.Point(12, 45);
            this.listSenhas.Name = "listSenhas";
            this.listSenhas.Size = new System.Drawing.Size(204, 139);
            this.listSenhas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qtde. guichês";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(238, 119);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 23);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtd.Location = new System.Drawing.Point(262, 79);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(32, 37);
            this.lblQtd.TabIndex = 9;
            this.lblQtd.Text = "0";
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Location = new System.Drawing.Point(12, 190);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(204, 23);
            this.btnListarSenhas.TabIndex = 10;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Location = new System.Drawing.Point(347, 190);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(204, 23);
            this.btnListarAtendimentos.TabIndex = 11;
            this.btnListarAtendimentos.Text = "Listar Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            this.btnListarAtendimentos.Click += new System.EventHandler(this.btnListarAtendimentos_Click);
            // 
            // AtendimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 224);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSenhas);
            this.Controls.Add(this.listAtendimentos);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.lblGuiche);
            this.Controls.Add(this.btnGerar);
            this.Name = "AtendimentoForm";
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.AtendimentoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblGuiche;
        private System.Windows.Forms.TextBox txtGuiche;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.ListBox listAtendimentos;
        private System.Windows.Forms.ListBox listSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Button btnListarAtendimentos;
    }
}

