namespace TestAppGUI
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
            this.actionsCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.featureOff = new System.Windows.Forms.RadioButton();
            this.featureOn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsCB
            // 
            this.actionsCB.FormattingEnabled = true;
            this.actionsCB.Location = new System.Drawing.Point(66, 48);
            this.actionsCB.Name = "actionsCB";
            this.actionsCB.Size = new System.Drawing.Size(182, 24);
            this.actionsCB.TabIndex = 1;
            this.actionsCB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            this.actionsCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.featureOff);
            this.panel1.Controls.Add(this.featureOn);
            this.panel1.Location = new System.Drawing.Point(66, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 99);
            this.panel1.TabIndex = 2;
            // 
            // featureOff
            // 
            this.featureOff.AutoSize = true;
            this.featureOff.Checked = true;
            this.featureOff.Location = new System.Drawing.Point(150, 41);
            this.featureOff.Name = "featureOff";
            this.featureOff.Size = new System.Drawing.Size(48, 21);
            this.featureOff.TabIndex = 1;
            this.featureOff.TabStop = true;
            this.featureOff.Text = "Off";
            this.featureOff.UseVisualStyleBackColor = true;
            this.featureOff.CheckedChanged += new System.EventHandler(this.featureOff_CheckedChanged);
            // 
            // featureOn
            // 
            this.featureOn.AutoSize = true;
            this.featureOn.Location = new System.Drawing.Point(36, 41);
            this.featureOn.Name = "featureOn";
            this.featureOn.Size = new System.Drawing.Size(48, 21);
            this.featureOn.TabIndex = 0;
            this.featureOn.Text = "On";
            this.featureOn.UseVisualStyleBackColor = true;
            this.featureOn.CheckedChanged += new System.EventHandler(this.featureOn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actionsCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox actionsCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton featureOff;
        private System.Windows.Forms.RadioButton featureOn;
    }
}

