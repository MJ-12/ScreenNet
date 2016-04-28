namespace ScreenNet
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.checkBoxAutoRun = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoLoad = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.boxSaveFolder = new System.Windows.Forms.Label();
            this.panelSave = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.folderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxShowInTray = new System.Windows.Forms.CheckBox();
            this.panelSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxAutoRun
            // 
            this.checkBoxAutoRun.AutoSize = true;
            this.checkBoxAutoRun.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAutoRun.Location = new System.Drawing.Point(21, 12);
            this.checkBoxAutoRun.Name = "checkBoxAutoRun";
            this.checkBoxAutoRun.Size = new System.Drawing.Size(238, 24);
            this.checkBoxAutoRun.TabIndex = 0;
            this.checkBoxAutoRun.Text = "Запускать при старте системы";
            this.checkBoxAutoRun.UseVisualStyleBackColor = true;
            this.checkBoxAutoRun.CheckedChanged += new System.EventHandler(this.checkBoxAutoRun_CheckedChanged);
            // 
            // checkBoxAutoLoad
            // 
            this.checkBoxAutoLoad.AutoSize = true;
            this.checkBoxAutoLoad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAutoLoad.Location = new System.Drawing.Point(21, 72);
            this.checkBoxAutoLoad.Name = "checkBoxAutoLoad";
            this.checkBoxAutoLoad.Size = new System.Drawing.Size(226, 24);
            this.checkBoxAutoLoad.TabIndex = 1;
            this.checkBoxAutoLoad.Text = "Загружать все изображения";
            this.checkBoxAutoLoad.UseVisualStyleBackColor = true;
            this.checkBoxAutoLoad.CheckedChanged += new System.EventHandler(this.checkBoxAutoLoad_CheckedChanged);
            // 
            // checkBoxAutoSave
            // 
            this.checkBoxAutoSave.AutoSize = true;
            this.checkBoxAutoSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAutoSave.Location = new System.Drawing.Point(21, 116);
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.Size = new System.Drawing.Size(209, 24);
            this.checkBoxAutoSave.TabIndex = 2;
            this.checkBoxAutoSave.Text = "Сохранять автоматически";
            this.checkBoxAutoSave.UseVisualStyleBackColor = true;
            this.checkBoxAutoSave.CheckedChanged += new System.EventHandler(this.checkBoxAutoSave_CheckedChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = "C:\\Users\\Alex\\Pictures\\ScreenNet";
            // 
            // boxSaveFolder
            // 
            this.boxSaveFolder.BackColor = System.Drawing.SystemColors.Window;
            this.boxSaveFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxSaveFolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxSaveFolder.Location = new System.Drawing.Point(54, 6);
            this.boxSaveFolder.Name = "boxSaveFolder";
            this.boxSaveFolder.Size = new System.Drawing.Size(319, 20);
            this.boxSaveFolder.TabIndex = 3;
            this.boxSaveFolder.Click += new System.EventHandler(this.boxSaveFolder_Click);
            this.boxSaveFolder.MouseHover += new System.EventHandler(this.boxSaveFolder_MouseHover);
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.label1);
            this.panelSave.Controls.Add(this.boxSaveFolder);
            this.panelSave.Location = new System.Drawing.Point(21, 146);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(391, 35);
            this.panelSave.TabIndex = 5;
            this.panelSave.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(342, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Client ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.Location = new System.Drawing.Point(412, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(160, 27);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.Validated += new System.EventHandler(this.textBoxID_Validated);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(498, 198);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // checkBoxShowInTray
            // 
            this.checkBoxShowInTray.AutoSize = true;
            this.checkBoxShowInTray.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowInTray.Location = new System.Drawing.Point(21, 42);
            this.checkBoxShowInTray.Name = "checkBoxShowInTray";
            this.checkBoxShowInTray.Size = new System.Drawing.Size(293, 24);
            this.checkBoxShowInTray.TabIndex = 9;
            this.checkBoxShowInTray.Text = "Отображать значок в системном трее";
            this.checkBoxShowInTray.UseVisualStyleBackColor = true;
            this.checkBoxShowInTray.CheckedChanged += new System.EventHandler(this.checkBoxShowInTray_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 233);
            this.Controls.Add(this.checkBoxShowInTray);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxAutoSave);
            this.Controls.Add(this.checkBoxAutoLoad);
            this.Controls.Add(this.checkBoxAutoRun);
            this.Controls.Add(this.panelSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры";
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.CheckBox checkBoxAutoRun;
        private System.Windows.Forms.CheckBox checkBoxAutoLoad;
        private System.Windows.Forms.CheckBox checkBoxAutoSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label boxSaveFolder;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolTip folderToolTip;
        private System.Windows.Forms.CheckBox checkBoxShowInTray;
    }
}