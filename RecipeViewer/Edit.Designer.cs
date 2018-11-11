namespace RecipeViewer
{
    partial class Edit
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
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lbxIngedients = new System.Windows.Forms.ListBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.txtPreperation = new System.Windows.Forms.TextBox();
            this.btn_CloseEdit = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(13, 14);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(775, 22);
            this.txtRecipeName.TabIndex = 0;
            this.txtRecipeName.TextChanged += new System.EventHandler(this.txtRecipeName_TextChanged);
            // 
            // lbxIngedients
            // 
            this.lbxIngedients.FormattingEnabled = true;
            this.lbxIngedients.ItemHeight = 16;
            this.lbxIngedients.Location = new System.Drawing.Point(13, 42);
            this.lbxIngedients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxIngedients.Name = "lbxIngedients";
            this.lbxIngedients.Size = new System.Drawing.Size(120, 212);
            this.lbxIngedients.TabIndex = 1;
            this.lbxIngedients.SelectedIndexChanged += new System.EventHandler(this.lbxIngedients_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(139, 41);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(140, 70);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 22);
            this.txtUnit.TabIndex = 3;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(140, 98);
            this.txtIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(100, 22);
            this.txtIngredient.TabIndex = 4;
            this.txtIngredient.TextChanged += new System.EventHandler(this.txtIngredient_TextChanged);
            // 
            // txtPreperation
            // 
            this.txtPreperation.Location = new System.Drawing.Point(139, 127);
            this.txtPreperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPreperation.Name = "txtPreperation";
            this.txtPreperation.Size = new System.Drawing.Size(588, 22);
            this.txtPreperation.TabIndex = 5;
            this.txtPreperation.TextChanged += new System.EventHandler(this.txtPreperation_TextChanged);
            // 
            // btn_CloseEdit
            // 
            this.btn_CloseEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_CloseEdit.Location = new System.Drawing.Point(649, 394);
            this.btn_CloseEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CloseEdit.Name = "btn_CloseEdit";
            this.btn_CloseEdit.Size = new System.Drawing.Size(100, 28);
            this.btn_CloseEdit.TabIndex = 6;
            this.btn_CloseEdit.Text = "Close";
            this.btn_CloseEdit.UseVisualStyleBackColor = true;
            this.btn_CloseEdit.Click += new System.EventHandler(this.btn_CloseEdit_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(13, 260);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngredient.TabIndex = 7;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(94, 260);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteIngredient.TabIndex = 8;
            this.btnDeleteIngredient.Text = "Delete";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.btn_CloseEdit);
            this.Controls.Add(this.txtPreperation);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lbxIngedients);
            this.Controls.Add(this.txtRecipeName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.ListBox lbxIngedients;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.TextBox txtPreperation;
        private System.Windows.Forms.Button btn_CloseEdit;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
    }
}