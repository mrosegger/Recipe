using System;
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
                            Ingredient tmpIng = new Ingredient();
                            tmpIng.ID = uint.Parse(line_data[1]);
                            tmpIng.Name = line_data[2];
                            this._ingredients.Add(tmpIng);
                        } else if (line_data[0]=="R") {
                            uint count = 0;
                            Recipe.Recipe tmpRecipe = new Recipe.Recipe();
                            while (++count < line_data.Length)
                            {
                                if (count == 1)
                                {
                                    tmpRecipe.ID = uint.Parse(line_data[count]);
                                } else if (count == 2)
                                {
                                    tmpRecipe.Name = line_data[count];
                                } else if (count == 3)
                                {
                                    tmpRecipe.Text = line_data[count];
                                } else
                                {
                                    RecipeItem tmpItem = new RecipeItem();
                                    var item_data = line_data[count].Split(';');
                                    tmpItem.Count = uint.Parse(item_data[0]);
                                    tmpItem.Unit = item_data[1];
                                    foreach(var tmpIngredient in this._ingredients)
                                    {
                                        if (tmpIngredient.ID == uint.Parse(item_data[2]))
                                        {
                                            tmpItem.Ingredient = tmpIngredient;
                                        }
                                    }
                                    tmpRecipe.addIngredient(tmpItem);
                                }
                            }
                            this._recipes.Add(tmpRecipe);
                        }
                       
                    }
                }
            }
        }
        public void StoreData()
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

        public void AddIngredient(Ingredient ingredient)
        {
            if (ingredient.ID == 0)
            {
                ingredient.ID = this.GetIngId();
            }
            this._ingredients.Add(ingredient);
            this.StoreData();
        }

        public void AddRecipe(Recipe.Recipe recipe)
        {
            foreach(RecipeItem rcpItem in recipe.Items)
            {
                if (rcpItem.Ingredient.ID == 0)
                {
                    AddIngredient(rcpItem.Ingredient);
                }
            }
            if(recipe.ID==0)
            {
                recipe.ID = this.GetRcpId();
            }
            this._recipes.Add(recipe);
            this.StoreData();
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            _ingredients.Remove(ingredient);
            StoreData();
        }

        public void DeleteRecipe(Recipe.Recipe recipe)
        {
            _recipes.Remove(recipe);
            StoreData();
        }
        private List<Recipe.Recipe> _recipes;
        private List<Ingredient> _ingredients;
        private String _file_path;
    }
}
