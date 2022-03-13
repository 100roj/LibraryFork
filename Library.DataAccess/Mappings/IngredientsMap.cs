namespace Library.DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    internal class IngredientsMap : ClassMap<Author>
    {
        public IngredientsMap()
        {
            this.Table("Ingredients");

            this.Id(x => x.Ing_ID);

            this.Map(x => x.ingName)
                .Not.Nullable();

            this.Map(x => x.Weight)
                .Nullable();

            this.Map(x => x.DateProduced)
                .Not.Nullable();

            this.Map(x => x.DateExpired)
                .Not.Nullable();

            this.Map(x => x.RequireFridge)
                .Not.Nullable();

            this.HasManyToMany(x => x.Books)
                .Cascade.Delete();
        }
    }
}
