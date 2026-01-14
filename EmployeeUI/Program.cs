using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace EmployeeUI
{
    internal static class Program
    {
        public static IContainer Container;

        [STAThread]
        static void Main()
        {            
            ApplicationConfiguration.Initialize();
            Container = Configure();
            Application.Run(new MainForm(Container.Resolve<IDepartmentService>(), Container.Resolve<IEmployeeService>()));
        }

        // Dependency Injection Configuration
        static IContainer Configure()
        { 
            var builder = new ContainerBuilder();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<MainForm>();

            return builder.Build();
        }
    }
}