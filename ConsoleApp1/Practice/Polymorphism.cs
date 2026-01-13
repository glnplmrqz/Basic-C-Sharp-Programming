using System;

namespace PracticeCSharp {

    class Vehicle {

        virtual public void move() {
            Console.WriteLine("Override This Please");
        }

    }

    class Car : Vehicle {

        override public void move() {
            Console.WriteLine("Car moves by driving on the road.");
        }

    }

    class Bicycle : Vehicle {
        override public void move() {
            Console.WriteLine("Bicycle moves by pedaling on the road.");
        }
    }

    class Airplane : Vehicle {
        override public void move() {
            Console.WriteLine("Airplane moves by flying in the sky.");
        }
    }

    class Polymorphism {

        static void Main(string[] args) {

            // Vehicle class is a Base Class or Super Class

            Vehicle car = new Car();
            Vehicle bicycle = new Bicycle();
            Vehicle airplane = new Airplane();

            Vehicle[] vehicles = { car, bicycle, airplane };

            foreach (Vehicle vehicless in vehicles) {
                vehicless.move();
            }
        }
    }
}