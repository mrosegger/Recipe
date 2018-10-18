namespace RecipeViewer
{
    partial class Form1
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
            this.lbxRecipe = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxRecipe
            // 
            this.lbxRecipe.FormattingEnabled = true;
            this.lbxRecipe.ItemHeight = 16;
            this.lbxRecipe.Location = new System.Drawing.Point(13, 13);
            this.lbxRecipe.Name = "lbxRecipe";
            this.lbxRecipe.Size = new System.Drawing.Size(199, 420);
            this.lbxRecipe.TabIndex = 0;
            this.lbxRecipe.SelectedIndexChanged += new System.EventHandler(this.lbxRecipe_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.Location = new System.Drawing.Point(219, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(569, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(219, 42);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(569, 391);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "RECIPE TEXT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbxRecipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRecipe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblOutput;
    }
}

