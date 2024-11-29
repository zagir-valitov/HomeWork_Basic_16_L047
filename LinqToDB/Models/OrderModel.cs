using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using ColumnAttribute = LinqToDB.Mapping.ColumnAttribute;
using TableAttribute = LinqToDB.Mapping.TableAttribute;


namespace LinqToDB.Models
{
    [Table("orders")]
    public class OrderModel
    {
        [PrimaryKey, Identity]
        [Column("id")]
        public int OrderID { get; set; }


        [Column("customerid")]
        [ForeignKey("FK_RelationCustomer")]
        public int CustomerID { get; set; }


        [Column("productid")]
        [ForeignKey("FK_RelationProduct")]
        public int ProductID { get; set; }


        [Column("quantity")]
        public int Quantity { get; set; }


        [Association(ThisKey = nameof(OrderModel.ProductID), OtherKey = nameof(ProductModel.ProductID))]
        public ProductModel Relations { get; set; } = new ProductModel();


        //[Association(ThisKey = nameof(OrderModel.CustomerID), OtherKey = nameof(CustomerModel.CustomerID))]
        //public CustomerModel RelationsOnCustomer { get; set; } = new CustomerModel();       
    }
}
