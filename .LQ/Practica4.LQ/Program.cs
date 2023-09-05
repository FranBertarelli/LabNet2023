using Lq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Query Menu!");

            while (true)
            {
                Console.WriteLine("Selecciona la query:");
                Console.WriteLine("1. Query para devolver objeto customer");
                Console.WriteLine("2. Query para devolver todos los productos sin stock");
                Console.WriteLine("3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por\nunidad");
                Console.WriteLine("4. Query para devolver todos los customers de la Región WA");
                Console.WriteLine("5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de\nproducto sea igual a 789");
                Console.WriteLine("6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en\nMinuscula.");
                Console.WriteLine("7. Query para devolver Join entre Customers y Orders donde los customers sean de la \nRegión WA y la fecha de orden sea mayor a 1/1/1997.");
                Console.WriteLine("8. Query para devolver los primeros 3 Customers de la  Región WA");
                Console.WriteLine("9. Query para devolver lista de productos ordenados por nombre");
                Console.WriteLine("10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
                Console.WriteLine("11. Query para devolver las distintas categorías asociadas a los productos");
                Console.WriteLine("12. Query para devolver el primer elemento de una lista de productos");
                Console.WriteLine("13. Query para devolver los customer con la cantidad de ordenes asociadas");
                Console.WriteLine("14. Para Salir del programa");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                CustomersLogic customersLogic = new CustomersLogic();
                                var customer = customersLogic.CustomerObject();

                                Console.WriteLine("CUSTOMER:");
                                Console.WriteLine($"Id: {customer.CustomerID}");
                                Console.WriteLine($"Contact Name: {customer.ContactName}");
                                Console.WriteLine($"Company Name: {customer.CompanyName}");
                                Console.WriteLine($"Country: {customer.Country}");
                                Console.WriteLine($"Contact Title: {customer.ContactTitle}");
                                Console.WriteLine($"Address: {customer.Address}");
                                Console.WriteLine($"City: {customer.City}");
                                Console.WriteLine($"Region: {customer.Region}");
                                Console.WriteLine($"Postal Code: {customer.PostalCode}");
                                Console.WriteLine($"Country: {customer.Country}");
                                Console.WriteLine($"Phone: {customer.Phone}");
                                Console.WriteLine($"Fax: {customer.Fax}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 2:
                            try
                            {
                                ProductsLogic productsLogic = new ProductsLogic();
                                var products = productsLogic.ProductsWithNoStock();

                                Console.WriteLine("Productos sin Stock:");
                                foreach (var product in products)
                                {
                                    Console.WriteLine($"Product ID: {product.ProductID} - Product Name: {product.ProductName}");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 3:
                            try
                            {
                                ProductsLogic productsLogic = new ProductsLogic();
                                var products = productsLogic.ProductsWithStock();

                                Console.WriteLine("productos que tienen stock y que cuestan más de 3 por\nunidad:");
                                foreach (var product in products)
                                {
                                    Console.WriteLine($"Product ID: {product.ProductID} - Product Name: {product.ProductName} - Unit Price: {product.UnitPrice} - Units In Stock: {product.UnitsInStock}");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 4:
                            try
                            {
                                CustomersLogic customersLogic = new CustomersLogic();
                                var customersInRegionWA = customersLogic.CustomersInRegionWA();

                                Console.WriteLine("customers de la Región WA:");
                                foreach (var customer in customersInRegionWA)
                                {
                                    Console.WriteLine($"ID: {customer.CustomerID} - Contact Name: {customer.ContactName} - Company Name: {customer.CompanyName} - Country: {customer.Country}");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 5:
                            try
                            {
                                ProductsLogic productsLogic = new ProductsLogic();
                                var productInfo = productsLogic.GetProductId(789);
                                Console.WriteLine(productInfo);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 6:
                            try
                            {
                                CustomersLogic customersLogic = new CustomersLogic();
                                var customers = customersLogic.CustomerNamesUpperAndLower();

                                Console.WriteLine("nombre de los Customers:");

                                foreach (var customer in customers)
                                {
                                    Console.WriteLine($"UpperCase: {customer.ToUpper()} - LowerCase: {customer.ToLower()} ");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 7:
                            try
                            {
                                CustomersLogic customersLogic = new CustomersLogic();
                                var customers = customersLogic.JoinCustomersFromWaAndOrderDate();

                                Console.WriteLine("Customers y Orders donde los customers sean de la \nRegión WA y la fecha de orden sea mayor a 1/1/1997:");

                                foreach (var customer in customers)
                                {
                                    Console.WriteLine($"Customer ID: {customer.CustomerID} - Contact Name: {customer.ContactName} - Company Name: {customer.CompanyName} - Country: {customer.Country}");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 8:
                            try
                            {
                                CustomersLogic customersLogic = new CustomersLogic();
                                var customers = customersLogic.First3CustomersFromWA();

                                Console.WriteLine("los primeros 3 Customers de la  Región WA:");

                                foreach (var customer in customers)
                                {
                                    Console.WriteLine($"Customer ID: {customer.CustomerID} - Contact Name: {customer.ContactName} - Company Name: {customer.CompanyName} - Country: {customer.Country}");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 9:
                            try
                            {
                                ProductsLogic productsLogic = new ProductsLogic();
                                var products = productsLogic.GetProductsOrderedByName();

                                Console.WriteLine("productos ordenados por nombre:");
                                foreach (var product in products)
                                {
                                    Console.WriteLine($"Product Name: {product.ProductName}");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 10:
                            try
                            {
                                ProductsLogic productsLogic = new ProductsLogic();
                                var products = productsLogic.GetProductsOrderedByUnitsInStockDesc();

                                Console.WriteLine("productos ordenados por unit in stock de mayor a menor:");
                                foreach (var product in products)
                                {
                                    Console.WriteLine($"Product Name: {product.ProductName} - Units In Stock: {product.UnitsInStock}");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 11:
                            try
                            {
                                CategoriesLogic categoriesLogic = new CategoriesLogic();
                                var differentsCategories = categoriesLogic.DifferentsCategories();

                                Console.WriteLine("Categorias de Productos:");
                                foreach (var category in differentsCategories)
                                {
                                    Console.WriteLine($"- {category}");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        case 12:
                            try
                            {
                                ProductsLogic productsLogic = new ProductsLogic();
                                var product = productsLogic.GetFirstProduct();

                                Console.WriteLine("First Product:");
                                Console.WriteLine($"Product Name: {product.ProductName} - Units In Stock: {product.UnitsInStock}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: ({ex.GetType().Name}): {ex.Message}");
                            }
                            break;

                        

                        case 14:
                            Console.WriteLine("Saliendo :)");
                            return;

                        default:
                            Console.WriteLine("Invalido, seleccione una opcion valida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalido. Pon un numero valido.");
                }

                Console.WriteLine("Presiona una tecla para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
