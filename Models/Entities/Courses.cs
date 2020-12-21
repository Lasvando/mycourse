using System;
using System.Collections.Generic;
using MyCourse.Models.Services.Infrastructure;

namespace MyCourse.Models.Entities
{
    public partial class Course
    {
        public Course(string title, string author)
        {
            if(string.IsNullOrEmpty(title)){
                throw new ArgumentException("Il corso deve avere un titolo");
            }
            if(string.IsNullOrEmpty(author)){
                throw new ArgumentException("Il corso deve avere un autore");
            }

            Title = title;
            Author = author;

            Lessons = new HashSet<Lesson>();
        }

        public long Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ImagePath { get; private set; }
        public string Author { get; private set; }
        public string Email { get; private set; }
        public double Rating { get; private set; }
        public Money FullPrice { get; private set; }
        public Money CurrentPrice { get; private set; }

        public virtual ICollection<Lesson> Lessons { get; private set; }

        public void ChangeTitle(string newTitle){
            if(string.IsNullOrEmpty(newTitle)){
                throw new ArgumentException("Il corso deve avere un titolo");
            }
            Title = newTitle;
        }

        public void ChangePrices(Money newFullPrice, Money newDiscountPrice){
            if(newFullPrice == null || newDiscountPrice == null){
                throw new ArgumentException("I prezzi non possono essere nulli");
            }
            if(newFullPrice.Currency != newDiscountPrice.Currency){
                throw new ArgumentException("Non possono avere una currency diversa");
            }
            if(newFullPrice.Amount < newDiscountPrice.Amount){
                throw new ArgumentException("Il prezzo intero non può essere minore di quello scontato");
            }
            FullPrice = newFullPrice;
            CurrentPrice = newDiscountPrice;
        }        
    }
}
