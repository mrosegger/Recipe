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
            this.components = new System.ComponentModel.Container();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lbxIngedients = new System.Windows.Forms.ListBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.txtPreperation = new System.Windows.Forms.TextBox();
            this.btn_CloseEdit = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.txtnewIngredient = new System.Windows.Forms.TextBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(10, 11);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(582, 20);
            this.txtRecipeName.TabIndex = 0;
            this.txtRecipeName.TextChanged += new System.EventHandler(this.txtRecipeName_TextChanged);
            // 
            // lbxIngedients
            // 
            this.lbxIngedients.FormattingEnabled = true;
            this.lbxIngedients.Location = new System.Drawing.Point(10, 34);
            this.lbxIngedients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxIngedients.Name = "lbxIngedients";
            this.lbxIngedients.Size = new System.Drawing.Size(91, 173);
            this.lbxIngedients.TabIndex = 1;
            this.lbxIngedients.SelectedIndexChanged += new System.EventHandler(this.lbxIngedients_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(104, 33);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(76, 20);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(105, 57);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(76, 20);
            this.txtUnit.TabIndex = 3;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(105, 80);
            this.txtIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(76, 20);
            this.txtIngredient.TabIndex = 4;
            this.txtIngredient.TextChanged += new System.EventHandler(this.txtIngredient_TextChanged);
            // 
            // txtPreperation
            // 
            this.txtPreperation.Location = new System.Drawing.Point(104, 103);
            this.txtPreperation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreperation.Name = "txtPreperation";
            this.txtPreperation.Size = new System.Drawing.Size(442, 20);
            this.txtPreperation.TabIndex = 5;
            this.txtPreperation.TextChanged += new System.EventHandler(this.txtPreperation_TextChanged);
            // 
            // btn_CloseEdit
            // 
            this.btn_CloseEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_CloseEdit.Location = new System.Drawing.Point(487, 320);
            this.btn_CloseEdit.Name = "btn_CloseEdit";
            this.btn_CloseEdit.Size = new System.Drawing.Size(75, 23);
            this.btn_CloseEdit.TabIndex = 6;
            this.btn_CloseEdit.Text = "Close";
            this.btn_CloseEdit.UseVisualStyleBackColor = true;
            this.btn_CloseEdit.Click += new System.EventHandler(this.btn_CloseEdit_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(11, 238);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(56, 19);
            this.btnAddIngredient.TabIndex = 7;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(71, 238);
            this.btnDeleteIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteIngredient.TabIndex = 8;
            this.btnDeleteIngredient.Text = "Delete";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // txtnewIngredient
            // 
            this.txtnewIngredient.Location = new System.Drawing.Point(13, 213);
            this.txtnewIngredient.Name = "txtnewIngredient";
            this.txtnewIngredient.Size = new System.Drawing.Size(100, 20);
            this.txtnewIngredient.TabIndex = 9;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtnewIngredient);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.btn_CloseEdit);
            this.Controls.Add(this.txtPreperation);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lbxIngedients);
            this.Controls.Add(this.txtRecipeName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtnewIngredient;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}