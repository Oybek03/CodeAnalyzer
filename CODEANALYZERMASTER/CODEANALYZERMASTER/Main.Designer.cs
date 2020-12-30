namespace CODEANALYZERMASTER
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
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.Maroon;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(283, 124);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(176, 57);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Static Code Analyzer";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.Maroon;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCos.ForeColor = System.Drawing.Color.White;
            this.btnCos.Location = new System.Drawing.Point(283, 200);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(176, 57);
            this.btnCos.TabIndex = 1;
            this.btnCos.Text = "CosineSimilarity";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CODEANALYZERMASTER.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnAnalyze);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnCos;
    }
}