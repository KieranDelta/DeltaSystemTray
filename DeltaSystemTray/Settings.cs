using System;
using System.Windows.Forms;
using Microsoft;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using System.Configuration;

namespace DeltaSystemTray
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Create message box
            DialogResult logonOutput;

            // Buttons for message box
            MessageBoxButtons OKButtons = MessageBoxButtons.OK;
            MessageBoxButtons retryButtons = MessageBoxButtons.RetryCancel;

            // Get the CRM connection string and connect to the CRM Organization
            CrmServiceClient crmConn = new CrmServiceClient(ConfigurationManager.ConnectionStrings["D365"].ConnectionString);
            IOrganizationService crmService = crmConn.OrganizationServiceProxy;


            if (crmConn.IsReady)
            {
                Entity acc = new Entity("account");
                acc["name"] = "System Tray's New Account";
                crmService.Create(acc);

                // Successful login box
                logonOutput = MessageBox.Show("Successfully connected to Dynamics 365", "Connected", OKButtons);
            }
            else
            {
                // Failed login box
                logonOutput = MessageBox.Show("Please check your credentials and try again", "Failed To Connect", retryButtons);
            }
        }
    }
}
