﻿using System;
using System.Collections.Generic;
using Recipe;
using System.IO;

namespace RecipeStorageCSV
{
    public class RecipeDataProviderImpl : Recipe.RecipeDataProvider
    {
        public uint GetIngId()
        {
            List<uint> used_ids = new List<uint>();
            foreach (Ingredient tmpItem in this._ingredients)
            {
                used_ids.Add(tmpItem.ID);
            }
            uint newId = 1;
            while (used_ids.Contains(newId))
            {
                newId++;
            }
            return newId;
        }

        public uint GetRcpId()
        {
            List<uint> used_ids = new List<uint>();
            foreach (Recipe.Recipe tmpItem in this._recipes)
            {
                used_ids.Add(tmpItem.ID);
            }
            uint newId = 1;
            while (used_ids.Contains(newId))
            {
                newId++;
            }
            return newId;
        }

        public RecipeDataProviderImpl(String file_name)
        {
            this._file_path = file_name;
            this._recipes = new List<Recipe.Recipe>();
            this._ingredients = new List<Ingredient>();
            this.ParseData();
        }
        private void ParseData()
        {
            if (File.Exists(this._file_path))
            {
                FileStream dataFile = File.OpenRead(this._file_path);
                using (StreamReader streamReader = new StreamReader(dataFile))
                {
                    this._ingredients.Clear();
                    while(streamReader.Peek() >= 0)
                    {
                        String line = streamReader.ReadLine();
                        var line_data = line.Split(',');
                        if(line_data[0]=="I")
                        {
                            // System.Console.WriteLine("Got ingredient with id {0}, and name {1}", line_data[1], line_data[2]);
                            Ingredient tmpIng = new Ingredient();
                            tmpIng.ID = uint.Parse(line_data[1]);
                            tmpIng.Name = line_data[2];
                            this._ingredients.Add(tmpIng);
                        }
                    }
                }
            }
        }
        private void StoreData()
        {
            File.Delete(this._file_path);
            var outFile = File.OpenWrite(this._file_path);
            using (StreamWriter stream = new StreamWriter(outFile))
            {
                foreach (Ingredient ing in this._ingredients)
                {
                    String file_content = String.Format("I,{0},{1}", ing.ID, ing.Name);
                    stream.WriteLine(file_content);
                }
                foreach (Recipe.Recipe rcp in this._recipes)
                {
                    String file_content = String.Format("R,{0},{1},{2}", rcp.ID, rcp.Name, rcp.Text);
                    foreach (RecipeItem rcpItem in rcp.Items)
                    {
                        file_content = String.Format("{0},{1};{2};{3}", file_content, rcpItem.Count, rcpItem.Unit, rcpItem.Ingredient.ID);
                    }
                    stream.WriteLine(file_content);
                }
            }
        }
        public IReadOnlyList<Recipe.Recipe> Recipes => _recipes.AsReadOnly();

        public IReadOnlyList<Ingredient> Ingredients => _ingredients.AsReadOnly();

        public void addIngredient(Ingredient ingredient)
        {
            if (ingredient.ID == 0)
            {
                ingredient.ID = this.GetIngId();
            }
            this._ingredients.Add(ingredient);
            this.StoreData();
        }

        public void addRecipe(Recipe.Recipe recipe)
        {
            foreach(RecipeItem rcpItem in recipe.Items)
            {
                if (rcpItem.Ingredient.ID == 0)
                {
                    addIngredient(rcpItem.Ingredient);
                }
            }
            if(recipe.ID==0)
            {
                recipe.ID = this.GetRcpId();
            }
            this._recipes.Add(recipe);
            this.StoreData();
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
