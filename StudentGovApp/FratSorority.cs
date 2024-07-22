using PresentationGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGovApp
{
    internal class FratSorority : Organization, IFunding
    {
        private bool chartered; // Private member data
        private string houseAddress;
        public FratSorority()
        {
            houseAddress = "unknown";
            chartered = false;
        }
        public FratSorority(string name, string pContact,
        bool isChartered, string address)
        : base(name, pContact)
        // Call to base constructor
        {
            houseAddress = address;
            chartered = isChartered;
        }
        // Required method - because of interface
        public void SetFundingAmt()
        {
            if (chartered)
            {
                FundedAmt = 500M;
            }
            else
            {
                FundedAmt = 0M;
            }
        }
        // Properties
        private bool Chartered
        {
            get
            {
                return chartered;
            }
            set
            {
                chartered = value;
            }
        }

        private string HouseAddress
        {
            get
            {
                return houseAddress;
            }
            set
            {
                houseAddress = value;
            }
        }
    }
}
