using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AirConditionerRepository : IAirConditionerRepository
    {
        public List<AirConditioner> GetAllAirConditioners() => AirConditionerDAO.Instance.GetAllAirConditioners();

        public void DeleteAirConditioner(int airConditionerId) => AirConditionerDAO.Instance.DeleteAirConditioner(airConditionerId);

        public void UpdateAirConditioner(AirConditioner airConditioner) => AirConditionerDAO.Instance.UpdateAirConditioner(airConditioner);

        public void AddAirConditioner(AirConditioner airConditioner) => AirConditionerDAO.Instance.AddAirConditioner(airConditioner);
    }
}
