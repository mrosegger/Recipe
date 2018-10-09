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
            RecipeStorageCSV.RecipeDataProviderImpl rsStorage = new RecipeStorageCSV.RecipeDataProviderImpl("test.csv");
            foreach (Ingredient ing in rsStorage.Ingredients)
            {
                System.Console.WriteLine("Got stored ingredient {0}", ing);
            }
            if (rsStorage.Ingredients.Count == 0) { 
                foreach (String ingName in TEST_ING_NAMES)
                    {
                        Ingredient tmpIng = new Ingredient();
                        tmpIng.Name = ingName;
                        System.Console.WriteLine("Ing name: " + tmpIng);
                        rsStorage.addIngredient(tmpIng);
                    }
            }
            if (rsStorage.Recipes.Count == 0)
            {
                Recipe.Recipe kuchenRcp = new Recipe.Recipe();
                kuchenRcp.Name = "Kuchen";
                kuchenRcp.Text = "Zubereitung";
                RecipeItem mehlItem = new RecipeItem();
                mehlItem.Count = 1;
                mehlItem.Unit = "Tasse";
                mehlItem.Ingredient = rsStorage.Ingredients[2];
                RecipeItem backPulverItem = new RecipeItem();
                backPulverItem.Count = 2;
                backPulverItem.Unit = "Messerspitze";
                backPulverItem.Ingredient = new Ingredient();
                backPulverItem.Ingredient.Name = "Backpulver";
                kuchenRcp.addIngredient(mehlItem);
                kuchenRcp.addIngredient(backPulverItem);
                rsStorage.addRecipe(kuchenRcp);
            }
            System.Console.ReadKey();
        }
    }
}
