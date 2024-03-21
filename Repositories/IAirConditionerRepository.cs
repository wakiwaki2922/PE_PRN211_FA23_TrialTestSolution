using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAirConditionerRepository
    {
        List<AirConditioner> GetAllAirConditioners();

        void DeleteAirConditioner(int airConditionerId);
        void UpdateAirConditioner(AirConditioner airConditioner);

        void AddAirConditioner(AirConditioner airConditioner);
    }
}
