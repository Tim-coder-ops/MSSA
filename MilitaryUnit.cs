using System;

namespace ImplementingInheritence
{

    class Personnel
    {
        protected int numberOfPersonnel;
        protected int numberOfLimDuty;
        protected string[] MOSs;

        public void SetMOSs(params string[] List)
        {
            MOSs = List;
        }

        public void SetNumOfLimDuty(int limDu)
        {
            numberOfLimDuty = limDu;
        }

        public void SetNumOfPersonnel(int personnel)
        {
            numberOfPersonnel = personnel;
        }

        public string PersonnelFitForDuty()
        {
            return $"There are {numberOfPersonnel - numberOfLimDuty} personnel fit for duty.";
        }

        public string MOSsAvailable()
        {
            return $"There are {MOSs.Length} different MOSs, the MOSs of {string.Join(", ", MOSs)}.";
        }

        public virtual string WhatBranch()
        {
            return "These personnel are in the Marine Corps.";
        }

    }

     class USMCUnit : Personnel
    {
        string unitName = "MWHS3";
        string parentCommand = "3d MAW";
        

        public string WhatParentUnit()
        {
            return $"{unitName}'s parent command is {parentCommand}.";
        }
    }

    class ArmyUnit : Personnel
    {
       string unitName;
       string[] subordinateCommands;

       public ArmyUnit(string Unit, params string[] subs)
       {
           this.unitName = Unit;
           this.subordinateCommands = subs;
       }

       public string WhatSubordinates()
       {
           return $"{unitName}'s subordinate units are {string.Join(", ", subordinateCommands)}.";
       }

       public override string WhatBranch()
       {
           return "These personnel are in the Army.";
       }
   }

     class Equipement
     {
         string[] equipNames;
         int numOfEquipement;
         int numOfEqipUnavailable;

        public void SetEquipNames(params string[] names)
        {
            this.equipNames = names;
        }

        public void SetNumOfEquip(int num)
        {
            this.numOfEquipement = num;
        }

        public void SetNumOfEquipUnalailable(int num)
        {
            this.numOfEqipUnavailable = num;
        }

         public string NumEqipAvailable()
         {
             return $"There are {numOfEquipement - numOfEqipUnavailable} equipment items available.";
         }

         public string EquipmentNames()
         {
             return $"The unit has {string.Join("s, ", equipNames)}.";
         }

        public virtual string Moto()
        {
            return "Bullets dont fly without supply!";
        }

     }

    class CommunicationsEquipement : Equipement
    {
        string[] classifications;

        public void SetClassificaitons(params string[] classes)
        {
            this.classifications = classes;
        }

        public string GetClassifications()
        {
            return $"The classifications of the equipment includes {string.Join(", ", classifications)}.";
        }

        public override string Moto()
        {
            return "Have you restarted it yet?";
        }

    }

    class Weapons : Equipement
    {
        string[] calibers;
        
        public Weapons(params string[] cal)
        {
            this.calibers = cal;
        }

        public override string Moto()
        {
            return "Stand by...... Targets!";
        }

        public string CalibersOnHand()
        {
            return $"There are {string.Join(", ", calibers)} on hand.";
        }
    }

     class MilitaryUnit
     {
         static void Main(string[] args)
         {
            //Creating a derived instance of the personnel class
            Console.WriteLine("Creating an instance of the USMC Unit class derived from the personnel class:");
           USMCUnit MWHS = new USMCUnit();
           Console.WriteLine(MWHS.WhatBranch());
           Console.WriteLine(MWHS.WhatParentUnit());
           MWHS.SetMOSs("0111","0231", "2651", "0571" );
           Console.WriteLine($"{MWHS.MOSsAvailable()}\n");

            //creating a derived instance of the personnel class
            Console.WriteLine("Creating an instance of the Army Unit class derived from the personnel class:");
            ArmyUnit A101 = new ArmyUnit("101", "104", "105", "106");
           Console.WriteLine(A101.WhatSubordinates());
           Console.WriteLine($"{A101.WhatBranch()}\n");

            //Creating a derived instance of the equipement class
            Console.WriteLine("Creating an instance of the Communications Equipment class derived from the Equipment class:");
            CommunicationsEquipement S6 = new CommunicationsEquipement();
            S6.SetClassificaitons("Unclassified", "Secret");
            Console.WriteLine($"The S6's moto is {S6.Moto()}");
            S6.SetNumOfEquip(52);
            S6.SetNumOfEquipUnalailable(3);
            Console.WriteLine($"{S6.NumEqipAvailable()}\n");

            //Creating a derived instance of the equipement class
            Console.WriteLine("Creating an instance of the Weapons class derived from the Equipment class:");
            Weapons MARSOC = new Weapons(".223", ".50 cal", ".338");
            Console.WriteLine(MARSOC.CalibersOnHand());
            Console.WriteLine($"MARSOCs moto is {MARSOC.Moto()}\n");

         }
     }
   }
