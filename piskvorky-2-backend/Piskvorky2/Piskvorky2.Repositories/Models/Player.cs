using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Piskvorky2.Repositories.Models
{
    public class Player
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; } = null!;

        public string Symbol { get; set; } = null!;

        public string BackgroundColor { get; set; } = null!;

        public string TextColor { get; set; } = null!;

        public DateTime LastActivity { get; set; } = DateTime.Now;
    }
}
