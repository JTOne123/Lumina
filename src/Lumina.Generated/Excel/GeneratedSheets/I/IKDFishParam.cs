using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDFishParam", columnHash: 0x5a516458 )]
    public class IKDFishParam : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Fish;

        // col: 01 offset: 0004
        public byte IKDContentBonus;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Fish = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            IKDContentBonus = parser.ReadOffset< byte >( 0x4 );


        }
    }
}