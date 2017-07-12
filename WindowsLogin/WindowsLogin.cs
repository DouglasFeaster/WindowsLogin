using System;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace WindowsLogin
{
    public partial class frmWindowsLogin : Form
    {
        // Native Windows Library for user accounts
        [DllImport("advapi32.dll")]
        public static extern bool LogonUser(string userName, string domainName, string password, int LogonType, int LogonProvider, ref IntPtr phToken);

        public frmWindowsLogin()
        {
            InitializeComponent();
        }

        private void frmWindowsLogin_Load(object sender, EventArgs e)
        {
            // Gets current domain and sends it to the Combobox in Uppercase
            cbxDomain.Items.Add(GetDomain().ToUpper());

            // Makes sure a domian is selected by default
            cbxDomain.SelectedIndex = 0;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool issuccess = false;
            string username = GetloggedinUserName();

            // If username of current Windows user does not match the username of the person logging into the application 
            // and if the current Windows user does not belong to the correct security group then the login will fail.
            if (username.ToLowerInvariant().Contains(tbUsername.Text.Trim().ToLowerInvariant()) && username.ToLowerInvariant().Contains(cbxDomain.Text.Trim().ToLowerInvariant()) && SecGroupMember() == true)
            {
                // The given credentials will be validated using the Native Windows Library for user accounts and return a True or False
                issuccess = IsValidateCredentials(tbUsername.Text.Trim(), mtbPassword.Text.Trim(), cbxDomain.Text.Trim());

                // If the Native Windows Library returns a True then the program will open the specified main form
                if (issuccess)
                {
                    // Insert Form here \/
                    MessageBox.Show("Success!");
                    /*
                      // Creates new Form object
                      Form form = new frmform();
                      // Hides Login Form
                      this.Hide();
                      // Opens created Form object
                      frmform.Show();
                    */
                }
            }
            
            else
            {
                // If the given credentials are not valid, meaning False, then the error message with appear
                MessageBox.Show("User Name or Password is invalid!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Retreives the username of the current Windows user and returns it
        private string GetloggedinUserName()
        {
            // Current user
            WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
            // Separates and returns current Username
            return currentUser.Name;
        }

        // Runs the given credentials through the Native Windows Library and return a True or False
        private bool IsValidateCredentials(string userName, string password, string domain)
        {
            // User security token
            IntPtr tokenHandler = IntPtr.Zero;
            // Given credentials run through Native Windows Library and returns True or False
            bool isValid = LogonUser(userName, domain, password, 2, 0, ref tokenHandler);
            // Returns True or False value
            return isValid;
        }

        // Checks that the current Windows user is a member of the JU_Applications Security group
        private bool SecGroupMember()
        {
            // Current user
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            // Current user's group information
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            // Confirms membership
            return principal.IsInRole("Security Group Here");
        }

        // Gets and returns current Window Domain name
        private string GetDomain()
        {
            // Gets Window Domain name
            string domain = Domain.GetComputerDomain().ToString();

            // Domain is @.local e.g. campus.local
            if (domain.Contains(".local"))
            {
                // .local is then removed from domain string
                domain = domain.Replace(".local", "");
            }

            // domain name is returned
            return domain;
        }
    }
}
