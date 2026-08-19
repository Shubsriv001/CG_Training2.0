using System;
using System.Collections.Generic;
using System.Linq;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Condition { get; set; }
    public List<string> MedicalHistory { get; set; }

    public Patient(int id, string name, int age, string condition)
    {
        Id = id;
        Name = name;
        Age = age;
        Condition = condition;
        MedicalHistory = new List<string>();
    }
}

public class HospitalManager
{
    private Dictionary<int, Patient> _patients;
    private Queue<Patient> _appointmentQueue;

    public HospitalManager()
    {
        _patients = new Dictionary<int, Patient>();
        _appointmentQueue = new Queue<Patient>();
    }

    public void RegisterPatient(int id, string name, int age, string condition)
    {
        if (_patients.ContainsKey(id))
        {
            Console.WriteLine("Patient ID already exists.");
            return;
        }

        Patient patient = new Patient(id, name, age, condition);
        _patients.Add(id, patient);
    }

    public void ScheduleAppointment(int patientId)
    {
        if (_patients.ContainsKey(patientId))
        {
            _appointmentQueue.Enqueue(_patients[patientId]);
        }
        else
        {
            Console.WriteLine("Patient not found.");
        }
    }

    public Patient ProcessNextAppointment()
    {
        if (_appointmentQueue.Count == 0)
        {
            return null;
        }

        return _appointmentQueue.Dequeue();
    }

    public List<Patient> FindPatientsByCondition(string condition)
    {
        return _patients.Values
            .Where(p => p.Condition.Equals(condition, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public void AddMedicalHistory(int patientId, string history)
    {
        if (_patients.ContainsKey(patientId))
        {
            _patients[patientId].MedicalHistory.Add(history);
        }
    }

    public void DisplayPendingAppointments()
    {
        foreach (Patient patient in _appointmentQueue)
        {
            Console.WriteLine(patient.Name);
        }
    }

    public int GetTotalPatients()
    {
        return _patients.Count;
    }

    public Patient FindOldestPatient()
    {
        return _patients.Values
            .OrderByDescending(p => p.Age)
            .FirstOrDefault();
    }

    public void GroupPatientsByCondition()
    {
        var groups = _patients.Values
            .GroupBy(p => p.Condition);

        foreach (var group in groups)
        {
            Console.WriteLine(group.Key);

            foreach (Patient patient in group)
            {
                Console.WriteLine(patient.Name);
            }
        }
    }
}

public class Hospital
{
    public static void Main()
    {
        HospitalManager manager = new HospitalManager();

        manager.RegisterPatient(1, "John Doe", 45, "Hypertension");
        manager.RegisterPatient(2, "Jane Smith", 32, "Diabetes");

        manager.ScheduleAppointment(1);
        manager.ScheduleAppointment(2);

        Patient nextPatient = manager.ProcessNextAppointment();

        if (nextPatient != null)
        {
            Console.WriteLine(nextPatient.Name);
        }

        List<Patient> diabeticPatients =
            manager.FindPatientsByCondition("Diabetes");

        Console.WriteLine(diabeticPatients.Count);
    }
}
