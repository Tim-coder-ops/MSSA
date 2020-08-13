using System;

namespace EX4A
{
    class Program
    {
        //Cow class
        class Cow
        {
            //fields specific to cow
            int numOfLegs = 4;
            String mainColor = "white";
            //default constructor
            public Cow()
            {
                Console.WriteLine($"\nA cow has been created.");
            }

            //Argument Constructor 
            public Cow(int legs, String color)
            {
                this.numOfLegs = legs;
                this.mainColor = color;
                Console.WriteLine($"\nA cow has been created.");
            }

            //Noise method
            public void MakeNoise()
            {
                Console.WriteLine($"The {this.mainColor} cow goes moo.");
            }

            //Move Method
            public void Move()
            {
                Console.WriteLine($"The cow with its {this.numOfLegs} is walking.");
            }

            //Use method 
            public void Use()
            {
                Console.WriteLine("This cow is used for milk production.");
            }

            //Alt use method
            public void AlternateUse()
            {
                Console.WriteLine("This cow can also be used to obtain beef.");
            }
        }

        //Pig Class
        class Pig
        {
            //Pig fields
            int numberOfLegs = 4;
            int weight = 215;

            //Default constructor
            public Pig()
            {
                Console.WriteLine($"\nA pig has been created.");
            }

            //Argument constructor 
            public Pig(int legs, int weight)
            {
                this.numberOfLegs = legs;
                this.weight = weight;
                Console.WriteLine($"\nA pig has been created.");
            }

            //Noise method
            public void MakeNoise()
            {
                Console.WriteLine($"The pig with {this.numberOfLegs} legs goes oink!");
            }

            //Move Method
            public void Move()
            {
                Console.WriteLine($"The pig with {this.numberOfLegs} legs is walking.");
            }

            //Use Method
            public void Use()
            {
                Console.WriteLine($"The {this.weight}lb pig is used for production of pork.");
            }

            //Alt Use Method
            public void AlternateUse()
            {
                Console.WriteLine($"The {this.weight}lb pig can also be used as a garbage disposal.");
            }
        }

        //Chicken Method
        class Chicken
        {
            //Chicken Field
            int ageInMonths = 14;
            int heightInInches = 11;

            //Default Constructor
            public Chicken()
            {
                Console.WriteLine($"\nA chicken has been created.");
            }

            //Argument Constructor 
            public Chicken(int age, int height)
            {
                this.ageInMonths = age;
                this.heightInInches = height;
                Console.WriteLine($"\nA chicken has been created.");
            }

            //Noise Method
            public void MakeNoise()
            {
                Console.WriteLine($"The {this.ageInMonths} month old chicken goes cluck.");
            }

            //Move Method
            public void Move()
            {
                Console.WriteLine($"The {this.heightInInches} inch tall chicken is running.");
            }

            //Use Method
            public void Use()
            {
                Console.WriteLine("The chicken is primarily used for eggs.");
            }

            //Alt Use Method 
            public void AlternateUse()
            {
                Console.WriteLine("The chicken can also be used for chicken meat.");
            }
        }

        //Sheep Class
        class Sheep
        {
            //Sheep Fields 
            Boolean hasFur = true;
            int ageInYears = 2;

            //Default Constructor
            public Sheep()
            {
                Console.WriteLine($"\nA sheep has been created.");
            }

            //Argument Constructor
            public Sheep(Boolean fur, int age)
            {
                this.hasFur = fur;
                this.ageInYears = age;
                Console.WriteLine($"\nA sheep has been created.");
            }

            //Noise Method
            public void MakeNoise()
            {
                Console.WriteLine($"The {this.ageInYears} year old sheep goes bahh.");
            }

            //Move Method
            public void Move()
            {
                Console.WriteLine("The sheep is slowly walking.");
            }

            //Use Method
             public void Use()
            {
                Console.WriteLine("The sheep is primarily used for wool.");
            }

            //Alt Use Method
            public void AlternateUse()
            {
                Console.WriteLine("The sheep can also be used for meat if needed.");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                //Testing the creation of instances and methods.
                Sheep Frank = new Sheep();
                Frank.MakeNoise();
                Frank.Use();
                Frank.Move();
                Frank.AlternateUse();

                Pig Steve = new Pig(4, 352);
                Steve.Move();
                Steve.Use();
                Steve.AlternateUse();
                Steve.MakeNoise();

                Cow Lucy = new Cow(4, "brown");
                Lucy.Use();
                Lucy.AlternateUse();
                Lucy.Move();
                Lucy.MakeNoise();

                Chicken Carl = new Chicken(8,18);
                Carl.Move();
                Carl.MakeNoise();
                Carl.Use();
                Carl.AlternateUse();
            }

            catch(Exception e) 
            {
                Console.WriteLine(e);
            }
        }
    }
}
