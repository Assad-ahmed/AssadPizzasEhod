using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; 
namespace Pizzéria.Models
{
    public class PizzaEhod
    {
        [Key]  
        public int IdEhod {get; set;}
        public string? NomEhod {get; set;}
        public string? DescriptionEhod{get; set;}
    }

   

    public class PizzaEhodDB : DbContext
    {
        public PizzaEhodDB(DbContextOptions<PizzaEhodDB> options)
            : base(options) { }

        public DbSet<PizzaEhod> Pizzas { get; set; } = null!;
    }
}