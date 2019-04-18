using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Common.Models
{
    public class Bios
    {
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public object Name { get; set; }

    }
}
