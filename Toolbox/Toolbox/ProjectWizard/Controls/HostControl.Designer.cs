﻿namespace NetOffice.DeveloperToolbox
{
    partial class HostControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxAccess = new System.Windows.Forms.CheckBox();
            this.checkBoxPowerPoint = new System.Windows.Forms.CheckBox();
            this.checkBoxOutlook = new System.Windows.Forms.CheckBox();
            this.checkBoxWord = new System.Windows.Forms.CheckBox();
            this.checkBoxExcel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxAccess
            // 
            this.checkBoxAccess.AutoSize = true;
            this.checkBoxAccess.Location = new System.Drawing.Point(63, 131);
            this.checkBoxAccess.Name = "checkBoxAccess";
            this.checkBoxAccess.Size = new System.Drawing.Size(61, 17);
            this.checkBoxAccess.TabIndex = 9;
            this.checkBoxAccess.Text = "Access";
            this.checkBoxAccess.UseVisualStyleBackColor = true;
            this.checkBoxAccess.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxPowerPoint
            // 
            this.checkBoxPowerPoint.AutoSize = true;
            this.checkBoxPowerPoint.Location = new System.Drawing.Point(63, 108);
            this.checkBoxPowerPoint.Name = "checkBoxPowerPoint";
            this.checkBoxPowerPoint.Size = new System.Drawing.Size(83, 17);
            this.checkBoxPowerPoint.TabIndex = 8;
            this.checkBoxPowerPoint.Text = "Power Point";
            this.checkBoxPowerPoint.UseVisualStyleBackColor = true;
            this.checkBoxPowerPoint.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxOutlook
            // 
            this.checkBoxOutlook.AutoSize = true;
            this.checkBoxOutlook.Location = new System.Drawing.Point(63, 85);
            this.checkBoxOutlook.Name = "checkBoxOutlook";
            this.checkBoxOutlook.Size = new System.Drawing.Size(63, 17);
            this.checkBoxOutlook.TabIndex = 7;
            this.checkBoxOutlook.Text = "Outlook";
            this.checkBoxOutlook.UseVisualStyleBackColor = true;
            this.checkBoxOutlook.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxWord
            // 
            this.checkBoxWord.AutoSize = true;
            this.checkBoxWord.Location = new System.Drawing.Point(63, 62);
            this.checkBoxWord.Name = "checkBoxWord";
            this.checkBoxWord.Size = new System.Drawing.Size(52, 17);
            this.checkBoxWord.TabIndex = 6;
            this.checkBoxWord.Text = "Word";
            this.checkBoxWord.UseVisualStyleBackColor = true;
            this.checkBoxWord.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxExcel
            // 
            this.checkBoxExcel.AutoSize = true;
            this.checkBoxExcel.Location = new System.Drawing.Point(63, 39);
            this.checkBoxExcel.Name = "checkBoxExcel";
            this.checkBoxExcel.Size = new System.Drawing.Size(52, 17);
            this.checkBoxExcel.TabIndex = 5;
            this.checkBoxExcel.Text = "Excel";
            this.checkBoxExcel.UseVisualStyleBackColor = true;
            this.checkBoxExcel.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // HostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxAccess);
            this.Controls.Add(this.checkBoxPowerPoint);
            this.Controls.Add(this.checkBoxOutlook);
            this.Controls.Add(this.checkBoxWord);
            this.Controls.Add(this.checkBoxExcel);
            this.Name = "HostControl";
            this.Size = new System.Drawing.Size(611, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAccess;
        private System.Windows.Forms.CheckBox checkBoxPowerPoint;
        private System.Windows.Forms.CheckBox checkBoxOutlook;
        private System.Windows.Forms.CheckBox checkBoxWord;
        private System.Windows.Forms.CheckBox checkBoxExcel;
    }
}
