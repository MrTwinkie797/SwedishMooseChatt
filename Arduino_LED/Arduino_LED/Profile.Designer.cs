namespace Arduino_LED
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            this.ReturnToChatt = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // ReturnToChatt
            // 
            this.ReturnToChatt.Location = new System.Drawing.Point(12, 545);
            this.ReturnToChatt.Name = "ReturnToChatt";
            this.ReturnToChatt.Size = new System.Drawing.Size(114, 95);
            this.ReturnToChatt.TabIndex = 0;
            this.ReturnToChatt.Text = "Back";
            this.ReturnToChatt.UseVisualStyleBackColor = true;
            this.ReturnToChatt.Click += new System.EventHandler(this.ReturnToChatt_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 652);
            this.Controls.Add(this.ReturnToChatt);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnToChatt;
        public System.IO.Ports.SerialPort serialPort1;
    }
}