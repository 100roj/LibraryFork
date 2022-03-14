namespace DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Domain;

    internal class ServiceStationMap : ClassMap<ServiceStation>
    {
        public ServiceStationMap()
        {
            this.Table("ServiceStations");

            this.Id(x => x.ID);

            this.Map(x => x.ManagerName)
                .Not.Nullable();

            this.Map(x => x.LocationAddress)
                .Not.Nullable();
        }
    }
}

