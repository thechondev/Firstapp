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
            this.cmdcargar = new System.Windows.Forms.Button();
            this.ofdcargador = new System.Windows.Forms.OpenFileDialog();
            this.cmdstart = new System.Windows.Forms.Button();
            this.lblruta = new System.Windows.Forms.Label();
            this.reproductorwmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmgbotones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.reproductorwmp)).BeginInit();
            this.cmgbotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdcargar
            // 
            this.cmdcargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcargar.Location = new System.Drawing.Point(14, 46);
            this.cmdcargar.Name = "cmdcargar";
            this.cmdcargar.Size = new System.Drawing.Size(87, 32);
            this.cmdcargar.TabIndex = 1;
            this.cmdcargar.Text = "cargar";
            this.cmdcargar.UseVisualStyleBackColor = true;
            this.cmdcargar.Click += new System.EventHandler(this.cmdcargar_Click);
            // 
            // ofdcargador
            // 
            this.ofdcargador.Filter = "todos|*";
            // 
            // cmdstart
            // 
            this.cmdstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdstart.Location = new System.Drawing.Point(107, 46);
            this.cmdstart.Name = "cmdstart";
            this.cmdstart.Size = new System.Drawing.Size(87, 32);
            this.cmdstart.TabIndex = 4;
            this.cmdstart.Text = "start";
            this.cmdstart.UseVisualStyleBackColor = true;
            this.cmdstart.Click += new System.EventHandler(this.cmdstart_Click);
            // 
            // lblruta
            // 
            this.lblruta.AllowDrop = true;
            this.lblruta.AutoSize = true;
            this.lblruta.CausesValidation = false;
            this.lblruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruta.Location = new System.Drawing.Point(112, 388);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(39, 16);
            this.lblruta.TabIndex = 5;
            this.lblruta.Text = "Ruta";
            // 
            // reproductorwmp
            // 
            this.reproductorwmp.Enabled = true;
            this.reproductorwmp.Location = new System.Drawing.Point(115, 12);
            this.reproductorwmp.Name = "reproductorwmp";
            this.reproductorwmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductorwmp.OcxState")));
            this.reproductorwmp.Size = new System.Drawing.Size(545, 294);
            this.reproductorwmp.TabIndex = 0;
            // 
            // cmgbotones
            // 
            this.cmgbotones.Controls.Add(this.cmdstart);
            this.cmgbotones.Controls.Add(this.cmdcargar);
            this.cmgbotones.Location = new System.Drawing.Point(285, 281);
            this.cmgbotones.Name = "cmgbotones";
            this.cmgbotones.Size = new System.Drawing.Size(205, 100);
            this.cmgbotones.TabIndex = 6;
            this.cmgbotones.TabStop = false;
            this.cmgbotones.Text = "botones";
            // 
            // wwindowsm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.reproductorwmp);
            this.Controls.Add(this.cmgbotones);
            this.Name = "wwindowsm";
            this.Text = "wwindowsm";
            ((System.ComponentModel.ISupportInitialize)(this.reproductorwmp)).EndInit();
            this.cmgbotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer reproductorwmp;
        private System.Windows.Forms.Button cmdcargar;
        private System.Windows.Forms.OpenFileDialog ofdcargador;
        private System.Windows.Forms.Button cmdstart;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.GroupBox cmgbotones;
    }
}