using OOPHW.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
    public class Patients
    {
        public TreatmentPlan TreatmentPlan { get; set; }
        public general AssignedDoctor { get; set; }
        public string Name { get; set; }

        public Patients(string name)
        {
            Name = name;
        }

        public Patients(string name, TreatmentPlan treatmentPlan)
        {
            TreatmentPlan = treatmentPlan;
            Name = name;
        }
    }
}
