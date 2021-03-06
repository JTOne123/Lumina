using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DisposalShopFilterType", columnHash: 0xdebb20e3 )]
    public class DisposalShopFilterType : IExcelRow
    {
        
        public string Category;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Category = parser.ReadColumn< string >( 0 );
        }
    }
}