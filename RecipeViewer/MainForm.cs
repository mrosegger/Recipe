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
        RecipeDataProviderImpl rsStorage = new RecipeDataProviderImpl("C:/Users/temp/test.csv");
        public static bool RecipeChanged;
        List<int> recipIDs;
        public MainForm()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            rsStorage = new RecipeDataProviderImpl("C:/temp/test.csv");
            List<string> recipeNames = new List<string>();
            recipIDs = new List<int>();
            foreach (Recipe.Recipe item in rsStorage.Recipes)
            {
                recipeNames.Add(item.Name);
                recipIDs.Add((int)item.ID);
            }
            lbxRecipe.DataSource = recipeNames;
            outputInLabel((int)recipIDs[lbxRecipe.SelectedIndex]);
        }

        public void outputInLabel(int selectedElement)
        {
            string output;
            Recipe.Recipe selectedRecipe = new Recipe.Recipe();
            foreach (Recipe.Recipe recipe in rsStorage.Recipes)
            {
                if (recipe.ID == selectedElement)
                {
                    selectedRecipe = recipe;
                }
            }            
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
                    outputInLabel((int)item.ID);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            bool emptySearch = false;
            List<string> queryResults = new List<string>();
            recipIDs = new List<int>();
            foreach (Recipe.Recipe item in rsStorage.Recipes)
            {
                if (item.Name.ToLower().Contains(searchQuery.ToLower()))
                {
                    queryResults.Add(item.Name);
                    recipIDs.Add((int)item.ID);

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
            Edit edit = new Edit((int)recipIDs[lbxRecipe.SelectedIndex], ref RecipeChanged);
            edit.ShowDialog();
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
            if (txt_newIngredient.Text != "")
            {
                newRecipe.Name = txt_newIngredient.Text;
                txt_newIngredient.Text = "";
            }
            rsStorage.AddRecipe(newRecipe);
            init();
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            Recipe.Recipe recipeToDelete = new Recipe.Recipe();
            foreach (Recipe.Recipe recipe in rsStorage.Recipes)
            {
                if (recipe.ID == recipIDs[lbxRecipe.SelectedIndex])
                {
                    recipeToDelete = recipe;
                }
            }
            rsStorage.DeleteRecipe(recipeToDelete);
            init();
        }
    }
}
