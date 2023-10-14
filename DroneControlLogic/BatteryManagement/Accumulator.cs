using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryManagement
{
  public  class Accumulator
    {

        public int AccumulatorId { get; set; }
        public int AccuAdress { get; set; }
        public int BatterryId { get; set; }

        public short NetworkAddress => throw new NotImplementedException();

        public int RegisterAddress => throw new NotImplementedException();

        public Accumulator(int accumulatorId, int accuAdress)
        {
            this.AccumulatorId = accumulatorId;
            this.AccuAdress = accuAdress;
        }

        public override string ToString()
        {
            return this.AccumulatorId.ToString();
        }
    }
}
