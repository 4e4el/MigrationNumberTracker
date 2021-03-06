﻿using System.Windows.Forms;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;

namespace MigrationNumberTracker.ResharperPlugin
{
    [ActionHandler("MigrationNumberTracker.ResharperPlugin.About")]
    public class AboutAction : IActionHandler
    {
        public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
        {
            // return true or false to enable/disable this action
            return true;
        }

        public void Execute(IDataContext context, DelegateExecute nextExecute)
        {
            MessageBox.Show(
              "MigrationNumberTracker.ResharperPlugin\nSPCPH\\ale\n\nMigrationNumberTracker.ResharperPlugin",
              "About MigrationNumberTracker.ResharperPlugin",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
        }
    }
}