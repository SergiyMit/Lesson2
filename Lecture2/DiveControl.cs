using System;
using System.Collections.Generic;

namespace Lecture2
{
    public class User
    {
        private int IdUser;
        public string Login { get; set; }
        public string Password { get; set; }
        private readonly int UserType;
        protected User(string login, string password, int type)
        {
            Login = login;
            Password = password;
            UserType = type;
        }
    }
    public class Diver : User
    {
        private int IdDiver;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int TelNumber { get; set; }
        public int DeviceNumber { get; set; }
        public Diver (string name, string surname, int age, string email, int telnumber, int devicenumber, string login, string password) : base(login, password, 1)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            TelNumber = telnumber;
            DeviceNumber = devicenumber;
        }
    }
    public class Admin : User
    {
        private int IdAdmin;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonalAccessCode { get; set; }

        public Admin(string name, string surname, int personalaccesscode, string login, string password) : base (login, password, 2)
        {
            Name = name;
            Surname = surname;
            PersonalAccessCode = personalaccesscode;
        }
    }
    public class DiveCertificate
    {
        private int IdCertificate;
        public string CertNumber { get; set; }
        public DateTime DateOfIssuance { get; set; }
        public Diver Diver { get; set; }
        public CertificateLevel CertificateLevel { get; set; }
        public DiveCertificate(string certnumber, DateTime dateofissuance, Diver diver, CertificateLevel certificatelevel)
        {
            CertNumber = certnumber;
            DateOfIssuance = dateofissuance;
            Diver = diver;
            CertificateLevel = certificatelevel;
        }
    }
    public class CertificateLevel
    {
        private int IdLevel;
        public string LevelName { get; set; }
        public int MaxAllowedDeep { get; set; }
        public int RequiredDives { get; set; }
        public string AdditionalInfo { get; set; }
        
        public CertificateLevel(string levelname, int maxalloweddeep, int requireddives, string additionalinfo)
        {
            LevelName = levelname;
            MaxAllowedDeep = maxalloweddeep;
            RequiredDives = requireddives;
            AdditionalInfo = additionalinfo;
        }
            
    }
    public class DiveMeasurement
    {
        private int IdMeasurement;
        public Diver Diver { get; set; }
        public int MaxDiveDeep { get; set; }
        public int DiveTime { get; set; }
        public decimal WaterTemperature { get; set; }
        public DiveMeasurement(int maxdivedeep, int divetime, decimal watertemperature, Diver diver)
        {
            Diver = diver;
            MaxDiveDeep = maxdivedeep;
            DiveTime = divetime;
            WaterTemperature = watertemperature;
        }
    }
    public class DiveLog : DiveMeasurement
    {
        private int IdDive;
        public int WeightsAmount { get; set; }
        public string WetsuitType { get; set; }
        public int OxygenAtStart { get; set; }
        public int OxygenAtEnd { get; set; }
        public string DiveSite { get; set; }

        public DiveLog(int weightsamout, string wetsuittype, int oxygenatstart, int oxygenatend, string divesite, int maxdivedeep, int divetime, int watertemperature, Diver diver )
        : base(maxdivedeep, divetime, watertemperature, diver)
        {
            WeightsAmount = weightsamout;
            WetsuitType = wetsuittype;
            OxygenAtStart = oxygenatstart;
            OxygenAtEnd = oxygenatend;
        }
    }
}
