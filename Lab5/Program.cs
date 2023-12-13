using Lab5.Logic.Realisations;
using Lab5.UI;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static Program() 
        {
            //::begin:: User Services
            //services.AddScoped<IUserService, UserService>();
            //::end:: User Services

            

            var services = new ServiceCollection();

            services.AddSingleton<IDataSerializer, DataSerializer>();
            services.AddSingleton<IDatabase, Database>();
            services.AddSingleton(sp => new MainForm(sp.GetService<IDatabase>()));
            ServiceProvider = services.BuildServiceProvider();

        }
        

        public static T? GetService<T>() where T : class
        {
            return (T?)ServiceProvider.GetService(typeof(T));
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mainForm = GetService<MainForm>();
            Application.Run(mainForm);
        }
    }
}