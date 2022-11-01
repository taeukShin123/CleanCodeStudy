using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    public class AnimalFriends : MonoBehaviour, AnimalFactory
    {
        public AnimalHospital MakeHospital(AnimalChoice choice)
        {
            switch (choice)
            {
                case AnimalChoice.Cat:

                    return new AnimalHospital();
                    break;
                case AnimalChoice.Dog:
                    return new AnimalHospital();

                    break;
            }

            return new AnimalHospital();

        }
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

    public enum AnimalChoice{
        Cat,
        Dog
    }


    abstract class Cat{
        public abstract string Name(); 
        // public abstract void Move();
        // public abstract void Run();
        // public abstract void Eat();
    }   

    public interface AnimalFactory{
        public AnimalHospital MakeHospital(AnimalChoice choice);
    }

    class Tuxedo : Cat
    {
        string name;
        public override string Name()
        {
            return name;
        }
    }

    class ThreeColored : Cat
    {
        string name;
        public override string Name()
        {
            return name;
        }
    }

    public abstract class Dog{

    }   

    class Beagle : Dog
    {

    }

    public class Bichon : Dog
    {
        
    }

    public abstract class House{
        // public abstract Cat CreateCat<T>() where T : class;
        public abstract Dog CreateDog();
    }

    public class AnimalHospital : House
    {
        // public override Cat CreateCat<Tuxedo>()
        // {
        //     return new Tuxedo();
        // }
        
        public override Dog CreateDog()
        {
            return new Bichon();
        }
    }
}
