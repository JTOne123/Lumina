using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StatusHitEffect", columnHash: 0xd870e208 )]
    public class StatusHitEffect : IExcelRow
    {
        
        public LazyRow< VFX > Location;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Location = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}