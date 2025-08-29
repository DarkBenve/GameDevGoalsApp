using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace GameDevGoals
{
    public partial class GameDevGoals : Form
    {
        private readonly string dataDir =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GoalChecklist");
        private string DataFile => Path.Combine(dataDir, "goals.json");

        public GameDevGoals()
        {
            InitializeComponent();

            // Eventi aggiuntivi comodi:
            checkedListBoxGoals.ItemCheck += CheckedListBoxGoals_ItemCheck;
            this.Load += Form1_Load;
            textBoxNewGoal.KeyDown += TextBoxNewGoal_KeyDown;
            buttonAdd.Click += btnAdd_Click;
            btnRemoveChecked.Click += btnRemoveChecked_Click;
            btnClearAll.Click += btnClearAll_Click;

            UpdateCounters();
        }

        // MODEL
        public class GoalItem
        {
            public string Text { get; set; } = "";
            public bool Done { get; set; }
        }

        // EVENTS
        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(dataDir);
            LoadFromDisk();
        }

        private void TextBoxNewGoal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var text = textBoxNewGoal.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            checkedListBoxGoals.Items.Add(text, false);
            textBoxNewGoal.Clear();

            SaveToDisk();
            UpdateCounters();
        }

        private void CheckedListBoxGoals_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // ItemCheck scatta PRIMA che lo stato cambi: rinvia l'azione a dopo l'aggiornamento
            BeginInvoke(new Action(() =>
            {
                SaveToDisk();
                UpdateCounters();
            }));
        }

        private void btnRemoveChecked_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBoxGoals.CheckedIndices.Count - 1; i >= 0; i--)
                checkedListBoxGoals.Items.RemoveAt(checkedListBoxGoals.CheckedIndices[i]);

            SaveToDisk();
            UpdateCounters();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (checkedListBoxGoals.Items.Count == 0) return;

            if (MessageBox.Show("Sei sicuro di voler svuotare la lista?",
                                "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                checkedListBoxGoals.Items.Clear();
                SaveToDisk();
                UpdateCounters();
            }
        }

        // PERSISTENZA
       private void SaveToDisk()
{
    try
    {
        Directory.CreateDirectory(dataDir);

        var list = new List<GoalItem>();
        for (int i = 0; i < checkedListBoxGoals.Items.Count; i++)
        {
            list.Add(new GoalItem
            {
                Text = checkedListBoxGoals.Items[i]?.ToString() ?? "",
                Done = checkedListBoxGoals.GetItemChecked(i)
            });
        }

        var json = JsonConvert.SerializeObject(list, Formatting.Indented);
        File.WriteAllText(DataFile, json);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Errore nel salvataggio: " + ex.Message);
    }
}

private void LoadFromDisk()
{
    try
    {
        checkedListBoxGoals.Items.Clear();

        if (!File.Exists(DataFile)) { UpdateCounters(); return; }

        var json = File.ReadAllText(DataFile);
        var list = JsonConvert.DeserializeObject<List<GoalItem>>(json) ?? new List<GoalItem>();

        foreach (var item in list)
            checkedListBoxGoals.Items.Add(item.Text, item.Done);

        UpdateCounters();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Errore nel caricamento: " + ex.Message);
    }
}

        // UI HELPERS
        private void UpdateCounters()
        {
            int total = checkedListBoxGoals.Items.Count;
            int done = checkedListBoxGoals.CheckedItems.Count;
            labelCounters.Text = $"Completati: {done}/{total}";
        }

        private void checkedListBoxGoals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
