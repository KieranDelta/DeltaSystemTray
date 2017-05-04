using System;
using System.Windows.Forms;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using CredentialManagement;

namespace DeltaSystemTray
{
    public partial class Settings : Form
    {

        // Start

        // Get instance username and password
        String username = "kieran.holmes@dc-it.co.uk";
        String password;
        String environment = "https://dcmisdev.api.crm4.dynamics.com/api/data/v8.2/";


        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            using (var cred = new Credential())
            {

                cred.Target = "Fabric Time Recording App";

                // If credentials are found
                if (cred.Exists())
                {
                    cred.Load();
                    username = cred.Username;
                    password = cred.Password;

                    //Hide/lock login related fields
                    passwordLabel.Visible = false;
                    passwordField.Visible = false;
                    connectButton.Visible = false;
                    environmentField.Text = environment;
                    usernameField.Text = username;
                    environmentField.Enabled = false;
                    usernameField.Enabled = false;

                    // Set Logged in/out messages
                    loggedOutMessage.Visible = false;
                    loggedInLabel.Visible = true;
                    userLoggedInLabel.Visible = true;
                    userLoggedInLabel.Text = username;
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            // DEV REMOVE
            password = passwordField.Text;
            environment = "https://dcmisdev.api.crm4.dynamics.com/api/data/v8.2/";   // environmentField.Text;


            using (var cred = new Credential())
            {
                if (!usernameField.Text.Equals(null) && !passwordField.Text.Equals(null))
                {
                    // Store username and password in credential manager
                    cred.Username = username;
                    cred.Password = password;
                    cred.Target = "Fabric Time Recording App";
                    cred.Type = CredentialType.Generic;
                    cred.PersistanceType = PersistanceType.LocalComputer;
                    cred.Save();

                    // Create message box
                    System.Windows.Forms.DialogResult logonOutput;

                    // Buttons for message box
                    MessageBoxButtons OKButtons = MessageBoxButtons.OK;
                    MessageBoxButtons retryButtons = MessageBoxButtons.RetryCancel;

                    // Get the CRM connection string and connect to the CRM Organization
                    CrmServiceClient crmConn = new CrmServiceClient("AuthType = Office365; Url =" + environment + "; Username=" + username + "; Password=" + password + "");
                    IOrganizationService crmService = crmConn.OrganizationServiceProxy;


                    if (crmConn.IsReady)
                    {

                        // Create a column set to define which attributes should be retrieved.
                        ColumnSet caseAttributes = new ColumnSet(new string[] { "title", "ticketnumber" });
                        ColumnSet timeRecordAttributes = new ColumnSet(new string[] { "subject", "new_caseid", "regardingobjectid" });

                        // Retrieve the caseID and its name and ownerid attributes.
                        Entity caseID = crmService.Retrieve("incident", new Guid("CFA8B94E-C81D-E711-80FF-5065F38BD4E1"), caseAttributes);
                        Console.Write("Retrieved Case: " + caseAttributes.ToString() + ".");

                        // Update the postal code attribute.
                        caseID["description"] = "Connected Successfully";



                        // Update the Case.
                        crmService.Update(caseID);
                        Console.WriteLine("\n Updated Case: " + caseAttributes.ToString() + ".");

                        // Successful login box
                        logonOutput = MessageBox.Show("Successfully connected to Dynamics 365", "Connected", OKButtons);

                        //Hide/lock login related fields
                        passwordLabel.Visible = false;
                        passwordField.Visible = false;
                        connectButton.Visible = false;
                        environmentField.Text = environment;
                        usernameField.Text = username;
                        environmentField.Enabled = false;
                        usernameField.Enabled = false;

                        // Set Logged in/out messages
                        loggedOutMessage.Visible = false;
                        loggedInLabel.Visible = true;
                        userLoggedInLabel.Visible = true;
                        userLoggedInLabel.Text = username;
                    }
                    else
                    {
                        // Failed login box
                        logonOutput = MessageBox.Show("Please check your credentials and try again", "Failed To Connect", retryButtons);

                        // Set Logged in/out messages
                        loggedOutMessage.Visible = true;
                        loggedInLabel.Visible = false;
                        userLoggedInLabel.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in Username and Password");
                }
            }

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            using (var cred = new Credential())
            {
                // Remove stored credentials for this user
                cred.Target = "Fabric Time Recording App";
                cred.Delete();

                //Show/unlock login related fields
                passwordLabel.Visible = true;
                passwordField.Visible = true;
                connectButton.Visible = true;
                environmentField.Enabled = true;
                usernameField.Enabled = true;

                // Set Logged in/out messages
                loggedOutMessage.Visible = true;
                loggedInLabel.Visible = false;
                userLoggedInLabel.Visible = false;
            }
        }
    }
}
