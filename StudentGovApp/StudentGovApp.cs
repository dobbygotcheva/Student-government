using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizationNamespace;
using IntramularNamespace;
using ClubDLLNamespace; // Namespace for Club class
using IntramularNamespace; // Namespace for Intramural class
using FratSororityDLLNamespace; // Namespace for FratSorority class
using PresentationGUI;

namespace StudentGovApp
{
    public partial class StudentGovApp : Form
    {
        // Object of Club class declared
        private Club aClub;
        // Object of Intramural class declared
        private Intramural aTeam;
        // Object of FratSorority class declared
        private FratSorority aFratSorority;
        public StudentGovApp()
        {
            InitializeComponent();
        }

        private void StudentGovApp_Load(object sender, EventArgs e)
        {
            aClub = new Club ("ACM", "Jones", "Davis 203", "Tues", "12:30");
            aFratSorority = new FratSorority ("Delta PI", "Brenda Wynn", true, "86 SmithField");
            aTeam = new Intramural("Winners", "Joe Kitchen", "VolleyBall");
        }

        private void radBtnIntr_CheckedChanged(object sender, EventArgs e)
        {
            txtBxName.Text = aTeam.OrgName;
            txtBxFund.Text = aTeam.FundedAmt.ToString("C");
            ShowDetails();
        }

        private void radBtnClub_CheckedChanged(object sender, EventArgs e)
        {
            txtBxName.Text = aClub.OrgName;
            aClub.SetFundingAmt();
            txtBxFund.Text = aClub.FundedAmt.ToString("C");
            ShowDetails();
        }

        private void radBtnFratSor_CheckedChanged(object sender, EventArgs e)
        {
            txtBxName.Text = aFratSorority.OrgName;
            aFratSorority.SetFundingAmt();
            txtBxFund.Text =
            aFratSorority.FundedAmt.ToString("C");
            ShowDetails();
        }

        // Area at the bottom of the form initally set to
        // Visible = false using the Properties window.
        // Because each of the RadioButton objects needed to reset
        // the objects to Visible = true, a method is used.
        public void ShowDetails()
        {
            txtBxName.Visible = true;
            lblName.Visible = true;
            txtBxFund.Visible = true;
            lblFundedAmt.Visible = true;
        }
    }
}
