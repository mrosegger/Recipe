using System;
using System.Collections.Generic;
using Recipe;
using System.IO;

namespace RecipeStorageCSV
{
    public class RecipeDataProviderImpl : Recipe.RecipeDataProvider
    {
        public RecipeDataProviderImpl(String file_name)
        {
            _file_path = file_name;
            _recipes = new List<Recipe.Recipe>();
            _ingredients = new List<Ingredient>();
            this.ParseData();
        }
        private void ParseData()
        {
            FileStream stream = File.OpenRead(this._file_path);
        }
        private void StoreData()
        {
            FileStream stream = File.OpenWrite(this._file_path);
            String file_content = new string();
            foreach(Ingredient ing in this._ingredients)
            {
                file_content
            }
        }
        public IReadOnlyList<Recipe.Recipe> Recipes => throw new NotImplementedException();

        public IReadOnlyList<Ingredient> Ingredients => throw new NotImplementedException();

        public void addIngredient(Ingredient ingredient)
        {
            uint newId = 1;
            this._ingredients.Add(ingredient);
            this.StoreData();
        }

        public void addRecipe(Recipe.Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void deleteIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void deleteRecipe(Recipe.Recipe recipe)
        {
            throw new NotImplementedException();
        }
        private List<Recipe.Recipe> _recipes;
        private List<Ingredient> _ingredients;
        private String _file_path;
    }
}
