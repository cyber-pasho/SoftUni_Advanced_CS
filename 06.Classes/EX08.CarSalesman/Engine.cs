using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08.CarSalesman
{
    internal class Engine
    {
        public Engine(string engineModel, int enginePower)
        {
            EngineModel = engineModel;
            EnginePower = enginePower;
        }

        public string EngineModel { get; set; }
        public int EnginePower { get; set; }
        public int? EngineDisplacement  { get; set; }
        public string EngineEfficiency { get; set; }
    }
}
