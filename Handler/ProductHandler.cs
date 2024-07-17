using Algorithm.Objects;
using System.Collections.Generic;

namespace Algorithm.Dao
{
    public class ProductHandler
    {
        /**
         * Finds a product in the list by name.
         * @param productList The list of products to search in.
         * @param nameProduct The name of the product to find.
         * @return The product found, or null if not found.
         */
        public Product FindProduct(List<Product> productList, string nameProduct)
        {
            foreach (Product product in productList)
            {
                if (product.Name.ToUpper().Equals(nameProduct.ToUpper())) return product;
            }
            return null;
        }

        /**
         * Finds products in the list by category ID.
         * @param productList The list of products to search in.
         * @param categoryId The ID of the category to filter by.
         * @return A list of products in the specified category.
         */
        public List<Product> FindProductByCategory(List<Product> productList, int categoryId)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in productList)
            {
                if (product.CategoryId == categoryId) result.Add(product);
            }
            return result;
        }

        /**
         * Finds product names in the list that are priced less than or equal to a specified price.
         * @param productList The list of products to search in.
         * @param price The maximum price to filter by.
         * @return A list of product names that meet the price criteria.
         */
        public List<string> FindProductByPrice(List<Product> productList, int price)
        {
            List<string> result = new List<string>();
            foreach (Product product in productList)
            {
                if (product.Price <= price) result.Add(product.Name);
            }
            return result;
        }

        /**
         * Sorts the list of products by price in ascending order using bubble sort.
         * @param productList The list of products to sort.
         * @return The sorted list of products by price.
         */
        public List<Product> SortByPrice(List<Product> productList)
        {
            int loop = productList.Count;
            for (int i = 0; i < loop - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < loop - 1; j++)
                {
                    if (productList[j].Price > productList[j + 1].Price)
                    {
                        Product temp = productList[j];
                        productList[j] = productList[j + 1];
                        productList[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
            return productList;
        }

        /**
         * Sorts the list of products by name length in descending order using insertion sort.
         * @param productList The list of products to sort.
         * @return The sorted list of products by name length.
         */
        public List<Product> SortByName(List<Product> productList)
        {
            int insertIndex;
            Product insertProduct;
            for (int i = 1; i < productList.Count(); i++)
            {
                insertIndex = i;
                insertProduct = productList[i];

                while (insertIndex > 0 && productList[insertIndex - 1].Name.Length < insertProduct.Name.Length)
                {
                    productList[insertIndex] = productList[insertIndex - 1];
                    insertIndex--;
                }
                productList[insertIndex] = insertProduct;
            }
            return productList;
        }

        /**
         * Sorts the list of products by category name in ascending order using insertion sort.
         * @param productList The list of products to sort.
         * @param categoryList The list of categories for comparison.
         * @return The sorted list of products by category name.
         */
        public List<Product> SortByCategoryName(List<Product> productList, List<Category> categoryList)
        {
            int insertIndex;
            var categoryDictionary = CreateCategoryDictionary(categoryList);
            Product insertProduct;
            for (int i = 1; i < productList.Count(); i++)
            {
                insertIndex = i;
                insertProduct = productList[i];
                while (
                    insertIndex > 0 &&
                    categoryDictionary[productList[insertIndex - 1].CategoryId].CompareTo(categoryDictionary[insertProduct.CategoryId]) > 0
                )
                {
                    productList[insertIndex] = productList[insertIndex - 1];
                    insertIndex--;
                }
                productList[insertIndex] = insertProduct;
            }
            return productList;
        }

        /**
         * Maps each product to a ProductWithCategory object using category information.
         * @param productList The list of products to map.
         * @param categoryList The list of categories used for mapping.
         * @return A list of ProductWithCategory objects mapped from the products.
         */
        public List<ProductWithCategory> MapProductByCategory(List<Product> productList, List<Category> categoryList)
        {
            var categoryDictionary = CreateCategoryDictionary(categoryList);
            var productWithCategoryList = new List<ProductWithCategory>();
            foreach (Product product in productList)
            {
                ProductWithCategory newProductWithCategory = ProductWithCategory.ConvertProductToProductWithCategory(product, categoryDictionary[product.CategoryId]);
                productWithCategoryList.Add(newProductWithCategory);
            }
            return productWithCategoryList;
        }

        /**
         * Finds the product with the minimum price in the list.
         * @param productList The list of products to search.
         * @return The product with the minimum price.
         */
        public Product MinByPrice(List<Product> productList)
        {
            return GetProductByPrice(productList, 1);
        }

        /**
         * Finds the product with the maximum price in the list.
         * @param productList The list of products to search.
         * @return The product with the maximum price.
         */
        public Product MaxByPrice(List<Product> productList)
        {
            return GetProductByPrice(productList, 0);
        }

        /**
         * Helper method to get the product with either the minimum or maximum price.
         * @param productList The list of products to search.
         * @param maxOrMin 0 to find maximum price, 1 to find minimum price.
         * @return The product with the specified price extremum.
         */
        private Product GetProductByPrice(List<Product> productList, int maxOrMin)
        {
            int returnIndex = 0;
            for (int i = 1; i < productList.Count; i++)
            {
                if (maxOrMin == 1)
                {
                    if (productList[i].Price < productList[returnIndex].Price) returnIndex = i;
                }
                else
                {
                    if (productList[i].Price > productList[returnIndex].Price) returnIndex = i;
                }
            }
            return productList[returnIndex];
        }

        /**
         * Creates a dictionary of category IDs mapped to category names.
         * @param categoryList The list of categories to create the dictionary from.
         * @return A dictionary mapping category IDs to category names.
         */
        private Dictionary<int, string> CreateCategoryDictionary(List<Category> categoryList)
        {
            var categoryDictionary = new Dictionary<int, string>();
            foreach (Category category in categoryList)
            {
                categoryDictionary[category.Id] = category.Name;
            }
            return categoryDictionary;
        }

    }
}
