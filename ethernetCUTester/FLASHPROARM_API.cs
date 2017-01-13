using System;
using System.Runtime.InteropServices;

namespace ethernetCUTester
{
    class FLASHPROARM_API
    {
        const string SEL_DLL = "FlashProARM-FPAsel.dll";

        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////MULTI API-DLL FUNCTIONS/////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

        //void   MSPPRG_API	F_Trace_ON( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Trace_ON", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern void F_Trace_ON();

        //void   MSPPRG_API	F_Trace_OFF( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Trace_OFF", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern void F_Trace_OFF();
     
        //INT_X  MSPPRG_API	F_OpenInstancesAndFPAs( char * FileName );
        [DllImport(SEL_DLL, EntryPoint = "F_OpenInstancesAndFPAs", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_OpenInstancesAndFPAs(String FileName);

        //INT_X  MSPPRG_API	F_CloseInstances( void );
        [DllImport(SEL_DLL, EntryPoint = "F_CloseInstances", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_CloseInstances();

        //INT_X  MSPPRG_API	F_Set_FPA_index( BYTE fpa );
        [DllImport(SEL_DLL, EntryPoint = "F_Set_FPA_index", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Set_FPA_index(byte fpa);

        //BYTE	 MSPPRG_API	F_Get_FPA_index( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_FPA_index", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte F_Get_FPA_index();

        //INT_X  MSPPRG_API	F_Check_FPA_index( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Check_FPA_index", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Check_FPA_index();

        //INT_X  MSPPRG_API	F_LastStatus( BYTE fpa );
        [DllImport(SEL_DLL, EntryPoint = "F_LastStatus", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_LastStatus(byte fpa);

        //INT_X  MSPPRG_API	F_Multi_DLLTypeVer( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Multi_DLLTypeVer", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Multi_DLLTypeVer();

        //INT_X  MSPPRG_API	F_Get_FPA_SN( BYTE fpa );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_FPA_SN", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Get_FPA_SN(byte fpa);
      
        //INT_X  MSPPRG_API	F_GetProgressBar( BYTE fpa );
        [DllImport(SEL_DLL, EntryPoint = "F_GetProgressBar", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_GetProgressBar(byte fpa);

        //INT_X  MSPPRG_API	F_GetLastOpCode( BYTE fpa );
        [DllImport(SEL_DLL, EntryPoint = "F_GetLastOpCode", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_GetLastOpCode(byte fpa);

        //void  MSPPRG_API	F_Disable_FPA_index( BYTE fpa );
        [DllImport(SEL_DLL, EntryPoint = "F_Disable_FPA_index", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern void F_Disable_FPA_index(byte fpa);

        //void  MSPPRG_API	F_Enable_FPA_index( BYTE fpa );
        [DllImport(SEL_DLL, EntryPoint = "F_Enable_FPA_index", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern void F_Enable_FPA_index(byte fpa);

        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////GENERIC FUNCTIONS///////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

        //INT_X  MSPPRG_API	F_Initialization( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Initialization", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Initialization();

        //INT_X  MSPPRG_API	F_Get_Device_Info( INT_X index );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_Device_Info", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Get_Device_Info(Int32 index);

        //INT_X  MSPPRG_API	F_Reset_Target( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Reset_Target", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Reset_Target();

        //char* F_Report_Message( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Report_Message", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern String F_Report_Message();

        //INT_X  MSPPRG_API	F_Set_MCU_Name( char * MCU_name );
        [DllImport(SEL_DLL, EntryPoint = "F_Set_MCU_Name", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Set_MCU_Name(String MCU_name);

        //char F_GetReportMessageChar( INT_X index );
        [DllImport(SEL_DLL, EntryPoint = "F_GetReportMessageChar", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern char F_GetReportMessageChar(Int32 index);


        //INT_X  MSPPRG_API F_Use_Config_INI(BYTE use);
        [DllImport(SEL_DLL, EntryPoint = "F_Use_Config_INI", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Use_Config_INI(byte use);

        //MSPPRG_API char *	F_Get_Config_Name_List( INT_X index );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_Config_Name_List", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern String F_Get_Config_Name_List(Int32 index);

        //unsigned int MSPPRG_API F_Get_Config_Value_By_Name(char *name, INT_X type);
        [DllImport(SEL_DLL, EntryPoint = "F_Get_Config_Value_By_Name", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 F_Get_Config_Value_By_Name(String name, Int32 type);

        //INT_X	MSPPRG_API F_Set_Config_Value_By_Name(char *name, unsigned int newValue);
        [DllImport(SEL_DLL, EntryPoint = "F_Set_Config_Value_By_Name", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Set_Config_Value_By_Name(String name, UInt32 newValue);

        //char *  F_Get_MCU_Name_list( INT_X type, INT_X index );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_MCU_Name_list", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern String F_Get_MCU_Name_list(Int32 type, Int32 index);

        //INT_X  MSPPRG_API	F_Set_MCU_Family_Group( INT_X type, INT_X index );
        [DllImport(SEL_DLL, EntryPoint = "F_Set_MCU_Family_Group", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Set_MCU_Family_Group(Int32 type, Int32 index);

        //INT_X F_DLLTypeVer( void );
        [DllImport(SEL_DLL, EntryPoint = "F_DLLTypeVer", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_DLLTypeVer();

        //INT_X  MSPPRG_API	F_ConfigFileLoad( char * filename );
        [DllImport(SEL_DLL, EntryPoint = "F_ConfigFileLoad", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_ConfigFileLoad(String filename);

        //INT_X	 MSPPRG_API	F_Power_Target( INT_X OnOff );
        [DllImport(SEL_DLL, EntryPoint = "F_Power_Target", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Power_Target(Int32 OnOff);

        //INT_X  MSPPRG_API	F_Get_Targets_Vcc( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_Targets_Vcc", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Get_Targets_Vcc();

        //INT_X	 MSPPRG_API	F_Set_fpa_io_state( BYTE jtag, BYTE reset, BYTE VccOn );
        [DllImport(SEL_DLL, EntryPoint = "F_Set_fpa_io_state", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Set_fpa_io_state(byte jtag, byte reset, byte VccOn);

        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////DATA BUFFER FUNCTIONS///////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

        //INT_X  MSPPRG_API	F_ReadCodeFile( char * FileName );
        [DllImport(SEL_DLL, EntryPoint = "F_ReadCodeFile", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_ReadCodeFile(String FileName);

        //INT_X  MSPPRG_API	F_AppendCodeFile( char * FileName );
        [DllImport(SEL_DLL, EntryPoint = "F_AppendCodeFile", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_AppendCodeFile(String FileName);

        //INT_X  MSPPRG_API	F_Get_CodeCS( INT_X dest );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_CodeCS", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Get_CodeCS(Int32 dest);

        //INT_X  MSPPRG_API	F_Clr_Code_Buffer( void  );
        [DllImport(SEL_DLL, EntryPoint = "F_Clr_Code_Buffer", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Clr_Code_Buffer();

        //INT_X  MSPPRG_API	F_Put_Byte_to_Code_Buffer( INT_X  addr, BYTE data );
        [DllImport(SEL_DLL, EntryPoint = "F_Put_Byte_to_Code_Buffer", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Put_Byte_to_Code_Buffer(Int32 addr, byte data);

        //INT_X  MSPPRG_API	F_Get_Byte_from_Code_Buffer( INT_X  addr );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_Byte_from_Code_Buffer", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Get_Byte_from_Code_Buffer(Int32 addr);


        //INT_X  MSPPRG_API	F_Put_Byte_to_Buffer( INT_X  addr, BYTE data );
        [DllImport(SEL_DLL, EntryPoint = "F_Put_Byte_to_Buffer", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Put_Byte_to_Buffer(Int32 addr, byte data);

        //INT_X  MSPPRG_API	F_Get_Byte_from_Buffer( INT_X  addr );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_Byte_from_Buffer", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Get_Byte_from_Buffer(Int32 addr);

        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////ENCAPSULATED FUNCTIONS///////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

        //INT_X  MSPPRG_API	F_AutoProgram( INT_X mode );
        [DllImport(SEL_DLL, EntryPoint = "F_AutoProgram", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_AutoProgram(Int32 mode);

        //INT_X  MSPPRG_API	F_Verify_Access_to_MCU( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Verify_Access_to_MCU", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Verify_Access_to_MCU();

        //INT_X  MSPPRG_API	F_Memory_Erase( INT_X mode );
        [DllImport(SEL_DLL, EntryPoint = "F_Memory_Erase", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Memory_Erase(Int32 mode);

        //INT_X  MSPPRG_API	F_Memory_Blank_Check( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Memory_Blank_Check", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Memory_Blank_Check();

        //INT_X  MSPPRG_API	F_Memory_Write( INT_X mode );
        [DllImport(SEL_DLL, EntryPoint = "F_Memory_Write", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Memory_Write(Int32 mode);

        //INT_X  MSPPRG_API	F_Memory_Verify( INT_X mode );
        [DllImport(SEL_DLL, EntryPoint = "F_Memory_Verify", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Memory_Verify(Int32 mode);

        //INT_X  MSPPRG_API	F_Memory_Read( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Memory_Read", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Memory_Read();

        //INT_X  MSPPRG_API	F_Lock_MCU( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Lock_MCU", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Lock_MCU();

        //INT_X  MSPPRG_API F_Clear_Locked_Device( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Clear_Locked_Device", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Clear_Locked_Device();

        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////SEQUENTIAL FUNCTIONS////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

        //INT_X  MSPPRG_API	F_Open_Target_Device( void )
        [DllImport(SEL_DLL, EntryPoint = "F_Open_Target_Device", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Open_Target_Device();

        //INT_X F_Close_Target_Device( void );
        [DllImport(SEL_DLL, EntryPoint = "F_Close_Target_Device", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Close_Target_Device();

        //INT_X F_Segment_Erase(INT_X address);
        [DllImport(SEL_DLL, EntryPoint = "F_Segment_Erase", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Segment_Erase(Int32 address);

        //INT_X F_Sectors_Blank_Check( INT_X start_addr, INT_X stop_addr );
        [DllImport(SEL_DLL, EntryPoint = "F_Sectors_Blank_Check", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Sectors_Blank_Check(Int32 start_addr, Int32 stop_addr);

        //INT_X F_Get_Sector_Size( INT_X address );
        [DllImport(SEL_DLL, EntryPoint = "F_Get_Sector_Size", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Get_Sector_Size(Int32 address);

        //INT_X  MSPPRG_API	F_Copy_Buffer_to_Flash( INT_X  start_addr, INT_X  size );
        [DllImport(SEL_DLL, EntryPoint = "F_Copy_Buffer_to_Flash", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Copy_Buffer_to_Flash(Int32 start_addr, Int32 size);

        //INT_X  MSPPRG_API	F_Copy_Flash_to_Buffer( INT_X  start_addr, INT_X  size );
        [DllImport(SEL_DLL, EntryPoint = "F_Copy_Flash_to_Buffer", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Copy_Flash_to_Buffer(Int32 start_addr, Int32 size);

        //INT_X F_Write_Byte_to_RAM( INT_X addr, BYTE data )
        [DllImport(SEL_DLL, EntryPoint = "F_Write_Byte_to_RAM", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Write_Byte_to_RAM(Int32 addr, byte data);

        //INT_X F_Write_Word16_to_RAM( INT_X addr, INT_X data )
        [DllImport(SEL_DLL, EntryPoint = "F_Write_Word16_to_RAM", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Write_Word16_to_RAM(Int32 addr, Int32 data);

        //INT_X F_Write_Word32_to_RAM( INT_X addr, INT_X data )
        [DllImport(SEL_DLL, EntryPoint = "F_Write_Word32_to_RAM", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Write_Word32_to_RAM(Int32 addr, Int32 data);
       

        //INT_X F_Read_Byte( INT_X addr )
        [DllImport(SEL_DLL, EntryPoint = "F_Read_Byte", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Read_Byte(Int32 addr);

        //INT_X F_Read_Word16( INT_X addr )
        [DllImport(SEL_DLL, EntryPoint = "F_Read_Word16", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Read_Word16(Int32 addr);

        //INT_X F_Read_Word32( INT_X addr )
        [DllImport(SEL_DLL, EntryPoint = "F_Read_Word32", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Read_Word32(Int32 addr);

        //INT_X F_Set_PC_and_RUN( INT_X PC_addr )
        [DllImport(SEL_DLL, EntryPoint = "F_Set_PC_and_RUN", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Set_PC_and_RUN(Int32 PC_addr);

        //INT_X F_Write_Locking_Registers( void )
        [DllImport(SEL_DLL, EntryPoint = "F_Write_Locking_Registers", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Write_Locking_Registers();

        //INT_X F_Write_Debug_Register( void )
        [DllImport(SEL_DLL, EntryPoint = "F_Write_Debug_Register", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Write_Debug_Register();

        //INT_X F_Get_MCU_Data( INT_X type )
        [DllImport(SEL_DLL, EntryPoint = "F_Get_MCU_Data", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 F_Get_MCU_Data(Int32 type);
    }
}
