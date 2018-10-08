﻿using System;
using System.Collections.Generic;

namespace Recipe
{
    public interface RecipeDataProvider
    {
        IReadOnlyList<Recipe> Recipes
        {
            get;
        }
        IReadOnlyList<Ingredient> Ingredients
        {
            get;
        }
        void deleteRecipe(Recipe recipe);
        void addRecipe(Recipe recipe);
        void deleteIngredient(Ingredient ingredient);
        void addIngredient(Ingredient ingredient);
    }

    public class Ingredient
    {
        public String Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public uint ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Ing({0}) {1}",this._id,this._name);
        }
        private uint _id;
        private String _name;
    }

    public class RecipeItem
    {
        public uint Count
        {
            set
            {
                _count = value;
            }
            get
            {
                return _count;
            }
        }
        public String Unit
        {
            set
            {
                _unit = value;
            }
            get
            {
                return _unit;
            }
        }
        public Ingredient Ingredient
        {
            set
            {
                _ingredient = value;
            }
            get
            {
                return _ingredient;
            }
        }
        private uint _count;
        private String _unit;
        private Ingredient _ingredient;
    }

    public class Recipe
    {
        public Recipe()
        {
            this._items = new List<RecipeItem>();
        }
        public String Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public String Text
        {
            set
            {
                _text = value;
            }
            get
            {
                return _text;
            }
        }
        public IReadOnlyList<RecipeItem> Items {
            get {
                return _items.AsReadOnly();
            }
        }
        public void addIngredient(RecipeItem item)
        {
            _items.Add(item);
        }
        public void deleteIngredient(RecipeItem item)
        {
            _items.Remove(item);
        }
        public uint ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        private uint _id;
        private String _name;
        private String _text;
        private List<RecipeItem> _items;
    }
}
