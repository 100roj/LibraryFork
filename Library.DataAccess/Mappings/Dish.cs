namespace Library.DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    internal class DishMap : ClassMap<Author>
    {
        public DishMap()
        {
            this.Table("Storage");

            this.Id(x => x.Storage_ID);

            this.Map(x => x.IsFridge)
                .Not.Nullable();

            this.HasManyToMany(x => x.Books)
                .Cascade.Delete();
        }
    }
}
