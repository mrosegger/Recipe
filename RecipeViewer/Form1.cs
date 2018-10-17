using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recipe;
using RecipeStorageCSV;

namespace RecipeViewer
{
    public partial class Form1 : Form
    {
        RecipeDataProviderImpl rsStorage = new RecipeDataProviderImpl("test.csv");
        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            List<string> recipeNames = new List<string>();
            foreach (Recipe.Recipe item in rsStorage.Recipes)
            {
                recipeNames.Add(item.Name);
            }
            lbxRecipe.DataSource = recipeNames;
        }
    }
}
