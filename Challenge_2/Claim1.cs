using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public enum ClaimType
    {
        Car = 1, Home, Theft
    }
    public class ClaimRepo
    {
        public ClaimRepo(DateTime dateAndTimeOfIncident)
        {
            DateAndTimeOfIncident = dateAndTimeOfIncident;
        }

        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateAndTimeOfIncident { get; set; }
        public DateTime DateReportedToInsurance { get; set; }
        public TimeSpan TimeBetweenIncidentAndClaim => DateReportedToInsurance - DateAndTimeOfIncident;

        private bool _isValid;

        public bool IsValid
        {
            get => _isValid;

            set
            {
                if (TimeBetweenIncidentAndClaim.Days < 30)
                    _isValid = true;

                else if (TimeBetweenIncidentAndClaim.Days < 30)
                    _isValid = false;
            }
        }

    }
}
