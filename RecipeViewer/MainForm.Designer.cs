namespace RecipeViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbxRecipe = new System.Windows.Forms.ListBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_AddRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.txt_newIngredient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxRecipe
            // 
            this.lbxRecipe.FormattingEnabled = true;
            this.lbxRecipe.Location = new System.Drawing.Point(10, 12);
            this.lbxRecipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxRecipe.Name = "lbxRecipe";
            this.lbxRecipe.Size = new System.Drawing.Size(150, 290);
            this.lbxRecipe.TabIndex = 6;
            this.lbxRecipe.SelectedIndexChanged += new System.EventHandler(this.lbxRecipe_SelectedIndexChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(164, 32);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(427, 318);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "RECIPE TEXT";
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.Location = new System.Drawing.Point(164, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(428, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(533, 331);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 19);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_AddRecipe
            // 
            this.btn_AddRecipe.Location = new System.Drawing.Point(10, 337);
            this.btn_AddRecipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddRecipe.Name = "btn_AddRecipe";
            this.btn_AddRecipe.Size = new System.Drawing.Size(56, 19);
            this.btn_AddRecipe.TabIndex = 10;
            this.btn_AddRecipe.Text = "Add";
            this.btn_AddRecipe.UseVisualStyleBackColor = true;
            this.btn_AddRecipe.Click += new System.EventHandler(this.btn_AddRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(71, 336);
            this.btnDeleteRecipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteRecipe.TabIndex = 11;
            this.btnDeleteRecipe.Text = "Delete";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // txt_newIngredient
            // 
            this.txt_newIngredient.Location = new System.Drawing.Point(10, 308);
            this.txt_newIngredient.Name = "txt_newIngredient";
            this.txt_newIngredient.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_newIngredient.Size = new System.Drawing.Size(150, 20);
            this.txt_newIngredient.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txt_newIngredient);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btn_AddRecipe);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbxRecipe);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRecipe;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_AddRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.TextBox txt_newIngredient;
    }

    
}

