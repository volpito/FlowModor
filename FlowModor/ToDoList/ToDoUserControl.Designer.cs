namespace FlowModor.ToDoList
{
    partial class ToDoUserControl
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
            this.ToDoTextBox = new System.Windows.Forms.RichTextBox();
            this.ToDoLabel = new System.Windows.Forms.Label();
            this.ToDoCheckBox = new System.Windows.Forms.CheckedListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToDoTextBox
            // 
            this.ToDoTextBox.Location = new System.Drawing.Point(6, 16);
            this.ToDoTextBox.Name = "ToDoTextBox";
            this.ToDoTextBox.Size = new System.Drawing.Size(311, 25);
            this.ToDoTextBox.TabIndex = 0;
            this.ToDoTextBox.Text = "";
            // 
            // ToDoLabel
            // 
            this.ToDoLabel.AutoSize = true;
            this.ToDoLabel.Location = new System.Drawing.Point(3, 0);
            this.ToDoLabel.Name = "ToDoLabel";
            this.ToDoLabel.Size = new System.Drawing.Size(84, 13);
            this.ToDoLabel.TabIndex = 1;
            this.ToDoLabel.Text = "Add a new task ";
            // 
            // ToDoCheckBox
            // 
            this.ToDoCheckBox.FormattingEnabled = true;
            this.ToDoCheckBox.Location = new System.Drawing.Point(6, 76);
            this.ToDoCheckBox.Name = "ToDoCheckBox";
            this.ToDoCheckBox.Size = new System.Drawing.Size(311, 259);
            this.ToDoCheckBox.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(227, 47);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(227, 340);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(90, 23);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // ToDoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ToDoCheckBox);
            this.Controls.Add(this.ToDoLabel);
            this.Controls.Add(this.ToDoTextBox);
            this.Name = "ToDoUserControl";
            this.Size = new System.Drawing.Size(320, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ToDoTextBox;
        private System.Windows.Forms.Label ToDoLabel;
        private System.Windows.Forms.CheckedListBox ToDoCheckBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
    }
}
