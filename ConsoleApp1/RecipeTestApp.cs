using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipe;
using RecipeStorageCSV;

namespace RecipeTestApp
{
    class RecipeTestApp
    {
        private static readonly String[] TEST_ING_NAMES = {
                "Pfeffer",
                "Salz",
                "Mehl",
                "Zucker",
                "Hefe",
                "Wasser"
        };

        static void Main(string[] args)
        {
            foreach(String ingName in TEST_ING_NAMES)
            {
                Ingredient tmpIng = new Ingredient();
                tmpIng.Name = ingName;
                System.Console.WriteLine("Ing name: " + tmpIng);

            }

            RecipeStorageCSV.RecipeDataProviderImpl rsStorage = new RecipeStorageCSV.RecipeDataProviderImpl("test.csv");


            System.Console.WriteLine("Hello World");
            System.Console.ReadKey();   
        }
    }
}
