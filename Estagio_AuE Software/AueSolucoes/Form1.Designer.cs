namespace AueSolucoes
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.checkBoxMasculino = new System.Windows.Forms.CheckBox();
            this.checkBoxFeminino = new System.Windows.Forms.CheckBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.buttonInclui = new System.Windows.Forms.Button();
            this.buttonAltera = new System.Windows.Forms.Button();
            this.buttonExclui = new System.Windows.Forms.Button();
            this.listBoxRelatorio = new System.Windows.Forms.ListBox();
            this.buttonContato = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 186);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(356, 48);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(417, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(349, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(356, 93);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 3;
            this.labelSexo.Text = "Sexo";
            this.labelSexo.Click += new System.EventHandler(this.labelSexo_Click);
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.AutoSize = true;
            this.checkBoxMasculino.Location = new System.Drawing.Point(422, 94);
            this.checkBoxMasculino.Name = "checkBoxMasculino";
            this.checkBoxMasculino.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMasculino.TabIndex = 4;
            this.checkBoxMasculino.Text = "Masculino";
            this.checkBoxMasculino.UseVisualStyleBackColor = true;
            // 
            // checkBoxFeminino
            // 
            this.checkBoxFeminino.AutoSize = true;
            this.checkBoxFeminino.Location = new System.Drawing.Point(523, 93);
            this.checkBoxFeminino.Name = "checkBoxFeminino";
            this.checkBoxFeminino.Size = new System.Drawing.Size(68, 17);
            this.checkBoxFeminino.TabIndex = 5;
            this.checkBoxFeminino.Text = "Feminino";
            this.checkBoxFeminino.UseVisualStyleBackColor = true;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(356, 172);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 6;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(417, 165);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(349, 20);
            this.textBoxCidade.TabIndex = 7;
            // 
            // buttonInclui
            // 
            this.buttonInclui.Location = new System.Drawing.Point(364, 226);
            this.buttonInclui.Name = "buttonInclui";
            this.buttonInclui.Size = new System.Drawing.Size(75, 23);
            this.buttonInclui.TabIndex = 8;
            this.buttonInclui.Text = "Inclui";
            this.buttonInclui.UseVisualStyleBackColor = true;
            this.buttonInclui.Click += new System.EventHandler(this.buttonInclui_Click);
            // 
            // buttonAltera
            // 
            this.buttonAltera.Location = new System.Drawing.Point(469, 226);
            this.buttonAltera.Name = "buttonAltera";
            this.buttonAltera.Size = new System.Drawing.Size(75, 23);
            this.buttonAltera.TabIndex = 9;
            this.buttonAltera.Text = "Altera";
            this.buttonAltera.UseVisualStyleBackColor = true;
            this.buttonAltera.Click += new System.EventHandler(this.buttonAltera_Click);
            // 
            // buttonExclui
            // 
            this.buttonExclui.Location = new System.Drawing.Point(571, 226);
            this.buttonExclui.Name = "buttonExclui";
            this.buttonExclui.Size = new System.Drawing.Size(75, 23);
            this.buttonExclui.TabIndex = 10;
            this.buttonExclui.Text = "Exclui";
            this.buttonExclui.UseVisualStyleBackColor = true;
            this.buttonExclui.Click += new System.EventHandler(this.buttonExclui_Click);
            // 
            // listBoxRelatorio
            // 
            this.listBoxRelatorio.FormattingEnabled = true;
            this.listBoxRelatorio.Location = new System.Drawing.Point(37, 279);
            this.listBoxRelatorio.Name = "listBoxRelatorio";
            this.listBoxRelatorio.Size = new System.Drawing.Size(728, 108);
            this.listBoxRelatorio.TabIndex = 11;
            // 
            // buttonContato
            // 
            this.buttonContato.Location = new System.Drawing.Point(34, 406);
            this.buttonContato.Name = "buttonContato";
            this.buttonContato.Size = new System.Drawing.Size(435, 28);
            this.buttonContato.TabIndex = 12;
            this.buttonContato.Text = "Contar No de contatos por cidade";
            this.buttonContato.UseVisualStyleBackColor = true;
            this.buttonContato.Click += new System.EventHandler(this.buttonContato_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(422, 129);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(249, 20);
            this.dateTime.TabIndex = 13;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(359, 135);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 14;
            this.labelData.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.buttonContato);
            this.Controls.Add(this.listBoxRelatorio);
            this.Controls.Add(this.buttonExclui);
            this.Controls.Add(this.buttonAltera);
            this.Controls.Add(this.buttonInclui);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.checkBoxFeminino);
            this.Controls.Add(this.checkBoxMasculino);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.CheckBox checkBoxMasculino;
        private System.Windows.Forms.CheckBox checkBoxFeminino;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Button buttonInclui;
        private System.Windows.Forms.Button buttonAltera;
        private System.Windows.Forms.Button buttonExclui;
        private System.Windows.Forms.ListBox listBoxRelatorio;
        private System.Windows.Forms.Button buttonContato;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label labelData;
    }
}

