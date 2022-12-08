using System;
using Autofac;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using baiquanlyweb.Service;

namespace baiquanlyweb
{
    static class Program
    {
        static IContainer container;
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<quanlyservice>().As<Iquanly>();
            builder.RegisterType<Form1>();
            return builder.Build();
        }
        
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
            Application.Run(new Form1(container.Resolve<Iquanly>()));
        }
    }
}
