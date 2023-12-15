// Nhia Vue
// Used for customer and doctor information
// 10/10/23
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppointment
{
    internal class AppointmentInformation
    {
        // properties
        private string cCustId;
        private string cName;
        private DateTime cAppDate;
        private DateTime cDateMade;
        private int cAge;
        private string cReason;
        private string cPhone;
        private string cDoctor;

        public string CustID { get { return cCustId;} set { cCustId = value; } }
        public string Name { get { return cName; } set { cName = value; } }
        public DateTime AppDate { get { return cAppDate; } set { cAppDate = value; } }
        public DateTime DateMade { get { return cDateMade; } set { cDateMade = value; } }
        public int Age { get { return cAge; } set { cAge = value; } }
        public string Reason { get {  return cReason; } set { cReason = value; } }
        public string Phone { get { return cPhone; } set { cPhone = value; } }
        public string Doctor { get { return cDoctor; } set { cDoctor = value; } }

        public AppointmentInformation() {
            Name = string.Empty;
            Reason = string.Empty;
            Phone = string.Empty;
            Doctor = string.Empty;
            Age = 0;
        }
    }
}
