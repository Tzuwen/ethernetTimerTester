using bpac;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;

namespace ethernetCUTester
{
   
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        // Label printer DLL
        [DllImport("bpac.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern object GetObject(string objName);
        [DllImport("bpac.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Open(string filePath);
        [DllImport("bpac.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool StartPrint(string docName, PrintOptionConstants option);
        [DllImport("bpac.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool PrintOut(int copyCount, PrintOptionConstants option);
        [DllImport("bpac.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool EndPrint();
        [DllImport("bpac.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Close();

        string basicInfo = "basicInfo.txt";
        string cuList = "cuList.txt";
        string lbxFileCUID = "macID.lbx";
        private int totalCount = 0;
        int[] MACSP = new int[6];
        public MainWindow()
        {           
            InitializeComponent();
            totalCount = Convert.ToInt16(getBasicInfo("currentQuantity"));
            tbMsg.AppendText("==================================\r\n");
            fpa_OpenInst();
            fpa_Initial();
            lbQuantity.Content = "數量 : " + totalCount;
            tbMsg.AppendText("==================================\r\n");
            tbMsg.AppendText("Flash Pro Ready");
        }
            
        
        private void btnProgram_Click(object sender, RoutedEventArgs e)
        {
            flashMCU();            
        }

        private int fpa_OpenInst()
        {
            int result;
            result = FLASHPROARM_API.F_OpenInstancesAndFPAs("*# *");
            System.Diagnostics.Debug.WriteLine("Open Instances And FPAs : " + result);           
            tbMsg.AppendText("Open Instances And FPAs : " + result + "\r\n");
            return result;
        }

        private int fpa_Initial()
        {
            int result;
            result = FLASHPROARM_API.F_Use_Config_INI(0);
            if (result == 1)
            {
                result = FLASHPROARM_API.F_Initialization();
                if (result == 1)
                {
                    var file = "CU_Rev_U500.hex";
                    var name = "stm32f107rc";                    
                    fpa_SetMCUName(name);
                    fpa_SetCode(file);
                    fpa_SetVCC(3000);
                    fpa_HardwareRestAndStart(4);
                }

            }
            System.Diagnostics.Debug.WriteLine("FPA Initial : " + result);            
            tbMsg.AppendText("FPA Initial : " + result + "\r\n");

            return result;
        }

        private int fpa_SetMCUName(string name)
        {
            int result;
            result = FLASHPROARM_API.F_Set_MCU_Name(name);
            System.Diagnostics.Debug.WriteLine("Set MCU Name : " + result);            
            tbMsg.AppendText("Set MCU Name : " + result + "\r\n");
            return result;
        }

        private int fpa_SetCode(string file)
        {
            int result;
            result = FLASHPROARM_API.F_ReadCodeFile(file);
            System.Diagnostics.Debug.WriteLine("Read Code : " + result);            
            tbMsg.AppendText("Read Code : " + result + "\r\n");
            return result;
        }

        private int fpa_SetVCC(uint vcc)
        {
            int result = 0, result1, result2 ;
            result1 = FLASHPROARM_API.F_Set_Config_Value_By_Name("PowerFromFpaEn", 1);
            System.Diagnostics.Debug.WriteLine("Set Power From FPA : " + result1);
            tbMsg.AppendText("Set Power From FPA : " + result1 + "\r\n");

            result2 = FLASHPROARM_API.F_Set_Config_Value_By_Name("VccFromFPAin_mV", vcc);
            System.Diagnostics.Debug.WriteLine("Set Vcc From FPA : " + result2);
            tbMsg.AppendText("Set Vcc From FPA : " + result2 + "\r\n");
            

            if (result1 == 1 && result2 == 1)
                result = 1;
            
            return result;
        }

        private int fpa_HardwareRestAndStart(int timeDelay)
        {
            int result = 0, result1, result2;
            result1 = FLASHPROARM_API.F_Set_Config_Value_By_Name("ApplicationStartEnable", 1);
            System.Diagnostics.Debug.WriteLine("Set Application Start Enable : " + result1);
            tbMsg.AppendText("Set Application Start Enable : " + result1 + "\r\n");

            result2 = FLASHPROARM_API.F_Set_Config_Value_By_Name("ApplProgramRunTime", (uint)timeDelay);
            System.Diagnostics.Debug.WriteLine("Set Application RunTime Result : " + result2);
            tbMsg.AppendText("Set Application RunTime Result : " + result2 + "\r\n");

            if (result1 == 1 && result2 == 1)
                result = 1;

            return result;
        }

        private int fpa_PowerTarget(int onoff)
        {
            int result;
            result = FLASHPROARM_API.F_Power_Target(onoff);           
            System.Diagnostics.Debug.WriteLine("Power Target : " + (onoff == 1 ? "On" : "Off"));         
            tbMsg.AppendText("Power Target : " + (onoff == 1 ? "On\r\n" : "Off\r\n"));
            return result;
        }

        private int fpa_AutoProgram()
        {
            int result;
            result = FLASHPROARM_API.F_AutoProgram(0);
            System.Diagnostics.Debug.WriteLine("Program : " + result);           
            tbMsg.AppendText("Program : " + result + "\r\n");
            return result;
        }

        private void flashMCU()
        {            
            var result = 0;
            tbMsg.Clear();
            tbMsg.AppendText("==================================\r\n");
            fpa_Initial();
            fpa_PowerTarget(1);
            result = fpa_AutoProgram();
            if (result == 1)
            {
                // get mac                
                FLASHPROARM_API.F_Open_Target_Device();
                MACSP[0] = FLASHPROARM_API.F_Read_Byte(0x0801B800);
                MACSP[1] = FLASHPROARM_API.F_Read_Byte(0x0801B801);
                MACSP[2] = FLASHPROARM_API.F_Read_Byte(0x0801B802);
                MACSP[3] = FLASHPROARM_API.F_Read_Byte(0x0801B803);
                MACSP[4] = FLASHPROARM_API.F_Read_Byte(0x0801B804);
                MACSP[5] = FLASHPROARM_API.F_Read_Byte(0x0801B805);
                FLASHPROARM_API.F_Close_Target_Device();
                // end of get mac            
                string MAC = int2hexMAC(MACSP[0]) + int2hexMAC(MACSP[1]) + int2hexMAC(MACSP[2]) + int2hexMAC(MACSP[3]) + int2hexMAC(MACSP[4]) + int2hexMAC(MACSP[5]);
                lbMAC.Content = "產品序號 : " + MAC;
            }

            //System.Threading.Thread.Sleep(1000);
            fpa_PowerTarget(0);
            tbMsg.AppendText("==================================\r\n");
            if (result == 1)
                tbMsg.AppendText("Production Code Done");           
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            
            var result = 0;
            tbMsg.Clear();
            string MAC = int2hexMAC(MACSP[0]) + int2hexMAC(MACSP[1]) + int2hexMAC(MACSP[2]) + int2hexMAC(MACSP[3]) + int2hexMAC(MACSP[4]) + int2hexMAC(MACSP[5]);
            lbQuantity.Content = "數量 : " + ++totalCount;
            lbMAC.Content = "產品序號 : " + MAC;
            PrintIDLB(MAC);
            writeCuList(MAC);
            writeBasicInfo("currentQuantity", totalCount);
            tbMsg.AppendText("Label Print Done");
        }

        private string int2hex(int data)// convert int to hex
        {
            string result = "";
            result = data.ToString("X4");
            return result;
        }
        private int hex2int(string data)// convert hex to int
        {
            int result = 0;
            result = int.Parse(data, System.Globalization.NumberStyles.HexNumber);
            return result;
        }
        private string int2hexMAC(int data)// convert int to hex
        {
            string result = "";
            result = data.ToString("X2");
            return result;
        }

        // Print labels
        private bool PrintIDLB(string text)// Print ID label
        {
            bool result = false;
            DocumentClass doc = new DocumentClass();
            if (doc.Open(lbxFileCUID) != false)
            {
                doc.GetObject("macID").Text = text;
                doc.StartPrint("", PrintOptionConstants.bpoDefault);
                doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
                result = true;
            }
            return result;
        }

        private void writeCuList(string value)// write to info.ini
        {
            File.AppendAllText(cuList, value + Environment.NewLine);
        }

        private string getBasicInfo(string data)// read from info.ini
        {
            string[] str;
            string result = "";
            foreach (string line in File.ReadLines(basicInfo))
            {
                if (line.Contains(data))
                {
                    str = line.Split('=');
                    result = str[1].ToString();
                }
            }
            return result;
        }

        private void writeBasicInfo(string data, int value)// write to info.ini
        {
            int linecount = 0;
            string[] str;
            string result = "";
            var seriallines = File.ReadAllLines(basicInfo);
            foreach (string line in seriallines)
            {
                if (line.Contains(data))
                {
                    str = line.Split('=');
                    result = str[0] + "=" + value;
                    seriallines[linecount] = result;
                }
                linecount += 1;
            }
            File.WriteAllLines(basicInfo, seriallines);
        }

        
    }    
}
