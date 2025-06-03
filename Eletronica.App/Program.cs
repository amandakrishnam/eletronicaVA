using Eletronica.App.Data;
using Eletronica.App.View;
using System;

namespace Eletronica.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new OrdemServicoFormulario());
            var context = new ContextoDados();
        }
    }
}