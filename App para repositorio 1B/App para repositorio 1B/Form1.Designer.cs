namespace App_para_repositorio_1B
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
            this.bPonerMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPonerMensaje
            // 
            this.bPonerMensaje.Location = new System.Drawing.Point(12, 28);
            this.bPonerMensaje.Name = "bPonerMensaje";
            this.bPonerMensaje.Size = new System.Drawing.Size(129, 92);
            this.bPonerMensaje.TabIndex = 0;
            this.bPonerMensaje.Text = "Mensaje";
            this.bPonerMensaje.UseVisualStyleBackColor = true;
            this.bPonerMensaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 478);
            this.Controls.Add(this.bPonerMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPonerMensaje;
    }
}

