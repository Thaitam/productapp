using Autofac;
using Autofac.Core;
using productapp.Service;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productapp
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
            Application.Run(new Form1(container.Resolve<IProduct>()));
        }
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductService>().As<IProduct>();
            builder.RegisterType<Form1>();
            return builder.Build();
        }

    }
}
