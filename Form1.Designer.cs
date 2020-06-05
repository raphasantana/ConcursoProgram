namespace Calendario2
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Filter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Scheduling = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartRevision = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fechar = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(135, 12);
            this.monthCalendar1.MaxSelectionCount = 60;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.Filter);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.Scheduling);
            this.guna2Panel1.Location = new System.Drawing.Point(1, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(201, 402);
            this.guna2Panel1.TabIndex = 3;
            // 
            // Filter
            // 
            this.Filter.CheckedState.Parent = this.Filter;
            this.Filter.CustomImages.Parent = this.Filter;
            this.Filter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Filter.ForeColor = System.Drawing.Color.White;
            this.Filter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Filter.HoverState.Parent = this.Filter;
            this.Filter.Image = global::Calendario2.Properties.Resources.filter;
            this.Filter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Filter.ImageSize = new System.Drawing.Size(25, 25);
            this.Filter.Location = new System.Drawing.Point(0, 198);
            this.Filter.Name = "Filter";
            this.Filter.ShadowDecoration.Parent = this.Filter;
            this.Filter.Size = new System.Drawing.Size(201, 57);
            this.Filter.TabIndex = 5;
            this.Filter.Text = "Filtrar";
            this.Filter.Click += new System.EventHandler(this.Filter_Click_1);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2Panel2.Location = new System.Drawing.Point(207, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(200, 100);
            this.guna2Panel2.TabIndex = 4;
            // 
            // Scheduling
            // 
            this.Scheduling.CheckedState.Parent = this.Scheduling;
            this.Scheduling.CustomImages.Parent = this.Scheduling;
            this.Scheduling.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Scheduling.ForeColor = System.Drawing.Color.White;
            this.Scheduling.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Scheduling.HoverState.Parent = this.Scheduling;
            this.Scheduling.Image = global::Calendario2.Properties.Resources.icon;
            this.Scheduling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Scheduling.ImageSize = new System.Drawing.Size(25, 25);
            this.Scheduling.Location = new System.Drawing.Point(0, 135);
            this.Scheduling.Name = "Scheduling";
            this.Scheduling.ShadowDecoration.Parent = this.Scheduling;
            this.Scheduling.Size = new System.Drawing.Size(201, 57);
            this.Scheduling.TabIndex = 2;
            this.Scheduling.Text = "Inserir Agendamento";
            this.Scheduling.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(202, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 188);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.StartRevision);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Fechar);
            this.panel2.Location = new System.Drawing.Point(202, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 216);
            this.panel2.TabIndex = 5;
            // 
            // StartRevision
            // 
            this.StartRevision.CheckedState.Parent = this.StartRevision;
            this.StartRevision.CustomImages.Parent = this.StartRevision;
            this.StartRevision.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartRevision.ForeColor = System.Drawing.Color.White;
            this.StartRevision.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.StartRevision.HoverState.Parent = this.StartRevision;
            this.StartRevision.Image = global::Calendario2.Properties.Resources.starred_list_on_paper;
            this.StartRevision.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StartRevision.ImageSize = new System.Drawing.Size(27, 27);
            this.StartRevision.Location = new System.Drawing.Point(6, 173);
            this.StartRevision.Name = "StartRevision";
            this.StartRevision.ShadowDecoration.Parent = this.StartRevision;
            this.StartRevision.Size = new System.Drawing.Size(261, 30);
            this.StartRevision.TabIndex = 6;
            this.StartRevision.Text = "Começar Revisão do Dia";
            this.StartRevision.Click += new System.EventHandler(this.StartRevision_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 159);
            this.dataGridView1.TabIndex = 7;
            // 
            // Fechar
            // 
            this.Fechar.CheckedState.Parent = this.Fechar;
            this.Fechar.CustomImages.Parent = this.Fechar;
            this.Fechar.FillColor = System.Drawing.Color.Red;
            this.Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Fechar.ForeColor = System.Drawing.Color.White;
            this.Fechar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Fechar.HoverState.Parent = this.Fechar;
            this.Fechar.Image = global::Calendario2.Properties.Resources.Fechar;
            this.Fechar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Fechar.ImageSize = new System.Drawing.Size(25, 25);
            this.Fechar.Location = new System.Drawing.Point(365, 173);
            this.Fechar.Name = "Fechar";
            this.Fechar.ShadowDecoration.Parent = this.Fechar;
            this.Fechar.Size = new System.Drawing.Size(121, 30);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "Fechar";
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Guna.UI2.WinForms.Guna2Button Scheduling;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button Filter;
        private Guna.UI2.WinForms.Guna2Button Fechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button StartRevision;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

