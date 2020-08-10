namespace Oefening1
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
            this.Oefening1 = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.txtToevoegen = new System.Windows.Forms.TextBox();
            this.btToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Oefening1
            // 
            this.Oefening1.Enabled = false;
            this.Oefening1.Location = new System.Drawing.Point(351, 13);
            this.Oefening1.Name = "Oefening1";
            this.Oefening1.Size = new System.Drawing.Size(100, 20);
            this.Oefening1.TabIndex = 0;
            this.Oefening1.Text = "Oefening1";
            this.Oefening1.TextChanged += new System.EventHandler(this.Oefening1_TextChanged);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(341, 39);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 147);
            this.ListBox.TabIndex = 1;
            // 
            // txtToevoegen
            // 
            this.txtToevoegen.Location = new System.Drawing.Point(293, 418);
            this.txtToevoegen.Name = "txtToevoegen";
            this.txtToevoegen.Size = new System.Drawing.Size(214, 20);
            this.txtToevoegen.TabIndex = 2;
            this.txtToevoegen.TextChanged += new System.EventHandler(this.txtToevoegen_TextChanged);
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(535, 418);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(145, 23);
            this.btToevoegen.TabIndex = 3;
            this.btToevoegen.Text = "Toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btToevoegen);
            this.Controls.Add(this.txtToevoegen);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Oefening1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Oefening1;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox txtToevoegen;
        private System.Windows.Forms.Button btToevoegen;
    }
}

