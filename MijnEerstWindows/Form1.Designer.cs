namespace MijnEerstWindows
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
            this.lblMijnLabel = new System.Windows.Forms.Label();
            this.btnMijnButton = new System.Windows.Forms.Button();
            this.cbLeerlingen = new System.Windows.Forms.ComboBox();
            this.lbLeerLingen = new System.Windows.Forms.ListBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.btnVoegtoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMijnLabel
            // 
            this.lblMijnLabel.AutoSize = true;
            this.lblMijnLabel.Location = new System.Drawing.Point(12, 9);
            this.lblMijnLabel.Name = "lblMijnLabel";
            this.lblMijnLabel.Size = new System.Drawing.Size(51, 13);
            this.lblMijnLabel.TabIndex = 0;
            this.lblMijnLabel.Text = "Mijn label";
            this.lblMijnLabel.Click += new System.EventHandler(this.lblMijnLabel_Click);
            // 
            // btnMijnButton
            // 
            this.btnMijnButton.Location = new System.Drawing.Point(13, 26);
            this.btnMijnButton.Name = "btnMijnButton";
            this.btnMijnButton.Size = new System.Drawing.Size(75, 23);
            this.btnMijnButton.TabIndex = 1;
            this.btnMijnButton.Text = "Klik mij";
            this.btnMijnButton.UseVisualStyleBackColor = true;
            this.btnMijnButton.Click += new System.EventHandler(this.btnMijnButton_Click);
            // 
            // cbLeerlingen
            // 
            this.cbLeerlingen.FormattingEnabled = true;
            this.cbLeerlingen.Location = new System.Drawing.Point(13, 56);
            this.cbLeerlingen.Name = "cbLeerlingen";
            this.cbLeerlingen.Size = new System.Drawing.Size(121, 21);
            this.cbLeerlingen.TabIndex = 2;
            this.cbLeerlingen.SelectedIndexChanged += new System.EventHandler(this.cbLeerlingen_SelectedIndexChanged);
            // 
            // lbLeerLingen
            // 
            this.lbLeerLingen.FormattingEnabled = true;
            this.lbLeerLingen.Location = new System.Drawing.Point(13, 82);
            this.lbLeerLingen.Name = "lbLeerLingen";
            this.lbLeerLingen.Size = new System.Drawing.Size(120, 134);
            this.lbLeerLingen.TabIndex = 3;
            this.lbLeerLingen.SelectedIndexChanged += new System.EventHandler(this.lbLeerLingen_SelectedIndexChanged);
            // 
            // txtbox2
            // 
            this.txtbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox2.Location = new System.Drawing.Point(15, 404);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(456, 20);
            this.txtbox2.TabIndex = 4;
            this.txtbox2.TextChanged += new System.EventHandler(this.txtbox2_TextChanged);
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoegtoe.Location = new System.Drawing.Point(597, 404);
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegtoe.TabIndex = 5;
            this.btnVoegtoe.Text = "Toevoegen!";
            this.btnVoegtoe.UseVisualStyleBackColor = true;
            this.btnVoegtoe.Click += new System.EventHandler(this.btnVoegtoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 439);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.lbLeerLingen);
            this.Controls.Add(this.cbLeerlingen);
            this.Controls.Add(this.btnMijnButton);
            this.Controls.Add(this.lblMijnLabel);
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MijnApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMijnLabel;
        private System.Windows.Forms.Button btnMijnButton;
        private System.Windows.Forms.ComboBox cbLeerlingen;
        private System.Windows.Forms.ListBox lbLeerLingen;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Button btnVoegtoe;
    }
}

