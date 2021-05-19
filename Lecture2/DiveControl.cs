using System;

namespace Lecture2
{
    public class Diver
    {
        private int IdDiver { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Age { get; set; }
        private string Email { get; set; }
        private int TelNumber { get; set; }
        private int IdDevice;//Номер персонального устройства для получения параметров про погружение
    }
    public class DiveCertificate
    {
        private string CertNumber { get; set; }
        private DateTime DateOfIssuance { get; set; }
        private int IdDiver;//Связь с дайверами(у одного дайвера может быть несколько сертификатов)
        private int IdLevel;//Связь с уровнями
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
        private int IdDevice;//Связь с дайвером
        private int MaxDiveDeep { get; set; }
        private int DiveTime { get; set; }
        private double WaterTemperature { get; set; }
    }
    public class DiveLog
    {
        private int IdDive { get; set; }
        private int IdMeasurement;//Связь с измерениями
        private int WeightsAmount { get; set; }
        private string WetsuitType { get; set; }
        private int OxygenAtStart { get; set; }
        private int OxygenAtEnd { get; set; }
        private string DiveSite { get; set; }
    }
}
