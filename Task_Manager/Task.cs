using System;
namespace Task_Manager
{
    public class Task
    {
        private string teamMemberName;
        private string description;
        private string dueDate;
        private bool completed;

        #region Properties
        public string TeamMemberName
        {
            get
            {
                return teamMemberName;
            }
            set
            {
                teamMemberName = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        public bool Completed
        {
            get
            {
                return completed;
            }
            set
            {
                completed = value;
            }
        }
        #endregion

        public Task(string teamMemberName, string description, string dueDate, bool completed)
        {
            this.teamMemberName = teamMemberName;
            this.description = description;
            this.dueDate = dueDate;
            this.completed = completed;
        }

        public override string ToString()
        {
            return $"Name: {TeamMemberName}\n" +
                $"Task Description: {Description}\n" +
                $"Due Date: {DueDate}\n" +
                $"Completed? {Completed}\n";
        }
    }
}
