using DzeTask.EntityFramework;
using EntityFramework.DynamicFilters;

namespace DzeTask.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly DzeTaskDbContext _context;

        public InitialHostDbBuilder(DzeTaskDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
