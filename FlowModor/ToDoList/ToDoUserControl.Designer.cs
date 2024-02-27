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
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ToDoFolv = new BrightIdeasSoftware.FastObjectListView();
            this.TaskName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.ToDoFolv)).BeginInit();
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
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(227, 47);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(227, 340);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(90, 23);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ToDoFolv
            // 
            this.ToDoFolv.AllColumns.Add(this.TaskName);
            this.ToDoFolv.AllColumns.Add(this.Status);
            this.ToDoFolv.CellEditUseWholeCell = false;
            this.ToDoFolv.CheckBoxes = true;
            this.ToDoFolv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskName,
            this.Status});
            this.ToDoFolv.Cursor = System.Windows.Forms.Cursors.Default;
            this.ToDoFolv.HideSelection = false;
            this.ToDoFolv.Location = new System.Drawing.Point(6, 76);
            this.ToDoFolv.Name = "ToDoFolv";
            this.ToDoFolv.ShowGroups = false;
            this.ToDoFolv.ShowImagesOnSubItems = true;
            this.ToDoFolv.Size = new System.Drawing.Size(311, 258);
            this.ToDoFolv.TabIndex = 5;
            this.ToDoFolv.UseCompatibleStateImageBehavior = false;
            this.ToDoFolv.View = System.Windows.Forms.View.Details;
            this.ToDoFolv.VirtualMode = true;
            this.ToDoFolv.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Task_Check);
            // 
            // TaskName
            // 
            this.TaskName.AspectName = "TaskName";
            this.TaskName.Text = "Task";
            this.TaskName.Width = 240;
            // 
            // Status
            // 
            this.Status.AspectName = "Status";
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToDoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToDoFolv);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ToDoLabel);
            this.Controls.Add(this.ToDoTextBox);
            this.Name = "ToDoUserControl";
            this.Size = new System.Drawing.Size(320, 366);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoFolv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ToDoTextBox;
        private System.Windows.Forms.Label ToDoLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private BrightIdeasSoftware.FastObjectListView ToDoFolv;
        private BrightIdeasSoftware.OLVColumn TaskName;
        private BrightIdeasSoftware.OLVColumn Status;
    }
}
