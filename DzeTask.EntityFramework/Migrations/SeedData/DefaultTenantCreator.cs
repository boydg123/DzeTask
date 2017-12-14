using System.Linq;
using DzeTask.EntityFramework;
using DzeTask.MultiTenancy;

namespace DzeTask.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly DzeTaskDbContext _context;

        public DefaultTenantCreator(DzeTaskDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
