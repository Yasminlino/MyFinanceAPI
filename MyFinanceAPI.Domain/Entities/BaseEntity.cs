using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyFinanceAPI.Domain.Entities;

public class BaseEntity
{
    public int Id { get; set; }
}