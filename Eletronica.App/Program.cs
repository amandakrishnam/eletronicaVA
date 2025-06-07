using Eletronica.App.Data;
using Eletronica.App.Entities;
using Eletronica.App.View;

namespace Eletronica.App
{    
    internal static class Program
    {
        internal static Repositorio repositorio;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var context = new ContextoDados();
            repositorio = new Repositorio(context);
            Application.Run(new FrmPrincipal());
           
        }
    }
}