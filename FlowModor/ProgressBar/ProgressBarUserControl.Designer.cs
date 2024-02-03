namespace FlowModor.ProgressBar
{
    partial class ProgressBarUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBarTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(782, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // ProgressBarTextBox
            // 
            this.ProgressBarTextBox.Enabled = false;
            this.ProgressBarTextBox.Location = new System.Drawing.Point(4, 4);
            this.ProgressBarTextBox.Name = "ProgressBarTextBox";
            this.ProgressBarTextBox.Size = new System.Drawing.Size(781, 20);
            this.ProgressBarTextBox.TabIndex = 1;
            // 
            // ProgressBarUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProgressBarTextBox);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressBarUserControl";
            this.Size = new System.Drawing.Size(788, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox ProgressBarTextBox;
    }
}
