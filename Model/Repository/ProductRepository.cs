/*using supermercadosq.Domain;
using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Response;

namespace supermercadosq.Model.Repository{
    public class ProductRepository
    {
        public Product CreateProduct(ProductRequest productRequest, DatabaseConnection context)
        {
        var product = new Product
        {
            Name = productRequest.Name,
            Ingredient = productRequest.Ingredient,
            Image = productRequest.Image,
            Status = productRequest.Status,
            User = productRequest.User,
            CreationDate = DateTime.UtcNow,
            UpdateDate = DateTime.UtcNow
        };
        context.Products.Add(product);
        context.SaveChanges();

        return product;
        }
        
        public Product UpdateProduct(int id, ProductRequest productRequest, DatabaseConnection context)
        {
            var product = context.Products.Where(p => p.Id == id).First();

            product.Name = productRequest.Name != null ? productRequest.Name : product.Name;
            product.Ingredient = productRequest.Ingredient != null ? productRequest.Ingredient : product.Ingredient;
            product.Image = productRequest.Image != null ? productRequest.Image : product.Image; 
            product.Status = productRequest.Status != null ? productRequest.Status : product.Status;
            product.User = productRequest.User != null ? productRequest.User : product.User;
            product.UpdateDate = DateTime.UtcNow;

        context.SaveChanges();

        return product;
        }

        public Product DeleteProduct(int id, DatabaseConnection context)
        {
            var product = context.Products.Where(p => p.Id == id).First();

        context.Products.Remove(product);
        context.SaveChanges();

        return product;
        }

        public List<ProductResponse> GetAllProduct(DatabaseConnection context)
        {
            List<Product> products = context.Products.ToList();
            List<ProductResponse> responses = new List<ProductResponse>();
            foreach(Product product in products)
            {
                var response = new ProductResponse
                (
                    product.Name,
                    product.Ingredient,
                    product.Image
                );
                responses.Add(response);
            }
            return responses;
        }

        public ProductResponse GetProductSingle(int id, DatabaseConnection context)
        {
            var product = context.Products.Where(p => p.Id == id).First();
            
                var response = new ProductResponse
                (
                    product.Name,
                    product.Ingredient,
                    product.Image
                );
            
            return response;
        }
    }
}*/