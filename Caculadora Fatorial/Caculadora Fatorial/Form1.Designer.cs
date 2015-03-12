namespace Caculadora_Fatorial
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
            this.viewValue = new System.Windows.Forms.Label();
            this.bIterativa = new System.Windows.Forms.Button();
            this.bRecursiva = new System.Windows.Forms.Button();
            this.enterValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // viewValue
            // 
            this.viewValue.AutoSize = true;
            this.viewValue.Location = new System.Drawing.Point(114, 197);
            this.viewValue.Name = "viewValue";
            this.viewValue.Size = new System.Drawing.Size(0, 13);
            this.viewValue.TabIndex = 0;
            // 
            // bIterativa
            // 
            this.bIterativa.Location = new System.Drawing.Point(37, 124);
            this.bIterativa.Name = "bIterativa";
            this.bIterativa.Size = new System.Drawing.Size(75, 23);
            this.bIterativa.TabIndex = 1;
            this.bIterativa.Text = "Iterativa";
            this.bIterativa.UseVisualStyleBackColor = true;
            this.bIterativa.Click += new System.EventHandler(this.bIterativa_Click);
            // 
            // bRecursiva
            // 
            this.bRecursiva.Location = new System.Drawing.Point(172, 124);
            this.bRecursiva.Name = "bRecursiva";
            this.bRecursiva.Size = new System.Drawing.Size(75, 23);
            this.bRecursiva.TabIndex = 2;
            this.bRecursiva.Text = "Recursiva";
            this.bRecursiva.UseVisualStyleBackColor = true;
            this.bRecursiva.Click += new System.EventHandler(this.bRecursiva_Click);
            // 
            // enterValue
            // 
            this.enterValue.Location = new System.Drawing.Point(96, 69);
            this.enterValue.Name = "enterValue";
            this.enterValue.Size = new System.Drawing.Size(100, 20);
            this.enterValue.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.enterValue);
            this.Controls.Add(this.bRecursiva);
            this.Controls.Add(this.bIterativa);
            this.Controls.Add(this.viewValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewValue;
        private System.Windows.Forms.Button bIterativa;
        private System.Windows.Forms.Button bRecursiva;
        private System.Windows.Forms.TextBox enterValue;
    }
}

