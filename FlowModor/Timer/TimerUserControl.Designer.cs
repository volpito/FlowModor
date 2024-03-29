﻿using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FlowModor.Timer
{
    partial class TimerUserControl
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
            this.components = new System.ComponentModel.Container();
            this.StartBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimerTextBox = new System.Windows.Forms.RichTextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(290, 158);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerTextBox.Location = new System.Drawing.Point(0, 0);
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.ReadOnly = true;
            this.TimerTextBox.Size = new System.Drawing.Size(449, 152);
            this.TimerTextBox.TabIndex = 3;
            this.TimerTextBox.Text = "00:00:00";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(371, 158);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // TimerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.TimerTextBox);
            this.Controls.Add(this.StartBtn);
            this.Name = "TimerUserControl";
            this.Size = new System.Drawing.Size(449, 184);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RichTextBox TimerTextBox;
        private Button ResetBtn;
    }
}
