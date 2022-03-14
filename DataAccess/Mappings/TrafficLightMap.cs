namespace DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Domain;

    internal class TrafficLightMap : ClassMap<TrafficLight>
    {
        public TrafficLightMap()
        {
            this.Table("TrafficLights");

            this.Id(x => x.ID);

            this.Map(x => x.LocationStreet)
                .Not.Nullable();
        }
    }
}
