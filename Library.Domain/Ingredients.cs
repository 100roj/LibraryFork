namespace Library.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Library.Staff.Extensions;

    public class Ingredients
    {
        public Ingredients(int id, string name, float weight, DateTime dateProduced, DateTime dateExpired, bool reqFr)
        {
            this.Id = id;
            this.ingName = name.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(name));
            this.Weight = weight;
            this.DateProduced = dateProduced;
            this.DateExpired = dateExpired;
            this.RequireFridge = reqFr;
        }
    }

        [Obsolete("For ORM", true)]
        protected Ingredients()
        {
        }

        public virtual int Ing_ID { get; protected set; }

        public virtual string ingName { get; set; }

        public virtual float Weight { get; protected set; }

        public virtual DateTime DateProduced { get; protected set; }

        public virtual DateTime DateExpired { get; protected set; }

        public virtual bool RequireFridge { get; protected set; }
    }
}
