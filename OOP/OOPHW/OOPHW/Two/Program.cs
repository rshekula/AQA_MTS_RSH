using System.Drawing;
using OOPHW;
using OOPHW.Doctors;

// задание 2

        var treatments = new Treatments();
        var patients = new Patients[]
        {
            new Patients("Patient 1", new TreatmentPlan(1)),
            new Patients("Patient 2", new TreatmentPlan(2)),
            new Patients("Patient 3", new TreatmentPlan(99))
        };
        treatments.StartDay(patients);

