namespace AulaWF01Arquivos
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
            this.lb_criar = new System.Windows.Forms.Label();
            this.txt_criar = new System.Windows.Forms.TextBox();
            this.txt_del = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_criar
            // 
            this.lb_criar.AutoSize = true;
            this.lb_criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_criar.Location = new System.Drawing.Point(32, 28);
            this.lb_criar.Name = "lb_criar";
            this.lb_criar.Size = new System.Drawing.Size(359, 32);
            this.lb_criar.TabIndex = 0;
            this.lb_criar.Text = "Nome da pasta a ser criada";
            this.lb_criar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_criar
            // 
            this.txt_criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_criar.Location = new System.Drawing.Point(38, 63);
            this.txt_criar.Name = "txt_criar";
            this.txt_criar.Size = new System.Drawing.Size(386, 34);
            this.txt_criar.TabIndex = 1;
            // 
            // txt_del
            // 
            this.txt_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_del.Location = new System.Drawing.Point(38, 156);
            this.txt_del.Name = "txt_del";
            this.txt_del.Size = new System.Drawing.Size(386, 34);
            this.txt_del.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da pasta a ser deletada";
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(448, 59);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(158, 38);
            this.btn_criar.TabIndex = 4;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(448, 152);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(158, 38);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "Deletar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(618, 249);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.txt_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_criar);
            this.Controls.Add(this.lb_criar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_criar;
        private System.Windows.Forms.TextBox txt_criar;
        private System.Windows.Forms.TextBox txt_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_del;
    }
}

