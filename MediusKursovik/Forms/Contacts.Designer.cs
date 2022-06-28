namespace MediusKursovik.Forms
{
    partial class Contacts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxGeo = new System.Windows.Forms.PictureBox();
            this.pictureBoxContact = new System.Windows.Forms.PictureBox();
            this.logotip = new System.Windows.Forms.PictureBox();
            this.buttonReturnMain = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(518, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наши контакты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(97, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(949, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Город Всеволожск, ул. Социалистическая улица д.107, Клиника Медиус Центр КТ и МРТ" +
    "";
            // 
            // pictureBoxGeo
            // 
            this.pictureBoxGeo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxGeo.Image = global::MediusKursovik.Properties.Resources.Contacts2;
            this.pictureBoxGeo.Location = new System.Drawing.Point(4, 257);
            this.pictureBoxGeo.Name = "pictureBoxGeo";
            this.pictureBoxGeo.Size = new System.Drawing.Size(1130, 347);
            this.pictureBoxGeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGeo.TabIndex = 10;
            this.pictureBoxGeo.TabStop = false;
            // 
            // pictureBoxContact
            // 
            this.pictureBoxContact.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxContact.Image = global::MediusKursovik.Properties.Resources.Contacts1;
            this.pictureBoxContact.Location = new System.Drawing.Point(381, 155);
            this.pictureBoxContact.Name = "pictureBoxContact";
            this.pictureBoxContact.Size = new System.Drawing.Size(556, 40);
            this.pictureBoxContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxContact.TabIndex = 8;
            this.pictureBoxContact.TabStop = false;
            // 
            // logotip
            // 
            this.logotip.BackColor = System.Drawing.Color.Transparent;
            this.logotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logotip.Image = global::MediusKursovik.Properties.Resources.Icon;
            this.logotip.Location = new System.Drawing.Point(12, 68);
            this.logotip.Name = "logotip";
            this.logotip.Size = new System.Drawing.Size(226, 95);
            this.logotip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logotip.TabIndex = 4;
            this.logotip.TabStop = false;
            // 
            // buttonReturnMain
            // 
            this.buttonReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonReturnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturnMain.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonReturnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReturnMain.Location = new System.Drawing.Point(494, 610);
            this.buttonReturnMain.Name = "buttonReturnMain";
            this.buttonReturnMain.Size = new System.Drawing.Size(220, 69);
            this.buttonReturnMain.TabIndex = 21;
            this.buttonReturnMain.Text = "Вернуться на главную";
            this.buttonReturnMain.UseVisualStyleBackColor = false;
            this.buttonReturnMain.Click += new System.EventHandler(this.buttonReturnMain_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelDate.Location = new System.Drawing.Point(944, 84);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(62, 25);
            this.labelDate.TabIndex = 44;
            this.labelDate.Text = "Дата";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelTime.Location = new System.Drawing.Point(981, 109);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(76, 25);
            this.labelTime.TabIndex = 45;
            this.labelTime.Text = "Время";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 718);
            this.ControlBox = false;
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonReturnMain);
            this.Controls.Add(this.pictureBoxGeo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logotip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Contacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logotip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxGeo;
        private System.Windows.Forms.Button buttonReturnMain;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}