namespace Library.DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    internal class StorageMap : ClassMap<Author>
    {
        public StorageMap()
        {
            this.Table("Storage");

            this.Id(x => x.Dish_ID);

            this.Map(x => x.Name)
                .Not.Nullable();

            this.HasManyToMany(x => x.Books)
                .Cascade.Delete();
        }
    }
}
