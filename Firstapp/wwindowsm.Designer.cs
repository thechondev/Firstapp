namespace Firstapp
{
    partial class wwindowsm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wwindowsm));
            this.wwm = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wwm)).BeginInit();
            this.SuspendLayout();
            // 
            // wwm
            // 
            this.wwm.Enabled = true;
            this.wwm.Location = new System.Drawing.Point(97, 95);
            this.wwm.Name = "wwm";
            this.wwm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wwm.OcxState")));
            this.wwm.Size = new System.Drawing.Size(545, 294);
            this.wwm.TabIndex = 0;
            this.wwm.Enter += new System.EventHandler(this.wwm_Enter);
            // 
            // wwindowsm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wwm);
            this.Name = "wwindowsm";
            this.Text = "wwindowsm";
            ((System.ComponentModel.ISupportInitialize)(this.wwm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wwm;
    }
}