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
        static int currentRecipeID;
        public Edit(int currentRecipe, ref bool RecipeChanged)
        {
            InitializeComponent();
            currentRecipeID = currentRecipe;
            init();
        }

        public Edit()
        {
            InitializeComponent();
        }

        public void init()
        {
            txtRecipeName.Text = rsStorage.Recipes[currentRecipeID].Name;
            List<string> recipeitems = new List<string>();
            foreach (RecipeItem item in rsStorage.Recipes[currentRecipeID].Items)
            {
                recipeitems.Add(item.Ingredient.Name);
            }
            lbxIngedients.DataSource = recipeitems;
            try
            {
                txtAmount.Text = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Count.ToString();
                txtIngredient.Text = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Ingredient.Name.ToString();
                txtUnit.Text = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Unit.ToString();
                txtPreperation.Text = rsStorage.Recipes[currentRecipeID].Text;
            }
            catch
            {
            }

        }

        private void lbxIngedients_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAmount.Text = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Count.ToString();
            txtIngredient.Text = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Ingredient.Name.ToString();
            txtUnit.Text = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Unit.ToString();
        }

        private void txtRecipeName_TextChanged(object sender, EventArgs e)
        {
            rsStorage.Recipes[currentRecipeID].Name = txtRecipeName.Text;
            rsStorage.StoreData();
            //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(txtAmount.Text, out uint result))
            {
                rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Count = result;
                rsStorage.StoreData();
                //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
            }
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Unit = txtUnit.Text;
            rsStorage.StoreData();
            //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
        }

        private void txtIngredient_TextChanged(object sender, EventArgs e)
        {
            rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Ingredient.Name = txtIngredient.Text;
            rsStorage.StoreData();
            lbxIngedients.Invalidate();
            //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
        }

        private void txtPreperation_TextChanged(object sender, EventArgs e)
        {
            rsStorage.Recipes[currentRecipeID].Text = txtPreperation.Text;
            rsStorage.StoreData();
            //(System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).init();
        }
        /*
        private void RefreshedRecipe()
        {
            if (rebuildIngredient)
            {
                RecipeItem itemToDelete = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex];
                Ingredient ingredientToDelete = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Ingredient;
                Ingredient refreshedIngredient = new Ingredient();
                refreshedIngredient.ID = rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex].Ingredient.ID;
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
                rsStorage.Recipes[currentRecipeID].deleteIngredient(itemToDelete);
                rsStorage.Recipes[currentRecipeID].addIngredient(refreshedRecipeItem);
            }
        }*/

        private void btn_CloseEdit_Click(object sender, EventArgs e)
        {
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
            rsStorage.Recipes[currentRecipeID].addIngredient(newRecipeItem);
            init();
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            rsStorage.Recipes[currentRecipeID].deleteIngredient(rsStorage.Recipes[currentRecipeID].Items[lbxIngedients.SelectedIndex]);
            init();
        }
    }
}
