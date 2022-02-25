// See https://aka.ms/new-console-template for more information

using System;

namespace Animals
{
    public class Animal
    {
        private string nameOfAnimal;
        private string habitat_area;
        private string sound;
        private int weight;
        private int height;
        public int birthYear = 2021;

        public Animal()
        {
            this.nameOfAnimal = "Cat";
            this.habitat_area = "houses, cities, forests, grasslands, farmland etc.";
            this.sound = "Meow";
            this.weight = 4;
            this.height = 24;
        }

        public void setName(string nameOfAnimal)
        {
            this.nameOfAnimal = nameOfAnimal;
        }

        public void setHabitat(string habitat_area)
        {
            this.habitat_area = habitat_area;
        }

        public void setSound(string sound)
        {
            this.sound = sound;
        }

        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public string getName()
        {
            return nameOfAnimal;
        }

        public string getHabitat()
        {
            return habitat_area;
        }

        public string getSound()
        {
            return sound;
        }

        public int getWeight()
        {
            return weight;
        }

        public int getHeight()
        {
            return height;
        }

        public int getAge()
        {
            return (2022 - birthYear);
        }

        public string getInformation()
        {
            return ("Name: " + nameOfAnimal + "\n" + "Habitat: " + habitat_area + "\n" + "Weight: " + weight + "\n" + "Height: " + height);
        }

        public virtual string vocalize()
        {
            return sound;
        }
    }

    public class Cow : Animal
    {
        public override string vocalize()
        {
            return "Moo";
        }
    }

    public class Chicken : Animal
    {
        public override string vocalize()
        {
            return "Buck Buck";
        }
    }

    public class Cat : Animal
    {
        public override string vocalize()
        {
            return "Meow";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here, the weights are shown in kg and heights in cm.\n");

            Animal dummy = new Animal();

            dummy.birthYear = 2020;

            if(dummy.birthYear <= 2021)
            {
                Console.WriteLine(dummy.getInformation());
                Console.WriteLine("Age: " + dummy.getAge());
                Console.WriteLine(dummy.vocalize());
            }

            else
            {
                Console.WriteLine("Invalid! >_<");
            }

            Console.WriteLine(".....................................................................\n");

            Cow dummy_cow = new Cow();

            dummy_cow.birthYear = 2016;

            if (dummy_cow.birthYear < 2021)
            {
                dummy_cow.setName("Cow");
                dummy_cow.setHabitat("As long as they have lots of space and plenty of grass, Cows are happy.");
                dummy_cow.setWeight(720);
                dummy_cow.setHeight(170);

                Console.WriteLine(dummy_cow.getInformation());
                Console.WriteLine("Age: " + dummy_cow.getAge());
                Console.WriteLine(dummy_cow.vocalize());
            }

            else
            {
                Console.WriteLine("Invalid! >_<");
            }

            Console.WriteLine(".....................................................................\n");

            Chicken dummy_chicken = new Chicken();

            dummy_chicken.birthYear = 2019;

            if (dummy_chicken.birthYear <= 2021)
            {
                dummy_chicken.setName("Chicken");
                dummy_chicken.setHabitat("Most chickens are raised in captivity. Their habitat often consists of a factory farm setting.");
                dummy_chicken.setWeight(3);
                dummy_chicken.setHeight(70);

                Console.WriteLine(dummy_chicken.getInformation());
                Console.WriteLine("Age: " + dummy_chicken.getAge());
                Console.WriteLine(dummy_chicken.vocalize());
            }

            else
            {
                Console.WriteLine("Invalid! >_<");
            }

            Console.WriteLine(".....................................................................\n");

            Cat dummy_cat = new Cat();

            dummy_cat.birthYear = 2017;

            if (dummy_cat.birthYear < 2021)
            {
                dummy_cat.setName("Cat");
                dummy_cat.setHabitat("Feral cats can live in forests, grasslands, tundra, coastal areas, agricultural land, scrublands, urban areas, and wetlands.");
                dummy_cat.setWeight(4);
                dummy_cat.setHeight(24);

                Console.WriteLine(dummy_cat.getInformation());
                Console.WriteLine("Age: " + dummy_cat.getAge());
                Console.WriteLine(dummy_cat.vocalize());
            }

            else
            {
                Console.WriteLine("Invalid! >_<");
            }
        }
    }
}
