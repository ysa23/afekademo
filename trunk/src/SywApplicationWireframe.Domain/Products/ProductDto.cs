using MongoDB.Bson;

namespace SywApplicationWireframe.Domain.Products
{
	public class ProductDto
	{
		public ObjectId Id { get; set; }
		public string Description { get; set; }
	}
}
