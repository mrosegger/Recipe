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
            outputInLabel(lbxRecipe.SelectedIndex);
        }

        public void outputInLabel(int selectedElement)
        {
            string output;
            Recipe.Recipe selectedRecipe = rsStorage.Recipes[selectedElement];
            output = $"{selectedRecipe.Name}: \n\n";
            output += "Zutaten: \n";
            foreach (RecipeItem item in selectedRecipe.Items)
            {
                output += $"{item.Count} {item.Unit} {item.Ingredient.Name}\n";
            }
            output += $"\n{selectedRecipe.Text}";
            lblOutput.Text = output;
        }

        private void lbxRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputInLabel(lbxRecipe.SelectedIndex);
        }
    }
}
