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
    public partial class Edit : Form
    {
        RecipeDataProviderImpl rsStorage = new RecipeDataProviderImpl("C:/temp/test.csv");
        //static int currentRecipeID;
        Recipe.Recipe currentRecipe = new Recipe.Recipe();
        public Edit(int currentRecipeID, ref bool RecipeChanged)
        {
            InitializeComponent();
            //currentRecipeID = currentRecipe;
            currentRecipe = getRecipe(currentRecipeID);
            init();
        }

        public Edit()
        {
            InitializeComponent();
        }

        public void init()
        {
            txtRecipeName.Text = currentRecipe.Name;
            List<string> recipeitems = new List<string>();
            foreach (RecipeItem item in currentRecipe.Items)
            {
                recipeitems.Add(item.Ingredient.Name);
            }
            lbxIngedients.DataSource = recipeitems;
            try
            {
                txtAmount.Text = currentRecipe.Items[lbxIngedients.SelectedIndex].Count.ToString();
                txtIngredient.Text = currentRecipe.Items[lbxIngedients.SelectedIndex].Ingredient.Name.ToString();
                txtUnit.Text = currentRecipe.Items[lbxIngedients.SelectedIndex].Unit.ToString();
                txtPreperation.Text = currentRecipe.Text;
            }
            catch
            {
            }

        }

        private void lbxIngedients_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAmount.Text = currentRecipe.Items[lbxIngedients.SelectedIndex].Count.ToString();
            txtIngredient.Text = currentRecipe.Items[lbxIngedients.SelectedIndex].Ingredient.Name.ToString();
            txtUnit.Text = currentRecipe.Items[lbxIngedients.SelectedIndex].Unit.ToString();
        }

        private void txtRecipeName_TextChanged(object sender, EventArgs e)
        {
            currentRecipe.Name = txtRecipeName.Text;
            rsStorage.StoreData();
            //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(txtAmount.Text, out uint result))
            {
                currentRecipe.Items[lbxIngedients.SelectedIndex].Count = result;
                rsStorage.StoreData();
                //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
            }
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            currentRecipe.Items[lbxIngedients.SelectedIndex].Unit = txtUnit.Text;
            rsStorage.StoreData();
            //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
        }

        private void txtIngredient_TextChanged(object sender, EventArgs e)
        {
            currentRecipe.Items[lbxIngedients.SelectedIndex].Ingredient.Name = txtIngredient.Text;
            rsStorage.StoreData();
            lbxIngedients.Invalidate();
            //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
        }

        private void txtPreperation_TextChanged(object sender, EventArgs e)
        {
            currentRecipe.Text = txtPreperation.Text;
            rsStorage.StoreData();
            //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
        }
        /*
        private void RefreshedRecipe()
        {
            if (rebuildIngredient)
            {
                RecipeItem itemToDelete = currentRecipe.Items[lbxIngedients.SelectedIndex];
                Ingredient ingredientToDelete = currentRecipe.Items[lbxIngedients.SelectedIndex].Ingredient;
                Ingredient refreshedIngredient = new Ingredient();
                refreshedIngredient.ID = currentRecipe.Items[lbxIngedients.SelectedIndex].Ingredient.ID;
                refreshedIngredient.Name = txtIngredient.Text;
                rsStorage.DeleteIngredient(ingredientToDelete);
                rsStorage.AddIngredient(refreshedIngredient);
                RecipeItem refreshedRecipeItem = new RecipeItem();
                refreshedRecipeItem.Ingredient = refreshedIngredient;
                if (uint.TryParse(txtAmount.Text, out uint result))
                {
                    refreshedRecipeItem.Count = result;
                }
                refreshedRecipeItem.Unit = txtUnit.Text;
                currentRecipe.deleteIngredient(itemToDelete);
                currentRecipe.addIngredient(refreshedRecipeItem);
            }
        }*/

        private void btn_CloseEdit_Click(object sender, EventArgs e)
        {
            writeRecipe();
            (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingredient newIngredient = new Ingredient();
            newIngredient.Name = "new Ingredient";
            if (txtnewIngredient.Text != "")
            {
                newIngredient.Name = txtnewIngredient.Text;
                txtnewIngredient.Text = "";
            }
            rsStorage.AddIngredient(newIngredient);
            RecipeItem newRecipeItem = new RecipeItem();
            newRecipeItem.Ingredient = newIngredient;
            newRecipeItem.Count = 0;
            newRecipeItem.Unit = "";
            currentRecipe.addIngredient(newRecipeItem);
            init();
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            currentRecipe.deleteIngredient(currentRecipe.Items[lbxIngedients.SelectedIndex]);
            init();
        }

        //TODO Test if this works;; Also add one to wirte to the database
        private Recipe.Recipe getRecipe(int recipeID)
        {
            Recipe.Recipe fetchedRecipe = new Recipe.Recipe();

            foreach (Recipe.Recipe recipe in rsStorage.Recipes)
            {
                if (recipe.ID == recipeID)
                {
                    fetchedRecipe = recipe;
                }
            }

            return fetchedRecipe;
        }

        private void writeRecipe()
        {
            int setRecipeID = 0;
            for (int index = 0; index < rsStorage.Recipes.Count; index++)
            {
                if (rsStorage.Recipes[index].ID == currentRecipe.ID)
                {
                    setRecipeID = index;
                }
            }
            rsStorage.Recipes[setRecipeID].Name = currentRecipe.Name;
            rsStorage.Recipes[setRecipeID].Text = currentRecipe.Text;
            int StorageRecipeCount = rsStorage.Recipes[setRecipeID].Items.Count;
            int ToBeSetRecipeCount = currentRecipe.Items.Count;
            List<RecipeItem> RecipeItemList = new List<RecipeItem>();
            foreach (RecipeItem item in currentRecipe.Items)
            {
                RecipeItemList.Add(item);
            }
            //Fix issue to delete right recipes
            for (int index = StorageRecipeCount; index > 0; index--)
            {
                rsStorage.Recipes[setRecipeID].deleteIngredient(rsStorage.Recipes[setRecipeID].Items[index - 1]);
            }
            for (int index = 0; index < ToBeSetRecipeCount; index++)
            {
                rsStorage.Recipes[setRecipeID].addIngredient(RecipeItemList[index]);
            }
            rsStorage.StoreData();
        }
    }
}
