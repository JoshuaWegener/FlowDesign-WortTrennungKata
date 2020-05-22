namespace WortTrennung
{
    partial class WortTrennungForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
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
            this.Ctrl_OriginalerText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ctrl_AngepassterText = new System.Windows.Forms.TextBox();
            this.Ctrl_SpaltenBreite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ctrl_TextTransformieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ctrl_OriginalerText
            // 
            this.Ctrl_OriginalerText.Location = new System.Drawing.Point(12, 60);
            this.Ctrl_OriginalerText.Multiline = true;
            this.Ctrl_OriginalerText.Name = "Ctrl_OriginalerText";
            this.Ctrl_OriginalerText.Size = new System.Drawing.Size(633, 381);
            this.Ctrl_OriginalerText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Originaler Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angepasster Text";
            // 
            // Ctrl_AngepassterText
            // 
            this.Ctrl_AngepassterText.Location = new System.Drawing.Point(12, 510);
            this.Ctrl_AngepassterText.Multiline = true;
            this.Ctrl_AngepassterText.Name = "Ctrl_AngepassterText";
            this.Ctrl_AngepassterText.ReadOnly = true;
            this.Ctrl_AngepassterText.Size = new System.Drawing.Size(633, 381);
            this.Ctrl_AngepassterText.TabIndex = 3;
            // 
            // Ctrl_SpaltenBreite
            // 
            this.Ctrl_SpaltenBreite.Location = new System.Drawing.Point(12, 938);
            this.Ctrl_SpaltenBreite.Name = "Ctrl_SpaltenBreite";
            this.Ctrl_SpaltenBreite.Size = new System.Drawing.Size(164, 22);
            this.Ctrl_SpaltenBreite.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 918);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spalten Breite in Zeichen";
            // 
            // Ctrl_TextTransformieren
            // 
            this.Ctrl_TextTransformieren.Location = new System.Drawing.Point(491, 918);
            this.Ctrl_TextTransformieren.Name = "Ctrl_TextTransformieren";
            this.Ctrl_TextTransformieren.Size = new System.Drawing.Size(154, 42);
            this.Ctrl_TextTransformieren.TabIndex = 6;
            this.Ctrl_TextTransformieren.Text = "Transformieren";
            this.Ctrl_TextTransformieren.UseVisualStyleBackColor = true;
            this.Ctrl_TextTransformieren.Click += new System.EventHandler(this.Ctrl_TextTransformieren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 972);
            this.Controls.Add(this.Ctrl_TextTransformieren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ctrl_SpaltenBreite);
            this.Controls.Add(this.Ctrl_AngepassterText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ctrl_OriginalerText);
            this.Name = "WortTrennungForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ctrl_OriginalerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ctrl_AngepassterText;
        private System.Windows.Forms.TextBox Ctrl_SpaltenBreite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ctrl_TextTransformieren;
    }
}

