using System;
using System.Windows.Forms;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

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

            // Get instance username and password
            String username = "kieran.holmes@dc-it.co.uk";                                  // usernameField.Text;
            String password = "K!ieran101";                                                 // passwordField.Text;
            String environment = "https://dcmisdev.api.crm4.dynamics.com/api/data/v8.2/";   // environmentField.Text;

            // Create message box
            DialogResult logonOutput;

            // Buttons for message box
            MessageBoxButtons OKButtons = MessageBoxButtons.OK;
            MessageBoxButtons retryButtons = MessageBoxButtons.RetryCancel;

            // Get the CRM connection string and connect to the CRM Organization
            CrmServiceClient crmConn = new CrmServiceClient("AuthType = Office365; Url =" + environment + "; Username=" + username + "; Password=" + password + "");
            IOrganizationService crmService = crmConn.OrganizationServiceProxy;


            if (crmConn.IsReady)
            {
                
                // Create a column set to define which attributes should be retrieved.
                ColumnSet attributes = new ColumnSet(new string[] { "title", "ticketnumber" });

                // Retrieve the caseID and its name and ownerid attributes.
                Entity caseID = crmService.Retrieve("incident", new Guid("CFA8B94E-C81D-E711-80FF-5065F38BD4E1"), attributes);
                Console.Write("retrieved, ");

                // Update the postal code attribute.
                caseID["description"] = "Connected Successfully";
      

                // Update the Case.
                crmService.Update(caseID);
                Console.WriteLine("and updated.");

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
