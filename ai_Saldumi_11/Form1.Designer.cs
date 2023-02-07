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
            this.Nauda_daudzums_textbox = new System.Windows.Forms.TextBox();
            this.Saldumi_rezultats_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Saldumi_aprekinat_button
            // 
            this.Saldumi_aprekinat_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Saldumi_aprekinat_button.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Saldumi_aprekinat_button.Location = new System.Drawing.Point(319, 186);
            this.Saldumi_aprekinat_button.Name = "Saldumi_aprekinat_button";
            this.Saldumi_aprekinat_button.Size = new System.Drawing.Size(100, 77);
            this.Saldumi_aprekinat_button.TabIndex = 0;
            this.Saldumi_aprekinat_button.Text = "Aprekinat";
            this.Saldumi_aprekinat_button.UseVisualStyleBackColor = false;
            this.Saldumi_aprekinat_button.Click += new System.EventHandler(this.Saldumi_aprekinat_button_Click);
            // 
            // Nauda_daudzums_textbox
            // 
            this.Nauda_daudzums_textbox.Location = new System.Drawing.Point(145, 215);
            this.Nauda_daudzums_textbox.Name = "Nauda_daudzums_textbox";
            this.Nauda_daudzums_textbox.Size = new System.Drawing.Size(96, 20);
            this.Nauda_daudzums_textbox.TabIndex = 1;
            this.Nauda_daudzums_textbox.TextChanged += new System.EventHandler(this.Saldumi_daudzums_textbox_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(471, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rezultats/Daudzums";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sveicinati saldumu veikala! Seit jus aprekinasiet cik saldumus jus varat iegadati" +
    "es, musu saldumi maksa 9,88eur/kg.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cik jums ir nauda?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lugums ievadot skaitli ar decimaldalam, izmantot komatu!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "*Decimaldala - Cipari aiz komata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::ai_Saldumi_11.Properties.Resources.Saldumu_bilde;
            this.ClientSize = new System.Drawing.Size(823, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Saldumi_rezultats_textbox);
            this.Controls.Add(this.Nauda_daudzums_textbox);
            this.Controls.Add(this.Saldumi_aprekinat_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Saldumi_aprekinat_button;
        private System.Windows.Forms.TextBox Nauda_daudzums_textbox;
        private System.Windows.Forms.TextBox Saldumi_rezultats_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

