using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3_SEMESTRE.GerenciadorNavegacao
{
    internal class NavigationManager
    {
        private Panel mainPanel;
        private Form currentForm;

        public NavigationManager(Panel panel)
        {
            mainPanel = panel;
        }

        public void NavigateTo(Form newForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                mainPanel.Controls.Remove(currentForm);
            }

            currentForm = newForm;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();
        }
    }
}