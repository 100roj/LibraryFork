namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Staff.Extensions;
    public class TrafficLight
    {
        public TrafficLight(int id, string locationStreet, params ServiceStation[] ServiceStations)
            : this(id, locationStreet, new HashSet<ServiceStation>(ServiceStations))
        {
        }

        public TrafficLight(int id, string locationStreet, ISet<ServiceStation> ServiceStations = null)
        {
            this.ID = id;
            this.LocationStreet = locationStreet.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(locationStreet));

            foreach (var ServiceStation in ServiceStations ?? Enumerable.Empty<ServiceStation>())
            {
                this.ServiceStations.Add(ServiceStation);
                ServiceStation.AddTrafficLight(this);
            }
        }

        [Obsolete("For ORM", true)]
        protected TrafficLight()
        {
        }

        public virtual int ID { get; protected set; }
        public virtual string LocationStreet { get; protected set; }
        public virtual ISet<ServiceStation> ServiceStations { get; protected set; } = new HashSet<ServiceStation>();

        /// <inheritdoc/>
        public override string ToString() => $"{this.LocationStreet} {this.ServiceStations.Join()}".Trim();

    }
}
