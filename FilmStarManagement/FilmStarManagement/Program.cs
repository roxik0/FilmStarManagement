using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;

namespace FilmStarManagement
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IKernel Ninject = new StandardKernel();
            Ninject.Bind<IMovieStarRepository>().To<TempMovieStarRepository>().InSingletonScope();
            Ninject.Bind<IMovieRepository>().To<TempMovieRepository>().InSingletonScope();
            Ninject.Bind<Form1>().ToSelf();
	        Ninject.Bind<IStaffProvider>().To<TempStaffProvider>();
            Ninject.Bind<ISkillsRepository>().To<TempSkillsRepository>().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Ninject.Get<Form1>());
        }
    }
}
