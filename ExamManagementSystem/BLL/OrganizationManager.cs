using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
   public class OrganizationManager
    {
        OrganizationRepository _organizationRepository = new OrganizationRepository();

        public bool Add(Organization organization)
        {
           return _organizationRepository.Add(organization);
        }

       public bool Update(Organization organization)
       {
           return _organizationRepository.Update(organization);
       }

       public List<Organization> GetAll()
       {
           return _organizationRepository.GetAll();
       }

       public List<Organization> GetAllorganization()
       {
           List<Organization> getAllOrganizations = _organizationRepository.GetAllOrganization();
       }
    }
}
