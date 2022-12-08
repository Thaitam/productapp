using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Ontap.Core.Services;
using Ontap.UI;
namespace Ontap
{
    static class Program
    {
        static IContainer container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            container = Configure();
            Application.Run(new FrmMain(container.Resolve<IEmployeeService>()));
        }
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<FrmMain>();
            return builder.Build();

        }
    }
}
