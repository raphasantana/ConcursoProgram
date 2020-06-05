namespace Calendario2
{
    partial class OpenDocuments
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
            this.OpenDoc = new Guna.UI2.WinForms.Guna2Button();
            this.Next = new Guna.UI2.WinForms.Guna2Button();
            this.Previous = new Guna.UI2.WinForms.Guna2Button();
            this.Disciplinabox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Disciplina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Arquivobox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TempoRevisaobox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Concluded = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Categoriabox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Revisionbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cronometro = new System.Windows.Forms.Label();
            this.StartTime = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // OpenDoc
            // 
            this.OpenDoc.CheckedState.Parent = this.OpenDoc;
            this.OpenDoc.CustomImages.Parent = this.OpenDoc;
            this.OpenDoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenDoc.ForeColor = System.Drawing.Color.White;
            this.OpenDoc.HoverState.Parent = this.OpenDoc;
            this.OpenDoc.Location = new System.Drawing.Point(12, 327);
            this.OpenDoc.Name = "OpenDoc";
            this.OpenDoc.ShadowDecoration.Parent = this.OpenDoc;
            this.OpenDoc.Size = new System.Drawing.Size(180, 45);
            this.OpenDoc.TabIndex = 0;
            this.OpenDoc.Text = "Abrir Documento";
            this.OpenDoc.Click += new System.EventHandler(this.AbrirDocumento_Click);
            // 
            // Next
            // 
            this.Next.CheckedState.Parent = this.Next;
            this.Next.CustomImages.Parent = this.Next;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.HoverState.Parent = this.Next;
            this.Next.Location = new System.Drawing.Point(486, 249);
            this.Next.Name = "Next";
            this.Next.ShadowDecoration.Parent = this.Next;
            this.Next.Size = new System.Drawing.Size(49, 45);
            this.Next.TabIndex = 1;
            this.Next.Text = ">";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.CheckedState.Parent = this.Previous;
            this.Previous.CustomImages.Parent = this.Previous;
            this.Previous.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.Previous.ForeColor = System.Drawing.Color.White;
            this.Previous.HoverState.Parent = this.Previous;
            this.Previous.Location = new System.Drawing.Point(12, 249);
            this.Previous.Name = "Previous";
            this.Previous.ShadowDecoration.Parent = this.Previous;
            this.Previous.Size = new System.Drawing.Size(49, 45);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "<";
            this.Previous.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Disciplinabox
            // 
            this.Disciplinabox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Disciplinabox.DefaultText = "";
            this.Disciplinabox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Disciplinabox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Disciplinabox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Disciplinabox.DisabledState.Parent = this.Disciplinabox;
            this.Disciplinabox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Disciplinabox.Enabled = false;
            this.Disciplinabox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Disciplinabox.FocusedState.Parent = this.Disciplinabox;
            this.Disciplinabox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Disciplinabox.HoverState.Parent = this.Disciplinabox;
            this.Disciplinabox.Location = new System.Drawing.Point(97, 82);
            this.Disciplinabox.Name = "Disciplinabox";
            this.Disciplinabox.PasswordChar = '\0';
            this.Disciplinabox.PlaceholderText = "";
            this.Disciplinabox.SelectedText = "";
            this.Disciplinabox.ShadowDecoration.Parent = this.Disciplinabox;
            this.Disciplinabox.Size = new System.Drawing.Size(160, 27);
            this.Disciplinabox.TabIndex = 3;
            // 
            // Disciplina
            // 
            this.Disciplina.AutoSize = true;
            this.Disciplina.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disciplina.Location = new System.Drawing.Point(8, 82);
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.Size = new System.Drawing.Size(83, 21);
            this.Disciplina.TabIndex = 4;
            this.Disciplina.Text = "Disciplina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arquivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Revisar Hoje";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Arquivobox
            // 
            this.Arquivobox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Arquivobox.DefaultText = "";
            this.Arquivobox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Arquivobox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Arquivobox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Arquivobox.DisabledState.Parent = this.Arquivobox;
            this.Arquivobox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Arquivobox.Enabled = false;
            this.Arquivobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Arquivobox.FocusedState.Parent = this.Arquivobox;
            this.Arquivobox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Arquivobox.HoverState.Parent = this.Arquivobox;
            this.Arquivobox.Location = new System.Drawing.Point(27, 145);
            this.Arquivobox.Name = "Arquivobox";
            this.Arquivobox.PasswordChar = '\0';
            this.Arquivobox.PlaceholderText = "";
            this.Arquivobox.SelectedText = "";
            this.Arquivobox.ShadowDecoration.Parent = this.Arquivobox;
            this.Arquivobox.Size = new System.Drawing.Size(495, 27);
            this.Arquivobox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tempo de Revisão:";
            // 
            // TempoRevisaobox
            // 
            this.TempoRevisaobox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TempoRevisaobox.DefaultText = "";
            this.TempoRevisaobox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TempoRevisaobox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TempoRevisaobox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TempoRevisaobox.DisabledState.Parent = this.TempoRevisaobox;
            this.TempoRevisaobox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TempoRevisaobox.Enabled = false;
            this.TempoRevisaobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TempoRevisaobox.FocusedState.Parent = this.TempoRevisaobox;
            this.TempoRevisaobox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TempoRevisaobox.HoverState.Parent = this.TempoRevisaobox;
            this.TempoRevisaobox.Location = new System.Drawing.Point(168, 205);
            this.TempoRevisaobox.Name = "TempoRevisaobox";
            this.TempoRevisaobox.PasswordChar = '\0';
            this.TempoRevisaobox.PlaceholderText = "";
            this.TempoRevisaobox.SelectedText = "";
            this.TempoRevisaobox.ShadowDecoration.Parent = this.TempoRevisaobox;
            this.TempoRevisaobox.Size = new System.Drawing.Size(40, 27);
            this.TempoRevisaobox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "min";
            // 
            // Concluded
            // 
            this.Concluded.CheckedState.Parent = this.Concluded;
            this.Concluded.CustomImages.Parent = this.Concluded;
            this.Concluded.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Concluded.ForeColor = System.Drawing.Color.White;
            this.Concluded.HoverState.Parent = this.Concluded;
            this.Concluded.Location = new System.Drawing.Point(352, 327);
            this.Concluded.Name = "Concluded";
            this.Concluded.ShadowDecoration.Parent = this.Concluded;
            this.Concluded.Size = new System.Drawing.Size(180, 45);
            this.Concluded.TabIndex = 11;
            this.Concluded.Text = "Marcar como Concluido";
            this.Concluded.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Categoria:";
            // 
            // Categoriabox
            // 
            this.Categoriabox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Categoriabox.DefaultText = "";
            this.Categoriabox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Categoriabox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Categoriabox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Categoriabox.DisabledState.Parent = this.Categoriabox;
            this.Categoriabox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Categoriabox.Enabled = false;
            this.Categoriabox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Categoriabox.FocusedState.Parent = this.Categoriabox;
            this.Categoriabox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Categoriabox.HoverState.Parent = this.Categoriabox;
            this.Categoriabox.Location = new System.Drawing.Point(352, 82);
            this.Categoriabox.Name = "Categoriabox";
            this.Categoriabox.PasswordChar = '\0';
            this.Categoriabox.PlaceholderText = "";
            this.Categoriabox.SelectedText = "";
            this.Categoriabox.ShadowDecoration.Parent = this.Categoriabox;
            this.Categoriabox.Size = new System.Drawing.Size(160, 27);
            this.Categoriabox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Revisões:";
            // 
            // Revisionbox
            // 
            this.Revisionbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Revisionbox.DefaultText = "";
            this.Revisionbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Revisionbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Revisionbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Revisionbox.DisabledState.Parent = this.Revisionbox;
            this.Revisionbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Revisionbox.Enabled = false;
            this.Revisionbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Revisionbox.FocusedState.Parent = this.Revisionbox;
            this.Revisionbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Revisionbox.HoverState.Parent = this.Revisionbox;
            this.Revisionbox.Location = new System.Drawing.Point(401, 205);
            this.Revisionbox.Name = "Revisionbox";
            this.Revisionbox.PasswordChar = '\0';
            this.Revisionbox.PlaceholderText = "";
            this.Revisionbox.SelectedText = "";
            this.Revisionbox.ShadowDecoration.Parent = this.Revisionbox;
            this.Revisionbox.Size = new System.Drawing.Size(40, 27);
            this.Revisionbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "vzs";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cronometro
            // 
            this.Cronometro.AutoSize = true;
            this.Cronometro.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cronometro.Location = new System.Drawing.Point(233, 261);
            this.Cronometro.Name = "Cronometro";
            this.Cronometro.Size = new System.Drawing.Size(79, 33);
            this.Cronometro.TabIndex = 17;
            this.Cronometro.Text = "00:00";
            // 
            // StartTime
            // 
            this.StartTime.CheckedState.Parent = this.StartTime;
            this.StartTime.CustomImages.Parent = this.StartTime;
            this.StartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartTime.ForeColor = System.Drawing.Color.White;
            this.StartTime.HoverState.Parent = this.StartTime;
            this.StartTime.Location = new System.Drawing.Point(218, 327);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShadowDecoration.Parent = this.StartTime;
            this.StartTime.Size = new System.Drawing.Size(109, 45);
            this.StartTime.TabIndex = 18;
            this.StartTime.Text = "Iniciar tempo";
            this.StartTime.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Back
            // 
            this.Back.CheckedState.Parent = this.Back;
            this.Back.CustomImages.Parent = this.Back;
            this.Back.FillColor = System.Drawing.Color.White;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.HoverState.Parent = this.Back;
            this.Back.Image = global::Calendario2.Properties.Resources.voltar2_removebg_preview2;
            this.Back.Location = new System.Drawing.Point(449, 12);
            this.Back.Name = "Back";
            this.Back.ShadowDecoration.Parent = this.Back;
            this.Back.Size = new System.Drawing.Size(73, 29);
            this.Back.TabIndex = 19;
            this.Back.Text = "Voltar";
            this.Back.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // OpenDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(547, 394);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.Cronometro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Revisionbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Arquivobox);
            this.Controls.Add(this.Categoriabox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Concluded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TempoRevisaobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Disciplina);
            this.Controls.Add(this.Disciplinabox);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.OpenDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenDocuments";
            this.Load += new System.EventHandler(this.OpenDocuments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button OpenDoc;
        private Guna.UI2.WinForms.Guna2Button Next;
        private Guna.UI2.WinForms.Guna2Button Previous;
        private Guna.UI2.WinForms.Guna2TextBox Disciplinabox;
        private System.Windows.Forms.Label Disciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Arquivobox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TempoRevisaobox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button Concluded;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Categoriabox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox Revisionbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Cronometro;
        private Guna.UI2.WinForms.Guna2Button StartTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button Back;
    }
}