using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlowModor.ToDoList
{
    public partial class ToDoUserControl : UserControl
    {
        public List<FolvTask> Tasks { get; set; } = new List<FolvTask>();

        public ToDoUserControl()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ToDoTextBox.Text))
            {
                Tasks.Add(new FolvTask(ToDoTextBox.Text));

                this.ToDoFolv.SetObjects(Tasks);
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (ToDoFolv?.CheckedObjects.Count > 0)
            {
                for (int i = 0; i < ToDoFolv.CheckedObjects.Count; i++)
                {
                    var current = ToDoFolv.CheckedObjects[i] as FolvTask;
                    Tasks.Remove(current);
                }
            }
            else
            {
                if(MessageBox.Show("You will clear all items in the TODO List\rAre you sure ?", "Clear All", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Tasks.Clear();
            }

            ToDoFolv.SetObjects(Tasks);
        }

        private void Task_Check(object sender, ItemCheckEventArgs e)
        {
            if(e.CurrentValue == CheckState.Checked)
            {

            }

        }
    }

    public class FolvTask
    {
        public string TaskName { get; set; } = null;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public Status Status { get; set; } = Status.Created;
        public bool IsDone { get; set; } = false;

        public FolvTask(string taskName)
        {
            TaskName = taskName;
        }
    }
    public enum Status
    {
        Created,
        Open,
        InProgress,
        Done,
        WontDo,
        WaitingFor,
    }
}
