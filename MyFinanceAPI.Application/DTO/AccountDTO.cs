using System;
using System.ComponentModel;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MyFinanceAPI.Domain.Entities;

namespace MyFinanceAPI.Application.DTO;

public class AccountDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Value { get; set; }
    public int Categoryid { get; set; }

    public ICollection<Transaction>? Transactions { get; set; }

    public AccountDTO() { }

    public AccountDTO(string name, decimal value, int categoryId, ICollection<Transaction>? updates)
    {
        Name = name;
        Value = value;
        Categoryid = categoryId;
        Transactions = updates;
    }

    public AccountDTO(int id, string name, decimal value, int categoryId, ICollection<Transaction>? updates)
    {
        Id = id;
        Name = name;
        Value = value;
        Categoryid = categoryId;
        Transactions = updates;
    }
}
