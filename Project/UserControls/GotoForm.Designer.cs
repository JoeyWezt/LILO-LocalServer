﻿namespace ICSharpCode.TextEditor.UserControls
{
    partial class GotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GotoForm));
            this.lblLineNumber = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLineNumber = new ICSharpCode.TextEditor.UserControls.Int32TextBox();
            this.SuspendLayout();
            // 
            // lblLineNumber
            // 
            this.lblLineNumber.AutoSize = true;
            this.lblLineNumber.Location = new System.Drawing.Point(17, 20);
            this.lblLineNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLineNumber.Name = "lblLineNumber";
            this.lblLineNumber.Size = new System.Drawing.Size(154, 20);
            this.lblLineNumber.TabIndex = 0;
            this.lblLineNumber.Text = "Line number (1 - 999):";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(152, 86);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(260, 86);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(21, 46);
            this.txtLineNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLineNumber.Max = 2147483647;
            this.txtLineNumber.Min = 1;
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(337, 27);
            this.txtLineNumber.TabIndex = 1;
            this.txtLineNumber.Text = "1";
            // 
            // GotoForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(376, 134);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(this.lblLineNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GotoForm";
            this.Text = "Go To Line";
            this.Load += new System.EventHandler(this.GotoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLineNumber;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private Int32TextBox txtLineNumber;
    }
}