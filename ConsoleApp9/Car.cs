using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Car
    {
        public Guid Id {get; set;}
        // goo id
        //gwid
        public string Make {get; set;}
        public string Model {get; set;}
        public Engine EngineType {get; set;}
        
        public Car(string make, string model, Engine engineType)
        {
            Id = Guid.NewGuid();
            Make = make;
            Model = model;
            EngineType = engineType;
        }
    }


}
