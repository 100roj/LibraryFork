namespace Library.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Library.Staff.Extensions;

    public class Storage
    {
        public Storage(int id, bool isFr)
        {
            this.Storage_ID = id;
            this.IsFridge = isFr;
        }
    }

        [Obsolete("For ORM", true)]
        protected Storage()
        {
        }

        public virtual int Storage_ID { get; protected set; }
        public virtual bool IsFridge { get; protected set; }
    }
}
