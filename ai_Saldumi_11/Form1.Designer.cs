namespace ai_Saldumi_11
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
            this.Saldumi_aprekinat_button = new System.Windows.Forms.Button();
            this.Saldumi_daudzums_textbox = new System.Windows.Forms.TextBox();
            this.Saldumi_rezultats_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Saldumi_aprekinat_button
            // 
            this.Saldumi_aprekinat_button.Location = new System.Drawing.Point(319, 186);
            this.Saldumi_aprekinat_button.Name = "Saldumi_aprekinat_button";
            this.Saldumi_aprekinat_button.Size = new System.Drawing.Size(100, 77);
            this.Saldumi_aprekinat_button.TabIndex = 0;
            this.Saldumi_aprekinat_button.Text = "Aprekinat";
            this.Saldumi_aprekinat_button.UseVisualStyleBackColor = true;
            this.Saldumi_aprekinat_button.Click += new System.EventHandler(this.Saldumi_aprekinat_button_Click);
            // 
            // Saldumi_daudzums_textbox
            // 
            this.Saldumi_daudzums_textbox.Location = new System.Drawing.Point(145, 215);
            this.Saldumi_daudzums_textbox.Name = "Saldumi_daudzums_textbox";
            this.Saldumi_daudzums_textbox.Size = new System.Drawing.Size(96, 20);
            this.Saldumi_daudzums_textbox.TabIndex = 1;
            this.Saldumi_daudzums_textbox.TextChanged += new System.EventHandler(this.Saldumi_daudzums_textbox_TextChanged);
            // 
            // Saldumi_rezultats_textbox
            // 
            this.Saldumi_rezultats_textbox.Location = new System.Drawing.Point(474, 215);
            this.Saldumi_rezultats_textbox.Name = "Saldumi_rezultats_textbox";
            this.Saldumi_rezultats_textbox.Size = new System.Drawing.Size(100, 20);
            this.Saldumi_rezultats_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rezultats/Cena";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sveicinati saldumu veikala \"Artura saldumi un vel kautkas\"! Seit jus aprekinasiet" +
    " jusu saldumu cenu, musu saldumi maksa 9.88eur/kg.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cik kg jus nemsiet resnais cuka?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Saldumi_rezultats_textbox);
            this.Controls.Add(this.Saldumi_daudzums_textbox);
            this.Controls.Add(this.Saldumi_aprekinat_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Saldumi_aprekinat_button;
        private System.Windows.Forms.TextBox Saldumi_daudzums_textbox;
        private System.Windows.Forms.TextBox Saldumi_rezultats_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

