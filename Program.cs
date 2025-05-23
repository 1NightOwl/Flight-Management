using FlightManagement.Core.Common;
using FlightManagement.Core.Data;
using FlightManagement.Core.Logic.Managers;
using FlightManagement.PL.Start.Loading;

namespace FlightManagement
{
    internal static class Program
    {


        public static PlanesManager PlanesManager;
        public static RoutesManager RoutesManager;
        public static AppDbContext DbContext { get; private set; }


        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = (Exception)e.ExceptionObject;
            if (ex.GetType() == typeof(FlightManagementException))
            {
                MessageBox.Show(ex.Message);
            }
            else
            {
                //LogsManager.LogError(ex);
                MessageBox.Show("Ndodhi nje gabim i paparashikuar");
            }
        }




        [STAThread]
        static void Main()
        {
            LoadApp();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLoading());
        }


        static void LoadApp()
        {

            PlanesManager = new PlanesManager();
            RoutesManager = new RoutesManager();
            DbContext = new AppDbContext();
            DbContext.Database.EnsureCreated();
        }
    }
}