namespace MediusKursovik.Forms
{
    partial class MenuNavigation
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonViewPatient = new System.Windows.Forms.Button();
            this.buttonRecordClient = new System.Windows.Forms.Button();
            this.buttonViewSpecialist = new System.Windows.Forms.Button();
            this.buttonViewWorkShed = new System.Windows.Forms.Button();
            this.buttonViewReception = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1138, 132);
            this.panel1.TabIndex = 9;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTime.Location = new System.Drawing.Point(976, 52);
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
            this.labelDate.Location = new System.Drawing.Point(931, 14);
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
            this.label2.Location = new System.Drawing.Point(336, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 62);
            this.label2.TabIndex = 5;
            this.label2.Text = " Поликлиника \"Медиус\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(398, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Меню навигации";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonViewPatient
            // 
            this.buttonViewPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonViewPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewPatient.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonViewPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewPatient.Location = new System.Drawing.Point(71, 262);
            this.buttonViewPatient.Name = "buttonViewPatient";
            this.buttonViewPatient.Size = new System.Drawing.Size(226, 76);
            this.buttonViewPatient.TabIndex = 27;
            this.buttonViewPatient.Text = "Просмотр пациентов";
            this.buttonViewPatient.UseVisualStyleBackColor = false;
            this.buttonViewPatient.Click += new System.EventHandler(this.buttonViewPatient_Click);
            // 
            // buttonRecordClient
            // 
            this.buttonRecordClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonRecordClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecordClient.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonRecordClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRecordClient.Location = new System.Drawing.Point(71, 464);
            this.buttonRecordClient.Name = "buttonRecordClient";
            this.buttonRecordClient.Size = new System.Drawing.Size(226, 74);
            this.buttonRecordClient.TabIndex = 28;
            this.buttonRecordClient.Text = "Просмотр записей на прием";
            this.buttonRecordClient.UseVisualStyleBackColor = false;
            this.buttonRecordClient.Click += new System.EventHandler(this.buttonRecordClient_Click);
            // 
            // buttonViewSpecialist
            // 
            this.buttonViewSpecialist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonViewSpecialist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewSpecialist.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonViewSpecialist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewSpecialist.Location = new System.Drawing.Point(787, 459);
            this.buttonViewSpecialist.Name = "buttonViewSpecialist";
            this.buttonViewSpecialist.Size = new System.Drawing.Size(284, 78);
            this.buttonViewSpecialist.TabIndex = 29;
            this.buttonViewSpecialist.Text = "Просмотр списка персонала";
            this.buttonViewSpecialist.UseVisualStyleBackColor = false;
            this.buttonViewSpecialist.Click += new System.EventHandler(this.buttonViewSpecialist_Click);
            // 
            // buttonViewWorkShed
            // 
            this.buttonViewWorkShed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonViewWorkShed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewWorkShed.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonViewWorkShed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewWorkShed.Location = new System.Drawing.Point(787, 262);
            this.buttonViewWorkShed.Name = "buttonViewWorkShed";
            this.buttonViewWorkShed.Size = new System.Drawing.Size(284, 76);
            this.buttonViewWorkShed.TabIndex = 30;
            this.buttonViewWorkShed.Text = "Просмотр расписания персонала";
            this.buttonViewWorkShed.UseVisualStyleBackColor = false;
            this.buttonViewWorkShed.Click += new System.EventHandler(this.buttonViewWorkShed_Click);
            // 
            // buttonViewReception
            // 
            this.buttonViewReception.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonViewReception.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewReception.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonViewReception.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewReception.Location = new System.Drawing.Point(431, 351);
            this.buttonViewReception.Name = "buttonViewReception";
            this.buttonViewReception.Size = new System.Drawing.Size(273, 76);
            this.buttonViewReception.TabIndex = 31;
            this.buttonViewReception.Text = "Просмотр приема пациентов";
            this.buttonViewReception.UseVisualStyleBackColor = false;
            this.buttonViewReception.Click += new System.EventHandler(this.buttonViewReception_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(21, 608);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(131, 57);
            this.buttonBack.TabIndex = 35;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MenuNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1135, 718);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonViewReception);
            this.Controls.Add(this.buttonViewWorkShed);
            this.Controls.Add(this.buttonViewSpecialist);
            this.Controls.Add(this.buttonRecordClient);
            this.Controls.Add(this.buttonViewPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MenuNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuNavigation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox logotip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonViewPatient;
        private System.Windows.Forms.Button buttonRecordClient;
        private System.Windows.Forms.Button buttonViewSpecialist;
        private System.Windows.Forms.Button buttonViewWorkShed;
        private System.Windows.Forms.Button buttonViewReception;
        private System.Windows.Forms.Button buttonBack;
    }
}