namespace Oefening2
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
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(309, 12);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(121, 21);
            this.cmbBox.TabIndex = 0;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged);
            // 
            // txtBox
            // 
            this.txtBox.Enabled = false;
            this.txtBox.Location = new System.Drawing.Point(309, 71);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(121, 20);
            this.txtBox.TabIndex = 1;
            this.txtBox.Text = "Mijnbox";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(489, 67);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.cmbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btDelete;
    }
}

