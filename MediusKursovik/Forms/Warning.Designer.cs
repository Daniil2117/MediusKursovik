namespace MediusKursovik.Forms
{
    partial class Warning
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
            this.buttonReturnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCheckPass = new System.Windows.Forms.TextBox();
            this.buttonCheckPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReturnMain
            // 
            this.buttonReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonReturnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturnMain.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonReturnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReturnMain.Location = new System.Drawing.Point(434, 344);
            this.buttonReturnMain.Name = "buttonReturnMain";
            this.buttonReturnMain.Size = new System.Drawing.Size(161, 61);
            this.buttonReturnMain.TabIndex = 14;
            this.buttonReturnMain.Text = "Вернуться на главную";
            this.buttonReturnMain.UseVisualStyleBackColor = false;
            this.buttonReturnMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(204, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Внимание!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(75, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 56);
            this.label2.TabIndex = 16;
            this.label2.Text = "В систему могут войти лишь персонал, \r\nдля подтверждения введите код";
            // 
            // textBoxCheckPass
            // 
            this.textBoxCheckPass.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxCheckPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCheckPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.textBoxCheckPass.Location = new System.Drawing.Point(139, 212);
            this.textBoxCheckPass.Name = "textBoxCheckPass";
            this.textBoxCheckPass.PasswordChar = '*';
            this.textBoxCheckPass.Size = new System.Drawing.Size(349, 40);
            this.textBoxCheckPass.TabIndex = 17;
            // 
            // buttonCheckPass
            // 
            this.buttonCheckPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.buttonCheckPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckPass.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.buttonCheckPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCheckPass.Location = new System.Drawing.Point(229, 267);
            this.buttonCheckPass.Name = "buttonCheckPass";
            this.buttonCheckPass.Size = new System.Drawing.Size(161, 61);
            this.buttonCheckPass.TabIndex = 18;
            this.buttonCheckPass.Text = "Подтвердить код";
            this.buttonCheckPass.UseVisualStyleBackColor = false;
            this.buttonCheckPass.Click += new System.EventHandler(this.buttonCheckPass_Click);
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 417);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCheckPass);
            this.Controls.Add(this.textBoxCheckPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReturnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(625, 423);
            this.MinimumSize = new System.Drawing.Size(625, 423);
            this.Name = "Warning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCheckPass;
        private System.Windows.Forms.Button buttonCheckPass;
    }
}