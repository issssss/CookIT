using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CookIT.Controllers;
using CookIT.PresentationLayer;

using CookIT.MemoryBasedDAL;

namespace CookIT.AppStarter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			WindowFormsFactory _formsFactory = new WindowFormsFactory();

			// umjesto Singleton patterna, imati ćemo samo jednu instancu repozitorija unutar glavnog programa
			//TransactionRepository _transRepo = new TransactionRepository();

			// a za Account repozitorij koristimo Singleton
			MainFormController mainController = new MainFormController(_formsFactory, RecipeRepository.getInstance(), IngredientRepository.getInstance());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CookIT.PresentationLayer.frmMainWindow(mainController));
        }
    }
}
