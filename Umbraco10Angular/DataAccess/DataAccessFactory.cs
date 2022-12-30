namespace Umbraco10Angular.DataAccess
{
    public class DataAccessFactory
    {
        public static HeroDataAccess GetHeroDataAccessObj()
        {
           // The returned HeroDataAccess class is our low-level component.
            return new HeroDataAccess();
        }

        public static CSVExportDataAccess ExportHeroesObj()
        {
            return new CSVExportDataAccess();
        }
    }
}
