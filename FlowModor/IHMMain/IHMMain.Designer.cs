namespace FlowModor
{
    partial class IHMMain
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TimerSplitPanel = new System.Windows.Forms.SplitContainer();
            this.timerUserControl1 = new FlowModor.Timer.TimerUserControl();
            this.ToDoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toDoUserControl1 = new FlowModor.ToDoList.ToDoUserControl();
            this.PBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBarUserControl1 = new FlowModor.ProgressBar.ProgressBarUserControl();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerSplitPanel)).BeginInit();
            this.TimerSplitPanel.Panel1.SuspendLayout();
            this.TimerSplitPanel.SuspendLayout();
            this.ToDoPanel.SuspendLayout();
            this.PBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TimerSplitPanel);
            this.MainPanel.Controls.Add(this.ToDoPanel);
            this.MainPanel.Controls.Add(this.PBarPanel);
            this.MainPanel.Location = new System.Drawing.Point(1, 1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(798, 446);
            this.MainPanel.TabIndex = 0;
            // 
            // TimerSplitPanel
            // 
            this.TimerSplitPanel.Location = new System.Drawing.Point(3, 3);
            this.TimerSplitPanel.Name = "TimerSplitPanel";
            this.TimerSplitPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TimerSplitPanel.Panel1
            // 
            this.TimerSplitPanel.Panel1.Controls.Add(this.timerUserControl1);
            this.TimerSplitPanel.Size = new System.Drawing.Size(455, 369);
            this.TimerSplitPanel.SplitterDistance = 195;
            this.TimerSplitPanel.TabIndex = 3;
            // 
            // timerUserControl1
            // 
            this.timerUserControl1.Location = new System.Drawing.Point(3, 8);
            this.timerUserControl1.Name = "timerUserControl1";
            this.timerUserControl1.Size = new System.Drawing.Size(449, 184);
            this.timerUserControl1.TabIndex = 0;
            // 
            // ToDoPanel
            // 
            this.ToDoPanel.Controls.Add(this.toDoUserControl1);
            this.ToDoPanel.Location = new System.Drawing.Point(464, 3);
            this.ToDoPanel.Name = "ToDoPanel";
            this.ToDoPanel.Size = new System.Drawing.Size(330, 369);
            this.ToDoPanel.TabIndex = 1;
            // 
            // toDoUserControl1
            // 
            this.toDoUserControl1.Location = new System.Drawing.Point(3, 3);
            this.toDoUserControl1.Name = "toDoUserControl1";
            this.toDoUserControl1.Size = new System.Drawing.Size(327, 366);
            this.toDoUserControl1.TabIndex = 0;
            // 
            // PBarPanel
            // 
            this.PBarPanel.Controls.Add(this.progressBarUserControl1);
            this.PBarPanel.Location = new System.Drawing.Point(3, 378);
            this.PBarPanel.Name = "PBarPanel";
            this.PBarPanel.Size = new System.Drawing.Size(792, 68);
            this.PBarPanel.TabIndex = 2;
            // 
            // progressBarUserControl1
            // 
            this.progressBarUserControl1.Location = new System.Drawing.Point(3, 3);
            this.progressBarUserControl1.Name = "progressBarUserControl1";
            this.progressBarUserControl1.Size = new System.Drawing.Size(788, 66);
            this.progressBarUserControl1.TabIndex = 0;
            // 
            // IHMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "IHMMain";
            this.Text = "FlowModor";
            this.MainPanel.ResumeLayout(false);
            this.TimerSplitPanel.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimerSplitPanel)).EndInit();
            this.TimerSplitPanel.ResumeLayout(false);
            this.ToDoPanel.ResumeLayout(false);
            this.PBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.FlowLayoutPanel PBarPanel;
        private System.Windows.Forms.FlowLayoutPanel ToDoPanel;
        private System.Windows.Forms.SplitContainer TimerSplitPanel;
        private Timer.TimerUserControl timerUserControl1;
        private ProgressBar.ProgressBarUserControl progressBarUserControl1;
        private ToDoList.ToDoUserControl toDoUserControl1;
    }
}

