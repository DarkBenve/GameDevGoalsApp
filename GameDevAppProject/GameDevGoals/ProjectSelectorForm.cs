using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GameDevGoals
{
    public partial class ProjectSelectorForm : Form
    {
        private readonly string dataDir =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GoalChecklist");
        private string ProjectsFile => Path.Combine(dataDir, "projects.json");
        private List<string> projects = new List<string>();

        public string SelectedProject { get; private set; }

        public ProjectSelectorForm()
        {
            InitializeComponent();
            Directory.CreateDirectory(dataDir);
            LoadProjects();
        }

        private void LoadProjects()
        {
            listBoxProjects.Items.Clear();
            if (File.Exists(ProjectsFile))
            {
                var json = File.ReadAllText(ProjectsFile);
                projects = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();
            }
            foreach (var p in projects)
                listBoxProjects.Items.Add(p);
        }

        private void SaveProjects()
        {
            var json = JsonConvert.SerializeObject(projects, Formatting.Indented);
            File.WriteAllText(ProjectsFile, json);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var name = textBoxProjectName.Text.Trim();
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (!projects.Contains(name))
                {
                    projects.Add(name);
                    SaveProjects();
                    LoadProjects();
                }
                SelectedProject = name;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void listBoxProjects_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedItem != null)
            {
                SelectedProject = listBoxProjects.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedItem != null)
            {
                var name = listBoxProjects.SelectedItem.ToString();
                projects.Remove(name);
                SaveProjects();
                LoadProjects();
            }
        }
    }
}