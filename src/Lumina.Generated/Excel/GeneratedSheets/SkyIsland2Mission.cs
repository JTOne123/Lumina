using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2Mission", columnHash: 0xf300dfd1 )]
    public class SkyIsland2Mission : IExcelRow
    {
        
        public LazyRow< EventItem > Item1;
        public LazyRow< EventItem > Item2;
        public ushort Unknown2;
        public ushort Unknown3;
        public LazyRow< SkyIsland2MissionDetail > Objective1;
        public uint Unknown5;
        public byte RequiredAmount1;
        public uint Unknown7;
        public byte Unknown8;
        public LazyRow< SkyIsland2MissionDetail > Objective2;
        public uint Unknown10;
        public byte RequiredAmount2;
        public uint Unknown12;
        public byte Unknown13;
        public LazyRow< SkyIsland2MissionDetail > Objective3;
        public uint Unknown15;
        public byte Unknown16;
        public uint Unknown17;
        public byte Unknown18;
        public uint Unknown19;
        public uint Image;
        public string Unknown21;
        public string Unknown22;
        public string Unknown23;
        public string Unknown24;
        public string Unknown25;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item1 = new LazyRow< EventItem >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Item2 = new LazyRow< EventItem >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Objective1 = new LazyRow< SkyIsland2MissionDetail >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            RequiredAmount1 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Objective2 = new LazyRow< SkyIsland2MissionDetail >( lumina, parser.ReadColumn< ushort >( 9 ), language );
            Unknown10 = parser.ReadColumn< uint >( 10 );
            RequiredAmount2 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Objective3 = new LazyRow< SkyIsland2MissionDetail >( lumina, parser.ReadColumn< ushort >( 14 ), language );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            Image = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< string >( 21 );
            Unknown22 = parser.ReadColumn< string >( 22 );
            Unknown23 = parser.ReadColumn< string >( 23 );
            Unknown24 = parser.ReadColumn< string >( 24 );
            Unknown25 = parser.ReadColumn< string >( 25 );
        }
    }
}