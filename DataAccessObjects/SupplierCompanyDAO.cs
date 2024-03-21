using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SupplierCompanyDAO
    {
        private static SupplierCompanyDAO instance = null;
        private static object lockObject = new object();

        private SupplierCompanyDAO() { }
        public static SupplierCompanyDAO Instance
        {
            get
            {
                lock(lockObject)
                {
                    if(instance == null)
                    {
                        instance = new SupplierCompanyDAO();
                    }
                    return instance;
                }
            }
        }

        public List<SupplierCompany> GetAllSupplierCompanies()
        {
            try
            {
                using (AirConditionerShop2023DbHackerLoContext? context = new AirConditionerShop2023DbHackerLoContext())
                {
                    List<SupplierCompany> supplierCompanies = context.SupplierCompanies.ToList();
                    return supplierCompanies;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
