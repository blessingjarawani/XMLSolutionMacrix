using SimpleInjector;
using SimpleInjector.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Interfaces;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Services;
using XMLSolutionMatrics.DAL.Respository;

namespace XMLSolutionMatric.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static Container container;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InjectServices();
            Application.Run(container.GetInstance<FrmMain>());
        }

        private static void InjectServices()
        {
            container = new Container();
            container.Register<IPersonService, PersonService>(Lifestyle.Transient);
            container.Register<IFileService, FileService>(Lifestyle.Transient);
            container.Register<IPersonRepository, PersonRepository>(Lifestyle.Transient);
            container.RegisterForm<FrmMain>();
            container.Verify();
        }

        public static void RegisterForm<TForm>(this Container container) where TForm : Form
        {
            var r = Lifestyle.Transient.CreateRegistration<TForm>(container);
            r.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent, "Done manually.");
            container.AddRegistration<TForm>(r);
        }
    }
}
