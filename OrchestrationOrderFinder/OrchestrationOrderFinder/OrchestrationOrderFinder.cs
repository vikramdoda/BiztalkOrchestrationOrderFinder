using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.BizTalk.ExplorerOM;
using PresentationControls;
using Application = Microsoft.BizTalk.ExplorerOM.Application;

namespace OrchestrationOrderFinder
{
    public partial class OrchestrationOrderFinder : Form
    {
        private readonly List<BtsOrchestration> _traversedOrchestrations = new List<BtsOrchestration>();

        public OrchestrationOrderFinder()
        {
            InitializeComponent();
            tbServer.Text = @"localhost";
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbServer.Text))
            {
                MessageBox.Show(@"Server name should not be empty");
            }
            else
            {
                string connectionString = string.Format("SERVER={0};DATABASE=BizTalkMgmtDb;Integrated Security=SSPI",
                    tbServer.Text);
                var catalog = new BtsCatalogExplorer
                {
                    ConnectionString = connectionString
                };
                List<Application> apps = catalog.Applications.Cast<Application>().ToList();
                var appSelections = new ListSelectionWrapper<Application>(apps, "Name");

                ddlApplications.DataSource = appSelections;
                ddlApplications.DisplayMemberSingleItem = "Name";
                ddlApplications.DisplayMember = "NameConcatenated";
                ddlApplications.ValueMember = "Selected";
            }
        }

        private void btnAssemblies_Click(object sender, EventArgs e)
        {
            List<Application> applications =
                ddlApplications.CheckBoxItems.Where(x => x.Checked)
                    .Select(x => ((ObjectSelectionWrapper<Application>)x.ComboBoxItem).Item)
                    .ToList();
            var assemblies = new List<BtsAssembly>();
            foreach (Application application in applications)
            {
                assemblies.AddRange(application.Assemblies.Cast<BtsAssembly>().ToList());
            }

            var assemblySelections = new ListSelectionWrapper<BtsAssembly>(assemblies, "Name");

            ddlAssemblies.DataSource = assemblySelections;
            ddlAssemblies.DisplayMemberSingleItem = "Name";
            ddlAssemblies.DisplayMember = "NameConcatenated";
            ddlAssemblies.ValueMember = "Selected";
        }

        private void btnOrchestraions_Click(object sender, EventArgs e)
        {
            List<BtsAssembly> assemblies =
                ddlAssemblies.CheckBoxItems.Where(x => x.Checked)
                    .Select(x => ((ObjectSelectionWrapper<BtsAssembly>)x.ComboBoxItem).Item)
                    .ToList();

            var list = new List<BtsOrchestration>();
            foreach (var assembly in assemblies)
            {
                list.AddRange(assembly.Orchestrations.Cast<BtsOrchestration>().ToList());
            }

            var computedList = new List<BtsOrchestration>();
            foreach (var btsOrchestration in list)
            {
                if (computedList.All(x => x.FullName != btsOrchestration.FullName))
                {
                    computedList.Add(btsOrchestration);
                    AddRange(computedList, btsOrchestration);
                }
            }

            BindOrcestrationsGrid(computedList);
        }

        private void BindOrcestrationsGrid(IEnumerable<BtsOrchestration> orchestrations)
        {
            var orchestrationModels = new BindingList<OrchestrationModel>();
            foreach (BtsOrchestration orchestration in orchestrations)
            {
                var orchestrationModel = new OrchestrationModel
                {
                    ApplicationName = orchestration.Application.Name,
                    AssemblyName = orchestration.BtsAssembly.Name,
                    OrchestrationName = orchestration.FullName.Substring(orchestration.FullName.LastIndexOf('.') + 1)
                };

                orchestrationModels.Add(orchestrationModel);
            }
            dgvOrchestrations.DataSource = orchestrationModels;
        }

        private void btnOrderOrchestrations_Click(object sender, EventArgs e)
        {
            List<BtsAssembly> assemblies =
                ddlAssemblies.CheckBoxItems.Where(x => x.Checked)
                    .Select(x => ((ObjectSelectionWrapper<BtsAssembly>)x.ComboBoxItem).Item)
                    .ToList();

            var list = new List<BtsOrchestration>();
            foreach (var assembly in assemblies)
            {
                list.AddRange(assembly.Orchestrations.Cast<BtsOrchestration>().ToList());
            }

            var computedList = new List<BtsOrchestration>();
            foreach (var btsOrchestration in list)
            {
                if (computedList.All(x => x.FullName != btsOrchestration.FullName))
                {
                    computedList.Add(btsOrchestration);
                    AddRange(computedList, btsOrchestration);
                }
            }

            
            foreach (BtsOrchestration orchestration in computedList)
            {
                if (_traversedOrchestrations.Count > 0)
                {
                    int index = _traversedOrchestrations.FindIndex(c => c.FullName == orchestration.FullName);

                    if (index < 0)
                    {
                        int dependIndex = CheckDepenciesPrevious(orchestration);
                        if (dependIndex < 0)
                        {
                            _traversedOrchestrations.Add(orchestration);
                        }
                        else
                        {
                            _traversedOrchestrations.Insert(dependIndex, orchestration);
                        }
                    }
                }
                else
                {
                    _traversedOrchestrations.Add(orchestration);
                }
            }

            BindOrcestrationsGrid(_traversedOrchestrations);

            _traversedOrchestrations.Clear();
        }

        private void AddRange(List<BtsOrchestration> computedList, BtsOrchestration btsOrchestration)
        {
            foreach (BtsOrchestration orch in btsOrchestration.InvokedOrchestrations)
            {
                if (computedList.All(x => x.FullName != orch.FullName))
                {
                    computedList.Add(orch);
                }

                AddRange(computedList, orch);
            }
        }

        private int CheckDepenciesPrevious(BtsOrchestration invokedOrchestration)
        {
            int index = -1;
            foreach (BtsOrchestration orchestration in invokedOrchestration.InvokedOrchestrations)
            {
                for (int i = 0; i < _traversedOrchestrations.Count; i++)
                {
                    if (_traversedOrchestrations[i].FullName == orchestration.FullName)
                    {
                        if ((index != -1 && index > i) || index == -1)
                        {
                            index = i;
                        }
                    }
                }
            }

            return index;
        }
    }
}