namespace FFXIVClientStructs.FFXIV.Component.Text;

[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe partial struct MacroDecoder {
    [FieldOffset(0x08)] public StdVector<nint> DecoderFuncs; // idx is the macro code byte

    [FieldOffset(0x38)] public StdDeque<TextParameter> GlobalParameters;

    [StaticAddress("48 8D 1D ?? ?? ?? ?? 8B 43 20", 3)]
    public static partial Tm* GetMacroTime();
}

//
// GlobalParameters
// Note that the StdDeque (and this list) is zero-based, so you need to subtract 1 from gnum/gstr.
//
// |-------|---------------|----------------------------------------------------------|
// | Index | Type          | Label                                                    |
// |-------|---------------|----------------------------------------------------------|
// |     0 | Utf8String    | Player Name                                              |
// |     1 | String        | Log Message Name 1                                       |
// |     2 | String        | Log Message Name 2                                       |
// |     3 | Integer       | Player Sex                                               |
// |    10 | Integer       | Eorzea Time Hours                                        |
// |    11 | Integer       | Eorzea Time Minutes                                      |
// |    12 | Integer       | Log Text Colors - Chat 1 - Say                           |
// |    13 | Integer       | Log Text Colors - Chat 1 - Shout                         |
// |    14 | Integer       | Log Text Colors - Chat 1 - Tell                          |
// |    15 | Integer       | Log Text Colors - Chat 1 - Party                         |
// |    16 | Integer       | Log Text Colors - Chat 1 - Alliance                      |
// | 17-24 | Integer       | Log Text Colors - Chat 2 - LS1-8                         |
// |    25 | Integer       | Log Text Colors - Chat 2 - Free Company                  |
// |    26 | Integer       | Log Text Colors - Chat 2 - PvP Team                      |
// | 29,30 | Integer       | Log Text Colors - Chat 1 - Emotes                        |
// |    31 | Integer       | Log Text Colors - Chat 1 - Yell                          |
// |    34 | Integer       | Log Text Colors - Chat 2 - CWLS1                         |
// |    27 | Integer       | Log Text Colors - General - PvP Team Announcements       |
// |    28 | Integer       | Log Text Colors - Chat 2 - Novice Network                |
// |    32 | Integer       | Log Text Colors - General - Free Company Announcements   |
// |    33 | Integer       | Log Text Colors - General - Novice Network Announcements |
// |    35 | Integer       | Log Text Colors - Battle - Damage Dealt                  |
// |    36 | Integer       | Log Text Colors - Battle - Missed Attacks                |
// |    37 | Integer       | Log Text Colors - Battle - Actions                       |
// |    38 | Integer       | Log Text Colors - Battle - Items                         |
// |    39 | Integer       | Log Text Colors - Battle - Healing                       |
// |    40 | Integer       | Log Text Colors - Battle - Enchanting Effects            |
// |    41 | Integer       | Log Text Colors - Battle - Enfeebing Effects             |
// |    42 | Integer       | Log Text Colors - General - Echo                         |
// |    43 | Integer       | Log Text Colors - General - System Messages              |
// |    54 | Utf8String    | Companion Name                                           |
// |    56 | Integer       | Log Text Colors - General - Battle System Messages       |
// |    57 | Integer       | Log Text Colors - General - Gathering System Messages    |
// |    58 | Integer       | Log Text Colors - General - Error Messages               |
// |    59 | Integer       | Log Text Colors - General - NPC Dialogue                 |
// |    60 | Integer       | Log Text Colors - General - Item Drops                   |
// |    61 | Integer       | Log Text Colors - General - Level Up                     |
// |    62 | Integer       | Log Text Colors - General - Loot                         |
// |    63 | Integer       | Log Text Colors - General - Synthesis                    |
// |    64 | Integer       | Log Text Colors - General - Gathering                    |
// |    67 | Integer       | Player ClassJobId                                        |
// |    68 | Integer       | Player Level                                             |
// |    70 | Integer       | Player Race                                              |
// |    77 | Integer       | Client/Plattform?                                        |
// |    82 | Integer       | Datacenter Region (see WorldDCGroupType sheet)           |
// |-------|---------------|----------------------------------------------------------|
