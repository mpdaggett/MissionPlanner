

using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN {




        public const int UAVCAN_PROTOCOL_FILE_ENTRYTYPE_MAX_PACK_SIZE = 1;
        public const ulong UAVCAN_PROTOCOL_FILE_ENTRYTYPE_DT_SIG = 0x6924572FBB2086E5;





        public const double UAVCAN_PROTOCOL_FILE_ENTRYTYPE_FLAG_FILE = 1; // saturated uint8

        public const double UAVCAN_PROTOCOL_FILE_ENTRYTYPE_FLAG_DIRECTORY = 2; // saturated uint8

        public const double UAVCAN_PROTOCOL_FILE_ENTRYTYPE_FLAG_SYMLINK = 4; // saturated uint8

        public const double UAVCAN_PROTOCOL_FILE_ENTRYTYPE_FLAG_READABLE = 8; // saturated uint8

        public const double UAVCAN_PROTOCOL_FILE_ENTRYTYPE_FLAG_WRITEABLE = 16; // saturated uint8




        public partial class uavcan_protocol_file_EntryType: IDroneCANSerialize {



            public uint8_t flags = new uint8_t();




            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx)
            {
                encode_uavcan_protocol_file_EntryType(this, chunk_cb, ctx);
            }

            public void decode(CanardRxTransfer transfer)
            {
                decode_uavcan_protocol_file_EntryType(transfer, this);
            }
        }
    }
}
