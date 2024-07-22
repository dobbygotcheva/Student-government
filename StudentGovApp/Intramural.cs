using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationGUI
{
    internal class Intramural : Organization
    {
        private string sportType;
        public Intramural(string name, string pContact,
        string sport)
        // Call to Organization (base) class constructor
        : base(name, pContact)
        {
            sportType = sport;
        }
        // Default constructor
        public Intramural()
        {
            sportType = "unknown";
        }
        // Property for sportType
        public string SportType
        {
            get
            {
                return sportType;
            }
            set
            {
                sportType = value;
            }
        }
    }
}
