using System;
using System.Windows.Forms;

namespace RecipeApp2
{
    partial class frmMain
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
            this.database2DataSet = new RecipeApp2.Database2DataSet();
            this.ingredientDataGridView = new System.Windows.Forms.DataGridView();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblIngedients = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnUpdateRecipeName = new System.Windows.Forms.Button();
            this.lstAllIngredients = new System.Windows.Forms.ListBox();
            this.lblAllIngredients = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddToRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientDataGridView
            // 
            this.ingredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientDataGridView.Location = new System.Drawing.Point(12, 21);
            this.ingredientDataGridView.Name = "ingredientDataGridView";
            this.ingredientDataGridView.RowHeadersWidth = 51;
            this.ingredientDataGridView.RowTemplate.Height = 24;
            this.ingredientDataGridView.Size = new System.Drawing.Size(186, 389);
            this.ingredientDataGridView.TabIndex = 1;
            this.ingredientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingredientDataGridView_CellContentClick);
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(22, 57);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(58, 16);
            this.lblRecipes.TabIndex = 2;
            this.lblRecipes.Text = "Recipes";
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 16;
            this.lstRecipes.Location = new System.Drawing.Point(25, 93);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(120, 292);
            this.lstRecipes.TabIndex = 3;
            this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.lstRecipes_SelectedIndexChanged);
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 16;
            this.lstIngredients.Location = new System.Drawing.Point(252, 93);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(120, 292);
            this.lstIngredients.TabIndex = 6;
            // 
            // lblIngedients
            // 
            this.lblIngedients.AutoSize = true;
            this.lblIngedients.Location = new System.Drawing.Point(249, 57);
            this.lblIngedients.Name = "lblIngedients";
            this.lblIngedients.Size = new System.Drawing.Size(120, 16);
            this.lblIngedients.TabIndex = 5;
            this.lblIngedients.Text = "Recipe Ingredients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(178, 389);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(279, 434);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 30);
            this.btnAddRecipe.TabIndex = 7;
            this.btnAddRecipe.Text = "Add";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(12, 435);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(241, 22);
            this.txtRecipeName.TabIndex = 8;
            // 
            // btnUpdateRecipeName
            // 
            this.btnUpdateRecipeName.Location = new System.Drawing.Point(370, 434);
            this.btnUpdateRecipeName.Name = "btnUpdateRecipeName";
            this.btnUpdateRecipeName.Size = new System.Drawing.Size(135, 30);
            this.btnUpdateRecipeName.TabIndex = 9;
            this.btnUpdateRecipeName.Text = "Update Name";
            this.btnUpdateRecipeName.UseVisualStyleBackColor = true;
            this.btnUpdateRecipeName.Click += new System.EventHandler(this.btnUpdateRecipeName_Click);
            // 
            // lstAllIngredients
            // 
            this.lstAllIngredients.FormattingEnabled = true;
            this.lstAllIngredients.ItemHeight = 16;
            this.lstAllIngredients.Location = new System.Drawing.Point(477, 93);
            this.lstAllIngredients.Name = "lstAllIngredients";
            this.lstAllIngredients.Size = new System.Drawing.Size(120, 292);
            this.lstAllIngredients.TabIndex = 12;
            // 
            // lblAllIngredients
            // 
            this.lblAllIngredients.AutoSize = true;
            this.lblAllIngredients.Location = new System.Drawing.Point(474, 57);
            this.lblAllIngredients.Name = "lblAllIngredients";
            this.lblAllIngredients.Size = new System.Drawing.Size(91, 16);
            this.lblAllIngredients.TabIndex = 11;
            this.lblAllIngredients.Text = "All Ingredients";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(464, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(178, 389);
            this.dataGridView2.TabIndex = 10;
            // 
            // btnAddToRecipe
            // 
            this.btnAddToRecipe.Location = new System.Drawing.Point(648, 380);
            this.btnAddToRecipe.Name = "btnAddToRecipe";
            this.btnAddToRecipe.Size = new System.Drawing.Size(128, 30);
            this.btnAddToRecipe.TabIndex = 13;
            this.btnAddToRecipe.Text = "Add To Recipe";
            this.btnAddToRecipe.UseVisualStyleBackColor = true;
            this.btnAddToRecipe.Click += new System.EventHandler(this.btnAddToRecipe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.btnAddToRecipe);
            this.Controls.Add(this.lstAllIngredients);
            this.Controls.Add(this.lblAllIngredients);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnUpdateRecipeName);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lblIngedients);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.lblRecipes);
            this.Controls.Add(this.ingredientDataGridView);
            this.Name = "frmMain";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ingredientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Database2DataSet database2DataSet;
        private System.Windows.Forms.DataGridView ingredientDataGridView;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListBox lstRecipes;
        private ListBox lstIngredients;
        private Label lblIngedients;
        private DataGridView dataGridView1;
        private Button btnAddRecipe;
        private TextBox txtRecipeName;
        private Button btnUpdateRecipeName;
        private ListBox lstAllIngredients;
        private Label lblAllIngredients;
        private DataGridView dataGridView2;
        private Button btnAddToRecipe;
    }
}

