﻿namespace GetterSetterGenerator
{
    partial class GetterSetterGui
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectaccess = new System.Windows.Forms.ComboBox();
            this.selecttype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvar = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.richoutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access";
            // 
            // selectaccess
            // 
            this.selectaccess.FormattingEnabled = true;
            this.selectaccess.Items.AddRange(new object[] {
            "protected",
            "public"});
            this.selectaccess.Location = new System.Drawing.Point(15, 25);
            this.selectaccess.Name = "selectaccess";
            this.selectaccess.Size = new System.Drawing.Size(121, 21);
            this.selectaccess.TabIndex = 1;
            this.selectaccess.Text = "- Please Select -";
            // 
            // selecttype
            // 
            this.selecttype.FormattingEnabled = true;
            this.selecttype.Items.AddRange(new object[] {
            "string",
            "boolean",
            "int",
            "double",
            "char"});
            this.selecttype.Location = new System.Drawing.Point(142, 25);
            this.selecttype.Name = "selecttype";
            this.selecttype.Size = new System.Drawing.Size(121, 21);
            this.selecttype.TabIndex = 3;
            this.selecttype.Text = "- Please Select -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Variable";
            // 
            // txtvar
            // 
            this.txtvar.Location = new System.Drawing.Point(269, 25);
            this.txtvar.Name = "txtvar";
            this.txtvar.Size = new System.Drawing.Size(179, 20);
            this.txtvar.TabIndex = 5;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(454, 23);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 6;
            this.btnstart.Text = "Go";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // richoutput
            // 
            this.richoutput.AcceptsTab = true;
            this.richoutput.Location = new System.Drawing.Point(15, 52);
            this.richoutput.Name = "richoutput";
            this.richoutput.ReadOnly = true;
            this.richoutput.Size = new System.Drawing.Size(514, 262);
            this.richoutput.TabIndex = 7;
            this.richoutput.Text = "";
            // 
            // GetterSetterGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 326);
            this.Controls.Add(this.richoutput);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selecttype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectaccess);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetterSetterGui";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Getter/Setter Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectaccess;
        private System.Windows.Forms.ComboBox selecttype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvar;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.RichTextBox richoutput;
    }
}