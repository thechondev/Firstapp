namespace Firstapp
{
    partial class Winicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdBrowser = new System.Windows.Forms.Button();
            this.cmdWindowsW = new System.Windows.Forms.Button();
            this.cmdPdf = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // cmdBrowser
            // 
            this.cmdBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowser.Location = new System.Drawing.Point(473, 154);
            this.cmdBrowser.Name = "cmdBrowser";
            this.cmdBrowser.Size = new System.Drawing.Size(168, 52);
            this.cmdBrowser.TabIndex = 0;
            this.cmdBrowser.Text = "Navegador";
            this.cmdBrowser.UseVisualStyleBackColor = true;
            this.cmdBrowser.Click += new System.EventHandler(this.cmdBrowser_Click);
            // 
            // cmdWindowsW
            // 
            this.cmdWindowsW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWindowsW.Location = new System.Drawing.Point(125, 154);
            this.cmdWindowsW.Name = "cmdWindowsW";
            this.cmdWindowsW.Size = new System.Drawing.Size(168, 52);
            this.cmdWindowsW.TabIndex = 1;
            this.cmdWindowsW.Text = "Windows Media";
            this.cmdWindowsW.UseVisualStyleBackColor = true;
            this.cmdWindowsW.Click += new System.EventHandler(this.cmdWindowsW_Click);
            // 
            // cmdPdf
            // 
            this.cmdPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPdf.Location = new System.Drawing.Point(302, 296);
            this.cmdPdf.Name = "cmdPdf";
            this.cmdPdf.Size = new System.Drawing.Size(168, 52);
            this.cmdPdf.TabIndex = 2;
            this.cmdPdf.Text = "PDF";
            this.cmdPdf.UseVisualStyleBackColor = true;
            // 
            // Winicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdPdf);
            this.Controls.Add(this.cmdWindowsW);
            this.Controls.Add(this.cmdBrowser);
            this.Name = "Winicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBrowser;
        private System.Windows.Forms.Button cmdWindowsW;
        private System.Windows.Forms.Button cmdPdf;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}

