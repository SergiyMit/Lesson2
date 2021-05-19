using System;

namespace Lecture2
{
    public class Diver
    {
        private int IdDiver;
        private string Name;
        private string Surname;
        private int Age;
        private string Email;
        private int TelNumber;
        private int IdDevice;//Номер персонального устройства для получения параметров про погружение
    }
    public class DiveCertificate
    {
        private string CertNumber;
        private DateTime DateOfIssuance;
        private int IdDiver;//Связь с дайверами(у одного дайвера может быть несколько сертификатов)
        private int IdLevel;//Связь с уровнями
    }
    public class CertificateLevel
    {
        private int IdLevel;
        private string LevelName;
        private int MaxAllowedDeep;
        private int RequiredDives;
        private string AdditionalInfo;
    }
    public class DiveMeasurement
    {
        private int IdMeasurement;
        private int IdDevice;//Связь с дайвером
        private int MaxDiveDeep;
        private int DiveTime;
        private double WaterTemperature;
    }
    public class DiveLog
    {
        private int IdDive;
        private int IdMeasurement;//Связь с измерениями
        private int WeightsAmount;
        private string WetsuitType;
        private int OxygenAtStart;
        private int OxygenAtEnd;
        private string DiveSite;
    }
}
