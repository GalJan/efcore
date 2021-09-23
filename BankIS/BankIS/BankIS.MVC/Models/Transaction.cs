using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BankIS.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int ID {  get; set; }

        public DateTime Date {  get; set; }

        public TransactionType Type {  get; set; }  

        /// <summary>
        /// Debetni operace jsou zaporne hodnoty
        /// Kreditni operace jsou kladne hodnoty
        /// </summary>
        public double Value {  get; set; }
    }

    public enum TransactionType
    {
        [Description("Debetni operace (odchozi)")]
        DEBIT,
        [Description("Kreditni operace (prichozi)")]
        CREDIT
    }
}
