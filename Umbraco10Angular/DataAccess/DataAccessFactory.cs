namespace Umbraco10Angular.DataAccess
{
    public class DataAccessFactory
    {
        public static HeroDataAccess GetHeroDataAccessObj()
        {
            return new HeroDataAccess();
        }

        public static HeroExportDataAccess ExportHeroesObj()
        {
            return new HeroExportDataAccess();
        }
    }
}
