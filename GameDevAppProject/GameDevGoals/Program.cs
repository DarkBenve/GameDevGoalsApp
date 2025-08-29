using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDevGoals
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (var selector = new ProjectSelectorForm())
                {
                    if (selector.ShowDialog() == DialogResult.OK)
                    {
                        var goalsForm = new GameDevGoals(selector.SelectedProject);
                        goalsForm.Show();

                        Application.Run(goalsForm);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
