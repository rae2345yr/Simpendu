
namespace SimPendu
{
    partial class frmData
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbData.Location = new System.Drawing.Point(0, 0);
            this.tbData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(309, 540);
            this.tbData.TabIndex = 0;
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 540);
            this.Controls.Add(this.tbData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmData";
            this.Text = "pendu Data";
            this.Load += new System.EventHandler(this.frmData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbData;
    }
}