namespace GetterSetterGenerator
{
    partial class GeneratorForm
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
            this.txtvar = new System.Windows.Forms.TextBox();
            this.btngenerate = new System.Windows.Forms.Button();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richoutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtvar
            // 
            this.txtvar.Location = new System.Drawing.Point(37, 30);
            this.txtvar.Name = "txtvar";
            this.txtvar.Size = new System.Drawing.Size(304, 20);
            this.txtvar.TabIndex = 0;
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(144, 217);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(84, 28);
            this.btngenerate.TabIndex = 1;
            this.btngenerate.Text = "Generate!";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // txttype
            // 
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "string",
            "bool",
            "int",
            "double",
            "char"});
            this.txttype.Location = new System.Drawing.Point(37, 78);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(121, 21);
            this.txttype.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Variable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // richoutput
            // 
            this.richoutput.Location = new System.Drawing.Point(37, 115);
            this.richoutput.Name = "richoutput";
            this.richoutput.ReadOnly = true;
            this.richoutput.Size = new System.Drawing.Size(304, 96);
            this.richoutput.TabIndex = 5;
            this.richoutput.Text = "";
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 253);
            this.Controls.Add(this.richoutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.txtvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneratorForm";
            this.ShowIcon = false;
            this.Text = "Getter / Setter Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvar;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.ComboBox txttype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richoutput;
    }
}