namespace WindowsFormsApp3
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.LBlistbox = new System.Windows.Forms.ListBox();
            this.cbFROM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVALUE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 415);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculating";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(105, 420);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "label1";
            // 
            // LBlistbox
            // 
            this.LBlistbox.FormattingEnabled = true;
            this.LBlistbox.Location = new System.Drawing.Point(13, 182);
            this.LBlistbox.Name = "LBlistbox";
            this.LBlistbox.Size = new System.Drawing.Size(738, 225);
            this.LBlistbox.TabIndex = 2;
            // 
            // cbFROM
            // 
            this.cbFROM.FormattingEnabled = true;
            this.cbFROM.Location = new System.Drawing.Point(12, 29);
            this.cbFROM.Name = "cbFROM";
            this.cbFROM.Size = new System.Drawing.Size(121, 21);
            this.cbFROM.TabIndex = 3;
            this.cbFROM.SelectedIndexChanged += new System.EventHandler(this.cbFROM_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valuta";
            // 
            // tbVALUE
            // 
            this.tbVALUE.Location = new System.Drawing.Point(12, 57);
            this.tbVALUE.Name = "tbVALUE";
            this.tbVALUE.Size = new System.Drawing.Size(121, 20);
            this.tbVALUE.TabIndex = 8;
            this.tbVALUE.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbVALUE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFROM);
            this.Controls.Add(this.LBlistbox);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox LBlistbox;
        private System.Windows.Forms.ComboBox cbFROM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVALUE;
    }
}

