using System;
using System.Text.Json.Serialization;

namespace MyFinanceAPI.Domain.Entities;

public class Transaction : BaseEntity
{
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public decimal? Value { get; set; }
    public int? IdAccount { get; set; }  // Nome correto da coluna no banco de dados
    public string Status { get; set; }

    [JsonIgnore]
    public Account? Account { get; set; }

    public Transaction()
    {

    }

    public Transaction(DateTime date, string name, decimal value, int? idAccount, string status)
    {
        Date = date;
        Name = name;
        Value = value;
        IdAccount = idAccount;
        Status = status;
    }

    public Transaction(int id, DateTime date, string name, int idAccount, decimal value, string status)
    {
        Id = id;
        Date = date;
        Name = name;
        IdAccount = idAccount;
        Value = value;
        Status = status;
    }
}
