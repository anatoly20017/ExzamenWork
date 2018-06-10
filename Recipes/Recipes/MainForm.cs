using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FunctionsLibrary;

namespace Recipes
{
    public partial class MainForm : Form
    {
        MyInterLayer product = new MyInterLayer();
        List<string> products = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void ProductPlusButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                
                if (product.Add(MyProductName.Text, MyProductDim.Text, int.Parse(MyProductCount.Text)))
                {
                    MyProductName.Clear();
                    MyProductDim.Clear();
                    MyProductCount.Clear();
                    MyProcessLabel.Text = "прошло";
                }
                else
                {
                    MyProcessLabel.Text = "не прошло";
                }
            }
            catch (FormatException)
            {
                MyProcessLabel.Text = "не прошло";
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void ProductToRecept_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (!product.MyProducts(ProductPlus.Text, int.Parse(ProductCounter.Text), true))
                {
                    ListOfProducts.Text = string.Concat(ListOfProducts.Text, $"{ProductPlus.Text} - {ProductCounter.Text} {product.dim};\r\n");
                    ProductCounter.Clear();
                    ProductPlus.Clear();
                }
                else
                {
                    PlusProductFunctionLabel.Text = "Добавьте продукт в закупку с количеством = 0.";
                }
            }
            catch (FormatException)
            {
                PlusProductFunctionLabel.Text = "Ошибка в формате количества.";
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void NotSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (product.RecipeClear())
            {
                Clear();
                PlusProductFunctionLabel.Text = "Отмена";
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (product.AddRecipe(DishName.Text, TextOfrepice.Text))
            {
                Clear();
                PlusProductFunctionLabel.Text = "Рецепт успешно добавлен.";
            }
            else
            {
                PlusProductFunctionLabel.Text = "Ошибки в добавлении.";
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void Clear()
        {
            DishName.Clear();
            ProductPlus.Clear();
            ProductCounter.Clear();
            ListOfProducts.Clear();
            TextOfrepice.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> myRecipes = product.ReturnDishes();
            foreach(string name in myRecipes)
            {
                RecipesTreeView.Nodes.Add(name);
                RecipesTreeView.Sort();
            }
        }

        private void RecipesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!product.MyDishes(RecipesTreeView.SelectedNode.Text))
            {
                DishName.Text = product.dishName;
                for (int i=0; i<product.dishProductsName.Count; i++)
                {
                    ListOfProducts.Text += $"{product.dishProductsName[i]} - {product.dishProductCounter[i]} {product.dishProductsDim[i]}\r\n";
                }
                TextOfrepice.Text = product.dishRecipe;
            }
        }
    }
}
