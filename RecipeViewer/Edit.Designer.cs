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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(50, 10);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(539, 20);
            this.txtRecipeName.TabIndex = 0;
            this.txtRecipeName.TextChanged += new System.EventHandler(this.txtRecipeName_TextChanged);
            // 
            // lbxIngedients
            // 
            this.lbxIngedients.FormattingEnabled = true;
            this.lbxIngedients.Location = new System.Drawing.Point(10, 34);
            this.lbxIngedients.Margin = new System.Windows.Forms.Padding(2);
            this.lbxIngedients.Name = "lbxIngedients";
            this.lbxIngedients.Size = new System.Drawing.Size(91, 173);
            this.lbxIngedients.TabIndex = 1;
            this.lbxIngedients.SelectedIndexChanged += new System.EventHandler(this.lbxIngedients_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(189, 38);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(76, 20);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(189, 62);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(76, 20);
            this.txtUnit.TabIndex = 3;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(189, 86);
            this.txtIngredient.Margin = new System.Windows.Forms.Padding(2);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(76, 20);
            this.txtIngredient.TabIndex = 4;
            this.txtIngredient.TextChanged += new System.EventHandler(this.txtIngredient_TextChanged);
            // 
            // txtPreperation
            // 
            this.txtPreperation.Location = new System.Drawing.Point(109, 137);
            this.txtPreperation.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnAddIngredient.Location = new System.Drawing.Point(10, 256);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(56, 19);
            this.btnAddIngredient.TabIndex = 7;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(70, 256);
            this.btnDeleteIngredient.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteIngredient.TabIndex = 8;
            this.btnDeleteIngredient.Text = "Delete";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // txtnewIngredient
            // 
            this.txtnewIngredient.Location = new System.Drawing.Point(10, 231);
            this.txtnewIngredient.Name = "txtnewIngredient";
            this.txtnewIngredient.Size = new System.Drawing.Size(100, 20);
            this.txtnewIngredient.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Unit: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingredient:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Directions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "New Ingredient:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name:";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}