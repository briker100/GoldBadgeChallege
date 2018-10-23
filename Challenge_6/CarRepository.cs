using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    class CarRepository
    {
        //Fields
        private List<Car> _claimsList = new List<Car>();

        //Methods
        public List<Car> GetClaims()
        {
            return _claimsList;
        }

        public void AddClaimToQueue(Car CarType)
        {
            _claimsList.Add(CarType);
        }

        public List<Car> RemoveQueueItem(string CarType)
        {
            _claimsList.Remove(CarType);
            return _claimsList;
        }
    }
}