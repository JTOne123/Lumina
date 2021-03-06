using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceWeather", columnHash: 0xfaedad07 )]
    public class ChocoboRaceWeather : IExcelRow
    {
        
        public LazyRow< Weather > WeatherType1;
        public LazyRow< Weather > WeatherType2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            WeatherType1 = new LazyRow< Weather >( lumina, parser.ReadColumn< int >( 0 ), language );
            WeatherType2 = new LazyRow< Weather >( lumina, parser.ReadColumn< int >( 1 ), language );
        }
    }
}