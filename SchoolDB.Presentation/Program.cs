using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolDB.Appcore.Interfaces;
using SchoolDB.Appcore.Services;
using SchoolDB.Domain.Interfaces;
using SchoolDB.Domain.SchoolDBEntities;
using SchoolDB.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDB.Presentation
{
    public static class Program
    {

        public static IConfiguration Configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .AddEnvironmentVariables().Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            services.AddDbContext<PepitoSchoolContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped<IPepitoSchoolContext, PepitoSchoolContext>();
            services.AddScoped<IEstudianteRepository, EFPepitoSchoolRepository>();
            services.AddScoped<IEstudianteService, EstudiantesServices>();
            services.AddScoped<Form1>();

            using (var serviceScope = services.BuildServiceProvider())
            {
                var main = serviceScope.GetRequiredService<Form1>();
                Application.Run(main);
            }


        }
    }
}
