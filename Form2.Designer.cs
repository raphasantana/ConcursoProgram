namespace Calendario2
{
    partial class Adicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar));
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NomedaDisciplina = new System.Windows.Forms.TextBox();
            this.Arquivo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Revisao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Help = new Guna.UI2.WinForms.Guna2Button();
            this.Back = new Guna.UI2.WinForms.Guna2Button();
            this.OpenFile = new Guna.UI2.WinForms.Guna2Button();
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Categoria
            // 
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Items.AddRange(new object[] {
            "Português ",
            "Específicas"});
            this.Categoria.Location = new System.Drawing.Point(139, 162);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(121, 21);
            this.Categoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da Disciplina:";
            // 
            // NomedaDisciplina
            // 
            this.NomedaDisciplina.Location = new System.Drawing.Point(139, 51);
            this.NomedaDisciplina.Name = "NomedaDisciplina";
            this.NomedaDisciplina.Size = new System.Drawing.Size(100, 20);
            this.NomedaDisciplina.TabIndex = 4;
            // 
            // Arquivo
            // 
            this.Arquivo.Location = new System.Drawing.Point(139, 125);
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(100, 20);
            this.Arquivo.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(139, 87);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(128, 20);
            this.Data.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(27, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Qnt. vezes o tema foi revisado:";
            // 
            // Revisao
            // 
            this.Revisao.Location = new System.Drawing.Point(220, 202);
            this.Revisao.MaxLength = 1;
            this.Revisao.Name = "Revisao";
            this.Revisao.Size = new System.Drawing.Size(40, 20);
            this.Revisao.TabIndex = 12;
            this.Revisao.Text = "0";
            this.Revisao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Arquivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Categoria:";
            // 
            // Help
            // 
            this.Help.CheckedState.Parent = this.Help;
            this.Help.CustomImages.Parent = this.Help;
            this.Help.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Help.ForeColor = System.Drawing.Color.White;
            this.Help.HoverState.Parent = this.Help;
            this.Help.Image = global::Calendario2.Properties.Resources.Interrogação_removebg_preview;
            this.Help.Location = new System.Drawing.Point(12, 12);
            this.Help.Name = "Help";
            this.Help.ShadowDecoration.Parent = this.Help;
            this.Help.Size = new System.Drawing.Size(67, 28);
            this.Help.TabIndex = 20;
            this.Help.Text = "Ajuda";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Back
            // 
            this.Back.CheckedState.Parent = this.Back;
            this.Back.CustomImages.Parent = this.Back;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.HoverState.Parent = this.Back;
            this.Back.Image = global::Calendario2.Properties.Resources.voltar2_removebg_preview;
            this.Back.Location = new System.Drawing.Point(280, 12);
            this.Back.Name = "Back";
            this.Back.ShadowDecoration.Parent = this.Back;
            this.Back.Size = new System.Drawing.Size(76, 28);
            this.Back.TabIndex = 18;
            this.Back.Text = "Voltar";
            this.Back.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.CheckedState.Parent = this.OpenFile;
            this.OpenFile.CustomImages.Parent = this.OpenFile;
            this.OpenFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.HoverState.Parent = this.OpenFile;
            this.OpenFile.Image = global::Calendario2.Properties.Resources.File_removebg_preview1;
            this.OpenFile.Location = new System.Drawing.Point(247, 125);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.ShadowDecoration.Parent = this.OpenFile;
            this.OpenFile.Size = new System.Drawing.Size(109, 26);
            this.OpenFile.TabIndex = 17;
            this.OpenFile.Text = "Abrir Arquivo";
            this.OpenFile.Click += new System.EventHandler(this.AbrirArquivo_Click);
            // 
            // Save
            // 
            this.Save.CheckedState.Parent = this.Save;
            this.Save.CustomImages.Parent = this.Save;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.HoverState.Parent = this.Save;
            this.Save.Image = global::Calendario2.Properties.Resources.salvar5_removebg_preview;
            this.Save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Save.Location = new System.Drawing.Point(139, 241);
            this.Save.Name = "Save";
            this.Save.ShadowDecoration.Parent = this.Save;
            this.Save.Size = new System.Drawing.Size(104, 27);
            this.Save.TabIndex = 16;
            this.Save.Text = "Salvar";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(368, 280);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Revisao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Arquivo);
            this.Controls.Add(this.NomedaDisciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Estudo Realizado";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomedaDisciplina;
        private System.Windows.Forms.TextBox Arquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Revisao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Save;
        private Guna.UI2.WinForms.Guna2Button OpenFile;
        private Guna.UI2.WinForms.Guna2Button Back;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button Help;
    }
}