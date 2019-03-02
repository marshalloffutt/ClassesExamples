using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples
{
    class Candy
    {
        // Properties
        public string Flavor { get; }
        public int Rating { get; private set; }
        public string Review { get; private set; }
        public string Name { get; }
        public CandyType Type { get; }

        // Fields
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        // Constructor
        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        // Methods
        public void SetRating(int userRating)
        {
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are so dumb. Ratings are {MinRatingValue}-{MaxRatingValue}.");
            }
        }

        // Method overloading example
        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        public override string ToString()
        {
            return $"This is {Type} {Name}, with a(n) {Flavor} flavor, rated {Rating} with a review of {Review}.";
        }
    }

    // Enums outside of class
    enum CandyType
    {
        Chocolate, // 0
        Hard, // 1
        Caramel, // 2
        Sour, // 3
        Stretchy, // 4
        Nut // 5
    }
}
