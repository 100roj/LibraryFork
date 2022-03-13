namespace Library.Domain
{
    using System;
    using System.Collections.Generic;
    using Library.Staff.Extensions;

    public class Dish : IEquatable<Dish>
    {
        public Dish(int id, string dishName)
        {
            this.Dish_ID = id;
            this.Name = Name.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(dishName));
        }

        [Obsolete("For ORM", true)]
        protected Dish()
        {
        }

        public virtual int Dish_ID { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual bool AddDish(Dish dish)
        {
            return dish == null
                ? throw new ArgumentNullException(nameof(dish))
                : this.Dish.Add(dish);
        }
        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj) && (ReferenceEquals(this, obj) || this.Equals(obj as Name));
        }

        /// <inheritdoc cref="IEquatable{T}"/>
        public virtual bool Equals(Dish other)
        {
            return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || this.Dish_ID == other.Dish_ID);
        }

        /// <inheritdoc/>
        public override int GetHashCode() => this.Dish_ID;
    }
}
