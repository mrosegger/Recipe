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
    public partial class MainForm : Form
    {
        RecipeDataProviderImpl rsStorage = new RecipeDataProviderImpl("C:/Users/Em0ting0fficer/Desktop/test.csv");
        public static bool RecipeChanged;
        public MainForm()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            rsStorage = new RecipeDataProviderImpl("C:/Users/Em0ting0fficer/Desktop/test.csv");
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
            string selcetElement = (string)lbxRecipe.SelectedItem;
            foreach (Recipe.Recipe item in rsStorage.Recipes)
            {
                if (item.Name == selcetElement)
                {
                    outputInLabel((int)item.ID - 1);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            bool emptySearch = false;
            List<string> queryResults = new List<string>();
            foreach (Recipe.Recipe item in rsStorage.Recipes)
            {
                if (item.Name.ToLower().Contains(searchQuery.ToLower()))
                {
                    queryResults.Add(item.Name);
                }
                else if(searchQuery == "")
                {
                    emptySearch = true;
                }
            }
            if (emptySearch)
            {
                init();
            }
            else
            {
                lbxRecipe.DataSource = queryResults;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
			Edit edit = new Edit(lbxRecipe.SelectedIndex, ref RecipeChanged);
            edit.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RecipeChanged)
            {
                init();
                RecipeChanged = false;
            }
        }

        private void btn_AddRecipe_Click(object sender, EventArgs e)
        {
            Recipe.Recipe newRecipe = new Recipe.Recipe();
            newRecipe.Name = "new Recipe";
            rsStorage.AddRecipe(newRecipe);
            init();
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            rsStorage.DeleteRecipe(rsStorage.Recipes[lbxRecipe.SelectedIndex]);
            init();
        }
    }
}
