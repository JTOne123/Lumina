using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DefaultTalk", columnHash: 0xe6dec88d )]
    public class DefaultTalk : IExcelRow
    {
        
        public uint Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public LazyRow< ActionTimeline >[] ActionTimelinePose;
        public byte Unknown8;
        public byte Unknown9;
        public byte Unknown10;
        public ushort Unknown11;
        public ushort Unknown12;
        public ushort Unknown13;
        public byte Unknown14;
        public byte Unknown15;
        public byte Unknown16;
        public bool Unknown17;
        public bool Unknown18;
        public bool Unknown19;
        public string[] Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            ActionTimelinePose = new LazyRow< ActionTimeline >[ 3 ];
            for( var i = 0; i < 3; i++ )
                ActionTimelinePose[ i ] = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 5 + i ), language );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown13 = parser.ReadColumn< ushort >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            Text = new string[ 3 ];
            for( var i = 0; i < 3; i++ )
                Text[ i ] = parser.ReadColumn< string >( 20 + i );
        }
    }
}