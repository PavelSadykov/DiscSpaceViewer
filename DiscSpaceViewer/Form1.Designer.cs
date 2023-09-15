namespace DiscSpaceViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.progressBarD = new System.Windows.Forms.ProgressBar();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelDownloads = new System.Windows.Forms.Label();
            this.labelAppData = new System.Windows.Forms.Label();
            this.labelDesktop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(71, 85);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(214, 23);
            this.progressBarC.TabIndex = 0;
            // 
            // progressBarD
            // 
            this.progressBarD.Location = new System.Drawing.Point(71, 136);
            this.progressBarD.Name = "progressBarD";
            this.progressBarD.Size = new System.Drawing.Size(214, 23);
            this.progressBarD.TabIndex = 1;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(68, 69);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(17, 13);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "C:";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(68, 120);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(18, 13);
            this.labelD.TabIndex = 3;
            this.labelD.Text = "D:";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(383, 85);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(34, 13);
            this.labelTemp.TabIndex = 4;
            this.labelTemp.Text = "Temp";
            // 
            // labelDownloads
            // 
            this.labelDownloads.AutoSize = true;
            this.labelDownloads.Location = new System.Drawing.Point(383, 112);
            this.labelDownloads.Name = "labelDownloads";
            this.labelDownloads.Size = new System.Drawing.Size(60, 13);
            this.labelDownloads.TabIndex = 5;
            this.labelDownloads.Text = "Downloads";
            // 
            // labelAppData
            // 
            this.labelAppData.AutoSize = true;
            this.labelAppData.Location = new System.Drawing.Point(383, 136);
            this.labelAppData.Name = "labelAppData";
            this.labelAppData.Size = new System.Drawing.Size(49, 13);
            this.labelAppData.TabIndex = 6;
            this.labelAppData.Text = "AppData";
            // 
            // labelDesktop
            // 
            this.labelDesktop.AutoSize = true;
            this.labelDesktop.Location = new System.Drawing.Point(383, 165);
            this.labelDesktop.Name = "labelDesktop";
            this.labelDesktop.Size = new System.Drawing.Size(47, 13);
            this.labelDesktop.TabIndex = 7;
            this.labelDesktop.Text = "Desktop";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDesktop);
            this.Controls.Add(this.labelAppData);
            this.Controls.Add(this.labelDownloads);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.progressBarD);
            this.Controls.Add(this.progressBarC);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.ProgressBar progressBarD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelDownloads;
        private System.Windows.Forms.Label labelAppData;
        private System.Windows.Forms.Label labelDesktop;
    }
}

