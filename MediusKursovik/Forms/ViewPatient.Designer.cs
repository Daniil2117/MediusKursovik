namespace MediusKursovik.Forms
{
    partial class ViewPatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.logotip = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDelPatient = new System.Windows.Forms.Button();
            this.buttonViewZapis = new System.Windows.Forms.Button();
            this.buttonBackMenu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAddReception = new System.Windows.Forms.Button();
            this.buttonNotExistRec = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCard = new System.Windows.Forms.Button();
            this.buttonPatDiagn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.logotip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 133);
            this.panel1.TabIndex = 10;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTime.Location = new System.Drawing.Point(993, 52);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(96, 31);
            this.labelTime.TabIndex = 46;
            this.labelTime.Text = "Время";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelDate.Location = new System.Drawing.Point(940, 14);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(77, 31);
            this.labelDate.TabIndex = 45;
            this.labelDate.Text = "Дата";
            // 
            // logotip
            // 
            this.logotip.BackColor = System.Drawing.Color.Transparent;
            this.logotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logotip.Image = global::MediusKursovik.Properties.Resources.Icon;
            this.logotip.Location = new System.Drawing.Point(12, 14);
            this.logotip.Name = "logotip";
            this.logotip.Size = new System.Drawing.Size(226, 95);
            this.logotip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logotip.TabIndex = 4;
            this.logotip.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(422, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 62);
            this.label2.TabIndex = 5;
            this.label2.Text = " Поликлиника \"Медиус\"";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(337, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 484);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Номер пациента";
            this.Column9.Name = "Column9";
            this.Column9.Width = 106;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.Width = 81;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.Width = 54;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.Width = 79;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Дата рождения";
            this.Column4.Name = "Column4";
            this.Column4.Width = 102;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Пол";
            this.Column5.Name = "Column5";
            this.Column5.Width = 52;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Телефон";
            this.Column6.Name = "Column6";
            this.Column6.Width = 77;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Адрес";
            this.Column7.Name = "Column7";
            this.Column7.Width = 63;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Паспорт";
            this.Column8.Name = "Column8";
            this.Column8.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(531, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Список пациентов";
            // 
            // textBoxSearchPatient
            // 
            this.textBoxSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.textBoxSearchPatient.Location = new System.Drawing.Point(12, 263);
            this.textBoxSearchPatient.Name = "textBoxSearchPatient";
            this.textBoxSearchPatient.Size = new System.Drawing.Size(305, 31);
            this.textBoxSearchPatient.TabIndex = 13;
            this.textBoxSearchPatient.TextChanged += new System.EventHandler(this.textBoxSearchPatient_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(65, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Найти пациента ";
            // 
            // buttonDelPatient
            // 
            this.buttonDelPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonDelPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelPatient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelPatient.Location = new System.Drawing.Point(77, 313);
            this.buttonDelPatient.Name = "buttonDelPatient";
            this.buttonDelPatient.Size = new System.Drawing.Size(160, 61);
            this.buttonDelPatient.TabIndex = 28;
            this.buttonDelPatient.Text = "Удалить пациента";
            this.buttonDelPatient.UseVisualStyleBackColor = false;
            this.buttonDelPatient.Click += new System.EventHandler(this.buttonDelPatient_Click);
            // 
            // buttonViewZapis
            // 
            this.buttonViewZapis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonViewZapis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewZapis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewZapis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewZapis.Location = new System.Drawing.Point(79, 465);
            this.buttonViewZapis.Name = "buttonViewZapis";
            this.buttonViewZapis.Size = new System.Drawing.Size(158, 63);
            this.buttonViewZapis.TabIndex = 29;
            this.buttonViewZapis.Text = "Просмотр заявок на прием";
            this.buttonViewZapis.UseVisualStyleBackColor = false;
            this.buttonViewZapis.Click += new System.EventHandler(this.buttonViewZapis_Click);
            // 
            // buttonBackMenu
            // 
            this.buttonBackMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonBackMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonBackMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackMenu.Location = new System.Drawing.Point(12, 634);
            this.buttonBackMenu.Name = "buttonBackMenu";
            this.buttonBackMenu.Size = new System.Drawing.Size(136, 72);
            this.buttonBackMenu.TabIndex = 36;
            this.buttonBackMenu.Text = "Выйти в меню";
            this.buttonBackMenu.UseVisualStyleBackColor = false;
            this.buttonBackMenu.Click += new System.EventHandler(this.buttonBackMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonAddReception
            // 
            this.buttonAddReception.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonAddReception.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddReception.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddReception.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddReception.Location = new System.Drawing.Point(77, 390);
            this.buttonAddReception.Name = "buttonAddReception";
            this.buttonAddReception.Size = new System.Drawing.Size(160, 58);
            this.buttonAddReception.TabIndex = 37;
            this.buttonAddReception.Text = "Добавить на прием";
            this.buttonAddReception.UseVisualStyleBackColor = false;
            this.buttonAddReception.Click += new System.EventHandler(this.buttonAddReception_Click);
            // 
            // buttonNotExistRec
            // 
            this.buttonNotExistRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonNotExistRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNotExistRec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNotExistRec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNotExistRec.Location = new System.Drawing.Point(77, 544);
            this.buttonNotExistRec.Name = "buttonNotExistRec";
            this.buttonNotExistRec.Size = new System.Drawing.Size(160, 60);
            this.buttonNotExistRec.TabIndex = 38;
            this.buttonNotExistRec.Text = "Не записанные пациенты";
            this.buttonNotExistRec.UseVisualStyleBackColor = false;
            this.buttonNotExistRec.Click += new System.EventHandler(this.buttonNotExistRec_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 139);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 60);
            this.buttonUpdate.TabIndex = 39;
            this.buttonUpdate.Text = "Обновить таблицу";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCard
            // 
            this.buttonCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCard.Location = new System.Drawing.Point(945, 139);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(160, 61);
            this.buttonCard.TabIndex = 40;
            this.buttonCard.Text = "Личная карточка";
            this.buttonCard.UseVisualStyleBackColor = false;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // buttonPatDiagn
            // 
            this.buttonPatDiagn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonPatDiagn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPatDiagn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPatDiagn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPatDiagn.Location = new System.Drawing.Point(204, 139);
            this.buttonPatDiagn.Name = "buttonPatDiagn";
            this.buttonPatDiagn.Size = new System.Drawing.Size(160, 60);
            this.buttonPatDiagn.TabIndex = 41;
            this.buttonPatDiagn.Text = "Пациенты с диагнозом";
            this.buttonPatDiagn.UseVisualStyleBackColor = false;
            this.buttonPatDiagn.Click += new System.EventHandler(this.buttonPatDiagn_Click);
            // 
            // ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1135, 718);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPatDiagn);
            this.Controls.Add(this.buttonCard);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNotExistRec);
            this.Controls.Add(this.buttonAddReception);
            this.Controls.Add(this.buttonBackMenu);
            this.Controls.Add(this.buttonViewZapis);
            this.Controls.Add(this.buttonDelPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ViewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ViewPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox logotip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDelPatient;
        private System.Windows.Forms.Button buttonViewZapis;
        private System.Windows.Forms.Button buttonBackMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonAddReception;
        private System.Windows.Forms.Button buttonNotExistRec;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCard;
        private System.Windows.Forms.Button buttonPatDiagn;
    }
}