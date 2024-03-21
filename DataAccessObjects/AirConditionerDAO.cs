using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AirConditionerDAO
    {
        private static AirConditionerDAO instance = null;
        private static object lockObject = new object();

        private AirConditionerDAO() { }
        public static AirConditionerDAO Instance
        {
            get
            {
                lock(lockObject)
                {
                    if(instance == null)
                    {
                        instance = new AirConditionerDAO();
                    }
                    return instance;
                }
            }
        }

        public List<AirConditioner> GetAllAirConditioners()
        {
            try
            {
                using (AirConditionerShop2023DbHackerLoContext? context = new AirConditionerShop2023DbHackerLoContext())
                {
                    List<AirConditioner> airConditioners = context.AirConditioners.ToList();
                    return airConditioners;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteAirConditioner(int airConditionerId)
        {
            try
            {
                using (AirConditionerShop2023DbHackerLoContext? context = new AirConditionerShop2023DbHackerLoContext())
                {
                    AirConditioner airConditioner = context.AirConditioners.Find(airConditionerId);
                    context.AirConditioners.Remove(airConditioner);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAirConditioner(AirConditioner airConditioner)
        {
            try
            {
                using (AirConditionerShop2023DbHackerLoContext? context = new AirConditionerShop2023DbHackerLoContext())
                {
                    context.Entry<AirConditioner>(airConditioner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddAirConditioner(AirConditioner airConditioner)
        {
            try
            {
                using (AirConditionerShop2023DbHackerLoContext? context = new AirConditionerShop2023DbHackerLoContext())
                {
                    context.AirConditioners.Add(airConditioner);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
