using System;
using System.Collections.Generic;

namespace Lecture2
{
    public class User
    {
        private string Login { get; set; }
        private string Email { get; set; }
        private int Type { get; set; }
    }
    public class Diver
    {
        private int IdDiver { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Age { get; set; }
        private string Email { get; set; }
        private int TelNumber { get; set; }
        private int IdDevice;
    }
    public class DiveCertificate
    {
        private string CertNumber { get; set; }
        private DateTime DateOfIssuance { get; set; }
        private List<CertificateLevel> Level { get; set; }
        private List<Diver> Diver { get; set; }


    }
    public class CertificateLevel
    {
        private int IdLevel { get; set; }
        private string LevelName { get; set; }
        private int MaxAllowedDeep { get; set; }
        private int RequiredDives { get; set; }
        private string AdditionalInfo { get; set; }
    }
    public class DiveMeasurement
    {
        private int IdMeasurement { get; set; }
        private List<Diver> DiverDevice { get; set; }
        private int MaxDiveDeep { get; set; }
        private int DiveTime { get; set; }
        private double WaterTemperature { get; set; }
    }
    public class DiveLog
    {
        private int IdDive { get; set; }
        private int WeightsAmount { get; set; }
        private string WetsuitType { get; set; }
        private int OxygenAtStart { get; set; }
        private int OxygenAtEnd { get; set; }
        private string DiveSite { get; set; }
        private List<DiveMeasurement> DiveMeasurement { get; set; }
    }
}
