using MetroFramework.Controls;
using MetroFramework.Forms;

namespace DSA5Chargen
{
    partial class Main
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
            this.btn_new_char = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_new_char
            // 
            this.btn_new_char.Location = new System.Drawing.Point(74, 177);
            this.btn_new_char.Name = "btn_new_char";
            this.btn_new_char.Size = new System.Drawing.Size(174, 23);
            this.btn_new_char.TabIndex = 0;
            this.btn_new_char.Text = "Neuer Charackter";
            this.btn_new_char.Click += new System.EventHandler(this.btn_new_char_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 238);
            this.Controls.Add(this.btn_new_char);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroButton btn_new_char;
    }
}

