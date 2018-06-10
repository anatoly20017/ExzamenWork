using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesDataUnit;
using ResipesEntities.Code;

namespace FunctionsLibrary
{
    public class MyInterLayer
    {
        private Product _product;
        private Dish _dish;
        private Recipe _recipe;
        private List<Product> _listProduct = new List<Product>();
        private List<Dish> _dishes = new List<Dish>();
        private List<Counter> _listCounter = new List<Counter>();
        public List<Product> listProduct
        {
            get { return _listProduct; }
        }
        public string dim
        {
            get { return _product.Dimension; }
        }
        public string dishName
        {
            get { return _dish.Name; }
        }
        public string dishRecipe
        {
            get { return _dish.Recipe.TextRecipe; }
        }

        public List<string> dishProductsName

        {
            get
            {
                List<string> returnProducts = new List<string>();
                foreach (Product product in _dish.Recipe.Products)
                {
                    returnProducts.Add(product.Name);
                }
                return returnProducts;
            }
        }

        public List<string> dishProductsDim

        {
            get
            {
                List<string> returnProducts = new List<string>();
                foreach (Product product in _dish.Recipe.Products)
                {
                    returnProducts.Add(product.Dimension);
                }
                return returnProducts;
            }
        }

        public List<int> dishProductCounter
        {
            get
            {
                List<int> returnCounter = new List<int>();
                foreach (Counter counter in _dish.Recipe.Counts)
                {
                    returnCounter.Add(counter.counts);
                }
                return returnCounter;
            }
        }
        public bool Add(string name, string dimension, int count)
        {
            try
            {
                if (name.CompareTo(string.Empty) != 0 && dimension.CompareTo(string.Empty) != 0 && count!=0)
                {
                    if (MyProductsPrivate(name, count))
                    {
                        _product = new Product
                        {
                            Name = name,
                            Dimension = dimension,
                            Count = count
                        };
                        Unit.ProductsRepository.AddItem(_product);
                        return true;
                    }
                    else
                    {
                        _product.Count += count;
                        Unit.ProductsRepository.ChangeItem(_product);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool MyProducts(string name, int count, bool plusToRecipe=false)
        {
            return (MyProductsPrivate(name, count, plusToRecipe));
        }
        private bool MyProductsPrivate(string name, int count, bool plusToRecipe = false)
        {
            
            if (name.CompareTo(string.Empty) != 0 && count != 0)
            {
            foreach (Product product in Unit.ProductsRepository.AllItems.ToList<Product>())
            {
                if (name.CompareTo(product.Name) == 0)
                {
                    _product = product;
                        if (plusToRecipe)
                        {
                            _listProduct.Add(product);
                            MakeCounter(count);
                        }
                    return false;
                }
            }
            return true;
            }
            else
            {
                return false;
            }
        }
        public void MakeCounter(int count)
        {
            Counter counter = new Counter { counts = count };
            Unit.CounteresRepository.AddItem(counter);
            _listCounter.Add(counter);
        }
        public bool RecipeClear()
        {
            return (RecipeClearPrivate());
        }

        private bool RecipeClearPrivate()
        {
            _listProduct.Clear();
            _listCounter.Clear();
            _product = null;
            return true;
        }

        public bool AddRecipe(string recipeName, string recipeText)
        {
            return AddRecipePrivate(recipeName, recipeText);
        }
        private bool AddRecipePrivate(string recipeName, string recipeText)
        {
            if (recipeName.CompareTo(string.Empty)!=0 && recipeText.CompareTo(string.Empty) != 0 && listProduct.Count>0)
            {
                if (MyDishesPrivate(recipeName))
                {
                    _recipe = new Recipe
                    {
                        Products = _listProduct,
                        TextRecipe = recipeText,
                        Counts = _listCounter,
                    };
                    Unit.RecipesRepository.AddItem(_recipe);
                    _dish = new Dish
                    {
                        Name = recipeName,
                        Recipe = _recipe
                    };
                    Unit.DishesRepository.AddItem(_dish);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool MyDishes(string dishName)
        {
            return MyDishesPrivate(dishName);
        }
        private bool MyDishesPrivate(string dishName)
        {
            foreach (Dish dish in Unit.DishesRepository.AllItems.ToList<Dish>())
            {
                if (dishName.CompareTo(dish.Name) == 0)
                {
                    _dish = dish;
                    return false;
                }
            }
            return true;
        }
        public List<string> ReturnDishes()
        {
            return ReturnDishesPrivate();
        }
        private List<string> ReturnDishesPrivate()
        {
            List<string> nameDishes = new List<string>();
            foreach (Dish dish in Unit.DishesRepository.AllItems.ToList<Dish>())
            {
                _dishes.Add(dish);
                nameDishes.Add(dish.Name);
            }
            return nameDishes;
        }
    }
}
