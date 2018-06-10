namespace Recipes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductPlusButton = new System.Windows.Forms.Button();
            this.MyProductName = new System.Windows.Forms.TextBox();
            this.MyProductDim = new System.Windows.Forms.TextBox();
            this.MyProductCount = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.MyProductDimensionLabel = new System.Windows.Forms.Label();
            this.ProductCountLabel = new System.Windows.Forms.Label();
            this.MyProcessLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.ProductsPlus = new System.Windows.Forms.Label();
            this.RecipesPlus = new System.Windows.Forms.Label();
            this.DishNameLabel = new System.Windows.Forms.Label();
            this.ProductPlusLabel = new System.Windows.Forms.Label();
            this.ProductToRecept = new System.Windows.Forms.Button();
            this.ProductRecipeLabel = new System.Windows.Forms.Label();
            this.ListOfProducts = new System.Windows.Forms.TextBox();
            this.TextOfRecipeLabel = new System.Windows.Forms.Label();
            this.TextOfrepice = new System.Windows.Forms.TextBox();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.DishName = new System.Windows.Forms.TextBox();
            this.ProductPlus = new System.Windows.Forms.TextBox();
            this.ProductCounter = new System.Windows.Forms.TextBox();
            this.RecipesTreeView = new System.Windows.Forms.TreeView();
            this.ListrecipesLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NotSave = new System.Windows.Forms.Button();
            this.PlusProductFunctionLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductPlusButton
            // 
            this.ProductPlusButton.Location = new System.Drawing.Point(15, 179);
            this.ProductPlusButton.Name = "ProductPlusButton";
            this.ProductPlusButton.Size = new System.Drawing.Size(359, 23);
            this.ProductPlusButton.TabIndex = 0;
            this.ProductPlusButton.Text = "Добавить продукт";
            this.ProductPlusButton.UseVisualStyleBackColor = true;
            this.ProductPlusButton.Click += new System.EventHandler(this.ProductPlusButton_Click);
            // 
            // MyProductName
            // 
            this.MyProductName.Location = new System.Drawing.Point(162, 50);
            this.MyProductName.Name = "MyProductName";
            this.MyProductName.Size = new System.Drawing.Size(212, 22);
            this.MyProductName.TabIndex = 1;
            // 
            // MyProductDim
            // 
            this.MyProductDim.Location = new System.Drawing.Point(162, 91);
            this.MyProductDim.Name = "MyProductDim";
            this.MyProductDim.Size = new System.Drawing.Size(212, 22);
            this.MyProductDim.TabIndex = 2;
            // 
            // MyProductCount
            // 
            this.MyProductCount.Location = new System.Drawing.Point(162, 132);
            this.MyProductCount.Name = "MyProductCount";
            this.MyProductCount.Size = new System.Drawing.Size(212, 22);
            this.MyProductCount.TabIndex = 3;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(15, 53);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(63, 17);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Продукт";
            // 
            // MyProductDimensionLabel
            // 
            this.MyProductDimensionLabel.AutoSize = true;
            this.MyProductDimensionLabel.Location = new System.Drawing.Point(15, 94);
            this.MyProductDimensionLabel.Name = "MyProductDimensionLabel";
            this.MyProductDimensionLabel.Size = new System.Drawing.Size(141, 17);
            this.MyProductDimensionLabel.TabIndex = 5;
            this.MyProductDimensionLabel.Text = "Единица измерений";
            // 
            // ProductCountLabel
            // 
            this.ProductCountLabel.AutoSize = true;
            this.ProductCountLabel.Location = new System.Drawing.Point(15, 135);
            this.ProductCountLabel.Name = "ProductCountLabel";
            this.ProductCountLabel.Size = new System.Drawing.Size(86, 17);
            this.ProductCountLabel.TabIndex = 6;
            this.ProductCountLabel.Text = "Количество";
            // 
            // MyProcessLabel
            // 
            this.MyProcessLabel.AutoSize = true;
            this.MyProcessLabel.Location = new System.Drawing.Point(159, 216);
            this.MyProcessLabel.Name = "MyProcessLabel";
            this.MyProcessLabel.Size = new System.Drawing.Size(0, 17);
            this.MyProcessLabel.TabIndex = 7;
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(15, 216);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(94, 17);
            this.InformationLabel.TabIndex = 8;
            this.InformationLabel.Text = "Добавление:";
            // 
            // ProductsPlus
            // 
            this.ProductsPlus.AutoSize = true;
            this.ProductsPlus.Location = new System.Drawing.Point(15, 18);
            this.ProductsPlus.Name = "ProductsPlus";
            this.ProductsPlus.Size = new System.Drawing.Size(138, 17);
            this.ProductsPlus.TabIndex = 9;
            this.ProductsPlus.Text = "Закупка продуктов:";
            // 
            // RecipesPlus
            // 
            this.RecipesPlus.AutoSize = true;
            this.RecipesPlus.Location = new System.Drawing.Point(390, 18);
            this.RecipesPlus.Name = "RecipesPlus";
            this.RecipesPlus.Size = new System.Drawing.Size(153, 17);
            this.RecipesPlus.TabIndex = 10;
            this.RecipesPlus.Text = "Добавление рецепов:";
            // 
            // DishNameLabel
            // 
            this.DishNameLabel.AutoSize = true;
            this.DishNameLabel.Location = new System.Drawing.Point(390, 53);
            this.DishNameLabel.Name = "DishNameLabel";
            this.DishNameLabel.Size = new System.Drawing.Size(118, 17);
            this.DishNameLabel.TabIndex = 11;
            this.DishNameLabel.Text = "Название блюда";
            // 
            // ProductPlusLabel
            // 
            this.ProductPlusLabel.AutoSize = true;
            this.ProductPlusLabel.Location = new System.Drawing.Point(393, 93);
            this.ProductPlusLabel.Name = "ProductPlusLabel";
            this.ProductPlusLabel.Size = new System.Drawing.Size(129, 17);
            this.ProductPlusLabel.TabIndex = 12;
            this.ProductPlusLabel.Text = "Добавить продукт";
            // 
            // ProductToRecept
            // 
            this.ProductToRecept.Location = new System.Drawing.Point(390, 179);
            this.ProductToRecept.Name = "ProductToRecept";
            this.ProductToRecept.Size = new System.Drawing.Size(359, 23);
            this.ProductToRecept.TabIndex = 13;
            this.ProductToRecept.Text = "Добавить продукт";
            this.ProductToRecept.UseVisualStyleBackColor = true;
            this.ProductToRecept.Click += new System.EventHandler(this.ProductToRecept_Click);
            // 
            // ProductRecipeLabel
            // 
            this.ProductRecipeLabel.AutoSize = true;
            this.ProductRecipeLabel.Location = new System.Drawing.Point(393, 135);
            this.ProductRecipeLabel.Name = "ProductRecipeLabel";
            this.ProductRecipeLabel.Size = new System.Drawing.Size(151, 17);
            this.ProductRecipeLabel.TabIndex = 14;
            this.ProductRecipeLabel.Text = "Количество продукта";
            // 
            // ListOfProducts
            // 
            this.ListOfProducts.Location = new System.Drawing.Point(390, 245);
            this.ListOfProducts.Multiline = true;
            this.ListOfProducts.Name = "ListOfProducts";
            this.ListOfProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListOfProducts.Size = new System.Drawing.Size(359, 158);
            this.ListOfProducts.TabIndex = 15;
            // 
            // TextOfRecipeLabel
            // 
            this.TextOfRecipeLabel.AutoSize = true;
            this.TextOfRecipeLabel.Location = new System.Drawing.Point(773, 20);
            this.TextOfRecipeLabel.Name = "TextOfRecipeLabel";
            this.TextOfRecipeLabel.Size = new System.Drawing.Size(153, 17);
            this.TextOfRecipeLabel.TabIndex = 16;
            this.TextOfRecipeLabel.Text = "Добавление рецепов:";
            // 
            // TextOfrepice
            // 
            this.TextOfrepice.Location = new System.Drawing.Point(776, 50);
            this.TextOfrepice.Multiline = true;
            this.TextOfrepice.Name = "TextOfrepice";
            this.TextOfrepice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextOfrepice.Size = new System.Drawing.Size(319, 353);
            this.TextOfrepice.TabIndex = 17;
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(776, 410);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(319, 23);
            this.AddRecipeButton.TabIndex = 18;
            this.AddRecipeButton.Text = "Добавить рецепт";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // DishName
            // 
            this.DishName.Location = new System.Drawing.Point(550, 50);
            this.DishName.Name = "DishName";
            this.DishName.Size = new System.Drawing.Size(199, 22);
            this.DishName.TabIndex = 19;
            // 
            // ProductPlus
            // 
            this.ProductPlus.Location = new System.Drawing.Point(550, 91);
            this.ProductPlus.Name = "ProductPlus";
            this.ProductPlus.Size = new System.Drawing.Size(199, 22);
            this.ProductPlus.TabIndex = 20;
            // 
            // ProductCounter
            // 
            this.ProductCounter.Location = new System.Drawing.Point(550, 132);
            this.ProductCounter.Name = "ProductCounter";
            this.ProductCounter.Size = new System.Drawing.Size(199, 22);
            this.ProductCounter.TabIndex = 21;
            // 
            // RecipesTreeView
            // 
            this.RecipesTreeView.Location = new System.Drawing.Point(15, 282);
            this.RecipesTreeView.Name = "RecipesTreeView";
            this.RecipesTreeView.Size = new System.Drawing.Size(359, 121);
            this.RecipesTreeView.TabIndex = 22;
            this.RecipesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RecipesTreeView_AfterSelect);
            // 
            // ListrecipesLabel
            // 
            this.ListrecipesLabel.AutoSize = true;
            this.ListrecipesLabel.Location = new System.Drawing.Point(15, 245);
            this.ListrecipesLabel.Name = "ListrecipesLabel";
            this.ListrecipesLabel.Size = new System.Drawing.Size(93, 17);
            this.ListrecipesLabel.TabIndex = 23;
            this.ListrecipesLabel.Text = "Список блюд";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Удалить блюдо";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NotSave
            // 
            this.NotSave.Location = new System.Drawing.Point(390, 410);
            this.NotSave.Name = "NotSave";
            this.NotSave.Size = new System.Drawing.Size(359, 23);
            this.NotSave.TabIndex = 25;
            this.NotSave.Text = "Отмена";
            this.NotSave.UseVisualStyleBackColor = true;
            this.NotSave.Click += new System.EventHandler(this.NotSave_Click);
            // 
            // PlusProductFunctionLabel
            // 
            this.PlusProductFunctionLabel.AutoSize = true;
            this.PlusProductFunctionLabel.Location = new System.Drawing.Point(396, 215);
            this.PlusProductFunctionLabel.Name = "PlusProductFunctionLabel";
            this.PlusProductFunctionLabel.Size = new System.Drawing.Size(0, 17);
            this.PlusProductFunctionLabel.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(547, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Режим просмотра";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(576, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(519, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Режим добавления";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 468);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PlusProductFunctionLabel);
            this.Controls.Add(this.NotSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListrecipesLabel);
            this.Controls.Add(this.RecipesTreeView);
            this.Controls.Add(this.ProductCounter);
            this.Controls.Add(this.ProductPlus);
            this.Controls.Add(this.DishName);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.TextOfrepice);
            this.Controls.Add(this.TextOfRecipeLabel);
            this.Controls.Add(this.ListOfProducts);
            this.Controls.Add(this.ProductRecipeLabel);
            this.Controls.Add(this.ProductToRecept);
            this.Controls.Add(this.ProductPlusLabel);
            this.Controls.Add(this.DishNameLabel);
            this.Controls.Add(this.RecipesPlus);
            this.Controls.Add(this.ProductsPlus);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.MyProcessLabel);
            this.Controls.Add(this.ProductCountLabel);
            this.Controls.Add(this.MyProductDimensionLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.MyProductCount);
            this.Controls.Add(this.MyProductDim);
            this.Controls.Add(this.MyProductName);
            this.Controls.Add(this.ProductPlusButton);
            this.Name = "MainForm";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProductPlusButton;
        private System.Windows.Forms.TextBox MyProductName;
        private System.Windows.Forms.TextBox MyProductDim;
        private System.Windows.Forms.TextBox MyProductCount;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label MyProductDimensionLabel;
        private System.Windows.Forms.Label ProductCountLabel;
        private System.Windows.Forms.Label MyProcessLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label ProductsPlus;
        private System.Windows.Forms.Label RecipesPlus;
        private System.Windows.Forms.Label DishNameLabel;
        private System.Windows.Forms.Label ProductPlusLabel;
        private System.Windows.Forms.Button ProductToRecept;
        private System.Windows.Forms.Label ProductRecipeLabel;
        private System.Windows.Forms.TextBox ListOfProducts;
        private System.Windows.Forms.Label TextOfRecipeLabel;
        private System.Windows.Forms.TextBox TextOfrepice;
        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.TextBox DishName;
        private System.Windows.Forms.TextBox ProductPlus;
        private System.Windows.Forms.TextBox ProductCounter;
        private System.Windows.Forms.TreeView RecipesTreeView;
        private System.Windows.Forms.Label ListrecipesLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NotSave;
        private System.Windows.Forms.Label PlusProductFunctionLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

