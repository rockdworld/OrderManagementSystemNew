using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OrderMgmtSystem.ProductService.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public string Packing { get; set; }
        public int Rating { get; set; }
    }
}
