namespace ScreenNet
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.screenbox = new System.Windows.Forms.PictureBox();
            this.screenPanel = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.backgroundUpload = new System.ComponentModel.BackgroundWorker();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.progressUpload = new System.Windows.Forms.ProgressBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUrl = new System.Windows.Forms.Button();
            this.saveScreen = new System.Windows.Forms.SaveFileDialog();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screenbox)).BeginInit();
            this.screenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenbox
            // 
            this.screenbox.Location = new System.Drawing.Point(38, 25);
            this.screenbox.Name = "screenbox";
            this.screenbox.Size = new System.Drawing.Size(100, 100);
            this.screenbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.screenbox.TabIndex = 0;
            this.screenbox.TabStop = false;
            // 
            // screenPanel
            // 
            this.screenPanel.AutoScroll = true;
            this.screenPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.screenPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenPanel.Controls.Add(this.screenbox);
            this.screenPanel.Location = new System.Drawing.Point(5, 54);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(975, 487);
            this.screenPanel.TabIndex = 2;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(769, 547);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 100);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // backgroundUpload
            // 
            this.backgroundUpload.WorkerReportsProgress = true;
            this.backgroundUpload.WorkerSupportsCancellation = true;
            this.backgroundUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundUpload_DoWork);
            this.backgroundUpload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundUpload_ProgressChanged);
            this.backgroundUpload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundUpload_RunWorkerCompleted);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCopy.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCopy.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.Location = new System.Drawing.Point(163, 547);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 100);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // progressUpload
            // 
            this.progressUpload.Location = new System.Drawing.Point(769, 645);
            this.progressUpload.Name = "progressUpload";
            this.progressUpload.Size = new System.Drawing.Size(100, 24);
            this.progressUpload.TabIndex = 7;
            this.progressUpload.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(12, 547);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 100);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUrl
            // 
            this.buttonUrl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUrl.Location = new System.Drawing.Point(902, 576);
            this.buttonUrl.Name = "buttonUrl";
            this.buttonUrl.Size = new System.Drawing.Size(70, 70);
            this.buttonUrl.TabIndex = 3;
            this.buttonUrl.UseVisualStyleBackColor = true;
            this.buttonUrl.Visible = false;
            this.buttonUrl.Click += new System.EventHandler(this.url_Click);
            // 
            // saveScreen
            // 
            this.saveScreen.DefaultExt = "png";
            this.saveScreen.FileName = "Снимок";
            this.saveScreen.Filter = "PNG (*.png)|.png";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(930, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(50, 50);
            this.buttonSettings.TabIndex = 8;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 669);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonUrl);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.progressUpload);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.screenPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ScreenNet";
            ((System.ComponentModel.ISupportInitialize)(this.screenbox)).EndInit();
            this.screenPanel.ResumeLayout(false);
            this.screenPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel screenPanel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ProgressBar progressUpload;
        private System.Windows.Forms.PictureBox screenbox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUrl;
        private System.Windows.Forms.SaveFileDialog saveScreen;
        internal System.ComponentModel.BackgroundWorker backgroundUpload;
        private System.Windows.Forms.Button buttonSettings;
    }
}