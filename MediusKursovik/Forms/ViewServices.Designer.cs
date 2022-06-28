namespace MediusKursovik.Forms
{
    partial class ViewServices
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
            this.logotip = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchServ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearchDirec = new System.Windows.Forms.ComboBox();
            this.buttonReturnMain = new System.Windows.Forms.Button();
            this.comboBoxFiltrCoast = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logotip
            // 
            this.logotip.BackColor = System.Drawing.Color.Transparent;
            this.logotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logotip.Image = global::MediusKursovik.Properties.Resources.Icon;
            this.logotip.Location = new System.Drawing.Point(12, 69);
            this.logotip.Name = "logotip";
            this.logotip.Size = new System.Drawing.Size(226, 95);
            this.logotip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logotip.TabIndex = 5;
            this.logotip.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(362, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 497);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Номер услуги";
            this.Column1.Name = "Column1";
            this.Column1.Width = 102;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Услуга";
            this.Column2.Name = "Column2";
            this.Column2.Width = 68;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Стоимость";
            this.Column3.Name = "Column3";
            this.Column3.Width = 87;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Направление";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Специалист";
            this.Column5.Name = "Column5";
            this.Column5.Width = 92;
            // 
            // textBoxSearchServ
            // 
            this.textBoxSearchServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.textBoxSearchServ.Location = new System.Drawing.Point(12, 244);
            this.textBoxSearchServ.Name = "textBoxSearchServ";
            this.textBoxSearchServ.Size = new System.Drawing.Size(305, 31);
            this.textBoxSearchServ.TabIndex = 7;
            this.textBoxSearchServ.TextChanged += new System.EventHandler(this.textBoxSearchServ_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Найти услугу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Найти по \r\nнаправлению";
            // 
            // comboBoxSearchDirec
            // 
            this.comboBoxSearchDirec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchDirec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.comboBoxSearchDirec.FormattingEnabled = true;
            this.comboBoxSearchDirec.Location = new System.Drawing.Point(17, 365);
            this.comboBoxSearchDirec.Name = "comboBoxSearchDirec";
            this.comboBoxSearchDirec.Size = new System.Drawing.Size(300, 33);
            this.comboBoxSearchDirec.TabIndex = 10;
            this.comboBoxSearchDirec.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchDirec_SelectedIndexChanged);
            // 
            // buttonReturnMain
            // 
            this.buttonReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonReturnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturnMain.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonReturnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReturnMain.Location = new System.Drawing.Point(17, 583);
            this.buttonReturnMain.Name = "buttonReturnMain";
            this.buttonReturnMain.Size = new System.Drawing.Size(171, 69);
            this.buttonReturnMain.TabIndex = 22;
            this.buttonReturnMain.Text = "Вернуться на главную";
            this.buttonReturnMain.UseVisualStyleBackColor = false;
            this.buttonReturnMain.Click += new System.EventHandler(this.buttonReturnMain_Click);
            // 
            // comboBoxFiltrCoast
            // 
            this.comboBoxFiltrCoast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrCoast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFiltrCoast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.comboBoxFiltrCoast.FormattingEnabled = true;
            this.comboBoxFiltrCoast.Items.AddRange(new object[] {
            "по убыванию",
            "по возрастанию"});
            this.comboBoxFiltrCoast.Location = new System.Drawing.Point(17, 478);
            this.comboBoxFiltrCoast.Name = "comboBoxFiltrCoast";
            this.comboBoxFiltrCoast.Size = new System.Drawing.Size(300, 33);
            this.comboBoxFiltrCoast.TabIndex = 24;
            this.comboBoxFiltrCoast.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltrCoast_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Фильтр по стоимости";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelDate.Location = new System.Drawing.Point(979, 83);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(62, 25);
            this.labelDate.TabIndex = 43;
            this.labelDate.Text = "Дата";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelTime.Location = new System.Drawing.Point(1012, 108);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(76, 25);
            this.labelTime.TabIndex = 44;
            this.labelTime.Text = "Время";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(480, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 36);
            this.label4.TabIndex = 45;
            this.label4.Text = "Услуги поликлиники Медиус";
            // 
            // ViewServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 757);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFiltrCoast);
            this.Controls.Add(this.buttonReturnMain);
            this.Controls.Add(this.comboBoxSearchDirec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchServ);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logotip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ViewServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ViewServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logotip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBoxSearchServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchDirec;
        private System.Windows.Forms.Button buttonReturnMain;
        private System.Windows.Forms.ComboBox comboBoxFiltrCoast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}