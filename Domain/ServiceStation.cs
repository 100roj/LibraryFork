namespace Domain
{
    using System;
    using System.Collections.Generic;
    using Staff.Extensions;
    
    public class ServiceStation : IEquatable<ServiceStation>
    {
        public ServiceStation(int id, string managerName, string locationaddress)
        {
            this.ID = id;
            this.ManagerName = managerName.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(managerName));
            this.LocationAddress = locationaddress.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(locationaddress));
        }
        
        [Obsolete("For ORM", true)]
        protected ServiceStation()
        {
        }
        public virtual int ID { get; protected set; }
        public virtual string ManagerName { get; protected set; }
        public virtual string LocationAddress { get; protected set; }
        public virtual string FullInfo => $"{this.ManagerName} {this.LocationAddress}".Trim();

        public virtual ISet<TrafficLight> TrafficLightes { get; protected set; } = new HashSet<TrafficLight>();

        public virtual bool AddTrafficLight(TrafficLight class1)
        {
            return class1 == null
                ? throw new ArgumentNullException(nameof(class1))
                : this.TrafficLightes.Add(class1);
        }

        public override string ToString() => this.FullInfo;

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj) && (ReferenceEquals(this, obj) || this.Equals(obj as ServiceStation));
        }

        public virtual bool Equals(ServiceStation other)
        {
            return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || this.ID == other.ID);
        }

        public override int GetHashCode() => this.ID;
    }
}

