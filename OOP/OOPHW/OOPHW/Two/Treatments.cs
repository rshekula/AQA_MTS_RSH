using OOPHW.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
    public class Treatments
    {
        private Dentist newdentist = new Dentist();
        private Surgeon newsurgeon = new Surgeon();
        private Therapist newtherapist = new Therapist();

        public void StartDay(Patients[] patients)
        {
            foreach (var patient in patients)
            {
                AssignDoctor(patient);
                patient.AssignedDoctor.recording(patient.Name);
            }
        }

        public void AssignDoctor(Patients patient)
        {
            switch (patient.TreatmentPlan.TreatmentPlanCode)
            {
                case 1:
                    patient.AssignedDoctor = newsurgeon;
                    break;
                case 2:
                    patient.AssignedDoctor = newdentist;
                    break;
                default:
                    patient.AssignedDoctor = newtherapist;
                    break;
            }
        }
    }
}
