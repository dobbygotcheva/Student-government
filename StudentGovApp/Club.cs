﻿using PresentationGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGovApp
{
    internal class Club : Organization, IFunding
    {
        // Private member data
        private string meetingLocation;
        private string meetingDay;
        private string meetingTime;
        public Club(string name, string pContact,
        string mLoc, string mDay, string mTime)
        // Call to base constructor
        : base(name, pContact)
        {
            meetingLocation = mLoc;
            meetingDay = mDay;
            meetingTime = mTime;
        }
        // Required method - because of interface
        public void SetFundingAmt()
        {
            FundedAmt = 600M;
        }
    }
}
