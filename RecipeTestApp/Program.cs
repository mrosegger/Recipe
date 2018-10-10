using System;
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
            RecipeDataProviderImpl rsStorage = new RecipeDataProviderImpl("test.csv");
            if (rsStorage.Ingredients.Count == 0) { 
                foreach (String ingName in TEST_ING_NAMES)
                    {
                        Ingredient tmpIng = new Ingredient();
                        tmpIng.Name = ingName;
                        System.Console.WriteLine("Add Ingredient: " + tmpIng);
                        rsStorage.AddIngredient(tmpIng);
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
                rsStorage.AddRecipe(kuchenRcp);
                System.Console.WriteLine("Add Recipe: " + kuchenRcp);
            }
            foreach (Ingredient ing in rsStorage.Ingredients)
            {
                System.Console.WriteLine("Got stored ingredient {0}", ing);
            }
            foreach (Recipe.Recipe rcp in rsStorage.Recipes)
            {
                System.Console.WriteLine("Got stored recipe {0}", rcp);
            }
            // System.Console.ReadKey();
        }
    }
}
