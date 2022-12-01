// using Newtonsoft.Json;
// using StackExchange.Redis;
// using Underdog.Orders;

// namespace Underdog.Storage;
// public class RedisStorage : IStorage
// {
//     private readonly String connectionString;
//     private readonly ConnectionMultiplexer connection;

//     public RedisStorage(String connectionString)
//     {
//         this.connectionString = connectionString;
//         this.connection = ConnectionMultiplexer.Connect(this.connectionString);
//     }

//     public List<GenericOrder> GetAllOrders()
//     {
//         throw new NotImplementedException();
//     }

//     public GenericOrder? GetOrder(Guid orderId)
//     {
//         var cache = this.connection.GetDatabase();

//         String? jsonString = cache.StringGet($"Order:{orderId}");

//         if (jsonString == null)
//         {
//             return null;
//         }

//         return JsonConvert.DeserializeObject<GenericOrder>(jsonString);
//     }

//     public void SaveOrder(GenericOrder order)
//     {
//         string jsonString = JsonConvert.SerializeObject(order, Formatting.Indented);
//         var cache = this.connection.GetDatabase();
//         cache.StringSet($"Order:{order.orderId}", jsonString);
//     } 
// }