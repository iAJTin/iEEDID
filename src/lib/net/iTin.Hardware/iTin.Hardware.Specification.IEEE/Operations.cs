﻿
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Hardware.Specification.IEEE;

/// <summary>
/// Contains methods for retrieve the manufacturer
/// </summary>
public static class Operations
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly Dictionary<string, string> Oui = new Dictionary<string, string>
    {
        {"002272", "American Micro-Fuel Device Corp."},
        {"00D0EF", "IGT"},
        {"086195", "Rockwell Automation"},
        {"F4BD9E", "Cisco Systems, Inc"},
        {"5885E9", "Realme Chongqing MobileTelecommunications Corp Ltd"},
        {"BC2392", "BYD Precision Manufacture Company Ltd."},
        {"94E6F7", "Intel Corporate"},
        {"405582", "Nokia"},
        {"A4E31B", "Nokia"},
        {"D89790", "Commonwealth Scientific and Industrial Research Organisation"},
        {"883A30", "Aruba, a Hewlett Packard Enterprise Company"},
        {"B8A58D", "Axe Group Holdings Limited"},
        {"50CEE3", "Gigafirm.co.LTD"},
        {"98E743", "Dell Inc."},
        {"C419D1", "Telink Semiconductor (Shanghai) Co., Ltd."},
        {"4C1D96", "Intel Corporate"},
        {"887E25", "Extreme Networks, Inc."},
        {"086083", "zte corporation"},
        {"E01954", "zte corporation"},
        {"10327E", "Huawei Device Co., Ltd."},
        {"F8084F", "Sagemcom Broadband SAS"},
        {"30FBB8", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"F497C2", "Nebulon Inc"},
        {"A44519", "Xiaomi Communications Co Ltd"},
        {"68DBF5", "Amazon Technologies Inc."},
        {"2446C8", "Motorola Mobility LLC, a Lenovo Company"},
        {"1802AE", "vivo Mobile Communication Co., Ltd."},
        {"0C20D3", "vivo Mobile Communication Co., Ltd."},
        {"44D791", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"8446FE", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"D82918", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"D0D003", "Samsung Electronics Co., LTD"},
        {"64B21D", "Chengdu Phycom Tech Co., Ltd."},
        {"C42996", "Signify B.V."},
        {"980637", "IEEE Registration Authority"},
        {"8CB84A", "SAMSUNG ELECTRO-MECHANICS(THAILAND)"},
        {"98E8FA", "Nintendo Co., Ltd"},
        {"38C4E8", "NSS Sp.z o.o."},
        {"34DD7E", "Umeox Innovations Co., Ltd"},
        {"CCCD64", "SM-Electronic GmbH"},
        {"24DFA7", "Hangzhou BroadLink Technology Co., Ltd"},
        {"B065F1", "WIO Manufacturing HK Limited"},
        {"901234", "Shenzhen YOUHUA Technology Co., Ltd"},
        {"542A1B", "Sonos, Inc."},
        {"5C925E", "Zioncom Electronics (Shenzhen) Ltd."},
        {"084FA9", "Cisco Systems, Inc"},
        {"084FF9", "Cisco Systems, Inc"},
        {"5098B8", "New H3C Technologies Co., Ltd"},
        {"1100AA", "Private"},
        {"B84DEE", "Hisense broadband multimedia technology Co., Ltd"},
        {"A89352", "SHANGHAI ZHONGMI COMMUNICATION TECHNOLOGY CO., LTD"},
        {"E4CC9D", "Integrated Device Technology (Malaysia) Sdn. Bhd."},
        {"A8D0E3", "Systech Electronics Ltd"},
        {"98BA39", "Doro AB"},
        {"D46BA6", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"CC0577", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"308BB2", "Cisco Systems, Inc"},
        {"E0EB62", "Shanghai Hulu Devices Co., Ltd"},
        {"08688D", "New H3C Technologies Co., Ltd"},
        {"E86F38", "CHONGQING FUGUI ELECTRONICS CO., LTD."},
        {"48216C", "China Mobile IOT Company Limited"},
        {"8CBE24", "Tashang Semiconductor(Shanghai) Co., Ltd."},
        {"08B3AF", "vivo Mobile Communication Co., Ltd."},
        {"30862D", "Arista Network, Inc."},
        {"6CE8C6", "Earda Technologies co Ltd"},
        {"1C4176", "China Mobile Group Device Co., Ltd."},
        {"608B0E", "Apple, Inc."},
        {"1871D5", "Hazens Automotive Electronics(SZ) Co., Ltd."},
        {"ACB1EE", "SHENZHEN FENDA TECHNOLOGY CO., LTD"},
        {"F8ADCB", "HMD Global Oy"},
        {"D462EA", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"54BAD6", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"94DC4E", "AEV, spol.s r. o."},
        {"1442FC", "Texas Instruments"},
        {"AC5D5C", "FN-LINK TECHNOLOGY LIMITED"},
        {"A4AE11", "Hon Hai Precision Ind. Co., Ltd."},
        {"54DED0", "Sevio Srl"},
        {"6C5E3B", "Cisco Systems, Inc"},
        {"401920", "Movon Corporation"},
        {"D03745", "TP-LINK TECHNOLOGIES CO., LTD."},
        {"603A7C", "TP-LINK TECHNOLOGIES CO., LTD."},
        {"000178", "MARGI Systems, Inc."},
        {"0CB771", "ARRIS Group, Inc."},
        {"58C876", "China Mobile (Hangzhou) Information Technology Co., Ltd."},
        {"2C1E4F", "Chengdu Qianli Network Technology Co., Ltd."},
        {"009052", "SELCOM ELETTRONICA S.R.L."},
        {"001A83", "Pegasus Technologies Inc."},
        {"50E085", "Intel Corporate"},
        {"24166D", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"940B19", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"70C7F2", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"3894ED", "NETGEAR"},
        {"700433", "California Things Inc."},
        {"DCA632", "Raspberry Pi Trading Ltd"},
        {"88F56E", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"BC97E1", "Broadcom Limited"},
        {"28D1B7", "Shenzhen YOUHUA Technology Co., Ltd"},
        {"C8C2FA", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"88B362", "Nokia Shanghai Bell Co., Ltd."},
        {"0847D0", "Nokia Shanghai Bell Co., Ltd."},
        {"089C86", "Nokia Shanghai Bell Co., Ltd."},
        {"7C8956", "Samsung Electronics Co., Ltd"},
        {"9C93E4", "Private"},
        {"88299C", "Samsung Electronics Co., Ltd"},
        {"CC9093", "Hansong Tehnologies"},
        {"CC64A6", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"30317D", "Hosiden Corporation"},
        {"F0A968", "Antailiye Technology Co., Ltd"},
        {"48E1E9", "Chengdu Meross Technology Co., Ltd."},
        {"D81399", "Hui Zhou Gaoshengda Technology Co., LTD"},
        {"54E019", "Ring LLC"},
        {"148430", "MITAC COMPUTING TECHNOLOGY CORPORATION"},
        {"B8A44F", "Axis Communications AB"},
        {"0024EB", "ClearPath Networks, Inc."},
        {"50AF4D", "zte corporation"},
        {"C8EAF8", "zte corporation"},
        {"709F2D", "zte corporation"},
        {"383B26", "Jiangsu Qinheng Co., Ltd."},
        {"5CFAFB", "Acubit"},
        {"9C7BEF", "Hewlett Packard"},
        {"742EDB", "Perinet GmbH"},
        {"201742", "LG Electronics"},
        {"CC8826", "LG Innotek"},
        {"EC5B73", "Advanced & Wise Technology Corp."},
        {"E0CB1D", "Private"},
        {"848BCD", "IEEE Registration Authority"},
        {"14C03E", "ARRIS Group, Inc."},
        {"C089AB", "ARRIS Group, Inc."},
        {"D44DA4", "Murata Manufacturing Co., Ltd."},
        {"DC7196", "Intel Corporate"},
        {"F8E5CF", "CGI IT UK LIMITED"},
        {"6882F2", "grandcentrix GmbH"},
        {"D420B0", "Mist Systems, Inc."},
        {"08EDED", "Zhejiang Dahua Technology Co., Ltd."},
        {"6092F5", "ARRIS Group, Inc."},
        {"0022AF", "Safety Vision, LLC"},
        {"A091A2", "OnePlus Electronics (Shenzhen) Co., Ltd."},
        {"0080B5", "UNITED NETWORKS INC."},
        {"B808CF", "Intel Corporate"},
        {"1C697A", "EliteGroup Computer Systems Co., LTD"},
        {"4C1744", "Amazon Technologies Inc."},
        {"B03055", "China Mobile IOT Company Limited"},
        {"905C34", "Sirius Electronic Systems Srl"},
        {"D46A35", "Cisco Systems, Inc"},
        {"D09C7A", "Xiaomi Communications Co Ltd"},
        {"C82C2B", "IEEE Registration Authority"},
        {"8020DA", "Sagemcom Broadband SAS"},
        {"68847E", "FUJITSU LIMITED"},
        {"003085", "Cisco Systems, Inc"},
        {"605F8D", "eero inc."},
        {"C4B36A", "Cisco Systems, Inc"},
        {"70F754", "AMPAK Technology, Inc."},
        {"6C8BD3", "Cisco Systems, Inc"},
        {"68974B", "Shenzhen Costar Electronics Co.Ltd."},
        {"34E1D1", "IEEE Registration Authority"},
        {"0021B7", "LEXMARK INTERNATIONAL, INC."},
        {"00A0B0", "I-O DATA DEVICE, INC."},
        {"2479F3", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"80A235", "Edgecore Networks Corporation"},
        {"C8C64A", "Flextronics Tech.(Ind) Pvt Ltd"},
        {"30EA26", "Sycada BV"},
        {"9C497F", "Integrated Device Technology (Malaysia) Sdn. Bhd."},
        {"C4E39F", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"F89A78", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"88F872", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"EC5623", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"5486BC", "Cisco Systems, Inc"},
        {"402343", "CHONGQING FUGUI ELECTRONICS CO., LTD."},
        {"18F18E", "ChipER Technology co.ltd"},
        {"000422", "Studio Technologies, Inc"},
        {"80DA13", "eero inc."},
        {"50EC50", "Beijing Xiaomi Mobile Software Co., Ltd"},
        {"6061DF", "Z-meta Research LLC"},
        {"7057BF", "New H3C Technologies Co., Ltd"},
        {"8CE748", "Private"},
        {"108286", "Luxshare Precision Industry Co., Ltd"},
        {"14B457", "Silicon Laboratories"},
        {"DC962C", "NST Audio Ltd"},
        {"18022D", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"D8BC59", "Shenzhen DAPU Microelectronics Co., Ltd"},
        {"089798", "COMPAL INFORMATION (KUNSHAN) CO., LTD."},
        {"246F28", "Espressif Inc."},
        {"8C79F5", "Samsung Electronics Co., Ltd"},
        {"48F8DB", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"00122A", "VTech Telecommunications Ltd."},
        {"B0518E", "Holl technology CO.Ltd."},
        {"681729", "Intel Corporate"},
        {"2852E0", "Layon international Electronic & Telecom Co., Ltd"},
        {"58CB52", "Google, Inc."},
        {"7C6166", "Amazon Technologies Inc."},
        {"989BCB", "AVM Audiovisuelles Marketing und Computersysteme GmbH"},
        {"94F7AD", "Juniper Networks"},
        {"6063F9", "Ciholas, Inc."},
        {"AC8FF8", "Nokia"},
        {"6003A6", "Inteno Broadband Technology AB"},
        {"7C5259", "Sichuan Jiuzhou Electronic Technology Co., Ltd."},
        {"44B295", "Sichuan AI-Link Technology Co., Ltd."},
        {"9424E1", "Alcatel-Lucent Enterprise"},
        {"F8CA59", "NetComm Wireless"},
        {"88B291", "Apple, Inc."},
        {"C42AD0", "Apple, Inc."},
        {"CCD281", "Apple, Inc."},
        {"200DB0", "Shenzhen Four Seas Global Link Network Technology Co., Ltd."},
        {"D81EDD", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"D43FCB", "ARRIS Group, Inc."},
        {"5C7695", "Technicolor CH USA Inc."},
        {"F84D33", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"C08ACD", "Guangzhou Shiyuan Electronic Technology Company Limited"},
        {"ACF6F7", "LG Electronics (Mobile Communications)"},
        {"E89E0C", "Private"},
        {"48E6C0", "SIMCom Wireless Solutions Co., Ltd."},
        {"383C9C", "Fujian Newland Payment Technology Co., Ltd."},
        {"C02E25", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"107717", "SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD"},
        {"A86D5F", "Raisecom Technology CO., LTD"},
        {"58ECED", "Integrated Device Technology (Malaysia) Sdn. Bhd."},
        {"A468BC", "Private"},
        {"005079", "Private"},
        {"100C6B", "NETGEAR"},
        {"505FB5", "Askey Computer Corp."},
        {"C4F0EC", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"E80FC8", "Universal Electronics, Inc."},
        {"E45D37", "Juniper Networks"},
        {"00EEAB", "Cisco Systems, Inc"},
        {"54A703", "TP-LINK TECHNOLOGIES CO., LTD."},
        {"907A58", "Zegna-Daidong Limited"},
        {"E009BF", "SHENZHEN TONG BO WEI TECHNOLOGY Co., LTD"},
        {"00131E", "peiker acustic GmbH"},
        {"846991", "Nokia"},
        {"001BF7", "Lund IP Products AB"},
        {"783607", "Cermate Technologies Inc."},
        {"B00073", "Wistron Neweb Corporation"},
        {"D88DC8", "Atil Technology Co., LTD"},
        {"D0ABD5", "Intel Corporate"},
        {"88DE7C", "Askey Computer Corp."},
        {"A8E2C1", "Texas Instruments"},
        {"909A77", "Texas Instruments"},
        {"04EE03", "Texas Instruments"},
        {"4C2498", "Texas Instruments"},
        {"7CD95C", "Google, Inc."},
        {"C8AACC", "Private"},
        {"002167", "HWA JIN T&I Corp."},
        {"000B86", "Aruba, a Hewlett Packard Enterprise Company"},
        {"DC31D1", "vivo Mobile Communication Co., Ltd."},
        {"C8F750", "Dell Inc."},
        {"D49234", "NEC Corporation"},
        {"0007CB", "FREEBOX SAS"},
        {"149FB6", "GUANGDONG GENIUS TECHNOLOGY CO., LTD."},
        {"00115A", "Ivoclar Vivadent AG"},
        {"4CAEA3", "Hewlett Packard Enterprise"},
        {"1C2E1B", "Suzhou Tremenet Communication Technology Co., Ltd."},
        {"1C24EB", "Burlywood"},
        {"001013", "Kontron America, Inc."},
        {"2C2BF9", "LG Innotek"},
        {"D8C7C8", "Aruba, a Hewlett Packard Enterprise Company"},
        {"703A0E", "Aruba, a Hewlett Packard Enterprise Company"},
        {"204C03", "Aruba, a Hewlett Packard Enterprise Company"},
        {"58C6F0", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"84A06E", "Sagemcom Broadband SAS"},
        {"A43EA0", "iComm HK LIMITED"},
        {"64C2DE", "LG Electronics (Mobile Communications)"},
        {"8C444F", "HUMAX Co., Ltd."},
        {"006762", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"2CC407", "machineQ"},
        {"B4ED19", "Pie Digital, Inc."},
        {"40DF02", "LINE BIZ Plus"},
        {"D43B04", "Intel Corporate"},
        {"CCE194", "Juniper Networks"},
        {"900218", "BSkyB Ltd"},
        {"144E2A", "Ciena Corporation"},
        {"84139F", "zte corporation"},
        {"F051EA", "Fitbit, Inc."},
        {"5033F0", "YICHEN (SHENZHEN) TECHNOLOGY CO.LTD"},
        {"FC2BB2", "Actiontec Electronics, Inc"},
        {"E09F2A", "Iton Technology Corp."},
        {"4CE19E", "TECNO MOBILE LIMITED"},
        {"7495EC", "ALPS ELECTRIC CO., LTD."},
        {"AC5AEE", "China Mobile Group Device Co., Ltd."},
        {"70BC10", "Microsoft Corporation"},
        {"884A18", "Opulinks"},
        {"0006F7", "ALPS ELECTRIC CO., LTD."},
        {"000704", "ALPS ELECTRIC CO., LTD."},
        {"0006F5", "ALPS ELECTRIC CO., LTD."},
        {"34C731", "ALPS ELECTRIC CO., LTD."},
        {"9C69B4", "IEEE Registration Authority"},
        {"500084", "Siemens Canada"},
        {"64D4BD", "ALPS ELECTRIC CO., LTD."},
        {"0498F3", "ALPS ELECTRIC CO., LTD."},
        {"00214F", "ALPS ELECTRIC CO., LTD."},
        {"44B433", "tide.co., ltd"},
        {"D8A6FD", "Ghost Locomotion"},
        {"DC21B9", "Sentec Co.Ltd"},
        {"6CDFFB", "IEEE Registration Authority"},
        {"247D4D", "Texas Instruments"},
        {"8850F6", "Shenzhen Jingxun Software Telecommunication Technology Co., Ltd"},
        {"E498BB", "Phyplus Microelectronics Limited"},
        {"60A11E", "Wuhan Maxsine Electric Co., Ltd."},
        {"C45BF7", "ants"},
        {"8CDF9D", "NEC Corporation"},
        {"5C415A", "Amazon.com, LLC"},
        {"705E55", "Realme Chongqing MobileTelecommunications Corp Ltd"},
        {"B0D568", "Shenzhen Cultraview Digital Technology Co., Ltd"},
        {"F00EBF", "ZettaHash Inc."},
        {"703509", "Cisco Systems, Inc"},
        {"04EA56", "Intel Corporate"},
        {"D0C637", "Intel Corporate"},
        {"441AFA", "New H3C Technologies Co., Ltd"},
        {"04072E", "VTech Electronics Ltd."},
        {"780ED1", "TRUMPF Werkzeugmaschinen GmbH+Co.KG"},
        {"44ECCE", "Juniper Networks"},
        {"F82F08", "Molex CMS"},
        {"441C12", "Technicolor CH USA Inc."},
        {"4428A3", "Jiangsu fulian Communication Technology Co., Ltd."},
        {"10C595", "Lenovo"},
        {"203233", "SHENZHEN BILIAN ELECTRONIC CO.，LTD"},
        {"6829DC", "Ficosa Electronics S.L.U."},
        {"9454DF", "YST CORP."},
        {"7CBC84", "IEEE Registration Authority"},
        {"F80DF1", "Sontex SA"},
        {"A49426", "Elgama-Elektronika Ltd."},
        {"E4F14C", "Private"},
        {"A8B456", "Cisco Systems, Inc"},
        {"2CA9F0", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"549B72", "Ericsson AB"},
        {"A047D7", "Best IT World (India) Pvt Ltd"},
        {"6899CD", "Cisco Systems, Inc"},
        {"1040F3", "Apple, Inc."},
        {"586B14", "Apple, Inc."},
        {"BCB863", "Apple, Inc."},
        {"2C1CF6", "Alien Green LLC"},
        {"6C2B59", "Dell Inc."},
        {"44E66E", "Apple, Inc."},
        {"C0E862", "Apple, Inc."},
        {"F40616", "Apple, Inc."},
        {"0CFE5D", "IEEE Registration Authority"},
        {"3C8D20", "Google, Inc."},
        {"601D91", "Motorola Mobility LLC, a Lenovo Company"},
        {"D4C94B", "Motorola Mobility LLC, a Lenovo Company"},
        {"08351B", "Shenzhen Jialihua Electronic Technology Co., Ltd"},
        {"AC1585", "silergy corp"},
        {"AC5093", "Magna Electronics Europe GmbH & Co.OHG"},
        {"70BBE9", "Xiaomi Communications Co Ltd"},
        {"50A0A4", "Nokia"},
        {"00D02D", "Resideo"},
        {"806940", "LEXAR CO., LIMITED"},
        {"64F81C", "Huawei Technologies Co., Ltd."},
        {"1098C3", "Murata Manufacturing Co., Ltd."},
        {"9CC8FC", "ARRIS Group, Inc."},
        {"B07E11", "Texas Instruments"},
        {"10C753", "Qingdao Intelligent&Precise Electronics Co., Ltd."},
        {"F4951B", "Hefei Radio Communication Technology Co., Ltd"},
        {"6C3845", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"2C6104", "SHENZHEN FENGLIAN TECHNOLOGY CO., LTD."},
        {"BC9325", "Ningbo Joyson Preh Car Connect Co., Ltd."},
        {"D0B60A", "Xingluo Technology Company Limited"},
        {"049226", "ASUSTek COMPUTER INC."},
        {"E8ADA6", "Sagemcom Broadband SAS"},
        {"0C1C19", "LONGCONN ELECTRONICS(SHENZHEN) CO., LTD"},
        {"90E710", "New H3C Technologies Co., Ltd"},
        {"302952", "Hillstone Networks Inc"},
        {"E013B5", "vivo Mobile Communication Co., Ltd."},
        {"E0795E", "Wuxi Xiaohu Technology Co., Ltd."},
        {"00B1E3", "Cisco Systems, Inc"},
        {"A41194", "Lenovo"},
        {"00CB00", "Private"},
        {"DCF401", "Dell Inc."},
        {"0C4101", "Ruichi Auto Technology (Guangzhou) Co., Ltd."},
        {"00B771", "Cisco Systems, Inc"},
        {"E4B2FB", "Apple, Inc."},
        {"2CCA0C", "WITHUS PLANET"},
        {"84326F", "GUANGZHOU AVA ELECTRONICS TECHNOLOGY CO., LTD"},
        {"C89C13", "Inspiremobile"},
        {"8C85E6", "Cleondris GmbH"},
        {"807D14", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"20283E", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"A4FC77", "Mega Well Limited"},
        {"4C569D", "Apple, Inc."},
        {"38539C", "Apple, Inc."},
        {"402619", "Apple, Inc."},
        {"6CE85C", "Apple, Inc."},
        {"049162", "Microchip Technology Inc."},
        {"F83880", "Apple, Inc."},
        {"2C79D7", "Sagemcom Broadband SAS"},
        {"00B4F5", "DongGuan Siyoto Electronics Co., Ltd"},
        {"BC3F4E", "Teleepoch Ltd"},
        {"1838AE", "CONSPIN SOLUTION"},
        {"04CF8C", "XIAOMI Electronics, CO., LTD"},
        {"0C7512", "Shenzhen Kunlun TongTai Technology Co., Ltd."},
        {"7483C2", " Ubiquiti Networks Inc."},
        {"E063DA", "Ubiquiti Networks Inc."},
        {"50579C", "Seiko Epson Corporation"},
        {"983B8F", "Intel Corporate"},
        {"54278D", "NXP (China) Management Ltd."},
        {"B0BE76", "TP-LINK TECHNOLOGIES CO., LTD."},
        {"4447CC", "Hangzhou Hikvision Digital Technology Co., Ltd."},
        {"4CD98F", "Dell Inc."},
        {"B0AE25", "Varikorea"},
        {"4C1B86", "Arcadyan Corporation"},
        {"ECC40D", "Nintendo Co., Ltd"},
        {"440049", "Amazon Technologies Inc."},
        {"E86A64", "LCFC(HeFei) Electronics Technology co., ltd"},
        {"10A24E", "GOLD3LINK ELECTRONICS CO., LTD"},
        {"CCC5E5", "Dell Inc."},
        {"6CC374", "Texas Instruments"},
        {"684749", "Texas Instruments"},
        {"F8D9B8", "Open Mesh, Inc."},
        {"7C696B", "Atmosic Technologies"},
        {"5CD20B", "Yytek Co., Ltd."},
        {"70037E", "Technicolor CH USA Inc."},
        {"D003DF", "Samsung Electronics Co., Ltd"},
        {"C423A2", "PT.Emsonic Indonesia"},
        {"B4CB57", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"4C1265", "ARRIS Group, Inc."},
        {"00500C", "e-Tek Labs, Inc."},
        {"485F99", "Cloud Network Technology (Samoa) Limited"},
        {"8834FE", "Bosch Automotive Products (Suzhou) Co. Ltd"},
        {"88F7BF", "vivo Mobile Communication Co., Ltd."},
        {"D87D7F", "Sagemcom Broadband SAS"},
        {"00051A", "3COM EUROPE LTD"},
        {"08004E", "3COM EUROPE LTD"},
        {"00301E", "3COM EUROPE LTD"},
        {"005004", "3COM"},
        {"000103", "3COM"},
        {"58B568", "SECURITAS DIRECT ESPAÑA, SAU"},
        {"484AE9", "Hewlett Packard Enterprise"},
        {"846A66", "Sumitomo Kizai Co., Ltd."},
        {"18D717", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"80B624", "IVS"},
        {"DCF505", "AzureWave Technology Inc."},
        {"CCF0FD", "China Mobile (Hangzhou) Information Technology Co., Ltd."},
        {"8489EC", "IEEE Registration Authority"},
        {"88108F", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"F4631F", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"A49B4F", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"00073A", "INVENTEL"},
        {"00266C", "INVENTEC CORPORATION"},
        {"008CFA", "INVENTEC CORPORATION"},
        {"5CFB7C", "Shenzhen Jingxun Software Telecommunication Technology Co., Ltd"},
        {"FC039F", "Samsung Electronics Co., Ltd"},
        {"02C08C", "3COM"},
        {"0057C1", "LG Electronics (Mobile Communications)"},
        {"7C240C", "Telechips, Inc."},
        {"00203D", "Honeywell Environmental & Combustion Controls"},
        {"004084", "Honeywell International HPS"},
        {"1C1BB5", "Intel Corporate"},
        {"A4D990", "Samsung Electronics Co., Ltd"},
        {"006087", "KANSAI ELECTRIC CO., LTD."},
        {"DCF719", "Cisco Systems, Inc"},
        {"A0950C", "China Mobile IOT Company Limited"},
        {"D4741B", "Beijing HuaDa ZhiBao Electronic System Co., Ltd."},
        {"001BC0", "Juniper Networks"},
        {"2C15E1", "Phicomm (Shanghai) Co., Ltd."},
        {"30D16B", "Liteon Technology Corporation"},
        {"98AE71", "VVDN Technologies Pvt Ltd"},
        {"A456CC", "Technicolor CH USA Inc."},
        {"AC6E1A", "SHENZHEN GONGJIN ELECTRONICS CO., LT"},
        {"0080EB", "COMPCONTROL B.V."},
        {"0002EB", "Pico Communications"},
        {"342EB6", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"AC9232", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"000FB0", "Compal Electronics INC."},
        {"00023F", "Compal Electronics INC."},
        {"68A8E1", "Wacom Co., Ltd."},
        {"30D32D", "devolo AG"},
        {"BCF2AF", "devolo AG"},
        {"E0AF4F", "Deutsche Telekom AG"},
        {"DC8B28", "Intel Corporate"},
        {"B869F4", "Routerboard.com"},
        {"283A4D", "Cloud Network Technology (Samoa) Limited"},
        {"B87C6F", "NXP (China) Management Ltd."},
        {"305DA6", "ADVALY SYSTEM Inc."},
        {"BC30D9", "Arcadyan Corporation"},
        {"0479B7", "Texas Instruments"},
        {"C0D0FF", "China Mobile IOT Company Limited"},
        {"88DF9E", "New H3C Technologies Co., Ltd"},
        {"2C7CE4", "Wuhan Tianyu Information Industry Co., Ltd."},
        {"5803FB", "Hangzhou Hikvision Digital Technology Co., Ltd."},
        {"144802", "THE YEOLRIM Co., Ltd."},
        {"FC4AE9", "Castlenet Technology Inc."},
        {"40313C", "XIAOMI Electronics, CO., LTD"},
        {"FC4596", "COMPAL INFORMATION (KUNSHAN) CO., LTD."},
        {"A0E534", "Stratec Biomedical AG"},
        {"444B5D", "GE Healthcare"},
        {"001555", "DFM GmbH"},
        {"1C7508", "COMPAL INFORMATION (KUNSHAN) CO., LTD."},
        {"001B38", "COMPAL INFORMATION (KUNSHAN) CO., LTD."},
        {"00235A", "COMPAL INFORMATION (KUNSHAN) CO., LTD."},
        {"24D76B", "Syntronic AB"},
        {"C4FEE2", "AMICCOM Electronics Corporation"},
        {"780CF0", "Cisco Systems, Inc"},
        {"0C8C24", "SHENZHEN BILIAN ELECTRONIC CO.，LTD"},
        {"8C6D77", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"E8C57A", "Ufispace Co., LTD."},
        {"E01283", "Shenzhen Fanzhuo Communication Technology Co., Lt"},
        {"A0CF5B", "Cisco Systems, Inc"},
        {"002421", "MICRO-STAR INT'L CO., LTD."},
        {"0060D1", "CASCADE COMMUNICATIONS"},
        {"84C9C6", "SHENZHEN GONGJIN ELECTRONICS CO., LT"},
        {"88B66B", "easynetworks"},
        {"24F57E", "HWH CO., LTD."},
        {"8CA048", "Beijing NeTopChip Technology Co., LTD"},
        {"24D3F2", "zte corporation"},
        {"D469A5", "Miura Systems Ltd."},
        {"8C8126", "ARCOM"},
        {"D47C44", "IEEE Registration Authority"},
        {"805E4F", "FN-LINK TECHNOLOGY LIMITED"},
        {"8417EF", "Technicolor CH USA Inc."},
        {"3856B5", "Peerbridge Health Inc"},
        {"7C96D2", "Fihonest communication co., Ltd"},
        {"302432", "Intel Corporate"},
        {"C042D0", "Juniper Networks"},
        {"D0C5D8", "LATECOERE"},
        {"7054B4", "Vestel Elektronik San ve Tic. A.Ş."},
        {"20A60C", "Xiaomi Communications Co Ltd"},
        {"488AD2", "MERCURY COMMUNICATION TECHNOLOGIES CO., LTD."},
        {"DCE838", "CK Telecom (Shenzhen) Limited"},
        {"A8D498", "Avira Operations GmbH & Co.KG"},
        {"505967", "Intent Solutions Inc"},
        {"000680", "Card Access, Inc."},
        {"3C576C", "Samsung Electronics Co., Ltd"},
        {"841766", "WEIFANG GOERTEK ELECTRONICS CO., LTD"},
        {"2C4D79", "WEIFANG GOERTEK ELECTRONICS CO., LTD"},
        {"000C42", "Routerboard.com"},
        {"0026BD", "JTEC Card &amp; Communication Co., Ltd"},
        {"60D02C", "Ruckus Wireless"},
        {"D058FC", "BSkyB Ltd"},
        {"14579F", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"B44326", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"04AB18", "ELECOM CO., LTD."},
        {"78D294", "NETGEAR"},
        {"709FA9", "TECNO MOBILE LIMITED"},
        {"0C01DB", "Infinix mobility limited"},
        {"08C5E1", "SAMSUNG ELECTRO-MECHANICS(THAILAND)"},
        {"1866C7", "Shenzhen Libre Technology Co., Ltd"},
        {"5CB3F6", "Human, Incorporated"},
        {"2C4835", "IEEE Registration Authority"},
        {"482AE3", "Wistron InfoComm(Kunshan) Co., Ltd."},
        {"FCA6CD", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"44C874", "China Mobile Group Device Co., Ltd."},
        {"74C14F", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"B0EB57", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"1869DA", "China Mobile Group Device Co., Ltd."},
        {"F85C4D", "Nokia"},
        {"2C584F", "ARRIS Group, Inc."},
        {"F04B3A", "Juniper Networks"},
        {"54BF64", "Dell Inc."},
        {"A85B6C", "Robert Bosch Gmbh, CM-CI2"},
        {"C8B1EE", "Qorvo"},
        {"00FCBA", "Cisco Systems, Inc"},
        {"00CBB4", "SHENZHEN ATEKO PHOTOELECTRICITY CO., LTD"},
        {"4CC00A", "vivo Mobile Communication Co., Ltd."},
        {"9CE82B", "vivo Mobile Communication Co., Ltd."},
        {"7079B3", "Cisco Systems, Inc"},
        {"D818D3", "Juniper Networks"},
        {"149B2F", "JiangSu ZhongXie Intelligent Technology co., LTD"},
        {"3835FB", "Sagemcom Broadband SAS"},
        {"48DD9D", "ITEL MOBILE LIMITED"},
        {"A075EA", "BoxLock, Inc."},
        {"F04CD5", "Maxlinear, Inc"},
        {"0001AE", "Trex Enterprises"},
        {"00E009", "Stratus Technologies"},
        {"E4EA83", "SHENZHEN GONGJIN ELECTRONICS CO., LT"},
        {"74EC42", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"D4FC13", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"807D3A", "Espressif Inc."},
        {"ECAF97", "GIT"},
        {"A0B045", "Halong Mining"},
        {"E0BAB4", "Arrcus, Inc"},
        {"589B0B", "Shineway Technologies, Inc."},
        {"D8160A", "Nippon Electro-Sensory Devices"},
        {"10C07C", "Blu-ray Disc Association"},
        {"40A677", "Juniper Networks"},
        {"E4B021", "Samsung Electronics Co., Ltd"},
        {"9C7F57", "UNIC Memory Technology Co Ltd"},
        {"B4E01D", "CONCEPTION ELECTRONIQUE"},
        {"1C0042", "NARI Technology Co., Ltd."},
        {"4434A7", "ARRIS Group, Inc."},
        {"3CE1A1", "Universal Global Scientific Industrial Co., Ltd."},
        {"F898EF", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"58F987", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"A8F5AC", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"58BAD4", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"701D08", "99IOT Shenzhen co., ltd"},
        {"7412BB", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"001027", "L-3 COMMUNICATIONS EAST"},
        {"BC2643", "Elprotronic Inc."},
        {"04E229", "Qingdao Haier Technology Co., Ltd"},
        {"348B75", "LAVA INTERNATIONAL(H.K) LIMITED"},
        {"9CE895", "New H3C Technologies Co., Ltd"},
        {"00583F", "PC Aquarius"},
        {"903D68", "G-Printec, Inc."},
        {"1094BB", "Apple, Inc."},
        {"781D4A", "zte corporation"},
        {"94E1AC", "Hangzhou Hikvision Digital Technology Co., Ltd."},
        {"34E894", "TP-LINK TECHNOLOGIES CO., LTD."},
        {"F86FC1", "Apple, Inc."},
        {"28FF3C", "Apple, Inc."},
        {"F099B6", "Apple, Inc."},
        {"88E9FE", "Apple, Inc."},
        {"38892C", "Apple, Inc."},
        {"749EAF", "Apple, Inc."},
        {"94BF2D", "Apple, Inc."},
        {"68CAE4", "Cisco Systems, Inc"},
        {"00BE3B", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"7CA177", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"242E02", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"78B6EC", "Scuf Gaming International LLC"},
        {"8035C1", "Xiaomi Communications Co Ltd"},
        {"58B3FC", "SHENZHEN RF-LINK TECHNOLOGY CO., LTD."},
        {"2047DA", "Xiaomi Communications Co Ltd"},
        {"2429FE", "KYOCERA Corporation"},
        {"7C49EB", "XIAOMI Electronics, CO., LTD"},
        {"C43306", "China Mobile Group Device Co., Ltd."},
        {"08DFCB", "Systrome Networks"},
        {"A4933F", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"28AC9E", "Cisco Systems, Inc"},
        {"2CB8ED", "SonicWall"},
        {"68D482", "SHENZHEN GONGJIN ELECTRONICS CO., LT"},
        {"984562", "Shanghai Baud Data Communication Co., Ltd."},
        {"E4C483", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"001FBA", "Boyoung Tech"},
        {"A433D7", "MitraStar Technology Corp."},
        {"B0ACD2", "zte corporation"},
        {"200F70", "FOXTECH"},
        {"202D23", "Collinear Networks Inc."},
        {"90834B", "BEIJING YUNYI TIMES TECHNOLOGY CO,.LTD"},
        {"18502A", "SOARNEX"},
        {"A8367A", "frogblue TECHNOLOGY GmbH"},
        {"6CE4DA", "NEC Platforms, Ltd."},
        {"10E7C6", "Hewlett Packard"},
        {"1831BF", "ASUSTek COMPUTER INC."},
        {"C8FAE1", "ARQ Digital LLC"},
        {"DCA333", "Shenzhen YOUHUA Technology Co., Ltd"},
        {"788C54", "Ping Communication"},
        {"B8AF67", "Hewlett Packard"},
        {"C098DA", "China Mobile IOT Company Limited"},
        {"F00FEC", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"AC075F", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"C048E6", "Samsung Electronics Co., Ltd"},
        {"882E5A", "storONE"},
        {"007147", "Amazon Technologies Inc."},
        {"00BE75", "Cisco Systems, Inc"},
        {"64DB8B", "Hangzhou Hikvision Digital Technology Co., Ltd."},
        {"78257A", "LEO Innovation Lab"},
        {"10A4B9", "Baidu Online Network Technology (Beijing) Co., Ltd"},
        {"501CB0", "Cisco Systems, Inc"},
        {"04AC44", "Holtek Semiconductor Inc."},
        {"F4DCA5", "DAWON DNS"},
        {"0C5415", "Intel Corporate"},
        {"80CE62", "Hewlett Packard"},
        {"801F12", "Microchip Technology Inc."},
        {"506CBE", "InnosiliconTechnology Ltd"},
        {"247E12", "Cisco Systems, Inc"},
        {"04C241", "Nokia"},
        {"3C479B", "Theissen Training Systems, Inc."},
        {"606BFF", "Nintendo Co., Ltd"},
        {"8CF710", "AMPAK Technology, Inc."},
        {"307BAC", "New H3C Technologies Co., Ltd"},
        {"785DC8", "LG Electronics"},
        {"3C0461", "ARRIS Group, Inc." },
        {"883D24", "Google, Inc." },
        {"E8C1B8", "Nanjing Bangzhong Electronic Commerce Limited" },
        {"D8D775", "Sagemcom Broadband SAS" },
        {"E8330D", "Xaptec GmbH" },
        {"D460E3", "Sercomm Corporation." },
        {"B4A8B9", "Cisco Systems, Inc" },
        {"50DCE7", "Amazon Technologies Inc." },
        {"649829", "Integrated Device Technology (Malaysia) Sdn. Bhd." },
        {"081DC4", "Thermo Fisher Scientific Messtechnik GmbH" },
        {"785364", "SHIFT GmbH" },
        {"38E60A", "Xiaomi Communications Co Ltd" },
        {"40CBC0", "Apple, Inc."},
        {"C4618B", "Apple, Inc."},
        {"CC6EA4", "Samsung Electronics Co., Ltd" },
        {"5C5F67", "Intel Corporate" },
        {"803A59", "AT&T" },
        {"588D64", "Xi'an Clevbee Technology Co.,Ltd" },
        {"005D73", "Cisco Systems, Inc" },
        {"606D3C", "Luxshare Precision Industry Company Limited" },
        {"44F034", "Kaonmedia CO., LTD." },
        {"002790", "Cisco Systems, Inc" },
        {"0010FA", "Apple, Inc."},
        {"BC0963", "Apple, Inc."},
        {"D84C90", "Apple, Inc."},
        {"24D0DF", "Apple, Inc."},
        {"6C4A85", "Apple, Inc."},
        {"28F033", "Apple, Inc."},
        {"B8D4E7", "Aruba, a Hewlett Packard Enterprise"},
        {"78AC44", "Dell Inc."},
        {"98C8B8", "vivo Mobile Communications Co., Ltd."},
        {"209EF7", "Extreme Networks, Inc."},
        {"34BA38", "PAL MOHAN ELECTRONICS PVT LTD"},
        {"9829A6", "COMPAL INFORMATION (KUNSHAN) CO., LTD."},
        {"CC4D38", "Carnegie Technologies"},
        {"08E689", "Apple, Inc."},
        {"DC56E7", "Apple, Inc."},
        {"A816D0", "Samsung Electronics Co., Ltd"},
        {"A46CF1", "Samsung Electronics Co., Ltd"},
        {"08AED6", "Samsung Electronics Co., Ltd"},
        {"DCBFE9", "Motorola Mobility LLC, a Lenovo Company"},
        {"B42D56", "Extreme Networks, Inc."},
        {"4064A4", "THE FURUKAWA ELECTRIC CO., LTD"},
        {"6CB2AE", "Cisco Systems, Inc"},
        {"B0982B", "Sagemcom Broadband SAS"},
        {"34FA9F", "Ruckus Wireless"},
        {"F065C2", "Yanfeng Visteon Electronics Technology (Shanghai) Co., Ltd."},
        {"70B7E2", "Jiangsu Miter Technology Co., Ltd."},
        {"808DB7", "Hewlett Packard Enterprise"},
        {"A09D86", "Alcatel-Lucent Shanghai Bell Co., Ltd"},
        {"00C0FF", "Seagate Cloud Systems Inc"},
        {"D45DDF", "PEGATRON CORPORATION"},
        {"F8B568", "IEEE Registration Authority"},
        {"2C6B7D", "Texas Instruments"},
        {"88D171", "BEGHELLI S.P.A"},
        {"A09DC1", "China Dragon Technology Limited"},
        {"2C4205", "Lytx"},
        {"A825EB", "Cambridge Industries(Group) Co., Ltd."},
        {"34E380", "Genexis B.V."},
        {"5C5819", "Jingsheng Technology Co., Ltd."},
        {"B8CA04", "Holtek Semiconductor Inc."},
        {"C4C563", "TECNO MOBILE LIMITED"},
        {"80B708", "Blue Danube Systems, Inc"},
        {"08BC20", "Hangzhou Royal Cloud Technology Co., Ltd"},
        {"942A3F", "Diversey Inc"},
        {"2031EB", "HDSN"},
        {"F8C96C", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"844823", "WOXTER TECHNOLOGY Co.Ltd"},
        {"F41E5E", "RtBrick Inc."},
        {"6C7660", "KYOCERA CORPORATION"},
        {"002102", "UpdateLogic Inc."},
        {"505800", "WyTec International, Inc."},
        {"C8D12A", "Comtrend Corporation"},
        {"0CEAC9", "ARRIS Group, Inc."},
        {"E82A44", "Liteon Technology Corporation"},
        {"10A4BE", "SHENZHEN BILIAN ELECTRONIC CO.，LTD"},
        {"947BBE", "Ubicquia"},
        {"ECC06A", "PowerChord Group Limited"},
        {"944996", "WiSilica Inc"},
        {"F81D0F", "Hitron Technologies.Inc" },
        {"58C935", "Chiun Mai Communication Systems, Inc"},
        {"0094A1", "F5 Networks, Inc."},
        {"BCF292", "PLANTRONICS, INC."},
        {"0450DA", "Qiku Internet Network Scientific (Shenzhen) Co., Ltd"},
        {"E820E2", "HUMAX Co., Ltd."},
        {"0026A8", "DAEHAP HYPER-TECH"},
        {"785C28", "Prime Motion Inc."},
        {"F4EAB5", "Aerohive Networks Inc."},
        {"8C5BF0", "ARRIS Group, Inc."},
        {"1890D8", "Sagemcom Broadband SAS"},
        {"88835D", "FN-LINK TECHNOLOGY LIMITED"},
        {"EC9F0D", "IEEE Registration Authority"},
        {"E078A3", "Shanghai Winner Information Technology Co., Inc"},
        {"0005A7", "HYPERCHIP Inc."},
        {"088466", "Novartis Pharma AG"},
        {"309FFB", "Ardomus Networks Corporation"},
        {"282373", "Digita"},
        {"649A08", "Shenzhen SuperElectron Technology Co., LTD"},
        {"68A682", "Shenzhen YOUHUA Technology Co., Ltd"},
        {"587A62", "Texas Instruments"},
        {"547A52", "CTE International srl"},
        {"F06E0B", "Microsoft Corporation"},
        {"346FED", "Enovation Controls"},
        {"5433CB", "Apple, Inc."},
        {"3408BC", "Apple, Inc."},
        {"1C36BB", "Apple, Inc."},
        {"3C2EFF", "Apple, Inc."},
        {"00E025", "dit Co., Ltd."},
        {"AC84C6", "TP-LINK TECHNOLOGIES CO., LTD."},
        {"001530", "Dell EMC"},
        {"0CB2B7", "Texas Instruments"},
        {"24F677", "Apple, Inc."},
        {"B0CA68", "Apple, Inc."},
        {"C83C85", "Apple, Inc."},
        {"78870D", "Unifiedgateways India Private Limited"},
        {"A88200", "Hisense Electric Co., Ltd"},
        {"3820A8", "ColorTokens, Inc."},
        {"705896", "InShow Technology"},
        {"000589", "National Datacomputer"},
        {"3CA616", "vivo Mobile Communication Co., Ltd."},
        {"9CE063", "Samsung Electronics Co., Ltd"},
        {"D03169", "Samsung Electronics Co., Ltd"},
        {"24F27F", "Hewlett Packard Enterprise"},
        {"BC0543", "AVM GmbH"},
        {"00B69F", "Latch"},
        {"842C80", "Sichuan Changhong Electric Ltd."},
        {"3CC079", "Shenzhen One-Nine Intelligent Electronic Science and Technology Co., Ltd"},
        {"98C5DB", "Ericsson AB"},
        {"149F3C", "Samsung Electronics Co., Ltd"},
        {"FCEEE6", "FORMIKE ELECTRONIC CO., LTD"},
        {"84E327", "TAILYN TECHNOLOGIES INC"},
        {"0021B8", "Inphi Corporation"},
        {"0C9160", "Hui Zhou Gaoshengda Technology Co., LTD"},
        {"D8ED1C", "Magna Technology SL"},
        {"D83134", "Roku, Inc"},
        {"408BF6", "Shenzhen TCL New Technology Co., Ltd"},
        {"00006B", "Silicon Graphics"},
        {"74373B", "UNINET Co., Ltd."},
        {"7C6456", "Samsung Electronics Co., Ltd"},
        {"F46E24", "NEC Personal Computers, Ltd."},
        {"888279", "Shenzhen RB-LINK Intelligent Technology Co.Ltd"},
        {"68C63A", "Espressif Inc."},
        {"A0648F", "ASKEY COMPUTER CORP"},
        {"C850E9", "Raisecom Technology CO., LTD"},
        {"10F163", "TNK CO., LTD"},
        {"88DA1A", "Redpine Signals, Inc."},
        {"98EF9B", "OHSUNG"},
        {"14CF8D", "OHSUNG"},
        {"104400", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"B0E17E", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"E4A7C5", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"5C8D2D", "Shanghai Wellpay Information Technology Co., Ltd"},
        {"90FD9F", "Silicon Laboratories"},
        {"B430C0", "York Instruments Ltd"},
        {"E81DA8", "Ruckus Wireless"},
        {"F03D03", "TECNO MOBILE LIMITED"},
        {"DCF090", "Nubia Technology Co., Ltd."},
        {"A0FE61", "Vivint Wireless Inc."},
        {"5C2BF5", "Vivint Wireless Inc."},
        {"CC5A53", "Cisco Systems, Inc"},
        {"006088", "Analog Devices, Inc."},
        {"084ACF", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"2C279E", "IEEE Registration Authority"},
        {"8C5F48", "Continental Intelligent Transportation Systems LLC"},
        {"947EB9", "National Narrowband Network Communications Pty Ltd"},
        {"646E69", "Liteon Technology Corporation"},
        {"706BB9", "Cisco Systems, Inc"},
        {"D4389C", "Sony Mobile Communications Inc"},
        {"00C0EE", "KYOCERA Display Corporation"},
        {"245FDF", "KYOCERA CORPORATION"},
        {"9C63ED", "zte corporation"},
        {"74F661", "Schneider Electric Fire & Security Oy"},
        {"B8634D", "Apple, Inc."},
        {"24C42F", "Philips Lifeline"},
        {"2CB21A", "Phicomm (Shanghai) Co., Ltd."},
        {"A4E975", "Apple, Inc."},
        {"3035AD", "Apple, Inc."},
        {"844167", "Apple, Inc."},
        {"9800C6", "Apple, Inc."},
        {"AC1F74", "Apple, Inc."},
        {"A85C2C", "Apple, Inc."},
        {"00DB70", "Apple, Inc."},
        {"FCE557", "Nokia Corporation"},
        {"48C58D", "Lear Corporation GmbH"},
        {"00289F", "Semptian Co., Ltd."},
        {"9C305B", "Hon Hai Precision Ind.Co., Ltd."},
        {"104E89", "Garmin International"},
        {"D8C497", "Quanta Computer Inc."},
        {"BCC342", "Panasonic Communications Co., Ltd."},
        {"001BD3", "Panasonic Corporation AVC Networks Company"},
        {"CC7EE7", "Panasonic Corporation AVC Networks Company"},
        {"20C6EB", "Panasonic Corporation AVC Networks Company"},
        {"64B5C6", "Nintendo Co., Ltd"},
        {"2830AC", "Frontiir Co.Ltd."},
        {"D4D2E5", "BKAV Corporation"},
        {"0050B5", "FICHET SECURITE ELECTRONIQUE"},
        {"001439", "Blonder Tongue Laboratories, Inc"},
        {"20A6CD", "Hewlett Packard Enterprise"},
        {"84802D", "Cisco Systems, Inc"},
        {"001987", "Panasonic Mobile Communications Co., Ltd."},
        {"E470B8", "Intel Corporate"},
        {"741C27", "ITEL MOBILE LIMITED"},
        {"00A0AC", "GILAT SATELLITE NETWORKS, LTD."},
        {"002609", "Phyllis Co., Ltd."},
        {"28F537", "IEEE Registration Authority"},
        {"00869C", "Palo Alto Networks"},
        {"94D9B3", "TP-LINK TECHNOLOGIES CO., LTD."},
        {"C84029", "Fiberhome Telecommunication Technologies Co., LTD"},
        {"F86EEE", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"7802B1", "Cisco Systems, Inc"},
        {"B40F3B", "Tenda Technology Co., Ltd.Dongguan branch"},
        {"00188D", "Nokia Danmark A/S"},
        {"0015AB", "PRO CO SOUND INC"},
        {"5876C5", "DIGI I'S LTD"},
        {"A8B2DA", "FUJITSU LIMITED"},
        {"001354", "Zcomax Technologies, Inc."},
        {"78D800", "IEEE Registration Authority"},
        {"0835B2", "CoreEdge Networks Co., Ltd"},
        {"4C49E3", "Xiaomi Communications Co Ltd"},
        {"245880", "VIZEO"},
        {"54666C", "Shenzhen YOUHUA Technology Co., Ltd"},
        {"A89675", "Motorola Mobility LLC, a Lenovo Company"},
        {"389AF6", "Samsung Electronics Co., Ltd"},
        {"E0AA96", "Samsung Electronics Co., Ltd"},
        {"507705", "Samsung Electronics Co., Ltd"},
        {"F83441", "Intel Corporate"},
        {"28D436", "Jiangsu dewosi electric co., LTD"},
        {"D4B27A", "ARRIS Group, Inc."},
        {"44EA4B", "Actlas Inc."},
        {"C4CB6B", "Airista Flow, Inc."},
        {"188090", "Cisco Systems, Inc"},
        {"786256", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"B05508", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"B875C0", "PayPal, Inc."},
        {"001C71", "Emergent Electronics"},
        {"001A93", "ERCO Leuchten GmbH"},
        {"94F665", "Ruckus Wireless"},
        {"B090D4", "Shenzhen Hoin Internet Technology Co., Ltd"},
        {"C0BAE6", "Application Solutions (Electronics and Vision) Ltd"},
        {"8C9F3B", "Qingdao Hisense Communications Co.,Ltd."},
        {"0014B8", "Hill-Rom"},
        {"ACED5C", "Intel Corporate"},
        {"842096", "SHENZHEN RF-LINK TECHNOLOGY CO.,LTD."},
        {"B4C170", "Yi chip Microelectronics(Hangzhou) Co., Ltd"},
        {"AC6706", "Ruckus Wireless"},
        {"044FAA", "Ruckus Wireless"},
        {"589396", "Ruckus Wireless"},
        {"001F41", "Ruckus Wireless"},
        {"C4108A", "Ruckus Wireless"},
        {"F0B052", "Ruckus Wireless"},
        {"70DF2F", "Cisco Systems, Inc"},
        {"3894E0", "Syrotech Networks.Ltd."},
        {"34F64B", "Intel Corporate"},
        {"F46BEF", "Sagemcom Broadband SAS"},
        {"08306B", "Palo Alto Networks"},
        {"10CDB6", "Essential Products, Inc."},
        {"A4F3E7", "Integrated Device Technology (Malaysia) Sdn. Bhd."},
        {"E43A6E", "Shenzhen Zeroone Technology CO., LTD"},
        {"7CE2CA", "Juniper Networks"},
        {"9061AE", "Intel Corporate"},
        {"6CF9D2", "CHENGDU POVODO ELECTRONIC TECHNOLOGY CO., LTD"},
        {"30B62D", "Mojo Networks, Inc."},
        {"50184C", "Platina Systems Inc."},
        {"F4B7B3", "vivo Mobile Communication Co., Ltd."},
        {"CC03D9", "Cisco Meraki"},
        {"FCA667", "Amazon Technologies Inc."},
        {"C81FEA", "Avaya Inc"},
        {"0027E3", "Cisco Systems, Inc"},
        {"0018AE", "TVT CO., LTD"},
        {"8891DD", "Racktivity"},
        {"1C4593", "Texas Instruments"},
        {"90EC50", "C.O.B.O.SPA"},
        {"E0D848", "Dell Inc."},
        {"60271C", "VIDEOR E.Hartig GmbH"},
        {"00EC0A", "Xiaomi Communications Co Ltd"},
        {"C8D7B0", "Samsung Electronics Co., Ltd"},
        {"6C60EB", "ZHI YUAN ELECTRONICS CO., LIMITED"},
        {"74DADA", "D-Link International"},
        {"D8F1F0", "Pepxim International Limited"},
        {"DCC8F5", "Shanghai UMEinfo CO., LTD."},
        {"88D7F6", "ASUSTek COMPUTER INC."},
        {"9097F3", "Samsung Electronics Co., Ltd"},
        {"7C1C68", "Samsung Electronics Co., Ltd"},
        {"C087EB", "Samsung Electronics Co., Ltd"},
        {"04714B", "IEEE Registration Authority"},
        {"2C41A1", "Bose Corporation"},
        {"4C38D8", "ARRIS Group, Inc."},
        {"447BBB", "Shenzhen YOUHUA Technology Co., Ltd"},
        {"9C7BD2", "NEOLAB Convergence"},
        {"D0F88C", "Motorola (Wuhan) Mobility Technologies Communication Co., Ltd."},
        {"2CB115", "Integrated Device Technology (Malaysia) Sdn. Bhd."},
        {"34873D", "Quectel Wireless Solution Co., Ltd."},
        {"10D07A", "AMPAK Technology, Inc."},
        {"D4C1C8", "zte corporation"},
        {"88D274", "zte corporation"},
        {"002449", "Shen Zhen Lite Star Electronics Technology Co., Ltd"},
        {"00E18C", "Intel Corporate"},
        {"847933", "profichip GmbH"},
        {"881544", "Cisco Meraki"},
        {"C4ABB2", "vivo Mobile Communication Co., Ltd."},
        {"80B234", "Technicolor CH USA Inc."},
        {"44B412", "SIUS AG"},
        {"0CB912", "JM-DATA GmbH"},
        {"3CA308", "Texas Instruments"},
        {"F43E61", "SHENZHEN GONGJIN ELECTRONICS CO., LT"},
        {"B4417A", "SHENZHEN GONGJIN ELECTRONICS CO., LT"},
        {"185207", "SICHUAN TIANYI COMHEART TELECOMCO., LTD"},
        {"000062", "BULL HN INFORMATION SYSTEMS"},
        {"E8C1D7", "Philips"},
        {"4C8120", "Taicang T&W Electronics"},
        {"28A6DB", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"14A0F8","HUAWEI TECHNOLOGIES CO., LTD"},
        {"C8F86D", "Alcatel-Lucent Shanghai Bell Co., Ltd"},
        {"6045CB", "ASUSTek COMPUTER INC."},
        {"00118B", "Alcatel-Lucent Enterprise"},
        {"00E0B1", "Alcatel-Lucent Enterprise"},
        {"00E0DA", "Alcatel-Lucent Enterprise"},
        {"F8BE0D", "A2UICT Co., Ltd."},
        {"E442A6", "Intel Corporate"},
        {"3C678C", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"D4503F", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"388C50", "LG Electronics"},
        {"DC0856", "Alcatel-Lucent Enterprise"},
        {"1CDA27", "vivo Mobile Communication Co., Ltd."},
        {"90F305", "HUMAX Co., Ltd."},
        {"4095BD", "NTmore.Co., Ltd"},
        {"98AAFC", "IEEE Registration Authority"},
        {"00143F", "Hotway Technology Corporation"},
        {"D055B2", "Integrated Device Technology (Malaysia) Sdn. Bhd."},
        {"144FD7", "IEEE Registration Authority"},
        {"B85510", "Zioncom Electronics (Shenzhen) Ltd."},
        {"049573", "zte corporation"},
        {"F0D7AA", "Motorola Mobility LLC, a Lenovo Company"},
        {"F8FF0B", "lectronic Technology Inc."},
        {"7C6BF7", "NTI co., ltd."},
        {"00D318", "SPG Controls"},
        {"3096FB", "Samsung Electronics Co., Ltd"},
        {"4827EA", "Samsung Electronics Co., Ltd"},
        {"7C787E", "Samsung Electronics Co., Ltd"},
        {"245BA7", "Apple, Inc."},
        {"70F087", "Apple, Inc."},
        {"E0C63C", "SICHUAN TIANYI COMHEART TELECOMCO., LTD"},
        {"000C46", "Allied Telesyn Inc."},
        {"001F72", "QingDao Hiphone Technology Co,.Ltd"},
        {"002365", "Insta Elektro GmbH"},
        {"6091F3", "vivo Mobile Communication Co., Ltd."},
        {"28395E", "Samsung Electronics Co., Ltd"},
        {"38295A", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD"},
        {"88E628", "Shenzhen Kezhonglong Optoelectronic Technology Co., Ltd"},
        {"58238C", "Technicolor CH USA Inc."},
        {"CC82EB", "KYOCERA CORPORATION"},
        {"14987D", "Technicolor CH USA Inc."},
        {"D4CF37", "Symbolic IO"},
        {"D47DFC", "TECNO MOBILE LIMITED"},
        {"409F38", "AzureWave Technology Inc."},
        {"000631", "Calix Inc."},
        {"BC2F3D", "vivo Mobile Communication Co., Ltd."},
        {"40FA7F", "Preh Car Connect GmbH"},
        {"000DBB", "Nippon Dentsu Co., Ltd."},
        {"2C7E81", "ARRIS Group, Inc."},
        {"407D0F", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"68CC6E", "HUAWEI TECHNOLOGIES CO., LTD"},
        {"3034D2", "Availink, Inc."},
        {"504061", "Nokia"},
    };
    
    /// <summary>
    /// Returns the manufacturer name for a given code.<br/>
    /// If code not exist always returns the <b>Unknown</b> value.
    /// </summary>
    /// <param name="code">Manufaturer code to retrieve</param>
    /// <returns>
    /// The manufacturer name for a given code
    /// </returns>
    public static string GetManufacturer(IEnumerable<byte> code)
    {
        var hexCode = $"{code.ElementAt(0):X2}{code.ElementAt(1):X2}{code.ElementAt(2):X2}";
        var existCode = Oui.ContainsKey(hexCode);
        if (existCode)
        {
            return Oui[hexCode];
        }

        hexCode = $"{code.ElementAt(2):X2}{code.ElementAt(1):X2}{code.ElementAt(0):X2}";
        existCode = Oui.ContainsKey(hexCode);
        return !existCode ? "Unknown" : Oui[hexCode];
    }
}


//00108E HUGH SYMONS CONCEPT Technologies Ltd.
//E05163 Arcadyan Corporation
//54E3F6 Alcatel-Lucent
//40B034 Hewlett Packard
//B816DB CHANT SINCERE CO., LTD
//40B4CD Amazon Technologies Inc.
//D481D7 Dell Inc.
//F42B48 Ubiqam
//50F14A Texas Instruments
//04DEF2 Shenzhen ECOM Technology Co.Ltd
//540384 Hangkong Nano IC Technologies Co., Ltd
//78C1A7 zte corporation
//4C7872 Cav. Uff.Giacomo Cimberio S.p.A.
//8CF5A3 SAMSUNG ELECTRO-MECHANICS(THAILAND)
//8CC8F4 IEEE Registration Authority
//F483E1 Shanghai Clouder Semiconductor Co., Ltd
//083E5D agemcom Broadband SAS
//3CBD3E Beijing Xiaomi Electronics Co., Ltd.
//641A22 Heliospectra AB
//A084CB SonicSensory, Inc.
//D47AE2 Samsung Electronics Co., Ltd
//6854FD Amazon Technologies Inc.
//0003BC COT GmbH
//D4B169 Le Shi Zhi Xin Electronic Technology (Tianjin) Limited
//E44790 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//38454C Light Labs, Inc.
//000A49 F5 Networks, Inc.
//00A0C8 Adtran Inc
//F49651 NAKAYO Inc
//446246 Comat AG
//34FCB9 Hewlett Packard Enterprise
//70918F Weber-Stephen Products LLC
//D8E0E1 Samsung Electronics Co., Ltd
//7C1015 Brilliant Home Technology, Inc.
//D8C771 HUAWEI TECHNOLOGIES CO., LTD
//E02A82 Universal Global Scientific Industrial Co., Ltd.
//B0F963 Hangzhou H3C Technologies Co., Limited
//D490E0 Topcon Electronics GmbH & Co.KG
//A84041 Dragino Technology Co., Limited
//E02202 ARRIS Group, Inc.
//D825B0 Rockeetech Systems Co., Ltd.
//74614B Chongqing Huijiatong Information Technology Co., Ltd.
//98D293 Google, Inc.
//CCB8A8 AMPAK Technology, Inc.
//1077B0 Fiberhome Telecommunication Technologies Co., LTD
//F01DBC Microsoft Corporation
//34049E IEEE Registration Authority
//94FB29 Zebra Technologies Inc.
//B0702D Apple, Inc.
//6C19C0 Apple, Inc.
//00204F DEUTSCHE AEROSPACE AG
//00DBDF Intel Corporate
//94A04E Bostex Technology Co., LTD
//8CE117 zte corporation
//688AF0 zte corporation
//C0210D SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//4CE2F1 sclak srl
//504B5B CONTROLtronic GmbH
//B47447 CoreOS
//80D4A5 HUAWEI TECHNOLOGIES CO., LTD
//04B0E7 HUAWEI TECHNOLOGIES CO., LTD
//446A2E HUAWEI TECHNOLOGIES CO., LTD
//0C8DDB Cisco Meraki
//B0EE7B Roku, Inc
//AC587B JCT Healthcare
//1062EB D-Link International
//000894 InnoVISION Multimedia Ltd.
//480033 Technicolor CH USA Inc.
//A06FAA LG Innotek
//0026AB Seiko Epson Corporation
//FC10C6 Taicang T&W Electronics
//2C6FC9 Hon Hai Precision Ind.Co., Ltd.
//58EF68 Belkin International Inc.
//000B4F Verifone
//60C798 Verifone
//C8662C Beijing Haitai Fangyuan High Technology Co,.Ltd.
//8096CA Hon Hai Precision Ind.Co., Ltd.
//186571 Top Victory Electronics (Taiwan) Co., Ltd.
//F83F51 Samsung Electronics Co., Ltd
//50D753 CONELCOM GmbH
//0CC47A Super Micro Computer, Inc.
//34D270 Amazon Technologies Inc.
//50795B Interexport Telecomunicaciones S.A.
//0016D9 NINGBO BIRD CO., LTD.
//6CA7FA YOUNGBO ENGINEERING INC.
//8C7EB3 Lytro, Inc.
//B4B384 ShenZhen Figigantic Electronic Co., Ltd
//7828CA Sonos, Inc.
//00C003 GLOBALNET COMMUNICATIONS
//00234A Private
//2C402B Smart iBlue Technology Limited
//5C6B4F Hello Inc.
//2C9924 ARRIS Group, Inc.
//D058A8 zte corporation
//D071C4 zte corporation
//A0CC2B Murata Manufacturing Co., Ltd.
//5001D9 HUAWEI TECHNOLOGIES CO., LTD
//00271C MERCURY CORPORATION
//E0D9E3 Eltex Enterprise Ltd.
//805EC0 YEALINK(XIAMEN) NETWORK TECHNOLOGY CO., LTD.
//007B18 SENTRY Co., LTD.
//144D67 Zioncom Electronics (Shenzhen) Ltd.
//4CE173 IEEE Registration Authority
//0CD86C SHENZHEN FAST TECHNOLOGIES CO., LTD
//049790 Lartech telecom LLC
//28EED3 Shenzhen Super D Technology Co., Ltd
//24C44A zte corporation
//98541B Intel Corporate
//1C40E8 SHENZHEN PROGRESS&WIN TECHNOLOGY CO., LTD
//0023D2 Inhand Electronics, Inc.
//DC0B34 LG Electronics (Mobile Communications)
//404E36 HTC Corporation
//A8E705 Fiberhome Telecommunication Technologies Co., LTD
//9840BB Dell Inc.
//0060D6 NovAtel Inc.
//503AA0 SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//B0958E TP-LINK TECHNOLOGIES CO., LTD.
//C025E9 TP-LINK TECHNOLOGIES CO., LTD.
//802AA8 Ubiquiti Networks Inc.
//F09FC2 Ubiquiti Networks Inc.
//188B15 ShenZhen ZhongRuiJing Technology co., LTD
//788A20 Ubiquiti Networks Inc.
//886B0F Bluegiga Technologies OY
//AC84C9 Sagemcom Broadband SAS
//245CBF NCSE
//2C3361 Apple, Inc.
//60A4D0 Samsung Electronics Co., Ltd
//008701 Samsung Electronics Co., Ltd
//5C9960 Samsung Electronics Co., Ltd
//9C62AB Sumavision Technologies Co., Ltd
//C8F946 LOCOSYS Technology Inc.
//487B6B HUAWEI TECHNOLOGIES CO., LTD
//883FD3 HUAWEI TECHNOLOGIES CO., LTD
//240D65 Shenzhen Vsun Communication Technology Co., Ltd.
//000B14 ViewSonic Corporation
//C8028F Nova Electronics (Shanghai) Co., Ltd.
//A46011 Verifone
//5CA933 Luma Home
//00137E CorEdge Networks, Inc.
//D814D6 SURE SYSTEM Co Ltd
//6CEFC6 SHENZHEN TWOWING TECHNOLOGIES CO., LTD.
//101DC0 Samsung Electronics Co., Ltd
//002341 Vanderbilt International (SWE) AB
//407C7D Nokia
//24590B White Sky Inc. Limited
//68EBAE Samsung Electronics Co., Ltd
//444E1A Samsung Electronics Co., Ltd
//143365 TEM Mobile Limited
//801844 Dell Inc.
//78471D Samsung Electronics Co., Ltd
//A07591 Samsung Electronics Co., Ltd
//0CDFA4 Samsung Electronics Co., Ltd
//B072BF Murata Manufacturing Co., Ltd.
//701DC4 NorthStar Battery Company, LLC
//64DAA0 Robert Bosch Smart Home GmbH
//14B837 Shenzhen YOUHUA Technology Co., Ltd
//5C8613 Beijing Zhoenet Technology Co., Ltd
//CC7314 HONG KONG WHEATEK TECHNOLOGY LIMITED
//B8EE65 Liteon Technology Corporation
//985BB0 KMDATA INC.
//E006E6 Hon Hai Precision Ind.Co., Ltd.
//BC8556 Hon Hai Precision Ind.Co., Ltd.
//342387 Hon Hai Precision Ind. Co., Ltd.
//002637 SAMSUNG ELECTRO MECHANICS CO., LTD.
//002119 SAMSUNG ELECTRO MECHANICS CO., LTD.
//F4D9FB Samsung Electronics Co., Ltd
//3C6200 Samsung Electronics Co., Ltd
//C417FE Hon Hai Precision Ind. Co., Ltd.
//9439E5 Hon Hai Precision Ind. Co., Ltd.
//642737 Hon Hai Precision Ind. Co., Ltd.
//A41731 Hon Hai Precision Ind.Co., Ltd.
//5CA39D SAMSUNG ELECTRO MECHANICS CO., LTD.
//90187C SAMSUNG ELECTRO MECHANICS CO., LTD.
//50CCF8 SAMSUNG ELECTRO MECHANICS CO., LTD.
//00223B Communication Networks, LLC
//C0F8DA Hon Hai Precision Ind. Co., Ltd.
//0011FF Digitro Tecnologia Ltda
//001B94 T.E.M.A.S.p.A.
//F0F002 Hon Hai Precision Ind.Co., Ltd.
//C0CB38 Hon Hai Precision Ind.Co., Ltd.
//F07BCB Hon Hai Precision Ind.Co., Ltd.
//50B7C3 Samsung Electronics Co., Ltd
//1C5A3E Samsung Electronics Co., Ltd
//A02195 Samsung Electronics Co., Ltd
//B07870 Wi-NEXT, Inc.
//E47CF9 Samsung Electronics Co., Ltd
//4844F7 Samsung Electronics Co., Ltd
//001377 Samsung Electronics Co., Ltd
//002454 Samsung Electronics Co., Ltd
//E81132 Samsung Electronics Co., Ltd
//C06599 Samsung Electronics Co., Ltd
//BC79AD Samsung Electronics Co., Ltd
//4C3C16 Samsung Electronics Co., Ltd
//0073E0 Samsung Electronics Co., Ltd
//0017D5 Samsung Electronics Co., Ltd
//001E7D Samsung Electronics Co., Ltd
//001DF6 Samsung Electronics Co., Ltd
//F008F1 Samsung Electronics Co., Ltd
//58C38B Samsung Electronics Co., Ltd
//00E3B2 Samsung Electronics Co., Ltd
//301966 Samsung Electronics Co., Ltd
//F0E77E Samsung Electronics Co., Ltd
//94350A Samsung Electronics Co., Ltd
//001D25 Samsung Electronics Co., Ltd
//E4C1F1 SHENZHEN SPOTMAU INFORMATION TECHNOLIGY CO., Ltd
//240AC4 Espressif Inc.
//343111 Samsung Electronics Co., Ltd
//08FD0E Samsung Electronics Co., Ltd
//041BBA Samsung Electronics Co., Ltd
//889B39 Samsung Electronics Co., Ltd
//E432CB Samsung Electronics Co., Ltd
//BC8CCD SAMSUNG ELECTRO-MECHANICS(THAILAND)
//D022BE SAMSUNG ELECTRO-MECHANICS(THAILAND)
//EC9BF3 SAMSUNG ELECTRO-MECHANICS(THAILAND)
//F409D8 SAMSUNG ELECTRO-MECHANICS(THAILAND)
//10D542 Samsung Electronics Co., Ltd
//A0821F Samsung Electronics Co., Ltd
//F06BCA Samsung Electronics Co., Ltd
//AC3613 Samsung Electronics Co., Ltd
//002611 Licera AB
//005094 ARRIS Group, Inc.
//E0B7B1 ARRIS Group, Inc.
//D82522 ARRIS Group, Inc.
//F0038C AzureWave Technology Inc.
//18D276 HUAWEI TECHNOLOGIES CO., LTD
//005218 Wuxi Keboda Electron Co.Ltd
//001E81 CNB Technology Inc.




//7CA97D Objenious
//A8A648 Qingdao Hisense Communications Co., Ltd.
//985DAD Texas Instruments
//D43639", "Texas Instruments
//BC282C e-Smart Systems Pvt.Ltd
//A40DBC", "Xiamen Intretech Inc.
//84EF18, "Intel Corporate
//84C1C1 Juniper Networks
//A81B6A", "Texas Instruments
//343DC4 BUFFALO.INC
//B0F893", "Shanghai MXCHIP Information Technology Co., Ltd.
//C411E0 Bull Group Co., Ltd
//28C87A ARRIS Group, Inc.
//48FD8E HUAWEI TECHNOLOGIES CO., LTD
//7C0623 Ultra Electronics Sonar System Division
//28AC67 Mach Power, Rappresentanze Internazionali s.r.l.
//14825B Hefei Radio Communication Technology Co., Ltd
//641269, "ARRIS Group, Inc.
//0002C9 Mellanox Technologies, Inc.
//080051, "ExperData
//00126C Visonic Technologies 1993 Ltd.
//AC6175 HUAWEI TECHNOLOGIES CO., LTD
//244427, "HUAWEI TECHNOLOGIES CO., LTD
//0080C7 XIRCOM
//000138, "XAVi Technologies Corp.
//00166D, "Yulong Computer Telecommunication Scientific (Shenzhen) Co., Ltd
//3C9157 Yulong Computer Telecommunication Scientific (Shenzhen) Co., Ltd
//0000D8, "Novell, Inc.
//001F46, "Nortel Networks
//003093, "Sonnet Technologies, Inc
//00034B Nortel Networks
//002561, "ProCurve Networking by HP
//008058, "PRINTER SYSTEMS CORP.
//00157D, "POSDATA
//4849C7 Samsung Electronics Co., Ltd
//849866, "Samsung Electronics Co., Ltd
//001C9C Nortel Networks
//001B25 Nortel Networks
//0019E1, "Nortel Networks
//001D42, "Nortel Networks
//00140D, "Nortel Networks
//000E40, "Nortel Networks
//FCB0C4 Shanghai DareGlobal Technologies Co., Ltd
//A89DD2", "Shanghai DareGlobal Technologies Co., Ltd
//00E00F, "Shanghai Baud Data Communication Co., Ltd.
//28BE03 TCT mobile ltd
//903AE6 PARROT SA
//A098ED", "Shandong Intelligent Optical Communication Development Co., Ltd.
//000EF4, "Kasda Networks Inc
//00167A Skyworth Overseas Development Ltd.
//A42940 Shenzhen YOUHUA Technology Co., Ltd
//E4A387", "Control Solutions LLC
//1880F5, "Alcatel-Lucent Shanghai Bell Co., Ltd
//10E878, "Nokia
//10F96F, "LG Electronics (Mobile Communications)
//C4438F", "LG Electronics (Mobile Communications)
//A09169", "LG Electronics (Mobile Communications)
//286C07 XIAOMI Electronics, CO., LTD
//002280, "A2B Electronics AB
//404AD4 Widex A/S
//9893CC LG ELECTRONICS INC
//3CCD93 LG ELECTRONICS INC
//2021A5 LG Electronics (Mobile Communications)
//6CD68A LG Electronics (Mobile Communications)
//CC79CF", "SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//001925, "Intelicis Corporation
//9476B7 Samsung Electronics Co., Ltd
//2C54CF LG Electronics (Mobile Communications)
//485929, "LG Electronics (Mobile Communications)
//58A2B5 LG Electronics (Mobile Communications)
//002483, "LG Electronics (Mobile Communications)
//001FE3 LG Electronics (Mobile Communications)
//F0421C", "Intel Corporate
//000F62, "Alcatel Bell Space N.V.
//001CD8 BlueAnt Wireless
//0019AB Raycom CO., LTD
//4C334E HIGHTECH
//7C70BC IEEE Registration Authority
//E81863 IEEE Registration Authority
//2CD141 IEEE Registration Authority
//3C39E7 IEEE Registration Authority
//BC6641 IEEE Registration Authority
//80E4DA IEEE Registration Authority
//885D90, "IEEE Registration Authority
//C88ED1", "IEEE Registration Authority
//B01F81", "IEEE Registration Authority
//549A11 IEEE Registration Authority
//B8D812 IEEE Registration Authority
//1C21D1 IEEE Registration Authority
//283638, "IEEE Registration Authority
//F485C6", "FDT Technologies
//60EB69 QUANTA COMPUTER INC.
//C80AA9 QUANTA COMPUTER INC.
//D404FF Juniper Networks
//C8755B", "Quantify Technology Pty.Ltd.
//001B24 QUANTA COMPUTER INC.
//00C09F QUANTA COMPUTER INC.
//C45444 QUANTA COMPUTER INC.
//00269E, "QUANTA COMPUTER INC.
//88124E, "Qualcomm Inc.
//001428, "Vocollect Inc
//006B9E Vizio, Inc
//4C6641 SAMSUNG ELECTRO-MECHANICS(THAILAND)
//5CA86A HUAWEI TECHNOLOGIES CO., LTD
//001B32 QLogic Corporation
//0017CA Qisda Corporation
//70F395, "Universal Global Scientific Industrial Co., Ltd.
//48F7C0 Technicolor CH USA Inc.
//0015B7 Toshiba
//E89D87 Toshiba
//E09579 ORTHOsoft inc, d/b/a Zimmer CAS
//A0ADA1", "JMR Electronics, Inc
//BCC00F", "Fiberhome Telecommunication Technologies Co., LTD
//9CA5C0 vivo Mobile Communication Co., Ltd.
//80C6AB Technicolor CH USA Inc.
//90A4DE Wistron Neweb Corporation
//70E284, "Wistron Infocomm (Zhongshan) Corporation
//A854B2 Wistron Neweb Corporation
//3044A1 Shanghai Nanchao Information Technology
//CC03FA", "Technicolor CH USA Inc.
//E0ACF1 Cisco Systems, Inc
//00015B ITALTEL S.p.A/RF-UP-I
//00A0A8 RENEX CORPORATION
//00C0AB Telco Systems, Inc.
//0023F8, "Zyxel Communications Corporation
//0019CB Zyxel Communications Corporation
//2C094D Raptor Engineering, LLC
//AC3743", "HTC Corporation
//001D7E, "Cisco-Linksys, LLC
//E4FB8F", "MOBIWIRE MOBILES (NINGBO) CO., LTD
//10BD55 Q-Lab Corporation
//C449BB MITSUMI ELECTRIC CO., LTD.
//FC2D5E zte corporation
//B40418", "Smartchip Integrated Inc.
//90CF7D Qingdao Hisense Communications Co., Ltd.
//F40A4A INDUSNET Communication Technology Co., LTD
//F85A00", "Sanford LP
//FC55DC Baltic Latvian Universal Electronics LLC
//08010F, "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//941882, "Hewlett Packard Enterprise
//6038E0, "Belkin International Inc.
//8850DD Infiniband Trade Association
//002550, "Riverbed Technology, Inc.
//D0B2C4 Technicolor CH USA Inc.
//50AB3E Qibixx AG
//3876CA Shenzhen Smart Intelligent Technology Co.Ltd
//042758, "HUAWEI TECHNOLOGIES CO., LTD
//9CE374 HUAWEI TECHNOLOGIES CO., LTD
//8CD2E9 YOKOTE SEIKO CO., LTD.
//B8BBAF Samsung Electronics Co., Ltd
//60C5AD Samsung Electronics Co., Ltd
//442C05 AMPAK Technology, Inc.
//8C897A AUGTEK
//F845AD Konka Group Co., Ltd.
//000FE2 Hangzhou H3C Technologies Co., Limited
//80F62E, "Hangzhou H3C Technologies Co., Limited
//608D17, "Sentrus Government Systems Division, Inc
//ECADB8", "Apple, Inc.
//9801A7 Apple, Inc.
//6879ED, "SHARP Corporation
//002382, "Lih Rong electronic Enterprise Co., Ltd.
//24F094, "Apple, Inc.
//086D41, "Apple, Inc.
//B4D5BD Intel Corporate
//98AA3C Will i-tech Co., Ltd.
//BCAD28 Hangzhou Hikvision Digital Technology Co., Ltd.
//F4911E ZHUHAI EWPE INFORMATION TECHNOLOGY INC
//002552, "VXi Corporation
//6CE983 Gastron Co., LTD.
//28E31F, "Xiaomi Communications Co Ltd
//989096, "Dell Inc.
//DC3752 GE
//DCD916 HUAWEI TECHNOLOGIES CO., LTD
//00022E, "TEAC Corp. R& D
//0060B0 Hewlett Packard
//7C738B Cocoon Alarm Ltd
//F80F84 Natural Security SAS
//44A42D TCT mobile ltd
//70F96D, "Hangzhou H3C Technologies Co., Limited
//BC6A44", "Commend International GmbH
//F0EE58", "PACE Telematics GmbH
//083FBC zte corporation
//00C0F0 Kingston Technology Company, Inc.
//943BB1 Kaonmedia CO., LTD.
//0018D7, "JAVAD GNSS, Inc.
//001F09, "Jastec
//AC620D", "Jabil Circuit(Wuxi) Co., Ltd
//08000D, "International Computers, Ltd
//1C7370 Neotech
//30E37A Intel Corporate
//0000C9 Emulex Corporation
//0040AA Valmet Automation
//D0B0CD", "Moen
//7050AF BSkyB Ltd
//F4EF9E", "SGSG SCIENCE & TECHNOLOGY CO. LTD
//1C740D Zyxel Communications Corporation
//603ECA Cambridge Medical Robotics Ltd
//001F1F, "Edimax Technology Co.Ltd.
//00020E, "ECI Telecom Ltd.
//200A5E Xiangshan Giant Eagle Technology Developing Co., Ltd.
//9C741A HUAWEI TECHNOLOGIES CO., LTD
//E4A8B6", "HUAWEI TECHNOLOGIES CO., LTD
//244C07 HUAWEI TECHNOLOGIES CO., LTD
//746FF7 Wistron Neweb Corporation
//B8AEED Elitegroup Computer Systems Co., Ltd.
//000DB0 Olym-tech Co., Ltd.
//30F6B9 Ecocentric Energy
//847BEB Dell Inc.
//54511B HUAWEI TECHNOLOGIES CO., LTD
//68536C SPnS Co., Ltd
//1CEA1B Nokia
//D4612E HUAWEI TECHNOLOGIES CO., LTD
//B0E2E5", "Fiberhome Telecommunication Technologies Co., LTD
//40476A AG Acquisition Corp. d.b.a.ASTRO Gaming
//001FA7 Sony Interactive Entertainment Inc.
//9046A2 Tedipay UK Ltd
//6479A7 Phison Electronics Corp.
//CCB11A Samsung Electronics Co., Ltd
//703C03 RadiAnt Co., Ltd
//00C164 Cisco Systems, Inc
//DC2DCB", "Beijing Unis HengYue Technology Co., Ltd.
//2C9662 Invenit BV
//CCD3E2", "Jiangsu Yinhe", "Electronics Co., Ltd.
//E4FAED Samsung Electronics Co., Ltd
//288335, "Samsung Electronics Co., Ltd
//DCCF96", "Samsung Electronics Co., Ltd
//AC44F2", "YAMAHA CORPORATION
//1C5F2B D-Link International
//1C98EC Hewlett Packard Enterprise
//70661B Sonova AG
//B07FB9", "NETGEAR
//047E4A moobox CO., Ltd.
//0080E5, "NetApp
//9C5C8E ASUSTek COMPUTER INC.
//C88722 Lumenpulse
//84683E, "Intel Corporate
//E0CDFD Beijing E3Control Technology Co, LTD
//000895, "DIRC Technologie GmbH & Co.KG
//60ACC8 KunTeng Inc.
//CCB3AB shenzhen Biocare Bio-Medical Equipment Co., Ltd.
//E4B318 Intel Corporate
//743E2B Ruckus Wireless
//E0C767", "Apple, Inc.
//80ED2C Apple, Inc.
//F03404 TCT mobile ltd
//80D160, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//30785C Partow Tamas Novin (Parman)
//246968, "TP-LINK TECHNOLOGIES CO., LTD.
//8CA2FD Starry, Inc.
//84BA3B CANON INC.
//000585, "Juniper Networks
//204E71, "Juniper Networks
//00194F, "Nokia Danmark A/S
//00BD3A Nokia Corporation
//80501B Nokia Corporation
//A04E04", "Nokia Corporation
//001262, "Nokia Danmark A/S
//0014A7 Nokia Danmark A/S
//0015A0 Nokia Danmark A/S
//0016BC Nokia Danmark A/S
//00174B Nokia Danmark A/S
//002669, "Nokia Danmark A/S
//AC61EA", "Apple, Inc.
//38B54D Apple, Inc.
//1C5CF2 Apple, Inc.
//A87E33 Nokia Danmark A/S
//002403, "Nokia Danmark A/S
//002404, "Nokia Danmark A/S
//0019B7 Nokia Danmark A/S
//0017B0 Nokia Danmark A/S
//002109, "Nokia Danmark A/S
//002108, "Nokia Danmark A/S
//001B33 Nokia Danmark A/S
//0015DE Nokia Danmark A/S
//0002EE Nokia Danmark A/S
//D8F710", "Libre Wireless Technologies Inc.
//3C591E TCL King Electrical Appliances (Huizhou) Co., Ltd
//C43655", "Shenzhen Fenglian Technology Co., Ltd.
//E0B9E5 Technicolor
//0030DA Comtrend Corporation
//64680C Comtrend Corporation
//3872C0 Comtrend Corporation
//A80600", "Samsung Electronics Co., Ltd
//002682, "Gemtek Technology Co., Ltd.
//0009E1, "Gemtek Technology Co., Ltd.
//14C126 Nokia Corporation
//600194, "Espressif Inc.
//F05A09 Samsung Electronics Co., Ltd
//503275, "Samsung Electronics Co., Ltd
//08FC88 Samsung Electronics Co., Ltd
//0270B3 DATA RECALL LTD.
//000136, "CyberTAN Technology Inc.
//D04D2C Roku, Inc.
//B0A737 Roku, Inc.
//140C76 FREEBOX SAS
//001BE9 Broadcom
//0019C7 Cambridge Industries(Group) Co., Ltd.
//70D931, "Cambridge Industries(Group) Co., Ltd.
//029D8E, "CARDIAC RECORDERS, INC.
//00402A Canoga Perkins Corporation
//A4C7DE Cambridge Industries(Group) Co., Ltd.
//D8B8F6 Nantworks
//008077, "Brother industries, LTD.
//24F5AA Samsung Electronics Co., Ltd
//988389, "Samsung Electronics Co., Ltd
//84A466 Samsung Electronics Co., Ltd
//C4576E", "Samsung Electronics Co., Ltd
//508569, "Samsung Electronics Co., Ltd
//0060BB Cabletron Systems, Inc.
//F8D0BD Samsung Electronics Co., Ltd
//78595E, "Samsung Electronics Co., Ltd
//0C1420 Samsung Electronics Co., Ltd
//94B10A Samsung Electronics Co., Ltd
//3CBBFD Samsung Electronics Co., Ltd
//A48431", "Samsung Electronics Co., Ltd
//A0B4A5", "Samsung Electronics Co., Ltd
//E4F8EF", "Samsung Electronics Co., Ltd
//DC446D", "Allwinner Technology Co., Ltd
//745AAA HUAWEI TECHNOLOGIES CO., LTD
//04FE8D HUAWEI TECHNOLOGIES CO., LTD
//001333, "BaudTec Corporation
//58671A Barnes&Noble
//002675, "Aztech Electronics Pte Ltd
//0024FE AVM GmbH
//C02506", "AVM GmbH
//405D82, "NETGEAR
//DCEF09", "NETGEAR
//DC64B8", "Shenzhen JingHanDa Electronics Co.Ltd
//000D92, "ARIMA Communications Corp.
//002163, "ASKEY COMPUTER CORP
//A8D3F7", "Arcadyan Technology Corporation
//4C60DE NETGEAR
//C43DC7 NETGEAR
//489D24, "BlackBerry RTS
//08BD43 NETGEAR
//44EE02 MTI Ltd.
//5856E8, "ARRIS Group, Inc.
//F80BBE ARRIS Group, Inc.
//DC4517 ARRIS Group, Inc.
//C8AA21 ARRIS Group, Inc.
//0017EE ARRIS Group, Inc.
//00111A ARRIS Group, Inc.
//000F9F, "ARRIS Group, Inc.
//0004BD ARRIS Group, Inc.
//002642, "ARRIS Group, Inc.
//0024A1 ARRIS Group, Inc.
//002210, "ARRIS Group, Inc.
//0022B4 ARRIS Group, Inc.
//00149A ARRIS Group, Inc.
//0014E8, "ARRIS Group, Inc.
//0019C0 ARRIS Group, Inc.
//00E06F, "ARRIS Group, Inc.
//8096B1 ARRIS Group, Inc.
//707E43, "ARRIS Group, Inc.
//00152F, "ARRIS Group, Inc.
//001FC4 ARRIS Group, Inc.
//001CFB ARRIS Group, Inc.
//002395, "ARRIS Group, Inc.
//0023AF ARRIS Group, Inc.
//F87B7A ARRIS Group, Inc.
//0000F4, "Allied Telesis, Inc.
//001577, "Allied Telesis, Inc.
//001AEB Allied Telesis R&D Center K.K.
//703C39 SEAWING Kft
//9097D5, "Espressif Inc.
//ACD074 Espressif Inc.
//38E3C5 Taicang T&W Electronics
//0015CE ARRIS Group, Inc.
//0015A2 ARRIS Group, Inc.
//0015A3 ARRIS Group, Inc.
//0015A4 ARRIS Group, Inc.
//0000CA ARRIS Group, Inc.
//709E29, "Sony Interactive Entertainment Inc.
//A4DB30 Liteon Technology Corporation
//40F02F, "Liteon Technology Corporation
//74C246 Amazon Technologies Inc.
//000FA3 Alpha Networks Inc.
//001D6A Alpha Networks Inc.
//002345, "Sony Mobile Communications Inc
//6C0E0D Sony Mobile Communications Inc
//6C23B9 Sony Mobile Communications Inc
//3017C8 Sony Mobile Communications Inc
//0012EE Sony Mobile Communications Inc
//001620, "Sony Mobile Communications Inc
//001963, "Sony Mobile Communications Inc
//001FE4 Sony Mobile Communications Inc
//205476, "Sony Mobile Communications Inc
//001A80 Sony Corporation
//8841FC AirTies Wireless Networks
//0030D3, "Agilent Technologies, Inc.
//00A02F ADB Broadband Italia
//98743D, "Shenzhen Jun Kai Hengye Technology Co. Ltd
//A0F459", "FN-LINK TECHNOLOGY LIMITED
//586356, "FN-LINK TECHNOLOGY LIMITED
//8CB864 AcSiP Technology Corp.
//5CE2F4 AcSiP Technology Corp.
//B8616F Accton Technology Corp
//0012CF Accton Technology Corp
//0030F1, "Accton Technology Corp
//705A0F Hewlett Packard
//4495FA Qingdao Santong Digital Technology Co.Ltd
//0025D3, "AzureWave Technology Inc.
//1C4BD6 AzureWave Technology Inc.
//08A95A AzureWave Technology Inc.
//94DBC9 AzureWave Technology Inc.
//240A64 AzureWave Technology Inc.
//40E230, "AzureWave Technology Inc.
//80D21D, "AzureWave Technology Inc.
//D4D184 ADB Broadband Italia
//A04FD4 ADB Broadband Italia
//D00ED9 Taicang T&W Electronics
//541473, "Wingtech Group (HongKong）Limited
//8086F2, "Intel Corporate
//E09467 Intel Corporate
//08D40C Intel Corporate
//6C8814 Intel Corporate
//303A64 Intel Corporate
//ACFDCE", "Intel Corporate
//7CCCB8 Intel Corporate
//F40669", "Intel Corporate
//001DE1 Intel Corporate
//90E2BA Intel Corporate
//0026C7 Intel Corporate
//0026C6 Intel Corporate
//0CCC26 Airenetworks
//E09D31 Intel Corporate
//88532E, "Intel Corporate
//74C99A Ericsson AB
//5CC213 Fr. Sauter AG
//28101B MagnaCom
//001676, "Intel Corporate
//0016EA Intel Corporate
//001B77 Intel Corporate
//001CC0 Intel Corporate
//104A7D Intel Corporate
//001AA0 Dell Inc.
//0019B9 Dell Inc.
//00B0D0 Dell Inc.
//00C04F Dell Inc.
//B07994 Motorola Mobility LLC, a Lenovo Company
//A470D6", "Motorola Mobility LLC, a Lenovo Company
//74867A Dell Inc.
//180373, "Dell Inc.
//14FEB5 Dell Inc.
//782BCB Dell Inc.
//001F3B Intel Corporate
//00215D, "Intel Corporate
//00216A Intel Corporate
//001C23 Dell Inc.
//A4BADB Dell Inc.
//002564, "Dell Inc.
//A41F72 Dell Inc.
//C46699 vivo Mobile Communication Co., Ltd.
//C8F230 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//8C0EE3 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//C8CD72", "Sagemcom Broadband SAS
//F82C18, "2Wire Inc
//18017D, "Harbin Arteor technology co., LTD
//001556, "Sagemcom Broadband SAS
//C0D044", "Sagemcom Broadband SAS
//A01B29", "Sagemcom Broadband SAS
//74E14A IEEE Registration Authority
//0CEFAF IEEE Registration Authority
//F80278 IEEE Registration Authority
//A0BB3E IEEE Registration Authority
//884AEA Texas Instruments
//0022A4", "2Wire Inc
//982CBE", "2Wire Inc
//640F28, "2Wire Inc
//00123F, "Dell Inc.
//000BDB Dell Inc.
//204747, "Dell Inc.
//001495, "2Wire Inc
//348AAE Sagemcom Broadband SAS
//7C03D8 Sagemcom Broadband SAS
//C0AC54 Sagemcom Broadband SAS
//2C3996 Sagemcom Broadband SAS
//F08261 Sagemcom Broadband SAS
//0030C5 CADENCE DESIGN SYSTEMS, INC.
//D08CB5 Texas Instruments
//00182F, "Texas Instruments
//0017EA Texas Instruments
//0021BA Texas Instruments
//BC0DA5", "Texas Instruments
//CC8CE3 Texas Instruments
//E0D7BA", "Texas Instruments
//1CE2CC Texas Instruments
//985945, "Texas Instruments
//944452, "Belkin International Inc.
//B0B448 Texas Instruments
//D494A1", "Texas Instruments
//0014BF Cisco-Linksys, LLC
//CCB255", "D-Link International
//28107B D-Link International
//FC7516 D-Link International
//84C9B2 D-Link International
//C8D3A3 D-Link International
//3CBB73 Shenzhen Xinguodu Technology Co., Ltd.
//0C47C9 Amazon Technologies Inc.
//0050BA D-Link Corporation
//00179A D-Link Corporation
//001CF0 D-Link Corporation
//001E58, "D-Link Corporation
//0022B0 D-Link Corporation
//002401, "D-Link Corporation
//1CAFF7 D-Link International
//14D64D, "D-Link International
//9094E4, "D-Link International
//B499BA Hewlett Packard
//047863, "Shanghai MXCHIP Information Technology Co., Ltd.
//409F87, "Jide Technology (Hong Kong) Limited
//0CF9C0 BSkyB Ltd
//4CFF12 Fuze Entertainment Co., ltd
//AC9A22", "NXP Semiconductors
//287CDB Hefei", "Toycloud Technology Co., ltd
//806AB0 Shenzhen TINNO Mobile Technology Corp.
//48AD08 HUAWEI TECHNOLOGIES CO., LTD
//4CFB45 HUAWEI TECHNOLOGIES CO., LTD
//009ACD HUAWEI TECHNOLOGIES CO., LTD
//3C5AB4 Google, Inc.
//F4F5E8 Google, Inc.
//94EB2C Google, Inc.
//0CC731 Currant, Inc.
//70B3D5 IEEE Registration Authority
//28ED6A Apple, Inc.
//C056E3 Hangzhou Hikvision Digital Technology Co., Ltd.
//001977, "Aerohive Networks Inc.
//08EA44 Aerohive Networks Inc.
//EC3EF7 Juniper Networks
//0CF893 ARRIS Group, Inc.
//3CDFA9 ARRIS Group, Inc.
//8461A0 ARRIS Group, Inc.
//0015D1, "ARRIS Group, Inc.
//001DD0 ARRIS Group, Inc.
//001DD3 ARRIS Group, Inc.
//ACB313 ARRIS Group, Inc.
//38F23E, "Microsoft Mobile Oy
//E4F89C", "Intel Corporate
//6CA100 Intel Corporate
//2C4138 Hewlett Packard
//441EA1 Hewlett Packard
//78E7D1, "Hewlett Packard
//5C8FE0 ARRIS Group, Inc.
//90C792 ARRIS Group, Inc.
//BCCAB5 ARRIS Group, Inc.
//D039B3 ARRIS Group, Inc.
//000FCC ARRIS Group, Inc.
//0012F0, "Intel Corporate
//000740, "BUFFALO.INC
//0024A5 BUFFALO.INC
//CCE1D5", "BUFFALO.INC
//A402B9", "Intel Corporate
//DC5360 Intel Corporate
//001CC4 Hewlett Packard
//001E0B Hewlett Packard
//002264, "Hewlett Packard
//0025B3 Hewlett Packard
//000CF1 Intel Corporation
//784859, "Hewlett Packard
//58DC6D Exceptional Innovation, Inc.
//902155, "HTC Corporation
//643150, "Hewlett Packard
//7CB15D HUAWEI TECHNOLOGIES CO., LTD
//00265E, "Hon Hai Precision Ind. Co., Ltd.
//00242C Hon Hai Precision Ind.Co., Ltd.
//D8B377 HTC Corporation
//B0F1A3", "Fengfan (BeiJing) Technology Co., Ltd.
//3464A9 Hewlett Packard
//3863BB Hewlett Packard
//5CB901 Hewlett Packard
//DC4A3E", "Hewlett Packard
//B05ADA Hewlett Packard
//001083, "Hewlett Packard
//A0B3CC Hewlett Packard
//ECB1D7", "Hewlett Packard
//9CB654 Hewlett Packard
//6C3BE5 Hewlett Packard
//B0AA36", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//784B87 Murata Manufacturing Co., Ltd.
//E4CE02 WyreStorm Technologies Ltd
//40F308, "Murata Manufacturing Co., Ltd.
//808917, "TP-LINK TECHNOLOGIES CO., LTD.
//A09347 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//E8BBA8", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//942CB3 HUMAX Co., Ltd.
//002719, "TP-LINK TECHNOLOGIES CO., LTD.
//40169F, "TP-LINK TECHNOLOGIES CO., LTD.
//F4EC38 TP-LINK TECHNOLOGIES CO., LTD.
//140467, "SNK Technologies Co., Ltd.
//8030DC Texas Instruments
//A4D578", "Texas Instruments
//14CF92 TP-LINK TECHNOLOGIES CO., LTD.
//20DCE6 TP-LINK TECHNOLOGIES CO., LTD.
//14CC20 TP-LINK TECHNOLOGIES CO., LTD.
//246081, "razberi technologies
//A4D18C Apple, Inc.
//90F652, "TP-LINK TECHNOLOGIES CO., LTD.
//241EEB Apple, Inc.
//CC25EF Apple, Inc.
//88CF98 HUAWEI TECHNOLOGIES CO., LTD
//F80D43", "Hon Hai Precision Ind. Co., Ltd.
//38F889, "HUAWEI TECHNOLOGIES CO., LTD
//D07AB5", "HUAWEI TECHNOLOGIES CO., LTD
//0019C6 zte corporation
//001DD9 Hon Hai Precision Ind.Co., Ltd.
//00197D, "Hon Hai Precision Ind. Co., Ltd.
//7C4CA5 BSkyB Ltd
//CC4E24", "Brocade Communications Systems, Inc.
//00E052, "Brocade Communications Systems, Inc.
//0014A4 Hon Hai Precision Ind.Co., Ltd.
//78DD08 Hon Hai Precision Ind.Co., Ltd.
//9CD21E Hon Hai Precision Ind.Co., Ltd.
//B43052 HUAWEI TECHNOLOGIES CO., LTD
//80D09B HUAWEI TECHNOLOGIES CO., LTD
//1C8E5C HUAWEI TECHNOLOGIES CO., LTD
//84742A zte corporation
//9CD24B zte corporation
//C87B5B", "zte corporation
//0007D8, "Hitron Technologies. Inc
//C03E0F", "BSkyB Ltd
//904E2B HUAWEI TECHNOLOGIES CO., LTD
//2008ED, "HUAWEI TECHNOLOGIES CO., LTD
//00010F, "Brocade Communications Systems, Inc.
//080088, "Brocade Communications Systems, Inc.
//0034FE HUAWEI TECHNOLOGIES CO., LTD
//C85195", "HUAWEI TECHNOLOGIES CO., LTD
//40CBA8 HUAWEI TECHNOLOGIES CO., LTD
//D46E5C", "HUAWEI TECHNOLOGIES CO., LTD
//8853D4, "HUAWEI TECHNOLOGIES CO., LTD
//04C06F HUAWEI TECHNOLOGIES CO., LTD
//202BC1 HUAWEI TECHNOLOGIES CO., LTD
//54A51B HUAWEI TECHNOLOGIES CO., LTD
//002568, "HUAWEI TECHNOLOGIES CO., LTD
//781DBA HUAWEI TECHNOLOGIES CO., LTD
//00259E, "HUAWEI TECHNOLOGIES CO., LTD
//006B8E Shanghai Feixun Communication Co., Ltd.
//D46AA8 HUAWEI TECHNOLOGIES CO., LTD
//BCADAB", "Avaya Inc
//FCA841 Avaya Inc
//3CB15B Avaya Inc
//3475C7 Avaya Inc
//B0ADAA", "Avaya Inc
//B4475E Avaya Inc
//B8BC1B", "HUAWEI TECHNOLOGIES CO., LTD
//582AF7 HUAWEI TECHNOLOGIES CO., LTD
//24D921, "Avaya Inc
//848371, "Avaya Inc
//001B4F Avaya Inc
//4C8BEF HUAWEI TECHNOLOGIES CO., LTD
//5006AB Cisco Systems, Inc
//FC48EF", "HUAWEI TECHNOLOGIES CO., LTD
//707BE8 HUAWEI TECHNOLOGIES CO., LTD
//4C1FCC HUAWEI TECHNOLOGIES CO., LTD
//00906D, "Cisco Systems, Inc
//0090AB Cisco Systems, Inc
//005054, "Cisco Systems, Inc
//00500B Cisco Systems, Inc
//0003DD Comark Interactive Solutions
//005053, "Cisco Systems, Inc
//005050, "Cisco Systems, Inc
//D4B110", "HUAWEI TECHNOLOGIES CO., LTD
//E468A3", "HUAWEI TECHNOLOGIES CO., LTD
//247189, "Texas Instruments
//987BF3 Texas Instruments
//A0F6FD", "Texas Instruments
//D0B5C2 Texas Instruments
//78A504 Texas Instruments
//6CECEB Texas Instruments
//3400A3 HUAWEI TECHNOLOGIES CO., LTD
//00902B Cisco Systems, Inc
//00E08F, "Cisco Systems, Inc
//001868, "Cisco SPVTG
//887556, "Cisco Systems, Inc
//FC9947", "Cisco Systems, Inc
//6C2056 Cisco Systems, Inc
//0015F2, "ASUSTek COMPUTER INC.
//90E6BA ASUSTek COMPUTER INC.
//002618, "ASUSTek COMPUTER INC.
//F46D04 ASUSTek COMPUTER INC.
//00E018, "ASUSTek COMPUTER INC.
//000C6E ASUSTek COMPUTER INC.
//000EA6 ASUSTek COMPUTER INC.
//001D60, "ASUSTek COMPUTER INC.
//6C416A Cisco Systems, Inc
//ECE1A9", "Cisco Systems, Inc
//C067AF", "Cisco Systems, Inc
//ACF2C5", "Cisco Systems, Inc
//2401C7 Cisco Systems, Inc
//6886A7 Cisco Systems, Inc
//C0255C", "Cisco Systems, Inc
//3C0E23 Cisco Systems, Inc
//08CC68 Cisco Systems, Inc
//0C2724 Cisco Systems, Inc
//6CFA89 Cisco Systems, Inc
//00E0A3 Cisco Systems, Inc
//602AD0 Cisco SPVTG
//745E1C PIONEER CORPORATION
//046273, "Cisco Systems, Inc
//D8B190", "Cisco Systems, Inc
//80E86F, "Cisco Systems, Inc
//AC7E8A", "Cisco Systems, Inc
//1CE85D Cisco Systems, Inc
//A89D21", "Cisco Systems, Inc
//689CE2 Cisco Systems, Inc
//0023BE Cisco SPVTG
//185933, "Cisco SPVTG
//445829, "Cisco SPVTG
//F44E05 Cisco Systems, Inc
//881DFC Cisco Systems, Inc
//001011, "Cisco Systems, Inc
//00000C Cisco Systems, Inc
//28CFE9 Apple, Inc.
//00A040 Apple, Inc.
//A0F849 Cisco Systems, Inc
//3CD0F8 Apple, Inc.
//680927, "Apple, Inc.
//6CC26B Apple, Inc.
//44D884, "Apple, Inc.
//002608, "Apple, Inc.
//0026B0 Apple, Inc.
//0026BB Apple, Inc.
//D49A20 Apple, Inc.
//F81EDF Apple, Inc.
//C82A14 Apple, Inc.
//3C0754 Apple, Inc.
//A4B197 Apple, Inc.
//F0B479 Apple, Inc.
//1093E9, "Apple, Inc.
//442A60 Apple, Inc.
//A4D1D2 Apple, Inc.
//28CFDA Apple, Inc.
//003065, "Apple, Inc.
//001451, "Apple, Inc.
//001E52, "Apple, Inc.
//0021E9, "Apple, Inc.
//CC08E0 Apple, Inc.
//045453, "Apple, Inc.
//F4F951 Apple, Inc.
//C06394 Apple, Inc.
//18AF8F Apple, Inc.
//C8B5B7 Apple, Inc.
//90B21F Apple, Inc.
//30F7C5 Apple, Inc.
//40B395 Apple, Inc.
//44FB42 Apple, Inc.
//E88D28 Apple, Inc.
//949426, "Apple, Inc.
//207D74, "Apple, Inc.
//F4F15A Apple, Inc.
//C86F1D Apple, Inc.
//3090AB Apple, Inc.
//8C2DAA Apple, Inc.
//848506, "Apple, Inc.
//98FE94 Apple, Inc.
//D8004D Apple, Inc.
//64200C Apple, Inc.
//C8334B Apple, Inc.
//64E682, "Apple, Inc.
//B8E856 Apple, Inc.
//D89695 Apple, Inc.
//1499E2, "Apple, Inc.
//B418D1 Apple, Inc.
//9C207B Apple, Inc.
//B065BD Apple, Inc.
//542696, "Apple, Inc.
//64A3CB Apple, Inc.
//903C92 Apple, Inc.
//D81D72 Apple, Inc.
//341298, "Apple, Inc.
//70E72C Apple, Inc.
//70ECE4 Apple, Inc.
//68AE20 Apple, Inc.
//AC87A3 Apple, Inc.
//D8BB2C Apple, Inc.
//D04F7E Apple, Inc.
//2078F0, "Apple, Inc.
//E0ACCB Apple, Inc.
//A0999B Apple, Inc.
//24240E, "Apple, Inc.
//F0DBF8 Apple, Inc.
//48746E, "Apple, Inc.
//54AE27 Apple, Inc.
//FCE998 Apple, Inc.
//0CBC9F Apple, Inc.
//34363B Apple, Inc.
//D0A637 Apple, Inc.
//789F70, "Apple, Inc.
//9CF387 Apple, Inc.
//A85B78 Apple, Inc.
//C8F650 Apple, Inc.
//A88E24 Apple, Inc.
//6C4A39 BITA
//847D50, "Holley Metering Limited
//50D59C Thai Habel Industrial Co., Ltd.
//20896F, "Fiberhome Telecommunication Technologies Co., LTD
//3052CB Liteon Technology Corporation
//049645, "WUXI SKY CHIP INTERCONNECTION TECHNOLOGY CO., LTD.
//1CCDE5 Shanghai Wind Technologies Co., Ltd
//681401, "Hon Hai Precision Ind. Co., Ltd.
//50A9DE Smartcom - Bulgaria AD
//AC1FD7 Real Vision Technology Co., Ltd.
//88C242 Poynt Co.
//1402EC Hewlett Packard Enterprise
//E034E4 Feit Electric Company, Inc.
//34C9F0 LM Technologies Ltd
//68A828 HUAWEI TECHNOLOGIES CO., LTD
//CC20E8", "Apple, Inc.
//48BF74 Baicells Technologies Co., LTD
//6C9354 Yaojin Technology (Shenzhen) Co., LTD.
//DCDC07 TRP Systems BV
//3891D5, "Hangzhou H3C Technologies Co., Limited
//8CE2DA Circle Media Inc
//382187, "Midea Group Co., Ltd.
//78D6B2 Toshiba
//E8DED6 Intrising Networks, Inc.
//DC82F6 iPort
//70480F, "Apple, Inc.
//3CB72B PLUMgrid Inc
//489A42 Technomate Ltd
//20D160, "Private
//BC9C31", "HUAWEI TECHNOLOGIES CO., LTD
//D88B4C", "KingTing Tech.
//384C90 ARRIS Group, Inc.
//F0B0E7 Apple, Inc.
//381C23 Hilan Technology CO., LTD
//649A12 P2 Mobile Technologies Limited
//AC8995", "AzureWave Technology Inc.
//0469F8, "Apple, Inc.
//3029BE Shanghai MRDcom Co., Ltd
//20C3A4 RetailNext
//E4C2D1 HUAWEI TECHNOLOGIES CO., LTD
//D4F4BE", "Palo Alto Networks
//48B620 ROLI Ltd.
//D888CE RF Technology Pty Ltd
//307CB2 ANOV FRANCE
//847973, "Shanghai Baud Data Communication Co., Ltd.
//E8B4C8 Samsung Electronics Co., Ltd
//D087E2", "Samsung Electronics Co., Ltd
//F05B7B", "Samsung Electronics Co., Ltd
//B047BF", "Samsung Electronics Co., Ltd
//7C0BC6 Samsung Electronics Co., Ltd
//7CFE90 Mellanox Technologies, Inc.
//845B12 HUAWEI TECHNOLOGIES CO., LTD
//205531, "Samsung Electronics Co., Ltd
//10868C ARRIS Group, Inc.
//44FDA3 Everysight LTD.
//A8A795 Hon Hai Precision Ind.Co., Ltd.
//906FA9 NANJING PUTIAN TELECOMMUNICATIONS TECHNOLOGY CO., LTD.
//60FD56 WOORISYSTEMS CO., Ltd
//9870E8, "INNATECH SDN BHD
//44656A Mega Video Electronic(HK) Industry Co., Ltd
//78EB39 Instituto Nacional de Tecnología Industrial
//0C756C Anaren Microwave, Inc.
//D47BB0 ASKEY COMPUTER CORP
//F0224E Esan electronic co.
//CC5FBF Topwise 3G Communication Co., Ltd.
//C8F9C8 NewSharp Technology(SuZhou) Co, Ltd
//80C5E6 Microsoft Corporation
//10DF8B Shenzhen CareDear Communication Technology Co., Ltd
//C412F5", "D-Link International
//5C4527 Juniper Networks
//E02CB2", "Lenovo Mobile Communication (Wuhan) Company Limited
//606DC7 Hon Hai Precision Ind.Co., Ltd.
//68EDA4 Shenzhen Seavo Technology Co., Ltd
//2CC5D3 Ruckus Wireless
//F4573E", "Fiberhome Telecommunication Technologies Co., LTD
//D0431E", "Dell Inc.
//54CD10 Panasonic Mobile Communications Co., Ltd.
//408D5C GIGA-BYTE TECHNOLOGY CO., LTD.
//FCE1FB Array Networks
//E89120", "Motorola Mobility LLC, a Lenovo Company
//D4F9A1", "HUAWEI TECHNOLOGIES CO., LTD
//5440AD Samsung Electronics Co., Ltd
//A424DD", "Cambrionix Ltd
//145A83 Logi-D inc
//804E81, "Samsung Electronics Co., Ltd
//C09A71", "XIAMEN MEITU MOBILE TECHNOLOGY CO.LTD
//64167F, "Polycom
//340B40 MIOS ELETTRONICA SRL
//48066A Tempered Networks, Inc.
//BCF811 Xiamen DNAKE Technology Co., Ltd
//900A39 Wiio, Inc.
//D0C0BF Actions Microelectronics Co., Ltd
//E861BE", "Melec Inc.
//5870C6 Shanghai Xiaoyi Technology Co., Ltd.
//FC8F90 Samsung Electronics Co., Ltd
//74042B Lenovo Mobile Communication (Wuhan) Company Limited
//F87AEF", "Rosonix Technology, Inc.
//2028BC Visionscape Co,. Ltd.
//241C04 SHENZHEN JEHE TECHNOLOGY DEVELOPMENT CO., LTD.
//D05C7A Sartura d.o.o.
//BC5C4C ELECOM CO., LTD.
//887033, "Hangzhou Silan Microelectronic Inc
//DC56E6 Shenzhen Bococom Technology Co., LTD
//CC9635", "LVS Co., Ltd.
//4480EB Motorola Mobility LLC, a Lenovo Company
//402814, "RFI Engineering
//144146, "Honeywell (China) Co., LTD
//94F19E, "HUIZHOU MAORONG INTELLIGENT TECHNOLOGY CO., LTD
//B856BD", "ITT LLC
//40A5EF Shenzhen Four Seas Global Link Network Technology Co., Ltd.
//C4924C KEISOKUKI CENTER CO., LTD.
//749CE3 KodaCloud Canada, Inc
//D45556", "Fiber Mountain Inc.
//50502A Egardia
//749637, "Todaair Electronic Co., Ltd
//88E603, "Avotek corporation
//2CAD13 SHENZHEN ZHILU TECHNOLOGY CO., LTD
//78ACBF Igneous Systems
//C48E8F", "Hon Hai Precision Ind. Co., Ltd.
//C4366C LG Innotek
//54369B", "1Verge Internet Technology (Beijing) Co., Ltd.
//40D28A Nintendo Co., Ltd.
//4062B6 Tele system communication
//60128B CANON INC.
//84C3E8 Vaillant GmbH
//9CD35B Samsung Electronics Co., Ltd
//A89FBA", "Samsung Electronics Co., Ltd
//B88EC6", "Stateless Networks
//BCD165 Cisco SPVTG
//28E476, "Pi-Coral
//4CA515 Baikal Electronics JSC
//7C3CB6 Shenzhen Homecare Technology Co., Ltd.
//1C7D22 Fuji Xerox Co., Ltd.
//20C06D SHENZHEN SPACETEK TECHNOLOGY CO., LTD
//4886E8, "Microsoft Corporation
//74A34A ZIMI CORPORATION
//A86405", "nimbus 9, Inc
//30D587, "Samsung Electronics Co., Ltd
//6828F6, "Vubiq Networks, Inc.
//DC60A1 Teledyne DALSA Professional Imaging
//10A659 Mobile Create Co., Ltd.
//58856E, "QSC AG
//8C9109 Toyoshima Electric Technoeogy(Suzhou) Co., Ltd.
//54098D, "deister electronic GmbH
//D05BA8", "zte corporation
//E4BAD9", "360 Fly Inc.
//EC59E7 Microsoft Corporation
//C035C5", "Prosoft Systems LTD
//A0A3E2", "Actiontec Electronics, Inc
//74547D, "Cisco SPVTG
//00E6E8 Netzin Technology Corporation,.Ltd.
//50F43C Leeo Inc
//E887A3", "Loxley Public Company Limited
//10C67E SHENZHEN JUCHIN TECHNOLOGY CO., LTD
//08A5C8 Sunnovo International Limited
//F88479 Yaojin Technology(Shenzhen) Co., Ltd
//2C2997 Microsoft Corporation
//D46132", "Pro Concept Manufacturer Co., Ltd.
//54A050 ASUSTek COMPUTER INC.
//4C2C83 Zhejiang KaNong Network Technology Co., Ltd.
//908C09 Total Phase
//DC2F03", "Step forward Group Co., Ltd.
//380E7B V.P.S.Thai Co., Ltd
//2C3796 CYBO CO., LTD.
//587FB7 SONAR INDUSTRIAL CO., LTD.
//08EB29 Jiangsu Huitong Group Co., Ltd.
//409B0D Shenzhen Yourf Kwan Industrial Co., Ltd
//D8CB8A", "Micro-Star INTL CO., LTD.
//70FC8C OneAccess SA
//58108C Intelbras
//4C7403 BQ
//8C5D60 UCI Corporation Co., Ltd.
//BC6B4D Nokia
//C8D019 Shanghai Tigercel Communication Technology Co., Ltd
//902181, "Shanghai Huaqin Telecom Technology Co., Ltd
//849681, "Cathay Communication Co., Ltd
//2CA30E POWER DRAGON DEVELOPMENT LIMITED
//8486F3, "Greenvity Communications
//1C5216 DONGGUAN HELE ELECTRONICS CO., LTD
//6099D1, "Vuzix / Lenovo
//B04515", "mira fitness, LLC.
//14488B Shenzhen Doov Technology Co., Ltd
//2012D5, "Scientech Materials Corporation
//6C6EFE Core Logic Inc.
//3808FD Silca Spa
//784561, "CyberTAN Technology Inc.
//94CE31 CTS Limited
//80F8EB RayTight
//D437D7 zte corporation
//2C010B NASCENT Technology, LLC - RemKon
//04DEDB Rockport Networks Inc
//1C4840 IMS Messsysteme GmbH
//6050C1 Kinetek Sports
//2C1A31 Electronics Company Limited
//90B686 Murata Manufacturing Co., Ltd.
//ECD9D1 Shenzhen TG-NET Botone Technology Co., Ltd.
//6C0273 Shenzhen Jin Yun Video Equipment Co., Ltd.
//54DF00 Ulterius Technologies, LLC
//20ED74, "Ability enterprise co., Ltd.
//A056B2 Harman/Becker Automotive Systems GmbH
//44666E, "IP-LINE
//244F1D, "iRule LLC
//94AEE3 Belden Hirschmann Industries (Suzhou) Ltd.
//5CB6CC NovaComm Technologies Inc.
//705B2E M2Communication Inc.
//5C1515 ADVAN
//D059E4 Samsung Electronics Co., Ltd
//14A364 Samsung Electronics Co., Ltd
//B40AC6", "DEXON Systems Ltd.
//D866EE BOXIN COMMUNICATION CO., LTD.
//2829CC Corsa Technology Incorporated
//184A6F Alcatel-Lucent Shanghai Bell Co., Ltd
//10C37B ASUSTek COMPUTER INC.
//E85D6B Luminate Wireless
//B40B44", "Smartisan Technology Co., Ltd.
//3431C4 AVM GmbH
//50FEF2 Sify Technologies Ltd
//34C5D0 Hagleitner Hygiene International GmbH
//A012DB", "TABUCHI ELECTRIC CO., LTD
//481A84 Pointer Telocation Ltd
//DC663A Apacer Technology Inc.
//08DF1F Bose Corporation
//581F67, "Open-m technology limited
//4826E8, "Tek-Air Systems, Inc.
//D05AF1 Shenzhen Pulier Tech CO., Ltd
//FCE186", "A3M Co., LTD
//54EF92, "Shenzhen Elink Technology Co., LTD
//ECE512", "tado GmbH
//30918F, "Technicolor
//5CF4AB Zyxel Communications Corporation
//08B2A3 Cynny Italia S.r.L.
//70305D, "Ubiquoss Inc
//488244, "Life Fitness / Div.of Brunswick
//C83168 eZEX corporation
//40B3CD Chiyoda Electronics Co., Ltd.
//24336C Private
//B87CF2 Aerohive Networks Inc.
//202564, "PEGATRON CORPORATION
//C8D590 FLIGHT DATA SYSTEMS
//7CFF62 Huizhou Super Electron Technology Co., Ltd.
//84B59C Juniper Networks
//C09D26", "Topicon HK Lmd.
//442938, "NietZsche enterprise Co.Ltd.
//A0DA92 Nanjing Glarun Atten Technology Co. Ltd.
//ECF72B HD DIGITAL TECH CO., LTD.
//4CF45B Blue Clover Devices
//B06971 DEI Sales, Inc.
//1889DF CerebrEX Inc.
//54C80F TP-LINK TECHNOLOGIES CO., LTD.
//E4D332 TP-LINK TECHNOLOGIES CO., LTD.
//0C2026 noax Technologies AG
//283B96 Cool Control LTD
//648D9E, "IVT Electronic Co., Ltd
//CC95D7", "Vizio, Inc
//FC09F6", "GUANGDONG TONZE ELECTRIC CO., LTD
//BCF61C", "Geomodeling Wuxi Technology Co. Ltd.
//FC923B Nokia Corporation
//E03F49", "ASUSTek COMPUTER INC.
//88A73C Ragentek Technology Group
//88D962, "Canopus Systems US LLC
//D09C30 Foster Electric Company, Limited
//949F3F, "Optek Digital Technology company limited
//E817FC", "Fujitsu Cloud Technologies Limited
//78FEE2 Shanghai Diveo Technology Co., Ltd
//086DF2 Shenzhen MIMOWAVE Technology Co., Ltd
//687848, "Westunitis Co., Ltd.
//48D0CF Universal Electronics, Inc.
//9C3EAA EnvyLogic Co., Ltd.
//1CFCBB Realfiction ApS
//F8F005", "Newport Media Inc.
//28656B Keystone Microtech Corporation
//CC9F35 Transbit Sp.z o.o.
//DCC793 Nokia Corporation
//444891, "HDMI Licensing, LLC
//5C254C Avire Global Pte Ltd
//D42F23", "Akenori PTE Ltd
//98C0EB Global Regency Ltd
//F03FF8 R L Drake
//B0C554 D-Link International
//48EE86 UTStarcom (China) Co., Ltd
//888914, "All Components Incorporated
//F0321A", "Mita-Teknik A/S
//A881F1", "BMEYE B.V.
//C4E984 TP-LINK TECHNOLOGIES CO., LTD.
//D069D0 Verto Medical Solutions, LLC
//FC1349", "Global Apps Corp.
//848433, "Paradox Engineering SA
//44C306 SIFROM Inc.
//602103, "I4VINE, INC
//FC07A0", "LRE Medical GmbH
//1CEEE8 Ilshin Elecom
//9031CD Onyx Healthcare Inc.
//E48184 Nokia
//14C089 DUNE HD LTD
//F4B6E5 TerraSem Co., Ltd
//60FFDD C.E.ELECTRONICS, INC
//24050F, "MTN Electronic Co.Ltd
//AC2DA3", "TXTR GmbH
//889CA6 BTB Korea INC
//90837A General Electric Water & Process Technologies
//80BAE6 Neets
//F8A2B4 RHEWA-WAAGENFABRIK August Freudewald GmbH &amp; Co.KG
//E056F4", "AxesNetwork Solutions inc.
//84569C Coho Data, Inc.,
//78AE0C Far South Networks
//B024F3 Progeny Systems
//0C54A5 PEGATRON CORPORATION
//8C4DB9 Unmonday Ltd
//78CA5E ELNO
//2C5A05 Nokia Corporation
//D481CA", "iDevices, LLC
//D858D7", "CZ.NIC, z.s.p.o.
//B0D7C5 Logipix Ltd
//A43A69", "Vers Inc
//9C44A6 SwiftTest, Inc.
//4CD9C4 Magneti Marelli Automotive Electronics(Guangzhou) Co.Ltd
//50E0C7 TurControlSystme AG
//B4827B", "AKG Acoustics GmbH
//DC5E36", "Paterson Technology
//DCAD9E GreenPriz
//B8DF6B SpotCam Co., Ltd.
//9C8888 Simac Techniek NV
//10B26B, "base Co.,Ltd.
//4CF02E Vifa Denmark A/S
//288A1C Juniper Networks
//DCCEBC", "Shenzhen JSR Technology Co., Ltd.
//18C8E7 Shenzhen Hualistone Technology Co., Ltd
//A03B1B", "Inspire Tech
//7CCD3C Guangzhou Juzing Technology Co., Ltd
//9843DA INTERTECH
//08CA45 Toyou Feiji Electronics Co., Ltd.
//3CCA87 Iders Incorporated
//7C6AB3 IBC TECHNOLOGIES INC.
//181BEB Actiontec Electronics, Inc
//84A783 Alcatel Lucent
//041A04 WaveIP
//68764F, "Sony Mobile Communications Inc
//34A5E1 Sensorist ApS
//8079AE ShanDong Tecsunrise Co., Ltd
//7CBD06 AE REFUsol
//94BA56 Shenzhen Coship Electronics Co., Ltd.
//38DBBB Sunbow Telecom Co., Ltd.
//448A5B Micro-Star INT'L CO., LTD.
//6C4B7F Vossloh-Schwabe Deutschland GmbH
//908C44 H.K ZONGMU TECHNOLOGY CO., LTD.
//688AB5 EDP Servicos
//2493CA Voxtronic Austria
//0CCB8D ASCO Numatics GmbH
//907990, "Benchmark Electronics Romania SRL
//740EDB Optowiz Co., Ltd
//6C8366 Nanjing SAC Power Grid Automation Co., Ltd.
//F83D4E Softlink Automation System Co., Ltd
//74D435, "GIGA-BYTE TECHNOLOGY CO., LTD.
//78D99F, "NuCom HK Ltd.
//142BD2 Armtel Ltd.
//9CA10A SCLE SFE
//88789C Game Technologies SA
//A4895B ARK INFOSOLUTIONS PVT LTD
//D09D0A", "LINKCOM
//EC219F", "VidaBox LLC
//A8CCC5 Saab AB (publ)
//58468F, "Koncar Electronics and Informatics
//985D46, "PeopleNet Communication
//F89FB8 YAZAKI Energy System Corporation
//F0F5AE", "Adaptrum Inc.
//FC3FAB Henan Lanxin Technology Co., Ltd
//988E4A NOXUS(BEIJING) TECHNOLOGY CO., LTD
//EC2AF0", "Ypsomed AG
//F854AF ECI Telecom Ltd.
//54BEF7 PEGATRON CORPORATION
//50B888 wi2be Tecnologia S/A
//7C8306 Glen Dimplex Nordic as
//442AFF E3 Technology, Inc.
//140D4F, "Flextronics International
//446755, "Orbit Irrigation
//E0FAEC Platan sp.z o.o.sp.k.
//7CE56B ESEN Optoelectronics Technology Co., Ltd.
//D44C9C Shenzhen YOOBAO Technology Co.Ltd
//20CEC4 Peraso Technologies
//CC4703", "Intercon Systems Co., Ltd.
//ACCA8E ODA Technologies
//088E4F, "SF Software Solutions
//540536, "Vivago Oy
//6C90B1 SanLogic Inc
//CC7B35", "zte corporation
//04D437, "ZNV
//CCF407", "EUKREA ELECTROMATIQUE SARL
//DC1792", "Captivate Network
//28A241 exlar corp
//509871, "Inventum Technologies Private Limited
//048C03 ThinPAD Technology (Shenzhen) CO., LTD
//88462A Telechips Inc.
//C80258 ITW GSE ApS
//30786B TIANJIN Golden Pentagon Electronics Co., Ltd.
//20DF3F Nanjing SAC Power Grid Automation Co., Ltd.
//F8516D Denwa Technology Corp.
//444A65 Silverflare Ltd.
//744BE9 EXPLORER HYPERTECH CO., LTD
//FC6018", "Zhejiang Kangtai Electric Co., Ltd.
//F42012 Cuciniale GmbH
//98B039 Nokia
//B830A8 Road-Track Telematics Development
//4CD637 Qsono Electronics Co., Ltd
//9436E0, "Sichuan Bihong Broadcast &amp; Television New Technologies Co., Ltd
//5422F8, "zte corporation
//486E73, "Pica8, Inc.
//6405BE NEW LIGHT LED
//646EEA Iskratel d.o.o.
//D0737F Mini-Circuits
//E8BB3D", "Sino Prime-Tech Limited
//28285D, "Zyxel Communications Corporation
//0CF019 Malgn Technology Co., Ltd.
//949FB4 ChengDu JiaFaAnTai Technology Co., Ltd
//406826, "Thales UK Limited
//F82BC8", "Jiangsu Switter Co., Ltd
//60C397", "2Wire Inc
//E07F88 EVIDENCE Network SIA
//1C7CC7 Coriant GmbH
//341B22 Grandbeing Technology Co., Ltd
//40560C In Home Displays Ltd
//58E02C Micro Technic A/S
//78B3CE Elo touch solutions
//88142B Protonic Holland
//A4FCCE", "Security Expert Ltd.
//1C08C1 Lg Innotek
//34A68C Shine Profit Development Limited
//341A4C SHENZHEN WEIBU ELECTRONICS CO., LTD.
//0488E2, "Beats Electronics LLC
//A47ACF", "VIBICOM COMMUNICATIONS INC.
//BC261D HONG KONG TECON TECHNOLOGY
//E8CE06", "SkyHawke Technologies, LLC.
//C8F386 Shenzhen Xiaoniao Technology Co., Ltd
//E0DCA0", "Siemens Industrial Automation Products Ltd Chengdu
//842F75, "Innokas Group
//CC3C3F SA.S.S.Datentechnik AG
//2C69BA RF Controls, LLC
//D4BF7F", "UPVEL
//2C72C3 Soundmatters
//C44838 Satcom Direct, Inc.
//C8DDC9 Lenovo Mobile Communication Technology Ltd.
//6C8686 Technonia
//D4AC4E BODi rS, LLC
//204C6D Hugo Brennenstuhl Gmbh & Co.KG.
//40C4D6 ChongQing Camyu Technology Development Co., Ltd.
//A8294C Precision Optical Transceivers, Inc.
//70C6AC Bosch Automotive Aftermarket
//7C0507 PEGATRON CORPORATION
//880905, "MTMCommunications
//30D46A Autosales Incorporated
//282CB2 TP-LINK TECHNOLOGIES CO., LTD.
//64E599, "EFM Networks
//308999, "Guangdong East Power Co.,
//C89346 MXCHIP Company Limited
//F4B381 WindowMaster A/S
//74F102, "Beijing HCHCOM Technology Co., Ltd
//A0861D", "Chengdu Fuhuaxin Technology co., Ltd
//508D6F, "CHAHOO Limited
//E8DE27 TP-LINK TECHNOLOGIES CO., LTD.
//94ACCA trivum technologies GmbH
//9C9726 Technicolor
//908260, "IEEE 1904.1 Working Group
//D4EE07 HIWIFI Co., Ltd.
//FCAD0F QTS NETWORKS
//984C04 Zhangzhou Keneng Electrical Equipment Co Ltd
//A4E991", "SISTEMAS AUDIOVISUALES ITELSIS S.L.
//3C86A8 Sangshin elecom.co,, LTD
//84F493, "OMS spol. s.r.o.
//BCD177 TP-LINK TECHNOLOGIES CO., LTD.
//ACDBDA Shenzhen Geniatech Inc, Ltd
//D42751", "Infopia Co., Ltd
//103DEA HFC Technology (Beijing) Ltd. Co.
//F05DC8 Duracell Powermat
//CC5D57", "Information System Research Institute, Inc.
//64C667 Barnes&Noble
//F0F260", "Mobitec AB
//044CEF Fujian Sanao Technology Co., Ltd
//4C804F Armstrong Monitoring Corp
//7CD762 Freestyle Technology Pty Ltd
//901D27, "zte corporation
//9C3178 Foshan Huadian Intelligent Communications Teachnologies Co., Ltd
//B0C95B", "Beijing Symtech CO., LTD
//4CCA53 Skyera, Inc.
//90FF79 Metro Ethernet Forum
//B01408 LIGHTSPEED INTERNATIONAL CO.
//081DFB Shanghai Mexon Communication Technology Co., Ltd
//983F9F, "China SSJ (Suzhou) Network Technology Inc.
//B838CA Kyokko Tsushin System CO., LTD
//C44EAC", "Shenzhen Shiningworth Technology Co., Ltd.
//A80180 IMAGO Technologies GmbH
//0C5521 Axiros GmbH
//68A40E BSH Hausgeräte GmbH
//F4C6D7 blackned GmbH
//D4CA6E", "u-blox AG
//5C43D2 HAZEMEYER
//D809C3 Cercacor Labs
//E0C2B7", "Masimo Corporation
//A01917 Bertel S.p.a.
//68B8D9 Act KDE, Inc.
//90CC24 Synaptics, Inc
//2CE871 Alert Metalguard ApS
//F87B62 FASTWEL INTERNATIONAL CO., LTD.Taiwan Branch
//40270B Mobileeco Co., Ltd
//74FE48 ADVANTECH CO., LTD.
//80B95C ELFTECH Co., Ltd.
//38B5BD E.G.O.Elektro-Ger
//20918A PROFALUX
//E4EEFD MR&D Manufacturing
//105CBF DuroByte Inc
//A46E79", "DFT System Co.Ltd
//C88A83", "Dongguan HuaHong Electronics Co., Ltd
//8CC5E1 ShenZhen Konka Telecommunication Technology Co., Ltd
//64A341 Wonderlan (Beijing) Technology Co., Ltd.
//7898FD Q9 Networks Inc.
//D063B4 SolidRun Ltd.
//9C541C Shenzhen My-power Technology Co., Ltd
//8C3330 EmFirst Co., Ltd.
//087BAA SVYAZKOMPLEKTSERVICE, LLC
//24F2DD Radiant Zemax LLC
//20B5C6 Mimosa Networks
//E4E409", "LEIFHEIT AG
//B877C3 METER Group
//004D32, "Andon Health Co., Ltd.
//FCA9B0 MIARTECH (SHANGHAI), INC.
//94DE80 GIGA-BYTE TECHNOLOGY CO., LTD.
//2C441B Spectrum Medical Limited
//EC4993 Qihan Technology Co., Ltd
//B0ACFA", "FUJITSU LIMITED
//8CE081 zte corporation
//5865E6, "INFOMARK CO., LTD.
//A44E2D Adaptive Wireless Solutions, LLC
//0CCDFB EDIC Systems Inc.
//9C8D1A INTEG process group inc
//480362, "DESAY ELECTRONICS(HUIZHOU) CO., LTD
//18673F, "Hanover Displays Limited
//7C0A50 J-MEX Inc.
//5011EB SilverNet Ltd
//54DF63 Intrakey technologies GmbH
//40F2E9, "IBM
//744D79, "Arrive Systems Inc.
//9C0473 Tecmobile (International) Ltd.
//B4DFFA Litemax Electronics Inc.
//681CA2 Rosewill Inc.
//604616, "XIAMEN VANN INTELLIGENT CO., LTD
//E45614", "Suttle Apparatus
//3C83B5 Advance Vision Electronics Co.Ltd.
//28A192 GERP Solution
//106FEF Ad-Sol Nissin Corp
//6C40C6 Nimbus Data, Inc.
//1048B1 Beijing Duokan Technology Limited
//D493A0", "Fidelix Oy
//08EBED World Elite Technology Co., LTD
//DC9FA4", "Nokia Corporation
//44C39B OOO RUBEZH NPO
//C44567 SAMBON PRECISON and ELECTRONICS
//48F8B3 Cisco-Linksys, LLC
//D8D27C", "JEMA ENERGY, SA
//B01203", "Dynamics Hong Kong Limited
//9886B1 Flyaudio corporation (China)
//7093F8, "Space Monkey, Inc.
//28B3AB Genmark Automation
//C4E7BE", "SCSpro Co., Ltd
//58874C LITE-ON CLEAN ENERGY TECHNOLOGY CORP.
//2891D0, "Stage Tec Entwicklungsgesellschaft für professionelle Audiotechnik mbH
//C0BD42", "ZPA Smart Energy a.s.
//FC52CE Control iD
//5C4A26 Enguity Technology Corp
//60F2EF, "VisionVera International Co., Ltd.
//C03F2A Biscotti, Inc.
//381C4A SIMCom Wireless Solutions Co., Ltd.
//D8C691 Hichan Technology Corp.
//E43FA2 Wuxi DSP Technologies Inc.
//F4B72A TIME INTERCONNECT LTD
//749975, "IBM Corporation
//2C625A Finest Security Systems Co., Ltd
//2074CF Shenzhen Voxtech Co., Ltd
//E0F5CA", "CHENG UEI PRECISION INDUSTRY CO., LTD.
//A8EF26 Tritonwave
//20DC93 Cheetah Hi-Tech, Inc.
//4423AA Farmage Co., Ltd.
//7CFE28 Salutron Inc.
//E8102E Really Simple Software, Inc
//0C565C HyBroad Vision (Hong Kong) Technology Co Ltd
//8C6AE4 Viogem Limited
//543968, "Edgewater Networks Inc
//440CFD NetMan Co., Ltd.
//8CD3A2 VisSim AS
//D82DE1", "Tricascade Inc.
//14358B Mediabridge Products, LLC.
//00F403, "Orbis Systems Oy
//547398, "Toyo Electronics Corporation
//E0A30F", "Pevco
//88DC96 SENAO Networks, Inc.
//20443A Schneider Electric Asia Pacific Ltd
//C4393A SMC Networks Inc
//5C2479 Baltech AG
//EC9327", "MEMMERT GmbH + Co.KG
//A0EF84", "Seine Image Int'l Co., Ltd
//64517E, "LONG BEN (DONGGUAN) ELECTRONIC TECHNOLOGY CO., LTD.
//D43D7E Micro-Star Int'l Co, Ltd
//ACD9D6 tci GmbH
//48282F, "zte corporation
//60CBFB AirScape Inc.
//7C160D Saia-Burgess Controls AG
//A497BB", "Hitachi Industrial Equipment Systems Co., Ltd
//4C5427 Linepro Sp.z o.o.
//80D18B Hangzhou I'converge Technology Co.,Ltd
//4088E0, "Beijing Ereneben Information Technology Limited Shenzhen Branch
//E85484", "NEO Information Systems Co., Ltd.
//74AE76 iNovo Broadband, Inc.
//EC1A59 Belkin International Inc.
//881036, "Panodic(ShenZhen) Electronics Limted
//68B6FC Hitron Technologies.Inc
//ECA29B", "Kemppi Oy
//04CE14 Wilocity LTD.
//C4BA99 I+ME Actia Informatik und Mikro-Elektronik GmbH
//A4934C Cisco Systems, Inc
//D0D212", "K2NET Co., Ltd.
//B0435D NuLEDs, Inc.
//0808EA AMSC
//E8D483 ULTIMATE Europe Transportation Equipment GmbH
//1C8464 FORMOSA WIRELESS COMMUNICATION CORP.
//346E8A Ecosense
//64F242, "Gerdes Aktiengesellschaft
//60F281, "TRANWO TECHNOLOGY CO., LTD.
//942197, "Stalmart Technology Limited
//A0C3DE", "Triton Electronic Systems Ltd.
//D0699E LUMINEX Lighting Control Equipment
//0CC0C0 MAGNETI MARELLI SISTEMAS ELECTRONICOS MEXICO
//08379C Topaz Co.LTD.
//D80DE3 FXI TECHNOLOGIES AS
//B0D2F5 Vello Systems, Inc.
//709A0B Italian Institute of Technology
//F0FDA0", "Acurix Networks Pty Ltd
//B45570 Borea
//100D2F, "Online Security Pty.Ltd.
//142DF5 Amphitech
//5057A8 Cisco Systems, Inc
//00DEFB Cisco Systems, Inc
//3CA315 Bless Information & Communications Co., Ltd
//F83094", "Alcatel-Lucent Telecom Limited
//10A932 Beijing Cyber Cloud Technology Co. , Ltd.
//34FC6F ALCEA
//C0B357 Yoshiki Electronics Industry Ltd.
//3C98BF Quest Controls, Inc.
//D0AEEC Alpha Networks Inc.
//E81324 GuangZhou Bonsoninfo System CO., LTD
//E477D4", "Minrray Industry Co., Ltd
//38E08E Mitsubishi Electric Corporation
//E4C806 Ceiec Electric Technology Inc.
//E0F9BE Cloudena Corp.
//B88F14 Analytica GmbH
//7C94B2 Philips Healthcare PCCI
//442B03 Cisco Systems, Inc
//F473CA", "Conversion Sound Inc.
//F8F7FF SYN-TECH SYSTEMS INC
//A81758", "Elektronik System i Umeå AB
//882012, "LMI Technologies
//60E956, "Ayla Networks, Inc
//EC1120", "FloDesign Wind Turbine Corporation
//F897CF DAESHIN-INFORMATION TECHNOLOGY CO., LTD.
//08B4CF Abicom International
//C495A2", "SHENZHEN WEIJIU INDUSTRY AND TRADE DEVELOPMENT CO., LTD
//8C6878 Nortek-AS
//202598, "Teleview
//38F8B7 V2COM PARTICIPACOES S.A.
//F8D462 Pumatronix Equipamentos Eletronicos Ltda.
//A0DC04 Becker-Antriebe GmbH
//40605A Hawkeye Tech Co. Ltd
//A04CC1", "Helixtech Corp.
//34A7BA Fischer International Systems Corporation
//0463E0, "Nome Oy
//B49EE6 SHENZHEN TECHNOLOGY CO LTD
//BC4B79", "SensingTek
//A49005", "CHINA GREATWALL COMPUTER SHENZHEN CO., LTD
//C40ACB", "Cisco Systems, Inc
//E86D6E", "voestalpine SIGNALING Fareham Ltd.
//681605, "Systems And Electronic Development FZCO
//D4A02A", "Cisco Systems, Inc
//3C4E47 Etronic A/S
//F48771", "Infoblox
//5453ED, "Sony Corporation
//00376D, "Murata Manufacturing Co., Ltd.
//50008C Hong Kong Telecommunications (HKT) Limited
//902B34 GIGA-BYTE TECHNOLOGY CO., LTD.
//88C36E Beijing Ereneben lnformation Technology Limited
//4C9E80 KYOKKO ELECTRIC Co., Ltd.
//5CEB4E R. STAHL HMI Systems GmbH
//34AA99 Nokia
//645563, "Intelight Inc.
//943AF0 Nokia Corporation
//645422, "Equinox Payments
//080D84, "GECO, Inc.
//88E712, "Whirlpool Corporation
//D412BB Quadrant Components Inc. Ltd
//24B88C Crenus Co., Ltd.
//BCFE8C Altronic, LLC
//649EF3, "Cisco Systems, Inc
//24BBC1 Absolute Analysis
//9CCAD9 Nokia Corporation
//046D42, "Bryston Ltd.
//D8E743 Wush, Inc
//644D70, "dSPACE GmbH
//DCC101 SOLiD Technologies, Inc.
//3CE624 LG Display
//D8F0F2", "Zeebo Inc
//806007, "RIM
//38A851 Moog, Ing
//94E0D0, "HealthStream Taiwan Inc.
//D8052E Skyviia Corporation
//80946C TOKYO RADAR CORPORATION
//D0CF5E Energy Micro AS
//1803FA IBT Interfaces
//306E5C Validus Technologies
//C894D2", "Jiangsu Datang", "Electronic Products Co., Ltd
//C8A620", "Nebula, Inc
//EC6264", "Global411 Internet Services, LLC
//00F051, "KWB Gmbh
//FC946C UBIVELOX
//407B1B Mettle Networks Inc.
//40D559, "MICRO S.E.R.I.
//306CBE Skymotion Technology (HK) Limited
//183825, "Wuhan Lingjiu High-tech Co., Ltd.
//7C4B78 Red Sun Synthesis Pte Ltd
//64A0E7 Cisco Systems, Inc
//DCF858", "Lorent Networks, Inc.
//940B2D NetView Technologies(Shenzhen) Co., Ltd
//803F5D, "Winstars Technology Ltd
//40BF17 Digistar Telecom.SA
//780738, "Z.U.K.Elzab S.A.
//2037BC Kuipers Electronic Engineering BV
//94319B Alphatronics BV
//00E175, "AK-Systems Ltd
//CC501C KVH Industries, Inc.
//04D783, "Y&H E&C Co., LTD.
//54A9D4 Minibar Systems
//B0E50E", "NRG SYSTEMS INC
//64808B VG Controls, Inc.
//48C1AC PLANTRONICS, INC.
//98588A SYSGRATION Ltd.
//2437EF, "EMC Electronic Media Communication SA
//28B0CC Xenya d.o.o.
//205B5E Shenzhen Wonhe Technology Co., Ltd
//C058A7", "Pico Systems Co., Ltd.
//EC3F05 Institute 706, The Second Academy China Aerospace Science & Industry Corp
//489BE2 SCI Innovations Ltd
//80FFA8 UNIDIS
//E435FB Sabre Technology (Hull) Ltd
//C83B45 JRI
//E878A1 BEOVIEW INTERCOM DOO
//CCEF48 Cisco Systems, Inc
//F04B6A", "Scientific Production Association Siberian Arsenal, Ltd.
//64AE0C Cisco Systems, Inc
//E8DA96", "Zhuhai Tianrui Electrical Power Tech.Co., Ltd.
//B4D8DE iota Computing, Inc.
//C8903E Pakton Technologies
//54CDA7 Fujian Shenzhou Electronic Co., Ltd
//886B76 CHINA HOPEFUL GROUP HOPEFUL ELECTRIC CO., LTD
//78F7D0, "Silverbrook Research
//207600, "Actiontec Electronics, Inc
//F013C3", "SHENZHEN FENDA TECHNOLOGY CO., LTD
//04A82A Nokia Corporation
//E44E18", "Gardasoft VisionLimited
//2046A1 VECOW Co., Ltd
//FC01CD", "FUNDACION TEKNIKER
//9C8BF1 The Warehouse Limited
//DC2E6A HCT. Co., Ltd.
//148A70 ADS GmbH
//00B338 Kontron Asia Pacific Design Sdn. Bhd
//84248D, "Zebra Technologies Inc
//FCE892", "Hangzhou Lancable Technology Co., Ltd
//1071F9, "Cloud Telecomputers, LLC
//B8621F", "Cisco Systems, Inc
//F0022B", "Chrontel
//D453AF", "VIGO System S.A.
//18AD4D Polostar Technology Corporation
//94C6EB NOVA electronics, Inc.
//843F4E, "Tri-Tech Manufacturing, Inc.
//C83232 Hunting Innova
//549478, "Silvershore Technology Partners
//A06E50", "Nanotek Elektronik Sistemler Ltd. Sti.
//4C774F Embedded Wireless Labs
//D0C282 Cisco Systems, Inc
//147DB3 JOA TELECOM.CO., LTD
//ECBD09", "FUSION Electronics Ltd
//944696, "BaudTec Corporation
//54847B Digital Devices GmbH
//3C2763 SLE quality engineering GmbH & Co.KG
//B0F1BC", "Dhemax Ingenieros Ltda
//B8288B", "Parker Hannifin Manufacturing (UK) Ltd
//90D11B Palomar Medical Technologies
//34A55D TECHNOSOFT INTERNATIONAL SRL
//802E14, "azeti Networks AG
//D4C1FC", "Nokia Corporation
//34BCA6 Beijing Ding Qing Technology, Ltd.
//5835D9, "Cisco Systems, Inc
//64D912, "Solidica, Inc.
//C47B2F Beijing JoinHope Image Technology Ltd.
//508ACB SHENZHEN MAXMADE TECHNOLOGY CO., LTD.
//3CD16E Telepower Communication Co., Ltd
//FC2E2D", "Lorom Industrial Co.LTD.
//40040C A&T
//DC3C84", "Ticom Geomatics, Inc.
//D0131E Sunrex Technology Corp
//00FC70 Intrepid Control Systems, Inc.
//703AD8 Shenzhen Afoundry Electronic Co., Ltd
//704AAE Xstream Flow (Pty) Ltd
//40B3FC Logital Co.Limited
//A4134E", "Luxul
//B09928", "FUJITSU LIMITED
//04E1C8 IMS Soluções em Energia Ltda.
//948FEE Verizon Telematics
//50D6D7, "Takahata Precision
//88F077, "Cisco Systems, Inc
//587521, "CJSC RTSoft
//C40F09 Hermes electronic GmbH
//48F47D, "TechVision Holding", "Internation Limited
//F081AF IRZ AUTOMATION TECHNOLOGIES LTD
//701404, "Limited Liability Company
//B435F7", "Zhejiang Pearmain Electronics Co.ltd.
//9866EA Industrial Control Communications, Inc.
//983000, "Beijing KEMACOM Technologies Co., Ltd.
//90CF15 Nokia Corporation
//948B03 EAGET Innovation and Technology Co., Ltd.
//2C0033 EControls, LLC
//AC199F", "SUNGROW POWER SUPPLY CO., LTD.
//7C4A82 Portsmith LLC
//94E848, "FYLDE MICRO LTD
//AC5E8C", "Utillink
//18E288, "STT Condigi
//1C35F1 NEW Lift Neue Elektronische Wege Steuerungsbau GmbH
//803457, "OT Systems Limited
//5C0CBB CELIZION Inc.
//C4242E Galvanic Applied Sciences Inc
//24C86E Chaney Instrument Co.
//F0AE51 Xi3 Corp
//B80B9D", "ROPEX Industrie-Elektronik GmbH
//306118, "Paradom Inc.
//4C7367 Genius Bytes Software Solutions GmbH
//90EA60 SPI Lasers Ltd
//5070E5, "He Shan World Fair Electronics Technology Limited
//802275, "Beijing Beny Wave Technology Co Ltd
//CCF3A5 Chi Mei Communication Systems, Inc
//14A9E3 MST CORPORATION
//F8EA0A", "Dipl.-Math.Michael Rauch
//3831AC WEG
//584C19 Chongqing Guohong Technology Development Company Limited
//6469BC Hytera Communications Co ., ltd
//B4F323", "PETATEL INC.
//285132, "Shenzhen Prayfly Technology Co., Ltd
//E42FF6", "Unicore communication Inc.
//84D9C8 Unipattern Co.,
//94AAB8 Joview(Beijing) Technology Co.Ltd.
//28F358, "2C - Trifonov & Co
//14C21D Sabtech Industries
//C88439", "Sunrise Technologies
//F0BF97 Sony Corporation
//C44AD0", "FIREFLIES SYSTEMS
//EC7D9D CPI
//C81E8E ADV Security (S) Pte Ltd
//A88792", "Broadband Antenna Tracking Systems
//14F0C5 Xtremio Ltd.
//E8C229 H-Displays (MSC) Bhd
//3CA72B MRV Communications (Networks) LTD
//301A28 Mako Networks Ltd
//04E662, "Acroname Inc.
//F87B8C Amped Wireless
//283410, "Enigma Diagnostics Limited
//0CE82F Bonfiglioli Vectron GmbH
//40F4EC Cisco Systems, Inc
//14B73D ARCHEAN Technologies
//948D50, "Beamex Oy Ab
//A433D1", "Fibrlink Communications Co., Ltd.
//5CBD9E HONGKONG MIRACLE EAGLE TECHNOLOGY(GROUP) LIMITED
//08E672, "JEBSEE ELECTRONICS CO., LTD.
//B8E589 Payter BV
//88E0A0 Shenzhen VisionSTOR Technologies Co., Ltd
//FC10BD", "Control Sistematizado S.A.
//F0C27C Mianyang Netop Telecom Equipment Co., Ltd.
//241A8C Squarehead Technology AS
//D44F80 Kemper Digital GmbH
//A41BC0 Fastec Imaging Corporation
//205B2A Private
//F40321 BeNeXt B.V.
//A071A9 Nokia Corporation
//A4E32E", "Silicon & Software Systems Ltd.
//C8C126 ZPM Industria e Comercio Ltda
//64DE1C Kingnetic Pte Ltd
//A862A2 JIWUMEDIA CO., LTD.
//984E97, "Starlight Marketing (H.K.) Ltd.
//64DC01 Static Systems Group PLC
//FC1FC0", "EURECAM
//BC6784", "Environics Oy
//68DCE8 PacketStorm Communications
//488E42, "DIGALOG GmbH
//607688, "Velodyne
//78CD8E SMC Networks Inc
//2C8065 HARTING Inc.of North America
//3CC0C6 d&b audiotechnik GmbH
//4468AB JUIN COMPANY, LIMITED
//F81037", "Atopia Systems, LP
//78A683 Precidata
//F02572 Cisco Systems, Inc
//04FF51 NOVAMEDIA INNOVISION SP. Z O.O.
//4CB4EA HRD (S) PTE., LTD.
//D44C24 Vuppalamritha Magnetic Components LTD
//F8C678", "Carefusion
//6CAB4D Digital Payment Technologies
//2CB0DF Soliton Technologies Pvt Ltd
//ECE555", "Hirschmann Automation
//58F98E, "SECUDOS GmbH
//B4C44E VXL eTech Pvt Ltd
//707EDE NASTEC LTD.
//C07E40 SHENZHEN XDK COMMUNICATION EQUIPMENT CO., LTD
//E44F29", "MA Lighting Technology GmbH
//B4749F ASKEY COMPUTER CORP
//7C4AA8 MindTree Wireless PVT Ltd
//8091C0 AgileMesh, Inc.
//084EBF Broad Net Mux Corporation
//E05FB9", "Cisco Systems, Inc
//E0143E", "Modoosis Inc.
//90D852, "Comtec Co., Ltd.
//380197, "TSST Global, Inc
//AC02CF", "RW Tecnologia Industria e Comercio Ltda
//D41296 Anobit Technologies Ltd.
//48174C MicroPower technologies
//349A0D ZBD Displays Ltd
//90507B Advanced PANMOBIL Systems GmbH & Co.KG
//0876FF Thomson Telecom Belgium
//1C7C11 EID
//20AA25 IP-NET LLC
//C4EEF5 II-VI Incorporated
//E0CF2D Gemintek Corporation
//D491AF", "Electroacustica General Iberica, S.A.
//C4B512 General Electric Digital Energy
//0034F1, "Radicom Research, Inc.
//9433DD Taco Inc
//E02538", "Titan Pet Products
//CC7A30", "CMAX Wireless Co., Ltd.
//B88E3A Infinite Technologies JLT
//588D09, "Cisco Systems, Inc
//C0C1C0", "Cisco-Linksys, LLC
//6015C7 IdaTech
//DC2008 ASD Electronics Ltd
//1C83B0 Linked IP GmbH
//A4D1D1 ECOtality North America
//C49313", "100fio networks technology llc
//7C3920 SSOMA SECURITY
//28C0DA Juniper Networks
//9C77AA NADASNV
//10E8EE PhaseSpace
//A47C1F Cobham plc
//D46CDA", "CSM GmbH
//5CD998 D-Link Corporation
//68597F, "Alcatel Lucent
//F065DD Primax Electronics Ltd.
//706582, "Suzhou Hanming Technologies Co., Ltd.
//34D2C4 RENA GmbH Print Systeme
//D4CBAF", "Nokia Corporation
//045D56, "camtron industrial inc.
//68234B Nihon Dengyo Kousaku
//1C3DE7 Sigma Koki Co., Ltd.
//58BC27 Cisco Systems, Inc
//20D607, "Nokia Corporation
//6CE0B0 SOUND4
//9CFFBE OTSL Inc.
//00F860, "PT.Panggung Electric Citrabuana
//B8BA72", "Cynove
//443D21, "Nuvolt
//30493B Nanjing Z-Com Wireless Co., Ltd
//A45C27", "Nintendo Co., Ltd.
//6C0460 RBH Access Technologies Inc.
//706417, "ORBIS TECNOLOGIA ELECTRICA S.A.
//18EF63, "Cisco Systems, Inc
//206FEC Braemac CA LLC
//100D32, "Embedian, Inc.
//88ACC1 Generiton Co., Ltd.
//8818AE Tamron Co., Ltd
//7CED8D Microsoft
//A4BE61 EutroVision System, Inc.
//D07DE5 Forward Pay Systems, Inc.
//04DD4C Velocytech
//A40CC3 Cisco Systems, Inc
//4CBAA3 Bison Electronics Inc.
//A8B1D4 Cisco Systems, Inc
//EC7C74", "Justone Technologies Co., Ltd.
//CCFCB1 Wireless Technology, Inc.
//3C1A79 Huayuan Technology CO., LTD
//9CF61A UTC Fire and Security
//7CF098 Bee Beans Technologies, Inc.
//EC66D1 B&W Group LTD
//385FC3 Yu Jeong System, Co.Ltd
//888B5D Storage Appliance Corporation
//78C6BB Innovasic, Inc.
//84A991 Cyber Trans Japan Co., Ltd.
//68784C Nortel Networks
//F8D756", "Simm Tronic Limited
//04A3F3 Emicon
//1C17D3 Cisco Systems, Inc
//7CE044 NEON Inc
//284C53 Intune Networks
//64D02D, "Next Generation Integration (NGI)
//90513F, "Elettronica Santerno SpA
//8841C1 ORBISAT DA AMAZONIA IND E AEROL SA
//9C7514 Wildix srl
//4CF737 SamJi Electronics Co., Ltd
//F0D767", "Axema Passagekontroll AB
//C84C75", "Cisco Systems, Inc
//C802A6", "Beijing Newmine Technology
//4C8B55 Grupo Digicon
//6C5CDE SunReports, Inc.
//34F39B WizLAN Ltd.
//E86CDA Supercomputers and Neurocomputers Research Center
//240B2A Viettel Group
//00B5D6 Omnibit Inc.
//548922, "Zelfy Inc
//50C58D Juniper Networks
//24A42C KOUKAAM a.s.
//4C3089 Thales Transportation Systems GmbH
//481249, "Luxcom Technologies Inc.
//24A937 PURE Storage
//348302, "iFORCOM Co., Ltd
//B43DB2", "Degreane Horizon
//84F64C Cross Point BV
//C08B6F S I Sistemas Inteligentes Eletrônicos Ltda
//F86ECF", "Arcx Inc
//8C8401 Private
//408493, "Clavister AB
//78A6BD DAEYEON Control&Instrument Co,.Ltd
//3C1915 GFI Chrono Time
//ECB106 Acuro Networks, Inc
//C835B8", "Ericsson, EAB/RWI/K
//F89D0D", "Control Technology Inc.
//2C3F3E Alge-Timing GmbH
//089F97, "LEROY AUTOMATION
//34BA51 Se-Kure Controls, Inc.
//6C7039 Novar GmbH
//982D56, "Resolution Audio
//147373, "TUBITAK UEKAE
//FCCF62 IBM Corp
//084E1C H2A Systems, LLC
//88B627 Gembird Europe BV
//F06853 Integrated Corporation
//A4ADB8", "Vitec Group, Camera Dynamics Ltd
//A4B121", "Arantia 2010 S.L.
//E02636 Nortel Networks
//5C57C8 Nokia Corporation
//D46CBF", "Goodrich ISR
//E02630 Intrigue Technologies, Inc.
//ECC882 Cisco Systems, Inc
//6CFDB9 Proware Technologies Co Ltd.
//10189E, "Elmo Motion Control
//8C56C5 Nintendo Co., Ltd.
//CCB888 AnB Securite s.a.
//6C5E7A Ubiquitous Internet Telecom Co., Ltd
//B42CBE", "Direct Payment Solutions Limited
//CC2218 InnoDigital Co., Ltd.
//C86C1E Display Systems Ltd
//A01859 Shenzhen Yidashi Electronics Co Ltd
//E8056D Nortel Networks
//C45976", "Fugoo Coorporation
//90A7C1 Pakedge Device and Software Inc.
//80BAAC TeleAdapt Ltd
//502DF4 Phytec Messtechnik GmbH
//2CCD27 Precor Inc
//104369, "Soundmax Electronic Limited
//C06C0F", "Dobbs Stanford
//C86CB6 Optcom Co., Ltd.
//5849BA Chitai Electronic Corp.
//00D11C ACETEL
//601D0F, "Midnite Solar
//A8F94B Eltex Enterprise Ltd.
//0C8230 SHENZHEN MAGNUS TECHNOLOGIES CO., LTD
//746B82 MOVEK
//9CC077 PrintCounts, LLC
//3CB17F Wattwatchers Pty Ld
//CC5459 OnTime Networks AS
//F8DC7A Variscite LTD
//D4F143", "IPROAD., Inc
//B8F732", "Aryaka Networks Inc
//E8DFF2", "PRF Co., Ltd.
//B4ED54 Wohler Technologies
//006440, "Cisco Systems, Inc
//94C4E9 PowerLayer Microsystems HongKong Limited
//8843E1, "Cisco Systems, Inc
//34862A Heinz Lackmann GmbH & Co KG
//ACE348 MadgeTech, Inc
//549A16 Uzushio Electric Co., Ltd.
//9018AE Shanghai Meridian Technologies, Co.Ltd.
//0494A1 CATCH THE WIND INC
//003A99 Cisco Systems, Inc
//003A9A Cisco Systems, Inc
//003A98 Cisco Systems, Inc
//50A6E3 David Clark Company
//50934F, "Gradual Tecnologia Ltda.
//B8B1C7 BT&COM CO., LTD
//DC2C26", "Iton Technology Limited
//D411D6", "ShotSpotter, Inc.
//9CAFCA Cisco Systems, Inc
//1C0FCF Sypro Optics GmbH
//9C4E8E ALT Systems Ltd
//7072CF EdgeCore Networks
//ECD00E", "MiraeRecognition Co., Ltd.
//A4AD00 Ragsdale Technology
//4C9EE4 Hanyang Navicom Co., Ltd.
//C87248 Aplicom Oy
//C47D4F", "Cisco Systems, Inc
//3CDF1E Cisco Systems, Inc
//986DC8 TOSHIBA MITSUBISHI-ELECTRIC INDUSTRIAL SYSTEMS CORPORATION
//6CAC60 Venetex Corp
//F04BF2", "JTECH Communications, Inc.
//042BBB PicoCELA, Inc.
//FC0877 Prentke Romich Company
//64F970, "Kenade Electronics Technology Co., LTD.
//C82E94 Halfa Enterprise Co., Ltd.
//80177D, "Nortel Networks
//7C7BE4 Z'SEDAI KENKYUSHO CORPORATION
//F0DE71 Shanghai EDO Technologies Co., Ltd.
//60D30A Quatius Limited
//24CF21 Shenzhen State Micro Technology Co., Ltd
//10BAA5 GANA I&C CO., LTD
//BC9DA5", "DASCOM Europe GmbH
//28FBD3 Ragentek Technology Group
//586ED6, "Private
//EC3091", "Cisco Systems, Inc
//64BC11 CombiQ AB
//C8C13C", "RuggedTek Hangzhou Co., Ltd
//F4ACC1", "Cisco Systems, Inc
//4097D1, "BK Electronics cc
//0CE936 ELIMOS srl
//A02EF3", "United Integrated Services Co., Led.
//A09805 OpenVox Communication Co Ltd
//60391F, "ABB Ltd
//E8A4C1 Deep Sea Electronics Ltd
//C8D2C1", "Jetlun (Shenzhen) Corporation
//E09153 XAVi Technologies Corp.
//88A5BD QPCOM INC.
//D4C766 Acentic GmbH
//002712, "MaxVision LLC
//00271F, "MIPRO Electronics Co., Ltd
//00270C Cisco Systems, Inc
//0026CF DEKA R&D
//0026E7, "Shanghai ONLAN Communication Tech. Co., Ltd.
//0026E0, "ASITEQ
//002703, "Testech Electronics Pte Ltd
//0026F3, "SMC Networks
//0026A5 MICROROBOT.CO., LTD
//0026A3 FQ Ingenieria Electronica S.A.
//00269D, "M2Mnet Co., Ltd.
//002697, "Alpha Technologies Inc.
//00268A Terrier SC Ltd
//002689, "General Dynamics Robotic Systems
//0026C5 Guangdong Gosun Telecommunications Co., Ltd
//0026C4 Cadmos microsystems S.r.l.
//0026C8 System Sensor
//00267A wuhan hongxin telecommunication technologies co., ltd
//0026C2 SCDI Co.LTD
//002685, "Digital Innovation
//0026A9 Strong Technologies Pty Ltd
//002672, "AAMP of America
//0025FD OBR Centrum Techniki Morskiej S.A.
//002600, "TEAC Australia Pty Ltd.
//0025FF CreNova Multimedia Co., Ltd
//002604, "Audio Processing Technology Ltd
//002659, "Nintendo Co., Ltd.
//002651, "Cisco Systems, Inc
//002612, "Space Exploration Technologies
//002616, "Rosemount Inc.
//00260B Cisco Systems, Inc
//002623, "JRD Communication Inc
//002627, "Truesell
//00264E, "Rail & Road Protec GmbH
//00264F, "Krüger &Gothe GmbH
//002621, "InteliCloud Technology Inc.
//00261C NEOVIA INC.
//002664, "Core System Japan
//002639, "T.M.Electronics, Inc.
//0025C6 kasercorp, ltd
//0025C5 Star Link Communication Pvt.Ltd.
//0025C7 altek Corporation
//0025E6, "Belgian Monitoring Systems bvba
//0025E0, "CeedTec Sdn Bhd
//0025DE Probits Co., LTD.
//0025B0 Schmartz Inc
//0025AD Manufacturing Resources International
//0025AC I-Tech corporation
//0025AB AIO LCD PC BU / TPV
//0025EC Humanware
//0025ED, "NuVo Technologies LLC
//0025E9, "i-mate Development, Inc.
//0025BA Alcatel-Lucent IPD
//0025BB INNERINT Co., Ltd.
//0025B8 Agile Communications, Inc.
//0025B1 Maya-Creation Corporation
//0025A1 Enalasys
//0025F3, "Nordwestdeutsche Zählerrevision
//0025DD SUNNYTEK INFORMATION CO., LTD.
//0025CE InnerSpace
//002549, "Jeorich Tech. Co., Ltd.
//002539, "IfTA GmbH
//002537, "Runcom Technologies Ltd.
//002538, "Samsung Electronics Co., Ltd., Memory Division
//002544, "LoJack Corporation
//002532, "Digital Recorders
//00255D, "Morningstar Corporation
//002558, "MPEDIA
//00254A RingCube Technologies, Inc.
//00254F, "ELETTROLAB Srl
//002583, "Cisco Systems, Inc
//002591, "NEXTEK, Inc.
//00258D, "Haier
//002571, "Zhejiang Tianle Digital Electric Co., Ltd
//00259A CEStronics GmbH
//002502, "NaturalPoint
//0024F8, "Technical Solutions Company Ltd.
//0024F9, "Cisco Systems, Inc
//0024F2, "Uniphone Telecommunication Co., Ltd.
//002514, "PC Worth Int'l Co., Ltd.
//00250B CENTROFACTOR", "INC
//002506, "A.I.ANTITACCHEGGIO ITALIA SRL
//00251C EDT
//00251A Psiber Data Systems Inc.
//0024E1, "Convey Computer Corp.
//0024EE Wynmax Inc.
//0024E3, "CAO Group
//002507, "ASTAK Inc.
//0024D9, "BICOM, Inc.
//00248E, "Infoware ZRt.
//002494, "Shenzhen Baoxin Tech CO., Ltd.
//002489, "Vodafone Omnitel N.V.
//00246F, "Onda Communication spa
//002469, "Smart Doorphones
//00247F, "Nortel Networks
//002475, "Compass System(Embedded Dept.)
//0024C3 Cisco Systems, Inc
//0024B5 Nortel Networks
//0024B0 ESAB AB
//0024C4 Cisco Systems, Inc
//00249D, "NES Technology Inc.
//002464, "Bridge Technologies Co AS
//002462, "Rayzone Corporation
//002420, "NetUP Inc.
//00241E, "Nintendo Co., Ltd.
//00241F, "DCT-Delta GmbH
//00240E, "Inventec Besta Co., Ltd.
//002460, "Giaval Science Development Co. Ltd.
//00245C Design-Com Technologies Pty.Ltd.
//00243D, "Emerson Appliance Motors and Controls
//002437, "Motorola - BSG
//002444, "Nintendo Co., Ltd.
//002413, "Cisco Systems, Inc
//00244F, "Asantron Technologies Ltd.
//0023DD ELGIN S.A.
//0023DE Ansync Inc.
//0023D9, "Banner Engineering
//0023DA Industrial Computer Source (Deutschland) GmbH
//002405, "Dilog Nordic AB
//0023E8, "Demco Corp.
//0023E3, "Microtronic AG
//0023B7 Q-Light Co., Ltd.
//0023FD AFT Atlas Fahrzeugtechnik GmbH
//0023EF, "Zuend Systemtechnik AG
//0023AC Cisco Systems, Inc
//0023D8, "Ball-It Oy
//00239F, "Institut für Prüftechnik
//00239D, "Mapower Electronics Co., Ltd
//00239C Juniper Networks
//002398, "Vutlan sro
//00235B Gulfstream
//002359, "Benchmark Electronics (Thailand ) Public Company Limited
//002357, "Pitronot Technologies and Engineering P.T.E.Ltd.
//002355, "Kinco Automation(Shanghai) Ltd.
//002373, "GridIron Systems, Inc.
//002367, "UniControls a.s.
//002368, "Zebra Technologies Inc
//00236E, "Burster GmbH & Co KG
//002366, "Beijing Siasun Electronic System Co., Ltd.
//00238F, "NIDEC COPAL CORPORATION
//002380, "Nanoteq
//00233D, "Laird Technologies
//00233F, "Purechoice Inc
//00231B Danaher Motion - Kollmorgen
//00231E, "Cezzer Multimedia Technologies
//00231F, "Guangda Electronic & Telecommunication Technology Development Co., Ltd.
//002270, "ABK North America, LLC
//002313, "Qool Technologies Ltd.
//002310, "LNC Technology Co., Ltd.
//0022CD Ared Technology Co., Ltd.
//0022CC SciLog, Inc.
//0022CB IONODES Inc.
//0022C6 Sutus Inc
//0022E8, "Applition Co., Ltd.
//0022E9, "ProVision Communications
//0022E6, "Intelligent Data
//0022E3, "Amerigon
//0022EB Data Respons A/S
//0022EF, "iWDL Technologies
//0022F2, "SunPower Corp
//0022E2, "WABTEC Transit Division
//002301, "Witron Technology Limited
//0022F7, "Conceptronic
//00230C CLOVER ELECTRONICS CO., LTD.
//002334, "Cisco Systems, Inc
//0022C8 Applied Instruments B.V.
//0022C0 Shenzhen Forcelink Electronic Co, Ltd
//0022A6 Sony Computer Entertainment America
//0022A7 Tyco Electronics AMP GmbH
//0022A1 Huawei Symantec Technologies Co., Ltd.
//00229D, "PYUNG-HWA IND.CO., LTD
//002296, "LinoWave Corporation
//002244, "Chengdu Linkon Communications Device Co., Ltd
//002250, "Point Six Wireless, LLC
//00226F, "3onedata Technology Co.Ltd.
//002278, "Shenzhen Tongfang Multimedia Technology Co., Ltd.
//00227A Telecom Design
//002260, "AFREEY Inc.
//0021EF, "Kapsys
//0021ED, "Telegesis
//0021EB ESP SYSTEMS, LLC
//002237, "Shinhint Group
//00222F, "Open Grid Computing, Inc.
//0021F6, "Oracle Corporation
//002206, "Cyberdyne Inc.
//002202, "Excito Elektronik i Skåne AB
//002227, "uv-electronic GmbH
//00221E, "Media Devices Co., Ltd.
//002225, "Thales Avionics Ltd
//002220, "Mitac Technology Corp
//00220E, "Indigo Security Co., Ltd.
//002207, "Inteno Broadband Technology AB
//00223E, "IRTrans GmbH
//0021CE NTC-Metrotek
//0021CA ART System Co., Ltd.
//0021CB SMS TECNOLOGIA ELETRONICA LTDA
//0021C8 LOHUIS Networks
//0021DB Santachi Video Technology (Shenzhen) Co., Ltd.
//0021BF Hitachi High-Tech Control Systems Corporation
//0021BC ZALA COMPUTER
//0021B4 APRO MEDIA CO., LTD
//0021A8 Telephonics Corporation
//0021A9 Mobilink Telecom Co., Ltd
//00218D, "AP Router Ind.Eletronica LTDA
//002190, "Goliath Solutions
//002185, "MICRO-STAR INT'L CO.,LTD.
//00219F, "SATEL OY
//002196, "Telsey S.p.A.
//002182, "SandLinks Systems, Ltd.
//002183, "ANDRITZ HYDRO GmbH
//0021DF Martin Christ GmbH
//0021D4, "Vollmer Werke GmbH
//0021D6, "LXI Consortium
//0021A6 Videotec Spa
//002159, "Juniper Networks
//002155, "Cisco Systems, Inc
//002157, "National Datacast, Inc.
//00213B Berkshire Products, Inc
//002137, "Bay Controls, LLC
//002139, "Escherlogic Inc.
//00212C SemIndia System Private Limited
//00212B MSA Auer
//002174, "AvaLAN Wireless
//002179, "IOGEAR, Inc.
//002168, "iVeia, LLC
//002150, "EYEVIEW ELECTRONICS
//00214D, "Guangzhou Skytone Transmission Technology Com.Ltd.
//00212A Audiovox Corporation
//00215E, "IBM Corp
//001FF6 PS Audio International
//002110, "Clearbox Systems
//00210C Cymtec Systems, Inc.
//00210B GEMINI TRAZE RFID PVT.LTD.
//001FDD GDI LLC
//001FDA Nortel Networks
//002104, "Gigaset Communications GmbH
//001FFB Green Packet Bhd
//001FE9 Printrex, Inc.
//001FF0 Audio Partnership
//001FEA Applied Media Technologies Corporation
//001FD9 RSD Communications Ltd
//001FCE QTECH LLC
//001F8B Cache IQ
//001F85, "Apriva ISS, LLC
//001F87, "Skydigital Inc.
//001F88, "FMS Force Measuring Systems AG
//001F86, "digEcor
//001FA1 Gtran Inc
//001F9F, "Thomson Telecom Belgium
//001F99, "SERONICS co.ltd
//001F80, "Lucas Holding bv
//001B58 ACE CAD Enterprise Co., Ltd.
//001FB0 TimeIPS, Inc.
//001FAE Blick South Africa (Pty) Ltd
//001F79, "Lodam Electronics A/S
//001F71, "xG Technology, Inc.
//001FA5 Blue-White Industries
//001F9D, "Cisco Systems, Inc
//001F96, "APROTECH CO.LTD
//001F40, "Speakercraft Inc.
//001F6C Cisco Systems, Inc
//001F6F, "Fujian Sunnada Communication Co., Ltd.
//001F60, "COMPASS SYSTEMS CORP.
//001F6A PacketFlux Technologies, Inc.
//001F65, "KOREA ELECTRIC TERMINAL CO., LTD.
//001F17, "IDX Company, Ltd.
//001F1B RoyalTek Company Ltd.
//001F5E, "Dyna Technology Co., Ltd.
//001F55, "Honeywell Security (China) Co., Ltd.
//001F54, "Lorex Technology Inc.
//001F2E, "Triangle Research Int'l Pte Ltd
//001F4B Lineage Power
//001F0D, "L3 Communications - Telemetry West
//001EFC JSC MASSA-K
//001F23, "Interacoustics
//001F06, "Integrated Dispatch Solutions
//001EBA High Density Devices AS
//001EB8 Aloys, Inc
//001EB4 UNIFAT TECHNOLOGY LTD.
//001EE0 Urmet Domus SpA
//001EDA Wesemann Elektrotechniek B.V.
//001ED7, "H-Stream Wireless, Inc.
//001ED5, "Tekon-Automatics
//001EE8 Mytek
//001EEE ETL Systems Ltd
//001EFA PROTEI Ltd.
//001EFB Trio Motion Technology Ltd
//001EF8, "Emfinity Inc.
//001ECB RPC Energoautomatika Ltd
//001EA8 Datang Mobile Communications Equipment CO., LTD
//001EAB TeleWell Oy
//001E9F, "Visioneering Systems, Inc.
//001E6B Cisco SPVTG
//001E70, "Cobham Antenna Systems
//001E61, "ITEC GmbH
//001E3E KMW Inc.
//001E38, "Bluecard Software Technology Co., Ltd.
//001E47, "PT.Hariff Daya Tunggal Engineering
//001E48, "Wi-Links
//001E8A eCopy, Inc
//001E9B San-Eisha, Ltd.
//001E96, "Sepura Plc
//001E59, "Silicon Turnkey Express, LLC
//001E51, "Converter Industry Srl
//001E71, "MIrcom Group of Companies
//001DC4 AIOI Systems Co., Ltd.
//001DC0 Enphase Energy
//001DBD Versamed Inc.
//001DF8 Webpro Vision Technology Corporation
//001DF9 Cybiotronics (Far East) Limited
//001DF7 R. STAHL Schaltgeräte GmbH
//001E05, "Xseed Technologies & Computing
//001E07, "Winy Technology Co., Ltd.
//001E0A Syba Tech Limited
//001E03, "LiComm Co., Ltd.
//001E1B Digital Stream Technology, Inc.
//001E17, "STN BV
//001E18, "Radio Activity srl
//001E15, "Beech Hill Electronics
//001E30, "Shireen Inc
//001E2E SIRTI S.p.A.
//001DDC HangZhou DeChangLong Tech&Info Co., Ltd
//001DEB DINEC International
//001D9A GODEX INTERNATIONAL CO., LTD
//001D97, "Alertus Technologies LLC
//001D91, "Digitize, Inc
//001D95, "Flash, Inc.
//001D9D, "ARTJOY INTERNATIONAL LIMITED
//001D9E, "AXION TECHNOLOGIES
//001D70, "Cisco Systems, Inc
//001D78, "Invengo Information Technology Co., Ltd
//001D6F, "Chainzone Technology Co., Ltd
//001D7F, "Tekron International Ltd
//001D79, "SIGNAMAX LLC
//001DAE CHANG TSENG TECHNOLOGY CO., LTD
//001DA6 Media Numerics Limited
//001D62, "InPhase Technologies
//001D63, "Miele & Cie.KG
//001DB7 Tendril Networks, Inc.
//001D8D, "Fluke Process Instruments GmbH
//001D1F, "Siauliu Tauro Televizoriai, JSC
//001D43, "Shenzhen G-link Digital Technology Co., Ltd.
//001D3F, "Mitron Pty Ltd
//001D39, "MOOHADIGITAL CO., LTD
//001D37, "Thales-Panda Transportation System
//001D13, "NextGTV
//001D14, "SPERADTONE INFORMATION TECHNOLOGY LIMITED
//001D10, "LightHaus Logic, Inc.
//001D04, "Zipit Wireless, Inc.
//001CF2 Tenlon Technology Co., Ltd.
//001D30, "YX Wireless S.A.
//001CB2 BPT SPA
//001CB5 Neihua Network Technology Co., LTD.(NHN)
//001CB4 Iridium Satellite LLC
//001CB6 Duzon CNT Co., Ltd.
//001CC7 Rembrandt Technologies, LLC d/b/a REMSTREAM
//001CBB MusicianLink
//001C8D Mesa Imaging
//001C89 Force Communications, Inc.
//001C87 Uriver Inc.
//001CCD Alektrona Corporation
//001CEC Mobilesoft (Aust.) Pty Ltd
//001CE8 Cummins Inc
//001CD0 Circleone Co., Ltd.
//001C9F Razorstream, LLC
//001C7D Excelpoint Manufacturing Pte Ltd
//001C5C Integrated Medical Systems, Inc.
//001C52 VISIONEE SRL
//001C47 Hangzhou Hollysys Automation Co., Ltd
//001C16 ThyssenKrupp Elevator
//001C19 secunet Security Networks AG
//001C6C", "30805
//001C61 Galaxy", "Microsystems LImited
//001C3B AmRoad Technology Inc.
//001C3F International Police Technologies, Inc.
//001C28 Sphairon Technologies GmbH
//001C1F Quest Retail Technology Pty Ltd
//001C32 Telian Corporation
//001C2B Alertme.com Limited
//001C77 Prodys
//001C6F Emfit Ltd
//001C49 Zoltan Technology Inc.
//001C63 TRUEN
//001BDF Iskra Sistemi d.d.
//001BD9 Edgewater Wireless Systems Inc
//001BC7 StarVedia Technology Inc.
//001BEC Netio Technologies Co., Ltd
//001C09 SAE Electronic Co., Ltd.
//001C0C TANITA Corporation
//001BA6 intotech inc.
//001BA4 S.A.E Afikim
//001BB4 Airvod Limited
//001BB6 Bird Electronic Corp.
//001BE8 Ultratronik GmbH
//001BE1 ViaLogy
//001B93 JC Decaux SA DNT
//001B9B Hose-McCann Communications
//001B9C SATEL sp.z o.o.
//001B92 l-acoustics
//001B8E Hulu Sweden AB
//001B45 ABB AS, Division Automation Products
//001B3F ProCurve Networking by HP
//001B41 General Infinity Co., Ltd.
//001B50 Nizhny Novgorod Factory named after M.Frunze, FSUE (NZiF)
//001B47 Futarque A/S
//001B6C LookX Digital Media BV
//001B6B Swyx Solutions AG
//001B69 Equaline Corporation
//001B76 Ripcode, Inc.
//001B70 IRI Ubiteq, INC.
//001B68 Modnnet Co., Ltd
//001B62 JHT Optoelectronics Co., Ltd.
//001B8A", "2M Electronic A/S
//001B80 LORD Corporation
//001B3E Curtis, Inc.
//001B37 Computec Oy
//001B07 Mendocino Software
//001B08 Danfoss Drives A/S
//001B01 Applied Radio Technologies
//001B02 ED Co.Ltd
//001AFC ModusLink Corporation
//001B10 ShenZhen Kang Hui Technology Co., ltd
//001B0B Phidgets Inc.
//001B0C Cisco Systems, Inc
//001AE0 Mythology Tech Express Inc.
//001AE2 Cisco Systems, Inc
//001AD7 Christie Digital Systems, Inc.
//001B23 SimpleComTools
//001AF6 Woven Systems, Inc.
//001AF9 AeroVIronment (AV Inc)
//001B30 Solitech Inc.
//001B18 Tsuken Electric Ind. Co., Ltd
//001AE7 Aztek Networks, Inc.
//001A95 Hisense Mobile Communications Technoligy Co., Ltd.
//001A81 Zelax
//001A87 Canhold International Limited
//001A88 Venergy, Co, Ltd
//001AC1", "3Com Ltd
//001ABB Fontal Technology Incorporation
//001ABD Impatica Inc.
//001AAE Savant Systems LLC
//001ACD Tidel Engineering LP
//001AC9 SUZUKEN CO., LTD
//001A79 TELECOMUNICATION TECHNOLOGIES LTD.
//001AAA Analogic Corp.
//001A8B CHUNIL ELECTRIC IND., CO.
//001A8D AVECS Bergen GmbH
//001AB4 FFEI Ltd.
//001AB5 Home Network System
//001AA4 Future University-Hakodate
//001A9F A-Link Ltd
//001A74 Procare International Co
//001ABE COMPUTER HI-TECH INC.
//001A19 Computer Engineering Limited
//001A18 Advanced Simulation Technology inc.
//001A58 CCV Deutschland GmbH - Celectronic eHealth Div.
//001A5E Thincom Technology Co., Ltd
//001A5C Euchner GmbH+Co.KG
//001A5B NetCare Service Co., Ltd.
//001A24 Galaxy Telecom Technologies Ltd
//001A20 CMOTECH Co.Ltd.
//001A4E NTI AG / LinMot
//001A52 Meshlinx Wireless Inc.
//001A13 Wanlida Group Co., LTD
//001A0F Sistemas Avanzados de Control, S.A.
//001A43 Logical Link Communications
//001A47 Agami Systems, Inc.
//001A2D The Navvo Group
//001A2F Cisco Systems, Inc
//0019A9 Cisco Systems, Inc
//0019AE Hopling Technologies b.v.
//0019AF Rigol Technologies, Inc.
//0019DE MOBITEK
//0019E5, "Lynx Studio Technology, Inc.
//0019DB MICRO-STAR INTERNATIONAL CO., LTD.
//001A03 Angel Electronics Co., Ltd.
//0019F9, "TDK-Lambda
//0019CE Progressive Gaming International
//0019BD New Media Life
//0019F2, "Teradyne K.K.
//0019A7 ITU-T
//00199F, "DKT A/S
//00198D, "Ocean Optics, Inc.
//001982, "SmarDTV
//001985, "IT Watchdogs, Inc
//001951, "NETCONS, s.r.o.
//001957, "Saafnet Canada Inc.
//001958, "Bluetooth SIG, Inc.
//001956, "Cisco Systems, Inc
//00196B Danpex Corporation
//00193D, "GMC Guardian Mobility Corp.
//001986, "Cheng Hongjian
//00199E, "Nifty
//00196A MikroM GmbH
//0018FF PowerQuattro Co.
//0018F4, "EO TECHNICS Co., Ltd.
//0018FC Altec Electronic AG
//0018F6, "Thomson Telecom Belgium
//0018F5, "Shenzhen Streaming Video Technology Company Limited
//0018F9, "VVOND, Inc.
//00193B LigoWave
//001935, "DUERR DENTAL AG
//001932, "Gude Analog- und Digialsysteme GmbH
//001910, "Knick Elektronische Messgeraete GmbH & Co.KG
//001913, "Chuang-Yi Network Equipment Co.Ltd.
//0018FA Yushin Precision Equipment Co., Ltd.
//0018EA Alltec GmbH
//0018E8, "Hacetron Corporation
//001914, "Winix Co., Ltd
//001906, "Cisco Systems, Inc
//001901, "F1MEDIA
//001931, "Balluff GmbH
//0018E3, "Visualgate Systems, Inc.
//00189F, "Lenntek Corporation
//001899, "ShenZhen jieshun Science&Technology Industry CO, LTD.
//00186D, "Zhenjiang Sapphire Electronic Industry CO.
//00186F, "Setha Industria Eletronica LTDA
//001875, "AnaCise Testnology Pte Ltd
//0018C1 Almitec Informática e Comércio
//0018C4 Raba Technologies LLC
//0018C9 EOps Technology Limited
//0018D8, "ARCH METER Corporation
//0018D9, "Santosha Internatonal, Inc
//0018CF Baldor Electric Company
//0018BC ZAO NVP Bolid
//0018B7 D3 LED, LLC
//001895, "Hansun Technologies Inc.
//001883, "FORMOSA21 INC.
//00188E, "Ekahau, Inc.
//001814, "Mitutoyo Corporation
//001817, "D.E.Shaw Research, LLC
//001811, "Neuros Technology International, LLC.
//0017DE Advantage Six Ltd
//0017D7, "ION Geophysical Corporation Inc.
//001837, "Universal ABIT Co., Ltd.
//001822, "CEC TELECOM CO., LTD.
//001820, "w5networks
//00185D, "TAIGUEN TECHNOLOGY (SHEN-ZHEN) CO., LTD.
//00185E, "Nexterm Inc.
//001828, "e2v technologies (UK) ltd.
//001835, "Thoratec / ITC
//001801, "Actiontec Electronics, Inc
//0017F3, "Harris Corporation
//00184A Catcher, Inc.
//00184B Las Vegas Gaming, Inc.
//00180E, "Avega Systems
//0017BC Touchtunes Music Corporation
//0017C1 CM Precision Technology LTD.
//0017B2 SK Telesys
//0017B1 ACIST Medical Systems, Inc.
//0017A3 MIX s.r.l.
//0017A6 YOSIN ELECTRONICS CO., LTD.
//00179C DEPRAG SCHULZ GMBH u.CO.
//001796, "Rittmeyer AG
//0017E1, "DACOS Technologies Co., Ltd.
//0017E0, "Cisco Systems, Inc
//0017D2, "THINLINX PTY LTD
//001785, "Sparr Electronics Ltd
//001775, "TTE Germany GmbH
//0017B8 NOVATRON CO., LTD.
//0017BB Syrinx Industrial Electronics
//00177C Smartlink Network Systems Limited
//001781, "Greystone Data System, Inc.
//00178D, "Checkpoint Systems, Inc.
//00178E, "Gunnebo Cash Automation AB
//0017C7 MARA Systems Consulting AB
//00175D, "Dongseo system.
//001750, "GSI Group, MicroE Systems
//001755, "GE Security
//00171D, "DIGIT
//001718, "Vansco Electronics Oy
//001719, "Audiocodes USA, Inc
//001776, "Meso Scale Diagnostics, LLC
//001779, "QuickTel
//001767, "Earforce AS
//001739, "Bright Headphone Electronics Company
//00172C TAEJIN INFOTECH
//001751, "Online Corporation
//00174C Millipore
//001711, "GE Healthcare Bio-Sciences AB
//001745, "INNOTZ CO., Ltd
//001748, "Neokoros Brasil Ltda
//001763, "Essentia S.p.A.
//001701, "KDE, Inc.
//0016F6, "Video Products Group
//0016EE Royaldigital Inc.
//0016DE FAST Inc
//0016DA Futronic Technology Co. Ltd.
//0016D4, "Compal Communications, Inc.
//0016D7, "Sunways AG
//0016FF Wamin Optocomm Mfg Corp
//0016D1, "ZAT a.s.
//0016C5 Shenzhen Xing Feng Industry Co., Ltd
//0016CC Xcute Mobile Corp.
//001717, "Leica Geosystems AG
//001715, "Qstik
//00170E, "Cisco Systems, Inc
//001705, "Methode Electronics
//0016AA Kei Communication Technology Inc.
//0016A8 CWT CO., LTD.
//0016A6 Dovado FZ-LLC
//0016ED, "Utility, Inc
//0016C7 Cisco Systems, Inc
//001671, "Symphox Information Co.
//001669, "MRV Communication (Networks) LTD
//001668, "Eishin Electronics
//001640, "Asmobile Communication Inc.
//00163C Rebox B.V.
//00167D, "Sky-Line Information Co., Ltd.
//001677, "Bihl + Wiedemann GmbH
//001655, "FUHO TECHNOLOGY Co., LTD
//001646, "Cisco Systems, Inc
//001648, "SSD Company Limited
//001672, "Zenway enterprise ltd
//00165A Harman Specialty Group
//001659, "Z.M.P.RADWAG
//0016A2 CentraLite Systems, Inc.
//001695, "AVC Technology (International) Limited
//0015D8, "Interlink Electronics
//0015D2, "Xantech Corporation
//0015D4, "Emitor AB
//0015D5, "NICEVT
//00160C LPL", "DEVELOPMENT S.A.DE C.V
//001612, "Otsuka Electronics Co., Ltd.
//00160B TVWorks LLC
//001603, "COOLKSKY Co., LTD
//0015EA Tellumat (Pty) Ltd
//0015E2, "Dr.Ing.Herbert Knauer GmbH
//0015E1, "Picochip Ltd
//0015DF Clivet S.p.A.
//00161D, "Innovative Wireless Technologies, Inc.
//001611, "Altecon Srl
//001609, "Unitech electronics co., ltd.
//0015F5, "Sustainable Energy Systems
//0015F1, "KYLINK Communications Corp.
//001623, "Interval Media
//001619, "Lancelan Technologies S.L.
//001625, "Impinj, Inc.
//001586, "Xiamen Overseas Chinese Electronic Co., Ltd.
//00157E, "Weidmüller Interface GmbH & Co.KG
//001580, "U-WAY CORPORATION
//00157C Dave Networks, Inc.
//00157F, "ChuanG International Holding CO., LTD.
//0015B3 Caretech AB
//0015AA Rextechnik International Co.,
//0015A6 Digital Electronics Products Ltd.
//00159D, "Tripp Lite
//0015D6, "OSLiNK Sp. z o.o.
//001592, "Facom UK Ltd (Melksham)
//00158B Park Air Systems Ltd
//001576, "LABiTec - Labor Biomedical Technologies GmbH
//0015BE Iqua Ltd.
//0015C7 Cisco Systems, Inc
//00155E, "Morgan Stanley
//00150B SAGE INFOTECH LTD.
//001507, "Renaissance Learning Inc
//001508, "Global Target Enterprise Inc
//001502, "BETA tech
//0014FD Thecus Technology Corp.
//0014FC Extandon, Inc.
//0014F8, "Scientific Atlanta
//0014F7, "CREVIS Co., LTD
//001515, "Leipold+Co.GmbH
//00150F, "mingjong
//00155C Dresser Wayne
//001559, "Securaplane Technologies, Inc.
//001557, "Olivetti
//001554, "Atalum Wireless S.A.
//00153B EMH metering GmbH & Co.KG
//001537, "Ventus Networks
//001533, "NADAM.CO., LTD
//001534, "A Beltrónica-Companhia de Comunicações, Lda
//00153F, "Alcatel Alenia Space Italia
//001518, "Shenzhen 10MOONS Technology Development CO., Ltd
//001526, "Remote Technologies Inc
//0014F1, "Cisco Systems, Inc
//0014EA S Digm Inc. (Safe Paradigm Inc.)
//0014E5, "Alticast
//00149F, "System and Chips, Inc.
//0014B3 CoreStar International Corp
//0014B1 Axell Wireless Limited
//0014E0, "LET'S Corporation
//0014E2, "datacom systems inc.
//0014E4, "infinias, LLC
//0014CC Zetec, Inc.
//0014CB LifeSync Corporation
//0014C6 Quixant Ltd
//001498, "Viking Design Technology
//001496, "Phonic Corp.
//001493, "Systimax Solutions
//0014DB Elma Trenew Electronic GmbH
//00143A RAYTALK INTERNATIONAL SRL
//001436, "Qwerty Elektronik AB
//00146B Anagran, Inc.
//001461, "CORONA CORPORATION
//001462, "Digiwell Technology, inc
//001463, "IDCS N.V.
//001465, "Novo Nordisk A/S
//001474, "K40 Electronics
//00146F, "Kohler Co
//001466, "Kleinhenz Elektronik GmbH
//00147F, "Thomson Telecom Belgium
//001475, "Wiline Networks, Inc.
//001486, "Echo Digital Audio Corporation
//001482, "Aurora Networks
//001455, "Coder Electronics Corporation
//00144E, "SRISA
//00148D, "Cubic Defense Simulation Systems
//00143D, "Aevoe Inc.
//001415, "Intec Automation inc.
//001410, "Suzhou Keda Technology CO., Ltd
//001417, "RSE Informations Technologie GmbH
//001433, "Empower Technologies(Canada) Inc.
//001434, "Keri Systems, Inc
//0013DE Adapt4, LLC
//0013DD Abbott Diagnostics
//0013D7, "SPIDCOM Technologies SA
//0013C7 IONOS Co., Ltd.
//001423, "J-S Co. NEUROCOM
//001425, "Galactic Computing Corp.
//001419, "SIDSA
//0013EE JBX Designs Inc.
//0013E5, "TENOSYS, INC.
//0013E2, "GeoVision Inc.
//001402, "kk-electronic a/s
//0013FF Dage-MTI of MC, Inc.
//0013BC Artimi Ltd
//001408, "Eka Systems Inc.
//0013A7 BATTELLE MEMORIAL INSTITUTE
//0013A6 Extricom Ltd
//0013A2 MaxStream, Inc
//00139F, "Electronics Design Services, Co., Ltd.
//0013A0 ALGOSYSTEM Co., Ltd.
//001398, "TrafficSim Co., Ltd
//00139B ioIMAGE Ltd.
//001396, "Acbel Polytech Inc.
//001393, "Panta Systems, Inc.
//00138B Phantom Technologies LLC
//001388, "WiMedia Alliance
//00136E, "Techmetro Corp.
//00136D, "Tentaculus AB
//00136A Hach Lange Sarl
//0013B2 Carallon Limited
//0013AD Sendo Ltd
//0013AA ALS", "& TEC Ltd.
//0013A4 KeyEye Communications
//00134D, "Inepro BV
//00134B ToGoldenNet Technology Inc.
//001384, "Advanced Motion Controls
//00137B Movon Corporation
//001353, "HYDAC Filtertechnik GMBH
//001363, "Verascape, Inc.
//001303, "GateConnect
//001304, "Flaircomm Technologies Co.LTD
//0012F9, "URYU SEISAKU, LTD.
//0012F3, "connectBlue AB
//001337, "Orient Power Home Network Ltd.
//001334, "Arkados, Inc.
//001332, "Beijing Topsec Network Security Technology Co., Ltd.
//00131F, "NxtPhase T&D, Corp.
//0012DC SunCorp Industrial Limited
//0012FF Lely Industries N.V.
//00133A VadaTech Inc.
//00132A Sitronics Telecom Solutions
//0012E5, "Time America, Inc.
//00130E, "Focusrite Audio Engineering Limited
//001309, "Ocean Broadband Networks
//001319, "Cisco Systems, Inc
//00131C LiteTouch, Inc.
//00134A Engim, Inc.
//0012D7, "Invento Networks, Inc.
//0012C4 Viseon, Inc.
//001293, "GE Energy
//001294, "SUMITOMO ELECTRIC DEVICE INNOVATIONS, INC
//001296, "Addlogix
//0012B3 Advance Wireless Technology Corp.
//0012B0 Efore Oyj", " (Plc)
//00127F, "Cisco Systems, Inc
//0012A6 Dolby Australia
//0012A4 ThingMagic, LLC
//0012A9", "3Com Ltd
//0012D0, "Gossen-Metrawatt-GmbH
//001299, "Ktech Telecommunications Inc
//00128C Woodward Governor
//0012B8 G2 Microsystems
//00127B VIA Networking Technologies, Inc.
//001280, "Cisco Systems, Inc
//001275, "Sentilla Corporation
//001276, "CG Power Systems Ireland Limited
//001271, "Measurement Computing Corp
//001273, "Stoke Inc
//001269, "Value Electronics
//001250, "Tokyo Aircaft Instrument Co., Ltd.
//001252, "Citronix, LLC
//001240, "AMOI ELECTRONICS CO., LTD
//00122E, "Signal Technology - AISD
//001264, "daum electronic gmbh
//001261, "Adaptix, Inc
//001260, "Stanton Magnetics, inc.
//001231, "Motion Control Systems, Inc.
//00124B Texas Instruments
//00124A Dedicated Devices, Inc.
//001243, "Cisco Systems, Inc
//0011D9, "TiVo
//0011D2, "Perception Digital Ltd
//0011CF Thrane & Thrane A/S
//0011D4, "NetEnrich, Inc
//0011D5, "Hangzhou Sunyard System Engineering Co., Ltd.
//0011F8, "AIRAYA Corp
//0011F4, "woori-net
//0011F6, "Asia Pacific Microsystems , Inc.
//0011F0, "Wideful Limited
//0011F1, "QinetiQ Ltd
//0011ED, "802 Global
//001211, "Protechna Herbst GmbH & Co.KG
//001219, "General Datacomm LLC
//001216, "ICP Internet Communication Payment AG
//001215, "iStor Networks, Inc.
//001203, "ActivNetworks
//0011CC Guangzhou Jinpeng Group Co., Ltd.
//0011C7 Raymarine UK Ltd
//0011C9 MTT Corporation
//0011DB Land-Cellular Corporation
//001224, "NexQL Corporation
//0011BD Bombardier Transportation
//0011AA Uniclass Technology, Co., LTD
//001179, "Singular Technology Co.Ltd.
//00118A Viewtran Technology Limited
//001184, "Humo Laboratory, Ltd.
//0011B1 BlueExpert Technology Corp.
//0011A6 Sypixx Networks
//0011B5 Shenzhen Powercom Co., Ltd
//0011BB Cisco Systems, Inc
//001166, "Taelim Electronics Co., Ltd.
//001164, "ACARD Technology Corp.
//0011A2 Manufacturing Technology Inc
//00119E, "Solectron Brazil
//001173, "SMART Storage Systems
//001125, "IBM Corp
//00111C Pleora Technologies Inc.
//00111F, "Doremi Labs, Inc.
//00111D, "Hectrix Limited
//001119, "Solteras, Inc.
//001150, "Belkin Corporation
//001146, "Telecard-Pribor Ltd
//00110D, "SANBlaze Technology, Inc.
//001106, "Siemens NV (Belgium)
//000FF4 Guntermann & Drunck GmbH
//000FF8 Cisco Systems, Inc
//00112C IZT GmbH
//001114, "EverFocus Electronics Corp.
//00110E, "Tsurusaki Sealand Transportation Co. Ltd.
//00114C caffeina applied research ltd.
//001141, "GoodMan Corporation
//001155, "Sevis Systems
//001152, "Eidsvoll Electronics AS
//000FCF DataWind Research
//000FD2 EWA Technologies, Inc.
//000FCE Kikusui Electronics Corp.
//000FEB Cylon Controls
//000FDC Ueda Japan Radio Co., Ltd.
//000F8E, "DONGYANG TELECOM CO., LTD.
//000F91, "Aerotelecom Co., Ltd.
//000F87, "Maxcess International
//000FA1 Gigabit Systems Inc.
//000F99, "APAC opto Electronics Inc.
//000FF5 GN&S company
//000FE8 Lobos, Inc.
//000FB2 Broadband Pacenet (India) Pvt. Ltd.
//000FD7 Harman Music Group
//000FD4 Soundcraft
//000FAF Dialog Inc.
//000FA5 BWA Technology GmbH
//000F80, "Trinity Security Systems, Inc.
//000F32, "Lootom Telcovideo Network Wuxi Co Ltd
//000F2A Cableware Electronics
//000F29, "Augmentix Corporation
//000F27, "TEAL Electronics, Inc.
//000F43, "Wasabi Systems Inc.
//000F48, "Polypix Inc.
//000F50, "StreamScale Limited
//000F4E, "Cellink
//000F47, "ROBOX SPA
//000F18, "Industrial Control Systems
//000F1D, "Cosmo Techs Co., Ltd.
//000F1B Ego Systems Inc.
//000F78, "Datacap Systems Inc
//000F70, "Wintec Industries, inc.
//000F74, "Qamcom Technology AB
//000F6D, "Midas Engineering
//000F5F, "Nicety Technologies Inc. (NTS)
//000F5A Peribit Networks
//000F31, "Allied Vision Technologies Canada Inc
//000F73, "RS Automation Co., Ltd
//000F3C Endeleo Limited
//000EAB Cray Inc
//000EAD Metanoia Technologies, Inc.
//000EAF CASTEL
//000EF8, "SBC ASI
//000EF9, "REA Elektronik GmbH
//000EE6 Adimos Systems LTD
//000EF6, "E-TEN Information Systems Co., Ltd.
//000EEA Shadong Luneng Jicheng Electronics, Co., Ltd
//000F0F, "Real ID Technology Co., Ltd.
//000F16, "JAY HOW TECHNOLOGY CO.,
//000EC6 ASIX ELECTRONICS CORP.
//000EBF Remsdaq Limited
//000EFF Megasolution, Inc.
//000EE0 Mcharge
//000E9F, "TEMIC SDS GmbH
//000E96, "Cubic Defense Applications, Inc.
//000E8E SparkLAN Communications, Inc.
//000E91, "Navico Auckland Ltd
//000E48, "Lipman TransAction Solutions
//000E3E Sun Optronics Inc
//000E33, "Shuko Electronics Co., Ltd
//000E75, "New York Air Brake Corp.
//000E7C Televes S.A.
//000E66, "Hitachi Industry & Control Solutions, Ltd.
//000E68, "E-TOP Network Technology Inc.
//000E5E Raisecom Technology
//000E56, "4G Systems GmbH & Co.KG
//000E55, "AUVITRAN
//000E73, "Tpack A/S
//000E72, "CTS electronics
//000E6E MAT S.A. (Mircrelec Advanced Technology)
//000E84, "Cisco Systems, Inc
//000E87, "adp Gauselmann GmbH
//000E92, "Open Telecom
//000E53, "AV TECH CORPORATION
//000DF9 NDS Limited
//000DFD Huges Hi-Tech Inc.,
//000DFB Komax AG
//000E00, "Atrie
//000DF4 Watertek Co.
//000DFA Micro Control Systems Ltd.
//000DFC ITFOR Inc.
//000DFE Hauppauge Computer Works, Inc.
//000DD6 ITI", "", "LTD
//000DD5 O'RITE TECHNOLOGY CO.,LTD
//000E0F, "ERMME
//000E10, "C-guys, Inc.
//000E0A SAKUMA DESIGN OFFICE
//000E0E ESA elettronica S.P.A.
//000E18, "MyA Technology
//000E14, "Visionary Solutions, Inc.
//000E1B IAV GmbH
//000E13, "Accu-Sort Systems inc.
//000DDE Joyteck Co., Ltd.
//000DE2 CMZ Sistemi Elettronici
//000DDA ALLIED TELESIS K.K.
//000DCD GROUPE TXCOM
//000DCA Tait Electronics
//000DCF Cidra Corp.
//000E3A Cirrus Logic
//000E3B Hawking Technologies, Inc.
//000DEC Cisco Systems, Inc
//000DF2 Private
//000E27, "Crere Networks, Inc.
//000DA0 NEDAP N.V.
//000D8E, "Koden Electronics Co., Ltd.
//000D8A Winners Electronics Co., Ltd.
//000D7E, "Axiowave Networks, Inc.
//000D71, "boca systems
//000D5A Tiesse SpA
//000DB8 SCHILLER AG
//000DC4 Emcore Corporation
//000D9B Heraeus Electro-Nite International N.V.
//000D7C Codian Ltd
//000D6B Mita-Teknik A/S
//000D43, "DRS Tactical Systems Inc.
//000D44, "Audio BU - Logitech
//000D36, "Wu Han Routon Electronic Co., Ltd
//000D3D, "Hammerhead Systems, Inc.
//000D3E, "APLUX Communications Ltd.
//000D0D, "ITSupported, LLC
//000D06, "Compulogic Limited
//000D4A Steag ETA-Optik
//000D4F, "Kenwood Corporation
//000D47, "Collex
//000D61, "Giga-Byte Technology Co., Ltd.
//000D3B Microelectronics Technology Inc.
//000D2D, "NCT Deutschland GmbH
//000D1E, "Control Techniques
//000D52, "Comart system
//000D1A Mustek System Inc.
//000CB8 MEDION AG
//000CBB ISKRAEMECO
//000CC0 Genera Oy
//000CA8 Garuda Networks Corporation
//000D03, "Matrics, Inc.
//000CFF MRO-TEK Realty Limited
//000CFA Digital Systems Corp
//000CFD Hyundai ImageQuest Co., Ltd.
//000CD3 Prettl Elektronik Radeberg GmbH
//000CD7 Nallatech Ltd
//000CD4 Positron Public Safety Systems inc.
//000CD6 PARTNER TECH
//000CB9 LEA
//000CBD Interface Masters, Inc
//000CB2 UNION co., ltd.
//000CEB CNMP Networks, Inc.
//000CCC Aeroscout Ltd.
//000CC7 Intelligent Computer Solutions Inc.
//000CBE Innominate Security Technologies AG
//000CA7 Metro (Suzhou) Technologies Co., Ltd.
//000CEF Open Networks Engineering Ltd
//000C64 X2 MSA Group
//000CA0 StorCase Technology, Inc.
//000C99 HITEL LINK Co., Ltd
//000C5A IBSmm Embedded Electronics Consulting
//000C5E Calypso Medical
//000C61 AC Tech corporation DBA Advanced Digital
//000C5F Avtec, Inc.
//000C4B Cheops Elektronik
//000C45 Animation Technologies Inc.
//000C3C MediaChorus, Inc.
//000C7C Internet Information Image Inc.
//000C7B ALPHA PROJECT Co., Ltd.
//000C77 Life Racing Ltd
//000C69 National Radio Astronomy Observatory
//000C66 Pronto Networks Inc
//000C88 Apache Micro Peripherals, Inc.
//000C82 NETWORK TECHNOLOGIES INC
//000C8D MATRIX VISION GmbH
//000C89 AC Electric Vehicles, Ltd.
//000C4E Winbest Technology CO, LT
//000BFE CASTEL Broadband Limited
//000BF5 Shanghai Sibo Telecom Technology Co., Ltd
//000C27 Sammy Corporation
//000C2A OCTTEL Communication Co., Ltd.
//000C1C MicroWeb Co., Ltd.
//000BDF Shenzhen RouterD Networks Limited
//000BE6 Datel Electronics
//000BF2 Chih-Kan Technology Co., Ltd.
//000BEB Systegra AG
//000BEF Code Corporation
//000C05 RPA Reserch Co., Ltd.
//000C22 Double D Electronics Ltd
//000C0F Techno-One Co., Ltd
//000C38 TelcoBridges Inc.
//000BAF WOOJU COMMUNICATIONS Co,.Ltd
//000BB6 Metalligence Technology Corp.
//000BB3 RiT technologies Ltd.
//000BB7 Micro Systems Co., Ltd.
//000BBA Harmonic, Inc
//000B62 ib-mohnen KG
//000B64 Kieback & Peter GmbH & Co KG
//000B67 Topview Technology Corporation
//000B7D SOLOMON EXTREME INTERNATIONAL LTD.
//000B94 Digital Monitoring Products, Inc.
//000BAE Vitals System Inc.
//000BD9 General Hydrogen
//000BAB Advantech Technology (CHINA) Co., Ltd.
//000B6D SOLECTRON JAPAN NAKANIIDA
//000BC4 BIOTRONIK GmbH & Co
//000B57 Silicon Laboratories
//000B51 Micetek International Inc.
//000B53 INITIUM Co., Ltd.
//000AFB Ambri Limited
//000AFF Kilchherr Elektronik AG
//000B4A Visimetrics (UK) Ltd
//000B48 sofrel
//000B1E KAPPA opto-electronics GmbH
//000B1C SIBCO bv
//000B37 MANUFACTURE DES MONTRES ROLEX SA
//000AF8 American Telecare Inc.
//000B17 MKS Instruments
//000B2D Danfoss Inc.
//000AA3 SHIMAFUJI ELECTRIC CO., LTD.
//000AA7 FEI Electron Optics
//000AA6 Hochiki Corporation
//000A9A Aiptek International Inc
//000A94 ShangHai cellink CO., LTD
//000A97 SONICblue, Inc.
//000A92 Presonus Corporation
//000A85 PLAT'C2,Inc
//000AD0 Niigata Develoment Center, F.I.T.Co., Ltd.
//000AD4 CoreBell Systems Inc.
//000ACA YOKOYAMA SHOKAI CO., Ltd.
//000ACE RADIANTECH, INC.
//000AC7 Unication Group
//000ADE Happy Communication Co., Ltd.
//000AE2 Binatone Electronics International, Ltd
//000ADB Trilliant
//000AB8 Cisco Systems, Inc
//000AAC TerraTec Electronic GmbH
//000ABF HIROTA SS
//000ABC Seabridge Ltd.
//000A50 REMOTEK CORPORATION
//000A58 Freyer & Siegel Elektronik GmbH & Co.KG
//000A4E UNITEK Electronics INC.
//000A62 Crinis Networks, Inc.
//000A6A SVM Microwaves s.r.o.
//000A66 MITSUBISHI ELECTRIC SYSTEM & SERVICE CO., LTD.
//000A31 HCV Consulting
//004252, "RLX Technologies
//000A70 MPLS Forum
//000A72 STEC, INC.
//000A3D Elo Sistemas Eletronicos S.A.
//000A46 ARO WELDING TECHNOLOGIES SAS
//000A71 Avrio Technologies, Inc
//000A64 Eracom Technologies
//000A83 SALTO SYSTEMS S.L.
//000A86 Lenze
//000A3F Data East Corporation
//000A0C Scientific Research Corporation
//0009F6, "Shenzhen Eastern Digital Tech Ltd.
//000A20 SVA Networks, Inc.
//000A24 Octave Communications
//000A19 Valere Power, Inc.
//0009E5, "Hottinger Baldwin Messtechnik GmbH
//0009DE Samjin Information & Communications Co., Ltd.
//0009E0, "XEMICS S.A.
//000A01 SOHOware, Inc.
//0009EC Daktronics, Inc.
//0009EE MEIKYO ELECTRIC CO., LTD
//0009CA iMaxNetworks(Shenzhen) Limited.
//0009CF iAd GmbH
//000A11 ExPet Technologies, Inc
//000A0F Ilryung Telesys, Inc
//0009E7, "ADC Techonology
//000993, "Visteon Corporation
//000999, "CP GEORGES RENAULT
//000994, "Cronyx Engineering
//0009B9 Action Imaging Solutions
//0009AC LANVOICE
//0009B1 Kanematsu Electronics, Ltd.
//0009B0 Onkyo Corporation
//000979, "Advanced Television Systems Committee, Inc.
//000963, "Dominion Lasercom Inc.
//000966, "TRIMBLE EUROPE BV
//0009C1 PROCES-DATA A/S
//0009BB MathStar, Inc.
//000968, "TECHNOVENTURE, INC.
//000961, "Switchgear and Instrumentation Ltd
//00097C Cisco Systems, Inc
//00097B Cisco Systems, Inc
//00099D, "Haliplex Communications
//00099E, "Testech, Inc.
//000988, "Nudian Electron Co., Ltd.
//00098E, "ipcas GmbH
//0009AB Netcontrol Oy
//000960, "YOZAN Inc.
//000956, "Network Systems Group, Ltd. (NSG)
//000900, "TMT
//000901, "Shenzhen Shixuntong Information & Technoligy Co
//000913, "SystemK Corporation
//00090E, "Helix Technology Inc.
//00093C Jacques Technologies P/L
//000935, "Sandvine Incorporated
//000936, "Ipetronik GmbH & Co.KG
//000937, "Inventec Appliance Corp
//000946, "Cluster Labs GmbH
//00093F, "Double-Win Enterpirse CO., LTD
//000948, "Vista Control Systems, Corp.
//000949, "Glyph Technologies Inc.
//00092A MYTECS Co., Ltd.
//000925, "VSN Systemen BV
//0008E0, "ATO Technology Ltd.
//0008E4, "Envenergy Inc
//0008E3, "Cisco Systems, Inc
//0008E5, "IDK Corporation
//0008D9, "Mitadenshi Co., LTD
//000891, "Lyan Inc.
//000892, "EM Solutions
//00088C Quanta Network Systems Inc.
//00088A Minds@Work
//0008FD BlueKorea Co., Ltd.
//0008F8, "UTC CCS
//0008D5, "Vanguard Networks Solutions, LLC
//0008CD With-Net Inc
//0008CC Remotec, Inc.
//0008D1, "KAREL INC.
//0008A7 iLogic Inc.
//000899, "Netbind, Inc.
//0008A0 Stotz Feinmesstechnik GmbH
//0008BC Ilevo AB
//0008BD TEPG-US
//0008AE PacketFront Network Products AB
//0008C3 Contex A/S
//0008F3, "WANY
//0008DE", "3UP Systems
//000822, "InPro Comm
//000823, "Texa Corp.
//00081D, "Ipsil, Incorporated
//00082D, "Indus Teqsite Private Limited
//000820, "Cisco Systems, Inc
//000828, "Koei Engineering Ltd.
//000824, "Nuance Document Imaging
//00086C Plasmon LMS
//000868, "PurOptix
//000869, "Command-e Technology Co., Ltd.
//000862, "NEC Eluminant Technologies, Inc.
//000803, "Cos Tron
//000805, "Techno-Holon Corporation
//000808, "PPT Vision, Inc.
//000814, "TIL Technologies
//00085C Shanghai Dare Technologies Co.Ltd.
//00082C Homag AG
//000821, "Cisco Systems, Inc
//000887, "Maschinenfabrik Reinhausen GmbH
//000877, "Liebert-Hiross Spa
//00087B RTX Telecom A/S
//000861, "SoftEnergy Co., Ltd.
//00084F, "Qualstar Corporation
//000854, "Netronix, Inc.
//000876, "SDSystem
//000870, "Rasvia Systems, Inc.
//00086E, "Hyglo AB
//0007FD LANergy Ltd.
//0007FE Rigaku Corporation
//00047D, "Pelco
//0007BF Armillaire Technologies, Inc.
//0007BB Candera Inc.
//0007BD Radionet Ltd.
//0007C4 JEAN Co.Ltd.
//0007B6 Telecom Technology Ltd.
//0007B7 Samurai Ind.Prods Eletronicos Ltda
//0007B0 Office Details, Inc.
//0007D9, "Splicecom
//0007DA Neuro Telecom Co., Ltd.
//0007CD Kumoh Electronic Co, Ltd
//0007CF Anoto AB
//0007D2, "Logopak Systeme GmbH & Co.KG
//0007C9 Technol Seven Co., Ltd.
//0007C7 Synectics Systems Limited
//0007C3 Thomson
//0007A5 Y.D.K Co. Ltd.
//00079C Golden Electronics Technology Co., Ltd.
//0007E4, "SoftRadio Co., Ltd.
//00078E, "Garz & Friche GmbH
//000754, "Xyterra Computing, Inc.
//000757, "Topcall International AG
//000753, "Beijing Qxcomm Technology Co., Ltd.
//00074C Beicom Inc.
//00074D, "Zebra Technologies Corp.
//000732, "AAEON Technology Inc.
//000725, "Bematech International Corp.
//000723, "ELCON Systemtechnik GmbH
//00071D, "Satelsa Sistemas Y Aplicaciones De Telecomunicaciones, S.A.
//000720, "Trutzschler GmbH & Co.KG
//00076E, "Sinetica Corporation Limited
//00076F, "Synoptics Limited
//000773, "Ascom Powerline Communications Ltd.
//00076C Daehanet, Inc.
//00075D, "Celleritas Inc.
//00073F, "Woojyun Systec Co., Ltd.
//000728, "Neo Telecom
//00072C Fabricom
//00072D, "CNSystems
//00072F, "Intransa, Inc.
//000780, "Bluegiga Technologies OY
//000777, "Motah Ltd.
//000724, "Telemax Co., Ltd.
//00071B CDVI Americas Ltd
//000715, "General Research of Electronics, Inc.
//000737, "Soriya Co. Ltd.
//000734, "ONStor, Inc.
//000765, "Jade Quantum Technologies, Inc.
//0005EA Rednix
//0006C9 Technical Marketing Research, Inc.
//0006C8 Sumitomo Metal Micro Devices, Inc.
//0006F1, "Optillion
//0006A7 Primarion
//0006A9 Universal Instruments Corp.
//00069E, "UNIQA, Inc.
//0006B1 Sonicwall
//0006AD KB Electronics Ltd.
//0006AF Xalted Networks
//0006D7, "Cisco Systems, Inc
//0006D5, "Diamond Systems Corp.
//0006FD Comjet Information Systems Corp.
//0006F9, "Mitsui Zosen Systems Research Inc.
//0006C0 United Internetworks, Inc.
//0006E0, "MAT Co., Ltd.
//00D0B9, "MICROTEK INTERNATIONAL, INC.
//00D05F, "VALCOM, INC.
//000675, "Banderacom, Inc.
//000698, "egnite GmbH
//00069C Transmode Systems AB
//000643, "SONO Computer Co., Ltd.
//000649, "3M Deutschland GmbH
//00063E, "Opthos Inc.
//00063B Arcturus Networks Inc.
//00067B Toplink C&C Corporation
//000670, "Upponetti Oy
//00066F, "Korea Data Systems
//000668, "Vicon Industries Inc.
//00066D, "Compuprint S.P.A.
//000626, "MWE GmbH
//000620, "Serial System Ltd.
//000618, "DigiPower Manufacturing Inc.
//000633, "Cross Match Technologies GmbH
//000686, "ZARDCOM Co., Ltd.
//000689, "yLez Technologies Pte Ltd
//000681, "Goepel Electronic GmbH
//000658, "Helmut Fischer GmbH Institut für Elektronik und Messtechnik
//0005D3, "eProduction Solutions, Inc.
//000604, "@Track Communications, Inc.
//000606, "RapidWAN, Inc.
//000603, "Baker Hughes Inc.
//000607, "Omni Directional Control Technology Inc.
//0005F7, "Analog Devices, Inc.
//00059C Kleinknecht GmbH, Ing.Büro
//0005AE Mediaport USA
//0005B0 Korea Computer Technology Co., Ltd.
//0005B2 Medison Co., Ltd.
//000597, "Eagle Traffic Control Systems
//0005B5 Broadcom Technologies
//0005CB ROIS Technologies, Inc.
//0005C8 VERYTECH
//0005CD D&M Holdings Inc.
//0005A2 CELOX Networks
//0005AA Moore Industries International Inc.
//0005E7, "Netrake an AudioCodes Company
//0005F4, "System Base Co., Ltd.
//0005E1, "Trellis Photonics, Ltd.
//0005E2, "Creativ Network Technologies
//000613, "Kawasaki Microelectronics Incorporated
//000617, "Redswitch Inc.
//000551, "F & S Elektronik Systeme GmbH
//00054D, "Brans Technologies, Inc.
//000547, "Starent Networks
//00054E, "Philips
//000546, "KDDI Network & Solultions Inc.
//000540, "FAST Corporation
//00053C XIRCOM
//000544, "Valley Technologies, Inc.
//00052E, "Cinta Networks
//00052F, "Leviton Network Solutions
//00053B Harbour Networks Ltd., Co.Beijing
//000528, "New Focus, Inc.
//00056B C.P.Technology Co., Ltd.
//000560, "LEADER COMM.CO., LTD
//00055E, "Cisco Systems, Inc
//000596, "Genotech Co., Ltd.
//000579, "Universal Control Solution Corp.
//00057F, "Acqis Technology
//000573, "Cisco Systems, Inc
//000575, "CDS-Electronics BV
//000556, "360 Systems
//000559, "Intracom S.A.
//00058C Opentech Inc.
//0004C9 Micro Electron Co., Ltd.
//0004BE OptXCon, Inc.
//0004C4 Audiotonix Group Limited
//0004C1 Cisco Systems, Inc
//0004D6, "Takagi Industrial Co., Ltd.
//0004D1, "Drew Technologies, Inc.
//0004D0, "Softlink s.r.o.
//008087, "OKI ELECTRIC INDUSTRY CO., LTD
//0004D9, "Titan Electronics, Inc.
//0004D8, "IPWireless, Inc.
//000524, "BTL System (HK) Limited
//000522, "LEA* D Corporation, Inc.
//000520, "Smartronix, Inc.
//0004EB Paxonet Communications, Inc.
//0004EF, "Polestar Corp.
//000514, "KDT Systems Co., Ltd.
//00050B SICOM Systems, Inc.
//000505, "Systems Integration Solutions, Inc.
//0004FE Pelago Networks
//000518, "Jupiters Technology
//0004B7 AMB i.t.Holding
//0004B9 S.I.Soubou, Inc.
//0004BB Bardac Corporation
//0004BC Giantec, Inc.
//0004AF Digital Fountain, Inc.
//000456, "Cambium Networks Limited
//000458, "Fusion X Co., Ltd.
//00044F, "Schubert System Elektronik Gmbh
//000446, "CYZENTECH Co., Ltd.
//00044A iPolicy Networks, Inc.
//000440, "cyberPIXIE, Inc.
//00043C SONOS Co., Ltd.
//0004B2 ESSEGI SRL
//0004B4 CIAC
//0004AD Malibu Networks
//0004A9 SandStream Technologies, Inc.
//000461, "EPOX Computer Co., Ltd.
//000462, "DAKOS Data & Communication Co., Ltd.
//00045F, "Avalue Technology, Inc.
//00049C Surgient Networks, Inc.
//00049D, "Ipanema Technologies
//000460, "Knilink Technology, Inc.
//00048F, "TD Systems Corporation
//000495, "Tejas Networks India Limited
//00046F, "Digitel S/A Industria Eletronica
//000469, "Innocom, Inc.
//000487, "Cogency Semiconductor, Inc.
//000468, "Vivity, Inc.
//0003E1, "Winmate Communication, Inc.
//0003E4, "Cisco Systems, Inc
//0003DC Lexar Media, Inc.
//0003D8, "iMPath Networks, Inc.
//0003D5, "Advanced Communications Co., Ltd.
//0003F7, "Plast-Control GmbH
//0003FC Intertex Data AB
//0003EF, "Oneline AG
//0003F1, "Cicada Semiconductor, Inc.
//000430, "Netgem
//00042C Minet, Inc.
//00042A Wireless Networks, Inc.
//00042B IT Access Co., Ltd.
//0003D6, "RADVision, Ltd.
//0003D4, "Alloptic, Inc.
//0003CE ETEN Technologies, Inc.
//0003C8 CML Emergency Services
//0003C3 Micronik Multimedia
//000419, "Fibercycle Networks, Inc.
//00041C ipDialog, Inc.
//000418, "Teltronic S.A.U.
//000370, "NXTV, Inc.
//000402, "Nexsan Technologies, Ltd.
//0003ED, "Shinkawa Electric Co., Ltd.
//0003BD OmniCluster Technologies, Inc.
//0003C0 RFTNC Co., Ltd.
//0003B8 NetKit Solutions, LLC
//0003B7 ZACCESS Systems
//0003A0 Cisco Systems, Inc
//0003A2 Catapult Communications
//00039C OptiMight Communications, Inc.
//0003B0 Xsense Technology Corp.
//0003AA Watlow
//0003A8 IDOT Computers, Inc.
//000355, "TeraBeam Internet Systems
//000369, "Nippon Antenna Co., Ltd.
//000373, "Aselsan A.S
//000377, "Gigabit Wireless
//000365, "Kira Information & Communications, Ltd.
//000385, "Actelis Networks, Inc.
//000354, "Fiber Logic Communications
//000350, "BTICINO SPA
//000351, "Diebold, Inc.
//00034E, "Pos Data Company, Ltd.
//000348, "Norscan Instruments, Ltd.
//000346, "Hitachi Kokusai Electric, Inc.
//000344, "Tietech.Co., Ltd.
//0002E6, "Gould Instrument Systems, Inc.
//0002E4, "JC HYUN Systems, Inc.
//0002DE Astrodesign, Inc.
//0002E2, "NDC Infared Engineering
//0002E1, "Integrated Network Corporation
//0002F7, "ARM
//00D024, "Cognex Corporation
//0002F1, "Pinetron Co., Ltd.
//0002ED, "DXO Telecom Co., Ltd.
//0002EC Maschoff Design Engineering
//000336, "Zetes Technologies
//000337, "Vaone, Inc.
//00033B TAMI Tech Co., Ltd.
//00032D, "IBASE Technology, Inc.
//00B052 Atheros Communications
//000343, "Martin Professional A/S
//000335, "Mirae Technology
//0002F8, "SEAKR Engineering, Inc.
//000314, "Teleware Network Systems
//00032F, "Global Sun Technology, Inc.
//0002DC Fujitsu General Limited
//0002D7, "EMPEG Ltd
//0002D3, "NetBotz, Inc.
//0002DA ExiO Communications, Inc.
//0002D4, "PDA Peripherals, Inc.
//0002D6, "NICE Systems
//00027D, "Cisco Systems, Inc
//00027C Trilithic, Inc.
//00028B VDSL Systems OY
//00028C Micrel-Synergy Semiconductor
//00028D, "Movita Technologies, Inc.
//000298, "Broadframe Corporation
//000297, "C-COR.net
//000291, "Open Network Co., Ltd.
//0002C1 Innovative Electronic Designs, Inc.
//0002C0 Bencent Tzeng Industry Co., Ltd.
//000299, "Apex, Inc.
//000275, "SMART Technologies, Inc.
//0002C6 Data Track Technology PLC
//0002A6 Effinet Systems Co., Ltd.
//00025F, "Nortel Networks
//00025C SCI Systems (Kunshan) Co., Ltd.
//000087, "HITACHI, LTD.
//000258, "Flying Packets Communications
//00024E, "Datacard Group
//000242, "Videoframe Systems
//000244, "SURECOM Technology Co.
//00023E, "Selta Telematica S.p.a
//000241, "Amer.com
//000207, "VisionGlobal Network Corp.
//000208, "Unify Networks, Inc.
//000204, "Bodmann Industries Elektronik GmbH
//000229, "Adtec Corporation
//00022D, "Agere Systems
//000226, "XESystems, Inc.
//000225, "One Stop Systems
//000211, "Nature Worldwide Technology Corp.
//000212, "SierraCom
//000217, "Cisco Systems, Inc
//00017A Chengdu Maipu Electric Industrial Co., Ltd.
//000238, "Serome Technology, Inc.
//000269, "Nadatel Co., Ltd
//000264, "AudioRamp.com
//000255, "IBM Corp
//000252, "Carrier Corporation
//000220, "CANON FINETECH INC.
//00020D, "Micronpc.com
//0001D4, "Leisure Time, Inc.
//0001DD Avail Networks
//0001D5, "HAEDONG INFO & COMM CO., LTD
//0001D7, "F5 Networks, Inc.
//0001DE Trango Systems, Inc.
//0001DC Activetelco
//0001F9, "TeraGlobal Communications Corp.
//0001FB DoTop Technology, Inc.
//0001F8, "TEXIO TECHNOLOGY CORPORATION
//0001BE Gigalink Co., Ltd.
//0001B1 General Bandwidth
//0001BF Teleforce Co., Ltd.
//0001B4 Wayport, Inc.
//0001BA IC-Net, Inc.
//0001CF Alpha Data Parallel Systems, Ltd.
//0001D0, "VitalPoint, Inc.
//0001B0 Fulltek Technology Co., Ltd.
//0001A9 BMW AG
//0001AA Airspan Communications, Ltd.
//00019E, "ESS Technology, Inc.
//00017D, "ThermoQuest
//000181, "Nortel Networks
//000194, "Capital Equipment Corporation
//000198, "Darim Vision
//0001E8, "Force10 Networks, Inc.
//0001E9, "Litton Marine Systems B.V.
//0001E5, "Supernet, Inc.
//0001A2 Logical Co., Ltd.
//000185, "Hitachi Aloka Medical, Ltd.
//0001C7 Cisco Systems, Inc
//000121, "WatchGuard Technologies, Inc.
//000129, "DFI Inc.
//000119, "RTUnet (Australia)
//000122, "Trend Communications, Ltd.
//00011A Hoffmann und Burmeister GbR
//00010A CIS TECHNOLOGY INC.
//000167, "HIOKI E.E.CORPORATION
//000168, "VITANA CORPORATION
//000162, "Cygnet Technologies, Inc.
//000154, "G3M Corporation
//000152, "CHROMATEK INC.
//000150, "GILAT COMMUNICATIONS, LTD.
//000151, "Ensemble Communications
//000115, "EXTRATECH CORPORATION
//000101, "Private
//00010D, "Teledyne DALSA Inc.
//000105, "Beckhoff Automation GmbH
//00B017 InfoGear Technology Corp.
//00012C Aravox Technologies, Inc.
//000142, "Cisco Systems, Inc
//000164, "Cisco Systems, Inc
//00015F, "DIGITAL DESIGN GmbH
//00012B TELENET Co., Ltd.
//00013F, "Neighbor World Co., Ltd.
//000124, "Acer Incorporated
//003088, "Ericsson
//003020, "TSI, Inc..
//003095, "Procomp Informatics, Ltd.
//0030CA Discovery Com
//0030CE Zaffire
//00307B Cisco Systems, Inc
//0030B5 Tadiran Microwave Networks
//0030B8 RiverDelta Networks
//003071, "Cisco Systems, Inc
//00303A MAATEL
//00304E, "BUSTEC PRODUCTION LTD.
//0030A4 Woodwind Communications System
//00303B PowerCom Technology
//0030BC Optronic AG
//00B02D ViaGate Technologies, Inc.
//0030EE DSG Technology, Inc.
//00309E, "WORKBIT CORPORATION.
//0030DE WAGO Kontakttechnik GmbH
//00303E, "Radcom Ltd.
//0030D7, "Innovative Systems, L.L.C.
//00B0CE Viveris Technologies
//00B01C Westport Technologies
//00B04A Cisco Systems, Inc
//00B048 Marconi Communications Inc.
//00301B SHUTTLE, INC.
//003021, "HSING TECH. ENTERPRISE CO., LTD
//00302C SYLANTRO SYSTEMS CORPORATION
//0030DF KB/TEL TELECOMUNICACIONES
//003030, "HARMONIX CORPORATION
//003063, "SANTERA SYSTEMS, INC.
//0030A3 Cisco Systems, Inc
//0030DD INDIGITA CORPORATION
//003099, "BOENIG UND KALLENBACH OHG
//0030F2, "Cisco Systems, Inc
//003051, "ORBIT AVIONIC & COMMUNICATION
//00308E, "CROSS MATCH TECHNOLOGIES, INC.
//003027, "KERBANGO, INC.
//003033, "ORIENT TELECOM CO., LTD.
//003008, "AVIO DIGITAL, INC.
//00301D, "SKYSTREAM, INC.
//0030BA AC&T SYSTEM CO., LTD.
//0030FD INTEGRATED SYSTEMS DESIGN
//0030B9 ECTEL
//00307D, "GRE AMERICA, INC.
//0030EF, "NEON TECHNOLOGY, INC.
//003096, "Cisco Systems, Inc
//003039, "SOFTBOOK PRESS
//00D0F8, "FUJIAN STAR TERMINAL
//00D0ED, "XIOX
//00D097, "Cisco Systems, Inc
//00D08E, "Grass Valley, A Belden Brand
//00D056, "SOMAT CORPORATION
//00D0E0, "DOOIN ELECTRONICS CO.
//00D000, "FERRAN SCIENTIFIC, INC.
//00D0D0, "ZHONGXING TELECOM LTD.
//00D053, "CONNECTED SYSTEMS
//00D033, "DALIAN DAXIAN NETWORK
//00D0D6, "AETHRA TELECOMUNICAZIONI
//00D063, "Cisco Systems, Inc
//00D047, "XN TECHNOLOGIES
//00D055, "KATHREIN-WERKE KG
//00D03B VISION PRODUCTS PTY. LTD.
//00D0B3, "DRS Technologies Canada Ltd
//00D0AF CUTLER-HAMMER, INC.
//00D052, "ASCEND COMMUNICATIONS, INC.
//00D0AD TL INDUSTRIES
//00D0A4 ALANTRO COMMUNICATIONS
//00D0B0, "BITSWITCH LTD.
//00D030, "Safetran Systems Corp
//00302A SOUTHERN INFORMATION
//0030E1, "Network Equipment Technologies, Inc.
//00302B INALP NETWORKS, INC.
//003001, "SMP
//00D08B ADVA Optical Networking Ltd.
//00D0E4, "Cisco Systems, Inc
//00D05A SYMBIONICS, LTD.
//00D079, "Cisco Systems, Inc
//00D021, "REGENT ELECTRONICS CORP.
//00D09F, "NOVTEK TEST SYSTEMS
//00D0FE ASTRAL POINT
//00D0D4, "V-BITS, INC.
//00D084, "NEXCOMM SYSTEMS, INC.
//00D099, "Elcard Wireless Systems Oy
//00D0E7, "VCON TELECOMMUNICATION LTD.
//00D01B MIMAKI ENGINEERING CO., LTD.
//00D00D, "MICROMERITICS INSTRUMENT
//00D054, "SAS INSTITUTE INC.
//00D009, "HSING TECH. ENTERPRISE CO. LTD
//00D0F4, "CARINTHIAN TECH INSTITUTE
//00D07D, "COSINE COMMUNICATIONS
//00D083, "INVERTEX, INC.
//00D0BA Cisco Systems, Inc
//00D098, "Photon Dynamics Canada Inc.
//00D0BE EMUTEC INC.
//00D092, "GLENAYRE WESTERN MULTIPLEX
//00509D, "THE INDUSTREE B.V.
//00D0B8, "Iomega Corporation
//0050F1, "Intel Corporation
//0050CB JETTER
//005058, "Sangoma Technologies
//005074, "ADVANCED HI-TECH CORP.
//00500A IRIS TECHNOLOGIES, INC.
//00506D, "VIDEOJET SYSTEMS
//0050CA NET TO NET TECHNOLOGIES
//00D0C7 PATHWAY, INC.
//00D07A AMAQUEST COMPUTER CORP.
//00503F, "ANCHOR GAMES
//005032, "PICAZO COMMUNICATIONS, INC.
//00D04A PRESENCE TECHNOLOGY GMBH
//00D074, "TAQUA SYSTEMS, INC.
//00504D, "Tokyo Electron Device Limited
//005070, "CHAINTECH COMPUTER CO., LTD.
//005023, "PG DESIGN ELECTRONICS, INC.
//00509E, "Les Technologies SoftAcoustik Inc.
//005071, "AIWA CO., LTD.
//00505F, "BRAND INNOVATORS
//0050B4 SATCHWELL CONTROL SYSTEMS, LTD
//0050D6, "ATLAS COPCO TOOLS AB
//005082, "FORESSON CORPORATION
//0050DF AirFiber, Inc.
//0050C5 ADS Technologies, Inc
//00508E, "OPTIMATION, INC.
//005028, "AVAL COMMUNICATIONS
//00502F, "TollBridge Technologies, Inc.
//0050FE PCTVnet ASA
//0050AB NALTEC, Inc.
//005037, "KOGA ELECTRONICS CO.
//0050A8 OpenCon Systems, Inc.
//00509C BETA RESEARCH
//0050B1 GIDDINGS & LEWIS
//005006, "TAC AB
//005009, "PHILIPS BROADBAND NETWORKS
//005030, "FUTURE PLUS SYSTEMS
//005078, "MEGATON HOUSE, LTD.
//005002, "OMNISEC AG
//00506A EDEVA, INC.
//0050AA KONICA MINOLTA HOLDINGS, INC.
//005038, "DAIN TELECOM CO., LTD.
//0050B7 BOSER TECHNOLOGY CO., LTD.
//009088, "BAXALL SECURITY LTD.
//00906C Sartorius Hamburg GmbH
//0090A4 ALTIGA NETWORKS
//0090F9, "Imagine Communications
//009089, "SOFTCOM MICROSYSTEMS, INC.
//0090EE PERSONAL COMMUNICATIONS TECHNOLOGIES
//009080, "NOT LIMITED, INC.
//0090E8, "MOXA TECHNOLOGIES CORP., LTD.
//0090A1 Flying Pig Systems/High End Systems Inc.
//009079, "ClearOne, Inc.
//00909A ONE WORLD SYSTEMS, INC.
//0090C2 JK microsystems, Inc.
//0050D0, "MINERVA SYSTEMS
//0050D8, "UNICORN COMPUTER CORP.
//0050B2 BRODEL GmbH
//009076, "FMT AIRCRAFT GATE SUPPORT SYSTEMS AB
//009017, "Zypcom, Inc
//009049, "ENTRIDIA CORPORATION
//0090E6, "ALi Corporation
//009070, "NEO NETWORKS, INC.
//009030, "HONEYWELL-DATING
//009008, "HanA Systems Inc.
//0090AC OPTIVISION, INC.
//00904E, "DELEM BV
//0090ED, "CENTRAL SYSTEM RESEARCH CO., LTD.
//00901E, "Selesta Ingegneria S.p.A.
//009075, "NEC DO BRASIL S.A.
//0090AD ASPECT ELECTRONICS, INC.
//009001, "NISHIMU ELECTRONICS INDUSTRIES CO., LTD.
//009043, "Tattile SRL
//0090CB Wireless OnLine, Inc.
//001063, "STARGUIDE DIGITAL NETWORKS
//001023, "Network Equipment Technologies
//00102B UMAX DATA SYSTEMS, INC.
//00908A BAYLY COMMUNICATIONS, INC.
//00900E, "HANDLINK TECHNOLOGIES, INC.
//0090C1 Peco II, Inc.
//00108D, "Johnson Controls, Inc.
//001045, "Nortel Networks
//00107D, "AURORA COMMUNICATIONS, LTD.
//0090E4, "NEC AMERICA, INC.
//009040, "Siemens Network Convergence LLC
//0090C8 WAVERIDER COMMUNICATIONS (CANADA) INC.
//00901B DIGITAL CONTROLS
//0090F7, "NBASE COMMUNICATIONS LTD.
//009012, "GLOBESPAN SEMICONDUCTOR, INC.
//0090B7 DIGITAL LIGHTWAVE, INC.
//0090A0", "8X8 INC.
//009047, "GIGA FAST E.LTD.
//0090E1, "TELENA S.P.A.
//009032, "PELCOMBE GROUP LTD.
//001062, "NX SERVER, ILNC.
//0010F0, "RITTAL-WERK RUDOLF LOH GmbH & Co.
//001001, "Citel
//00105C QUANTUM DESIGNS (H.K.) LTD.
//0010CF FIBERLANE COMMUNICATIONS
//001069, "HELIOSS COMMUNICATIONS, INC.
//0010BF InterAir Wireless
//001026, "ACCELERATED NETWORKS, INC.
//001036, "INTER-TEL INTEGRATED SYSTEMS
//001039, "Vectron Systems AG
//0010B6 ENTRATA COMMUNICATIONS CORP.
//0010EC RPCG, LLC
//001059, "DIABLO RESEARCH CO.LLC
//0010FC BROADBAND NETWORKS, INC.
//001031, "OBJECTIVE COMMUNICATIONS, INC.
//00106D, "Axxcelera Broadband Wireless
//00104C Teledyne LeCroy, Inc
//0010CC CLP COMPUTER LOGISTIK PLANUNG GmbH
//001030, "EION Inc.
//0010D0, "WITCOM, LTD.
//001093, "CMS COMPUTERS, LTD.
//00108F, "RAPTOR SYSTEMS
//0010A4 XIRCOM
//0010F1, "I-O CORPORATION
//001066, "ADVANCED CONTROL SYSTEMS, INC.
//0010AC IMCI TECHNOLOGIES
//0010B1 FOR-A CO., LTD.
//0010EE CTI PRODUCTS, INC.
//001041, "BRISTOL BABCOCK, INC.
//0010AA MEDIA4, INC.
//0010E8, "TELOCITY, INCORPORATED
//0010A2 TNS
//001065, "RADYNE CORPORATION
//00109F, "PAVO, INC.
//00101D, "WINBOND ELECTRONICS CORP.
//001084, "K-BOT COMMUNICATIONS
//001000, "CABLE TELEVISION LABORATORIES, INC.
//001009, "HORANET
//0010F8, "TEXIO TECHNOLOGY CORPORATION
//0010C0 ARMA, Inc.
//00105B NET INSIGHT AB
//001002, "ACTIA
//0010EB SELSIUS SYSTEMS, INC.
//001057, "Rebel.com, Inc.
//0010F9, "UNIQUE SYSTEMS, INC.
//001075, "Segate Technology LLC
//00E003, "NOKIA WIRELESS BUSINESS COMMUN
//00E0F3, "WebSprint Communications, Inc.
//08BBCC AK-NORD EDV VERTRIEBSGES.mbH
//00E0DB ViaVideo Communications, Inc.
//00E0A6 TELOGY NETWORKS, INC.
//00E09F, "PIXEL VISION
//00E0CC HERO SYSTEMS, LTD.
//00E080, "CONTROL RESOURCES CORPORATION
//00E004, "PMC-SIERRA, INC.
//00E03B PROMINET CORPORATION
//00E0F5, "TELES AG
//00E0D7, "SUNSHINE ELECTRONICS, INC.
//00E0B5 ARDENT COMMUNICATIONS CORP.
//00E068, "MERRIMAC SYSTEMS INC.
//00E049, "MICROWI ELECTRONIC GmbH
//00E095, "ADVANCED-VISION TECHNOLGIES CORP.
//00E00E AVALON IMAGING SYSTEMS, INC.
//00E048, "SDL COMMUNICATIONS, INC.
//00E0CB RESON, INC.
//00E0C8 VIRTUAL ACCESS, LTD.
//00E006, "SILICON INTEGRATED SYS.CORP.
//00E0AC MIDSCO, INC.
//00E008, "AMAZING CONTROLS! INC.
//00E0AE XAQTI CORPORATION
//00E0E0 SI ELECTRONICS, LTD.
//00E050, "EXECUTONE INFORMATION SYSTEMS, INC.
//00E023, "TELRAD
//00E02C AST COMPUTER
//00E067, "eac AUTOMATION-CONSULTING GmbH
//00E0FA TRL TECHNOLOGY, LTD.
//00E02A TANDBERG TELEVISION AS
//00E04E SANYO DENKI CO., LTD.
//00E012, "PLUTO TECHNOLOGIES INTERNATIONAL INC.
//00E04C REALTEK SEMICONDUCTOR CORP.
//00E051, "TALX CORPORATION
//00606B Synclayer Inc.
//00603B AMTEC spa
//00E039, "PARADYNE CORP.
//00600B LOGWARE GmbH
//00E0C7 EUROTECH SRL
//00E0AF GENERAL DYNAMICS INFORMATION SYSTEMS
//00E054, "KODAI HITEC CO., LTD.
//00E0B9 BYAS SYSTEMS
//00604B Safe-com GmbH & Co.KG
//00E0EF DIONEX
//00E02D, "InnoMediaLogic, Inc.
//00E035, "Artesyn Embedded Technologies
//00E090, "BECKMAN LAB. AUTOMATION DIV.
//006001, "InnoSys, Inc.
//0060FE LYNX SYSTEM DEVELOPERS, INC.
//0060BD Enginuity Communications
//000800, "MULTITECH SYSTEMS, INC.
//00E085, "GLOBAL MAINTECH, INC.
//00E0BE GENROCO INTERNATIONAL, INC.
//00E0B6 Entrada Networks
//00E0F4, "INSIDE Technology A/S
//00E0A0 WILTRON CO.
//00E0F1, "THAT CORPORATION
//0060D5, "AMADA MIYACHI Co., Ltd
//00603F, "PATAPSCO DESIGNS
//0060B5 KEBA GmbH
//006014, "EDEC CO., LTD.
//0060AC RESILIENCE CORPORATION
//00604E, "CYCLE COMPUTER CORPORATION, INC.
//0060E1, "ORCKIT COMMUNICATIONS LTD.
//0060D2, "LUCENT TECHNOLOGIES TAIWAN TELECOMMUNICATIONS CO., LTD.
//006042, "TKS (USA), INC.
//006079, "Mainstream Data, Inc.
//00609A NJK TECHNO CO.
//00602B PEAK AUDIO
//0060F1, "EXP COMPUTER, INC.
//0060E6, "SHOMITI SYSTEMS INCORPORATED
//0060FF QuVis, Inc.
//006067, "ACER NETXUS INC.
//00609F, "PHAST CORPORATION
//006040, "NETRO CORP.
//0060CC EMTRAK, INCORPORATED
//00602C LINX Data Terminals, Inc.
//00607E, "GIGALABS, INC.
//0060CD VideoServer, Inc.
//0060AA INTELLIGENT DEVICES INC. (IDI)
//006025, "ACTIVE IMAGING PLC
//0060A7 MICROSENS GmbH & CO.KG
//0005A8 WYLE ELECTRONICS
//0060E5, "FUJI AUTOMATION CO., LTD.
//00605E, "LIBERTY TECHNOLOGY NETWORKING
//0060C6 DCS AG
//00601E, "SOFTLAB, INC.
//006065, "BERNECKER & RAINER INDUSTRIE-ELEKTRONIC GmbH
//00605D, "SCANIVALVE CORP.
//00606F, "CLARION CORPORATION OF AMERICA
//00A010 SYSLOGIC DATENTECHNIK AG
//00A059 HAMILTON HALLMARK
//00A039 ROSS TECHNOLOGY, INC.
//00A0AD MARCONI SPA
//00A0D6 SBE, Inc.
//00A02E BRAND COMMUNICATIONS, LTD.
//00604A SAIC IDEAS GROUP
//00A0BD I-TECH CORP.
//006090, "Artiza Networks Inc
//00600D, "Digital Logic GmbH
//006030, "VILLAGE TRONIC ENTWICKLUNG
//00A08D JACOMO CORPORATION
//00A08E Check Point Software Technologies
//00A0FC IMAGE SCIENCES, INC.
//00A09C Xyplex, Inc.
//00A00D THE PANDA PROJECT
//00A0E9 ELECTRONIC RETAILING SYSTEMS INTERNATIONAL
//00A0BE INTEGRATED CIRCUIT SYSTEMS, INC.COMMUNICATIONS GROUP
//00A016 MICROPOLIS CORP.
//00A048 QUESTECH, LTD.
//00A003 Siemens Switzerland Ltd., I B T HVP
//00A0F9 BINTEC COMMUNICATIONS GMBH
//00A0F5 RADGUARD LTD.
//00A0CA FUJITSU DENSO LTD.
//00A022 CENTRE FOR DEVELOPMENT OF ADVANCED COMPUTING
//00A0B6 SANRITZ AUTOMATION CO., LTD.
//00A079 ALPS ELECTRIC (USA), INC.
//00A0C0 DIGITAL LINK CORP.
//00A01E EST CORPORATION
//00A0AE NUCOM SYSTEMS, INC.
//00A062 AES PRODATA
//00A076 CARDWARE LAB, INC.
//00A0A1 EPIC DATA INC.
//00A044 NTT IT CO., LTD.
//00A011 MUTOH INDUSTRIES LTD.
//00A0BA PATTON ELECTRONICS CO.
//00A0B5", "3H TECHNOLOGY
//00A04D EDA INSTRUMENTS, INC.
//00A086 AMBER WAVE SYSTEMS, INC.
//00A0AF WMS INDUSTRIES
//00A057 LANCOM Systems GmbH
//00A030 CAPTOR NV/SA
//00A0DE YAMAHA CORPORATION
//00A084 Dataplex Pty Ltd
//00A049 DIGITECH INDUSTRIES, INC.
//00A09D JOHNATHON FREEMAN TECHNOLOGIES
//00A06B DMS DORSCH MIKROSYSTEM GMBH
//00A0F8 Zebra Technologies Inc
//00A09F COMMVISION CORP.
//00A06E AUSTRON, INC.
//002022, "NMS Communications
//0020AE ORNET DATA COMMUNICATION TECH.
//0020AA Ericsson Television Limited
//0020A4 MULTIPOINT NETWORKS
//000267, "NODE RUNNER, INC.
//0020B1 COMTECH RESEARCH INC.
//002032, "ALCATEL TAISEL
//0020E9, "DANTEL
//002038, "VME MICROSYSTEMS INTERNATIONAL CORPORATION
//0020A3 Harmonic, Inc
//002059, "MIRO COMPUTER PRODUCTS AG
//002034, "ROTEC INDUSTRIEAUTOMATION GMBH
//002079, "MIKRON GMBH
//002005, "SIMPLE TECHNOLOGY
//002018, "CIS TECHNOLOGY INC.
//002098, "HECTRONIC AB
//0020FD ITV TECHNOLOGIES, INC.
//0020FA GDE SYSTEMS, INC.
//0020C1 SAXA, Inc.
//002080, "SYNERGY (UK) LTD.
//00C023 TUTANKHAMON ELECTRONICS
//00C08B RISQ MODULAR SYSTEMS, INC.
//0020C4 INET, INC.
//002074, "SUNGWOON SYSTEMS
//00203C EUROTIME AB
//002028, "WEST EGG SYSTEMS, INC.
//002068, "ISDYNE
//0020C8 LARSCOM INCORPORATED
//00209D, "LIPPERT AUTOMATIONSTECHNIK
//00209C PRIMARY ACCESS CORP.
//00206D, "DATA RACE, INC.
//00203A DIGITAL BI0METRICS INC.
//002048, "Marconi Communications
//0020DC DENSITRON TAIWAN LTD.
//00200C ADASTRA SYSTEMS CORP.
//002011, "CANOPUS CO., LTD.
//002051, "Verilink Corporation
//00203B WISDM LTD.
//0020BA CENTER FOR HIGH PERFORMANCE
//0020F5, "PANDATEL AG
//00200E, "NSSLGlobal Technologies AS
//0020E7, "B&W NUCLEAR SERVICE COMPANY
//0020F0, "UNIVERSAL MICROELECTRONICS CO.
//002089, "T3PLUS NETWORKING, INC.
//002061, "GarrettCom, Inc.
//00C080 NETSTAR, INC.
//00C0B4 MYSON TECHNOLOGY, INC.
//00C045 ISOLATION SYSTEMS, LTD.
//0070B3 DATA RECALL LTD.
//0070B0 M/A-COM INC. COMPANIES
//00E6D3, "NIXDORF COMPUTER CORP.
//00C0C3 ACUSON COMPUTED SONOGRAPHY
//00C0B3 COMSTAT DATACOMM CORPORATION
//00C0E5 GESPAC, S.A.
//00C04D MITEC, INC.
//00C047 UNIMICRO SYSTEMS, INC.
//00C084 DATA LINK CORP. LTD.
//00C041 DIGITAL TRANSMISSION SYSTEMS
//00C01F S.E.R.C.E.L.
//006086, "LOGIC REPLACEMENT TECH.LTD.
//00C059 DENSO CORPORATION
//00C0F1 SHINKO ELECTRIC CO., LTD.
//00C0A1 TOKYO DENSHI SEKEI CO.
//00C02E NETWIZ
//00C00D ADVANCED LOGIC RESEARCH, INC.
//00C081 METRODATA LTD.
//00C03B MULTIACCESS COMPUTING CORP.
//00C082 MOORE PRODUCTS CO.
//00C099 YOSHIKI INDUSTRIAL CO., LTD.
//00C001 DIATEK PATIENT MANAGMENT
//00C0F4 INTERLINK SYSTEM CO., LTD.
//00C0E2 CALCOMP, INC.
//00C07B ASCEND COMMUNICATIONS, INC.
//00C03C TOWER TECH S.R.L.
//00C01D GRAND JUNCTION NETWORKS, INC.
//00C035 QUINTAR COMPANY
//00C070 SECTRA SECURE-TRANSMISSION AB
//00C06D BOCA RESEARCH, INC.
//00C0EA ARRAY TECHNOLOGY LTD.
//00C009 KT TECHNOLOGY (S) PTE LTD
//00C0D6 J1 SYSTEMS, INC.
//00C0DC EOS TECHNOLOGIES, INC.
//00C072 KNX LTD.
//00C0AE TOWERCOM CO.INC.DBA PC HOUSE
//00C0C2 INFINITE NETWORKS LTD.
//00C0AF TEKLOGIX INC.
//00C07A PRIVA B.V.
//00C0F6 CELAN TECHNOLOGY INC.
//00C0F8 ABOUT COMPUTING INC.
//00C078 COMPUTER SYSTEMS ENGINEERING
//00C09A PHOTONICS CORPORATION
//00C01A COROMETRICS MEDICAL SYSTEMS
//00C068 HME Clear-Com LTD.
//00C0D8 UNIVERSAL DATA SYSTEMS
//004036, "Zoom Telephonics, Inc
//004016, "ADC - Global Connectivity Solutions Division
//00406A KENTEK INFORMATION SYSTEMS, INC
//00400A PIVOTAL TECHNOLOGIES, INC.
//004099, "NEWGEN SYSTEMS CORP.
//004011, "ANDOVER CONTROLS CORPORATION
//0040A1 ERGO COMPUTING
//004081, "MANNESMANN SCANGRAPHIC GMBH
//00C08C PERFORMANCE TECHNOLOGIES, INC.
//00C007 PINNACLE DATA SYSTEMS, INC.
//00C098 CHUNTEX ELECTRONIC CO., LTD.
//00C0BE ALCATEL - SEL
//00C06E HAFT TECHNOLOGY, INC.
//00C08A Lauterbach GmbH
//00C0F7 ENGAGE COMMUNICATION, INC.
//0040B7 STEALTH COMPUTER SYSTEMS
//0040AC SUPER WORKSTATION, INC.
//10005A IBM Corp
//0040D1, "FUKUDA DENSHI CO., LTD.
//004069, "LEMCOM SYSTEMS, INC.
//00403B SYNERJET INTERNATIONAL CORP.
//00803B APT COMMUNICATIONS, INC.
//00806A ERI (EMPAC RESEARCH INC.)
//00C0A8 GVC CORPORATION
//0040E0, "ATOMWIDE LTD.
//0040A8 IMF INTERNATIONAL LTD.
//004070, "INTERWARE CO., LTD.
//00408A TPS TELEPROCESSING SYS. GMBH
//0040FD LXE
//00403F, "SSANGYONG COMPUTER SYSTEMS
//004082, "LABORATORY EQUIPMENT CORP.
//0040F1, "CHUO ELECTRONICS CO., LTD.
//0040A9 DATACOM INC.
//0040E3, "QUIN SYSTEMS LTD
//004091, "PROCOMP INDUSTRIA ELETRONICA
//0040EA PLAIN TREE SYSTEMS INC
//0040A7 ITAUTEC PHILCO S.A.
//004064, "KLA INSTRUMENTS CORPORATION
//004043, "Nokia Siemens Networks GmbH & Co.KG.
//00405A GOLDSTAR INFORMATION & COMM.
//004013, "NTT DATA COMM.SYSTEMS CORP.
//00400C GENERAL MICRO SYSTEMS, INC.
//00405E, "NORTH HILLS ISRAEL
//0040FA MICROBOARDS, INC.
//004014, "COMSOFT GMBH
//004000, "PCI COMPONENTES DA AMZONIA LTD
//00406C COPERNIQUE
//004075, "Tattile SRL
//004053, "AMPRO COMPUTERS
//008038, "DATA RESEARCH & APPLICATIONS
//00805E, "LSI LOGIC CORPORATION
//008060, "NETWORK INTERFACE CORPORATION
//0080C3 BICC INFORMATION SYSTEMS & SVC
//008044, "SYSTECH COMPUTER CORP.
//008006, "COMPUADD CORPORATION
//00809B JUSTSYSTEM CORPORATION
//0080DF ADC CODENOLL TECHNOLOGY CORP.
//008028, "TRADPOST (HK) LTD
//008061, "LITTON SYSTEMS, INC.
//0080F5, "Quantel Ltd
//0080B9 ARCHE TECHNOLIGIES INC.
//004063, "VIA TECHNOLOGIES, INC.
//00808A SUMMIT MICROSYSTEMS CORP.
//0080A7 Honeywell International Inc
//008066, "ARCOM CONTROL SYSTEMS, LTD.
//0080CB FALCO DATA PRODUCTS
//008007, "DLOG NC-SYSTEME
//008062, "INTERFACE CO.
//00801E, "XINETRON, INC.
//0080E2, "T.D.I.CO., LTD.
//008049, "NISSIN ELECTRIC CO., LTD.
//0080C1 LANEX CORPORATION
//0080A3 Lantronix
//0080BC HITACHI ENGINEERING CO., LTD
//008036, "REFLEX MANUFACTURING SYSTEMS
//008083, "AMDAHL
//0080B8 DMG MORI B.U.G.CO., LTD.
//00804D, "CYCLONE MICROSYSTEMS, INC.
//0080D4, "CHASE RESEARCH LTD.
//00803D, "SURIGIKEN CO., LTD.
//00808B DACOLL LIMITED
//0080B2 NETWORK EQUIPMENT TECHNOLOGIES
//008076, "MCNC
//00800B CSK CORPORATION
//008018, "KOBE STEEL, LTD.
//008068, "YAMATECH SCIENTIFIC LTD.
//0080A8 VITACOM CORPORATION
//008033, "EMS Aviation, Inc.
//00807C FIBERCOM, INC.
//008091, "TOKYO ELECTRIC CO., LTD
//00008E, "SOLBOURNE COMPUTER, INC.
//0000DC HAYES MICROCOMPUTER PRODUCTS
//000063, "BARCO CONTROL ROOMS GMBH
//00004E, "AMPEX CORPORATION
//0000BD Mitsubishi Cable Industries, Ltd. / Ryosei Systems
//00002E, "SOCIETE EVIRA
//00003F, "SYNTREX, INC.
//00809D, "Commscraft Ltd.
//0080F4, "TELEMECANIQUE ELECTRIQUE
//008022, "SCAN-OPTICS
//0000CD Allied Telesis Labs Ltd
//0080DD GMX INC/GIMIX
//0080FB BVM LIMITED
//0080B4 SOPHIA SYSTEMS
//00807F, "DY-4 INCORPORATED
//00802D, "XYLOGICS INC
//000061, "GATEWAY COMMUNICATIONS
//0000EA UPNOD AB
//000043, "MICRO TECHNOLOGY
//000017, "Oracle
//0000B2 TELEVIDEO SYSTEMS, INC.
//0000EE NETWORK DESIGNERS, LTD.
//0000E5, "SIGMEX LTD.
//000089, "CAYMAN SYSTEMS INC.
//0000FF CAMTEC ELECTRONICS LTD.
//0000B7 DOVE COMPUTER CORPORATION
//0000F2, "SPIDER COMMUNICATIONS
//0000CC DENSAN CO., LTD.
//0000A4 ACORN COMPUTERS LIMITED
//0000DB British Telecommunications plc
//0000C1 Madge Ltd.
//0000F6, "APPLIED MICROSYSTEMS CORP.
//000077, "INTERPHASE CORPORATION
//0000A2 Bay Networks
//0000EC MICROPROCESS
//0000C2 INFORMATION PRESENTATION TECH.
//0000FC MEIKO
//00006D, "CRAY COMMUNICATIONS, LTD.
//0000DA ATEX
//0000DD TCL INCORPORATED
//0000AE DASSAULT ELECTRONIQUE
//0000A0 SANYO Electric Co., Ltd.
//0000C0 WESTERN DIGITAL CORPORATION
//000033, "EGAN MACHINERY COMPANY
//00009D, "LOCUS COMPUTING CORPORATION
//0000FD HIGH LEVEL HARDWARE
//000065, "Network General Corporation
//000011, "NORMEREL SYSTEMES
//000010, "SYTEK INC.
//0000BC Rockwell Automation
//08007E, "AMALGAMATED WIRELESS(AUS) LTD
//08007F, "CARNEGIE-MELLON UNIVERSITY
//000099, "MTX, INC.
//0000C4 WATERS DIV.OF MILLIPORE
//0000EB MATSUSHITA COMM.IND.CO.LTD.
//000028, "PRODIGY SYSTEMS CORPORATION
//08003B TORUS SYSTEMS LIMITED
//08003C SCHLUMBERGER WELL SERVICES
//080034, "FILENET CORPORATION
//080036, "INTERGRAPH CORPORATION
//080033, "BAUSCH & LOMB
//080048, "EUROTHERM GAUGING SYSTEMS
//080043, "PIXEL COMPUTER INC.
//080045, "CONCURRENT COMPUTER CORP.
//080078, "ACCELL CORPORATION
//08006D, "WHITECHAPEL COMPUTER WORKS
//080030, "NETWORK RESEARCH CORPORATION
//080031, "LITTLE MACHINES INC.
//08002E, "METAPHOR COMPUTER SYSTEMS
//080056, "STANFORD LINEAR ACCEL.CENTER
//08004F, "CYGNET SYSTEMS
//080050, "DAISY SYSTEMS CORP.
//08005E, "COUNTERPOINT COMPUTER INC.
//080076, "PC LAN TECHNOLOGIES
//080075, "DANSK DATA ELECTRONIK
//08002B DIGITAL EQUIPMENT CORPORATION
//080029, "Megatek Corporation
//0270B0 M/A-COM INC. COMPANIES
//000053, "COMPUCORP
//080090, "SONOMA SYSTEMS
//08000A NESTAR SYSTEMS INCORPORATED
//00800F, "STANDARD MICROSYSTEMS
//00406B SYSGEN
//08000F, "MITEL CORPORATION
//080023, "Panasonic Communications Co., Ltd.
//B04FC3 Shenzhen NVC Cloud Technology Co., Ltd.
//08001C KDD-KOKUSAI DEBNSIN DENWA CO.
//00DD0C UNGERMANN-BASS INC.
//080018, "PIRELLI FOCOM NETWORKS
//0000A6 NETWORK GENERAL CORPORATION
//00BBF0 UNGERMANN-BASS INC.
//00408E, "Tattile SRL
//000004, "XEROX CORPORATION
//00DD0E UNGERMANN-BASS INC.
//88571D, "Seongji Industry Company
//7CF31B LG Electronics (Mobile Communications)
//0001C8 THOMAS CONRAD CORP.
//CCEF03 Hunan Keyshare Communication Technology Co., Ltd.
//102FA3 Shenzhen Uvision-tech Technology Co.Ltd
//7048F7, "Nintendo Co., Ltd
//18E1CA wanze
//ECBEDD Sagemcom Broadband SAS
//00C0B6 HVE, Inc.
//309176, "Skyworth Digital Technology(Shenzhen) Co., Ltd
//78C881 Sony Interactive Entertainment Inc.
//D44F68 Eidetic Communications Inc
//749EA5 OHSUNG
//340F66, "MicroArx Corporation
//8CC84B CHONGQING FUGUI ELECTRONICS CO., LTD.
//0C2FB0 Samsung Electronics Co., Ltd
//B40216", "Cisco Systems, Inc
//54A493 IEEE Registration Authority
//6C1C71 Zhejiang Dahua Technology Co., Ltd.
//CC6A10 The Chamberlain Group, Inc
//F03F95", "HUAWEI TECHNOLOGIES CO., LTD
//185644, "HUAWEI TECHNOLOGIES CO., LTD
//9C69D1 HUAWEI TECHNOLOGIES CO., LTD
//185A58 Dell Inc.
//C43A35 FN-LINK TECHNOLOGY LIMITED
//04D16E, "IEEE Registration Authority
//040E3C HP Inc.
//C4E0DE Zhengzhou XindaJiean Information Technology Co., Ltd.
//901A4F EM Microelectronic
//C84F0E", "Integrated Device Technology (Malaysia) Sdn. Bhd.
//6CD2BA zte corporation
//303ABA Guangzhou BaoLun Electronics Co., Ltd
//D88ADC", "Huawei Device Co., Ltd.
//10E953, "Huawei Device Co., Ltd.
//7C48B2 Vida Resources Lte Ltd
//2CAB33 Texas Instruments
//B887C6", "Prudential Technology co., LTD
//EC9C32", "Sichuan AI-Link Technology Co., Ltd.
//4CADA8 PANOPTICS CORP.
//FC1CA1 Nokia
//D42DC5 Panasonic i-PRO Sensing Solutions Co., Ltd.
//E8D03C Shenzhen Jingxun Software Telecommunication Technology Co., Ltd
//1C1ADF Microsoft Corporation
//D4F547", "Google, Inc.
//981BB5 ASSA ABLOY Korea Co., Ltd iRevo
//34CB1A Procter & Gamble Company
//F0B107 Ericsson AB
//784F9B Juniper Networks
//783A6C TECNO MOBILE LIMITED
//E04007 Huawei Device Co., Ltd.
//383FB3 Technicolor CH USA Inc.
//70CE8C Samsung Electronics Co., Ltd
//4070F5, "Apple, Inc.
//B035B5 Apple, Inc.
//90AFD1 netKTI Co., Ltd
//800C67 Apple, Inc.
//90812A Apple, Inc.
//7817BE HUAWEI TECHNOLOGIES CO., LTD
//F072EA", "Google, Inc.
//B87BC5 Apple, Inc.
//F05136 TCT mobile ltd
//105932, "Roku, Inc
//207454, "vivo Mobile Communication Co., Ltd.
//B8C9B5 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//88ACC0 Zyxel Communications Corporation
//90FD73 zte corporation
//1C1E38 PCCW Global, Inc.
//3C410E Cisco Systems, Inc
//88D98F, "Juniper Networks
//0045E2, "CyberTAN Technology Inc.
//006967, "IEEE Registration Authority
//F86FDE", "Shenzhen Goodix Technology Co., Ltd.
//98DF82 Hangzhou Hikvision Digital Technology Co., Ltd.
//646624, "Sagemcom Broadband SAS
//B0F530", "Hitron Technologies. Inc
//740AE1 Huawei Device Co., Ltd.
//B4A898 Huawei Device Co., Ltd.
//0CE4A0 Huawei Device Co., Ltd.
//BC1AE4 Huawei Device Co., Ltd.
//043F72, "Mellanox Technologies, Inc.
//1C4D66 Amazon Technologies Inc.
//D83BBF Intel Corporate
//502CC6 GREE ELECTRIC APPLIANCES, INC.OF ZHUHAI
//F4FEFB Samsung Electronics Co., Ltd
//984914, "Wistron Neweb Corporation
//0CEE99 Amazon Technologies Inc.
//00117E, "Midmark Corp
//D028BA Realme Chongqing MobileTelecommunications Corp Ltd
//A428B7 Yangtze Memory Technologies Co., Ltd.
//9492D2, "KCF Technologies, Inc.
//E4A8DF COMPAL INFORMATION (KUNSHAN) CO., LTD.
//8C53C3 Beijing Xiaomi Mobile Software Co., Ltd
//702F35, "HUAWEI TECHNOLOGIES CO., LTD
//C014B8", "Nokia
//00763D, "Veea
//3093BC Sagemcom Broadband SAS
//FCF5C4 Espressif Inc.
//E826B6 Inside Biometrics International Limited
//54CE69 Hikari Trading Co., Ltd.
//6CC63B Taicang T&W Electronics
//588E81, "Silicon Laboratories
//48B02D NVIDIA Corporation
//4CE176 Cisco Systems, Inc
//6CAEF6 eero inc.
//FC8E6E StreamCCTV, LLC
//E02AE6", "Fiberhome Telecommunication Technologies Co., LTD
//641236, "Technicolor CH USA Inc.
//788B2A Zhen Shi Information Technology (Shanghai) Co., Ltd.
//AC64CF FN-LINK TECHNOLOGY LIMITED
//F06728", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//BCD767", "Private
//9CE176 Cisco Systems, Inc
//102959, "Apple, Inc.
//E47684 Apple, Inc.
//B41A1D Samsung Electronics Co., Ltd
//F05CD5", "Apple, Inc.
//14F6D8, "Intel Corporate
//3CDA6D Tiandy Technologies CO., LTD
//F80DF0", "zte corporation
//9CE91C zte corporation
//5C17CF OnePlus Technology (Shenzhen) Co., Ltd
//A4FA76", "New H3C Technologies Co., Ltd
//70EA5A Apple, Inc.
//3CFAD3 IEEE Registration Authority
//8C6078 Swissbit AG
//00DD25 Shenzhen hechengdong Technology Co., Ltd
//8020E1, "BVBA DPTechnics
//0445A1 NIRIT- Xinwei Telecom Technology Co., Ltd.
//8C97EA FREEBOX SAS
//30AB6A SAMSUNG ELECTRO-MECHANICS(THAILAND)
//749BE8 Hitron Technologies.Inc
//5CBAEF CHONGQING FUGUI ELECTRONICS CO., LTD.
//4C6371 Xiaomi Communications Co Ltd
//D84DB9", "Wu Qi Technologies, Inc.
//A04F85 LG Electronics (Mobile Communications)
//D807B6", "TP-LINK TECHNOLOGIES CO., LTD.
//646E97, "TP-LINK TECHNOLOGIES CO., LTD.
//78507C Juniper Networks
//001258, "TechVoIP Sp z o.o.
//6C1632 HUAWEI TECHNOLOGIES CO., LTD
//2C1A01 HUAWEI TECHNOLOGIES CO., LTD
//347839, "zte corporation
//24169D, "Cisco Systems, Inc
//F419E2", "Volterra
//4CA003 VITEC
//64F2FB Hangzhou Ezviz Software Co., Ltd.
//30809B New H3C Technologies Co., Ltd
//7422BB Huawei Device Co., Ltd.
//6C0D34 Nokia
//4C4576 China Mobile(Hangzhou) Information Technology Co., Ltd.
//B440A4 Apple, Inc.
//48B8A3 Apple, Inc.
//F4DBE3 Apple, Inc.
//88A406 Johnson Outdoors Marine Electronics d/b/a Minnkota
//BC428C ALPS ELECTRIC CO., LTD.
//F07CC7 Juniper Networks
//74C929 Zhejiang Dahua Technology Co., Ltd.
//D4CFF9 Shenzhen SEI Robotics Co., Ltd
//D45EEC", "Beijing Xiaomi Electronics Co., Ltd.
//5CB29E ASCO Power Technologies
//94CC04 IEEE Registration Authority
//9CC9EB NETGEAR
//9CFFC2 AVI Systems GmbH
//44D878, "Hui Zhou Gaoshengda Technology Co., LTD
//A0D807", "Huawei Device Co., Ltd.
//2C780E Huawei Device Co., Ltd.
//34B20A Huawei Device Co., Ltd.
//98F4AB Espressif Inc.
//D8BFC0 Espressif Inc.
//202681, "TECNO MOBILE LIMITED
//F4D620", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//64FB92 PPC Broadband Inc.
//141346, "Skyworth Digital Technology(Shenzhen) Co., Ltd
//949034, "SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD
//987A10 Ericsson AB
//542BDE New H3C Technologies Co., Ltd
//98F781, "ARRIS Group, Inc.
//7897C3 DINGXIN INFORMATION TECHNOLOGY CO., LTD
//4C90DB JL Audio
//B899AE", "Shenzhen MiaoMing", "Intelligent Technology Co., Ltd
//E8D0B9", "Taicang T&W Electronics
//3C8F06 Shenzhen Libtor Technology Co., Ltd
//B00875", "HUAWEI TECHNOLOGIES CO., LTD
//8CF112 Motorola Mobility LLC, a Lenovo Company
//847637, "HUAWEI TECHNOLOGIES CO., LTD
//FC9435", "HUAWEI TECHNOLOGIES CO., LTD
//E02481", "HUAWEI TECHNOLOGIES CO., LTD
//A8C0EA", "Pepwave Limited
//182AD3 Juniper Networks
//80B07B zte corporation
//C85A9F", "zte corporation
//44AEAB GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//A4F05E", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//1C687E Shenzhen Qihu Intelligent Technology Company Limited
//C03656", "Fiberhome Telecommunication Technologies Co., LTD
//5885A2 Realme Chongqing MobileTelecommunications Corp Ltd
//2CF89B Cisco Systems, Inc
//00071C AT&T
//E0E8E6", "Shenzhen C-Data Technology Co., Ltd.
//500291, "Espressif Inc.
//001DDF Sunitec Enterprise Co., Ltd
//8C0FFA Hutec co., ltd
//ACFE05", "ITEL MOBILE LIMITED
//782A79 Integrated Device Technology (Malaysia) Sdn. Bhd.
//786559, "Sagemcom Broadband SAS
//50D2F5, "Beijing Xiaomi Mobile Software Co., Ltd
//24526A Zhejiang Dahua Technology Co., Ltd.
//20DFB9 Google, Inc.
//5CCAD3 CHIPSEA TECHNOLOGIES (SHENZHEN) CORP.
//28167F, "Xiaomi Communications Co Ltd
//087190, "Intel Corporate
//B03E51 BSkyB Ltd
//5CE883 HUAWEI TECHNOLOGIES CO., LTD
//100177, "HUAWEI TECHNOLOGIES CO., LTD
//44A191 HUAWEI TECHNOLOGIES CO., LTD
//6023A4 Sichuan AI-Link Technology Co., Ltd.
//A4530E Cisco Systems, Inc
//00403A IMPACT TECHNOLOGIES
//F887F1", "Apple, Inc.
//9C28BF Continental Automotive Czech Republic s.r.o.
//807215, "BSkyB Ltd
//74D637, "Amazon Technologies Inc.
//D05F64 IEEE Registration Authority
//BCC31B Kygo Life A
//64DF10 JingLue Semiconductor(SH) Ltd.
//C463FB Neatframe AS
//0C8126 Juniper Networks
//305714, "Apple, Inc.
//60447A Water-i.d.GmbH
//C8B1CD", "Apple, Inc.
//1460CB Apple, Inc.
//B8F12A Apple, Inc.
//04AB6A Chun-il Co., Ltd.
//544E45, "Private
//04C807 Xiaomi Communications Co Ltd
//04A222 Arcadyan Corporation
//489BD5 Extreme Networks, Inc.
//3C8C93 Juniper Networks
//28FE65 DongGuan Siyoto Electronics Co., Ltd
//1806F5, "RAD Data Communications, Ltd.
//7484E1, "Dongguan Haoyuan Electronics Co., Ltd
//44FB5A zte corporation
//4459E3, "HUAWEI TECHNOLOGIES CO., LTD
//4074E0, "Intel Corporate
//DC54D7 Amazon Technologies Inc.
//44D3CA Cisco Systems, Inc
//889FAA Hella Gutmann Solutions GmbH
//E454E8", "Dell Inc.
//20968A China Mobile (Hangzhou) Information Technology Co., Ltd.
//8C1850 China Mobile (Hangzhou) Information Technology Co., Ltd.
//D8D4E6 Hytec Inter Co., Ltd.
//683F1E, "EFFECT Photonics B.V.
//0035FF Texas Instruments
//F8E7A0", "vivo Mobile Communication Co., Ltd.
//2CFFEE vivo Mobile Communication Co., Ltd.
//840B7C Hitron Technologies.Inc
//48A73C Sichuan tianyi kanghe communications co., LTD
//C85D38", "HUMAX Co., Ltd.
//F8A763 Zhejiang Tmall Technology Co., Ltd.
//A49813 ARRIS Group, Inc.
//6C2990 WiZ Connected Lighting Company Limited
//9835ED, "HUAWEI TECHNOLOGIES CO., LTD
//084F0A HUAWEI TECHNOLOGIES CO., LTD
//A8494D", "HUAWEI TECHNOLOGIES CO., LTD
//44004D, "HUAWEI TECHNOLOGIES CO., LTD
//18CF24 HUAWEI TECHNOLOGIES CO., LTD
//D89B3B", "HUAWEI TECHNOLOGIES CO., LTD
//88403B HUAWEI TECHNOLOGIES CO., LTD
//FC8743", "HUAWEI TECHNOLOGIES CO., LTD
//807693, "Newag SA
//BC9740 IEEE Registration Authority
//04885F, "HUAWEI TECHNOLOGIES CO., LTD
//C850CE", "HUAWEI TECHNOLOGIES CO., LTD
//50F8A5 eWBM Co., Ltd.
//1449BC DrayTek Corp.
//20F478, "Xiaomi Communications Co Ltd
//90735A Motorola Mobility LLC, a Lenovo Company
//1C8259 IEEE Registration Authority
//0004DF TERACOM TELEMATICA S.A
//7438B7 CANON INC.
//8C04BA Dell Inc.
//00FA21 Samsung Electronics Co., Ltd
//7C2302 Samsung Electronics Co., Ltd
//18B6F7 NEW POS TECHNOLOGY LIMITED
//5CB15F Oceanblue Cloud Technology Limited
//18AACA Sichuan tianyi kanghe communications co., LTD
//D49DC0", "Samsung Electronics Co., Ltd
//D0196A", "Ciena Corporation
//4413D0, "zte corporation
//2462AB Espressif Inc.
//88B436 Private
//84FDD1 Intel Corporate
//6CAB05 Cisco Systems, Inc
//000BE4 Hosiden Corporation
//60D248, "ARRIS Group, Inc.
//485DEB Just Add Power
//501395, "Sichuan AI-Link Technology Co., Ltd.
//18D9EF, "Shuttle Inc.
//88DA33 Beijing Xiaoyuer Network Technology Co., Ltd
//84C78F STORDIS GmbH
//5041B9 I-O DATA DEVICE, INC.
//80DABC Megafone Limited
//C09FE1", "zte corporation
//184644, "Home Control Singapore Pte Ltd
//B0700D", "Nokia
//346B5B New H3C Technologies Co., Ltd
//84E892, "Actiontec Electronics, Inc
//78E2BD Vodafone Automotive S.p.A.
//F848FD China Mobile Group Device Co., Ltd.
//20DA22 HUAWEI TECHNOLOGIES CO., LTD
//C821DA", "Shenzhen YOUHUA Technology Co., Ltd
//E0B655", "Beijing Xiaomi Electronics Co., Ltd.
//002175, "Pacific Satellite International Ltd.
//889746, "Sichuan AI-Link Technology Co., Ltd.
//1CDE57 Fiberhome Telecommunication Technologies Co., LTD
//E0DCFF", "Xiaomi Communications Co Ltd
//608CDF Private
//00778D, "Cisco Systems, Inc
//000E8C Siemens AG
//008764, "Cisco Systems, Inc
//FC3342", "Juniper Networks
//C468D0 VTech Telecommunications Ltd.
//14AEDB VTech Telecommunications Ltd.
//78DB2F Texas Instruments
//8C0FA0 di-soric GmbH & Co.KG
//DCB808", "Extreme Networks, Inc.
//B0E71D Shanghai Maigantech Co., Ltd
//F8BBBF", "eero inc.
//DCFB48 Intel Corporate
//846FCE GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//20658E, "HUAWEI TECHNOLOGIES CO., LTD
//183D5E, "HUAWEI TECHNOLOGIES CO., LTD
//DC7137", "zte corporation
//847C9B GD Midea Air-Conditioning Equipment Co., Ltd.
//3441A8 ER-Telecom
//34DB9C Sagemcom Broadband SAS
//7440BE LG Innotek
//04D4C4 ASUSTek COMPUTER INC.
//A0510B Intel Corporate
//F0D4E2", "Dell Inc.
//A8E2C3 Shenzhen YOUHUA Technology Co., Ltd
//9020C2 Aruba, a Hewlett Packard Enterprise Company
//0CA06C Industrial Cyber Sensing Inc.
//FCD2B6 IEEE Registration Authority
//804A14 Apple, Inc.
//703C69 Apple, Inc.
//AC2DA9 TECNO MOBILE LIMITED
//FCB662 IC Holdings LLC
//48049F, "ELECOM CO., LTD
//087F98, "vivo Mobile Communication Co., Ltd.
//C85261 ARRIS Group, Inc.
//C04121 Nokia
//7488BB Cisco Systems, Inc
//A4CF12", "Espressif Inc.
//4C6AF6 HMD Global Oy
//489DD1 Samsung Electronics Co., Ltd
//B06FE0", "Samsung Electronics Co., Ltd
//44B994 Douglas Lighting Controls
//40A93F Pivotal Commware, Inc.
//70BF92 GN Audio A/S
//C08C71", "Motorola Mobility LLC, a Lenovo Company
//F46F4E", "Echowell
//2C3F0B Cisco Meraki
//5C8816 Rockwell Automation
//002F5C Cisco Systems, Inc
//F4645D", "Toshiba
//38F85E, "HUMAX Co., Ltd.
//ACBB61 YSTen Technology Co., Ltd
//2479F8, "KUPSON spol. s r.o.
//7CFD82 GUANGDONG GENIUS TECHNOLOGY CO., LTD.
//180D2C Intelbras
//042DB4 First Property (Beijing) Co., Ltd Modern MOMA Branch
//04E0B0 Shenzhen YOUHUA Technology Co., Ltd
//08ECF5 Cisco Systems, Inc
//D07650", "IEEE Registration Authority
//60D0A9 Samsung Electronics Co., Ltd
//88CEFA HUAWEI TECHNOLOGIES CO., LTD
//002706, "YOISYS
//00CB51 Sagemcom Broadband SAS
//C464B7 Fiberhome Telecommunication Technologies Co., LTD
//EC4118", "XIAOMI Electronics, CO., LTD
//D8860B", "IEEE Registration Authority
//342003, "Shenzhen Feitengyun Technology Co., LTD
//F07D68", "D-Link Corporation
//40E3D6, "Aruba, a Hewlett Packard Enterprise Company
//B45D50", "Aruba, a Hewlett Packard Enterprise Company
//78DAA2 Cynosure Technologies Co., Ltd
//38B19E IEEE Registration Authority
//38E26E ShenZhen Sweet Rain Electronics Co., Ltd.
//00D050, "Iskratel d.o.o.
//70C9C6 Cisco Systems, Inc
//D4B92F", "Technicolor CH USA Inc.
//689A87 Amazon Technologies Inc.
//64AE88 Polytec GmbH
//ACA31E", "Aruba, a Hewlett Packard Enterprise Company
//00177B Azalea Networks inc
//98DAC4 TP-LINK TECHNOLOGIES CO., LTD.
//F84DFC Hangzhou Hikvision Digital Technology Co., Ltd.
//502B98 Es-tech International
//C82832 Beijing Xiaomi Electronics Co., Ltd.
//946A77 Technicolor CH USA Inc.
//C4346B Hewlett Packard
//48F17F, "Intel Corporate
//8084A9 oshkosh Corporation
//F46E95", "Extreme Networks, Inc.
//4CC7D6 FLEXTRONICS MANUFACTURING(ZHUHAI) CO., LTD.
//C80873 Ruckus Wireless
//701BFB Integrated Device Technology (Malaysia) Sdn. Bhd.
//04766E, "ALPS ELECTRIC CO., LTD.
//AC7A4D ALPS ELECTRIC CO., LTD.
//001BB5 Cherry GmbH
//002643, "ALPS ELECTRIC CO., LTD.
//38C096 ALPS ELECTRIC CO., LTD.
//D05157 LEAX Arkivator Telecom
//288088, "NETGEAR
//64CE6E Sierra Wireless
//1C3477 Innovation Wireless
//BC3E07", "Hitron Technologies. Inc
//48FDA3 Xiaomi Communications Co Ltd
//001697, "NEC Corporation
//003013, "NEC Corporation
//049DFE Hivesystem
//0CEC84 Shenzhen TINNO Mobile Technology Corp.
//9CDB07 Thum+Mahr GmbH
//DCEB69 Technicolor CH USA Inc.
//004E35, "Hewlett Packard Enterprise
//F81308", "Nokia
//F8A2D6", "Liteon Technology Corporation
//182A44 HIROSE ELECTRONIC SYSTEM
//FC94CE zte corporation
//90869B zte corporation
//E0189F", "EM Microelectronic
//74366D, "Vodafone Italia S.p.A.
//84DB2F Sierra Wireless
//9458CB Nintendo Co., Ltd
//28EC9A Texas Instruments
//FCBE7B", "vivo Mobile Communication Co., Ltd.
//B40FB3 vivo Mobile Communication Co., Ltd.
//EC5C68 CHONGQING FUGUI ELECTRONICS CO., LTD.
//C4E506 Piper Networks, Inc.
//30EB5A LANDIS + GYR
//F80F6F", "Cisco Systems, Inc
//0080E3, "CORAL NETWORK CORPORATION
//D8F2CA", "Intel Corporate
//B4C62E Molex CMS
//B8259A", "Thalmic Labs
//282536, "SHENZHEN HOLATEK CO., LTD
//B8A175", "Roku, Inc.
//CCD3C1 Vestel Elektronik San ve Tic. A.Ş.
//0CD0F8 Cisco Systems, Inc
//745F90, "LAM Technologies
//A42655 LTI Motion (Shanghai) Co., Ltd.
//60A730 Shenzhen Yipinfang Internet Technology Co., Ltd
//3C9BD6 Vizio, Inc
//F85B9C", "SB SYSTEMS Co., Ltd
//6CA928 HMD Global Oy
//00D861, "Micro-Star INTL CO., LTD.
//74C17D Infinix mobility limited
//8871B1 ARRIS Group, Inc.
//F0AF85 ARRIS Group, Inc.
//FCAE34 ARRIS Group, Inc.
//DCDA80 New H3C Technologies Co., Ltd
//CC7286", "Xi'an Fengyu Information Technology Co., Ltd.
//64EEB7 Netcore Technology Inc
//3881D7, "Texas Instruments
//1804ED, "Texas Instruments
//D43260 GoPro
//50DB3F SHENZHEN GONGJIN ELECTRONICS CO., LT
//1081B4 Hunan Greatwall Galaxy Science and Technology Co., Ltd.
//004279, "Sunitec Enterprise Co., Ltd
//00B8B3 Cisco Systems, Inc
//F4DD9E", "GoPro
//D4D919", "GoPro
//141114, "TECNO MOBILE LIMITED
//A45046", "Xiaomi Communications Co Ltd
//1C24CD Askey Computer Corp.
//007C2D Samsung Electronics Co., Ltd
//B47748", "Shenzhen Neoway Technology Co., Ltd.
//F8501C Tianjin Geneuo Technology Co., Ltd
//44070B Google, Inc.
//F8C249 Private
//B831B5 Microsoft Corporation
//ECF6BD", "SNCF MOBILITÉS
//38B4D3 BSH Hausgeraete GmbH
//C84782 Areson Technology Corp.
//E89363 Nokia
//7C0CF6 Guangdong Huiwei High-tech Co., Ltd.
//749D79, "Sercomm Corporation.
//00D6FE Cisco Systems, Inc
//0CBF74 Morse Micro
//FC8F7D", "SHENZHEN GONGJIN ELECTRONICS CO., LT
//24BE18 DADOUTEK COMPANY LIMITED
//BCF310 Aerohive Networks Inc.
//B41D2B Shenzhen YOUHUA Technology Co., Ltd
//14C213 Apple, Inc.
//70D313, "HUAWEI TECHNOLOGIES CO., LTD
//9C1D36 HUAWEI TECHNOLOGIES CO., LTD
//CCBBFE", "HUAWEI TECHNOLOGIES CO., LTD
//A4D931", "Apple, Inc.
//BCFED9 Apple, Inc.
//808223, "Apple, Inc.
//300A60 IEEE Registration Authority
//80D065, "CKS Corporation
//283166, "vivo Mobile Communication Co., Ltd.
//C04004 Medicaroid Corporation
//20AD56 Continental Automotive Systems Inc.
//5029F5, "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//CC08FB", "TP-LINK TECHNOLOGIES CO., LTD.
//BCAF91 TE Connectivity Sensor Solutions
//F0D7DC", "Wesine (Wuhan) Technology Co., Ltd.
//007204, "Samsung Electronics Co., Ltd.ARTIK
//40C81F Shenzhen Xinguodu Technology Co., Ltd.
//1459C0 NETGEAR
//8C61A3 ARRIS Group, Inc.
//A81087 Texas Instruments
//A02833", "IEEE Registration Authority
//C8C2F5", "FLEXTRONICS MANUFACTURING(ZHUHAI) CO., LTD.
//F05849 CareView Communications
//34E5EC Palo Alto Networks
//A4ED43 IEEE Registration Authority
//94298D, "Shanghai AdaptComm Technology Co., Ltd.
//00AA6E Cisco Systems, Inc
//0C7C28 Nokia
//6843D7, "Agilecom Photonics Solutions Guangdong Limited
//20D80B Juniper Networks
//8C8F8B China Mobile Chongqing branch
//B86A97", "Edgecore Networks Corporation
//000A5E", "3COM
//00105A", "3COM
//006097, "3COM
//006008, "3COM
//001B6E Keysight Technologies, Inc.
//00040B", "3COM EUROPE LTD
//000102, "3COM
//8CFE74 Ruckus Wireless
//A8016D", "Aiwa Corporation
//0440A9 New H3C Technologies Co., Ltd
//48A472 Intel Corporate
//4C0143 eero inc.
//E43493 HUAWEI TECHNOLOGIES CO., LTD
//342912, "HUAWEI TECHNOLOGIES CO., LTD
//604BAA Magic Leap, Inc.
//4C364E Panasonic Corporation Connected Solutions Company
//BCA58B Samsung Electronics Co., Ltd
//80CEB9 Samsung Electronics Co., Ltd
//D0D3FC", "Mios, Ltd.
//6C6CD3 Cisco Systems, Inc
//E049ED", "Audeze LLC
//8030E0, "Hewlett Packard Enterprise
//E85D86", "CHANG YOW TECHNOLOGIES INTERNATIONAL CO., LTD.
//143719, "PT Prakarsa Visi Valutama
//582F40, "Nintendo Co., Ltd
//0890BA Danlaw Inc
//94A3CA KonnectONE, LLC
//244CE3 Amazon Technologies Inc.
//B8BEF4 devolo AG
//000157, "SYSWAVE CO., LTD
//58FDBE Shenzhen Taikaida Technology Co., Ltd
//F4F197", "EMTAKE Inc
//6CED51 NEXCONTROL Co., Ltd
//04C3E6 IEEE Registration Authority
//286336, "Siemens AG
//14D169, "HUAWEI TECHNOLOGIES CO., LTD
//1062E5, "Hewlett Packard
//0020B5 YASKAWA ELECTRIC CORPORATION
//E06267 Xiaomi Communications Co Ltd
//70B7AA vivo Mobile Communication Co., Ltd.
//84B31B Kinexon GmbH
//082525, "Xiaomi Communications Co Ltd
//C49500 Amazon Technologies Inc.
//F460E2 Xiaomi Communications Co Ltd
//E4D124", "Mojo Networks, Inc.
//0013A3 Siemens Home & Office Comm. Devices
//B0B867", "Hewlett Packard Enterprise
//C00380", "Juniper Networks
//98BB99 Phicomm (Sichuan) Co., Ltd.
//002622, "COMPAL INFORMATION (KUNSHAN) CO., LTD.
//F8272E Mercku
//9CC950 Baumer Holding
//F89910", "Integrated Device Technology (Malaysia) Sdn. Bhd.
//50E0EF Nokia
//848A8D Cisco Systems, Inc
//1CC3EB GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//504C7E THE 41ST INSTITUTE OF CETC
//001413, "Trebing & Himstedt Prozeßautomation GmbH & Co.KG
//000799, "Tipping Point Technologies, Inc.
//D01CBB Beijing Ctimes Digital Technology Co., Ltd.
//7487BB Ciena Corporation
//C0B6F9", "Intel Corporate
//68DD26 Shanghai Focus Vision Security Technology Co., Ltd
//2866E3, "AzureWave Technology Inc.
//60F18A HUAWEI TECHNOLOGIES CO., LTD
//EC3873", "Juniper Networks
//780473, "Texas Instruments
//A83E0E HMD Global Oy
//10C172 HUAWEI TECHNOLOGIES CO., LTD
//00151E, "ETHERNET Powerlink Standarization Group (EPSG)
//00111E, "ETHERNET Powerlink Standarization Group (EPSG)
//00409D, "DigiBoard
//CC50E3", "Espressif Inc.
//DCE305 ZAO NPK Rotek
//A4DA32 Texas Instruments
//000EEE Muco Industrie BV
//7C1C4E LG Innotek
//D8B6B7", "Comtrend Corporation
//144F8A Intel Corporate
//002106, "RIM Testing Services
//8C14B4 zte corporation
//3C9872 Sercomm Corporation.
//40C3C6 SnapRoute
//5C9656 AzureWave Technology Inc.
//E06066 Sercomm Corporation.
//149346, "PNI sensor corporation
//DCE0EB", "Nanjing Aozheng Information Technology Co.Ltd
//EC8C9A", "HUAWEI TECHNOLOGIES CO., LTD
//B48655", "HUAWEI TECHNOLOGIES CO., LTD
//2C4759 Beijing MEGA preponderance Science & Technology Co. Ltd
//A41566", "WEIFANG GOERTEK ELECTRONICS CO., LTD
//1C965A WEIFANG GOERTEK ELECTRONICS CO., LTD
//401B5F WEIFANG GOERTEK ELECTRONICS CO., LTD
//A8E552", "JUWEL Aquarium AG & Co.KG
//5CCD7C MEIZU Technology Co., Ltd.
//00138A Qingdao GoerTek Technology Co., Ltd.
//A830AD WEIFANG GOERTEK ELECTRONICS CO., LTD
//BC5FF6", "MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//C8E7D8 MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//60D21C Sunnovo International Limited
//CC51B4 Integrated Device Technology (Malaysia) Sdn. Bhd.
//00C3F4 Samsung Electronics Co., Ltd
//B88AEC", "Nintendo Co., Ltd
//D0D783", "HUAWEI TECHNOLOGIES CO., LTD
//AC3B77", "Sagemcom Broadband SAS
//B46BFC", "Intel Corporate
//B0FC0D Amazon Technologies Inc.
//CCC92C Schindler - PORT Technology
//001E39, "Comsys Communication Ltd.
//78725D, "Cisco Systems, Inc
//FCE66A", "Industrial Software Co
//7836CC GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//8CCF5C BEFEGA GmbH
//70C833 Wirepas Oy
//0C73EB IEEE Registration Authority
//048AE1 FLEXTRONICS MANUFACTURING(ZHUHAI) CO., LTD.
//F0B5D1 Texas Instruments
//00E000, "FUJITSU LIMITED
//90848B HDR10+ Technologies, LLC
//C8D779", "QING DAO HAIER TELECOM CO., LTD.
//10B36F Bowei Technology Company Limited
//FC9BC6", "Sumavision Technologies Co., Ltd
//C8292A", "Barun Electronics
//E482CC Jumptronic GmbH
//48605F, "LG Electronics (Mobile Communications)
//B0416F", "Shenzhen Maxtang Computer Co., Ltd
//501D93, "HUAWEI TECHNOLOGIES CO., LTD
//2816A8 Microsoft Corporation
//F8F532", "ARRIS Group, Inc.
//B083D6 ARRIS Group, Inc.
//80C7C5 Fiberhome Telecommunication Technologies Co., LTD
//E4434B", "Dell Inc.
//0CF5A4 Cisco Systems, Inc
//9C2EA1 Xiaomi Communications Co Ltd
//089734, "Hewlett Packard Enterprise
//F09CD7", "Guangzhou Blue Cheetah Intelligent Technology Co., Ltd.
//BCE143 Apple, Inc.
//647033, "Apple, Inc.
//846878, "Apple, Inc.
//C8D083 Apple, Inc.
//0C6ABC Fiberhome Telecommunication Technologies Co., LTD
//0080BA SPECIALIX (ASIA) PTE, LTD
//480BB2 IEEE Registration Authority
//CCC079 Murata Manufacturing Co., Ltd.
//E019D8 BH TECHNOLOGIES
//6030D4, "Apple, Inc.
//F895EA Apple, Inc.
//18F1D8, "Apple, Inc.
//3CCD5D HUAWEI TECHNOLOGIES CO., LTD
//7C7668 HUAWEI TECHNOLOGIES CO., LTD
//6C3838 Marking System Technology Co., Ltd.
//30D9D9, "Apple, Inc.
//780F77, "HangZhou Gubei Electronics Technology Co., Ltd
//A438CC", "Nintendo Co., Ltd
//74721E, "Edison Labs Inc.
//8C4CDC PLANEX COMMUNICATIONS INC.
//5065F3, "Hewlett Packard
//3C9509 Liteon Technology Corporation
//BCAB7C TRnP KOREA Co Ltd
//64CB5D SIA TeleSet
//5821E9, "TWPI
//C49F4C", "HUAWEI TECHNOLOGIES CO., LTD
//0C704A HUAWEI TECHNOLOGIES CO., LTD
//F0E3DC", "Tecon MT, LLC
//A8DA01", "Shenzhen NUOLIJIA Digital Technology Co., Ltd
//7C2586 Juniper Networks
//F041C8", "IEEE Registration Authority
//CC9916", "Integrated Device Technology (Malaysia) Sdn. Bhd.
//EC7FC6 ECCEL CORPORATION SAS
//4CABFC zte corporation
//7C2A31 Intel Corporate
//0010D8, "CALISTA
//002194, "Ping Communication
//5C5AEA FORD
//000B7B Test-Um Inc.
//30FD38 Google, Inc.
//001386, "ABB Inc/Totalflow
//003C10 Cisco Systems, Inc
//54A65C Technicolor CH USA Inc.
//BCDDC2 Espressif Inc.
//98D863, "Shanghai High-Flying Electronics Technology Co., Ltd
//0CF346 Xiaomi Communications Co Ltd
//7CFF4D AVM Audiovisuelles Marketing und Computersysteme GmbH
//7470FD Intel Corporate
//C88F26", "Skyworth Digital Technology(Shenzhen) Co., Ltd
//703A73 Shenzhen Sundray Technologies Company Limited
//10F9EB Industria Fueguina de Relojería Electrónica s.a.
//80AD16 Xiaomi Communications Co Ltd
//044EAF LG Innotek
//1894C6 ShenZhen Chenyee Technology Co., Ltd.
//40BD32 Texas Instruments
//CC8E71", "Cisco Systems, Inc
//38F554, "HISENSE ELECTRIC CO., LTD
//88E90F, "innomdlelab
//003074, "EQUIINET LTD.
//EC9B8B Hewlett Packard Enterprise
//B0B3AD HUMAX Co., Ltd.
//18A28A Essel-T Co., Ltd
//20365B Megafone Limited
//E8DE00", "ChongQing GuanFang Technology Co., LTD
//70C94E Liteon Technology Corporation
//70D081, "Beijing Netpower Technologies Inc.
//FC643A Samsung Electronics Co., Ltd
//A8515B", "Samsung Electronics Co., Ltd
//54B7E5 Rayson Technology Co., Ltd.
//946372, "vivo Mobile Communication Co., Ltd.
//BC0FA7 Ouster
//F8C120 Xi'an Link-Science Technology Co.,Ltd
//F0C9D1 GD Midea Air-Conditioning Equipment Co., Ltd.
//347E5C Sonos, Inc.
//B4FBF9 HUAWEI TECHNOLOGIES CO., LTD
//506F77, "HUAWEI TECHNOLOGIES CO., LTD
//0C41E9 HUAWEI TECHNOLOGIES CO., LTD
//3CE824 HUAWEI TECHNOLOGIES CO., LTD
//345A06 SHARP Corporation
//001936, "STERLITE OPTICAL TECHNOLOGIES LIMITED
//B89F09 Wistron Neweb Corporation
//0402CA Shenzhen Vtsonic Co., ltd
//3CFB5C Fiberhome Telecommunication Technologies Co., LTD
//7440BB Hon Hai Precision Ind.Co., Ltd.
//1C1161 Ciena Corporation
//B4DE31", "Cisco Systems, Inc
//A44027", "zte corporation
//B4F7A1 LG Electronics (Mobile Communications)
//28EDE0 AMPAK Technology, Inc.
//88BD45 Samsung Electronics Co., Ltd
//54FCF0 Samsung Electronics Co., Ltd
//306A85 Samsung Electronics Co., Ltd
//4CDD31 Samsung Electronics Co., Ltd
//88B6EE Dish Technologies Corp
//70F220, "Actiontec Electronics, Inc
//D0817A", "Apple, Inc.
//98CA33 Apple, Inc.
//68AB1E Apple, Inc.
//70EF00, "Apple, Inc.
//C87765 Tiesse SpA
//2C37C5 Qingdao Haier Intelligent Home Appliance Technology Co., Ltd
//CC40D0", "NETGEAR
//7C7630 Shenzhen YOUHUA Technology Co., Ltd
//9822EF, "Liteon Technology Corporation
//7C7635 Intel Corporate
//788038, "FUNAI ELECTRIC CO., LTD.
//BCFFEB Motorola Mobility LLC, a Lenovo Company
//000130, "Extreme Networks, Inc.
//FC0A81 Extreme Networks, Inc.
//F045DA Texas Instruments
//B80716", "vivo Mobile Communication Co., Ltd.
//A8EEC6 Muuselabs NV/SA
//E4F042", "Google, Inc.
//4048FD IEEE Registration Authority
//20B399 Enterasys
//CC2D21 Tenda Technology Co., Ltd.Dongguan branch
//004097, "DATEX DIVISION OF
//9C4FCF TCT mobile ltd
//D896E0 Alibaba Cloud Computing Ltd.
//001862, "Seagate Technology
//1CEEC9 Elo touch solutions
//000C50 Seagate Technology
//342AF1 Texas Instruments
//207852, "Nokia
//C8DEC9", "Coriant
//44D5A5 AddOn Computer
//38F73D, "Amazon Technologies Inc.
//C0A00D ARRIS Group, Inc.
//0C6111 Anda Technologies SAC
//0022C4 epro GmbH
//1C330E PernixData
//B8F74A RCNTEC
//645106, "Hewlett Packard
//0C1539 Apple, Inc.
//6C5697 Amazon Technologies Inc.
//0005FF SNS Solutions, Inc.
//F87B20 Cisco Systems, Inc
//E0AADB", "Nanjing PANENG Technology Development Co., Ltd
//ECF451", "Arcadyan Corporation
//581243, "AcSiP Technology Corp.
//A89FEC ARRIS Group, Inc.
//00BE9E Fiberhome Telecommunication Technologies Co., LTD
//54C57A Sunnovo International Limited
//58C17A Cambium Networks Limited
//38019F, "SHENZHEN FAST TECHNOLOGIES CO., LTD
//245CCB AXIe Consortium, Inc.
//609BC8 Hipad Intelligent Technology Co., Ltd.
//406A8E Hangzhou Puwell OE Tech Ltd.
//1C0FAF Lucid Vision Labs
//88B4A6 Motorola Mobility LLC, a Lenovo Company
//28CF08 ESSYS
//002128, "Oracle Corporation
//001C73 Arista Networks
//2C8A72 HTC Corporation
//38AD8E New H3C Technologies Co., Ltd
//34D0B8, "IEEE Registration Authority
//D06726", "Hewlett Packard Enterprise
//ECFAF4", "SenRa Tech Pvt.Ltd
//D88F76", "Apple, Inc.
//409C28 Apple, Inc.
//5CA176 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//583879, "RICOH COMPANY, LTD.
//F44C70 Skyworth Digital Technology(Shenzhen) Co., Ltd
//C8E7F0", "Juniper Networks
//B0935B ARRIS Group, Inc.
//F449EF EMSTONE
//54DF24 Fiberhome Telecommunication Technologies Co., LTD
//AC1DDF", "IEEE Registration Authority
//E8D819", "AzureWave Technology Inc.
//782D7E, "TRENDnet, Inc.
//741AE0 IEEE Registration Authority
//24B209 Avaya Inc
//FC65DE", "Amazon Technologies Inc.
//B06EBF ASUSTek COMPUTER INC.
//603D26, "Technicolor CH USA Inc.
//BC903A Robert Bosch GmbH
//D0B128 Samsung Electronics Co., Ltd
//BC5451", "Samsung Electronics Co., Ltd
//74860B Cisco Systems, Inc
//182D98, "Jinwoo Industrial system
//D8A534", "Spectronix Corporation
//EC51BC GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//F079E8", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//78321B D-Link International
//601803, "Daikin Air-conditioning (Shanghai) Co., Ltd.
//00A096 MITSUMI ELECTRIC CO., LTD.
//78617C MITSUMI ELECTRIC CO., LTD.
//940E6B HUAWEI TECHNOLOGIES CO., LTD
//08661F, "Palo Alto Networks
//64FB50 RoomReady/Zdi, Inc.
//74EAC8 New H3C Technologies Co., Ltd
//B4D64E", "Caldero Limited
//F89DBB Tintri
//D8A01D Espressif Inc.
//C4F312 Texas Instruments
//904E91, "IEEE Registration Authority
//5CE8B7 Oraimo Technology Limited
//3C11B2 Fraunhofer FIT
//104B46 Mitsubishi Electric Corporation
//DC0C2D WEIFANG GOERTEK ELECTRONICS CO., LTD
//D067E5", "Dell Inc.
//8CFEB4 VSOONTECH ELECTRONICS CO., LIMITED
//CC66B2", "Nokia
//68ECC5 Intel Corporate
//9C65EE DASAN Network Solutions
//78CA04 Nokia Corporation
//34298F, "IEEE Registration Authority
//5CEA1D Hon Hai Precision Ind.Co., Ltd.
//181456, "Nokia Corporation
//0017C8 KYOCERA Display Corporation
//38E2DD zte corporation
//885DFB zte corporation
//58B42D YSTen Technology Co., Ltd
//E048D3", "MOBIWIRE MOBILES (NINGBO) CO., LTD
//58E28F, "Apple, Inc.
//787B8A Apple, Inc.
//4C16FC Juniper Networks
//48BCA6", "​ASUNG TECHNO CO., Ltd
//B009DA", "Ring Solutions
//00054F, "Garmin International
//005C86 SHENZHEN FAST TECHNOLOGIES CO., LTD
//30053F, "JTI Co., Ltd.
//B8DB1C Integrated Device Technology (Malaysia) Sdn. Bhd.
//3C10E6 PHAZR Inc.
//904506, "Tokyo Boeki Medisys Inc.
//0021A1 Cisco Systems, Inc
//FCB698", "Cambridge Industries(Group) Co., Ltd.
//0001CD ARtem
//5C546D HUAWEI TECHNOLOGIES CO., LTD
//84A1D1 Sagemcom Broadband SAS
//909D7D, "ARRIS Group, Inc.
//788C4D Indyme Solutions, LLC
//78BC1A Cisco Systems, Inc
//000E59, "Sagemcom Broadband SAS
//101D51, "8Mesh Networks Limited
//DCEB53", "Wuhan QianXiao Elecronic Technology CO., LTD
//EC8AC7", "Fiberhome Telecommunication Technologies Co., LTD
//88365F, "LG Electronics (Mobile Communications)
//288CB8 zte corporation
//FC7F56", "CoSyst Control Systems GmbH
//2C4053 Samsung Electronics Co., Ltd
//0C8FFF HUAWEI TECHNOLOGIES CO., LTD
//54B121 HUAWEI TECHNOLOGIES CO., LTD
//2880A2 Novatel Wireless Solutions, Inc.
//788102, "Sercomm Corporation.
//84AA9C MitraStar Technology Corp.
//F0EFD2 TF PAYMENT SERVICE CO., LTD
//24B2DE Espressif Inc.
//F4939F Hon Hai Precision Ind.Co., Ltd.
//000726, "SHENZHEN GONGJIN ELECTRONICS CO., LT
//FC8B97", "SHENZHEN GONGJIN ELECTRONICS CO., LT
//2CAB25 SHENZHEN GONGJIN ELECTRONICS CO., LT
//1CA532 SHENZHEN GONGJIN ELECTRONICS CO., LT
//001F92, "Avigilon Corporation
//000C03 HDMI Licensing, LLC
//7CBACC IEEE Registration Authority
//94F128, "Hewlett Packard Enterprise
//101B54 HUAWEI TECHNOLOGIES CO., LTD
//A80C63", "HUAWEI TECHNOLOGIES CO., LTD
//5CC307 HUAWEI TECHNOLOGIES CO., LTD
//E0107F", "Ruckus Wireless
//C4017C Ruckus Wireless
//04FA3F Opticore Inc.
//540237, "Teltronic AG
//4CB008 Shenzhen Gwelltimes Technology Co., Ltd
//E86FF2", "Actiontec Electronics, Inc
//005018, "AMIT, Inc.
//70DEF9 FAI WAH INTERNATIONAL (HONG KONG) LIMITED
//B0EABC ASKEY COMPUTER CORP
//94C691 EliteGroup Computer Systems Co., LTD
//3CF591 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//602101, "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//7CEB7F Dmet Products Corp.
//8C8580 Smart Innovation LLC
//404229, "Layer3TV, Inc
//FC2F6B", "Everspin Technologies, Inc.
//287B09 zte corporation
//0025C4 Ruckus Wireless
//C0C520", "Ruckus Wireless
//78B28D Beijing Tengling Technology CO.Ltd
//A88038", "ShenZhen MovingComm Technology Co., Limited
//F81D90", "Solidwintech
//A06A44", "Vizio, Inc
//DCBE7A", "Zhejiang Nurotron Biotechnology Co.
//3438B7 HUMAX Co., Ltd.
//CC0677 Fiberhome Telecommunication Technologies Co., LTD
//784501, "Biamp Systems
//309C23 Micro-Star INTL CO., LTD.
//145E45, "Kaleao Limited
//54D751, "Proximus
//14780B Varex Imaging Deutschland AG
//ACAFB9", "Samsung Electronics Co., Ltd
//88B111 Intel Corporate
//8C395C Bit4id Srl
//D4258B", "Intel Corporate
//041B6D LG Electronics (Mobile Communications)
//F44156", "Arrikto Inc.
//0080C2 IEEE 802.1 Working Group
//688DB6 AETEK INC.
//ECF342 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//50FF20 Keenetic Limited
//E45740", "ARRIS Group, Inc.
//F894C2 Intel Corporate
//70D379, "Cisco Systems, Inc
//00F82C Cisco Systems, Inc
//00C1B1 Cisco Systems, Inc
//F4FCB1", "JJ Corp
//D8C8E9 Phicomm (Shanghai) Co., Ltd.
//7CB960 Shanghai X-Cheng telecom LTD
//B03D96", "Vision Valley FZ LLC
//986C5C Jiangxi Gosun Guard Security Co., Ltd
//24792A Ruckus Wireless
//30D386, "zte corporation
//70DB98 Cisco Systems, Inc
//B42A0E", "Technicolor CH USA Inc.
//9CC8AE Becton, Dickinson and Company
//B0359F", "Intel Corporate
//C0D962 ASKEY COMPUTER CORP
//F80BCB Cisco Systems, Inc
//50D37F, "Yu Fly Mikly Way Science and Technology Co., Ltd.
//181212, "Cepton Technologies
//70D923, "vivo Mobile Communication Co., Ltd.
//B83A08 Tenda Technology Co., Ltd.Dongguan branch
//28B448 HUAWEI TECHNOLOGIES CO., LTD
//100501, "PEGATRON CORPORATION
//2CFAA2 Alcatel-Lucent Enterprise
//A49BF5 Hybridserver Tec GmbH
//503DA1 Samsung Electronics Co., Ltd
//F097E5", "TAMIO, INC
//4C1A3D GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//08028E, "NETGEAR
//E8E732", "Alcatel-Lucent Enterprise
//B47C9C Amazon Technologies Inc.
//F4A739 Juniper Networks
//F470AB", "vivo Mobile Communication Co., Ltd.
//2C5A0F Cisco Systems, Inc
//2C3124 Cisco Systems, Inc
//503237, "Apple, Inc.
//B0481A Apple, Inc.
//B49CDF Apple, Inc.
//48BF6B Apple, Inc.
//2C1DB8 ARRIS Group, Inc.
//58821D, "H.Schomäcker GmbH
//D8A105 Syslane, Co., Ltd.
//BCA042 SHANGHAI FLYCO ELECTRICAL APPLIANCE CO., LTD
//3C0518 Samsung Electronics Co., Ltd
//900628, "Samsung Electronics Co., Ltd
//B4A9FE", "GHIA Technology (Shenzhen) LTD
//08B258 Juniper Networks
//9C84BF Apple, Inc.
//1CA0D3 IEEE Registration Authority
//9CFCD1 Aetheris Technology (Shanghai) Co., Ltd.
//CCCE1E AVM Audiovisuelles Marketing und Computersysteme GmbH
//0CF4D5 Ruckus Wireless
//7C2664 Sagemcom Broadband SAS
//AC6B0F CADENCE DESIGN SYSTEMS INC
//C8B5AD", "Hewlett Packard Enterprise
//7C3866 Texas Instruments
//0C61CF Texas Instruments
//9C1D58 Texas Instruments
//3805AC Piller Group GmbH
//346E9D, "Ericsson AB
//6854C1 ColorTokens, Inc.
//00111B Targa Systems Div L-3 Communications
//6C750D WiFiSONG
//BC3F8F HUAWEI TECHNOLOGIES CO., LTD
//143004, "HUAWEI TECHNOLOGIES CO., LTD
//F4DC41", "YOUNGZONE CULTURE (SHANGHAI) CORP
//C4836F Ciena Corporation
//7CC6C4 Kolff Computer Supplies b.v.
//000F4F, "PCS Systemtechnik GmbH
//A80CCA", "Shenzhen Sundray Technologies Company Limited
//38AA3C SAMSUNG ELECTRO MECHANICS CO., LTD.
//000302, "Charles Industries, Ltd.
//50A4D0 IEEE Registration Authority
//800010, "AT&T
//0024F1, "Shenzhen Fanhai Sanjiang Electronics Co., Ltd.
//142FFD LT SECURITY INC
//0C3CCD Universal Global Scientific Industrial Co., Ltd.
//14ABC5 Intel Corporate
//50D213, "CviLux Corporation
//001E29, "Hypertherm Inc
//5004B8 HUAWEI TECHNOLOGIES CO., LTD
//00D0B2, "Xiotech Corporation
//5CFF35 Wistron Corporation
//CC9F7A", "Chiun Mai Communication Systems, Inc
//78F29E, "PEGATRON CORPORATION
//64777D, "Hitron Technologies. Inc
//9C50EE Cambridge Industries(Group) Co., Ltd.
//40ED98, "IEEE Registration Authority
//C891F9", "Sagemcom Broadband SAS
//ACDCE5", "Procter & Gamble Company
//00B362 Apple, Inc.
//E4E4AB Apple, Inc.
//60D262, "Tzukuri Pty Ltd
//8404D2, "Kirale Technologies SL
//54FA96 Nokia
//60334B Apple, Inc.
//38AFD7 FUJITSU LIMITED
//28993A Arista Networks
//64EB8C Seiko Epson Corporation
//F48C50 Intel Corporate
//DCD255", "Kinpo Electronics, Inc.
//001351, "Niles Audio Corporation
//A02C36", "FN-LINK TECHNOLOGY LIMITED
//000320, "Xpeed, Inc.
//508A0F SHENZHEN FISE TECHNOLOGY HOLDING CO., LTD.
//7CCBE2 IEEE Registration Authority
//A8A5E2 MSF-Vathauer Antriebstechnik GmbH & Co KG
//BCA8A6 Intel Corporate
//74FF4C Skyworth Digital Technology(Shenzhen) Co., Ltd
//68AF13 Futura Mobility
//681AB2 zte corporation
//E04FBD", "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//7CEBAE Ridgeline Instruments
//E0508B", "Zhejiang Dahua Technology Co., Ltd.
//9C1E95 Actiontec Electronics, Inc
//60427F, "SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD
//E89EB4", "Hon Hai Precision Ind. Co., Ltd.
//D46A6A Hon Hai Precision Ind.Co., Ltd.
//98FD74 ACT.CO.LTD
//64DB43 Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//000E58, "Sonos, Inc.
//002590, "Super Micro Computer, Inc.
//AC1F6B Super Micro Computer, Inc.
//000B2E Cal-Comp Electronics & Communications Company Ltd.
//4865EE IEEE Registration Authority
//D0F73B Helmut Mauell GmbH Werk Weida
//180675, "Dilax Intelcom GmbH
//000FC2 Uniwell Corporation
//6CEC5A Hon Hai Precision Ind.CO., Ltd.
//44C346 HUAWEI TECHNOLOGIES CO., LTD
//307496, "HUAWEI TECHNOLOGIES CO., LTD
//708A09 HUAWEI TECHNOLOGIES CO., LTD
//CCC5EF", "Co-Comm Servicios Telecomunicaciones S.L.
//9002A9 Zhejiang Dahua Technology Co., Ltd.
//C0288D Logitech, Inc
//0C4933 Sichuan Jiuzhou Electronic Technology Co., Ltd.
//000064, "Yokogawa Digital Computer Corporation
//506B8D Nutanix
//0038DF Cisco Systems, Inc
//F4CAE5", "FREEBOX SAS
//90004E, "Hon Hai Precision Ind. Co., Ltd.
//7C2634 ARRIS Group, Inc.
//40F413, "Rubezh
//C8D3FF", "Hewlett Packard
//C4BE84 Texas Instruments
//F4F524", "Motorola Mobility LLC, a Lenovo Company
//00BBC1 CANON INC.
//A81E84 QUANTA COMPUTER INC.
//24C1BD CRRC DALIAN R&D CO., LTD.
//00A2EE Cisco Systems, Inc
//0059DC Cisco Systems, Inc
//00FD45 Hewlett Packard Enterprise
//5098F3, "Rheem Australia Pty Ltd
//B4D135 Cloudistics
//0013A5 General Solutions, LTD.
//9C3DCF NETGEAR
//248894, "shenzhen lensun Communication Technology LTD
//B04BBF", "PT HAN SUNG ELECTORONICS INDONESIA
//CC2D83", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//0015FF Novatel Wireless Solutions, Inc.
//D46E0E TP-LINK TECHNOLOGIES CO., LTD.
//88366C EFM Networks
//48DA96 Eddy Smart Home Solutions Inc.
//F074E4 Thundercomm Technology Co., Ltd
//A0722C", "HUMAX Co., Ltd.
//FCD848 Apple, Inc.
//EC107B Samsung Electronics Co., Ltd
//1C232C Samsung Electronics Co., Ltd
//E00DB9", "Cree, Inc.
//DC0D30 Shenzhen Feasycom Technology Co., Ltd.
//F0ACD7 IEEE Registration Authority
//9495A0 Google, Inc.
//00A6CA Cisco Systems, Inc
//38D547, "ASUSTek COMPUTER INC.
//FC83C6 N-Radio Technologies Co., Ltd.
//30B64F Juniper Networks
//1C9D3E Integrated Device Technology (Malaysia) Sdn. Bhd.
//F02FA7 HUAWEI TECHNOLOGIES CO., LTD
//18DED7 HUAWEI TECHNOLOGIES CO., LTD
//C83DD4", "CyberTAN Technology Inc.
//E0B94D SHENZHEN BILIAN ELECTRONIC CO.，LTD
//D8452B", "Integrated Device Technology (Malaysia) Sdn. Bhd.
//E4186B Zyxel Communications Corporation
//008731, "Cisco Systems, Inc
//88DEA9 Roku, Inc.
//78888A CDR Sp.z o.o.Sp.k.
//D41D71 Palo Alto Networks
//0021D1, "Samsung Electronics Co., Ltd
//001FCC Samsung Electronics Co., Ltd
//A42983", "Boeing Defence Australia
//EC8892", "Motorola Mobility LLC, a Lenovo Company
//7487A9 OCT Technology Co., Ltd.
//004A77 zte corporation
//A41437", "Hangzhou Hikvision Digital Technology Co., Ltd.
//60A10A Samsung Electronics Co., Ltd
//8C71F8 Samsung Electronics Co., Ltd
//CC051B", "Samsung Electronics Co., Ltd
//8C7712 Samsung Electronics Co., Ltd
//9463D1, "Samsung Electronics Co., Ltd
//0021D2, "Samsung Electronics Co., Ltd
//5C497D Samsung Electronics Co., Ltd
//98234E, "Micromedia AG
//503F98, "CMITECH
//782079, "ID Tech
//0C6076 Hon Hai Precision Ind.Co., Ltd.
//0CEEE6 Hon Hai Precision Ind.Co., Ltd.
//E4D53D Hon Hai Precision Ind.Co., Ltd.
//C0143D Hon Hai Precision Ind.Co., Ltd.
//C01885 Hon Hai Precision Ind.Co., Ltd.
//00749C Ruijie Networks Co., LTD
//5894CF Vertex Standard LMR, Inc.
//20F85E, "Delta Electronics
//7825AD Samsung Electronics Co., Ltd
//ECE09B", "Samsung Electronics Co., Ltd
//0023E4, "IPnect co. ltd.
//70D4F2, "RIM
//78D6F0, "SAMSUNG ELECTRO MECHANICS CO., LTD.
//BC20A4 Samsung Electronics Co., Ltd
//08D42B Samsung Electronics Co., Ltd
//789ED0, "Samsung Electronics Co., Ltd
//B0C4E7", "Samsung Electronics Co., Ltd
//A00798", "Samsung Electronics Co., Ltd
//001FCD Samsung Electronics Co., Ltd
//38ECE4 Samsung Electronics Co., Ltd
//945103, "Samsung Electronics Co., Ltd
//002490, "Samsung Electronics Co., Ltd
//0023D7, "Samsung Electronics Co., Ltd
//549B12 Samsung Electronics Co., Ltd
//FCA13E", "Samsung Electronics Co., Ltd
//24C696 Samsung Electronics Co., Ltd
//94D771, "Samsung Electronics Co., Ltd
//E84E84", "Samsung Electronics Co., Ltd
//001632, "Samsung Electronics Co., Ltd
//E4E0C5", "Samsung Electronics Co., Ltd
//C81479", "Samsung Electronics Co., Ltd
//1CAF05 Samsung Electronics Co., Ltd
//0016DB Samsung Electronics Co., Ltd
//001EE2 Samsung Electronics Co., Ltd
//20D5BF Samsung Electronics Co., Ltd
//5CE8EB Samsung Electronics Co., Ltd
//C0BDD1", "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//B479A7", "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//7C11CB HUAWEI TECHNOLOGIES CO., LTD
//1C25E1 China Mobile IOT Company Limited
//C0F636 Hangzhou Kuaiyue Technologies, Ltd.
//001A22 eQ-3 Entwicklung GmbH
//B0DF3A Samsung Electronics Co., Ltd
//805719, "Samsung Electronics Co., Ltd
//34BE00 Samsung Electronics Co., Ltd
//54E2E0 ARRIS Group, Inc.
//347A60 ARRIS Group, Inc.
//001CC3 ARRIS Group, Inc.
//240DC2 TCT mobile ltd
//78521A Samsung Electronics Co., Ltd
//7085C6 ARRIS Group, Inc.
//20BBC6 Jabil Circuit Hungary Ltd.
//04FEA1 Fihonest communication co., Ltd
//EC8CA2", "Ruckus Wireless
//B80018 Htel
//7472B0 Guangzhou Shiyuan Electronics Co., Ltd.
//546C0E Texas Instruments
//EC8EAE", "Nagravision SA
//A043DB Sitael S.p.A.
//E0E7BB Nureva, Inc.
//00808C NetAlly
//049F81, "NetAlly
//001087, "XSTREAMIS PLC
//00B0B3 XSTREAMIS PLC
//049FCA HUAWEI TECHNOLOGIES CO., LTD
//50016B HUAWEI TECHNOLOGIES CO., LTD
//AC482D", "Ralinwi Nanjing Electronic Technology Co., Ltd.
//002363, "Zhuhai Raysharp Technology Co., Ltd
//00001B Novell, Inc.
//009058, "Ultra Electronics Command & Control Systems
//001CFD Universal Electronics, Inc.
//080087, "Xyplex, Inc.
//DC1A01 Ecoliv Technology (Shenzhen ) Ltd.
//00549F, "Avaya Inc
//2824FF Wistron Neweb Corporation
//38256B Microsoft Mobile Oy
//001CEF Primax Electronics Ltd.
//000276, "Primax Electronics Ltd.
//4CB21C Maxphotonics Co., Ltd
//205EF7, "Samsung Electronics Co., Ltd
//141F78, "Samsung Electronics Co., Ltd
//D84710", "Sichuan Changhong Electric Ltd.
//001972, "Plexus (Xiamen) Co., ltd.
//002347, "ProCurve Networking by HP
//0024A8 ProCurve Networking by HP
//C09134", "ProCurve Networking by HP
//001969, "Nortel Networks
//0018B0 Nortel Networks
//0016CA Nortel Networks
//000FCD Nortel Networks
//001BBA Nortel Networks
//0004DC Nortel Networks
//000CF7 Nortel Networks
//00140E, "Nortel Networks
//001E1F, "Nortel Networks
//203AEF Sivantos GmbH
//005979, "Networked Energy Services
//207C8F Quanta Microsystems, Inc.
//000B34 ShangHai Broadband Technologies CO.LTD
//74B57E zte corporation
//B8BB23", "Guangdong Nufront CSC Co., Ltd
//34EA34 HangZhou Gubei Electronics Technology Co., Ltd
//3092F6, "SHANGHAI SUNMON COMMUNICATION TECHNOGY CO., LTD
//A8AD3D", "Alcatel-Lucent Shanghai Bell Co., Ltd
//24AF4A Alcatel-Lucent IPD
//7C2064 Alcatel-Lucent IPD
//44DC91 PLANEX COMMUNICATIONS INC.
//E09DB8 PLANEX COMMUNICATIONS INC.
//000F59, "Phonak AG
//001478, "TP-LINK TECHNOLOGIES CO., LTD.
//48F8E1, "Nokia
//8C90D3 Nokia
//0028F8, "Intel Corporate
//58BC8F Cognitive Systems Corp.
//D455BE SHENZHEN FAST TECHNOLOGIES CO., LTD
//640DCE SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//54D272, "Nuki Home Solutions GmbH
//EC26FB TECC CO., LTD.
//0020F4, "SPECTRIX CORPORATION
//04EE91 x-fabric GmbH
//B47443 Samsung Electronics Co., Ltd
//FCF647", "Fiberhome Telecommunication Technologies Co., LTD
//18686A zte corporation
//C44BD1", "Wallys Communications", "Teachnologies Co., Ltd.
//6CB9C5 Delta Networks, Inc.
//30766F, "LG Electronics (Mobile Communications)
//A8922C", "LG Electronics (Mobile Communications)
//F80CF3", "LG Electronics (Mobile Communications)
//C49A02", "LG Electronics (Mobile Communications)
//001F6B LG Electronics (Mobile Communications)
//0026E2, "LG Electronics (Mobile Communications)
//DC4427", "IEEE Registration Authority
//BC3400", "IEEE Registration Authority
//E8886C", "Shenzhen SC Technologies Co., LTD
//0024FF QLogic Corporation
//001E21, "Qisda Corporation
//00039D, "Qisda Corporation
//00080D, "Toshiba
//000E7B Toshiba
//0003B2 Radware
//089E01, "QUANTA COMPUTER INC.
//047D7B QUANTA COMPUTER INC.
//9C6121 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//00A0C6 Qualcomm Inc.
//649C81 Qualcomm Inc.
//001A6A Tranzas, Inc.
//A47174 HUAWEI TECHNOLOGIES CO., LTD
//F4CB52", "HUAWEI TECHNOLOGIES CO., LTD
//B808D7", "HUAWEI TECHNOLOGIES CO., LTD
//94611E, "Wata Electronics Co., Ltd.
//00C0E4 SIEMENS BUILDING
//000D10, "Embedtronics Oy
//001FA8 Smart Energy Instruments Inc.
//000FDB Westell Technologies Inc.
//3C0771 Sony Corporation
//80414E, "BBK EDUCATIONAL ELECTRONICS CORP., LTD.
//249442, "OPEN ROAD SOLUTIONS , INC.
//C46413 Cisco Systems, Inc
//0010CA Telco Systems, Inc.
//00E09E Quantum Corporation
//000A08 Alpine Electronics, Inc.
//206A8A Wistron Infocomm (Zhongshan) Corporation
//784476, "Zioncom Electronics (Shenzhen) Ltd.
//001165, "ZNYX Networks, Inc.
//000A68 Solarflare Communications Inc.
//002186, "Universal Global Scientific Industrial Co., Ltd.
//183919, "Unicoi Systems
//E8E0B7 Toshiba
//680715, "Intel Corporate
//3CB6B7 vivo Mobile Communication Co., Ltd.
//C42795 Technicolor CH USA Inc.
//A020A6 Espressif Inc.
//58528A Mitsubishi Electric Corporation
//C4F1D1 BEIJING SOGOU TECHNOLOGY DEVELOPMENT CO., LTD.
//ACE77B SICHUAN TIANYI COMHEART TELECOMCO., LTD
//2C36A0 Capisco Limited
//B0B2DC", "Zyxel Communications Corporation
//CC5D4E", "Zyxel Communications Corporation
//404A03 Zyxel Communications Corporation
//C86C87 Zyxel Communications Corporation
//001EC0 Microchip Technology Inc.
//645D92, "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//38BC1A MEIZU Technology Co., Ltd.
//38F0C8 Livestream
//802994, "Technicolor CH USA Inc.
//E0885D Technicolor CH USA Inc.
//340AFF Qingdao Hisense Communications Co., Ltd.
//587E61, "Qingdao Hisense Communications Co., Ltd.
//C0A1A2 MarqMetrix
//08D0B7, "Qingdao Hisense Communications Co., Ltd.
//ECD68A Shenzhen JMicron Intelligent Technology Developmen
//5052D2, "Hangzhou Telin Technologies Co., Limited
//90EED9 UNIVERSAL DE DESARROLLOS ELECTRÓNICOS, SA
//606453, "AOD Co., Ltd.
//6C98EB Riverbed Technology, Inc.
//009E1E Cisco Systems, Inc
//00253E, "Sensus Metering Systems
//C8AFE3", "Hefei Radio Communication Technology Co., Ltd
//CCA260", "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//7C574E COBI GmbH
//28F10E, "Dell Inc.
//045604, "Gionee Communication Equipment Co., Ltd.
//34C0F9 Rockwell Automation
//00FEC8 Cisco Systems, Inc
//2C5A8D SYSTRONIK Elektronik u. Systemtechnik GmbH
//10BEF5 D-Link International
//E47B3F BEIJING CO-CLOUD TECHNOLOGY LTD.
//0C8A87 AgLogica Holdings, Inc
//54EDA3 Navdy, Inc.
//40F420, "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//34A2A2 HUAWEI TECHNOLOGIES CO., LTD
//749D8F, "HUAWEI TECHNOLOGIES CO., LTD
//945907, "Shanghai HITE-BELDEN Network Technology Co., Ltd.
//001848, "Vecima Networks Inc.
//0016FB SHENZHEN MTC CO LTD
//A0415E", "Opsens Solution Inc.
//A860B6 Apple, Inc.
//C4B301 Apple, Inc.
//E05F45 Apple, Inc.
//74CC39 Fiberhome Telecommunication Technologies Co., LTD
//3822D6, "Hangzhou H3C Technologies Co., Limited
//94E8C5 ARRIS Group, Inc.
//6C3B6B Routerboard.com
//0022E7, "WPS Parking Systems
//4851B7 Intel Corporate
//B8E779, "9Solutions Oy
//C864C7 zte corporation
//483B38 Apple, Inc.
//1C9148 Apple, Inc.
//905F2E, "TCT mobile ltd
//F823B2", "HUAWEI TECHNOLOGIES CO., LTD
//341290, "Treeview Co., Ltd.
//7CFE4E Shenzhen Safe vision Technology Co., LTD
//644FB0 Hyunjin.com
//00E0E6 INCAA Computers
//28F366, "Shenzhen Bilian electronic CO., LTD
//E0A3AC", "HUAWEI TECHNOLOGIES CO., LTD
//BC7574", "HUAWEI TECHNOLOGIES CO., LTD
//20A680 HUAWEI TECHNOLOGIES CO., LTD
//8828B3 HUAWEI TECHNOLOGIES CO., LTD
//A4E597", "Gessler GmbH
//006CBC Cisco Systems, Inc
//5C70A3 LG Electronics (Mobile Communications)
//001D08, "Jiangsu Yinhe", "Electronics Co., Ltd.
//001D82, "GN Netcom A/S
//001317, "GN Netcom A/S
//00A0A4 Oracle Corporation
//749781, "zte corporation
//0001F4, "Enterasys
//00109B Emulex Corporation
//00142A Elitegroup Computer Systems Co., Ltd.
//00115B Elitegroup Computer Systems Co., Ltd.
//C03FD5 Elitegroup Computer Systems Co., Ltd.
//ECA86B Elitegroup Computer Systems Co., Ltd.
//C89CDC Elitegroup Computer Systems Co., Ltd.
//002511, "Elitegroup Computer Systems Co., Ltd.
//4487FC Elitegroup Computer Systems Co., Ltd.
//A86BAD Hon Hai Precision Ind.Co., Ltd.
//D80F99 Hon Hai Precision Ind.Co., Ltd.
//B4B15A Siemens AG Energy Management Division
//002465, "Elentec
//00089F, "EFM Networks
//0050FC Edimax Technology Co. Ltd.
//9CDF03 Harman/Becker Automotive Systems GmbH
//001188, "Enterasys
//0016FA ECI Telecom Ltd.
//F8A188 LED Roadway Lighting
//A082AC Linear DMS Solutions Sdn.Bhd.
//A86AC1 HanbitEDS Co., Ltd.
//D463FE Arcadyan Corporation
//689361, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//BC15AC Vodafone Italia S.p.A.
//00BD82 Shenzhen YOUHUA Technology Co., Ltd
//94513D, "iSmart Alarm, Inc.
//001174, "Mojo Networks, Inc.
//001954, "Leaf Corporation.
//9466E7, "WOM Engineering
//4CB8B5 Shenzhen YOUHUA Technology Co., Ltd
//7085C2 ASRock Incorporation
//EC93ED", "DDoS-Guard LTD
//30FC68 TP-LINK TECHNOLOGIES CO., LTD.
//008A96 Cisco Systems, Inc
//BC60A7", "Sony Interactive Entertainment Inc.
//808C97 Kaonmedia CO., LTD.
//DCEE06 HUAWEI TECHNOLOGIES CO., LTD
//0452C7 Bose Corporation
//F02745", "F-Secure Corporation
//54D0B4, "Xiamen Four-Faith Communication Technology Co., Ltd
//00137C Kaicom co., Ltd.
//E85659 Advanced-Connectek Inc.
//34BF90 Fiberhome Telecommunication Technologies Co., LTD
//CCB3F8", "FUJITSU ISOTEC LIMITED
//E4A471", "Intel Corporate
//10F005, "Intel Corporate
//64CC2E Xiaomi Communications Co Ltd
//8801F2, "Vitec System Engineering Inc.
//14D11F, "HUAWEI TECHNOLOGIES CO., LTD
//DC094C", "HUAWEI TECHNOLOGIES CO., LTD
//1C6758 HUAWEI TECHNOLOGIES CO., LTD
//24BCF8 HUAWEI TECHNOLOGIES CO., LTD
//A0043E", "Parker Hannifin Manufacturing Germany GmbH & Co.KG
//C84529", "IMK Networks Co., Ltd
//7C477C IEEE Registration Authority
//F877B8 Samsung Electronics Co., Ltd
//F0D2F1", "Amazon Technologies Inc.
//A8E3EE Sony Interactive Entertainment Inc.
//00248D, "Sony Interactive Entertainment Inc.
//00041F, "Sony Interactive Entertainment Inc.
//20A90E TCT mobile ltd
//EC438B YAPTV
//980CA5 Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//441102, "EDMI Europe Ltd
//A85EE4, "12Sided Technology, LLC
//182195, "Samsung Electronics Co., Ltd
//44783E, "Samsung Electronics Co., Ltd
//0CA2F4 Chameleon Technology (UK) Limited
//BC44B0 Elastifile
//74BFB7 Nusoft Corporation
//50DA00 Hangzhou H3C Technologies Co., Limited
//F4ED5F", "SHENZHEN KTC TECHNOLOGY GROUP
//00E0E4 FANUC ROBOTICS NORTH AMERICA, Inc.
//000896, "Printronix, Inc.
//245EBE QNAP Systems, Inc.
//0404EA Valens Semiconductor Ltd.
//800DD7 Latticework, Inc
//D0B53D", "SEPRO ROBOTIQUE
//00D0EC NAKAYO Inc
//4CCC6A Micro-Star INTL CO., LTD.
//30636B Apple, Inc.
//70884D, "JAPAN RADIO CO., LTD.
//A4F1E8 Apple, Inc.
//546751, "Compal Broadband Networks, Inc.
//240B0A Palo Alto Networks
//D099D5 Alcatel-Lucent
//14C3C2 K.A.Schmersal GmbH & Co.KG
//10785B Actiontec Electronics, Inc
//DC0077", "TP-LINK TECHNOLOGIES CO., LTD.
//F4F5A5 Nokia Corporation
//EC9B5B", "Nokia Corporation
//2CCC15 Nokia Corporation
//14BB6E Samsung Electronics Co., Ltd
//1886AC Nokia Danmark A/S
//001F5C Nokia Danmark A/S
//001F00, "Nokia Danmark A/S
//002547, "Nokia Danmark A/S
//0018C5 Nokia Danmark A/S
//00164E, "Nokia Danmark A/S
//002668, "Nokia Danmark A/S
//00247D, "Nokia Danmark A/S
//002265, "Nokia Danmark A/S
//F88096", "Elsys Equipamentos Eletrônicos Ltda
//A811FC ARRIS Group, Inc.
//001DAA DrayTek Corp.
//E498D1 Microsoft Mobile Oy
//6C2779 Microsoft Mobile Oy
//00CF1C Communication Machinery Corporation
//28CC01 Samsung Electronics Co., Ltd
//D8FB5E", "ASKEY COMPUTER CORP
//002326, "FUJITSU LIMITED
//0CBF15 Genetec Inc.
//000D4B Roku, Inc.
//0040FB CASCADE COMMUNICATIONS
//D0542D", "Cambridge Industries(Group) Co., Ltd.
//744AA4 zte corporation
//001BA9 Brother industries, LTD.
//30A220 ARG Telecom
//6CF373 Samsung Electronics Co., Ltd
//9C3AAF Samsung Electronics Co., Ltd
//781FDB Samsung Electronics Co., Ltd
//4CA56D Samsung Electronics Co., Ltd
//B86CE8", "Samsung Electronics Co., Ltd
//0CB319 Samsung Electronics Co., Ltd
//183F47, "Samsung Electronics Co., Ltd
//B46293", "Samsung Electronics Co., Ltd
//50A4C8 Samsung Electronics Co., Ltd
//00001D, "Cabletron Systems, Inc.
//1867B0 Samsung Electronics Co., Ltd
//6C8336 Samsung Electronics Co., Ltd
//DCD87C", "Beijing Jingdong Century Trading Co., LTD.
//C4DA7D Ivium Technologies B.V.
//000B6A Asiarock Technology Limited
//009096, "ASKEY COMPUTER CORP
//001B9E ASKEY COMPUTER CORP
//E0CA94 ASKEY COMPUTER CORP
//0026B6 ASKEY COMPUTER CORP
//002557, "BlackBerry RTS
//001CCC BlackBerry RTS
//00300A Aztech Electronics Pte Ltd
//001F3F, "AVM GmbH
//246511, "AVM GmbH
//C0FFD4 NETGEAR
//6CB0CE NETGEAR
//008EF2, "NETGEAR
//9CD36D NETGEAR
//C40415 NETGEAR
//E8FCAF NETGEAR
//841B5E NETGEAR
//2CB05D NETGEAR
//A021B7 NETGEAR
//0024B2 NETGEAR
//001B2F NETGEAR
//00264D, "Arcadyan Technology Corporation
//849CA6 Arcadyan Technology Corporation
//E03E44 Broadcom
//001F33, "NETGEAR
//002040, "ARRIS Group, Inc.
//386BBB ARRIS Group, Inc.
//E86D52 ARRIS Group, Inc.
//3C754A ARRIS Group, Inc.
//E48399 ARRIS Group, Inc.
//002143, "ARRIS Group, Inc.
//74F612, "ARRIS Group, Inc.
//002495, "ARRIS Group, Inc.
//0024A0 ARRIS Group, Inc.
//00080E, "ARRIS Group, Inc.
//00909C ARRIS Group, Inc.
//001225, "ARRIS Group, Inc.
//145BD1 ARRIS Group, Inc.
//6CC1D2 ARRIS Group, Inc.
//1C1448 ARRIS Group, Inc.
//001784, "ARRIS Group, Inc.
//001C11 ARRIS Group, Inc.
//001E46, "ARRIS Group, Inc.
//0018A4 ARRIS Group, Inc.
//0018C0 ARRIS Group, Inc.
//002374, "ARRIS Group, Inc.
//ACE010 Liteon Technology Corporation
//747548, "Amazon Technologies Inc.
//0000B1 Alpha Micro
//001802, "Alpha Networks Inc.
//001E45, "Sony Mobile Communications Inc
//001CA4 Sony Mobile Communications Inc
//001A75 Sony Mobile Communications Inc
//78843C Sony Corporation
//0013A9 Sony Corporation
//000AD9 Sony Mobile Communications Inc
//000E07, "Sony Mobile Communications Inc
//94CE2C Sony Mobile Communications Inc
//FC0FE6", "Sony Interactive Entertainment Inc.
//74DE2B Liteon Technology Corporation
//00225F, "Liteon Technology Corporation
//5C93A2 Liteon Technology Corporation
//24FD52 Liteon Technology Corporation
//2CD05A Liteon Technology Corporation
//74E543, "Liteon Technology Corporation
//0015CF ARRIS Group, Inc.
//6CFAA7 AMPAK Technology, Inc.
//0023F1, "Sony Mobile Communications Inc
//54E4BD FN-LINK TECHNOLOGY LIMITED
//5414FD Orbbec 3D Technology International
//900BC1 Sprocomm Technologies CO., Ltd
//001CA8 AirTies Wireless Networks
//485D60, "AzureWave Technology Inc.
//DC85DE AzureWave Technology Inc.
//B0EE45 AzureWave Technology Inc.
//00238E, "ADB Broadband Italia
//001D8B ADB Broadband Italia
//0013C8 ADB Broadband Italia
//DC0B1A ADB Broadband Italia
//0C6AE6 Stanley Security Solutions
//842615, "ADB Broadband Italia
//F0842F", "ADB Broadband Italia
//54271E, "AzureWave Technology Inc.
//28C2DD AzureWave Technology Inc.
//80A589 AzureWave Technology Inc.
//C40938 FUJIAN STAR-NET COMMUNICATION CO., LTD
//001C50 TCL Technoly Electronics (Huizhou) Co., Ltd.
//00AA02 Intel Corporation
//ACE5F0", "Doppler Labs
//F48E38 Dell Inc.
//74C63B AzureWave Technology Inc.
//7C7A91 Intel Corporate
//AC7BA1", "Intel Corporate
//6C2995 Intel Corporate
//984FEE Intel Corporate
//E82AEA", "Intel Corporate
//605718, "Intel Corporate
//C4D987 Intel Corporate
//FCF8AE", "Intel Corporate
//6036DD Intel Corporate
//100BA9 Intel Corporate
//8C705A Intel Corporate
//606720, "Intel Corporate
//7C5CF8 Intel Corporate
//B4E1C4", "Microsoft Mobile Oy
//E0757D", "Motorola Mobility LLC, a Lenovo Company
//34BB26 Motorola Mobility LLC, a Lenovo Company
//806C1B Motorola Mobility LLC, a Lenovo Company
//0016EB Intel Corporate
//0018DE Intel Corporate
//5CE0C5 Intel Corporate
//58A839 Intel Corporate
//001E67, "Intel Corporate
//0022FA Intel Corporate
//001500, "Intel Corporate
//A088B4 Intel Corporate
//648099, "Intel Corporate
//D07E35 Intel Corporate
//001E65, "Intel Corporate
//348446, "Ericsson AB
//044E06, "Ericsson AB
//00270E, "Intel Corporate
//0026B9 Dell Inc.
//64006A Dell Inc.
//00D09E, "2Wire Inc
//0019E4, "2Wire Inc
//001AC4", "2Wire Inc
//001B5B", "2Wire Inc
//3CEA4F", "2Wire Inc
//DC7FA4", "2Wire Inc
//B0D5CC Texas Instruments
//3829DD ONvocal Inc
//001EC7", "2Wire Inc
//002650, "2Wire Inc
//002351, "2Wire Inc
//001E4F, "Dell Inc.
//5C260A Dell Inc.
//7845C4 Dell Inc.
//C81F66 Dell Inc.
//0015C5 Dell Inc.
//001422, "Dell Inc.
//109836, "Dell Inc.
//800A80 IEEE Registration Authority
//F8DB88 Dell Inc.
//3CA348 vivo Mobile Communication Co., Ltd.
//E45AA2 vivo Mobile Communication Co., Ltd.
//CC3B3E Lester Electrical
//2082C0 Xiaomi Communications Co Ltd
//DC6DCD", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//C4282D", "Embedded Intellect Pty Ltd
//5846E1, "Baxter International Inc
//00173F, "Belkin International Inc.
//001CDF Belkin International Inc.
//C05627 Belkin International Inc.
//4C17EB Sagemcom Broadband SAS
//CC33BB Sagemcom Broadband SAS
//D86CE9 Sagemcom Broadband SAS
//E8F1B0 Sagemcom Broadband SAS
//5C6B32 Texas Instruments
//84DD20 Texas Instruments
//001831, "Texas Instruments
//24FD5B SmartThings, Inc.
//2876CD Funshion Online Technologies Co., Ltd
//205532, "Gotech International Technology Limited
//2CFF65 Oki Electric Industry Co., Ltd.
//2C27D7 Hewlett Packard
//984BE1 Hewlett Packard
//002926, "Applied Optoelectronics, Inc Taiwan Branch
//24BA13 RISO KAGAKU CORPORATION
//0017E5, "Texas Instruments
//0017EC Texas Instruments
//0017E7, "Texas Instruments
//0017E9, "Texas Instruments
//1CBA8C Texas Instruments
//0015E9, "D-Link Corporation
//001B11 D-Link Corporation
//00265A D-Link Corporation
//C8BE19 D-Link International
//A4BA76 HUAWEI TECHNOLOGIES CO., LTD
//0050C2 IEEE Registration Authority
//440010, "Apple, Inc.
//0056CD Apple, Inc.
//006037, "NXP Semiconductors
//DCC0EB ASSA ABLOY CÔTE PICARDE
//28BC56 EMAC, Inc.
//00CDFE Apple, Inc.
//A0F895 Shenzhen TINNO Mobile Technology Corp.
//0078CD Ignition Design Labs
//B436A9 Fibocom Wireless Inc.
//70CA4D Shenzhen lnovance Technology Co., Ltd.
//001A11 Google, Inc.
//48DB50 HUAWEI TECHNOLOGIES CO., LTD
//C8665D", "Aerohive Networks Inc.
//C8478C Beken Corporation
//D854A2", "Aerohive Networks Inc.
//9CEFD5 Panda Wireless, Inc.
//9C3426 ARRIS Group, Inc.
//2C6E85 Intel Corporate
//001DD1 ARRIS Group, Inc.
//001DCF ARRIS Group, Inc.
//001DD5 ARRIS Group, Inc.
//001DD4 ARRIS Group, Inc.
//E498D6 Apple, Inc.
//002283, "Juniper Networks
//0010DB Juniper Networks
//00121E, "Juniper Networks
//E01C41 Aerohive Networks Inc.
//CCA462 ARRIS Group, Inc.
//484520, "Intel Corporate
//C80E77 Le Shi Zhi Xin Electronic Technology (Tianjin) Limited
//106F3F, "BUFFALO.INC
//9049FA Intel Corporate
//BC0F64", "Intel Corporate
//0000C5 ARRIS Group, Inc.
//6455B1 ARRIS Group, Inc.
//0002B3 Intel Corporation
//000347, "Intel Corporation
//000E0C Intel Corporation
//D8D385", "Hewlett Packard
//18A905 Hewlett Packard
//001B78 Hewlett Packard
//E4FAFD", "Intel Corporate
//94659C Intel Corporate
//B0C745", "BUFFALO.INC
//14CFE2 ARRIS Group, Inc.
//44E137, "ARRIS Group, Inc.
//001320, "Intel Corporate
//0080E1, "STMicroelectronics SRL
//F8DB7F HTC Corporation
//64A769 HTC Corporation
//E899C4", "HTC Corporation
//BCCFCC HTC Corporation
//0004EA Hewlett Packard
//001279, "Hewlett Packard
//001321, "Hewlett Packard
//000802, "Hewlett Packard
//0002A5 Hewlett Packard
//001871, "Hewlett Packard
//000E7F, "Hewlett Packard
//001185, "Hewlett Packard
//10604B Hewlett Packard
//C8CBB8", "Hewlett Packard
//843497, "Hewlett Packard
//6CC217 Hewlett Packard
//1458D0, "Hewlett Packard
//5C8A38 Hewlett Packard
//EC9A74", "Hewlett Packard
//2C59E5 Hewlett Packard
//D8FC38", "Giantec Semiconductor Inc
//AC2A0C", "CSR ZHUZHOU INSTITUTE CO., LTD.
//2C6798 InTalTech Ltd.
//00234D, "Hon Hai Precision Ind. Co., Ltd.
//002556, "Hon Hai Precision Ind. Co., Ltd.
//601888, "zte corporation
//D860B0 bioMérieux Italia S.p.A.
//54E6FC TP-LINK TECHNOLOGIES CO., LTD.
//74EA3A TP-LINK TECHNOLOGIES CO., LTD.
//F81A67 TP-LINK TECHNOLOGIES CO., LTD.
//EC172F TP-LINK TECHNOLOGIES CO., LTD.
//847778, "Cochlear Limited
//887F03, "Comper Technology Investment Limited
//0019E0, "TP-LINK TECHNOLOGIES CO., LTD.
//002586, "TP-LINK TECHNOLOGIES CO., LTD.
//D81FCC Brocade Communications Systems, Inc.
//F431C3 Apple, Inc.
//64A5C3 Apple, Inc.
//28565A Hon Hai Precision Ind.Co., Ltd.
//6CB56B HUMAX Co., Ltd.
//BC3AEA GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//E422A5", "PLANTRONICS, INC.
//D4C9B2 Quanergy Systems Inc
//6021C0 Murata Manufacturing Co., Ltd.
//88308A Murata Manufacturing Co., Ltd.
//5CDAD4 Murata Manufacturing Co., Ltd.
//0026E8, "Murata Manufacturing Co., Ltd.
//002512, "zte corporation
//001C26 Hon Hai Precision Ind.Co., Ltd.
//0027F8, "Brocade Communications Systems, Inc.
//748EF8, "Brocade Communications Systems, Inc.
//002438, "Brocade Communications Systems, Inc.
//0014C9 Brocade Communications Systems, Inc.
//14E6E4 TP-LINK TECHNOLOGIES CO., LTD.
//344B50 zte corporation
//FCC897", "zte corporation
//0016CE Hon Hai Precision Ind.Co., Ltd.
//002268, "Hon Hai Precision Ind. Co., Ltd.
//50EB1A Brocade Communications Systems, Inc.
//001882, "HUAWEI TECHNOLOGIES CO., LTD
//D4EA0E", "Avaya Inc
//6CFA58 Avaya Inc
//20F3A3 HUAWEI TECHNOLOGIES CO., LTD
//0C37DC HUAWEI TECHNOLOGIES CO., LTD
//BC7670", "HUAWEI TECHNOLOGIES CO., LTD
//24DBAC HUAWEI TECHNOLOGIES CO., LTD
//1C1D67 HUAWEI TECHNOLOGIES CO., LTD
//300ED5, "Hon Hai Precision Ind. Co., Ltd.
//485AB6 Hon Hai Precision Ind.Co., Ltd.
//543530, "Hon Hai Precision Ind. Co., Ltd.
//F866D1 Hon Hai Precision Ind.Co., Ltd.
//2469A5 HUAWEI TECHNOLOGIES CO., LTD
//EC233D", "HUAWEI TECHNOLOGIES CO., LTD
//78F5FD HUAWEI TECHNOLOGIES CO., LTD
//5C7D5E HUAWEI TECHNOLOGIES CO., LTD
//90671C HUAWEI TECHNOLOGIES CO., LTD
//BC25E0", "HUAWEI TECHNOLOGIES CO., LTD
//F4E3FB", "HUAWEI TECHNOLOGIES CO., LTD
//D02DB3", "HUAWEI TECHNOLOGIES CO., LTD
//E8CD2D", "HUAWEI TECHNOLOGIES CO., LTD
//84A8E4 HUAWEI TECHNOLOGIES CO., LTD
//0C96BF HUAWEI TECHNOLOGIES CO., LTD
//60E701, "HUAWEI TECHNOLOGIES CO., LTD
//E8088B", "HUAWEI TECHNOLOGIES CO., LTD
//A051C6", "Avaya Inc
//F0EBD0 Shanghai Feixun Communication Co., Ltd.
//643E8C HUAWEI TECHNOLOGIES CO., LTD
//0012D2, "Texas Instruments
//A863F2 Texas Instruments
//7C6097 HUAWEI TECHNOLOGIES CO., LTD
//CC53B5", "HUAWEI TECHNOLOGIES CO., LTD
//60DE44 HUAWEI TECHNOLOGIES CO., LTD
//105172, "HUAWEI TECHNOLOGIES CO., LTD
//08E84F, "HUAWEI TECHNOLOGIES CO., LTD
//888603, "HUAWEI TECHNOLOGIES CO., LTD
//04F938, "HUAWEI TECHNOLOGIES CO., LTD
//AC853D", "HUAWEI TECHNOLOGIES CO., LTD
//4846FB HUAWEI TECHNOLOGIES CO., LTD
//D0FF50", "Texas Instruments
//20C38F Texas Instruments
//7C669D Texas Instruments
//D8DDFD", "Texas Instruments
//D05FB8 Texas Instruments
//E0247F", "HUAWEI TECHNOLOGIES CO., LTD
//00464B HUAWEI TECHNOLOGIES CO., LTD
//80FB06 HUAWEI TECHNOLOGIES CO., LTD
//6CA849 Avaya Inc
//64C354 Avaya Inc
//50CD22 Avaya Inc
//B4A95A", "Avaya Inc
//84EB18 Texas Instruments
//EC1127", "Texas Instruments
//581626, "Avaya Inc
//70E422, "Cisco Systems, Inc
//00500F, "Cisco Systems, Inc
//7C1DD9 Xiaomi Communications Co Ltd
//A086C6", "Xiaomi Communications Co Ltd
//9C99A0 Xiaomi Communications Co Ltd
//584498, "Xiaomi Communications Co Ltd
//00E0B0 Cisco Systems, Inc
//00E0FE Cisco Systems, Inc
//00E034, "Cisco Systems, Inc
//00E0F9, "Cisco Systems, Inc
//C8D719", "Cisco-Linksys, LLC
//001079, "Cisco Systems, Inc
//001029, "Cisco Systems, Inc
//000E08, "Cisco-Linksys, LLC
//4403A7 Cisco Systems, Inc
//B0FAEB", "Cisco Systems, Inc
//7CAD74 Cisco Systems, Inc
//00603E, "Cisco Systems, Inc
//00602F, "Cisco Systems, Inc
//006047, "Cisco Systems, Inc
//0050A2 Cisco Systems, Inc
//00023D, "Cisco Systems, Inc
//203A07 Cisco Systems, Inc
//00502A Cisco Systems, Inc
//BC16F5", "Cisco Systems, Inc
//FC5B39", "Cisco Systems, Inc
//346F90, "Cisco Systems, Inc
//5CFC66 Cisco Systems, Inc
//D46D50", "Cisco Systems, Inc
//74A02F Cisco Systems, Inc
//88908D, "Cisco Systems, Inc
//F07816", "Cisco Systems, Inc
//00223A Cisco SPVTG
//0021BE Cisco SPVTG
//14DAE9 ASUSTek COMPUTER INC.
//F4CFE2 Cisco Systems, Inc
//A80C0D", "Cisco Systems, Inc
//C07BBC", "Cisco Systems, Inc
//24E9B3 Cisco Systems, Inc
//0011D8, "ASUSTek COMPUTER INC.
//C08C60 Cisco Systems, Inc
//E8EDF3", "Cisco Systems, Inc
//E4C722", "Cisco Systems, Inc
//64E950, "Cisco Systems, Inc
//F41FC2", "Cisco Systems, Inc
//44ADD9 Cisco Systems, Inc
//0C6803 Cisco Systems, Inc
//1CDEA7 Cisco Systems, Inc
//F07F06", "Cisco Systems, Inc
//88F031, "Cisco Systems, Inc
//0018F3, "ASUSTek COMPUTER INC.
//001A92 ASUSTek COMPUTER INC.
//000C41 Cisco-Linksys, LLC
//0016B6 Cisco-Linksys, LLC
//0018F8, "Cisco-Linksys, LLC
//00252E, "Cisco SPVTG
//54D46F, "Cisco SPVTG
//A4A24A Cisco SPVTG
//44E08E Cisco SPVTG
//00E036, "PIONEER CORPORATION
//00E04F, "Cisco Systems, Inc
//0010FF Cisco Systems, Inc
//001054, "Cisco Systems, Inc
//0010F6, "Cisco Systems, Inc
//0010A6 Cisco Systems, Inc
//BCC810", "Cisco SPVTG
//7CB21B Cisco SPVTG
//24767D, "Cisco SPVTG
//481D70, "Cisco SPVTG
//F0B2E5 Cisco Systems, Inc
//002332, "Apple, Inc.
//00236C Apple, Inc.
//0023DF Apple, Inc.
//002500, "Apple, Inc.
//0025BC Apple, Inc.
//5897BD Cisco Systems, Inc
//5C838F Cisco Systems, Inc
//ECBD1D", "Cisco Systems, Inc
//0019E3, "Apple, Inc.
//001B63 Apple, Inc.
//001EC2 Apple, Inc.
//001FF3 Apple, Inc.
//0050E4, "Apple, Inc.
//000D93, "Apple, Inc.
//7CFADF Apple, Inc.
//78A3E4 Apple, Inc.
//148FC6 Apple, Inc.
//286AB8 Apple, Inc.
//28E02C Apple, Inc.
//E0B9BA Apple, Inc.
//00C610 Apple, Inc.
//B8F6B1 Apple, Inc.
//8CFABA Apple, Inc.
//7CD1C3 Apple, Inc.
//F0DCE2 Apple, Inc.
//24AB81 Apple, Inc.
//E0F847 Apple, Inc.
//28E7CF Apple, Inc.
//E4CE8F Apple, Inc.
//A82066 Apple, Inc.
//BC52B7 Apple, Inc.
//5C5948 Apple, Inc.
//C8BCC8 Apple, Inc.
//E8040B Apple, Inc.
//145A05 Apple, Inc.
//1CABA7 Apple, Inc.
//C0847A Apple, Inc.
//34159E, "Apple, Inc.
//58B035 Apple, Inc.
//DC86D8 Apple, Inc.
//90B931 Apple, Inc.
//D0E140 Apple, Inc.
//24A2E1 Apple, Inc.
//04214C Insight Energy Ventures LLC
//F832E4", "ASUSTek COMPUTER INC.
//80EA96 Apple, Inc.
//600308, "Apple, Inc.
//04F13E, "Apple, Inc.
//98F0AB Apple, Inc.
//7831C1 Apple, Inc.
//783A84 Apple, Inc.
//5C8D4E Apple, Inc.
//8863DF Apple, Inc.
//881FA1 Apple, Inc.
//C8E0EB Apple, Inc.
//98B8E3 Apple, Inc.
//885395, "Apple, Inc.
//786C1C Apple, Inc.
//4C8D79 Apple, Inc.
//1CE62B Apple, Inc.
//0C3021 Apple, Inc.
//0C3E9F Apple, Inc.
//FCFC48 Apple, Inc.
//9C293F Apple, Inc.
//80A1AB Intellisis
//84285A Saffron Solutions Inc
//D4B8FF Home Control Singapore Pte Ltd
//087402, "Apple, Inc.
//94F6A3 Apple, Inc.
//98E0D9, "Apple, Inc.
//CC29F5 Apple, Inc.
//285AEB Apple, Inc.
//F02475 Apple, Inc.
//2C1F23 Apple, Inc.
//549F13, "Apple, Inc.
//F0DBE2 Apple, Inc.
//748114, "Apple, Inc.
//18F643, "Apple, Inc.
//A45E60 Apple, Inc.
//A01828 Apple, Inc.
//D0034B Apple, Inc.
//10417F, "Apple, Inc.
//A8667F Apple, Inc.
//D02598 Apple, Inc.
//80BE05 Apple, Inc.
//24A074 Apple, Inc.
//84788B Apple, Inc.
//84A423 Sagemcom Broadband SAS
//3C7873 Airsonics
//9C88AD Fiberhome Telecommunication Technologies Co., LTD
//88947E, "Fiberhome Telecommunication Technologies Co., LTD
//C8A2CE", "Oasis Media Systems LLC
//58F496, "Source Chain
//587F57, "Apple, Inc.
//D07C2D Leie IOT technology Co., Ltd
//EC64E7", "MOCACARE Corporation
//40862E, "JDM MOBILE INTERNET SOLUTION CO., LTD.
//C4BBEA Pakedge Device and Software Inc
//988744, "Wuxi Hongda Science and Technology Co., LTD
//E8343E", "Beijing Infosec Technologies Co., LTD.
//346987, "zte corporation
//98F428, "zte corporation
//A4CC32 Inficomm Co., Ltd
//006D52, "Apple, Inc.
//A03299 Lenovo (Beijing) Co., Ltd.
//4054E4, "Wearsafe Labs Inc
//DC9A8E", "Nanjing Cocomm electronics co., LTD
//ACEE9E", "Samsung Electronics Co., Ltd
//B857D8", "Samsung Electronics Co., Ltd
//70BF3E Charles River Laboratories
//A8C87F Roqos, Inc.
//3C831E CKD Corporation
//90DFFB HOMERIDER SYSTEMS
//305A3A ASUSTek COMPUTER INC.
//2C081C OVH
//C08488 Finis Inc
//38F557, "JOLATA, INC.
//54A3FA BQT Solutions (Australia) Pty Ltd
//246C8A YUKAI Engineering
//ACC51B", "Zhuhai Pantum Electronics Co., Ltd.
//385F66, "Cisco SPVTG
//B844D9 Apple, Inc.
//9C7A03 Ciena Corporation
//5CCF7F Espressif Inc.
//681295, "Lupine Lighting Systems GmbH
//7011AE Music Life LTD
//041E7A DSPWorks
//84A788 Perples
//AC60B6 Ericsson AB
//14B370 Gigaset Digital Technology (Shenzhen) Co., Ltd.
//6889C1 HUAWEI TECHNOLOGIES CO., LTD
//1C497B Gemtek Technology Co., Ltd.
//2CCF58 HUAWEI TECHNOLOGIES CO., LTD
//D09380", "Ducere Technologies Pvt.Ltd.
//68F956, "Objetivos y Servicio de Valor Añadido
//C8A9FC Goyoo Networks Inc.
//FCFEC2 Invensys Controls UK Limited
//689AB7 Atelier Vision Corporation
//444CA8 Arista Networks
//7C2BE1 Shenzhen Ferex Electrical Co., Ltd
//5031AD ABB Global Industries and Services Private Limited
//143EBF zte corporation
//FC2FEF", "UTT Technologies Co., Ltd.
//A4C138 Telink Semiconductor (Taipei) Co. Ltd.
//20F510, "Codex Digital Limited
//A8741D", "PHOENIX CONTACT Electronics GmbH
//F09A51 Shanghai Viroyal Electronic Technology Company Limited
//4CB82C Cambridge Mobile Telematics, Inc.
//E4A32F Shanghai Artimen Technology Co., Ltd.
//F4672D ShenZhen Topstar Technology Company
//A8D828", "Ascensia Diabetes Care
//B869C2", "Sunitec Enterprise Co., Ltd.
//88CBA5 Suzhou Torchstar Intelligent Technology Co., Ltd
//7CA23E HUAWEI TECHNOLOGIES CO., LTD
//501AA5 GN Netcom A/S
//A48D3B", "Vizio, Inc
//1C56FE Motorola Mobility LLC, a Lenovo Company
//B899B0", "Cohere Technologies
//D85DEF Busch-Jaeger Elektro GmbH
//88A2D7 HUAWEI TECHNOLOGIES CO., LTD
//00323A so-logic
//809FAB Fiberhome Telecommunication Technologies Co., LTD
//E00370", "ShenZhen Continental Wireless Technology Co., Ltd.
//046169, "MEDIA GLOBAL LINKS CO., LTD.
//BCEB5F Fujian Beifeng Telecom Technology Co., Ltd.
//AC5A14 Samsung Electronics Co., Ltd
//F0AB54", "MITSUMI ELECTRIC CO., LTD.
//3C3178 Qolsys Inc.
//08ECA9 Samsung Electronics Co., Ltd
//E04B45", "Hi-P Electronics Pte Ltd
//F46A92 SHENZHEN FAST TECHNOLOGIES CO., LTD
//F0D657", "ECHOSENS
//9C37F4 HUAWEI TECHNOLOGIES CO., LTD
//3C4711 HUAWEI TECHNOLOGIES CO., LTD
//5CEB68 Cheerstar Technology Co., Ltd
//AC562C", "LAVA INTERNATIONAL(H.K) LIMITED
//FC9AFA Motus Global Inc.
//14157C TOKYO COSMOS ELECTRIC CO., LTD.
//20E407, "Spark srl
//D09DAB TCT mobile ltd
//887384, "Toshiba
//24693E, "innodisk Corporation
//C0DC6A Qingdao Eastsoft Communication Technology Co., LTD
//24B0A9 Shanghai Mobiletek Communication Ltd.
//1CC586 Absolute Acoustics
//407FE0 Glory Star Technics (ShenZhen) Limited
//C8E130 Milkyway Group Ltd
//486EFB Davit System Technology Co., Ltd.
//B0966C Lanbowan Technology Ltd.
//1CF03E Wearhaus Inc.
//C43ABE Sony Mobile Communications Inc
//883B8B Cheering Connection Co. Ltd.
//E4F939 Minxon Hotel Technology INC.
//146B72 Shenzhen Fortune Ship Technology Co., Ltd.
//B8F080 SPS, INC.
//805067, "W & D TECHNOLOGY CORPORATION
//78F944, "Private
//247656, "Shanghai Net Miles Fiber Optics Technology Co., LTD.
//F8CFC5 Motorola Mobility LLC, a Lenovo Company
//A47B85", "ULTIMEDIA Co Ltd,
//5C5B35 Mist Systems, Inc.
//ECBAFE GIROPTIC
//3C2C94 杭州德澜科技有限公司（HangZhou Delan Technology Co., Ltd）
//241B44 Hangzhou Tuners Electronics Co., Ltd
//80A85D Osterhout Design Group
//ACCAAB Virtual Electric Inc
//485415, "NET RULES TECNOLOGIA EIRELI
//7840E4, "Samsung Electronics Co., Ltd
//E09971", "Samsung Electronics Co., Ltd
//70DA9C TECSEN
//2CA2B4 Fortify Technologies, LLC
//10D38A Samsung Electronics Co., Ltd
//E48501", "Geberit International AG
//206274, "Microsoft Corporation
//E8162B IDEO Security Co., Ltd.
//B47356 Hangzhou Treebear Networking Co., Ltd.
//346895, "Hon Hai Precision Ind. Co., Ltd.
//847303, "Letv Mobile and Intelligent Information Technology (Beijing) Corporation Ltd.
//3CC2E1 XINHUA CONTROL ENGINEERING CO., LTD
//8C873B Leica Camera AG
//44F477, "Juniper Networks
//142971, "NEMOA ELECTRONICS (HK) CO. LTD
//78E980, "RainUs Co., Ltd
//E0FFF7", "Softiron Inc.
//3C6A9D Dexatek Technology LTD.
//349E34, "Evervictory Electronic Co.Ltd
//700FC7 SHENZHEN IKINLOOP TECHNOLOGY CO., LTD.
//BC74D7 HangZhou JuRu Technology CO., LTD
//78EB14 SHENZHEN FAST TECHNOLOGIES CO., LTD
//3C4937 ASSMANN Electronic GmbH
//844464, "ServerU Inc
//003560, "Rosen Aviation
//F8BC41 Rosslare Enterprises Limited
//3CB792 Hitachi Maxell, Ltd., Optronics Division
//F8B2F3 GUANGZHOU BOSMA TECHNOLOGY CO., LTD
//28D98A Hangzhou Konke Technology Co., Ltd.
//D89341 General Electric Global Research
//1C9ECB Beijing Nari Smartchip Microelectronics Company Limited
//D48DD9", "Meld Technology, Inc
//DCC622", "BUHEUNG SYSTEM
//902CC7 C-MAX Asia Limited
//8870EF, "SC Professional Trading Co., Ltd.
//94C038 Tallac Networks
//6836B5 DriveScale, Inc.
//C40880 Shenzhen UTEPO Tech Co., Ltd.
//D88039 Microchip Technology Inc.
//5C966A RTNET
//BCBC46 SKS Welding Systems GmbH
//9816EC IC Intracom
//D062A0", "China Essence Technology (Zhumadian) Co., Ltd.
//90179B Nanomegas
//14F893, "Wuhan FiberHome Digital Technology Co., Ltd.
//582136, "KMB systems, s.r.o.
//800902, "Keysight Technologies, Inc.
//0499E6, "Shenzhen Yoostar Technology Co., Ltd
//70FF5C Cheerzing Communication(Xiamen) Technology Co., Ltd
//4C48DA Beijing Autelan Technology Co., Ltd
//205CFA Yangzhou ChangLian Network Technology Co, ltd.
//84930C InCoax Networks Europe AB
//1CA2B1 ruwido austria gmbh
//384B76 AIRTAME ApS
//38B1DB Hon Hai Precision Ind.Co., Ltd.
//34F6D2, "Panasonic Taiwan Co., Ltd.
//307512, "Sony Mobile Communications Inc
//64002D, "Powerlinq Co., LTD
//B47C29", "Shenzhen Guzidi Technology Co., Ltd
//D48F33", "Microsoft Corporation
//54F876, "ABB AG
//34B7FD Guangzhou Younghead Electronic Technology Co., Ltd
//B41780", "DTI Group Ltd
//489D18, "Flashbay Limited
//90203A BYD Precision Manufacture Co., Ltd
//80EACA Dialog Semiconductor Hellas SA
//20A99B Microsoft Corporation
//604826, "Newbridge Technologies Int.Ltd.
//38F33F, "TATSUNO CORPORATION
//D80CCF C.G.V.S.A.S.
//4CBB58 Chicony Electronics Co., Ltd.
//A41242 NEC Platforms, Ltd.
//D00AAB Yokogawa Digital Computer Corporation
//C40006", "Lipi Data Systems Ltd.
//38262B UTran Technology
//480C49 NAKAYO Inc
//3CD9CE Eclipse WiFi
//6077E2, "Samsung Electronics Co., Ltd
//FC1910", "Samsung Electronics Co., Ltd
//FC790B", "Hitachi High Technologies America, Inc.
//6081F9, "Helium Systems, Inc
//8401A7 Greyware Automation Products, Inc
//98F170, "Murata Manufacturing Co., Ltd.
//686E48, "Prophet Electronic Technology Corp., Ltd
//04C991 Phistek INC.
//3CA10D Samsung Electronics Co., Ltd
//646CB2 Samsung Electronics Co., Ltd
//680571, "Samsung Electronics Co., Ltd
//14B484 Samsung Electronics Co., Ltd
//F4C447", "Coagent International Enterprise Limited
//C8E42F Technical Research Design and Development
//C4C9EC Gugaoo", " HK Limited
//34E42A Automatic Bar Controls Inc.
//3059B7 Microsoft
//20A787 Bointec Taiwan Corporation Limited
//A0FC6E", "Telegrafia a.s.
//2053CA Risk Technology Ltd
//A43D78 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//04572F, "Sertel Electronics UK Ltd
//D8977C Grey Innovation
//BC8D0E", "Nokia
//A49F85", "Lyve Minds, Inc
//78923E, "Nokia Corporation
//ACA9A0 Audioengine, Ltd.
//A481EE Nokia Corporation
//78D66F, "Aristocrat Technologies Australia Pty. Ltd.
//441E91, "ARVIDA Intelligent Electronics Technology", "Co., Ltd.
//C4626B ZPT Vigantice
//EC1766", "Research Centre Module
//A0D12A", "AXPRO Technology Inc.
//209AE9 Volacomm Co., Ltd
//345D10, "Wytek
//6C14F7 Erhardt+Leimer GmbH
//B0D59D Shenzhen Zowee Technology Co., Ltd
//6828BA Dejai
//B05706 Vallox Oy
//48EE07 Silver Palm Technologies LLC
//50C7BF TP-LINK TECHNOLOGIES CO., LTD.
//205A00 Coval
//A8A668 zte corporation
//00EEBD HTC Corporation
//38F708, "National Resource Management, Inc.
//E0DB88 Open Standard Digital-IF Interface for SATCOM Systems
//A8BD3A UNIONMAN TECHNOLOGY CO., LTD
//A824EB", "ZAO NPO Introtest
//C40E45", "ACK Networks, Inc.
//3C89A6 KAPELSE
//A46CC1 LTi REEnergy GmbH
//A8B9B3 ESSYS
//6C09D6 Digiquest Electronics LTD
//481842, "Shanghai Winaas Co.Equipment Co. Ltd.
//447098, "MING HONG TECHNOLOGY (SHEN ZHEN) LIMITED
//9CBD9D SkyDisk, Inc.
//74C621 Zhejiang Hite Renewable Energy Co., LTD
//D4319D", "Sinwatec
//B068B6", "Hangzhou OYE Technology Co. Ltd
//9C65F9 AcSiP Technology Corp.
//487604, "Private
//2C534A Shenzhen Winyao Electronic Limited
//A4BBAF", "Lime Instruments
//F490CA Tensorcom
//E44C6C Shenzhen Guo Wei Electronic Co,. Ltd.
//A8574E TP-LINK TECHNOLOGIES CO., LTD.
//B843E4 Vlatacom
//282246, "Beijing Sinoix Communication Co., LTD
//48B977 PulseOn Oy
//7071B3 Brain Corporation
//64E625, "Woxu Wireless Co., Ltd
//10B713 Private
//100E7E Juniper Networks
//208986, "zte corporation
//44C56F NGN Easy Satfinder (Tianjin) Electronic Co., Ltd
//B898F7", "Gionee Communication Equipment Co, Ltd.ShenZhen
//848336, "Newrun
//182012, "Aztech Associates Inc.
//B8266C ANOV France
//3C300C Dewar Electronics Pty Ltd
//98FFD0 Lenovo Mobile Communication Technology Ltd.
//A875E2 Aventura Technologies, Inc.
//B87AC9 Siemens Ltd.
//F06130 Advantage Pharmacy Services, LLC
//6C3C53 SoundHawk Corp
//084027, "Gridstore Inc.
//38BF2F Espec Corp.
//44C4A9 Opticom Communication, LLC
//C4824E", "Changzhou Uchip Electronics Co., LTD.
//A47760 Nokia Corporation
//C85663", "Sunflex Europe GmbH
//88FED6 ShangHai WangYong Software Co., Ltd.
//7C72E4 Unikey Technologies
//7C2048 KoamTac
//8CB7F7 Shenzhen UniStrong Science & Technology Co., Ltd
//38B74D Fijowave Limited
//180C14 iSonea Limited
//9CA9E4 zte corporation
//90F3B7 Kirisun Communications Co., Ltd.
//C4E92F AB Sciex
//A88D7B", "SunDroid Global limited.
//3CF748 Shenzhen Linsn Technology Development Co., Ltd
//B07908", "Cummings Engineering
//E47723 zte corporation
//1C63B7 OpenProducts 237 AB
//B4527E", "Sony Mobile Communications Inc
//94B9B4 Aptos Technology
//6C15F9 Nautronix Limited
//18AA45 Fon Technology
//902083, "General Engine Management Systems Ltd.
//14B126 Industrial Software Co
//D850E6 ASUSTek COMPUTER INC.
//DC3EF8 Nokia Corporation
//A49F89", "Shanghai Rui Rui Communication Technology Co.Ltd.
//7060DE LaVision GmbH
//502E5C HTC Corporation
//FCFE77", "Hitachi Reftechno, Inc.
//70533F, "Alfa Instrumentos Eletronicos Ltda.
//407A80 Nokia Corporation
//644214, "Swisscom Energy Solutions AG
//0CA694 Sunitec Enterprise Co., Ltd
//184462, "Riava Networks, Inc.
//C03580 A&R TECH
//D08A55 Skullcandy
//344F3F, "IO-Power Technology Co., Ltd.
//146080, "zte corporation
//9CBB98 Shen Zhen RND Electronic Co., LTD
//50C271 SECURETECH INC
//CC720F", "Viscount Systems Inc.
//742B62 FUJITSU LIMITED
//643F5F, "Exablaze
//8C2F39 IBA Dosimetry GmbH
//C0A0BB D-Link International
//2CCD69 Aqavi.com
//F45F69", "Matsufu Electronics distribution Company
//28A1EB ETEK TECHNOLOGY (SHENZHEN) CO., LTD
//B8F828", "Changshu Gaoshida Optoelectronic Technology Co.Ltd.
//3C1A57 Cardiopulmonary Corp
//541B5D Techno-Innov
//9CE7BD Winduskorea co., Ltd
//3842A6 Ingenieurbuero Stahlkopf
//2C553C Gainspeed, Inc.
//248000, "Westcontrol AS
//1C4BB9 SMG ENTERPRISE, LLC
//346178, "The Boeing Company
//1446E4, "AVISTEL
//D095C7", "Pantech Co., Ltd.
//D02C45 littleBits Electronics, Inc.
//044F8B Adapteva, Inc.
//B4A82B Histar Digital Electronics Co., Ltd.
//284D92, "Luminator
//54FB58 WISEWARE, Lda
//940BD5 Himax Technologies, Inc
//E0D1E6", "Aliph dba Jawbone
//D82D9B", "Shenzhen G.Credit Communication Technology Co., Ltd
//709BFC Bryton Inc.
//ACE42E SK hynix
//78FE41 Socus networks
//205721, "Salix Technology CO., Ltd.
//883612, "SRC Computers, LLC
//083571, "CASwell INC.
//9876B6 Adafruit
//503CC4 Lenovo Mobile Communication Technology Ltd.
//2C7B84 OOO Petr Telegin
//A4C0C7 ShenZhen Hitom Communication Technology Co..LTD
//306112, "PAV GmbH
//789F4C HOERBIGER Elektronik GmbH
//18104E, "CEDINT-UPM
//9C1465 Edata Elektronik San. ve Tic. A.Ş.
//4C55CC Zentri Pty Ltd
//00C5DB Datatech Sistemas Digitales Avanzados SL
//8CF945 Power Automation pte Ltd
//F842FB", "Yasuda Joho Co., ltd.
//887398, "K2E Tekpoint
//2C922C Kishu Giken Kogyou Company Ltd,.
//D8FEE3 D-Link International
//58F387, "HCCP
//3C977E IPS Technology Limited
//A4FB8D Hangzhou Dunchong Technology Co.Ltd
//F4CD90", "Vispiron Rotec GmbH
//806C8B KAESER KOMPRESSOREN AG
//043D98, "ChongQing QingJia Electronics CO., LTD
//E03E4A", "Cavanagh Group International
//041B94 Host Mobility AB
//A0CEC8 CE LINK LIMITED
//907A28 Beijing Morncloud Information And Technology Co.Ltd.
//1001CA Ashley Butterworth
//246AAB IT-IS International
//FC4BBC Sunplus Technology Co., Ltd.
//50A0BF Alba Fiber Systems Inc.
//B836D8 Videoswitch
//DC6F00 Livescribe, Inc.
//54E3B0 JVL Industri Elektronik
//804B20 Ventilation Control
//287994, "Realplay Digital Technology(Shenzhen) Co., Ltd
//107A86 U&U ENGINEERING INC.
//40BD9E Physio-Control, Inc
//6C5779 Aclima, Inc.
//C0DA74 Hangzhou Sunyard Technology Co., Ltd.
//18D6CF Kurth Electronic GmbH
//F48139 CANON INC.
//1836FC Elecsys International Corporation
//A4D094 Erwin Peters Systemtechnik GmbH
//882364, "Watchnet DVR Inc
//581CBD Affinegy
//284FCE Liaoning Wontel Science and Technology Development Co., Ltd.
//048D38, "Netcore Technology Inc.
//2C9464 Cincoze Co., Ltd.
//3065EC Wistron (ChongQing)
//542CEA PROTECTRON
//94B8C5 RuggedCom Inc.
//DC825B JANUS, spol.s r.o.
//9CA577 Osorno Enterprises Inc.
//C04301 Epec Oy
//E07C62", "Whistle Labs, Inc.
//F07F0C Leopold Kostal GmbH &Co.KG
//4C6255 SANMINA-SCI SYSTEM DE MEXICO S.A.DE C.V.
//082719, "APS systems/electronic AG
//505AC6 GUANGDONG SUPER TELECOM CO., LTD.
//9C79AC Suntec Software(Shanghai) Co., Ltd.
//4C9614 Juniper Networks
//B863BC", "ROBOTIS, Co, Ltd
//980D2E, "HTC Corporation
//C419EC Qualisys AB
//604A1C SUYIN Corporation
//D464F7", "CHENGDU USEE DIGITAL TECHNOLOGY CO., LTD
//74D02B ASUSTek COMPUTER INC.
//601E02, "EltexAlatau
//E0C6B3", "MilDef AB
//6472D8, "GooWi Technology Co., Limited
//60601F, "SZ DJI TECHNOLOGY CO., LTD
//5C8486 Brightsource Industries Israel LTD
//50CD32 NanJing Chaoran Science & Technology Co., Ltd.
//BCBAE1 AREC Inc.
//18FA6F ISC applied systems corp
//A01C05", "NIMAX TELECOM CO., LTD.
//60E00E SHINSEI ELECTRONICS CO LTD
//545414, "Digital RF Corea, Inc
//24EB65 SAET I.S.S.r.l.
//D0F27F SteadyServ Technoligies, LLC
//E894F6", "TP-LINK TECHNOLOGIES CO., LTD.
//188410, "CoreTrust Inc.
//FC229C Han Kyung I Net Co., Ltd.
//1832A2 LAON TECHNOLOGY CO., LTD.
//D4A499 InView Technology Corporation
//08482C Raycore Taiwan Co., LTD.
//DC2BCA Zera GmbH
//9498A2 Shanghai LISTEN TECH.LTD
//E0EDC7", "Shenzhen Friendcom Technology Development Co., Ltd
//B4DD15", "ControlThings Oy Ab
//DC1DD4", "Microstep-MIS spol. s r.o.
//FCDD55 Shenzhen WeWins wireless Co., Ltd
//B01743", "EDISON GLOBAL CIRCUITS LLC
//D0BE2C CNSLink Co., Ltd.
//40516C Grandex International Corporation
//C0885B SnD Tech Co., Ltd.
//3CFB96 Emcraft Systems LLC
//846223, "Shenzhen Coship Electronics Co., Ltd.
//1CFA68 TP-LINK TECHNOLOGIES CO., LTD.
//081F3F, "WondaLink Inc.
//1853E0, "Hanyang Digitech Co.Ltd
//00C14F DDL Co,.ltd.
//2C26C5 zte corporation
//105F06, "Actiontec Electronics, Inc
//087999, "AIM GmbH
//C011A6 Fort-Telecom ltd.
//C04A00 TP-LINK TECHNOLOGIES CO., LTD.
//045FA7 Shenzhen Yichen Technology Development Co., LTD
//94C962 Teseq AG
//DC2A14", "Shanghai Longjing Technology Co.
//6886E7, "Orbotix, Inc.
//C05E6F V. Stonkaus firma Kodinis Raktas
//C0B8B1 BitBox Ltd
//F82EDB", "RTW GmbH & Co.KG
//808B5C Shenzhen Runhuicheng Technology Co., Ltd
//D819CE", "Telesquare
//E0CEC3", "ASKEY COMPUTER CORP
//38F597, "home2net GmbH
//807B1E Corsair Memory, Inc.
//B4AB2C MtM Technology Corporation
//74372F, "Tongfang Shenzhen Cloudcomputing Technology Co., Ltd
//F0219D", "Cal-Comp Electronics & Communications Company Ltd.
//181725, "Cameo Communications, Inc.
//8462A6 EuroCB (Phils), Inc.
//E4F365 Time-O-Matic, Inc.
//DCC0DB Shenzhen Kaiboer Technology Co., Ltd.
//AC5D10 Pace Americas
//FC626E", "Beijing MDC Telecom
//84C8B1 Incognito Software Systems Inc.
//E8A364 Signal Path International / Peachtree Audio
//BC51FE Swann communications Pty Ltd
//88F490, "Jetmobile Pte Ltd
//1C9179 Integrated System Technologies Ltd
//A0BAB8", "Pixon Imaging
//74E424, "APISTE CORPORATION
//2411D0, "Chongqing Ehs Science and Technology Development Co., Ltd.
//B461FF Lumigon A/S
//A0A130", "DLI Taiwan Branch office
//30215B Shenzhen Ostar Display Electronic Co., Ltd
//34FA40 Guangzhou Robustel Technologies Co., Limited
//1C5A6B Philips Electronics Nederland BV
//A875D6", "FreeTek International Co., Ltd.
//ECE915 STI Ltd
//80D733, "QSR Automations, Inc.
//303D08, "GLINTT TES S.A.
//A81FAF KRYPTON POLSKA
//30D357, "Logosol, Inc.
//BC39A6 CSUN System Technology Co., LTD
//ECB541", "SHINANO E and E Co.Ltd.
//D410CF Huanshun Network Science and Technology Co., Ltd.
//6CB311 Shenzhen Lianrui Electronics Co., Ltd
//10A743 SK Mtek Limited
//547FA8 TELCO systems, s.r.o.
//5474E6, "Webtech Wireless
//C46DF1 DataGravity
//304449, "PLATH GmbH
//94FD2E Shanghai Uniscope Technologies Co., Ltd
//E4C146", "Objetivos y Servicios de Valor A
//D40057 MC Technologies GmbH
//5CE0F6 NIC.br- Nucleo de Informacao e Coordenacao do Ponto BR
//C83D97 Nokia Corporation
//0CF361 Java Information
//600F77, "SilverPlus, Inc
//B0358D", "Nokia Corporation
//F8E4FB Actiontec Electronics, Inc
//8C4AEE GIGA TMS INC
//34C99D EIDOLON COMMUNICATIONS TECHNOLOGY CO.LTD.
//ACE64B Shenzhen Baojia Battery Technology Co., Ltd.
//789F87, "Siemens AG I IA PP PRM
//08E5DA NANJING FUJITSU COMPUTER PRODUCTS CO., LTD.
//5884E4, "IP500 Alliance e.V.
//044BFF GuangZhou Hedy Digital Technology Co., Ltd
//E8718D", "Elsys Equipamentos Eletronicos Ltda
//D0738E DONG OH PRECISION CO., LTD.
//64C944 LARK Technologies, Inc
//0C93FB BNS Solutions
//E44F5F", "EDS Elektronik Destek San.Tic.Ltd.Sti
//E86D54", "Digit Mobile Inc
//90B11C Dell Inc.
//005D03, "Xilinx, Inc
//802FDE Zurich Instruments AG
//5C38E0 Shanghai Super Electronics Technology Co., LTD
//08AF78 Totus Solutions, Inc.
//C8C791 Zero1.tv GmbH
//ECD925 RAMI
//1C9492 RUAG Schweiz AG
//B889CA ILJIN ELECTRIC Co., Ltd.
//64F50E, "Kinion Technology Company Limited
//D04CC1 SINTRONES Technology Corp.
//503F56, "Syncmold Enterprise Corp
//8CEEC6 Precepscion Pty.Ltd.
//101248, "ITG, Inc.
//1848D8, "Fastback Networks
//F0D3E7 Sensometrix SA
//B01266", "Futaba-Kikaku
//7CC8D0 TIANJIN YAAN TECHNOLOGY CO., LTD.
//88E917, "Tamaggo
//88615A Siano Mobile Silicon Ltd.
//70E24C SAE IT-systems GmbH & Co.KG
//00FD4C NEVATEC
//144319, "Creative&Link Technology Limited
//D8AF3B", "Hangzhou Bigbright Integrated communications system Co., Ltd
//6032F0, "Mplus technology
//2829D9, "GlobalBeiMing technology (Beijing) Co. Ltd
//1CC316 MileSight Technology Co., Ltd.
//6815D3, "Zaklady Elektroniki i Mechaniki Precyzyjnej R&G S.A.
//10F3DB Gridco Systems, Inc.
//305D38, "Beissbarth
//60D2B9 REALAND BIO CO., LTD.
//30FD11 MACROTECH (USA) INC.
//C4DA26 NOBLEX SA
//7CC8AB Acro Associates, Inc.
//601929, "VOLTRONIC POWER TECHNOLOGY(SHENZHEN) CORP.
//48B253 Marketaxess Corporation
//74943D, "AgJunction
//58CF4B Lufkin Industries
//68B43A WaterFurnace International, Inc.
//4C7897 Arrowhead Alarm Products Ltd
//44E8A5 Myreka Technologies Sdn. Bhd.
//D8AFF1 Panasonic Appliances Company
//2C6289 Regenersis (Glenrothes) Ltd
//58ECE1 Newport Corporation
//4C09B4 zte corporation
//60D1AA Vishal Telecommunications Pvt Ltd
//709BA5 Shenzhen Y&D Electronics Co., LTD.
//F45433 Rockwell Automation
//B48910", "Coster T.E.S.P.A.
//B0C83F Jiangsu Cynray IOT Co., Ltd.
//3CF392 Virtualtek. Co.Ltd
//B482C5", "Relay2, Inc.
//985E1B ConversDigital Co., Ltd.
//D48CB5 Cisco Systems, Inc
//909DE0 Newland Design + Assoc.Inc.
//149FE8 Lenovo Mobile Communication Technology Ltd.
//BCD940 ASR Co,.Ltd.
//049C62 BMT Medical Technology s.r.o.
//0C2A69 electric imp, incorporated
//C455C2", "Bach-Simpson
//00E8AB Meggitt Training Systems, Inc.
//B4218A Dog Hunter LLC
//B4A4B5 Zen Eye Co., Ltd
//DC37D2", "Hunan HKT Electronic Technology Co., Ltd
//407074, "Life Technology (China) Co., Ltd
//20F002, "MTData Developments Pty.Ltd.
//388AB7 ITC Networks
//BCC23A", "Thomson Video Networks
//1CF4CA Private
//ACC2EC CLT INT'L IND. CORP.
//A865B2 DONGGUAN YISHANG ELECTRONIC TECHNOLOGY CO., LIMITED
//E8D0FA", "MKS Instruments Deutschland GmbH
//98262A Applied Research Associates, Inc
//3C9174 ALONG COMMUNICATION TECHNOLOGY
//ACEE3B", "6harmonics Inc
//1C6BCA Mitsunami Co., Ltd.
//642400, "Xorcom Ltd.
//E83EFB GEODESIC LTD.
//ECD19A Zhuhai Liming Industries Co., Ltd
//348137, "UNICARD SA
//38B12D Sonotronic Nagel GmbH
//549D85, "EnerAccess inc
//B0750C QA Cafe
//B4E1EB", "Private
//3C363D Nokia Corporation
//808698, "Netronics Technologies Inc.
//9CE10E NCTech Ltd
//A06D09", "Intelcan Technosystems Inc.
//60F3DA Logic Way GmbH
//FC5090 SIMEX Sp.z o.o.
//60B982 RO.VE.R.Laboratories S.p.A.
//B46238 Exablox
//C8BBD3 Embrane
//8C604F Cisco Systems, Inc
//A4B980", "Parking BOXX Inc.
//A47C14 ChargeStorm AB
//30B216 ABB AG - Power Grids - Grid Automation
//8020AF Trade FIDES, a.s.
//2C750F Shanghai Dongzhou-Lawton Communication Technology Co. Ltd.
//5C5015 Cisco Systems, Inc
//980284, "Theobroma Systems GmbH
//1CD40C Kriwan Industrie-Elektronik GmbH
//002D76, "TITECH GmbH
//F8DB4C PNY Technologies, INC.
//0C9D56 Consort Controls Ltd
//3CB87A Private
//AC1461 ATAW", "Co., Ltd.
//E4C6E6 Mophie, LLC
//502D1D, "Nokia Corporation
//F48E09 Nokia Corporation
//5848C0 COFLEC
//8C57FD LVX Western
//54E63F, "ShenZhen LingKeWeiEr Technology Co., Ltd.
//20FABB Cambridge Executive Limited
//141A51 Treetech Sistemas Digitais
//587FC8 S2M
//200505, "RADMAX COMMUNICATION PRIVATE LIMITED
//C035BD Velocytech Aps
//287184, "Spire Payments
//7CB03E OSRAM GmbH
//3C9F81 Shenzhen CATIC Bit Communications Technology Co., Ltd
//445F7A Shihlin Electric & Engineering Corp.
//088F2C Hills Sound Vision & Lighting
//441319, "WKK TECHNOLOGY LTD.
//18B591 I-Storm
//BC8B55", "NPP ELIKS America Inc. DBA T&M Atlantic
//C0493D MAITRISE TECHNOLOGIQUE
//C84544", "Asia Pacific CIS (Wuxi) Co, Ltd
//E0EF25", "Lintes Technology Co., Ltd.
//50ED94, "EGATEL SL
//48A22D Shenzhen Huaxuchang Telecom Technology Co., Ltd
//C86000", "ASUSTek COMPUTER INC.
//AC0DFE Ekon GmbH - myGEKKO
//FC5B26", "MikroBits
//40F407, "Nintendo Co., Ltd.
//B01C91 Elim Co
//04F17D, "Tarana Wireless
//844915, "vArmour Networks, Inc.
//2CBE97 Ingenieurbuero Bickele und Buehler GmbH
//70A66A Prox Dynamics AS
//DC3E51 Solberg & Andersen AS
//900A3A PSG Plastic Service GmbH
//28CD1C Espotel Oy
//D443A8", "Changzhou Haojie Electric Co., Ltd.
//BCE59F WATERWORLD Technology Co., LTD
//7041B7 Edwards Lifesciences LLC
//DCA8CF New Spin Golf, LLC.
//A849A5 Lisantech Co., Ltd.
//A05E6B MELPER Co., Ltd.
//D878E5 KUHN SA
//D824BD", "Cisco Systems, Inc
//3497FB ADVANCED RF TECHNOLOGIES INC
//F03A55", "Omega Elektronik AS
//98BC57 SVA TECHNOLOGIES CO.LTD
//DC3C2E", "Manufacturing System Insights, Inc.
//F83553 Magenta Research Ltd.
//F4044C ValenceTech Limited
//C467B5", "Libratone A/S
//4C3910 Newtek Electronics co., Ltd.
//903AA0 Nokia
//B06CBF", "3ality Digital Systems GmbH
//54D0ED, "AXIM Communications
//843611, "hyungseul publishing networks
//3440B5 IBM
//D4D748 Cisco Systems, Inc
//344F69, "EKINOPS SAS
//F8313E endeavour GmbH
//143605, "Nokia Corporation
//C81AFE DLOGIC GmbH
//EC63E5", "ePBoard Design LLC
//94DB49 SITCORP
//F0620D Shenzhen Egreat Tech Corp., Ltd
//2C67FB ShenZhen Zhengjili Electronics Co., LTD
//3CE5B4 KIDASEN INDUSTRIA E COMERCIO DE ANTENAS LTDA
//08D09F, "Cisco Systems, Inc
//644BF0 CalDigit, Inc
//64ED62, "WOORI SYSTEMS Co., Ltd
//2C002C UNOWHY
//5CC9D3 PALLADIUM ENERGY ELETRONICA DA AMAZONIA LTDA
//C87CBC", "Valink Co., Ltd.
//B81413 Keen High Holding(HK) Ltd.
//B4944E WeTelecom Co., Ltd.
//E00B28 Inovonics
//48022A B-Link Electronic Limited
//18E80F, "Viking Electronics Inc.
//CC6BF1 Sound Masking Inc.
//2C9717 I.C.Y.B.V.
//2C3F38 Cisco Systems, Inc
//4050E0, "Milton Security Group LLC
//70CA9B Cisco Systems, Inc
//A078BA", "Pantech Co., Ltd.
//68BC0C Cisco Systems, Inc
//345B11 EVI HEAT AB
//78BAD0 Shinybow Technology Co. Ltd.
//24E6BA JSC Zavod im. Kozitsky
//CCA374", "Guangdong Guanglian Electronic Technology Co.Ltd
//58677F, "Clare Controls Inc.
//0C5A19 Axtion Sdn Bhd
//A8BD1A Honey Bee (Hong Kong) Limited
//248707, "SEnergy Corporation
//C4C19F National Oilwell Varco Instrumentation, Monitoring, and Optimization (NOV IMO)
//000830, "Cisco Systems, Inc
//C4EEAE", "VSS Monitoring
//F8D3A9 AXAN Networks
//BC779F", "SBM Co., Ltd.
//406AAB RIM
//9CA3BA SAKURA Internet Inc.
//8C8A6E ESTUN AUTOMATION TECHNOLOY CO., LTD
//988217, "Disruptive Ltd
//9C5C8D FIREMAX INDÚSTRIA E COMÉRCIO DE PRODUTOS ELETRÔNICOS", "LTDA
//D4206D", "HTC Corporation
//7C1E52 Microsoft
//DCB4C4 Microsoft XCG
//ACCB09", "Hefcom Metering (Pty) Ltd
//1866E3, "Veros Systems, Inc.
//74FDA0 Compupal (Group) Corporation
//CCB8F1 EAGLE KINGDOM TECHNOLOGIES LIMITED
//A429B7", "bluesky
//48F317, "Private
//CCF8F0", "Xi'an HISU Multimedia Technology Co.,Ltd.
//04888C Eifelwerk Butler Systeme GmbH
//D45AB2", "Galleon Systems
//30DE86 Cedac Software S.r.l.
//18C451 Tucson Embedded Systems
//704642, "CHYNG HONG ELECTRONIC CO., LTD.
//D41C1C RCF S.P.A.
//58920D, "Kinetic Avionics Limited
//AC02EF", "Comsis
//B8B42E", "Gionee Communication Equipment Co, Ltd.ShenZhen
//443EB2 DEOTRON Co., LTD.
//D059C3 CeraMicro Technology Corporation
//182C91 Concept Development, Inc.
//FC1794 InterCreative Co., Ltd
//B40B7A", "Brusa Elektronik AG
//280CB8 Mikrosay Yazilim ve Elektronik A.S.
//3CC99E Huiyang Technology Co., Ltd
//2C1EEA AERODEV
//1C8E8E DB Communication & Systems Co., ltd.
//24EC99 ASKEY COMPUTER CORP
//A44B15 Sun Cupid Technology (HK) LTD
//48C862 Simo Wireless, Inc.
//78BEB6 Enhanced Vision
//449CB5 Alcomp, Inc
//B4FC75", "SEMA Electronics(HK) CO., LTD
//B0BF99", "WIZITDONGDO
//B82ADC", "EFR Europäische Funk-Rundsteuerung GmbH
//40F14C ISE Europe SPRL
//E8944C Cogent Healthcare Systems Ltd
//9067F3, "Alcatel Lucent
//D4F0B4 Napco Security Technologies
//68F895, "Redflow Limited
//70B921 Fiberhome Telecommunication Technologies Co., LTD
//A0E295", "DAT System Co., Ltd
//A0165C", "Triteka LTD
//9C417C Hame", "Technology Co., Limited
//9C6ABE QEES ApS.
//9C934E Xerox Corporation
//044665, "Murata Manufacturing Co., Ltd.
//2C2172 Juniper Networks
//900917, "Far-sighted mobile
//2C8BF2 Hitachi Metals America Ltd
//D8973B", "Artesyn Embedded Technologies
//3826CD ANDTEK
//88BFD5 Simple Audio Ltd
//24CBE7 MYK, Inc.
//B0A10A Pivotal Systems Corporation
//802DE1 Solarbridge Technologies
//F4A52A", "Hawa Technologies Inc
//0C6E4F PrimeVOLT Co., Ltd.
//E8B748 Cisco Systems, Inc
//BC99BC", "FonSee Technology Inc.
//783F15, "EasySYNC Ltd.
//18D071, "DASAN CO., LTD.
//58E476, "CENTRON COMMUNICATIONS TECHNOLOGIES FUJIAN CO., LTD
//447E95, "Alpha and Omega, Inc
//986022, "EMW Co., Ltd.
//B8D49D M Seven System Ltd.
//3C672C Sciovid Inc.
//DC9B1E Intercom, Inc.
//BC5FF4 ASRock Incorporation
//E8B4AE", "Shenzhen C&D Electronics Co., Ltd
//50FAAB L-tek d.o.o.
//3891FB Xenox Holding BV
//A8E018 Nokia Corporation
//781DFD Jabil Inc
//18AEBB Siemens Convergence Creators GmbH&Co.KG
//B0BDA1", "ZAKLAD ELEKTRONICZNY SIMS
//70B265 Hiltron s.r.l.
//CCC62B Tri-Systems Corporation
//D8C068 Netgenetech.co., ltd.
//601199, "Siama Systems Inc
//6C81FE Mitsuba Corporation
//C027B9", "Beijing National Railway Research & Design Institute", "of Signal & Communication Co., Ltd.
//147411, "RIM
//F8A9DE", "PUISSANCE PLUS
//A88CEE MicroMade Galka i Drozdz sp.j.
//DC2B66 InfoBLOCK S.A.de C.V.
//B8871E Good Mind Industries Co., Ltd.
//D4F027 Trust Power Ltd.
//0455CA BriView (Xiamen) Corp.
//1435B3 Future Designs, Inc.
//AC932F Nokia Corporation
//0054AF Continental Automotive Systems Inc.
//ACCABA Midokura Co., Ltd.
//0C8112 Private
//9C95F8 SmartDoor Systems, LLC
//7819F7, "Juniper Networks
//64094C Beijing Superbee Wireless Technology Co., Ltd
//7C7D41 Jinmuyu Electronics Co., Ltd.
//4C1480 NOREGON SYSTEMS, INC
//A4856B", "Q Electronics Ltd
//20D5AB Korea Infocom Co., Ltd.
//0CF3EE EM Microelectronic
//64D1A3 Sitecom Europe BV
//F43E9D Benu Networks, Inc.
//04E2F8, "AEP Ticketing solutions srl
//EC9ECD Artesyn Embedded Technologies
//8C5105 Shenzhen ireadygo Information Technology CO., LTD.
//C8208E Storagedata
//5C5EAB Juniper Networks
//9C807D SYSCABLE Korea Inc.
//28E297, "Shanghai InfoTM Microelectronics Co., Ltd.
//34B571 PLDS
//3C7437 RIM
//EC9233 Eddyfi NDT Inc
//743889, "ANNAX Anzeigesysteme GmbH
//44D2CA Anvia TV Oy
//386E21, "Wasion Group Ltd.
//2872F0, "ATHENA
//1C19DE eyevis GmbH
//609E64, "Vivonic GmbH
//BC15A6 Taiwan Jantek Electronics, Ltd.
//DCDECA Akyllor
//A0AAFD EraThink Technologies Corp.
//6CA906 Telefield Ltd
//78223D, "Affirmed Networks
//3C02B1 Creation Technologies LP
//E441E6 Ottec Technology GmbH
//BC71C1 XTrillion, Inc.
//E0E8E8 Olive Telecommunication Pvt. Ltd
//6052D0, "FACTS Engineering
//B08991 LGE
//30142D, "Piciorgros GmbH
//50AF73 Shenzhen Bitland Information Technology Co., Ltd.
//5C9AD8 FUJITSU LIMITED
//A4C0E1", "Nintendo Co., Ltd.
//4C3B74 VOGTEC(H.K.) Co., Ltd
//684352, "Bhuu Limited
//ECE90B SISTEMA SOLUCOES ELETRONICAS LTDA - EASYTECH
//A08C9B", "Xtreme Technologies Corp
//A83944", "Actiontec Electronics, Inc
//74E06E Ergophone GmbH
//0CF0B4 Globalsat International Technology Ltd
//48DF1C Wuhan NEC Fibre Optic Communications industry Co. Ltd
//D49C8E", "University of FUKUI
//F8F014", "RackWare Inc.
//2826A6 PBR electronics GmbH
//B428F1 E-Prime Co., Ltd.
//C01242 Alpha Security Products
//BC20BA Inspur (Shandong) Electronic Information Co., Ltd
//1CFEA7 IDentytech Solutins Ltd.
//304EC3 Tianjin Techua Technology Co., Ltd.
//B4CFDB Shenzhen Jiuzhou Electric Co., LTD
//FCD4F2", "The Coca Cola Company
//5C6A7D KENTKART EGE ELEKTRONIK SAN.VE TIC. LTD.STI.
//44599F, "Criticare Systems, Inc
//3C2F3A SFORZATO Corp.
//74CE56 Packet Force Technology Limited Company
//AC2FA8 Humannix Co., Ltd.
//1064E2, "ADFweb.com s.r.l.
//CC34D7 GEWISS S.P.A.
//F02A61 Waldo Networks, Inc.
//C8A70A Verizon Business
//60DA23 Estech Co., Ltd
//44DCCB SEMINDIA SYSTEMS PVT LTD
//A0DE05", "JSC Irbis-T
//0817F4, "IBM Corp
//CCD811 Aiconn Technology Corporation
//F43814 Shanghai Howell Electronic Co., Ltd
//90610C Fida International (S) Pte Ltd
//3C5F01 Synerchip Co., Ltd.
//ECBBAE Digivoice Tecnologia em Eletronica Ltda
//34A183 AWare, Inc
//9873C4 Sage Electronic Engineering LLC
//B40142", "GCI Science & Technology Co., LTD
//740ABC LightwaveRF Technology Ltd
//10A13B FUJIKURA RUBBER LTD.
//F4E142 Delta Elektronika BV
//AC8112 Gemtek Technology Co., Ltd.
//686359, "Advanced Digital Broadcast SA
//28061E, "NINGBO GLOBAL USEFUL ELECTRIC CO., LTD
//64E8E6 global moisture management system
//E0D10A", "Katoudenkikougyousyo co ltd
//C44B44", "Omniprint Inc.
//18922C Virtual Instruments
//A49B13", "Digital Check
//C8EE08 TANGTOP TECHNOLOGY CO., LTD
//7472F2, "Chipsip Technology Co., Ltd.
//48C8B6 SysTec GmbH
//3C6278 SHENZHEN JETNET TECHNOLOGY CO., LTD.
//C8D5FE Shenzhen Zowee Technology Co., Ltd
//2C3068 Pantech Co., Ltd
//00BD27 Exar Corp.
//5C4058 Jefferson Audio Video Systems, Inc.
//58D08F, "IEEE 1904.1 Working Group
//6C9CE9 Nimble Storage
//CC09C8", "IMAQLIQ LTD
//9C4563 DIMEP Sistemas
//D43D67", "Carma Industries Inc.
//E0A670 Nokia Corporation
//58DB8D Fast Co., Ltd.
//E446BD C&C TECHNIC TAIWAN CO., LTD.
//8CDD8D Wifly-City System Inc.
//20A2E7 Lee-Dickens Ltd
//FCEDB9 Arrayent
//44ED57, "Longicorn, inc.
//EC98C1 Beijing Risbo Network Technology Co., Ltd
//38A95F Actifio Inc
//F4DCDA", "Zhuhai Jiahe Communication Technology Co., limited
//E80462", "Cisco Systems, Inc
//DCD0F7", "Bentek Systems Ltd.
//D4A928 GreenWave Reality Inc
//E06290 Jinan Jovision Science & Technology Co., Ltd.
//100E2B NEC CASIO Mobile Communications
//70E139, "3view Ltd
//18422F, "Alcatel Lucent
//C46354 U-Raku, Inc.
//405FBE RIM
//6854F5, "enLighted Inc
//7CB542 ACES Technology
//905446, "TES ELECTRONIC SOLUTIONS
//544A05 wenglor sensoric gmbh
//98E165, "Accutome
//785712, "Mobile Integration Workgroup
//380A0A Sky-City Communication and Electronics Limited Company
//0CD696 Amimon Ltd
//F4DC4D", "Beijing CCD Digital Technology Co., Ltd
//4013D9, "Global ES
//AC4FFC SVS-VISTEK GmbH
//B43741 Consert, Inc.
//94857A Evantage Industries Corp
//4083DE Zebra Technologies Inc
//8897DF Entrypass Corporation Sdn. Bhd.
//24AF54 NEXGEN Mediatech Inc.
//F0F842 KEEBOX, Inc.
//DC4EDE SHINYEI TECHNOLOGY CO., LTD.
//E087B1 Nata-Info Ltd.
//447C7F Innolight Technology Corporation
//D496DF SUNGJIN C&T CO., LTD
//5C864A Secret Labs LLC
//F0AD4E Globalscale Technologies, Inc.
//903D5A Shenzhen Wision Technology Holding Limited
//7CA29B D.SignT GmbH & Co.KG
//A04041", "SAMWONFA Co., Ltd.
//40406B Icomera
//6C22AB Ainsworth Game Technology
//3018CF DEOS control systems GmbH
//08FAE0 Fohhn Audio AG
//58B9E1 Crystalfontz America, Inc.
//20D906, "Iota, Inc.
//F45595 HENGBAO Corporation LTD.
//1C3A4F AccuSpec Electronics, LLC
//9C4E20 Cisco Systems, Inc
//D87533", "Nokia Corporation
//9835B8 Assembled Products Corporation
//288915, "CashGuard Sverige AB
//4C5DCD Oy Finnish Electric Vehicle Technologies Ltd
//70D57E, "Scalar Corporation
//B0E39D CAT SYSTEM CO., LTD.
//7C2E0D Blackmagic Design
//180C77 Westinghouse Electric Company, LLC
//68CA00 Octopus Systems Limited
//E0589E Laerdal Medical
//0C1DC2 SeAH Networks
//5475D0, "Cisco Systems, Inc
//6089B7 KAEL MÜHENDİSLİK ELEKTRONİK TİCARET SANAYİ LİMİTED ŞİRKETİ
//30525A NST Co., LTD
//2CA780 True Technologies Inc.
//7C6F06 Caterpillar Trimble Control Technologies
//601283, "TSB REAL TIME LOCATION SYSTEMS S.L.
//98DCD9 UNITEC Co., Ltd.
//C0CFA3 Creative Electronics & Software, Inc.
//94236E, "Shenzhen Junlan Electronic Ltd
//10E6AE Source Technologies, LLC
//FCE192", "Sichuan Jinwangtong Electronic Science&Technology Co,.Ltd
//408A9A TITENG CO., Ltd.
//F445ED Portable Innovation Technology Ltd.
//5CE286 Nortel Networks
//8C640B Beyond Devices d.o.o.
//949C55 Alta Data Technologies
//D479C3 Cameronet GmbH & Co.KG
//70D5E7, "Wellcore Corporation
//3CF72A Nokia Corporation
//545FA9 Teracom Limited
//6C32DE Indieon Technologies Pvt. Ltd.
//14A62C S.M.Dezac S.A.
//547FEE Cisco Systems, Inc
//ACEA6A", "GENIX INFOCOMM CO., LTD.
//E0BC43 C2 Microsystems, Inc.
//2CA835 RIM
//C41ECE HMI Sources Ltd.
//A8F470 Fujian Newland Communication Science Technologies Co., Ltd.
//8C736E FUJITSU LIMITED
//B86491", "CK Telecom Ltd
//50F003, "Open Stack, Inc.
//DC49C9 CASCO SIGNAL LTD
//70D880, "Upos System sp.z o.o.
//A05DC1 TMCT Co., LTD.
//583CC6 Omneality Ltd.
//B0C8AD People Power Company
//181714, "DAEWOOIS
//F0EC39", "Essec
//446C24 Reallin Electronic Co., Ltd
//2046F9, "Advanced Network Devices (dba:AND)
//487119, "SGB GROUP LTD.
//04FE7F Cisco Systems, Inc
//A4B1EE", "H.ZANDER GmbH & Co.KG
//842141, "Shenzhen Ginwave Technologies Ltd.
//A0231B", "TeleComp R&D Corp.
//B8A3E0 BenRui Technology Co., Ltd
//3CF52C DSPECIALISTS GmbH
//EC4476", "Cisco Systems, Inc
//6C1811 Decatur Electronics
//F8E968", "Egker Kft.
//A8995C aizo ag
//4012E4, "Compass-EOS
//5403F5, "EBN Technology Corp.
//04C05B Tigo Energy
//8038FD LeapFrog Enterprises, Inc.
//ACBEB6 Visualedge Technology Co., Ltd.
//2C9127 Eintechno Corporation
//AC583B", "Human Assembler, Inc.
//E8E776 Shenzhen Kootion Technology Co., Ltd
//681FD8 Siemens Industry, Inc.
//4001C6", "3COM EUROPE LTD
//9C5E73 Calibre UK LTD
//5C1437 Thyssenkrupp Aufzugswerke GmbH
//9C55B4 I.S.E.S.r.l.
//4C63EB Application Solutions (Electronics and Vision) Ltd
//702F97, "Aava Mobile Oy
//10CA81 PRECIA
//40A6A4 PassivSystems Ltd
//94BA31 Visiontec da Amazônia Ltda.
//B894D2 Retail Innovation HTT AB
//B0E97E", "Advanced Micro Peripherals
//F0C24C", "Zhejiang FeiYue Digital Technology Co., Ltd
//E4751E", "Getinge Sterilization AB
//1065A3 Core Brands LLC
//9C5B96 NMR Corporation
//60F13D, "JABLOCOM s.r.o.
//50252B Nethra Imaging Incorporated
//F8811A OVERKIZ
//3863F6, "3NOD MULTIMEDIA(SHENZHEN) CO., LTD
//78B81A INTER SALES A/S
//CC0080", "BETTINI SRL
//644BC3 Shanghai WOASiS Telecommunications Ltd., Co.
//942E63, "Finsécur
//AC8317", "Shenzhen Furtunetel Communication Co., Ltd
//ACD180", "Crexendo Business Solutions, Inc.
//CCCC4E Sun Fountainhead USA. Corp
//688540, "IGI Mobile, Inc.
//A09A5A Time Domain
//64A837 Juni Korea Co., Ltd
//202CB7 Kong Yue Electronics & Information Industry (Xinhui) Ltd.
//609F9D, "CloudSwitch
//48343D, "IEP GmbH
//D4AAFF MICRO WORLD
//74E537, "RADSPIN
//0026E9, "SP Corp
//0026EB Advanced Spectrum Technology Co., Ltd.
//0026E1, "Stanford University, OpenFlow Group
//002717, "CE Digital(Zhenjiang) Co., Ltd
//002716, "Adachi-Syokai Co., Ltd.
//0026DC Optical Systems Design
//002700, "Shenzhen Siglent Technology Co., Ltd.
//0026EC Legrand Home Systems, Inc
//0026D4, "IRCA SpA
//002663, "Shenzhen Huitaiwei Tech.Ltd, co.
//002661, "Irumtek Co., Ltd.
//00265B Hitron Technologies.Inc
//002656, "Sansonic Electronics USA
//00267D, "A-Max Technology Macao Commercial Offshore Company Limited
//00267C Metz-Werke GmbH & Co KG
//002673, "RICOH COMPANY, LTD.
//00266D, "MobileAccess Networks
//0026C0 EnergyHub
//0026C1 ARTRAY CO., LTD.
//0026BE Schoonderbeek Elektronica Systemen B.V.
//0026B5 ICOMM Tele Ltd
//00268C StarLeaf Ltd.
//00268B Guangzhou Escene Computer Technology Limited
//00266F, "Coordiwise Technology Corp.
//00266E, "Nissho-denki Co., LTD.
//0026C3 Insightek Corp.
//002681, "Interspiro AB
//002683, "Ajoho Enterprise Co., Ltd.
//00267F, "Zenterio AB
//002698, "Cisco Systems, Inc
//00269B SOKRAT Ltd.
//0026A1 Megger
//002644, "Thomson Telecom Belgium
//002646, "SHENYANG TONGFANG MULTIMEDIA TECHNOLOGY COMPANY LIMITED
//00263F, "LIOS Technology GmbH
//00263B Onbnetech
//002658, "T-Platforms (Cyprus) Limited
//00264C Shanghai DigiVision Technology Co., Ltd.
//00262F, "HAMAMATSU TOA ELECTRONICS
//002631, "COMMTACT LTD
//0025FB Tunstall Healthcare A/S
//0025F4, "KoCo Connector AG
//002606, "RAUMFELD GmbH
//002607, "Enabling Technology Pty Ltd
//002624, "Thomson Inc.
//002605, "CC Systems AB
//002602, "SMART Temps LLC
//00261A Femtocomm System Technology Corp.
//002634, "Infineta Systems, Inc
//002599, "Hedon e.d.B.V.
//002597, "Kalki Communication Technologies
//002592, "Guangzhou Shirui Electronic Co., Ltd
//002594, "Eurodesign BG LTD
//00259F, "TechnoDigital Technologies GmbH
//00259D, "Private
//002598, "Zhong Shan City Litai Electronic Industrial Co.Ltd
//0025E3, "Hanshinit Inc.
//0025DC Sumitomo Electric Industries, Ltd
//0025D4, "General Dynamics Mission Systems
//0025C2 RingBell Co., Ltd.
//0025A7 itron
//0025A9 Shanghai Embedway Information Technologies Co., Ltd
//0025CA LS Research, LLC
//0025B4 Cisco Systems, Inc
//0025B2 MBDA Deutschland GmbH
//0025EF, "I-TEC Co., Ltd.
//002528, "Daido Signal Co., Ltd.
//002526, "Genuine Technologies Co., Ltd.
//00256B ATENIX E.E.s.r.l.
//00256E, "Van Breda B.V.
//002565, "Vizimax Inc.
//00255E, "Shanghai Dare Technologies Co., Ltd.
//00253B din Dietmar Nocker Facilitymanagement GmbH
//00253D, "DRS Consolidated Controls
//002535, "Minimax GmbH & Co KG
//002584, "Cisco Systems, Inc
//002579, "J & F Labs
//00257F, "CallTechSolution Co., Ltd
//002577, "D-BOX Technologies
//002572, "Nemo-Q International AB
//002529, "COMELIT GROUP S.P.A
//00252A Chengdu GeeYa Technology Co., LTD
//00258A Pole/Zero Corporation
//00255F, "SenTec AG
//0024EC United Information Technology Co., Ltd.
//0024E6, "In Motion Technology Inc.
//0024E7, "Plaster Networks
//0024E4, "Withings
//0024DE GLOBAL Technology Inc.
//0024DC Juniper Networks
//0024DB Alcohol Monitoring Systems
//002521, "Logitek Electronic Systems, Inc.
//00251F, "ZYNUS VISION INC.
//00251E, "ROTEL TECHNOLOGIES
//002519, "Viaas Inc
//0024D5, "Winward Industrial Limited
//0024DD Centrak, Inc.
//0024EA iris-GmbH infrared & intelligent sensors
//0024ED, "YT Elec. Co,.Ltd.
//002503, "IBM Corp
//002504, "Valiant Communications Limited
//002513, "CXP DIGITAL BV
//0024A4 Siklu Communication
//00249A Beijing Zhongchuang Telecommunication Test Co., Ltd.
//00249E, "ADC-Elektronik GmbH
//00249F, "RIM Testing Services
//0024C2 Asumo Co., Ltd.
//0024BF CIAT
//0024C0 NTI COMODO INC
//0024BB CENTRAL Corporation
//0024BC HuRob Co., Ltd
//0024AD Adolf Thies Gmbh & Co.KG
//0024A7 Advanced Video Communications Inc.
//0024AB A7 Engineering, Inc.
//002466, "Unitron nv
//00245F, "Vine Telecom CO., Ltd.
//002455, "MuLogic BV
//002488, "Centre For Development Of Telematics
//00248F, "DO-MONIX
//002479, "Optec Displays, Inc.
//0024B7 GridPoint, Inc.
//0024AE IDEMIA
//002468, "Sumavision Technologies Co., Ltd
//00243A Ludl Electronic Products
//002439, "Digital Barriers Advanced Technologies
//002434, "Lectrosonics, Inc.
//00245A Nanjing Panda Electronics Company Limited
//00245B RAIDON TECHNOLOGY, INC.
//002459, "ABB Automation products GmbH
//00244E, "RadChips, Inc.
//00240D, "OnePath Networks LTD.
//00240B Virtual Computer Inc.
//002402, "Op-Tection GmbH
//00242F, "Micron
//002426, "NOHMI BOSAI LTD.
//002418, "Nextwave Semiconductor
//002412, "Benign Technologies Co, Ltd.
//002429, "MK MASTER INC.
//0023DB saxnet gmbh
//0023C8 TEAM-R
//0023EB Cisco Systems, Inc
//0023EC Algorithmix GmbH
//0023C1 Securitas Direct AB
//0023AA HFR, Inc.
//0023A5 SageTV, LLC
//00239E, "Jiangsu Lemote Technology Corporation Limited
//0023FC Ultra Stereo Labs, Inc
//0023BB Schmitt Industries
//00238D, "Techno Design Co., Ltd.
//002387, "ThinkFlood, Inc.
//002384, "GGH Engineering s.r.l.
//002391, "Maxian
//002392, "Proteus Industries Inc.
//002393, "AJINEXTEK
//00237F, "PLANTRONICS, INC.
//00236F, "DAQ System
//002330, "DIZIPIA, INC.
//002369, "Cisco-Linksys, LLC
//0022F8, "PIMA Electronic Systems Ltd.
//00231C Fourier Systems Ltd.
//00231D, "Deltacom Electronics Ltd
//0022D7, "Nintendo Co., Ltd.
//0022D6, "Cypak AB
//0022D0, "Polar Electro Oy
//00230A ARBURG GmbH & Co KG
//0022C3 Zeeport Technology Inc.
//002316, "KISAN ELECTRONICS CO
//00230F, "Hirsch Electronics Corporation
//00232D, "SandForce
//002323, "Zylin AS
//0022DE OPPO Digital, Inc.
//0022F1, "Private
//0022A2 Xtramus Technologies
//00229E, "Social Aid Research Co., Ltd.
//002285, "NOMUS COMM SYSTEMS
//002281, "Daintree Networks Pty
//002255, "Cisco Systems, Inc
//00224E, "SEEnergy Corp.
//002287, "Titan Wireless LLC
//002288, "Sagrad, Inc.
//002273, "Techway
//00226B Cisco-Linksys, LLC
//002267, "Nortel Networks
//002295, "SGM Technology for lighting spa
//00225A Garde Security AB
//002242, "Alacron Inc.
//002234, "Corventis Inc.
//0021F7, "HPN Supply Chain
//0021F4, "INRange Systems, Inc
//0021F5, "Western Engravers Supply, Inc.
//002232, "Design Design Technology Ltd
//00222B Nucomm, Inc.
//002226, "Avaak, Inc.
//002221, "ITOH DENKI CO, LTD.
//00221D, "Freegene Technology LTD
//002224, "Good Will Instrument Co., Ltd.
//002245, "Leine & Linde AB
//002249, "HOME MULTIENERGY SL
//002240, "Universal Telecom S/A
//00220F, "MoCA (Multimedia over Coax Alliance)
//00220A OnLive, Inc
//002203, "Glensound Electronics Ltd
//002204, "KORATEK
//0021FF Cyfrowy Polsat SA
//0021E4, "I-WIN
//0021E5, "Display Solution AG
//00221B Morega Systems
//0021B2 Fiberblaze A/S
//0021AC Infrared Integrated Systems Ltd
//00218E, "MEKICS CO., LTD.
//00218F, "Avantgarde Acoustic Lautsprechersysteme GmbH
//00217E, "Telit Communication s.p.a
//002187, "Imacs GmbH
//002181, "Si2 Microsystems Limited
//0021C2 GL Communications Inc
//0021E2, "visago Systems & Controls GmbH & Co.KG
//0021DD Northstar Systems Corp
//0021D5, "X2E GmbH
//0021A2 EKE-Electronics Ltd.
//0021C9 Wavecom Asia Pacific Limited
//00214A Pixel Velocity, Inc
//002146, "Sanmina-SCI
//00216E, "Function ATI (Huizhou) Telecommunications Co., Ltd.
//00216D, "Soltech Co., Ltd.
//002165, "Presstek Inc.
//00211F, "SHINSUNG DELTATECH CO., LTD.
//002124, "Optos Plc
//002133, "Building B, Inc
//002134, "Brandywine Communications
//00213A Winchester Systems Inc.
//00212E, "dresden-elektronik
//002130, "Keico Hightech Inc.
//00215B SenseAnywhere
//00214E, "GS Yuasa Power Supply Ltd.
//002142, "Advanced Control Systems doo
//001FFA Coretree, Co, Ltd
//001FF5 Kongsberg Defence & Aerospace
//001FF2 VIA Technologies, Inc.
//002101, "Aplicaciones Electronicas Quasar (AEQ)
//002103, "GHI Electronics, LLC
//001FF8 Siemens AG, Sector Industry, Drive Technologies, Motion Control Systems
//001FD0 GIGA-BYTE TECHNOLOGY CO., LTD.
//001FD1 OPTEX CO., LTD.
//001FC9 Cisco Systems, Inc
//001FDC Mobile Safe Track Ltd
//001FD6 Shenzhen Allywll
//002117, "Tellord
//00210F, "Cernium Corp
//001FF1 Paradox Hellas S.A.
//001FE6 Alphion Corporation
//001FCF MSI Technology GmbH
//001F9C LEDCO
//001F90, "Actiontec Electronics, Inc
//001F91, "DBS Lodging Technologies, LLC
//001F98, "DAIICHI-DENTSU LTD.
//001F93, "Xiotech Corporation
//001F51, "HD Communications Corp
//001F53, "GEMAC Chemnitz GmbH
//001F50, "Swissdis AG
//001F4C Roseman Engineering Ltd
//001FA9 Atlanta DTH, Inc.
//001FA3 T&W Electronics(Shenzhen) Co., Ltd.
//001FA2 Datron World Communications, Inc.
//001F70, "Botik Technologies LTD
//001F64, "Beijing Autelan Technology Inc.
//001F6D, "Cisco Systems, Inc
//001F24, "DIGITVIEW TECHNOLOGY CO., LTD.
//001F21, "Inner Mongolia Yin An Science & Technology Development Co., L
//001F22, "Source Photonics, Inc.
//001F1D, "Atlas Material Testing Technology LLC
//001F15, "Bioscrypt Inc
//001F2B Orange Logic
//001F2A ACCM
//001F30, "Travelping
//001F48, "Mojix Inc.
//001F3E, "RP-Technik e.K.
//001EF0, "Gigafin Networks
//001EF2, "Micro Motion Inc
//001F37, "Genesis I&C
//001F2C Starbridge Networks
//001F31, "Radiocomp
//001F12, "Juniper Networks
//001EEA Sensor Switch, Inc.
//001F04, "Granch Ltd.
//001E94, "SUPERCOM TECHNOLOGY CORPORATION
//001E8F, "CANON INC.
//001EA5 ROBOTOUS, Inc.
//001EA7 Actiontec Electronics, Inc
//001EA0 XLN-t
//001E98, "GreenLine Communications
//001E9A HAMILTON Bonaduz AG
//001EDF Master Industrialization Center Kista
//001EE3 T&W Electronics (ShenZhen) Co., Ltd
//001ED9, "Mitsubishi Precision Co., LTd.
//001ED3, "Dot Technology Int'l Co., Ltd.
//001EA6 Best IT World (India) Pvt. Ltd.
//001E83, "LAN/MAN Standards Association (LMSC)
//001E7C Taiwick Limited
//001ECF PHILIPS ELECTRONICS UK LTD
//001E22, "ARVOO Imaging Products BV
//001E1A Best Source Taiwan Inc.
//001E19, "GTRI
//001E14, "Cisco Systems, Inc
//001E44, "SANTEC
//001E62, "Siemon
//001E5C RB GeneralEkonomik
//001E5D, "Holosys d.o.o.
//001E78, "Owitek Technology Ltd.,
//001E7A Cisco Systems, Inc
//001E27, "SBN TECH Co., Ltd.
//001E60, "Digital Lighting Systems, Inc
//001E6C Opaque Systems
//001E2F, "DiMoto Pty Ltd
//001E36, "IPTE
//001DA7 Seamless Internet
//001DA5 WB Electronics
//001DA8 Takahata Electronics Co., Ltd
//001DA9 Castles Technology, Co., LTD
//001DCB Exéns Development Oy
//001DCA PAV Electronics Limited
//001DC2 XORTEC OY
//001E0E MAXI VIEW HOLDINGS LIMITED
//001E0F, "Briot International
//001DE3 Intuicom
//001DDE Zhejiang Broadcast&Television Technology Co., Ltd.
//001DE5 Cisco Systems, Inc
//001DEC Marusys
//001DE8 Nikko Denki Tsushin Corporation(NDTC)
//001DDA Mikroelektronika spol.s r. o.
//001DB0 FuJian HengTong Information Technology Co., Ltd
//001DB8 Intoto Inc.
//001DF5 Sunshine Co, LTD
//001DF0 Vidient Systems, Inc.
//001DFE Palm, Inc
//001D52, "Defzone B.V.
//001D4A Carestream Health, Inc.
//001D96, "WatchGuard Video
//001D8F, "PureWave Networks
//001D8C La Crosse Technology LTD
//001D64, "Adam Communications Systems Int Ltd
//001D5E, "COMING MEDIA CORP.
//001D55, "ZANTAZ, Inc
//001DA1 Cisco Systems, Inc
//001D71, "Cisco Systems, Inc
//001D65, "Microwave Radio Communications
//001D50, "SPINETIX SA
//001D45, "Cisco Systems, Inc
//001D69, "Knorr-Bremse IT-Services GmbH
//001CF8 Parade Technologies, Ltd.
//001CF7 AudioScience
//001CF6 Cisco Systems, Inc
//001CF5 Wiseblue Technology Limited
//001CEE SHARP Corporation
//001D07, "Shenzhen Sang Fei Consumer Communications Co., Ltd
//001D06, "HM Electronics, Inc.
//001D01, "Neptune Digital
//001D33, "Maverick Systems Inc.
//001D2C Wavetrend Technologies (Pty) Limited
//001CCF LIMETEK
//001D24, "Aclara Power-Line Systems Inc.
//001D18, "Power Innovation GmbH
//001D1B Sangean Electronics Inc.
//001D17, "Digital Sky Corporation
//001D27, "NAC-INTERCOM
//001CE3 Optimedical Systems
//001CDE Interactive Multimedia eXchange Inc.
//001D36, "ELECTRONICS CORPORATION OF INDIA LIMITED
//001C80 New Business Division/Rhea-Information CO., LTD.
//001C83 New Level Telecom Co., Ltd.
//001C76 The Wandsworth Group Ltd
//001C72 Mayer & Cie GmbH & Co KG
//001CAD Wuhan Telecommunication Devices Co., Ltd
//001CA7 International Quartz Limited
//001CAB Meyer Sound Laboratories, Inc.
//001C9E Dualtech IT AB
//001CC8 INDUSTRONIC Industrie-Electronic GmbH & Co.KG
//001CC6 ProStor Systems
//001CBE Nintendo Co., Ltd.
//001C94 LI-COR Biosciences
//001C8C DIAL TECHNOLOGY LTD.
//001CCA Shanghai Gaozhi Science & Technology Development Co.
//001CC9 Kaise Electronic Technology Co., Ltd.
//001C93 ExaDigm Inc
//001C85 Eunicorn
//001C67 Pumpkin Networks, Inc.
//001C60 CSP Frontier Technologies, Inc.
//001C6A Weiss Engineering Ltd.
//001C0A Shenzhen AEE Technology Co., Ltd.
//001C0D G-Technology, Inc.
//001C03 Betty TV Technology AG
//001C46 QTUM
//001C42 Parallels, Inc.
//001C3E ECKey Corporation
//001C51 Celeno Communications
//001C54 Hillstone Networks Inc
//001C59 DEVON IT
//001C22 Aeris Elettronica s.r.l.
//001C1D CHENZHOU GOSPELL DIGITAL TECHNOLOGY CO., LTD
//001C39 S Netsystems Inc.
//001C37 Callpod, Inc.
//001C33 Sutron
//001BF6 CONWISE Technology Corporation Ltd.
//001BF8 Digitrax Inc.
//001C2F Pfister GmbH
//001C27 Sunell Electronics Co.
//001C0F Cisco Systems, Inc
//001C48 WiDeFi, Inc.
//001BAD iControl Incorporated
//001BA7 Lorica Solutions
//001BA5 MyungMin Systems, Inc.
//001BF1 Nanjing SilverNet Software Co., Ltd.
//001BEF Blossoms Digital Technology Co., Ltd.
//001BEB DMP Electronics INC.
//001BA2 IDS Imaging Development Systems GmbH
//001B9D Novus Security Sp. z o.o.
//001BC9 FSN DISPLAY INC
//001BC3 Mobisolution Co., Ltd
//001BCE Measurement Devices Ltd
//001BB8 BLUEWAY ELECTRONIC CO; LTD
//001BB2 Intellect International NV
//001BE7 Postek Electronics Co., Ltd.
//001BE3 Health Hero Network, Inc.
//001BDC Vencer Co., Ltd.
//001BD5 Cisco Systems, Inc
//001B95 VIDEO SYSTEMS SRL
//001B90 Cisco Systems, Inc
//001B7F TMN Technologies Telecomunicacoes Ltda
//001B7E Beckmann GmbH
//001B7A Nintendo Co., Ltd.
//001B34 Focus System Inc.
//001B3A SIMS Corp.
//001B2E Sinkyo Electron Inc
//001B5F Alien Technology
//001B61 Digital Acoustics, LLC
//001B5E BPL Limited
//001B5C Azuretec Co., Ltd.
//001B72 Sicep s.p.a.
//001B74 MiraLink Corporation
//001B6D Midtronics, Inc.
//001B6F Teletrak Ltd
//001B4B SANION Co., Ltd.
//001B2D Med-Eng Systems Inc.
//001B87 Deepsound Tech.Co., Ltd
//001B4D Areca Technology Corporation
//001AE3 Cisco Systems, Inc
//001ADF Interactivetv Pty Limited
//001AE1 EDGE ACCESS INC
//001AE8 Unify Software and Solutions GmbH & Co.KG
//001AE9 Nintendo Co., Ltd.
//001AE5 Mvox Technologies Inc.
//001AE4 Medicis Technologies Corporation
//001AF8 Copley Controls Corporation
//001AF5 PENTAONE. CO., LTD.
//001AED INCOTEC GmbH
//001AEE Shenztech Ltd
//001ACE YUPITERU CORPORATION
//001ACC Celestial Semiconductor, Ltd
//001AD2 Eletronica Nitron Ltda
//001B1D Phoenix International Co., Ltd
//001B1A e-trees Japan, Inc.
//001B12 Apprion
//001AFE SOFACREAL
//001AF1 Embedded Artists AB
//001B0D Cisco Systems, Inc
//001B0A Intelligent Distributed Controls Ltd
//001AB1 Asia Pacific Satellite Industries Co., Ltd.
//001AB7 Ethos Networks LTD.
//001AB2 Cyber Solutions Inc.
//001A97 fitivision technology Inc.
//001A90 Trópico Sistemas e Telecomunicações da Amazônia LTDA.
//001A94 Votronic GmbH
//001A86 AdvancedIO Systems Inc
//001AC7 UNIPOINT
//001AC0 JOYBIEN TECHNOLOGIES CO., LTD.
//001A9E ICON Digital International Limited
//001A98 Asotel Communication Limited Taiwan Branch
//001A72 Mosart Semiconductor Corp.
//001A68 Weltec Enterprise Co., Ltd.
//001AC2 YEC Co., Ltd.
//001AA5 BRN Phoenix
//001AA2 Cisco Systems, Inc
//001A9C RightHand Technologies, Inc.
//001A7E LN Srithai Comm Ltd.
//001A5A Korea Electric Power Data Network", "(KDN) Co., Ltd
//001A5F KitWorks.fi Ltd.
//001A35 BARTEC GmbH
//001A37 Lear Corporation
//001A38 Sanmina-SCI
//001A2B Ayecom Technology Co., Ltd.
//001A28 ASWT Co., LTD.Taiwan Branch H.K.
//001A2C SATEC Co., LTD
//001A27 Ubistar
//001A21 Brookhuis Applied Technologies BV
//0019FF Finnzymes
//0019FA Cable Vision Electronics CO., LTD.
//001A5D Mobinnova Corp.
//001A4D GIGA-BYTE TECHNOLOGY CO., LTD.
//001A48 Takacom Corporation
//001A0B BONA TECHNOLOGY INC.
//001A06 OpVista, Inc.
//001A2E Ziova Coporation
//001A32 ACTIVA MULTIMEDIA
//001A00 MATRIX INC.
//0019AD BOBST SA
//0019A2 ORDYN TECHNOLOGIES
//0019A5 RadarFind Corporation
//001993, "Changshu Switchgear MFG.Co., Ltd. (Former Changshu Switchgea
//0019F1, "Star Communication Network Technology Co., Ltd
//0019EC Sagamore Systems, Inc.
//0019CC RCG (HK) Ltd
//0019C8 AnyDATA Corporation
//0019C4 Infocrypt Inc.
//0019BC ELECTRO CHANCE SRL
//00199B Diversified Technical Systems, Inc.
//001990, "ELM DATA Co., Ltd.
//00198F, "Nokia Bell N.V.
//0019D8, "MAXFOR
//0019D5, "IP Innovations, Inc.
//0019A3 asteel electronique atlantique
//0019EA TeraMage Technologies Co., Ltd.
//00196E, "Metacom (Pty) Ltd.
//001965, "YuHua TelTech (ShangHai) Co., Ltd.
//001966, "Asiarock Technology Limited
//00197B Picotest Corp.
//001973, "Zeugma Systems
//001975, "Beijing Huisen networks technology Inc
//001940, "Rackable Systems
//00193C HighPoint Technologies Incorporated
//00195C Innotech Corporation
//00195F, "Valemount Networks Corporation
//001948, "AireSpider Networks
//001943, "Belden
//00192E, "Spectral Instruments, Inc.
//00192B Aclara RF Systems Inc.
//00191E, "Beyondwiz Co., Ltd.
//001981, "Vivox Inc
//001945, "RF COncepts, LLC
//00191F, "Microlink communications Inc.
//001920, "KUME electric Co., Ltd.
//001926, "BitsGen Co., Ltd.
//001929, "2M2B Montadora de Maquinas Bahia Brasil LTDA
//0018F1, "Chunichi Denshi Co., LTD.
//0018F2, "Beijing Tianyu Communication Equipment Co., Ltd
//0018EC Welding Technology Corporation
//0018ED, "Accutech Ultrasystems Co., Ltd.
//00190B Southern Vision Systems, Inc.
//001903, "Bigfoot Networks Inc
//001900, "Intelliverese - DBA Voicecom
//001902, "Cambridge Consultants Ltd
//00192A Antiope Associates
//00190F, "Advansus Corp.
//001911, "Just In Mobile Information Technologies (Shanghai) Co., Ltd.
//0018E0, "ANAVEO
//001917, "Posiflex Inc.
//001918, "Interactive Wear AG
//0018CB Tecobest Technology Limited
//0018CE Dreamtech Co., Ltd
//001894, "NPCore, Inc.
//001898, "KINGSTATE ELECTRONICS CORPORATION
//001892, "ads-tec GmbH
//001891, "Zhongshan General K-mate Electronics Co., Ltd
//0018AD NIDEC SANKYO CORPORATION
//0018AC Shanghai Jiao Da HISYS Technology Co.Ltd.
//0018AB BEIJING LHWT MICROELECTRONICS INC.
//0018A5 ADigit Technologies Corp.
//001878, "Mackware GmbH
//00186A Global Link Digital Technology Co,.LTD
//00186B Sambu Communics CO., LTD.
//00186E, "3Com Ltd
//0018A6 Persistent Systems, LLC
//00189B Thomson Inc.
//0018B2 ADEUNIS RF
//0018B3 TEC WizHome Co., Ltd.
//0018BD SHENZHEN DVBWORLD TECHNOLOGY CO., LTD.
//001867, "Datalogic ADC
//001865, "Siemens Healthcare Diagnostics Manufacturing Ltd
//001877, "Amplex A/S
//001889, "WinNet Solutions Limited
//0017F9, "Forcom Sp. z o.o.
//0017F4, "ZERON ALLIANCE
//0017F7, "CEM Solutions Pvt Ltd
//0017ED, "WooJooIT Ltd.
//001843, "Dawevision Ltd
//00182C Ascend Networks, Inc.
//00181D, "ASIA ELECTRONICS CO., LTD
//00181F, "Palmmicro Communications
//00181B TaiJin Metal Co., Ltd.
//001805, "Beijing InHand Networking Technology Co., Ltd.
//00180D, "Terabytes Server Storage Tech Corp
//001854, "Argard Co., Ltd
//001847, "AceNet Technology Inc.
//001836, "REJ Co., Ltd
//0017CC Alcatel-Lucent
//0017C4 Quanta Microsystems, INC.
//00179E, "Sirit Inc
//0017A7 Mobile Computing Promotion Consortium
//00179F, "Apricorn
//0017B4 Remote Security Systems, LLC
//0017AC O'Neil Product Development Inc.
//0017AD AceNet Corporation
//0017DD Clipsal Australia
//0017D9, "AAI Corporation
//0017DC DAEMYUNG ZERO1
//0017BF Coherent Research Limited
//0017BD Tibetsystem
//0017A1", "3soft inc.
//001792, "Falcom Wireless Comunications Gmbh
//001797, "Telsy Elettronica S.p.A.
//00178C Independent Witness, Inc
//0017CB Juniper Networks
//0017D3, "Etymotic Research, Inc.
//001788, "Philips Lighting BV
//00173C Extreme Engineering Solutions
//001736, "iiTron Inc.
//001737, "Industrie Dial Face S.p.A.
//001733, "SFR
//001758, "ThruVision Ltd
//00174F, "iCatch Inc.
//00174A SOCOMEC
//00174E, "Parama-tech Co., Ltd.
//00176F, "PAX Computer Technology(Shenzhen) Ltd.
//001771, "APD Communications Ltd
//00175B ACS Solutions Switzerland Ltd.
//001729, "Ubicod Co.LTD
//001727, "Thermo Ramsey Italia s.r.l.
//00172A Proware Technology Corp.(By Unifosa)
//001725, "Liquid Computing
//001764, "ATMedia GmbH
//00175E, "Zed-3
//001766, "Accense Technology, Inc.
//0016D0, "ATech elektronika d.o.o.
//0016C3 BA Systems Inc
//0016F0, "Dell
//0016F8, "AVIQTECH TECHNOLOGY CO., LTD.
//0016E8, "Sigma Designs, Inc.
//001703, "MOSDAN Internation Co., Ltd
//0016FC TOHKEN CO., LTD.
//0016E9, "Tiba Medical Inc
//0016DC ARCHOS
//001714, "BR Controls Nederland bv
//00171B Innovation Lab Corp.
//001709, "Exalt Communications
//0016C1 Eleksen Ltd
//0016A9", "2EI
//0016B0 VK Corporation
//0016B1 KBS
//0016AE INVENTEL
//0016AC Toho Technology Corp.
//001683, "WEBIO International Co.,.Ltd.
//001684, "Donjin Co., Ltd.
//001687, "Chubb CSC-Vendor AP
//00167F, "Bluebird Soft Inc.
//00164C PLANET INT Co., Ltd
//001649, "SetOne GmbH
//001647, "Cisco Systems, Inc
//001665, "Cellon France
//00165F, "Fairmount Automation
//00167C iRex Technologies BV
//001673, "Bury GmbH & Co.KG
//001694, "Sennheiser Communications A/S
//00169C Cisco Systems, Inc
//001657, "Aegate Ltd
//00168C DSL Partner AS
//00161B Micronet Corporation
//001618, "HIVION Co., Ltd.
//00161E, "Woojinnet
//00161F, "SUNWAVETEC Co., Ltd.
//001614, "Picosecond Pulse Labs
//00160E, "Optica Technologies Inc.
//001643, "Sunhillo Corporation
//001644, "LITE-ON Technology Corp.
//00163E, "Xensource, Inc.
//0015FD Complete Media Systems
//0015F6, "SCIENCE AND ENGINEERING SERVICES, INC.
//001634, "Mathtech, Inc.
//00162C Xanboo
//001605, "YORKVILLE SOUND INC.
//0015F9, "Cisco Systems, Inc
//0015E3, "Dream Technologies Corporation
//0015E0, "Ericsson
//0015F3, "PELTOR AB
//0015E7, "Quantec Tontechnik
//0015D3, "Pantech&Curitel Communications, Inc.
//0015AD Accedian Networks
//0015AC Capelon AB
//0015A9 KWANG WOO I&C CO., LTD
//00E0A8 SAT GmbH & Co.
//001574, "Horizon Semiconductors Ltd.
//00158A SURECOM Technology Corp.
//00158E, "Plustek.INC
//001589, "D-MAX Technology Co., Ltd
//0015B4 Polymap", "Wireless LLC
//0015CA TeraRecon, Inc.
//001598, "Kolektor group
//001512, "Zurich University of Applied Sciences
//00150A Sonoa Systems, Inc
//001570, "Zebra Technologies Inc
//00156E, "A.W.Communication Systems Ltd
//001568, "Dilithium Networks
//00154B Wonde Proud Technology Co., Ltd
//001548, "CUBE TECHNOLOGIES
//00155F, "GreenPeak Technologies
//00155A DAINIPPON PHARMACEUTICAL CO., LTD.
//00151D, "M2I CORPORATION
//00153C Kprotech Co., Ltd.
//00153A Shenzhen Syscan Technology Co., Ltd.
//001532, "Consumer Technologies Group, LLC
//00149B Nokota Communications, LLC
//0014A1 Synchronous Communication Corp
//00149E, "UbONE Co., Ltd
//0014A2 Core Micro Systems Inc.
//0014AD Gassner Wiege- und Meßtechnik GmbH
//0014AF Datasym POS Inc.
//0014A9 Cisco Systems, Inc
//0014FF Precise Automation, Inc.
//0014FA AsGa S.A.
//0014FB Technical Solutions Inc.
//0014D2, "Kyuden Technosystems Corporation
//0014DC Communication System Design & Manufacturing (CSDM)
//0014CD DigitalZone Co., Ltd.
//0014C0 Symstream Technology Group Ltd
//0014C1 U.S.Robotics Corporation
//0014C4 Vitelcom Mobile Technology
//0014EC Acro Telecom
//0014EB AwarePoint Corporation
//0014AB Senhai Electronic Technology Co., Ltd.
//0014B0 Naeil Community
//0014F4, "DekTec Digital Video B.V.
//0014F5, "OSI Security Devices
//00148E, "Tele Power Inc.
//00148F, "Protronic (Far East) Ltd.
//00148C General Dynamics Mission Systems
//001487, "American Technology Integrators
//001444, "Grundfos Holding
//001437, "GSTeletech Co., Ltd.
//001431, "PDL Electronics Ltd
//00144D, "Intelligent Systems
//00144A Taiwan Thick-Film Ind. Corp.
//001445, "Telefon-Gradnja d.o.o.
//001468, "CelPlan International, Inc.
//00147C", "3Com Ltd
//001481, "Multilink Inc
//001464, "Cryptosoft
//00145E, "IBM Corp
//001458, "HS Automatic ApS
//001421, "Total Wireless Technologies Pte. Ltd.
//001420, "G-Links networking company
//001418, "C4Line
//00141B Cisco Systems, Inc
//0013F0, "Wavefront Semiconductor
//0013EF, "Kingjon Digital Technology Co., Ltd
//0013EB Sysmaster Corporation
//0013EC Netsnapper Technologies SARL
//00142B Edata Communication Inc.
//00142C Koncept International, Inc.
//001424, "Merry Electrics CO., LTD.
//0013D0, "t+ Medical Ltd
//0013D2, "PAGE IBERICA, S.A.
//0013D1, "KIRK telecom A/S
//00140F, "Federal State Unitary Enterprise Leningrad R&D Institute of
//001407, "Sperian Protection Instrumentation
//001406, "Go Networks
//00140A WEPIO Co., Ltd.
//0013FA LifeSize Communications, Inc
//0013FB RKC INSTRUMENT INC.
//0013DC IBTEK INC.
//0013BA ReadyLinks Inc
//0013B8 RyCo Electronic Systems Limited
//0013B6 Sling Media, Inc.
//00137D, "Dynalab, Inc.
//001383, "Application Technologies and Engineering Research Laboratory
//001387, "27M Technologies AB
//001373, "BLwave Electronics Co., Ltd
//001366, "Neturity Technologies Inc.
//00135B PanelLink Cinema, LLC
//00136F, "PacketMotion, Inc.
//001368, "Saab Danmark A/S
//0013B4 Appear TV
//0013AE Radiance Technologies, Inc.
//001397, "Oracle Corporation
//0013C3 Cisco Systems, Inc
//0013BD HYMATOM SA
//001391, "OUEN CO., LTD.
//001323, "Cap Co., Ltd.
//001314, "Asiamajor Inc.
//001316, "L-S-B Broadcast Technologies GmbH
//001312, "Amedia Networks Inc.
//001336, "Tianjin 712 Communication Broadcasting co., ltd.
//00135E, "EAB/RWI/K
//00134E, "Valox Systems, Inc.
//001344, "Fargo Electronics Inc.
//001348, "Artila Electronics Co., Ltd.
//0012EF, "OneAccess SA
//0012E9, "Abbey Systems Ltd
//001300, "IT-FACTORY, INC.
//001322, "DAQ Electronics, Inc.
//0012D5, "Motion Reality Inc.
//0012D8, "International Games System Co., Ltd.
//00129A IRT Electronics Pty Ltd
//00128D, "STB Datenservice GmbH
//0012DB ZIEHL industrie-elektronik GmbH + Co KG
//0012D6, "Jiangsu Yitong High-Tech Co., Ltd
//0012DA Cisco Systems, Inc
//0012D3, "Zetta Systems, Inc.
//0012A2 VITA
//0012A5 Dolphin Interconnect Solutions AS
//0012A8 intec GmbH
//00129E, "Surf Communications Inc.
//0012BA FSI Systems, Inc.
//0012B2 AVOLITES LTD.
//0012AE HLS HARD-LINE Solutions Inc.
//0012AF ELPRO Technologies
//0012E6, "SPECTEC COMPUTER CO., LTD.
//0012E3, "Agat-RT, Ltd.
//001236, "ConSentry Networks
//001235, "Andrew Corporation
//001245, "Zellweger Analytics, Inc.
//001242, "Millennial Net
//001241, "a2i marketing center
//00123B KeRo Systems ApS
//001287, "Digital Everywhere Unterhaltungselektronik GmbH
//001282, "Qovia
//001285, "Gizmondo Europe Ltd
//001277, "Korenix Technologies Co., Ltd.
//00126D, "University of California, Berkeley
//001267, "Panasonic Corporation
//001265, "Enerdyne Technologies, Inc.
//001257, "LeapComm Communication Technologies Inc.
//001251, "SILINK
//00128E, "Q-Free ASA
//001292, "Griffin Technology
//0011F3, "NeoMedia Europe AG
//0011E9, "STARNEX CO., LTD.
//0011EC AVIX INC.
//0011E7, "WORLDSAT - Texas de France
//001202, "Decrane Aerospace - Audio International Inc.
//0011FE Keiyo System Research, Inc.
//0011FD KORG INC.
//0011FA Rane Corporation
//0011CE Ubisense Limited
//0011D0, "Tandberg Data ASA
//0011C3 Transceiving System Technology Corporation
//0011C2 United Fiber Optic Communication
//001228, "Data Ltd.
//00121F, "Harding Instruments
//001220, "Cadco Systems
//001229, "BroadEasy Technologies Co., Ltd
//001226, "Japan Direx Corporation
//001222, "Skardin (UK) Ltd
//0011E8, "Tixi.Com
//0011E0, "U-MEDIA Communications, Inc.
//00120D, "Advanced Telecommunication Technologies, Inc.
//00120E, "AboCom
//0011F2, "Institute of Network Technologies
//001210, "WideRay Corp
//0011A4 JStream Technologies Inc.
//001198, "Prism Media Products Limited
//001197, "Monitoring Technologies Limited
//001199, "2wcom Systems GmbH
//0011A7 Infilco Degremont Inc.
//0011A9 MOIMSTONE Co., LTD
//0011A3 LanReady Technologies Inc.
//001176, "Intellambda Systems, Inc.
//001177, "Coaxial Networks, Inc.
//001170, "GSC SRL
//00116B Digital Data Communications Asia Co., Ltd
//001169, "EMS Satcom
//001162, "STAR MICRONICS CO., LTD.
//001181, "InterEnergy Co.Ltd,
//001194, "Chi Mei Communication Systems, Inc.
//0011BF AESYS S.p.A.
//0011B7 Octalix B.V.
//0011B9 Inner Range Pty. Ltd.
//001109, "Micro-Star International
//001104, "TELEXY
//001161, "NetStreams, LLC
//001156, "Pharos Systems NZ
//001159, "MATISSE NETWORKS INC
//00115C Cisco Systems, Inc
//00115D, "Cisco Systems, Inc
//001126, "Venstar Inc.
//00112E, "CEICOM
//001122, "CIMSYS Inc
//001117, "CESNET
//001116, "COTEAU VERT CO., LTD.
//001110, "Maxanna Technology Co., Ltd.
//00113B Micronet Communications Inc.
//00113D, "KN SOLTEC CO., LTD.
//001134, "MediaCell, Inc.
//001135, "Grandeye Ltd
//001121, "Cisco Systems, Inc
//001149, "Proliphix Inc.
//000FC0 DELCOMp
//000FBA Tevebox AB
//000FB8 CallURL Inc.
//000FB7 Cavium
//000FD3 Digium
//000FD1 Applied Wireless Identifications Group, Inc.
//000FC1 WAVE Corporation
//001100, "Schneider Electric
//000FFA Optinel Systems, Inc.
//000FFD Glorytek Network Inc.
//000FF9 Valcretec, Inc.
//000FC4 NST co., LTD.
//000FC9 Allnet GmbH
//000FC6 Eurocom Industries A/S
//000FBE e-w/you Inc.
//000FA9 PC Fabrik
//000FA0 CANON KOREA BUSINESS SOLUTIONS INC.
//000F9A Synchrony, Inc.
//000FEA Giga-Byte Technology Co., LTD.
//000FF7 Cisco Systems, Inc
//000FD8 Force, Inc.
//000F8D, "FAST TV-Server AG
//000F85, "ADDO-Japan Corporation
//000F82, "Mortara Instrument, Inc.
//000F49, "Northover Solutions Limited
//000F4B Oracle Corporation
//000F44, "Tivella Inc.
//000F4A Kyushu-kyohan co., ltd
//000F81, "PAL Pacific Inc.
//000F7F, "UBSTORAGE Co., Ltd.
//000F95, "ELECOM Co., LTD Laneed Division
//000F55, "Datawire Communication Networks Inc.
//000F56, "Continuum Photonics Inc
//000F60, "Lifetron Co., Ltd
//000F5B Delta Information Systems, Inc.
//000F8A WideView
//000F90, "Cisco Systems, Inc
//000F77, "DENTUM CO., LTD
//000F7B Arce Sistemas, S.A.
//000F68, "Vavic Network Technology, Inc.
//000EE2 Custom Engineering
//000EE3 Chiyu Technology Co., Ltd
//000EE5 bitWallet, Inc.
//000EDA C-TECH UNITED CORP.
//000ECF PROFIBUS Nutzerorganisation e.V.
//000EEB Sandmartin(zhong shan) Electronics Co., Ltd
//000EEC Orban
//000EEF Private
//000EF1, "EZQUEST INC.
//000EE7 AAC ELECTRONICS CORP.
//000F1C DigitAll World Co., Ltd
//000F1A Gaming Support B.V.
//000F0A Clear Edge Networks
//000F02, "Digicube Technology Co., Ltd
//000F2F, "W-LINX TECHNOLOGY CO., LTD.
//000F2D, "CHUNG-HSIN ELECTRIC & MACHINERY MFG.CORP.
//000EF7, "Vulcan Portals Inc
//000EF0, "Festo AG & Co.KG
//000EE9 WayTech Development, Inc.
//000F40, "Optical Internetworking Forum
//000F33, "DUALi Inc.
//000F05, "3B SYSTEM INC.
//000EC9 YOKO Technology Corp.
//000EBD Burdick, a Quinton Compny
//000EB9 HASHIMOTO Electronics Industry Co., Ltd.
//000EB2 Micro-Research Finland Oy
//000ED0, "Privaris, Inc.
//000EC3 Logic Controls, Inc.
//000EC4 Iskra Transmission d.d.
//000EC1 MYNAH Technologies
//000E82, "Commtech Wireless
//000E89, "CLEMATIC
//000E79, "Ample Communications Inc.
//000EA1 Formosa Teletek Corporation
//000E98, "HME Clear-Com LTD.
//000E99, "Spectrum Digital, Inc
//000E95, "Fujiya Denki Seisakusho Co., Ltd.
//000E97, "Ultracker Technology CO., Inc
//000EA7 Endace Technology
//000E6F, "IRIS Corporation Berhad
//000EB5 Ecastle Electronics Co., Ltd.
//000E50, "Thomson Telecom Belgium
//000E4B atrium c and i
//000E2B Safari Technologies
//000E28, "Dynamic Ratings P/L
//000E24, "Huwell Technology Inc.
//000E3F, "Soronti, Inc.
//000E45, "Beijing Newtry Electronic Technology Ltd
//000E1D, "ARION Technology Inc.
//000E12, "Adaptive Micro Systems Inc.
//000E4F, "Trajet GmbH
//000E38, "Cisco Systems, Inc
//000E36, "HEINESYS, Inc.
//000E17, "Private
//000E15, "Tadlys LTD
//000E01, "ASIP Technologies Inc.
//000DCB Petcomkorea Co., Ltd.
//000DCC NEOSMART Corp.
//000DCE Dynavac Technology Pte Ltd
//000DE8 Nasaco Electronics Pte. Ltd
//000DE9 Napatech Aps
//000DE6 YOUNGBO ENGINEERING CO., LTD
//000DC3 First Communication, Inc.
//000DB9 PC Engines GmbH
//000DB7 SANKO ELECTRIC CO,.LTD
//000DAC Japan CBM Corporation
//000DDF Japan Image & Network Inc.
//000DDB AIRWAVE TECHNOLOGIES INC.
//000E04, "CMA/Microdialysis AB
//000D2A Scanmatic AS
//000D29, "Cisco Systems, Inc
//000D26, "Primagraphics Limited
//000D46, "Parker SSD Drives
//000D41, "Siemens AG ICM MP UC RD IT KLF1
//000D42, "Newbest Development Limited
//000D3C i.Tech Dynamic Ltd
//000D55, "SANYCOM Technology Co., Ltd
//000D57, "Fujitsu I-Network Systems Limited.
//000D58, "Private
//000D51, "DIVR Systems, Inc.
//000D39, "Network Electronics
//000D35, "PAC International Ltd
//000D95, "Opti-cell, Inc.
//000D91, "Eclipse (HQ Espana) S.L.
//000D62, "Funkwerk Dabendorf GmbH
//000D65, "Cisco Systems, Inc
//000D45, "Tottori SANYO Electric Co., Ltd.
//000DA1 MIRAE ITS Co., LTD.
//000D80, "Online Development Inc
//000D13, "Wilhelm Rutenbeck GmbH&Co.KG
//000D19, "ROBE Show lighting
//000D1C Amesys Defense
//000CED Real Digital Media
//000CF0 M & N GmbH
//000CF4 AKATSUKI ELECTRIC MFG.CO., LTD.
//000CF3 CALL IMAGE SA
//000CCF Cisco Systems, Inc
//000CD8 M. K.Juchheim GmbH & Co
//000CC6 Ka-Ro electronics GmbH
//000D01, "P&E Microcomputer Systems, Inc.
//000D00, "Seaway Networks Inc.
//000CF9 Xylem Water Solutions
//000CC4 Tiptel AG
//000CBA Jamex, Inc.
//000CD1 SFOM Technology Corp.
//000CCE Cisco Systems, Inc
//000CE0 Trek Diagnostics Inc.
//000CE2 Rolls-Royce
//000D0C MDI Security Systems
//000D16, "UHS Systems Pty Ltd
//000D1F, "AV Digital
//000CAD BTU International
//000CAA Cubic Transportation Systems Inc
//000CAC Citizen Watch Co., Ltd.
//000CAE Ailocom Oy
//000CA3 Rancho Technology, Inc.
//000C9C Chongho information & communications
//000C97 NV ADB TTV Technologies SA
//000C8F Nergal s.r.l.
//000C92 WolfVision Gmbh
//000C93 Xeline Co., Ltd.
//000C7F synertronixx GmbH
//000C81 Schneider Electric (Australia)
//000C9E MemoryLink Corp.
//000C95 PrimeNet
//000C76 MICRO-STAR INTERNATIONAL CO., LTD.
//000C80 Opelcomm Inc.
//000C7D TEIKOKU ELECTRIC MFG. CO., LTD
//000CB7 Nanjing Huazhuo Electronics Co., Ltd.
//000C68 SigmaTel, Inc.
//000C07 Iftest AG
//000C0C APPRO TECHNOLOGY INC.
//000C0E XtremeSpectrum, Inc.
//000C12 Micro-Optronic-Messtechnik GmbH
//000C10 PNI Corporation
//000C40 Altech Controls
//000C3E Crest Audio
//000C3A Oxance
//000C35 KaVo Dental GmbH & Co.KG
//000C56 Megatel Computer (1986) Corp.
//000C57 MACKIE Engineering Services Belgium BVBA
//000C23 Beijing Lanchuan Tech.Co., Ltd.
//000C25 Allied Telesis Labs, Inc.
//000C18 Zenisu Keisoku Inc.
//000C0A Guangdong Province Electronic Technology Research Institute
//000C0B Broadbus Technologies
//000C4A Cygnus Microsystems (P) Limited
//000C54 Pedestal Networks, Inc
//000C37 Geomation, Inc.
//000BE8 AOIP
//000BDC AKCP
//000BD8 Industrial Scientific Corp.
//000BD7 DORMA Time + Access GmbH
//000BDD TOHOKU RICOH Co., LTD.
//000BE5 HIMS International Corporation
//000BE9 Actel Corporation
//000BE3 Key Stream Co., Ltd.
//000BD3 cd3o
//000BD5 Nvergence, Inc.
//000BD1 Aeronix, Inc.
//000BD2 Remopro Technology Inc.
//000BC7 ICET S.p.A.
//000BB8 Kihoku Electronic Co.
//000BC0 China IWNComm Co., Ltd.
//000BB0 Sysnet Telematica srl
//000BB4 RDC Semiconductor Inc.,
//000BCC JUSAN, S.A.
//000BAC", "3Com Ltd
//000BF9 Gemstone Communications, Inc.
//000BFC Cisco Systems, Inc
//000BEA Zultys Technologies
//000B9F Neue ELSA GmbH
//000B98 NiceTechVision
//000B95 eBet Gaming Systems Pty Ltd
//000B9E Yasing Technology Corp.
//000B88 Vidisco ltd.
//000B54 BiTMICRO Networks, Inc.
//000B8C Flextronics
//000B8A MITEQ Inc.
//000B90 ADVA Optical Networking Ltd.
//000B79 X-COM, Inc.
//000B4B VISIOWAVE SA
//000B36 Productivity Systems, Inc.
//000B35 Quad Bit System co., Ltd.
//000B75 Iosoft Ltd.
//000B70 Load Technology, Inc.
//000B6F Media Streaming Networks Inc
//000B43 Microscan Systems, Inc.
//000B45 Cisco Systems, Inc
//000B4C Clarion (M) Sdn Bhd
//000B63 Kaleidescape
//000B68 Addvalue Communications Pte Ltd
//000B58 Astronautics C.A LTD
//000B55 ADInstruments
//000B87 American Reliance Inc.
//000B0D Air2U, Inc.
//000B0B Corrent Corporation
//000B08 Pillar Data Systems
//000B27 Scion Corporation
//000B21 G-Star Communications Inc.
//000ADA Vindicator Technologies
//000AC9 Zambeel Inc
//000B25 Aeluros
//000B1A Industrial Defender, Inc.
//000B18 Private
//000B15 Platypus Technology
//000AFA Traverse Technologies Australia
//000AFC Core Tec Communications, LLC
//000AEC Koatsu Gas Kogyo Co., Ltd.
//000AE7 ELIOP S.A.
//000AE8 Cathay Roxus Information Technology Co. LTD
//000ADD Allworx Corp.
//000AE1 EG Technology
//000ADF Gennum Corporation
//000B3F Anthology Solutions Inc.
//000B3C Cygnal Integrated Products, Inc.
//000AF1 Clarity Design, Inc.
//000AF3 Cisco Systems, Inc
//000A8D EUROTHERM LIMITED
//000A9F Pannaway Technologies, Inc.
//000A8F Aska International Inc.
//000AA0 Cedar Point Communications
//000A8E Invacom Ltd
//000AC1 Futuretel
//000ABE OPNET Technologies CO., LTD.
//000AC3 eM Technics Co., Ltd.
//000AC4 Daewoo Teletech Co., Ltd
//000AC0 Fuyoh Video Industry CO., LTD.
//000AAE Rosemount Process Analytical
//000AB3 Fa. GIRA
//000ABA Arcon Technology Limited
//000AB6 COMPUNETIX, INC
//000AAF Pipal Systems
//000A76 Beida Jade Bird Huaguang Technology Co., Ltd
//000AB2 Fresnel Wireless Systems
//000AAA AltiGen Communications Inc.
//000A99 Calamp Wireless Networks Inc
//000A93 W2 Networks, Inc.
//000A89 Creval Systems, Inc.
//000A80 Telkonet Inc.
//000A79 corega K.K
//000A5C Carel s.p.a.
//000A5A GreenNET Technologies Co., Ltd.
//000A56 HITACHI Maxell Ltd.
//000A51 GyroSignal Technology Co., Ltd.
//000A2C Active Tchnology Corporation
//000A2A QSI Systems Inc.
//000A23 Parama Networks Inc
//000A1F ART WARE Telecommunication Co., Ltd.
//000A0A SUNIX Co., Ltd.
//000A05 Widax Corp.
//000A34 Identicard Systems Incorporated
//000A30 Visteon Corporation
//000A2F Artnix Inc.
//000A15 Silicon Data, Inc
//000A1B Stream Labs
//000A1A Imerge Ltd
//000A60 Autostar Technology Pte Ltd
//000A5D FingerTec Worldwide Sdn Bhd
//000A39 LoPA Information Technology
//000A37 Procera Networks, Inc.
//000A53 Intronics, Incorporated
//000A4A Targa Systems Ltd.
//0009D6, "KNC One GmbH
//0009C7 Movistec
//0009C9 BlueWINC Co., Ltd.
//0009D4, "Transtech Networks
//0009CB HBrain
//0009F1, "Yamaki Electric Corporation
//0009F4, "Alcon Laboratories, Inc.
//0009F5, "Emerson Network Power Co., Ltd
//0009EA YEM Inc.
//0009C5 KINGENE Technology Corporation
//0009CD HUDSON SOFT CO., LTD.
//0009C0", "6WIND
//0009BF Nintendo Co., Ltd.
//0009E3, "Angel Iglesias S.A.
//0009B4 KISAN TELECOM CO., LTD.
//0009AE OKANO ELECTRIC CO., LTD
//0009BA MAKU Informationstechik GmbH
//000A04", "3Com Ltd
//000971, "Time Management, Inc.
//000974, "Innopia Technologies, Inc.
//00098B Entropic Communications, Inc.
//00097E, "IMI TECHNOLOGY CO., LTD
//00096A Cloverleaf Communications Inc.
//00095A RACEWOOD TECHNOLOGY
//00094E, "BARTECH SYSTEMS INTERNATIONAL, INC
//000947, "Aztek, Inc.
//000951, "Apogee Imaging Systems
//00093D, "Newisys, Inc.
//000991, "GE Fanuc Automation Manufacturing, Inc.
//000967, "Tachyon, Inc
//000996, "RDI
//00090C Mayekawa Mfg.Co.Ltd.
//00090D, "LEADER ELECTRONICS CORP.
//0008FE UNIK C&C Co., Ltd.
//0008FF Trilogy Communications Ltd
//000904, "MONDIAL electronic
//00091F, "A&D Co., Ltd.
//000924, "Telebau GmbH
//000921, "Planmeca Oy
//000919, "MDS Gateways
//000918, "SAMSUNG TECHWIN CO., LTD
//00092F, "Akom Technology Corporation
//0008EF, "DIBAL, S.A.
//0008F0, "Next Generation Systems, Inc.
//0008E9, "NextGig
//000910, "Simple Access Inc.
//000914, "COMPUTROLS INC.
//0008E7, "SHI ControlSystems, Ltd.
//0008D7, "HOW CORPORATION
//0008FC Gigaphoton Inc.
//000938, "Allot Communications
//0008BF Aptus Elektronik AB
//0008B8 E.F.Johnson
//0008BB NetExcell
//0008BE XENPAK MSA Group
//0008C1 Avistar Communications Corporation
//0008C6 Philips Consumer Communications
//000865, "JASCOM CO., LTD
//000864, "Fasy S.p.A.
//000860, "LodgeNet Entertainment Corp.
//000897, "Quake Technologies
//000890, "AVILINKS SA
//00088D, "Sigma-Links Inc.
//0008A8 Systec Co., Ltd.
//0008A4 Cisco Systems, Inc
//08006B ACCEL TECHNOLOGIES INC.
//000884, "Index Braille AB
//0007E8, "EdgeWave
//0007EB Cisco Systems, Inc
//0007EC Cisco Systems, Inc
//000851, "Canadian Bank Note Company, Ltd.
//000859, "ShenZhen Unitone Electronics Co., Ltd.
//00084E, "DivergeNet, Inc.
//000819, "Banksys
//00081A Sanrad Intelligence Storage Communications (2000) Ltd.
//000810, "Key Technology, Inc.
//000807, "Access Devices Limited
//0007FC Adept Systems Inc.
//000825, "Acme Packet
//0007DC Atek Co, Ltd.
//00081F, "Pou Yuen Tech Corp. Ltd.
//0007C6 VDS Vosskuhler GmbH
//0007F5, "Bridgeco Co AG
//000794, "Simple Devices, Inc.
//000797, "Netpower Co., Ltd.
//00078C Elektronikspecialisten i Borlange AB
//0007CC Kaba Benzing GmbH
//0007C0 NetZerver Inc.
//00047E, "Siqura B.V.
//0007BC Identix Inc.
//0007A9 Novasonics
//0007A1 VIASYS Healthcare GmbH
//00079E, "Ilinx Co., Ltd.
//0007A0 e-Watch Inc.
//000788, "Clipcomm, Inc.
//000781, "Itron Inc.
//00076B Stralfors AB
//000768, "Danfoss A/S
//00075F, "VCS Video Communication Systems AG
//0007B8 Corvalent Corporation
//00077B Millimetrix Broadband Networks
//000769, "Italiana Macchi SpA
//00071A Finedigital Inc.
//00071E, "Tri-M Engineering / Nupak Dev. Corp.
//000717, "Wieland Electric GmbH
//000711, "Acterna
//000702, "Varex Imaging
//000705, "Endress & Hauser GmbH & Co
//0006FF Sheba Systems Co., Ltd.
//000741, "Sierra Automated Systems
//000745, "Radlan Computer Communications Ltd.
//00073E, "China Great-Wall Computer Shenzhen Co., Ltd.
//000733, "DANCONTROL Engineering
//00072B Jung Myung Telecom Co., Ltd.
//000718, "iCanTek Co., Ltd.
//000716, "J & S Marine Ltd.
//00075C Eastman Kodak Company
//000756, "Juyoung Telecom
//00075A Air Products and Chemicals, Inc.
//000748, "The Imaging Source Europe
//000746, "TURCK, Inc.
//00073B Tenovis GmbH & Co KG
//000731, "Ophir-Spiricon LLC
//00070A Unicom Automation Co., Ltd.
//000709, "Westerstrand Urfabrik AB
//0006EB Global Data
//0006D3, "Alpha Telecom, Inc.U.S.A.
//000647, "Etrali S.A.
//0006A4 INNOWELL Corp.
//0006D6, "Cisco Systems, Inc
//0006CB Jotron Electronics A/S
//0006CD Leaf Imaging Ltd.
//000695, "Ensure Technologies, Inc.
//000691, "PT Inovacao
//000692, "Intruvert Networks, Inc.
//00068B AirRunner Technologies, Inc.
//000688, "Telways Communication Co., Ltd.
//0006AB W-Link Systems, Inc.
//0006AC Intersoft Co.
//000694, "Mobillian Corporation
//0006C7 RFNET Technologies Pte Ltd (S)
//0006B9 A5TEK Corp.
//0006B3 Diagraph Corporation
//0006E3, "Quantitative Imaging Corporation
//0006E4, "Citel Technologies Ltd.
//0006A1 Celsian Technologies, Inc.
//0006D9, "IPM-Net S.p.A.
//000663, "Human Technology Co., Ltd.
//000665, "Sunny Giken, Inc.
//000669, "Datasound Laboratories Ltd
//00066E, "Delta Electronics, Inc.
//00061B Notebook Development Lab.", "Lenovo Japan Ltd.
//00060F, "Narad Networks Inc
//000610, "Abeona Networks Inc
//000611, "Zeus Wireless, Inc.
//0005EC Mosaic Systems Inc.
//000662, "MBM Technology Ltd.
//00065A Strix Systems
//000652, "Cisco Systems, Inc
//000656, "Tactel AB
//000641, "ITCN
//000648, "Seedsware, Inc.
//00064C Invicta Networks, Inc.
//000674, "Spectrum Control, Inc.
//000638, "Sungjin C&C Co., Ltd.
//000635, "PacketAir Networks, Inc.
//00061A Zetari Inc.
//00061F, "Vision Components GmbH
//000687, "Omnitron Systems Technology, Inc.
//000602, "Cirkitech Electronics Co.
//0005C0 Digital Network Alacarte Co., Ltd.
//0005B8 Electronic Design Associates, Inc.
//0005BA Area Netwoeks, Inc.
//0005BF JustEzy Technology, Inc.
//0005D5, "Speedcom Wireless
//0005C5 Flaga HF
//0005CA Hitron Technology, Inc.
//0005D2, "DAP Technologies
//0005B1 ASB Technology BV
//000599, "DRS Test and Energy Management or DRS-TEM
//00059A Cisco Systems, Inc
//0005AB Cyber Fone, Inc.
//000592, "Pultek Corp.
//00058B IPmental, Inc.
//0005AC Northern Digital, Inc.
//0005AD Topspin Communications, Inc.
//0005D1, "Metavector Technologies
//0005C9 LG Innotek Co., Ltd.
//0005FB ShareGate, Inc.
//0005FE Traficon N.V.
//0005F0, "SATEC
//000530, "Andiamo Systems, Inc.
//000538, "Merilus, Inc.
//00052B HORIBA, Ltd.
//00051D, "Airocon, Inc.
//000515, "Nuark Co., Ltd.
//000516, "SMART Modular Technologies
//000577, "SM Information & Communication
//000570, "Baydel Ltd.
//00056E, "National Enhance Technology, Inc.
//00056D, "Pacific Corporation
//000581, "Snell
//00057D, "Sun Communications, Inc.
//000586, "Lucent Technologies
//00057B Chung Nam Electronic Co., Ltd.
//000571, "Seiwa Electronics Co.
//000549, "Salira Optical Network Systems
//00054C RF Innovations Pty Ltd
//000543, "IQ Wireless GmbH
//00055C Kowa Company, Ltd.
//000510, "Infinite Shanghai Communication Terminals Ltd.
//0004FF Acronet Co., Ltd.
//000501, "Cisco Systems, Inc
//000508, "Inetcam, Inc.
//00051B Magic Control Technology Corporation
//000513, "VTLinx Multimedia Systems, Inc.
//00050E, "3ware, Inc.
//0004D7, "Omitec Instrumentation Ltd.
//0004D4, "Proview Electronics Co., Ltd.
//0004DB Tellus Group Corp.
//0004E0, "Procket Networks
//0004DD Cisco Systems, Inc
//008086, "COMPUTER GENERATION INC.
//000504, "Naray Information & Communication Enterprise
//000509, "AVOC Nishimura Ltd.
//0004FB Commtech, Inc.
//0004C0 Cisco Systems, Inc
//0004BA KDD Media Will Corporation
//0004B6 Stratex Networks, Inc.
//0004CD Extenway Solutions Inc
//0004E9, "Infiniswitch Corporation
//0004E8, "IER, Inc.
//0004B3 Videotek, Inc.
//00044C JENOPTIK
//000444, "Western Multiplex Corporation
//000439, "Rosco Entertainment Technology, Inc.
//00043A Intelligent Telecommunications, Inc.
//000492, "Hive Internet, Ltd.
//00048C Nayna Networks, Inc.
//000491, "Technovision, Inc.
//000493, "Tsinghua Unisplendour Co., Ltd.
//000494, "Breezecom, Ltd.
//000489, "YAFO Networks, Inc.
//00048A Temia Vertriebs GmbH
//000481, "Econolite Control Products, Inc.
//00046C Cyber Technology Co., Ltd.
//000471, "IPrad
//00046E, "Cisco Systems, Inc
//000474, "LEGRAND
//00042D, "Sarian Systems, Ltd.
//00042E, "Netous Technologies, Ltd.
//000425, "Atmel Corporation
//00043F, "ESTeem Wireless Modems, Inc
//000433, "Cyberboard A/S
//000434, "Accelent Systems, Inc.
//000477, "Scalant Systems, Inc.
//000473, "Photonex Corporation
//000470, "ipUnplugged AB
//00045D, "BEKA Elektronik
//000459, "Veristar Corporation
//0004A4 NetEnabled, Inc.
//000416, "Parks S/A Comunicacoes Digitais
//00040F, "Asus Network Technologies, Inc.
//00040A Sage Systems
//000404, "Makino Milling Machine Co., Ltd.
//0003D0, "KOANKEISO Co., Ltd.
//0003CF Muxcom, Inc.
//0003D1, "Takaya Corporation
//0003AD Emerson Energy Systems AB
//0003A7 Unixtar Technology, Inc.
//0003AE Allied Advanced Manufacturing Pte, Ltd.
//0003A3 MAVIX, Ltd.
//0003B6 QSI Corporation
//0003B1 Hospira Inc.
//0003B3 IA Link Systems Co., Ltd.
//0003EB Atrica
//0003E7, "Logostek Co. Ltd.
//0003E3, "Cisco Systems, Inc
//0003F4, "NetBurner
//0003F2, "Seneca Networks
//0003F0, "Redfern Broadband Networks
//0003DB Apogee Electronics Corp.
//0003D2, "Crossbeam Systems, Inc.
//000405, "ACN Technologies
//000401, "Osaki Electric Co., Ltd.
//00041B Bridgeworks Ltd.
//0003A1 HIPER Information & Communication, Inc.
//000396, "EZ Cast Co., Ltd.
//00039A SiConnect
//000363, "Miraesys Co., Ltd.
//00035F, "Prüftechnik Condition Monitoring GmbH & Co.KG
//000360, "PAC Interactive Technology, Inc.
//000361, "Widcomm, Inc.
//000394, "Connect One
//00038A America Online, Inc.
//00038D, "PCS Revenue Control Systems, Inc.
//000388, "Fastfame Technology Co., Ltd.
//000359, "DigitalSis
//000352, "Colubris Networks
//00034C Shanghai DigiVision Technology Co., Ltd.
//000378, "HUMAX Co., Ltd.
//000374, "Control Microsystems
//000376, "Graphtec Technology, Inc.
//00037E, "PORTech Communications, Inc.
//00036D, "Runtop, Inc.
//00036E, "Nicon Systems (Pty) Limited
//000371, "Acomz Networks Corp.
//000349, "Vidicode Datacommunicatie B.V.
//00033E, "Tateyama System Laboratory Co., Ltd.
//00033C Daiden Co., Ltd.
//000325, "Arima Computer Corp.
//00031F, "Condev Ltd.
//00029F, "L-3 Communication Aviation Recorders
//00031B Cellvision Systems, Inc.
//00031C Svenska Hardvarufabriken AB
//0001A8 Welltech Computer Co., Ltd.
//00030C Telesoft Technologies Ltd.
//000308, "AM Communications, Inc.
//000307, "Secure Works, Inc.
//000306, "Fusion In Tech Co., Ltd.
//0002FC Cisco Systems, Inc
//0002FA DX Antenna Co., Ltd.
//0002FB Baumuller Aulugen-Systemtechnik GmbH
//0002F6, "Equipe Communications
//000223, "ClickTV
//0002CB TriState Ltd.
//0002CA EndPoints, Inc.
//00032A UniData Communication Systems, Inc.
//000324, "SANYO Consumer Electronics Co., Ltd.
//0002C4 Vector International BVBA
//0002BF dotRocket, Inc.
//000317, "Merlin Systems, Inc.
//000318, "Cyras Systems, Inc.
//0002E3, "LITE-ON Communications, Inc.
//0002DD Bromax Communications, Ltd.
//000247, "Great Dragon Information Technology (Group) Co., Ltd.
//000243, "Raysis Co., Ltd.
//000231, "Ingersoll-Rand
//000266, "Thermalogic Corporation
//000268, "Harris Government Communications
//00025E, "High Technology Ltd
//000260, "Accordion Networks, Inc.
//000283, "Spectrum Controls, Inc.
//000284, "UK Grid Solutions Limited
//000280, "Mu Net, Inc.
//009064, "Thomson Inc.
//00027A IOI Technology Corporation
//000274, "Tommy Technologies Corp.
//00029E, "Information Equipment Co., Ltd.
//00029B Kreatel Communications AB
//000295, "IP.Access Limited
//000272, "CC&C Technologies, Inc.
//00026D, "Adept Telecom
//00026B BCM Computers Co., Ltd.
//000293, "Solid Data Systems
//000289, "DNE Technologies
//00012F, "Twinhead International Corp
//0002A7 Vivace Networks
//0001B2 Digital Processing Systems, Inc.
//0001B8 Netsensity, Inc.
//0001B9 SKF (U.K.) Limited
//0001B3 Precision Electronic Manufacturing
//0001BD Peterson Electro-Musical Products, Inc.
//000209, "Shenzhen SED Information Technology Co., Ltd.
//000202, "Amino Communications, Ltd.
//000201, "IFM Electronic gmbh
//000234, "Imperial Technology, Inc.
//000236, "INIT GmbH
//00022B SAXA, Inc.
//000224, "C-COR
//00021F, "Aculab PLC
//00021A Zuma Networks
//0001CA Geocast Network Systems, Inc.
//0001D1, "CoNet Communications, Inc.
//000222, "Chromisys, Inc.
//000213, "S.D.E.L.
//0001DB Freecom Technologies GmbH
//0001DF ISDN Communications, Ltd.
//0001EF, "Camtel Technology Corp.
//00020A Gefran Spa
//000206, "Telital R&D Denmark A/S
//000179, "WIRELESS TECHNOLOGY, INC.
//000160, "ELMEX Co., LTD.
//00014E, "WIN Enterprises, Inc.
//003073, "International Microsystems, In
//00303F, "TurboComm Tech Inc.
//000184, "SIEB & MEYER AG
//000195, "Sena Technologies, Inc.
//0001A4 Microlink Corporation
//00018E, "Logitec Corporation
//00016D, "CarrierComm Inc.
//00016F, "Inkel Corp.
//000170, "ESE Embedded System Engineer'g
//00016A ALITEC
//000153, "ARCHTEK TELECOM CORPORATION
//000135, "KDC Corp.
//000141, "CABLE PRINT
//000165, "AirSwitch Corporation
//000156, "FIREWIREDIRECT.COM, INC.
//0001B7 Centos, Inc.
//0001B5 Turin Networks, Inc.
//000183, "ANITE TELECOMS
//00017E, "ADTEK System Science Co., Ltd.
//00010C System Talks Inc.
//000111, "iDigm Inc.
//000107, "Leiser GmbH
//000114, "KANDA TSUSHIN KOGYO CO., LTD.
//00B0F5 NetWorth Technologies, Inc.
//00B0DB Nextcell, Inc.
//00B0AE Symmetricom
//00B0E7 British Federal Ltd.
//00B08E Cisco Systems, Inc
//00305C SMAR Laboratories Corp.
//003004, "LEADTEK RESEARCH INC.
//0030F9, "Sollae Systems Co., Ltd.
//000118, "EZ Digital Co., Ltd.
//00011C Universal Talkware Corporation
//000128, "EnjoyWeb, Inc.
//000146, "Tesco Controls, Inc.
//000149, "TDT AG
//000131, "Bosch Security Systems, Inc.
//0030BE City-Net Technology, Inc.
//003002, "Expand Networks
//003078, "Cisco Systems, Inc
//00B0EC EACEM
//00B0DF Starboard Storage Systems
//00010B Space CyberLink, Inc.
//00309C Timing Applications, Inc.
//00307E, "Redflex Communication Systems
//00304F, "PLANET Technology Corporation
//003022, "Fong Kai Industrial Co., Ltd.
//003070, "1Net Corporation
//0030F8, "Dynapro Systems, Inc.
//0030B7 Teletrol Systems, Inc.
//0030B3 San Valley Systems, Inc.
//003009, "Tachion Networks, Inc.
//00307A Advanced Technology & Systems
//003061, "MobyTEL
//003054, "CASTLENET TECHNOLOGY, INC.
//00300B mPHASE Technologies, Inc.
//00308F, "MICRILOR, Inc.
//003050, "Versa Technology
//0030C0 Lara Technology, Inc.
//003005, "Fujitsu Siemens Computers
//0030E0, "OXFORD SEMICONDUCTOR LTD.
//003064, "ADLINK TECHNOLOGY, INC.
//0030DB Mindready Solutions, Inc.
//0030E7, "CNF MOBILE SOLUTIONS, INC.
//0030B4 INTERSIL CORP.
//0030B1 TrunkNet
//003060, "Powerfile, Inc.
//0030A0 TYCO SUBMARINE SYSTEMS, LTD.
//003015, "CP CLARE CORP.
//00301F, "OPTICAL NETWORKS, INC.
//0030FA TELICA, INC.
//00304B ORBACOM SYSTEMS, INC.
//0030E9, "GMA COMMUNICATION MANUFACT'G
//0030A5 ACTIVE POWER
//003084, "ALLIED TELESYN INTERNAIONAL
//003043, "IDREAM TECHNOLOGIES, PTE.LTD.
//003000, "ALLWELL TECHNOLOGY CORP.
//003011, "HMS Industrial Networks
//003068, "CYBERNETICS TECH. CO., LTD.
//003091, "TAIWAN FIRST LINE ELEC. CORP.
//0030CD CONEXANT SYSTEMS, INC.
//00301A SMARTBRIDGES PTE.LTD.
//003029, "OPICOM
//003083, "Ivron Systems
//0030B6 Cisco Systems, Inc
//0030C7 Macromate Corp.
//0030E4, "CHIYODA SYSTEM RIKEN
//003066, "RFM
//003031, "LIGHTWAVE COMMUNICATIONS, INC.
//00D007, "MIC ASSOCIATES, INC.
//00D0FF Cisco Systems, Inc
//00D028, "Harmonic, Inc
//00D025, "XROSSTECH, INC.
//00D044, "ALIDIAN NETWORKS, INC.
//00305B Toko Inc.
//00D049, "IMPRESSTEK CO., LTD.
//00D05B ACROLOOP MOTION CONTROL
//00D042, "MAHLO GMBH & CO.UG
//00D031, "INDUSTRIAL LOGIC CORPORATION
//00D038, "FIVEMERE, LTD.
//00D0C6 THOMAS & BETTS CORP.
//00D077, "LUCENT TECHNOLOGIES
//00D03E, "ROCKETCHIPS, INC.
//00D093, "TQ - COMPONENTS GMBH
//00D03F, "AMERICAN COMMUNICATION
//00D0F7, "NEXT NETS CORPORATION
//00D06F, "KMC CONTROLS
//00D0FC GRANITE MICROSYSTEMS
//00D0A6 LANBIRD TECHNOLOGY CO., LTD.
//00D003, "COMDA ENTERPRISES CORP.
//00D0D2, "EPILOG CORPORATION
//00D0F9, "ACUTE COMMUNICATIONS CORP.
//00D0CE iSystem Labs
//00D018, "QWES.COM, INC.
//0001A7 UNEX TECHNOLOGY CORPORATION
//00D08C GENOA TECHNOLOGY, INC.
//00D059, "AMBIT MICROSYSTEMS CORP.
//00D0FD OPTIMA TELE.COM, INC.
//00D0A9 SHINANO KENSHI CO., LTD.
//00D0DD SUNRISE TELECOM, INC.
//00D0E6, "IBOND INC.
//00D0D1, "Sycamore Networks
//00D087, "MICROFIRST INC.
//00D080, "EXABYTE CORPORATION
//00D091, "SMARTSAN SYSTEMS, INC.
//00D04E, "LOGIBAG
//00D027, "APPLIED AUTOMATION, INC.
//00D072, "BROADLOGIC
//00D0E2, "MRT MICRO, INC.
//00D06A LINKUP SYSTEMS CORPORATION
//00D089, "DYNACOLOR, INC.
//00D02C CAMPBELL SCIENTIFIC, INC.
//00D0CD ATAN TECHNOLOGY INC.
//00D040, "SYSMATE CO., LTD.
//00D01A URMET", "TLC S.P.A.
//0050FF HAKKO ELECTRONICS CO., LTD.
//0050D2, "CMC Electronics Inc
//0050F9, "Sensormatic Electronics LLC
//005048, "INFOLIBRIA
//00504E, "SIERRA MONITOR CORP.
//0050F6, "PAN-INTERNATIONAL INDUSTRIAL CORP.
//00506C Beijer Electronics Products AB
//0050D7, "TELSTRAT
//005044, "ASACA CORPORATION
//0050E6, "HAKUSAN CORPORATION
//00503C TSINGHUA NOVEL ELECTRONICS
//005060, "TANDBERG TELECOM AS
//0050EE TEK DIGITEL CORPORATION
//005045, "RIOWORKS SOLUTIONS, INC.
//00502B GENRAD LTD.
//00502E, "CAMBEX CORPORATION
//00506E, "CORDER ENGINEERING CORPORATION
//00502C SOYO COMPUTER, INC.
//005077, "PROLIFIC TECHNOLOGY, INC.
//005033, "MAYAN NETWORKS
//00500E, "CHROMATIS NETWORKS, INC.
//00D0CC TECHNOLOGIES LYRE INC.
//0050EC OLICOM A/S
//0050C9 MASPRO DENKOH CORP.
//0050BB CMS TECHNOLOGIES
//005062, "KOUWELL ELECTRONICS CORP.", "**
//0050D5, "AD SYSTEMS CORP.
//0050F3, "GLOBAL NET INFORMATION CO., Ltd.
//0050BE FAST MULTIMEDIA AG
//00506F, "G-CONNECT
//0050F8, "ENTREGA TECHNOLOGIES, INC.
//005042, "SCI MANUFACTURING SINGAPORE PTE, LTD.
//0050C0 GATAN, INC.
//005051, "IWATSU ELECTRIC CO., LTD.
//00507D, "IFP
//005097, "MMC-EMBEDDED COMPUTERTECHNIK GmbH
//005010, "NovaNET Learning, Inc.
//00509A TAG ELECTRONIC SYSTEMS
//005022, "ZONET TECHNOLOGY, INC.
//005007, "SIEMENS TELECOMMUNICATION SYSTEMS LIMITED
//005040, "Panasonic Electric Works Co., Ltd.
//00501C JATOM SYSTEMS, INC.
//005092, "Rigaku Corporation Osaka Plant
//00507A XPEED, INC.
//005069, "PixStream Incorporated
//005068, "ELECTRONIC INDUSTRIES ASSOCIATION
//0050BC HAMMER STORAGE SOLUTIONS
//009071, "Applied Innovation Inc.
//0050EB ALPHA-TOP CORPORATION
//0050EF, "SPE Systemhaus GmbH
//005098, "GLOBALOOP, LTD.
//00504F, "OLENCOM ELECTRONICS
//0090FF TELLUS TECHNOLOGY INC.
//00903E, "N.V.PHILIPS INDUSTRIAL ACTIVITIES
//0090BA VALID NETWORKS, INC.
//009018, "ITO ELECTRIC INDUSTRY CO, LTD.
//0090CD ENT-EMPRESA NACIONAL DE TELECOMMUNICACOES, S.A.
//0090FB PORTWELL, INC.
//009094, "OSPREY TECHNOLOGIES, INC.
//0090B3 AGRANAT SYSTEMS
//00903C ATLANTIC NETWORK SYSTEMS
//00905D, "NETCOM SICHERHEITSTECHNIK GMBH
//0090D1, "LEICHU ENTERPRISE CO., LTD.
//009046, "DEXDYNE, LTD.
//0090DA DYNARC, INC.
//0090E0, "SYSTRAN CORP.
//0090D0, "Thomson Telecom Belgium
//00909B MARKEM-IMAJE
//009022, "IVEX
//009016, "ZAC
//0090A7 CLIENTEC CORPORATION
//009053, "DAEWOO ELECTRONICS CO., LTD.
//0090DC TECO INFORMATION SYSTEMS
//0090E2, "DISTRIBUTED PROCESSING TECHNOLOGY
//009085, "GOLDEN ENTERPRISES, INC.
//0090C7 ICOM INC.
//009035, "ALPHA TELECOM, INC.
//00900F, "KAWASAKI HEAVY INDUSTRIES, LTD
//0090EA ALPHA TECHNOLOGIES, INC.
//009077, "ADVANCED FIBRE COMMUNICATIONS
//009099, "ALLIED TELESIS, K.K.
//0010AD SOFTRONICS USB, INC.
//0010A7 UNEX TECHNOLOGY CORPORATION
//0010D5, "IMASDE CANARIAS, S.A.
//001055, "FUJITSU MICROELECTRONICS, INC.
//00907A Spectralink, Inc
//0090F0, "Harmonic Video Systems Ltd.
//009020, "PHILIPS ANALYTICAL X-RAY B.V.
//0010A3 OMNITRONIX, INC.
//00905C EDMI
//0090E3, "AVEX ELECTRONICS INC.
//0090A9 WESTERN DIGITAL
//0090F3, "ASPECT COMMUNICATIONS
//00904F, "ABB POWER T&D COMPANY, INC.
//009060, "SYSTEM CREATE CORP.
//009013, "SAMSAN CORP.
//001052, "METTLER-TOLEDO (ALBSTADT) GMBH
//00106B SONUS NETWORKS, INC.
//0010C3 CSI-CONTROL SYSTEMS
//009055, "PARKER HANNIFIN CORPORATION COMPUMOTOR DIVISION
//0010DD ENABLE SEMICONDUCTOR, INC.
//00102D, "HITACHI SOFTWARE ENGINEERING
//001033, "ACCESSLAN COMMUNICATIONS, INC.
//001012, "PROCESSOR SYSTEMS (I) PVT LTD
//001015, "OOmon Inc.
//001078, "NUERA COMMUNICATIONS, INC.
//00104F, "Oracle Corporation
//00107A AmbiCom, Inc.
//0010B9 MAXTOR CORP.
//00105D, "Draeger Medical
//001091, "NO WIRES NEEDED BV
//00101B CORNET TECHNOLOGY, INC.
//0010DC MICRO-STAR INTERNATIONAL CO., LTD.
//00100A WILLIAMS COMMUNICATIONS GROUP
//001032, "ALTA TECHNOLOGY
//001080, "METAWAVE COMMUNICATIONS
//0010F4, "Vertical Communications
//001077, "SAF DRIVE SYSTEMS, LTD.
//0010B3 NOKIA MULTIMEDIA TERMINALS
//00101E, "MATSUSHITA ELECTRONIC INSTRUMENTS CORP.
//00104D, "SURTEC INDUSTRIES, INC.
//001051, "CMICRO CORPORATION
//001037, "CYQ've Technology Co., Ltd.
//00E0BB NBX CORPORATION
//00E08A GEC AVERY, LTD.
//00E086, "Emerson Network Power, Avocent Division
//00E01B SPHERE COMMUNICATIONS, INC.
//00E059, "CONTROLLED ENVIRONMENTS, LTD.
//00E0C5 BCOM ELECTRONICS INC.
//00E0EE MAREL HF
//00E08E UTSTARCOM
//00E03F, "JATON CORPORATION
//00E0D4, "EXCELLENT COMPUTER
//00E07F, "LOGISTISTEM s.r.l.
//00E013, "EASTERN ELECTRONIC CO., LTD.
//00E0FD A-TREND TECHNOLOGY CO., LTD.
//00E0BD INTERFACE SYSTEMS, INC.
//00E06E FAR SYSTEMS S.p.A.
//00E06D, "COMPUWARE CORPORATION
//00E0EA INNOVAT COMMUNICATIONS, INC.
//00E064, "SAMSUNG ELECTRONICS
//00E0C9 AutomatedLogic Corporation
//00E038, "PROXIMA CORPORATION
//00E09C MII
//00E0E9 DATA LABS, INC.
//00E00C MOTOROLA
//00E00A DIBA, INC.
//00E0C4 HORNER ELECTRIC, INC.
//00E069, "JAYCOR
//00E0A4 ESAOTE S.p.A.
//00E0DE DATAX NV
//00E0A5 ComCore Semiconductor, Inc.
//00E015, "HEIWA CORPORATION
//00E0E8 GRETACODER Data Systems AG
//00E016, "RAPID CITY COMMUNICATIONS
//00E005, "TECHNICAL CORP.
//00E0C1 MEMOREX TELEX JAPAN, LTD.
//00E0A9 FUNAI ELECTRIC CO., LTD.
//00E084, "COMPULITE R&D
//00E096, "SHIMADZU CORPORATION
//00E017, "EXXACT GmbH
//00607F, "AURORA TECHNOLOGIES, INC.
//00E029, "STANDARD MICROSYSTEMS CORP.
//006074, "QSC LLC
//006076, "SCHLUMBERGER TECHNOLOGIES RETAIL PETROLEUM SYSTEMS
//0060A1 VPNet, Inc.
//006027, "Superior Modular Products
//0060BC KeunYoung Electronics & Communication Co., Ltd.
//0060A5 PERFORMANCE TELECOM CORP.
//006005, "FEEDBACK DATA LTD.
//00602E, "CYCLADES CORPORATION
//0060B6 LAND COMPUTER CO., LTD.
//00606C ARESCOM
//0060E3, "ARBIN INSTRUMENTS
//006071, "MIDAS LAB, INC.
//006061, "WHISTLE COMMUNICATIONS CORP.
//00601B MESA ELECTRONICS
//0060C5 ANCOT CORP.
//0060A9 GESYTEC MBH
//0060F2, "LASERGRAPHICS, INC.
//0060C3 NETVISION CORPORATION
//006029, "CARY PERIPHERALS INC.
//0060A8 TIDOMAT AB
//0060FC CONSERVATION THROUGH INNOVATION LTD.
//006018, "STELLAR ONE CORPORATION
//00600A SORD COMPUTER CORPORATION
//0060A4 GEW Technologies (PTY) Ltd
//006064, "NETCOMM LIMITED
//0060F9, "DIAMOND LANE COMMUNICATIONS
//0060EA StreamLogic
//006082, "NOVALINK TECHNOLOGIES, INC.
//0060E7, "RANDATA
//0060D9, "TRANSYS NETWORKS INC.
//00601F, "STALLION TECHNOLOGIES
//006054, "CONTROLWARE GMBH
//0060C2 MPL AG
//0060D4, "ELDAT COMMUNICATION LTD.
//00A04E VOELKER TECHNOLOGIES, INC.
//00A05A KOFAX IMAGE PRODUCTS
//00A052 STANILITE ELECTRONICS PTY. LTD
//00A05E MYRIAD LOGIC INC.
//00A095 ACACIA NETWORKS, INC.
//00A053 COMPACT DEVICES, INC.
//00A069 Symmetricom, Inc.
//00A07A ADVANCED PERIPHERALS TECHNOLOGIES, INC.
//00609B AstroNova, Inc
//0060DB NTP ELEKTRONIK A/S
//006052, "PERIPHERALS ENTERPRISE CO., Ltd.
//0060B2 PROCESS CONTROL CORP.
//006081, "TV/COM INTERNATIONAL
//00A005 DANIEL INSTRUMENTS, LTD.
//00A0F2 INFOTEK COMMUNICATIONS, INC.
//00A0DF STS TECHNOLOGIES, INC.
//00A094 COMSAT CORPORATION
//00A0EF LUCIDATA LTD.
//00A020 CITICORP/TTI
//00A0CE Ecessa
//00A028 CONNER PERIPHERALS
//00A09E ICTV
//00A099 K-NET LTD.
//00A0EC TRANSMITTON LTD.
//00A067 NETWORK SERVICES GROUP
//00A0E0 TENNYSON TECHNOLOGIES PTY LTD
//00A0FD SCITEX DIGITAL PRINTING, INC.
//00A00F Broadband Technologies
//00A002 LEEDS & NORTHRUP AUSTRALIA PTY LTD
//00A0E4 OPTIQUEST
//00A0EE NASHOBA NETWORKS
//00A0C3 UNICOMPUTER GMBH
//00A00A Airspan
//00A0E7 CENTRAL DATA CORPORATION
//00A080 Tattile SRL
//00A02B TRANSITIONS RESEARCH CORP.
//00A0E8 REUTERS HOLDINGS PLC
//00A008 NETCORP
//00A050 CYPRESS SEMICONDUCTOR
//00A0DD AZONIX CORPORATION
//00A075 MICRON TECHNOLOGY, INC.
//00A009 WHITETREE NETWORK
//00A00C KINGMAX TECHNOLOGY, INC.
//00A066 ISA CO., LTD.
//00A0AB NETCS INFORMATIONSTECHNIK GMBH
//00A0D8 SPECTRA - TEK
//00A0FA Marconi Communication GmbH
//00A0CB ARK TELECOMMUNICATIONS, INC.
//00A034 AXEL
//00A001 DRS Signal Solutions
//0020B2 GKD Gesellschaft Fur Kommunikation Und Datentechnik
//002052, "RAGULA SYSTEMS
//0020FC MATROX
//0020FE TOPWARE INC. / GRAND COMPUTER
//002073, "FUSION SYSTEMS CORPORATION
//002035, "IBM Corp
//00A017 J B M CORPORATION
//00A025 REDCOM LABS INC.
//00A0BB HILAN GMBH
//00A091 APPLICOM INTERNATIONAL
//00A0A5 TEKNOR MICROSYSTEME, INC.
//0020B7 NAMAQUA COMPUTERWARE
//0020E3, "MCD KENCOM CORPORATION
//002013, "DIVERSIFIED TECHNOLOGY, INC.
//0020AB MICRO INDUSTRIES CORP.
//00208D, "CMD TECHNOLOGY
//0020DD Cybertec Pty Ltd
//0020E6, "LIDKOPING MACHINE TOOLS AB
//00A0A2 DIGICOM S.P.A.
//002086, "MICROTECH ELECTRONICS LIMITED
//002023, "T.C.TECHNOLOGIES PTY. LTD
//00A054 Private
//00205A COMPUTER IDENTICS
//002000, "LEXMARK INTERNATIONAL, INC.
//00201D, "KATANA PRODUCTS
//002003, "PIXEL POWER LTD.
//002046, "CIPRICO, INC.
//00209B ERSAT ELECTRONIC GMBH
//00201C EXCEL, INC.
//00207F, "KYOEI SANGYO CO., LTD.
//0020C9 VICTRON BV
//002077, "KARDIOS SYSTEMS CORP.
//00207A WiSE Communications, Inc.
//00203E, "LogiCan Technologies, Inc.
//002058, "ALLIED SIGNAL INC.
//0020E1, "ALAMAR ELECTRONICS
//002026, "AMKLY SYSTEMS, INC.
//002065, "SUPERNET NETWORKING INC.
//00202A N.V.DZINE
//002083, "PRESTICOM INCORPORATED
//002019, "OHLER GMBH
//00209E, "BROWN'S OPERATING SYSTEM SERVICES, LTD.
//00208E, "CHEVIN SOFTWARE ENG.LTD.
//002097, "APPLIED SIGNAL TECHNOLOGY
//00C00B NORCONTROL A.S.
//0020B0 GATEWAY DEVICES, INC.
//00205B Kentrox, LLC
//0020F6, "NET TEK", "AND KARLNET, INC.
//0020C6 NECTEC
//002008, "CABLE & COMPUTER TECHNOLOGY
//0020D3, "OST (OUEST STANDARD TELEMATIQU
//00C00E PSITECH, INC.
//00C031 DESIGN RESEARCH SYSTEMS, INC.
//000701, "RACAL-DATACOM
//00C09C HIOKI E.E.CORPORATION
//00C0AA SILICON VALLEY COMPUTER
//00C066 DOCUPOINT, INC.
//00C02D FUJI PHOTO FILM CO., LTD.
//00C0F2 TRANSITION NETWORKS
//00C0BD INEX TECHNOLOGIES, INC.
//00C088 EKF ELEKTRONIK GMBH
//00C011 INTERACTIVE COMPUTING DEVICES
//00C03E FA. GEBR.HELLER GMBH
//00C0FD PROSUM
//00C014 TELEMATICS CALABASAS INT'L,INC
//00AA3C OLIVETTI TELECOM SPA (OLTECO)
//00C0C9 ELSAG BAILEY PROCESS
//00C048 BAY TECHNICAL ASSOCIATES
//00C076 I-DATA INTERNATIONAL A-S
//00C046 Blue Chip Technology Ltd
//00C097 ARCHIPEL SA
//00C004 JAPAN BUSINESS COMPUTER CO.LTD
//00C060 ID SCANDINAVIA AS
//0040CC SILCOM MANUF'G TECHNOLOGY INC.
//00C09E CACHE COMPUTERS, INC.
//00C0AC GAMBIT COMPUTER COMMUNICATIONS
//00C034 TRANSACTION NETWORK
//00C093 ALTA RESEARCH CORP.
//0040E7, "ARNOS INSTRUMENTS & COMPUTER
//004087, "UBITREX CORPORATION
//004007, "TELMAT INFORMATIQUE
//00407B SCIENTIFIC ATLANTA
//00402C ISIS DISTRIBUTED SYSTEMS, INC.
//00C0DF KYE Systems Corp.
//00C0F5 METACOMP, INC.
//00C091 JABIL CIRCUIT, INC.
//00C049 U.S.ROBOTICS, INC.
//00C09D DISTRIBUTED SYSTEMS INT'L, INC
//00C0E9 OAK SOLUTIONS, LTD.
//00C0C5 SID INFORMATICA
//00C051 ADVANCED INTEGRATION RESEARCH
//00C085 ELECTRONICS FOR IMAGING, INC.
//00C0B2 NORAND CORPORATION
//00C054 NETWORK PERIPHERALS, LTD.
//00C022 LASERMASTER TECHNOLOGIES, INC.
//00C025 DATAPRODUCTS CORPORATION
//0040CF STRAWBERRY TREE, INC.
//004077, "MAXTON TECHNOLOGY CORPORATION
//00C02C CENTRUM COMMUNICATIONS, INC.
//00C0FB ADVANCED TECHNOLOGY LABS
//00C02B GERLOFF GESELLSCHAFT FUR
//004074, "CABLE AND WIRELESS
//0040B8 IDEA ASSOCIATES
//0040E8, "CHARLES RIVER DATA SYSTEMS, INC
//0040C0 VISTA CONTROLS CORPORATION
//00C0A0 ADVANCE MICRO RESEARCH, INC.
//00C010 HIRAKAWA HEWTECH CORP.
//00C037 DYNATEM
//004083, "TDA INDUSTRIA DE PRODUTOS
//00405B FUNASSET LIMITED
//004073, "BASS ASSOCIATES
//00407D, "EXTENSION TECHNOLOGY CORP.
//0080D7, "Fantum Engineering
//00807A AITECH SYSTEMS LTD.
//0080DC PICKER INTERNATIONAL
//00404D, "TELECOMMUNICATIONS TECHNIQUES
//00400D, "LANNET DATA COMMUNICATIONS, LTD
//004019, "AEON SYSTEMS, INC.
//0040BE BOEING DEFENSE & SPACE
//00406E, "COROLLARY, INC.
//004076, "Sun Conversion Technologies
//004022, "KLEVER COMPUTERS, INC.
//0040BF CHANNEL SYSTEMS INTERN'L INC.
//00401E, "ICC
//00409A NETWORK EXPRESS, INC.
//004094, "SHOGRAPHICS, INC.
//004055, "METRONIX GMBH
//004027, "SMC MASSACHUSETTS, INC.
//00408B RAYLAN CORPORATION
//0040EF, "HYPERCOM, INC.
//004093, "PAXDATA NETWORKS LTD.
//004085, "SAAB INSTRUMENTS AB
//004023, "LOGIC CORPORATION
//0040A4 ROSE ELECTRONICS
//004008, "A PLUS INFO CORPORATION
//0040B5 VIDEO TECHNOLOGY COMPUTERS LTD
//004012, "WINDATA, INC.
//0040D5, "Sartorius Mechatronics T&H GmbH
//004010, "SONIC SYSTEMS, INC.
//0040CA FIRST INTERNAT'L COMPUTER, INC
//0040C4 KINKEI SYSTEM CORPORATION
//00405D, "STAR-TEK, INC.
//0040E2, "MESA RIDGE TECHNOLOGIES, INC.
//00408C AXIS COMMUNICATIONS AB
//004045, "TWINHEAD CORPORATION
//004028, "NETCOMM LIMITED
//0040DD HONG TECHNOLOGIES
//0040CB LANWAN TECHNOLOGIES
//0040B2 SYSTEMFORSCHUNG
//0040E6, "C.A.E.N.
//0040F0, "MicroBrain, Inc.
//004089, "MEIDENSHA CORPORATION
//004015, "ASCOM INFRASYS AG
//008095, "BASIC MERTON HANDELSGES.M.B.H.
//0080AE HUGHES NETWORK SYSTEMS
//00803A VARITYPER, INC.
//00801C NEWPORT SYSTEMS SOLUTIONS
//008056, "SPHINX Electronics GmbH & Co KG
//008031, "BASYS, CORP.
//0080DB GRAPHON CORPORATION
//008082, "PEP MODULAR COMPUTERS GMBH
//008039, "ALCATEL STC AUSTRALIA
//008023, "INTEGRATED BUSINESS NETWORKS
//00806B SCHMID TELECOMMUNICATION
//008059, "STANLEY ELECTRIC CO., LTD
//008041, "VEB KOMBINAT ROBOTRON
//008080, "DATAMEDIA CORPORATION
//00803F, "TATUNG COMPANY
//0080E6, "PEER NETWORKS, INC.
//0080E0, "XTP SYSTEMS, INC.
//008088, "VICTOR COMPANY OF JAPAN, LTD.
//0080D8, "NETWORK PERIPHERALS INC.
//00809E, "DATUS GMBH
//00802B INTEGRATED MARKETING CO
//008001, "PERIPHONICS CORPORATION
//008097, "CENTRALP AUTOMATISMES
//008071, "SAI TECHNOLOGY
//008098, "TDK CORPORATION
//0080CA NETCOM RESEARCH INCORPORATED
//0080D5, "CADRE TECHNOLOGIES
//00801B KODIAK TECHNOLOGY
//0080D3, "SHIVA CORP.
//0080B3 AVAL DATA CORPORATION
//0080E7, "Leonardo Tactical Systems.
//008020, "NETWORK PRODUCTS
//008070, "COMPUTADORAS MICRON
//008008, "DYNATECH COMPUTER SYSTEMS
//0000E4, "IN2 GROUPE INTERTECHNIQUE
//008013, "THOMAS-CONRAD CORPORATION
//00806E, "NIPPON STEEL CORPORATION
//008010, "COMMODORE INTERNATIONAL
//008047, "IN-NET CORP.
//008067, "SQUARE D COMPANY
//008045, "MATSUSHITA ELECTRIC IND.CO
//0080BF TAKAOKA ELECTRIC MFG. CO.LTD.
//0080F9, "HEURIKON CORPORATION
//0080A1 MICROTEST, INC.
//0080A9 CLEARPOINT RESEARCH
//008017, "PFU LIMITED
//0080F8, "MIZAR, INC.
//000014, "NETRONIX
//000072, "MINIWARE TECHNOLOGY
//0000A1 MARQUETTE ELECTRIC CO.
//0000F5, "DIAMOND SALES LIMITED
//00005C TELEMATICS INTERNATIONAL INC.
//0000AC CONWARE COMPUTER CONSULTING
//000094, "ASANTE TECHNOLOGIES
//000090, "MICROCOM
//000047, "NICOLET INSTRUMENTS CORP.
//000021, "SUREMAN COMP. & COMMUN.CORP.
//000030, "VG LABORATORY SYSTEMS LTD
//000035, "SPECTRAGRAPHICS CORPORATION
//000026, "SHA-KEN CO., LTD.
//0000B6 MICRO-MATIC RESEARCH
//000082, "LECTRA SYSTEMES SA
//00002B CRISP AUTOMATION, INC
//000051, "HOB ELECTRONIC GMBH & CO.KG
//0000A7 NETWORK COMPUTING DEVICES INC.
//000098, "CROSSCOMM CORPORATION
//0000C6 EON SYSTEMS
//000070, "HCL LIMITED
//00008F, "Raytheon
//0000F1, "MAGNA COMPUTER CORPORATION
//000054, "Schneider Electric
//000020, "DATAINDUSTRIER DIAB AB
//00007A DANA COMPUTER INC.
//000045, "FORD AEROSPACE & COMM.CORP.
//00009C ROLM MIL-SPEC COMPUTERS
//00007C AMPERE INCORPORATED
//000068, "ROSEMOUNT CONTROLS
//0000E9, "ISICAD, INC.
//00009F, "AMERISTAR TECHNOLOGIES INC.
//0000E3, "INTEGRATED MICRO PRODUCTS LTD
//0000AD BRUKER INSTRUMENTS INC.
//000074, "RICOH COMPANY LTD.
//000046, "OLIVETTI NORTH AMERICA
//00008D, "Cryptek Inc.
//00003B i Controls, Inc.
//0000B3 CIMLINC INCORPORATED
//0000D3, "WANG LABORATORIES INC.
//0000D0, "DEVELCON ELECTRONICS LTD.
//000093, "PROTEON INC.
//00008B INFOTRON
//080057, "Evans & Sutherland
//08005D, "GOULD INC.
//08005B VTA TECHNOLOGIES INC.
//080071, "MATRA (DSIE)
//08006C SUNTEK TECHNOLOGY INT'L
//080067, "ComDesign
//08008C NETWORK RESEARCH CORPORATION
//080081, "ASTECH INC.
//08002D, "LAN-TEC INC.
//00DD00 UNGERMANN-BASS INC.
//0000AA XEROX CORPORATION
//040AE0 XMIT AG COMPUTER NETWORKS
//080011, "TEKTRONIX INC.
//080026, "NORSK DATA A.S.
//080025, "CONTROL DATA
//100000, "Private
//0000D7, "DARTMOUTH COLLEGE
//AA0004 DIGITAL EQUIPMENT CORPORATION
//08000C MIKLYN DEVELOPMENT CO.
//00DD05 UNGERMANN-BASS INC.
//08001D, "ABLE COMMUNICATIONS INC.
//00DD0B UNGERMANN-BASS INC.
//080003, "ADVANCED COMPUTER COMM.
//00DD03 UNGERMANN-BASS INC.
//00DD0F UNGERMANN-BASS INC.
//000001, "XEROX CORPORATION
//080017, "NATIONAL SEMICONDUCTOR
//542160, "Alula
//10B3C6 Cisco Systems, Inc
//10B3D6 Cisco Systems, Inc
//589630, "Technicolor CH USA Inc.
//F854B8 Amazon Technologies Inc.
//781735, "Nokia Shanghai Bell Co., Ltd.
//3C894D Dr. Ing.h.c.F.Porsche AG
//84C807 ADVA Optical Networking Ltd.
//B43939 Shenzhen TINNO Mobile Technology Corp.
//5CCD5B Intel Corporate
//A0AB51", "WEIFANG GOERTEK ELECTRONICS CO., LTD
//64C901 INVENTEC Corporation
//749EF5, "Samsung Electronics Co., Ltd
//68BFC4 Samsung Electronics Co., Ltd
//A85E45", "ASUSTek COMPUTER INC.
//849A40 Hangzhou Hikvision Digital Technology Co., Ltd.
//04B1A1 Samsung Electronics Co., Ltd
//CC464E", "Samsung Electronics Co., Ltd
//F8893C", "Inventec Appliances Corp.
//A0DF15 HUAWEI TECHNOLOGIES CO., LTD
//C4AD34", "Routerboard.com
//306F07, "Nations Technologies Inc.
//2474F7, "GoPro
//7CD566 Amazon Technologies Inc.
//686350, "Hella India Automotive Pvt Ltd
//5CE50C Beijing Xiaomi Mobile Software Co., Ltd
//18703B Huawei Device Co., Ltd.
//D89E61 Huawei Device Co., Ltd.
//347E00, "Huawei Device Co., Ltd.
//003092, "Kontron Electronics AG
//80751F, "BSkyB Ltd
//E85A8B Xiaomi Communications Co Ltd
//442295, "China Mobile Iot Limited company
//98AF65 Intel Corporate
//5C710D Cisco Systems, Inc
//00AB48 eero inc.
//F855CD Visteon Corporation
//441847, "HUNAN SCROWN ELECTRONIC INFORMATION TECH.CO., LTD
//1CC1BC Yichip Microelectronics (Hangzhou) Co., Ltd
//AC61B9", "WAMA Technology Limited
//C4D8F3", "iZotope
//003056, "HMS Industrial Networks
//680AE2 Silicon Laboratories
//AC8B9C", "Primera Technology, Inc.
//2C3AFD AVM Audiovisuelles Marketing und Computersysteme GmbH
//34495B Sagemcom Broadband SAS
//C8F319 LG Electronics (Mobile Communications)
//801609, "Sleep Number
//045EA4 SHENZHEN NETIS TECHNOLOGY CO., LTD
//1CBFC0 CHONGQING FUGUI ELECTRONICS CO., LTD.
//78B46A HUAWEI TECHNOLOGIES CO., LTD
//6CEBB6 HUAWEI TECHNOLOGIES CO., LTD
//4CF55B HUAWEI TECHNOLOGIES CO., LTD
//E83F67", "Huawei Device Co., Ltd.
//3446EC Huawei Device Co., Ltd.
//643139, "IEEE Registration Authority
//A44BD5", "Xiaomi Communications Co Ltd
//64956C LG Electronics
//14876A Apple, Inc.
//E0B55F Apple, Inc.
//F8FFC2 Apple, Inc.
//E0EB40 Apple, Inc.
//40A6B7 Intel Corporate
//64694E, "Texas Instruments
//0C7A15 Intel Corporate
//94D6DB NexFi
//B4ECF2 Shanghai Listent Medical Tech Co., Ltd.
//18E777, "vivo Mobile Communication Co., Ltd.
//4077A9 New H3C Technologies Co., Ltd
//F83331", "Texas Instruments
//C4954D IEEE Registration Authority
//C49878 SHANGHAI MOAAN INTELLIGENT TECHNOLOGY CO., LTD
//6C639C ARRIS Group, Inc.
//5C2AEF r2p Asia-Pacific Pty Ltd
//A4BB6D", "Dell Inc.
//6C06D6 Huawei Device Co., Ltd.
//0C8E29 Arcadyan Corporation
//A0224E", "IEEE Registration Authority
//3027CF Private
//548D5A Intel Corporate
//3843E5, "Grotech Inc
//CC593E Sensium Healthcare Limited
//5C68D0 Aurora Innovation Inc.
//10364A Boston Dynamics
//00B810 Yichip Microelectronics (Hangzhou) Co., Ltd
//A4B239", "Cisco Systems, Inc
//D8D5B9", "Rainforest Automation, Inc.
//001BB0 Bharat Electronics Limited
//58961D, "Intel Corporate
//68AFFF Shanghai Cambricon Information Technology Co., Ltd.
//DC21E2 HUAWEI TECHNOLOGIES CO., LTD
//FC1BD1", "HUAWEI TECHNOLOGIES CO., LTD
//582575, "HUAWEI TECHNOLOGIES CO., LTD
//28DEE5 HUAWEI TECHNOLOGIES CO., LTD
//D01C3C", "TECNO MOBILE LIMITED
//18C04D GIGA-BYTE TECHNOLOGY CO., LTD.
//8CAAB5 Espressif Inc.
//B89A2A Intel Corporate
//402C76 IEEE Registration Authority
//44C7FC Huawei Device Co., Ltd.
//7885F4, "Huawei Device Co., Ltd.
//F44955 MIMO TECH Co., Ltd.
//0809C7 Zhuhai Unitech Power Technology Co., Ltd.
//88541F, "Google, Inc.
//900CC8 Google, Inc.
//041DC7 zte corporation
//68215F, "Edgecore Networks Corporation
//3C28A6 Alcatel-Lucent Enterprise (China)
//5050A4 Samsung Electronics Co., Ltd
//8086D9, "Samsung Electronics Co., Ltd
//F417B8", "AirTies Wireless Networks
//3CBF60 Apple, Inc.
//AC15F4 Apple, Inc.
//386A77 Samsung Electronics Co., Ltd
//141459, "Vodafone Italia S.p.A.
//5043B9 OktoInform RUS
//5C27D4 Shenzhen Qihu Intelligent Technology Company Limited
//74D83E, "Intel Corporate
//08D23E, "Intel Corporate
//88A479 Apple, Inc.
//047295, "Apple, Inc.
//D446E1 Apple, Inc.
//78D162, "Apple, Inc.
//08F8BC Apple, Inc.
//90A25B Apple, Inc.
//18300C Hisense Electric Co., Ltd
//487B5E Social Mobile
//44A56E NETGEAR
//1C919D Dongguan Liesheng Electronic Co., Ltd.
//FCF29F China Mobile Iot Limited company
//F81F32 Motorola Mobility LLC, a Lenovo Company
//B00AD5", "zte corporation
//A87EEA Intel Corporate
//20114E, "MeteRSit S.R.L.
//2C5741 Cisco Systems, Inc
//A84D4A", "Audiowise Technology Inc.
//7894E8, "Radio Bridge
//484EFC ARRIS Group, Inc.
//B0B353 IEEE Registration Authority
//547FBC iodyne
//7CDFA1 Espressif Inc.
//98006A zte corporation
//002674, "Hunter Douglas
//1C97C5 Ynomia Pty Ltd
//5CC1D7 Samsung Electronics Co., Ltd
//380146, "SHENZHEN BILIAN ELECTRONIC CO.，LTD
//889655, "Zitte corporation
//F4A4D6 HUAWEI TECHNOLOGIES CO., LTD
//FCE14F", "BRK Brands, Inc.
//74B6B6 eero inc.
//EC97B2 SUMEC Machinery & Electric Co., Ltd.
//28FA7A Zhejiang Tmall Technology Co., Ltd.
//842E14, "Silicon Laboratories
//1005E1, "Nokia
//08F458, "Huawei Device Co., Ltd.
//5CBA2C Hewlett Packard Enterprise
//343794, "Hamee Corp.
//40EC99 Intel Corporate
//6CD94C vivo Mobile Communication Co., Ltd.
//EC316D Hansgrohe
//BC542F Intel Corporate
//4410FE Huizhou Foryou General Electronics Co., Ltd.
//7CAB60 Apple, Inc.
//44C65D Apple, Inc.
//187EB9 Apple, Inc.
//4CA64D Cisco Systems, Inc
//CC7F75", "Cisco Systems, Inc
//20E874, "Apple, Inc.
//D03FAA Apple, Inc.
//0CB937 Ubee Interactive Co., Limited
//D4DC09", "Mist Systems, Inc.
//0088BA NC&C
//AC1ED0", "Temic Automotive Philippines Inc.
//DC35F1 Positivo Tecnologia S.A.
//E8E98E SOLAR controls s.r.o.
//64F6BB Fibocom Wireless Inc.
//A40801 Amazon Technologies Inc.
//402B69 Kumho Electric Inc.
//848094, "Meter, Inc.
//10B3D5 Cisco Systems, Inc
//30A2C2 Huawei Device Co., Ltd.
//DCDFD6 zte corporation
//ACA88E", "SHARP Corporation
//98415C Nintendo Co., Ltd
//F04F7C", "Private
//705425, "ARRIS Group, Inc.
//5C0BCA Tunstall Nordic AB
//283334, "Huawei Device Co., Ltd.
//F0A225 Private
//50A132 Shenzhen MiaoMing Intelligent Technology Co., Ltd
//807871, "ASKEY COMPUTER CORP
//4CB1CD Ruckus Wireless
//F49C12", "Structab AB
//88517A HMD Global Oy
//ACB3B5 HUAWEI TECHNOLOGIES CO., LTD
//083A88 Universal Global Scientific Industrial Co., Ltd.
//08318B HUAWEI TECHNOLOGIES CO., LTD
//F4B688", "PLANTRONICS, INC.
//4C7A48 Nippon Seiki (Europe) B.V.
//84D15A TCT mobile ltd
//047F0E, "Barrot Technology Limited
//B8F653", "Shenzhen Jingxun Software Telecommunication Technology Co., Ltd
//60AB14 LG Innotek
//BC62D2", "Genexis International B.V.
//6C9E7C Fiberhome Telecommunication Technologies Co., LTD
//BCBAC2", "Hangzhou Hikvision Digital Technology Co., Ltd.
//44D5F2, "IEEE Registration Authority
//0CDD24 Intel Corporate
//000C86 Cisco Systems, Inc
//F83CBF", "BOTATO ELECTRONICS SDN BHD
//FC589A Cisco Systems, Inc
//F08620", "Arcadyan Corporation
//DCCC8D Integrated Device Technology (Malaysia) Sdn. Bhd.
//F05C77 Google, Inc.
//111111, "Private
//6CD71F GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//F06865", "Taicang T&W Electronics
//A463A1 Inventus Power Eletronica do Brasil LTDA
//3C9D56 HUAWEI TECHNOLOGIES CO., LTD
//70FD45 HUAWEI TECHNOLOGIES CO., LTD
//446747, "HUAWEI TECHNOLOGIES CO., LTD
//884A70 Wacom Co., Ltd.
//F4B5BB CERAGON NETWORKS
//507AC5 Apple, Inc.
//4C6BE8 Apple, Inc.
//8C861E Apple, Inc.
//542B8D Apple, Inc.
//001D29, "Doro AB
//ECA5DE ONYX WIFI Inc
//8C4962 Roku, Inc
//1033BF Technicolor CH USA Inc.
//347563, "SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//142E5E Sercomm Corporation.
//0025CB Reiner SCT
//44237C Beijing Xiaomi Mobile Software Co., Ltd
//50EB71 Intel Corporate
//C064E4", "Cisco Systems, Inc
//50804A Quectel Wireless Solutions Co., Ltd.
//309435, "vivo Mobile Communication Co., Ltd.
//D44BB6 Zhejiang Tmall Technology Co., Ltd.
//38184C Sony Home Entertainment&Sound Products Inc
//D82FE6", "Zhejiang Tmall Technology Co., Ltd.
//140F42, "Nokia
//006D61, "Guangzhou V-SOLUTION Electronic Technology Co., Ltd.
//C4AC59 Murata Manufacturing Co., Ltd.
//5816D7, "ALPS ELECTRIC CO., LTD.
//FCA47A IEEE Registration Authority
//E419C1 HUAWEI TECHNOLOGIES CO., LTD
//B86685", "Sagemcom Broadband SAS
//381A52 Seiko Epson Corporation
//000A17 NESTAR COMMUNICATIONS, INC
//D8AF81", "ZAO NPK Rotek
//E4FDA1", "HUAWEI TECHNOLOGIES CO., LTD
//B452A9", "Texas Instruments
//54EF44, "Lumi United Technology Co., Ltd
//402B50 ARRIS Group, Inc.
//78CC2B SINEWY TECHNOLOGY CO., LTD
//B80756", "Cisco Meraki
//D0C857 IEEE Registration Authority
//FCBCD1 HUAWEI TECHNOLOGIES CO., LTD
//7460FA HUAWEI TECHNOLOGIES CO., LTD
//CC3ADF", "Private
//38EFE3 INGENICO TERMINALS SAS
//50D4F7, "TP-LINK TECHNOLOGIES CO., LTD.
//5C879C Intel Corporate
//24EE9A Intel Corporate
//001F47, "MCS Logic Inc.
//8CFD18 HUAWEI TECHNOLOGIES CO., LTD
//B45459", "China Mobile (Hangzhou) Information Technology Co., Ltd.
//000970, "Vibration Research Corporation
//14A2A0 Cisco Systems, Inc
//E4AB89", "MitraStar Technology Corp.
//78C313 China Mobile Group Device Co., Ltd.
//7434AE", "this is engineering Inc.
//74ADB7 China Mobile Group Device Co., Ltd.
//6095CE IEEE Registration Authority
//8CE5C0 Samsung Electronics Co., Ltd
//F08A76", "Samsung Electronics Co., Ltd
//ECAA25", "Samsung Electronics Co., Ltd
//687D6B Samsung Electronics Co., Ltd
//485169, "Samsung Electronics Co., Ltd
//C40683", "HUAWEI TECHNOLOGIES CO., LTD
//94D00D, "HUAWEI TECHNOLOGIES CO., LTD
//C48A5A", "JFCONTROL
//B49A95", "Shenzhen Boomtech Industrial Corporation
//AC83E9 Beijing Zile Technology Co., Ltd
//D8CA06", "Titan DataCenters France
//1C20DB HUAWEI TECHNOLOGIES CO., LTD
//D0C65B", "HUAWEI TECHNOLOGIES CO., LTD
//9078B2 Xiaomi Communications Co Ltd
//B4CFE0", "Sichuan tianyi kanghe communications co., LTD
//BC7FA4", "Xiaomi Communications Co Ltd
//FC492D Amazon Technologies Inc.
//74EE2A SHENZHEN BILIAN ELECTRONIC CO.，LTD
//087E64, "Technicolor CH USA Inc.
//080039, "SPIDER SYSTEMS LIMITED
//90473C China Mobile Group Device Co., Ltd.
//889E33, "TCT mobile ltd
//6C8AEC Nantong Coship Electronics Co., Ltd.
//84C2E4 Jiangsu Qinheng Co., Ltd.
//7C21D8 Shenzhen Think Will Communication Technology co., LTD.
//FCEA50 Integrated Device Technology (Malaysia) Sdn. Bhd.
//00E06B W&G SPECIAL PRODUCTS
//045C6C Juniper Networks
//D8F15B", "Espressif Inc.
//D4F057 Nintendo Co., Ltd
//6CF17E Zhejiang Uniview Technologies Co., Ltd.
//083A2F Guangzhou Juan Intelligent Tech Joint Stock Co., Ltd
//1C3A60 Ruckus Wireless
//D4351D", "Technicolor
//6009C3 u-blox AG
//488764, "vivo Mobile Communication Co., Ltd.
//5C1CB9 vivo Mobile Communication Co., Ltd.
//C0FD84 zte corporation
//444B7E Fiberhome Telecommunication Technologies Co., LTD
//DC8C37", "Cisco Systems, Inc
//E8D0FC", "Liteon Technology Corporation
//E8E8B7", "Murata Manufacturing Co., Ltd.
//103D3E, "China Mobile Group Device Co., Ltd.
//7C50DA Private
//64CC22 Arcadyan Corporation
//4C9157 Fujian LANDI Commercial Equipment Co., Ltd
//9C25BE Wildlife Acoustics, Inc.
//D039EA NetApp
//F8DFE1 MyLight Systems
//60D2DD Shenzhen Baitong Putian Technology Co., Ltd.
//788C77 LEXMARK INTERNATIONAL, INC.
//3C0C7D Tiny Mesh AS
//3476C5 I-O DATA DEVICE, INC.
//24DA33 HUAWEI TECHNOLOGIES CO., LTD
//FCAB90", "HUAWEI TECHNOLOGIES CO., LTD
//5893D8, "Texas Instruments
//5051A9 Texas Instruments
//988B0A Hangzhou Hikvision Digital Technology Co., Ltd.
//A4975C VTech Telecommunications Ltd.
//B02A1F Wingtech Group (HongKong）Limited
//DC680C", "Hewlett Packard Enterprise
//F40270", "Dell Inc.
//1C2704 zte corporation
//5078B3 zte corporation
//F0D4F7", "varram system
//E0CC7A HUAWEI TECHNOLOGIES CO., LTD
//6C23CB Wattty Corporation
//60AB67 Xiaomi Communications Co Ltd
//AC710C", "China Mobile Group Device Co., Ltd.
//A8DB03 SAMSUNG ELECTRO-MECHANICS(THAILAND)
//308944, "DEVA Broadcast Ltd.
//F47960 HUAWEI TECHNOLOGIES CO., LTD
//145290, "KNS Group LLC (YADRO Company)
//5C32C5 Teracom Ltd.
//ACEE70 Fontem Ventures BV
//ACE2D3 Hewlett Packard
//00FD22 Cisco Systems, Inc
//4418FD Apple, Inc.
//00B600 VOIM Co., Ltd.
//98FA9B LCFC(HeFei) Electronics Technology co., ltd
//005B94 Apple, Inc.
//E0897E Apple, Inc.
//B00CD1 Hewlett Packard
//4846C1 FN-LINK TECHNOLOGY LIMITED
//B4D0A9", "China Mobile Group Device Co., Ltd.
//FC29F3 McPay Co., LTD.
//F8AFDB Fiberhome Telecommunication Technologies Co., LTD
//4889E7, "Intel Corporate
//A0BD1D Zhejiang Dahua Technology Co., Ltd.
//E49F1E ARRIS Group, Inc.
//002615, "Teracom Limited
//9C8EDC Teracom Limited
//000191, "SYRED Data Systems
//ACD564", "CHONGQING FUGUI ELECTRONICS CO., LTD.
//94D075, "CIS Crypto
//28B4FB Sprocomm Technologies CO., LTD.
//40F9D5, "Tecore Networks
//CC2C83 DarkMatter L.L.C
//DCED84", "Haverford Systems Inc
//644C36 Intel Corporate
//7C573C Aruba, a Hewlett Packard Enterprise Company
//2C01B5 Cisco Systems, Inc
//28EF01, "Private
//C05336", "Beijing National Railway Research & Design Institute of Signal & Communication Group Co..Ltd.
//606ED0, "SEAL AG
//2CCCE6 Skyworth Digital Technology(Shenzhen) Co., Ltd
//E44CC7", "IEEE Registration Authority
//D4E880", "Cisco Systems, Inc
//A8346A", "Samsung Electronics Co., Ltd
//3C20F6 Samsung Electronics Co., Ltd
//7C38AD Samsung Electronics Co., Ltd
//D49CDD", "AMPAK Technology, Inc.
//50F722, "Cisco Systems, Inc
//9849E1, "Boeing Defence Australia
//04D7A5 New H3C Technologies Co., Ltd
//4C4D66 Nanjing Jiahao Technology Co., Ltd.
//A4817A CIG SHANGHAI CO LTD
//905851, "Technicolor CH USA Inc.
//9809CF OnePlus Technology (Shenzhen) Co., Ltd
//B8DE5E", "LONGCHEER TELECOMMUNICATION LIMITED
//885A06 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//5447D3, "TSAT AS
//CCEDDC MitraStar Technology Corp.
//3CF011 Intel Corporate
//CCD81F", "Maipu Communication Technology Co., Ltd.
//688B0F China Mobile IOT Company Limited
//F82F6A ITEL MOBILE LIMITED
//B068E6 CHONGQING FUGUI ELECTRONICS CO., LTD.
//A4E7E4 Connex GmbH
//B8EF8B", "SHENZHEN CANNICE TECHNOLOGY CO., LTD
//B8186F", "ORIENTAL MOTOR CO., LTD.
//001A3F Intelbras
//C0D834 xvtec ltd
//B8C253", "Juniper Networks
//F05C19 Aruba, a Hewlett Packard Enterprise Company
//04BD88 Aruba, a Hewlett Packard Enterprise Company
//9C1C12 Aruba, a Hewlett Packard Enterprise Company
//18DFB4 BOSUNG POWERTEC CO., LTD.
//000147, "Zhone Technologies
//20B780 Toshiba Visual Solutions Corporation Co., Ltd
//E03717", "Technicolor CH USA Inc.
//14D4FE ARRIS Group, Inc.
//304F75, "DASAN Network Solutions
//ECA9FA", "GUANGDONG GENIUS TECHNOLOGY CO., LTD.
//0003A5 Medea Corporation
//BCE67C", "Cambium Networks Limited
//7C1E06 New H3C Technologies Co., Ltd
//F0B31E", "Universal Electronics, Inc.
//F89173 AEDLE SAS
//C84F86", "Sophos Ltd
//6429ED, "AO PKK Milandr
//443C88 FICOSA MAROC INTERNATIONAL
//841C70 zte corporation
//544741, "XCHENG HOLDING
//CCF735 Amazon Technologies Inc.
//C4F839 Actia Automotive
//C8F742", "HangZhou Gubei Electronics Technology Co., Ltd
//006FF2 MITSUMI ELECTRIC CO., LTD.
//30DF8D SHENZHEN GONGJIN ELECTRONICS CO., LT
//D4C93C", "Cisco Systems, Inc
//78DD12 Arcadyan Corporation
//2C5D34 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//9C1463 Zhejiang Dahua Technology Co., Ltd.
//002433, "ALPS ELECTRIC CO., LTD.
//002306, "ALPS ELECTRIC CO., LTD.
//B4EC02 ALPS ELECTRIC CO., LTD.
//646038, "Hirschmann Automation and Control GmbH
//7018A7 Cisco Systems, Inc
//CCD39D", "IEEE Registration Authority
//E0750A", "ALPS ELECTRIC CO., LTD.
//0019C1 ALPS ELECTRIC CO., LTD.
//0016FE ALPS ELECTRIC CO., LTD.
//9C8D7C ALPS ELECTRIC CO., LTD.
//D425CC IEEE Registration Authority
//8C6DC4 Megapixel VR
//BC7536", "ALPS ELECTRIC CO., LTD.
//E0AE5E ALPS ELECTRIC CO., LTD.
//D4B761 Sichuan AI-Link Technology Co., Ltd.
//7C035E Xiaomi Communications Co Ltd
//44FE3B Arcadyan Corporation
//D83AF5", "Wideband Labs LLC
//38D9A5 Mikotek Information Inc.
//4C875D Bose Corporation
//982CBC Intel Corporate
//B0E7DE", "Homa Technologies JSC
//649D99, "FS COM INC
//00169D, "Cisco Systems, Inc
//4C962D Fresh AB
//00D279, "VINGROUP JOINT STOCK COMPANY
//484A30 George Robotics Limited
//4861A3 Concern Axion JSC
//304A26 Shenzhen Trolink Technology CO, LTD
//4CE5AE Tianjin Beebox Intelligent Technology Co., Ltd.
//E4D3AA FUJITSU CONNECTED TECHNOLOGIES LIMITED
//D467D3", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//A41232", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//48E3C3 JENOPTIK Advanced Systems GmbH
//CC355A", "SecuGen Corporation
//80546A SHENZHEN GONGJIN ELECTRONICS CO., LT
//B447F5", "Earda Technologies co Ltd
//F4C7C8 Kelvin Inc.
//A89CA4 Furrion Limited
//00004C NEC Corporation
//8CCF8F ITC Systems
//2875D8, "FUJIAN STAR-NET COMMUNICATION CO., LTD
//90E202, "Texas Instruments
//302478, "Sagemcom Broadband SAS
//7C89C1 Palo Alto Networks
//84A93E Hewlett Packard
//B0C387", "GOEFER, Inc.
//086BD7 Silicon Laboratories
//349342, "TTE Corporation
//589EC6 Gigaset Communications GmbH
//64C753 Apple, Inc.
//6458AD China Mobile IOT Company Limited
//1CF29A Google, Inc.
//748A0D ARRIS Group, Inc.
//CC75E2 ARRIS Group, Inc.
//A0A3B8 WISCLOUD
//38F9D3, "Apple, Inc.
//FC183C Apple, Inc.
//A40C66 Shenzhen Colorful Yugong Technology and Development Co., Ltd.
//4455B1 HUAWEI TECHNOLOGIES CO., LTD
//98F9C7 IEEE Registration Authority
//FC7774 Intel Corporate
//700B4F Cisco Systems, Inc
//E4388C", "Digital Products Limited
//184BDF Caavo Inc
//B89A9A", "Xin Shi Jia Technology (Beijing) Co., Ltd
//8C7BF0 Xufeng Development Limited
//E0A509 Bitmain Technologies Inc
//3C5CC4 Amazon Technologies Inc.
//D8A756 Sagemcom Broadband SAS
//D8D6F3 Integrated Device Technology (Malaysia) Sdn. Bhd.
//6C2CDC Skyworth Digital Technology(Shenzhen) Co., Ltd
//7835A0 Zurn Industries LLC
//F43909 Hewlett Packard
//201F31, "Inteno Broadband Technology AB
//2CCC44 Sony Interactive Entertainment Inc.
//F47DEF Samsung Electronics Co., Ltd
//7C8BB5 Samsung Electronics Co., Ltd
//54833A Zyxel Communications Corporation
//98ED5C Tesla Motors, Inc
//787052, "Welotec GmbH
//D8A98B Texas Instruments
//00116C Nanwang Multimedia Inc., Ltd
//10B9F7 Niko-Servodan
//14EFCF SCHREDER
//3830F9, "LG Electronics (Mobile Communications)
//A83FA1", "IEEE Registration Authority
//7847E3, "SICHUAN TIANYI COMHEART TELECOM CO., LTD
//6C9BC0 Chemoptics Inc.
//F4DBE6 Cisco Systems, Inc
//248498, "Beijing Jiaoda Microunion Tech.Co., Ltd.
//C074AD Grandstream Networks, Inc.
//F095F1 Carl Zeiss AG
//00F48D, "Liteon Technology Corporation
//702ED9, "Guangzhou Shiyuan Electronics Co., Ltd.
//70192F, "HUAWEI TECHNOLOGIES CO., LTD
//10C22F China Entropy Co., Ltd.
//BC3865 JWCNETWORKS
//04EB40 Cisco Systems, Inc
//18A7F1 Qingdao Haier Technology Co., Ltd
//90E17B Apple, Inc.
//D81C79 Apple, Inc.
//58E6BA Apple, Inc.
//44E4EE Wistron Neweb Corporation
//DC41E5 Shenzhen Zhixin Data Service Co., Ltd.
//00A5BF Cisco Systems, Inc
//C8BAE9", "QDIS
//1801F1, "Xiaomi Communications Co Ltd
//C44F33 Espressif Inc.
//546AD8 Elster Water Metering
//C0847D AMPAK Technology, Inc.
//0409A5 HFR, Inc.
//94917F, "ASKEY COMPUTER CORP
//9C0CDF GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//242124, "Nokia
//949B2C Extreme Networks, Inc.
//7CD30A INVENTEC CORPORATION
//001E33, "INVENTEC CORPORATION
//FC1D84 Autobase
//18AC9E ITEL MOBILE LIMITED
//EC84B4 CIG SHANGHAI CO LTD
//00D096, "3COM EUROPE LTD
//002654, "3COM
//0050DA", "3COM
//000476, "3COM
//000475, "3COM
//4422F1, "S.FAC, INC
//3009F9, "IEEE Registration Authority
//B4DDD0", "Continental Automotive Hungary Kft
//48F027, "Chengdu newifi Co., Ltd
//14C697 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//7C03AB Xiaomi Communications Co Ltd
//DC16B2", "HUAWEI TECHNOLOGIES CO., LTD
//24FB65 HUAWEI TECHNOLOGIES CO., LTD
//0CB527 HUAWEI TECHNOLOGIES CO., LTD
//B42E99", "GIGA-BYTE TECHNOLOGY CO., LTD.
//342CC4 Compal Broadband Networks, Inc.
//14E9B2 Fiberhome Telecommunication Technologies Co., LTD
//C8544B", "Zyxel Communications Corporation
//D07FA0", "Samsung Electronics Co., Ltd
//009093, "EIZO Corporation
//4C1159 Vision Information & Communications
//00049F, "Freescale Semiconductor
//00D07B COMCAM INTERNATIONAL INC
//78524A Ensenso GmbH
//E4FC82", "Juniper Networks
//00B5D0 Samsung Electronics Co., Ltd
//1496E5, "Samsung Electronics Co., Ltd
//C46E7B", "SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//C048FB Shenzhen JingHanDa Electronics Co.Ltd
//20E882, "zte corporation
//F09FFC SHARP Corporation
//0CB5DE Alcatel Lucent
//000B3B devolo AG
//240588, "Google, Inc.
//50DCFC ECOCOM
//700B01 Sagemcom Broadband SAS
//5C2623 WaveLynx Technologies Corporation
//303855, "Nokia Corporation
//00B670 Cisco Systems, Inc
//AC6417", "Siemens AG
//347916, "HUAWEI TECHNOLOGIES CO., LTD
//3466EA VERTU INTERNATIONAL CORPORATION LIMITED
//28385C FLEXTRONICS
//0C1C57 Texas Instruments
//806FB0 Texas Instruments
//883F99, "Siemens AG
//EC6F0B FADU, Inc.
//0006EC Harris Corporation
//00BB60 Intel Corporate
//7C6DA6 Superwave Group LLC
//D016B4 HUAWEI TECHNOLOGIES CO., LTD
//20A8B9 SIEMENS AG
//F0F08F", "Nextek Solutions Pte Ltd
//8CB0E9 Samsung Electronics., LTD
//1C3947 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//342792, "FREEBOX SAS
//40A108 Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//705AB6 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//201A06 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//F8A963 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//DC0EA1 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//B870F4 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//009D6B Murata Manufacturing Co., Ltd.
//745933, "Danal Entertainment
//EC58EA Ruckus Wireless
//7C9A54 Technicolor CH USA Inc.
//388B59 Google, Inc.
//880118, "BLT Co
//A42618 Integrated Device Technology (Malaysia) Sdn. Bhd.
//34E12D, "Intel Corporate
//A46191 NamJunSa
//84A24D Birds Eye Systems Private Limited
//7C6B9C GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//0017B6 Aquantia Corporation
//105917, "Tonal
//D0EFC1", "HUAWEI TECHNOLOGIES CO., LTD
//D45251", "IBT Ingenieurbureau Broennimann Thun
//0018B5 Magna Carta
//D87EB1", "x.o.ware, inc.
//485702, "HUAWEI TECHNOLOGIES CO., LTD
//644F42, "JETTER CO., Ltd.
//DCAF68 WEIFANG GOERTEK ELECTRONICS CO., LTD
//24EC51 ADF Technologies Sdn Bhd
//7089CC China Mobile Group Device Co., Ltd.
//2C5BE1 Centripetal Networks, Inc
//DCEFCA", "Murata Manufacturing Co., Ltd.
//00BC60 Cisco Systems, Inc
//CC7B61", "NIKKISO CO., LTD.
//9C713A HUAWEI TECHNOLOGIES CO., LTD
//2C97B1 HUAWEI TECHNOLOGIES CO., LTD
//A89969", "Dell Inc.
//A4EA8E Extreme Networks, Inc.
//882D53, "Baidu Online Network Technology (Beijing) Co., Ltd.
//00D0B5, "IPricot formerly DotCom
//746BAB GUANGDONG ENOK COMMUNICATION CO., LTD
//0CB6D2 D-Link International
//7829ED, "ASKEY COMPUTER CORP
//5061BF Cisco Systems, Inc
//0009DF Vestel Elektronik San ve Tic. A.Ş.
//F4032F Reduxio Systems
//944A0C Sercomm Corporation.
//000FA2", "2xWireless
//108EE0 Samsung Electronics Co., Ltd
//FCA621", "Samsung Electronics Co., Ltd
//8CF228 MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//700F6A Cisco Systems, Inc
//000BB2 SMALLBIG TECHNOLOGY
//00305E, "Abelko Innovation
//FC6BF0 TOPWELL INTERNATIONAL HOLDINDS LIMITED
//001477, "Trilliant
//00079B Aurora Networks
//544810, "Dell Inc.
//54B203 PEGATRON CORPORATION
//3868DD INVENTEC CORPORATION
//3C6AA7 Intel Corporate
//B8B7F1", "Wistron Neweb Corporation
//8050F6, "ITEL MOBILE LIMITED
//A8CAB9", "SAMSUNG ELECTRO MECHANICS CO., LTD.
//203956, "HMD Global Oy
//78AFE4 Comau S.p.A
//90A137 Beijing Splendidtel Communication Technology Co,. Ltd
//80029C Gemtek Technology Co., Ltd.
//D0C5D3 AzureWave Technology Inc.
//14169E, "Wingtech Group (HongKong）Limited
//F8C39E", "HUAWEI TECHNOLOGIES CO., LTD
//E8D099", "Fiberhome Telecommunication Technologies Co., LTD
//107BA4 Olive & Dove Co., Ltd.
//7C41A2 Nokia
//BC325F Zhejiang Dahua Technology Co., Ltd.
//505BC2 Liteon Technology Corporation
//6C21A2 AMPAK Technology, Inc.
//9C2F73 Universal Tiancheng Technology (Beijing) Co., Ltd.
//D832E3 Xiaomi Communications Co Ltd
//9487E0, "Xiaomi Communications Co Ltd
//38AF29 Zhejiang Dahua Technology Co., Ltd.
//C88629 Shenzhen Duubee Intelligent Technologies Co., LTD.
//CCC2E0 Raisecom Technology CO., LTD
//300AC5 Ruio telecommunication technologies Co., Limited
//00E065, "OPTICAL ACCESS INTERNATIONAL
//4466FC GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//A028ED", "HMD Global Oy
//AC5474", "China Mobile IOT Company Limited
//8C1CDA IEEE Registration Authority
//0007A8 Haier Group Technologies Ltd
//9814D2, "Avonic
//1409DC HUAWEI TECHNOLOGIES CO., LTD
//EC9365", "Mapper.ai, Inc.
//38BAF8 Intel Corporate
//C4BAA3", "Beijing Winicssec Technologies Co., Ltd.
//9CFEA1 Fiberhome Telecommunication Technologies Co., LTD
//D88A3B", "UNIT-EM
//EC5A86", "Yulong Computer Telecommunication Scientific (Shenzhen) Co., Ltd
//C0EEB5", "Enice Network.
//60DEF3 HUAWEI TECHNOLOGIES CO., LTD
//50A009 Xiaomi Communications Co Ltd
//88964E, "ARRIS Group, Inc.
//883F4A Texas Instruments
//9CA615 TP-LINK TECHNOLOGIES CO., LTD.
//E44E76 CHAMPIONTECH", "ENTERPRISE (SHENZHEN) INC
//004098, "DRESSLER GMBH & CO.
//001DFA Fujian LANDI Commercial Equipment Co., Ltd
//9CE65E Apple, Inc.
//C49880 Apple, Inc.
//E0338E Apple, Inc.
//08F69C Apple, Inc.
//04FA83 Qingdao Haier Technology Co., Ltd
//78F9B4 Nokia
//2016B9 Intel Corporate
//D076E7", "TP-LINK TECHNOLOGIES CO., LTD.
//50A67F Apple, Inc.
//D461DA Apple, Inc.
//F01898 Apple, Inc.
//881908, "Apple, Inc.
//5C0947 Apple, Inc.
//14205E, "Apple, Inc.
//B841A4 Apple, Inc.
//00165C Trackflow Ltd.
//641CAE Samsung Electronics Co., Ltd
//F8E44E", "MCOT INC.
//40CD7A Qingdao Hisense Communications Co., Ltd.
//DC4EF4 Shenzhen MTN Electronics CO., Ltd
//F08173", "Amazon Technologies Inc.
//EC65CC Panasonic Automotive Systems Company of America
//949990, "VTC Telecommunications
//F4BC97 Shenzhen Crave Communication Co., LTD
//28FEDE COMESTA, Inc.
//907910, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//003DE8 LG Electronics (Mobile Communications)
//68FEDA Fiberhome Telecommunication Technologies Co., LTD
//E8986D", "Palo Alto Networks
//144E34, "Remote Solution
//00508B Hewlett Packard
//146B9C SHENZHEN BILIAN ELECTRONIC CO.，LTD
//948DEF Oetiker Schweiz AG
//2CD974 Hui Zhou Gaoshengda Technology Co., LTD
//D4F786", "Fiberhome Telecommunication Technologies Co., LTD
//3403DE Texas Instruments
//94B86D Intel Corporate
//240A63 ARRIS Group, Inc.
//F88B37 ARRIS Group, Inc.
//20677C Hewlett Packard Enterprise
//34D712, "Smartisan Digital Co., Ltd
//A06610", "FUJITSU LIMITED
//44FFBA zte corporation
//E0E62E", "TCT mobile ltd
//387862, "Sony Mobile Communications Inc
//E42D7B China Mobile IOT Company Limited
//C464E3 Texas Instruments
//8817A3 Integrated Device Technology (Malaysia) Sdn. Bhd.
//88A9A7 IEEE Registration Authority
//EC8914 HUAWEI TECHNOLOGIES CO., LTD
//B89436", "HUAWEI TECHNOLOGIES CO., LTD
//501479, "iRobot Corporation
//6084BD BUFFALO.INC
//347ECA NEXTWILL
//B42EF8 Eline Technology co.Ltd
//A4D4B2", "Shenzhen MeiG Smart Technology Co., Ltd
//8CF773 Nokia
//DCDD24 Energica Motor Company SpA
//641CB0 Samsung Electronics Co., Ltd
//903A72 Ruckus Wireless
//CC3B58", "Curiouser Products Inc
//4CEFC0 Amazon Technologies Inc.
//8C5973 Zyxel Communications Corporation
//24181D, "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//58D759, "HUAWEI TECHNOLOGIES CO., LTD
//F89066", "Nain Inc.
//7006AC Eastcompeace Technology Co., Ltd
//2802D8, "Samsung Electronics Co., Ltd
//DCE533", "IEEE Registration Authority
//D8445C", "DEV Tecnologia Ind Com Man Eq LTDA
//509551, "ARRIS Group, Inc.
//804126, "HUAWEI TECHNOLOGIES CO., LTD
//ACF970", "HUAWEI TECHNOLOGIES CO., LTD
//7C3953 zte corporation
//38E1AA zte corporation
//48C796 Samsung Electronics Co., Ltd
//F4C248", "Samsung Electronics Co., Ltd
//F47190", "Samsung Electronics Co., Ltd
//C4FFBC", "IEEE Registration Authority
//0C2369 Honeywell SPS
//04C9D9 Dish Technologies Corp
//7055F8, "Cerebras Systems Inc
//6C54CD LAMPEX ELECTRONICS LIMITED
//000889, "Dish Technologies Corp
//F0B5B7", "Disruptive Technologies Research AS
//B4DEDF zte corporation
//283B82 D-Link International
//D4909C Apple, Inc.
//E4E0A6 Apple, Inc.
//580454, "ICOMM HK LIMITED
//3C9A77 Technicolor CH USA Inc.
//C477AF Advanced Digital Broadcast SA
//A486AE", "Quectel Wireless Solutions
//94290C Shenyang wisdom Foundation Technology Development Co., Ltd.
//9C32CE CANON INC.
//20E09C Nokia
//2CFDA1 ASUSTek COMPUTER INC.
//3807D4, "Zeppelin Systems GmbH
//04197F, "Grasphere Japan
//5C0038 Viasat Group S.p.A.
//8CEC4B Dell Inc.
//34415D, "Intel Corporate
//005091, "NETACCESS, INC.
//B85001 Extreme Networks, Inc.
//802BF9 Hon Hai Precision Ind.Co., Ltd.
//54B802 Samsung Electronics Co., Ltd
//10CEA9 Texas Instruments
//805E0C YEALINK(XIAMEN) NETWORK TECHNOLOGY CO., LTD.
//6C49C1 o2ones Co., Ltd.
//70EEA3 Eoptolink Technology Inc. Ltd,
//7047E9, "vivo Mobile Communication Co., Ltd.
//5C521E Nintendo Co., Ltd
//14444A Apollo Seiko Ltd.
//3C2C99 Edgecore Networks Corporation
//88D039, "TCL Technoly Electronics(Huizhou)., Ltd
//683E02, "SIEMENS AG, Digital Factory, Motion Control System
//000261, "Tilgin AB
//0014C3 Seagate Technology
//0004CF Seagate Technology
//002037, "Seagate Technology
//5C81A7 Network Devices Pty Ltd
//5C0C0E Guizhou Huaxintong Semiconductor Technology Co Ltd
//503CEA GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//D096FB", "DASAN Network Solutions
//00E091, "LG Electronics
//38437D, "Compal Broadband Networks, Inc.
//506F98, "Sehaj Synergy Technologies Private Limited
//4CAE1C SaiNXT Technologies LLP
//142882, "MIDICOM ELECTRONICS CO.LTD
//EC8193", "Logitech, Inc
//6CDD30 Cisco Systems, Inc
//6C4E86 Third Millennium Systems Ltd.
//5C86C1 DONGGUAN SOLUM ELECTRONICS CO., LTD
//5C7776 TCT mobile ltd
//70E56E Texas Instruments
//547DCD Texas Instruments
//00AECD Pensando Systems
//FC9DD8", "Beijing TongTongYiLian Science and Technology Ltd.
//DC2834 HAKKO Corporation
//84509A Easy Soft TV Co., Ltd
//001730, "Automation Electronics
//30E48E Vodafone UK
//449160, "Murata Manufacturing Co., Ltd.
//B4F1DA LG Electronics (Mobile Communications)
//C863F1", "Sony Interactive Entertainment Inc.
//DCE1AD Shenzhen Wintop Photoelectric Technology Co., Ltd
//948854, "Texas Instruments
//001D0D, "Sony Interactive Entertainment Inc.
//B0FC36 CyberTAN Technology Inc.
//001DF4 Magellan Technology Pty Limited
//6C05D5 Ethertronics Inc
//348584, "Aerohive Networks Inc.
//0019C2 Equustek Solutions, Inc.
//80000B Intel Corporate
//ECB0E1", "Ciena Corporation
//78DDD9 Guangzhou Shiyuan Electronics Co., Ltd.
//F8B7E2 Cisco Systems, Inc
//F82055", "Green Information System
//74E19A Fiberhome Telecommunication Technologies Co., LTD
//000097, "Dell EMC
//8CCF09 Dell EMC
//8C839D SHENZHEN XINYUPENG ELECTRONIC TECHNOLOGY CO., LTD
//B0C19E", "zte corporation
//0C3747 zte corporation
//ACA667", "Electronic Systems Protection, Inc.
//0081F9, "Texas Instruments
//ECB5FA Philips Lighting BV
//44CD0E FLEXTRONICS MANUFACTURING(ZHUHAI) CO., LTD.
//E8825B ARRIS Group, Inc.
//70991C Shenzhen Honesty Electronics Co., Ltd
//80B03D Apple, Inc.
//E49ADC Apple, Inc.
//ACE4B5 Apple, Inc.
//D0D2B0 Apple, Inc.
//001CAE WiChorus, Inc.
//7CDD76 Suzhou Hanming Technologies Co., Ltd.
//246880, "Braveridge.co., ltd.
//F092B4 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//E8DF70", "AVM Audiovisuelles Marketing und Computersysteme GmbH
//28AD3E Shenzhen TONG BO WEI Technology CO., LTD
//001C56 Pado Systems, Inc.
//F06D78 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//7844FD TP-LINK TECHNOLOGIES CO., LTD.
//ECF8EB SICHUAN TIANYI COMHEART TELECOMCO., LTD
//707D95, "Shenzhen City LinwlanTechnology Co. Ltd.
//2C431A Shenzhen YOUHUA Technology Co., Ltd
//A8D3C8", "Topcon Electronics GmbH & Co.KG
//D05995", "Fiberhome Telecommunication Technologies Co., LTD
//18CC88 Hitachi Johnson Controls Air
//80C755 Panasonic Appliances Company
//F0BD2E H+S Polatis Ltd
//746EE4 Asia Vital Components Co., Ltd.
//0040E4, "E-M TECHNOLOGY, INC.
//984B4A ARRIS Group, Inc.
//E084F3 High Grade Controls Corporation
//38A6CE BSkyB Ltd
//3456FE Cisco Meraki
//70708B Cisco Systems, Inc
//389F5A C-Kur TV Inc.
//D843ED Suzuken
//BC4101 Shenzhen TINNO Mobile Technology Corp.
//043A0D SM Optics S.r.l.
//448F17, "Samsung Electronics Co., Ltd.ARTIK
//00FC8B Amazon Technologies Inc.
//0076B1 Somfy-Protect By Myfox SAS
//6CC147 Xiamen Hanin Electronic Technology Co., Ltd
//A072E4", "NJ SYSTEM CO., LTD
//4C1365 Emplus Technologies
//CCF957", "u-blox AG
//0C62A6 Hui Zhou Gaoshengda Technology Co., LTD
//18132D, "zte corporation
//74D21D, "HUAWEI TECHNOLOGIES CO., LTD
//1878D4, "Verizon
//B8D94D", "Sagemcom Broadband SAS
//3890A5 Cisco Systems, Inc
//C0742B", "SHENZHEN XUNLONG SOFTWARE CO., LIMITED
//5C6776 IDS Imaging Development Systems GmbH
//44EAD8 Texas Instruments
//189BA5 IEEE Registration Authority
//A491B1 Technicolor
//1C7022 Murata Manufacturing Co., Ltd.
//CC9891 Cisco Systems, Inc
//28BF89 Fiberhome Telecommunication Technologies Co., LTD
//903DBD SECURE METERS LIMITED
//002294, "KYOCERA CORPORATION
//3889DC Opticon Sensors Europe B.V.
//8C4500 Murata Manufacturing Co., Ltd.
//1CDDEA GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//940006, "jinyoung
//74E5F9, "Intel Corporate
//20040F, "Dell Inc.
//A43412 Thales Alenia Space
//8C8590 Apple, Inc.
//BC88C3 Ningbo Dooya Mechanic & Electronic Technology Co., Ltd
//38CD07 Beijing FaceCam Technology Co., Ltd.
//00D060, "Panasonic Europe Ltd.
//ECFA03 FCA
//6C96CF Apple, Inc.
//681F40, "Blu Wireless Technology Ltd
//90ADF7 vivo Mobile Communication Co., Ltd.
//40CE24 Cisco Systems, Inc
//3432E6, "Panasonic Industrial Devices Europe GmbH
//40017A Cisco Systems, Inc
//78886D, "Apple, Inc.
//20EE28 Apple, Inc.
//B4F61C Apple, Inc.
//08F4AB Apple, Inc.
//FC017C Hon Hai Precision Ind.Co., Ltd.
//90324B Hon Hai Precision Ind.Co., Ltd.
//602E20, "HUAWEI TECHNOLOGIES CO., LTD
//E472E2", "HUAWEI TECHNOLOGIES CO., LTD
//00127D, "MobileAria
//F86465", "Anova Applied Electronics, Inc.
//002060, "ALCATEL ITALIA S.p.A.
//A08869 Intel Corporate
//508F4C Xiaomi Communications Co Ltd
//A47758", "Ningbo Freewings Technologies Co., Ltd
//58A0CB TrackNet, Inc
//000CEC Spectracom Corp.
//E06089 Cloudleaf, Inc.
//783690, "Yulong Computer Telecommunication Scientific (Shenzhen) Co., Ltd
//BC54FC", "SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//0C4B54 TP-LINK TECHNOLOGIES CO., LTD.
//E4F004 Dell Inc.
//94E36D, "Texas Instruments
//F0F8F2 Texas Instruments
//341513, "Texas Instruments
//74819A PT. Hartono Istana Teknologi
//283545, "SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD
//044F4C HUAWEI TECHNOLOGIES CO., LTD
//18B81F ARRIS Group, Inc.
//1C151F HUAWEI TECHNOLOGIES CO., LTD
//008BFC mixi, Inc.
//A82BB5 Edgecore Networks Corporation
//60F677, "Intel Corporate
//E8E1E2 Energotest
//7811DC XIAOMI Electronics, CO., LTD
//D463C6", "Motorola Mobility LLC, a Lenovo Company
//F844E3", "Taicang T&W Electronics
//24A534 SynTrust Tech International Ltd.
//C444A0 Cisco Systems, Inc
//18742E, "Amazon Technologies Inc.
//90A365 HMD Global Oy
//DC44B6 Samsung Electronics Co., Ltd
//1007B6 Samsung Electronics Co., Ltd
//342D0D, "Samsung Electronics Co., Ltd
//A44CC8", "Dell Inc.
//D837BE SHENZHEN GONGJIN ELECTRONICS CO., LT
//D4684D", "Ruckus Wireless
//8C0C90 Ruckus Wireless
//6CAAB3 Ruckus Wireless
//001392, "Ruckus Wireless
//085114, "QINGDAO TOPSCOMM COMMUNICATION CO., LTD
//D05A00", "Technicolor CH USA Inc.
//70788B vivo Mobile Communication Co., Ltd.
//4859A4 zte corporation
//54BD79 Samsung Electronics Co., Ltd
//A0423F", "Tyan Computer Corp
//70F11C Shenzhen Ogemray Technology Co., Ltd
//7065A3 Kandao lightforge Co., Ltd.
//14144B Ruijie Networks Co., LTD
//74D0DC Ericsson AB
//C08ADE", "Ruckus Wireless
//001D2E, "Ruckus Wireless
//B4E62A LG Innotek
//A0C5F2", "IEEE Registration Authority
//A86B7C", "SHENZHEN FENGLIAN TECHNOLOGY CO., LTD.
//B03956 NETGEAR
//3C0CDB UNIONMAN TECHNOLOGY CO., LTD
//EC42B4", "ADC Corporation
//60DA83 Hangzhou H3C Technologies Co., Limited
//2C5731 Wingtech Group (HongKong）Limited
//CC4639", "WAAV, Inc.
//AC9E17 ASUSTek COMPUTER INC.
//641666, "Nest Labs Inc.
//D8DF7A Quest Software, Inc.
//E4A749 Palo Alto Networks
//145BE1 nyantec GmbH
//A0239F", "Cisco Systems, Inc
//70F35A Cisco Systems, Inc
//A0341B", "Adero Inc
//A0AFBD Intel Corporate
//7C8BCA TP-LINK TECHNOLOGIES CO., LTD.
//B04E26 TP-LINK TECHNOLOGIES CO., LTD.
//B089C2 Zyptonite
//F023B9 IEEE Registration Authority
//FC4DD4 Universal Global Scientific Industrial Co., Ltd.
//A4F4C2 VNPT TECHNOLOGY
//8C147D IEEE Registration Authority
//30074D, "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//1C1FD4 LifeBEAM Technologies LTD
//009AD2 Cisco Systems, Inc
//447F77, "Connected Home
//E8B6C2 Juniper Networks
//947BE7 Samsung Electronics Co., Ltd
//5092B9 Samsung Electronics Co., Ltd
//DC74A8", "Samsung Electronics Co., Ltd
//E83935", "Hewlett Packard
//00180A Cisco Meraki
//5C6A80 Zyxel Communications Corporation
//D860B3 Guangdong Global Electronic Technology CO.，LTD
//64351C e-CON SYSTEMS INDIA PVT LTD
//60BA18 nextLAP GmbH
//44AA50 Juniper Networks
//84CD62 ShenZhen IDWELL Technology CO., Ltd
//A8D579", "Beijing Chushang Science and Technology Co., Ltd
//4448C1 Hewlett Packard Enterprise
//481063, "NTT Innovation Institute, Inc.
//A08E78 Sagemcom Broadband SAS
//88D50C GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//D428D5", "TCT mobile ltd
//9CAF6F ITEL MOBILE LIMITED
//FC539E Shanghai Wind Technologies Co., Ltd
//605317, "Sandstone Technologies
//907065, "Texas Instruments
//18A958 PROVISION THAI CO., LTD.
//74C9A3 Fiberhome Telecommunication Technologies Co., LTD
//EC8A4C", "zte corporation
//D45F25 Shenzhen YOUHUA Technology Co., Ltd
//40C8CB AM Telecom co., Ltd.
//2CABEB Cisco Systems, Inc
//C83A6B", "Roku, Inc
//B4C6F8", "Axilspot Communication
//9CE951 Shenzhen Sang Fei Consumer Communications Ltd., Co.
//B8D50B Sunitec Enterprise Co., Ltd
//BC66DE", "Shadow Creator Information Technology Co., Ltd.
//1868CB Hangzhou Hikvision Digital Technology Co., Ltd.
//C4AE12 Samsung Electronics Co., Ltd
//001FA4 SHENZHEN GONGJIN ELECTRONICS CO., LT
//D4DCCD", "Apple, Inc.
//484BAA Apple, Inc.
//DCA904 Apple, Inc.
//6CAB31 Apple, Inc.
//4C74BF Apple, Inc.
//04946B TECNO MOBILE LIMITED
//A04C5B Shenzhen TINNO Mobile Technology Corp.
//488803, "ManTechnology Inc.
//B436E3 KBVISION GROUP
//94D299, "Techmation Co., Ltd.
//341A35 Fiberhome Telecommunication Technologies Co., LTD
//2C029F", "3ALogics
//64D154, "Routerboard.com
//58D9D5, "Tenda Technology Co., Ltd.Dongguan branch
//6C4B90 LiteON
//00050F, "Tanaka S/S Ltd.
//989E63, "Apple, Inc.
//886B6E Apple, Inc.
//F4E4AD zte corporation
//28FF3E zte corporation
//B8D7AF", "Murata Manufacturing Co., Ltd.
//D4AE05 Samsung Electronics Co., Ltd
//E048AF", "Premietech Limited
//2C3311 Cisco Systems, Inc
//5082D5, "Apple, Inc.
//F0EE10 Samsung Electronics Co., Ltd
//C4700B", "GUANGZHOU CHIP TECHNOLOGIES CO., LTD
//3CA067 Liteon Technology Corporation
//BC024A HMD Global Oy
//949901, "Shenzhen YITOA Digital Appliance CO., LTD
//F85971", "Intel Corporate
//1005CA Cisco Systems, Inc
//7894B4 Sercomm Corporation.
//443708, "MRV Comunications
//285F2F, "RNware Co., Ltd.
//500FF5 Tenda Technology Co., Ltd.Dongguan branch
//BC452E Knowledge Development for POF S.L.
//DCC64B HUAWEI TECHNOLOGIES CO., LTD
//043389, "HUAWEI TECHNOLOGIES CO., LTD
//00A068 BHP LIMITED
//703ACB Google, Inc.
//706DEC Wifi-soft LLC
//B0C205 BIONIME
//94F551, "Cadi Scientific Pte Ltd
//105AF7 ADB Italia
//B81DAA", "LG Electronics (Mobile Communications)
//00E400, "Sichuan Changhong Electric Ltd.
//2C55D3 HUAWEI TECHNOLOGIES CO., LTD
//00C024 EDEN SISTEMAS DE COMPUTACAO SA
//7C4685 Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//1C1EE3 Hui Zhou Gaoshengda Technology Co., LTD
//44032C Intel Corporate
//7868F7, "YSTen Technology Co., Ltd
//004BF3 SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//08CCA7 Cisco Systems, Inc
//0896AD Cisco Systems, Inc
//0823B2 vivo Mobile Communication Co., Ltd.
//88C3B3 SOVICO
//E05124 NXP Semiconductors
//001DA3 SabiOso
//542F8A TELLESCOM INDUSTRIA E COMERCIO EM TELECOMUNICACAO
//6014B3 CyberTAN Technology Inc.
//105611, "ARRIS Group, Inc.
//347877, "O-Net Communications (Shenzhen) Limited
//0020CC DIGITAL SERVICES, LTD.
//689FF0 zte corporation
//5CAF06 LG Electronics (Mobile Communications)
//00179B CHANT SINCERE CO., LTD
//1C398A Fiberhome Telecommunication Technologies Co., LTD
//E865D4", "Tenda Technology Co., Ltd.Dongguan branch
//24D51C Zhongtian broadband technology co., LTD
//EC43F6", "Zyxel Communications Corporation
//60C658 PHYTRONIX Co., Ltd.
//FCB58A Wapice Ltd.
//A462DF DS Global.Co., LTD
//4C1694 shenzhen sibituo Technology Co., Ltd
//C81451", "HUAWEI TECHNOLOGIES CO., LTD
//44D437, "Inteno Broadband Technology AB
//ECE154 Beijing Unisound Information Technology Co., Ltd.
//6C160E ShotTracker
//803A0A Integrated Device Technology (Malaysia) Sdn. Bhd.
//0C73BE Dongguan Haimai Electronie Technology Co., Ltd
//286F7F, "Cisco Systems, Inc
//F0C850", "HUAWEI TECHNOLOGIES CO., LTD
//00014F, "Adtran Inc
//285261, "Cisco Systems, Inc
//C8AA55", "Hunan Comtom Electronic Incorporated Co., Ltd
//20780B Delta Faucet Company
//8809AF Masimo Corporation
//2CD02D Cisco Systems, Inc
//9CCC83 Juniper Networks
//2C6373 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//24A7DC BSkyB Ltd
//64DBA0 Select Comfort
//F8983A", "Leeman International (HongKong) Limited
//4CECEF Soraa, Inc.
//1CEFCE bebro electronic GmbH
//98B6E9 Nintendo Co., Ltd
//F015B9", "PlayFusion Limited
//64B0A6 Apple, Inc.
//7C04D0 Apple, Inc.
//84FCAC Apple, Inc.
//DC0C5C Apple, Inc.
//70700D, "Apple, Inc.
//30E171, "Hewlett Packard
//186590, "Apple, Inc.
//F86214 Apple, Inc.
//784F43, "Apple, Inc.
//404D7F, "Apple, Inc.
//001D72, "Wistron Corporation
//D8197A Nuheara Ltd
//4C38D5 MITAC COMPUTING TECHNOLOGY CORPORATION
//54B56C Xi'an NovaStar Tech Co., Ltd
//344CC8 Echodyne Corp
//64136C zte corporation
//04B648 ZENNER
//98F199, "NEC Platforms, Ltd.
//1840A4 Shenzhen Trylong Smart Science and Technology Co., Ltd.
//1C48CE GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//C80CC8", "HUAWEI TECHNOLOGIES CO., LTD
//0425C5 HUAWEI TECHNOLOGIES CO., LTD
//603E7B Gafachi, Inc.
//4C7487 Leader Phone Communication Technology Co., Ltd.
//AC83F3 AMPAK Technology, Inc.
//CC8CDA Shenzhen Wei Da Intelligent Technology Go., Ltd
//D436DB", "Jiangsu Toppower Automotive Electronics Co., Ltd
//2CDCAD Wistron Neweb Corporation
//6C5C14 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//E80945", "Integrated Device Technology (Malaysia) Sdn. Bhd.
//B0A2E7 Shenzhen TINNO Mobile Technology Corp.
//7C2587 chaowifi.com
//2C2131 Juniper Networks
//00501E, "Grass Valley, A Belden Brand
//EC0D9A", "Mellanox Technologies, Inc.
//90D7BE Wavelab Global Inc.
//244E7B IEEE Registration Authority
//30AEA4 Espressif Inc.
//206C8A Aerohive Networks Inc.
//3CFA43 HUAWEI TECHNOLOGIES CO., LTD
//145F94, "HUAWEI TECHNOLOGIES CO., LTD
//001F82, "Cal-Comp Electronics & Communications Company Ltd.
//883C1C MERCURY CORPORATION
//002144, "SS Telecoms
//006BF1 Cisco Systems, Inc
//2834A2 Cisco Systems, Inc
//7823AE ARRIS Group, Inc.
//20719E, "SF Technology Co., Ltd
//2CC260 Oracle Corporation
//3C3F51", "2CRSI
//3C2AF4 Brother Industries, LTD.
//C0854C Ragentek Technology Group
//0024AC Hangzhou DPtech Technologies Co., Ltd.
//50584F, "waytotec, Inc.
//085DDD MERCURY CORPORATION
//8C60E7 MPGIO CO., LTD
//CC9470", "Kinestral Technologies, Inc.
//B439D6 ProCurve Networking by HP
//34F39A Intel Corporate
//D816C1", "DEWAV (HK) ELECTRONICS LIMITED
//CC61E5", "Motorola Mobility LLC, a Lenovo Company
//8C8ABB Beijing Orient View Technology Co., Ltd.
//00039B NetChip Technology, Inc.
//44D9E7, "Ubiquiti Networks Inc.
//24A43C Ubiquiti Networks Inc.
//9C8BA0 Apple, Inc.
//CC088D Apple, Inc.
//38A4ED Xiaomi Communications Co Ltd
//B89919, "7signal Solutions, Inc
//40FE0D MAXIO
//AC64DD IEEE Registration Authority
//94B819 Nokia
//787D48, "ITEL MOBILE LIMITED
//8871E5, "Amazon Technologies Inc.
//BC39D9 Z-TEC
//609AC1 Apple, Inc.
//748D08, "Apple, Inc.
//00B0EE Ajile Systems, Inc.
//0418D6, "Ubiquiti Networks Inc.
//20DBAB Samsung Electronics Co., Ltd.
//383A21 IEEE Registration Authority
//D8380D SHENZHEN IP-COM Network Co., Ltd
//88AD43 PEGATRON CORPORATION
//B4EFFA", "Lemobile Information Technology (Beijing) Co., Ltd.
//6C71BD EZELINK TELECOM
//60EFC6 Shenzhen Chima Technologies Co Limited
//001FC6 ASUSTek COMPUTER INC.
//B0C128 Adler ELREHA GmbH
//3087D9, "Ruckus Wireless
//FCCAC4 LifeHealth, LLC
//F0D9B2", "EXO S.A.
//E4C801 BLU Products Inc
//F09838 HUAWEI TECHNOLOGIES CO., LTD
//C80E14", "AVM Audiovisuelles Marketing und Computersysteme GmbH
//AC63BE Amazon Technologies Inc.
//F81D78 IEEE Registration Authority
//38F7B2 SEOJUN ELECTRIC
//101250, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//7802B7 ShenZhen Ultra Easy Technology CO., LTD
//646184, "VELUX
//E8E5D6", "Samsung Electronics Co., Ltd
//C87E75", "Samsung Electronics Co., Ltd
//00265F, "Samsung Electronics Co., Ltd
//00233A Samsung Electronics Co., Ltd
//086A0A ASKEY COMPUTER CORP
//98E7F4, "Hewlett Packard
//0007AB Samsung Electronics Co., Ltd
//002486, "DesignArt Networks
//002478, "Mag Tech Electronics Co Limited
//382DD1 Samsung Electronics Co., Ltd
//001B2C ATRON electronic GmbH
//9034FC Hon Hai Precision Ind.Co., Ltd.
//001427, "JazzMutant
//001E84, "Pika Technologies Inc.
//10DDB1 Apple, Inc.
//002329, "DDRdrive LLC
//0026AD Arada Systems, Inc.
//FC1F19 SAMSUNG ELECTRO MECHANICS CO., LTD.
//840B2D SAMSUNG ELECTRO MECHANICS CO., LTD.
//206432, "SAMSUNG ELECTRO MECHANICS CO., LTD.
//B407F9 SAMSUNG ELECTRO MECHANICS CO., LTD.
//889FFA Hon Hai Precision Ind.Co., Ltd.
//8C7CB5 Hon Hai Precision Ind.Co., Ltd.
//C44619 Hon Hai Precision Ind.Co., Ltd.
//506313, "Hon Hai Precision Ind. Co., Ltd.
//60D819, "Hon Hai Precision Ind. Co., Ltd.
//F82FA8 Hon Hai Precision Ind.Co., Ltd.
//0C84DC Hon Hai Precision Ind.Co., Ltd.
//00166C Samsung Electronics Co., Ltd
//181EB0 Samsung Electronics Co., Ltd
//247F20, "Sagemcom Broadband SAS
//E8039A", "Samsung Electronics Co., Ltd
//30CDA7 Samsung Electronics Co., Ltd
//001247, "Samsung Electronics Co., Ltd
//001599, "Samsung Electronics Co., Ltd
//0012FB Samsung Electronics Co., Ltd
//D0667B", "Samsung Electronics Co., Ltd
//B85E7B", "Samsung Electronics Co., Ltd
//E492FB", "Samsung Electronics Co., Ltd
//6CB7F4 Samsung Electronics Co., Ltd
//2C4401 Samsung Electronics Co., Ltd
//B8D9CE", "Samsung Electronics Co., Ltd
//1C66AA Samsung Electronics Co., Ltd
//3C8BFE Samsung Electronics Co., Ltd
//D4E8B2", "Samsung Electronics Co., Ltd
//1489FD Samsung Electronics Co., Ltd
//BC851F", "Samsung Electronics Co., Ltd
//0015B9 Samsung Electronics Co., Ltd
//002491, "Samsung Electronics Co., Ltd
//002339, "Samsung Electronics Co., Ltd
//5001BB Samsung Electronics Co., Ltd
//C40142", "MaxMedia Technology Limited
//8430E5, "SkyHawke Technologies, LLC
//1C77F6 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//58E326, "Compass Technologies Inc.
//001B2A Cisco Systems, Inc
//749DDC", "2Wire Inc
//14DDE5 MPMKVVCL
//001A09 Wayfarer Transit Systems Ltd
//742344, "Xiaomi Communications Co Ltd
//54880E, "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//F025B7", "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//F04347", "HUAWEI TECHNOLOGIES CO., LTD
//9CB2B2 HUAWEI TECHNOLOGIES CO., LTD
//A8C83A", "HUAWEI TECHNOLOGIES CO., LTD
//BC72B1", "Samsung Electronics Co., Ltd
//78F7BE Samsung Electronics Co., Ltd
//684898, "Samsung Electronics Co., Ltd
//3423BA SAMSUNG ELECTRO-MECHANICS(THAILAND)
//003676, "ARRIS Group, Inc.
//FC8E7E ARRIS Group, Inc.
//FC6FB7 ARRIS Group, Inc.
//D42C0F ARRIS Group, Inc.
//400E85, "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//C8BA94", "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//843838, "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//A055DE", "ARRIS Group, Inc.
//80F503, "ARRIS Group, Inc.
//44AAF5 ARRIS Group, Inc.
//E09DFA Wanan Hongsheng Electronic Co.Ltd
//5C3C27 Samsung Electronics Co., Ltd
//70A84C MONAD., Inc.
//84C7EA Sony Mobile Communications Inc
//24E43F, "Wenzhou Kunmei Communication Technology Co., Ltd.
//287AEE ARRIS Group, Inc.
//88797E, "Motorola Mobility LLC, a Lenovo Company
//305890, "Frontier Silicon Ltd
//708BCD ASUSTek COMPUTER INC.
//00258B Mellanox Technologies, Inc.
//00562B Cisco Systems, Inc
//E8FD90", "Turbostor
//2CAC44 CONEXTOP
//D013FD LG Electronics (Mobile Communications)
//BC644B", "ARRIS Group, Inc.
//606405, "Texas Instruments
//1899F5, "Sichuan Changhong Electric Ltd.
//0025C3", "21168
//000F57, "CABLELOGIC Co., Ltd.
//000342, "Nortel Networks
//A48269 Datrium, Inc.
//10E68F, "KWANGSUNG ELECTRONICS KOREA CO., LTD.
//4CFACA Cambridge Industries(Group) Co., Ltd.
//18ABF5 Ultra Electronics Electrics
//B03EB0 MICRODIA Ltd.
//001591, "RLW Inc.
//00182E, "XStreamHD
//001283, "Nortel Networks
//0011F9, "Nortel Networks
//001158, "Nortel Networks
//000F6A Nortel Networks
//000E62, "Nortel Networks
//000CF8 Nortel Networks
//0026F1, "ProCurve Networking by HP
//380DD4 Primax Electronics Ltd.
//98FDB4 Primax Electronics Ltd.
//D8C46A Murata Manufacturing Co., Ltd.
//D8FB68 Cloud Corner Ltd.
//685388, "P&S Technology
//982F3C Sichuan Changhong Electric Ltd.
//14C1FF ShenZhen QianHai Comlan communication Co., LTD
//000417, "ELAU AG
//ECFAAA The IMS Company
//F00786 Shandong Bittel Electronics Co., Ltd
//00D0F6, "Nokia
//54A619 Alcatel-Lucent Shanghai Bell Co., Ltd
//000997, "Nortel Networks
//001CEB Nortel Networks
//001C17 Nortel Networks
//001A8F Nortel Networks
//0017D1, "Nortel Networks
//888322, "Samsung Electronics Co., Ltd
//E89309", "Samsung Electronics Co., Ltd
//0014C7 Nortel Networks
//001DAF Nortel Networks
//88A6C6 Sagemcom Broadband SAS
//94D469, "Cisco Systems, Inc
//882BD7 ADDÉNERGIE", "TECHNOLOGIES
//0090CC PLANEX COMMUNICATIONS INC.
//2057AF Shenzhen FH-NET OPTOELECTRONICS CO., LTD
//54DC1D Yulong Computer Telecommunication Scientific (Shenzhen) Co., Ltd
//ACA213", "Shenzhen Bilian electronic CO., LTD
//3C3300 Shenzhen Bilian electronic CO., LTD
//6CD032 LG Electronics
//3CBDD8 LG ELECTRONICS INC
//344DF7 LG Electronics (Mobile Communications)
//583F54, "LG Electronics (Mobile Communications)
//0022CF PLANEX COMMUNICATIONS INC.
//E417D8", "8BITDO TECHNOLOGY HK LIMITED
//9CD332 PLC Technology Ltd
//38F8CA OWIN Inc.
//44334C Shenzhen Bilian electronic CO., LTD
//64899A LG Electronics (Mobile Communications)
//002105, "Alcatel-Lucent IPD
//001BC5 IEEE Registration Authority
//48DF37 Hewlett Packard Enterprise
//C0E42D TP-LINK TECHNOLOGIES CO., LTD.
//8CA6DF TP-LINK TECHNOLOGIES CO., LTD.
//8416F9, "TP-LINK TECHNOLOGIES CO., LTD.
//18D6C7 TP-LINK TECHNOLOGIES CO., LTD.
//78C3E9 Samsung Electronics Co., Ltd
//8C1ABF Samsung Electronics Co., Ltd
//30CBF8 Samsung Electronics Co., Ltd
//A0CBFD", "Samsung Electronics Co., Ltd
//E45D75", "Samsung Electronics Co., Ltd
//00E04D, "INTERNET INITIATIVE JAPAN, INC
//F8A9D0", "LG Electronics (Mobile Communications)
//CCFA00", "LG Electronics (Mobile Communications)
//74A722 LG Electronics (Mobile Communications)
//F01C13", "LG Electronics (Mobile Communications)
//58FCDB IEEE Registration Authority
//B0C5CA IEEE Registration Authority
//7419F8, "IEEE Registration Authority
//A816B2", "LG Electronics (Mobile Communications)
//64BC0C LG Electronics (Mobile Communications)
//90C682 IEEE Registration Authority
//C01ADA Apple, Inc.
//2C600C QUANTA COMPUTER INC.
//000031, "QPSX COMMUNICATIONS, LTD.
//000E1E QLogic Corporation
//0014D1, "TRENDnet, Inc.
//00238B QUANTA COMPUTER INC.
//001E68, "QUANTA COMPUTER INC.
//CC52AF Universal Global Scientific Industrial Co., Ltd.
//001C14 VMware, Inc.
//005056, "VMware, Inc.
//00121C PARROT SA
//9003B7 PARROT SA
//208756, "SIEMENS AG
//74B472 CIESSE
//FCF152 Sony Corporation
//483C0C HUAWEI TECHNOLOGIES CO., LTD
//309BAD BBK EDUCATIONAL ELECTRONICS CORP., LTD.
//001BB1 Wistron Neweb Corporation
//0080F7, "Zenith Electronics Corporation
//BC307D", "Wistron Neweb Corporation
//48A9D2 Wistron Neweb Corporation
//80EA23 Wistron Neweb Corporation
//002713, "Universal Global Scientific Industrial Co., Ltd.
//BC307E Wistron Neweb Corporation
//08952A Technicolor CH USA Inc.
//4432C8 Technicolor CH USA Inc.
//38A28C SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//B4A5EF Sercomm Corporation.
//849D64, "SMC Corporation
//0010C1 OI ELECTRIC CO., LTD
//28BE9B Technicolor CH USA Inc.
//FC528D Technicolor CH USA Inc.
//506583, "Texas Instruments
//B09122 Texas Instruments
//FC51A4", "ARRIS Group, Inc.
//9857D3, "HON HAI-CCPBG PRECISION IND.CO., LTD.
//FCF528 Zyxel Communications Corporation
//00A0C5 Zyxel Communications Corporation
//A09E1A Polar Electro Oy
//1CD6BD LEEDARSON LIGHTING CO., LTD.
//D0D94F IEEE Registration Authority
//001E04, "Hanson Research Corporation
//60C0BF ON Semiconductor
//AC0481", "Jiangsu Huaxing Electronics Co., Ltd.
//68B35E Shenzhen Neostra Technology Co.Ltd
//408805, "Motorola Mobility LLC, a Lenovo Company
//24E271, "Qingdao Hisense Communications Co., Ltd.
//BC6010 Qingdao Hisense Communications Co., Ltd.
//D0FCCC Samsung Electronics Co., Ltd
//98398E, "Samsung Electronics Co., Ltd
//44D1FA Shenzhen Yunlink Technology Co., Ltd
//F0F644", "Whitesky Science & Technology Co., Ltd.
//20F17C HUAWEI TECHNOLOGIES CO., LTD
//346AC2 HUAWEI TECHNOLOGIES CO., LTD
//C41CFF", "Vizio, Inc
//C09727", "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//DC293A", "Shenzhen Nuoshi Technology Co., LTD.
//7C6AF3 Integrated Device Technology (Malaysia) Sdn. Bhd.
//E46251 HAO CHENG GROUP LIMITED
//40562D, "Smartron India Pvt ltd
//3876D1, "Euronda SpA
//C4693E Turbulence Design Inc.
//009569, "LSD Science and Technology Co., Ltd.
//B0CF4D MI-Zone Technology Ireland
//289AFA TCT mobile ltd
//001A34 Konka Group Co., Ltd.
//0011FC HARTING Electronics GmbH
//002389, "Hangzhou H3C Technologies Co., Limited
//3CE5A6 Hangzhou H3C Technologies Co., Limited
//5CDD70 Hangzhou H3C Technologies Co., Limited
//3C8C40 Hangzhou H3C Technologies Co., Limited
//A067BE", "Sicon srl
//D8209F Cubro Acronet GesmbH
//8C7716 LONGCHEER TELECOMMUNICATION LIMITED
//68FB7E Apple, Inc.
//84A134 Apple, Inc.
//A0D385 AUMA Riester GmbH & Co.KG
//1414E6, "Ningbo Sanhe Digital Co., Ltd
//002582, "Maksat Technologies (P) Ltd
//0C5101 Apple, Inc.
//2CF0A2 Apple, Inc.
//48C049 Broad Telecom SA
//AC6FBB TATUNG Technology Inc.
//001C41 scemtec Transponder Technology GmbH
//146308, "JABIL CIRCUIT (SHANGHAI) LTD.
//001E25, "INTEK DIGITAL
//00E0CF INTEGRATED DEVICE
//904D4A Sagemcom Broadband SAS
//044E5A ARRIS Group, Inc.
//0060B1 Input/Output, Inc.
//547F54, "INGENICO
//6C2483 Microsoft Mobile Oy
//6891D0, "IEEE Registration Authority
//E04F43", "Universal Global Scientific Industrial Co., Ltd.
//38700C ARRIS Group, Inc.
//000E2E Edimax Technology Co. Ltd.
//00065F, "ECI Telecom Ltd.
//00208F, "ECI Telecom Ltd.
//844076, "Drivenets
//001CD7 Harman/Becker Automotive Systems GmbH
//003A7D Cisco Systems, Inc
//90C7D8 zte corporation
//00185C EDSLAB Technologies
//001A45 GN Netcom A/S
//002088, "GLOBAL VILLAGE COMMUNICATION
//541379, "Hon Hai Precision Ind. Co., Ltd.
//001921, "Elitegroup Computer Systems Co., Ltd.
//0016EC Elitegroup Computer Systems Co., Ltd.
//000795, "Elitegroup Computer Systems Co., Ltd.
//FC0F4B Texas Instruments
//D4883F", "HDPRO CO., LTD.
//1088CE Fiberhome Telecommunication Technologies Co., LTD
//60B617 Fiberhome Telecommunication Technologies Co., LTD
//DC9C9F", "Shenzhen YOUHUA Technology Co., Ltd
//74DFBF Liteon Technology Corporation
//F03E90 Ruckus Wireless
//D8D723", "IDS, Inc
//84AD58 HUAWEI TECHNOLOGIES CO., LTD
//58605F, "HUAWEI TECHNOLOGIES CO., LTD
//00A0F4 GE
//AC0D1B LG Electronics (Mobile Communications)
//F0D1B8", "LEDVANCE
//986D35, "IEEE Registration Authority
//88795B Konka Group Co., Ltd.
//081F71, "TP-LINK TECHNOLOGIES CO., LTD.
//5CCA1A Microsoft Mobile Oy
//FC2FAA Nokia
//B07E70 Zadara Storage Ltd.
//0080B1 SOFTCOM A/S
//202DF8 Digital Media Cartridge Ltd.
//10D0AB zte corporation
//0004C6 YAMAHA MOTOR CO., LTD
//18A3E8 Fiberhome Telecommunication Technologies Co., LTD
//741E93, "Fiberhome Telecommunication Technologies Co., LTD
//202D07, "Samsung Electronics Co., Ltd
//D8803C", "Anhui Huami Information Technology Company Limited
//0034DA LG Electronics (Mobile Communications)
//3810D5, "AVM Audiovisuelles Marketing und Computersysteme GmbH
//18C501 SHENZHEN GONGJIN ELECTRONICS CO., LT
//00A0B8 NetApp
//00C88B Cisco Systems, Inc
//24C3F9 Securitas Direct AB
//2C21D7 IMAX Corporation
//0009D2, "Mai Logic Inc.
//006016, "CLARIION
//981FB1 Shenzhen Lemon Network Technology Co., Ltd
//0C5A9E Wi-SUN Alliance
//B44BD2 Apple, Inc.
//DC415F Apple, Inc.
//641225, "Cisco Systems, Inc
//7864E6, "Green Motive Technology Limited
//3CBEE1 NIKON CORPORATION
//102AB3 Xiaomi Communications Co Ltd
//40D357, "Ison Technology Co., Ltd.
//A41588 ARRIS Group, Inc.
//F45C89 Apple, Inc.
//20768F, "Apple, Inc.
//9C5CF9 Sony Mobile Communications Inc
//0011D1, "Soft Imaging System GmbH
//98D686, "Chyi Lee industry Co., ltd.
//8CC661 Current, powered by GE
//88A084 Formation Data Systems
//E8B2AC Apple, Inc.
//E49A79 Apple, Inc.
//30A9DE LG Innotek
//F01B6C", "vivo Mobile Communication Co., Ltd.
//A0B9ED Skytap
//94C960 Zhongshan B&T technology.co., ltd
//74C330 SHENZHEN FAST TECHNOLOGIES CO., LTD
//403F8C TP-LINK TECHNOLOGIES CO., LTD.
//DCB3B4 Honeywell Environmental & Combustion Controls (Tianjin) Co., Ltd.
//001D3B Nokia Danmark A/S
//001DFD Nokia Danmark A/S
//001E3B Nokia Danmark A/S
//001EA4 Nokia Danmark A/S
//0026CC Nokia Danmark A/S
//000EED Nokia Danmark A/S
//4C2578 Nokia Corporation
//BCC6DB", "Nokia Corporation
//60A8FE Nokia
//00119F, "Nokia Danmark A/S
//001A16 Nokia Danmark A/S
//001A89 Nokia Danmark A/S
//001ADC Nokia Danmark A/S
//0025CF Nokia Danmark A/S
//0021AB Nokia Danmark A/S
//001FDE Nokia Danmark A/S
//001FDF Nokia Danmark A/S
//547975, "Nokia Corporation
//A87B39 Nokia Corporation
//00247C Nokia Danmark A/S
//002266, "Nokia Danmark A/S
//0021FE Nokia Danmark A/S
//C477AB", "Beijing ASU Tech Co., Ltd
//000BCA DATAVAN TC
//702559, "CyberTAN Technology Inc.
//607EDD Microsoft Mobile Oy
//A8A089 Tactical Communications
//48365F, "Wintecronics Ltd.
//001D20, "Comtrend Corporation
//08373D, "Samsung Electronics Co., Ltd
//0C75BD Cisco Systems, Inc
//300D43, "Microsoft Mobile Oy
//00000E, "FUJITSU LIMITED
//000B5D FUJITSU LIMITED
//C488E5", "Samsung Electronics Co., Ltd
//080581, "Roku, Inc.
//000DF3 Asmax Solutions
//80ACAC Juniper Networks
//000DB6 Broadcom
//000AF7 Broadcom
//D40129 Broadcom
//001D00, "Brivo Systems, LLC
//0020D6, "Breezecom, Ltd.
//00E063, "Cabletron Systems, Inc.
//FCC734 Samsung Electronics Co., Ltd
//8425DB Samsung Electronics Co., Ltd
//B0EC71", "Samsung Electronics Co., Ltd
//E458B8", "Samsung Electronics Co., Ltd
//088C2C Samsung Electronics Co., Ltd
//64B853 Samsung Electronics Co., Ltd
//389496, "Samsung Electronics Co., Ltd
//5056BF Samsung Electronics Co., Ltd
//90F1AA Samsung Electronics Co., Ltd
//1077B1 Samsung Electronics Co., Ltd
//001FC7 Casio Hitachi Mobile Communications Co., Ltd.
//A49A58 Samsung Electronics Co., Ltd
//08EE8B Samsung Electronics Co., Ltd
//0CA42A OB Telecom Electronic Technology Co., Ltd
//74458A Samsung Electronics Co., Ltd
//5CDC96 Arcadyan Technology Corporation
//743170, "Arcadyan Technology Corporation
//001A2A Arcadyan Technology Corporation
//88252C Arcadyan Technology Corporation
//40BA61 ARIMA Communications Corp.
//0011F5, "ASKEY COMPUTER CORP
//0016E3, "ASKEY COMPUTER CORP
//E839DF", "ASKEY COMPUTER CORP
//1CC63C Arcadyan Technology Corporation
//1883BF Arcadyan Technology Corporation
//68ED43, "BlackBerry RTS
//70AAB2 BlackBerry RTS
//00146C NETGEAR
//001E2A NETGEAR
//00184D, "NETGEAR
//00040E, "AVM GmbH
//9CC7A6 AVM GmbH
//A06391", "NETGEAR
//20E52A NETGEAR
//4494FC NETGEAR
//200CC8 NETGEAR
//C4473F HUAWEI TECHNOLOGIES CO., LTD
//744401, "NETGEAR
//E091F5", "NETGEAR
//000F86, "BlackBerry RTS
//0024D2, "ASKEY COMPUTER CORP
//B4EEB4", "ASKEY COMPUTER CORP
//E46449", "ARRIS Group, Inc.
//40FC89 ARRIS Group, Inc.
//2C9E5F ARRIS Group, Inc.
//002636, "ARRIS Group, Inc.
//001CC1 ARRIS Group, Inc.
//001E5A ARRIS Group, Inc.
//001371, "ARRIS Group, Inc.
//0023EE ARRIS Group, Inc.
//001ADE ARRIS Group, Inc.
//745612, "ARRIS Group, Inc.
//0050E3, "ARRIS Group, Inc.
//002136, "ARRIS Group, Inc.
//001626, "ARRIS Group, Inc.
//0019A6 ARRIS Group, Inc.
//E8C74F Liteon Technology Corporation
//D05349 Liteon Technology Corporation
//000BA2 Sumitomo Electric Industries, Ltd
//0008F6, "Sumitomo Electric Industries, Ltd
//00005F, "Sumitomo Electric Industries, Ltd
//E8F724", "Hewlett Packard Enterprise
//5CB524 Sony Mobile Communications Inc
//90C115 Sony Mobile Communications Inc
//D05162", "Sony Mobile Communications Inc
//18002D, "Sony Mobile Communications Inc
//280DFC Sony Interactive Entertainment Inc.
//001311, "ARRIS Group, Inc.
//D0DF9A Liteon Technology Corporation
//1C659D Liteon Technology Corporation
//3010B3 Liteon Technology Corporation
//701A04 Liteon Technology Corporation
//48D224, "Liteon Technology Corporation
//20689D, "Liteon Technology Corporation
//0024EF, "Sony Mobile Communications Inc
//0025E7, "Sony Mobile Communications Inc
//58170C Sony Mobile Communications Inc
//0016B8 Sony Mobile Communications Inc
//7CBFB1 ARRIS Group, Inc.
//080046, "Sony Corporation
//ECF00E AboCom
//00E098, "AboCom
//74DAEA Texas Instruments
//948815, "Infinique Worldwide Inc
//D0E44A", "Murata Manufacturing Co., Ltd.
//384FF0 AzureWave Technology Inc.
//E874E6 ADB Broadband Italia
//0020E0, "Actiontec Electronics, Inc
//002662, "Actiontec Electronics, Inc
//002553, "ADB Broadband Italia
//00193E, "ADB Broadband Italia
//000827, "ADB Broadband Italia
//742F68, "AzureWave Technology Inc.
//4C14A3 TCL Technoly Electronics (Huizhou) Co., Ltd.
//4CB0E8 Beijing RongZhi xinghua technology co., LTD
//D887D5", "Leadcore Technology CO., LTD
//00F28B Cisco Systems, Inc
//34E6AD Intel Corporate
//081196, "Intel Corporate
//183DA2 Intel Corporate
//809B20 Intel Corporate
//002314, "Intel Corporate
//340286, "Intel Corporate
//001CBF Intel Corporate
//B4B676", "Intel Corporate
//3CA9F4 Intel Corporate
//B88A60", "Intel Corporate
//78FF57 Intel Corporate
//9C4E36 Intel Corporate
//3413E8, "Intel Corporate
//002710, "Intel Corporate
//A48E0A DeLaval International AB
//AC2B6E Intel Corporate
//9C3583 Nipro Diagnostics, Inc
//C06118", "TP-LINK TECHNOLOGIES CO., LTD.
//B82A72 Dell Inc.
//F8E079 Motorola Mobility LLC, a Lenovo Company
//CCC3EA", "Motorola Mobility LLC, a Lenovo Company
//40786A Motorola Mobility LLC, a Lenovo Company
//0019D1, "Intel Corporate
//0019D2, "Intel Corporate
//001B21 Intel Corporate
//18FF0F Intel Corporate
//34DE1A Intel Corporate
//E8B1FC", "Intel Corporate
//CC3D82 Intel Corporate
//001F3C Intel Corporate
//002315, "Intel Corporate
//00166F, "Intel Corporate
//000A8A Cisco Systems, Inc
//001D09, "Dell Inc.
//0023AE Dell Inc.
//BC305B Dell Inc.
//388602, "Flexoptix GmbH
//4065A3 Sagemcom Broadband SAS
//D02212 IEEE Registration Authority
//100723, "IEEE Registration Authority
//A44F29", "IEEE Registration Authority
//74F8DB IEEE Registration Authority
//A43BFA IEEE Registration Authority
//B8CA3A Dell Inc.
//ECF4BB Dell Inc.
//D4BED9 Dell Inc.
//00194B Sagemcom Broadband SAS
//001E74, "Sagemcom Broadband SAS
//383BC8", "2Wire Inc
//60FE20", "2Wire Inc
//002456, "2Wire Inc
//C0830A", "2Wire Inc
//00183F, "2Wire Inc
//000D56, "Dell Inc.
//181E78, "Sagemcom Broadband SAS
//0037B7 Sagemcom Broadband SAS
//0054BD Swelaser AB
//001E4C Hon Hai Precision Ind.Co., Ltd.
//20BB76 COL GIOVANNI PAOLO SpA
//3CDD89 SOMO HOLDINGS & TECH.CO., LTD.
//1801E3, "Bittium Wireless Ltd
//149182, "Belkin International Inc.
//18622C Sagemcom Broadband SAS
//3C81D8 Sagemcom Broadband SAS
//40F201, "Sagemcom Broadband SAS
//D084B0", "Sagemcom Broadband SAS
//D8543A", "Texas Instruments
//649C8E Texas Instruments
//102EAF Texas Instruments
//7C8EE4 Texas Instruments
//B4EED4", "Texas Instruments
//D03761 Texas Instruments
//C83E99", "Texas Instruments
//40984E, "Texas Instruments
//0017EB Texas Instruments
//0017E6, "Texas Instruments
//C4EDBA Texas Instruments
//001832, "Texas Instruments
//3C2DB7 Texas Instruments
//5464D9, "Sagemcom Broadband SAS
//00195B D-Link Corporation
//000F3D, "D-Link Corporation
//24DA11 NO NDA Inc
//EC2280 D-Link International
//9C8E99 Hewlett Packard
//9059AF Texas Instruments
//BC6A29", "Texas Instruments
//847E40, "Texas Instruments
//001735, "Intel Wireless Network Group
//74AC5F Qiku Internet Network Scientific (Shenzhen) Co., Ltd.
//38CADA Apple, Inc.
//D0B33F Shenzhen TINNO Mobile Technology Corp.
//BCD1D3 Shenzhen TINNO Mobile Technology Corp.
//D83C69 Shenzhen TINNO Mobile Technology Corp.
//F4F5D8 Google, Inc.
//8C579B Wistron Neweb Corporation
//0059AC KPN. B.V.
//40D855, "IEEE Registration Authority
//34AB37 Apple, Inc.
//2400BA HUAWEI TECHNOLOGIES CO., LTD
//24DF6A HUAWEI TECHNOLOGIES CO., LTD
//788B77 Standar Telecom
//B0C090", "Chicony Electronics Co., Ltd.
//907F61, "Chicony Electronics Co., Ltd.
//0C0535 Juniper Systems
//BC83A7", "SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD
//BCEC23", "SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD
//18AF61 Apple, Inc.
//5CF938 Apple, Inc.
//009069, "Juniper Networks
//64649B Juniper Networks
//F01C2D", "Juniper Networks
//307C5E Juniper Networks
//AC06C7", "ServerNet S.r.l.
//E83EFC ARRIS Group, Inc.
//900DCB ARRIS Group, Inc.
//001DCD ARRIS Group, Inc.
//001DD2 ARRIS Group, Inc.
//4018B1 Aerohive Networks Inc.
//8C09F4 ARRIS Group, Inc.
//8857EE BUFFALO.INC
//101F74, "Hewlett Packard
//009C02 Hewlett Packard
//F4CE46", "Hewlett Packard
//DCFB02 BUFFALO.INC
//001635, "Hewlett Packard
//0008C7 Hewlett Packard
//0010E3, "Hewlett Packard
//000883, "Hewlett Packard
//A02BB8 Hewlett Packard
//0019BB Hewlett Packard
//001F29, "Hewlett Packard
//00215A Hewlett Packard
//00237D, "Hewlett Packard
//E8ED05 ARRIS Group, Inc.
//789684, "ARRIS Group, Inc.
//CC65AD ARRIS Group, Inc.
//002655, "Hewlett Packard
//000D9D, "Hewlett Packard
//001560, "Hewlett Packard
//00207B Intel Corporation
//001175, "Intel Corporation
//780CB8 Intel Corporate
//185E0F, "Intel Corporate
//2C8158 Hon Hai Precision Ind.Co., Ltd.
//8002DF ORA Inc.
//00306E, "Hewlett Packard
//3C4A92 Hewlett Packard
//7C7D3D HUAWEI TECHNOLOGIES CO., LTD
//4482E5, "HUAWEI TECHNOLOGIES CO., LTD
//00234E, "Hon Hai Precision Ind. Co., Ltd.
//2C233A Hewlett Packard
//000A57 Hewlett Packard
//0001E7, "Hewlett Packard
//0001E6, "Hewlett Packard
//002376, "HTC Corporation
//38E7D8, "HTC Corporation
//188796, "HTC Corporation
//B4CEF6 HTC Corporation
//8CDCD4 Hewlett Packard
//D4C9EF", "Hewlett Packard
//FC15B4 Hewlett Packard
//3CA82A Hewlett Packard
//EC5F23", "Qinghai Kimascend Electronics Technology Co.Ltd.
//047D50, "Shenzhen Kang Ying Technology Co.Ltd.
//54EFFE Fullpower Technologies, Inc.
//940937, "HUMAX Co., Ltd.
//E84DD0 HUAWEI TECHNOLOGIES CO., LTD
//0C45BA HUAWEI TECHNOLOGIES CO., LTD
//20906F, "Shenzhen Tencent Computer System Co., Ltd.
//6CE3B6 Nera Telecommunications Ltd.
//DCD321 HUMAX Co., Ltd.
//6C72E7 Apple, Inc.
//741BB2 Apple, Inc.
//6CE873 TP-LINK TECHNOLOGIES CO., LTD.
//C46E1F TP-LINK TECHNOLOGIES CO., LTD.
//50FA84 TP-LINK TECHNOLOGIES CO., LTD.
//44B32D TP-LINK TECHNOLOGIES CO., LTD.
//CC4463 Apple, Inc.
//882593, "TP-LINK TECHNOLOGIES CO., LTD.
//001FE1 Hon Hai Precision Ind.Co., Ltd.
//D85D4C TP-LINK TECHNOLOGIES CO., LTD.
//A0F3C1 TP-LINK TECHNOLOGIES CO., LTD.
//001D0F, "TP-LINK TECHNOLOGIES CO., LTD.
//0023CD TP-LINK TECHNOLOGIES CO., LTD.
//90489A Hon Hai Precision Ind.Co., Ltd.
//0071CC Hon Hai Precision Ind.Co., Ltd.
//B05B67 HUAWEI TECHNOLOGIES CO., LTD
//CCA223", "HUAWEI TECHNOLOGIES CO., LTD
//786A89 HUAWEI TECHNOLOGIES CO., LTD
//384608, "zte corporation
//4CAC0A zte corporation
//B4B362", "zte corporation
//B075D5 zte corporation
//D0154A", "zte corporation
//0026ED, "zte corporation
//006057, "Murata Manufacturing Co., Ltd.
//783E53, "BSkyB Ltd
//0019FB BSkyB Ltd
//C4F57C", "Brocade Communications Systems, Inc.
//14B968 HUAWEI TECHNOLOGIES CO., LTD
//5CF96A HUAWEI TECHNOLOGIES CO., LTD
//0012F2, "Brocade Communications Systems, Inc.
//00051E, "Brocade Communications Systems, Inc.
//083E8E Hon Hai Precision Ind.Co., Ltd.
//002293, "zte corporation
//10A5D0 Murata Manufacturing Co., Ltd.
//50A72B HUAWEI TECHNOLOGIES CO., LTD
//0CD6BD HUAWEI TECHNOLOGIES CO., LTD
//00F81C HUAWEI TECHNOLOGIES CO., LTD
//087A4C HUAWEI TECHNOLOGIES CO., LTD
//ACE215", "HUAWEI TECHNOLOGIES CO., LTD
//346BD3 HUAWEI TECHNOLOGIES CO., LTD
//70723C HUAWEI TECHNOLOGIES CO., LTD
//ACE87B", "HUAWEI TECHNOLOGIES CO., LTD
//F83DFF", "HUAWEI TECHNOLOGIES CO., LTD
//285FDB HUAWEI TECHNOLOGIES CO., LTD
//404D8E, "HUAWEI TECHNOLOGIES CO., LTD
//4C5499 HUAWEI TECHNOLOGIES CO., LTD
//F49FF3", "HUAWEI TECHNOLOGIES CO., LTD
//240995, "HUAWEI TECHNOLOGIES CO., LTD
//84DBAC HUAWEI TECHNOLOGIES CO., LTD
//94772B HUAWEI TECHNOLOGIES CO., LTD
//D440F0", "HUAWEI TECHNOLOGIES CO., LTD
//04021F, "HUAWEI TECHNOLOGIES CO., LTD
//10CDAE Avaya Inc
//048A15 Avaya Inc
//B4B017", "Avaya Inc
//90FB5B Avaya Inc
//C8F406", "Avaya Inc
//7052C5 Avaya Inc
//F81547", "Avaya Inc
//506184, "Avaya Inc
//185936, "Xiaomi Communications Co Ltd
//20A783 miControl GmbH
//200BC7 HUAWEI TECHNOLOGIES CO., LTD
//F84ABF", "HUAWEI TECHNOLOGIES CO., LTD
//78D752, "HUAWEI TECHNOLOGIES CO., LTD
//104780, "HUAWEI TECHNOLOGIES CO., LTD
//548998, "HUAWEI TECHNOLOGIES CO., LTD
//00040D, "Avaya Inc
//70A8E3 HUAWEI TECHNOLOGIES CO., LTD
//F8E811", "HUAWEI TECHNOLOGIES CO., LTD
//F8A45F", "Xiaomi Communications Co Ltd
//640980, "Xiaomi Communications Co Ltd
//94049C HUAWEI TECHNOLOGIES CO., LTD
//688F84, "HUAWEI TECHNOLOGIES CO., LTD
//30D17E, "HUAWEI TECHNOLOGIES CO., LTD
//0050BD Cisco Systems, Inc
//00906F, "Cisco Systems, Inc
//74D6EA Texas Instruments
//209148, "Texas Instruments
//544A16 Texas Instruments
//E02F6D", "Cisco Systems, Inc
//58971E, "Cisco Systems, Inc
//B4E9B0", "Cisco Systems, Inc
//000832, "Cisco Systems, Inc
//189C5D Cisco Systems, Inc
//5CA48A Cisco Systems, Inc
//1C1D86 Cisco Systems, Inc
//60735C Cisco Systems, Inc
//34A84E Cisco Systems, Inc
//54781A Cisco Systems, Inc
//00605C Cisco Systems, Inc
//0006C1 Cisco Systems, Inc
//00E014, "Cisco Systems, Inc
//DCA5F4", "Cisco Systems, Inc
//5017FF Cisco Systems, Inc
//70105C Cisco Systems, Inc
//10F311, "Cisco Systems, Inc
//0050F0, "Cisco Systems, Inc
//005014, "Cisco Systems, Inc
//0090F2, "Cisco Systems, Inc
//0CE0E4 PLANTRONICS, INC.
//74A2E6 Cisco Systems, Inc
//BCF1F2", "Cisco Systems, Inc
//C80084", "Cisco Systems, Inc
//40A6E8 Cisco Systems, Inc
//3085A9 ASUSTek COMPUTER INC.
//B83861 Cisco Systems, Inc
//580A20 Cisco Systems, Inc
//2C3ECF Cisco Systems, Inc
//B05947", "Shenzhen Qihu Intelligent Technology Company Limited
//346288, "Cisco Systems, Inc
//CCD8C1", "Cisco Systems, Inc
//7C0ECE Cisco Systems, Inc
//A0ECF9", "Cisco Systems, Inc
//508789, "Cisco Systems, Inc
//381C1A Cisco Systems, Inc
//BC671C", "Cisco Systems, Inc
//001947, "Cisco SPVTG
//001839, "Cisco-Linksys, LLC
//002215, "ASUSTek COMPUTER INC.
//E0CB4E ASUSTek COMPUTER INC.
//547C69 Cisco Systems, Inc
//001731, "ASUSTek COMPUTER INC.
//DCCEC1 Cisco Systems, Inc
//9C57AD Cisco Systems, Inc
//60FEC5 Apple, Inc.
//E425E7 Apple, Inc.
//BC926B Apple, Inc.
//101C0C Apple, Inc.
//080007, "Apple, Inc.
//004096, "Cisco Systems, Inc
//30F70D, "Cisco Systems, Inc
//E86549", "Cisco Systems, Inc
//B07D47", "Cisco Systems, Inc
//38ED18, "Cisco Systems, Inc
//382056, "Cisco Systems, Inc
//40D32D, "Apple, Inc.
//C42C03 Apple, Inc.
//9027E4, "Apple, Inc.
//109ADD Apple, Inc.
//581FAA Apple, Inc.
//88C663 Apple, Inc.
//001F5B Apple, Inc.
//002436, "Apple, Inc.
//00254B Apple, Inc.
//0016CB Apple, Inc.
//0017F2, "Apple, Inc.
//7C6D62 Apple, Inc.
//20C9D0 Apple, Inc.
//68967B Apple, Inc.
//84FCFE Apple, Inc.
//E48B7F Apple, Inc.
//008865, "Apple, Inc.
//BC3BAF Apple, Inc.
//3CE072 Apple, Inc.
//38484C Apple, Inc.
//A46706 Apple, Inc.
//8C5877 Apple, Inc.
//7CF05F Apple, Inc.
//804971, "Apple, Inc.
//6C3E6D Apple, Inc.
//BC6778 Apple, Inc.
//D8D1CB Apple, Inc.
//A8FAD8 Apple, Inc.
//B817C2 Apple, Inc.
//7C11BE Apple, Inc.
//283737, "Apple, Inc.
//50EAD6 Apple, Inc.
//98D6BB Apple, Inc.
//189EFC Apple, Inc.
//ACCF5C Apple, Inc.
//80006E, "Apple, Inc.
//848E0C Apple, Inc.
//3C15C2 Apple, Inc.
//6C709F Apple, Inc.
//C0F2FB Apple, Inc.
//24E314, "Apple, Inc.
//80E650, "Apple, Inc.
//90FD61 Apple, Inc.
//087045, "Apple, Inc.
//A88808 Apple, Inc.
//A4C361 Apple, Inc.
//2CF0EE Apple, Inc.
//5C97F3 Apple, Inc.
//D4F46F Apple, Inc.
//6476BA Apple, Inc.
//34E2FD Apple, Inc.
//04489A Apple, Inc.
//F0F61C Apple, Inc.
//8C2937 Apple, Inc.
//B09FBA Apple, Inc.
//0C4DE9 Apple, Inc.
//E0F5C6 Apple, Inc.
//A0EDCD Apple, Inc.
//F0F249 Hitron Technologies.Inc
//2857BE Hangzhou Hikvision Digital Technology Co., Ltd.
//5CF5DA Apple, Inc.
//18EE69 Apple, Inc.
//649ABE Apple, Inc.
//F099BF Apple, Inc.
//94E96A Apple, Inc.
//AC293A Apple, Inc.
//9CFC01 Apple, Inc.
//9C35EB Apple, Inc.
//48437C Apple, Inc.
//34A395 Apple, Inc.
//787E61, "Apple, Inc.
//60F81D, "Apple, Inc.
//38C986 Apple, Inc.
//D03311 Apple, Inc.
//507A55 Apple, Inc.
//C8C2C6 Shanghai Airm2m Communication Technology Co., Ltd
//789C85 August Home, Inc.
//74D7CA Panasonic Corporation Automotive
//5882A8 Microsoft
//58685D, "Tempo Australia Pty Ltd
//544B8C Juniper Networks
//DCFE07", "PEGATRON CORPORATION
//707938, "Wuxi Zhanrui Electronic Technology Co., LTD
//243184, "SHARP Corporation
//582BDB Pax AB
//E03676", "HUAWEI TECHNOLOGIES CO., LTD
//EC388F", "HUAWEI TECHNOLOGIES CO., LTD
//D03E5C", "HUAWEI TECHNOLOGIES CO., LTD
//C49E41", "G24 Power Limited
//B813E9", "Trace Live Network
//80B709 Viptela, Inc
//F00D5C", "JinQianMao Technology Co., Ltd.
//54BE53 zte corporation
//280E8B Beijing Spirit Technology Development Co., Ltd.
//F44D30 Elitegroup Computer Systems Co., Ltd.
//0C8610 Juniper Networks
//38D40B Samsung Electronics Co., Ltd
//E83A12", "Samsung Electronics Co., Ltd
//24DA9B Motorola Mobility LLC, a Lenovo Company
//30E090, "Linctronix Ltd,
//A4DCBE HUAWEI TECHNOLOGIES CO., LTD
//ECB870", "Beijing Heweinet Technology Co., Ltd.
//94BBAE Husqvarna AB
//D40AA9", "ARRIS Group, Inc.
//203D66, "ARRIS Group, Inc.
//D494E8 HUAWEI TECHNOLOGIES CO., LTD
//B078F0", "Beijing HuaqinWorld Technology Co., Ltd.
//209BCD Apple, Inc.
//3095E3, "SHANGHAI SIMCOM LIMITED
//80656D, "Samsung Electronics Co., Ltd
//FCF136", "Samsung Electronics Co., Ltd
//B88687", "Liteon Technology Corporation
//18895B Samsung Electronics Co., Ltd
//584925, "E3 Enterprise
//94F278, "Elma Electronic
//283713, "Shenzhen 3Nod Digital Technology Co., Ltd.
//0894EF, "Wistron Infocomm (Zhongshan) Corporation
//E0319E Valve Corporation
//3C5CC3 Shenzhen First Blue Chip Technology Ltd
//C49FF3", "Mciao Technologies, Inc.
//788E33, "Jiangsu SEUIC Technology Co., Ltd
//ECEED8", "ZTLX Network Technology Co., Ltd
//80EB77 Wistron Corporation
//483974, "Proware Technologies Co., Ltd.
//30FFF6 HangZhou KuoHeng Technology Co., ltd
//D8EFCD", "Nokia
//4CC681 Shenzhen Aisat Electronic Co., Ltd.
//48E244, "Hon Hai Precision Ind. Co., Ltd.
//7CAB25 MESMO TECHNOLOGY INC.
//B0411D ITTIM Technologies
//F8BF09", "HUAWEI TECHNOLOGIES CO., LTD
//7CB25C Acacia Communications
//DCDB70", "Tonfunk Systementwicklung und Service GmbH
//800B51 Chengdu XGimi Technology Co., Ltd
//F80D60", "CANON INC.
//F0182B LG Chem
//3481F4, "SST Taiwan Ltd.
//7CA237 King Slide Technology CO., LTD.
//D404CD ARRIS Group, Inc.
//584822, "Sony Mobile Communications Inc
//747336, "MICRODIGTAL Inc
//382B78 ECO PLUGS ENTERPRISE CO., LTD
//A47B2C", "Nokia
//24E5AA Philips Oral Healthcare, Inc.
//78BDBC Samsung Electronics Co., Ltd
//349B5B Maquet GmbH
//884157, "Shenzhen Atsmart Technology Co., Ltd.
//D89A34 Beijing SHENQI Technology Co., Ltd.
//A0A65C Supercomputing Systems AG
//485073, "Microsoft Corporation
//E8377A Zyxel Communications Corporation
//803B2A ABB Xiamen Low Voltage Equipment Co., Ltd.
//C4EA1D Technicolor
//7CF90E Samsung Electronics Co., Ltd
//50F0D3, "Samsung Electronics Co., Ltd
//00A784 ITX security
//84119E, "Samsung Electronics Co., Ltd
//149A10 Microsoft Corporation
//38FACA Skyworth Digital Technology(Shenzhen) Co., Ltd
//5CB43E HUAWEI TECHNOLOGIES CO., LTD
//707781, "Hon Hai Precision Ind. Co., Ltd.
//54E140, "INGENICO
//E4907E", "Motorola Mobility LLC, a Lenovo Company
//746A3A Aperi Corporation
//94A7B7 zte corporation
//1844E6, "zte corporation
//3CCE15 Mercedes-Benz USA, LLC
//287610, "IgniteNet
//20D75A Posh Mobile Limited
//F41563 F5 Networks, Inc.
//8C8B83 Texas Instruments
//4011DC Sonance
//1C8341 Hefei Bitland Information Technology Co.Ltd
//081FEB BinCube
//785F4C Argox Information Co., Ltd.
//34CC28 Nexpring Co.LTD.,
//54E2C8 Dongguan Aoyuan Electronics Technology Co., Ltd
//6C1E70 Guangzhou YBDS IT Co., Ltd
//54B80A D-Link International
//D8ADDD Sonavation, Inc.
//8833BE Ivenix, Inc.
//E48D8C Routerboard.com
//706879, "Saijo Denki International Co., Ltd.
//10AF78 Shenzhen ATUE Technology Co., Ltd
//CC19A8", "PT Inovação e Sistemas SA
//B4B265", "DAEHO I&T
//E03560", "Challenger Supply Holdings, LLC
//3CCB7C TCT mobile ltd
//249EAB HUAWEI TECHNOLOGIES CO., LTD
//244B03 Samsung Electronics Co., Ltd
//E4CE70", "Health & Life co., Ltd.
//7C11CD QianTang Technology
//CCA4AF", "Shenzhen Sowell Technology Co., LTD
//102C83 XIMEA
//6CA75F zte corporation
//8C7967 zte corporation
//7858F3, "Vachen Co., Ltd
//709C8F Nero AG
//007E56, "China Dragon Technology Limited
//74E28C Microsoft Corporation
//0071C2 PEGATRON CORPORATION
//7C8274 Shenzhen Hikeen Technology CO., LTD
//94D417, "GPI KOREA INC.
//244B81 Samsung Electronics Co., Ltd
//704E66, "SHENZHEN FAST TECHNOLOGIES CO., LTD
//D855A3", "zte corporation
//38D82F, "zte corporation
//F07959 ASUSTek COMPUTER INC.
//E08E3C Aztech Electronics Pte Ltd
//844BB7 Beijing Sankuai Online Technology Co., Ltd
//68F0BC Shenzhen LiWiFi Technology Co., Ltd
//300EE3 Aquantia Corporation
//18F145, "NetComm Wireless Limited
//ACABBF", "AthenTek Inc.
//2884FA SHARP Corporation
//60AF6D Samsung Electronics Co., Ltd
//B85A73", "Samsung Electronics Co., Ltd
//3C1E04 D-Link International
//60D9A0 Lenovo Mobile Communication Technology Ltd.
//68B983 b-plus GmbH
//78B3B9 ShangHai sunup lighting CO., LTD
//04C09C Tellabs Inc.
//981DFA Samsung Electronics Co., Ltd
//186882, "Beward R&D Co., Ltd.
//EC8009 NovaSparks
//50ADD5 Dynalec Corporation
//B04519", "TCT mobile ltd
//D88D5C", "Elentec
//7429AF Hon Hai Precision Ind.Co., Ltd.
//3C1A0F ClearSky Data
//E8CC18", "D-Link International
//B09137 ISis ImageStream Internet Solutions, Inc
//8C0551 Koubachi AG
//D897BA", "PEGATRON CORPORATION
//A8D88A Wyconn
//40EACE FOUNDER BROADBAND NETWORK SERVICE CO., LTD
//848EDF Sony Mobile Communications Inc
//A49D49", "Ketra, Inc.
//C03896 Hon Hai Precision Ind.Co., Ltd.
//2C5089 Shenzhen Kaixuan Visual Technology Co., Limited
//948E89, "INDUSTRIAS UNIDAS SA DE CV
//00AEFA Murata Manufacturing Co., Ltd.
//841826, "Osram GmbH
//F8E903 D-Link International
//E89606 testo Instruments (Shenzhen) Co., Ltd.
//1C7E51", "3bumen.com
//6872DC CETORY.TV Company Limited
//3077CB Maike Industry(Shenzhen) CO., LTD
//2497ED, "Techvision Intelligent Technology Limited
//909F33, "EFM Networks
//600417, "POSBANK CO., LTD
//207693, "Lenovo (Beijing) Limited.
//084656, "VEO-LABS
//EC3C5A", "SHEN ZHEN HENG SHENG HUI DIGITAL TECHNOLOGY CO., LTD
//4488CB Camco Technologies NV
//6CBFB5 Noon Technology Co., Ltd
//50294D, "NANJING IOT SENSOR TECHNOLOGY CO, LTD
//0CCFD1 SPRINGWAVE Co., Ltd
//74BADB Longconn Electornics(shenzhen) Co., Ltd
//B8F317", "iSun Smasher Communications Private Limited
//8CF813 ORANGE POLSKA
//549F35, "Dell Inc.
//2442BC Alinco, incorporated
//F82441", "Yeelink
//108A1B RAONIX Inc.
//102F6B Microsoft Corporation
//8CB094 Airtech I&C Co., Ltd
//945493, "Rigado, LLC
//68F06D, "ALONG INDUSTRIAL CO., LIMITED
//F42853", "Zioncom Electronics (Shenzhen) Ltd.
//D4EC86 LinkedHope Intelligent Technologies Co., Ltd
//1C9C26 Zoovel Technologies
//046785, "scemtec Hard- und Software fuer Mess- und Steuerungstechnik GmbH
//D0FA1D", "Qihoo", "360", "Technology Co., Ltd
//AC11D3", "Suzhou HOTEK", "Video Technology Co.Ltd
//8432EA ANHUI WANZTEN P&T CO., LTD
//E01D38", "Beijing HuaqinWorld Technology Co., Ltd
//E47FB2", "FUJITSU LIMITED
//FC6DC0 BME CORPORATION
//24D13F, "MEXUS CO., LTD
//7824AF ASUSTek COMPUTER INC.
//FC9FE1 CONWIN.Tech.Ltd
//B89BE4", "ABB Power Systems Power Generation
//A81B5D", "Foxtel Management Pty Ltd
//505065, "TAKT Corporation
//40C62A Shanghai Jing Ren Electronic Technology Co., Ltd.
//E8150E Nokia Corporation
//C44202", "Samsung Electronics Co., Ltd
//B4AE6F", "Circle Reliance, Inc DBA Cranberry Networks
//90DA6A FOCUS H&S Co., Ltd.
//DC537C Compal Broadband Networks, Inc.
//44A6E5 THINKING TECHNOLOGY CO., LTD
//A45DA1", "ADB Broadband Italia
//0CAC05 Unitend Technologies Inc.
//4C6E6E Comnect Technology CO., LTD
//8C3357 HiteVision Digital Media Technology Co., Ltd.
//3CAA3F iKey, Ltd.
//0C383E Fanvil Technology Co., Ltd.
//60CDA9 Abloomy
//B8AD3E BLUECOM
//183009, "Woojin Industrial Systems Co., Ltd.
//74DBD1 Ebay Inc
//30B5F1 Aitexin Technology Co., Ltd
//B01041", "Hon Hai Precision Ind. Co., Ltd.
//80AD67 Kasda Networks Inc
//18D5B6 SMG Holdings LLC
//5C2E59 Samsung Electronics Co., Ltd
//A8E539", "Moimstone Co., Ltd
//54B753 Hunan Fenghui Yinjia Science And Technology Co., Ltd
//103047, "Samsung Electronics Co., Ltd
//F884F2", "Samsung Electronics Co., Ltd
//B0754D", "Nokia
//E0CBEE", "Samsung Electronics Co., Ltd
//4C3909 HPL Electric & Power Private Limited
//907EBA UTEK TECHNOLOGY (SHENZHEN) CO., LTD
//A002DC", "Amazon Technologies Inc.
//542AA2 Alpha Networks Inc.
//84948C Hitron Technologies.Inc
//A8F7E0", "PLANET Technology Corporation
//4486C1 Siemens Low Voltage & Products
//4045DA Spreadtrum Communications (Shanghai) Co., Ltd.
//3451AA JID GLOBAL
//98BE94 IBM
//6C198F D-Link International
//C8FF77 Dyson Limited
//B49EAC", "Imagik Int'l Corp
//CC07E4 Lenovo Mobile Communication Technology Ltd.
//C46BB4 myIDkey
//0C63FC Nanjing Signway Technology Co., Ltd
//D4E08E", "ValueHD Corporation
//C89F1D SHENZHEN COMMUNICATION TECHNOLOGIES CO., LTD
//143DF2 Beijing Shidai Hongyuan Network Communication Co., Ltd
//2C39C1 Ciena Corporation
//54EE75 Wistron InfoComm(Kunshan) Co., Ltd.
//885BDD Aerohive Networks Inc.
//0874F6, "Winterhalter Gastronom GmbH
//D8492F", "CANON INC.
//800E24, "ForgetBox
//3C25D7 Nokia Corporation
//30A8DB Sony Mobile Communications Inc
//18FF2E Shenzhen Rui Ying Da Technology Co., Ltd
//847207, "I&C Technology
//CCA614 AIFA TECHNOLOGY CORP.
//90F1B0 Hangzhou Anheng Info&Tech CO., LTD
//4C8B30 Actiontec Electronics, Inc
//0805CD DongGuang EnMai Electronic Product Co.Ltd.
//54D163, "MAX-TECH, INC
//48B5A7 Glory Horse Industries Ltd.
//0C4F5A ASA-RT s.r.l.
//D4224E Alcatel Lucent
//9C86DA Phoenix Geophysics Ltd.
//2C073C DEVLINE LIMITED
//7C1A03", "8Locations Co., Ltd.
//ACB859 Uniband Electronic Corp,
//2C9AA4 Eolo SpA
//88B1E1 Mojo Networks, Inc.
//90DB46 E-LEAD ELECTRONIC CO., LTD
//344F5C R&amp; M AG
//6047D4, "FORICS Electronic Technology Co., Ltd.
//FCF8B7 TRONTEQ Electronic
//30F42F, "ESP
//704E01, "KWANGWON TECH CO., LTD.
//746A8F VS Vision Systems GmbH
//54A31B Shenzhen Linkworld Technology Co,.LTD
//CC398C", "Shiningtek
//1820A6 Sage Co., Ltd.
//20EAC7 SHENZHEN RIOPINE ELECTRONICS CO., LTD
//64B370 PowerComm Solutions LLC
//5CF50D Institute of microelectronic applications
//749C52 Huizhou Desay SV Automotive Co., Ltd.
//C4291D KLEMSAN ELEKTRIK ELEKTRONIK SAN.VE TIC.AS.
//6C5F1C Lenovo Mobile Communication Technology Ltd.
//7CE4AA Private
//083F3E, "WSH GmbH
//2C957F zte corporation
//3C0C48 Servergy, Inc.
//10DEE4 automationNEXT GmbH
//F03A4B", "Bloombase, Inc.
//A0E453 Sony Mobile Communications Inc
//404A18 Addrek Smart Solutions
//C0C569 SHANGHAI LYNUC CNC TECHNOLOGY CO., LTD
//C4C0AE", "MIDORI ELECTRONIC CO., LTD.
//ACC595 Graphite Systems
//7CE1FF Computer Performance, Inc.DBA Digital Loggers, Inc.
//D8150D TP-LINK TECHNOLOGIES CO., LTD.
//5850AB TLS Corporation
//7CCD11 MS-Magnet
//98FF6A OTEC(Shanghai) Technology Co., Ltd.
//BC1A67 YF Technology Co., Ltd
//4CD7B6 Helmer Scientific
//8425A4 Tariox Limited
//483D32, "Syscor Controls &amp; Automation
//CC856C", "SHENZHEN MDK DIGITAL TECHNOLOGY CO.,LTD
//AC6BAC", "Jenny Science AG
//D8EE78", "Moog Protokraft
//241148, "Entropix, LLC
//C445EC", "Shanghai Yali Electron Co., LTD
//E0E631", "SNB TECHNOLOGIES LIMITED
//78B5D2 Ever Treasure Industrial Limited
//F8572E", "Core Brands, LLC
//50ED78, "Changzhou Yongse Infotech Co., Ltd
//90028A Shenzhen Shidean Legrand Electronic Products Co., Ltd
//1CC11A Wavetronix
//FC09D8 ACTEON Group
//743ECB Gentrice tech
//7C444C Entertainment Solutions, S.L.
//0444A1 TELECON GALICIA, S.A.
//20C60D Shanghai annijie Information technology Co., LTD
//38CA97 Contour Design LLC
//BC2D98 ThinGlobal LLC
//1879A2 GMJ ELECTRIC LIMITED
//E0C86A SHENZHEN TW-SCIE Co., Ltd
//BCEE7B", "ASUSTek COMPUTER INC.
//3413A8 Mediplan Limited
//7C9763 Openmatics s.r.o.
//48A2B7 Kodofon JSC
//CC7498", "Filmetrics Inc.
//085AE0 Recovision Technology Co., Ltd.
//20E791, "Siemens Healthcare Diagnostics, Inc
//089758, "Shenzhen Strong Rising Electronics Co., Ltd DongGuan Subsidiary
//FC19D0", "Cloud Vision Networks Technology Co., Ltd.
//9486D4, "Surveillance Pro Corporation
//9CD643 D-Link International
//3C18A0 Luxshare Precision Industry Company Limited
//8CAE89 Y-cam Solutions Ltd
//94E98C Nokia
//FCE1D9 Stable Imaging Solutions LLC
//50206B Emerson Climate Technologies Transportation Solutions
//7CBF88 Mobilicom LTD
//60DB2A HNS
//B04545 YACOUB Automation GmbH
//C8EE75 Pishion International Co. Ltd
//CC3429", "TP-LINK TECHNOLOGIES CO., LTD.
//64BABD SDJ Technologies, Inc.
//24C848 mywerk Portal GmbH
//CCFB65 Nintendo Co., Ltd.
//A0A23C GPMS
//68FCB3 Next Level Security Systems, Inc.
//94C3E4 Atlas Copco IAS GmbH
//34885D, "Logitech Far East
//88576D, "XTA Electronics Ltd
//BC4100", "CODACO ELECTRONIC s.r.o.
//FCD817 Beijing Hesun Technologies Co.Ltd.
//682DDC Wuhan Changjiang Electro-Communication Equipment CO., LTD
//E8611F", "Dawning Information Industry Co., Ltd
//2847AA Nokia Corporation
//5CD61F Qardio, Inc
//705957, "Medallion Instrumentation Systems
//9C443D CHENGDU XUGUANG TECHNOLOGY CO, LTD
//B424E7", "Codetek Technology Co., Ltd
//542F89, "Euclid Laboratories, Inc.
//909916, "ELVEES NeoTek OJSC
//00A2FF abatec group AG
//6024C1 Jiangsu Zhongxun Electronic Technology Co., Ltd
//A0143D", "PARROT SA
//FC1BFF V-ZUG AG
//F42896 SPECTO PAINEIS ELETRONICOS LTDA
//78CB33 DHC Software Co., Ltd
//60A9B0 Merchandising Technologies, Inc
//5027C7 TECHNART Co., Ltd
//6C5AB5 TCL Technoly Electronics (Huizhou) Co., Ltd.
//385AA8 Beijing Zhongdun Security Technology Development Co.
//F4A294 EAGLE WORLD DEVELOPMENT CO., LIMITED
//EC3E09", "PERFORMANCE DESIGNED PRODUCTS, LLC
//947C3E Polewall Norge AS
//34A3BF Terewave. Inc.
//8C088B Remote Solution
//B43E3B", "Viableware, Inc
//0C5CD8 DOLI Elektronik GmbH
//3C15EA TESCOM CO., LTD.
//E80410 Private
//F4BD7C Chengdu jinshi communication Co., LTD
//DCC422", "Systembase Limited
//C8F36B Yamato Scale Co., Ltd.
//98F8C1 IDT Technology Limited
//6CD1B0 WING SING ELECTRONICS HONG KONG LIMITED
//A4F522", "CHOFU SEISAKUSHO CO., LTD
//845C93 Chabrier Services
//68E166, "Private
//BC2BD7", "Revogi Innovation Co., Ltd.
//286D97, "SAMJIN Co., Ltd.
//24ECD6 CSG Science & Technology Co., Ltd.Hefei
//CC2A80", "Micro-Biz intelligence solutions Co., Ltd
//60FEF9 Thomas & Betts
//B8DC87", "IAI Corporation
//7C6FF8 ShenZhen ACTO Digital Video Technology Co., Ltd.
//DCF755 SITRONIK
//5C026A Applied Vision Corporation
//0C9301 PT. Prasimax Inovasi Teknologi
//746630, "T:mi Ytti
//6CB350 Anhui comhigher tech co., ltd
//3859F8, "MindMade Sp. z o.o.
//4CDF3D TEAM ENGINEERS ADVANCE TECHNOLOGIES INDIA PVT LTD
//E89218 Arcontia International AB
//0075E1, "Ampt, LLC
//D46A91", "Snap AV
//98CDB4 Virident Systems, Inc.
//A42305 Open Networking Laboratory
//1C48F9 GN Netcom A/S
//B0FEBD", "Private
//60699B isepos GmbH
//D4D50D", "Southwest Microwave, Inc
//34CD6D CommSky Technologies
//E4F3E3", "Shanghai iComhome Co., Ltd.
//9046B7 Vadaro Pte Ltd
//04CF25 MANYCOLORS, INC.
//80BBEB Satmap Systems Ltd
//00B78D Nanjing Shining Electric Automation Co., Ltd
//60FE1E China Palms Telecom.Ltd
//B050BC", "SHENZHEN BASICOM ELECTRONIC CO., LTD.
//841E26, "KERNEL-I Co., LTD
//B4346C", "MATSUNICHI DIGITAL TECHNOLOGY (HONG KONG) LIMITED
//0086A0 Private
//A05B21 ENVINET GmbH
//50B8A2 ImTech Technologies LLC,
//B04C05 Fresenius Medical Care Deutschland GmbH
//B0793C Revolv Inc
//9C4EBF BoxCast
//34A843 KYOCERA Display Corporation
//74CA25 Calxeda, Inc.
//5CA3EB Lokel s.r.o.
//C8B373 Cisco-Linksys, LLC
//0C2AE7 Beijing General Research Institute of Mining and Metallurgy
//983071, "DAIKYUNG VASCOM
//D49524 Clover Network, Inc.
//945047, "Rechnerbetriebsgruppe
//E031D0", "SZ Telstar CO., LTD
//54112F, "Sulzer Pump Solutions Finland Oy
//4C55B8 Turkcell Teknoloji
//088039, "Cisco SPVTG
//E438F2 Advantage Controls
//C4C755", "Beijing HuaqinWorld Technology Co., Ltd
//0C2D89 QiiQ Communications Inc.
//A8D236 Lightware Visual Engineering
//981094, "Shenzhen Vsun communication technology Co., ltd
//A4F3C1", "Open Source Robotics Foundation, Inc.
//141330, "Anakreon UK LLP
//0CF405 Beijing Signalway Technologies Co., Ltd
//5061D6, "Indu-Sol GmbH
//DC7014 Private
//788DF7 Hitron Technologies.Inc
//2C245F Babolat VS
//905692, "Autotalks Ltd.
//04BFA8 ISB Corporation
//8CC7D0 zhejiang ebang communication co., ltd
//B8AE6E", "Nintendo Co., Ltd.
//D0EB03 Zhehua technology limited
//683EEC ERECA
//C42628 Airo Wireless
//30AABD Shanghai Reallytek Information Technology Co., Ltd
//A4B818", "PENTA Gesellschaft für elektronische Industriedatenverarbeitung mbH
//C04DF7 SERELEC
//0C8484 Zenovia Electronics Inc.
//005907, "LenovoEMC Products USA, LLC
//50A715 Aboundi, Inc.
//0C0400 Jantar d.o.o.
//687CD5 Y Soft Corporation, a.s.
//907AF1 Wally
//2CB693 Radware
//A861AA Cloudview Limited
//FC1186", "Logic3 plc
//E01877 FUJITSU LIMITED
//E457A8", "Stuart Manufacturing, Inc.
//789966, "Musilab Electronics (DongGuan) Co., Ltd.
//28CBEB One
//7CA15D GN ReSound A/S
//3C081E Beijing Yupont Electric Power Technology Co., Ltd
//FC58FA", "Shen Zhen Shi Xin Zhong Xin Technology Co., Ltd.
//4CCC34 Motorola Solutions Inc.
//D0D471 MVTECH co., Ltd
//0868D0, "Japan System Design
//D4223F", "Lenovo Mobile Communication Technology Ltd.
//C8EEA6 Shenzhen SHX Technology Co., Ltd
//2481AA KSH International Co., Ltd.
//AC4122 Eclipse Electronic Systems Inc.
//6897E8, "Society of Motion Picture &amp; Television Engineers
//E8E875 iS5 Communications Inc.
//C80E95", "OmniLync Inc.
//30055C Brother industries, LTD.
//080EA8 Velex s.r.l.
//B8C46F PRIMMCON INDUSTRIES INC
//D8B02E Guangzhou Zonerich Business Machine Co., LTD.
//C4E032 IEEE 1904.1 Working Group
//58EB14 Proteus Digital Health
//C458C2 Shenzhen TATFOOK Technology Co., Ltd.
//D0CDE1 Scientech Electronics
//5CE0CA FeiTian United (Beijing) System Technology Co., Ltd.
//E08177 GreenBytes, Inc.
//9C9811 Guangzhou Sunrise Electronics Development Co., Ltd
//B86091", "Onnet Technologies and Innovations LLC
//8C76C1 Goden Tech Limited
//8C078C FLOW DATA INC
//F8DFA8 zte corporation
//A895B0", "Aker Subsea Ltd
//104D77, "Innovative Computer Engineering
//C45DD8", "HDMI Forum
//C4EBE3 RRCN SAS
//94756E, "QinetiQ North America
//4C1A95 Novakon Co., Ltd.
//60BB0C Beijing HuaqinWorld Technology Co, Ltd
//A42C08", "Masterwork Automodules
//10B9FE Lika srl
//301518, "Ubiquitous Communication Co.ltd.
//841715, "GP Electronics (HK) Ltd.
//848E96, "Embertec Pty Ltd
//6499A0 AG Elektronik AB
//08F1B7 Towerstream Corpration
//C044E3", "Shenzhen Sinkna Electronics Co., LTD
//18550F, "Cisco SPVTG
//187A93 AMICCOM Electronics Corporation
//8887DD DarbeeVision Inc.
//30C82A WI-BIZ srl
//88A3CC Amatis Controls
//C0A0C7", "FAIRFIELD INDUSTRIES
//DCA989 MACANDC
//A00363 Robert Bosch Healthcare GmbH
//D0B498", "Robert Bosch LLC Automotive Electronics
//E05597", "Emergent Vision Technologies Inc.
//7C438F E-Band Communications Corp.
//A0E25A Amicus SK, s.r.o.
//D40FB2 Applied Micro Electronics AME bv
//449B78 The Now Factory
//F0F669 Motion Analysis Corporation
//78995C Nationz Technologies Inc
//849DC5 Centera Photonics Inc.
//580943, "Private
//ECFC55", "A.Eberle GmbH & Co.KG
//182A7B Nintendo Co., Ltd.
//68FB95 Generalplus Technology Inc.
//F8F082 NAG LLC
//5C89D4 Beijing Banner Electric Co., Ltd
//54115F, "Atamo Pty Ltd
//8CAE4C Plugable Technologies
//0CC655 Wuxi YSTen Technology Co., Ltd.
//242FFA Toshiba Global Commerce Solutions
//E496AE", "ALTOGRAPHICS Inc.
//4C2258 cozybit, Inc.
//F49466 CountMax, ltd
//F45214", "Mellanox Technologies, Inc.
//1C959F Veethree Electronics And Marine LLC
//0881F4, "Juniper Networks
//10F49A T3 Innovation
//3C57BD Kessler Crane Inc.
//04E9E5 PJRC.COM, LLC
//60BD91 Move Innovation
//CC4BFB", "Hellberg Safety AB
//6CADEF KZ Broadband Technologies, Ltd.
//745FAE TSL PPL
//6851B7 PowerCloud Systems, Inc.
//742D0A Norfolk Elektronik AG
//70F1E5, "Xetawave LLC
//C0AA68 OSASI Technos Inc.
//88D7BC DEP Company
//485A3F WISOL
//60BC4C EWM Hightec Welding GmbH
//1C11E1 Wartsila Finland Oy
//50465D, "ASUSTek COMPUTER INC.
//74BFA1 HYUNTECK
//CC262D Verifi, LLC
//3C8AE5 Tensun Information Technology(Hangzhou) Co., LTD
//2C5AA3 PROMATE ELECTRONIC CO.LTD
//34E0CF zte corporation
//08B738 Lite-On Technogy Corp.
//F8AA8A Axview Technology (Shenzhen) Co., Ltd
//7C0187 Curtis Instruments, Inc.
//54F666, "Berthold Technologies GmbH and Co.KG
//34C803 Nokia Corporation
//F05F5A", "Getriebebau NORD GmbH and Co.KG
//801DAA Avaya Inc
//7C092B Bekey A/S
//842BBC Modelleisenbahn GmbH
//B4009C", "CableWorld Ltd.
//289EDF Danfoss Turbocor Compressors, Inc
//803FD6 bytes at work AG
//784405, "FUJITU(HONG KONG) ELECTRONIC Co., LTD.
//044A50 Ramaxel Technology (Shenzhen) limited company
//0CD9C1 Visteon Corporation
//38A5B6 SHENZHEN MEGMEET ELECTRICAL CO., LTD
//68AB8A RF IDeas
//24EE3A Chengdu Yingji Electronic Hi-tech Co Ltd
//0CC66A Nokia Corporation
//74273C ChangYang Technology (Nanjing) Co., LTD
//087CBE Quintic Corp.
//E804F3 Throughtek Co., Ltd.
//0868EA EITO ELECTRONICS CO., LTD.
//F82285 Cypress Technology CO., LTD.
//C4AD21 MEDIAEDGE Corporation
//E85BF0", "Imaging Diagnostics
//A40BED Carry Technology Co., Ltd
//702393, "fos4X GmbH
//64D814, "Cisco Systems, Inc
//F85F2A", "Nokia Corporation
//C438D3 TAGATEC CO., LTD
//502ECE Asahi Electronics Co., Ltd
//AC14D2", "wi-daq, inc.
//9C4CAE Mesa Labs
//20C1AF i Wit Digital Co., Limited
//80AAA4 USAG
//30AEF6 Radio Mobile Access
//085B0E Fortinet, Inc.
//EC42F0 ADL Embedded Solutions, Inc.
//E8CBA1 Nokia Corporation
//6CE4CE Villiger Security Solutions AG
//649FF7 Kone OYj
//CC912B", "TE Connectivity Touch Solutions
//C05E79 SHENZHEN HUAXUN ARK TECHNOLOGIES CO., LTD
//58BFEA Cisco Systems, Inc
//C401B1", "SeekTech INC
//C0C946 MITSUYA LABORATORIES INC.
//F4600D Panoptic Technology, Inc
//A82BD6", "Shina System Co., Ltd
//ACCF23", "Hi-flying electronics technology Co., Ltd
//609084, "DSSD Inc
//FC1D59 I Smart Cities HK Ltd
//78C4AB Shenzhen Runsil Technology Co., Ltd
//B0A86E", "Juniper Networks
//802AFA Germaneers GmbH
//18421D, "Private
//28C914 Taimag Corporation
//7493A4 Zebra Technologies Corp.
//E47185 Securifi Ltd
//080CC9 Mission Technology Group, dba Magma
//640E94, "Pluribus Networks, Inc.
//0CB4EF Digience Co., Ltd.
//146A0B Cypress Electronics Limited
//F490EA Deciso B.V.
//5CEE79 Global Digitech Co LTD
//4CAA16 AzureWave Technologies (Shanghai) Inc.
//AC40EA C&T Solution Inc.
//002AAF LARsys-Automation GmbH
//1CE165 Marshal Corporation
//4016FA EKM Metering
//0C130B Uniqoteq Ltd.
//2C542D Cisco Systems, Inc
//BC1401", "Hitron Technologies. Inc
//94CA0F Honeywell Analytics
//782544, "Omnima Limited
//A41875 Cisco Systems, Inc
//C8AE9C", "Shanghai TYD Elecronic Technology Co.Ltd
//AC3FA4", "TAIYO YUDEN CO., LTD
//6CAE8B IBM Corporation
//40AC8D Data Management, Inc.
//80CEB1 Theissen Training Systems GmbH
//FC2A54", "Connected Data, Inc.
//045C06 Zmodo Technology Corporation
//747B7A ETH Inc.
//48EA63 Zhejiang Uniview Technologies Co., Ltd.
//E88DF5 ZNYX Networks, Inc.
//90F72F, "Phillips Machine & Welding Co., Inc.
//D05785 Pantech Co., Ltd.
//408B07 Actiontec Electronics, Inc
//284121, "OptiSense Network, LLC
//38458C MyCloud Technology corporation
//10E4AF APR, LLC
//F4EA67", "Cisco Systems, Inc
//2C2D48 bct electronic GesmbH
//28BA18 NextNav, LLC
//AC3D75", "HANGZHOU ZHIWAY TECHNOLOGIES CO., LTD.
//A090DE VEEDIMS, LLC
//642DB7 SEUNGIL ELECTRONICS
//002A6A Cisco Systems, Inc
//F436E1", "Abilis Systems SARL
//781C5A SHARP Corporation
//E80C75", "Syncbak, Inc.
//800A06 COMTEC co., ltd
//608C2B Hanson Technology
//940070, "Nokia Corporation
//BC2C55 Bear Flag Design, Inc.
//0C7523 BEIJING GEHUA CATV NETWORK CO., LTD
//04F021, "Compex Systems Pte Ltd
//2818FD Aditya Infotech Ltd.
//D8B90E Triple Domain Vision Co., Ltd.
//342F6E, "Anywire corporation
//CCEED9 VAHLE Automation GmbH
//005CB1 Gospell DIGITAL TECHNOLOGY CO., LTD
//B08E1A", "URadio Systems Co., Ltd
//D8E952", "KEOPSYS
//BCA4E1", "Nabto
//908FCF UNO System Co., Ltd
//40E793, "Shenzhen Siviton Technology Co., Ltd
//000831, "Cisco Systems, Inc
//34D09B MobilMAX Technology Inc.
//F0007F Janz - Contadores de Energia, SA
//30B3A2 Shenzhen Heguang Measurement & Control Technology Co., Ltd
//506028, "Xirrus Inc.
//0091FA Synapse Product Development
//A05AA4 Grand Products Nevada, Inc.
//F0EEBB VIPAR GmbH
//6CE907 Nokia Corporation
//E4FA1D", "PAD Peripheral Advanced Design Inc.
//1C5C55 PRIMA Cinema, Inc
//34BA9A Asiatelco Technologies Co.
//506441, "Greenlee
//9C1FDD Accupix Inc.
//7CDD11 Chongqing MAS SCI&TECH.Co., Ltd
//B8FD32", "Zhejiang ROICX Microelectronics
//70EE50 Netatmo
//984A47 CHG Hospital Beds
//144978, "Digital Control Incorporated
//2C10C1 Nintendo Co., Ltd.
//8CD17B CG Mobile
//502267, "PixeLINK
//3C6A7D Niigata Power Systems Co., Ltd.
//3C7059 MakerBot Industries
//502690, "FUJITSU LIMITED
//24B657 Cisco Systems, Inc
//C8AF40", "marco Systemanalyse und Entwicklung GmbH
//40984C Casacom Solutions AG
//5C18B5 Talon Communications
//64E161, "DEP Corp.
//8823FE TTTech Computertechnik AG
//B89AED OceanServer Technology, Inc
//C87D77", "Shenzhen Kingtech Communication Equipment Co., Ltd
//94AE61 Alcatel Lucent
//5CCEAD CDYNE Corporation
//AC54EC", "IEEE P1823 Standards Working Group
//709756, "Happyelectronics Co., Ltd
//B820E7", "Guangzhou Horizontal Information & Network Integration Co.Ltd
//00CD90 MAS Elektronik AG
//7C6B52 Tigaro Wireless
//0064A6 Maquet CardioVascular
//988BAD Corintech Ltd.
//D44B5E TAIYO YUDEN CO., LTD.
//640E36, "TAZTAG
//941D1C TLab West Systems AB
//E455EA", "Dedicated Computing
//B05CE5 Nokia Corporation
//3482DE Kiio Inc
//4C5FD2 Alcatel-Lucent
//28C718 Altierre
//7C4C58 Scale Computing, Inc.
//1013EE Justec International Technology INC.
//8C271D QuantHouse
//386077, "PEGATRON CORPORATION
//708105, "Cisco Systems, Inc
//E0ED1A", "vastriver Technology Co., Ltd
//D4F63F", "IEA S.R.L.
//58B0D4 ZuniData Systems Inc.
//64557F, "NSFOCUS Information Technology Co., Ltd.
//00082F, "Cisco Systems, Inc
//9CC7D1 SHARP Corporation
//149090, "KongTop industrial(shen zhen) CO., LTD
//38DE60 Mohlenhoff GmbH
//2839E7, "Preceno Technology Pte.Ltd.
//685E6B PowerRay Co., Ltd.
//20C8B3 SHENZHEN BUL-TECH CO., LTD.
//F8E7B5 µTech Tecnologia LTDA
//D4CEB8 Enatel LTD
//807A7F ABB Genway Xiamen Electrical Equipment CO., LTD
//24DAB6 Sistemas de Gestión Energética S.A.de C.V
//B07D62", "Dipl.-Ing.H.Horstmann GmbH
//B8F5E7 WayTools, LLC
//B81999", "Nesys
//34255D, "Shenzhen Loadcom Technology Co., Ltd
//4CA74B Alcatel Lucent
//D03110", "Ingenic Semiconductor Co., Ltd
//1CE192 Qisda Corporation
//706F81, "Private
//FC0012", "Toshiba Samsung Storage Technolgoy Korea Corporation
//181420, "TEB SAS
//AC81F3 Nokia Corporation
//30688C Reach Technology Inc.
//10EED9 Canoga Perkins Corporation
//94DE0E SmartOptics AS
//C029F3", "XySystem
//AC4AFE", "Hisense Broadband Multimedia Technology Co., Ltd.
//54F5B6 ORIENTAL PACIFIC INTERNATIONAL LIMITED
//90342B Gatekeeper Systems, Inc.
//8CB82C IPitomy Communications
//807DE3 Chongqing Sichuan Instrument Microcircuit Co.LTD.
//DC175A Hitachi High-Technologies Corporation
//C8A1BA Neul Ltd
//C43A9F", "Siconix Inc.
//686E23, "Wi3 Inc.
//DCF05D Letta Teknoloji
//5C16C7 Big Switch Networks
//848F69, "Dell Inc.
//3C096D Powerhouse Dynamics
//900D66, "Digimore Electronics Co., Ltd
//0C924E Rice Lake Weighing Systems
//F49461", "NexGen Storage
//B8CDA7 Maxeler Technologies Ltd.
//5435DF Symeo GmbH
//F43D80", "FAG Industrial Services GmbH
//F0DB30 Yottabyte
//9C31B6 Kulite Semiconductor Products Inc
//A4B36A", "JSC SDO Chromatec
//E4DD79", "En-Vision America, Inc.
//E8CC32 Micronet", "LTD
//D43AE9", "DONGGUAN ipt INDUSTRIAL CO., LTD
//589835, "Technicolor
//8C5CA1 d-broad, INC
//18F650, "Multimedia Pacific Limited
//688470, "eSSys Co., Ltd
//48DCFB Nokia Corporation
//20B7C0 OMICRON electronics GmbH
//8058C5 NovaTec Kommunikationstechnik GmbH
//B8C716 Fiberhome Telecommunication Technologies Co., LTD
//D42C3D", "Sky Light Digital Limited
//A45A1C smart-electronic GmbH
//806459, "Nimbus Inc.
//8C89A5 Micro-Star INT'L CO., LTD
//B4A5A9 MODI GmbH
//E8C320", "Austco Communication Systems Pty Ltd
//C436DA", "Rusteletech Ltd.
//0432F4, "Partron
//1C184A ShenZhen RicherLink Technologies Co., LTD
//0C3956 Observator instruments
//DCA6BD", "Beijing Lanbo Technology Co., Ltd.
//10C586 BIO SOUND LAB CO., LTD.
//10768A EoCell
//F44EFD Actions Semiconductor Co., Ltd.(Cayman Islands)
//24B8D2 Opzoon Technology Co., Ltd.
//A49981 FuJian Elite Power Tech CO., LTD.
//B83A7B Worldplay (Canada) Inc.
//1407E0, "Abrantix AG
//DCCF94 Beijing Rongcheng Hutong Technology Co., Ltd.
//A4DB2E Kingspan Environmental Ltd
//605464, "Eyedro Green Solutions Inc.
//C8FE30 Bejing DAYO Mobile Communication Technology Ltd.
//E4D71D Oraya Therapeutics
//24C9DE Genoray
//54055F, "Alcatel Lucent
//6C5D63 ShenZhen Rapoo Technology Co., Ltd.
//941673, "Point Core SARL
//5C56ED", "3pleplay Electronics Private Limited
//78028F, "Adaptive Spectrum and Signal Alignment (ASSIA), Inc.
//DC16A2 Medtronic Diabetes
//308CFB Dropcam
//D0EB9E Seowoo Inc.
//BCCD45 VOISMART
//143E60, "Nokia
//7032D5, "Athena Wireless Communications Inc
//78510C LiveU Ltd.
//44AAE8 Nanotec Electronic GmbH & Co.KG
//D428B2", "ioBridge, Inc.
//8427CE Corporation of the Presiding Bishop of The Church of Jesus Christ of Latter-day Saints
//48D8FE ClarIDy Solutions, Inc.
//D4945A COSMO CO., LTD
//304C7E Panasonic Electric Works Automation Controls Techno Co., Ltd.
//5CF207 Speco Technologies
//B42A39", "ORBIT MERRET, spol.s r. o.
//70E843, "Beijing C&W Optical Communication Technology Co., Ltd.
//2C7ECF Onzo Ltd
//103711, "Simlink AS
//50E549, "GIGA-BYTE TECHNOLOGY CO., LTD.
//B4B88D Thuh Company
//4C73A5 KOVE
//70A41C Advanced Wireless Dynamics S.L.
//BCBBC9 Kellendonk Elektronik GmbH
//E42AD3 Magneti Marelli S.p.A.Powertrain
//E83EB6", "RIM
//BC35E5", "Hydro Systems Company
//9C5D95 VTC Electronics Corp.
//B8A8AF Logic S.p.A.
//60F673, "TERUMO CORPORATION
//28CCFF Corporacion Empresarial Altra SL
//94FD1D WhereWhen Corp
//4C07C9 COMPUTER OFFICE Co., Ltd.
//F8769B Neopis Co., Ltd.
//74B00C Network Video Technologies, Inc
//E84040", "Cisco Systems, Inc
//D89DB9", "eMegatech International Corp.
//405A9B ANOVO
//E06995 PEGATRON CORPORATION
//84DE3D Crystal Vision Ltd
//D075BE Reno A&E
//BC6E76", "Green Energy Options Ltd
//E828D5 Cots Technology
//F8DAF4", "Taishan Online Technology Co., Ltd.
//08D5C0 Seers Technology Co., Ltd
//6C33A9 Magicjack LP
//108CCF Cisco Systems, Inc
//D8E3AE", "CIRTEC MEDICAL SYSTEMS
//08B7EC Wireless Seismic
//18AF9F DIGITRONIC Automationsanlagen GmbH
//00B342 MacroSAN Technologies Co., Ltd.
//1CF5E7 Turtle Industry Co., Ltd.
//980EE4 Private
//447DA5 VTION INFORMATION TECHNOLOGY (FUJIAN) CO., LTD
//0CCDD3 EASTRIVER TECHNOLOGY CO., LTD.
//E46C21 messMa GmbH
//00B033 OAO Izhevskiy radiozavod
//081735, "Cisco Systems, Inc
//C89C1D", "Cisco Systems, Inc
//E437D7", "HENRI DEPAEPE S.A.S.
//E0A1D7 SFR
//9481A4 Azuray Technologies
//BCE09D", "Eoslink
//9C220E TASCAN Systems GmbH
//7CDD90 Shenzhen Ogemray Technology Co., Ltd.
//0C3C65 Dome Imaging Inc
//C8DF7C Nokia Corporation
//B44CC2", "NR ELECTRIC CO., LTD
//48CB6E Cello Electronics (UK) Ltd
//BC4377 Hang Zhou Huite Technology Co., ltd.
//CC7669 SEETECH
//AC20AA DMATEK Co., Ltd.
//FCAF6A Qulsar Inc
//346F92, "White Rodgers Division
//34BDF9 Shanghai WDK Industrial Co., Ltd.
//CCBE71 OptiLogix BV
//0C469D MS Sedco
//B09AE2", "STEMMER IMAGING GmbH
//14EE9D AirNav Systems LLC
//78D004, "Neousys Technology Inc.
//8895B9 Unified Packet Systems Crop
//D8FE8F", "IDFone Co., Ltd.
//888C19 Brady Corp Asia Pacific Ltd
//448C52 KTIS CO., Ltd
//006DFB Vutrix Technologies Ltd
//841888, "Juniper Networks
//9067B5 Alcatel-Lucent
//E0F379", "Vaddio
//78B6C1 AOBO Telecom Co., Ltd
//08D29A Proformatique
//C89383 Embedded Automation, Inc.
//78A051 iiNet Labs Pty Ltd
//804F58, "ThinkEco, Inc.
//0475F5, "CSST
//8C4DEA Cerio Corporation
//24BA30 Technical Consumer Products, Inc.
//188ED5, "TP Vision Belgium N.V. - innovation site Brugge
//E80C38", "DAEYOUNG INFORMATION SYSTEM CO., LTD
//E08A7E", "Exponent
//A8B0AE", "LEONI
//E42771", "Smartlabs
//34DF2A Fujikon Industrial Co., Limited
//2CDD0C Discovergy GmbH
//40B2C8 Nortel Networks
//70A191 Trendsetter Medical, LLC
//708B78 citygrow technology co., ltd
//64317E, "Dexin Corporation
//3C99F7 Lansentechnology AB
//507D02, "BIODIT
//B4A4E3", "Cisco Systems, Inc
//8C1F94 RF Surgical System Inc.
//4491DB Shanghai Huaqin Telecom Technology Co., Ltd
//14D76E, "CONCH ELECTRONIC Co., Ltd
//AC83F0", "ImmediaTV Corporation
//CC6B98 Minetec Wireless Technologies
//3C04BF PRAVIS SYSTEMS Co.Ltd.,
//94DD3F A+V Link Technologies, Corp.
//F44227 S & S Research Inc.
//C8A729 SYStronics Co., Ltd.
//4454C0 Thompson Aerospace
//C4F464", "Spica international
//602A54 CardioTek B.V.
//BCFFAC TOPCON CORPORATION
//445EF3, "Tonalite Holding B.V.
//68DB96 OPWILL Technologies CO ., LTD
//7C55E7 YSI, Inc.
//70B08C Shenou Communication Equipment Co., Ltd
//C03B8F", "Minicom Digital Signage
//20FEDB M2M Solution S.A.S.
//0C8D98 TOP EIGHT IND CORP
//40C7C9 Naviit Inc.
//7CBB6F Cosco Electronics Co., Ltd.
//94A7BC BodyMedia, Inc.
//C8A1B6 Shenzhen Longway Technologies Co., Ltd
//A8556A", "Pocketnet Technology Inc.
//B4C810 UMPI Elettronica
//64A232 OOO Samlight
//64FC8C Zonar Systems
//D0574C", "Cisco Systems, Inc
//F8DAE2", "NDC Technologies
//705EAA Action Target, Inc.
//34F968, "ATEK Products, LLC
//20B0F7 Enclustra GmbH
//543131, "Raster Vision Ltd
//D0E347", "Yoga
//F0ED1E", "Bilkon Bilgisayar Kontrollu Cih. Im.Ltd.
//C416FA Prysm Inc
//506F9A Wi-Fi Alliance
//842914, "EMPORIA TELECOM Produktions- und VertriebsgesmbH & Co KG
//BC7DD1 Radio Data Comms
//585076, "Linear Equipamentos Eletronicos SA
//F0F9F7 IES GmbH & Co.KG
//38580C Panaccess Systems GmbH
//4451DB Raytheon BBN Technologies
//DCFAD5 STRONG Ges.m.b.H.
//6C8D65 Wireless Glue Networks, Inc.
//9803A0 ABB n.v.Power Quality Products
//CC43E3", "Trump s.a.
//F8C091 Highgates Technology
//AC9B84", "Smak Tecnologia e Automacao
//90F278, "Radius Gateway
//806629, "Prescope Technologies CO., LTD.
//241F2C Calsys, Inc.
//F0BDF1 Sipod Inc.
//646707, "Beijing Omnific Technology, Ltd.
//58FD20 Bravida Sakerhet AB
//ACA016 Cisco Systems, Inc
//58E747, "Deltanet AG
//404022, "ZIV
//A85BB0", "Shenzhen Dehoo Technology Co., Ltd
//44A689 PROMAX ELECTRONICA SA
//40618E, "Stella-Green Co
//68E41F, "Unglaube Identech GmbH
//4C60D5 airPointe of New Hampshire
//888717, "CANON INC.
//6CDC6A Promethean Limited
//9055AE Ericsson, EAB/RWI/K
//1010B6 McCain Inc
//009363, "Uni-Link Technology Co., Ltd.
//D4823E Argosy Technologies, Ltd.
//003532, "Electro-Metrics Corporation
//081FF3 Cisco Systems, Inc
//44376F, "Young Electric Sign Co
//389F83, "OTN Systems N.V.
//BC6A16 tdvine
//003A9D NEC Platforms, Ltd.
//28CD4C Individual Computers GmbH
//8C53F7 A&D ENGINEERING CO., LTD.
//7C7673 ENMAS GmbH
//6C6F18 Stereotaxis, Inc.
//84C727 Gnodal Ltd
//087695, "Auto Industrial Co., Ltd.
//ACCE8F HWA YAO TECHNOLOGIES CO., LTD
//8C9236 Aus.Linx Technology Co., Ltd.
//10C73F Midas Klark Teknik Ltd
//F8912A", "GLP German Light Products GmbH
//44E49A OMNITRONICS PTY LTD
//08F2F4, "Net One Partners Co., Ltd.
//0C7D7C Kexiang Information Technology Co, Ltd.
//3037A6 Cisco Systems, Inc
//DC1D9F", "U & B tech
//D8E72B NetAlly
//785C72 Hioso Technology Co., Ltd.
//580556, "Elettronica GF S.r.L.
//B09074 Fulan Electronics Limited
//94F692, "Geminico co., Ltd.
//68EFBD Cisco Systems, Inc
//F02408", "Talaris (Sweden) AB
//8081A5 TONGQING COMMUNICATION EQUIPMENT (SHENZHEN) Co., Ltd
//B482FE", "ASKEY COMPUTER CORP
//307C30 RIM
//BC4E3C CORE STAFF CO., LTD.
//502A8B Telekom Research and Development Sdn Bhd
//EC43E6", "AWCER Ltd.
//7812B8 ORANTEK LIMITED
//98BC99 Edeltech Co., Ltd.
//F02FD8 Bi2-Vision
//544249, "Sony Corporation
//904716, "RORZE CORPORATION
//10445A Shaanxi Hitech Electronic Co., LTD
//F47626", "Viltechmeda UAB
//0C17F1 TELECSYS
//003A9B Cisco Systems, Inc
//2C3427 ERCO & GENER
//80912A Lih Rong electronic Enterprise Co., Ltd.
//7C2F80 Gigaset Communications GmbH
//10B7F6 Plastoform Industries Ltd.
//448E81, "VIG
//8894F9, "Gemicom Technology, Inc.
//502A7E Smart electronic GmbH
//5C8778 Cybertelbridge co., ltd
//38BB23 OzVision America LLC
//0C8411 A.O.Smith Water Products
//E0ABFE", "Orb Networks, Inc.
//448312, "Star-Net
//A05DE7", "DIRECTV, Inc.
//087618, "ViE Technologies Sdn.Bhd.
//D0E40B Wearable Inc.
//747E1A Red Embedded Design Limited
//14A86B ShenZhen Telacom Science&Technology Co., Ltd
//0CC3A7 Meritec
//DCE2AC Lumens Digital Optics Inc.
//98D88C Nortel Networks
//78192E, "NASCENT Technology
//48EB30 ETERNA TECHNOLOGY, INC.
//4C322D TELEDATA NETWORKS
//AC867E", "Create New Technology (HK) Limited Company
//8C598B C Technologies AB
//D44CA7 Informtekhnika & Communication, LLC
//A8C222", "TM-Research Inc.
//003D41, "Hatteland Computer AS
//CC5076", "Ocom Communications, Inc.
//4CC452 Shang Hai Tyd. Electon Technology Ltd.
//7CCB0D Antaira Technologies, LLC
//C01E9B", "Pixavi AS
//803B9A ghe-ces electronic ag
//743256, "NT-ware Systemprg GmbH
//C4E17C", "U2S co.
//20BFDB DVL
//20415A Smarteh d.o.o.
//A4DA3F Bionics Corp.
//A04025 Actioncable, Inc.
//4C4B68 Mobile Device, Inc.
//201257, "Most Lucky Trading Ltd
//E8DAAA VideoHome Technology Corp.
//647D81, "YOKOTA INDUSTRIAL CO,.LTD
//7CCFCF Shanghai SEARI Intelligent System Co., Ltd
//68AAD2 DATECS LTD.,
//A4DE50 Total Walther GmbH
//1CF061 SCAPS GmbH
//A893E6", "JIANGXI JINGGANGSHAN CKING COMMUNICATION TECHNOLOGY CO., LTD
//C4AAA1", "SUMMIT DEVELOPMENT, spol.s r.o.
//3032D4, "Hanilstm Co., Ltd.
//E064BB DigiView S.r.l.
//DC3350 TechSAT GmbH
//F0BCC8", "MaxID (Pty) Ltd
//24828A Prowave Technologies Ltd.
//68CC9C Mine Site Technologies
//146E0A Private
//0CE709 Fox Crypto B.V.
//B4B5AF Minsung Electronics
//04B3B6 Seamap (UK) Ltd
//00270B Adura Technologies
//00270D, "Cisco Systems, Inc
//00271B Alec Sicherheitssysteme GmbH
//002718, "Suzhou NEW SEAUNION Video Technology Co., Ltd
//6C0F6A JDC Tech Co., Ltd.
//04B466 BSP Co., Ltd.
//D8D67E GSK CNC EQUIPMENT CO., LTD
//0026AE Wireless Measurement Ltd
//0026B1 Navis Auto Motive Systems, Inc.
//0026AA Kenmec Mechanical Engineering Co., Ltd.
//0026D2, "Pcube Systems, Inc.
//0026CD PurpleComm, Inc.
//002707, "Lift Complex DS, JSC
//0026D7, "KM Electornic Technology Co., Ltd.
//0026D0, "Semihalf
//0026FE MKD Technology Inc.
//0026A0 moblic
//0026E5, "AEG Power Solutions
//0026E3, "DTI
//0026BC General Jack Technology Ltd.
//002696, "NOOLIX Co., Ltd
//00269A Carina System Co., Ltd.
//002695, "ZT Group Int'l Inc
//002693, "QVidium Technologies, Inc.
//002665, "ProtectedLogic Corporation
//002660, "Logiways
//002670, "Cinch Connectors
//002671, "AUTOVISION Co., Ltd
//002648, "Emitech Corp.
//002645, "Circontrol S.A.
//00263E, "Trapeze Networks
//00263C Bachmann Technology GmbH & Co.KG
//00263D, "MIA Corporation
//002678, "Logic Instrument SA
//002677, "DEIF A/S
//00268E, "Alta Solutions, Inc.
//002688, "Juniper Networks
//0025DA Secura Key
//0025DB ATI Electronics(Shenzhen) Co., LTD
//0025D5, "Robonica (Pty) Ltd
//0025E2, "Everspring Industry Co., Ltd.
//0025E1, "SHANGHAI SEEYOO ELECTRONIC & TECHNOLOGY CO., LTD
//00260E, "Ablaze Systems, LLC
//002610, "Apacewave Technologies
//00260D, "Mercury Systems, Inc.
//00260A Cisco Systems, Inc
//002632, "Instrumentation Technologies d.d.
//00262E, "Chengdu Jiuzhou Electronic Technology Inc
//00262C IKT Advanced Technologies s.r.o.
//002629, "Juphoon System Software Inc.
//002625, "MediaSputnik
//002626, "Geophysical Survey Systems, Inc.
//0025CC Mobile Communications Korea Incorporated
//0025F9, "GMK electronic design GmbH
//0025F7, "Ansaldo STS USA
//00261B LAUREL BANK MACHINES CO., LTD.
//002614, "KTNF
//002603, "Shenzhen Wistar Technology Co., Ltd
//0025A6 Central Network Solution Co., Ltd.
//0025AA Beijing Soul Technology Co., Ltd.
//002588, "Genie Industries, Inc.
//002580, "Equipson S.A.
//0025BD Italdata Ingegneria dell'Idea S.p.A.
//0025B7 Costar", "electronics, inc.,
//00257D, "PointRed Telecom Private Ltd.
//0025A2 Alta Definicion LINCEO S.L.
//00256D, "Broadband Forum
//00256C Azimut Production Association JSC
//002563, "Luxtera Inc
//002593, "DatNet Informatikai Kft.
//00258E, "The Weather Channel
//0025A3 Trimax Wireless, Inc.
//00259C Cisco-Linksys, LLC
//0025C8 S-Access GmbH
//0025C0 ZillionTV Corporation
//00251B Philips CareServant
//002518, "Power PLUS Communications AG
//002515, "SFR
//00250D, "GZT Telkom-Telmor sp. z o.o.
//00250E, "gt german telematics gmbh
//002531, "Cloud Engines, Inc.
//00252D, "Kiryung Electronics
//002545, "Cisco Systems, Inc
//002542, "Pittasoft
//002536, "Oki Electric Industry Co., Ltd.
//002541, "Maquet Critical Care AB
//00252B Stirling Energy Systems
//002524, "Lightcomm Technology Co., Ltd
//00254E, "Vertex Wireless Co., Ltd.
//002546, "Cisco Systems, Inc
//002522, "ASRock Incorporation
//002560, "Ibridge Networks & Communications Ltd.
//0024B8 free alliance sdn bhd
//0024B3 Graf-Syteco GmbH & Co.KG
//0024F6, "MIYOSHI ELECTRONICS CORPORATION
//0024F0, "Seanodes
//0024CB Autonet Mobile
//0024D1, "Thomson Inc.
//0024C9 Broadband Solutions Group
//0024CA Tobii Technology AB
//002508, "Maquet Cardiopulmonary AG
//0024FC QuoPin Co., Ltd.
//0024FB Private
//0024FA Hilger u.Kern GMBH
//0024D0, "Shenzhen SOGOOD Industry CO., LTD.
//0024CC Fascinations Toys and Gifts, Inc.
//0024C7 Mobilarm Ltd
//0024DF Digitalbox Europe GmbH
//002445, "Adtran Inc
//00243F, "Storwize, Inc.
//002497, "Cisco Systems, Inc
//0024A3 Sonim Technologies Inc
//0024AA Dycor Technologies Ltd.
//0024A9 Ag Leader Technology
//0024A6 TELESTAR DIGITAL GmbH
//00249B Action Star Enterprise Co., Ltd.
//002471, "Fusion MultiSystems dba Fusion-io
//002474, "Autronica Fire And Securirty
//002446, "MMB Research Inc.
//002463, "Phybridge Inc
//002472, "ReDriven Power Inc.
//00241C FuGang Electronic (DG) Co., Ltd
//002419, "Private
//002415, "Magnetic Autocontrol GmbH
//0023E7, "Hinke A/S
//0023E2, "SEA Signalisation
//002425, "Shenzhenshi chuangzhicheng Technology Co., Ltd
//002427, "SSI COMPUTER CORP
//002411, "PharmaSmart LLC
//00240F, "Ishii Tool & Engineering Corporation
//0023FA RG Nets, Inc.
//0023F2, "TVLogic
//00240A US Beverage Net
//002407, "TELEM SAS
//002440, "Halo Monitoring, Inc.
//0023CF CUMMINS-ALLISON CORP.
//0023C2 SAMSUNG Electronics.Co.LTD
//0023C4 Lux Lumen
//0023C5 Radiation Safety and Control Services Inc
//0023C6 SMC Corporation
//002388, "V.T.Telematica S.p.a.
//002386, "Tour & Andersson AB
//002383, "InMage Systems Inc
//002381, "Lengda Technology(Xiamen) Co., Ltd.
//0023BF Mainpine, Inc.
//0023B2 Intelligent Mechatronic Systems Inc
//0023B5 ORTANA LTD
//0023B9 Airbus Defence and Space Deutschland GmbH
//0023BD Digital Ally, Inc.
//0023D5, "WAREMA electronic GmbH
//0023C9 Sichuan Tianyi Information Science & Technology Stock CO., LTD
//0023CE KITA DENSHI CORPORATION
//0023A9 Beijing Detianquan Electromechanical Equipment Co., Ltd
//0023A7 Redpine Signals, Inc.
//00239B Elster Solutions, LLC
//00237B WHDI LLC
//002324, "G-PRO COMPUTER
//0023E0, "INO Therapeutics LLC
//002390, "Algolware Corporation
//002311, "Gloscom Co., Ltd.
//002309, "Janam Technologies LLC
//002304, "Cisco Systems, Inc
//00235D, "Cisco Systems, Inc
//00235C Aprius, Inc.
//002352, "DATASENSOR S.p.A.
//00232F, "Advanced Card Systems Ltd.
//002353, "F E T Elettronica snc
//002342, "Coffee Equipment Company
//002337, "Global Star Solutions ULC
//002319, "Sielox LLC
//00236A SmartRG Inc
//002331, "Nintendo Co., Ltd.
//002335, "Linkflex Co., Ltd
//002325, "IOLAN Holding
//002321, "Avitech International Corp
//002370, "Snell
//0022B9 Analogix Seminconductor, Inc
//0022B8 Norcott
//0022B7 GSS Grundig SAT-Systems GmbH
//0022B3 Sei S.p.A.
//00229C Verismo Networks Inc
//00229A Lastar, Inc.
//0022EE Algo Communication Products Ltd
//0022EA Rustelcom Inc.
//0022F0, "3 Greens Aviation Limited
//0022EC IDEALBT TECHNOLOGY CORPORATION
//0022DD Protecta Electronics Ltd
//0022AB Shenzhen Turbosight Technology Ltd
//00229B AverLogic Technologies, Inc.
//0022BE Cisco Systems, Inc
//0022BF SieAmp Group of Companies
//0022DB Translogic Corporation
//0022DA ANATEK, LLC
//0022F9, "Pollin Electronic GmbH
//0022C5 INFORSON Co, Ltd.
//002262, "BEP Marine
//00226A Honeywell
//002263, "Koos Technical Services, Inc.
//00226C LinkSprite Technologies, Inc.
//00225C Multimedia & Communication Technology
//002284, "DESAY A&V SCIENCE AND TECHNOLOGY CO., LTD
//002286, "ASTRON
//002282, "8086 Consultancy
//002246, "Evoc Intelligent Technology Co., Ltd.
//002248, "Microsoft Corporation
//002290, "Cisco Systems, Inc
//00228A Teratronik elektronische systeme gmbh
//00228E, "TV-NUMERIC
//002254, "Bigelow Aerospace
//002257, "3COM EUROPE LTD
//002276, "Triple EYE B.V.
//002274, "FamilyPhone AB
//002236, "VECTOR SP. Z O.O.
//002230, "FutureLogic Inc.
//00222E, "maintech GmbH
//002214, "RINNAI KOREA
//00220B National Source Coding Center
//00220C Cisco Systems, Inc
//0021EA Bystronic Laser AG
//0021FD LACROIX TRAFFIC S.A.U
//0021CD LiveTV
//0021D0, "Global Display Solutions Spa
//002228, "Breeze Innovations Ltd.
//002229, "Compumedics Ltd
//002216, "SHIBAURA VENDING MACHINE CORPORATION
//0021E1, "Nortel Networks
//002200, "IBM Corp
//0021C6 CSJ Global, Inc.
//0021C3 CORNELL Communications, Inc.
//0021C7 Russound
//0021C1 ABB Oy / Medium Voltage Products
//0021C0 Mobile Appliance, Inc.
//0021BB Riken Keiki Co., Ltd.
//002166, "NovAtel Inc.
//002164, "Special Design Bureau for Seismic Instrumentation
//002160, "Hidea Solutions Co.Ltd.
//0021B1 DIGITAL SOLUTIONS LTD
//0021B0 Tyco Telecommunications
//0021AD Nordic ID Oy
//00217F, "Intraco Technology Pte Ltd
//00217D, "PYXIS S.R.L.
//00216F, "SymCom, Inc.
//0021A3 Micromint
//0021A5 ERLPhase Power Technologies Ltd.
//00219D, "Adesys BV
//002195, "GWD Media Limited
//002188, "EMC Corporation
//00211A LInTech Corporation
//002116, "Transcon Electronic Systems, spol.s r. o.
//002115, "PHYWE Systeme GmbH & Co.KG
//002141, "RADLIVE
//002140, "EN Technologies Inc.
//00213D, "Cermetek Microelectronics, Inc.
//002111, "Uniphone Inc.
//002114, "Hylab Technology Inc.
//002132, "Masterclock, Inc.
//002131, "Blynke Inc.
//002129, "Cisco-Linksys, LLC
//00211D, "Dataline AB
//002120, "Sequel Technologies
//002152, "General Satellite Research & Development Limited
//002158, "Style Flying Technology Co.
//002148, "Kaco Solar Korea
//00213C AliphCom
//001FB5 I/O Interconnect Inc.
//001FE7 Simet
//001FDB Network Supply Corp.,
//001FBF Fulhua Microelectronics Corp. Taiwan Branch
//001FBE Shenzhen Mopnet Industrial Co., Ltd
//001FC2 Jow Tong Technology Co Ltd
//001FD2 COMMTECH TECHNOLOGY MACAO COMMERCIAL OFFSHORE LTD.
//001FB8 Universal Remote Control, Inc.
//001FD4", "4IPNET, INC.
//001FCB NIW Solutions
//001FF7 Nakajima All Precision Co., Ltd.
//001FEB Trio Datacom Pty Ltd
//001F69, "Pingood Technology Co., Ltd.
//001F4D, "Segnetics LLC
//001F81, "Accel Semiconductor Corp
//001F83, "Teleplan Technology Services Sdn Bhd
//001F9B POSBRO
//001F78, "Blue Fox Porini Textile
//001F68, "Martinsson Elektronik AB
//001F63, "JSC Goodwin-Europa
//001FAD Brown Innovations, Inc
//001FA6 Stilo srl
//001F97, "BERTANA srl
//001F8C CCS Inc.
//001F10, "TOLEDO DO BRASIL INDUSTRIA DE BALANCAS", "LTDA
//001F0F, "Select Engineered Systems
//001F02, "Pixelmetrix Corporation Pte Ltd
//001EFE LEVEL s.r.o.
//001F1A Prominvest
//001F18, "Hakusan.Mfg.Co,.Ltd
//001F13, "S.& A.S.Ltd.
//001F25, "MBS GmbH
//001F27, "Cisco Systems, Inc
//001F26, "Cisco Systems, Inc
//001EEF Cantronic International Limited
//001EDE BYD COMPANY LIMITED
//001EDD WASKO S.A.
//001EDB Giken Trastem Co., Ltd.
//001F42, "Etherstack plc
//001F35, "AIR802 LLC
//001F34, "Lung Hwa Electronics Co., Ltd.
//001EEB Talk-A-Phone Co.
//001E6A Beijing Bluexon Technology Co., Ltd
//001E66, "RESOL Elektronische Regelungen GmbH
//001E63, "Vibro-Meter SA
//001E7F, "CBM of America
//001E82, "SanDisk Corporation
//001EB1 Cryptsoft Pty Ltd
//001EAF Ophir Optronics Ltd
//001EAD Wingtech Group Limited
//001ED1, "Keyprocessor B.V.
//001ED0, "Ingespace
//001E8E Hunkeler AG
//001E87, "Realease Limited
//001ECD KYLAND Technology Co. LTD
//001EBF Haas Automation Inc.
//001EBC WINTECH AUTOMATION CO., LTD.
//001E6F, "Magna-Power Electronics, Inc.
//001EA1 Brunata a/s
//001E53, "Further Tech Co., LTD
//001E4E DAKO EDV-Ingenieur- und Systemhaus GmbH
//001E49, "Cisco Systems, Inc
//001E28, "Lumexis Corporation
//001E24, "Zhejiang Bell Technology Co., ltd
//001E20, "Intertain Inc.
//001E1C SWS Australia Pty Limited
//001E12, "Ecolab
//001E16, "Keytronix
//001E32, "Zensys
//001E35, "Nintendo Co., Ltd.
//001E2B Radio Systems Design, Inc.
//001E42, "Teltonika
//001E43, "AISIN AW CO., LTD.
//001E08, "Centec Networks Inc
//001DFB NETCLEUS Systems Corporation
//001DB9 Wellspring Wireless
//001DBB Dynamic System Electronics Corp.
//001DB3 HPN Supply Chain
//001DB1 Crescendo Networks
//001DB4 KUMHO ENG CO., LTD
//001DA4 Hangzhou System Technology CO., LTD
//001D9F, "MATT R.P.Traczynscy Sp.J.
//001D90, "EMCO Flow Systems
//001D93, "Modacom
//001D94, "Climax Technology Co., Ltd
//001D8E, "Alereon, Inc.
//001DDB C-BEL Corporation
//001DE6 Cisco Systems, Inc
//001DE7 Marine Sonic Technology, Ltd.
//001D7B Ice Energy, Inc.
//001D6C ClariPhy Communications, Inc.
//001DC5 Beijing Jiaxun Feihong Electricial Co., Ltd.
//001DC6 SNR Inc.
//001D84, "Gateway, Inc.
//001D85, "Call Direct Cellular Solutions
//001DBF Radiient Technologies, Inc.
//001D34, "SYRIS Technology Corp
//001D32, "Longkay Communication & Technology (Shanghai) Co. Ltd
//001D2A SHENZHEN BUL-TECH CO., LTD.
//001D2D, "Pylone, Inc.
//001D5B Tecvan Informática Ltda
//001D5D, "Control Dynamics Pty.Ltd.
//001D59, "Mitra Energy & Infrastructure
//001D2B Wuhan Pont Technology CO. , LTD
//001D22, "Foss Analytical A/S
//001D23, "SENSUS
//001D3E, "SAKA TECHNO SCIENCE CO., LTD
//001D40, "Intel – GE Care Innovations LLC
//001D57, "CAETEC Messtechnik
//001D51, "Babcock & Wilcox Power Generation Group, Inc
//001D4C Alcatel-Lucent
//001D1A OvisLink S.A.
//001CB7 USC DigiArk Corporation
//001CAF Plato Networks Inc.
//001CB1 Cisco Systems, Inc
//001CFE Quartics Inc
//001D0B, "Power Standards Lab
//001D02, "Cybertech Telecom Development
//001CE9 Galaxy Technology Limited
//001CEA Scientific-Atlanta, Inc
//001CE7 Rocon PLC Research Centre
//001CDB CARPOINT CO., LTD
//001CD5 ZeeVee, Inc.
//001CBC CastGrabber, LLC
//001CE4 EleSy JSC
//001CE2 Attero Tech, LLC.
//001CAA Bellon Pty Ltd
//001CA0 Production Resource Group, LLC
//001CD3 ZP Engineering SEL
//001CCB Forth Corporation Public Company Limited
//001C75 Segnet Ltd.
//001C74 Syswan Technologies Inc.
//001C68 Anhui Sun Create Electronics Co., Ltd
//001C66 UCAMP CO., LTD
//001C98 LUCKY TECHNOLOGY (HK) COMPANY LIMITED
//001C91 Gefen Inc.
//001C81 NextGen Venturi LTD
//001C7A Perfectone Netware Company Ltd
//001C7B Castlenet Technology Inc.
//001C53 Synergy Lighting Controls
//001C4D Aplix IP Holdings Corporation
//001C92 Tervela
//001C8A Cirrascale Corporation
//001C38 Bio-Rad Laboratories, Inc.
//001C30 Mode Lighting (UK ) Ltd.
//001C2E HPN Supply Chain
//001C2A Envisacor Technologies Inc.
//001C02 Pano Logic
//001C05 Nonin Medical Inc.
//001C06 Siemens Numerical Control Ltd., Nanjing
//001BEA Nintendo Co., Ltd.
//001BE5", "802automation Limited
//001BE4 TOWNET SRL
//001C04 Airgain, Inc.
//001C01 ABB Oy Drives
//001BFF Millennia Media inc.
//001BF2 KWORLD COMPUTER CO., LTD
//001BF0 Value Platforms Limited
//001C1B Hyperstone GmbH
//001C10 Cisco-Linksys, LLC
//001BD2 ULTRA-X ASIA PACIFIC Inc.
//001B8D Electronic Computer Systems, Inc.
//001B86 Bosch Access Systems GmbH
//001BC2 Integrated Control Technology Limitied
//001BBB RFTech Co., Ltd
//001BAA XenICs nv
//001B7C A & R Cambridge
//001B5D Vololink Pty Ltd
//001B5A Apollo Imaging Technologies, Inc.
//001B56 Tehuti Networks Ltd.
//001BC6 Strato Rechenzentrum AG
//001BC4 Ultratec, Inc.
//001BA1 Åmic AB
//001B96 General Sensing
//001AEA Radio Terminal Systems Pty Ltd
//001ADD PePWave Ltd
//001AD6 JIAGNSU AETNA ELECTRIC CO., LTD
//001AD4 iPOX Technology Co., Ltd.
//001B14 Carex Lighting Equipment Factory
//001B15 Voxtel, Inc.
//001B09 Matrix Telecom Pvt. Ltd.
//001B03 Action Technology (SZ) Co., Ltd
//001AFB Joby Inc.
//001AFD EVOLIS
//001B1E HART Communication Foundation
//001B4C Signtech
//001AD5 KMC CHAIN INDUSTRIAL CO., LTD.
//001AD0 Albis Technologies AG
//001AD3 Vamp Ltd.
//001AD8 AlsterAero GmbH
//001ADA Biz-2-Me Inc.
//001A6F MI.TEL s.r.l.
//001A71 Diostech Co., Ltd.
//001A69 Wuhan Yangtze Optical Technology CO., Ltd.
//001A67 Infinite QL Sdn Bhd
//001AC3 Scientific-Atlanta, Inc
//001ABF TRUMPF Laser Marking Systems AG
//001AB8 Anseri Corporation
//001ABC U4EA Technologies Ltd
//001ACB Autocom Products Ltd
//001ACF C.T.ELETTRONICA
//001AA3 DELORME
//001A9B ADEC & Parter AG
//001A9D Skipper Wireless, Inc.
//001A85 NV Michel Van de Wiele
//001A8E", "3Way Networks Ltd
//001A44 JWTrading Co., Ltd
//001A49 Micro Vision Co., LTD
//001A3D Ajin Vision Co., Ltd
//001A41 INOCOVA Co., Ltd
//001A33 ASI Communications, Inc.
//001A23 Ice Qube, Inc
//001A1D PChome Online Inc.
//001A17 Teak Technologies, Inc.
//001A1C GT&T Engineering Pte Ltd
//001A1F Coastal Environmental Systems
//001A64 IBM Corp
//001A51 Alfred Mann Foundation
//001A55 ACA-Digital Corporation
//0019E6, "TOYO MEDIC CO., LTD.
//0019E2, "Juniper Networks
//0019E8, "Cisco Systems, Inc
//0019DF Thomson Inc.
//0019DD FEI-Zyfer, Inc.
//0019B2 XYnetsoft Co., Ltd
//0019A4 Austar Technology (hang zhou) Co., Ltd
//0019AA Cisco Systems, Inc
//0019B1 Arrow7 Corporation
//0019B3 Stanford Research Systems
//001A0A Adaptive Micro-Ware Inc.
//001A05 OPTIBASE LTD
//0019D4, "ICX Technologies
//0019CF SALICRU, S.A.
//0019FC PT. Ufoakses Sukses Luarbiasa
//0019F4, "Convergens Oy Ltd
//001996, "TurboChef Technologies Inc.
//001997, "Soft Device Sdn Bhd
//001998, "SATO CORPORATION
//00199C CTRING
//001946, "Cianet Industria e Comercio S/A
//001949, "TENTEL COMTECH CO., LTD.
//001944, "Fossil Partners, L.P.
//001971, "Guangzhou Unicomp Technology Co., Ltd
//001964, "Doorking Inc.
//001976, "Xipher Technologies, LLC
//00196C ETROVISION TECHNOLOGY
//001967, "TELDAT Sp.J.
//001952, "ACOGITO Co., Ltd
//00198B Novera Optics Korea, Inc.
//001961, "Blaupunkt Embedded Systems GmbH
//001942, "ON SOFTWARE INTERNATIONAL LIMITED
//00193F, "RDI technology(Shenzhen) Co., LTD
//001941, "Pitney Bowes, Inc
//0018FD Optimal Technologies International Inc.
//0018F0, "JOYTOTO Co., Ltd.
//0018E9, "Numata Corporation
//001908, "Duaxes Corporation
//00190C Encore Electronics, Inc.
//001919, "ASTEL Inc.
//00192D, "Nokia Corporation
//0018EF, "Escape Communications, Inc.
//0018E6, "Computer Hardware Design SIA
//001930, "Cisco Systems, Inc
//001927, "ImCoSys Ltd
//0018F7, "Kameleon Technologies
//001885, "Avigilon Corporation
//001888, "GOTIVE a.s.
//00188A Infinova LLC
//001886, "EL-TECH, INC.
//001887, "Metasystem SpA
//0018BE ANSA Corporation
//0018BA Cisco Systems, Inc
//0018B4 Dawon Media Inc.
//0018B6 S3C, Inc.
//0018A3 ZIPPY TECHNOLOGY CORP.
//0018A0 Cierma Ascenseurs
//001893, "SHENZHEN PHOTON BROADBAND TECHNOLOGY CO., LTD
//0018B1 IBM Corp
//00187B", "4NSYS Co. Ltd.
//00187F, "ZODIANET
//00187E, "RGB Spectrum
//00189D, "Navcast Inc.
//0018D6, "Swirlnet A/S
//0018CD Erae Electronics Industry Co., Ltd
//0018DB EPL Technology Ltd
//0018C8 ISONAS Inc.
//001849, "nVent, Schroff GmbH
//001846, "Crypto S.A.
//001845, "Pulsar-Telecom LLC.
//00181E, "GDX Technologies Ltd.
//00181C Exterity Limited
//001863, "Veritech Electronics Limited
//00185A uControl, Inc.
//001852, "StorLink Semiconductors, Inc.
//001850, "Secfone Kft
//001858, "TagMaster AB
//001824, "Kimaldi Electronics, S.L.
//00183D, "Vertex Link Corporation
//001825, "Private
//001879, "dSys
//001803, "ArcSoft Shanghai Co.LTD
//0017EF, "IBM Corp
//0017F5, "LIG NEOPTEK
//0017CD CEC Wireless R&D Ltd.
//0017D0, "Opticom Communications, LLC
//0017C6 Cross Match Technologies Inc
//0017FE TALOS SYSTEM INC.
//0017F8, "Motech Industries Inc.
//0017C3 KTF Technologies Inc.
//0017B7 Tonze Technology Co.
//0017AB Nintendo Co., Ltd.
//001807, "Fanstel Corp.
//001808, "SightLogix, Inc.
//0017CE Screen Service Spa
//0017DB CANKO TECHNOLOGIES INC.
//0017D6, "Bluechips Microhouse Co., Ltd.
//001787, "Brother, Brother & Sons ApS
//001789, "Zenitron Corporation
//001760, "Naito Densei Machida MFG.CO., LTD
//001761, "Private
//001768, "Zinwave Ltd
//001769, "Cymphonix Corp
//001762, "Solar Technology, Inc.
//00178F, "NINGBO YIDONG ELECTRONIC CO., LTD.
//001794, "Cisco Systems, Inc
//00178A DARTS TECHNOLOGIES CORP.
//001734, "ADC Telecommunications
//00172E, "FXC Inc.
//00172B Global Technologies Inc.
//001772, "ASTRO Strobel Kommunikationssysteme GmbH
//00173E, "LeucotronEquipamentos Ltda.
//001798, "Azonic Technology Co., LTD
//001747, "Trimble
//00177A ASSA ABLOY AB
//0016F4, "Eidicom Co., Ltd.
//0016E7, "Dynamix Promotions Limited
//0016E5, "FORDLEY DEVELOPMENT LIMITED
//0016E6, "GIGA-BYTE TECHNOLOGY CO., LTD.
//001720, "Image Sensing Systems, Inc.
//00171A Winegard Company
//0016C8 Cisco Systems, Inc
//0016C4 SiRF Technology, Inc.
//0016F3, "CAST Information Co., Ltd
//0016F5, "Dalian Golden Hualu Digital Technology Co., Ltd
//0016F1, "OmniSense, LLC
//0016DD Gigabeam Corporation
//00171C NT MicroSystems, Inc.
//001716, "Qno Technology Inc.
//001726, "m2c Electronic Technology Ltd.
//001721, "FITRE S.p.A.
//0016F9, "CETRTA POT, d.o.o., Kranj
//00170A INEW DIGITAL COMPANY
//0016BD ATI Industrial Automation
//0016C0 Semtech Corporation
//0016C2 Avtec Systems Inc
//0016BA WEATHERNEWS INC.
//0016B2 DriveCam Inc
//0016B3 Photonicbridges (China) Co., Ltd.
//0016AD BT-Links Company Limited
//00166E, "Arbitron Inc.
//0016AF Shenzhen Union Networks Equipment Co., Ltd.
//00169E, "TV One Ltd
//00166A TPS
//001663, "KBT Mobile
//00169F, "Vimtron Electronics Co., Ltd.
//00169A Quadrics Ltd
//001692, "Scientific-Atlanta, Inc.
//001691, "Moser-Baer AG
//001688, "ServerEngines LLC
//00168B Paralan Corporation
//001682, "Pro Dex, Inc
//00160A SWEEX Europe BV
//001602, "CEYON TECHNOLOGY CO., LTD.
//001600, "CelleBrite Mobile Synchronization
//0015F4, "Eventide
//001629, "Nivus GmbH
//001621, "Colorado Vnet
//00161A Dametric AB
//001615, "Nittan Company, Limited
//001616, "BROWAN COMMUNICATION INC.
//001617, "MSI
//00162E, "Space Shuttle Hi-Tech Co., Ltd.
//00162A Antik computers & communications s.r.o.
//001656, "Nintendo Co., Ltd.
//001651, "Exeo Systems
//001610, "Carina Technology
//001606, "Ideal Industries
//001607, "Curves International Inc.
//001654, "Flex-P Industries Sdn.Bhd.
//001631, "Xteam
//00164B Quorion Data Systems GmbH
//001594, "BIXOLON CO., LTD
//001590, "Hectronic GmbH
//00158C Liab ApS
//00158F, "NTT Advanced Technology Corporation
//0015ED, "Fulcrum Microsystems, Inc.
//0015F0, "EGO BV
//0015EE Omnex Control Systems
//0015C8 FlexiPanel Ltd
//0015C0 DIGITAL TELEMEDIA CO., LTD.
//0015C2", "3M Germany
//001588, "Salutica Allied Solutions Sdn Bhd
//001583, "IVT corporation
//001585, "Aonvision Technolopy Corp.
//0015A5 DCI Co., Ltd.
//0015B2 Advanced Industrial Computer, Inc.
//0015DA IRITEL A.D.
//00154A WANSHIH ELECTRONIC CO., LTD
//00154C Saunders Electronics
//00154D, "Netronome Systems, Inc.
//001549, "Dixtal Biomedica Ind.Com.Ltda
//00153D, "ELIM PRODUCT CO.
//001544, "coM.s.a.t.AG
//001539, "Technodrive srl
//001531, "KOCOM
//001535, "OTE Spa
//001536, "Powertech co., Ltd
//00152B Cisco Systems, Inc
//00152C Cisco Systems, Inc
//001528, "Beacon Medical Products LLC d.b.a.BeaconMedaes
//001527, "Balboa Instruments
//001521, "Horoquartz
//001520, "Radiocrafts AS
//001566, "A-First Technology Co., Ltd.
//00156B Perfisans Networks Corp.
//001547, "AiZen Solutions Inc.
//001579, "Lunatone Industrielle Elektronik GmbH
//0014D7, "Datastore Technology Corp
//0014DD Covergence Inc.
//0014D4, "K Technology Corporation
//0014CF INVISIO Communications
//0014BE Wink communication technology CO.LTD
//001511, "Data Center Systems
//00150E, "OPENBRAIN TECHNOLOGIES CO., LTD.
//00150D, "Hoana Medical, Inc.
//00151C LENECO
//001519, "StoreAge Networking Technologies
//001506, "Neo Photonics
//001504, "GAME PLUS CO., LTD.
//001505, "Actiontec Electronics, Inc
//0014FE Artech Electronics
//0014DE Sage Instruments Inc.
//0014DF HI-P Tech Corporation
//0014E6, "AIM Infrarotmodule GmbH
//0014F3, "ViXS Systems Inc
//00147E, "InnerWireless
//00147D, "Aeon Digital International
//001476, "MultiCom Industries Limited
//001473, "Bookham Inc
//001489, "B15402100 - JANDEI, S.L.
//001480, "Hitachi-LG Data Storage Korea, Inc
//0014B6 Enswer Technology Inc.
//0014B2 mCubelogics Corporation
//0014AE Wizlogics Co., Ltd.
//0014A6 Teranetics, Inc.
//001469, "Cisco Systems, Inc
//0014BA Carvers SA de CV
//00148A Elin Ebg Traction Gmbh
//001491, "Daniels Electronics Ltd.dbo Codan Rado Communications
//00146E, "H.Stoll GmbH & Co.KG
//0014AA Ashly Audio, Inc.
//001409, "MAGNETI MARELLI", " S.E.S.p.A.
//00140B FIRST INTERNATIONAL COMPUTER, INC.
//0013FD Nokia Danmark A/S
//001400, "MINERVA KOREA CO., LTD
//0013FC SiCortex, Inc
//0013F6, "Cintech
//00144F, "Oracle Corporation
//001456, "Edge Products
//001450, "Heim Systems GmbH
//001452, "CALCULEX, INC.
//001442, "ATTO CORPORATION
//001447, "BOAZ Inc.
//00143E, "AirLink Communications, Inc.
//00145D, "WJ Communications, Inc.
//00143B Sensovation AG
//00142D, "Toradex AG
//001429, "V Center Technologies Co., Ltd.
//001414, "Jumpnode Systems LLC.
//00141E, "P.A.Semi, Inc.
//0013CB Zenitel Norway AS
//0013CF", "4Access Communications
//0013BE Virtual Conexions
//0013B9 BM SPA
//0013AB Telemotive AG
//0013C9 Beyond Achieve Enterprises Ltd.
//0013C6 OpenGear, Inc
//0013F3, "Giga-byte Communications Inc.
//0013F4, "Psitek (Pty) Ltd
//0013AC Sunmyung Electronics Co., LTD
//0013A8 Tanisys Technology
//0013DA Diskware Co., Ltd
//0013D8, "Princeton Instruments
//001399, "STAC Corporation.
//0013E9, "VeriWave, Inc.
//001395, "congatec AG
//001356, "FLIR Radiation Inc
//00135A Project T&E Limited
//001361, "Biospace Co., Ltd.
//001362, "ShinHeung Precision Co., Ltd.
//00134F, "Rapidus Wireless Networks Inc.
//001378, "Qsan Technology, Inc.
//00137A Netvox Technology Co., Ltd.
//001381, "CHIPS & Systems, Inc.
//001379, "PONDER INFORMATION INDUSTRIES LTD.
//00132C MAZ Brandenburg GmbH
//001324, "Schneider Electric Ultra Terminal
//001326, "ECM Systems Ltd
//001327, "Data Acquisitions limited
//001367, "Narayon.Co., Ltd.
//00135C OnSite Systems, Inc.
//00135F, "Cisco Systems, Inc
//00133B Speed Dragon Multimedia Limited
//001338, "FRESENIUS-VIAL
//00132D, "iWise Communications
//001374, "Atheros Communications, Inc.
//001369, "Honda Electron Co., LED.
//001342, "Vision Research, Inc.
//001340, "AD.EL s.r.l.
//00130C HF System Corporation
//00130F, "EGEMEN Bilgisayar Muh San ve Tic LTD STI
//001313, "GuangZhou Post & Telecom Equipment ltd
//0012CB CSS Inc.
//0012CE Advanced Cybernetics Group
//0012CA Mechatronic Brick Aps
//0012C7 SECURAY Technologies Ltd.Co.
//0012CD ASEM SpA
//0012E8, "Fraunhofer IMS
//0012DD Shengqu Information Technology (Shanghai) Co., Ltd.
//00131D, "Scanvaegt International A/S
//001318, "DGSTATION Co., Ltd.
//00131A Cisco Systems, Inc
//0012F4, "Belco International Co., Ltd.
//0012F5, "Imarda New Zealand Limited
//0012E0, "Codan Limited
//0012DE Radio Components Sweden AB
//001301, "IronGate S.L.
//0012F6, "MDK CO., LTD.
//0012F1, "IFOTEC
//0012F8, "WNI Resources, LLC
//00127C SWEGON AB
//001278, "International Bar Code
//00127A Sanyu Industry Co., Ltd.
//001268, "IPS d.o.o.
//0012AC ONTIMETEK INC.
//0012BC Echolab LLC
//0012BD Avantec Manufacturing Limited
//0012AB WiLife, Inc.
//00129B E2S Electronic Engineering Solutions, S.L.
//001298, "MICO ELECTRIC(SHENZHEN) LIMITED
//001272, "Redux Communications Ltd.
//00126A OPTOELECTRONICS Co., Ltd.
//0012C0 HotLava Systems, Inc.
//0012B7 PTW Freiburg
//0012A1 BluePacket Communications Co., Ltd.
//001206, "iQuest (NZ) Ltd
//001207, "Head Strong International Limited
//001209, "Fastrax Ltd
//00120B Chinasys Technologies Limited
//001205, "Terrasat Communications, Inc.
//001238, "SetaBox Technology Co., Ltd.
//00123C Second Rule LLC
//00123E, "ERUNE technology Co., Ltd.
//001254, "Spectra Technologies Holdings Company Ltd
//00124F, "nVent
//001221, "B.Braun Melsungen AG
//001212, "PLUS Corporation
//001213, "Metrohm AG
//001218, "ARUZE Corporation
//001249, "Delta Elettronica S.p.A.
//00124D, "Inducon BV
//001266, "Swisscom Hospitality Services SA
//00125E, "CAEN
//00125D, "CyberNet Inc.
//001223, "Pixim
//00123A Posystech Inc., Co.
//001234, "Camille Bauer
//0011E3, "Thomson, Inc.
//0011DC Glunz & Jensen
//001196, "Actuality Systems, Inc.
//001187, "Category Solutions, Inc
//001190, "Digital Design Corporation
//0011C4 Terminales de Telecomunicacion Terrestre, S.L.
//0011CB Jacobsons AB
//0011F7, "Shenzhen Forward Industry Co., Ltd
//0011D3, "NextGenTel Holding ASA
//0011AB TRUSTABLE TECHNOLOGY CO., LTD.
//0011A5 Fortuna Electronic Corp.
//00113C Micronas GmbH
//001131, "UNATECH.CO., LTD
//001127, "TASI, Inc
//00112A Niko NV
//00112B NetModule AG
//00116F, "Netforyou Co., LTD.
//001171, "DEXTER Communications, Inc.
//001167, "Integrated System Solution Corp.
//00116D, "American Time and Signal
//001160, "ARTDIO Company Co., LTD
//001154, "Webpro Technologies Inc.
//001145, "ValuePoint Networks
//001151, "Mykotronx
//00114E, "690885 Ontario Inc.
//00112D, "iPulse Systems
//00117B Büchi", "Labortechnik AG
//000FEE XTec, Incorporated
//000FE4 Pantech Co., Ltd
//000FE7 Lutron Electronics Co., Inc.
//000FE6 MBTech Systems, Inc.
//000FDA YAZAKI CORPORATION
//000FEF Thales e-Transactions GmbH
//000FE9 GW TECHNOLOGIES CO., LTD.
//000FE1 ID DIGITAL CORPORATION
//000FDF SOLOMON Technology Corp.
//000FFE G-PRO COMPUTER
//00110B Franklin Technology Systems
//001105, "Sunplus Technology Co., Ltd.
//001102, "Aurora Multimedia Corp.
//001123, "Appointech, Inc.
//00110F, "netplat, Inc.
//000FD6 Sarotech Co., Ltd
//001115, "EPIN Technologies, Inc.
//000FC7 Dionica R&D Ltd.
//000F64, "D&R Electronica Weesp BV
//000F75, "First Silicon Solutions
//000F7C ACTi Corporation
//000F7A BeiJing NuQX Technology CO., LTD
//000FAD FMN communications GmbH
//000FAB Kyushu Electronics Systems Inc.
//000FAC IEEE 802.11
//000F72, "Sandburst
//000FB3 Actiontec Electronics, Inc
//000F9C Panduit Corp
//000FC8 Chantry Networks
//000FBB Nokia Siemens Networks GmbH & Co.KG.
//000FBC Onkey Technologies, Inc.
//000FB6 Europlex Technologies
//000FB9 Adaptive Instruments
//000F98, "Avamax Co. Ltd.
//000F97, "Avanex Corporation
//000F96, "Telco Systems, Inc.
//000F8B Orion MultiSystems Inc
//000F8C Gigawavetech Pte Ltd
//000F38, "Netstar
//000F3A HISHARP
//000F30, "Raza Microelectronics Inc
//000F53, "Solarflare Communications Inc.
//000F51, "Azul Systems, Inc.
//000F07, "Mangrove Systems, Inc.
//000F00, "Legra Systems, Inc.
//000F01, "DIGITALKS INC
//000F03, "COM&C CO., LTD
//000F34, "Cisco Systems, Inc
//000F2E, "Megapower International Corp.
//000F26, "WorldAccxx LLC
//000F45, "Stretch, Inc.
//000F3B Fuji System Machines Co., Ltd.
//000F37, "Xambala Incorporated
//000F54, "Entrelogic Corporation
//000F25, "AimValley B.V.
//000F19, "Boston Scientific
//000F10, "RDM Corporation
//000EA8 United Technologists Europe Limited
//000EAA Scalent Systems, Inc.
//000EAC MINTRON ENTERPRISE CO., LTD.
//000EAE GAWELL TECHNOLOGIES CORP.
//000EBA HANMI SEMICONDUCTOR CO., LTD.
//000EBC Paragon Fidelity GmbH
//000EC5 Digital Multitools Inc
//000EC7 Motorola Korea
//000E8B Astarte Technology Co, Ltd.
//000EDF PLX Technology
//000EE1 ExtremeSpeed Inc.
//000ED7, "Cisco Systems, Inc
//000ED3, "Epicenter, Inc.
//000E9D, "Tiscali UK Ltd
//000E47, "NCI System Co., Ltd.
//000E46, "Niigata Seimitsu Co., Ltd.
//000E1F, "TCL Networks Equipment Co., Ltd.
//000E26, "Gincom Technology Corp.
//000E6C Device Drivers Limited
//000E6B Janitza electronics GmbH
//000E5F, "activ-net GmbH & Co.KG
//000E57, "Iworld Networking, Inc.
//000E51, "tecna elettronica srl
//000E67, "Eltis Microelectronics Ltd.
//000E65, "TransCore
//000E43, "G-Tek Electronics Sdn.Bhd.
//000E44, "Digital 5, Inc.
//000E74, "Solar Telecom. Tech
//000E7A GemWon Communications Co., Ltd.
//000E80, "Thomson Technology Inc
//000E85, "Catalyst Enterprises, Inc.
//000E32, "Kontron Medical
//000E0B Netac Technology Co., Ltd.
//000E11, "BDT Büro und Datentechnik GmbH & Co.KG
//000DF5 Teletronics International Inc.
//000DF7 Space Dynamics Lab
//000DEB CompXs Limited
//000DEE Andrew RF Power Amplifier Group
//000DEF Soc. Coop.Bilanciai
//000DE7 Snap-on OEM Group
//000DC6 DigiRose Technology Co., Ltd.
//000DC1 SafeWeb Inc
//000DF0 QCOM TECHNOLOGY INC.
//000DE5 Samsung Thales
//000DC0 Spagat AS
//000DDD Profilo Telra Elektronik Sanayi ve Ticaret.A.Ş
//000DF8 ORGA Kartensysteme GmbH
//000E16, "SouthWing S.L.
//000DA7 Private
//000DAD Dataprobe, Inc.
//000DA9 T.E.A.M.S.L.
//000DAB Parker Hannifin GmbH Electromechanical Division Europe
//000DA8 Teletronics Technology Corporation
//000D79, "Dynamic Solutions Co,.Ltd.
//000D6D, "K-Tech Devices Corp.
//000DAF Plexus Corp (UK) Ltd
//000DB1 Japan Network Service Co., Ltd.
//000D83, "Sanmina-SCI Hungary", "Ltd.
//000D7F, "MIDAS COMMUNICATION TECHNOLOGIES PTE LTD (Foreign Branch)
//000D75, "Kobian Pte Ltd - Taiwan Branch
//000D78, "Engineering & Security
//000D9E, "TOKUDEN OHIZUMI SEISAKUSYO Co., Ltd.
//000DA3 Emerging Technologies Limited
//000DA4 DOSCH & AMAND SYSTEMS AG
//000D9A INFOTEC LTD
//000D6E, "K-Patents Oy
//000D6A Redwood Technologies LTD
//000DBA Océ Document Technologies GmbH
//000DBD Cisco Systems, Inc
//000DB5 GLOBALSAT TECHNOLOGY CORPORATION
//000D97, "ABB Inc./Tropos
//000D96, "Vtera Technology Inc.
//000D8B T&D Corporation
//000D90, "Factum Electronics AB
//000D85, "Tapwave, Inc.
//000D82, "PHSNET
//000D23, "Smart Solution, Inc
//000D27, "MICROPLEX Printware AG
//000D1B Kyoto Electronics Manufacturing Co., Ltd.
//000D1D, "HIGH-TEK HARNESS ENT.CO., LTD.
//000D02, "NEC Platforms, Ltd.
//000D07, "Calrec Audio Ltd
//000D40, "Verint Loronix Video Solutions
//000D21, "WISCORE Inc.
//000D09, "Yuehua(Zhuhai) Electronic CO.LTD
//000D37, "WIPLUG
//000D33, "Prediwave Corp.
//000D2F, "AIN Comm.Tech.Co., LTD
//000D5D, "Raritan Computer, Inc
//000D63, "DENT Instruments, Inc.
//000D66, "Cisco Systems, Inc
//000CCD IEC - TC57
//000CCB Design Combus Ltd
//000CC9 ILWOO DATA & TECHNOLOGY CO., LTD
//000CE9 BLOOMBERG L.P.
//000CEA aphona Kommunikationssysteme
//000CDA FreeHand Systems, Inc.
//000CF5 InfoExpress
//000CEE jp-embedded
//000CAF TRI TERM CO., LTD.
//000CB3 ROUND Co., Ltd.
//000CDD AOS technologies AG
//000CA5 Naman NZ LTd
//000CA9 Ebtron Inc.
//000CFB Korea Network Systems
//000C7A DaTARIUS Technologies GmbH
//000C79 Extel Communications P/L
//000C75 Oriental integrated electronics. LTD
//000C5D CHIC TECHNOLOGY (CHINA) CORP.
//000C4F UDTech Japan Corporation
//000C62 ABB AB, Cewe-Control
//000C4C Arcor AG&Co.
//000C47 SK Teletech(R&D Planning Team)
//000C6D Edwards Ltd.
//000C70 ACC GmbH
//000C6A MBARI
//000C6B Kurz Industrie-Elektronik GmbH
//000C9D UbeeAirWalk, Inc.
//000C9F NKE Corporation
//000C84 Eazix, Inc.
//000C85 Cisco Systems, Inc
//000C3F Cogent Defence & Security Networks,
//000C30 Cisco Systems, Inc
//000C9A Hitech Electronics Corp.
//000C91 Riverhead Networks Inc.
//000BDA EyeCross Co., Inc.
//000BD6 Paxton Access Ltd
//000BD4 Beijing Wise Technology & Science Development Co.Ltd
//000C1F Glimmerglass Networks
//000C20 Fi WIn, Inc.
//000C15 CyberPower Systems, Inc.
//000BF8 Infinera
//000BFF Berkeley Camera Engineering
//000C16 Concorde Microsystems Inc.
//000C09 Hitachi IE Systems Co., Ltd
//000BE7 COMFLUX TECHNOLOGY INC.
//000BEC NIPPON ELECTRIC INSTRUMENT, INC.
//000C02 ABB Oy
//000B71 Litchfield Communications Inc.
//000B74 Kingwave Technology Co., Ltd.
//000B73 Kodeos Communications
//000B76 ET&T Technology Co.Ltd.
//000B5E Audio Engineering Society Inc.
//000B60 Cisco Systems, Inc
//000B65 Sy.A.C.srl
//000B5F Cisco Systems, Inc
//000B61 Friedrich Lütze GmbH & Co.KG
//000B59 ScriptPro, LLC
//000B5C Newtech Co., Ltd
//000B7E SAGINOMIYA Seisakusho Inc.
//000B80 Lycium Networks
//000BA7 Maranti Networks
//000BAA Aiphone co., Ltd
//000BA4 Shiron Satellite Communications Ltd. (1996)
//000BD0 XiMeta Technology Americas Inc.
//000BC5 SMC Networks, Inc.
//000BC6 ISAC, Inc.
//000BC1 Bay Microsystems, Inc.
//000B8B KERAJET, S.A.
//000B89 Top Global Technology, Ltd.
//000B99 SensAble Technologies, Inc.
//000B9C TriBeam Technologies, Inc.
//000B7C Telex Communications
//000B83 DATAWATT B.V.
//000B20 Hirata corporation
//000B22 Environmental Systems and Services
//000B1B Systronix, Inc.
//000B03 Taekwang Industrial Co., Ltd
//000B01 DAIICHI ELECTRONICS CO., LTD.
//000B3E BittWare, Inc
//000B29 LS(LG) Industrial Systems co., Ltd
//000B39 Keisoku Giken Co., Ltd.
//000B3A QuStream Corporation
//000B33 Vivato Technologies
//000B05 Pacific Broadband Networks
//000B00 FUJIAN START COMPUTER EQUIPMENT CO., LTD
//000B5B Rincon Research Corporation
//000AF6 Emerson Climate Technologies Retail Solutions, Inc.
//000B11 HIMEJI ABC TRADING CO., LTD.
//000B41 Ing. Büro Dr. Beutlhauser
//000AEA ADAM ELEKTRONIK LTD. ŞTI
//000AE3 YANG MEI TECHNOLOGY CO., LTD
//000ADC RuggedCom Inc.
//000AB7 Cisco Systems, Inc
//000AAD Stargames Corporation
//000AB1 GENETEC Corporation
//000AB9 Astera Technologies Corp.
//000A90 Bayside Interactive, Inc.
//000A9D King Young Technology Co.Ltd.
//000AA1 V V S Limited
//000AA4 SHANGHAI SURVEILLANCE TECHNOLOGY CO, LTD
//000A9E BroadWeb Corportation
//000AE0 Fujitsu Softek
//000A8B Cisco Systems, Inc
//000A88 InCypher S.A.
//000ABB Taiwan Secom Co,. Ltd
//000A7C Tecton Ltd
//000A6E Harmonic, Inc
//000A6D EKS Elektronikservice GmbH
//000A43 Chunghwa Telecom Co., Ltd.
//000A45 Audio-Technica Corp.
//000A35 Xilinx
//000A3B GCT Semiconductor, Inc
//000A74 Manticom Networks Inc.
//000A6F ZyFLEX Technologies Inc
//000A63 DHD GmbH
//000A2E MAPLE NETWORKS CO., LTD
//000A2D Cabot Communications Limited
//000A25 CERAGON NETWORKS
//000A21 Integra Telecom Co. Ltd
//000A1E Red-M Products Limited
//000A4B DataPower Technology, Inc.
//000A33 Emulex Corporation
//000A67 OngCorp
//0009F9, "ART JAPAN CO., LTD.
//0009FC IPFLEX Inc.
//0009FD Ubinetics Limited
//0009F7, "SED, a division of Calian
//0009E2, "Sinbon Electronics Co., Ltd.
//0009DA Control Module Inc.
//0009D7, "DC Security Products
//0009D8, "Fält Communications AB
//000A14 TECO a.s.
//000A0B Sealevel Systems, Inc.
//000A10 FAST media integrations AG
//0009DB eSpace
//0009D5, "Signal Communication, Inc.
//0009D3, "Western DataCom Co., Inc.
//0009BC Utility, Inc
//0009BE Mamiya-OP Co., Ltd.
//0009E6, "Cyber Switching Inc.
//0009FB Philips Patient Monitoring
//00098F, "Cetacean Networks
//000987, "NISHI NIPPON ELECTRIC WIRE & CABLE CO., LTD.
//000989, "VividLogic Inc.
//000986, "Metalink LTD.
//00098C Option Wireless Sweden
//000985, "Auto Telecom Company
//00098D, "Velocity Semiconductor
//000981, "Newport Networks
//000955, "Young Generation International Corp.
//00094A Homenet Communications
//00094B FillFactory NV
//00094D, "Braintree Communications Pty Ltd
//000950, "Independent Storage Corporation
//000954, "AMiT spol. s.r.o.
//000992, "InterEpoch Technology, INC.
//000995, "Castle Technology Ltd
//000998, "Capinfo Company Limited
//0009B6 Cisco Systems, Inc
//0009B3 MCM Systems Ltd
//00095C Philips Medical Systems - Cardiac and Monitoring Systems (CM
//000958, "INTELNET S.A.
//0009A3 Leadfly Techologies Corp. Ltd.
//0009A5 HANSUNG ELETRONIC INDUSTRIES DEVELOPMENT CO., LTD
//000962, "Sonitor Technologies AS
//00095D, "Dialogue Technology Corp.
//00099A ELMO COMPANY, LIMITED
//00099C Naval Research Laboratory
//000984, "MyCasa Network Inc.
//00092B iQstor Networks, Inc.
//000926, "YODA COMMUNICATIONS, INC.
//000927, "TOYOKEIKI CO., LTD.
//000923, "Heaman System Co., Ltd
//00091D, "Proteam Computer Corporation
//0008EB ROMWin Co., Ltd.
//0008E8, "Excel Master Ltd.
//0008DC Wiznet
//0008DD Telena Communications, Inc.
//0008E1, "Barix AG
//000909, "Telenor Connect A/S
//00090A SnedFar Technology Co., Ltd.
//00090F, "Fortinet Inc.
//00092C Hitpoint Inc.
//000903, "Panasas, Inc
//000907, "Chrysalis Development
//000906, "Esteem Networks
//000952, "Auerswald GmbH & Co.KG
//000944, "Cisco Systems, Inc
//0008FB SonoSite, Inc.
//0008EE Logic Product Development
//000917, "WEM Technology Inc
//000881, "DIGITAL HANDS CO., LTD.
//000882, "SIGMA CORPORATION
//000873, "DapTechnology B.V.
//00087A Wipotec GmbH
//000871, "NORTHDATA Co., Ltd.
//0008B2 SHENZHEN COMPASS TECHNOLOGY DEVELOPMENT CO., LTD
//0008B1 ProQuent Systems
//0008AF Novatec Corporation
//0008A6 Multiware & Image Co., Ltd.
//00087E, "Bon Electro-Telecom Inc.
//000880, "BroadTel Canada Communications inc.
//00086D, "Missouri FreeNet
//0008D4, "IneoQuest Technologies, Inc
//0008D6, "HASSNET Inc.
//0008CE IPMobileNet Inc.
//0008C2 Cisco Systems, Inc
//0008C0 ASA SYSTEMS
//0008A3 Cisco Systems, Inc
//00089E, "Beijing Enter-Net co.LTD
//0008B4 SYSPOL
//0008B3 Fastwel
//00088E, "Nihon Computer Co., Ltd.
//0008DA SofaWare Technologies Ltd.
//0007D5, "3e Technologies Int;., Inc.
//0007DB Kirana Networks, Inc.
//00086A Securiton Gmbh
//000863, "Entrisphere Inc.
//000866, "DSX Access Systems, Inc.
//0007EF, "Lockheed Martin Tactical Systems
//0007F4, "Eletex Co., Ltd.
//0007DD Cradle Technologies
//00081B Windigo Systems
//0007FF Gluon Networks
//0007F7, "Galtronics
//00085F, "Picanol N.V.
//000852, "Davolink Co. Inc.
//00080C VDA Elettronica spa
//000804, "ICA Inc.
//000857, "Polaris Networks, Inc.
//00078B Wegener Communications, Inc.
//000783, "SynCom Network, Inc.
//000787, "Idea System Co., Ltd.
//000789, "Allradio Co., Ltd
//0007B9 Ginganet Corporation
//00047F, "Chr.Mayr GmbH & Co.KG
//00047B Schlumberger
//0007B4 Cisco Systems, Inc
//0007B3 Cisco Systems, Inc
//0007B5 Any One Wireless Ltd.
//000785, "Cisco Systems, Inc
//000775, "Valence Semiconductor, Inc.
//000793, "Shin Satellite Public Company Limited
//000796, "LSI Systems, Inc.
//00077F, "J Communications Co., Ltd.
//000771, "Embedded System Corporation
//000770, "Ubiquoss Inc
//0007D1, "Spectrum Signal Processing Inc.
//0007A2 Opteon Corporation
//0006F8, "The Boeing Company
//0006FB Hitachi Printing Solutions, Ltd.
//0006FC Fnet Co., Ltd.
//0006F4, "Prime Electronics & Satellitics Inc.
//000738, "Young Technology Co., Ltd.
//000729, "Kistler Instrumente AG
//00072A Innovance Networks
//00074A Carl Valentin GmbH
//00073C Telecom Design
//000736, "Data Video Technologies Co., Ltd.
//000750, "Cisco Systems, Inc
//000742, "Ormazabal
//00074B Daihen Corporation
//000764, "YoungWoo Telecom Co.Ltd.
//000766, "Chou Chin Industrial Co., Ltd.
//000761, "29530
//000755, "Lafon
//000759, "Boris Manufacturing Corp.
//000751, "m-u-t AG
//000719, "Mobiis Co., Ltd.
//00070D, "Cisco Systems, Inc
//00070E, "Cisco Systems, Inc
//00070B Novabase SGPS, SA
//000710, "Adax, Inc.
//0006E8, "Optical Network Testing, Inc.
//0006EE Shenyang Neu-era Information & Technology Stock Co., Ltd
//0006E2, "Ceemax Technology Co., Ltd.
//0006A5 PINON Corp.
//00069D, "Petards Ltd
//0006A8 KC Technology, Inc.
//0006A0 Mx Imaging
//0006BE Baumer Optronic GmbH
//0006BA Westwave Communications
//0006C4 Piolink Inc.
//0006B5 Source Photonics, Inc.
//00068F, "Telemonitor, Inc.
//0006DA ITRAN Communications Ltd.
//0006D0, "Elgar Electronics Corp.
//0006CC JMI Electronics Co., Ltd.
//0006BF Accella Technologies Co., Ltd.
//000690, "Euracom Communication GmbH
//0006E1, "Techno Trade s.a
//00062E, "Aristos Logic Corp.
//000624, "Gentner Communications Corp.
//000625, "The Linksys Group, Inc.
//000627, "Uniwide Technologies, Inc.
//00062A Cisco Systems, Inc
//00062C Bivio Networks
//000621, "Hinox, Co., Ltd.
//00064E, "Broad Net Technology Inc.
//00062D, "TouchStar Technologies, L.L.C.
//000646, "ShenZhen XunBao Network Technology Co Ltd
//00064B Alexon Co., Ltd.
//00063C Intrinsyc Software International Inc.
//000630, "Adtranz Sweden
//000637, "Toptrend-Meta Information (ShenZhen) Inc.
//00061C Hoshino Metal Industries, Ltd.
//000623, "MGE UPS Systems France
//00060B Artesyn Embedded Technologies
//00067E, "WinCom Systems, Inc.
//000677, "SICK AG
//000666, "Roving Networks
//000667, "Tripp Lite
//00064D, "Sencore
//000660, "NADEX Co., Ltd.
//000679, "Konami Corporation
//00066C Robinson Corporation
//000615, "Kimoto Electric Co., Ltd.
//00060A Blue2space
//0005CE Prolink Microsystems Corporation
//0005C2 Soronti, Inc.
//0005DF Electronic Innovation, Inc.
//0005DE Gi Fone Korea, Inc.
//0005E0, "Empirix Corp.
//0005D8, "Arescom, Inc.
//0005E4, "Red Lion Controls Inc.
//0005F2, "Power R, Inc.
//0005F3, "Webyn
//000601, "Otanikeiki Co., Ltd.
//000605, "Inncom International, Inc.
//0005FA IPOptical, Inc.
//0005E5, "Renishaw PLC
//0005F5, "Geospace Technologies
//0005FD PacketLight Networks Ltd.
//0005D4, "FutureSmart Networks, Inc.
//0005C4 Telect, Inc.
//0005A3 QEI, Inc.
//00059E, "Zinwell Corporation
//0005A5 KOTT
//0005B3 Asahi-Engineering Co., Ltd.
//00059D, "Daniel Computing Systems, Inc.
//0005A4 Lucid Voice Ltd.
//000563, "J-Works, Inc.
//000557, "Agile TV Corporation
//00055B Charles Industries, Ltd.
//000554, "Rangestar Wireless
//000553, "DVC Company, Inc.
//000566, "Secui.com Corporation
//00056C Hung Chang Co., Ltd.
//00055F, "Cisco Systems, Inc
//00055D, "D-LINK SYSTEMS, INC.
//000561, "nac Image Technology, Inc.
//000594, "HMS Industrial Networks
//00056F, "Innomedia Technologies Pvt.Ltd.
//000574, "Cisco Systems, Inc
//000567, "Etymonic Design, Inc.
//000565, "Tailyn Communication Company Ltd.
//00058E, "Flextronics International GmbH & Co.Nfg.KG
//000532, "Cisco Systems, Inc
//000536, "Danam Communications, Inc.
//000542, "Otari, Inc.
//000537, "Nets Technology Co., Ltd.
//00057C RCO Security AB
//000583, "ImageCom Limited
//00054B Eaton Automation AG
//0004C8 LIBA Maschinenfabrik GmbH
//0004CC Peek Traffic B.V.
//0004BF VersaLogic Corp.
//0004C3 CASTOR Informatique
//0004F6, "Amphus
//0004F4, "Infinite Electronics Inc.
//0004F1, "WhereNet
//000521, "Control Microsystems
//000523, "AVL List GmbH
//00051F, "Taijin Media Co., Ltd.
//00050C Network Photonics, Inc.
//0004EC Memobox SA
//0004E4, "Daeryung Ind., Inc.
//00050A ICS Spa
//000511, "Complementary Technologies Ltd
//000506, "Reddo Networks AB
//0004E2, "SMC Networks, Inc.
//0004CB Tdsoft Communication, Ltd.
//000526, "IPAS GmbH
//000467, "Wuhan Research Institute of MII
//00045A The Linksys Group, Inc.
//000463, "Bosch Security Systems
//00045C Mobiwave Pte Ltd
//000453, "YottaYotta, Inc.
//000450, "DMD Computers SRL
//000443, "Agilent Technologies, Inc.
//000449, "Mapletree Networks
//00042F, "International Communications Products, Inc.
//000429, "Pixord Corporation
//000426, "Autosys
//0004B8 Kumahira Co., Ltd.
//0004B5 Equitrac Corporation
//0004B1 Signal Technology, Inc.
//000451, "Medrad, Inc.
//000483, "Deltron Technology, Inc.
//000441, "Half Dome Systems, Inc.
//0004A5 Barco Projection Systems NV
//000482, "Medialogic Corp.
//0003CA MTS Systems Corp.
//0003C7 hopf Elektronik GmbH
//0003C2 Solphone K.K.
//0003F3, "Dazzle Multimedia, Inc.
//0003EC ICG Research, Inc.
//0003E9, "Akara Canada, Inc.
//0003E5, "Hermstedt SG
//0003E8, "Wavelength Digital Limited
//000421, "Ocular Networks
//000424, "TMC s.r.l.
//00041D, "Corega of America
//00041A Ines Test and Measurement GmbH & CoKG
//00041E, "Shikoku Instrumentation Co., Ltd.
//000413, "snom technology GmbH
//0003B4 Macrotek International Corp.
//0003A6 Traxit Technology, Inc.
//0003A4 Imation Corp.
//0003AB Bridge Information Systems
//000403, "Nexsi Corporation
//000406, "Fa.Metabox AG
//0003F8, "SanCastle Technologies, Inc.
//0003FA TiMetra Networks
//0003C6 ICUE Systems, Inc.
//0003BB Signal Communications Limited
//0003BE Netility
//0003DF Desana Systems
//0003DA Takamisawa Cybernetics Co., Ltd.
//0003D9, "Secheron SA
//0003FB ENEGATE Co., Ltd.
//0003F6, "Allegro Networks, Inc.
//000415, "Rasteme Systems Co., Ltd.
//000398, "WISI
//000395, "California Amplifier
//000392, "Hyundai Teletek Co., Ltd.
//00038E, "Atoga Systems, Inc.
//00031A Beijing Broad Telecom Ltd., China
//00035B BridgeWave Communications
//000357, "Intervoice-Brite, Inc.
//00037F, "Atheros Communications, Inc.
//0002F0, "AME Optimedia Technology Co., Ltd.
//00039E, "Tera System Co., Ltd.
//000397, "FireBrick Limited
//00033F, "BigBand Networks, Ltd.
//000327, "ACT'L
//00032E, "Scope Information Management, Ltd.
//00037C Coax Media
//000368, "Embedone Co., Ltd.
//000345, "Routrek Networks Corporation
//0002C8 Technocom Communications Technology (pte) Ltd
//0002B8 WHI KONSULT AB
//0002A9 RACOM, s.r.o.
//0002BB Continuous Computing Corp
//0002BC LVL 7 Systems, Inc.
//00030F, "Digital China (Shanghai) Networks Ltd.
//000311, "Micro Technology Co., Ltd.
//00030D, "Uniwill Computer Corp.
//000309, "Texcel Technology PLC
//000303, "JAMA Electronics Co., Ltd.
//000305, "MSC Vertriebs GmbH
//0002FE Viditec, Inc.
//00019F, "ReadyNet
//0002FF Handan BroadInfoCom
//0002F4, "PCTEL, Inc.
//0002E9, "CS Systemes De Securite - C3S
//0002E5, "Timeware Ltd.
//0002E0, "ETAS GmbH
//0002CE FoxJet, Inc.
//0002C3 Arelnet Ltd.
//000316, "Nobell Communications, Inc.
//000329, "F3, Inc.
//000321, "Reco Research Co., Ltd.
//0002F5, "VIVE Synergies, Inc.
//0002D5, "ACR
//0002AB CTC Union Technologies Co., Ltd.
//0002A4 AddPac Technology Co., Ltd.
//0002A3 ABB Switzerland Ltd, Power Systems
//0002A0 Flatstack Ltd.
//0002B2 Cablevision
//0002B7 Watanabe Electric Industry Co., Ltd.
//0002AF TeleCruz Technology, Inc.
//0002A8 Air Link Technology
//00026A Cocess Telecom Co., Ltd.
//00026C Philips CFT
//000262, "Soyo Group Soyo Com Tech Co., Ltd
//000265, "Virditech Co. Ltd.
//00025B Cambridge Silicon Radio
//000256, "Alpha Processor, Inc.
//000259, "Tsann Kuen China (Shanghai) Enterprise Co., Ltd.IT Group
//000294, "Tokyo Sokushin Co., Ltd.
//000296, "Lectron Co,. Ltd.
//00028E, "Rapid 5 Networks, Inc.
//00024F, "IPM Datacom S.R.L.
//000271, "Zhone Technologies
//00028A Ambit Microsystems Corporation
//0001FA HOROSCAS
//000282, "ViaClix, Inc.
//000285, "Riverstone Networks
//000279, "Control Applications, Ltd.
//000251, "Soma Networks, Inc.
//0001F5, "ERIM S.A.
//0001FF Data Direct Networks, Inc.
//0001FC Keyence Corporation
//0001FD Digital Voice Systems, Inc.
//000210, "Fenecom
//00020B Native Networks, Inc.
//000218, "Advanced Scientific Corp
//0001EE Comtrol Europe, Ltd.
//0001F0, "Tridium, Inc.
//0001F1, "Innovative Concepts, Inc.
//0001E2, "Ando Electric Corporation
//00022F, "P-Cube, Ltd.
//000227, "ESD Electronic System Design GmbH
//00021D, "Data General Communication Ltd.
//000219, "Paralon Technologies
//000203, "Woonsang Telecom, Inc.
//0001D3, "PAXCOMM, Inc.
//0001E1, "Kinpo Electronics, Inc.
//00022C ABB Bomem, Inc.
//00023C Creative Technology, Ltd.
//00306C Hitex Holding GmbH
//00308B Brix Networks
//000177, "EDSL
//00014D, "Shin Kin Enterprises Co., Ltd
//0001DA WINCOMM Corporation
//0001D2, "inXtron, Inc.
//0001C6 Quarry Technologies
//00016E, "Conklin Corporation
//000174, "CyberOptics Corporation
//00015E, "BEST TECHNOLOGY CO., LTD.
//000161, "Meta Machine Technology
//0001A1 Mag-Tek, Inc.
//000186, "Uwe Disch
//0001A6 Scientific-Atlanta Arcodan A/S
//000172, "TechnoLand Co., LTD.
//0001A0 Infinilink Corporation
//000196, "Cisco Systems, Inc
//000199, "HeiSei Electronics
//00018B NetLinks Co., Ltd.
//00018D, "AudeSi Technologies
//00019D, "E-Control Systems, Inc.
//0001CE Custom Micro Products, Ltd.
//0001BB Frequentis
//0001BC Brains Corporation
//0001C0 CompuLab, Ltd.
//00017C AG-E GmbH
//000108, "AVLAB Technology, Inc.
//00062B INTRASERVER TECHNOLOGY
//000100, "EQUIP'TRANS
//00B09D Point Grey Research Inc.
//000110, "Gotham Networks
//000112, "Shark Multimedia Inc.
//000116, "Netspect Technologies, Inc.
//00B06D Jones Futurex Inc.
//00B094 Alaris, Inc.
//0030F0, "Uniform Industrial Corp.
//00013B BNA SYSTEMS
//000134, "Selectron Systems AG
//000139, "Point Multimedia Systems
//00013E, "Ascom Tateco AB
//00012E, "PC Partner Ltd.
//000132, "Dranetz - BMI
//000113, "OLYMPUS CORPORATION
//00011E, "Precidia Technologies, Inc.
//000155, "Promise Technology, Inc.
//003094, "Cisco Systems, Inc
//00308A NICOTRA SISTEMI S.P.A
//003072, "Intellibyte Inc.
//003040, "Cisco Systems, Inc
//003032, "MagicRam, Inc.
//0030EA TeraForce Technology Corporation
//00309B Smartware
//003045, "Village Networks, Inc. (VNI)
//0030E5, "Amper Datos S.A.
//003006, "SUPERPOWER COMPUTER
//003038, "XCP, INC.
//003079, "CQOS, INC.
//00300C CONGRUENCY, LTD.
//00304C APPIAN COMMUNICATIONS, INC.
//0030E8, "ENSIM CORP.
//0030C9 LuxN, N
//003028, "FASE Saldatura srl
//003069, "IMPACCT TECHNOLOGY CORP.
//0030C3 FLUECKIGER ELEKTRONIK AG
//00305A TELGEN CORPORATION
//003010, "VISIONETICS INTERNATIONAL
//0030D9, "DATACORE SOFTWARE CORP.
//003026, "HeiTel Digital Video GmbH
//003077, "ONPREM NETWORKS
//003047, "NISSEI ELECTRIC CO., LTD.
//0030D4, "AAE Systems, Inc.
//00D0D7, "B2C2, INC.
//00D073, "ACN ADVANCED COMMUNICATIONS
//00D057, "ULTRAK, INC.
//0030AB DELTA NETWORKS, INC.
//003049, "BRYANT TECHNOLOGY, LTD.
//00306D, "LUCENT TECHNOLOGIES
//003017, "BlueArc UK Ltd
//00301C ALTVATER AIRDATA SYSTEMS
//003080, "Cisco Systems, Inc
//0030F7, "RAMIX INC.
//0030D0, "Tellabs
//003014, "DIVIO, INC.
//003081, "ALTOS C&C
//00D0F0, "CONVISION TECHNOLOGY GMBH
//00D010, "CONVERGENT NETWORKS, INC.
//00D04B LA CIE GROUP S.A.
//00D00E, "PLURIS, INC.
//00D012, "GATEWORKS CORP.
//00D04D, "DIV OF RESEARCH & STATISTICS
//00D02E, "COMMUNICATION AUTOMATION CORP.
//00D0C5 COMPUTATIONAL SYSTEMS, INC.
//00D046, "DOLBY LABORATORIES, INC.
//00D0DE PHILIPS MULTIMEDIA NETWORK
//00D00C SNIJDER MICRO SYSTEMS
//00D017, "SYNTECH INFORMATION CO., LTD.
//00D036, "TECHNOLOGY ATLANTA CORP.
//00D0E3, "ELE-CHEM ENGINEERING CO., LTD.
//00D0B6, "CRESCENT NETWORKS, INC.
//00D0C4 TERATECH CORPORATION
//00D061, "TREMON ENTERPRISES CO., LTD.
//00D0E5, "SOLIDUM SYSTEMS CORP.
//00D045, "KVASER AB
//00D004, "PENTACOM LTD.
//00D005, "ZHS ZEITMANAGEMENTSYSTEME
//00D0D3, "Cisco Systems, Inc
//00D026, "HIRSCHMANN AUSTRIA GMBH
//00D0DA TAICOM DATA SYSTEMS CO., LTD.
//00D03C Vieo, Inc.
//00D0B4, "KATSUJIMA CO., LTD.
//00D086, "FOVEON, INC.
//00D0A8 NETWORK ENGINES, INC.
//00D0AB DELTAKABEL TELECOM CV
//00D0E8, "MAC SYSTEM CO., LTD.
//00D06B SR TELECOM INC.
//00D0DC MODULAR MINING SYSTEMS, INC.
//00D01E, "PINGTEL CORP.
//00D0CA Intrinsyc Software International Inc.
//00D065, "TOKO ELECTRIC
//00D09A FILANET CORPORATION
//00D0AE ORESIS COMMUNICATIONS, INC.
//00D0F2, "MONTEREY NETWORKS
//00D014, "ROOT, INC.
//00D023, "INFORTREND TECHNOLOGY, INC.
//00D0A2 INTEGRATED DEVICE
//00D034, "ORMEC SYSTEMS CORP.
//00D08A PHOTRON USA
//00D0A7 TOKYO SOKKI KENKYUJO CO., LTD.
//00D01D, "FURUNO ELECTRIC CO., LTD.
//00504C Galil Motion Control
//005076, "IBM Corp
//0050D4, "JOOHONG INFORMATION &
//0050A6 OPTRONICS
//0050A9 MOLDAT WIRELESS TECHNOLGIES
//00509B SWITCHCORE AB
//00507E, "NEWER TECHNOLOGY
//0050CE LG INTERNATIONAL CORP.
//0050F7, "VENTURE MANUFACTURING (SINGAPORE) LTD.
//005019, "SPRING TIDE NETWORKS, INC.
//0050FD VISIONCOMM CO., LTD.
//0050BF Metalligence Technology Corp.
//005036, "NETCAM, LTD.
//0050DB CONTEMPORARY CONTROL
//00507C VIDEOCON AG
//005047, "Private
//00D06C SHAREWAVE, INC.
//0050A7 Cisco Systems, Inc
//005055, "DOMS A/S
//005072, "CORVIS CORPORATION
//00D0EE DICTAPHONE CORPORATION
//00501B ABL CANADA, INC.
//009057, "AANetcom, Inc.
//009083, "TURBO COMMUNICATION, INC.
//00903D, "BIOPAC SYSTEMS, INC.
//0090D7, "NetBoost Corp.
//005083, "GILBARCO, INC.
//0050DC TAS TELEFONBAU A. SCHWABE GMBH & CO.KG
//005008, "TIVA MICROCOMPUTER CORP. (TMC)
//005052, "TIARA NETWORKS, INC.
//005027, "GENICOM CORPORATION
//00505A NETWORK ALCHEMY, INC.
//005039, "MARINER NETWORKS
//005064, "CAE ELECTRONICS
//0050B8 INOVA COMPUTERS GMBH & CO.KG
//00505B KAWASAKI LSI U.S.A., INC.
//0050CC Seagate Cloud Systems Inc
//005016, "Molex Canada Ltd
//00501F, "MRG SYSTEMS, LTD.
//005043, "MARVELL SEMICONDUCTOR, INC.
//005095, "PERACOM NETWORKS
//0050FA OXTEL, LTD.
//009038, "FOUNTAIN TECHNOLOGIES, INC.
//0090B0 VADEM
//0090EF, "INTEGRIX, INC.
//0090C5 INTERNET MAGIC, INC.
//00908C ETREND ELECTRONICS, INC.
//009048, "ZEAL CORPORATION
//0090B9 BERAN INSTRUMENTS LTD.
//0090C4 JAVELIN SYSTEMS, INC.
//0090A5 SPECTRA LOGIC
//0090A3 Corecess Inc.
//009082, "FORCE INSTITUTE
//009000, "DIAMOND MULTIMEDIA
//00906E, "PRAXON, INC.
//009054, "INNOVATIVE SEMICONDUCTORS, INC
//009061, "PACIFIC RESEARCH & ENGINEERING CORPORATION
//00900B LANNER ELECTRONICS, INC.
//0090CE avateramedical Mechatronics GmbH
//009007, "DOMEX TECHNOLOGY CORP.
//00902D, "DATA ELECTRONICS (AUST.) PTY, LTD.
//0090D4, "BindView Development Corp.
//009029, "CRYPTO AG
//0090DF MITSUBISHI CHEMICAL AMERICA, INC.
//0090C0 K.J.LAW ENGINEERS, INC.
//00901F, "ADTEC PRODUCTIONS, INC.
//009024, "PIPELINKS, INC.
//00903A NIHON MEDIA TOOL INC.
//0090B2 AVICI SYSTEMS INC.
//0090B6 FIBEX SYSTEMS
//009063, "COHERENT COMMUNICATIONS SYSTEMS CORPORATION
//009062, "ICP VORTEX COMPUTERSYSTEME GmbH
//0010D3, "GRIPS ELECTRONIC GMBH
//0010FB ZIDA TECHNOLOGIES LIMITED
//001053, "COMPUTER TECHNOLOGY CORP.
//0010ED, "SUNDANCE TECHNOLOGY, INC.
//00106C EDNT GmbH
//0010E9, "RAIDTEC LTD.
//001003, "IMATRON, INC.
//001071, "ADVANET INC.
//009015, "CENTIGRAM COMMUNICATIONS CORP.
//009095, "UNIVERSAL AVIONICS
//009041, "APPLIED DIGITAL ACCESS
//00905A DEARBORN GROUP, INC.
//009011, "WAVTrace, Inc.
//009065, "FINISAR CORPORATION
//009023, "ZILOG INC.
//0090F6, "ESCALATE NETWORKS, INC.
//0090A8 NineTiles Networks, Ltd.
//00102A ZF MICROSYSTEMS, INC.
//0010E5, "SOLECTRON TEXAS
//00109D, "CLARINET SYSTEMS, INC.
//00100E, "MICRO LINEAR COPORATION
//0090EC PYRESCOM
//0090C3 TOPIC SEMICONDUCTOR CORP.
//0010C8 COMMUNICATIONS ELECTRONICS SECURITY GROUP
//0010F3, "Nexcom International Co., Ltd.
//001086, "ATTO Technology, Inc.
//0010DF RISE COMPUTER INC.
//001072, "GVN TECHNOLOGIES, INC.
//0010DA Kollmorgen Corp
//0010E4, "NSI CORPORATION
//00107E, "BACHMANN ELECTRONIC GmbH
//0010A0 INNOVEX TECHNOLOGIES, INC.
//001016, "T.SQWARE
//001090, "CIMETRICS, INC.
//0010F5, "AMHERST SYSTEMS, INC.
//00103D, "PHASECOM, LTD.
//001096, "TRACEWELL SYSTEMS, INC.
//001082, "JNA TELECOMMUNICATIONS LIMITED
//001098, "STARNET TECHNOLOGIES, INC.
//001042, "Alacritech, Inc.
//001068, "COMOS TELECOM
//0010EA ADEPT TECHNOLOGY
//0010AE SHINKO ELECTRIC INDUSTRIES CO.
//0010C4 MEDIA GLOBAL LINKS CO., LTD.
//0010FE DIGITAL EQUIPMENT CORPORATION
//001056, "SODICK CO., LTD.
//0010CD INTERFACE CONCEPT
//001061, "HOSTLINK CORP.
//001099, "InnoMedia, Inc.
//0010E1, "S.I.TECH, INC.
//0010BB DATA & INFORMATION TECHNOLOGY
//001020, "Hand Held Products Inc
//00103A DIAMOND NETWORK TECH
//001004, "THE BRANTLEY COILE COMPANY, INC
//0010EF, "DBTEL INCORPORATED
//001088, "AMERICAN NETWORKS INC.
//001022, "SatCom Media Corporation
//001076, "EUREM GmbH
//00103F, "TOLLGRADE COMMUNICATIONS, INC.
//001049, "ShoreTel, Inc
//00105E, "Spirent plc, Service Assurance Broadband
//0010AF TAC SYSTEMS, INC.
//00108C Fujitsu Services Ltd
//0010F7, "IRIICHI TECHNOLOGIES Inc.
//0010AB KOITO ELECTRIC INDUSTRIES, LTD.
//001010, "INITIO CORPORATION
//0010F2, "ANTEC
//00E007, "Avaya ECS Ltd
//0010BE MARCH NETWORKS CORPORATION
//001058, "ArrowPoint Communications
//00100F, "INDUSTRIAL CPU SYSTEMS
//0010BC Aastra Telecom
//00E0BF TORRENT NETWORKING TECHNOLOGIES CORP.
//00E0E3 SK-ELEKTRONIK GMBH
//00E0C6 LINK2IT, L.L.C.
//00E0E5 CINCO NETWORKS, INC.
//00E061, "EdgePoint Networks, Inc.
//00E053, "CELLPORT LABS, INC.
//00E0D3, "DATENTECHNIK GmbH
//00E043, "VitalCom
//00E0B3 EtherWAN Systems, Inc.
//00E0ED SILICOM, LTD.
//00E0B8 GATEWAY 2000
//00E07C METTLER-TOLEDO, INC.
//00E026, "Redlake MASD LLC
//00E020, "TECNOMEN OY
//00E00D, "RADIANT SYSTEMS
//00E0DC NEXWARE CORP.
//00E037, "CENTURY CORPORATION
//00E0C2 NECSY S.p.A.
//00E0FB LEIGHTRONIX, INC.
//00E09B ENGAGE NETWORKS, INC.
//00E045, "TOUCHWAVE, INC.
//00E040, "DeskStation Technology, Inc.
//00E01A COMTEC SYSTEMS.CO., LTD.
//00E078, "BERKELEY NETWORKS
//00E087, "LeCroy - Networking Productions Division
//00E041, "CSPI
//00E0E2 INNOVA CORP.
//00E081, "TYAN COMPUTER CORP.
//00E057, "HAN MICROTELECOM. CO., LTD.
//00E0BC SYMON COMMUNICATIONS, INC.
//00E082, "ANERMA
//00E077, "WEBGEAR, INC.
//00E056, "HOLONTECH CORPORATION
//00E031, "HAGIWARA ELECTRIC CO., LTD.
//00E00B ROOFTOP COMMUNICATIONS CORP.
//00E0B2 TELMAX COMMUNICATIONS CORP.
//00E02F, "MCNS HOLDINGS, L.P.
//00E07E WALT DISNEY IMAGINEERING
//00E099, "SAMSON AG
//0060AE TRIO INFORMATION SYSTEMS AB
//006053, "TOYODA MACHINE WORKS, LTD.
//006056, "NETWORK TOOLS, INC.
//00600C Eurotech Inc.
//00601C TELXON CORPORATION
//00605F, "NIPPON UNISOFT CORPORATION
//006091, "FIRST PACIFIC NETWORKS, INC.
//00601D, "LUCENT TECHNOLOGIES
//00607B FORE SYSTEMS, INC.
//00E06C Ultra Electronics Command & Control Systems
//00E04A ZX Technologies, Inc
//0060C9 ControlNet, Inc.
//00E07A MIKRODIDAKT AB
//006032, "I-CUBE, INC.
//006033, "ACUITY IMAGING, INC.
//006013, "NETSTAL MASCHINEN AG
//006022, "VICOM SYSTEMS, INC.
//0060EE APOLLO
//0060D8, "ELMIC SYSTEMS, INC.
//0060EF, "FLYTECH TECHNOLOGY CO., LTD.
//006085, "Storage Concepts
//006011, "CRYSTAL SEMICONDUCTOR CORP.
//0060F5, "ICON WEST, INC.
//006062, "TELESYNC, INC.
//0060E9, "ATOP TECHNOLOGIES, INC.
//006043, "iDirect, INC.
//006028, "MACROVISION CORPORATION
//0060F0, "JOHNSON & JOHNSON MEDICAL, INC
//0060E0, "AXIOM TECHNOLOGY CO., LTD.
//006096, "T.S.MICROTECH INC.
//00603A QUICK CONTROLS LTD.
//000288, "GLOBAL VILLAGE COMMUNICATION
//006034, "ROBERT BOSCH GmbH
//006050, "INTERNIX INC.
//0060FA EDUCATIONAL TECHNOLOGY RESOURCES, INC.
//0060DA Red Lion Controls, LP
//0060E4, "COMPUSERVE, INC.
//00608F, "TEKRAM TECHNOLOGY CO., LTD.
//0060C4 SOLITON SYSTEMS K.K.
//00A03C EG&G NUCLEAR INSTRUMENTS
//00A0C4 CRISTIE ELECTRONICS LTD.
//00A063 JRL SYSTEMS, INC.
//00A02C interWAVE Communications
//00A0F7 V.I COMPUTER CORP.
//00A090 TimeStep Corporation
//00A0EA ETHERCOM CORP.
//00A0DC O.N.ELECTRONIC CO., LTD.
//00A00B COMPUTEX CO., LTD.
//00A0E2 Keisokugiken Corporation
//00A033 imc MeBsysteme GmbH
//00A0A9 NAVTEL COMMUNICATIONS INC.
//00A071 VIDEO LOTTERY TECHNOLOGIES, INC
//006000, "XYCOM INC.
//006045, "PATHLIGHT TECHNOLOGIES
//00A05D CS COMPUTER SYSTEME GmbH
//00A061 PURITAN BENNETT
//0060A6 PARTICLE MEASURING SYSTEMS
//00602A SYMICRON COMPUTER COMMUNICATIONS, LTD.
//00A06D MANNESMANN TALLY CORPORATION
//00A0F6 AutoGas Systems Inc.
//0060BE WEBTRONICS
//0060BF MACRAIGOR SYSTEMS, INC.
//006080, "MICROTRONIX DATACOM LTD.
//00A037 Mindray DS USA, Inc.
//00A04C INNOVATIVE SYSTEMS & TECHNOLOGIES, INC.
//00A031 HAZELTINE CORPORATION, MS 1-17
//00A041 INFICON
//00A0A7 VORAX CORPORATION
//00A07E AVID TECHNOLOGY, INC.
//00A06F Color Sentinel Systems, LLC
//00A0C7 TADIRAN TELECOMMUNICATIONS
//00A01A BINAR ELEKTRONIK AB
//00A088 ESSENTIAL COMMUNICATIONS
//00A0C2 R.A.SYSTEMS CO., LTD.
//00A098 NetApp
//00A04B TFL LAN INC.
//00A064 KVB/ANALECT
//00A03E ATM FORUM
//00A01F TRICORD SYSTEMS, INC.
//00A0FB TORAY ENGINEERING CO., LTD.
//00A06C SHINDENGEN ELECTRIC MFG. CO., LTD.
//00A0DB FISHER & PAYKEL PRODUCTION
//00A081 ALCATEL DATA NETWORKS
//00A0B1 FIRST VIRTUAL CORPORATION
//002010, "JEOL SYSTEM TECHNOLOGY CO. LTD
//00209F, "MERCURY COMPUTER SYSTEMS, INC.
//00A073 COM21, INC.
//00A03A KUBOTEK CORPORATION
//00A0B2 SHIMA SEIKI
//00A08B ASTON ELECTRONIC DESIGNS LTD.
//00A097 JC INFORMATION SYSTEMS
//00A027 FIREPOWER SYSTEMS, INC.
//00A046 SCITEX CORP.LTD.
//00A0D4 RADIOLAN, INC.
//00A092 H. BOLLMANN MANUFACTURERS, LTD
//00200D, "CARL ZEISS
//00202D, "TAIYO CORPORATION
//002091, "J125, NATIONAL SECURITY AGENCY
//0020BD NIOBRARA R & D CORPORATION
//002054, "Sycamore Networks
//0020A7 PAIRGAIN TECHNOLOGIES, INC.
//002055, "ALTECH CO., LTD.
//00200A SOURCE-COMM CORP.
//0020CF TEST & MEASUREMENT SYSTEMS INC
//0020B4 TERMA ELEKTRONIK AS
//0020E4, "HSING TECH ENTERPRISE CO., LTD
//00206C EVERGREEN TECHNOLOGY CORP.
//00205E, "CASTLE ROCK, INC.
//002012, "CAMTRONICS MEDICAL SYSTEMS
//002075, "MOTOROLA COMMUNICATION ISRAEL
//0020A5 API ENGINEERING
//002064, "PROTEC MICROSYSTEMS, INC.
//002033, "SYNAPSE TECHNOLOGIES, INC.
//0020CB PRETEC ELECTRONICS CORP.
//0020EB CINCINNATI MICROWAVE, INC.
//0020A0 OA LABORATORY CO., LTD.
//0020E2, "INFORMATION RESOURCE ENGINEERING
//002007, "SFA, INC.
//00205C InterNet Systems of Florida, Inc.
//0020A2 GALCOM NETWORKING LTD.
//002031, "Tattile SRL
//0020D0, "VERSALYNX CORPORATION
//0020B9 METRICOM, INC.
//002039, "SCINETS
//002072, "WORKLINK INNOVATIONS
//0020EC TECHWARE SYSTEMS CORP.
//00206E, "XACT, INC.
//0020F1, "ALTOS INDIA LIMITED
//002041, "DATA NET
//002076, "REUDO CORPORATION
//0020E8, "DATATREK CORPORATION
//0020C5 EAGLE TECHNOLOGY
//002009, "PACKARD BELL ELEC., INC.
//002027, "MING FORTUNE INDUSTRY CO., LTD
//00208A SONIX COMMUNICATIONS, LTD.
//0020D2, "RAD DATA COMMUNICATIONS, LTD.
//002002, "SERITECH ENTERPRISE CO., LTD.
//00204B AUTOCOMPUTER CO., LTD.
//0020EA EFFICIENT NETWORKS, INC.
//00206A OSAKA COMPUTER CORP.
//0020DB XNET TECHNOLOGY, INC.
//0020BB ZAX CORPORATION
//0020A8 SAST TECHNOLOGY CORP.
//002045, "ION Networks, Inc.
//002049, "COMTRON, INC.
//002050, "KOREA COMPUTER INC.
//002084, "OCE PRINTING SYSTEMS, GMBH
//00208C GALAXY NETWORKS, INC.
//0020A6 Proxim Wireless
//00202C WELLTRONIX CO., LTD.
//002021, "ALGORITHMS SOFTWARE PVT.LTD.
//00C0F9 Artesyn Embedded Technologies
//00C075 XANTE CORPORATION
//001C7C PERQ SYSTEMS CORPORATION
//00C039 Teridian Semiconductor Corporation
//00C0A9 BARRON MCCANN LTD.
//00C04B CREATIVE MICROSYSTEMS
//00C0B9 FUNK SOFTWARE, INC.
//00C015 NEW MEDIA CORPORATION
//00C083 TRACE MOUNTAIN PRODUCTS, INC.
//00C094 VMX INC.
//00C019 LEAP TECHNOLOGY, INC.
//00C0CF IMATRAN VOIMA OY
//00C07D RISC DEVELOPMENTS LTD.
//00C043 STRATACOM
//00C0B5 CORPORATE NETWORK SYSTEMS, INC.
//00C0ED US ARMY ELECTRONIC
//00C032 I-CUBED LIMITED
//00C0A5 DICKENS DATA SYSTEMS
//00C0EF ABIT CORPORATION
//00C061 SOLECTEK CORPORATION
//00C0AD MARBEN COMMUNICATION SYSTEMS
//00C07F NUPON COMPUTING CORP.
//00C057 MYCO ELECTRONICS
//00C056 SOMELEC
//00C027 CIPHER SYSTEMS, INC.
//00C05C ELONEX PLC
//00C028 JASCO CORPORATION
//00C08D TRONIX PRODUCT DEVELOPMENT
//00C02A OHKURA ELECTRIC CO., LTD.
//00C0FC ELASTIC REALITY, INC.
//00C0BB FORVAL CREATIVE, INC.
//00C0E0 DSC COMMUNICATION CORP.
//00C05B NETWORKS NORTHWEST, INC.
//00C008 SECO SRL
//00C0B7 AMERICAN POWER CONVERSION CORP
//00C0D3 OLYMPUS IMAGE SYSTEMS, INC.
//00C0E8 PLEXCOM, INC.
//00C0DA NICE SYSTEMS LTD.
//00C0D1 COMTREE TECHNOLOGY CORPORATION
//00C038 RASTER IMAGE PROCESSING SYSTEM
//00409B HAL COMPUTER SYSTEMS INC.
//0040EB MARTIN MARIETTA CORPORATION
//0040BD STARLIGHT NETWORKS, INC.
//0040ED, "NETWORK CONTROLS INT'NATL INC.
//004021, "RASTER GRAPHICS
//0040C1 BIZERBA-WERKE WILHEIM KRAUT
//0040E1, "MARNER INTERNATIONAL, INC.
//0040FE SYMPLEX COMMUNICATIONS
//0040E5, "SYBUS CORPORATION
//0040A5 CLINICOMP INTL.
//004005, "ANI COMMUNICATIONS INC.
//0040D9, "AMERICAN MEGATRENDS INC.
//00404C HYPERTEC PTY LTD.
//00C030 INTEGRATED ENGINEERING B. V.
//00C0A6 EXICOM AUSTRALIA PTY. LTD
//00C0CB CONTROL TECHNOLOGY CORPORATION
//00C0EB SEH COMPUTERTECHNIK GMBH
//0040DB ADVANCED TECHNICAL SOLUTIONS
//00C092 MENNEN MEDICAL INC.
//00C052 BURR-BROWN
//00400E, "MEMOTEC, INC.
//00C03D WIESEMANN & THEIS GMBH
//0040C8 MILAN TECHNOLOGY CORPORATION
//0040BA ALLIANT COMPUTER SYSTEMS CORP.
//004038, "TALENT ELECTRIC INCORPORATED
//0040D8, "OCEAN OFFICE AUTOMATION LTD.
//004088, "MOBIUS TECHNOLOGIES, INC.
//004032, "DIGITAL COMMUNICATIONS
//0040C2 APPLIED COMPUTING DEVICES
//0040D4, "GAGE TALKER CORP.
//0040CE NET-SOURCE, INC.
//004062, "E-SYSTEMS, INC./GARLAND DIV.
//004034, "BUSTEK CORPORATION
//00401C AST RESEARCH, INC.
//00400F, "DATACOM TECHNOLOGIES
//004006, "SAMPO TECHNOLOGY CORPORATION
//0080AA MAXPEED
//00C050 TOYO DENKI SEIZO K.K.
//0040C6 FIBERNET RESEARCH, INC.
//004047, "WIND RIVER SYSTEMS
//004050, "IRONICS, INCORPORATED
//008092, "Silex Technology, Inc.
//008093, "XYRON CORPORATION
//00805A TULIP COMPUTERS INTERNAT'L B.V
//004041, "FUJIKURA LTD.
//00804E, "APEX COMPUTER COMPANY
//008055, "FERMILAB
//00802A TEST SYSTEMS & SIMULATIONS INC
//008035, "TECHNOLOGY WORKS, INC.
//00807E, "SOUTHERN PACIFIC LTD.
//0080EF, "RATIONAL
//0080F0, "Panasonic Communications Co., Ltd.
//00801D, "INTEGRATED INFERENCE MACHINES
//008075, "PARSYTEC GMBH
//008051, "FIBERMUX
//0080C6 NATIONAL DATACOMM CORPORATION
//0080C0 PENRIL DATACOMM
//00802E, "CASTLE ROCK COMPUTING
//0080F2, "RAYCOM SYSTEMS INC
//0080BD THE FURUKAWA ELECTRIC CO., LTD
//008025, "Telit Wireless Solutions GmbH
//0080EA ADVA Optical Networking Ltd.
//00001E, "TELSIST INDUSTRIA ELECTRONICA
//000050, "RADISYS CORPORATION
//008004, "ANTLOW COMMUNICATIONS, LTD.
//0080D0, "COMPUTER PERIPHERALS, INC.
//008024, "KALPANA, INC.
//008040, "JOHN FLUKE MANUFACTURING CO.
//008021, "Alcatel Canada Inc.
//0080E8, "CUMULUS CORPORATIION
//008069, "COMPUTONE SYSTEMS
//00800D, "VOSSWINKEL F.U.
//0080D1, "KIMTRON CORPORATION
//008042, "Artesyn Embedded Technologies
//00809A NOVUS NETWORKS LTD
//008000, "MULTITECH SYSTEMS, INC.
//0080ED, "IQ TECHNOLOGIES, INC.
//00804A PRO-LOG
//000066, "TALARIS SYSTEMS, INC.
//000049, "APRICOT COMPUTERS, LTD
//0000FA MICROSAGE COMPUTER SYSTEMS INC
//0000D4, "PURE DATA LTD.
//000019, "APPLIED DYNAMICS INTERNATIONAL
//000015, "DATAPOINT CORPORATION
//00001C BELL TECHNOLOGIES
//000034, "NETWORK RESOURCES CORPORATION
//000022, "VISUAL TECHNOLOGY INC.
//0000B5 DATABILITY SOFTWARE SYS. INC.
//00002F, "TIMEPLEX INC.
//0000B8 SEIKOSHA CO., LTD.
//0000E6, "APTOR PRODUITS DE COMM INDUST
//000084, "SUPERNET
//00009A RC COMPUTER A/S
//000027, "JAPAN RADIO COMPANY
//0000E8, "ACCTON TECHNOLOGY CORP.
//00004B ICL DATA OY
//0000E0, "QUADRAM CORP.
//0000AB LOGIC MODELING CORPORATION
//0080AC IMLOGIX, DIVISION OF GENESYS
//00004F, "LOGICRAFT, INC.
//00006F, "Madge Ltd.
//000078, "LABTAM LIMITED
//00005A SysKonnect GmbH
//00005B ELTEC ELEKTRONIK AG
//000071, "ADRA SYSTEMS INC.
//000073, "SIECOR CORPORATION
//0000B9 MCDONNELL DOUGLAS COMPUTER SYS
//0000BF SYMMETRIC COMPUTER SYSTEMS
//00002D, "CHROMATICS INC
//000018, "WEBSTER COMPUTER CORPORATION
//0000C8 ALTOS COMPUTER SYSTEMS
//0000D5, "MICROGNOSIS INTERNATIONAL
//00003A CHYRON CORPORATION
//000059, "Hellige GMBH
//000069, "CONCORD COMMUNICATIONS INC
//0000E7, "Star Gate Technologies
//00004D, "DCI CORPORATION
//000023, "ABB INDUSTRIAL SYSTEMS AB
//0000BE THE NTI GROUP
//0000D9, "NIPPON TELEGRAPH & TELEPHONE
//000080, "CRAY COMMUNICATIONS A/S
//08002A MOSAIC TECHNOLOGIES INC.
//080089, "Kinetics
//080086, "KONICA MINOLTA HOLDINGS, INC.
//080083, "Seiko Instruments Inc.
//080061, "JAROGATE LTD.
//08005F, "SABER TECHNOLOGY CORP.
//080058, "SYSTEMS CONCEPTS
//080049, "UNIVATION
//080024, "10NET COMMUNICATIONS/DCA
//080022, "NBI INC.
//080020, "Oracle Corporation
//08001F, "SHARP CORPORATION
//080014, "EXCELAN
//AA0000", "DIGITAL EQUIPMENT CORPORATION
//AA0001", "DIGITAL EQUIPMENT CORPORATION
//AA0002", "DIGITAL EQUIPMENT CORPORATION
//000007, "XEROX CORPORATION
//00801F, "KRUPP ATLAS ELECTRONIK GMBH
//080006, "SIEMENS AG
//04E0C4 TRIUMPH-ADLER AG
//020701, "RACAL-DATACOM
//080013, "Exxon
//00DD08 UNGERMANN-BASS INC.
//000005, "XEROX CORPORATION
//021C7C PERQ SYSTEMS CORPORATION
//080065, "GENRAD INC.
//84A9EA Career Technologies USA
//E405F8 Delta Innovation Technology Co., Ltd.
//000009, "XEROX CORPORATION
//0080E9, "Madge Ltd.
//0040D6, "LOCAMATION B.V.
//08004B Planning Research Corp.
//02AA3C OLIVETTI TELECOMM SPA (OLTECO)
//080059, "A/S MYCRON
//080008, "BOLT BERANEK AND NEWMAN INC.
//F47488 New H3C Technologies Co., Ltd
//FCC233", "ASUSTek COMPUTER INC.
//401175, "IEEE Registration Authority
//8031F0, "Samsung Electronics Co., Ltd
//287FCF Intel Corporate
//583526, "DEEPLET TECHNOLOGY CORP
//34B5A3 CIG SHANGHAI CO LTD
//6C1DEB u-blox AG
//2852F9, "Zhongxin Intelligent Times (Shenzhen) Co., Ltd.
//B8F853 Arcadyan Corporation
//E0D083", "Samsung Electronics Co., Ltd
//743C18 Taicang T&W Electronics
//4C80BA Wuhan Tianyu Information Industry Co., Ltd.
//8C02FA COMMANDO Networks Limited
//F0264C Sigrist-Photometer AG
//D03D52 Vaion Limited
//D80B9A", "Samsung Electronics Co., Ltd
//AC8D34", "HUAWEI TECHNOLOGIES CO., LTD
//645299, "The Chamberlain Group, Inc
//F875A4", "LCFC(HeFei) Electronics Technology co., ltd
//00D2B1 TPV Display Technology (Xiamen) Co., Ltd.
//C0E434 AzureWave Technology Inc.
//6C710D Cisco Systems, Inc
//246F8C Huawei Device Co., Ltd.
//1C1386 Huawei Device Co., Ltd.
//BC2EF6 Huawei Device Co., Ltd.
//4455C4 Huawei Device Co., Ltd.
//000829, "TOKYO ELECTRON DEVICE NAGASAKI LIMITED
//1C4455 Sieb & Meyer AG
//803253, "Intel Corporate
//F88A5E Texas Instruments
//5CE7A0 Nokia
//E01F88 Xiaomi Communications Co Ltd
//8CDC02 zte corporation
//B4BC7C", "Texas Instruments
//E0AAB0 SUNTAILI ENTERPRISE CO. LTD,
//683943, "ittim
//10C65E Adapt-IP
//7CA7B0 SHENZHEN BILIAN ELECTRONIC CO.，LTD
//20311C vivo Mobile Communication Co., Ltd.
//104F58, "Aruba, a Hewlett Packard Enterprise Company
//B4E842", "Hong Kong Bouffalo Lab Limited
//0003CB SystemGear Co., Ltd.
//F0A7B2 FUTABA CORPORATION
//609B2D JMACS Japan Co., Ltd.
//14A32F Huawei Device Co., Ltd.
//04D3B5 Huawei Device Co., Ltd.
//00BB1C Huawei Device Co., Ltd.
//80AC7C Sichuan AI-Link Technology Co., Ltd.
//DC4BFE Shenzhen Belon Technology CO., LTD
//506255, "IEEE Registration Authority
//58D50A Murata Manufacturing Co., Ltd.
//88A303 Samsung Electronics Co., Ltd
//FCDE90", "Samsung Electronics Co., Ltd
//1854CF Samsung Electronics Co., Ltd
//80795D, "Infinix mobility limited
//E884C6", "HUAWEI TECHNOLOGIES CO., LTD
//642CAC HUAWEI TECHNOLOGIES CO., LTD
//08CC27 Motorola Mobility LLC, a Lenovo Company
//04D395, "Motorola Mobility LLC, a Lenovo Company
//E09806", "Espressif Inc.
//F4CFA2 Espressif Inc.
//F81E6F EBG compleo GmbH
//F0A35A Apple, Inc.
//608373, "Apple, Inc.
//84AD8D Apple, Inc.
//74428B Apple, Inc.
//149138, "Amazon Technologies Inc.
//6C410E Cisco Systems, Inc
//6C310E Cisco Systems, Inc
//2877F1, "Apple, Inc.
//A8E77D Texas Instruments
//DC543D", "ITEL MOBILE LIMITED
//0C8447 Fiberhome Telecommunication Technologies Co., LTD
//9C6B72 Realme Chongqing MobileTelecommunications Corp Ltd
//50C6AD Fiberhome Telecommunication Technologies Co., LTD
//748A28 HMD Global Oy
//D42493 GW Technologies Co., Ltd
//0023E6, "Innovation Farm, Inc.
//ECA940 ARRIS Group, Inc.
//FC8596 Axonne Inc.
//5CB4E2 Inspur Software Group Ltd.
//3C510E Cisco Systems, Inc
//D8AED0", "Shanghai Engineering Science & Technology Co., LTD CGNPC
//E0859A SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//0C42A1 Mellanox Technologies, Inc.
//B47AF1 Hewlett Packard Enterprise
//349F7B CANON INC.
//F4D9C6 UNIONMAN TECHNOLOGY CO., LTD
//34F150, "Hui Zhou Gaoshengda Technology Co., LTD
//CC5289", "SHENZHEN OPTFOCUS TECHNOLOGY., LTD
//CC5D78", "JTD Consulting
//BCF9F2 TEKO
//000EA4 Quantum Corp.
//005084, "Quantum Corp.
//809F9B Sichuan AI-Link Technology Co., Ltd.
//A82BCD HUAWEI TECHNOLOGIES CO., LTD
//48DC2D HUAWEI TECHNOLOGIES CO., LTD
//ACEB51", "Universal Electronics, Inc.
//6010A2 Crompton Instruments
//C4B239", "Cisco Systems, Inc
//B0A454", "Tripwire Inc.
//6490C1 Beijing Xiaomi Mobile Software Co., Ltd
//CC5CDE", "China Mobile Group Device Co., Ltd.
//60CE86 Sercomm Corporation.
//4C4FEE OnePlus Technology (Shenzhen) Co., Ltd
//4CE175 Cisco Systems, Inc
//A824B8", "Nokia
//000CE6 Fortinet Inc.
//9055DE Fiberhome Telecommunication Technologies Co., LTD
//E8910F", "Fiberhome Telecommunication Technologies Co., LTD
//D005E4", "Huawei Device Co., Ltd.
//30AAE4 Huawei Device Co., Ltd.
//14AB56 WUXI FUNIDE DIGITAL CO., LTD
//E8D8D1", "HP Inc.
//28CDC4 CHONGQING FUGUI ELECTRONICS CO., LTD.
//000CDF JAI Manufacturing
//2C91AB AVM Audiovisuelles Marketing und Computersysteme GmbH
//807B3E Samsung Electronics Co., Ltd
//F8F1E6", "Samsung Electronics Co., Ltd
//88A9B7 Apple, Inc.
//ECCED7 Apple, Inc.
//48EB62 Murata Manufacturing Co., Ltd.
//5CE176 Cisco Systems, Inc
//AC9085", "Apple, Inc.
//3448ED, "Dell Inc.
//3C5731 Cisco Systems, Inc
//6C55E8 Technicolor CH USA Inc.
//9CFCE8 Intel Corporate
//342FBD Nintendo Co., Ltd
//A02D13", "AirTies Wireless Networks
//8468C8 TOTOLINK TECHNOLOGY INT‘L LIMITED
//9C28F7 Xiaomi Communications Co Ltd
//10521C Espressif Inc.
//6C42AB Subscriber Networks, Inc.
//64F6F7, "Anhui Dynamic Power Co., Ltd.
//941C56 Actiontec Electronics, Inc
//D80BCB", "Telink Semiconductor (Shanghai) Co., Ltd.
//F0F0A4 Amazon Technologies Inc.
//C0D682 Arista Networks
//CC2D1B", "SFR
//80E540, "ARRIS Group, Inc.
//000DB4 Stormshield
//2CF05D Micro-Star INTL CO., LTD.
//943BB0 New H3C Technologies Co., Ltd
//9043E2, "Cornami, Inc
//803049, "Liteon Technology Corporation
//E84943", "YUGE Information technology Co. Ltd
//501408, "AiNET
//289AF7 ADVA Optical Networking Ltd.
//B0B194 zte corporation
//10C3AB HUAWEI TECHNOLOGIES CO., LTD
//2811EC HUAWEI TECHNOLOGIES CO., LTD
//E42686", "DWnet Technologies(Suzhou) Corporation
//00692D, "Sunnovo International Limited
//38EB47 HUAWEI TECHNOLOGIES CO., LTD
//0C3796 BIZLINK TECHNOLOGY, INC.
//F4032A Amazon Technologies Inc.
//147740, "Huawei Device Co., Ltd.
//B4157E Celona Inc.
//ACCB51 Hangzhou Hikvision Digital Technology Co., Ltd.
//18D98F, "Huawei Device Co., Ltd.
//645E2C IRay Technology Co., Ltd.
//00E0EC CELESTICA INC.
//703811, "Siemens Mobility Limited
//646266, "IEEE Registration Authority
//B89047", "Apple, Inc.
//909C4A Apple, Inc.
//908C43 Apple, Inc.
//3C7D0A Apple, Inc.
//188A6A AVPro Global Hldgs
//20826A GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//487AF6 NCS ELECTRICAL SDN BHD
//486E70, "Zhejiang Tmall Technology Co., Ltd.
//601D9D, "Sichuan AI-Link Technology Co., Ltd.
//D85F77 Telink Semiconductor (Shanghai) Co., Ltd.
//2C97ED Sony Imaging Products & Solutions Inc.
//F8D027 Seiko Epson Corporation
//5C666C GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//4C4BF9 IEEE Registration Authority
//1CEA0B Edgecore Networks Corporation
//24418C Intel Corporate
//44EFBF China Dragon Technology Limited
//B81F5E", "Apption Labs Limited
//D81265", "CHONGQING FUGUI ELECTRONICS CO., LTD.
//4CB44A NANOWAVE Technologies Inc.
//048C9A Huawei Device Co., Ltd.
//60F262, "Intel Corporate
//EC3CBB Huawei Device Co., Ltd.
//8C3A7E Universal Electronics, Inc.
//70441C SHENZHEN KAIFA TECHNOLOGY CO., LTD.
//B47C59 Jiangsu Hengxin Technology Co., Ltd.
//300D9E, "Ruijie Networks Co., LTD
//ECFA5C", "Beijing Xiaomi Electronics Co., Ltd.
//F8B46A Hewlett Packard
//BCB0E7", "HUAWEI TECHNOLOGIES CO., LTD
//5434EF, "HUAWEI TECHNOLOGIES CO., LTD
//88D5A8 ITEL MOBILE LIMITED
//208593, "IEEE Registration Authority
//ACE342", "HUAWEI TECHNOLOGIES CO., LTD
//9017C8 HUAWEI TECHNOLOGIES CO., LTD
//E4922A", "DBG HOLDINGS LIMITED
//2C641F Vizio, Inc
//207759, "OPTICAL NETWORK VIDEO TECHNOLOGIES (SHENZHEN) CO., LTD.
//54E7D5, "Sun Cupid Technology (HK) LTD
//189088, "eero inc.
//4C56DF Targus US LLC
//241510, "IEEE Registration Authority
//6C4D51 Shenzhen Ceres Technology Co., Ltd.
//889D98, "Allied-telesisK.K.
//DCF8B9 zte corporation
//18BF1C Jiangsu Huitong Group Co., Ltd.
//ACDE48 Private
//0050C7 Private
//002067, "Private
//4801C5 OnePlus Technology (Shenzhen) Co., Ltd
//B4EE25", "Shenzhen Belon Technology CO., LTD
//C82B96", "Espressif Inc.
//98523D, "Sunitec Enterprise Co., Ltd
//D015A6", "Aruba, a Hewlett Packard Enterprise Company
//000163, "Cisco Systems, Inc
//60634C D-Link International
//205F3D, "Cambridge Communication Systems Ltd
//04819B BSkyB Ltd
//E00084", "HUAWEI TECHNOLOGIES CO., LTD
//2CA89C Creatz inc.
//4CDC0D Coral Telecom Limited
//004E01, "Dell Inc.
//C4E1A1 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//ACC358", "Continental Automotive Czech Republic s.r.o.
//3CECEF Super Micro Computer, Inc.
//1855E3, "Apple, Inc.
//E450EB Apple, Inc.
//886440, "Apple, Inc.
//6070C0 Apple, Inc.
//F0C371 Apple, Inc.
//64FF0A Wistron Neweb Corporation
//F09919 Garmin International
//0000DE CETIA
//F43E66 Bee Computing (HK) Limited
//DC396F AVM Audiovisuelles Marketing und Computersysteme GmbH
//B4C476", "Wuhan Maritime Communication Research Institute
//683489, "LEA Professional
//B46C47 Panasonic Appliances Company
//44422F, "TESTOP CO., LTD.
//549C27 Plasma Cloud Limited
//D04E50 Mobiwire Mobiles (NingBo) Co., LTD
//94BF80 zte corporation
//987A14 Microsoft Corporation
//C83DDC", "Xiaomi Communications Co Ltd
//9C3A9A Shenzhen Sundray Technologies Company Limited
//B0B5E8 Ruroc LTD
//04D590, "Fortinet, Inc.
//541589, "MCS Logic Inc.
//845733, "Microsoft Corporation
//002423, "AzureWave Technologies (Shanghai) Inc.
//8C593C IEEE Registration Authority
//6029D5, "DAVOLINK Inc.
//509744, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//58F39C Cisco Systems, Inc
//C4411E", "Belkin International Inc.
//0077E4, "Nokia
//00AD63 Dedicated Micros Malta LTD
//E415F6", "Texas Instruments
//AC4228 Parta Networks
//F41D6B", "HUAWEI TECHNOLOGIES CO., LTD
//7CEC9B Fuzhou Teraway Information Technology Co., Ltd
//CC9070", "Cisco Systems, Inc
//2841C6 HUAWEI TECHNOLOGIES CO., LTD
//380118, "ULVAC, Inc.
//14ADCA China Mobile Iot Limited company
//809133, "AzureWave Technology Inc.
//B4F58E HUAWEI TECHNOLOGIES CO., LTD
//C48FC1", "DEEPTRACK S.L.U.
//F82387 Shenzhen Horn Audio Co., Ltd.
//E828C1 Eltex Enterprise Ltd.
//78D347, "Ericsson AB
//A4A179 Nanjing dianyan electric power automation co.LTD
//68DB67 Nantong Coship Electronics Co., Ltd.
//1819D6, "Samsung Electronics Co., Ltd
//BC98DF", "Motorola Mobility LLC, a Lenovo Company
//70FC8F FREEBOX SAS
//501B32 Taicang T&W Electronics
//980D67, "Zyxel Communications Corporation
//0002D8, "BRECIS Communications Corporation
//B0A6F5", "Xaptum, Inc.
//ACF5E6 Cisco Systems, Inc
//58A023 Intel Corporate
//DCB082", "Nokia
//F8C397", "NZXT Corp. Ltd.
//70DDA8 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//4C6F9C GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//782C29 New H3C Technologies Co., Ltd
//BC9FE4", "Aruba, a Hewlett Packard Enterprise Company
//702E80, "DIEHL Connectivity Solutions
//D4D252", "Intel Corporate
//ACA46E SHENZHEN GONGJIN ELECTRONICS CO., LT
//C8B422", "ASKEY COMPUTER CORP
//94EE9F HMD Global Oy
//DC2AA1 MedHab LLC
//E4F3E8", "Shenzhen SuperElectron Technology Co., Ltd.
//F4323D Sichuan tianyi kanghe communications co., LTD
//F8B797", "NEC Platforms, Ltd.
//B0AAD2 Sichuan tianyi kanghe communications co., LTD
//109397, "ARRIS Group, Inc.
//5075F1, "ARRIS Group, Inc.
//C46516 Hewlett Packard
//E41E0A", "IEEE Registration Authority
//CCA12B", "TCL King Electrical Appliances (Huizhou) Co., Ltd
//AC00D0", "zte corporation
//E8C417 Fiberhome Telecommunication Technologies Co., LTD
//001EA3 Nokia Danmark A/S
//38F32E, "Skullcandy
//981E19, "Sagemcom Broadband SAS
//84B866 Beijing XiaoLu technology co.LTD
//18BC5A Zhejiang Tmall Technology Co., Ltd.
//C4C138 OWLink Technology Inc
//AC37C9 RAID Incorporated
//205869, "Ruckus Wireless
//CC37AB Edgecore Networks Corporation
//907841, "Intel Corporate
//1422DB eero inc.
//C86314 IEEE Registration Authority
//243154, "HUAWEI TECHNOLOGIES CO., LTD
//2C58E8 HUAWEI TECHNOLOGIES CO., LTD
//70CD91 TERACOM TELEMATICA S.A
//2C1875 Skyworth Digital Technology(Shenzhen) Co., Ltd
//D06EDE", "Sagemcom Broadband SAS
//18399C Skorpios Technologies
//94C2BD TECNOBIT
//4883B4 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//84B8B8 Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//D041C9 Fiberhome Telecommunication Technologies Co., LTD
//E8018D", "Fiberhome Telecommunication Technologies Co., LTD
//10A3B8 Iskratel d.o.o.
//E8ECA3 Dongguan Liesheng Electronic Co.Ltd
//08A6BC Amazon Technologies Inc.
//701E68, "Hanna Instruments, Inc.
//1CB3E9 Shenzhen Zhongke United Communication Technology
//8C965F Shandong Zhongan Technology Co., Ltd.
//C0074A Brita GmbH
//E8B2FE", "HUMAX Co., Ltd.
//80FD7A BLU Products Inc
//0017FA Microsoft Corporation
//941625, "Apple, Inc.
//543B30 duagon AG
//40F21C DASAN Zhone Solutions
//B0BB8B WAVETEL TECHNOLOGY LIMITED
//34A8EB Apple, Inc.
//94BFC4 Ruckus Wireless
//A483E7", "Apple, Inc.
//F4AFE7 Apple, Inc.
//AC88FD Apple, Inc.
//503E7C LeiShen Intelligent System Co.Ltd
//24586E, "zte corporation
//B4A305 XIAMEN YAXON NETWORK CO., LTD.
//803E48, "SHENZHEN GONGJIN ELECTRONICS CO., LT
//243F30, "Oxygen Broadband s.a.
//3C9180 Liteon Technology Corporation
//20326C Samsung Electronics Co., Ltd
//6489F1, "Samsung Electronics Co., Ltd
//2034FB Xiaomi Communications Co Ltd
//A89CED", "Xiaomi Communications Co Ltd
//6CA604 ARRIS Group, Inc.
//5CF9DD Dell Inc.
//D0EC35 Cisco Systems, Inc
//10AE60 Private
//0025DF Private
//BCCF4F Zyxel Communications Corporation
//C010B1 HMD Global Oy
//90895F, "WEIFANG GOERTEK ELECTRONICS CO., LTD
//48D845, "Shenzhen Mainuoke Electronics Co., Ltd
//0CE041 iDruide
//B88FB4 JABIL CIRCUIT ITALIA S.R.L
//0052C2 peiker acustic GmbH
//8C53D2 China Mobile Group Device Co., Ltd.
//D45383 Murata Manufacturing Co., Ltd.
//A04246 IT Telecom Co., Ltd.
//0CF475 Zliide Technologies ApS
//68FF7B TP-LINK TECHNOLOGIES CO., LTD.
//808F1D, "TP-LINK TECHNOLOGIES CO., LTD.
//00124E, "XAC AUTOMATION CORP.
//88E034, "Shinwa industries(China) ltd.
//48BD0E Quanta Storage Inc.
//000F69, "SEW Eurodrive GmbH & Co.KG
//E458E7", "Samsung Electronics Co., Ltd
//00104A The Parvus Corporation
//380025, "Intel Corporate
//D058C0 Qingdao Haier Multimedia Limited.
//F8D478 Flextronics Tech.(Ind) Pvt Ltd
//48C3B0 Pharos Co.Ltd
//DC58BC", "Thomas-Krenn.AG
//001025, "Grayhill, Inc
//3821C7 Aruba, a Hewlett Packard Enterprise Company
//A45F9B", "Nexell
//70EA1A Cisco Systems, Inc
//808A8B vivo Mobile Communication Co., Ltd.
//9844B6 INFRANOR SAS
//38839A SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//DC6723 barox Kommunikation GmbH
//44B462 Flextronics Tech.(Ind) Pvt Ltd
//94B40F Aruba, a Hewlett Packard Enterprise Company
//001A1E Aruba, a Hewlett Packard Enterprise Company
//00246C Aruba, a Hewlett Packard Enterprise Company
//201BC9 Juniper Networks
//C8F6C8", "Fiberhome Telecommunication Technologies Co., LTD
//1C3B8F Selve GmbH & Co.KG
//E4E749", "Hewlett Packard
//ECC57F Suzhou Pairlink Network Technology
//A86DAA", "Intel Corporate
//38C2BA CCTV NEOTECH
//A0F9B7", "Ademco Smart Homes Technology(Tianjin) Co., Ltd.
//A83CCB ROSSMA
//886FD4 Dell Inc.
//CC3FEA BAE Systems, Inc
//4CF2BF Cambridge Industries(Group) Co., Ltd.
//CC9EA2 Amazon Technologies Inc.
//AC4330 Versa Networks
//E85BB7", "Ample Systems Inc.
//94677E, "Belden India Private Limited
//AC5775 HMD Global Oy
//D43A2E SHENZHEN MTC CO LTD
//50AD92 NX Technologies
//30C3D9 ALPS ELECTRIC CO., LTD.
//003217, "Cisco Systems, Inc
//001BFB ALPS ELECTRIC CO., LTD.
//94E0D6, "China Dragon Technology Limited
//B4A9FC Quanta Computer Inc.
//6CA936 DisplayLink (UK) Ltd
//708540, "Skyworth Digital Technology(Shenzhen) Co., Ltd
//08F1EA Hewlett Packard Enterprise
//F00DF5 ACOMA Medical Industry Co,. Ltd.
//6845F1, "TOSHIBA CLIENT SOLUTIONS CO., LTD.
//8CAEDB NAG LLC
//78B213 DWnet Technologies(Suzhou) Corporation
//58C232 NEC Corporation
//381D14, "Skydio Inc.
//7CDB98 ASKEY COMPUTER CORP
//380B3C Texas Instruments
//9C8CD8 Hewlett Packard Enterprise
//A48CC0 JLG Industries, Inc.
//3C286D Google, Inc.
//00093A Molex CMS
//04F9D9, "Speaker Electronic(Jiashan) Co., Ltd
//DC080F", "Apple, Inc.
//F8E94E Apple, Inc.
//EC2CE2 Apple, Inc.
//40BC60 Apple, Inc.
//E83617 Apple, Inc.
//9C648B Apple, Inc.
//344262, "Apple, Inc.
//14D00D, "Apple, Inc.
//88D211, "Eko Devices, Inc.
//B8C227 PSTec
//74F737, "KCE
//48A493 TAIYO YUDEN CO., LTD
//E82C6D", "SmartRG, Inc.
//48E695, "Insigma Inc
//B479C8 Ruckus Wireless
//B40B78", "Brusa Elektronik AG
//207918, "Intel Corporate
//C03DD9 MitraStar Technology Corp.
//2CAA8E Wyze Labs Inc
//703A51 Xiaomi Communications Co Ltd
//DC48B2", "Baraja Pty. Ltd.
//ACAE19 Roku, Inc
//181E95, "AuVerte
//0C9541 CHIPSEA TECHNOLOGIES (SHENZHEN) CORP.
//ACF85C Private
//9C6937 Qorvo Utrecht B.V.
//3C3786 NETGEAR
//48352E, "Shenzhen Wolck Network Product Co., LTD
//04E598, "Xiaomi Communications Co Ltd
//1012B4 SICHUAN TIANYI COMHEART TELECOM CO., LTD
//B82CA0", "Resideo
//6CC7EC SAMSUNG ELECTRO-MECHANICS(THAILAND)
//B033A6", "Juniper Networks
//D89685 GoPro
//3C01EF Sony Mobile Communications Inc
//C0BDC8", "Samsung Electronics Co., Ltd
//647BCE Samsung Electronics Co., Ltd
//A887B3", "Samsung Electronics Co., Ltd
//6C006B Samsung Electronics Co., Ltd
//001060, "BILLIONTON SYSTEMS, INC.
//C4D489 JiangSu Joyque Information Industry Co., Ltd
//B4F949", "optilink networks pvt ltd
//E43C80 University of Oklahoma
//3C2C30 Dell Inc.
//706D15, "Cisco Systems, Inc
//A4A1E4", "Innotube, Inc.
//94EAEA TELLESCOM INDUSTRIA E COMERCIO EM TELECOMUNICACAO
//1CFD08 IEEE Registration Authority
//B8599F Mellanox Technologies, Inc.
//A0A4C5 Intel Corporate
//F4D108", "Intel Corporate
//301389, "Siemens AG, Automations & Drives,
//046B25 SICHUAN TIANYI COMHEART TELECOM CO., LTD
//98D3E7, "Netafim L
//F063F9 HUAWEI TECHNOLOGIES CO., LTD
//7CC385 HUAWEI TECHNOLOGIES CO., LTD
//900EB3 Shenzhen Amediatech Technology Co., Ltd.
//549FAE iBASE Gaming Inc
//1469A2 SICHUAN TIANYI COMHEART TELECOM CO., LTD
//548028, "Hewlett Packard Enterprise
//00AD24 D-Link International
//54068B Ningbo Deli Kebei Technology Co.LTD
//60CE92 The Refined Industry Company Limited
//105BAD Mega Well Limited
//74BFC0 CANON INC.
//181DEA Intel Corporate
//185680, "Intel Corporate
//C8D9D2 Hewlett Packard
//24FCE5 Samsung Electronics Co., Ltd
//809621, "Lenovo
//78055F, "Shenzhen WYC Technology Co., Ltd.
//00EABD Cisco Systems, Inc
//48872D, "SHEN ZHEN DA XIA LONG QUE TECHNOLOGY CO., LTD
//E81A58", "TECHNOLOGIC SYSTEMS
//20B001 Technicolor
//C0BFA7 Juniper Networks
//F05494", "Honeywell Connected Building
//5CC999 New H3C Technologies Co., Ltd
//B02A43", "Google, Inc.
//C474F8 Hot Pepper, Inc.
//142233, "Fiberhome Telecommunication Technologies Co., LTD
//743400, "MTG Co., Ltd.
//DC3757 Integrated Device Technology (Malaysia) Sdn. Bhd.
//005099, "3COM EUROPE LTD
//04BC87 Shenzhen JustLink Technology Co., LTD
//54C33E Ciena Corporation
//EC79F2", "Startel
//BCB22B", "EM-Tech
//D4AB82", "ARRIS Group, Inc.
//704FB8 ARRIS Group, Inc.
//0060EB FOURTHTRACK SYSTEMS
//1862E4, "Texas Instruments
//6035C0 SFR
//C4985C Hui Zhou Gaoshengda Technology Co., LTD
//30A1FA HUAWEI TECHNOLOGIES CO., LTD
//242E90, "PALIT MICROSYSTEMS, LTD
//9CAA1B Microsoft Corporation
//A89A93", "Sagemcom Broadband SAS
//001AC5 Keysight Technologies, Inc.
//00201E, "NETQUEST CORPORATION
//64628A evon GmbH
//0415D9, "Viwone
//ECB313", "SHENZHEN GONGJIN ELECTRONICS CO., LT
//B08BCF", "Cisco Systems, Inc
//00608C", "3COM
//00A024", "3COM
//0020AF", "3COM
//00104B", "3COM
//A85AF3", "Shanghai Siflower Communication Technology Co., Ltd
//70FD46 Samsung Electronics Co., Ltd
//8C83E1 Samsung Electronics Co., Ltd
//889F6F, "Samsung Electronics Co., Ltd
//5C63C9 Intellithings Ltd.
//645D86, "Intel Corporate
//0C96E6 Cloud Network Technology (Samoa) Limited
//3C8994 BSkyB Ltd
//E00EE1", "We Corporation Inc.
//000C43 Ralink Technology, Corp.
//8C9246 Oerlikon Textile Gmbh&Co.KG
//000E94, "Maas International BV
//4898CA Sichuan AI-Link Technology Co., Ltd.
//247E51, "zte corporation
//E8B541 zte corporation
//0C9D92 ASUSTek COMPUTER INC.
//988ED4, "ITEL MOBILE LIMITED
//E8A788", "XIAMEN LEELEN TECHNOLOGY CO., LTD
//582D34, "Qingping Electronics (Suzhou) Co., Ltd
//20DE88 IC Realtime LLC
//F4068D devolo AG
//001A31 SCAN COIN AB
//001B84 Scan Engineering Telecom
//482CA0 Xiaomi Communications Co Ltd
//3412F9, "HUAWEI TECHNOLOGIES CO., LTD
//BCE265", "HUAWEI TECHNOLOGIES CO., LTD
//4CD1A1 HUAWEI TECHNOLOGIES CO., LTD
//88BFE4 HUAWEI TECHNOLOGIES CO., LTD
//4017E2, "INTAI TECHNOLOGY CORP.
//0CCB85 Motorola Mobility LLC, a Lenovo Company
//A4E615", "SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD
//741F79, "YOUNGKOOK ELECTRONICS CO., LTD
//A09351", "Cisco Systems, Inc
//98039B Mellanox Technologies, Inc.
//208984, "COMPAL INFORMATION (KUNSHAN) CO., LTD.
//B4CEFE James Czekaj
//F8CC6E", "DEPO Electronics Ltd
//F8369B", "Texas Instruments
//88AE1D COMPAL INFORMATION (KUNSHAN) CO., LTD.
//B888E3 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//289EFC Sagemcom Broadband SAS
//00C055 MODULAR COMPUTING TECHNOLOGIES
//E41FE9 Dunkermotoren GmbH
//C4518D", "Shenzhen YOUHUA Technology Co., Ltd
//486834, "Silicon Motion, Inc.
//001133, "Siemens AG Austria
//000B23 Siemens Home & Office Comm. Devices
//641331, "Bosch Car Multimedia (Wuhu) Co. Ltd.
//183A48 VostroNet
//782F17, "Xlab Co., Ltd
//B0027E", "MULLER SERVICES
//24FAF3 Shanghai Flexem Technology Co., Ltd.
//88D2BF German Autolabs
//20163D, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//E0735F NUCOM
//0051ED, "LG Innotek
//40DC9D HAJEN
//340A98 HUAWEI TECHNOLOGIES CO., LTD
//646D6C HUAWEI TECHNOLOGIES CO., LTD
//C4B8B4", "HUAWEI TECHNOLOGIES CO., LTD
//F0BCC9", "PFU LIMITED
//487583, "Intellion AG
//904C81 Hewlett Packard Enterprise
//8C3579 QDIQO Sp.z o.o.
//38C70A WiFiSong
//D8760A Escort, Inc.
//5C2ED2 ABC(XiSheng) Electronics Co., Ltd
//FCFBFB", "Cisco Systems, Inc
//007E95, "Cisco Systems, Inc
//9C5A44 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//14CAA0 Hu&Co
//08D46A LG Electronics (Mobile Communications)
//683A1E Cisco Meraki
//001017, "Bosch Access Systems GmbH
//F4EE14 MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//6C5940 MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//D02516 MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//1C60DE MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//D82477 Universal Electric Corporation
//00907F, "WatchGuard Technologies, Inc.
//4C5E0C Routerboard.com
//D4CA6D", "Routerboard.com
//001472, "China Broadband Wireless IP Standard group(ChinaBWIPS)
//80B575 HUAWEI TECHNOLOGIES CO., LTD
//A4BE2B", "HUAWEI TECHNOLOGIES CO., LTD
//68E7C2 Samsung Electronics Co., Ltd
//58B10F Samsung Electronics Co., Ltd
//4006A0 Texas Instruments
//F82DC0", "ARRIS Group, Inc.
//189C27 ARRIS Group, Inc.
//3CF5CC New H3C Technologies Co., Ltd
//D08A91", "Technicolor CH USA Inc.
//2811A5 Bose Corporation
//D8F3DB", "Post CH AG
//DCB4AC", "FLEXTRONICS MANUFACTURING(ZHUHAI) CO., LTD.
//A492CB Nokia
//C0D2F3 Hui Zhou Gaoshengda Technology Co., LTD
//B88303", "Hewlett Packard Enterprise
//203DBD LG Innotek
//A45385", "WEIFANG GOERTEK ELECTRONICS CO., LTD
//00402F, "XLNT DESIGNS INC.
//04ECBB Fiberhome Telecommunication Technologies Co., LTD
//64A2F9 OnePlus Technology (Shenzhen) Co., Ltd
//A87D12", "HUAWEI TECHNOLOGIES CO., LTD
//D42122", "Sercomm Corporation.
//00C002 Sercomm Corporation.
//BC9911 Zyxel Communications Corporation
//280245, "Konze System Technology Co., Ltd.
//E48F65 Yelatma Instrument Making Enterprise, JSC
//0000A8 Stratus Technologies
//0004FC Stratus Technologies
//3C24F0 IEEE Registration Authority
//00BB3A Amazon Technologies Inc.
//0CB34F Shenzhen Xiaoqi Intelligent Technology Co., Ltd.
//3CF4F9 Moda-InnoChips
//94193A Elvaco AB
//C08135", "Ningbo Forfan technology Co., LTD
//840D8E, "Espressif Inc.
//002082, "ONEAC CORPORATION
//B4C0F5 Shenzhen TINNO Mobile Technology Corp.
//406231, "GIFA
//FCB7F0", "Idaho National Laboratory
//2C28B7 Hangzhou Ruiying technology co., LTD
//106530, "Dell Inc.
//046B1B SYSDINE Co., Ltd.
//B0A37E QING DAO HAIER TELECOM CO., LTD.
//3CEAF9 JUBIXCOLTD
//58DB15 TECNO MOBILE LIMITED
//5050CE Hangzhou Dianyixia Communication Technology Co. Ltd.
//FC6947 Texas Instruments
//E07DEA", "Texas Instruments
//DCDE4F Gionee Communication Equipment Co Ltd
//4CD0CB HUAWEI TECHNOLOGIES CO., LTD
//505DAC HUAWEI TECHNOLOGIES CO., LTD
//E8FAF7", "Guangdong Uniteddata Holding Group Co., Ltd.
//949D57, "Panasonic do Brasil Limitada
//88D37B FirmTek, LLC
//1C666D Hon Hai Precision Ind.Co., Ltd.
//84F3EB Espressif Inc.
//001B48 Shenzhen Lantech Electronics Co., Ltd.
//00250C Senet Inc
//0C8063 TP-LINK TECHNOLOGIES CO., LTD.
//007278, "Cisco Systems, Inc
//04D3B0 Intel Corporate
//645AED Apple, Inc.
//C0B658 Apple, Inc.
//48A91C Apple, Inc.
//50BC96 Apple, Inc.
//FC2A9C Apple, Inc.
//682C7B Cisco Systems, Inc
//441E98, "Ruckus Wireless
//A056F3 Apple, Inc.
//549963, "Apple, Inc.
//90DD5D Apple, Inc.
//DC2919 AltoBeam (Xiamen) Technology Ltd, Co.
//885FE8 IEEE Registration Authority
//002FD9 Fiberhome Telecommunication Technologies Co., LTD
//B4CD27", "HUAWEI TECHNOLOGIES CO., LTD
//C819F7", "Samsung Electronics Co., Ltd
//64C3D6 Juniper Networks
//00A021 General Dynamics Mission Systems
//F0AF50", "Phantom Intelligence
//C42C4F Qingdao Hisense Mobile Communication Technology Co, Ltd
//24CACB Fiberhome Telecommunication Technologies Co., LTD
//543E64, "Fiberhome Telecommunication Technologies Co., LTD
//6402CB ARRIS Group, Inc.
//F4E11E Texas Instruments
//3880DF Motorola Mobility LLC, a Lenovo Company
//BC6A2F", "Henge Docks LLC
//0C08B4 HUMAX Co., Ltd.
//002705, "Sectronic
//48BD3D New H3C Technologies Co., Ltd
//184C08 Rockwell Automation
//DC0265", "Meditech Kft
//180F76, "D-Link International
//14A72B currentoptronics Pvt.Ltd
//A4DA22", "IEEE Registration Authority
//3C1710 Sagemcom Broadband SAS
//DC729B HUAWEI TECHNOLOGIES CO., LTD
//909497, "HUAWEI TECHNOLOGIES CO., LTD
//34029B Plexonics Technologies LImited
//900372, "Longnan Junya Digital Technology Co.Ltd.
//84DB9E Aifloo AB
//0CC6CC HUAWEI TECHNOLOGIES CO., LTD
//785860, "HUAWEI TECHNOLOGIES CO., LTD
//E8ABF3", "HUAWEI TECHNOLOGIES CO., LTD
//3CDCBC Samsung Electronics Co., Ltd
//804E70, "Samsung Electronics Co., Ltd
//D4E6B7", "Samsung Electronics Co., Ltd
//8C4CAD Evoluzn Inc.
//8CF957 RuiXingHengFang Network (Shenzhen) Co., Ltd
//4C776D Cisco Systems, Inc
//74E182, "Texas Instruments
//449EF9, "vivo Mobile Communication Co., Ltd.
//6CC4D5 HMD Global Oy
//80C548 Shenzhen Zowee Technology Co., Ltd
//10C25A Technicolor CH USA Inc.
//E8DEFB MESOTIC SAS
//C400AD", "Advantech Technology (CHINA) Co., Ltd.
//94FE9D SHENZHEN GONGJIN ELECTRONICS CO., LT
//6CB6CA DIVUS GmbH
//04D13A Xiaomi Communications Co Ltd
//4CC206 Somfy
//040973, "Hewlett Packard Enterprise
//3499D7, "Universal Flow Monitors, Inc.
//0C8BD3 ITEL MOBILE LIMITED
//C0A8F0 Adamson Systems Engineering
//9C431E IEEE Registration Authority
//0024AF Dish Technologies Corp
//282C02 IEEE Registration Authority
//FCA183 Amazon Technologies Inc.
//6C2ACB Paxton Access Ltd
//583BD9 Fiberhome Telecommunication Technologies Co., LTD
//DCA266", "Hon Hai Precision Ind. Co., Ltd.
//C48466 Apple, Inc.
//347C25 Apple, Inc.
//CC2DB7 Apple, Inc.
//A0BDCD BSkyB Ltd
//BC91B5", "Infinix mobility limited
//282FC2 Automotive Data Solutions
//980074, "Raisecom Technology CO., LTD
//18C19D Integrated Device Technology (Malaysia) Sdn. Bhd.
//0C9838 Xiaomi Communications Co Ltd
//74EACB New H3C Technologies Co., Ltd
//D41A3F", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//D8B122", "Juniper Networks
//B4C799 Extreme Networks, Inc.
//646E6C Radio Datacom LLC
//E88E60 NSD Corporation
//000F9B Ross Video Limited
//0024BA Texas Instruments
//60512C TCT mobile ltd
//64DB81 Syszone Co., Ltd.
//44AD19 XINGFEI （H.K）LIMITED
//38ADBE New H3C Technologies Co., Ltd
//5CAD76 Shenzhen TCL New Technology Co., Ltd
//5C865C Samsung Electronics Co., Ltd
//04F128, "HMD Global Oy
//04B167 Xiaomi Communications Co Ltd
//EC8350", "Microsoft Corporation
//D007CA Juniper Networks
//1CDF52 Texas Instruments
//30C507 ECI Telecom Ltd.
//C8458F Wyler AG
//001BB9 Elitegroup Computer Systems Co., Ltd.
//002461, "Shin Wang Tech.
//E4A7A0 Intel Corporate
//0C5203 AGM GROUP LIMITED
//2C5491 Microsoft Corporation
//3817C3 Hewlett Packard Enterprise
//001E1D, "East Coast Datacom, Inc.
//7846C4 DAEHAP HYPER-TECH
//5CE28C Zyxel Communications Corporation
//E4BD4B zte corporation
//38D7CA", "7HUGS LABS
//000144, "Dell EMC
//08001B Dell EMC
//7C010A Texas Instruments
//E42B34", "Apple, Inc.
//3C2EF9 Apple, Inc.
//A04EA7 Apple, Inc.
//F0989D Apple, Inc.
//FCD6BD Robert Bosch GmbH
//701F53, "Cisco Systems, Inc
//18396E, "SUNSEA TELECOMMUNICATIONS CO., LTD.
//EC7D11 vivo Mobile Communication Co., Ltd.
//480EEC TP-LINK TECHNOLOGIES CO., LTD.
//503EAA TP-LINK TECHNOLOGIES CO., LTD.
//5800BB Juniper Networks
//48BA4E Hewlett Packard
//D80831", "Samsung Electronics Co., Ltd
//9441C1 Mini-Cam Limited
//504EDC Ping Communication
//08674E, "Hisense broadband multimedia technology Co., Ltd
//500F80, "Cisco Systems, Inc
//10F1F2, "LG Electronics (Mobile Communications)
//8C68C8 zte corporation
//EC8263", "zte corporation
//683C7D Magic Intelligence Technology Limited
//0C1C20 Kakao Corp
//24F5A2 Belkin International Inc.
//74BBD3 Shenzhen xeme Communication Co., Ltd.
//94282E, "New H3C Technologies Co., Ltd
//98F5A9 OHSUNG
//D89EF3 Dell Inc.
//384F49, "Juniper Networks
//4CBD8F Hangzhou Hikvision Digital Technology Co., Ltd.
//ECEBB8 Hewlett Packard Enterprise
//6CB749 HUAWEI TECHNOLOGIES CO., LTD
//989C57 HUAWEI TECHNOLOGIES CO., LTD
//185282, "Fiberhome Telecommunication Technologies Co., LTD
//8C3C4A NAKAYO Inc
//7086C1 Texas Instruments
//F4D7B2", "LGS Innovations, LLC
//00152A Nokia Corporation
//9C4A7B Nokia Corporation
//D86162", "Wistron Neweb Corporation
//28840E, "silicon valley immigration service
//80615F, "Beijing Sinead Technology Co., Ltd.
//2CD2E7 Nokia Corporation
//386EA2 vivo Mobile Communication Co., Ltd.
//982D68, "Samsung Electronics Co., Ltd
//BC2E48", "ARRIS Group, Inc.
//608CE6 ARRIS Group, Inc.
//080070, "Mitsubishi Precision Co., LTd.
//444AB0 Zhejiang Moorgen Intelligence Technology Co., Ltd
//DC6AEA", "Infinix mobility limited
//C421C8", "KYOCERA CORPORATION
//80739F, "KYOCERA CORPORATION
//48EC5B Nokia
//705812, "Panasonic Corporation AVC Networks Company
//04209A Panasonic Corporation AVC Networks Company
//34008A IEEE Registration Authority
//A41115 Robert Bosch Engineering and Business Solutions pvt. Ltd.
//40D63C Equitech Industrial(DongGuan) Co., Ltd
//F4F3AA", "JBL GmbH & Co.KG
//40A3CC Intel Corporate
//9050CA Hitron Technologies.Inc
//409922, "AzureWave Technology Inc.
//C06D1A Tianjin Henxinhuifeng Technology Co., Ltd.
//107B44 ASUSTek COMPUTER INC.
//84253F, "silex technology, Inc.
//0008C9 TechniSat Digital GmbH Daun
//D8B12A", "Panasonic Mobile Communications Co., Ltd.
//B019C6 Apple, Inc.
//3866F0, "Apple, Inc.
//008009, "JUPITER SYSTEMS, INC.
//00C064 General Datacomm LLC
//E86819 HUAWEI TECHNOLOGIES CO., LTD
//1CAB34 New H3C Technologies Co., Ltd
//3C7843 HUAWEI TECHNOLOGIES CO., LTD
//5C0979 HUAWEI TECHNOLOGIES CO., LTD
//E4FB5D", "HUAWEI TECHNOLOGIES CO., LTD
//0001CC Japan Total Design Communication Co., Ltd.
//0030C8 GAD LINE, LTD.
//0016E0, "3Com Ltd
//D8DECE ISUNG CO., LTD
//801934, "Intel Corporate
//703EAC Apple, Inc.
//0011C0 Aday Technology Inc
//0005F1, "Vrcom, Inc.
//AC512C Infinix mobility limited
//309935, "zte corporation
//0C72D9 zte corporation
//1062D0, "Technicolor CH USA Inc.
//50642B XIAOMI Electronics, CO., LTD
//28401A C8 MediSensors, Inc.
//30C01B Shenzhen Jingxun Software Telecommunication Technology Co., Ltd
//8886C2 STABILO International GmbH
//08A8A1 Cyclotronics Power Concepts, Inc
//F4B520", "Biostar Microtech international corp.
//CC2F71 Intel Corporate
//001CC5", "3Com Ltd
//887A31 Velankani Electronics Pvt. Ltd.
//8C0F6F PEGATRON CORPORATION
//8C2505 HUAWEI TECHNOLOGIES CO., LTD
//8C3BAD NETGEAR
//64CFD9 Texas Instruments
//6432A8 Intel Corporate
//747D24, "Phicomm (Shanghai) Co., Ltd.
//D09466 Dell Inc.
//38E595, "SHENZHEN GONGJIN ELECTRONICS CO., LT
//BC9680", "SHENZHEN GONGJIN ELECTRONICS CO., LT
//A47B9D", "Espressif Inc.
//B8F8BE BLUECOM
//002482, "Ruckus Wireless
//689234, "Ruckus Wireless
//50A733 Ruckus Wireless
//2C5D93 Ruckus Wireless
//38FF36 Ruckus Wireless
//84183A Ruckus Wireless
//24C9A1 Ruckus Wireless
//7C2EDD Samsung Electronics Co., Ltd
//3CF7A4 Samsung Electronics Co., Ltd
//103034, "Cara Systems
//0000FE Annapolis Micro Systems, Inc.
//00D01F, "Senetas Corporation Ltd
//E0CBBC", "Cisco Meraki
//6447E0, "Feitian Technologies Co., Ltd
//B44F96", "Zhejiang Xinzailing Technology co., ltd
//4C65A8 IEEE Registration Authority
//B0DFC1 Tenda Technology Co., Ltd.Dongguan branch
//9C6F52 zte corporation
//E86D65", "AUDIO MOBIL Elektronik GmbH
//706E6D, "Cisco Systems, Inc
//604762, "Beijing Sensoro Technology Co., Ltd.
//BC1C81 Sichuan iLink Technology Co., Ltd.
//900A1A Taicang T&W Electronics
//506E92, "Innocent Technology Co., Ltd.
//30FE31 Nokia
//98F2B3 Hewlett Packard Enterprise
//C4571F June Life Inc
//886AE3 Alpha Networks Inc.
//1C4D70 Intel Corporate
//D822F4", "Avnet Silica
//348F27, "Ruckus Wireless
//2C9EEC Jabil Circuit Penang
//001CFA Alarm.com
//60313B Sunnovo International Limited
//6CB227 Sony Video & Sound Products Inc.
//986F60, "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//000CAB Commend International GmbH
//745427, "SHENZHEN FAST TECHNOLOGIES CO., LTD
//60720B BLU Products Inc
//308976, "DALIAN LAMBA TECHNOLOGY CO., LTD
//2C2617 Oculus VR, LLC
//34D954, "WiBotic Inc.
//4857DD Facebook Inc
//487D2E, "TP-LINK TECHNOLOGIES CO., LTD.
//B0DAF9 ARRIS Group, Inc.
//1835D1, "ARRIS Group, Inc.
//C0A5DD SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//488D36, "Arcadyan Corporation
//BCD713 Owl Labs
//E8E1E1", "Gemtek Technology Co., Ltd.
//28070D, "GUANGZHOU WINSOUND INFORMATION TECHNOLOGY CO., LTD.
//00A3D1 Cisco Systems, Inc
//FC4D8C", "SHENZHEN PANTE ELECTRONICS TECHNOLOGY CO., LTD
//FC06ED", "M2Motive Technology Inc.
//F0D4F6 Lars Thrane A/S
//F4A997", "CANON INC.
//64DFE9 ATEME
//10C6FC Garmin International
//AC2205", "Compal Broadband Networks, Inc.
//80A036 Shanghai MXCHIP Information Technology Co., Ltd.
//F07485 NGD Systems, Inc.
//405CFD Dell Inc.
//20F452, "Shanghai IUV Software Development Co.Ltd
//509A4C Dell Inc.
//A0094C CenturyLink
//B43934 Pen Generations, Inc.
//7426AC Cisco Systems, Inc
//B02628", "Broadcom Limited
//9874DA Infinix mobility limited
//40B4F0 Juniper Networks
//143F27, "Noccela Oy
//105887, "Fiberhome Telecommunication Technologies Co., LTD
//704CA5 Fortinet, Inc.
//9C061B Hangzhou H3C Technologies Co., Limited
//50338B Texas Instruments
//68262A SICHUAN TIANYI COMHEART TELECOMCO., LTD
//E8DE8E", "Integrated Device Technology (Malaysia) Sdn. Bhd.
//D8D866 SHENZHEN TOZED TECHNOLOGIES CO., LTD.
//D8C06A Hunantv.com Interactive Entertainment Media Co., Ltd.
//AC202E Hitron Technologies.Inc
//9C32A9 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//1C5A0B Tegile Systems
//046E02, "OpenRTLS Group
//900E83, "Monico Monitoring, Inc.
//601466, "zte corporation
//6854ED, "Alcatel-Lucent
//680235, "Konten Networks Inc.
//38AC3D Nephos Inc
//E037BF", "Wistron Neweb Corporation
//E81367", "AIRSOUND Inc.
//001192, "Cisco Systems, Inc
//38F135, "SensorTec-Canada
//AC7409", "Hangzhou H3C Technologies Co., Limited
//C49DED", "Microsoft Corporation
//98A40E Snap, Inc.
//F40343 Hewlett Packard Enterprise
//F093C5 Garland Technology
//9810E8, "Apple, Inc.
//C0D012 Apple, Inc.
//BCA920 Apple, Inc.
//48A195 Apple, Inc.
//F80377 Apple, Inc.
//F49634 Intel Corporate
//107D1A Dell Inc.
//70AF24 TP Vision Belgium NV
//A41163", "IEEE Registration Authority
//C4D197", "Ventia Utility Services
//2C86D2 Cisco Systems, Inc
//7CE97C ITEL MOBILE LIMITED
//8058F8, "Motorola Mobility LLC, a Lenovo Company
//DCA4CA", "Apple, Inc.
//8C8FE9 Apple, Inc.
//70AF25 Nishiyama Industry Co., LTD.
//E8D11B ASKEY COMPUTER CORP
//B8224F SICHUAN TIANYI COMHEART TELECOMCO., LTD
//9800C1 GuangZhou CREATOR Technology Co., Ltd.(CHINA)
//54E1AD LCFC(HeFei) Electronics Technology co., ltd
//98D3D2, "MEKRA Lang GmbH & Co.KG
//0C5F35 Niagara Video Corporation
//CCBE59 Calix Inc.
//F8A34F zte corporation
//001912, "Welcat Inc
//8C78D7 SHENZHEN FAST TECHNOLOGIES CO., LTD
//B8EAAA", "ICG NETWORKS CO., ltd
//B8F883", "TP-LINK TECHNOLOGIES CO., LTD.
//DCFE18 TP-LINK TECHNOLOGIES CO., LTD.
//704F57, "TP-LINK TECHNOLOGIES CO., LTD.
//B0C46C Senseit
//0002A1 World Wide Packets
//00E022, "Analog Devices, Inc.
//14B7F8 Technicolor CH USA Inc.
//903D6B Zicon Technology Corp.
//B04089 Senient Systems LTD
//5425EA HUAWEI TECHNOLOGIES CO., LTD
//3C7F6F Telechips, Inc.
//5CBA37 Microsoft Corporation
//00C0C6 PERSONAL MEDIA CORP.
//28FECD Lemobile Information Technology (Beijing) Co., Ltd.
//C894BB HUAWEI TECHNOLOGIES CO., LTD
//10B1F8 HUAWEI TECHNOLOGIES CO., LTD
//089E08, "Google, Inc.
//00210D, "SAMSIN INNOTEC
//C87324 Sow Cheng Technology Co.Ltd.
//001F16, "Wistron Corporation
//00262D, "Wistron Corporation
//0495E6, "Tenda Technology Co., Ltd.Dongguan branch
//50E666, "Shenzhen Techtion Electronics Co., Ltd.
//0016D3, "Wistron Corporation
//4C4E03 TCT mobile ltd
//908674, "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//901711, "Hagenuk Marinekommunikation GmbH
//0010DE INTERNATIONAL DATACASTING CORPORATION
//C0D9F7 ShanDong Domor Intelligent S&T CO., Ltd
//00608B ConferTech International
//702D84, "i4C Innovations
//2C200B Apple, Inc.
//8866A5 Apple, Inc.
//000277, "Cash Systemes Industrie
//CCA219", "SHENZHEN ALONG INVESTMENT CO., LTD
//4C1A3A PRIMA Research And Production Enterprise Ltd.
//14B31F Dell Inc.
//ACC1EE Xiaomi Communications Co Ltd
//5419C8 vivo Mobile Communication Co., Ltd.
//B0B98A NETGEAR
//805A04 LG Electronics (Mobile Communications)
//8CA5A1 Oregano Systems - Design & Consulting GmbH
//B8ECA3 Zyxel Communications Corporation
//BC8385 Microsoft Corporation
//001438, "Hewlett Packard Enterprise
//E4B005", "Beijing IQIYI Science & Technology Co., Ltd.
//000048, "Seiko Epson Corporation
//B0E892", "Seiko Epson Corporation
//AC1826", "Seiko Epson Corporation
//A4EE57", "Seiko Epson Corporation
//9CAED3 Seiko Epson Corporation
//707C69 Avaya Inc
//500B91 IEEE Registration Authority
//F8461C Sony Interactive Entertainment Inc.
//704D7B ASUSTek COMPUTER INC.
//64A68F Zhongshan Readboy Electronics Co., Ltd
//38BC01 HUAWEI TECHNOLOGIES CO., LTD
//341E6B HUAWEI TECHNOLOGIES CO., LTD
//886639, "HUAWEI TECHNOLOGIES CO., LTD
//00425A Cisco Systems, Inc
//18DBF2 Dell Inc.
//18F87A i3 International Inc.
//4C26E7 Welgate Co., Ltd.
//006041, "Yokogawa Digital Computer Corporation
//C816A5 Masimo Corporation
//0C0227 Technicolor CH USA Inc.
//4C11BF Zhejiang Dahua Technology Co., Ltd.
//2C598A LG Electronics (Mobile Communications)
//B05216", "Hon Hai Precision Ind. Co., Ltd.
//A0E4CB Zyxel Communications Corporation
//284ED7, "OutSmart Power Systems, Inc.
//14A78B Zhejiang Dahua Technology Co., Ltd.
//A0B8F8 Amgen U.S.A.Inc.
//884477, "HUAWEI TECHNOLOGIES CO., LTD
//149D09, "HUAWEI TECHNOLOGIES CO., LTD
//686975, "Angler Labs Inc
//20D25F, "SmartCap Technologies
//E47DBD Samsung Electronics Co., Ltd
//9CFBD5 vivo Mobile Communication Co., Ltd.
//18F76B Zhejiang Winsight Technology CO., LTD
//583112, "DRUST
//9C83BF PRO-VISION, Inc.
//78EF4C Unetconvergence Co., Ltd.
//58696C Ruijie Networks Co., LTD
//48D343, "ARRIS Group, Inc.
//00C05A SEMAPHORE COMMUNICATIONS CORP.
//0007F9, "Sensaphone
//001CB3 Apple, Inc.
//407183, "Juniper Networks
//C81B5C BCTech
//5CE30E ARRIS Group, Inc.
//1CC0E1 IEEE Registration Authority
//001A39 Merten GmbH&CoKG
//FCECDA", "Ubiquiti Networks Inc.
//00B0E1 Cisco Systems, Inc
//005093, "BOEING
//905C44 Compal Broadband Networks, Inc.
//44BA46 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//E07C13", "zte corporation
//F41F88 zte corporation
//14EDBB", "2Wire Inc
//18E29F, "vivo Mobile Communication Co., Ltd.
//28EE52 TP-LINK TECHNOLOGIES CO., LTD.
//687251, "Ubiquiti Networks Inc.
//B4FBE4 Ubiquiti Networks Inc.
//707990, "HUAWEI TECHNOLOGIES CO., LTD
//A04E01", "CENTRAL ENGINEERING co., ltd.
//28CA09 ThyssenKrupp Elevators (Shanghai) Co., Ltd
//842519, "Samsung Electronics
//5C2443 O-Sung Telecom Co., Ltd.
//24920E, "Samsung Electronics Co., Ltd
//FC4203", "Samsung Electronics Co., Ltd
//A01081", "Samsung Electronics Co., Ltd
//3C8BCD Alcatel-Lucent Shanghai Bell Co., Ltd
//4CF95D HUAWEI TECHNOLOGIES CO., LTD
//8421F1, "HUAWEI TECHNOLOGIES CO., LTD
//00F22C Shanghai B-star Technology Co., Ltd.
//0005EE Vanderbilt International (SWE) AB
//F07960 Apple, Inc.
//A0D795 Apple, Inc.
//0090E7, "HORSCH ELEKTRONIK AG
//E43ED7", "Arcadyan Corporation
//5454CF PROBEDIGITAL CO., LTD
//F8633F", "Intel Corporate
//088620, "TECNO MOBILE LIMITED
//F0D5BF", "Intel Corporate
//6474F6, "Shooter Detection Systems
//981333, "zte corporation
//2047ED, "BSkyB Ltd
//748A69 Korea Image Technology Co., Ltd
//BC4760", "Samsung Electronics Co., Ltd
//04180F, "Samsung Electronics Co., Ltd
//2013E0, "Samsung Electronics Co., Ltd
//002566, "Samsung Electronics Co., Ltd
//D0DB32", "Nokia Corporation
//E80036 Befs co,. ltd
//C09F05", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//5C4979 AVM Audiovisuelles Marketing und Computersysteme GmbH
//C0F945", "Toshiba Toko Meter Systems Co., LTD.
//70F8E7, "IEEE Registration Authority
//D42C44", "Cisco Systems, Inc
//843DC6 Cisco Systems, Inc
//002485, "ConteXtream Ltd
//28FCF6 Shenzhen Xin KingBrand enterprises Co., Ltd
//001F58, "EMH Energiemesstechnik GmbH
//689423, "Hon Hai Precision Ind. Co., Ltd.
//844BF5 Hon Hai Precision Ind.Co., Ltd.
//08EDB9 Hon Hai Precision Ind.Co., Ltd.
//3C77E6 Hon Hai Precision Ind.Co., Ltd.
//70188B Hon Hai Precision Ind.Co., Ltd.
//5C6D20 Hon Hai Precision Ind.Co., Ltd.
//5CAC4C Hon Hai Precision Ind.Co., Ltd.
//0016DF Lundinova AB
//001D0C MobileCompia
//B88EDF Zencheer Communication Technology Co., Ltd.
//DC7144 SAMSUNG ELECTRO MECHANICS CO., LTD.
//980C82 SAMSUNG ELECTRO MECHANICS CO., LTD.
//A00BBA SAMSUNG ELECTRO MECHANICS CO., LTD.
//606BBD Samsung Electronics Co., Ltd
//00214C Samsung Electronics Co., Ltd
//08C6B3 QTECH LLC
//0018AF Samsung Electronics Co., Ltd
//001EE1 Samsung Electronics Co., Ltd
//00166B Samsung Electronics Co., Ltd
//0000F0, "Samsung Electronics Co., Ltd
//8CC8CD Samsung Electronics Co., Ltd
//A8F274", "Samsung Electronics Co., Ltd
//D487D8", "Samsung Electronics Co., Ltd
//184617, "Samsung Electronics Co., Ltd
//380A94 Samsung Electronics Co., Ltd
//D0DFC7", "Samsung Electronics Co., Ltd
//D0C1B1", "Samsung Electronics Co., Ltd
//8018A7 Samsung Electronics Co., Ltd
//F47B5E", "Samsung Electronics Co., Ltd
//70F927, "Samsung Electronics Co., Ltd
//34E71C Shenzhen YOUHUA Technology Co., Ltd
//886AB1 vivo Mobile Communication Co., Ltd.
//6C1E90 Hansol Technics Co., Ltd.
//005A13 HUAWEI TECHNOLOGIES CO., LTD
//C45006", "Samsung Electronics Co., Ltd
//88329B SAMSUNG ELECTRO-MECHANICS(THAILAND)
//1449E0, "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//D02544", "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//BC4486", "Samsung Electronics Co., Ltd
//20D390, "Samsung Electronics Co., Ltd
//9401C2 Samsung Electronics Co., Ltd
//50FC9F Samsung Electronics Co., Ltd
//380B40 Samsung Electronics Co., Ltd
//B8FF61", "Apple, Inc.
//946124, "Pason Systems
//F0728C Samsung Electronics Co., Ltd
//34AA8B Samsung Electronics Co., Ltd
//24DBED Samsung Electronics Co., Ltd
//C8DE51", "IntegraOptics
//98F058, "Lynxspring, Incl.
//68C44D Motorola Mobility LLC, a Lenovo Company
//400D10, "ARRIS Group, Inc.
//943DC9 Asahi Net, Inc.
//440444, "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//00177E, "Meshcom Technologies Inc.
//A00460 NETGEAR
//9884E3, "Texas Instruments
//38D269, "Texas Instruments
//C8FD19 Texas Instruments
//508CB1 Texas Instruments
//C4F5A5", "Kumalift Co., Ltd.
//70B14E ARRIS Group, Inc.
//304487, "Hefei Radio Communication Technology Co., Ltd
//2C9D1E HUAWEI TECHNOLOGIES CO., LTD
//0081C4 Cisco Systems, Inc
//58E876, "IEEE Registration Authority
//D03742", "Yulong Computer Telecommunication Scientific (Shenzhen) Co., Ltd
//001765, "Nortel Networks
//0015E8, "Nortel Networks
//00159B Nortel Networks
//000F06, "Nortel Networks
//84B541 Samsung Electronics Co., Ltd
//006F64, "Samsung Electronics Co., Ltd
//DC6672", "Samsung Electronics Co., Ltd
//EC8EB5", "Hewlett Packard
//70AF6A SHENZHEN FENGLIAN TECHNOLOGY CO., LTD.
//20F543, "Hui Zhou Gaoshengda Technology Co., LTD
//E0DDC0", "vivo Mobile Communication Co., Ltd.
//00164D, "Alcatel-Lucent IPD
//001AF0 Alcatel-Lucent IPD
//38521A Nokia
//001E40, "Shanghai DareGlobal Technologies Co., Ltd
//94D723, "Shanghai DareGlobal Technologies Co., Ltd
//C4047B", "Shenzhen YOUHUA Technology Co., Ltd
//20F41B Shenzhen Bilian electronic CO., LTD
//FCFAF7", "Shanghai Baud Data Communication Co., Ltd.
//D826B9 Guangdong Coagent Electronics S&amp; T Co., Ltd.
//AC9CE4 Alcatel-Lucent Shanghai Bell Co., Ltd
//00233E, "Alcatel-Lucent IPD
//6CBEE9 Alcatel-Lucent IPD
//001540, "Nortel Networks
//001ECA Nortel Networks
//00130A Nortel Networks
//001F0A Nortel Networks
//F8E61A", "Samsung Electronics Co., Ltd
//A091C8", "zte corporation
//6CA858 Fiberhome Telecommunication Technologies Co., LTD
//CC2D8C", "LG ELECTRONICS INC
//98D6F7, "LG Electronics (Mobile Communications)
//700514, "LG Electronics (Mobile Communications)
//E892A4", "LG Electronics (Mobile Communications)
//10683F, "LG Electronics (Mobile Communications)
//40B0FA LG Electronics (Mobile Communications)
//0025E5, "LG Electronics (Mobile Communications)
//0021FB LG Electronics (Mobile Communications)
//34FCEF LG Electronics (Mobile Communications)
//BCF5AC", "LG Electronics (Mobile Communications)
//A84E3F", "Hitron Technologies. Inc
//0C4885 LG Electronics (Mobile Communications)
//0022A9 LG Electronics (Mobile Communications)
//2C6A6F IEEE Registration Authority
//08D833, "Shenzhen RF Technology Co., Ltd
//A46032", "MRV Communications (Networks) LTD
//40667A mediola - connected living AG
//68A0F6 HUAWEI TECHNOLOGIES CO., LTD
//000E5C ARRIS Group, Inc.
//845DD7 Shenzhen Netcom Electronics Co., Ltd
//00B064 Cisco Systems, Inc
//9C2A83 Samsung Electronics Co., Ltd
//C80210", "LG Innotek
//A039F7 LG Electronics (Mobile Communications)
//1CCAE3 IEEE Registration Authority
//E4956E IEEE Registration Authority
//B437D1 IEEE Registration Authority
//0055DA IEEE Registration Authority
//78C2C0 IEEE Registration Authority
//000EE8 Zioncom Electronics (Shenzhen) Ltd.
//00C095 ZNYX Networks, Inc.
//002025, "CONTROL TECHNOLOGY, INC.
//001A6B Universal Global Scientific Industrial Co., Ltd.
//001641, "Universal Global Scientific Industrial Co., Ltd.
//0010C6 Universal Global Scientific Industrial Co., Ltd.
//00247E, "Universal Global Scientific Industrial Co., Ltd.
//00DD0A UNGERMANN-BASS INC.
//54AB3A QUANTA COMPUTER INC.
//683563, "SHENZHEN LIOWN ELECTRONICS CO., LTD.
//004072, "Applied Innovation Inc.
//001938, "UMB Communications Co., Ltd.
//4439C4 Universal Global Scientific Industrial Co., Ltd.
//402CF4 Universal Global Scientific Industrial Co., Ltd.
//001E37, "Universal Global Scientific Industrial Co., Ltd.
//E89A8F QUANTA COMPUTER INC.
//1C57D8 Kraftway Corporation PLC
//002318, "Toshiba
//B86B23", "Toshiba
//0008F1, "Voltaire
//00199D, "Vizio, Inc
//00E08B QLogic Corporation
//D8EB97", "TRENDnet, Inc.
//001C7E Toshiba
//002517, "Venntis, LLC
//00600F, "Westell Technologies Inc.
//00183A Westell Technologies Inc.
//6002B4 Wistron Neweb Corporation
//94DF4E Wistron InfoComm(Kunshan) Co., Ltd.
//98EECB Wistron Infocomm (Zhongshan) Corporation
//643AB1 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//001BFE Zavio Inc.
//5410EC Microchip Technology Inc.
//0004A3 Microchip Technology Inc.
//789CE7 Shenzhen Aikede Technology Co., Ltd
//509F3B OI ELECTRIC CO., LTD
//446EE5 HUAWEI TECHNOLOGIES CO., LTD
//88F7C7 Technicolor CH USA Inc.
//8048A5 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//683E34, "MEIZU Technology Co., Ltd.
//C8778B Mercury Systems – Trusted Mission Solutions, Inc.
//00044B NVIDIA
//AC9B0A Sony Corporation
//104FA8 Sony Corporation
//000B6B Wistron Neweb Corporation
//AC040B Peloton Interactive, Inc
//48FCB6 LAVA INTERNATIONAL(H.K) LIMITED
//B0E235 Xiaomi Communications Co Ltd
//40C729 Sagemcom Broadband SAS
//14C913 LG Electronics
//F8A097", "ARRIS Group, Inc.
//FC2325 EosTek (Shenzhen) Co., Ltd.
//FC3D93 LONGCHEER TELECOMMUNICATION LIMITED
//D8E0B8 BULAT LLC
//603197, "Zyxel Communications Corporation
//C0C976", "Shenzhen TINNO Mobile Technology Corp.
//588BF3 Zyxel Communications Corporation
//5067F0, "Zyxel Communications Corporation
//001349, "Zyxel Communications Corporation
//E09861", "Motorola Mobility LLC, a Lenovo Company
//9C8ECD Amcrest Technologies
//A009ED", "Avaya Inc
//0014B4 General Dynamics United Kingdom Ltd
//A0B437 GD Mission Systems
//8C6D50 SHENZHEN MTC CO LTD
//00F663, "Cisco Systems, Inc
//A06090", "Samsung Electronics Co., Ltd
//BC765E", "Samsung Electronics Co., Ltd
//E0A8B8", "Le Shi Zhi Xin Electronic Technology (Tianjin) Limited
//F45B73 Wanjiaan Interconnected Technology Co., Ltd
//B88198", "Intel Corporate
//B0D7CC Tridonic GmbH & Co KG
//2CDDA3 Point Grey Research Inc.
//00809F, "ALE International
//48C663 GTO Access Systems LLC
//005F86, "Cisco Systems, Inc
//381DD9 FN-LINK TECHNOLOGY LIMITED
//1CB9C4 Ruckus Wireless
//8C59C3 ADB Italia
//B824F0", "SOYO Technology Development Co., Ltd.
//D85B2A Samsung Electronics Co., Ltd
//FCA89A", "Sunitec Enterprise Co., Ltd
//1C7B23 Qingdao Hisense Communications Co., Ltd.
//000BDE TELDIX GmbH
//C83DFC", "Pioneer DJ Corporation
//CCD31E", "IEEE Registration Authority
//34B354 HUAWEI TECHNOLOGIES CO., LTD
//1C6E76 Quarion Technology Inc
//90C1C6 Apple, Inc.
//6C0EE6 Chengdu Xiyida Electronic Technology Co,.Ltd
//CC500A", "Fiberhome Telecommunication Technologies Co., LTD
//D046DC", "Southwest Research Institute
//70A2B3 Apple, Inc.
//F40F24 Apple, Inc.
//4C57CA Apple, Inc.
//000763, "Sunniwell Cyber Tech.Co., Ltd.
//0062EC Cisco Systems, Inc
//CC167E", "Cisco Systems, Inc
//C46AB7", "Xiaomi Communications Co Ltd
//000AED HARTING Electronics GmbH
//240A11 TCT mobile ltd
//D8E56D TCT mobile ltd
//540593, "WOORI ELEC Co., Ltd
//C02FF1", "Volta Networks
//E8A7F2 sTraffic
//001F20, "Logitech Europe SA
//741F4A Hangzhou H3C Technologies Co., Limited
//E41D2D", "Mellanox Technologies, Inc.
//0CDA41 Hangzhou H3C Technologies Co., Limited
//74258A Hangzhou H3C Technologies Co., Limited
//A0B662", "Acutvista Innovation Co., Ltd.
//E42F56 OptoMET GmbH
//F8DA0C", "Hon Hai Precision Ind. Co., Ltd.
//1C1B0D GIGA-BYTE TECHNOLOGY CO., LTD.
//48E9F1, "Apple, Inc.
//903809, "Ericsson AB
//00A006 IMAGE DATA PROCESSING SYSTEM GROUP
//C83F26 Microsoft Corporation
//3497F6, "ASUSTek COMPUTER INC.
//50680A HUAWEI TECHNOLOGIES CO., LTD
//002238, "LOGIPLUS
//000C49 Dangaard Telecom Denmark A/S
//0008B9 Kaonmedia CO., LTD.
//60B387 Synergics Technologies GmbH
//A4D8CA HONG KONG WATER WORLD TECHNOLOGY CO.LIMITED
//8019FE JianLing Technology CO., LTD
//60B4F7 Plume Design Inc
//487ADA Hangzhou H3C Technologies Co., Limited
//001F45, "Enterasys
//001E90, "Elitegroup Computer Systems Co., Ltd.
//0022B1 Elbit Systems Ltd.
//0000B4 Edimax Technology Co. Ltd.
//00168F, "GN Netcom A/S
//000D87, "Elitegroup Computer Systems Co., Ltd.
//1078D2, "Elitegroup Computer Systems Co., Ltd.
//002197, "Elitegroup Computer Systems Co., Ltd.
//E4F3F5 SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//A08CFD Hewlett Packard
//000E03, "Emulex Corporation
//00CAE5 Cisco Systems, Inc
//004268, "Cisco Systems, Inc
//4883C7 Sagemcom Broadband SAS
//40163B Samsung Electronics Co., Ltd
//44650D, "Amazon Technologies Inc.
//D4F207 DIAODIAO(Beijing) Technology CO., Ltd
//D4AD2D", "Fiberhome Telecommunication Technologies Co., LTD
//F08CFB", "Fiberhome Telecommunication Technologies Co., LTD
//48555F, "Fiberhome Telecommunication Technologies Co., LTD
//FC3F7C", "HUAWEI TECHNOLOGIES CO., LTD
//384C4F HUAWEI TECHNOLOGIES CO., LTD
//0CBF3F Shenzhen Lencotion Technology Co., Ltd
//50FF99 IEEE Registration Authority
//84E323, "Green Wave Telecommunication SDN BHD
//705A9E Technicolor CH USA Inc.
//04A316 Texas Instruments
//140C5B PLNetworks
//001706, "Techfaithwireless Communication Technology Limited.
//FC084A FUJITSU LIMITED
//BC9889", "Fiberhome Telecommunication Technologies Co., LTD
//24615A China Mobile Group Device Co., Ltd.
//405EE1 Shenzhen H&T Intelligent Control Co., Ltd.
//002578, "JSC Concern Sozvezdie
//30B49E TP-LINK TECHNOLOGIES CO., LTD.
//C83870 Samsung Electronics Co., Ltd
//1C553A QianGua Corp.
//34E70B HAN Networks Co., Ltd
//007888, "Cisco Systems, Inc
//900325, "HUAWEI TECHNOLOGIES CO., LTD
//98E7F5, "HUAWEI TECHNOLOGIES CO., LTD
//085BDA CliniCare LTD
//1CC035 PLANEX COMMUNICATIONS INC.
//34543C TAKAOKA TOKO CO., LTD.
//1866DA Dell Inc.
//583277, "Reliance Communications LLC
//248A07 Mellanox Technologies, Inc.
//9C9D5D Raden Inc
//DC4D23", "MRV Comunications
//0023B3 Lyyn AB
//402E28, "MiXTelematics
//6C8FB5 Microsoft Mobile Oy
//008E73, "Cisco Systems, Inc
//0015C1 Sony Interactive Entertainment Inc.
//A09D91 SoundBridge
//40B688 LEGIC Identsystems AG
//9CD48B Innolux Technology Europe BV
//90A62F NAVER
//C0C522 ARRIS Group, Inc.
//1C9E46 Apple, Inc.
//C4E510 Mechatro, Inc.
//18A6F7 TP-LINK TECHNOLOGIES CO., LTD.
//00351A Cisco Systems, Inc
//00AF1F Cisco Systems, Inc
//803896, "SHARP Corporation
//0060EC HERMARY OPTO ELECTRONICS INC.
//C0CCF8 Apple, Inc.
//9C4FDA Apple, Inc.
//8489AD Apple, Inc.
//AC3A7A Roku, Inc.
//B83E59 Roku, Inc.
//DC3A5E Roku, Inc.
//001A73 Gemtek Technology Co., Ltd.
//00904B Gemtek Technology Co., Ltd.
//001A7F GCI Science & Technology Co., LTD
//00180F, "Nokia Danmark A/S
//C8979F", "Nokia Corporation
//ECF35B Nokia Corporation
//544408, "Nokia Corporation
//3CC243 Nokia Corporation
//0021FC Nokia Danmark A/S
//001F5D, "Nokia Danmark A/S
//001F01, "Nokia Danmark A/S
//001BEE Nokia Danmark A/S
//001979, "Nokia Danmark A/S
//0025D0, "Nokia Danmark A/S
//0024D4, "FREEBOX SAS
//347E39, "Nokia Danmark A/S
//00507F, "DrayTek Corp.
//647791, "Samsung Electronics Co., Ltd
//9CE6E7 Samsung Electronics Co., Ltd
//9C0298 Samsung Electronics Co., Ltd
//28987B Samsung Electronics Co., Ltd
//54FA3E Samsung Electronics Co., Ltd
//0C8910 Samsung Electronics Co., Ltd
//78ABBB Samsung Electronics Co., Ltd
//D8C4E9", "Samsung Electronics Co., Ltd
//BCD11F", "Samsung Electronics Co., Ltd
//F4428F", "Samsung Electronics Co., Ltd
//0090A2 CyberTAN Technology Inc.
//0090D6, "Crystal Group, Inc.
//446D6C Samsung Electronics Co., Ltd
//00F46F, "Samsung Electronics Co., Ltd
//0C715D Samsung Electronics Co., Ltd
//9C80DF Arcadyan Technology Corporation
//002308, "Arcadyan Technology Corporation
//880355, "Arcadyan Technology Corporation
//34BB1F BlackBerry RTS
//406F2A BlackBerry RTS
//7C1CF1 HUAWEI TECHNOLOGIES CO., LTD
//78F557, "HUAWEI TECHNOLOGIES CO., LTD
//E02861", "HUAWEI TECHNOLOGIES CO., LTD
//D0D04B", "HUAWEI TECHNOLOGIES CO., LTD
//480031, "HUAWEI TECHNOLOGIES CO., LTD
//D476EA", "zte corporation
//00175A Cisco Systems, Inc
//0896D7, "AVM GmbH
//506A03 NETGEAR
//100D7F, "NETGEAR
//504A6E NETGEAR
//4C09D4 Arcadyan Technology Corporation
//18C086 Broadcom
//001018, "Broadcom
//C8FF28", "Liteon Technology Corporation
//B81619", "ARRIS Group, Inc.
//B077AC ARRIS Group, Inc.
//FCB4E6 ASKEY COMPUTER CORP
//00192C ARRIS Group, Inc.
//00195E, "ARRIS Group, Inc.
//001A1B ARRIS Group, Inc.
//001A66 ARRIS Group, Inc.
//001A77 ARRIS Group, Inc.
//64ED57, "ARRIS Group, Inc.
//A4ED4E ARRIS Group, Inc.
//00211E, "ARRIS Group, Inc.
//002180, "ARRIS Group, Inc.
//001BDD ARRIS Group, Inc.
//001D6B ARRIS Group, Inc.
//001DBE ARRIS Group, Inc.
//0012C9 ARRIS Group, Inc.
//0023A2 ARRIS Group, Inc.
//0023ED, "ARRIS Group, Inc.
//001B52 ARRIS Group, Inc.
//001E8D, "ARRIS Group, Inc.
//E0469A NETGEAR
//30469A NETGEAR
//002493, "ARRIS Group, Inc.
//002641, "ARRIS Group, Inc.
//0015D0, "ARRIS Group, Inc.
//001596, "ARRIS Group, Inc.
//04E676, "AMPAK Technology, Inc.
//0022F4, "AMPAK Technology, Inc.
//001DBA Sony Corporation
//0024BE Sony Corporation
//000FDE Sony Mobile Communications Inc
//0CFE45 Sony Interactive Entertainment Inc.
//2016D8, "Liteon Technology Corporation
//E063E5", "Sony Mobile Communications Inc
//F8D0AC Sony Interactive Entertainment Inc.
//2421AB Sony Mobile Communications Inc
//B8F934", "Sony Mobile Communications Inc
//8C6422 Sony Mobile Communications Inc
//20E564, "ARRIS Group, Inc.
//90B134 ARRIS Group, Inc.
//40B7F3 ARRIS Group, Inc.
//001B59 Sony Mobile Communications Inc
//002298, "Sony Mobile Communications Inc
//0017E2, "ARRIS Group, Inc.
//001675, "ARRIS Group, Inc.
//000CE5 ARRIS Group, Inc.
//0003E0, "ARRIS Group, Inc.
//00D0C9 ADVANTECH CO., LTD.
//6487D7, "ADB Broadband Italia
//E0B2F1", "FN-LINK TECHNOLOGY LIMITED
//0C4C39 MitraStar Technology Corp.
//74888B ADB Broadband Italia
//008C54 ADB Broadband Italia
//00247B Actiontec Electronics, Inc
//0004E3, "Accton Technology Corp
//0010B5 Accton Technology Corp
//001974, "16063
//E8617E Liteon Technology Corporation
//18CF5E Liteon Technology Corporation
//F0272D Amazon Technologies Inc.
//84D6D0, "Amazon Technologies Inc.
//18FE34 Espressif Inc.
//38229D, "ADB Broadband Italia
//A4526F", "ADB Broadband Italia
//605BB4 AzureWave Technology Inc.
//64D954, "Taicang T&W Electronics
//5C36B8 TCL King Electrical Appliances (Huizhou) Co., Ltd
//00AA01 Intel Corporation
//985FD3 Microsoft Corporation
//00DA55 Cisco Systems, Inc
//18E3BC TCT mobile ltd
//CC1FC4 InVue
//00AA00 Intel Corporation
//00C2C6 Intel Corporate
//5CD2E4 Intel Corporate
//28B2BD Intel Corporate
//002243, "AzureWave Technology Inc.
//00006E, "Artisoft Inc.
//448723, "HOYA SERVICE CORPORATION
//D86C02", "Huaqin Telecom Technology Co., Ltd
//60BEB5 Motorola Mobility LLC, a Lenovo Company
//F8F1B6", "Motorola Mobility LLC, a Lenovo Company
//3CFDFE Intel Corporate
//A4C494", "Intel Corporate
//902E1C Intel Corporate
//A434D9", "Intel Corporate
//685D43, "Intel Corporate
//A0369F Intel Corporate
//64D4DA Intel Corporate
//4025C2 Intel Corporate
//502DA2 Intel Corporate
//78929C Intel Corporate
//843A4B Intel Corporate
//5C514F Intel Corporate
//A44E31", "Intel Corporate
//4CEB42 Intel Corporate
//F81654", "Intel Corporate
//606C66 Intel Corporate
//4C8093 Intel Corporate
//AC7289", "Intel Corporate
//448500, "Intel Corporate
//0CD292 Intel Corporate
//DCA971", "Intel Corporate
//58946B Intel Corporate
//0024D7, "Intel Corporate
//0024D6, "Intel Corporate
//001DE0 Intel Corporate
//4C79BA Intel Corporate
//84A6C8 Intel Corporate
//5891CF Intel Corporate
//0C8BFD Intel Corporate
//00215C Intel Corporate
//00216B Intel Corporate
//0022FB Intel Corporate
//001517, "Intel Corporate
//A0A8CD Intel Corporate
//5CC5D4 Intel Corporate
//001E64, "Intel Corporate
//F4F1E1 Motorola Mobility LLC, a Lenovo Company
//9CD917 Motorola Mobility LLC, a Lenovo Company
//9068C3 Motorola Mobility LLC, a Lenovo Company
//3C197D Ericsson AB
//B4E10F", "Dell Inc.
//002219, "Dell Inc.
//0024E8, "Dell Inc.
//B083FE Dell Inc.
//3417EB Dell Inc.
//F8BC12 Dell Inc.
//18A99B Dell Inc.
//001372, "Dell Inc.
//001143, "Dell Inc.
//4C7625 Dell Inc.
//44A842 Dell Inc.
//00253C", "2Wire Inc
//34EF44, "2Wire Inc
//B0E754", "2Wire Inc
//F01FAF Dell Inc.
//00188B Dell Inc.
//000874, "Dell Inc.
//B8E625", "2Wire Inc
//001D5A", "2Wire Inc
//1C4419 TP-LINK TECHNOLOGIES CO., LTD.
//5C353B Compal Broadband Networks, Inc.
//28FAA0 vivo Mobile Communication Co., Ltd.
//ECDF3A vivo Mobile Communication Co., Ltd.
//F42981 vivo Mobile Communication Co., Ltd.
//84F6FA Miovision Technologies Incorporated
//70106F, "Hewlett Packard Enterprise
//F8E71E", "Ruckus Wireless
//08863B Belkin International Inc.
//247C4C Herman Miller
//E46F13", "D-Link International
//2C56DC ASUSTek COMPUTER INC.
//003146, "Juniper Networks
//00604C Sagemcom Broadband SAS
//001F95, "Sagemcom Broadband SAS
//002348, "Sagemcom Broadband SAS
//002691, "Sagemcom Broadband SAS
//988B5D Sagemcom Broadband SAS
//90013B Sagemcom Broadband SAS
//7C034C Sagemcom Broadband SAS
//6C2E85 Sagemcom Broadband SAS
//94FEF4 Sagemcom Broadband SAS
//34B1F7 Texas Instruments
//2CFD37 Blue Calypso, Inc.
//0C6127 Actiontec Electronics, Inc
//3CD92B Hewlett Packard
//78DEE4 Texas Instruments
//001833, "Texas Instruments
//001834, "Texas Instruments
//0017E3, "Texas Instruments
//001830, "Texas Instruments
//0023D4, "Texas Instruments
//BCF685 D-Link International
//78542E, "D-Link International
//C4A81D D-Link International
//002191, "D-Link Corporation
//ACF1DF D-Link International
//C0E422 Texas Instruments
//D00790", "Texas Instruments
//3C7DB1 Texas Instruments
//F4FC32", "Texas Instruments
//90D7EB Texas Instruments
//0017E8, "Texas Instruments
//001783, "Texas Instruments
//00F871, "DGS Denmark A/S
//2435CC Zhongshan Scinan Internet of Things Co., Ltd.
//2C3033 NETGEAR
//CC46D6 Cisco Systems, Inc
//0041D2, "Cisco Systems, Inc
//2CAB00 HUAWEI TECHNOLOGIES CO., LTD
//A8CA7B", "HUAWEI TECHNOLOGIES CO., LTD
//BC4434", "Shenzhen TINNO Mobile Technology Corp.
//04BF6D Zyxel Communications Corporation
//F88FCA Google, Inc.
//3898D8, "MERITECH CO., LTD
//C8675E", "Aerohive Networks Inc.
//9486CD SEOUL ELECTRONICS&TELECOM
//3897D6, "Hangzhou H3C Technologies Co., Limited
//1CA770 SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD
//4419B6 Hangzhou Hikvision Digital Technology Co., Ltd.
//F09CE9 Aerohive Networks Inc.
//9C5D12 Aerohive Networks Inc.
//C413E2 Aerohive Networks Inc.
//68DBCA Apple, Inc.
//086698, "Apple, Inc.
//BC5436 Apple, Inc.
//044BED Apple, Inc.
//6C8DC1 Apple, Inc.
//84ACFB Crouzet Automatismes
//7CBB8A Nintendo Co., Ltd.
//FCFFAA IEEE Registration Authority
//0CD746 Apple, Inc.
//60A37D Apple, Inc.
//88A25E Juniper Networks
//541E56, "Juniper Networks
//8896B6 Global Fire Equipment S.A.
//88B8D0 Dongguan Koppo Electronic Co., Ltd
//601971, "ARRIS Group, Inc.
//F8CAB8 Dell Inc.
//001111, "Intel Corporation
//001302, "Intel Corporate
//6CCA08 ARRIS Group, Inc.
//78719C ARRIS Group, Inc.
//D40598 ARRIS Group, Inc.
//E83381 ARRIS Group, Inc.
//8C7F3B ARRIS Group, Inc.
//5C571A ARRIS Group, Inc.
//E8892C ARRIS Group, Inc.
//94877C ARRIS Group, Inc.
//407009, "ARRIS Group, Inc.
//083E0C ARRIS Group, Inc.
//3C36E4 ARRIS Group, Inc.
//1C1B68 ARRIS Group, Inc.
//000423, "Intel Corporation
//207355, "ARRIS Group, Inc.
//F8EDA5 ARRIS Group, Inc.
//5465DE ARRIS Group, Inc.
//58AC78 Cisco Systems, Inc
//780AC7 Baofeng TV Co., Ltd.
//000D0B, "BUFFALO.INC
//001D73, "BUFFALO.INC
//001601, "BUFFALO.INC
//7403BD BUFFALO.INC
//B8FC9A", "Le Shi Zhi Xin Electronic Technology (Tianjin) Limited
//A45D36 Hewlett Packard
//F0921C", "Hewlett Packard
//A0481C Hewlett Packard
//A01D48", "Hewlett Packard
//40A8F0 Hewlett Packard
//8851FB Hewlett Packard
//082E5F, "Hewlett Packard
//E4115B Hewlett Packard
//28924A Hewlett Packard
//288023, "Hewlett Packard
//CC3E5F Hewlett Packard
//D89D67", "Hewlett Packard
//0014C2 Hewlett Packard
//00805F, "Hewlett Packard
//0018FE Hewlett Packard
//001A4B Hewlett Packard
//002481, "Hewlett Packard
//000F61, "Hewlett Packard
//480FCF Hewlett Packard
//D40B1A", "HTC Corporation
//945330, "Hon Hai Precision Ind. Co., Ltd.
//A08D16 HUAWEI TECHNOLOGIES CO., LTD
//4CD08A HUMAX Co., Ltd.
//CC4EEC HUMAX Co., Ltd.
//403DEC HUMAX Co., Ltd.
//EC4D47 HUAWEI TECHNOLOGIES CO., LTD
//C44044", "RackTop Systems Inc.
//4CA161 Rain Bird Corporation
//8CAB8E Shanghai Feixun Communication Co., Ltd.
//FC64BA Xiaomi Communications Co Ltd
//9060F1, "Apple, Inc.
//F8D111 TP-LINK TECHNOLOGIES CO., LTD.
//B0487A TP-LINK TECHNOLOGIES CO., LTD.
//940C6D TP-LINK TECHNOLOGIES CO., LTD.
//A4516F Microsoft Mobile Oy
//542758, "Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//00242B Hon Hai Precision Ind.Co., Ltd.
//000480, "Brocade Communications Systems, Inc.
//000CDB Brocade Communications Systems, Inc.
//001BED Brocade Communications Systems, Inc.
//000533, "Brocade Communications Systems, Inc.
//006069, "Brocade Communications Systems, Inc.
//08181A zte corporation
//001E73, "zte corporation
//0015EB zte corporation
//001C25 Hon Hai Precision Ind.Co., Ltd.
//00197E, "Hon Hai Precision Ind. Co., Ltd.
//90FBA6 Hon Hai Precision Ind.Co., Ltd.
//4437E6, "Hon Hai Precision Ind. Co., Ltd.
//CCAF78 Hon Hai Precision Ind.Co., Ltd.
//F4B7E2 Hon Hai Precision Ind.Co., Ltd.
//647002, "TP-LINK TECHNOLOGIES CO., LTD.
//10FEED TP-LINK TECHNOLOGIES CO., LTD.
//645601, "TP-LINK TECHNOLOGIES CO., LTD.
//F02765 Murata Manufacturing Co., Ltd.
//5CF8A1 Murata Manufacturing Co., Ltd.
//44A7CF Murata Manufacturing Co., Ltd.
//0013E0, "Murata Manufacturing Co., Ltd.
//EC26CA TP-LINK TECHNOLOGIES CO., LTD.
//9471AC TCT mobile ltd
//2C088C HUMAX Co., Ltd.
//1C994C Murata Manufacturing Co., Ltd.
//0060DF Brocade Communications Systems, Inc.
//000088, "Brocade Communications Systems, Inc.
//F4559C HUAWEI TECHNOLOGIES CO., LTD
//80B686 HUAWEI TECHNOLOGIES CO., LTD
//10C61F HUAWEI TECHNOLOGIES CO., LTD
//CC96A0", "HUAWEI TECHNOLOGIES CO., LTD
//F80113", "HUAWEI TECHNOLOGIES CO., LTD
//A49947", "HUAWEI TECHNOLOGIES CO., LTD
//C8D15E", "HUAWEI TECHNOLOGIES CO., LTD
//785968, "Hon Hai Precision Ind. Co., Ltd.
//C07009 HUAWEI TECHNOLOGIES CO., LTD
//8038BC HUAWEI TECHNOLOGIES CO., LTD
//C4072F", "HUAWEI TECHNOLOGIES CO., LTD
//F48E92", "HUAWEI TECHNOLOGIES CO., LTD
//00664B HUAWEI TECHNOLOGIES CO., LTD
//9CC172 HUAWEI TECHNOLOGIES CO., LTD
//247F3C HUAWEI TECHNOLOGIES CO., LTD
//581F28, "HUAWEI TECHNOLOGIES CO., LTD
//ECCB30", "HUAWEI TECHNOLOGIES CO., LTD
//F4DCF9", "HUAWEI TECHNOLOGIES CO., LTD
//308730, "HUAWEI TECHNOLOGIES CO., LTD
//C057BC", "Avaya Inc
//64A7DD Avaya Inc
//241FA0 HUAWEI TECHNOLOGIES CO., LTD
//18C58A HUAWEI TECHNOLOGIES CO., LTD
//080028, "Texas Instruments
//405FC2 Texas Instruments
//E0E5CF", "Texas Instruments
//68DFDD Xiaomi Communications Co Ltd
//7054F5, "HUAWEI TECHNOLOGIES CO., LTD
//DCD2FC", "HUAWEI TECHNOLOGIES CO., LTD
//9017AC HUAWEI TECHNOLOGIES CO., LTD
//34CDBE HUAWEI TECHNOLOGIES CO., LTD
//D8490B", "HUAWEI TECHNOLOGIES CO., LTD
//44322A Avaya Inc
//7038EE Avaya Inc
//703018, "Avaya Inc
//9C28EF HUAWEI TECHNOLOGIES CO., LTD
//EC24B8", "Texas Instruments
//7CEC79 Texas Instruments
//689E19, "Texas Instruments
//20CD39 Texas Instruments
//B4994C", "Texas Instruments
//A4251B Avaya Inc
//646A52 Avaya Inc
//00100B Cisco Systems, Inc
//00173B Cisco Systems, Inc
//04DAD2 Cisco Systems, Inc
//F02929", "Cisco Systems, Inc
//20BBC0 Cisco Systems, Inc
//4C4E35 Cisco Systems, Inc
//98FAE3 Xiaomi Communications Co Ltd
//F0B429", "Xiaomi Communications Co Ltd
//005080, "Cisco Systems, Inc
//005073, "Cisco Systems, Inc
//00900C Cisco Systems, Inc
//00905F, "Cisco Systems, Inc
//00E0F7, "Cisco Systems, Inc
//001BD7 Cisco SPVTG
//006083, "Cisco Systems, Inc
//006009, "Cisco Systems, Inc
//00067C Cisco Systems, Inc
//00107B Cisco Systems, Inc
//0050E2, "Cisco Systems, Inc
//E4D3F1", "Cisco Systems, Inc
//8478AC Cisco Systems, Inc
//0090A6 Cisco Systems, Inc
//009086, "Cisco Systems, Inc
//00248C ASUSTek COMPUTER INC.
//002354, "ASUSTek COMPUTER INC.
//1C872C ASUSTek COMPUTER INC.
//60182E, "ShenZhen Protruly Electronic Ltd co.
//C4143C Cisco Systems, Inc
//3C08F6 Cisco Systems, Inc
//001E8C ASUSTek COMPUTER INC.
//0013D4, "ASUSTek COMPUTER INC.
//20CF30 ASUSTek COMPUTER INC.
//BC1665 Cisco Systems, Inc
//F872EA", "Cisco Systems, Inc
//D0C789", "Cisco Systems, Inc
//F84F57", "Cisco Systems, Inc
//501CBF Cisco Systems, Inc
//B000B4", "Cisco Systems, Inc
//544A00 Cisco Systems, Inc
//00E16D, "Cisco Systems, Inc
//78BAF9 Cisco Systems, Inc
//0022CE Cisco SPVTG
//E0D173", "Cisco Systems, Inc
//E0899D", "Cisco Systems, Inc
//C47295", "Cisco Systems, Inc
//7C69F6 Cisco Systems, Inc
//78DA6E Cisco Systems, Inc
//B8782E", "Apple, Inc.
//000502, "Apple, Inc.
//000A95 Apple, Inc.
//34BDC8 Cisco Systems, Inc
//DCEB94", "Cisco Systems, Inc
//84B517 Cisco Systems, Inc
//1C6E4C Logistic Service & Engineering Co., Ltd
//000F66, "Cisco-Linksys, LLC
//24374C Cisco SPVTG
//188B9D Cisco Systems, Inc
//E4AA5D", "Cisco Systems, Inc
//F45FD4", "Cisco SPVTG
//2CABA4 Cisco SPVTG
//00264A Apple, Inc.
//041E64, "Apple, Inc.
//001124, "Apple, Inc.
//002241, "Apple, Inc.
//7CC537 Apple, Inc.
//78CA39 Apple, Inc.
//18E7F4, "Apple, Inc.
//70CD60 Apple, Inc.
//8C7B9D Apple, Inc.
//D89E3F Apple, Inc.
//B8C75D Apple, Inc.
//0C74C2 Apple, Inc.
//403004, "Apple, Inc.
//842999, "Apple, Inc.
//74E2F5, "Apple, Inc.
//E0C97A Apple, Inc.
//68A86D Apple, Inc.
//7CC3A1 Apple, Inc.
//7073CB Apple, Inc.
//90840D, "Apple, Inc.
//E80688 Apple, Inc.
//EC852F Apple, Inc.
//00F4B9 Apple, Inc.
//5C95AE Apple, Inc.
//9803D8, "Apple, Inc.
//60C547 Apple, Inc.
//685B35 Apple, Inc.
//2CB43A Apple, Inc.
//689C70 Apple, Inc.
//380F4A Apple, Inc.
//3010E4, "Apple, Inc.
//A886DD Apple, Inc.
//444C0C Apple, Inc.
//B4F0AB Apple, Inc.
//80929F, "Apple, Inc.
//9C04EB Apple, Inc.
//5C969D Apple, Inc.
//609217, "Apple, Inc.
//84B153 Apple, Inc.
//E06678 Apple, Inc.
//48D705, "Apple, Inc.
//041552, "Apple, Inc.
//CC785F Apple, Inc.
//88CB87 Apple, Inc.
//F0C1F1 Apple, Inc.
//843835, "Apple, Inc.
//8C006D Apple, Inc.
//A8968A Apple, Inc.
//F41BA1 Apple, Inc.
//60D9C7 Apple, Inc.
//3CAB8E Apple, Inc.
//F82793 Apple, Inc.
//907240, "Apple, Inc.
//908D6C Apple, Inc.
//B8098A Apple, Inc.
//4C7C5F Apple, Inc.
//68644B Apple, Inc.
//C81EE7 Apple, Inc.
//A43135 Apple, Inc.
//68D93C Apple, Inc.
//00F76F, "Apple, Inc.
//C88550 Apple, Inc.
//7014A6 Apple, Inc.
//985AEB Apple, Inc.
//78D75F, "Apple, Inc.
//E0B52D Apple, Inc.
//6C94F8 Apple, Inc.
//C0CECD Apple, Inc.
//F44B2A Cisco SPVTG
//746F19, "ICARVISIONS (SHENZHEN) TECHNOLOGY CO., LTD.
//2CAE2B Samsung Electronics Co., Ltd
//C4ADF1", "GOPEACE Inc.
//58FC73 Arria Live Media, Inc.
//0C1A10 Acoustic Stream
//C4EF70", "Home Skinovations
//5CE3B6 Fiberhome Telecommunication Technologies Co., LTD
//7C5A67 JNC Systems, Inc.
//A0F9E0 VIVATEL COMPANY LIMITED
//C869CD Apple, Inc.
//A4B805 Apple, Inc.
//90C99B Tesorion Nederland B.V.
//5CADCF Apple, Inc.
//080A4E Planet Bingo® — 3rd Rock Gaming®
//B49D0B BQ
//3C8CF8 TRENDnet, Inc.
//E81363 Comstock RD, Inc.
//741865, "Shanghai DareGlobal Technologies Co., Ltd
//BC6C21", "Apple, Inc.
//F8C372 TSUZUKI DENKI
//D47208", "Bragi GmbH
//A87285 IDT, INC.
//780541, "Queclink Wireless Solutions Co., Ltd
//044169, "GoPro
//C02DEE", "Cuff
//6CEBB2 Dongguan Sen DongLv Electronics Co., Ltd
//3C7A8A ARRIS Group, Inc.
//F40E22 Samsung Electronics Co., Ltd
//881B99 SHENZHEN XIN FEI JIA ELECTRONIC CO.LTD.
//544E90, "Apple, Inc.
//A4A6A9 Private
//8C10D4 Sagemcom Broadband SAS
//F898B9 HUAWEI TECHNOLOGIES CO., LTD
//5CB559 CNEX Labs
//B83A9D", "Alarm.com
//6858C5 ZF TRW Automotive
//C01173 Samsung Electronics Co., Ltd
//7853F2, "ROXTON Ltd.
//BCE63F Samsung Electronics Co., Ltd
//7C9122 Samsung Electronics Co., Ltd
//ACBC32", "Apple, Inc.
//9023EC Availink, Inc.
//441CA8 Hon Hai Precision Ind.Co., Ltd.
//B4293D Shenzhen Urovo Technology Co., Ltd.
//54FF82 Davit Solution co.
//50DF95 Lytx
//9CA69D Whaley Technology Co.Ltd
//5853C0 Beijing Guang Runtong Technology Development Company co., Ltd
//2CA539 Parallel Wireless, Inc
//CC794A", "BLU Products Inc.
//F4E926 Tianjin Zanpu Technology Inc.
//906F18, "Private
//98CB27 Galore Networks Pvt. Ltd.
//E8F2E2 LG Innotek
//247260, "IOTTECH Corp
//245BF0 Liteon, Inc.
//E855B4 SAI Technology Inc.
//340CED Moduel AB
//2827BF Samsung Electronics Co., Ltd
//94D859, "TCT mobile ltd
//2CFCE4 CTEK Sweden AB
//C0EE40 Laird Technologies
//F4B8A7", "zte corporation
//300C23 zte corporation
//C0B713", "Beijing Xiaoyuer Technology Co. Ltd.
//1005B1 ARRIS Group, Inc.
//20635F, "Abeeway
//083A5C Junilab, Inc.
//B8B3DC DEREK (SHAOGUAN) LIMITED
//702A7D EpSpot AB
//4CAE31 ShengHai Electronics (Shenzhen) Ltd
//188EF9, "G2C Co. Ltd.
//44F436, "zte corporation
//C47D46 FUJITSU LIMITED
//185D9A BobjGear LLC
//F4E9D4", "QLogic Corporation
//4CB76D Novi Security
//6CE01E Modcam AB
//74852A PEGATRON CORPORATION
//9CB6D0 Rivet Networks
//40B89A Hon Hai Precision Ind.Co., Ltd.
//1CB72C ASUSTek COMPUTER INC.
//40B837 Sony Mobile Communications Inc
//4CEEB0 SHC Netzwerktechnik GmbH
//800184, "HTC Corporation
//44C69B Wuhan Feng Tian Information Network CO., LTD
//FCE33C", "HUAWEI TECHNOLOGIES CO., LTD
//C02567", "Nexxt Solutions
//609C9F Brocade Communications Systems, Inc.
//A8827F CIBN Oriental Network(Beijing) CO., Ltd
//D048F3", "DATTUS Inc
//B8C3BF Henan Chengshi NetWork Technology Co.，Ltd
//44962B Aidon Oy
//E076D0", "AMPAK Technology, Inc.
//B008BF Vital Connect, Inc.
//D4522A TangoWiFi.com
//E807BF", "SHENZHEN BOOMTECH INDUSTRY CO., LTD
//84F129, "Metrascale Inc.
//B89ACD ELITE OPTOELECTRONIC(ASIA) CO., LTD
//D468BA", "Shenzhen Sundray Technologies Company Limited
//086266, "ASUSTek COMPUTER INC.
//9C3066 RWE Effizienz GmbH
//18BDAD L-TECH CORPORATION
//60E6BC Sino-Telecom Technology Co., Ltd.
//C8C50E Shenzhen Primestone Network Technologies.Co., Ltd.
//D06A1F BSE CO., LTD.
//700136, "FATEK Automation Corporation
//FCA22A", "PT.Callysta Multi Engineering
//A45602", "fenglian Technology Co., Ltd.
//94E2FD Boge Kompressoren OTTO Boge GmbH & Co.KG
//F01E34", "ORICO Technologies Co., Ltd
//DCE026", "Patrol Tag, Inc
//B40566", "SP Best Corporation Co., LTD.
//1CC72D Shenzhen Huapu Digital CO., Ltd
//A89008", "Beijing Yuecheng Technology Co. Ltd.
//183864, "CAP-TECH INTERNATIONAL CO., LTD.
//6CF5E8 Mooredoll Inc.
//8CBFA6 Samsung Electronics Co., Ltd
//C8A823", "Samsung Electronics Co., Ltd
//B0C559", "Samsung Electronics Co., Ltd
//F42C56", "SENOR TECH CO LTD
//FCDC4A G-Wearables Corp.
//1C14B3 Airwire Technologies
//A48CDB", "Lenovo
//D85DE2", "Hon Hai Precision Ind. Co., Ltd.
//3C912B Vexata Inc
//346C0F Pramod Telecom Pvt. Ltd
//BC1485", "Samsung Electronics Co., Ltd
//9C6C15 Microsoft Corporation
//445ECD Razer Inc
//4CA928 Insensi
//E8447E Bitdefender SRL
//C0335E", "Microsoft
//B0E03C", "TCT mobile ltd
//B0495F", "OMRON HEALTHCARE Co., Ltd.
//60F189, "Murata Manufacturing Co., Ltd.
//742EFC DirectPacket Research, Inc,
//84CFBF Fairphone
//ACD1B8 Hon Hai Precision Ind.Co., Ltd.
//A0C2DE Costar Video Systems
//88E161, "Art Beijing Science and Technology Development Co., Ltd.
//00A509 WigWag Inc.
//7491BD Four systems Co., Ltd.
//F0FE6B Shanghai High-Flying Electronics Technology Co., Ltd
//3CAE69 ESA Elektroschaltanlagen Grimma GmbH
//D43266", "Fike Corporation
//900CB4 Alinket Electronic Technology Co., Ltd
//48C093 Xirrus, Inc.
//DC0914 Talk-A-Phone Co.
//D0929E Microsoft Corporation
//BC52B4", "Nokia
//9405B6 Liling FullRiver Electronics & Technology Ltd
//00F3DB WOO Sports
//78312B zte corporation
//C81B6B", "Innova Security
//3438AF Inlab Software GmbH
//B4A828 Shenzhen Concox Information Technology Co., Ltd
//00A2F5 Guangzhou Yuanyun Network Technology Co., Ltd
//1008B1 Hon Hai Precision Ind.Co., Ltd.
//E48C0F Discovery Insure
//E42354", "SHENZHEN FUZHI SOFTWARE TECHNOLOGY CO., LTD
//94BF95 Shenzhen Coship Electronics Co., Ltd
//44CE7D SFR
//344DEA zte corporation
//4C16F1 zte corporation
//10FACE Reacheng Communication Technology Co., Ltd
//9470D2, "WINFIRM TECHNOLOGY
//A44AD3 ST Electronics(Shanghai) Co., Ltd
//7CB177 Satelco AG
//CC3080", "VAIO Corporation
//587BE9 AirPro Technology India Pvt.Ltd
//8C18D9 Shenzhen RF Technology Co., Ltd
//C4BD6A", "SKF GmbH
//C401CE PRESITION (2000) CO., LTD.
//187117, "eta plus electronic gmbh
//EC0EC4 Hon Hai Precision Ind.Co.,Ltd.
//30FAB7 Tunai Creative
//0809B6 Masimo Corp
//4CF5A0 Scalable Network Technologies Inc
//D8FB11", "AXACORE
//4CE933 RailComm, LLC
//CCE17F Juniper Networks
//E4C62B", "Airware
//EC1D7F", "zte corporation
//AC3870 Lenovo Mobile Communication Technology Ltd.
//4CBC42 Shenzhen Hangsheng Electronics Co., Ltd.
//70F196, "Actiontec Electronics, Inc
//188219, "Alibaba Cloud Computing Ltd.
//28A5EE Shenzhen SDGI CATV Co., Ltd
//D0A0D6", "Chengdu TD Tech Ltd.
//ECB907 CloudGenix Inc
//F42833", "MMPC Inc.
//0C8C8F Kamo Technology Limited
//A4A4D3 Bluebank Communication Technology Co.Ltd
//A8329A", "Digicom Futuristic Technologies Ltd.
//F4D032 Yunnan Ideal Information&Technology., Ltd
//600292, "PEGATRON CORPORATION
//B4B859 Texa Spa
//5CF9F0 Atomos Engineering P/L
//702DD1 Newings Communication CO., LTD.
//147590, "TP-LINK TECHNOLOGIES CO., LTD.
//50BD5F TP-LINK TECHNOLOGIES CO., LTD.
//987E46, "Emizon Networks Limited
//3C46D8 TP-LINK TECHNOLOGIES CO., LTD.
//4C83DE Cisco SPVTG
//A81374", "Panasonic Corporation AVC Networks Company
//083D88, "Samsung Electronics Co., Ltd
//BC4E5D", "ZhongMiao Technology Co., Ltd.
//3C189F Nokia Corporation
//7C6AC3 GatesAir, Inc
//5C5BC2 YIK Corporation
//30595B streamnow AG
//84850A Hella Sonnen- und Wetterschutztechnik GmbH
//08CD9B samtec automotive electronics & software GmbH
//28E6E9 SIS Sat Internet Services GmbH
//F4FD2B ZOYI Company
//F4F646", "Dediprog Technology Co.Ltd.
//300D2A Zhejiang Wellcom Technology Co., Ltd.
//045C8E gosund GROUP CO., LTD
//7CC4EF Devialet
//D85DFB Private
//DCF110 Nokia Corporation
//608F5C Samsung Electronics Co., Ltd
//DC38E1", "Juniper Networks
//908C63 GZ Weedong Networks Technology Co. , Ltd
//E8EF89", "OPMEX Tech.
//109266, "Samsung Electronics Co., Ltd
//EC2E4E", "HITACHI-LG DATA STORAGE INC
//D46761 United Gulf Gate Co.
//3481C4 AVM GmbH
//983713, "PT.Navicom Indonesia
//A47E39 zte corporation
//CCB691", "NECMagnusCommunications
//40167E, "ASUSTek COMPUTER INC.
//F84A73 EUMTECH CO., LTD
//142BD6 Guangdong Appscomm Co., Ltd
//FCC2DE", "Murata Manufacturing Co., Ltd.
//98349D, "Krauss Maffei Technologies GmbH
//880FB6 Jabil Circuits India Pvt Ltd,-EHTP unit
//B46698 Zealabs srl
//687CC8 Measurement Systems S. de R.L.
//74F85D, "Berkeley Nucleonics Corp
//B061C7", "Ericsson-LG Enterprise
//0092FA SHENZHEN WISKY TECHNOLOGY CO., LTD
//4C7F62 Nokia Corporation
//100F18, "Fu Gang Electronic(KunShan) CO., LTD
//D0C7C0", "TP-LINK TECHNOLOGIES CO., LTD.
//4411C2 Telegartner Karl Gartner GmbH
//8059FD Noviga
//400107, "Arista Corp
//30C750 MIC Technology Group
//18CC23 Philio Technology Corporation
//407875, "IMBEL - Industria de Material Belico do Brasil
//D881CE", "AHN INC.
//28C825 DellKing Industrial Co., Ltd
//80618F, "Shenzhen sangfei consumer communications co., ltd
//D82A15", "Leitner SpA
//447E76, "Trek Technology (S) Pte Ltd
//B0EC8F", "GMX SAS
//28DEF6 bioMerieux Inc.
//580528, "LABRIS NETWORKS
//E0D31A EQUES Technology Co., Limited
//987770, "Pep Digital Technology (Guangzhou) Co., Ltd
//68D247, "Portalis LC
//50B695 Micropoint Biotechnologies, Inc.
//B4430D Broadlink Pty Ltd
//A06518 VNPT TECHNOLOGY
//7C8D91 Shanghai Hongzhuo Information Technology co., LTD
//748F1B MasterImage 3D
//083F76, "Intellian Technologies, Inc.
//CC89FD Nokia Corporation
//34466F, "HiTEM Engineering
//386C9B Ivy Biomedical
//B42C92", "Zhejiang Weirong Electronic Co., Ltd
//A07771", "Vialis BV
//10DDF4 Maxway Electronics CO., LTD
//5CE7BF New Singularity International Technical Development Co., Ltd
//6C641A Penguin Computing
//50A054 Actineon
//B48547 Amptown System Company GmbH
//5056A8 Jolla Ltd
//E8E770", "Warp9 Tech Design, Inc.
//609620, "Private
//C0F991", "GME Standard Communications P/L
//D87CDD", "SANIX INCORPORATED
//707C18 ADATA Technology Co., Ltd
//14F28E, "ShenYang ZhongKe-Allwin Technology Co.LTD
//BC14EF", "ITON Technology Limited
//080371, "KRG CORPORATE
//200E95, "IEC – TC9 WG43
//C8F68D S.E.TECHNOLOGIES LIMITED
//3CD4D6 WirelessWERX, Inc
//0C1262 zte corporation
//78EC74 Kyland-USA
//98DA92 Vuzix Corporation
//387B47 AKELA, Inc.
//C064C6 Nokia Corporation
//E40439", "TomTom Software Ltd
//D0C42F", "Tamagawa Seiki Co., Ltd.
//549359, "SHENZHEN TWOWING TECHNOLOGIES CO., LTD.
//90356E, "Vodafone Omnitel N.V.
//284430, "GenesisTechnical Systems (UK) Ltd
//5C1193 Seal One AG
//783D5B TELNET Redes Inteligentes S.A.
//D0B523 Bestcare Cloucal Corp.
//24A495 Thales Canada Inc.
//847616, "Addat s.r.o.
//DC0575 SIEMENS ENERGY AUTOMATION
//E097F2 Atomax Inc.
//70305E, "Nanjing Zhongke Menglian Information Technology Co., LTD
//C098E5", "University of Michigan
//50E14A Private
//708D09, "Nokia Corporation
//98FB12 Grand Electronics (HK) Ltd
//3C1040 daesung network
//443C9C Pintsch Tiefenbach GmbH
//28FC51 The Electric Controller and Manufacturing Co., LLC
//407496, "aFUN TECHNOLOGY INC.
//701D7F, "Comtech Technology Co., Ltd.
//705986, "OOO TTV
//844F03, "Ablelink Electronics Ltd
//906717, "Alphion India Private Limited
//6064A1 RADiflow Ltd.
//58B961 SOLEM Electronique
//0C473D Hitron Technologies.Inc
//8CCDA2 ACTP, Inc.
//84262B Nokia
//986CF5 zte corporation
//447BC4 DualShine Technology(SZ) Co., Ltd
//9C039E Beijing Winchannel Software Technology Co., Ltd
//680AD7 Yancheng Kecheng Optoelectronic Technology Co., Ltd
//BC8893", "VILLBAU Ltd.
//706173, "Calantec GmbH
//7C49B9 Plexus Manufacturing Sdn Bhd
//9CF8DB shenzhen eyunmei technology co,.ltd
//20D21F, "Wincal Technology Corp.
//F89550 Proton Products Chengdu Ltd
//58639A TPL SYSTEMES
//187ED5, "shenzhen kaism technology Co. Ltd
//841B38 Shenzhen Excelsecu Data Technology Co., Ltd
//4CCBF5 zte corporation
//44700B IFFU
//54A54B NSC Communications Siberia Ltd
//BC2B6B", "Beijing Haier IC Design Co., Ltd
//98D331, "Shenzhen Bolutek Technology Co., Ltd.
//38EC11 Novatek Microelectronics Corp.
//1C4158 Gemalto M2M GmbH
//9C2840 Discovery Technology, LTD..
//1C7B21 Sony Mobile Communications Inc
//E0AF4B", "Pluribus Networks, Inc.
//840F45, "Shanghai GMT Digital Technologies Co., Ltd
//2C5FF3 Pertronic Industries
//78491D, "The Will-Burt Company
//F46ABC Adonit Corp.Ltd.
//28C671 Yota Devices OY
//D86960 Steinsvik
//08EF3B MCS Logic Inc.
//E8EADA Denkovi Assembly Electronics LTD
//F85BC9", "M-Cube Spa
//7CB77B Paradigm Electronics Inc
//B0CE18 Zhejiang shenghui lighting co., Ltd
//6CF97C Nanoptix Inc.
//F8FF5F Shenzhen Communication Technology Co., Ltd
//102279, "ZeroDesktop, Inc.
//7C1AFC Dalian Co-Edifice Video Technology Co., Ltd
//F47A4E", "Woojeon&Handan
//04848A", "7INOVA TECHNOLOGY LIMITED
//EC2257", "JiangSu NanJing University Electronic Information Technology Co., Ltd
//F037A1", "Huike Electronics (SHENZHEN) CO., LTD.
//704CED TMRG, Inc.
//F08EDB VeloCloud Networks
//C0A39E", "EarthCam, Inc.
//109AB9 Tosibox Oy
//142D8B Incipio Technologies, Inc
//68EE96 Cisco SPVTG
//78D38D, "HONGKONG YUNLINK TECHNOLOGY LIMITED
//DCAE04 CELOXICA Ltd
//8005DF Montage Technology Group Limited
//681D64, "Sunwave Communications Co., Ltd
//4C21D0 Sony Mobile Communications Inc
//907A0A Gebr. Bode GmbH & Co KG
//A0C6EC ShenZhen ANYK Technology Co., LTD
//78E8B6 zte corporation
//1078CE Hanvit SI, Inc.
//D8DA52 APATOR S.A.
//587A4D Stonesoft Corporation
//84E629, "Bluwan SA
//C47F51 Inventek Systems
//A897DC", "IBM
//CCD29B", "Shenzhen Bopengfa Elec&Technology CO., Ltd
//A09BBD", "Total Aviation Solutions Pty Ltd
//D40BB9", "Solid Semecs bv.
//F415FD Shanghai Pateo Electronic Equipment Manufacturing Co., Ltd.
//70E027, "HONGYU COMMUNICATION TECHNOLOGY LIMITED
//FC35E6 Visteon corp
//E8481F", "Advanced Automotive Antennas
//3495DB Logitec Corporation
//9CB793 Creatcomm Technology Inc.
//5C335C Swissphone Telecom AG
//04DF69 Car Connectivity Consortium
//78DAB3 GBO Technology
//700FEC Poindus Systems Corp.
//F02405 OPUS High Technology Corporation
//D41090", "iNFORM Systems AG
//78D5B5 NAVIELEKTRO KY
//E47D5A", "Beijing Hanbang Technology Corp.
//E4F7A1 Datafox GmbH
//105C3B Perma-Pipe, Inc.
//349D90, "Heinzmann GmbH & CO.KG
//D862DB", "Eno Inc.
//C47DFE A.N.Solutions GmbH
//CCBD35 Steinel GmbH
//6CECA1 SHENZHEN CLOU ELECTRONICS CO.LTD.
//B03850 Nanjing CAS-ZDC IOT SYSTEM CO., LTD
//748E08, "Bestek Corp.
//78F5E5, "BEGA Gantenbrink-Leuchten KG
//8C3C07 Skiva Technologies, Inc.
//38A86B Orga BV
//F07765", "Sourcefire, Inc
//1441E2, "Monaco Enterprises, Inc.
//ECD040 GEA Farm Technologies GmbH
//F80DEA", "ZyCast Technology Inc.
//B08807 Strata Worldwide
//249504, "SFR
//F45842", "Boxx TV Ltd
//106682, "NEC Platforms, Ltd.
//246278, "sysmocom - systems for mobile communications GmbH
//F084C9", "zte corporation
//D4016D TP-LINK TECHNOLOGIES CO., LTD.
//985C93 SBG Systems SAS
//A08A87 HuiZhou KaiYue Electronic Co., Ltd
//28CD9C Shenzhen Dynamax Software Development Co., Ltd.
//C0C3B6 Automatic Systems
//A0EB76", "AirCUVE Inc.
//FC4499 Swarco LEA d.o.o.
//DC647C C.R.S.iiMotion GmbH
//148692, "TP-LINK TECHNOLOGIES CO., LTD.
//A8154D TP-LINK TECHNOLOGIES CO., LTD.
//5CF370 CC&C Technologies, Inc
//A4E0E6", "FILIZOLA S.A.PESAGEM E AUTOMACAO
//381766, "PROMZAKAZ LTD.
//18E8DD MODULETEK
//D073D5 LIFI LABS MANAGEMENT PTY LTD
//149448, "BLU CASTLE S.A.
//48F925, "Maestronic
//386793, "Asia Optical Co., Inc.
//0C8268 TP-LINK TECHNOLOGIES CO., LTD.
//D81EDE B&W Group Ltd
//24EA40 Helmholz GmbH & Co.KG
//D429EA", "Zimory GmbH
//34ADE4 Shanghai Chint Power Systems Co., Ltd.
//3C94D5 Juniper Networks
//68831A Pandora Mobility Corporation
//FCDB96 ENERVALLEY CO., LTD
//1423D7, "EUTRONIX CO., LTD.
//DC6F08 Bay Storage Technology
//90DA4E AVANU
//281878, "Microsoft Corporation
//7038B4 Low Tech Solutions
//745F00, "Samsung Semiconductor Inc.
//E0C3F3 zte corporation
//5C20D0 Asoni Communication Co., Ltd.
//ACA430 Peerless AV
//847A88 HTC Corporation
//A4D856", "Gimbal, Inc
//785517, "SankyuElectronics
//B47F5E", "Foresight Manufacture (S) Pte Ltd
//A0FE91", "AVAT Automation GmbH
//74ECF1 Acumen
//5809E5, "Kivic Inc.
//504F94, "Loxone Electronics GmbH
//60B185 ATH system
//BC629F", "Telenet Systems P.Ltd.
//380FE4 Dedicated Network Partners Oy
//48F230, "Ubizcore Co., LTD
//78324F, "Millennium Group, Inc.
//384369, "Patrol Products Consortium LLC
//44184F, "Fitview
//84ACA4 Beijing Novel Super Digital TV Technology Co., Ltd
//541FD5 Advantage Electronics
//ACE97F", "IoT Tech Limited
//E85AA7", "LLC Emzior
//9C9C1D Starkey Labs Inc.
//D0D6CC Wintop
//58D071, "BW Broadcast
//1C52D6 FLAT DISPLAY TECHNOLOGY CORPORATION
//D0DFB2", "Genie Networks Limited
//386645, "OOSIC Technology CO., Ltd
//B85AF7", "Ouya, Inc
//34F62D, "SHARP Corporation
//4C8FA5 Jastec
//84ED33, "BBMC Co., Ltd
//E82E24", "Out of the Fog Research LLC
//80FA5B CLEVO CO.
//C0B339 Comigo Ltd.
//20858C Assa
//60CDC5 Taiwan Carol Electronics., Ltd
//D8182B", "Conti Temic Microelectronic GmbH
//80CF41 Lenovo Mobile Communication Technology Ltd.
//9CE1D6 Junger Audio-Studiotechnik GmbH
//48B9C2 Teletics Inc.
//58D6D3, "Dairy Cheq Inc
//046E49, "TaiYear Electronic Technology (Suzhou) Co., Ltd
//2C3BFD Netstor Technology Co., Ltd.
//AC3CB4 Nilan A/S
//B49DB4", "Axion Technologies Inc.
//ACE87E Bytemark Computer Consulting Ltd
//8007A2 Esson Technology Inc.
//C0A0E2 Eden Innovations
//080FFA KSP INC.
//E8ABFA Shenzhen Reecam Tech.Ltd.
//DCB058 Bürkert Werke GmbH
//6C5A34 Shenzhen Haitianxiong Electronic Co., Ltd.
//9038DF Changzhou Tiannengbo System Co.Ltd.
//185253, "Pixord Corporation
//683B1E Countwise LTD
//ACA22C", "Baycity Technologies Ltd
//303294, "W-IE-NE-R Plein & Baus GmbH
//7C822D Nortec
//10FBF0 KangSheng LTD.
//6C9AC9 Valentine Research, Inc.
//AC8D14 Smartrove Inc
//2091D9, "I'M SPA
//AC7236 Lexking Technology Co., Ltd.
//3CD7DA SK Mtek microelectronics(shenzhen) limited
//04F8C2 Flaircomm Microelectronics, Inc.
//141BF0 Intellimedia Systems Ltd
//5887E2, "Shenzhen Coship Electronics Co., Ltd.
//6869F2, "ComAp s.r.o.
//B85AFE Handaer Communication Technology (Beijing) Co., Ltd
//F46DE2", "zte corporation
//F0ACA4 HBC-radiomatic
//60748D, "Atmaca Elektronik
//B8B7D7", "2GIG Technologies
//808287, "ATCOM Technology Co.Ltd.
//28A186 enblink
//503955, "Cisco SPVTG
//78D129, "Vicos
//84DF0C NET2GRID BV
//388EE7 Fanhattan LLC
//5CD41B UCZOON Technology Co., LTD
//CCE798", "My Social Stuff
//A036F0", "Comprehensive Power
//180CAC CANON INC.
//78AB60 ABB Australia
//8482F4, "Beijing Huasun Unicreate Technology Co., Ltd
//00DB1E Albedo Telecom SL
//18863A DIGITAL ART SYSTEM
//0CDCCC Inala Technologies
//98291D, "Jaguar de Mexico, SA de CV
//34AF2C Nintendo Co., Ltd.
//7CD9FE New Cosmos Electric Co., Ltd.
//E49069 Rockwell Automation
//CCC104", "Applied Technical Systems
//A4B1E9", "Technicolor
//60455E, "Liptel s.r.o.
//D806D1 Honeywell Fire System (Shanghai) Co,. Ltd.
//647657, "Innovative Security Designs
//907025, "Garea Microsys Co., Ltd.
//10D1DC INSTAR Deutschland GmbH
//34996F, "VPI Engineering
//944A09 BitWise Controls
//BC28D6", "Rowley Associates Limited
//10BD18 Cisco Systems, Inc
//5869F9, "Fusion Transactive Ltd.
//D41E35 TOHO Electronics INC.
//4C72B9 PEGATRON CORPORATION
//2CEDEB Alpheus Digital Company Limited
//0CD996 Cisco Systems, Inc
//30F33A", "+plugg srl
//0C57EB Mueller Systems
//745327, "COMMSEN CO., LIMITED
//D08CFF", "UPWIS AB
//68CE4E L-3 Communications Infrared Products
//68D1FD Shenzhen Trimax Technology Co., Ltd
//9C066E Hytera Communications Corporation Limited
//3CEAFB NSE AG
//8CC7AA Radinet Communications Inc.
//40336C Godrej & Boyce Mfg. co.ltd
//F8A03D", "Dinstar Technologies Co., Ltd.
//2CD444 FUJITSU LIMITED
//BC811F", "Ingate Systems
//D867D9 Cisco Systems, Inc
//A4E731", "Nokia Corporation
//98A7B0 MCST ZAO
//4C068A Basler Electric Company
//E856D6 NCTech Ltd
//C08170", "Effigis GeoSolutions
//642216, "Shandong Taixin Electronic co., Ltd
//443839, "Cumulus Networks, inc
//048B42 Skspruce Technologies
//5076A6 Ecil Informatica Ind. Com.Ltda
//A44C11", "Cisco Systems, Inc
//60843B Soladigm, Inc.
//AC4BC8 Juniper Networks
//209BA5 JIAXING GLEAD Electronics Co., Ltd
//A0F450", "HTC Corporation
//6089B1 Key Digital Systems
//44D15E, "Shanghai Kingto Information Technology Ltd
//0036FE SuperVision
//709E86, "X6D Limited
//A0F419 Nokia Corporation
//1C973D PRICOM Design
//BC0200", "Stewart Audio
//9C611D Omni-ID USA, Inc.
//489153, "Weinmann Geräte für Medizin GmbH + Co.KG
//AC9403", "Envision Peripherals Inc
//68D925, "ProSys Development Services
//848D84, "Rajant Corporation
//54466B Shenzhen CZTIC Electronic Technology Co., Ltd
//44B382 Kuang-chi Institute of Advanced Technology
//60B933 Deutron Electronics Corp.
//0043FF KETRON S.R.L.
//7CACB2 Bosch Software Innovations GmbH
//18D66A Inmarsat
//1C7C45 Vitek Industrial Video Products, Inc.
//3C3888 ConnectQuest, llc
//48D7FF BLANKOM Antennentechnik GmbH
//C47130 Fon Technology S.L.
//D8337F Office FA.com Co., Ltd.
//0036F8, "Conti Temic microelectronic GmbH
//A4F7D0 LAN Accessories Co., Ltd.
//C85645 Intermas France
//44348F, "MXT INDUSTRIAL LTDA
//D4EC0C", "Harley-Davidson Motor Company
//28E608, "Tokheim
//74FF7D Wren Sound Systems, LLC
//ACF0B2", "Becker Electronics Taiwan Ltd.
//542A9C LSY Defense, LLC.
//504A5E Masimo Corporation
//6CA96F TransPacket AS
//AC0142", "Uriel Technologies SIA
//C47BA3", "NAVIS Inc.
//F44848 Amscreen Group Ltd
//50D274, "Steffes Corporation
//C8F704 Building Block Video
//508A42 Uptmate Technology Co., LTD
//BCEA2B", "CityCom GmbH
//0CA138 Blinq Wireless Inc.
//5C6F4F S.A.SISTEL
//901B0E Fujitsu Technology Solutions GmbH
//F85063", "Verathon
//F0D14F", "LINEAR LLC
//2C36F8 Cisco Systems, Inc
//845787, "DVR C&C Co., Ltd.
//5808FA Fiber Optic & telecommunication INC.
//AC3D05 Instorescreen Aisa
//286094, "CAPELEC
//A45630", "Cisco Systems, Inc
//C43C3C", "CYBELEC SA
//B826D4 Furukawa Industrial S.A.Produtos Elétricos
//B87447 Convergence Technologies
//7463DF VTS GmbH
//BC125E", "Beijing WisVideo", "INC.
//14E4EC mLogic LLC
//3828EA Fujian Netcom Technology Co., LTD
//D01AA7", "UniPrint
//846AED Wireless Tsukamoto., co.LTD
//E05DA6", "Detlef Fink Elektronik & Softwareentwicklung
//045A95 Nokia Corporation
//04F4BC Xena Networks
//80DB31 Power Quotient International Co., Ltd.
//1C51B5 Techaya LTD
//6C3A84 Shenzhen Aero-Startech.Co.Ltd
//00D632, "GE Energy
//0C9E91 Sankosha Corporation
//383F10, "DBL Technology Ltd.
//ACD364 ABB SPA, ABB SACE DIV.
//2CEE26 Petroleum Geo-Services
//C8F9F9", "Cisco Systems, Inc
//A4EF52", "Telewave Co., Ltd.
//A826D9 HTC Corporation
//28940F, "Cisco Systems, Inc
//B8DAF7", "Advanced Photonics, Inc.
//143AEA Dynapower Company LLC
//A086EC SAEHAN HITEC Co., Ltd
//942E17, "Schneider Electric Canada Inc
//C46044 Everex Electronics Limited
//98FE03 Ericsson - North America
//E03C5B SHENZHEN JIAXINJIE ELECTRON CO., LTD
//CC944A", "Pfeiffer Vacuum GmbH
//0C8525 Cisco Systems, Inc
//B4D8A9", "BetterBots
//7CC8D7 Damalisk
//9CB008 Ubiquitous Computing Technology Corporation
//A8776F", "Zonoff
//648788, "Juniper Networks
//00FA3B CLOOS ELECTRONIC GMBH
//541DFB Freestyle Energy Ltd
//60B606 Phorus
//9092B4 Diehl BGT Defence GmbH & Co.KG
//20AA4B Cisco-Linksys, LLC
//CC6DEF", "TJK Tietolaite Oy
//A85BF3", "Audivo GmbH
//B8975A BIOSTAR Microtech Int'l Corp.
//4833DD ZENNIO AVANCE Y TECNOLOGIA, S.L.
//087572, "Obelux Oy
//10C2BA UTT Co., Ltd.
//90D74F, "Bookeen
//64C5AA South African Broadcasting Corporation
//98AAD7 BLUE WAVE NETWORKING CO LTD
//9C53CD ENGICAM s.r.l.
//608645, "Avery Weigh-Tronix, LLC
//FC8FC4", "Intelligent Technology Inc.
//10FC54 Shany Electronic Co., Ltd.
//C02973 Audyssey Laboratories Inc.
//78FE3D Juniper Networks
//2838CF Gen2wave
//24BC82 Dali Wireless, Inc.
//B40C25 Palo Alto Networks
//F8F7D3 International Communications Corporation
//28D1AF Nokia Corporation
//24C0B3 RSF
//FC455F JIANGXI SHANSHUI OPTOELECTRONIC TECHNOLOGY CO., LTD
//F04A2B", "PYRAMID Computer GmbH
//302DE8 JDA, LLC (JDA Systems)
//48A6D2 GJsun Optical Science and Tech Co., Ltd.
//500B32 Foxda Technology Industrial(ShenZhen) Co., LTD
//603553, "Buwon Technology
//E039D7 Plexxi, Inc.
//7C336E MEG Electronics Inc.
//D4E33F Nokia
//68CD0F U Tek Company Limited
//603FC5 COX CO., LTD
//A4E391", "DENY FONTAINE
//AC6FD9 Valueplus Inc.
//DC1EA3 Accensus LLC
//A40130", "ABIsystems Co., LTD
//90A783 JSW PACIFIC CORPORATION
//F8462D SYNTEC Incorporation
//78A5DD Shenzhen Smarteye Digital Electronics Co., Ltd
//ECE744", "Omntec mfg. inc
//28AF0A Sirius XM Radio Inc
//5CD4AB Zektor
//08FC52 OpenXS BV
//4C32D9 M Rutty Holdings Pty.Ltd.
//08A12B ShenZhen EZL Technology Co., Ltd
//A00CA1", "SKTB SKiT
//64E84F, "Serialway Communication Technology Co. Ltd
//2C9EFC CANON INC.
//182B05", "8D Technologies
//240BB1 KOSTAL Industrie Elektrik GmbH
//20EEC6 Elefirst Science & Tech Co ., ltd
//E01E07", "Anite Telecoms", "US.Inc
//7C6B33 Tenyu Tech Co. Ltd.
//147DC5 Murata Manufacturing Co., Ltd.
//00B9F6 Shenzhen Super Rich Electronics Co., Ltd
//FCC23D", "Atmel Corporation
//88E7A6 iKnowledge Integration Corp.
//A446FA AmTRAN Video Corporation
//CCE7DF American Magnetics, Inc.
//2804E0, "FERMAX ELECTRONICA S.A.U.
//644346, "GuangDong Quick Network Computer CO., LTD
//D4024A", "Delphian Systems LLC
//0041B4 Wuxi Zhongxing Optoelectronics Technology Co., Ltd.
//F44450 BND Co., Ltd.
//0462D7, "ALSTOM HYDRO FRANCE
//D4507A", "CEIVA Logic, Inc
//64D989, "Cisco Systems, Inc
//645DD7 Shenzhen Lifesense Medical Electronics Co., Ltd.
//EC4670 Meinberg Funkuhren GmbH & Co.KG
//D05A0F", "I-BT DIGITAL CO., LTD
//EC9681, "2276427 Ontario Inc
//5C076F Thought Creator
//3C0FC1 KBC Networks
//58E636, "EVRsafe Technologies
//10F9EE Nokia Corporation
//742B0F Infinidat Ltd.
//C8F981 Seneca s.r.l.
//24497B Innovative Converged Devices Inc
//98E79A Foxconn(NanJing) Communication Co., Ltd.
//A0E9DB Ningbo FreeWings Technologies Co., Ltd
//788973, "CMC
//14307A Avermetrics
//A06CEC RIM
//203706, "Cisco Systems, Inc
//F4B164", "Lightning Telecommunications Technology Co. Ltd
//70B035 Shenzhen Zowee Technology Co., Ltd
//8821E3, "Nebusens, S.L.
//90B97D Johnson Outdoors Marine Electronics d/b/a Minnkota
//7CF429 NUUO Inc.
//CCB55A Fraunhofer ITWM
//AC8ACD", "ROGER D.Wensker, G.Wensker sp.j.
//984246, "SOL INDUSTRY PTE., LTD
//3429EA MCD ELECTRONICS SP. Z O.O.
//8C82A8 Insigma Technology Co., Ltd
//60190C RRAMAC
//D05FCE Hitachi Data Systems
//F80332 Khomp
//28A574 Miller Electric Mfg. Co.
//1045BE Norphonic AS
//90B8D0 Joyent, Inc.
//AC4723 Genelec
//E8BA70 Cisco Systems, Inc
//D4A425", "SMAX Technology Co., Ltd.
//281471, "Lantis co., LTD.
//24470E, "PentronicAB
//D09B05", "Emtronix
//8C11CB ABUS Security-Center GmbH & Co.KG
//FC8329", "Trei technics
//14EB33 BSMediasoft Co., Ltd.
//F4B549 Xiamen Yeastar Information Technology Co., Ltd.
//88B168 Delta Control GmbH
//68876B INQ Mobile Limited
//1CAA07 Cisco Systems, Inc
//685B36 POWERTECH INDUSTRIAL CO., LTD.
//28EE2C Frontline Test Equipment
//782EEF Nokia Corporation
//7CF0BA Linkwell Telesystems Pvt Ltd
//AC8674", "Open Mesh, Inc.
//64D241, "Keith & Koep GmbH
//18B79E Invoxia
//8C4435 Shanghai BroadMobi Communication Technology Co., Ltd.
//F81D93 Longdhua(Beijing) Controls Technology Co., Ltd
//94D93C ENELPS
//B8BEBF Cisco Systems, Inc
//64B64A ViVOtech, Inc.
//38D135, "EasyIO Corporation Sdn.Bhd.
//CCF841 Lumewave
//30EB25 INTEK DIGITAL
//44E4D9, "Cisco Systems, Inc
//ACCA54", "Telldus Technologies AB
//901900, "SCS SA
//D45D42 Nokia Corporation
//B03829", "Siliconware Precision Industries Co., Ltd.
//7C6C39 PIXSYS SRL
//18B3BA Netlogic AB
//8C5FDF Beijing Railway Signal Factory
//D47B75", "HARTING Electronics GmbH
//D8DF0D", "beroNet GmbH
//ACF97E ELESYS INC.
//204005, "feno GmbH
//D46F42 WAXESS USA Inc
//300B9C Delta Mobile Systems, Inc.
//6CAD3F Hubbell Building Automation, Inc.
//B01B7C Ontrol A.S.
//04C5A4 Cisco Systems, Inc
//BC2846", "NextBIT Computing Pvt.Ltd.
//BC0F2B FORTUNE TECHGROUP CO., LTD
//648125, "Alphatron Marine BV
//8CF9C9 MESADA Technology Co., Ltd.
//C0626B Cisco Systems, Inc
//94E226, "D.ORtiz Consulting, LLC
//D8C99D", "EA DISPLAY LIMITED
//1083D2, "Microseven Systems, LLC
//34684A Teraworks Co., Ltd.
//CCFC6D RIZ TRANSMITTERS
//E03E7D", "data-complex GmbH
//0CC6AC DAGS
//042605, "GFR Gesellschaft für Regelungstechnik und Energieeinsparung mbH
//24F0FF GHT Co., Ltd.
//9CC0D2 Conductix-Wampfler GmbH
//CCF67A Ayecka Communication Systems LTD
//8065E9, "BenQ Corporation
//EC986C Lufft Mess- und Regeltechnik GmbH
//D093F8", "Stonestreet One LLC
//9C645E Harman Consumer Group
//1C334D ITS Telecom
//DCD87F", "Shenzhen JoinCyber Telecom Equipment Ltd
//B4E0CD", "Fusion-io, Inc
//286046, "Lantech Communications Global, Inc.
//10E2D5, "Qi Hardware Inc.
//60C980 Trymus
//A036FA Ettus Research LLC
//EC836C RM Tech Co., Ltd.
//303955, "Shenzhen Jinhengjia Electronic Co., Ltd.
//FC5B24 Weibel Scientific A/S
//78593E, "RAFI GmbH & Co.KG
//509772, "Westinghouse Digital
//503DE5 Cisco Systems, Inc
//540496, "Gigawave LTD
//EC4644 TTK SAS
//4CB9C8 CONET CO., LTD.
//8CB64F Cisco Systems, Inc
//204AAA Hanscan Spain S.A.
//20FECD System In Frontier Inc.
//F0933A NxtConect
//B8415F ASP AG
//2CB69D RED Digital Cinema
//582F42, "Universal Electric Corporation
//0474A1 Aligera Equipamentos Digitais Ltda
//5C6984 NUVICO
//70DDA1 Tellabs
//94D019, "Cydle Corp.
//8C278A Vocollect Inc
//CC0CDA", "Miljovakt AS
//E41C4B V2 TECHNOLOGY, INC.
//5CF3FC IBM Corp
//A86A6F", "RIM
//68122D, "Special Instrument Development Co., Ltd.
//94F720, "Tianjin Deviser Electronics Instrument Co., Ltd
//DC9C52", "Sapphire Technology Limited.
//4891F6, "Shenzhen Reach software technology CO., LTD
//649B24 V Technology Co., Ltd.
//846EB1 Park Assist LLC
//6C504D Cisco Systems, Inc
//B8D06F", "GUANGZHOU HKUST FOK YING TUNG RESEARCH INSTITUTE
//EC14F6", "BioControl AS
//E8995A PiiGAB, Processinformation i Goteborg AB
//401D59, "Biometric Associates, LP
//B8FF6F", "Shanghai Typrotech Technology Co.Ltd
//1CBD0E Amplified Engineering Pty Ltd
//A0F217", "GE Medical System(China) Co., Ltd.
//F0A764 GST Co., Ltd.
//1C0656 IDY Corporation
//500E6D, "TrafficCast International
//EC3BF0 NovelSat
//4CEDDE ASKEY COMPUTER CORP
//E8E08F GRAVOTECH MARKING SAS
//ACAB8D Lyngso Marine A/S
//6083B2 GkWare e.K.
//80D019, "Embed, Inc
//68EBC5 Angstrem Telecom
//A0B5DA", "HongKong THTF Co., Ltd
//8886A0 Simton Technologies, Ltd.
//A45055 BUSWARE.DE
//A89B10", "inMotion Ltd.
//B41489 Cisco Systems, Inc
//A4A80F", "Shenzhen Coship Electronics Co., Ltd.
//F8B599 Guangzhou CHNAVS Digital Technology Co., Ltd
//B8921D", "BG T&A
//D08999", "APCON, Inc.
//C88447 Beautiful Enterprise Co., Ltd
//54FDBF Scheidt & Bachmann GmbH
//D0BB80 SHL Telemedicine International Ltd.
//5C17D3 LGE
//1CDF0F Cisco Systems, Inc
//68BDAB Cisco Systems, Inc
//9CADEF Obihai Technology, Inc.
//C88B47 Nolangroup S.P.A con Socio Unico
//C4CD45 Beijing Boomsense Technology CO., LTD.
//8CE7B3 Sonardyne International Ltd
//088DC8 Ryowa Electronics Co., Ltd
//80C6CA Endian s.r.l.
//7076F0, "LevelOne Communications (India) Private Limited
//C02BFC", "iNES.applied informatics GmbH
//94C7AF Raylios Technology
//D81C14", "Compacta International, Ltd.
//008C10 Black Box Corp.
//90903C TRISON TECHNOLOGY CORPORATION
//E061B2 HANGZHOU ZENOINTEL TECHNOLOGY CO., LTD
//9411DA ITF Fröschl GmbH
//8039E5, "PATLITE CORPORATION
//DC7B94 Cisco Systems, Inc
//5CCA32 Theben AG
//7415E2, "Tri-Sen Systems Corporation
//ECC38A", "Accuenergy (CANADA) Inc
//D48FAA Sogecam Industrial, S.A.
//B081D8 I-sys Corp
//14FEAF SAGITTAR LIMITED
//B0B8D5", "Nanjing Nengrui Auto Equipment CO., Ltd
//94E711, "Xirka Dama Persada PT
//6C9B02 Nokia Corporation
//641E81, "Dowslake Microsystems
//EC542E Shanghai XiMei Electronic Technology Co. Ltd
//FCD4F6", "Messana Air.Ray Conditioning s.r.l.
//D466A8 Riedo Networks Ltd
//F0E5C3 Drägerwerk AG & Co.KG aA
//D82986 Best Wish Technology LTD
//446132, "ecobee inc
//F41F0B YAMABISHI Corporation
//A082C7", "P.T.I Co., LTD
//043604, "Gyeyoung I&T
//A4B2A7", "Adaxys Solutions AG
//D0D0FD", "Cisco Systems, Inc
//E05B70", "Innovid, Co., Ltd.
//141BBD Volex Inc.
//E87AF3 S5 Tech S.r.l.
//CC5C75 Weightech Com.Imp.Exp.Equip.Pesagem Ltda
//1C6F65 GIGA-BYTE TECHNOLOGY CO., LTD.
//90E0F0, "IEEE 1722a Working Group
//40520D, "Pico Technology
//807D1B Neosystem Co.Ltd.
//18B209 Torrey Pines Logic, Inc
//D84B2A", "Cognitas Technologies, Inc.
//684B88 Galtronics Telemetry Inc.
//98FC11 Cisco-Linksys, LLC
//34E0D7, "DONGGUAN QISHENG ELECTRONICS INDUSTRIAL CO., LTD
//D84606", "Silicon Valley Global Marketing
//F8AC6D Deltenna Ltd
//F450EB", "Telechips Inc
//988EDD TE Connectivity Limerick
//A4AE9A Maestro Wireless Solutions ltd.
//C848F5 MEDISON Xray Co., Ltd
//78A714 Amphenol
//F893F3 VOLANS
//7866AE ZTEC Instruments, Inc.
//4C022E CMR KOREA CO., LTD
//34AAEE Mikrovisatos Servisas UAB
//44D63D, "Talari Networks
//78A2A0 Nintendo Co., Ltd.
//48FCB8 Woodstream Corporation
//D4000D", "Phoenix Broadband Technologies, LLC.
//AC5135 MPI TECH
//74B9EB JinQianMao Technology Co., Ltd.
//D45297 nSTREAMS Technologies, Inc.
//1880CE Barberry Solutions Ltd
//24B6B8 FRIEM SPA
//A4561B", "MCOT Corporation
//80C63F Remec Broadband Wireless, LLC
//40D40E, "Biodata Ltd
//0C826A Wuhan Huagong Genuine Optics Technology Co., Ltd
//E0271A", "TTC Next-generation Home Network System WG
//0097FF Heimann Sensor GmbH
//E4AB46 UAB Selteka
//945B7E TRILOBIT LTDA.
//04E548, "Cohda Wireless Pty Ltd
//7071BC PEGATRON CORPORATION
//7884EE INDRA ESPACIO S.A.
//7C051E RAFAEL LTD.
//10090C Janome Sewing Machine Co., Ltd.
//E01CEE Bravo Tech, Inc.
//2893FE Cisco Systems, Inc
//F4C795", "WEY Elektronik AG
//781185, "NBS Payment Solutions Inc.
//D05875 Active Control Technology Inc.
//C8EF2E Beijing Gefei Tech. Co., Ltd
//08F6F8, "GET Engineering
//3C4C69 Infinity System S.L.
//7830E1, "UltraClenz, LLC
//B09134", "Taleo
//A4C2AB", "Hangzhou LEAD-IT Information & Technology Co., Ltd
//48AA5D Store Electronic Systems
//042F56, "ATOCS (Shenzhen) LTD
//E85E53 Infratec Datentechnik GmbH
//88BA7F Qfiednet Co., Ltd.
//64DB18 OpenPattern
//90A2DA GHEO SA
//9889ED, "Anadem Information Inc.
//D81BFE TWINLINX CORPORATION
//FC4463", "Universal Audio, Inc
//102D96, "Looxcie Inc.
//5C35DA There Corporation Oy
//A06986 Wellav Technologies Ltd
//EC8EAD DLX
//34C69A Enecsys Ltd
//D8AE90", "Itibia Technologies
//B8653B Bolymin, Inc.
//38E8DF b gmbh medien + datenbanken
//1C129D IEEE PES PSRC/SUB
//E0CA4D", "Shenzhen Unistar Communication Co., LTD
//0CC9C6 Samwin Hong Kong Limited
//1062C9 Adatis GmbH & Co.KG
//60B3C4 Elber Srl
//04C880 Samtec Inc
//F88DEF", "Tenebraex
//042234, "Wireless Standard Extensions
//F0B6EB", "Poslab Technology Co., Ltd.
//80C862 Openpeak, Inc
//1C8F8A Phase Motion Control SpA
//FCCCE4", "Ascon Ltd.
//5850E6, "Best Buy Corporation
//3C1CBE JADAK LLC
//BCD5B6", "d2d technologies
//FC683E Directed Perception, Inc
//28E794, "Microtime Computer Inc.
//0CD502 Westell Technologies Inc.
//70828E, "OleumTech Corporation
//A438FC Plastic Logic
//18FC9F Changhe Electronics Co., Ltd.
//94592D, "EKE Building Technology Systems Ltd
//CC69B0", "Global Traffic Technologies, LLC
//A0593A", "V.D.S.Video Display Systems srl
//CCEA1C DCONWORKS", "Co., Ltd
//7C08D9 Shanghai B-Star Technology Co
//2059A0 Paragon Technologies Inc.
//38E98C Reco S.p.A.
//A0BFA5 CORESYS
//B05B1F THERMO FISHER SCIENTIFIC S.P.A.
//24D2CC SmartDrive Systems Inc.
//0CEF7C AnaCom Inc
//ECE9F8", "Guang Zhou TRI-SUN Electronics Technology Co., Ltd
//34CE94 Parsec (Pty) Ltd
//34EF8B NTT Communications Corporation
//687F74, "Cisco-Linksys, LLC
//D0D286", "Beckman Coulter K.K.
//C4198B Dominion Voting Systems Corporation
//C83A35", "Tenda Technology Co., Ltd.
//6C8CDB Otus Technologies Ltd
//40F52E, "Leica Microsystems (Schweiz) AG
//E4FFDD ELECTRON INDIA
//68A1B7 Honghao Mingchuan Technology (Beijing) CO., Ltd.
//0CD7C2 Axium Technologies, Inc.
//E84ECE Nintendo Co., Ltd.
//1045F8, "LNT-Automation GmbH
//DCE71C AUG Elektronik GmbH
//A870A5 UniComm Inc.
//F8472D X2gen Digital Corp. Ltd
//849000, "Arnold & Richter Cine Technik
//08184C A. S.Thomas, Inc.
//10880F, "Daruma Telecomunicações e Informática S.A.
//FC6198 NEC Personal Products, Ltd
//74D850, "Evrisko Systems
//54B620 SUHDOL E&C Co.Ltd.
//78C40E H&D Wireless
//2C0623 Win Leader Inc.
//0C2755 Valuable Techologies Limited
//78998F, "MEDILINE ITALIA SRL
//40ECF8 Siemens AG
//BCB181", "SHARP CORPORATION
//C8873B Net Optics
//A8CE90", "CVC
//E41F13", "IBM Corp
//701AED ADVAS CO., LTD.
//6465C0 Nuvon, Inc
//7C1EB3", "2N TELEKOMUNIKACE a.s.
//4456B7 Spawn Labs, Inc
//44C9A2 Greenwald Industries
//906DC8 DLG Automação Industrial Ltda
//584CEE Digital One Technologies, Limited
//002721, "Shenzhen Baoan Fenda Industrial Co., Ltd
//A07332", "Cashmaster International Limited
//64C6AF AXERRA Networks Ltd
//44568D, "PNC Technologies", "Co., Ltd.
//406186, "MICRO-STAR INT'L CO.,LTD
//0026F5, "XRPLUS Inc.
//0026F8, "Golden Highway Industry Development Co., Ltd.
//0026F4, "Nesslab
//0026EE TKM GmbH
//0026EF, "Technology Advancement Group, Inc.
//0026B2 Setrix GmbH
//0026AF Duelco A/S
//0026B3 Thales Communications Inc
//0026A7 CONNECT SRL
//0026A4 Novus Produtos Eletronicos Ltda
//0026D8, "Magic Point Inc.
//0026D6, "Ningbo Andy Optoelectronic Co., Ltd.
//00270F, "Envisionnovation Inc
//00270A IEE S.A.
//002709, "Nintendo Co., Ltd.
//0026D3, "Zeno Information System
//0026D1, "S Squared Innovations Inc.
//0026CB Cisco Systems, Inc
//002701, "INCOstartec GmbH
//0026FB AirDio Wireless, Inc.
//00271A Geenovo Technology Ltd.
//002714, "Grainmustards, Co, ltd.
//002715, "Rebound Telecom. Co., Ltd
//0026E6, "Visionhitech Co., Ltd.
//0026DF TaiDoc Technology Corp.
//00266A ESSENSIUM NV
//00266B SHINE UNION ENTERPRISE LIMITED
//002667, "CARECOM CO., LTD.
//0026A2 Instrumentation Technology Systems
//00269F, "Private
//002699, "Cisco Systems, Inc
//002647, "WFE TECHNOLOGY CORP.
//002640, "Baustem Broadband Technologies, Ltd.
//002653, "DaySequerra Corporation
//00267B GSI Helmholtzzentrum für Schwerionenforschung GmbH
//002687, "corega K.K
//00268D, "CellTel S.p.A.
//002628, "companytec automação e controle ltda.
//00261F, "SAE Magnetics (H.K.) Ltd.
//00261E, "QINGBANG ELEC(SZ) CO., LTD
//002619, "FRC
//0025EA Iphion BV
//0025F0, "Suga Electronics Limited
//0025E8, "Idaho Technology
//0025E4, "OMNI-WiFi, LLC
//0025FC ENDA ENDUSTRIYEL ELEKTRONIK LTD.STI.
//0025FA J&M Analytik AG
//002633, "MIR - Medical International Research
//0025D7, "CEDO
//0025D8, "KOREA MAINTENANCE
//0025D2, "InpegVision Co., Ltd
//002630, "ACOREL S.A.S
//00262A Proxense, LLC
//0025FE Pilot Electronics Corporation
//00257B STJ", "ELECTRONICS PVT", "LTD
//00257C Huachentel Technology Development Co., Ltd
//002575, "FiberPlex Technologies, LLC
//002570, "Eastern Communications Company Limited
//00259B Beijing PKUNITY Microsystems Technology Co., Ltd
//002596, "GIGAVISION srl
//002595, "Northwest Signal Supply, Inc
//0025C9 SHENZHEN HUAPU DIGITAL CO., LTD
//00258F, "Trident Microsystems, Inc.
//002589, "Hills Industries Limited
//002585, "KOKUYO S&T Co., Ltd.
//002581, "x-star networks Inc.
//0025B5 Cisco Systems, Inc
//0025BE Tektrap Systems Inc.
//0025A0 Nintendo Co., Ltd.
//00254D, "Singapore Technologies Electronics Limited
//00254C Videon Central, Inc.
//002543, "MONEYTECH
//00255B CoachComm, LLC
//002516, "Integrated Design Tools, Inc.
//002510, "Pico-Tesla Magnetic Therapies
//00256A inIT - Institut Industrial IT
//002562, "interbro Co. Ltd.
//002520, "SMA Railway Technology GmbH
//002527, "Bitrode Corp.
//002525, "CTERA Networks Ltd.
//002551, "SE-Elektronic GmbH
//00253A CEVA, Ltd.
//0024A2 Hong Kong Middleware Technology Limited
//0024B9 Wuhan Higheasy Electronic Technology Development Co.Ltd
//0024BD Hainzl Industriesysteme GmbH
//0024B6 Seagate Technology
//0024F7, "Cisco Systems, Inc
//0024E5, "Seer Technology, Inc
//0024E2, "HASEGAWA ELECTRIC CO., LTD.
//0024E0, "DS Tech, LLC
//0024F3, "Nintendo Co., Ltd.
//002501, "JSC Supertel
//0024C8 Broadband Solutions Group
//0024C5 Meridian Audio Limited
//002496, "Ginzinger electronic systems
//002499, "Aquila Technologies
//00248A Kaga Electronics Co., Ltd.
//002435, "WIDE CORPORATION
//002431, "Uni-v co., ltd
//002432, "Neostar Technology Co., LTD
//002443, "Nortel Networks
//002441, "Wanzl Metallwarenfabrik GmbH
//00243B CSSI (S) Pte Ltd
//002451, "Cisco Systems, Inc
//00244A Voyant International
//002447, "Kaztek Systems
//002477, "Tibbo Technology
//00246E, "Phihong USA Corp.
//00245D, "Terberg besturingstechniek B.V.
//002450, "Cisco Systems, Inc
//002458, "PA Bastion CC
//002473, "3COM EUROPE LTD
//00246B Covia, Inc.
//0023F5, "WILO SE
//0023FF Beijing HTTC Technology Ltd.
//0023F6, "Softwell Technology Co., Ltd.
//0023F3, "Glocom, Inc.
//0023F0, "Shanghai Jinghan Weighing Apparatus Co.Ltd.
//002410, "NUETEQ Technology, Inc.
//002408, "Pacific Biosciences
//002430, "Ruby Tech Corp.
//00242E, "Datastrip Inc.
//00241D, "GIGA-BYTE TECHNOLOGY CO., LTD.
//00241A Red Beetle Inc.
//002414, "Cisco Systems, Inc
//00240C DELEC GmbH
//0023F9, "Double-Take Software, INC.
//0023E9, "F5 Networks, Inc.
//0023EA Cisco Systems, Inc
//0023E5, "IPaXiom Networks
//0023B6 SECURITE COMMUNICATIONS / HONEYWELL
//0023B8 Sichuan Jiuzhou Electronic Technology Co., Ltd
//0023BA Chroma
//0023BC EQ-SYS GmbH
//0023B1 Longcheer Technology (Singapore) Pte Ltd
//002396, "ANDES TECHNOLOGY CORPORATION
//002394, "Samjeon
//002377, "Isotek Electronics Ltd
//002371, "SOAM Systel
//0023A1 Trend Electronics Ltd
//0023A6 E-Mon
//0023A8 Marshall Electronics
//00239A EasyData Hardware GmbH
//0023CC Nintendo Co., Ltd.
//002379, "Union Business Machines Co. Ltd.
//00238C Private
//0023C0 Broadway Networks
//002358, "SYSTEL SA
//002356, "Packet Forensics LLC
//002350, "RDC, Inc.dba LynTec
//00234F, "Luminous Power Technologies Pvt. Ltd.
//00234B Inyuan Technology Inc.
//002349, "Helmholtz Centre Berlin for Material and Energy
//002346, "Vestac
//002307, "FUTURE INNOVATION TECH CO., LTD
//002305, "Cisco Systems, Inc
//0022FF NIVIS LLC
//002344, "Objective Interface Systems, Inc.
//00233C Alflex
//002333, "Cisco Systems, Inc
//00232E, "Kedah Electronics Engineering, LLC
//002320, "Nicira Networks
//002364, "Power Instruments Pte Ltd
//002317, "Lasercraft Inc
//00230E, "Gorba AG
//002362, "Goldline Controls
//00235E, "Cisco Systems, Inc
//002322, "KISS Teknical Solutions, Inc.
//0022B6 Superflow Technologies Group
//0022B5 NOVITA
//0022B2", "4RF Communications Ltd
//0022AC Hangzhou Siyuan Tech. Co., Ltd
//0022AD TELESIS TECHNOLOGIES, INC.
//0022AE Mattel Inc.
//0022D5, "Eaton Corp. Electrical Group Data Center Solutions - Pulizzi
//0022D1, "Albrecht Jung GmbH & Co.KG
//0022D2, "All Earth Comércio de Eletrônicos LTDA.
//0022C2 Proview Eletrônica do Brasil LTDA
//0022BD Cisco Systems, Inc
//0022BA HUTH Elektronik Systeme GmbH
//0022BB beyerdynamic GmbH & Co.KG
//0022A3 California Eastern Laboratories
//002302, "Cobalt Digital, Inc.
//0022F5, "Advanced Realtime Tracking GmbH
//0022CA Anviz Biometric Tech. Co., Ltd.
//0022C7 SEGGER Microcontroller GmbH & Co.KG
//0022C1 Active Storage Inc.
//00228F, "CNRS
//002297, "XMOS Semiconductor
//002292, "Cinetal
//0022E5, "Fisher-Rosemount Systems Inc.
//0022E4, "APASS TECHNOLOGY CO., LTD.
//00224F, "Byzoro Networks Ltd.
//002251, "Lumasense Technologies
//00225E, "Uwin Technologies Co., LTD
//002258, "Taiyo Yuden Co., Ltd.
//00225B Teradici Corporation
//002259, "Guangzhou New Postcom Equipment Co., Ltd.
//002253, "Entorian Technologies
//00222C Ceton Corp
//00222D, "SMC Networks Inc.
//00222A SoundEar A/S
//00227E, "Chengdu 30Kaitian Communication Industry Co.Ltd
//00227C Woori SMT Co., ltd
//002277, "NEC Australia Pty Ltd
//00223D, "JumpGen Systems, LLC
//002239, "Indiana Life Sciences Incorporated
//002235, "Strukton Systems bv
//002279, "Nippon Conlux Co., Ltd.
//002271, "Jäger Computergesteuerte Meßtechnik GmbH.
//002247, "DAC ENGINEERING CO., LTD.
//00221F, "eSang Technologies Co., Ltd.
//0021E6, "Starlight Video Limited
//0021E0, "CommAgility Ltd
//0021DE Firepro Wireless
//0021F9, "WIRECOM Technologies
//0021FA A4SP Technologies Ltd.
//0021F0, "EW3 Technologies LLC
//0021D3, "BOCOM SECURITY(ASIA PACIFIC) LIMITED
//0021CC Flextronics International
//0021B9 Universal Devices Inc.
//0021B3 Ross Controls
//0021B6 Triacta Power Technologies Inc.
//002217, "Neat Electronics
//002211, "Rohati Systems
//0021CF The Crypto Group
//0021C5", "3DSP Corp
//002212, "CAI Networks, Inc.
//00220D, "Cisco Systems, Inc
//002208, "Certicom Corp
//0021EE Full Spectrum Inc.
//0021EC Solutronic GmbH
//002205, "WeLink Solutions, Inc.
//002209, "Omron Healthcare Co., Ltd
//00218C TopControl GMBH
//00218A Electronic Design and Manufacturing Company
//00218B Wescon Technology, Inc.
//002184, "POWERSOFT SRL
//002178, "Matuschek Messtechnik GmbH
//002173, "Ion Torrent Systems, Inc.
//002177, "W.L.Gore & Associates
//002172, "Seoultek Valley
//002153, "SeaMicro Inc.
//00217A Sejin Electron, Inc.
//0021A4 Dbii Networks
//002199, "Vacon Plc
//0021A0 Cisco Systems, Inc
//002198, "Thai Radio Co, LTD
//0021AE ALCATEL-LUCENT FRANCE - WTD
//0021AF Radio Frequency Systems
//002154, "D-TACQ Solutions Ltd
//002169, "Prologix, LLC.
//00214B Shenzhen HAMP Science & Technology Co., Ltd
//002145, "Semptian Technologies Ltd.
//001FFE HPN Supply Chain
//001FFF Respironics, Inc.
//001FFC Riccius+Sohn GmbH
//001FFD Indigo Mobile Technologies Corp.
//002121, "VRmagic GmbH
//002123, "Aerosat Avionics
//00210A byd:sign Corporation
//002107, "Seowonintech Co Ltd.
//00213E, "TomTom
//00213F, "A-Team Technology Ltd.
//00211B Cisco Systems, Inc
//00212D, "SCIMOLEX CORPORATION
//001FD5 MICRORISC s.r.o.
//001FB1 Cybertech Inc.
//001FB2 Sontheim Industrie Elektronik GmbH
//001FEE ubisys technologies GmbH
//001FEF SHINSEI INDUSTRIES CO., LTD
//001FEC Synapse Électronique
//001FCA Cisco Systems, Inc
//001FC3 SmartSynch, Inc
//001FE0 EdgeVelocity Corp
//001FD8 A-TRUST COMPUTER CORPORATION
//001FD7 TELERAD SA
//001FD3 RIVA Networks Inc.
//001FC1 Hanlong Technology Co., LTD
//001FBB Xenatech Co., LTD
//001FE8 KURUSUGAWA Electronics Industry Inc,.
//001FAB I.S HIGH TECH.INC
//001FAC Goodmill Systems Ltd
//001F36, "Bellwin Information Co.Ltd.,
//001F3D, "Qbit GmbH
//001F38, "POSITRON
//001F2D, "Electro-Optical Imaging, Inc.
//001F89, "Signalion GmbH
//001F8A Ellion Digital Inc.
//001F7F, "Phabrix Limited
//001F76, "AirLogic Systems Inc.
//001F73, "Teraview Technology Co., Ltd.
//001F62, "JSC Stilsoft
//001F67, "Hitachi, Ltd.
//001F56, "DIGITAL FORECAST
//001F52, "UVT Unternehmensberatung fur Verkehr und Technik GmbH
//001F4F, "Thinkware Co. Ltd.
//001F2F, "Berker GmbH & Co.KG
//001F32, "Nintendo Co., Ltd.
//001F44, "GE Transportation Systems
//001F39, "Construcciones y Auxiliar de Ferrocarriles, S.A.
//001F7C Witelcom AS
//001F7A WiWide Inc.
//001F77, "HEOL DESIGN
//001F94, "Lascar Electronics Ltd
//001F8E, "Metris USA Inc.
//001F61, "Talent Communication Networks Inc.
//001ECE BISA Technologies (Hong Kong) Limited
//001EC8 Rapid Mobile (Pty) Ltd
//001ECC CDVI
//001EC5 Middle Atlantic Products Inc
//001F03, "NUM AG
//001EFF Mueller-Elektronik GmbH & Co.KG
//001F05, "iTAS Technology Corp.
//001F07, "AZTEQ Mobile
//001EF6, "Cisco Systems, Inc
//001EF9, "Pascom Kommunikations systeme GmbH.
//001EF3, "From2
//001F19, "BEN-RI ELECTRONICA S.A.
//001F11, "OPENMOKO, INC.
//001EE4 ACS Solutions France
//001EED Adventiq Ltd.
//001ED2, "Ray Shine Video Technology Inc
//001ED4, "Doble Engineering
//001EFD Microbit 2.0 AB
//001EE7 Epic Systems Inc
//001EE9 Stoneridge Electronics AB
//001F1C KOBISHI ELECTRIC Co., Ltd.
//001E79, "Cisco Systems, Inc
//001E76, "Thermo Fisher Scientific
//001E72, "PCS
//001E5F, "KwikByte, LLC
//001E5B Unitron Company, Inc.
//001E5E COmputime Ltd.
//001E9D, "Recall Technologies, Inc.
//001E95, "SIGMALINK
//001E93, "CiriTech Systems Inc
//001EA2 Symx Systems, Inc.
//001EA9 Nintendo Co., Ltd.
//001E9E ddm hopt + schuler Gmbh + Co.KG
//001EBE Cisco Systems, Inc
//001EC3 Kozio, Inc.
//001EBD Cisco Systems, Inc
//001EB9 Sing Fai Technology Limited
//001EB2 LG innotek
//001EB7 TBTech, Co., Ltd.
//001E69, "Thomson Inc.
//001E92, "JEULIN S.A.
//001E91, "KIMIN Electronic Co., Ltd.
//001E89, "CRFS Limited
//001E86, "MEL Co., Ltd.
//001E88, "ANDOR SYSTEM SUPPORT CO., LTD.
//001E0C Sherwood Information Partners, Inc.
//001E02, "Sougou Keikaku Kougyou Co., Ltd.
//001E01, "Renesas Technology Sales Co., Ltd.
//001DFF Network Critical Solutions Ltd
//001E00, "Shantou Institute of Ultrasonic Instruments
//001E54, "TOYO ELECTRIC Corporation
//001E3C Lyngbox Media AB
//001E4D, "Welkin Sciences, LLC
//001E4B City Theatrical
//001E4A Cisco Systems, Inc
//001E13, "Cisco Systems, Inc
//001E0D, "Micran Ltd.
//001E09, "ZEFATEK Co., LTD
//001E06, "WIBRAIN
//001E31, "INFOMARK CO., LTD.
//001E2C CyVerse Corporation
//001E26, "Digifriends Co. Ltd
//001E23, "Electronic Educational Devices, Inc
//001DF3 SBS Science & Technology Co., Ltd
//001DEE NEXTVISION SISTEMAS DIGITAIS DE TELEVISÃO LTDA.
//001DEA Commtest Instruments Ltd
//001DDD DAT H.K.LIMITED
//001DE4 Visioneered Image Systems
//001DE2 Radionor Communications
//001DD7 Algolith
//001DC9 GainSpan Corp.
//001D86, "Shinwa Industries(China) Ltd.
//001D88, "Clearwire
//001D81, "GUANGZHOU GATEWAY ELECTRONICS CO., LTD
//001D7D, "GIGA-BYTE TECHNOLOGY CO., LTD.
//001DC7 L-3 Communications Geneva Aerospace
//001D89, "VaultStor Corporation
//001D66, "Hyundai Telecom
//001D77, "NSGate
//001DA2 Cisco Systems, Inc
//001D99, "Cyan Optic, Inc.
//001D9B Hokuyo Automatic Co., Ltd.
//001DBC Nintendo Co., Ltd.
//001DB6 BestComm Networks, Inc.
//001DAC Gigamon Systems LLC
//001D15, "Shenzhen Dolphin Electronic Co., Ltd
//001D16, "SFR
//001D11, "Analogue & Micro Ltd
//001D12, "ROHM CO., LTD.
//001D47, "Covote GmbH & Co KG
//001D41, "Hardy Instruments
//001D3D, "Avidyne Corporation
//001D3C Muscle Corporation
//001D3A mh acoustics LLC
//001D49, "Innovation Wireless Inc.
//001D46, "Cisco Systems, Inc
//001D48, "Sensor-Technik Wiedemann GmbH
//001D76, "Eyeheight Ltd.
//001D7A Wideband Semiconductor, Inc.
//001D68, "Thomson Telecom Belgium
//001D26, "Rockridgesound Technology Co.
//001D35, "Viconics Electronics Inc.
//001D31, "HIGHPRO INTERNATIONAL R&D CO,.LTD.
//001D61, "BIJ Corporation
//001D5C Tom Communication Industrial Co., Ltd.
//001D56, "Kramer Electronics Ltd.
//001D4E, "TCM Mobile LLC
//001D21, "Alcad SL
//001D1C Gennet s.a.
//001CE1 INDRA SISTEMAS, S.A.
//001CE0 DASAN TPS
//001CD9 GlobalTop Technology Inc.
//001CDA Exegin Technologies Limited
//001CD2 King Champion (Hong Kong) Limited
//001CA6 Win4NET
//001CA9 Audiomatica Srl
//001CA1 AKAMAI TECHNOLOGIES, INC.
//001C99 Shunra Software Ltd.
//001CF9 Cisco Systems, Inc
//001CF1 SUPoX Technology Co. , LTD.
//001CCE By Techdesign
//001CF3 EVS BROADCAST EQUIPMENT
//001CF4 Media Technology Systems Inc
//001CE6 INNES
//001CB9 KWANG SUNG ELECTRONICS CO., LTD.
//001D03, "Design Solutions Inc.
//001CA3 Terra
//001C90 Empacket Corporation
//001C8E Alcatel-Lucent IPD
//001C8F Advanced Electronic Design, Inc.
//001C88 TRANSYSTEM INC.
//001C86 Cranite Systems, Inc.
//001C4F MACAB AB
//001C4E TASA International Limited
//001C4B Gener8, Inc.
//001C9B FEIG ELECTRONIC GmbH
//001C95 Opticomm Corporation
//001C97 Enzytek Technology Inc.,
//001C70 NOVACOMM LTDA
//001C6E Newbury Networks, Inc.
//001C6B COVAX", "Co.Ltd
//001C69 Packet Vision Ltd
//001C3D WaveStorm
//001C7F Check Point Software Technologies
//001C78 WYPLAY SAS
//001C58 Cisco Systems, Inc
//001C5A Advanced Relay Corporation
//001C65 JoeScan, Inc.
//001C5F Winland Electronics, Inc.
//001C40 VDG-Security bv
//001C3A Element Labs, Inc.
//001C18 Sicert S.r.L.
//001C1A Thomas Instrumentation, Inc
//001C0E Cisco Systems, Inc
//001C13 OPTSYS TECHNOLOGY CO., LTD.
//001C0B SmartAnt Telecom
//001BD0 IDENTEC SOLUTIONS
//001BCD DAVISCOMMS (S) PTE LTD
//001BCA Beijing Run Technology LTD.Company
//001BCC KINGTEK CCTV ALLIANCE CO., LTD.
//001BF4 KENWIN INDUSTRIAL(HK) LTD.
//001BF9 Intellitect Water Ltd
//001BFA G.i.N.mbH
//001BF3 TRANSRADIO SenderSysteme Berlin AG
//001C21 Nucsafe Inc.
//001C1E emtrion GmbH
//001BDE Renkus-Heinz, Inc.
//001BDB Valeo VECS
//001BD8 FLIR Systems Inc
//001BD4 Cisco Systems, Inc
//001C2D FlexRadio Systems
//001C2C Synapse
//001C08 Echo360, Inc.
//001BC8 MIURA CO., LTD
//001BC1 HOLUX Technology, Inc.
//001BBC Silver Peak Systems, Inc.
//001B73 DTL Broadcast Ltd
//001B71 Telular Corp.
//001B97 Violin Technologies
//001BA8 UBI&MOBI,.Inc
//001B81 DATAQ Instruments, Inc.
//001B7D CXR Anderson Jacobson
//001B79 FAIVELEY TRANSPORT
//001B65 China Gridcom Co., Ltd
//001B88 Divinet Access Technologies Ltd
//001B83 Finsoft Ltd
//001BAB Telchemy, Incorporated
//001BAE Micro Control Systems, Inc
//001BA0 Awox
//001B51 Vector Technology Corp.
//001B54 Cisco Systems, Inc
//001B4A W&W Communications, Inc.
//001AFA Welch Allyn, Inc.
//001AF7 dataschalt e+a GmbH
//001AF3 Samyoung Electronics
//001AEF Loopcomm Technology, Inc.
//001AEC Keumbee Electronics Co., Ltd.
//001B44 SanDisk Corporation
//001B46 Blueone Technology Co., Ltd
//001B40 Network Automation mxc AB
//001B42 Wise & Blue
//001B35 ChongQing JINOU Science & Technology Development CO., Ltd
//001B36 Tsubata Engineering Co., Ltd. (Head Office)
//001B39 Proxicast
//001B3B Yi-Qing CO., LTD
//001B20 TPine Technology
//001B22 Palit Microsystems (H.K.) Ltd.
//001B1C Coherent
//001B19 IEEE I&M Society TC9
//001B64 IsaacLandKorea Co., Ltd,
//001B26 RON-Telecom ZAO
//001B13 Icron Technologies Corporation
//001B0F Petratec
//001AA9 FUJIAN STAR-NET COMMUNICATION CO., LTD
//001AA8 Mamiya Digital Imaging Co., Ltd.
//001A99 Smarty (HZ) Information Electronics Co., Ltd
//001AA6 Telefunken Radio Communication Systems GmbH &CO.KG
//001A96 ECLER S.A.
//001A91 FusionDynamic Ltd.
//001A8C Sophos Ltd
//001AB3 VISIONITE INC.
//001ACA Tilera Corporation
//001A84 V One Multimedia Pte Ltd
//001AB9 PMC
//001ABA Caton Overseas Limited
//001AD1 FARGO CO., LTD.
//001A3A Dongahelecomm
//001A3B Doah Elecom Inc.
//001A3C Technowave Ltd.
//001A40 A-FOUR TECH CO., LTD.
//001A30 Cisco Systems, Inc
//001A7B Teleco, Inc.
//001A36 Aipermon GmbH & Co.KG
//001A26 Deltanode Solutions AB
//001A6D Cisco Systems, Inc
//001A6E Impro Technologies
//001A6C Cisco Systems, Inc
//001A4A Qumranet Inc.
//001A3E Faster Technology LLC
//001A63 Elster Solutions, LLC,
//001A59 Ircona
//001A46 Digital Multimedia Technology Co., Ltd
//001A25 DELTA DORE
//0019FE SHENZHEN SEECOMM TECHNOLOGY CO., LTD.
//0019FD Nintendo Co., Ltd.
//001A0D HandHeld entertainment, Inc.
//001A0E Cheng Uei Precision Industry Co., Ltd
//0019CD Chengdu ethercom information technology Ltd.
//0019D9, "Zeutschel GmbH
//001A01 Smiths Medical
//0019CA Broadata Communications, Inc
//0019D3, "TRAK Microwave
//0019C3 Qualitrol
//0019BE Altai Technologies Limited
//0019B4 Intellio Ltd
//0019BA Paradox Security Systems Ltd
//0019A1 LG INFORMATION & COMM.
//0019A8 WiQuest Communications
//0019ED, "Axesstel Inc.
//0019F6, "Acconet (PTE) Ltd
//001A15 gemalto e-Payment
//001968, "Digital Video Networks(Shanghai) CO. LTD.
//00197F, "PLANTRONICS, INC.
//00197A MAZeT GmbH
//001978, "Datum Systems, Inc.
//001989, "Sonitrol Corporation
//00198E, "Oticon A/S
//001980, "Gridpoint Systems
//001983, "CCT R&D Limited
//00194C Fujian Stelcom information & Technology CO., Ltd
//00194A TESTO AG
//00198A Northrop Grumman Systems Corp.
//001960, "DoCoMo Systems, Inc.
//00195A Jenaer Antriebstechnik GmbH
//00196D, "Raybit Systems Korea, Inc
//001970, "Z-Com, Inc.
//001950, "Harman Multimedia
//0018EE Videology Imaging Solutions, Inc.
//0018EB Blue Zen Enterprises Private Limited
//001924, "LBNL Engineering
//00191A IRLINK
//001916, "PayTec AG
//00190E, "Atech Technology Co., Ltd.
//001939, "Gigamips
//00193A OESOLUTIONS
//0018E2, "Topdata Sistemas de Automacao Ltda
//001922, "CM Comandos Lineares
//00191D, "Nintendo Co., Ltd.
//00192F, "Cisco Systems, Inc
//001905, "SCHRACK Seconet AG
//001907, "Cisco Systems, Inc
//0018FB Compro Technology
//0018C3 CS Corporation
//0018CA Viprinet GmbH
//0018C7 Real Time Automation
//0018BB Eliwell Controls srl
//0018BF Essence Technology Solution, Inc.
//00188C Mobile Action Technology Inc.
//00188F, "Montgomery Technology, Inc.
//001884, "Fon Technology S.L.
//001880, "Maxim Integrated Products
//0018D0, "AtRoad, A Trimble Company
//0018D2, "High-Gain Antennas LLC
//0018D3, "TEAMCAST
//0018C6 OPW Fuel Management Systems
//00187C INTERCROSS, LLC
//001870, "E28 Shanghai Limited
//001872, "Expertise Engineering
//0018DC Prostar Co., Ltd.
//0018D1, "Siemens Home & Office Comm. Devices
//0018AA Protec Fire Detection plc
//001896, "Great Well Electronic LTD
//001890, "RadioCOM, s.r.o.
//0018B9 Cisco Systems, Inc
//0018B8 New Voice International AG
//0018A1 Tiqit Computers, Inc.
//001812, "Beijing Xinwei Telecom Technology Co., Ltd.
//00180B Brilliant Telecommunications
//001861, "Ooma, Inc.
//00185B Network Chemistry, Inc
//001855, "Aeromaritime Systembau GmbH
//001851, "SWsoft
//001874, "Cisco Systems, Inc
//001869, "KINGJIM
//001856, "EyeFi, Inc
//00184E, "Lianhe Technologies, Inc.
//00184C Bogen Communications
//001826, "Cale Access AB
//00182D, "Artec Design
//00182A Taiwan Video & Monitor
//00183B CENITS Co., Ltd.
//00183C Encore Software Limited
//001841, "High Tech Computer Corp
//001819, "Cisco Systems, Inc
//00180C Optelian Access Networks
//001810, "IPTrade S.A.
//001809, "CRESYN
//001804, "E-TEK DIGITAL TECHNOLOGY LIMITED
//001800, "UNIGRAND LTD
//0017FD Amulet Hotkey
//0017FC Suprema Inc.
//0017FB FA
//0017D8, "Magnum Semiconductor, Inc.
//0017DA Spans Logic
//0017CF iMCA-GmbH
//0017B9 Gambro Lundia AB
//0017B3 Aftek Infosys Limited
//0017A2 Camrivox Ltd.
//00175F, "XENOLINK Communications Co., Ltd.
//00175C SHARP CORPORATION
//00179D, "Kelman Limited
//001790, "HYUNDAI DIGITECH Co, Ltd.
//001791, "LinTech GmbH
//001795, "Cisco Systems, Inc
//001759, "Cisco Systems, Inc
//001754, "Arkino HiTOP Corporation Limited
//001752, "DAGS, Inc
//001756, "Vinci Labs Oy
//001777, "Obsidian Research Corporation
//00176A Avago Technologies
//001786, "wisembed
//001782, "LoBenn Inc.
//001778, "Central Music Co.
//00176B Kiyon, Inc.
//001799, "SmarTire Systems Inc.
//00177F, "Worldsmart Retech
//00176E, "DUCATI SISTEMI
//001774, "Elesta GmbH
//00170C Twig Com Ltd.
//00170D, "Dust Networks Inc.
//00170B Contela, Inc.
//00170F, "Cisco Systems, Inc
//001704, "Shinco Electronics Group Co., Ltd
//001707, "InGrid, Inc
//001712, "ISCO International
//0016D8, "Senea AB
//0016D6, "TDA Tech Pty Ltd
//0016D5, "Synccom Co., Ltd
//0016C9 NAT Seattle, Inc.
//0016C6 North Atlantic Industries
//001724, "Studer Professional Audio GmbH
//001702, "Osung Midicom Co., Ltd
//0016F7, "L-3 Communications, Aviation Recorders
//00172D, "Axcen Photonics Corporation
//001741, "DEFIDEV
//001738, "International Business Machines
//00171E, "Theo Benning GmbH & Co.KG
//0016D2, "Caspian
//0016A4 Ezurio Ltd
//001699, "Tonic DVB Marketing Ltd
//00169B Alstom Transport
//001690, "J-TEK INCORPORATION
//001693, "PowerLink Technology Inc.
//001698, "T&A Mobile Phones
//001662, "Liyuh Technology Ltd.
//001661, "Novatium Solutions (P) Ltd
//001664, "Prod-El SpA
//00165E, "Precision I/O
//001658, "Fusiontech Technologies Inc.
//0016A5 Tandberg Storage ASA
//0016A1", "3Leaf Networks
//001666, "Quantier Communication Inc.
//001681, "Vector Informatik GmbH
//00BAC0 Biometric Access Company
//001685, "Elisa Oyj
//001680, "Bally Gaming + Systems
//001696, "QDI Technology (H.K.) Limited
//0016BE INFRANET, Inc.
//0016AB Dansensor A/S
//001653, "LEGO System A/S IE Electronics Division
//001652, "Hoatech Technologies, Inc.
//001650, "Kratos EPD
//0015FA Cisco Systems, Inc
//0015FC Littelfuse Startco
//0015F7, "Wintecronics Ltd.
//001630, "Vativ Technologies
//00162F, "Geutebrück GmbH
//00162B Togami Electric Mfg.co., Ltd.
//001642, "Pangolin
//00163B VertexRSI/General Dynamics
//001637, "CITEL SpA
//001608, "Sequans Communications
//001624, "Teneros, Inc.
//0015F8, "Kingtronics Industrial Co.Ltd.
//00161C e:cue
//0015B8 Tahoe
//0015B6 ShinMaywa Industries, Ltd.
//0015B0 AUTOTELENET CO., LTD
//0015B1 Ambient Corporation
//00159F, "Terascala, Inc.
//00159E, "Mad Catz Interactive Inc
//0015A1 ECA-SINTERS
//001593, "U4EA Technologies Inc.
//001581, "MAKUS Inc.
//00157A Telefin S.p.A.
//0015C3 Ruf Telematik AG
//0015E6, "MOBILE TECHNIKA Inc.
//0015DB Canesta Inc.
//00158D, "Jennic Ltd
//001584, "Schenck Process GmbH
//0015CC UQUEST, LTD.
//0015C6 Cisco Systems, Inc
//0015D7, "Reti Corporation
//0015CB Surf Communication Solutions Ltd.
//0015A7 Robatech AG
//001523, "Meteor Communications Corporation
//001524, "Numatics, Inc.
//00151B Isilon Systems Inc.
//001573, "NewSoft Technology Corporation
//001575, "Nevis Networks Inc.
//00156C SANE SYSTEM CO., LTD
//00156A DG2L Technologies Pvt. Ltd.
//001529, "N3 Corporation
//00152D, "TenX Networks, LLC
//00156F, "Xiranet Communications GmbH
//001572, "Red-Lemon
//001567, "RADWIN Inc.
//00155B Sampo Corporation
//001553, "Cytyc Corporation
//001551, "RadioPulse Inc.
//001552, "Wi-Gear Inc.
//00153E, "Q-Matic Sweden AB
//001542, "MICROHARD S.R.L.
//00154E, "IEC
//001550, "Nits Technology Inc
//001546, "ITG Worldwide Sdn Bhd
//00155D, "Microsoft Corporation
//001562, "Cisco Systems, Inc
//0014E1, "Data Display AG
//0014E3, "mm-lab GmbH
//0014D9, "IP Fabrics, Inc.
//0014D6, "Jeongmin Electronics Co., Ltd.
//0014F9, "Vantage Controls
//0014E7, "Stolinx,. Inc
//0014E9, "Nortech International
//0014ED, "Airak, Inc.
//0014CE NF CORPORATION
//0014D0, "BTI Systems Inc.
//001503, "PROFIcomms s.r.o.
//001509, "Plus Technology Co., Ltd
//0014F0, "Business Security OL AB
//0014F2, "Cisco Systems, Inc
//001510, "Techsphere Co., Ltd
//001513, "EFS sas
//00148B Globo Electronic GmbH & Co.KG
//001490, "ASP Corporation
//001484, "Cermate Technologies Inc.
//001479, "NEC Magnus Communications, Ltd.
//00147B Iteris, Inc.
//0014BB Open Interface North America
//001470, "Prokom Software SA
//001467, "ArrowSpan Inc.
//00145F, "ADITEC CO. LTD
//001488, "Akorri
//00147A Eubus GmbH
//00146D, "RF Technologies
//0014AC Bountiful WiFi
//0014A8 Cisco Systems, Inc
//0014A0 Accsense, Inc.
//001459, "Moram Co., Ltd.
//001457, "T-VIPS AS
//001453, "ADVANTECH TECHNOLOGIES CO., LTD
//001454, "Symwave
//0013F8, "Dex Security Solutions
//0013F9, "Cavera Systems
//0013F2, "Klas Ltd
//0013F7, "SMC Networks, Inc.
//00144B Hifn, Inc.
//001441, "Innovation Sound Technology Co., LTD.
//00143C Rheinmetall Canada Inc.
//00141A DEICY CORPORATION
//00141C Cisco Systems, Inc
//00140C GKB CCTV CO., LTD.
//0013FE GRANDTEC ELECTRONIC CORP.
//001435, "CityCom Corp.
//001448, "Inventec Multimedia & Telecom Corporation
//001416, "Scosche Industries, Inc.
//001426, "NL Technology
//0013C5 LIGHTRON FIBER-OPTIC DEVICES INC.
//0013C4 Cisco Systems, Inc
//0013C2 WACOM Co., Ltd
//0013BF Media System Planning Corp.
//0013BB Smartvue Corporation
//0013B5 Wavesat
//0013AF NUMA Technology, Inc.
//0013B0 Jablotron
//00139A K-ubique ID Corp.
//00139E, "Ciara Technologies Inc.
//00139D, "MaxLinear Hispania S.L.U.
//0013D5, "RuggedCom
//0013D6, "TII NETWORK TECHNOLOGIES, INC.
//0013DB SHOEI Electric Co., Ltd
//0013CD MTI co.LTD
//0013D3, "MICRO-STAR INTERNATIONAL CO., LTD.
//0013CA Pico Digital
//0013E6, "Technolution
//0013DF Ryvor Corp.
//00138D, "Kinghold
//0013ED, "PSIA
//0013B1 Intelligent Control Systems (Asia) Pte Ltd
//00133C QUINTRON SYSTEMS INC.
//00133D, "Micro Memory Curtiss Wright Co
//00133F, "Eppendorf Instrumente GmbH
//001341, "Shandong New Beiyang Information Technology Co., Ltd
//001330, "EURO PROTECTION SURVEILLANCE
//001325, "Cortina Systems Inc
//001331, "CellPoint Connect
//001335, "VS Industry Berhad
//00132F, "Interactek
//00134C YDT Technology International
//001359, "ProTelevision Technologies A/S
//001350, "Silver Spring Networks, Inc
//00137F, "Cisco Systems, Inc
//001382, "Cetacea Networks Corporation
//001390, "Termtek Computer Co., Ltd
//001375, "American Security Products Co.
//001358, "Realm Systems, Inc.
//0012C1 Check Point Software Technologies
//0012BB Telecommunications Industry Association TR-41 Committee
//0012B6 Santa Barbara Infrared, Inc.
//0012B9 Fusion Digital Technology
//0012B4 Work Microwave GmbH
//0012ED, "AVG Advanced Technologies
//0012EA Trane
//0012E7, "Projectek Networking Electronics Corp.
//0012C3 WIT S.A.
//0012C8 Perfect tech
//0012C6 TGC America, Inc
//0012CC Bitatek CO., LTD
//0012FA THX LTD
//001306, "Always On Wireless
//0012FD OPTIMUS IC S.A.
//001305, "Epicom, Inc.
//0012E4, "ZIEHL industrie-electronik GmbH + Co KG
//001297, "O2Micro, Inc.
//00129D, "First International Computer do Brasil
//00129C Yulinet
//001290, "KYOWA Electric & Machinery Corp.
//001291, "KWS Computersysteme GmbH
//001295, "Aiware Inc.
//00128B Sensory Networks Inc
//00128F, "Montilio
//0012A3 Trust International B.V.
//0012A7 ISR TECHNOLOGIES Inc
//0012AA IEE, Inc.
//00129F, "RAE Systems
//0012B5 Vialta, Inc.
//0012B1 Dai Nippon Printing Co., Ltd
//001289, "Advance Sterilization Products
//001284, "Lab33 Srl
//001281, "March Networks S.p.A.
//00127E, "Digital Lifestyles Group, Inc.
//00126B Ascalade Communications Limited
//001233, "JRC TOKKI Co., Ltd.
//00125B KAIMEI ELECTRONI
//001259, "THERMO ELECTRON KARLSRUHE
//00125A Microsoft Corporation
//00123D, "GES Co, Ltd
//001239, "S Net Systems Inc.
//00122F, "Sanei Electric Inc.
//001230, "Picaso Infocommunication CO., LTD.
//001246, "T.O.M TECHNOLOGY INC..
//001256, "LG INFORMATION & COMM.
//001214, "Koenig & Bauer AG
//00120F, "IEEE 802.3
//00121D, "Netfabric Corporation
//00120C CE-Infosys Pte Ltd
//0011B3 YOSHIMIYA CO., LTD.
//0011B6 Open Systems International
//0011B0 Fortelink Inc.
//0011AC Simtec Electronics
//0011AD Shanghai Ruijie Technology
//0011CD Axsun Technologies
//0011C5 TEN Technology
//0011BE AGP Telecom Co. Ltd
//0011BA Elexol Pty Ltd
//0011BC Cisco Systems, Inc
//0011A8 Quest Technologies
//0011A1 VISION NETWARE CO., LTD
//0011E2, "Hua Jung Components Co., Ltd.
//0011DA Vivaas Technology Inc.
//0011DD FROMUS TEC.Co., Ltd.
//0011EB Innovative Integration
//0011EA IWICS Inc.
//0011E4, "Danelec Electronics A/S
//0011E1, "Arcelik A.S
//0011FB Heidelberg Engineering GmbH
//0011D6, "HandEra, Inc.
//0011CA Long Range Systems, Inc.
//0011EF, "Conitec Datensysteme GmbH
//00114F, "US Digital Television, Inc
//001182, "IMI Norgren Ltd
//00117A Singim International Corp.
//001148, "Prolon Control Systems
//001140, "Nanometrics Inc.
//001144, "Assurance Technology Corp
//001168, "HomeLogic LLC
//001163, "SYSTEM SPA DEPT.ELECTRONICS
//00118F, "EUTECH INSTRUMENTS PTE.LTD.
//00118D, "Hanchang System Corp.
//00115F, "ITX Security Co., Ltd.
//001153, "Trident Tek, Inc.
//001172, "COTRON CORPORATION
//0011A0 Vtech Engineering Canada Ltd
//00119B Telesynergy Research Inc.
//001191, "CTS-Clima Temperatur Systeme GmbH
//001189, "Aerotech Inc
//000FFB Nippon Denso Industry Co., Ltd.
//000FF2 Loud Technologies Inc.
//000FF1 nex-G Systems Pte.Ltd
//001101, "CET Technologies Pte Ltd
//000FFF Control4
//000FFC Merit Li-Lin Ent.
//001113, "Fraunhofer FOKUS
//001112, "Honeywell CMSS
//000FE0 NComputing Co., Ltd.
//000FE3 Damm Cellular Systems A/S
//001128, "Streamit
//00113F, "Alcatel DI
//001137, "AICHI ELECTRIC CO., LTD.
//000FF3 Jung Myoung Communications&Technology
//00113A SHINBORAM
//000F89, "Winnertec System Co., Ltd.
//000FA4 Sprecher Automation GmbH
//000FA6 S2 Security Corporation
//000FAA Nexus Technologies
//000FA8 Photometrics, Inc.
//000FBD MRV Communications (Networks) LTD
//000FB4 Timespace Technology
//000F9D, "DisplayLink (UK) Ltd
//000FC5 KeyMed Ltd
//000FBF DGT Sp.z o.o.
//000F92, "Microhard Systems Inc.
//000FCB", "3Com Ltd
//000FD5 Schwechat - RISE
//000F67, "West Instruments
//000F6E, "BBox
//000F6F, "FTA Communication Technologies
//000F63, "Obzerv Technologies
//000F21, "Scientific Atlanta, Inc
//000F11, "Prodrive B.V.
//000F13, "Nisca corporation
//000F14, "Mindray Co., Ltd.
//000F65, "icube Corp.
//000F5D, "Genexis BV
//000F58, "Adder Technology Limited
//000F12, "Panasonic Europe Ltd.
//000F0E, "WaveSplitter Technologies, Inc.
//000F0C SYNCHRONIC ENGINEERING
//000F0B, "Kentima Technologies AB
//000F46, "SINAR AG
//000F41, "Zipher Ltd
//000F4D, "TalkSwitch
//000F71, "Sanmei Electronics Co., Ltd
//000F6B GateWare Communications GmbH
//000ED5, "COPAN Systems Inc.
//000ECA WTSS Inc
//000ECC Tableau, LLC
//000ECB VineSys Technology
//000ED2, "Filtronic plc
//000EC8 Zoran Corporation
//000ED9, "Aksys, Ltd.
//000EB4 GUANGZHOU GAOKE COMMUNICATIONS TECHNOLOGY CO.LTD.
//000EB1 Newcotech, Ltd
//000EA9 Shanghai Xun Shi Communications Equipment Ltd.Co.
//000EB6 Riverbed Technology, Inc.
//000EB7 Knovative, Inc.
//000EFA Optoway Technology Incorporation
//000EFD FUJINON CORPORATION
//000EF5, "iPAC Technology Co., Ltd.
//000EFB Macey Enterprises
//000F09, "Private
//000EDC Tellion INC.
//000ECD SKOV A/S
//000EDB XiNCOM Corp.
//000EDD SHURE INCORPORATED
//000EC2 Lowrance Electronics, Inc.
//000EA3 CNCR-IT CO., LTD, HangZhou P.R.CHINA
//000EA2 McAfee, Inc
//000E9B Ambit Microsystems Corporation
//000E78, "Amtelco
//000E71, "Gemstar Technology Development Ltd.
//000E70, "in2 Networks
//000E37, "Harms & Wende GmbH & Co.KG
//000E31, "Olympus Soft Imaging Solutions GmbH
//000E2F, "Roche Diagnostics GmbH
//000E2A Private
//000E9E Topfield Co., Ltd
//000E41, "NIHON MECHATRONICS CO., LTD.
//000E3C Transact Technologies Inc
//000E63, "Lemke Diagnostics GmbH
//000E5B ParkerVision - Direct2Data
//000E60, "360SUN Digital Broadband Corporation
//000E54, "AlphaCell Wireless Ltd.
//000E4E Waveplus Technology Co., Ltd.
//000E4A Changchun Huayu WEBPAD Co., LTD
//000E93, "Milénio 3 Sistemas Electrónicos, Lda.
//000E8D, "Systems in Progress Holding GmbH
//000E76, "GEMSOC INNOVISION INC.
//000E7D, "Electronics Line 3000 Ltd.
//000E2C Netcodec co.
//000E23, "Incipient, Inc.
//000E25, "Hannae Technology Co., Ltd
//000E20, "ACCESS Systems Americas, Inc.
//000E21, "MTU Friedrichshafen GmbH
//000DD4 Symantec Corporation
//000DD2 Simrad Optronics ASA
//000DD1 Stryker Corporation
//000DD7 Bright
//000DD9 Anton Paar GmbH
//000DDC VAC
//000DE0 ICPDAS Co., LTD
//000DE3 AT Sweden AB
//000DEA Kingtel Telecommunication Corp.
//000DED Cisco Systems, Inc
//000DE4 DIGINICS, Inc.
//000E09, "Shenzhen Coship Software Co., LTD.
//000E05, "WIRELESS MATRIX CORP.
//000E22, "Private
//000E1C Hach Company
//000E02, "Advantech AMT Inc.
//000DC9 THALES Elektronik Systeme GmbH
//000D81, "Pepperl+Fuchs GmbH
//000D7A DiGATTO Asia Pacific Pte Ltd
//000D77, "FalconStor Software
//000D76, "Hokuto Denshi Co,. Ltd.
//000D7B Consensys Computers Inc.
//000D8F, "King Tsushin Kogyo Co., LTD.
//000D89, "Bils Technology Inc
//000D86, "Huber + Suhner AG
//000DC8 AirMagnet, Inc
//000DBE Bel Fuse Europe Ltd., UK
//000DBC Cisco Systems, Inc
//000D9F, "RF Micro Devices
//000DA5 Fabric7 Systems, Inc
//000DC5 EchoStar Global B.V.
//000D99, "Orbital Sciences Corp.; Launch Systems Group
//000D6C M-Audio
//000D70, "Datamax Corporation
//000D59, "Amity Systems, Inc.
//000D4E, "NDR Co., LTD.
//000D50, "Galazar Networks
//000D17, "Turbo Networks Co.Ltd
//000D18, "Mega-Trend Electronics CO., LTD.
//000D20, "ASAHIKASEI TECHNOSYSTEM CO., LTD.
//000D49, "Triton Systems of Delaware, Inc.
//000D48, "AEWIN Technologies Co., Ltd.
//000D24, "SENTEC E&E CO., LTD.
//000D22, "Unitronics LTD
//000D14, "Vtech Innovation LP dba Advanced American Telephones
//000D5B Smart Empire Investments Limited
//000D3A Microsoft Corp.
//000D30, "IceFyre Semiconductor
//000D31, "Compellent Technologies, Inc.
//000D2C Net2Edge Limited
//000D25, "SANDEN CORPORATION
//000D6F, "Ember Corporation
//000D5E, "NEC Personal Products
//000D3F, "VTI Instruments Corporation
//000CE3 Option International N.V.
//000CE7 MediaTek Inc.
//000CE8 GuangZhou AnJuBao Co., Ltd
//000CE4 NeuroCom International, Inc.
//000CB5 Premier Technolgies, Inc
//000CB6 NANJING SEU MOBILE & INTERNET TECHNOLOGY CO., LTD
//000CC3 BeWAN systems
//000CB4 AutoCell Laboratories, Inc.
//000CB1 Salland Engineering (Europe) BV
//000CBC Iscutum
//000D04, "Foxboro Eckardt Development GmbH
//000D08, "AboveCable, Inc.
//000D05, "cybernet manufacturing inc.
//000CFE Grand Electronic Co., Ltd
//000D0E, "Inqnet Systems, Inc.
//000D11, "DENTSPLY - Gendex
//000CC8 Xytronix Research & Design, Inc.
//000CCA HGST a Western Digital Company
//000CD0 Symetrix
//000CD9 Itcare Co., Ltd
//000CD5 Passave Inc.
//000CD2 Schaffner EMV AG
//000A07 WebWayOne Ltd
//000CB0 Star Semiconductor Corporation
//000C34 Vixen Co., Ltd.
//000C58 M&S Systems
//000C51 Scientific Technologies Inc.
//000C73 TELSON ELECTRONICS CO., LTD
//000C65 Sunin Telecom
//000C6C Eve Systems GmbH
//000C6F Amtek system co., LTD.
//000C7E Tellium Incorporated
//000C87 AMD
//000C98 LETEK Communications Inc.
//000C8E Mentor Engineering Inc
//000CA2 Harmonic Video Network
//000CA4 Prompttec Product Management GmbH
//000C5B HANWANG TECHNOLOGY CO., LTD
//000C60 ACM Systems
//000C83 Logical Solutions
//000C96 OQO, Inc.
//000C08 HUMEX Technologies Corp.
//000C0D Communications & Power Industries / Satcom Division
//000C04 Tecnova
//000C01 Abatron AG
//000C39 Sentinel Wireless Inc.
//000C32 Avionic Design Development GmbH
//000C33 Compucase Enterprise Co. Ltd.
//000C36 SHARP TAKAYA ELECTRONICS INDUSTRY CO., LTD.
//000BF6 Nitgen Co., Ltd
//000BFD Cisco Systems, Inc
//000BFA EXEMYS SRL
//000BF4 Private
//000BFB D-NET International Corporation
//000C1D Mettler & Fuchs AG
//000C1E Global Cache
//000C1A Quest Technical Solutions Inc.
//000C24 ANATOR
//000C19 Telio Communications GmbH
//000C13 MediaQ
//000C06 Nixvue Systems Pte Ltd
//000C2D FullWave Technology Co., Ltd.
//000C26 Weintek Labs.Inc.
//000C2B ELIAS Technology, Inc.
//000BF0 MoTEX Products Co., Ltd.
//000BF1 LAP Laser Applikations
//000BEE inc.jet, Incorporated
//000B8D Avvio Networks
//000B85 Cisco Systems, Inc
//000B7F Align Engineering LLC
//000BA6 Miyakawa Electric Works Ltd.
//000B93 Ritter Elektronik
//000B9B Sirius System Co, Ltd.
//000BE2 Lumenera Corporation
//000BE1 Nokia NET Product Operations
//000BA8 HANBACK ELECTRONICS CO., LTD.
//000BA9 CloudShield Technologies, Inc.
//000BA1 Fujikura Solutions Ltd.
//000B8E Ascent Corporation
//000B8F AKITA ELECTRONICS SYSTEMS CO., LTD.
//000BCB Fagor Automation , S.Coop
//000BC8 AirFlow Networks
//000BCE Free2move AB
//000BCF AGFA NDT INC.
//000BC3 Multiplex, Inc.
//000BBE Cisco Systems, Inc
//000BE0 SercoNet Ltd.
//000BBD Connexionz Limited
//000B40 Cambridge Industries Group (CIG)
//000B44 Concord IDea Corp.
//000B42 commax Co., Ltd.
//000B47 Advanced Energy
//000B81 Kaparel Corporation
//000B82 Grandstream Networks, Inc.
//000B6E Neff Instrument Corp.
//000B72 Lawo AG
//000B31 Yantai ZhiYang Scientific and technology industry CO., LTD
//000B2F bplan GmbH
//000B3D CONTAL OK Ltd.
//000B4E VertexRSI, General Dynamics SatCOM Technologies, Inc.
//000B4D Emuzed
//000B24 AirLogic
//000B78 TAIFATECH INC.
//000B6C Sychip Inc.
//0091D6, "Crystal Group, Inc.
//000B5A HyperEdge
//000B0F Bosch Rexroth
//000B0C Agile Systems Inc.
//000B0A dBm Optics
//000B09 Ifoundry Systems Singapore
//000B1D LayerZero Power Systems, Inc.
//000B19 Vernier Networks, Inc.
//000B16 Communication Machinery Corporation
//000B12 NURI Telecom Co., Ltd.
//000AC5 Color Kinetics
//000ABD Rupprecht & Patashnick Co.
//000ACB XPAK MSA Group
//000AD5 Brainchild Electronic Co., Ltd.
//000AD6 BeamReach Networks
//000AFE NovaPal Ltd
//000AFD Kentec Electronics
//000AEF OTRUM ASA
//000AE5 ScottCare Corporation
//000AB0 LOYTEC electronics GmbH
//000AB5 Digital Electronic Network
//000AD2 JEPICO Corporation
//000A98 M+F Gwinner GmbH & Co
//000A9B TB Group Inc
//000A6C Walchem Corporation
//000A5F almedio inc.
//000A6B Tadiran Telecom Business Systems LTD
//000A61 Cellinx Systems Inc.
//000A78 OLITEC
//000AA9 Brooks Automation GmbH
//000AA5 MAXLINK INDUSTRIES LIMITED
//000AA2 SYSTEK INC.
//000A5B Power-One as
//000A55 MARKEM Corporation
//000A73 Scientific Atlanta
//000A69 SUNNY bell Technology Co., Ltd.
//000A84 Rainsun Enterprise Co., Ltd.
//000A7E The Advantage Group
//000A4C Molecular Devices Corporation
//000A4D Noritz Corporation
//000A91 HemoCue AB
//0009F2, "Cohu, Inc., Electronics Division
//0009E9, "Cisco Systems, Inc
//0009DC Galaxis Technology AG
//000A3A J-THREE INTERNATIONAL Holding Co., Ltd.
//000A47 Allied Vision Technologies
//000A3C Enerpoint Ltd.
//000A44 Avery Dennison Deutschland GmbH
//0009F8, "UNIMO TECHNOLOGY CO., LTD.
//0009FF X.net 2000 GmbH
//000A03 ENDESA SERVICIOS, S.L.
//0009FE Daisy Technologies, Inc.
//000A28 Motorola
//000A29 Pan Dacom Networking AG
//0009EB HuMANDATA LTD.
//0009E8, "Cisco Systems, Inc
//0009ED, "CipherOptics
//000A40 Crown Audio -- Harmanm International
//000A26 CEIA S.p.A.
//000A1D Optical Communications Products Inc.
//000A16 Lassen Research
//000A18 Vichel Inc.
//000A06 Teledex LLC
//000A0D FCI Deutschland GmbH
//0009A9 Ikanos Communications
//00099F, "VIDEX INC.
//0009A2 Interface Co., Ltd.
//0009A1 Telewise Communications, Inc.
//00097D, "SecWell Networks Oy
//000976, "Datasoft ISDN Systems GmbH
//0009C6 Visionics Corporation
//0009D1, "SERANOA NETWORKS INC
//0009CE SpaceBridge Semiconductor Corp.
//0009B8 Entise Systems
//0009AF e-generis
//0009AD HYUNDAI SYSCOMM, INC.
//0009BD Epygi Technologies, Ltd.
//0009C2 Onity, Inc.
//0009C3 NETAS
//0009B5", "3J Tech. Co., Ltd.
//000982, "Loewe Opta GmbH
//000983, "GlobalTop Technology, Inc.
//0009DD Mavin Technology Inc.
//00097A Louis Design Labs.
//00096B IBM Corp
//00096D, "Powernet Technologies Corp.
//000964, "Hi-Techniques, Inc.
//000965, "HyunJu Computer Co., Ltd.
//000939, "ShibaSoku Co., Ltd.
//000933, "Ophit Co.Ltd.
//000932, "Omnilux
//00091C CacheVision, Inc
//00091A Macat Optics & Electronics Co., Ltd.
//00091B Digital Generation Inc.
//000929, "Sanyo Industries (UK) Limited
//000928, "Telecore
//00092E, "B&Tech System Inc.
//00096F, "Beijing Zhongqing Elegant Tech. Corp., Limited
//00095E, "Masstech Group Inc.
//00094F, "elmegt GmbH & Co.KG
//000943, "Cisco Systems, Inc
//000902, "Redline Communications Inc.
//0008FA KEB Automation KG
//000959, "Sitecsoft
//000957, "Supercaller, Inc.
//0008D2, "ZOOM Networks Inc.
//0008C5 Liontech Co., Ltd.
//0008AC Eltromat GmbH
//0008AA KARAM
//0008AB EnerLinx.com, Inc.
//0008AD Toyo-Linx Co., Ltd.
//0008F2, "C&S Technology
//0008EA Motion Control Engineering, Inc
//0008ED, "ST&T Instrument Corp.
//000888, "OULLIM Information Technology Inc,.
//000885, "EMS Dr. Thomas Wünsche
//000872, "Sorenson Communications
//00089A Alcatel Microelectronics
//0008A1 CNet Technology Inc.
//000893, "LE INFORMATION COMMUNICATION INC.
//0008B0 BKtel communications GmbH
//0008CA TwinHan Technology Co., Ltd
//0008B6 RouteFree, Inc.
//0008D8, "Dowkey Microwave
//0008DF Alistel Inc.
//0008DB Corrigent Systems
//00087C Cisco Systems, Inc
//000879, "CEM Corporation
//00087D, "Cisco Systems, Inc
//000875, "Acorp Electronics Corp.
//000816, "Bluelon ApS
//000811, "VOIX Corporation
//000806, "Raonet Systems, Inc.
//00086F, "Resources Computer Network Ltd.
//000867, "Uptime Devices
//0007F8, "ITDevices, Inc.
//0007F3, "Thinkengine Networks
//00081C @pos.com
//00081E, "Repeatit AB
//000856, "Gamatronic Electronic Industries Ltd.
//000853, "Schleicher GmbH & Co.Relaiswerke KG
//000826, "Colorado Med Tech
//00085E, "PCO AG
//00079A Verint Systems Inc
//000774, "GuangZhou Thinker Technology Co. Ltd.
//000798, "Selea SRL
//000791, "International Data Communications, Inc.
//0007EE telco Informationssysteme GmbH
//0007E2, "Bitworks, Inc.
//0007E6, "edgeflow Canada Inc.
//0007E5, "Coup Corporation
//0007DE eCopilt AB
//0007C8 Brain21, Inc.
//0007C5 Gcom, Inc.
//0007C1 Overture Networks, Inc.
//0007A7 A-Z Inc.
//0007A6 Leviton Manufacturing Co., Inc.
//0007A3 Ositis Software, Inc.
//0007C2 Netsys Telecom
//00078F, "Emkay Innovative Products
//000782, "Oracle Corporation
//0007AE Britestream Networks, Inc.
//0007B1 Equator Technologies
//0005F9, "TOA Corporation
//0007CA Creatix Polymedia Ges Fur Kommunikaitonssysteme
//0007DF Vbrick Systems Inc.
//000744, "Unico, Inc.
//000749, "CENiX Inc.
//00073D, "Nanjing Postel Telecommunications Co., Ltd.
//000739, "Scotty Group Austria Gmbh
//00074E, "IPFRONT Inc
//000752, "Rhythm Watch Co., Ltd.
//00074F, "Cisco Systems, Inc
//000743, "Chelsio Communications
//000747, "Mecalc
//000779, "Sungil Telecom Co., Ltd.
//00077E, "Elrest GmbH
//000778, "GERSTEL GmbH & Co.KG
//00076D, "Flexlight Networks
//000730, "Hutchison OPTEL Telecom Technology Co., Ltd.
//000722, "The Nielsen Company
//000760, "TOMIS Information & Telecom Corp.
//000735, "Flarion Technologies, Inc.
//00075E, "Ametek Power Instruments
//00071F, "European Systems Integration
//000721, "Formac Elektronik GmbH
//000786, "Wireless Networks Inc.
//0006BC Macrolink, Inc.
//0006C2 Smartmatic Corporation
//000654, "Winpresa Building Automation Technologies GmbH
//0006B4 Vorne Industries, Inc.
//0006AE Himachal Futuristic Communications Ltd
//0006E5, "Fujian Newland Computer Ltd. Co.
//0006DE Flash Technology
//0006DF AIDONIC Corporation
//0006DD AT & T Laboratories - Cambridge Ltd
//0006F0, "Digeo, Inc.
//000700, "Zettamedia Korea
//0006C5 INNOVI Technologies Limited
//0006C6 lesswire AG
//0006B7 TELEM GmbH
//0006EF, "Maxxan Systems, Inc.
//0006E9, "Intime Corp.
//0006EA ELZET80 Mikrocomputer GmbH&Co.KG
//000708, "Bitrage Inc.
//000712, "JAL Information Technology
//000713, "IP One, Inc.
//000707, "Interalia Inc.
//0006F2, "Platys Communications
//0006FA IP SQUARE Co, Ltd.
//000703, "CSEE Transport
//000706, "Sanritz Corporation
//0006D1, "Tahoe Networks, Inc.
//0006D4, "Interactive Objects, Inc.
//0006CA American Computer & Digital Components, Inc. (ACDC)
//0006CE DATENO
//00068E, "HID Corporation
//00068A NeuronNet Co.Ltd.R&D Center
//000685, "NetNearU Corporation
//000650, "Tiburon Networks, Inc.
//00065E, "Photuris, Inc.
//00067F, "Digeo, Inc.
//000683, "Bravara Communications, Inc.
//000655, "Yipee, Inc.
//000676, "Novra Technologies Inc.
//000664, "Fostex Corporation
//00067A JMP Systems
//000673, "TKH Security Solutions USA
//00069B AVT Audio Video Technologies GmbH
//000693, "Flexus Computer Technology, Inc.
//00065D, "Heidelberg Web Systems
//0006B0 Comtech EF Data Corp.
//000696, "Advent Networks
//0005D7, "Vista Imaging, Inc.
//0005DB PSI Nentec GmbH
//0005DD Cisco Systems, Inc
//000628, "Cisco Systems, Inc
//00061D, "MIP Telecom, Inc.
//000619, "Connection Technology Systems
//000640, "White Rock Networks
//000644, "NextGen Business Solutions, Inc
//000645, "Meisei Electric Co.Ltd.
//A06A00 Verilink Corporation
//0005F8, "Real Time Access, Inc.
//0005EB Blue Ridge Networks, Inc.
//0005E8, "TurboWave, Inc.
//0005F6, "Young Chang Co.Ltd.
//0005FC Schenck Pegasus Corp.
//00063A Dura Micro, Inc.
//000632, "Mesco Engineering GmbH
//000634, "GTE Airfone Inc.
//00060C Melco Industries, Inc.
//00060E, "IGYS Systems, Inc.
//000614, "Prism Holdings
//000608, "At-Sky SAS
//0005C3 Pacific Instruments, Inc.
//0005B9 Airvana, Inc.
//0005BC Resource Data Management Ltd
//0005BE Kongsberg Seatex AS
//0005BD ROAX BV
//0005C1 A-Kyung Motion, Inc.
//0005B4 Aceex Corporation
//000598, "CRONOS S.r.l.
//0005B7 Arbor Technology Corp.
//00059B Cisco Systems, Inc
//00057E, "Eckelmann Steuerungstechnik GmbH
//000580, "FibroLAN Ltd.
//000582, "ClearCube Technology
//0005D9, "Techno Valley, Inc.
//0005DC Cisco Systems, Inc
//0005D0, "Solinet Systems
//00059F, "Yotta Networks, Inc.
//000587, "Locus, Incorporated
//000590, "Swissvoice Ltd.
//000595, "Alesis Corporation
//000578, "Private
//000572, "Deonet Co., Ltd.
//000576, "NSM Technology Ltd.
//00056A Heuft Systemtechnik GmbH
//000568, "Piltofish Networks AB
//0005B6 INSYS Microelectronics GmbH
//000555, "Japan Cash Machine Co., Ltd.
//000552, "Xycotec Computer GmbH
//00054A Ario Data Networks, Inc.
//000548, "Disco Corporation
//0004F7, "Omega Band, Inc.
//0004EE Lincoln Electric Company
//0004F0, "International Computers, Ltd
//000527, "SJ Tek Co.Ltd
//000529, "Shanghai Broadan Communication Technology Co., Ltd
//00052C Supreme Magic Corporation
//00053E, "KID Systeme GmbH
//00053F, "VisionTek, Inc.
//00053D, "Agere Systems
//000500, "Cisco Systems, Inc
//000519, "Siemens Building Technologies AG,
//00050D, "Midstream Technologies, Inc.
//000534, "Northstar Engineering Ltd.
//000535, "Chip PC Ltd.
//000507, "Fine Appliance Corp.
//0004FD Japan Control Engineering Co., Ltd.
//000562, "Digital View Limited
//0004E5, "Glonet Systems, Inc.
//0004D2, "Adcon Telemetry GmbH
//0004D3, "Toyokeiki Co., Ltd.
//0004AA Jetstream Communications
//0004A0 Verity Instruments, Inc.
//00049E, "Wirelink Co., Ltd.
//00049A Cisco Systems, Inc
//000479, "Radius Co., Ltd.
//0004B0 ELESIGN Co., Ltd.
//0004AB Mavenir Inc.
//0004A7 FabiaTech Corporation
//000498, "Mahi Networks
//000497, "MacroSystem Digital Video AG
//0004D5, "Hitachi Information & Communication Engineering, Ltd.
//0004CA FreeMs Corp.
//000488, "Eurotherm Controls
//000485, "PicoLight
//0004DA Relax Technology, Inc.
//0004C5 ASE Technologies, USA
//000436, "ELANsat Technologies, Inc.
//000432, "Voyetra Turtle Beach, Inc.
//000435, "InfiNet LLC
//000437, "Powin Information Technology, Inc.
//00040C Kanno Works, Ltd.
//000408, "Sanko Electronics Co., Ltd.
//000407, "Topcon Positioning Systems, Inc.
//000409, "Cratos Networks
//000455, "ANTARA.net
//000457, "Universal Access Technology, Inc.
//00044D, "Cisco Systems, Inc
//000454, "Quadriga UK
//000448, "Polaroid Corporation
//000447, "Acrowave Systems Co., Ltd.
//00043E, "Telencomm
//00046D, "Cisco Systems, Inc
//000466, "ARMITEL Co.
//0003E2, "Comspace Corporation
//0003FF Microsoft Corporation
//000414, "Umezawa Musen Denki Co., Ltd.
//000428, "Cisco Systems, Inc
//000386, "Ho Net, Inc.
//00037D, "Stellcom
//000383, "Metera Networks, Inc.
//0003CC Momentum Computer, Inc.
//0003D7, "NextNet Wireless, Inc.
//0003D3, "Internet Energy Systems, Inc.
//0003CD Clovertech, Inc.
//00038B PLUS-ONE I&T, Inc.
//00038C Total Impact
//0003EE MKNet Corporation
//0003EA Mega System Technologies, Inc.
//0003E6, "Entone, Inc.
//0003A9 AXCENT Media AG
//00039F, "Cisco Systems, Inc
//000390, "Digital Video Communications, Inc.
//0003B5 Entra Technology Co.
//000364, "Scenix Semiconductor, Inc.
//00035E, "Metropolitan Area Networks, Inc.
//00035C Saint Song Corp.
//00035D, "Bosung Hi-Net Co., Ltd.
//000379, "Proscend Communications, Inc.
//00036F, "Telsey SPA
//000372, "ULAN
//000334, "Newport Electronics
//00033A Silicon Wave, Inc.
//000332, "Cisco Systems, Inc
//00030E, "Core Communications Co., Ltd.
//000312, "TRsystems GmbH
//000341, "Axon Digital Design
//008037, "Ericsson Group
//00033D, "ILSHin Lab
//000366, "ASM Pacific Technology
//000362, "Vodtel Communications, Inc.
//00034D, "Chiaro Networks, Ltd.
//000322, "IDIS Co., Ltd.
//00031D, "Taiwan Commate Computer, Inc.
//000326, "Iwasaki Information Systems Co., Ltd.
//000290, "Woorigisool, Inc.
//000292, "Logic Innovations, Inc.
//000286, "Occam Networks
//0002D2, "Workstation AG
//0002CD TeleDream, Inc.
//0002D0, "Comdial Corporation
//0002CC M.C.C.I
//0002B0 Hokubu Communication & Industrial Co., Ltd.
//0002AA PLcom Co., Ltd.
//0002B5 Avnet, Inc.
//0002B4 DAPHNE
//0002AC", "3PAR data
//0002D9, "Reliable Controls
//0002EF, "CCC Network Systems Group Ltd.
//0002E8, "E.D.&A.
//0002F2, "eDevice, Inc.
//00029D, "Merix Corp.
//0002C5 Evertz Microsystems Ltd.
//00024A Cisco Systems, Inc
//000249, "Aviv Infocom Co, Ltd.
//000245, "Lampus Co, Ltd.
//000232, "Avision, Inc.
//000235, "Paragon Networks International
//000237, "Cosmo Research Corp.
//000228, "Necsom, Ltd.
//000246, "All-Win Tech Co., Ltd.
//00023A ZSK Stickmaschinen GmbH
//00027F, "ask-technologies.com
//00027E, "Cisco Systems, Inc
//001095, "Thomson Inc.
//00025D, "Calix Networks
//00027B Amplify Net, Inc.
//000273, "Coriolis Networks
//000257, "Microcom Corp.
//000253, "Televideo, Inc.
//00026F, "Senao International Co., Ltd.
//000230, "Intersoft Electronics
//00021C Network Elements, Inc.
//00020C Metro-Optix
//000216, "Cisco Systems, Inc
//000214, "DTVRO
//00020F, "AATR
//0001C3 Acromag, Inc.
//0001C2 ARK Research Corp.
//0001EA Cirilium Corp.
//0001E0, "Fast Systems, Inc.
//0001AC Sitara Networks, Inc.
//0001ED, "SETA Corp.
//0001F6, "Association of Musical Electronics Industry
//0001CB EVR
//0001D6, "manroland AG
//0001AD Coach Master International", "d.b.a.CMI Worldwide, Inc.
//000188, "LXCO Technologies ag
//00019B Kyoto Microcomputer Co., Ltd.
//00017F, "Experience Music Project
//00015A Digital Video Broadcasting
//00012A Telematica Sistems Inteligente
//000166, "TC GROUP A/S
//000176, "Orient Silver Enterprises
//000158, "Electro Industries/Gauge Tech
//00012D, "Komodo Technology
//000148, "X-traWeb Inc.
//000187, "I2SE GmbH
//000180, "AOpen, Inc.
//000197, "Cisco Systems, Inc
//00019A LEUNIG GmbH
//000159, "S1 Corporation
//000171, "Allied Data Technologies
//0030AC Systeme Lauer GmbH & Co., Ltd.
//0030FB AZS Technology AG
//0030AE Times N System, Inc.
//003003, "Phasys Ltd.
//0030E2, "GARNET SYSTEMS CO., LTD.
//00013A SHELCAD COMMUNICATIONS, LTD.
//000140, "Sendtek Corporation
//000123, "Schneider Electric Japan Holdings Ltd.
//000125, "YAESU MUSEN CO., LTD.
//000126, "PAC Labs
//00011B Unizone Technologies, Inc.
//00011D, "Centillium Communications
//00011F, "RC Networks, Inc.
//00B080 Mannesmann Ipulsys B.V.
//00B01E Rantic Labs, Inc.
//00B0F0 CALY NETWORKS
//00B09A Morrow Technologies Corp.
//00302E, "Hoft & Wessel AG
//0030ED, "Expert Magnetics Corp.
//00300F, "IMT - Information Management T
//003082, "TAIHAN ELECTRIC WIRE CO., LTD.
//0030A9 Netiverse, Inc.
//0030FE DSA GmbH
//0030C4 Canon Imaging Systems Inc.
//00304D, "ESI
//081443, "UNIBRAIN S.A.
//00B009 Grass Valley, A Belden Brand
//00B0AC SIAE-Microelettronica S.p.A.
//003023, "COGENT COMPUTER SYSTEMS, INC.
//003090, "CYRA TECHNOLOGIES, INC.
//0030A7 SCHWEITZER ENGINEERING
//00307C ADID SA
//003055, "Renesas Technology America, Inc.
//00302F, "GE Aviation System
//00300E, "Klotz Digital AG
//0030D5, "DResearch GmbH
//003018, "Jetway Information Co., Ltd.
//00309F, "AMBER NETWORKS
//0030A8 OL'E COMMUNICATIONS, INC.
//0030D1, "INOVA CORPORATION
//0030BB CacheFlow, Inc.
//0030AF Honeywell GmbH
//0030AA AXUS MICROSYSTEMS, INC.
//003089, "Spectrapoint Wireless, LLC
//00309A ASTRO TERRA CORP.
//003087, "VEGA GRIESHABER KG
//003062, "IP Video Networks Inc
//00302D, "QUANTUM BRIDGE COMMUNICATIONS
//0030CB OMNI FLOW COMPUTERS, INC.
//00306B CMOS SYSTEMS, INC.
//0030AD SHANGHAI COMMUNICATION
//0030CF TWO TECHNOLOGIES, INC.
//0030B2 L-3 Sonoma EO
//003035, "Corning Incorporated
//00307F, "IRLAN LTD.
//00D015, "UNIVEX MICROTECHNOLOGY CORP.
//00D048, "ECTON, INC.
//00D0A5 AMERICAN ARIUM
//00305D, "DIGITRA SYSTEMS, INC.
//003036, "RMP ELEKTRONIKSYSTEME GMBH
//00D0CF MORETON BAY
//00D07F, "STRATEGY & TECHNOLOGY, LIMITED
//0030E6, "Draeger Medical Systems, Inc.
//0030BD BELKIN COMPONENTS
//003007, "OPTI, INC.
//00D0C2 BALTHAZAR TECHNOLOGY AB
//00D022, "INCREDIBLE TECHNOLOGIES, INC.
//00D071, "ECHELON CORP.
//00D04F, "BITRONICS, INC.
//00D069, "TECHNOLOGIC SYSTEMS
//00D090, "Cisco Systems, Inc
//00D0F5, "ORANGE MICRO, INC.
//00D0E9, "Advantage Century Telecommunication Corp.
//00D094, "Seeion Control LLC
//00D0FB TEK MICROSYSTEMS, INCORPORATED
//00D066, "WINTRISS ENGINEERING CORP.
//00D082, "IOWAVE INC.
//00D081, "RTD Embedded Technologies, Inc.
//00D002, "DITECH CORPORATION
//00D085, "OTIS ELEVATOR COMPANY
//00D011, "PRISM VIDEO, INC.
//00D0DF KUZUMI ELECTRONICS, INC.
//00D09B SPECTEL LTD.
//00D067, "CAMPIO COMMUNICATIONS
//00D058, "Cisco Systems, Inc
//00D032, "YANO ELECTRIC CO., LTD.
//00D0F1, "SEGA ENTERPRISES, LTD.
//00D03A ZONEWORX, INC.
//00D001, "VST TECHNOLOGIES, INC.
//00503E, "Cisco Systems, Inc
//005020, "MEDIASTAR CO., LTD.
//00D075, "ALARIS MEDICAL SYSTEMS, INC.
//00D04C EUROTEL TELECOM LTD.
//00D0E1, "AVIONITEK ISRAEL INC.
//00D008, "MACTELL CORPORATION
//00D0D9, "DEDICATED MICROCOMPUTERS
//00D00B RHK TECHNOLOGY, INC.
//00D09C KAPADIA COMMUNICATIONS
//00D0F3, "SOLARI DI UDINE SPA
//00D039, "UTILICOM, INC.
//00D0A0 MIPS DENMARK
//00D00A LANACCESS TELECOM S.A.
//00D01C SBS TECHNOLOGIES,
//00D0D5, "GRUNDIG AG
//00D041, "AMIGO TECHNOLOGY CO., LTD.
//00D09D, "VERIS INDUSTRIES
//00D06D, "ACRISON, INC.
//00D02B JETCELL, INC.
//00D062, "DIGIGRAM
//00D08D, "PHOENIX GROUP, INC.
//00D03D, "GALILEO TECHNOLOGY, LTD.
//0050C6 LOOP TELECOMMUNICATION INTERNATIONAL, INC.
//00509F, "HORIZON COMPUTER
//0050A5 CAPITOL BUSINESS SYSTEMS, LTD.
//005000, "NEXO COMMUNICATIONS, INC.
//005090, "DCTRI
//00503B MEDIAFIRE CORPORATION
//005046, "MENICX INTERNATIONAL CO., LTD.
//005041, "Coretronic Corporation
//0050B0 TECHNOLOGY ATLANTA CORPORATION
//0050DD SERRA SOLDADURA, S.A.
//005063, "OY COMSEL SYSTEM AB
//00508D, "ABIT COMPUTER CORPORATION
//0050A0 DELTA COMPUTER SYSTEMS, INC.
//005066, "AtecoM GmbH advanced telecomunication modules
//005059, "iBAHN
//0050D9, "ENGETRON-ENGENHARIA ELETRONICA IND.e COM. LTDA
//005001, "YAMASHITA SYSTEMS CORP.
//005067, "AEROCOMM, INC.
//0050B6 GOOD WAY IND. CO., LTD.
//00504B BARCONET N.V.
//0050EA XEL COMMUNICATIONS, INC.
//0050C8 Addonics Technologies, Inc.
//0050C4 IMD
//005089, "SAFETY MANAGEMENT SYSTEMS
//0050F4, "SIGMATEK GMBH & CO.KG
//005021, "EIS INTERNATIONAL, INC.
//00505E, "DIGITEK MICROLOGIC S.A.
//0050E8, "NOMADIX INC.
//0050AE FDK Co., Ltd
//0050E7, "PARADISE INNOVATIONS (ASIA)
//0050FB VSK ELECTRONICS
//009073, "GAIO TECHNOLOGY
//00907B E-TECH, INC.
//009081, "ALOHA NETWORKS, INC.
//00901C mps Software Gmbh
//005086, "TELKOM SA, LTD.
//00501A IQinVision
//00508F, "ASITA TECHNOLOGIES INT'L LTD.
//005015, "BRIGHT STAR ENGINEERING
//005057, "BROADBAND ACCESS SYSTEMS
//005088, "AMANO CORPORATION
//005031, "AEROFLEX LABORATORIES, INC.
//0090DB NEXT LEVEL COMMUNICATIONS
//009056, "TELESTREAM, INC.
//009068, "DVT CORP.
//00905E, "RAULAND-BORG CORPORATION
//0090AF J. MORITA MFG. CORP.
//005003, "Xrite Inc
//0050D3, "DIGITAL AUDIO PROCESSING PTY. LTD.
//0050AD CommUnique Wireless Corp.
//0050AF INTERGON, INC.
//009034, "IMAGIC, INC.
//0090AA INDIGO ACTIVE VISION SYSTEMS LIMITED
//00905B RAYMOND AND LAE ENGINEERING
//0090BC TELEMANN CO., LTD.
//00900A PROTON ELECTRONIC INDUSTRIAL CO., LTD.
//0090F8, "MEDIATRIX TELECOM
//009010, "SIMULATION LABORATORIES, INC.
//0090C6 OPTIM SYSTEMS, INC.
//00902E, "NAMCO LIMITED
//009037, "ACUCOMM, INC.
//009078, "MER TELEMANAGEMENT SOLUTIONS, LTD.
//0090B8 ROHDE & SCHWARZ GMBH & CO.KG
//00901A UNISPHERE SOLUTIONS
//0090B5 NIKON CORPORATION
//009005, "PROTECH SYSTEMS CO., LTD.
//009059, "TELECOM DEVICE K.K.
//0090CA ACCORD VIDEO TELECOMMUNICATIONS, LTD.
//0090E9, "JANZ COMPUTER AG
//0090EB SENTRY TELECOM SYSTEMS
//0090FE ELECOM CO., LTD.", "(LANEED DIV.)
//0090BB TAINET COMMUNICATION SYSTEM Corp.
//009090, "I-BUS
//0090D5, "EUPHONIX, INC.
//00904A CONCUR SYSTEM TECHNOLOGIES
//00908F, "AUDIO CODES LTD.
//00909E, "Critical IO, LLC
//001092, "NETCORE INC.
//00101C OHM TECHNOLOGIES INTL, LLC
//001046, "ALCORN MCBRIDE INC.
//001028, "COMPUTER TECHNICA, INC.
//0010B7 COYOTE TECHNOLOGIES, LLC
//0090E5, "TEKNEMA, INC.
//0090F4, "LIGHTNING INSTRUMENTATION
//009074, "ARGON NETWORKS, INC.
//00909F, "DIGI-DATA CORPORATION
//00903B TriEMS Research Lab, Inc.
//0010C9 MITSUBISHI ELECTRONICS LOGISTIC SUPPORT CO.
//000400, "LEXMARK INTERNATIONAL, INC.
//0010C5 PROTOCOL TECHNOLOGIES, INC.
//00101A PictureTel Corp.
//001047, "ECHO ELETRIC CO.LTD.
//00903F, "AZTEC RADIOMEDIA
//001043, "A2 CORPORATION
//0010A5 OXFORD INSTRUMENTS
//0010D7, "ARGOSY RESEARCH INC.
//00102C Lasat Networks A/S
//0010FD COCOM A/S
//009019, "HERMES ELECTRONICS CO., LTD.
//0090D8, "WHITECROSS SYSTEMS
//00104E, "CEOLOGIC
//0010C2 WILLNET, INC.
//001040, "INTERMEC CORPORATION
//00102E, "NETWORK SYSTEMS & TECHNOLOGIES PVT. LTD.
//0010B0 MERIDIAN TECHNOLOGY CORP.
//001021, "ENCANTO NETWORKS, INC.
//001064, "DNPG, LLC
//001074, "ATEN INTERNATIONAL CO., LTD.
//00109E, "AWARE, INC.
//001005, "UEC COMMERCIAL
//0010B8 ISHIGAKI COMPUTER SYSTEM CO.
//00108B LASERANIMATION SOLLINGER GMBH
//0010C7 DATA TRANSMISSION NETWORK
//001070, "CARADON TREND LTD.
//0010BA MARTINHO-DAVIS SYSTEMS, INC.
//0010B4 ATMOSPHERE NETWORKS
//0004AC IBM Corp
//001067, "Ericsson
//00E07D, "NETRONIX, INC.
//00E028, "APTIX CORPORATION
//00E08C NEOPARADIGM LABS, INC.
//00E0A1 HIMA PAUL HILDEBRANDT GmbH Co. KG
//00E088, "LTX-Credence CORPORATION
//00E05D, "UNITEC CO., LTD.
//00E05E JAPAN AVIATION ELECTRONICS INDUSTRY, LTD.
//00E09D, "SARNOFF CORPORATION
//00E058, "PHASE ONE DENMARK A/S
//00E076, "DEVELOPMENT CONCEPTS, INC.
//00E0F8, "DICNA CONTROL AB
//00E0DF KEYMILE GmbH
//00E0F2, "ARLOTTO COMNET, INC.
//00E0E1 G2 NETWORKS, INC.
//00E03D, "FOCON ELECTRONIC SYSTEMS A/S
//00E046, "BENTLY NEVADA CORP.
//00E07B BAY NETWORKS
//00E01D, "WebTV NETWORKS, INC.
//00E0CD SAAB SENSIS CORPORATION
//00E08D, "PRESSURE SYSTEMS, INC.
//00E019, "ING.GIORDANO ELETTRONICA
//00E047, "InFocus Corporation
//00E0C3 SAKAI SYSTEM DEVELOPMENT CORP.
//00E092, "ADMTEK INCORPORATED
//00E0FF SECURITY DYNAMICS TECHNOLOGIES, Inc.
//00E0AB DIMAT S.A.
//00E030, "MELITA INTERNATIONAL CORP.
//00E033, "E.E.P.D.GmbH
//00E0A2 MICROSLATE INC.
//00E079, "A.T.N.R.
//00E075, "Verilink Corporation
//006039, "SanCom Technology, Inc.
//006049, "VINA TECHNOLOGIES
//00608D, "UNIPULSE CORP.
//00E02E SPC ELECTRONICS CORPORATION
//00E09A Positron Inc.
//00E03E ALFATECH, INC.
//006099, "SBE, Inc.
//0060B3 Z-COM, INC.
//006002, "SCREEN SUBTITLING SYSTEMS, LTD
//006089, "XATA
//006021, "DSC CORPORATION
//0060B8 CORELIS Inc.
//00E0AA ELECTROSONIC LTD.
//00E010, "HESS SB-AUTOMATENBAU GmbH
//00E0D2, "VERSANET COMMUNICATIONS, INC.
//0060CE ACCLAIM COMMUNICATIONS
//006036, "AIT Austrian Institute of Technology GmbH
//00608E, "HE ELECTRONICS, TECHNOLOGIE & SYSTEMTECHNIK GmbH
//00601A KEITHLEY INSTRUMENTS
//00606A MITSUBISHI WIRELESS COMMUNICATIONS. INC.
//0060AD MegaChips Corporation
//006055, "CORNELL UNIVERSITY
//00606D, "DIGITAL EQUIPMENT CORP.
//0060B9 NEC Platforms, Ltd
//00609C Perkin-Elmer Incorporated
//0060CF ALTEON NETWORKS, INC.
//006075, "PENTEK, INC.
//0060B7 CHANNELMATIC, INC.
//006006, "SOTEC CO., LTD
//0060BA SAHARA NETWORKS, INC.
//006098, "HT COMMUNICATIONS
//0060DE Kayser-Threde GmbH
//0060D0, "SNMP RESEARCH INCORPORATED
//006015, "NET2NET CORPORATION
//00609D, "PMI FOOD EQUIPMENT GROUP
//0060A2 NIHON UNISYS LIMITED CO.
//006084, "DIGITAL VIDEO
//00602D, "ALERTON TECHNOLOGIES, INC.
//0060F8, "Loran International Technologies Inc.
//006078, "POWER MEASUREMENT LTD.
//0060E8, "HITACHI COMPUTER PRODUCTS (AMERICA), INC.
//0060F6, "NEXTEST COMMUNICATIONS PRODUCTS, INC.
//006072, "VXL INSTRUMENTS, LIMITED
//006051, "QUALITY SEMICONDUCTOR
//006092, "MICRO/SYS, INC.
//00609E, "ASC X3 - INFORMATION TECHNOLOGY STANDARDS SECRETARIATS
//006010, "NETWORK MACHINES, INC.
//006044, "LITTON/POLY-SCIENTIFIC
//006004, "COMPUTADORES MODULARES SA
//0060E2, "QUEST ENGINEERING & DEVELOPMENT
//0060B4 GLENAYRE R&D INC.
//00A01D Red Lion Controls, LP
//00A0A6 M.I.SYSTEMS, K.K.
//00A051 ANGIA COMMUNICATIONS.INC.
//00A013 TELTREND LTD.
//00A0B9 EAGLE TECHNOLOGY, INC.
//00A019 NEBULA CONSULTANTS, INC.
//00A0ED Brooks Automation, Inc.
//0060CA HARMONIC SYSTEMS INCORPORATED
//006024, "GRADIENT TECHNOLOGIES, INC.
//0060AF PACIFIC MICRO DATA, INC.
//006038, "Nortel Networks
//00604F, "Tattile SRL
//00A0D0 TEN X TECHNOLOGY, INC.
//00A0BC VIASAT, INCORPORATED
//00A05B MARQUIP, INC.
//00A08C MultiMedia LANs, Inc.
//00A058 GLORY, LTD.
//00A077 FUJITSU NEXION, INC.
//00A0A0 COMPACT DATA, LTD.
//00A038 EMAIL ELECTRONICS
//00A065 Symantec Corporation
//00A0A3 RELIABLE POWER METERS
//00A01B PREMISYS COMMUNICATIONS, INC.
//00A055 Data Device Corporation
//00A074 PERCEPTION TECHNOLOGY
//00A07F GSM-SYNTEL, LTD.
//00A029 COULTER CORPORATION
//00A087 Microsemi Corporation
//00A043 AMERICAN TECHNOLOGY LABS, INC.
//00A042 SPUR PRODUCTS CORP.
//00A0C1 ORTIVUS MEDICAL AB
//00A04F AMERITEC CORP.
//00A0CF SOTAS, INC.
//00A072 OVATION SYSTEMS LTD.
//00A082 NKT ELEKTRONIK A/S
//00A0F0 TORONTO MICROELECTRONICS INC.
//00A0D7 KASTEN CHASE APPLIED RESEARCH
//00A0F1 MTI
//00A0B3 ZYKRONIX
//00A0FF TELLABS OPERATIONS, INC.
//00A0E5 NHC COMMUNICATIONS
//00A036 APPLIED NETWORK TECHNOLOGY
//00A0D2 ALLIED TELESIS INTERNATIONAL CORPORATION
//00A09B QPSX COMMUNICATIONS, LTD.
//00A000 CENTILLION NETWORKS, INC.
//00A08A BROOKTROUT TECHNOLOGY, INC.
//00A07B DAWN COMPUTER INCORPORATION
//00A05C INVENTORY CONVERSION, INC./
//00200F, "EBRAINS Inc
//00A0D3 INSTEM COMPUTER SYSTEMS, LTD.
//00A0B4 TEXAS MICROSYSTEMS, INC.
//00A060 ACER PERIPHERALS, INC.
//00A083 ASIMMPHONY TURKEY
//00A0AA SPACELABS MEDICAL
//00A03B TOSHIN ELECTRIC CO., LTD.
//00A0F3 STAUBLI
//0020DF KYOSAN ELECTRIC MFG. CO., LTD.
//0020C7 AKAI Professional M.I.Corp.
//00A004 NETPOWER, INC.
//002029, "TELEPROCESSING PRODUCTS, INC.
//002069, "ISDN SYSTEMS CORPORATION
//00208B LAPIS TECHNOLOGIES, INC.
//00202B ADVANCED TELECOMMUNICATIONS MODULES, LTD.
//00206B KONICA MINOLTA HOLDINGS, INC.
//002004, "YAMATAKE-HONEYWELL CO., LTD.
//002015, "ACTIS COMPUTER SA
//002099, "BON ELECTRIC CO., LTD.
//0020F9, "PARALINK NETWORKS, INC.
//002092, "CHESS ENGINEERING B.V.
//002043, "NEURON COMPANY LIMITED
//002071, "IBR GMBH
//00207C AUTEC GMBH
//002057, "TITZE DATENTECHNIK GmbH
//0020E5, "APEX DATA, INC.
//002087, "MEMOTEC, INC.
//0020BC Long Reach Networks Pty Ltd
//00C0C0 SHORE MICROSYSTEMS, INC.
//00C00C RELIA TECHNOLGIES
//00C073 XEDIA CORPORATION
//00C0D4 AXON NETWORKS, INC.
//00C0CD COMELTA, S.A.
//0020ED, "GIGA-BYTE TECHNOLOGY CO., LTD.
//002085, "Eaton Corporation
//0020CD HYBRID NETWORKS, INC.
//00202E, "DAYSTAR DIGITAL
//0020B3 Tattile SRL
//0020EE GTECH CORPORATION
//00204C MITRON COMPUTER PTE LTD.
//002017, "ORBOTECH
//002093, "LANDINGS TECHNOLOGY CORP.
//002063, "WIPRO INFOTECH LTD.
//002016, "SHOWA ELECTRIC WIRE & CABLE CO
//00204D, "INOVIS GMBH
//00205F, "GAMMADATA COMPUTER GMBH
//00201F, "BEST POWER TECHNOLOGY, INC.
//0020B6 AGILE NETWORKS, INC.
//0020D1, "MICROCOMPUTER SYSTEMS (M) SDN.
//0020CE LOGICAL DESIGN GROUP, INC.
//002014, "GLOBAL VIEW CO., LTD.
//0020C2 TEXAS MEMORY SYSTEMS, INC.
//00C0F3 NETWORK COMMUNICATIONS CORP.
//002056, "NEOPRODUCTS
//002042, "DATAMETRICS CORP.
//002078, "RUNTOP, INC.
//002006, "GARRETT COMMUNICATIONS, INC.
//002024, "PACIFIC COMMUNICATION SCIENCES
//00205D, "NANOMATIC OY
//00C005 LIVINGSTON ENTERPRISES, INC.
//00C077 DAEWOO TELECOM LTD.
//00C0C8 MICRO BYTE PTY. LTD.
//00C069 Axxcelera Broadband Wireless
//00C067 UNITED BARCODE INDUSTRIES
//00C0A3 DUAL ENTERPRISES CORPORATION
//00C018 LANART CORPORATION
//009D8E, "CARDIAC RECORDERS, INC.
//00BB01 OCTOTHORPE CORP.
//00C033 TELEBIT COMMUNICATIONS APS
//00C090 PRAIM S.R.L.
//00C0DE ZCOMM, INC.
//00C013 NETRIX
//00C06B OSI PLUS CORPORATION
//00C04C DEPARTMENT OF FOREIGN AFFAIRS
//00C07C HIGHTECH INFORMATION
//00C0B8 FRASER'S HILL LTD.
//00C062 IMPULSE TECHNOLOGY
//00C0EC DAUPHIN TECHNOLOGY
//00C086 THE LYNK CORPORATION
//00C058 DATAEXPERT CORP.
//00C0D0 RATOC SYSTEM INC.
//00C0BF TECHNOLOGY CONCEPTS, LTD.
//00C0BA NETVANTAGE
//00C05E VARI-LITE, INC.
//00C0D5 Werbeagentur Jürgen Siebert
//00C063 MORNING STAR TECHNOLOGIES, INC
//00C021 NETEXPRESS
//00C0DB IPC CORPORATION (PTE) LTD.
//00C09B RELIANCE COMM/TEC, R-TEC
//00C06A ZAHNER-ELEKTRIK GMBH & CO.KG
//00C0E3 OSITECH COMMUNICATIONS, INC.
//00C0FE APTEC COMPUTER SYSTEMS, INC.
//00C016 ELECTRONIC THEATRE CONTROLS
//00C0BC TELECOM AUSTRALIA/CSSC
//00C0C1 QUAD/GRAPHICS, INC.
//00C089 TELINDUS DISTRIBUTION
//00C0B0 GCC TECHNOLOGIES, INC.
//00C00A MICRO CRAFT
//00C074 TOYODA AUTOMATIC LOOM
//00404E, "FLUENT, INC.
//00408D, "THE GOODYEAR TIRE & RUBBER CO.
//00401B PRINTER SYSTEMS CORP.
//0040A3 MICROUNITY SYSTEMS ENGINEERING
//0040B3 ParTech Inc.
//00401D, "INVISIBLE SOFTWARE, INC.
//00C0CA ALFA, INC.
//00C06C SVEC COMPUTER CORP.
//0040FF TELEBIT CORPORATION
//00401F, "COLORGRAPH LTD
//0040AF DIGITAL PRODUCTS, INC.
//0040F7, "Polaroid Corporation
//004037, "SEA-ILAN, INC.
//00C026 LANS TECHNOLOGY CO., LTD.
//00407E, "EVERGREEN SYSTEMS, INC.
//0040F9, "COMBINET
//00C06F KOMATSU LTD.
//00C0A7 SEEL LTD.
//00C04A GROUP 2000 AG
//004054, "CONNECTION MACHINES SERVICES
//004004, "ICM CO. LTD.
//004058, "KRONOS, INC.
//004018, "ADOBE SYSTEMS, INC.
//00404A WEST AUSTRALIAN DEPARTMENT
//00403C FORKS, INC.
//004042, "N.A.T.GMBH
//0040F2, "JANICH & KLASS COMPUTERTECHNIK
//0040A2 KINGSTAR TECHNOLOGY INC.
//0040DC TRITEC ELECTRONIC GMBH
//004060, "COMENDEC LTD
//004056, "MCM JAPAN LTD.
//004030, "GK COMPUTER
//004040, "RING ACCESS, INC.
//008057, "ADSOFT, LTD.
//0080BB HUGHES LAN SYSTEMS
//00403D, "Teradata Corporation
//0040D0, "MITAC INTERNATIONAL CORP.
//0040AB ROLAND DG CORPORATION
//0040B6 COMPUTERM", "CORPORATION
//0040A6 Cray, Inc.
//00403E, "RASTER OPS CORPORATION
//004046, "UDC RESEARCH LIMITED
//00C0D7 TAIWAN TRADING CENTER DBA
//0040DA TELSPEC LTD
//0040C7 RUBY TECH CORPORATION
//004052, "STAR TECHNOLOGIES, INC.
//00402E, "PRECISION SOFTWARE, INC.
//00402B TRIGEM COMPUTER, INC.
//00401A FUJI ELECTRIC CO., LTD.
//00405F, "AFE COMPUTERS LTD.
//004080, "ATHENIX CORPORATION
//004051, "Garbee and Garbee
//00407A SOCIETE D'EXPLOITATION DU CNIT
//004031, "KOKUSAI ELECTRIC CO., LTD
//0040D3, "KIMPSION INTERNATIONAL CORP.
//0040EE OPTIMEM
//004025, "MOLECULAR DYNAMICS
//004067, "OMNIBYTE CORPORATION
//0040C3 FISCHER AND PORTER CO.
//0040EC MIKASA SYSTEM ENGINEERING
//00802F, "NATIONAL INSTRUMENTS CORP.
//008054, "FRONTIER TECHNOLOGIES CORP.
//008053, "INTELLICOM, INC.
//008026, "NETWORK PRODUCTS CORPORATION
//0080B0 ADVANCED INFORMATION
//0080FA RWT GMBH
//0080FD EXSCEED CORPRATION
//0080FE AZURE TECHNOLOGIES, INC.
//00803C TVS ELECTRONICS LTD
//008046, "Tattile SRL
//004002, "PERLE SYSTEMS LIMITED
//004049, "Roche Diagnostics International Ltd.
//004029, "Compex
//00409E, "CONCURRENT TECHNOLOGIES", "LTD.
//0080AD CNET TECHNOLOGY, INC.
//00800E, "ATLANTIX CORPORATION
//0080AB DUKANE NETWORK INTEGRATION
//0080F1, "OPUS SYSTEMS
//008029, "EAGLE TECHNOLOGY, INC.
//008072, "MICROPLEX SYSTEMS LTD.
//004001, "Zero One Technology Co. Ltd.
//004071, "ATM COMPUTER GMBH
//008011, "DIGITAL SYSTEMS INT'L. INC.
//008034, "SMT GOUPIL
//0080E4, "NORTHWEST DIGITAL SYSTEMS, INC
//0080EC SUPERCOMPUTING SOLUTIONS, INC.
//00802C THE SAGE GROUP PLC
//0080D6, "NUVOTECH, INC.
//00800A JAPAN COMPUTER CORP.
//00804B EAGLE TECHNOLOGIES PTY.LTD.
//0080C8 D-LINK SYSTEMS, INC.
//008012, "INTEGRATED MEASUREMENT SYSTEMS
//008027, "ADAPTIVE SYSTEMS, INC.
//0080FC AVATAR CORPORATION
//008016, "WANDEL AND GOLTERMANN
//0080A2 CREATIVE ELECTRONIC SYSTEMS
//0080CC MICROWAVE BYPASS SYSTEMS
//0080A5 SPEED INTERNATIONAL
//008079, "MICROBUS DESIGNS LTD.
//000079, "NETWORTH INCORPORATED
//000091, "ANRITSU CORPORATION
//000075, "Nortel Networks
//0000A5 Tattile SRL
//000036, "ATARI CORPORATION
//0000F8, "DIGITAL EQUIPMENT CORPORATION
//00805C AGILIS CORPORATION
//0080C5 NOVELLCO DE MEXICO
//008078, "PRACTICAL PERIPHERALS, INC.
//0080F6, "SYNERGY MICROSYSTEMS
//00807B ARTEL COMMUNICATIONS CORP.
//008014, "ESPRIT SYSTEMS
//0080B7 STELLAR COMPUTER
//0000ED, "APRIL
//0000A3 NETWORK APPLICATION TECHNOLOGY
//000039, "TOSHIBA CORPORATION
//00003C AUSPEX SYSTEMS INC.
//00007E, "CLUSTRIX CORPORATION
//0000CB COMPU-SHACK ELECTRONIC GMBH
//000013, "CAMEX
//000095, "SONY TEKTRONIX CORP.
//000057, "SCITEX CORPORATION LTD.
//0000D6, "PUNCH LINE HOLDING
//00009E, "MARLI S.A.
//000042, "METIER MANAGEMENT SYSTEMS LTD.
//00007D, "Oracle Corporation
//000096, "MARCONI ELECTRONICS LTD.
//00005E, "ICANN, IANA Department
//000038, "CSS LABS
//000044, "CASTELLE CORPORATION
//0000CE MEGADATA CORP.
//00007B RESEARCH MACHINES
//00000F, "NEXT, INC.
//0000BB TRI-DATA
//00001A ADVANCED MICRO DEVICES
//00007F, "LINOTYPE-HELL AG
//000060, "KONTRON ELEKTRONIK GMBH
//08006F, "PHILIPS APELDOORN B.V.
//000040, "APPLICON, INC.
//00005D, "CS TELECOM
//000012, "INFORMATION TECHNOLOGY LIMITED
//00008A DATAHOUSE INFORMATION SYSTEMS
//000032, "Marconi plc
//000085, "CANON INC.
//00004A ADC CODENOLL TECHNOLOGY CORP.
//08008F, "CHIPCOM CORPORATION
//00006A COMPUTER CONSOLES INC.
//08003E, "CODEX CORPORATION
//080040, "FERRANTI COMPUTER SYS.LIMITED
//08003A ORCATECH INC.
//08003D, "CADNETIX CORPORATIONS
//080038, "BULL S.A.S.
//080073, "TECMAR INC.
//080072, "XEROX CORP UNIV GRANT PROGRAM
//08006A AT&T
//08007A INDATA
//080079, "THE DROID WORKS
//08004D, "CORVUS SYSTEMS INC.
//08002F, "PRIME COMPUTER INC.
//08002C BRITTON LEE INC.
//080062, "General Dynamics
//08005C FOUR PHASE SYSTEMS
//08005A IBM Corp
//080052, "INSYSTEC
//08001E, "APOLLO COMPUTER INC.
//080019, "GENERAL ELECTRIC CORPORATION
//027001, "RACAL-DATACOM
//08000E, "NCR CORPORATION
//00DD09 UNGERMANN-BASS INC.
//000002, "XEROX CORPORATION
//000003, "XEROX CORPORATION
//000006, "XEROX CORPORATION
//080001, "COMPUTERVISION CORPORATION
//080005, "SYMBOLICS INC.
//00DD07 UNGERMANN-BASS INC.
//000008, "XEROX CORPORATION
//00003D, "UNISYS
//00DD0D UNGERMANN-BASS INC.
//080064, "Sitasys AG
//080002, "BRIDGE COMMUNICATIONS INC.
//08001A TIARA/ 10NET
//08008B PYRAMID TECHNOLOGY CORP.
//080012, "BELL ATLANTIC INTEGRATED SYST.
//14A1BF ASSA ABLOY Korea Co., Ltd Unilock
//9483C4 GL Technologies (Hong Kong) Limited
//080030, "ROYAL MELBOURNE INST OF TECH
//00000B MATRIX CORPORATION
//00009B INFORMATION INTERNATIONAL, INC
//9C93B0 Megatronix (Beijing) Technology Co., Ltd.
//64AEF1 Qingdao Hisense Electronics Co., Ltd.
//080016, "BARRISTER INFO SYS CORP
//44CB8B LG Innotek
//B4055D", "Inspur Electronic Information Industry Co., Ltd.
//984827, "TP-LINK TECHNOLOGIES CO., LTD.
//D4F5EF Hewlett Packard Enterprise
//90B832 Aerohive Networks Inc.
//28BD89 Google, Inc.
//EC1BBD Silicon Laboratories
//D8A315", "vivo Mobile Communication Co., Ltd.
//80647A Ola Sense Inc
//C0B883 Intel Corporate
//24FD0D INDÚSTRIA DE TELECOMUNICAÇÃO ELETRÔNICA
//70F82B DWnet Technologies(Suzhou) Corporation
//142475, "4DReplay, Inc
//10DCB6 IEEE Registration Authority
//F89E28 Cisco Meraki
//F8C4F3", "Shanghai Infinity Wireless Technologies Co., Ltd.
//D4772B Nanjing Ztlink Network Technology Co., Ltd
//64F9C0 ANALOG DEVICES
//18D0C5 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//34ED1B Cisco Systems, Inc
//BCA511", "NETGEAR
//000A7B Cornelius Consult
//C4E90A", "D-Link International
//C4447D HUAWEI TECHNOLOGIES CO., LTD
//30E98E HUAWEI TECHNOLOGIES CO., LTD
//748B34 Shanghai Smart System Technology Co., Ltd
//ACBD70", "Huawei Device Co., Ltd.
//C809A8 Intel Corporate
//C02E26", "Private
//34D262, "SZ DJI TECHNOLOGY CO., LTD
//0812A5 Amazon Technologies Inc.
//807FF8 Juniper Networks
//440377, "IEEE Registration Authority
//002487, "Transact Campus, Inc.
//B4E9A3 port industrial automation GmbH
//38E8EE Nanjing Youkuo Electric Technology Co., Ltd
//90B8E0 SHENZHEN YANRAY TECHNOLOGY CO., LTD
//9CF531 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//80E455, "New H3C Technologies Co., Ltd
//2C4CC6 Murata Manufacturing Co., Ltd.
//7C210D Cisco Systems, Inc
//4CBC72 Primex Wireless
//6802B8 Compal Broadband Networks, Inc.
//3463D4, "BIONIX SUPPLYCHAIN TECHNOLOGIES SLU
//08F7E9, "HRCP Research and Development Partnership
//8CBA25 UNIONMAN TECHNOLOGY CO., LTD
//D49E3B", "Guangzhou Shiyuan Electronic Technology Company Limited
//DCDCE2 Samsung Electronics Co., Ltd
//A0AC69", "Samsung Electronics Co., Ltd
//1089FB Samsung Electronics Co., Ltd
//DC4BDD", "Shenzhen SuperElectron Technology Co., Ltd.
//C0B5CD Huawei Device Co., Ltd.
//4C5077 Huawei Device Co., Ltd.
//502DBB GD Midea Air-Conditioning Equipment Co., Ltd.
//84EA97 Shenzhen iComm Semiconductor Co., Ltd.
//5C3A3D zte corporation
//30FD65 HUAWEI TECHNOLOGIES CO., LTD
//7CA1AE Apple, Inc.
//3C22FB Apple, Inc.
//58EAFC ELL-IoT Inc
//9013DA Athom B.V.
//14115D, "Skyworth Digital Technology(Shenzhen) Co., Ltd
//E4F327", "ATOL LLC
//6819AC Guangzhou Xianyou Intelligent Technogoly CO., LTD
//E82E0C", "NETINT Technologies Inc.
//1892A4 Ciena Corporation
//10082C Texas Instruments
//B0735D", "Huawei Device Co., Ltd.
//F0B4D2 D-Link International
//5C3A45 CHONGQING FUGUI ELECTRONICS CO., LTD.
//A03C31 Shenzhen Belon Technology CO., LTD
//A897CD", "ARRIS Group, Inc.
//404C77 ARRIS Group, Inc.
//2CE310 Stratacache
//0022A0 APTIV SERVICES US, LLC
//A4307A", "Samsung Electronics Co., Ltd
//FC8E5B", "China Mobile Iot Limited company
//142A14 ShenZhen Selenview Digital Technology Co., Ltd
//D87E76", "ITEL MOBILE LIMITED
//384B5B ZTRON TECHNOLOGY LIMITED
//B86142 Beijing Tricolor Technology Co., Ltd
//200A0D IEEE Registration Authority
//E47C65 Sunstar Communication Technology", "Co., Ltd
//9C54DA SkyBell Technologies Inc.
//4C494F zte corporation
//C4741E", "zte corporation
//00D078, "Eltex of Sweden AB
//5C78F8 Huawei Device Co., Ltd.
//B827C5 Huawei Device Co., Ltd.
//DC8983 Samsung Electronics Co., Ltd
//5CCB99 Samsung Electronics Co., Ltd
//D46075", "Baidu Online Network Technology (Beijing) Co., Ltd
//78C5F8 Huawei Device Co., Ltd.
//D45D64 ASUSTek COMPUTER INC.
//90B144 Samsung Electronics Co., Ltd
//48DD0C eero inc.
//940C98 Apple, Inc.
//E8FBE9 Apple, Inc.
//38EC0D Apple, Inc.
//58278C BUFFALO.INC
//140AC5 Amazon Technologies Inc.
//2083F8, "Advanced Digital Broadcast SA
//C8C750 Motorola Mobility LLC, a Lenovo Company
//2CDCD7 AzureWave Technology Inc.
//8CC681 Intel Corporate
//34E3DA Hoval Aktiengesellschaft
//E0BB9E", "Seiko Epson Corporation
//48D24F, "Sagemcom Broadband SAS
//E4AAEC", "Tianjin Hualai Technology Co., Ltd
//94BE46 Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//ACF8CC ARRIS Group, Inc.
//8C5A25 ARRIS Group, Inc.
//483FDA Espressif Inc.
//6C5D3A Microsoft Corporation
//CCD42E", "Arcadyan Corporation
//C853E1 Beijing Bytedance Network Technology Co., Ltd
//14169D, "Cisco Systems, Inc
//48A2E6 Resideo
//90E2FC IEEE Registration Authority
//F008D1 Espressif Inc.
//5894B2 BrainCo
//B09575 TP-LINK TECHNOLOGIES CO., LTD.
//B4B055 HUAWEI TECHNOLOGIES CO., LTD
//048C16 HUAWEI TECHNOLOGIES CO., LTD
//98DD5B TAKUMI JAPAN LTD
//3C5CF1 eero inc.
//14AE85 IEEE Registration Authority
//90749D, "IRay Technology Co., Ltd.
//8C3B32 Microfan B.V.
//D0D3E0 Aruba, a Hewlett Packard Enterprise Company
//3C58C2 Intel Corporate
//CCF9E4", "Intel Corporate
//645CF3 ParanTek Inc.
//B0CCFE Huawei Device Co., Ltd.
//540DF9 Huawei Device Co., Ltd.
//006619, "Huawei Device Co., Ltd.
//FC3964 ITEL MOBILE LIMITED
//E45E37 Intel Corporate
//14472D, "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//E490FD", "Apple, Inc.
//84AB1A Apple, Inc.
//206D31, "FIREWALLA INC
//D06544 Apple, Inc.
//7C8AE1 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//54E4A9 BHR Tech GmbH
//208058, "Ciena Corporation
//684AAE HUAWEI TECHNOLOGIES CO., LTD
//60D755, "HUAWEI TECHNOLOGIES CO., LTD
//A445CD", "IoT Diagnostics
//946269, "ARRIS Group, Inc.
//D0DD49 Juniper Networks
//C863FC", "ARRIS Group, Inc.
//1CCCD6 Xiaomi Communications Co Ltd
//A8C252", "Huawei Device Co., Ltd.
//A04147 Huawei Device Co., Ltd.
//1CAECB HUAWEI TECHNOLOGIES CO., LTD
//4CF19E Groupe Atlantic
//04ED33, "Intel Corporate
//2036D7, "Shanghai Reacheng", "Communication Technology Co., Ltd
//68070A TPVision Europe B.V
//4CEBBD CHONGQING FUGUI ELECTRONICS CO., LTD.
//7CC926 Wuhan GreeNet Information Service Co., Ltd.
//5C75AF Fitbit, Inc.
//38BAB0 Broadcom
//70879E, "Beken Corporation
//B45062 EmBestor Technology Inc.
//044A6C HUAWEI TECHNOLOGIES CO., LTD
//38FB14 HUAWEI TECHNOLOGIES CO., LTD
//F0E4A2", "HUAWEI TECHNOLOGIES CO., LTD
//7C5189 SG Wireless Limited
//7CB27D Intel Corporate
//1063C8 Liteon Technology Corporation
//582059, "Xiaomi Communications Co Ltd
//90272B Algorab S.r.l.
//4CBCB4 ABB SpA - DIN Rail
//94D505, "Fiberhome Telecommunication Technologies Co., LTD
//74E1B6 Apple, Inc.
//24A52C HUAWEI TECHNOLOGIES CO., LTD
//482759, "Levven Electronics Ltd.
//AC7713 Honeywell Safety Products (Shanghai) Co., Ltd
//08849D, "Amazon Technologies Inc.
//90BDE6 Quectel Wireless Solutions Co., Ltd.
//18A4A9 Vanu Inc.
//80E82C Hewlett Packard
//D4ADBD", "Cisco Systems, Inc
//2440AE NIIC Technology Co., Ltd.
//F40E01 Apple, Inc.
//1495CE Apple, Inc.
//50DE06 Apple, Inc.
//5CD135 Xtreme Power Systems
//7869D4, "Shenyang Vibrotech Instruments Inc.
//082697, "Zyxel Communications Corporation
//CCCCCC", "Silicon Laboratories
//CC660A Apple, Inc.
//FC1D43 Apple, Inc.
//64CB9F TECNO MOBILE LIMITED
//4CFBFE Sercomm Japan Corporation
//C0CBF1 Mobiwire Mobiles (NingBo) Co., LTD
//FC7D6C", "HYESUNG TECHWIN Co., Ltd
//E47E9A", "zte corporation
//2C16BD IEEE Registration Authority
//30A889 DECIMATOR DESIGN
//B4A2EB", "IEEE Registration Authority
//1CD5E2 Shenzhen YOUHUA Technology Co., Ltd
//0024E9, "Samsung Electronics Co., Ltd
//683B78 Cisco Systems, Inc
//F860F0", "Aruba, a Hewlett Packard Enterprise Company
//5CA1E0 EmbedWay Technologies
//84D412, "Palo Alto Networks
//68AB09 Nokia
//F4CE36 Nordic Semiconductor ASA
//B46077 Sichuan Changhong Electric Ltd.
//00F620, "Google, Inc.
//F43328 CIMCON Lighting Inc.
//7C942A HUAWEI TECHNOLOGIES CO., LTD
//1CB796 HUAWEI TECHNOLOGIES CO., LTD
//3847BC HUAWEI TECHNOLOGIES CO., LTD
//549209, "HUAWEI TECHNOLOGIES CO., LTD
//745909, "HUAWEI TECHNOLOGIES CO., LTD
//5C5AC7 Cisco Systems, Inc
//3CB74B Technicolor CH USA Inc.
//00EDB8 KYOCERA Corporation
//9C99CD Voippartners
//C4C603 Cisco Systems, Inc
//BCA13A", "SES-imagotag
//2823F5, "China Mobile (Hangzhou) Information Technology Co., Ltd.
//F010AB China Mobile (Hangzhou) Information Technology Co., Ltd.
//B4DC09 Guangzhou Dawei Communication Co., Ltd
//98865D, "Nokia Shanghai Bell Co., Ltd.
//7CB59B TP-LINK TECHNOLOGIES CO., LTD.
//2C4F52 Cisco Systems, Inc
//68A03E HUAWEI TECHNOLOGIES CO., LTD
//B8C385", "HUAWEI TECHNOLOGIES CO., LTD
//4CE9E4 New H3C Technologies Co., Ltd
//ACDB48", "ARRIS Group, Inc.
//C80D32 Holoplot GmbH
//D05794", "Sagemcom Broadband SAS
//04D9F5, "ASUSTek COMPUTER INC.
//B891C9 Handreamnet
//C8A776 HUAWEI TECHNOLOGIES CO., LTD
//A400E2", "HUAWEI TECHNOLOGIES CO., LTD
//B4C4FC", "Xiaomi Communications Co Ltd
//C8D69D Arab International Optronics
//405BD8 CHONGQING FUGUI ELECTRONICS CO., LTD.
//54EC2F Ruckus Wireless
//2899C7 LINDSAY BROADBAND INC
//FCBD67 Arista Networks
//00257E, "NEW POS TECHNOLOGY LIMITED
//487746, "Calix Inc.
//F8AE27 John Deere Electronic Solutions
//7445CE CRESYN
//C4F7D5 Cisco Systems, Inc
//1C6499 Comtrend Corporation
//686DBC Hangzhou Hikvision Digital Technology Co., Ltd.
//10DC4A Fiberhome Telecommunication Technologies Co., LTD
//88EF16, "ARRIS Group, Inc.
//8CA96F D&M Holdings Inc.
//7CD661 Xiaomi Communications Co Ltd
//B0FD0B", "IEEE Registration Authority
//98B8BA LG Electronics (Mobile Communications)
//0CE99A ATLS ALTEC
//4C11AE Espressif Inc.
//8C89FA Zhejiang Hechuan Technology Co., Ltd.
//4CBC48 Cisco Systems, Inc
//80D04A Technicolor CH USA Inc.
//48D875, "China TransInfo Technology Co., Ltd
//D4789B", "Cisco Systems, Inc
//483FE9 HUAWEI TECHNOLOGIES CO., LTD
//143CC3 HUAWEI TECHNOLOGIES CO., LTD
//A8E544", "HUAWEI TECHNOLOGIES CO., LTD
//1820D5, "ARRIS Group, Inc.
//3050FD Skyworth Digital Technology(Shenzhen) Co., Ltd
//0040BC ALGORITHMICS LTD.
//004065, "GTE SPACENET
//88E64B Juniper Networks
//D8D090", "Dell Inc.
//50C4DD BUFFALO.INC
//0084ED, "Private
//E002A5", "ABB Robotics
//F42E7F Aruba, a Hewlett Packard Enterprise Company
//B4CC04", "Piranti
//B8D526", "Zyxel Communications Corporation
//F0B968", "ITEL MOBILE LIMITED
//04E56E THUB Co., ltd.
//1C7F2C HUAWEI TECHNOLOGIES CO., LTD
//88BCC1 HUAWEI TECHNOLOGIES CO., LTD
//1CBFCE Shenzhen Century Xinyang Technology Co., Ltd
//F83002", "Texas Instruments
//A8A159 ASRock Incorporation
//ECADE0", "D-Link International
//78DA07 Zhejiang Tmall Technology Co., Ltd.
//44A61E INGRAM MICRO SERVICES
//38D2CA Zhejiang Tmall Technology Co., Ltd.
//109E3A Zhejiang Tmall Technology Co., Ltd.
//904DC3 Flonidan A/S
//000DF1 IONIX INC.
//00077C Westermo Network Technologies AB
//8C426D HUAWEI TECHNOLOGIES CO., LTD
//90F891, "Kaonmedia CO., LTD.
//445D5E, "SHENZHEN Coolkit Technology CO., LTD
//50AD71 Tessolve Semiconductor Private Limited
//202AC5 Petite-En
//A8BF3C", "HDV Phoelectron Technology Limited
//D4F527 SIEMENS AG
//B8B2F8", "Apple, Inc.
//98460A Apple, Inc.
//B85D0A Apple, Inc.
//7C9A1D Apple, Inc.
//103025, "Apple, Inc.
//70ACD7 Shenzhen YOUHUA Technology Co., Ltd
//5462E2, "Apple, Inc.
//149D99, "Apple, Inc.
//147BAC Nokia
//906D05, "BXB ELECTRONICS CO., LTD
//D4BBC8", "vivo Mobile Communication Co., Ltd.
//489507, "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//24BF74 Private
//CCDC55 Dragonchip Limited
//A4C3F0", "Intel Corporate
//28FFB2 Toshiba Corp.
//1C60D2 Fiberhome Telecommunication Technologies Co., LTD
//F4B5AA", "zte corporation
//E8ACAD zte corporation
//0836C9 NETGEAR
//745BC5 IEEE Registration Authority
//9440C9 Hewlett Packard Enterprise
//A041A7 NL Ministry of Defense
//E446DA", "Xiaomi Communications Co Ltd
//1C12B0 Amazon Technologies Inc.
//4CC8A1 Cisco Meraki
//4CBC98 IEEE Registration Authority
//2CF432 Espressif Inc.
//647366, "Shenzhen Siera Technology Ltd
//041EFA BISSELL Homecare, Inc.
//D85575 Samsung Electronics Co., Ltd
//D411A3", "Samsung Electronics Co., Ltd
//04BA8D Samsung Electronics Co., Ltd
//744D28, "Routerboard.com
//A41162", "Arlo Technology
//00A085 Private
//E05A9F IEEE Registration Authority
//8C5AF8 Beijing Xiaomi Electronics Co., Ltd.
//D45800 Fiberhome Telecommunication Technologies Co., LTD
//90842B LEGO System A/S
//00267E, "PARROT SA
//2C557C Shenzhen YOUHUA Technology Co., Ltd
//F4BCDA", "Shenzhen Jingxun Software Telecommunication Technology Co., Ltd
//000915, "CAS Corp.
//58D9C3 Motorola Mobility LLC, a Lenovo Company
//2C73A0 Cisco Systems, Inc
//443E07, "Electrolux
//8485E6, "Guangdong Asano Technology CO., Ltd.
//3C8375 Microsoft Corporation
//000AA8 ePipe Pty.Ltd.
//0029C2 Cisco Systems, Inc
//187C0B Ruckus Wireless
//D47B35", "NEO Monitors AS
//000878, "Benchmark Storage Innovations
//6CF37F Aruba, a Hewlett Packard Enterprise Company
//140708, "Private
//78A7EB", "1MORE
//485D36, "Verizon
//20C047 Verizon
//346B46 Sagemcom Broadband SAS
//7C604A Avelon
//186472, "Aruba, a Hewlett Packard Enterprise Company
//84D47E, "Aruba, a Hewlett Packard Enterprise Company
//24DEC6 Aruba, a Hewlett Packard Enterprise Company
//0017A0 RoboTech srl
//103D0A Hui Zhou Gaoshengda Technology Co., LTD
//942790, "TCT mobile ltd
//A41791", "Shenzhen Decnta Technology Co., LTD.
//34DAB7 zte corporation
//109C70 Prusa Research s.r.o.
//E84C56 INTERCEPT SERVICES LIMITED
//A41908 Fiberhome Telecommunication Technologies Co., LTD
//38AFD0 Private
//80D336, "CERN
//64255E, "Observint Technologies, Inc.
//90940A Analog Devices, Inc
//40B076 ASUSTek COMPUTER INC.
//D43D39 Dialog Semiconductor
//0014A5 Gemtek Technology Co., Ltd.
//C0B5D7 CHONGQING FUGUI ELECTRONICS CO., LTD.
//D4AD71 Cisco Systems, Inc
//702B1D E-Domus International Limited
//F085C1", "SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//60380E, "ALPS ELECTRIC CO., LTD.
//FC62B9 ALPS ELECTRIC CO., LTD.
//0002C7 ALPS ELECTRIC CO., LTD.
//001E3D, "ALPS ELECTRIC CO., LTD.
//28A183 ALPS ELECTRIC CO., LTD.
//4CDD7D LHP Telematics LLC
//48F07B ALPS ELECTRIC CO., LTD.
//B8BC5B Samsung Electronics Co., Ltd
//108EBA Molekule
//4C218C Panasonic India Private limited
//2C4E7D Chunghua Intelligent Network Equipment Inc.
//A4F465 ITEL MOBILE LIMITED
//4C917A IEEE Registration Authority
//F48CEB D-Link International
//743A65 NEC Corporation
//00255C NEC Corporation
//684F64, "Dell Inc.
//CC70ED Cisco Systems, Inc
//907E30, "LARS
//84EB3E Vivint Smart Home
//00A0D5 Sierra Wireless
//18BB26 FN-LINK TECHNOLOGY LIMITED
//18B905 Hong Kong Bouffalo Lab Limited
//ECF0FE zte corporation
//94A40C Diehl Metering GmbH
//70B317 Cisco Systems, Inc
//B00247", "AMPAK Technology, Inc.
//BCE796 Wireless CCTV Ltd
//948FCF ARRIS Group, Inc.
//A8F5DD ARRIS Group, Inc.
//44D3AD Shenzhen TINNO Mobile Technology Corp.
//9C8275 Yichip Microelectronics (Hangzhou) Co., Ltd
//5CCBCA FUJIAN STAR-NET COMMUNICATION CO., LTD
//28E98E Mitsubishi Electric Corporation
//34F8E7, "Cisco Systems, Inc
//B0907E", "Cisco Systems, Inc
//2C7360 Earda Technologies co Ltd
//508CF5 China Mobile Group Device Co., Ltd.
//1C549E Universal Electronics, Inc.
//E4CA12 zte corporation
//D49E05", "zte corporation
//585FF6 zte corporation
//40B30E Integrated Device Technology (Malaysia) Sdn. Bhd.
//04CE7E NXP France Semiconductors France
//C09AD0", "Apple, Inc.
//94B01F Apple, Inc.
//98CC4D Shenzhen mantunsci co., LTD
//C01B23", "SICHUAN TIANYI COMHEART TELECOM CO., LTD
//B8C74A", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//D8CE3A", "Xiaomi Communications Co Ltd
//102C6B AMPAK Technology, Inc.
//7485C4 New H3C Technologies Co., Ltd
//94F6D6, "Apple, Inc.
//F82D7C Apple, Inc.
//D0BAE4 Shanghai MXCHIP Information Technology Co., Ltd.
//48D35D, "Private
//80FBF0 Quectel Wireless Solutions Co., Ltd.
//C0132B Sichuan Changhong Electric Ltd.
//0CB4A4 Xintai Automobile Intelligent Network Technology
//90633B Samsung Electronics Co., Ltd
//FCAAB6", "Samsung Electronics Co., Ltd
//C82E47", "Suzhou SmartChip Semiconductor Co., LTD
//C02250", "Koss Corporation
//A0B549 Arcadyan Corporation
//001F5A Beckwith Electric Co.
//985D82, "Arista Networks
//2453BF Enernet
//043385, "Nanchang BlackShark Co., Ltd.
//84E5D8, "Guangdong UNIPOE IoT Technology Co., Ltd.
//A8BC9C Cloud Light Technology Limited
//A89042", "Beijing Wanwei Intelligent Technology Co., Ltd.
//18BE92 Delta Networks, Inc.
//90C54A vivo Mobile Communication Co., Ltd.
//BC7596 Beijing Broadwit Technology Co., Ltd.
//1C34DA Mellanox Technologies, Inc.
//2CA02F Veroguard Systems Pty Ltd
//6C5C3D IEEE Registration Authority
//782327, "Samsung Electronics Co., Ltd
//DCF756", "Samsung Electronics Co., Ltd
//68A47D Sun Cupid Technology (HK) LTD
//184B0D Ruckus Wireless
//D41243", "AMPAK Technology, Inc.
//48A6B8 Sonos, Inc.
//B87826 Nintendo Co., Ltd
//5076AF Intel Corporate
//DCCBA8", "Explora Technologies Inc
//C07878", "FLEXTRONICS MANUFACTURING(ZHUHAI) CO., LTD.
//E4B97A Dell Inc.
//001636, "QUANTA COMPUTER INC.
//34DAC1 SAE Technologies Development(Dongguan) Co., Ltd.
//705DCC EFM Networks
//D092FA", "Fiberhome Telecommunication Technologies Co., LTD
//E85AD1", "Fiberhome Telecommunication Technologies Co., LTD
//A823FE", "LG Electronics
//E05D5C Oy Everon Ab
//688F2E, "Hitron Technologies. Inc
//E046E5", "Gosuncn Technology Group Co., Ltd.
//1C599B HUAWEI TECHNOLOGIES CO., LTD
//D4BD1E, "5VT Technologies, Taiwan LTd.
//BC9B68 Technicolor CH USA Inc.
//CCD4A1 MitraStar Technology Corp.
//08BA5F Qingdao Hisense Electronics Co., Ltd.
//10DFFC Siemens AG
//847F3D, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//C4FDE6 DRTECH
//CC988B SONY Visual Products Inc.
//30E3D6, "Spotify USA Inc.
//9CA525 Shandong USR IOT Technology Limited
//787D53, "Aerohive Networks Inc.
//E0456D China Mobile Group Device Co., Ltd.
//283926, "CyberTAN Technology Inc.
//8CFCA0 Shenzhen Smart Device Technology Co., LTD.
//1C427D GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//806933, "HUAWEI TECHNOLOGIES CO., LTD
//BC26C7", "Cisco Systems, Inc
//BC5EA1", "PsiKick, Inc.
//944F4C Sound United LLC
//981888, "Cisco Meraki
//18810E, "Apple, Inc.
//608C4A Apple, Inc.
//74B587 Apple, Inc.
//FCB6D8 Apple, Inc.
//3C6A2C IEEE Registration Authority
//241B7A Apple, Inc.
//8CFE57 Apple, Inc.
//C0A600 Apple, Inc.
//18E829, "Ubiquiti Networks Inc.
//E0C286 Aisai Communication Technology Co., Ltd.
//7405A5 TP-LINK TECHNOLOGIES CO., LTD.
//286DCD Beijing Winner Microelectronics Co., Ltd.
//541031, "SMARTO
//44A466 GROUPE LDLC
//D80D17", "TP-LINK TECHNOLOGIES CO., LTD.
//18C2BF BUFFALO.INC
//E81CBA", "Fortinet, Inc.
//F0B014 AVM Audiovisuelles Marketing und Computersysteme GmbH
//1889A0 Wuhan Funshion Online Technologies Co., Ltd
//0C2A86 Fiberhome Telecommunication Technologies Co., LTD
//FC61E9", "Fiberhome Telecommunication Technologies Co., LTD
//405662, "GuoTengShengHua Electronics LTD.
//E4DB6D Beijing Xiaomi Electronics Co., Ltd.
//00A0D1 INVENTEC CORPORATION
//0018CC AXIOHM SAS
//001827, "NEC UNIFIED SOLUTIONS NEDERLAND B.V.
//009004, "3COM EUROPE LTD
//00068C", "3COM
//02608C", "3COM
//00D0D8, "3COM
//18937F, "AMPAK Technology, Inc.
//A43523 Guangdong Donyan Network Technologies Co., Ltd.
//B4A94F MERCURY CORPORATION
//803AF4 Fiberhome Telecommunication Technologies Co., LTD
//48A0F8 Fiberhome Telecommunication Technologies Co., LTD
//F85E3C", "SHENZHEN ZHIBOTONG ELECTRONICS CO., LTD
//283E76, "Common Networks
//DC3979 Cisco Systems, Inc
//58D56E, "D-Link International
//0C5331 ETH Zurich
//DC9088", "HUAWEI TECHNOLOGIES CO., LTD
//54812D, "PAX Computer Technology(Shenzhen) Ltd.
//0C9A42 FN-LINK TECHNOLOGY LIMITED
//000809, "Systemonic AG
//8C41F4 IPmotion GmbH
//704F08, "Shenzhen Huisheng Information Technology Co., Ltd.
//8835C1 OI ELECTRIC CO., LTD
//3042A1 ilumisys Inc.DBA Toggled
//0026B7 Kingston Technology Company, Inc.
//28D0CB Cambridge Communication Systems Ltd
//44657F, "Calix Inc.
//4062EA China Mobile Group Device Co., Ltd.
//4C0FC7 Earda Technologies co Ltd
//80A796 Neurotek LLC
//CC2119", "Samsung Electronics Co., Ltd
//302303, "Belkin International Inc.
//9CF6DD IEEE Registration Authority
//001E80, "Icotera A/S
//48881E, "EthoSwitch LLC
//3C71BF Espressif Inc.
//000393, "Apple, Inc.
//0000C3 Harris Corporation
//304B07 Motorola Mobility LLC, a Lenovo Company
//345ABA tcloud intelligence
//502FA8 Cisco Systems, Inc
//B46921", "Intel Corporate
//902BD2 HUAWEI TECHNOLOGIES CO., LTD
//08D59D, "Sagemcom Broadband SAS
//C08359", "IEEE Registration Authority
//EC83D5", "GIRD Systems Inc
//14942F, "USYS CO., LTD.
//FCB10D Shenzhen Tian Kun Technology Co., LTD.
//20F77C vivo Mobile Communication Co., Ltd.
//001EEC COMPAL INFORMATION (KUNSHAN) CO., LTD.
//F0761C COMPAL INFORMATION (KUNSHAN) CO., LTD.
//0004AE Sullair Corporation
//00451D, "Cisco Systems, Inc
//A0D635", "WBS Technology
//34800D, "Cavium Inc
//B44BD6 IEEE Registration Authority
//D8912A Zyxel Communications Corporation
//3C427E IEEE Registration Authority
//000BA3 Siemens AG
//000C8A Bose Corporation
//243A82 IRTS
//880907, "MKT Systemtechnik GmbH & Co.KG
//58A48E PixArt Imaging Inc.
//30D659, "Merging Technologies SA
//702AD5 Samsung Electronics Co., Ltd
//889765, "exands
//386E88, "zte corporation
//B88584 Dell Inc.
//40EEDD HUAWEI TECHNOLOGIES CO., LTD
//B01886", "SmarDTV
//AC751D", "HUAWEI TECHNOLOGIES CO., LTD
//289E97, "HUAWEI TECHNOLOGIES CO., LTD
//001525, "Chamberlain Access Solutions
//001EB0 ImesD Electronica S.L.
//641C67 DIGIBRAS INDUSTRIA DO BRASILS/A
//60058A Hitachi Metals, Ltd.
//BC22FB RF Industries
//0080B6 Mercury Systems – Trusted Mission Solutions, Inc.
//08512E, "Orion Diagnostica Oy
//98A404 Ericsson AB
//00CC3F Universal Electronics, Inc.
//74B91E Nanjing Bestway Automation System Co., Ltd
//A019B2", "IEEE Registration Authority
//8C15C7 HUAWEI TECHNOLOGIES CO., LTD
//60FA9D HUAWEI TECHNOLOGIES CO., LTD
//DC9914", "HUAWEI TECHNOLOGIES CO., LTD
//4C3FD3 Texas Instruments
//B05365", "China Mobile IOT Company Limited
//308841, "Sichuan AI-Link Technology Co., Ltd.
//44EFCF UGENE SOLUTION inc.
//304596, "HUAWEI TECHNOLOGIES CO., LTD
//C0F4E6", "HUAWEI TECHNOLOGIES CO., LTD
//74EB80 Samsung Electronics Co., Ltd
//0CE0DC Samsung Electronics Co., Ltd
//D868C3", "Samsung Electronics Co., Ltd
//C493D9", "Samsung Electronics Co., Ltd
//A82BB9", "Samsung Electronics Co., Ltd
//ACFD93", "WEIFANG GOERTEK ELECTRONICS CO., LTD
//68572D, "HANGZHOU AIXIANGJI TECHNOLOGY CO., LTD
//00B8C2 Heights Telecom T ltd
//F4BF80", "HUAWEI TECHNOLOGIES CO., LTD
//000E8F, "Sercomm Corporation.
//A0E617 MATIS
//7001B5 Cisco Systems, Inc
//001F49, "Manhattan TV Ltd
//88D652, "AMERGINT Technologies
//FC90FA Independent Technologies
//D0B214", "PoeWit Inc
//C42456 Palo Alto Networks
//B4B686 Hewlett Packard
//4CEDFB ASUSTek COMPUTER INC.
//7C2EBD Google, Inc.
//6CAF15 Webasto SE
//E4E130", "TCT mobile ltd
//0C2138 Hengstler GmbH
//E46059", "Pingtek Co., Ltd.
//E0191D HUAWEI TECHNOLOGIES CO., LTD
//68D1BA Shenzhen YOUHUA Technology Co., Ltd
//1C1AC0 Apple, Inc.
//3078C2 Innowireless / QUCELL Networks
//4050B5 Shenzhen New Species Technology Co., Ltd.
//3C15FB HUAWEI TECHNOLOGIES CO., LTD
//CC934A", "Sierra Wireless
//00CFC0 China Mobile Group Device Co., Ltd.
//DC330D QING DAO HAIER TELECOM CO., LTD.
//688975, "nuoxc
//40F04E, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//0021F2, "EASY3CALL Technology Limited
//0015C4 FLOVEL CO., LTD.
//0011E6, "Scientific Atlanta
//24F128, "Telstra
//E0383F", "zte corporation
//D47226 zte corporation
//40831D, "Apple, Inc.
//DCD3A2 Apple, Inc.
//5C1DD9 Apple, Inc.
//800588, "Ruijie Networks Co., LTD
//F00E1D", "Megafone Limited
//88AE07 Apple, Inc.
//68FEF7 Apple, Inc.
//AC35EE FN-LINK TECHNOLOGY LIMITED
//881196, "HUAWEI TECHNOLOGIES CO., LTD
//E40EEE", "HUAWEI TECHNOLOGIES CO., LTD
//28D997, "Yuduan Mobile Co., Ltd.
//301F9A IEEE Registration Authority
//0C2C54 HUAWEI TECHNOLOGIES CO., LTD
//D4C19E", "Ruckus Wireless
//70695A Cisco Systems, Inc
//00BF77 Cisco Systems, Inc
//D07714", "Motorola Mobility LLC, a Lenovo Company
//30B7D4 Hitron Technologies.Inc
//B481BF", "Meta-Networks, LLC
//946AB0 Arcadyan Corporation
//4818FA Nocsys
//587A6A GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//A038F8", "OURA Health Oy
//687924, "ELS-GmbH & Co.KG
//28FD80 IEEE Registration Authority
//0CAE7D Texas Instruments
//304511, "Texas Instruments
//E81AAC ORFEO SOUNDWORKS Inc.
//000758, "DragonWave Inc.
//F0FCC8 ARRIS Group, Inc.
//F8DF15 Sunitec Enterprise Co., Ltd
//001DB5 Juniper Networks
//B02680", "Cisco Systems, Inc
//D49398", "Nokia Corporation
//001937, "CommerceGuard AB
//FC7C02 Phicomm (Shanghai) Co., Ltd.
//A8610A ARDUINO AG
//6097DD MicroSys Electronics GmbH
//047970, "HUAWEI TECHNOLOGIES CO., LTD
//A057E3", "HUAWEI TECHNOLOGIES CO., LTD
//1CB044 ASKEY COMPUTER CORP
//AC17C8 Cisco Meraki
//F4844C", "Texas Instruments
//38DEAD Intel Corporate
//D46D6D", "Intel Corporate
//B4F2E8 ARRIS Group, Inc.
//3C574F China Mobile Group Device Co., Ltd.
//D49CF4 Palo Alto Networks
//8C1645 LCFC(HeFei) Electronics Technology co., ltd
//689861, "Beacon Inc
//609813, "Shanghai Visking Digital Technology Co.LTD
//506B4B Mellanox Technologies, Inc.
//B41C30 zte corporation
//705AAC Samsung Electronics Co., Ltd
//2C9569 ARRIS Group, Inc.
//A039EE Sagemcom Broadband SAS
//E4CB59 Beijing Loveair Science and Technology Co.Ltd.
//B4E62D Espressif Inc.
//847460, "zte corporation
//4C82CF Dish Technologies Corp
//285767, "Dish Technologies Corp
//70169F, "EtherCAT Technology Group
//68EF43, "Apple, Inc.
//D02B20 Apple, Inc.
//2C61F6 Apple, Inc.
//D4A33D Apple, Inc.
//F0766F Apple, Inc.
//4098AD Apple, Inc.
//6C4D73 Apple, Inc.
//1CA0B8 Hon Hai Precision Ind.Co., Ltd.
//D88466 Extreme Networks, Inc.
//000496, "Extreme Networks, Inc.
//00E02B Extreme Networks, Inc.
//5C0E8B Extreme Networks, Inc.
//7467F7, "Extreme Networks, Inc.
//E43022 Hanwha Techwin Security Vietnam
//044F17, "HUMAX Co., Ltd.
//5C4A1F SICHUAN TIANYI COMHEART TELECOMCO., LTD
//E48F34", "Vodafone Italia S.p.A.
//685ACF Samsung Electronics Co., Ltd
//0CA8A7 Samsung Electronics Co., Ltd
//B0672F", "Bowers & Wilkins
//10CD6E FISYS
//D86375 Xiaomi Communications Co Ltd
//D89C67", "Hon Hai Precision Ind. Co., Ltd.
//64209F, "Tilgin AB
//A43E51 ANOV FRANCE
//702605, "SONY Visual Products Inc.
//0090F1, "Seagate Cloud Systems Inc
//845A81 ffly4u
//CC81DA Phicomm (Shanghai) Co., Ltd.
//00806C Secure Systems & Services
//007263, "Netcore Technology Inc.
//1C27DD Datang Gohighsec(zhejiang) Information Technology Co., Ltd.
//B8C8EB ITEL MOBILE LIMITED
//80C5F2 AzureWave Technology Inc.
//64F88A China Mobile IOT Company Limited
//68DB54 Phicomm (Shanghai) Co., Ltd.
//B45253 Seagate Technology
//0011C6 Seagate Technology
//001D38, "Seagate Technology
//005013, "Seagate Cloud Systems Inc
//C8DF84 Texas Instruments
//240D6C SMND
//48555C Wu Qi Technologies, Inc.
//18F0E4, "Xiaomi Communications Co Ltd
//588A5A Dell Inc.
//9C8C6E Samsung Electronics Co., Ltd
//DC4F22", "Espressif Inc.
//F86CE1 Taicang T&W Electronics
//1C7328 Connected Home
//D8E004", "Vodia Networks Inc
//2CFDAB Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//30B4B8 LG Electronics
//380E4D, "Cisco Systems, Inc
//3873EA IEEE Registration Authority
//4C5262 Fujitsu Technology Solutions GmbH
//803BF6 LOOK EASY INTERNATIONAL LIMITED
//30EB1F Skylab M&C Technology Co., Ltd
//549A4C GUANGDONG HOMECARE TECHNOLOGY CO., LTD.
//EC1D8B Cisco Systems, Inc
//EC7097", "ARRIS Group, Inc.
//5819F8, "ARRIS Group, Inc.
//D07FC4 Ou Wei Technology Co.，Ltd.of Shenzhen City
//1479F3, "China Mobile Group Device Co., Ltd.
//0CCEF6 Guizhou Fortuneship Technology Co., Ltd
//1806FF Acer Computer(Shanghai) Limited.
//C4CD82 Hangzhou Lowan Information Technology Co., Ltd.
//30FB94 Shanghai Fangzhiwei Information Technology CO., Ltd.
//0023A0 Hana CNS Co., LTD.
//F406A5 Hangzhou Bianfeng Networking Technology Co., Ltd.
//A4B52E Integrated Device Technology (Malaysia) Sdn. Bhd.
//3CA581 vivo Mobile Communication Co., Ltd.
//34E911, "vivo Mobile Communication Co., Ltd.
//64CBA3 Pointmobile
//ECFABC Espressif Inc.
//08BA22 Swaive Corporation
//28C13C Hon Hai Precision Ind.Co., Ltd.
//B0ECE1 Private
//60E78A UNISEM
//F8F21E Intel Corporate
//282986, "APC by Schneider Electric
//707DB9 Cisco Systems, Inc
//08BEAC Edimax Technology Co. Ltd.
//248BE0 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//002424, "Ace Axis Limited
//50C9A0 SKIPPER AS
//7483EF, "Arista Networks
//00E0F6, "DECISION EUROPE
//CC2DE0 Routerboard.com
//00BF61 Samsung Electronics Co., Ltd
//7867D7, "Apple, Inc.
//B8C111 Apple, Inc.
//1046B4 FormericaOE
//9CE33F Apple, Inc.
//386B1C SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//DC5583 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//001248, "Dell EMC
//006048, "Dell EMC
//7CC95A Dell EMC
//D00401", "Motorola Mobility LLC, a Lenovo Company
//742857, "Mayfield Robotics
//589043, "Sagemcom Broadband SAS
//2856C1 Harman International
//B4A382", "Hangzhou Hikvision Digital Technology Co., Ltd.
//9C9C40 SICHUAN TIANYI COMHEART TELECOMCO., LTD
//A407B6", "Samsung Electronics Co., Ltd
//40498A Synapticon GmbH
//389D92, "Seiko Epson Corporation
//24E124, "Xiamen Ursaconn Technology Co. , Ltd.
//8C0F83 Angie Hospitality LLC
//DC68EB Nintendo Co., Ltd
//E8361D", "Sense Labs, Inc.
//087808, "Samsung Electronics Co., Ltd
//887598, "Samsung Electronics Co., Ltd
//C0174D", "Samsung Electronics Co., Ltd
//20F19E, "ARRIS Group, Inc.
//C89F42 VDII Innovation AB
//7091F3, "Universal Electronics, Inc.
//080069, "Silicon Graphics
//002291, "Cisco Systems, Inc
//10FCB6 mirusystems CO., LTD
//04D6AA SAMSUNG ELECTRO-MECHANICS(THAILAND)
//50A83A S Mobile Devices Limited
//6405E9, "Shenzhen WayOS Technology Crop., Ltd.
//A07099 Beijing Huacan Electronics Co., Ltd
//48D6D5, "Google, Inc.
//0C5842 DME Micro
//B810D4", "Masimo Corporation
//BC825D MITSUMI ELECTRIC CO., LTD.
//D0666D Shenzhen Bus-Lan Technology Co., Ltd.
//08152F, "Samsung Electronics Co., Ltd.ARTIK
//F4F5DB", "Xiaomi Communications Co Ltd
//F4E204 Traqueur
//CC2237 IEEE Registration Authority
//38D620, "Limidea Concept Pte.Ltd.
//74F91A Onface
//A434F1 Texas Instruments
//186024, "Hewlett Packard
//BC3D85 HUAWEI TECHNOLOGIES CO., LTD
//2054FA HUAWEI TECHNOLOGIES CO., LTD
//38378B HUAWEI TECHNOLOGIES CO., LTD
//745C4B GN Audio A/S
//00149D, "Sound ID Inc.
//A8E824 INIM ELECTRONICS S.R.L.
//104963, "HARTING K.K.
//8CD48E ITEL MOBILE LIMITED
//642B8A ALL BEST Industrial Co., Ltd.
//B8EE0E Sagemcom Broadband SAS
//ECD09F Xiaomi Communications Co Ltd
//78E103, "Amazon Technologies Inc.
//000659, "EAL (Apeldoorn) B.V.
//78A6E1 Brocade Communications Systems, Inc.
//E4EC10 Nokia Corporation
//002692, "Mitsubishi Electric Corporation
//8CC121 Panasonic Corporation AVC Networks Company
//EC0441 ShenZhen TIGO Semiconductor Co., Ltd.
//ACBE75 Ufine Technologies Co., Ltd.
//00C08F Panasonic Electric Works Co., Ltd.
//B0350B MOBIWIRE MOBILES (NINGBO) CO., LTD
//28A6AC seca gmbh & co.kg
//A8BE27", "Apple, Inc.
//C0A53E Apple, Inc.
//444E6D, "AVM Audiovisuelles Marketing und Computersysteme GmbH
//90B1E0 Beijing Nebula Link Technology Co., Ltd
//6C090A GEMATICA SRL
//70E1FD FLEXTRONICS
//74E60F, "TECNO MOBILE LIMITED
//001AA7 Torian Wireless
//0CB459 Marketech International Corp.
//8014A8 Guangzhou V-SOLUTION Electronic Technology Co., Ltd.
//409BCD D-Link International
//002EC7 HUAWEI TECHNOLOGIES CO., LTD
//488EEF HUAWEI TECHNOLOGIES CO., LTD
//547595, "TP-LINK TECHNOLOGIES CO., LTD.
//C47154 TP-LINK TECHNOLOGIES CO., LTD.
//586163, "Quantum Networks (SG) Pte. Ltd.
//EC3DFD SHENZHEN BILIAN ELECTRONIC CO.，LTD
//94D029, "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//308454, "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//5C0339 HUAWEI TECHNOLOGIES CO., LTD
//F82819", "Liteon Technology Corporation
//0015E5, "Cheertek Inc.
//50E971, "Jibo, Inc.
//30F77F, "S Mobile Devices Limited
//D86C63 Google, Inc.
//0840F3, "Tenda Technology Co., Ltd.Dongguan branch
//94FBB2 SHENZHEN GONGJIN ELECTRONICS CO., LT
//001E99, "Vantanol Industrial Corporation
//58B633 Ruckus Wireless
//5C5181 Samsung Electronics Co., Ltd
//608E08, "Samsung Electronics Co., Ltd
//543D37, "Ruckus Wireless
//2CE6CC Ruckus Wireless
//00227F, "Ruckus Wireless
//74911A Ruckus Wireless
//00C05D L&N TECHNOLOGIES
//58C583 ITEL MOBILE LIMITED
//18204C Kummler+Matter AG
//18D225, "Fiberhome Telecommunication Technologies Co., LTD
//18B430 Nest Labs Inc.
//30B164 Power Electronics International Inc.
//F88A3C IEEE Registration Authority
//A40450 nFore Technology Inc.
//001B17 Palo Alto Networks
//58493B Palo Alto Networks
//786D94, "Palo Alto Networks
//FC5A1D", "Hitron Technologies. Inc
//94147A vivo Mobile Communication Co., Ltd.
//3817E1, "Technicolor CH USA Inc.
//9828A6 COMPAL INFORMATION (KUNSHAN) CO., LTD.
//943FC2 Hewlett Packard Enterprise
//681DEF Shenzhen CYX Technology Co., Ltd.
//B40016 INGENICO TERMINALS SAS
//AC203E Wuhan Tianyu Information Industry Co., Ltd.
//B01F29 Helvetia INC.
//880F10, "Huami Information Technology Co., Ltd.
//14612F, "Avaya Inc
//00309D, "Nimble Microsystems, Inc.
//8C210A TP-LINK TECHNOLOGIES CO., LTD.
//4C189A GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//CC4B73", "AMPAK Technology, Inc.
//0015DC KT&C Co., Ltd.
//00187D, "Armorlink Co .Ltd
//F430B9", "Hewlett Packard
//0019F0, "UNIONMAN TECHNOLOGY CO., LTD
//C8DB26", "Logitech
//A40E2B", "Facebook Inc
//AC4E2E Shenzhen JingHanDa Electronics Co.Ltd
//4C910C Lanix Internacional, S.A.de C.V.
//A47886 Avaya Inc
//0403D6, "Nintendo Co., Ltd
//5C1A6F Cambridge Industries(Group) Co., Ltd.
//3C4CD0 CERAGON NETWORKS
//F40E83", "ARRIS Group, Inc.
//98F7D7, "ARRIS Group, Inc.
//B4BFF6 Samsung Electronics Co., Ltd
//2C3AE8 Espressif Inc.
//88BD78 Flaircomm Microelectronics, Inc.
//58C5CB Samsung Electronics Co., Ltd
//206BE7 TP-LINK TECHNOLOGIES CO., LTD.
//182CB4 Nectarsoft Co., Ltd.
//54C9DF FN-LINK TECHNOLOGY LIMITED
//74F61C HTC Corporation
//B8FFB3", "MitraStar Technology Corp.
//EC237B zte corporation
//A0C9A0", "Murata Manufacturing Co., Ltd.
//982DBA Fibergate Inc.
//84C0EF Samsung Electronics Co., Ltd
//00A38E Cisco Systems, Inc
//E0D55E", "GIGA-BYTE TECHNOLOGY CO., LTD.
//A040A0 NETGEAR
//000D2B Racal Instruments
//004066, "APRESIA Systems Ltd
//48A74E zte corporation
//BC8AE8", "QING DAO HAIER TELECOM CO., LTD.
//F4DE0C ESPOD Ltd.
//3C5282 Hewlett Packard
//08ED02, "IEEE Registration Authority
//E8FDE8", "CeLa Link Corporation
//28C63F Intel Corporate
//88CC45 Skyworth Digital Technology(Shenzhen) Co., Ltd
//600837, "ivvi Scientific(Nanchang) Co.Ltd
//EC363F", "Markov Corporation
//5804CB Tianjin Huisun Technology Co., Ltd.
//60D7E3, "IEEE Registration Authority
//1893D7, "Texas Instruments
//A8B86E LG Electronics (Mobile Communications)
//CC90E8", "Shenzhen YOUHUA Technology Co., Ltd
//7C4F7D Sawwave
//9CAC6D Universal Electronics, Inc.
//08EA40 SHENZHEN BILIAN ELECTRONIC CO.，LTD
//00D095, "Alcatel-Lucent Enterprise
//0020DA Alcatel-Lucent Enterprise
//6C5976 Shanghai Tricheer Technology Co., Ltd.
//7C7B8B Control Concepts, Inc.
//84A9C4 HUAWEI TECHNOLOGIES CO., LTD
//A0086F", "HUAWEI TECHNOLOGIES CO., LTD
//34CE00 XIAOMI Electronics, CO., LTD
//D06F82", "HUAWEI TECHNOLOGIES CO., LTD
//A0F479", "HUAWEI TECHNOLOGIES CO., LTD
//844765, "HUAWEI TECHNOLOGIES CO., LTD
//C4FF1F", "HUAWEI TECHNOLOGIES CO., LTD
//A0C4A5", "SYGN HOUSE CO., LTD
//B83765", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//345BBB GD Midea Air-Conditioning Equipment Co., Ltd.
//C40BCB Xiaomi Communications Co Ltd
//84AFEC BUFFALO.INC
//5CC6E9 Edifier International
//98DDEA Infinix mobility limited
//001D44, "Krohne
//A8A198", "TCT mobile ltd
//E0C0D1", "CK Telecom (Shenzhen) Limited
//00219E, "Sony Mobile Communications Inc
//ACB57D Liteon Technology Corporation
//D4619D Apple, Inc.
//D0498B ZOOM SERVER
//0827CE NAGANO KEIKI CO., LTD.
//C0D3C0 Samsung Electronics Co., Ltd
//948BC1 Samsung Electronics Co., Ltd
//14568E, "Samsung Electronics Co., Ltd
//14BD61 Apple, Inc.
//54E061, "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//503A7D AlphaTech PLC Int’l Co., Ltd.
//F4C4D6 Shenzhen Xinfa Electronic Co., ltd
//6837E9, "Amazon Technologies Inc.
//2CA17D ARRIS Group, Inc.
//D83214 Tenda Technology Co., Ltd.Dongguan branch
//10954B Megabyte Ltd.
//D8325A Shenzhen YOUHUA Technology Co., Ltd
//9CDA3E Intel Corporate
//283F69, "Sony Mobile Communications Inc
//002CC8 Cisco Systems, Inc
//C0028D", "WINSTAR Display CO., Ltd
//E89FEC", "CHENGDU KT ELECTRONIC HI-TECH CO., LTD
//802689, "D-Link International
//F8AB05 Sagemcom Broadband SAS
//7C5049 Apple, Inc.
//E47DEB Shanghai Notion Information Technology CO., LTD.
//C4B9CD Cisco Systems, Inc
//EC4F82", "Calix Inc.
//D461FE Hangzhou H3C Technologies Co., Limited
//2C4D54 ASUSTek COMPUTER INC.
//349672, "TP-LINK TECHNOLOGIES CO., LTD.
//64B473 Xiaomi Communications Co Ltd
//7451BA Xiaomi Communications Co Ltd
//6CB4A7 Landauer, Inc.
//7802F8, "Xiaomi Communications Co Ltd
//00238A Ciena Corporation
//001081, "DPS, INC.
//40F385, "IEEE Registration Authority
//887873, "Intel Corporate
//F87588 HUAWEI TECHNOLOGIES CO., LTD
//F44C7F", "HUAWEI TECHNOLOGIES CO., LTD
//28A24B Juniper Networks
//080027, "PCS Systemtechnik GmbH
//F8A5C5", "Cisco Systems, Inc
//7C5A1C Sophos Ltd
//B0F1EC", "AMPAK Technology, Inc.
//542B57 Night Owl SP
//501E2D, "StreamUnlimited Engineering GmbH
//E45D51", "SFR
//EC01EE", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//6049C1 Avaya Inc
//702084, "Hon Hai Precision Ind. Co., Ltd.
//9C6650 Glodio Technolies Co., Ltd Tianjin Branch
//A0A33B", "HUAWEI TECHNOLOGIES CO., LTD
//7C67A2 Intel Corporate
//00E05A GALEA NETWORK SECURITY
//48A380 Gionee Communication Equipment Co., Ltd.
//94652D, "OnePlus Technology (Shenzhen) Co., Ltd
//1CB857 Becon Technologies Co,.Ltd.
//682737, "Samsung Electronics Co., Ltd
//F06E32", "MICROTEL INNOVATION S.R.L.
//54C415 Hangzhou Hikvision Digital Technology Co., Ltd.
//3CF862 Intel Corporate
//2816AD Intel Corporate
//0060D3, "AT&T
//848DC7 Cisco SPVTG
//001992, "Adtran Inc
//045D4B Sony Corporation
//78AF58 GIMASI SA
//90505A unGlue, Inc
//8C9351 Jigowatts Inc.
//D838FC Ruckus Wireless
//3478D7, "Gionee Communication Equipment Co., Ltd.
//5CCCA0 Gridwiz Inc.
//6831FE Teladin Co., Ltd.
//5800E3, "Liteon Technology Corporation
//2C0BE9 Cisco Systems, Inc
//C43018", "MCS Logic Inc.
//D0FF98 HUAWEI TECHNOLOGIES CO., LTD
//B0E5ED", "HUAWEI TECHNOLOGIES CO., LTD
//C486E9", "HUAWEI TECHNOLOGIES CO., LTD
//000AE4 Wistron Corporation
//344B3D Fiberhome Telecommunication Technologies Co., LTD
//FC3CE9", "Tsingtong Technologies Co, Ltd.
//A408F5 Sagemcom Broadband SAS
//00B091 Transmeta Corp.
//ACC662 MitraStar Technology Corp.
//886B44 Sunnovo International Limited
//A4580F IEEE Registration Authority
//C8F733 Intel Corporate
//E0A700", "Verkada Inc
//58404E, "Apple, Inc.
//D0C5F3 Apple, Inc.
//BC9FEF Apple, Inc.
//20AB37 Apple, Inc.
//60F445, "Apple, Inc.
//48F97C Fiberhome Telecommunication Technologies Co., LTD
//40B93C Hewlett Packard Enterprise
//C0BFC0 HUAWEI TECHNOLOGIES CO., LTD
//9CD9CB Lesira Manufacturing Pty Ltd
//94E979, "Liteon Technology Corporation
//A03D6F", "Cisco Systems, Inc
//A0E0AF", "Cisco Systems, Inc
//187532, "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//4CB81C SAM Electronics GmbH
//003048, "Super Micro Computer, Inc.
//44D244, "Seiko Epson Corporation
//A08CF8", "HUAWEI TECHNOLOGIES CO., LTD
//7CF95C U.I.Lapp GmbH
//101331, "Technicolor
//A4E6B1", "Shanghai Joindata Technology Co., Ltd.
//C09C04 Shaanxi GuoLian Digital TV Technology Co., Ltd.
//ACD657 Shaanxi GuoLian Digital TV Technology Co., Ltd.
//007686, "Cisco Systems, Inc
//8C2FA6 Solid Optics B.V.
//8C192D IEEE Registration Authority
//00ACE0 ARRIS Group, Inc.
//007532, "INID BV
//6473E2, "Arbiter Systems, Inc.
//88C626 Logitech, Inc
//D0608C", "zte corporation
//AC233F Shenzhen Minew Technologies Co., Ltd.
//7C03C9 Shenzhen YOUHUA Technology Co., Ltd
//B8E937", "Sonos, Inc.
//E45D52 Avaya Inc
//0023F7, "Private
//3C80AA Ransnet Singapore Pte Ltd
//B49691", "Intel Corporate
//C82158 Intel Corporate
//7C95B1 Aerohive Networks Inc.
//2420C7 Sagemcom Broadband SAS
//D4C8B0 Prime Electronics & Satellitics Inc.
//446AB7 ARRIS Group, Inc.
//701CE7 Intel Corporate
//9C2A70 Hon Hai Precision Ind.Co., Ltd.
//703D15, "Hangzhou H3C Technologies Co., Limited
//E49E12", "FREEBOX SAS
//0481AE Clack Corporation
//9C13AB Chanson Water Co., Ltd.
//98E476, "Zentan
//14A51A HUAWEI TECHNOLOGIES CO., LTD
//047503, "HUAWEI TECHNOLOGIES CO., LTD
//3CEF8C Zhejiang Dahua Technology Co., Ltd.
//FC372B SICHUAN TIANYI COMHEART TELECOMCO., LTD
//A4D9A4", "neXus ID Solutions AB
//484D7E, "Dell Inc.
//D4E90B CVT CO., LTD
//CCB0DA", "Liteon Technology Corporation
//7CCC1F SICHUAN TIANYI COMHEART TELECOMCO., LTD
//18F292, "Shannon Systems
//8CEA1B Edgecore Networks Corporation
//E02CF3 MRS Electronic GmbH
//50B363 Digitron da Amazonia S/A
//2C0E3D SAMSUNG ELECTRO-MECHANICS(THAILAND)
//58E16C Ying Hua Information Technology (Shanghai) Co., LTD
//9C7DA3 HUAWEI TECHNOLOGIES CO., LTD
//A4C64F", "HUAWEI TECHNOLOGIES CO., LTD
//CCFD17", "TCT mobile ltd
//DC9FDB", "Ubiquiti Networks Inc.
//002722, "Ubiquiti Networks Inc.
//00156D, "Ubiquiti Networks Inc.
//00D78F, "Cisco Systems, Inc
//2CBABA Samsung Electronics Co., Ltd
//40D3AE Samsung Electronics Co., Ltd
//2CDD95 Taicang T&W Electronics
//88E87F, "Apple, Inc.
//9CF48E Apple, Inc.
//5CF7E6 Apple, Inc.
//B853AC Apple, Inc.
//203CAE Apple, Inc.
//A03BE3 Apple, Inc.
//4C3275 Apple, Inc.
//487A55 ALE International
//001EAE Continental Automotive Systems Inc.
//502B73 Tenda Technology Co., Ltd.Dongguan branch
//04BA36 Li Seng Technology Ltd
//107223, "TELLESCOM INDUSTRIA E COMERCIO EM TELECOMUNICACAO
//E0686D Raybased AB
//1861C7 lemonbeat GmbH
//9CDC71 Hewlett Packard Enterprise
//B4F81E Kinova
//D03DC3 AQ Corporation
//EC01E2", "FOXCONN INTERCONNECT TECHNOLOGY
//B4E782", "Vivalnk
//4409B8 Salcomp (Shenzhen) CO., LTD.
//3816D1, "Samsung Electronics Co., Ltd
//D0176A", "Samsung Electronics Co., Ltd
//D48890", "Samsung Electronics Co., Ltd
//5492BE Samsung Electronics Co., Ltd
//205D47, "vivo Mobile Communication Co., Ltd.
//10C60C Domino UK Ltd
//043110, "Inspur Group Co., Ltd.
//949AA9 Microsoft Corporation
//ACAB2E", "Beijing LasNubes Technology Co., Ltd.
//600B03 Hangzhou H3C Technologies Co., Limited
//A0AB1B", "D-Link International
//D842E2 Canary Connect, Inc.
//C8B21E CHIPSEA TECHNOLOGIES (SHENZHEN) CORP.
//000678, "D&M Holdings Inc.
//E0286D AVM Audiovisuelles Marketing und Computersysteme GmbH
//884CCF Pulzze Systems, Inc
//500959, "Technicolor CH USA Inc.
//E41218 ShenZhen Rapoo Technology Co., Ltd.
//001984, "ESTIC Corporation
//001628, "Magicard Ltd
//702E22, "zte corporation
//C8E776 PTCOM Technology
//000278, "SAMSUNG ELECTRO MECHANICS CO., LTD.
//002399, "Samsung Electronics Co., Ltd
//0017C9 Samsung Electronics Co., Ltd
//906EBB Hon Hai Precision Ind.Co., Ltd.
//18F46A Hon Hai Precision Ind.Co., Ltd.
//4C0F6E Hon Hai Precision Ind.Co., Ltd.
//78E400, "Hon Hai Precision Ind. Co., Ltd.
//00212F, "Phoebe Micro Inc.
//3859F9, "Hon Hai Precision Ind. Co., Ltd.
//EC55F9 Hon Hai Precision Ind.Co., Ltd.
//C4731E Samsung Electronics Co., Ltd
//5C0A5B SAMSUNG ELECTRO MECHANICS CO., LTD.
//7CE9D3 Hon Hai Precision Ind.Co., Ltd.
//1C3E84 Hon Hai Precision Ind.Co., Ltd.
//B8763F Hon Hai Precision Ind.Co., Ltd.
//60F494, "Hon Hai Precision Ind. Co., Ltd.
//8056F2, "Hon Hai Precision Ind. Co., Ltd.
//7CF854 Samsung Electronics Co., Ltd
//001B98 Samsung Electronics Co., Ltd
//001A8A Samsung Electronics Co., Ltd
//3C5A37 Samsung Electronics Co., Ltd
//F49F54", "Samsung Electronics Co., Ltd
//34C3AC Samsung Electronics Co., Ltd
//44F459, "Samsung Electronics Co., Ltd
//00265D, "Samsung Electronics Co., Ltd
//CCF9E8", "Samsung Electronics Co., Ltd
//D857EF", "Samsung Electronics Co., Ltd
//18E2C2 Samsung Electronics Co., Ltd
//9852B1 Samsung Electronics Co., Ltd
//E440E2", "Samsung Electronics Co., Ltd
//103B59 Samsung Electronics Co., Ltd
//D890E8", "Samsung Electronics Co., Ltd
//C462EA", "Samsung Electronics Co., Ltd
//14F42A Samsung Electronics Co., Ltd
//0808C2 Samsung Electronics Co., Ltd
//CCFE3C", "Samsung Electronics Co., Ltd
//28BAB5 Samsung Electronics Co., Ltd
//182666, "Samsung Electronics Co., Ltd
//30D6C9 Samsung Electronics Co., Ltd
//CC07AB", "Samsung Electronics Co., Ltd
//002567, "Samsung Electronics Co., Ltd
//BCB1F3", "Samsung Electronics Co., Ltd
//1C62B8 Samsung Electronics Co., Ltd
//B43A28", "Samsung Electronics Co., Ltd
//78A873 Samsung Electronics Co., Ltd
//001C43 Samsung Electronics Co., Ltd
//0023D6, "Samsung Electronics Co., Ltd
//E4121D", "Samsung Electronics Co., Ltd
//44D6E1, "Snuza International Pty.Ltd.
//FC9114 Technicolor CH USA Inc.
//486DBB Vestel Elektronik San ve Tic. A.Ş.
//002A10 Cisco Systems, Inc
//00A289 Cisco Systems, Inc
//44E9DD Sagemcom Broadband SAS
//000F5E, "Veo
//001328, "Westech Korea Inc.,
//B8BF83 Intel Corporate
//8C6102 Beijing Baofengmojing Technologies Co., Ltd
//548CA0 Liteon Technology Corporation
//7C79E8 PayRange Inc.
//A43111 ZIV
//008073, "DWB ASSOCIATES
//80A1D7 Shanghai DareGlobal Technologies Co., Ltd
//EC1F72", "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//8C0D76 HUAWEI TECHNOLOGIES CO., LTD
//84BE52 HUAWEI TECHNOLOGIES CO., LTD
//849FB5 HUAWEI TECHNOLOGIES CO., LTD
//A4CAA0", "HUAWEI TECHNOLOGIES CO., LTD
//84E0F4, "IEEE Registration Authority
//D83062", "Apple, Inc.
//D0E54D ARRIS Group, Inc.
//A0C562 ARRIS Group, Inc.
//8496D8, "ARRIS Group, Inc.
//0026D9, "ARRIS Group, Inc.
//E8508B SAMSUNG ELECTRO-MECHANICS(THAILAND)
//F8042E", "SAMSUNG ELECTRO-MECHANICS(THAILAND)
//00D037, "ARRIS Group, Inc.
//84E058, "ARRIS Group, Inc.
//707630, "ARRIS Group, Inc.
//04BBF9 Pavilion Data Systems Inc
//E4BEED", "Netcore Technology Inc.
//58FB84 Intel Corporate
//00A00E NetAlly
//00C017 NetAlly
//5CB066 ARRIS Group, Inc.
//BC8AA3 NHN Entertainment
//A8BD27", "Hewlett Packard Enterprise
//345760, "MitraStar Technology Corp.
//C0D391 IEEE Registration Authority
//D49B5C Chongqing Miedu Technology Co., Ltd.
//E8EB11 Texas Instruments
//44BFE3 Shenzhen Longtech Electronics Co., Ltd
//3C6FEA Panasonic India Pvt. Ltd.
//002261, "Frontier Silicon Ltd
//001988, "Wi2Wi, Inc
//18DC56 Yulong Computer Telecommunication Scientific (Shenzhen) Co., Ltd
//0016F2, "Dmobile System Co., Ltd.
//34074F, "AccelStor, Inc.
//B4A984 Symantec Corporation
//B0B28F", "Sagemcom Broadband SAS
//441441, "AudioControl Inc.
//C88D83 HUAWEI TECHNOLOGIES CO., LTD
//00E011, "UNIDEN CORPORATION
//002555, "Visonic Technologies 1993 Ltd.
//58986F, "Revolution Display
//C81FBE HUAWEI TECHNOLOGIES CO., LTD
//203DB2 HUAWEI TECHNOLOGIES CO., LTD
//48D539, "HUAWEI TECHNOLOGIES CO., LTD
//001F9A Nortel Networks
//000A0E Invivo Research Inc.
//001660, "Nortel Networks
//001E7E Nortel Networks
//001365, "Nortel Networks
//000438, "Nortel Networks
//000EC0 Nortel Networks
//D84FB8", "LG ELECTRONICS
//000AEB TP-LINK TECHNOLOGIES CO., LTD.
//2C3731 SHENZHEN YIFANG DIGITAL TECHNOLOGY CO., LTD.
//60EE5C SHENZHEN FAST TECHNOLOGIES CO., LTD
//6488FF Sichuan Changhong Electric Ltd.
//002162, "Nortel Networks
//02E6D3, "NIXDORF COMPUTER CORP.
//0016B9 ProCurve Networking by HP
//C4084A", "Nokia
//000801, "HighSpeed Surfing Inc.
//000772, "Alcatel-Lucent Shanghai Bell Co., Ltd
//E03005", "Alcatel-Lucent Shanghai Bell Co., Ltd
//3C404F GUANGDONG PISEN ELECTRONICS CO., LTD
//0CA402 Alcatel-Lucent IPD
//A0F3E4 Alcatel-Lucent IPD
//84DBFC Nokia
//7CFC3C Visteon Corporation
//981E0F, "Jeelan (Shanghai Jeelan Technology Information Inc
//4888CA Motorola (Wuhan) Mobility Technologies Communication Co., Ltd.
//385610, "CANDY HOUSE, Inc.
//00A742 Cisco Systems, Inc
//00AA70 LG Electronics (Mobile Communications)
//F895C7", "LG Electronics (Mobile Communications)
//84D931, "Hangzhou H3C Technologies Co., Limited
//00116E, "Peplink International Ltd.
//540955, "zte corporation
//001E75, "LG Electronics (Mobile Communications)
//001C62 LG Electronics (Mobile Communications)
//505527, "LG Electronics (Mobile Communications)
//88C9D0 LG Electronics (Mobile Communications)
//C041F6", "LG ELECTRONICS INC
//8C3AE3 LG Electronics (Mobile Communications)
//90A46A SISNET CO., LTD
//14E7C8 Integrated Device Technology (Malaysia) Sdn. Bhd.
//ECCD6D Allied Telesis, Inc.
//18339D, "Cisco Systems, Inc
//146102, "Alpine Electronics, Inc.
//54276C Jiangsu Houge Technology Corp.
//9CA3A9 Guangzhou Juan Optical and Electronical Tech Joint Stock Co., Ltd
//7CC709 SHENZHEN RF-LINK TECHNOLOGY CO., LTD.
//A03E6B IEEE Registration Authority
//9802D8, "IEEE Registration Authority
//64FB81 IEEE Registration Authority
//0821EF, "Samsung Electronics Co., Ltd
//34145F, "Samsung Electronics Co., Ltd
//2C265F IEEE Registration Authority
//D0052A Arcadyan Corporation
//EC6881", "Palo Alto Networks
//E4509A", "HW Communications Ltd
//702900, "Shenzhen ChipTrip Technology Co, Ltd
//ECAAA0", "PEGATRON CORPORATION
//00E0DD Zenith Electronics Corporation
//50CE75 Measy Electronics Co., Ltd.
//00045B Techsan Electronics Co., Ltd.
//0007BA UTStarcom Inc
//90A210 United Telecoms Ltd
//6C0B84 Universal Global Scientific Industrial Co., Ltd.
//001597, "AETA AUDIO SYSTEMS
//002397, "Westell Technologies Inc.
//60E3AC LG Electronics (Mobile Communications)
//90F052, "MEIZU Technology Co., Ltd.
//001639, "Ubiquam Co., Ltd.
//000C29 VMware, Inc.
//000569, "VMware, Inc.
//000B0E Trapeze Networks
//8CFDF0 Qualcomm Inc.
//C4BB4C Zebra Information Tech Co.Ltd
//98CF53 BBK EDUCATIONAL ELECTRONICS CORP., LTD.
//D4A148 HUAWEI TECHNOLOGIES CO., LTD
//D065CA", "HUAWEI TECHNOLOGIES CO., LTD
//486B2C BBK EDUCATIONAL ELECTRONICS CORP., LTD.
//6C25B9 BBK EDUCATIONAL ELECTRONICS CORP., LTD.
//2C282D BBK EDUCATIONAL ELECTRONICS CORP., LTD.
//4813F3, "BBK EDUCATIONAL ELECTRONICS CORP., LTD.
//00409F, "Telco Systems, Inc.
//00001F, "Telco Systems, Inc.
//00A012 Telco Systems, Inc.
//8CEBC6 HUAWEI TECHNOLOGIES CO., LTD
//B08900", "HUAWEI TECHNOLOGIES CO., LTD
//78CB68 DAEHAP HYPER-TECH
//34ED0B, "Shanghai XZ-COM.CO., Ltd.
//F0DEF1 Wistron Infocomm (Zhongshan) Corporation
//F80F41 Wistron Infocomm (Zhongshan) Corporation
//3C970E Wistron InfoComm(Kunshan) Co., Ltd.
//30144A Wistron Neweb Corporation
//4C0BBE Microsoft
//0C2576 LONGCHEER TELECOMMUNICATION LIMITED
//D8D43C Sony Corporation
//D44165", "SICHUAN TIANYI COMHEART TELECOMCO., LTD
//E4029B", "Intel Corporate
//DC1AC5 vivo Mobile Communication Co., Ltd.
//F45EAB Texas Instruments
//A8FCB7", "Consolidated Resource Imaging
//00C000 LANOPTICS, LTD.
//845181, "Samsung Electronics Co., Ltd
//B0C287", "Technicolor CH USA Inc.
//CC3540 Technicolor CH USA Inc.
//8C04FF Technicolor CH USA Inc.
//FC94E3 Technicolor CH USA Inc.
//B88D12 Apple, Inc.
//90EF68, "Zyxel Communications Corporation
//C816BD", "Qingdao Hisense Communications Co., Ltd.
//00EBD5 Cisco Systems, Inc
//C48F07", "Shenzhen Yihao Hulian Science and Technology Co., Ltd.
//DC7834 LOGICOM SA
//CCCC81", "HUAWEI TECHNOLOGIES CO., LTD
//6C9522 Scalys
//B456B9 Teraspek Technologies Co., Ltd
//9CDD1F Intelligent Steward Co., Ltd
//3C6816 VXi Corporation
//E811CA", "SHANDONG KAER ELECTRIC.CO., LTD
//70288B Samsung Electronics Co., Ltd
//348A7B Samsung Electronics Co., Ltd
//D0577B", "Intel Corporate
//78009E, "Samsung Electronics Co., Ltd
//ACC33A", "Samsung Electronics Co., Ltd
//54F201, "Samsung Electronics Co., Ltd
//C4A366", "zte corporation
//6073BC zte corporation
//7C3548 Transcend Information
//18B169 Sonicwall
//444450, "OttoQ
//50F5DA Amazon Technologies Inc.
//101212, "Vivo International Corporation Pty Ltd
//C85B76", "LCFC(HeFei) Electronics Technology co., ltd
//78FFCA TECNO MOBILE LIMITED
//046565, "Testop
//A8BB50", "WiZ IoT Company Limited
//08C021 HUAWEI TECHNOLOGIES CO., LTD
//600810, "HUAWEI TECHNOLOGIES CO., LTD
//48435A HUAWEI TECHNOLOGIES CO., LTD
//8C8EF2 Apple, Inc.
//90B0ED Apple, Inc.
//F03EBF GOGORO TAIWAN LIMITED
//3C92DC Octopod Technology Co. Ltd.
//1000FD LaonPeople
//C47C8D IEEE Registration Authority
//745C9F TCT mobile ltd
//8C99E6 TCT mobile ltd
//449F7F, "DataCore Software Corporation
//848319, "Hangzhou Zero Zero Technology Co., Ltd.
//A81559 Breathometer, Inc.
//70BAEF Hangzhou H3C Technologies Co., Limited
//586AB1 Hangzhou H3C Technologies Co., Limited
//009006, "Hamamatsu Photonics K.K.
//001AF4 Handreamnet
//04D3CF Apple, Inc.
//4882F2, "Appel Elektronik GmbH
//78B84B SICHUAN TIANYI COMHEART TELECOMCO., LTD
//7CB0C2 Intel Corporate
//001793, "Tigi Corporation
//000358, "Hanyang Digitech Co.Ltd
//C4CAD9", "Hangzhou H3C Technologies Co., Limited
//5866BA Hangzhou H3C Technologies Co., Limited
//E0C79D", "Texas Instruments
//4C0B3A TCT mobile ltd
//E42D02 TCT mobile ltd
//0CBD51 TCT mobile ltd
//4000E0, "Derek(Shaoguan) Limited
//FCBC9C Vimar Spa
//149ECF Dell Inc.
//E80959 Guoguang Electric Co., Ltd
//D89403", "Hewlett Packard Enterprise
//E00EDA", "Cisco Systems, Inc
//D0A4B1", "Sonifex Ltd.
//F49EEF Taicang T&W Electronics
//C4F081 HUAWEI TECHNOLOGIES CO., LTD
//801382, "HUAWEI TECHNOLOGIES CO., LTD
//94FE22 HUAWEI TECHNOLOGIES CO., LTD
//F4CC55", "Juniper Networks
//50DD4F Automation Components, Inc
//341FE4 ARRIS Group, Inc.
//0024F4, "Kaminario, Ltd.
//001A29 Johnson Outdoors Marine Electronics d/b/a Minnkota
//0090AE ITALTEL S.p.A/RF-UP-I
//00177D, "IDT Technology Limited
//00A045 PHOENIX CONTACT Electronics GmbH
//002378, "GN Netcom A/S
//50C971 GN Netcom A/S
//F0407B", "Fiberhome Telecommunication Technologies Co., LTD
//94885E, "Surfilter Network Technology Co., Ltd.
//C825E1 Lemobile Information Technology (Beijing) Co., Ltd
//945089, "SimonsVoss Technologies GmbH
//042AE2 Cisco Systems, Inc
//E0B6F5", "IEEE Registration Authority
//0090FA Emulex Corporation
//00E0D5, "Emulex Corporation
//001035, "Elitegroup Computer Systems Co., Ltd.
//000AE6 Elitegroup Computer Systems Co., Ltd.
//7427EA Elitegroup Computer Systems Co., Ltd.
//649968, "Elentec
//00409C TRANSWARE
//B01BD2 Le Shi Zhi Xin Electronic Technology (Tianjin) Limited
//54489C CDOUBLES ELECTRONICS CO. LTD.
//E4A1E6 Alcatel-Lucent Shanghai Bell Co., Ltd
//84002D, "PEGATRON CORPORATION
//408256, "Continental Automotive GmbH
//5CC7D7 AZROAD TECHNOLOGY COMPANY LIMITED
//986B3D ARRIS Group, Inc.
//E0071B Hewlett Packard Enterprise
//1CABC0 Hitron Technologies.Inc
//1C3ADE Samsung Electronics Co., Ltd
//002360, "Lookit Technology Co., Ltd
//84FEDC Borqs Beijing Ltd.
//608334, "HUAWEI TECHNOLOGIES CO., LTD
//E47E66", "HUAWEI TECHNOLOGIES CO., LTD
//94DBDA HUAWEI TECHNOLOGIES CO., LTD
//54D9E4, "BRILLIANTTS CO., LTD
//F462D0", "Not for Radio, LLC
//98DED0 TP-LINK TECHNOLOGIES CO., LTD.
//508965, "SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//005BA1 shanghai huayuan chuangxin software CO., LTD.
//58D67A TCPlink
//98072D, "Texas Instruments
//F0C77F Texas Instruments
//000AC2 Wuhan FiberHome Digital Technology Co., Ltd.
//10DA43 NETGEAR
//B805AB zte corporation
//789682, "zte corporation
//D467E7 Fiberhome Telecommunication Technologies Co., LTD
//E42F26", "Fiberhome Telecommunication Technologies Co., LTD
//04C1B9 Fiberhome Telecommunication Technologies Co., LTD
//C4BED4", "Avaya Inc
//D017C2 ASUSTek COMPUTER INC.
//349971, "Quanta Storage Inc.
//9C52F8 HUAWEI TECHNOLOGIES CO., LTD
//EC13DB", "Juniper Networks
//5CF286 IEEE Registration Authority
//E8FD72 SHANGHAI LINGUO TECHNOLOGY CO., LTD.
//98BB1E BYD Precision Manufacture Company Ltd.
//AC5F3E SAMSUNG ELECTRO-MECHANICS(THAILAND)
//546D52, "TOPVIEW OPTRONICS CORP.
//04C103 Clover Network, Inc.
//280C28 Unigen DataStorage Corporation
//A4BF01 Intel Corporate
//208B37 Skyworth Digital Technology(Shenzhen) Co., Ltd
//08BE77 Green Electronics
//509EA7 Samsung Electronics Co., Ltd
//A88195", "Samsung Electronics Co., Ltd
//88ADD2 Samsung Electronics Co., Ltd
//00CCFC Cisco Systems, Inc
//0019C5 Sony Interactive Entertainment Inc.
//001315, "Sony Interactive Entertainment Inc.
//1C234F EDMI", "Europe Ltd
//A444D1 Wingtech Group (HongKong）Limited
//006CFD Sichuan Changhong Electric Ltd.
//545AA6 Espressif Inc.
//FC1A11 vivo Mobile Communication Co., Ltd.
//001A57 Matrix Design Group, LLC
//A0C589", "Intel Corporate
//001E1E Honeywell Life Safety
//002340, "MiXTelematics
//B48B19", "Apple, Inc.
//38FDFE IEEE Registration Authority
//2C09CB COBS AB
//BCEC5D", "Apple, Inc.
//28A02B Apple, Inc.
//A84481 Nokia Corporation
//8844F6, "Nokia Corporation
//F44D17 GOLDCARD HIGH-TECH CO., LTD.
//38B8EB IEEE Registration Authority
//9897D1, "MitraStar Technology Corp.
//B83241 Wuhan Tianyu Information Industry Co., Ltd.
//0060DC NEC Magnus Communications, Ltd.
//907282, "Sagemcom Broadband SAS
//001C35 Nokia Danmark A/S
//001C9A Nokia Danmark A/S
//001CD6 Nokia Danmark A/S
//001CD4 Nokia Danmark A/S
//001D98, "Nokia Danmark A/S
//001DE9 Nokia Danmark A/S
//001E3A Nokia Danmark A/S
//002548, "Nokia Danmark A/S
//0022FC Nokia Danmark A/S
//0022FD Nokia Danmark A/S
//0021AA Nokia Danmark A/S
//001D6E, "Nokia Danmark A/S
//001CFC Sumitomo Electric Industries, Ltd
//0023B4 Nokia Danmark A/S
//001370, "Nokia Danmark A/S
//9C1874 Nokia Danmark A/S
//001BAF Nokia Danmark A/S
//C8D10B", "Nokia Corporation
//5CC6D0 Skyworth Digital Technology(Shenzhen) Co., Ltd
//001A9A Skyworth Digital Technology(Shenzhen) Co., Ltd
//CC6DA0", "Roku, Inc.
//0016E4, "VANGUARD SECURITY ENGINEERING CORP.
//3C8970 Neosfar
//001742, "FUJITSU LIMITED
//001999, "Fujitsu Technology Solutions GmbH
//005A39 SHENZHEN FAST TECHNOLOGIES CO., LTD
//A089E4", "Skyworth Digital Technology(Shenzhen) Co., Ltd
//78CA83 IEEE Registration Authority
//0C1167 Cisco Systems, Inc
//74EAE8 ARRIS Group, Inc.
//F88E85 Comtrend Corporation
//02CF1C Communication Machinery Corporation
//0090F5, "CLEVO CO.
//0030FF DataFab Systems Inc.
//000FF6 DARFON LIGHTING CORP
//002100, "Gemtek Technology Co., Ltd.
//50F520, "Samsung Electronics Co., Ltd
//64B310 Samsung Electronics Co., Ltd
//A4EBD3", "Samsung Electronics Co., Ltd
//C81073", "CENTURY OPTICOMM CO., LTD
//343759, "zte corporation
//FC2F40 Calxeda, Inc.
//BC620E HUAWEI TECHNOLOGIES CO., LTD
//74A528 HUAWEI TECHNOLOGIES CO., LTD
//5CF6DC Samsung Electronics Co., Ltd
//0026E4, "Canal +
//000117, "Canal +
//E01D3B Cambridge Industries(Group) Co., Ltd.
//70C76F INNO S
//38192F, "Nokia Corporation
//B8C68E Samsung Electronics Co., Ltd
//04FE31 Samsung Electronics Co., Ltd
//4CBCA5 Samsung Electronics Co., Ltd
//D831CF", "Samsung Electronics Co., Ltd
//188331, "Samsung Electronics Co., Ltd
//9C65B0 Samsung Electronics Co., Ltd
//8455A5 Samsung Electronics Co., Ltd
//A87C01", "Samsung Electronics Co., Ltd
//B0D09C", "Samsung Electronics Co., Ltd
//50C8E5 Samsung Electronics Co., Ltd
//0020D4, "Cabletron Systems, Inc.
//00E03A Cabletron Systems, Inc.
//0010E7, "Breezecom, Ltd.
//9492BC SYNTECH(HK) TECHNOLOGY LIMITED
//001D19, "Arcadyan Technology Corporation
//0012BF Arcadyan Technology Corporation
//507E5D, "Arcadyan Technology Corporation
//7C4FB5 Arcadyan Technology Corporation
//00223F, "NETGEAR
//000FB5 NETGEAR
//00095B NETGEAR
//001A4F AVM GmbH
//001C4A AVM GmbH
//00150C AVM GmbH
//0026FF BlackBerry RTS
//A4E4B8", "BlackBerry RTS
//003067, "BIOSTAR Microtech Int'l Corp.
//F40B93 BlackBerry RTS
//1C69A5 BlackBerry RTS
//94EBCD BlackBerry RTS
//28C68E NETGEAR
//04A151 NETGEAR
//F87394 NETGEAR
//204E7F, "NETGEAR
//C03F0E", "NETGEAR
//0026F2, "NETGEAR
//00138F, "Asiarock Technology Limited
//803773, "NETGEAR
//A42B8C", "NETGEAR
//CC7D37", "ARRIS Group, Inc.
//A47AA4 ARRIS Group, Inc.
//001700, "ARRIS Group, Inc.
//0016B5 ARRIS Group, Inc.
//0015A8 ARRIS Group, Inc.
//00159A ARRIS Group, Inc.
//001180, "ARRIS Group, Inc.
//000B06 ARRIS Group, Inc.
//00D088, "ARRIS Group, Inc.
//00128A ARRIS Group, Inc.
//002375, "ARRIS Group, Inc.
//0023A3 ARRIS Group, Inc.
//001ADB ARRIS Group, Inc.
//001F7E, "ARRIS Group, Inc.
//0011AE ARRIS Group, Inc.
//94CCB9 ARRIS Group, Inc.
//3C438E ARRIS Group, Inc.
//0024C1 ARRIS Group, Inc.
//0025F2, "ARRIS Group, Inc.
//0025F1, "ARRIS Group, Inc.
//001404, "ARRIS Group, Inc.
//001AAD ARRIS Group, Inc.
//0026BA ARRIS Group, Inc.
//00230B ARRIS Group, Inc.
//74E7C6 ARRIS Group, Inc.
//001C12 ARRIS Group, Inc.
//5C338E Alpha Networks Inc.
//000941, "Allied Telesis R&D Center K.K.
//28E347, "Liteon Technology Corporation
//446D57, "Liteon Technology Corporation
//9CB70D Liteon Technology Corporation
//68A3C4 Liteon Technology Corporation
//70F1A1 Liteon Technology Corporation
//8400D2, "Sony Mobile Communications Inc
//303926, "Sony Mobile Communications Inc
//00EB2D Sony Mobile Communications Inc
//B4527D", "Sony Mobile Communications Inc
//00D9D1, "Sony Interactive Entertainment Inc.
//B00594 Liteon Technology Corporation
//EC086B TP-LINK TECHNOLOGIES CO., LTD.
//94A1A2 AMPAK Technology, Inc.
//00014A Sony Corporation
//001EDC Sony Mobile Communications Inc
//001D28, "Sony Mobile Communications Inc
//001813, "Sony Mobile Communications Inc
//402BA1 Sony Mobile Communications Inc
//983B16 AMPAK Technology, Inc.
//409558, "Aisino Corporation
//182861, "AirTies Wireless Networks
//6C71D9 AzureWave Technology Inc.
//D0E782 AzureWave Technology Inc.
//6CADF8 AzureWave Technology Inc.
//A81D16 AzureWave Technology Inc.
//34C3D2 FN-LINK TECHNOLOGY LIMITED
//54F6C5 FUJIAN STAR-NET COMMUNICATION CO., LTD
//D0D412", "ADB Broadband Italia
//0026B8 Actiontec Electronics, Inc
//0026FC AcSiP Technology Corp.
//0015AF AzureWave Technology Inc.
//74F06D, "AzureWave Technology Inc.
//44D832, "AzureWave Technology Inc.
//E0B9A5 AzureWave Technology Inc.
//781881, "AzureWave Technology Inc.
//B046FC MitraStar Technology Corp.
//E04136 MitraStar Technology Corp.
//001CA2 ADB Broadband Italia
//002233, "ADB Broadband Italia
//3039F2, "ADB Broadband Italia
//0017C2 ADB Broadband Italia
//689C5E AcSiP Technology Corp.
//9C0E4A Shenzhen Vastking Electronic Co., Ltd.
//A85840 Cambridge Industries(Group) Co., Ltd.
//A0D37A Intel Corporate
//8896F2, "Valeo Schalter und Sensoren GmbH
//001073, "TECHNOBOX, INC.
//20934D, "FUJIAN STAR-NET COMMUNICATION CO., LTD
//009027, "Intel Corporation
//C48508 Intel Corporate
//6805CA Intel Corporate
//247703, "Intel Corporate
//74E50B Intel Corporate
//B80305", "Intel Corporate
//00A0C9 Intel Corporation
//141877, "Dell Inc.
//E09796 HUAWEI TECHNOLOGIES CO., LTD
//1C4024 Dell Inc.
//18FB7B Dell Inc.
//F8B156 Dell Inc.
//141AA3 Motorola Mobility LLC, a Lenovo Company
//3407FB Ericsson AB
//A4A1C2", "Ericsson AB
//00065B Dell Inc.
//842B2B Dell Inc.
//F04DA2 Dell Inc.
//E0DB55 Dell Inc.
//000F1F, "Dell Inc.
//24B6FD Dell Inc.
//74E6E2 Dell Inc.
//34E6D7, "Dell Inc.
//001EC9 Dell Inc.
//002170, "Dell Inc.
//00219B Dell Inc.
//B8AC6F Dell Inc.
//8CA982 Intel Corporate
//BC7737", "Intel Corporate
//1430C6 Motorola Mobility LLC, a Lenovo Company
//D8FC93", "Intel Corporate
//D4AE52 Dell Inc.
//28162E, "2Wire Inc
//F81897", "2Wire Inc
//94C150", "2Wire Inc
//5CF821 Texas Instruments
//88074B LG Electronics (Mobile Communications)
//000D72, "2Wire Inc
//001288, "2Wire Inc
//00789E, "Sagemcom Broadband SAS
//E8BE81", "Sagemcom Broadband SAS
//681590, "Sagemcom Broadband SAS
//F4EB38", "Sagemcom Broadband SAS
//001BBF Sagemcom Broadband SAS
//002569, "Sagemcom Broadband SAS
//141FBA IEEE Registration Authority
//807B85 IEEE Registration Authority
//CC1BE0 IEEE Registration Authority
//F40E11 IEEE Registration Authority
//10F681, "vivo Mobile Communication Co., Ltd.
//00217C", "2Wire Inc
//001FB3", "2Wire Inc
//002275, "Belkin International Inc.
//0057D2, "Cisco Systems, Inc
//3C6716 Lily Robotics
//00D0BD Lattice Semiconductor Corp. (LPA)
//001F3A Hon Hai Precision Ind.Co., Ltd.
//C8A030 Texas Instruments
//78C5E5 Texas Instruments
//0CFD37 SUSE Linux GmbH
//2C228B CTR SRL
//0C6F9C Shaw Communications Inc.
//0017E4, "Texas Instruments
//04E451, "Texas Instruments
//505663, "Texas Instruments
//883314, "Texas Instruments
//647BD4 Texas Instruments
//D8952F", "Texas Instruments
//B8FFFE Texas Instruments
//2CE412 Sagemcom Broadband SAS
//44C15C Texas Instruments
//0022A5 Texas Instruments
//E043DB", "Shenzhen ViewAt Technology Co., Ltd.
//3CCF5B ICOMM HK LIMITED
//2405F5, "Integrated Device Technology (Malaysia) Sdn. Bhd.
//3C3556 Cognitec Systems GmbH
//3C9066 SmartRG, Inc.
//000D88, "D-Link Corporation
//001195, "D-Link Corporation
//001346, "D-Link Corporation
//78E3B5 Hewlett Packard
//78ACC0 Hewlett Packard
//68B599 Hewlett Packard
//1CC1DE Hewlett Packard
//B8A386", "D-Link International
//1C7EE5 D-Link International
//1CBDB9 D-Link International
//00142F, "Savvius
//28BC18 SourcingOverseas Co.Ltd
//94ABDE OMX Technology - FZE
//9CDFB1 Shenzhen Crave Communication Co., LTD
//ACCF85", "HUAWEI TECHNOLOGIES CO., LTD
//3871DE Apple, Inc.
//7081EB Apple, Inc.
//00738D, "Shenzhen TINNO Mobile Technology Corp.
//34BA75 Everest Networks, Inc
//7C18CD E-TRON Co., Ltd.
//00E0FC HUAWEI TECHNOLOGIES CO., LTD
//6416F0, "HUAWEI TECHNOLOGIES CO., LTD
//F40304", "Google, Inc.
//546009, "Google, Inc.
//A47733 Google, Inc.
//807ABF HTC Corporation
//78F882, "LG Electronics (Mobile Communications)
//C02C7A", "Shenzhen Horn Audio Co., Ltd.
//1CCB99 TCT mobile ltd
//A42BB0 TP-LINK TECHNOLOGIES CO., LTD.
//188B45 Cisco Systems, Inc
//606944, "Apple, Inc.
//B0C69A Juniper Networks
//2C6BF5 Juniper Networks
//C42F90", "Hangzhou Hikvision Digital Technology Co., Ltd.
//F4CA24 FreeBit Co., Ltd.
//00D0B7, "Intel Corporation
//001DD6 ARRIS Group, Inc.
//903EAB ARRIS Group, Inc.
//306023, "ARRIS Group, Inc.
//14ABF0 ARRIS Group, Inc.
//0014F6, "Juniper Networks
//901ACA ARRIS Group, Inc.
//C83FB4 ARRIS Group, Inc.
//E0B70A ARRIS Group, Inc.
//001DCE ARRIS Group, Inc.
//0013E8, "Intel Corporate
//0013CE Intel Corporate
//2C768A Hewlett Packard
//C8348E", "Intel Corporate
//4C3488 Intel Corporate
//1002B5 Intel Corporate
//004026, "BUFFALO.INC
//4CE676 BUFFALO.INC
//000BCD Hewlett Packard
//000F20, "Hewlett Packard
//00110A Hewlett Packard
//B8B81E", "Intel Corporate
//B46D83 Intel Corporate
//000E35, "Intel Corporation
//0007E9, "Intel Corporation
//001708, "Hewlett Packard
//0017A4 Hewlett Packard
//C005C2", "ARRIS Group, Inc.
//0030C1 Hewlett Packard
//0080A0 Hewlett Packard
//D48564", "Hewlett Packard
//24BE05 Hewlett Packard
//FC3FDB", "Hewlett Packard
//308D99, "Hewlett Packard
//5820B1 Hewlett Packard
//9457A5 Hewlett Packard
//000EB3 Hewlett Packard
//080009, "Hewlett Packard
//90CDB6 Hon Hai Precision Ind.Co., Ltd.
//40490F, "Hon Hai Precision Ind. Co., Ltd.
//00265C Hon Hai Precision Ind.Co., Ltd.
//002269, "Hon Hai Precision Ind. Co., Ltd.
//D87988 Hon Hai Precision Ind.Co., Ltd.
//74A78E zte corporation
//00092D, "HTC Corporation
//443192, "Hewlett Packard
//A0D3C1 Hewlett Packard
//38EAA7 Hewlett Packard
//AC162D", "Hewlett Packard
//80C16E Hewlett Packard
//B4B52F", "Hewlett Packard
//D07E28 Hewlett Packard
//D0BF9C", "Hewlett Packard
//7C6193 HTC Corporation
//90E7C4 HTC Corporation
//BCEAFA", "Hewlett Packard
//7446A0 Hewlett Packard
//2C44FD Hewlett Packard
//0453D5, "Sysorex Global Holdings
//EC52DC", "WORLD MEDIA AND TECHNOLOGY Corp.
//94B2CC PIONEER CORPORATION
//0452F3, "Apple, Inc.
//88C255 Texas Instruments
//CC78AB", "Texas Instruments
//1C7839 Shenzhen Tencent Computer System Co., Ltd.
//FCD733 TP-LINK TECHNOLOGIES CO., LTD.
//5C899A TP-LINK TECHNOLOGIES CO., LTD.
//A81B5A GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//2C5BB8 GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//08EB74 HUMAX Co., Ltd.
//E005C5 TP-LINK TECHNOLOGIES CO., LTD.
//388345, "TP-LINK TECHNOLOGIES CO., LTD.
//EC888F TP-LINK TECHNOLOGIES CO., LTD.
//6466B3 TP-LINK TECHNOLOGIES CO., LTD.
//2832C5 HUMAX Co., Ltd.
//F0F336 TP-LINK TECHNOLOGIES CO., LTD.
//BC4699 TP-LINK TECHNOLOGIES CO., LTD.
//F483CD TP-LINK TECHNOLOGIES CO., LTD.
//002127, "TP-LINK TECHNOLOGIES CO., LTD.
//5C63BF TP-LINK TECHNOLOGIES CO., LTD.
//889471, "Brocade Communications Systems, Inc.
//8C7CFF Brocade Communications Systems, Inc.
//142D27, "Hon Hai Precision Ind. Co., Ltd.
//88E3AB HUAWEI TECHNOLOGIES CO., LTD
//C40528", "HUAWEI TECHNOLOGIES CO., LTD
//3CDFBD HUAWEI TECHNOLOGIES CO., LTD
//509F27, "HUAWEI TECHNOLOGIES CO., LTD
//80717A HUAWEI TECHNOLOGIES CO., LTD
//0021E8, "Murata Manufacturing Co., Ltd.
//000E6D, "Murata Manufacturing Co., Ltd.
//902106, "BSkyB Ltd
//D02788 Hon Hai Precision Ind.Co., Ltd.
//904CE5 Hon Hai Precision Ind.Co., Ltd.
//001FE2 Hon Hai Precision Ind.Co., Ltd.
//0016CF Hon Hai Precision Ind.Co., Ltd.
//2002AF Murata Manufacturing Co., Ltd.
//98F537, "zte corporation
//5C4CA9 HUAWEI TECHNOLOGIES CO., LTD
//F4C714", "HUAWEI TECHNOLOGIES CO., LTD
//286ED4, "HUAWEI TECHNOLOGIES CO., LTD
//001E10, "HUAWEI TECHNOLOGIES CO., LTD
//D47856", "Avaya Inc
//D842AC Shanghai Feixun Communication Co., Ltd.
//5439DF HUAWEI TECHNOLOGIES CO., LTD
//283CE4 HUAWEI TECHNOLOGIES CO., LTD
//2CF4C5 Avaya Inc
//3C3A73 Avaya Inc
//FC8399", "Avaya Inc
//587F66, "HUAWEI TECHNOLOGIES CO., LTD
//64A651 HUAWEI TECHNOLOGIES CO., LTD
//086361, "HUAWEI TECHNOLOGIES CO., LTD
//A01290", "Avaya Inc
//38BB3C Avaya Inc
//F873A2", "Avaya Inc
//CCF954 Avaya Inc
//8C34FD HUAWEI TECHNOLOGIES CO., LTD
//ACF7F3", "Xiaomi Communications Co Ltd
//D4970B Xiaomi Communications Co Ltd
//8CBEBE Xiaomi Communications Co Ltd
//14F65A Xiaomi Communications Co Ltd
//009EC8 Xiaomi Communications Co Ltd
//0C1DAF Xiaomi Communications Co Ltd
//0819A6 HUAWEI TECHNOLOGIES CO., LTD
//3CF808 HUAWEI TECHNOLOGIES CO., LTD
//486276, "HUAWEI TECHNOLOGIES CO., LTD
//B41513", "HUAWEI TECHNOLOGIES CO., LTD
//AC4E91", "HUAWEI TECHNOLOGIES CO., LTD
//283152, "HUAWEI TECHNOLOGIES CO., LTD
//3480B3 Xiaomi Communications Co Ltd
//F48B32", "Xiaomi Communications Co Ltd
//009021, "Cisco Systems, Inc
//0090B1 Cisco Systems, Inc
//001AB6 Texas Instruments
//0012D1, "Texas Instruments
//001237, "Texas Instruments
//A0E6F8 Texas Instruments
//70FF76 Texas Instruments
//D03972", "Texas Instruments
//5C313E Texas Instruments
//F4B85E", "Texas Instruments
//68C90B Texas Instruments
//74882A HUAWEI TECHNOLOGIES CO., LTD
//4CB16C HUAWEI TECHNOLOGIES CO., LTD
//04BD70 HUAWEI TECHNOLOGIES CO., LTD
//D4F513", "Texas Instruments
//507224, "Texas Instruments
//0090D9, "Cisco Systems, Inc
//009092, "Cisco Systems, Inc
//00102F, "Cisco Systems, Inc
//00100D, "Cisco Systems, Inc
//001007, "Cisco Systems, Inc
//001014, "Cisco Systems, Inc
//0090BF Cisco Systems, Inc
//0050D1, "Cisco Systems, Inc
//1CE6C7 Cisco Systems, Inc
//CCD539", "Cisco Systems, Inc
//4C0082 Cisco Systems, Inc
//7C95F3 Cisco Systems, Inc
//34DBFD Cisco Systems, Inc
//885A92 Cisco Systems, Inc
//00400B Cisco Systems, Inc
//006070, "Cisco Systems, Inc
//500604, "Cisco Systems, Inc
//00E01E Cisco Systems, Inc
//00112F, "ASUSTek COMPUTER INC.
//001BFC ASUSTek COMPUTER INC.
//A0554F Cisco Systems, Inc
//204C9E Cisco Systems, Inc
//84B802 Cisco Systems, Inc
//B0AA77", "Cisco Systems, Inc
//BCC493", "Cisco Systems, Inc
//A46C2A", "Cisco Systems, Inc
//D0A5A6", "Cisco Systems, Inc
//3C5EC3 Cisco Systems, Inc
//64F69D, "Cisco Systems, Inc
//000389, "PLANTRONICS, INC.
//D072DC Cisco Systems, Inc
//28C7CE Cisco Systems, Inc
//F40F1B", "Cisco Systems, Inc
//F8C288", "Cisco Systems, Inc
//1C6A7A Cisco Systems, Inc
//001EE5 Cisco-Linksys, LLC
//484487, "Cisco SPVTG
//38C85C Cisco SPVTG
//485B39 ASUSTek COMPUTER INC.
//BCAEC5 ASUSTek COMPUTER INC.
//10BF48 ASUSTek COMPUTER INC.
//5067AE Cisco Systems, Inc
//F09E63", "Cisco Systems, Inc
//6C9989 Cisco Systems, Inc
//18E728, "Cisco Systems, Inc
//001217, "Cisco-Linksys, LLC
//001310, "Cisco-Linksys, LLC
//046C9D Cisco Systems, Inc
//84B261 Cisco Systems, Inc
//E448C7", "Cisco SPVTG
//00101F, "Cisco Systems, Inc
//54A274 Cisco Systems, Inc
//60FB42 Apple, Inc.
//64B9E8 Apple, Inc.
//001D4F, "Apple, Inc.
//002312, "Apple, Inc.
//80E01D, "Cisco Systems, Inc
//D8A25E", "Apple, Inc.
//000A27 Apple, Inc.
//183451, "Apple, Inc.
//0C771A Apple, Inc.
//286ABA Apple, Inc.
//4CB199 Apple, Inc.
//C09F42 Apple, Inc.
//D023DB Apple, Inc.
//70DEE2 Apple, Inc.
//F0CBA1 Apple, Inc.
//182032, "Apple, Inc.
//403CFC Apple, Inc.
//4860BC Apple, Inc.
//3451C9 Apple, Inc.
//406C8F Apple, Inc.
//5855CA Apple, Inc.
//DC2B61 Apple, Inc.
//40A6D9 Apple, Inc.
//60FACD Apple, Inc.
//003EE1 Apple, Inc.
//FC253F Apple, Inc.
//04F7E4, "Apple, Inc.
//34C059 Apple, Inc.
//F0D1A9 Apple, Inc.
//705681, "Apple, Inc.
//14109F, "Apple, Inc.
//040CCE Apple, Inc.
//54EAA8 Apple, Inc.
//28E14C Apple, Inc.
//E4C63D Apple, Inc.
//54E43A Apple, Inc.
//04DB56 Apple, Inc.
//AC3C0B Apple, Inc.
//701124, "Apple, Inc.
//042665, "Apple, Inc.
//EC3586 Apple, Inc.
//78FD94 Apple, Inc.
//2CBE08 Apple, Inc.
//E8802E Apple, Inc.
//006171, "Apple, Inc.
//8C7C92 Apple, Inc.
//B03495 Apple, Inc.
//F437B7 Apple, Inc.
//AC7F3E Apple, Inc.
//280B5C Apple, Inc.
//ACFDEC Apple, Inc.
//DC9B9C Apple, Inc.
//54724F, "Apple, Inc.
//D8CF9C Apple, Inc.
//7C6DF8 Apple, Inc.
//04E536, "Apple, Inc.
//A8BBCF Apple, Inc.
//6C4008 Apple, Inc.
//FCA386 SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD
//40331A Apple, Inc.
//CCC760 Apple, Inc.
//BC4CC4 Apple, Inc.
//DC3714 Apple, Inc.
//20A2E4 Apple, Inc.
//28F076, "Apple, Inc.
//141357, "ATP Electronics, Inc.
//B8B2EB Googol Technology (HK) Limited
//FCCF43 HUIZHOU CITY HUIYANG DISTRICT MEISIQI INDUSTRY DEVELOPMENT CO,.LTD
//D848EE", "Hangzhou Xueji Technology Co., Ltd.
//B4EF04 DAIHAN Scientific Co., Ltd.
//A4DEC9 QLove Mobile Intelligence Information Technology (W.H.) Co. Ltd.
//CCE0C3 EXTEN Technologies, Inc.
//646A74 AUTH-SERVERS, LLC
//4C8ECC SILKAN SA
//E435C8", "HUAWEI TECHNOLOGIES CO., LTD
//0C54B9 Nokia
//84100D, "Motorola Mobility LLC, a Lenovo Company
//D00F6D", "T&W Electronics Company
//908D78, "D-Link International
//7C7176 Wuxi iData Technology Company Ltd.
//7C0191 Apple, Inc.
//2C1BC8 Hunan Topview Network System CO., LTD
//A8474A", "Hon Hai Precision Ind. Co., Ltd.
//C40049 Kamama
//80D605, "Apple, Inc.
//98E848, "Axiim
//4040A7 Sony Mobile Communications Inc
//C04A09", "Zhejiang Everbright Communication Equip. Co,. Ltd
//A01E0B", "MINIX Technology Limited
//68E8EB Linktel Technologies Co., Ltd
//A845CD", "Siselectron Technology LTD.
//D0C193 SKYBELL, INC
//AC6462", "zte corporation
//C025A2 NEC Platforms, Ltd.
//48137E, "Samsung Electronics Co., Ltd
//30F772, "Hon Hai Precision Ind. Co., Ltd.
//DC3CF6 Atomic Rules LLC
//089B4B iKuai Networks
//4473D6, "Logitech
//10CC1B Liverock technologies, INC
//E80734", "Champion Optical Network Engineering, LLC
//A43831", "RF elements s.r.o.
//380546, "Foctek Photonics, Inc.
//D48304 SHENZHEN FAST TECHNOLOGIES CO., LTD
//DC2B2A", "Apple, Inc.
//9C8DD3 Leonton Technologies
//E41A2C", "ZPE Systems, Inc.
//E8BDD1 HUAWEI TECHNOLOGIES CO., LTD
//F41535", "SPON Communication Technology Co., Ltd
//380AAB Formlabs
//382DE8 Samsung Electronics Co., Ltd
//C08997", "Samsung Electronics Co., Ltd
//A815D6", "Shenzhen Meione Technology CO., LTD
//C07CD1", "PEGATRON CORPORATION
//90D8F3, "zte corporation
//D445E8 Jiangxi Hongpai Technology Co., Ltd.
//342606, "CarePredict, Inc.
//38B725 Wistron Infocomm (Zhongshan) Corporation
//ACEC80 ARRIS Group, Inc.
//507B9D LCFC(HeFei) Electronics Technology co., ltd
//6C7220 D-Link International
//30A243 Shenzhen Prifox Innovation Technology Co., Ltd.
//380195, "Samsung Electronics Co., Ltd
//246E96, "Dell Inc.
//44975A SHENZHEN FAST TECHNOLOGIES CO., LTD
//5045F7, "Liuhe Intelligence Technology Ltd.
//AC676F Electrocompaniet A.S.
//640DE6 Petra Systems
//E0553D", "Cisco Meraki
//FC335F Polyera
//84D4C8 Widex A/S
//EC21E5", "Toshiba
//04C23E HTC Corporation
//E01AEA", "Allied Telesis, Inc.
//28B9D9 Radisys Corporation
//F4C613", "Alcatel-Lucent Shanghai Bell Co., Ltd
//445F8C Intercel Group Limited
//B88981 Chengdu InnoThings Technology Co., Ltd.
//F02624 WAFA TECHNOLOGIES CO., LTD.
//F8F464 Rawe Electonic GmbH
//5C5188 Motorola Mobility LLC, a Lenovo Company
//EC0133", "TRINUS SYSTEMS INC.
//2CC548 IAdea Corporation
//14DDA9 ASUSTek COMPUTER INC.
//184F32, "Hon Hai Precision Ind. Co., Ltd.
//DCA3AC RBcloudtech
//0CE725 Microsoft Corporation
//58F102, "BLU Products Inc.
//B4AE2B Microsoft
//949F3E, "Sonos, Inc.
//3089D3, "HONGKONG UCLOUDLINK NETWORK TECHNOLOGY LIMITED
//5CB395 HUAWEI TECHNOLOGIES CO., LTD
//906CAC Fortinet, Inc.
//3CDA2A zte corporation
//842E27, "Samsung Electronics Co., Ltd
//1CADD1 Bosung Electronics Co., Ltd.
//082CB0 Network Instruments
//A013CB", "Fiberhome Telecommunication Technologies Co., LTD
//D00492", "Fiberhome Telecommunication Technologies Co., LTD
//1432D1, "Samsung Electronics Co., Ltd
//1816C9 Samsung Electronics Co., Ltd
//00FC8D Hitron Technologies.Inc
//84DF19 Chuango Security Technology Corporation
//DC15DB", "Ge Ruili Intelligent Technology (Beijing ) Co., Ltd.
//E0DB10 Samsung Electronics Co., Ltd
//546172, "ZODIAC AEROSPACE SAS
//EC60E0", "AVI-ON LABS
//B46D35 Dalian Seasky Automation Co; Ltd
//3CA31A Oilfind International LLC
//30F335, "HUAWEI TECHNOLOGIES CO.,LTD
//E8F2E3", "Starcor Beijing Co.,Limited
//6459F8, "Vodafone Omnitel B.V.
//6C4418 Zappware
//A8D409 USA 111 Inc
//6C4598 Antex Electronic Corp.
//68A378 FREEBOX SAS
//340A22 TOP-ACCESS ELECTRONICS CO LTD
//E866C4 Diamanti
//D4D7A9 Shanghai Kaixiang Info Tech LTD
//343D98, "JinQianMao Technology Co., Ltd.
//F44713 Leading Public Performance Co., Ltd.
//5CA178 TableTop Media (dba Ziosk)
//9CBEE0 Biosoundlab Co., Ltd.
//0C413E Microsoft Corporation
//D06F4A", "TOPWELL INTERNATIONAL HOLDINGS LIMITED
//0492EE iway AG
//807459, "K's Co.,Ltd.
//601970, "HUIZHOU QIAOXING ELECTRONICS TECHNOLOGY CO., LTD.
//A408EA Murata Manufacturing Co., Ltd.
//B87879 Roche Diagnostics GmbH
//D083D4 Xtel Wireless ApS
//08D34B Techman Electronics (Changshu) Co., Ltd.
//78A351 SHENZHEN ZHIBOTONG ELECTRONICS CO., LTD
//E4695A", "Dictum Health, Inc.
//7C7A53 Phytrex Technology Corp.
//107873, "Shenzhen Jinkeyi Communication Co., Ltd.
//48EE0C D-Link International
//EC3C88 MCNEX Co., Ltd.
//70AD54 Malvern Instruments Ltd
//9000DB Samsung Electronics Co., Ltd
//B4EF39", "Samsung Electronics Co., Ltd
//F02A23", "Creative Next Design
//584704, "Shenzhen Webridge Technology Co., Ltd
//74A063 HUAWEI TECHNOLOGIES CO., LTD
//ECE2FD", "SKG Electric Group(Thailand) Co., Ltd.
//148F21, "Garmin International
//9C685B Octonion SA
//7C534A Metamako
//BC6E64 Sony Mobile Communications Inc
//BCB308", "HONGKONG RAGENTEK COMMUNICATION TECHNOLOGY CO., LIMITED
//6C2E72 B&B EXPORTING LIMITED
//5CCCFF Techroutes Network Pvt Ltd
//90C35F Nanjing Jiahao Technology Co., Ltd.
//C808E9 LG Electronics
//183A2D Samsung Electronics Co., Ltd
//EC74BA", "Hirschmann Automation and Control GmbH
//FC3288", "CELOT Wireless Co., Ltd
//D87495", "zte corporation
//5C3B35 Gehirn Inc.
//E4FED9 EDMI Europe Ltd
//5CF7C3 SYNTECH (HK) TECHNOLOGY LIMITED
//9CE230 JULONG CO,.LTD.
//5C41E7 Wiatec International Ltd.
//344CA4 amazipoint technology Ltd.
//A8F038 SHEN ZHEN SHI JIN HUA TAI ELECTRONICS CO., LTD
//ACC73F", "VITSMO CO., LTD.
//44356F, "Neterix
//74E277, "Vizmonet Pte Ltd
//14893E, "VIXTEL TECHNOLOGIES LIMTED
//BC54F9", "Drogoo Technology Co., Ltd.
//78FC14 Family Zone Cyber Safety Ltd
//3809A4 Firefly Integrations
//BCE767", "Quanzhou TDX Electronics Co., Ltd
//FCAFAC", "Socionext Inc.
//BC4DFB Hitron Technologies.Inc
//2C337A Hon Hai Precision Ind.Co., Ltd.
//84DDB7 Cilag GmbH International
//08EFAB SAYME WIRELESS SENSOR NETWORK
//7076FF KERLINK
//1436C6 Lenovo Mobile Communication Technology Ltd.
//68F728, "LCFC(HeFei) Electronics Technology co., ltd
//382C4A ASUSTek COMPUTER INC.
//307350, "Inpeco SA
//DCEC06 Heimi Network Technology Co., Ltd.
//CCBDD3 Ultimaker B.V.
//8CE78C DK Networks
//545146, "AMG Systems Ltd.
//8463D6, "Microsoft Corporation
//EC13B2 Netonix
//104E07, "Shanghai Genvision Industries Co., Ltd
//049B9C Eadingcore", "Intelligent Technology Co., Ltd.
//842690, "BEIJING THOUGHT SCIENCE CO., LTD.
//801967, "Shanghai Reallytek Information Technology", "Co., Ltd
//2CF7F1 Seeed Technology Inc.
//3C1E13 HANGZHOU SUNRISE TECHNOLOGY CO., LTD
//08115E, "Bitel Co., Ltd.
//0881BC HongKong Ipro Technology Co., Limited
//C09879", "Acer Inc.
//B84FD5 Microsoft Corporation
//D84A87", "OI ELECTRIC CO., LTD
//F03D29", "Actility
//88708C Lenovo Mobile Communication Technology Ltd.
//5014B5 Richfit Information Technology Co., Ltd
//CC3F1D", "Intesis Software SL
//DCDA4F", "GETCK TECHNOLOGY, INC
//101218, "Korins Inc.
//3428F0, "ATN International Limited
//CC10A3", "Beijing Nan Bao Technology Co., Ltd.
//5CAAFD Sonos, Inc.
//14EDE4 Kaiam Corporation
//D01242", "BIOS Corporation
//603696, "The Sapling Company
//54FFCF Mopria Alliance
//F4F26D", "TP-LINK TECHNOLOGIES CO., LTD.
//404EEB Higher Way Electronic Co., Ltd.
//C456FE Lava International Ltd.
//ACB74F METEL s.r.o.
//C0EEFB OnePlus Tech (Shenzhen) Ltd
//304225, "BURG-WÄCHTER KG
//FCDBB3 Murata Manufacturing Co., Ltd.
//CCF538", "3isysnetworks
//B8BD79", "TrendPoint Systems
//74F413, "Maxwell Forest
//A00627 NEXPA System
//303335, "Boosty
//44746C Sony Mobile Communications Inc
//4C9EFF Zyxel Communications Corporation
//BC9CC5 Beijing Huafei Technology Co., Ltd.
//5CB8CB Allis Communications
//34F0CA Shenzhen Linghangyuan Digital Technology Co., Ltd.
//70720D, "Lenovo Mobile Communication Technology Ltd.
//3CCD5A Technische Alternative GmbH
//FCAA14 GIGA-BYTE TECHNOLOGY CO., LTD.
//94D60E, "shenzhen yunmao information technologies co., ltd
//748F4D, "MEN Mikro Elektronik GmbH
//506787, "Planet Networks
//8CBF9D Shanghai Xinyou Information Technology Ltd. Co.
//9CAD97 Hon Hai Precision Ind.Co., Ltd.
//882950, "Netmoon Technology Co., Ltd
//7CE524 Quirky, Inc.
//F4D261 SEMOCON Co., Ltd
//48D855, "Telvent
//08F728, "GLOBO Multimedia Sp.z o.o.Sp.k.
//206E9C Samsung Electronics Co., Ltd
//6C2F2C Samsung Electronics Co., Ltd
//B009D3", "Avizia
//60C1CB Fujian Great Power PLC Equipment Co., Ltd
//BC25F0, "3D Display Technologies Co., Ltd.
//C03D46 Shanghai Sango Network Technology Co., Ltd
//64EAC5 SiboTech Automation Co., Ltd.
//30F7D7, "Thread Technology Co., Ltd
//18227E, "Samsung Electronics Co., Ltd
//30C7AE Samsung Electronics Co., Ltd
//44D4E0, "Sony Mobile Communications Inc
//FCD5D9 Shenzhen SDMC Technology Co., Ltd.
//74DA38 Edimax Technology Co. Ltd.
//E4F4C6 NETGEAR
//CCA0E5 DZG Metering GmbH
//60812B Custom Control Concepts
//1C1CFD Dalian Hi-Think Computer Technology, Corp
//90AE1B TP-LINK TECHNOLOGIES CO., LTD.
//60E327, "TP-LINK TECHNOLOGIES CO., LTD.
//48D18E, "Metis Communication Co., Ltd
//F86601", "Suzhou Chi-tek information technology Co., Ltd
//145645, "Savitech Corp.
//7062B8 D-Link International
//ACA919 TrekStor GmbH
//B025AA", "Private
//D4B43E", "Messcomp Datentechnik GmbH
//94C014 Sorter Sp.j.Konrad Grzeszczyk MichaA, Ziomek
//9CFBF1 MESOMATIC GmbH & Co.KG
//1027BE TVIP
//2087AC AES motomation
//709383, "Intelligent Optical Network High Tech CO., LTD.
//80D433, "LzLabs GmbH
//B0DA00 CERA ELECTRONIQUE
//1CAB01 Innovolt
//D8B6D6 Blu Tether Limited
//6C2C06 OOO NPP Systemotechnika-NN
//C4913A", "Shenzhen Sanland Electronic Co., ltd.
//68856A OuterLink Corporation
//9451BF Hyundai ESG
//F015A0", "KyungDong One Co., Ltd.
//C44E1F BlueN
//B0869E Chloride S.r.L
//D057A1", "Werma Signaltechnik GmbH & Co.KG
//B4B542", "Hubbell Power Systems, Inc.
//54CDEE ShenZhen Apexis Electronic Co., Ltd
//88E8F8, "YONG TAI ELECTRONIC (DONGGUAN) LTD.
//909864, "Impex-Sat GmbH&amp; Co KG
//DCE578 Experimental Factory of Scientific Engineering and Special Design Department
//D86595 Toy's Myth Inc.
//F4B52F Juniper Networks
//C0F79D", "Powercode
//C4C919", "Energy Imports Ltd
//38F098, "Vapor Stone Rail Systems
//64E892, "Morio Denki Co., Ltd.
//D8DD5F BALMUDA Inc.
//D86194 Objetivos y Sevicios de Valor Añadido
//E8FC60", "ELCOM Innovations Private Limited
//589CFC FreeBSD Foundation
//702C1F Wisol
//C8D429 Muehlbauer AG
//F85C45", "IC Nexus Co.Ltd.
//ACE069 ISAAC Instruments
//30B5C2 TP-LINK TECHNOLOGIES CO.,LTD.
//E07F53 TECHBOARD SRL
//48FEEA HOMA B.V.
//E8EA6A StarTech.com
//04DB8A Suntech International Ltd.
//90DFB7 s.m.s smart microwave sensors GmbH
//085700, "TP-LINK TECHNOLOGIES CO., LTD.
//FC27A2 TRANS ELECTRIC CO., LTD.
//FCBBA1 Shenzhen Minicreate Technology Co., Ltd
//F08A28", "JIANGSU HENGSION ELECTRONIC S and T CO., LTD
//28BB59 RNET Technologies, Inc.
//242642, "SHARP Corporation.
//34DE34 zte corporation
//FC1607", "Taian Technology(Wuxi) Co., Ltd.
//AC02CA HI Solutions, Inc.
//746F3D, "Contec GmbH
//4C0DEE JABIL CIRCUIT (SHANGHAI) LTD.
//D0634D Meiko Maschinenbau GmbH &amp; Co.KG
//008B43 RFTECH
//8C41F2 RDA Technologies Ltd.
//E036E3", "Stage One International Co., Ltd.
//DC052F National Products Inc.
//D0BD01 DS International
//8CDE99 Comlab Inc.
//4CE1BB Zhuhai HiFocus Technology Co., Ltd.
//24A87D Panasonic Automotive Systems Asia Pacific(Thailand) Co., Ltd.
//EC71DB Shenzhen Baichuan Digital Technology Co., Ltd.
//A409CB Alfred Kaercher GmbH &amp; Co KG
//8C569D Imaging Solutions Group
//40B6B1 SUNGSAM CO,.Ltd
//84FE9E RTC Industries, Inc.
//FC4B1C INTERSENSOR S.R.L.
//403067, "Conlog(Pty) Ltd
//E86183", "Black Diamond Advanced Technology, LLC
//38C9A9 SMART High Reliability Solutions, Inc.
//501AC5 Microsoft
//B0989F LG CNS
//C0F1C4", "Pacidal Corporation Ltd.
//600347, "Billion Electric Co.Ltd.
//F0D3A7 CobaltRay Co., Ltd
//38A53C COMECER Netherlands
//5CFFFF Shenzhen Kezhonglong Optoelectronic Technology Co., Ltd
//085240, "EbV Elektronikbau- und Vertriebs GmbH
//B8C1A2", "Dragon Path Technologies Co., Limited
//80F25E, "Kyynel
//68692E, "Zycoo Co., Ltd
//D46867", "Neoventus Design Group
//2C18AE Trend Electronics Co., Ltd.
//F81CE5 Telefonbau Behnke GmbH
//889166, "Viewcooper Corp.
//103378, "FLECTRON Co., LTD
//14EDA5 Wächter GmbH Sicherheitssysteme
//50C006 Carmanah Signs
//04CB1D Traka plc
//A4E9A3", "Honest Technology Co., Ltd
//A0E5E9", "enimai Inc
//9C216A TP-LINK TECHNOLOGIES CO., LTD.
//F862AA xn systems
//107BEF Zyxel Communications Corporation
//B462AD Elysia Germany GmbH
//345C40 Cargt Holdings LLC
//68193F, "Digital Airways
//B4750E Belkin International Inc.
//94103E, "Belkin International Inc.
//7CB733 ASKEY COMPUTER CORP
//3051F8, "BYK-Gardner GmbH
//E8F226 MILLSON CUSTOM SOLUTIONS INC.
//44EE30 Budelmann Elektronik GmbH
//FC1E16 IPEVO corp
//3C6E63 Mitron OY
//A4059E", "STA Infinity LLP
//A0BF50", "S.C.ADD-PRODUCTION S.R.L.
//E8D4E0 Beijing BenyWave Technology Co., Ltd.
//FC019E VIEVU
//642184, "Nippon Denki Kagaku Co., LTD
//2464EF, "CYG SUNRI CO., LTD.
//D8270C MaxTronic International Co., Ltd.
//B4CCE9 PROSYST
//C4D655 Tercel technology co., ltd
//58BDF9 Sigrand
//C0C687 Cisco SPVTG
//C49380", "Speedytel technology
//007DFA Volkswagen Group of America
//2C7155 HiveMotion
//20180E, "Shenzhen Sunchip Technology Co., Ltd
//80B219 ELEKTRON TECHNOLOGY UK LIMITED
//E0AEB2", "Bender GmbH &amp; Co.KG
//F84A7F", "Innometriks Inc
//74A4B5 Powerleader Science and Technology Co.Ltd.
//909F43, "Accutron Instruments Inc.
//2894AF Samhwa Telecom
//AC5036", "Pi-Coral Inc
//0C9B13 Shanghai Magic Mobile Telecommunication Co.Ltd.
//94BF1E eflow Inc. / Smart Device Planning and Development Division
//E8516E TSMART Inc.
//AC220B ASUSTek COMPUTER INC.
//B887A8 Step Ahead Innovations Inc.
//E0A198 NOJA Power Switchgear Pty Ltd
//88354C Transics
//3C6104 Juniper Networks
//CC4AE1", "fourtec -Fourier Technologies
//8C4B59", "3D Imaging & Simulations Corp
//5C3327 Spazio Italia srl
//507691, "Tekpea, Inc.
//28F532, "ADD-Engineering BV
//9440A2 Anywave Communication Technologies, Inc.
//1C86AD MCT CO., LTD.
//28D93E, "Telecor Inc.
//640B4A Digital Telecom Technology Limited
//384233, "Wildeboer Bauteile GmbH
//3C8AB0 Juniper Networks
//C034B4", "Gigastone Corporation
//CCE8AC SOYEA Technology Co., Ltd.
//70F176, "Data Modul AG
//B847C6", "SanJet Technology Corp.
//B8CD93 Penetek, Inc
//28DB81 Shanghai Guao Electronic Technology Co., Ltd
//3806B4 A.D.C.GmbH
//B8241A", "SWEDA INFORMATICA LTDA
//A0B100", "ShenZhen Cando Electronics Co., Ltd
//201D03, "Elatec GmbH
//E067B3 Shenzhen C-Data Technology Co., Ltd
//1C4AF7 AMON INC
//E4776B", "AARTESYS AG
//30F31D, "zte corporation
//A0EC80 zte corporation
//0CC81F Summer Infant, Inc.
//A8FB70 WiseSec L.t.d
//E481B3", "Shenzhen ACT Industrial Co., Ltd.
//C06C6D MagneMotion, Inc.
//E880D8 GNTEK Electronics Co., Ltd.
//303EAD Sonavox Canada Inc
//F835DD Gemtek Technology Co., Ltd.
//D8B04C Jinan USR IOT Technology Co., Ltd.
//CC04B4 Select Comfort
//5C15E1 AIDC TECHNOLOGY (S) PTE LTD
//E8519D", "Yeonhab Precision Co., LTD
//DC5726", "Power-One
//F8DADF", "EcoTech, Inc.
//30AE7B Deqing Dusun Electron CO., LTD
//68EC62 YODO Technology Corp. Ltd.
//188857, "Beijing Jinhong Xi-Dian Information Technology Corp.
//B8C855 Shanghai GBCOM Communication Technology Co., Ltd.
//78303B Stephen Technologies Co., Limited
//CC1AFA", "zte corporation
//6C8B2F zte corporation
//8C5AF0 Exeltech Solar Products
//B0808C Laser Light Engines
//D8DCE9 Kunshan Erlab ductless filtration system Co., Ltd
//DCD52A", "Sunny Heart Limited
//D866C6", "Shenzhen Daystar Technology Co., ltd
//D00EA4", "Porsche Cars North America
//784B08 f.robotics acquisitions ltd
//84E4D9, "Shenzhen NEED technology Ltd.
//40BC73 Cronoplast", "S.L.
//4007C0 Railtec Systems GmbH
//A4D3B5 GLITEL Stropkov, s.r.o.
//D43A65 IGRS Engineering Lab Ltd.
//F499AC WEBER Schraubautomaten GmbH
//D05099 ASRock Incorporation
//A49EDB", "AutoCrib, Inc.
//1C76CA Terasic Technologies Inc.
//888964, "GSI Electronics Inc.
//7CD844 Enmotus Inc
//44619C FONsystem co.ltd.
//70820E, "as electronics GmbH
//0C1105 AKUVOX (XIAMEN) NETWORKS CO., LTD
//5C22C4 DAE EUN ELETRONICS CO., LTD
//F8FEA8", "Technico Japan Corporation
//1800DB Fitbit Inc.
//78A106 TP-LINK TECHNOLOGIES CO., LTD.
//6C6126 Rinicom Holdings
//88685C Shenzhen ChuangDao & Perpetual Eternal Technology Co., Ltd
//102831, "Morion Inc.
//EC2C49 University of Tokyo
//D82916 Ascent Communication Technology
//2CF203 EMKO ELEKTRONIK SAN VE TIC AS
//B4FE8C", "Centro Sicurezza Italia SpA
//40E730, "DEY Storage Systems, Inc.
//68B094 INESA ELECTRON CO., LTD
//A073FC", "Rancore Technologies Private Limited
//44F849, "Union Pacific Railroad
//CC0DEC", "Cisco SPVTG
//1C37BF Cloudium Systems Ltd.
//50ABBF Hoseo Telecom
//0C722C TP-LINK TECHNOLOGIES CO., LTD.
//9CE635 Nintendo Co., Ltd.
//60A44C ASUSTek COMPUTER INC.
//185AE8 Zenotech.Co., Ltd
//C47DCC", "Zebra Technologies Inc
//E0AEED", "LOENK
//E492E7", "Gridlink Tech. Co., Ltd.
//CC047C G-WAY Microwave
//64535D, "Frauscher Sensortechnik
//3C6FF7 EnTek Systems, Inc.
//2C7B5A Milper Ltd
//D4BF2D", "SE Controls Asia Pacific Ltd
//E0D9A2", "Hippih aps
//FC0647 Cortland Research, LLC
//6CD146 FRAMOS GmbH
//54E032, "Juniper Networks
//7076DD Oxyguard International A/S
//5461EA Zaplox AB
//D08B7E", "Passif Semiconductor
//04586F, "Sichuan Whayer information industry Co., LTD
//FC9FAE", "Fidus Systems Inc
//681E8B InfoSight Corporation
//D052A8", "Physical Graph Corporation
//CC3A61", "SAMSUNG ELECTRO MECHANICS CO., LTD.
//F8D7BF REV Ritter GmbH
//48BE2D Symanitron
//F02329 SHOWA DENKI CO., LTD.
//F073AE PEAK-System Technik
//48B8DE HOMEWINS TECHNOLOGY CO., LTD.
//10EA59 Cisco SPVTG
//0C191F Inform Electronik
//1065CF IQSIM
//684CA8 Shenzhen Herotel Tech. Co., Ltd.
//98208E, "Definium Technologies
//704AE4 Rinstrum Pty Ltd
//083AB8 Shinoda Plasma Co., Ltd.
//A0DD97 PolarLink Technologies, Ltd
//EC89F5", "Lenovo Mobile Communication Technology Ltd.
//B49842 zte corporation
//7054D2, "PEGATRON CORPORATION
//645A04 Chicony Electronics Co., Ltd.
//AC1702 Fibar Group sp. z o.o.
//984CD3 Mantis Deposition
//08606E, "ASUSTek COMPUTER INC.
//3C57D5 FiveCo
//F84897 Hitachi, Ltd.
//F80BD0 Datang Telecom communication terminal (Tianjin) Co., Ltd.
//E89AFF Fujian LANDI Commercial Equipment Co., Ltd
//0C8CDC Suunto Oy
//60C5A8 Beijing LT Honway Technology Co., Ltd
//28D244, "LCFC(HeFei) Electronics Technology Co., Ltd.
//B4DF3B Chromlech
//7C9A9B VSE valencia smart energy
//84E714, "Liang Herng Enterprise, Co.Ltd.
//B829F7 Blaster Tech
//E4A7FD", "Cellco Partnership
//2CE2A8 DeviceDesign
//00B56D David Electronics Co., LTD.
//2C3557 ELLIY Power CO..Ltd
//B80415", "Bayan Audio
//D4136F Asia Pacific Brands
//C8E1A7 Vertu Corporation Limited
//4CAB33 KST technology
//F4472A", "Nanjing Rousing Sci.and Tech. Industrial Co., Ltd
//DC028E", "zte corporation
//A845E9 Firich Enterprises CO., LTD.
//485261, "SOREEL
//646223, "Cellient Co., Ltd.
//98473C SHANGHAI SUNMON COMMUNICATION TECHNOGY CO., LTD
//5481AD Eagle Research Corporation
//54A04F t-mac Technologies Ltd
//14DB85 S NET MEDIA
//B8DAF1 Strahlenschutz- Entwicklungs- und Ausruestungsgesellschaft mbH
//D45C70", "Wi-Fi Alliance
//EC473C Redwire, LLC
//3CC12C AES Corporation
//949BFD Trans New Technology, Inc.
//A00ABF Wieson Technologies Co., Ltd.
//8CCDE8 Nintendo Co., Ltd.
//7CB232 Hui Zhou Gaoshengda Technology Co., LTD
//00E666, "ARIMA Communications Corp.
//34BDFA Cisco SPVTG
//F41E26", "Simon-Kaloi Engineering
//702526, "Nokia
//18D949, "Qvis Labs, LLC
//D808F5", "Arcadia Networks Co.Ltd.
//0CC47E EUCAST Co., Ltd.
//50724D, "BEG Brueck Electronic GmbH
//783CE3 Kai-EE
//B898B0", "Atlona Inc.
//24694A Jasmine Systems Inc.
//080C0B SysMik GmbH Dresden
//DCBF90 HUIZHOU QIAOXING TELECOMMUNICATION INDUSTRY CO., LTD.
//049F06, "Smobile Co., Ltd.
//289A4B SteelSeries ApS
//A08C15", "Gerhard D. Wempe KG
//90CF6F Dlogixs Co Ltd
//C8FB26 Cisco SPVTG
//B85810", "NUMERA, INC.
//ECD950 IRT SA
//7C02BC Hansung Electronics Co. LTD
//B82410", "Magneti Marelli Slovakia s.r.o.
//105F49, "Cisco SPVTG
//1C5C60 Shenzhen Belzon Technology Co., LTD.
//B8B94E Shenzhen iBaby Labs, Inc.
//ACC698 Kohzu Precision Co., Ltd.
//7C386C Real Time Logic
//2067B1 Pluto inc.
//189A67 CSE-Servelec Limited
//087D21, "Altasec technology corporation
//F8051C", "DRS Imaging and Targeting Solutions
//78D34F, "Pace-O-Matic, Inc.
//A4466B EOC Technology
//901EDD GREAT COMPUTER CORPORATION
//34D7B4 Tributary Systems, Inc.
//F40F9B WAVELINK
//645FFF Nicolet Neuro
//AC7A42", "iConnectivity
//700BC0 Dewav Technology Company
//CC14A6 Yichun MyEnergy Domain, Inc
//109FA9 Actiontec Electronics, Inc
//C0A364, "3D Systems Massachusetts
//1C5FFF Beijing Ereneben Information Technology Co., Ltd Shenzhen Branch
//6045BD Microsoft
//241064, "Shenzhen Ecsino Tecnical Co. Ltd
//7CEBEA ASCT
//9C0DAC Tymphany HK Limited
//70B599 Embedded Technologies s.r.o.
//EC4C4D ZAO NPK RoTeK
//A4D18F Shenzhen Skyee Optical Fiber Communication Technology Ltd.
//58343B Glovast Technology Ltd.
//889676, "TTC MARCONI s.r.o.
//5C1737 I-View Now, LLC.
//AC0A61 Labor S.r.L.
//1C43EC JAPAN CIRCUIT CO., LTD
//54D1B0 Universal Laser Systems, Inc
//785262, "Shenzhen Hojy Software Co., Ltd.
//746A89 Rezolt Corporation
//702F4B PolyVision Inc.
//741489, "SRT Wireless
//241B13 Shanghai Nutshell Electronic Co., Ltd.
//20014F, "Linea Research Ltd
//EC0ED6", "ITECH INSTRUMENTS SAS
//240917, "Devlin Electronics Limited
//9C54CA Zhengzhou VCOM Science and Technology Co., Ltd
//B43564", "Fujian Tian Cheng Electron Science & Technical Development Co., Ltd.
//00BF15 Genetec Inc.
//38EE9D Anedo Ltd.
//78BEBD STULZ GmbH
//D4DF57", "Alpinion Medical Systems
//5048EB BEIJING HAIHEJINSHENG NETWORK TECHNOLOGY CO. LTD.
//B40E96 HERAN
//508C77 DIRMEIER Schanktechnik GmbH &Co KG
//40704A Power Idea Technology Limited
//545EBD NL Technologies
//F47F35", "Cisco Systems, Inc
//BCC168", "DinBox Sverige AB
//DC309C", "Heyrex Limited
//2C00F7 XOS
//28F606, "Syes srl
//0CAF5A GENUS POWER INFRASTRUCTURES LIMITED
//7CEF8A Inhon International Ltd.
//241125, "Hutek Co., Ltd.
//B431B8 Aviwest
//CC187B Manzanita Systems, Inc.
//08BE09 Astrol Electronic AG
//B41DEF Internet Laboratories, Inc.
//809393, "Xapt GmbH
//A007B6 Advanced Technical Support, Inc.
//0CD2B5 Binatone Telecommunication Pvt. Ltd
//4846F1, "Uros Oy
//B827EB Raspberry Pi Foundation
//84AF1F Beat System Service Co,. Ltd.
//B058C4 Broadcast Microwave Services, Inc
//745798, "TRUMPF Laser GmbH + Co.KG
//2817CE Omnisense Ltd
//3CCE73 Cisco Systems, Inc
//B0BD6D", "Echostreams Innovative Solutions
//6044F5, "Easy Digital Ltd.
//90AC3F BrightSign LLC
//AC51EE", "Cambridge Communication Systems Ltd
//78A183 Advidia
//A8D0E5 Juniper Networks
//F89955", "Fortress Technology Inc
//4CC94F Nokia
//0CE5D3 DH electronics GmbH
//E425E9 Color-Chip
//14B1C8 InfiniWing, Inc.
//E840F2 PEGATRON CORPORATION
//50053D, "CyWee Group Ltd
//F88C1C", "KAISHUN ELECTRONIC TECHNOLOGY CO., LTD.BEIJING
//1C0B52 EPICOM S.A
//747E2D, "Beijing Thomson CITIC Digital Technology Co. LTD.
//885C47 Alcatel Lucent
//3CC1F6 Melange Systems Pvt. Ltd.
//94FAE8 Shenzhen Eycom Technology Co., Ltd
//B48255", "Research Products Corporation
//8016B7 Brunel University
//008DDA Link One Co., Ltd.
//C49805 Minieum Networks, Inc
//90F4C1 Rand McNally
//18193F, "Tamtron Oy
//944444, "LG Innotek
//4C64D9 Guangdong Leawin Group Co., Ltd
//940149, "AutoHotBox
//1CB094 HTC Corporation
//9C0111 Shenzhen Newabel Electronic Co., Ltd.
//400E67, "Tremol Ltd.
//C0DF77 Conrad Electronic SE
//3055ED, "Trex Network LLC
//F0F755", "Cisco Systems, Inc
//1CB243 TDC A/S
//38BF33 NEC CASIO Mobile Communications
//B467E9", "Qingdao GoerTek Technology Co., Ltd.
//186751, "KOMEG Industrielle Messtechnik GmbH
//645EBE Yahoo! JAPAN
//CCC50A", "SHENZHEN DAJIAHAO TECHNOLOGY CO., LTD
//1CB17F NEC Platforms, Ltd.
//E42C56 Lilee Systems, Ltd.
//48ED80, "daesung eltec
//C80718 TDSi
//581D91, "Advanced Mobile Telecom co., ltd.
//D8BF4C Victory Concept Electronics Limited
//3CB9A6 Belden Deutschland GmbH
//8C0CA3 Amper
//94DF58 IJ Electron CO., Ltd.
//48D54C Jeda Networks
//8CDE52 ISSC Technologies Corp.
//082522, "ADVANSEE
//4C2F9D ICM Controls
//E467BA", "Danish Interpretation Systems A/S
//BCB852", "Cybera, Inc.
//C49300", "8Devices
//6CA682 EDAM information & communications
//28D576, "Premier Wireless, Inc.
//70D6B6 Metrum Technologies
//C0A0DE", "Multi Touch Oy
//40BC8B itelio GmbH
//9CA134 Nike, Inc.
//50FC30 Treehouse Labs
//B89674", "AllDSP GmbH & Co.KG
//48E1AF Vity
//1CBBA8 OJSC Ufimskiy Zavod Promsvyaz
//006BA0 SHENZHEN UNIVERSAL INTELLISYS PTE LTD
//A898C6 Shinbo Co., Ltd.
//B4211D Beijing GuangXin Technology Co., Ltd
//903CAE Yunnan KSEC Digital Technology Co., Ltd.
//70704C Purple Communications, Inc
//D89760", "C2 Development, Inc.
//F47ACC SolidFire, Inc.
//905682, "Lenbrook Industries Limited
//F0DA7C", "RLH INDUSTRIES, INC.
//AC319D Shenzhen TG-NET Botone Technology Co., Ltd.
//20107A Gemtek Technology Co., Ltd.
//78DDD6 c-scape
//C09132", "Patriot Memory
//90185E, "Apex Tool Group GmbH & Co OHG
//F8FE5C Reciprocal Labs Corp
//6C9CED Cisco Systems, Inc
//2486F4, "Ctek, Inc.
//C4237A WhizNets Inc.
//F4E6D7 Solar Power Technologies, Inc.
//B87424 Viessmann Elektronik GmbH
//B451F9 NB Software
//30168D, "ProLon
//E4AFA1", "HES-SO
//A887ED", "ARC Wireless LLC
//D4D249", "Power Ethernet
//80427C Adolf Tedsen GmbH & Co.KG
//E0DADC", "JVC KENWOOD Corporation
//E843B6", "QNAP Systems, Inc.
//B89BC9 SMC Networks Inc
//409FC7 BAEKCHUN I&C Co., Ltd.
//00FC58 WebSilicon Ltd.
//983571, "Sub10 Systems Ltd
//5404A6 ASUSTek COMPUTER INC.
//186D99, "Adanis Inc.
//A0E201 AVTrace Ltd.(China)
//F0DEB9", "ShangHai Y&Y Electronics Co., Ltd
//7CA61D MHL, LLC
//9CF67D Ricardo Prague, s.r.o.
//F82F5B eGauge Systems LLC
//98C845 PacketAccess
//989080, "Linkpower Network System Inc Ltd.
//F83376 Good Mind Innovation Co., Ltd.
//50F61A Kunshan JADE Technologies co., Ltd.
//542018, "Tely Labs
//581FEF Tuttnaer LTD
//58BDA3 Nintendo Co., Ltd.
//F8F25A G-Lab GmbH
//307ECB SFR
//68F125, "Data Controls Inc.
//BC764E Rackspace US, Inc.
//CCC8D7 CIAS Elettronica srl
//84D32A IEEE 1905.1
//4C0289 LEX COMPUTECH CO., LTD
//C0E54E", "ARIES Embedded GmbH
//F8C001", "Juniper Networks
//187C81 Valeo Vision Systems
//ACCC8E Axis Communications AB
//8C94CF Encell Technology, Inc.
//6CA780 Nokia Corporation
//3057AC IRLAB LTD.
//842B50 Huria Co., Ltd.
//48F7F1, "Nokia
//8C8E76 taskit GmbH
//A0133B", "HiTi Digital, Inc.
//9C5711 Feitian Xunda(Beijing) Aeronautical Information Technology Co., Ltd.
//88F488, "cellon communications technology(shenzhen) Co., Ltd.
//448E12, "DT Research, Inc.
//B8BB6D ENERES Co., Ltd.
//14373B PROCOM Systems
//1897FF TechFaith Wireless Technology Limited
//4C5585 Hamilton Systems
//ECEA03", "DARFON LIGHTING CORP
//30F9ED, "Sony Corporation
//582EFE Lighting Science Group
//CC60BB Empower RF Systems
//7CDD20 IOXOS Technologies S.A.
//ECF236 NEOMONTANA ELECTRONICS
//0418B6 Private
//E4A5EF TRON LINK ELECTRONICS CO., LTD.
//3071B2 Hangzhou Prevail Optoelectronic Equipment Co., LTD.
//DCCE41 FE GLOBAL HONG KONG LIMITED
//FC6C31 LXinstruments GmbH
//705CAD Konami Gaming Inc
//3C6F45 Fiberpro Inc.
//703187, "ACX GmbH
//30E4DB Cisco Systems, Inc
//88E0F3, "Juniper Networks
//80971B Altenergy Power System, Inc.
//587675, "Beijing ECHO Technologies Co., Ltd
//0C51F7 CHAUVIN ARNOUX
//0CFC83 Airoha Technology Corp.,
//007F28, "Actiontec Electronics, Inc
//804731, "Packet Design, Inc.
//B09BD4 GNH Software India Private Limited
//F08BFE COSTEL., CO.LTD
//3C26D5 Sotera Wireless
//E84E06", "EDUP INTERNATIONAL (HK) CO., LTD
//00077D, "Cisco Systems, Inc
//CCD9E9", "SCR Engineers Ltd.
//34A709 Trevil srl
//E0C922", "Jireh Energy Tech., Ltd.
//905F8D, "modas GmbH
//98293F, "Fujian Start Computer Equipment Co., Ltd
//B45CA4", "Thing-talk Wireless Communication Technologies Corporation Limited
//908D1D, "GH Technologies
//444F5E, "Pan Studios Co., Ltd.
//D0AFB6 Linktop Technology Co., LTD
//98EC65 Cosesy ApS
//ACC935", "Ness Corporation
//008D4E, "CJSC NII STT
//98F8DB Marini Impianti Industriali s.r.l.
//E41289 topsystem Systemhaus GmbH
//58E808, "AUTONICS CORPORATION
//DC05ED Nabtesco", "Corporation
//4C98EF Zeo
//00A1DE ShenZhen ShiHua Technology CO., LTD
//806CBC NET New Electronic Technology GmbH
//909060, "RSI VIDEO TECHNOLOGIES
//BC8199", "BASIC Co., Ltd.
//DCA7D9 Compressor Controls Corp
//38FEC5 Ellips B.V.
//C455A6 Cadac Holdings Ltd
//5C7757 Haivision Network Video
//D4D898 Korea CNO Tech Co., Ltd
//B4AA4D", "Ensequence, Inc.
//B83D4E Shenzhen Cultraview Digital Technology Co., Ltd Shanghai Branch
//5087B8 Nuvyyo Inc
//C0EAE4", "Sonicwall
//0838A5 Funkwerk plettac electronic GmbH
//CC1EFF", "Metrological Group BV
//184E94, "MESSOA TECHNOLOGIES INC.
//6C391D Beijing ZhongHuaHun Network Information center
//80B32A UK Grid Solutions Ltd
//405539, "Cisco Systems, Inc
//E0F211", "Digitalwatt
//F86971", "Seibu Electric Co.,
//44AA27 udworks Co., Ltd.
//E8F928 RFTECH SRL
//1C955D I-LAX ELECTRONICS INC.
//60F59C CRU-Dataport
//B0A72A", "Ensemble Designs, Inc.
//6400F1, "Cisco Systems, Inc
//B8F4D0", "Herrmann Ultraschalltechnik GmbH & Co.Kg
//08ACA5 Benu Video, Inc.
//586D8F, "Cisco-Linksys, LLC
//10E3C7 Seohwa Telecom
//7465D1, "Atlinks
//040A83 Alcatel-Lucent
//C45600", "Galleon Embedded Computing
//BC3E13", "Accordance Systems Inc.
//A81B18 XTS CORP
//D0A311", "Neuberger Gebäudeautomation GmbH
//041D10, "Dream Ware Inc.
//801440, "Sunlit System Technology Corp
//180B52 Nanotron Technologies GmbH
//DC07C1 HangZhou QiYang Technology Co., Ltd.
//C0A26D Abbott Point of Care
//00BB8E HME Co., Ltd.
//D82A7E Nokia Corporation
//801F02, "Edimax Technology Co.Ltd.
//58EECE Icon Time Systems
//647FDA TEKTELIC Communications Inc.
//AC0613 Senselogix Ltd
//747818, "Jurumani Solutions
//E01F0A Xslent Energy Technologies. LLC
//443719, "2 Save Energy Ltd
//84EA99 Vieworks
//E00C7F Nintendo Co., Ltd.
//E48AD5 RF WINDOW CO., LTD.
//FCF1CD OPTEX-FA CO., LTD.
//4425BB Bamboo Entertainment Corporation
//7CDA84 Dongnian Networks Inc.
//BCC61A SPECTRA EMBEDDED SYSTEMS
//0470BC Globalstar Inc.
//88DD79 Voltaire
//64F987, "Avvasi Inc.
//D85D84 CAx soft GmbH
//D4E32C S. Siedle & Sohne
//7C6ADB SafeTone Technology Co., Ltd
//902E87, "LabJack
//A424B3", "FlatFrog Laboratories AB
//94CDAC Creowave Oy
//144C1A Max Communication GmbH
//340804, "D-Link Corporation
//F05D89 Dycon Limited
//AC80D6", "Hexatronic AB
//9CF938 AREVA NP GmbH
//8CDB25 ESG Solutions
//FC3598", "Favite Inc.
//90D92C HUG-WITSCHI AG
//988E34, "ZHEJIANG BOXSAM ELECTRONIC CO., LTD
//C471FE", "Cisco Systems, Inc
//4022ED, "Digital Projection Ltd
//989449, "Skyworth Wireless Technology Ltd.
//2CA157 acromate, Inc.
//942053, "Nokia Corporation
//28852D, "Touch Networks
//B8BA68 Xi'an Jizhong Digital Communication Co.,Ltd
//B0B32B Slican Sp.z o.o.
//5842E4, "Baxter International Inc
//B8797E", "Secure Meters (UK) Limited
//CC9E00 Nintendo Co., Ltd.
//58A76F iD corporation
//0006F6, "Cisco Systems, Inc
//747DB6 Aliwei Communications, Inc
//B06563", "Shanghai Railway Communication Factory
//4018D7, "Smartronix, Inc.
//4C2C80 Beijing Skyway Technologies Co., Ltd
//D49E6D", "Wuhan Zhongyuan Huadian Science & Technology Co.,
//6C2E33 Accelink Technologies Co., Ltd.
//40987B Aisino Corporation
//BC38D2", "Pandachip Limited
//2005E8, "OOO InProMedia
//F00248 SmarteBuilding
//AC6F4F Enspert Inc
//E82877", "TMY Co., Ltd.
//F0C88C LeddarTech Inc.
//4037AD Macro Image Technology, Inc.
//28ED58, "JAG Jakob AG
//486B91 Fleetwood Group Inc.
//643409, "BITwave Pte Ltd
//40C245 Shenzhen Hexicom Technology Co., Ltd.
//CC55AD RIM
//E8757F FIRS Technologies(Shenzhen) Co., Ltd
//F0F7B3", "Phorm
//00D38D, "Hotel Technology Next Generation
//C83EA7 KUNBUS GmbH
//60893C Thermo Fisher Scientific P.O.A.
//D86BF7 Nintendo Co., Ltd.
//74CD0C Smith Myers Communications Ltd.
//CCCE40 Janteq Corp
//B8EE79", "YWire Technologies, Inc.
//74D675, "WYMA Tecnologia
//B40EDC LG-Ericsson Co., Ltd.
//E0EE1B Panasonic Automotive Systems Company of America
//74BE08 ATEK Products, LLC
//6063FD Transcend Communication Beijing Co., Ltd.
//D8B6C1 NetworkAccountant, Inc.
//74A4A7 QRS Music Technologies, Inc.
//700258, "01DB-METRAVIB
//F455E0", "Niceway CNC Technology Co., Ltd.Hunan Province
//20FDF1", "3COM EUROPE LTD
//8497B8 Memjet Inc.
//A0DDE5 SHARP Corporation
//206AFF Atlas Elektronik UK Limited
//AC34CB", "Shanhai GBCOM Communication Technology Co.Ltd
//9088A2 IONICS TECHNOLOGY ME LTDA
//40CD3A Z3 Technology
//482CEA Motorola Inc Business Light Radios
//00336C SynapSense Corporation
//2CD1DA Sanjole, Inc.
//F866F2 Cisco Systems, Inc
//AC6123", "Drivven, Inc.
//100C24 pomdevices, LLC
//58F6BF Kyoto University
//78EC22 Shanghai Qihui Telecom Technology Co., LTD
//0C15C5 SDTEC Co., Ltd.
//FC75E6 Handreamnet
//A0A763 Polytron Vertrieb GmbH
//EC2368 IntelliVoice Co., Ltd.
//749050, "Renesas Electronics Corporation
//389592, "Beijing Tendyron Corporation
//A4218A", "Nortel Networks
//F8FB2F Santur Corporation
//2CCD43 Summit Technology Group
//64995D, "LGE
//7CEF18 Creative Product Design Pty.Ltd.
//FC7CE7 FCI USA LLC
//145412, "Entis Co., Ltd.
//7C3E9D PATECH
//244597, "GEMUE Gebr. Mueller Apparatebau
//78818F, "Server Racks Australia Pty Ltd
//284846, "GridCentric Inc.
//30694B RIM
//6C626D Micro-Star INT'L CO., LTD
//28068D, "ITL, LLC
//C00D7E", "Additech, Inc.
//84C7A9 C3PO S.A.
//D87157 Lenovo Mobile Communication Technology Ltd.
//609AA4 GVI SECURITY INC.
//641084, "HEXIUM Technical Development Co., Ltd.
//342109, "Jensen Scandinavia AS
//3C106F ALBAHITH TECHNOLOGIES
//0CDDEF Nokia Corporation
//ECFE7E", "BlueRadios, Inc.
//E4AD7D SCL Elements
//F09CBB", "RaonThink Inc.
//10CCDB AXIMUM PRODUITS ELECTRONIQUES
//38C7BA CS Services Co., Ltd.
//EC5C69 MITSUBISHI HEAVY INDUSTRIES MECHATRONICS SYSTEMS, LTD.
//6C92BF Inspur Electronic Information Industry Co., Ltd.
//44A8C2 SEWOO TECH CO., LTD
//AC9A96", "Lantiq Deutschland GmbH
//80EE73 Shuttle Inc.
//FCE23F CLAY PAKY SPA
//58570D, "Danfoss Solar Inverters
//C4823F", "Fujian Newland Auto-ID Tech. Co,.Ltd.
//E85B5B LG ELECTRONICS INC
//BCA9D6 Cyber-Rain, Inc.
//6C3E9C KE Knestel Elektronik GmbH
//8CD628 Ikor Metering
//243C20 Dynamode Group
//3C39C3 JW Electronics Co., Ltd.
//3C05AB Product Creation Studio
//F04335 DVN(Shanghai) Ltd.
//A479E4 KLINFO Corp
//481BD2 Intron Scientific co., ltd.
//D0F0DB Ericsson
//7C1476 Damall Technologies SAS
//8C541D LGE
//00A2DA INAT GmbH
//003CC5 WONWOO Engineering Co., Ltd
//F077D0", "Xcellen
//4CC602 Radios, Inc.
//80711F, "Juniper Networks
//88FD15 LINEEYE CO., LTD
//884B39 Siemens AG, Healthcare Sector
//D828C9 General Electric Consumer and Industrial
//44C233 Guangzhou Comet Technology Development Co.Ltd
//30EFD1 Alstom Strongwish (Shenzhen) Co., Ltd.
//7C2CF3 Secure Electrans Ltd
//081651, "SHENZHEN SEA STAR TECHNOLOGY CO., LTD
//A863DF", "DISPLAIRE CORPORATION
//183BD2 BYD Precision Manufacture Company Ltd.
//E43593 Hangzhou GoTo technology Co.Ltd
//2C3A28 Fagor Electrónica
//B45861", "CRemote, LLC
//B0973A", "E-Fuel Corporation
//204E6B Axxana(israel) ltd
//80F593, "IRCO Sistemas de Telecomunicación S.A.
//E497F0 Shanghai VLC Technologies Ltd.Co.
//B40832 TC Communications
//ECDE3D", "Lamprey Networks, Inc.
//6CFFBE MPB Communications Inc.
//304174, "ALTEC LANSING LLC
//80B289 Forworld Electronics Ltd.
//E83A97 Toshiba Corporation
//1056CA Peplink International Ltd.
//486FD2 StorSimple Inc
//A03A75", "PSS Belgium N.V.
//24DBAD ShopperTrak RCT Corporation
//9CEBE8 BizLink (Kunshan) Co., Ltd
//040EC2 ViewSonic Mobile China Limited
//C8D1D1", "AGAiT Technology Corporation
//00DB45 THAMWAY CO., LTD.
//D49C28 JayBird LLC
//74F726, "Neuron Robotics
//2872C5 Smartmatic Corp
//E08FEC", "REPOTEC CO., LTD.
//ACE9AA Hay Systems Ltd
//082AD0 SRD Innovations Inc.
//889821, "TERAON
//E0E751", "Nintendo Co., Ltd.
//003AAF BlueBit Ltd.
//64168D, "Cisco Systems, Inc
//003A9C Cisco Systems, Inc
//7C6C8F AMS NEVE LTD
//9CB206 PROCENTEC
//88ED1C Cudo Communication Co., Ltd.
//9CCD82 CHENG UEI PRECISION INDUSTRY CO., LTD
//F06281", "ProCurve Networking by HP
//C09C92 COBY
//C038F9 Nokia Danmark A/S
//F46349", "Diffon Corporation
//74F07D, "BnCOM Co., Ltd
//F852DF", "VNL Europe AB
//A8CB95", "EAST BEST CO., LTD.
//F45FF7 DQ Technology Inc.
//7C3BD5 Imago Group
//5CE223 Delphin Technology AG
//F871FE The Goldman Sachs Group, Inc.
//2C1984 IDN Telecom, Inc.
//D8C3FB DETRACOM
//58F67B Xia Men UnionCore Technology LTD.
//6CF049 GIGA-BYTE TECHNOLOGY CO., LTD.
//644F74, "LENUS Co., Ltd.
//787F62, "GiK mbH
//401597, "Protect America, Inc.
//C4FCE4 DishTV NZ Ltd
//E80B13 Akib Systems Taiwan, INC
//EC6C9F", "Chengdu Volans Technology CO., LTD
//40EF4C Fihonest communication co., Ltd
//00271E, "Xagyl Communications
//00271D, "Comba Telecom Systems (China) Ltd.
//002720, "NEW-SOL COM
//0026F0, "cTrixs International GmbH.
//0026EA Cheerchip Electronic Technology (ShangHai) Co., Ltd.
//002708, "Nordiag ASA
//002702, "SolarEdge Technologies
//002704, "Accelerated Concepts, Inc
//0026FA BandRich Inc.
//0026F9, "S.E.M.srl
//0026FD Interactive Intelligence
//0026F7, "Nivetti Systems Pvt.Ltd.
//0026F6, "Military Communication Institute
//0026DD Fival Science & Technology Co., Ltd.
//0026DE FDI MATELEC
//0026DA Universal Media Corporation /Slovakia/ s.r.o.
//0026DB Ionics EMS Inc.
//0026D5, "Ory Solucoes em Comercio de Informatica Ltda.
//0026CE Kozumi USA Corp.
//002711, "LanPro Inc
//002686, "Quantenna Communcations, Inc.
//002684, "KISAN SYSTEM
//002680, "SIL3 Pty.Ltd
//0026BF ShenZhen Temobi Science&Tech Development Co., Ltd
//0026B4 Ford Motor Company
//0026CA Cisco Systems, Inc
//0026C9 Proventix Systems, Inc.
//002690, "I DO IT
//00268F, "MTA SpA
//002679, "Euphonic Technologies, Inc.
//0026AC Shanghai LUSTER Teraband photonic Co., Ltd.
//0026A6 TRIXELL
//00269C ITUS JAPAN CO. LTD
//002694, "Senscient Ltd
//002676, "COMMidt AS
//00261D, "COP SECURITY SYSTEM CORP.
//002617, "OEM Worldwide
//002613, "Engel Axil S.L.
//002638, "Xia Men Joyatech Co., Ltd.
//00263A Digitec Systems
//00260F, "Linn Products Ltd
//00260C Dataram
//00262B Wongs Electronics Co. Ltd.
//002620, "ISGUS GmbH
//002601, "Cutera Inc
//002635, "Bluetechnix GmbH
//002657, "OOO NPP EKRA
//002652, "Cisco Systems, Inc
//002666, "EFM Networks
//0025F5, "DVS Korea, Co., Ltd
//0025EB Reutech Radar Systems (PTY) Ltd
//0025EE Avtex Ltd
//0025AE Microsoft Corporation
//0025AF COMFILE Technology
//0025A8 Kontron (BeiJing) Technology Co., Ltd
//0025D9, "DataFab Systems Inc.
//0025D6, "The Kroger Co.
//0025D1, "Eastern Asia Technology Limited
//0025CD Skylane Optics
//0025BF Wireless Cables Inc.
//0025B9 Cypress Solutions Inc
//0025B6 Telecom FM
//0025A5 Walnut Media Network
//0025A4 EuroDesign embedded technologies GmbH
//0025C1 Nawoo Korea Corp.
//0025F6, "netTALK.com, Inc.
//00257A CAMCO Produktions- und Vertriebs-GmbH für", "Beschallungs- und Beleuchtungsanlagen
//002576, "NELI TECHNOLOGIES
//002574, "KUNIMI MEDIA DEVICE Co., Ltd.
//002559, "Syphan Technologies Ltd
//002554, "Pixel8 Networks
//002540, "Quasar Technologies, Inc.
//002533, "WITTENSTEIN AG
//002530, "Aetas Systems Inc.
//00252C Entourage Systems, Inc.
//00258C ESUS ELEKTRONIK SAN. VE DIS. TIC.LTD.STI.
//00255A Tantalus Systems Corp.
//002587, "Vitality, Inc.
//002573, "ST Electronics (Info-Security) Pte Ltd
//00256F, "Dantherm Power
//00252F, "Energy, Inc.
//00250A Security Expert Co.Ltd
//002505, "eks Engel GmbH & Co.KG
//002509, "SHARETRONIC Group LTD
//0024DA Innovar Systems Limited
//0024D8, "IlSung Precision
//0024CD Willow Garage, Inc.
//0024D3, "QUALICA Inc.
//0024CE Exeltech Inc
//0024CF Inscape Data Corporation
//0024C6 Hager Electro SAS
//0024FD Accedian Networks Inc
//002523, "OCP Inc.
//00251D, "DSA Encore, LLC
//00250F, "On-Ramp Wireless, Inc.
//0024F5, "NDS Surgical Imaging
//002467, "AOC International (Europe) GmbH
//00246D, "Weinzierl Engineering GmbH
//002470, "AUROTECH ultrasound AS.
//00246A Solid Year Co., Ltd.
//002492, "Motorola, Broadband Solutions Group
//00248B HYBUS CO., LTD.
//002484, "Bang and Olufsen Medicom a/s
//002480, "Meteocontrol GmbH
//00247A FU YI CHENG Technology Co., Ltd.
//002476, "TAP.tv
//0024B4 ESCATRONIC GmbH
//0024B1 Coulomb Technologies
//00249C Bimeng Comunication System Co.Ltd
//002498, "Cisco Systems, Inc
//002452, "Silicon Software GmbH
//002453, "Initra d.o.o.
//00244C Solartron Metrology Ltd
//002448, "SpiderCloud Wireless, Inc
//00244B PERCEPTRON INC
//002428, "EnergyICT
//002417, "Thomson Telecom Belgium
//002416, "Any Use
//00242A Hittite Microwave Corporation
//002422, "Knapp Logistik Automation GmbH
//00241B iWOW Communications Pte Ltd
//00245E, "Hivision Co., ltd
//00244D, "Hokkaido Electronics Corporation
//002442, "Axona Limited
//002400, "Nortel Networks
//0023FB IP Datatel, LLC.
//002409, "The Toro Company
//002406, "Pointmobile
//00243C S.A.A.A.
//0023D3, "AirLink WiFi Networking Corp.
//0023CA Behind The Set, LLC
//0023CB Shenzhen Full-join Technology Co., Ltd
//0023AD Xmark Corporation
//0023AB Cisco Systems, Inc
//0023A4 New Concepts Development Corp.
//0023DC Benein, Inc
//0023D1, "TRG
//0023FE Biodevices, SA
//0023F4, "Masternaut
//0023D0, "Uniloc USA Inc.
//0023C7 AVSystem
//0023C3 LogMeIn, Inc.
//0023B0 COMXION Technology Inc.
//0023E1, "Cavena Image Products AB
//00237E, "ELSTER GMBH
//00237C NEOTION
//00237A RIM
//00236D, "ResMed Ltd
//00236B Xembedded, Inc.
//002361, "Unigen Corporation
//00232C Senticare
//00232B IRD A/S
//002336, "METEL s.r.o.
//002338, "OJ-Electronics A/S
//00233B C-Matic Systems Ltd
//00232A eonas IT-Beratung und -Entwicklung GmbH
//002327, "Shouyo Electronics CO., LTD
//002328, "ALCON TELECOMMUNICATIONS CO., LTD.
//002372, "MORE STAR INDUSTRIAL GROUP LIMITED
//00234C KTC AB
//002343, "TEM AG
//00235F, "Silicon Micro Sensors GmbH
//002385, "ANTIPODE
//0022D8, "Shenzhen GST Security and Safety Technology Limited
//0022DC Vigil Health Solutions Inc.
//0022D9, "Fortex Industrial Ltd.
//0022D3, "Hub-Tech
//0022D4, "ComWorth Co., Ltd.
//0022FE Advanced Illumination
//002300, "Cayee Computer Ltd.
//0022F3, "SHARP Corporation
//0022F6, "Syracuse Research Corporation
//00230D, "Nortel Networks
//002303, "LITE-ON IT Corporation
//0022ED, "TSI Power Corporation
//0022E1, "ZORT Labs, LLC.
//0022E0, "Atlantic Software Technologies S.r.L.
//0022DF TAMUZ Monitors
//00231A ITF Co., Ltd.
//0022BC JDSU France SAS
//0022AA Nintendo Co., Ltd.
//0022C9 Lenord, Bauer & Co GmbH
//00228C Photon Europe GmbH
//00228B Kensington Computer Products Group
//00228D, "GBS Laboratories LLC
//00224C Nintendo Co., Ltd.
//00224A RAYLASE AG
//00224B AIRTECH TECHNOLOGIES, INC.
//002256, "Cisco Systems, Inc
//002252, "ZOLL Lifecor Corporation
//00224D, "MITAC INTERNATIONAL CORP.
//00229F, "Sensys Traffic AB
//002299, "SeaMicro Inc.
//00226D, "Shenzhen GIEC Electronics Co., Ltd.
//00226E, "Gowell Electronic Limited
//00225D, "Digicable Network India Pvt. Ltd.
//00227B Apogee Labs, Inc.
//002289, "Vandelrande APC inc.
//00227D, "YE DATA INC.
//0022A8 Ouman Oy
//002223, "TimeKeeping Systems, Inc.
//00221A Audio Precision
//002218, "AKAMAI TECHNOLOGIES INC
//00223C RATIO Entwicklungen GmbH
//0021E7, "Informatics Services Corporation
//0021DC TECNOALARM S.r.l.
//0021F1, "Tutus Data AB
//0021E3, "SerialTek LLC
//00221C Private
//002222, "Schaffner Deutschland GmbH
//0021F8, "Enseo, Inc.
//0021F3, "Si14 SpA
//002231, "SMT&C Co., Ltd.
//002213, "PCI CORPORATION
//002201, "Aksys Networks Inc
//00217B Bastec AB
//002176, "YMax Telecom Ltd.
//002171, "Wesung TNC Co., Ltd.
//002193, "Videofon MV
//002192, "Baoding Galaxy Electronic Technology", "Co., Ltd
//0021A7 Hantle System Co., Ltd.
//00219C Honeywld Technology Corp.
//00219A Cambridge Visual Networks Ltd
//0021D8, "Cisco Systems, Inc
//0021D7, "Cisco Systems, Inc
//0021D9, "SEKONIC CORPORATION
//0021DA Automation Products Group Inc.
//0021B5 Galvanic Ltd
//0021BD Nintendo Co., Ltd.
//0021C4 Consilium AB
//002189, "AppTech, Inc.
//002122, "Chip-pro Ltd.
//002125, "KUK JE TONG SHIN Co., LTD
//002126, "Shenzhen Torch Equipment Co., Ltd.
//002113, "Padtec S/A
//002112, "WISCOM SYSTEM CO., LTD
//00210E, "Orpak Systems L.T.D.
//002161, "Yournet Inc.
//00215F, "IHSE GmbH
//002135, "ALCATEL-LUCENT
//002138, "Cepheid
//002147, "Nintendo Co., Ltd.
//002149, "China Daheng Group , Inc.
//002156, "Cisco Systems, Inc
//002151, "Millinet Co., Ltd.
//00216C ODVA
//00211C Cisco Systems, Inc
//002118, "Athena Tech, Inc.
//001FBD Kyocera Wireless Corp.
//001FB9 Paltronics
//001FB7 WiMate Technologies Corp.
//001FB4 SmartShare Systems
//001FB6 Chi Lin Technology Co., Ltd.
//001FC8 Up-Today Industrial Co., Ltd.
//001FC5 Nintendo Co., Ltd.
//001FC0 Control Express Finland Oy
//001FBC EVGA Corporation
//001FF9 Advanced Knowledge Associates
//001FED Tecan Systems Inc.
//001FE5 In-Circuit GmbH
//001FF4 Power Monitors, Inc.
//001F5F, "Blatand GmbH
//001F57, "Phonik Innovation Co., LTD
//001F59, "Kronback Tracers
//001F4E, "ConMed Linvatec
//001FAA Taseon, Inc.
//001F7B TechNexion Ltd.
//001F7D, "Embedded Wireless GmbH
//001F8D, "Ingenieurbuero Stark GmbH und Ko.KG
//001FAF NextIO, Inc.
//001F74, "Eigen Development
//001F75, "GiBahn Media
//001F8F, "Shanghai Bellmann Digital Source Co., Ltd.
//001F84, "Gigle Semiconductor
//001F6E, "Vtech Engineering Corporation
//001F66, "PLANAR LLC
//001FA0 A10 Networks
//001F9E, "Cisco Systems, Inc
//001EE6 Shenzhen Advanced Video Info-Tech Co., Ltd.
//001EF7, "Cisco Systems, Inc
//001F0B, "Federal State Unitary Enterprise Industrial UnionElectropribor
//001F0C Intelligent Digital Services GmbH
//001F08, "RISCO LTD
//001F43, "ENTES ELEKTRONIK
//001F14, "NexG
//001EF1, "Servimat
//001EF4, "L-3 Communications Display Systems
//001EF5, "Hitek Automated Inc.
//001F0E, "Japan Kyastem Co., Ltd
//001F28, "HPN Supply Chain
//001F1E, "Astec Technology Co., Ltd
//001F4A Albentia Systems S.A.
//001EAA E-Senza Technologies GmbH
//001E9C Fidustron INC
//001E97, "Medium Link System Technology CO., LTD,
//001E8B Infra Access Korea Co., Ltd.
//001EBB BLUELIGHT TECHNOLOGY INC.
//001EB5 Ever Sparkle Technologies Ltd
//001EB3 Primex Wireless
//001E85, "Lagotek Corporation
//001ED8, "Digital United Inc.
//001ED6, "Alentec & Orion AB
//001EC6 Obvius Holdings LLC
//001EC4 Celio Corp
//001EC1", "3COM EUROPE LTD
//001EB6 TAG Heuer SA
//001EAC Armadeus Systems
//001E77, "Air2App
//001E7B R.I.CO.S.r.l.
//001E6E Shenzhen First Mile Communications Ltd
//001E6D, "IT R&D Center
//001E34, "CryptoMetrics
//001E2D, "STIM
//001E41, "Microwave Communication & Component, Inc.
//001DFC KSIC
//001E55, "COWON SYSTEMS, Inc.
//001E56, "Bally Wulff Entertainment GmbH
//001E3F, "TrellisWare Technologies, Inc.
//001E57, "ALCOMA, spol.s r.o.
//001E50, "BATTISTONI RESEARCH
//001E11, "ELELUX INTERNATIONAL LTD
//001DF2 Netflix, Inc.
//001DEF TRIMM, INC.
//001DF1 Intego Systems, Inc.
//001DED Grid Net, Inc.
//001DC3 RIKOR TV, Ltd
//001DC1 Audinate Pty L
//001DB2 HOKKAIDO ELECTRIC ENGINEERING CO., LTD.
//001DAD Sinotech Engineering Consultants, Inc.Geotechnical Enginee
//001DAB SwissQual License AG
//001D9C Rockwell Automation
//001DA0 Heng Yu Electronic Manufacturing Company Limited
//001DD8 Microsoft Corporation
//001DC8 Navionics Research Inc., dba SCADAmetrics
//001DCC Ayon Cyber Security, Inc
//001D92, "MICRO-STAR INT'L CO.,LTD.
//001D8A TechTrex Inc
//001D80, "Beijing Huahuan Eletronics Co., Ltd
//001D83, "Emitech Corporation
//001D74, "Tianjin China-Silicon Microelectronics Co., Ltd.
//001D4B Grid Connect Inc.
//001D4D, "Adaptive Recognition Hungary, Inc
//001D1E, "KYUSHU TEN CO., LTD
//001D1D, "Inter-M Corporation
//001D0E, "Agapha Technology co., Ltd.
//001D0A Davis Instruments, Inc.
//001D67, "AMEC
//001D7C ABE Elettronica S.p.A.
//001D6D, "Confidant International LLC
//001D75, "Radioscape PLC
//001D53, "S&O Electronics (Malaysia) Sdn. Bhd.
//001D54, "Sunnic Technology & Merchandise INC.
//001D5F, "OverSpeed SARL
//001D58, "CQ Inc
//001D87, "VigTech Labs Sdn Bhd
//001D2F, "QuantumVision Corporation
//001CE5 MBS Electronic Systems GmbH
//001CDD COWBELL ENGINEERING CO., LTD.
//001D05, "Eaton Corporation
//001CC2 Part II Research, Inc.
//001CBD Ezze Mobile Tech., Inc.
//001CB8 CBC Co., Ltd
//001CAC Qniq Technology Corp.
//001CA5 Zygo Corporation
//001C9D Liecthi AG
//001CFF Napera Networks Inc
//001CDC Custom Computer Services, Inc.
//001CD1 Waves Audio LTD
//001CED ENVIRONNEMENT SA
//001CBA VerScient, Inc.
//001CB0 Cisco Systems, Inc
//001C4C Petrotest Instruments
//001C45 Chenbro Micom Co., Ltd.
//001C3C Seon Design Inc.
//001C57 Cisco Systems, Inc
//001C5D Leica Microsystems
//001C5E ASTON France
//001C55 Shenzhen Kaifa Technology Co.
//001C5B Chubb Electronic Security Systems Ltd
//001C44 Bosch Security Systems BV
//001C82 Genew Technologies
//001C84 STL Solution Co., Ltd.
//001C79 Cohesive Financial Technologies LLC
//001C64 Landis+Gyr
//001C31 Mobile XP Technology Co., LTD
//001C8B MJ Innovations Ltd.
//001C6D KYOHRITSU ELECTRONIC INDUSTRY CO., LTD.
//001C96 Linkwise Technology Pte Ltd
//001C29 CORE DIGITAL ELECTRONICS CO., LTD
//001C24 Formosa Wireless Systems Corp.
//001C20 CLB Benelux
//001C1C Center Communication Systems GmbH
//001BDA UTStarcom Inc
//001BD1 SOGESTMATIC
//001C00 Entry Point, LLC
//001BFD Dignsys Inc.
//001BD6 Kelvin Hughes Ltd
//001BCF Dataupia Corporation
//001BCB PEMPEK SYSTEMS PTY LTD
//001BF5 Tellink Sistemas de Telecomunicación S.L.
//001BE6 VR AG
//001BE2 AhnLab, Inc.
//001BE0 TELENOT ELECTRONIC GmbH
//001C34 HUEY CHIAO INTERNATIONAL CO., LTD.
//001C36 iNEWiT NV
//001C15 iPhotonix LLC
//001C07 Cwlinux Limited
//001BA3 Flexit Group GmbH
//001B9F Calyptech Pty Ltd
//001B9A Apollo Fire Detectors Ltd
//001BBD FMC Kongsberg Subsea AS
//001BBE ICOP Digital
//001BB3 Condalo GmbH
//001BB7 Alta Heights Technology Corp.
//001B99 KS System GmbH
//001B8F Cisco Systems, Inc
//001B8C JMicron Technology Corp.
//001B91 EFKON AG
//001B82 Taiwan Semiconductor Co., Ltd.
//001B85 MAN Diesel SE
//001B89 EMZA Visual Sense Ltd.
//001B8B NEC Platforms, Ltd.
//001BAC Curtiss Wright Controls Embedded Computing
//001B6A Powerwave Technologies Sweden AB
//001B67 Cisco Systems Inc
//001B7B The Tintometer Ltd
//001B75 Hypermedia Systems
//001B27 Merlin CSI
//001B1B Siemens AG,
//001B1F DELTA - Danish Electronics, Light & Acoustics
//001B57 SEMINDIA SYSTEMS PRIVATE LIMITED
//001B55 Hurco Automation Ltd.
//001B53 Cisco Systems, Inc
//001B49 Roberts Radio limited
//001B0E InoTec GmbH Organisationssysteme
//001B04 Affinity International S.p.a
//001B06 Ateliers R.LAUMONIER
//001B31 Neural Image.Co.Ltd.
//001B29 Avantis.Co., Ltd
//001B2B Cisco Systems, Inc
//001B28 POLYGON, JSC
//001B43 Beijing DG Telecommunications equipment Co., Ltd
//001B3C Software Technologies Group, Inc.
//001B3D EuroTel Spa
//001B66 Sennheiser electronic GmbH & Co.KG
//001B60 NAVIGON AG
//001B05 YMC AG
//001AFF Wizyoung Tech.
//001B00 Neopost Technologies
//001B4E Navman New Zealand
//001B16 Celtro Ltd.
//001AE6 Atlanta Advanced Communications Holdings Limited
//001AD9 International Broadband Electric Communications, Inc.
//001AC8 ISL (Instrumentation Scientifique de Laboratoire)
//001AAB eWings s.r.l.
//001AAC Corelatus AB
//001AAF BLUSENS TECHNOLOGY
//001AB0 Signal Networks Pvt.Ltd.,
//001AA1 Cisco Systems, Inc
//001AC6 Micro Control Designs
//001AF2 Dynavisions Schweiz AG
//001A82 PROBA Building Automation Co., LTD
//001A7C Hirschmann Multimedia B.V.
//001A7A Lismore Instruments Limited
//001A78 ubtos
//001A76 SDT information Technology Co., LTD.
//001A70 Cisco-Linksys, LLC
//001A61 PacStar Corp.
//001A62 Data Robotics, Incorporated
//001A65 Seluxit
//001A54 Hip Shing Electronics Ltd.
//001A42 Techcity Technology co., Ltd.
//001A50 PheeNet Technology Corp.
//001A53 Zylaya
//001A4C Crossbow Technology, Inc
//001A1A Gentex Corporation/Electro-Acoustic Products
//001A12 Essilor
//001A7D cyber-blue(HK) Ltd
//001A60 Wave Electronics Co., Ltd.
//001A56 ViewTel Co,. Ltd.
//0019F3, "Cetis, Inc
//0019F5, "Imagination Technologies Ltd
//0019EF, "SHENZHEN LINNKING ELECTRONICS CO., LTD
//0019F7, "Onset Computer Corporation
//0019EE CARLO GAVAZZI CONTROLS SPA-Controls Division
//0019BF Citiway technology Co., ltd
//0019B6 Euro Emme s.r.l.
//0019EB Pyronix Ltd
//0019E7, "Cisco Systems, Inc
//0019E9, "S-Information Technolgy, Co., Ltd.
//0019DA Welltrans O&E Technology Co. , Ltd.
//001A14 Xin Hua Control Engineering Co., Ltd.
//001A10 LUCENT TRANS ELECTRONICS CO., LTD
//001A0C Swe-Dish Satellite Systems AB
//0019DC ENENSYS Technologies
//0019D0, "Cathexis
//0019D6, "LS Cable and System Ltd.
//0019D7, "FORTUNETEK CO., LTD
//001A02 SECURE CARE PRODUCTS, INC
//0019F8, "Embedded Systems Design, Inc.
//001A07 Arecont Vision
//001A08 Simoco Ltd.
//001A04 Interay Solutions BV
//0019C9 S&C ELECTRIC COMPANY
//0019B5 Famar Fueguina S.A.
//0019B8 Boundary Devices
//00195D, "ShenZhen XinHuaTong Opto Electronics Co., Ltd
//001953, "Chainleader Communications Corp.
//001955, "Cisco Systems, Inc
//001959, "Staccato Communications Inc.
//00194D, "Avago Technologies Sdn Bhd
//00194E, "Ultra Electronics - TCS (Tactical Communication Systems)
//0019AC GSP SYSTEMS Inc.
//0019B0 HanYang System
//001995, "Jurong Hi-Tech (Suzhou) Co.ltd
//00199A EDO-EVI
//001994, "Jorjin Technologies Inc.
//00197C Riedel Communications GmbH
//0019A0 NIHON DATA SYSTENS, INC.
//001991, "avinfo
//00198C iXSea
//001962, "Commerciant, LP
//00196F, "SensoPart GmbH
//0018DD Silicondust Engineering Ltd
//0018DF The Morey Corporation
//0018E1, "Verkerk Service Systemen
//0018DA Würth Elektronik eiSos GmbH & Co.KG
//0018D5, "REIGNCOM
//0018E7, "Cameo Communications, INC.
//0018E4, "YIGUANG
//0018E5, "Adhoco AG
//00190A HASWARE INC.
//001923, "Phonex Korea Co., LTD.
//00191C Sensicast Systems
//001928, "Siemens AG, Transportation Systems
//001915, "TECOM Co., Ltd.
//00191B Sputnik Engineering AG
//001909, "DEVI - Danfoss A/S
//001933, "Strix Systems, Inc.
//001904, "WB Electronics Sp.z o.o.
//001934, "TRENDON TOUCH TECHNOLOGY CORP.
//00190D, "IEEE 1394c
//001881, "Buyang Electronics Industrial Co., Ltd
//001876, "WowWee Ltd.
//00187A Wiremold
//00186C Neonode AB
//001873, "Cisco Systems, Inc
//00185F, "TAC Inc.
//0018D4, "Unified Display Interface SIG
//0018A7 Yoggie Security Systems LTD.
//0018A2 XIP Technology AB
//00189C Weldex Corporation
//00189A HANA Micron Inc.
//001864, "Eaton Corporation
//001866, "Leutron Vision
//001860, "SIM Technology Group Shanghai Simcom Ltd.,
//001897, "JESS-LINK PRODUCTS Co., LTD
//00189E, "OMNIKEY GmbH.
//0018A9 Ethernet Direct Corporation
//0018A8 AnNeal Technology Inc.
//0018C2 Firetide, Inc
//00183E, "Digilent, Inc
//001842, "Nokia Danmark A/S
//001840, "3 Phoenix, Inc.
//001844, "Heads Up Technologies, Inc.
//001821, "SINDORICOH
//001823, "Delta Electronics, Inc.
//001815, "GZ Technologies, Inc.
//001857, "Unilever R&D
//001853, "Atera Networks LTD.
//001859, "Strawberry Linux Co., Ltd.
//00184F, "8 Ways Technology Corp.
//001806, "Hokkei Industries Co., Ltd.
//001818, "Cisco Systems, Inc
//00181A AVerMedia Information Inc.
//001816, "Ubixon Co., Ltd.
//00182B Softier
//001829, "Gatsometer
//001838, "PanAccess Communications, Inc.
//0017F0, "SZCOM Broadband Network Technology Co., Ltd
//0017F1, "Renu Electronics Pvt Ltd
//0017FF PLAYLINE Co., Ltd.
//0017F6, "Pyramid Meriden Inc.
//0017C5 SonicWALL
//0017BE Tratec Telecom B.V.
//0017C0 PureTech Systems, Inc.
//0017BA SEDO CO., LTD.
//0017D4, "Monsoon Multimedia, Inc
//001780, "Applied Biosystems B.V.
//0017A5 Ralink Technology Corp
//0017A8 EDM Corporation
//0017A9 Sentivision
//0017AF Enermet
//0017AA elab-experience inc.
//0017AE GAI-Tronics
//0017B5 Peerless Systems Corporation
//00176C Pivot3, Inc.
//001770, "Arti Industrial Electronics Ltd.
//00178B Teledyne Technologies Incorporated
//0017DF Cisco Systems, Inc
//001746, "Freedom9 Inc.
//00174D, "DYNAMIC NETWORK FACTORY, INC.
//001744, "Araneo Ltd.
//001749, "HYUNDAE YONG-O-SA CO., LTD
//001743, "Deck Srl
//001728, "Selex Communications
//001722, "Hanazeder Electronic GmbH
//00173D, "Neology
//001740, "Bluberi Gaming Technologies Inc
//001732, "Science-Technical Center RISSA
//00176D, "CORE CORPORATION
//001773, "Laketune Technologies Co.Ltd
//00173A Cloudastructure Inc
//00172F, "NeuLion Incorporated
//001723, "Summit Data Communications
//00171F, "IMV Corporation
//001753, "nFore Technology Inc.
//001757, "RIX TECHNOLOGY LIMITED
//0016BB Law-Chain Computer Technology Co Ltd
//0016B4 Private
//0016A7 AWETA G&P
//001710, "Casa Systems Inc.
//0016BF PaloDEx Group Oy
//0016B7 Seoul Commtech
//0016E1, "SiliconStor, Inc.
//0016E2, "American Fibertek, Inc.
//001713, "Tiger NetCom
//0016CD HIJI HIGH-TECH CO., LTD.
//0016EF, "Koko Fitness, Inc.
//0016FD Jaty Electronics
//001678, "SHENZHEN BAOAN GAOKE ELECTRONICS CO., LTD
//001674, "EuroCB (Phils.), Inc.
//001670, "SKNET Corporation
//001689, "Pilkor Electronics Co., Ltd
//00168A id-Confirm Inc
//001686, "Karl Storz Imaging
//00168D, "KORWIN CO., Ltd.
//00168E, "Vimicro corporation
//00164F, "World Ethnic Broadcastin Inc.
//00167E, "DIBOSS.CO., LTD
//00167B Haver&Boecker
//001679, "eOn Communications
//0016A3 Ingeteam Transmission&Distribution, S.A.
//0016A0 Auto-Maskin
//00165D, "AirDefense, Inc.
//00165B Grip Audio
//001667, "A-TEC Subsystem INC.
//00164A Vibration Technology Limited
//001645, "Power Distribution, Inc.
//00163F, "CReTE SYSTEMS Inc.
//00163D, "Tsinghua Tongfang Legend Silicon Tech.Co., Ltd.
//00162D, "STNet Co., Ltd.
//001627, "embedded-logic DESIGN AND MORE GmbH
//00163A YVES TECHNOLOGY CO., LTD.
//001638, "TECOM Co., Ltd.
//001633, "Oxford Diagnostics Ltd.
//0015EC Boca Devices LLC
//0015EF, "NEC TOKIN Corporation
//0015E4, "Zimmer Elektromedizin
//001622, "BBH SYSTEMS GMBH
//001613, "LibreStream Technologies Inc.
//00160F, "BADGER METER INC
//001604, "Sigpro
//0015FB setex schermuly textile computer gmbh
//0015FE SCHILLING ROBOTICS LLC
//00160D, "Be Here Corporation
//0015C9 Gumstix, Inc
//0015BA iba AG
//0015BB SMA Solar Technology AG
//0015BF technicob
//001582, "Pulse Eight Limited
//00157B Leuze electronic GmbH + Co.KG
//001578, "Audio / Video Innovations
//0015AE kyung il
//0015BC Develco
//0015BD Group 4 Technology Ltd
//0015B5 CI Network Corp.
//0015CD Exartech International Corp.
//0015D9, "PKC Electronics Oy
//0015DD IP Control Systems Ltd.
//00159C B-KYUNG SYSTEM Co., Ltd.
//001595, "Quester Tangent Corporation
//001587, "Takenaka Seisakusho Co., Ltd
//00151A Hunter Engineering Company
//001514, "Hu Zhou NAVA Networks&Electronics Ltd.
//001516, "URIEL SYSTEMS INC.
//001545, "SEECODE Co., Ltd.
//001543, "Aberdeen Test Center
//001541, "StrataLight Communications, Inc.
//001569, "PECO II, Inc.
//001564, "BEHRINGER Spezielle Studiotechnik GmbH
//001563, "Cisco Systems, Inc
//001561, "JJPlus Corporation
//001571, "Nolan Systems
//001565, "XIAMEN YEALINK NETWORK TECHNOLOGY CO., LTD
//001538, "RFID, Inc.
//00152E, "PacketHop, Inc.
//001558, "FOXCONN
//00151F, "Multivision Intelligent Surveillance (Hong Kong) Ltd
//001522, "Dea Security
//00154F, "one RF Technology
//001501, "LexBox
//0014A3 Vitelec BV
//001497, "ZHIYUAN Eletronics co., ltd.
//001499, "Helicomm Inc
//001492, "Liteon, Mobile Media Solution SBU
//001494, "ESU AG
//0014EF, "TZero Technologies, Inc.
//0014BC SYNECTIC TELECOM EXPORTS PVT.LTD.
//0014B9 MSTAR SEMICONDUCTOR
//0014BD incNETWORKS, Inc
//0014B7 AR Infotek Inc.
//0014CA Key Radio Systems Limited
//0014C8 Contemporary Research Corp
//0014C5 Alive Technologies Pty Ltd
//0014DA Huntleigh Healthcare
//0014D5, "Datang Telecom Technology CO. , LCD, Optical Communication Br
//0014D3, "SEPSA
//0014D8, "bio-logic SA
//0014EE Western Digital Technologies, Inc.
//0014B5 PHYSIOMETRIX, INC
//00149C HF Company
//00145C Intronics B.V.
//00145A Neratec Solutions AG
//00145B SeekerNet Inc.
//001449, "Sichuan Changhong Electric Ltd.
//001446, "SuperVision Solutions LLC
//001440, "ATOMIC Corporation
//00142E, "77 Elektronika Kft.
//001430, "ViPowER, Inc
//001432, "Tarallax Wireless, Inc.
//001485, "Giga-Byte
//001483, "eXS Inc.
//001471, "Eastern Asia Technology Limited
//00146A Cisco Systems, Inc
//00144C General Meters Corp.
//001443, "Consultronics Europe Ltd
//001460, "Kyocera Wireless Corp.
//0013F5, "Akimbi Systems
//0013F1, "AMOD Technology Co., Ltd.
//0013E7, "Halcro
//0013EA Kamstrup A/S
//0013E1, "Iprobe AB
//0013E3, "CoVi Technologies, Inc.
//0013E4, "YANGJAE SYSTEMS CORP.
//0013C1 Asoka USA Corporation
//0013C0 Trix Tecnologia Ltda.
//00141F, "SunKwang Electronics Co., Ltd
//00141D, "LTI-Motion GmbH
//001412, "S-TEC electronics AG
//001411, "Deutschmann Automation GmbH & Co.KG
//001405, "OpenIB, Inc.
//004501, "Midmark RTLS
//001403, "Renasis, LLC
//001401, "Rivertree Networks Corp.
//0013D9, "Matrix Product Development, Inc.
//0013CC Tall Maple Systems
//001394, "Infohand Co., Ltd
//001389, "Redes de Telefonía Móvil S.A.
//00138C Kumyoung.Co.Ltd
//0013A1 Crow Electronic Engeneering
//00139C Exavera Technologies, Inc.
//001355, "TOMEN Cyber-business Solutions, Inc.
//001357, "Soyal Technology Co., Ltd.
//001360, "Cisco Systems, Inc
//00138E, "FOAB Elektronik AB
//001376, "Tabor Electronics Ltd.
//00135D, "NTTPC Communications, Inc.
//001352, "Naztec, Inc.
//00136C TomTom
//001364, "Paradigm Technology Inc..
//00136B E-TEC
//001380, "Cisco Systems, Inc
//001385, "Add-On Technology Co., LTD.
//0013B3 Ecom Communications Technology Co., Ltd.
//0013B7 Scantech ID
//001308, "Nuvera Fuel Cells
//001307, "Paravirtual Corporation
//0012FC PLANET System Co., LTD
//0012FE Lenovo Mobile Communication Technology Ltd.
//0012EC Movacolor b.v.
//0012EB PDH Solutions, LLC
//001343, "Matsushita Electronic Components (Europe) GmbH
//00133E, "MetaSwitch
//001345, "Eaton Corporation
//001347, "Red Lion Controls, LP
//00132E, "ITian Coporation
//001339, "CCV Deutschland GmbH
//001329, "VSST Co., LTD
//00132B Phoenix Digital
//00130B Mextal B.V.
//00130D, "GALILEO AVIONICA
//0012F7, "Xiamen Xinglian Electronics Co., Ltd.
//00131B BeCell Innovations Corp.
//0012E2, "ALAXALA Networks Corporation
//0012DF Novomatic AG
//0012D4, "Princeton Technology, Ltd
//0012D9, "Cisco Systems, Inc
//0012C2 Apex Electronics Factory
//0012BE Astek Corporation
//0012E1, "Alliant Networks, Inc
//0012C5 V-Show Technology (China) Co., Ltd
//0012AD IDS GmbH
//0012A0 NeoMeridian Sdn Bhd
//001286, "ENDEVCO CORP
//001263, "Data Voice Technologies GmbH
//001270, "NGES Denro Systems
//00126E, "Seidel Elektronik GmbH Nfg.KG
//00126F, "Rayson Technology Co., Ltd.
//00125C Green Hills Software, Inc.
//00125F, "AWIND Inc.
//00122D, "SiNett Corporation
//001274, "NIT lab
//001253, "AudioDev AB
//00124C BBWM Corporation
//001255, "NetEffect Incorporated
//001244, "Cisco Systems, Inc
//00122C Soenen Controls N.V.
//00122B Virbiage Pty Ltd
//001232, "LeWiz Communications Inc.
//001227, "Franklin Electric Co., Inc.
//00121A Techno Soft Systemnics Inc.
//00121B Sound Devices, LLC
//0011DF Current Energy
//0011D7, "eWerks Inc
//001204, "u10 Networks, Inc.
//00120A Emerson Climate Technologies GmbH
//001208, "Gantner Instruments GmbH
//001201, "Cisco Systems, Inc
//0011EE Estari, Inc.
//001200, "Cisco Systems, Inc
//0011E5, "KCodes Corporation
//0011DE EURILOGIC
//0011C8 Powercom Co., Ltd.
//0011B8 Liebherr - Elektronik GmbH
//0011B4 Westermo Network Technologies AB
//001178, "Chiron Technology Ltd
//00116A Domo Ltd
//001193, "Cisco Systems, Inc
//00118C Missouri Department of Transportation
//00118E, "Halytech Mace
//001186, "Prime Systems, Inc.
//001183, "Datalogic ADC, Inc.
//00117D, "ZMD America, Inc.
//00117F, "Neotune Information Technology Corporation,.LTD
//00119D, "Diginfo Technology Corporation
//00119C EP&T Energy
//00119A Alkeria srl
//0011C1", "4P MOBILE DATA PROCESSING
//0011B2", "2001 Technology Inc.
//0011AF Medialink-i, Inc
//00115E, "ProMinent Dosiertechnik GmbH
//00117C e-zy.net
//001139, "STOEBER ANTRIEBSTECHNIK GmbH + Co.KG.
//00113E, "JL Corporation
//001138, "TAISHIN CO., LTD.
//001136, "Goodrich Sensor Systems
//001132, "Synology Incorporated
//00114B Francotyp-Postalia GmbH
//001147, "Secom-Industry co.LTD.
//00114A KAYABA INDUSTRY Co,.Ltd.
//001142, "e-SMARTCOM INC.
//001120, "Cisco Systems, Inc
//001118, "BLX IC Design Corp., Ltd.
//001107, "RGB Networks Inc.
//001108, "Orbital Data Corporation
//00110C Atmark Techno, Inc.
//00114D, "Atsumi Electric Co., LTD.
//001130, "Allied Telesis (Hong Kong) Ltd.
//001129, "Paradise Datacom Ltd.
//001157, "Oki Electric Industry Co., Ltd.
//000FD9 FlexDSL Telecommunications AG
//000FD0 ASTRI
//000FCA A-JIN TECHLINE CO, LTD
//000FEC ARKUS Inc.
//000FED Anam Electronics Co., Ltd
//000FE5 MERCURY SECURITY CORPORATION
//000FAE E2O Communications
//000FB1 Cognio Inc.
//000FA7 Raptor Networks Technology
//000FF0 Sunray Co.Ltd.
//001103, "kawamura electric inc.
//000FDD SORDIN AB
//000FC3 PalmPalm Technology, Inc.
//000F88, "AMETEK, Inc.
//000F7E, "Ablerex Electronics Co., LTD
//000F83, "Brainium Technologies Inc.
//000F84, "Astute Networks, Inc.
//000F5C Day One Digital Media Limited
//000F52, "YORK Refrigeration, Marine & Controls
//000F4C Elextech INC
//000F93, "Landis+Gyr Ltd.
//000F94, "Genexis BV
//000F6C ADDI-DATA GmbH
//000F8F, "Cisco Systems, Inc
//000F7D, "Xirrus
//000F76, "Digital Keystone, Inc.
//000F9E, "Murrelektronik GmbH
//000F79, "Bluetooth Interest Group Inc.
//000F17, "Insta Elektro GmbH
//000F1E, "Chengdu KT Electric Co.of High & New Technology
//000F15, "Icotera A/S
//000F39, "IRIS SENSORS
//000F3E, "CardioNet, Inc
//000F3F, "Big Bear Networks
//000F35, "Cisco Systems, Inc
//000F36, "Accurate Techhnologies, Inc.
//000F28, "Itronix Corporation
//000F23, "Cisco Systems, Inc
//000F22, "Helius, Inc.
//000F24, "Cisco Systems, Inc
//000EFC JTAG Technologies B.V.
//000EFE EndRun Technologies LLC
//000F2C Uplogix, Inc.
//000F2B GREENBELL SYSTEMS
//000EF2, "Infinico Corporation
//000F0D, "Hunt Electronic Co., Ltd.
//000F08, "Indagon Oy
//000F04, "cim-usa inc
//000F42, "Xalyo Systems
//000EA5 BLIP Systems
//000EA0 NetKlass Technology Inc.
//000EE4 BOE TECHNOLOGY GROUP CO., LTD
//000EDE REMEC, Inc.
//000E9C Benchmark Electronics
//000E9A BOE TECHNOLOGY GROUP CO., LTD
//000E90, "PONICO CORP.
//000E8A Avara Technologies Pty. Ltd.
//000EB8 Iiga co., Ltd
//000EBE B&B Electronics Manufacturing Co.
//000EBB Everbee Networks
//000ECE S.I.T.T.I.S.p.A.
//000ED4, "CRESITT INDUSTRIE
//000ED6, "Cisco Systems, Inc
//000ED8, "Positron Access Solutions Corp
//000ED1, "Osaka Micro Computer.
//000EB0 Solutions Radio BV
//000E83, "Cisco Systems, Inc
//000E81, "Devicescape Software, Inc.
//000E88, "VIDEOTRON CORP.
//000E86, "Alcatel North America
//000E69, "China Electric Power Research Institute
//000E61, "MICROTROL LIMITED
//000E64, "Elphel, Inc
//000E49, "Forsway Scandinavia AB
//000E42, "Motic Incoporation Ltd.
//000E3D, "Televic N.V.
//000E39, "Cisco Systems, Inc
//000E34, "NexGen City, LP
//000E6A", "3Com Ltd
//000E5A TELEFIELD inc.
//000E5D, "Triple Play Technologies A/S
//000E52, "Optium Corporation
//000E7E ionSign Oy
//000E77, "Decru, Inc.
//000E4D, "Numesa Inc.
//000E4C Bermai Inc.
//000E2D, "Hyundai Digital Technology Co., Ltd.
//000E30, "AERAS Networks, Inc.
//000E29, "Shester Communications Inc
//000DE1 Control Products, Inc.
//000DD0 TetraTec Instruments GmbH
//000DD3 SAMWOO Telecommunication Co., Ltd.
//000DD8 BBN
//000DB3 SDO Communication Corperation
//000DAE SAMSUNG HEAVY INDUSTRIES CO., LTD.
//000DB2 Ammasso, Inc.
//000E0D, "Hesch Schröder GmbH
//000DF6 Technology Thesaurus Corp.
//000DFF CHENMING MOLD INDUSTRY CORP.
//000DC7 COSMIC ENGINEERING INC.
//000DC2 Private
//000DBF TekTone Sound & Signal Mfg., Inc.
//000E19, "LogicaCMG Pty Ltd
//000E1A JPS Communications
//000E06, "Team Simoco Ltd
//000D5C Robert Bosch GmbH, VT-ATMO
//000D60, "IBM Corp
//000D67, "Ericsson
//000D5F, "Minds Inc
//000D9C Elan GmbH & Co KG
//000D98, "S.W.A.C.Schmitt-Walter Automation Consult GmbH
//000D8C Shanghai Wedone Digital Ltd.CO.
//000D94, "AFAR Communications, Inc
//000DAA S.A.Tehnology co., Ltd.
//000DA6 Universal Switching Corporation
//000D8D, "Prosoft Technology, Inc
//000D84, "Makus Inc.
//000D73, "Technical Support, Inc.
//000D69, "TMT&D Corporation
//000DA2 Infrant Technologies, Inc.
//000D68, "Vinci Systems, Inc.
//000D64, "COMAG Handels AG
//000D74, "Sand Network Systems, Inc.
//000D7D, "Afco Systems
//000D54, "3Com Ltd
//000D4C Outline Electronics Ltd.
//000D0F, "Finlux Ltd
//000D12, "AXELL Corporation
//000D34, "Shell International Exploration and Production, Inc.
//000D32, "DispenseSource, Inc.
//000CF6 Sitecom Europe BV
//000CF2 GAMESA Eólica
//000D2E, "Matsushita Avionics Systems Corporation
//000D28, "Cisco Systems, Inc
//000D4D, "Ninelanes
//000D53, "Beijing 5w Communication Corp.
//000CFC S2io Technologies Corp
//000D38, "NISSIN INC.
//000D15, "Voipac s.r.o.
//000CA1 SIGMACOM Co., LTD.
//000CA6 Mintera Corporation
//000CC1 Eaton Corporation
//000C8B Connect Tech Inc
//000C90 Octasic Inc.
//000C8C KODICOM CO., LTD.
//000CC2 ControlNet (India) Private Limited
//000C94 United Electronic Industries, Inc. (EUI)
//000C9B EE Solutions, Inc
//000CE1 The Open Group
//000CDC BECS Technology, Inc
//000CC5 Nextlink Co., Ltd.
//000CDE ABB STOTZ-KONTAKT GmbH
//000CBF Holy Stone Ent. Co., Ltd.
//000C4D Curtiss-Wright Controls Avionics & Electronics
//000C44 Automated Interfaces, Inc.
//000C3B Orion Electric Co., Ltd.
//000C71 Wybron, Inc
//000C72 Tempearl Industrial Co., Ltd.
//000C78 In-Tech Electronics Limited
//000C59 Indyme Electronics, Inc.
//000C5C GTN Systems B.V.
//000C55 Microlink Communications Inc.
//000C52 Roll Systems Inc.
//000C74 RIVERTEC CORPORATION
//000C67 OYO ELECTRIC CO., LTD
//000C2E Openet information technology(shenzhen) Co., Ltd.
//000C2C Enwiser Inc.
//000C28 RIFATRON
//000C3D Glsystech Co., Ltd.
//000C2F SeorimTechnology Co., Ltd.
//000C31 Cisco Systems, Inc
//000C53 Private
//000C48 QoStek Corporation
//000C63 Zenith Electronics Corporation
//000BBB Etin Systems Co., Ltd
//000BBC En Garde Systems, Inc.
//000BB1 Super Star Technology Co., Ltd.
//000BBF Cisco Systems, Inc
//000BAD PC-PoS Inc.
//000BA0 T&L Information Inc.
//000C17 AJA Video Systems Inc
//000C11 NIPPON DEMPA CO., LTD.
//000C14 Diagnostic Instruments, Inc.
//000BB5 nStor Technologies, Inc.
//000BB9 Imsys AB
//000C21 Faculty of Science and Technology, Keio University
//000C1B ORACOM Co, Ltd.
//000BC9 Electroline Equipment
//000BC2 Corinex Communication Corp.
//000BF7 NIDEK CO., LTD
//000C00 BEB Industrie-Elektronik AG
//000BF3 BAE SYSTEMS
//000BED ELM Inc.
//000B91 Aglaia Gesellschaft für Bildverarbeitung und Kommunikation mbH
//000B97 Matsushita Electric Industrial Co., Ltd.
//000B92 Ascom Danmark A/S
//000B9A Shanghai Ulink Telecom Equipment Co. Ltd.
//000B9D TwinMOS Technologies Inc.
//000B96 Innotrac Diagnostics Oy
//000B56 Cybernetics
//000B50 Oxygnet
//000B52 JOYMAX ELECTRONICS CO. LTD.
//000B69 Franke Finland Oy
//000BA5 Quasar Cipta Mandiri, PT
//000B49 RF-Link System Inc.
//000B46 Cisco Systems, Inc
//000B7A L-3 Linkabit
//000B84 BODET
//000B77 Cogent Systems, Inc.
//000B66 Teralink Communications
//000B2C Eiki Industrial Co. Ltd.
//000B26 Wetek Corporation
//000B28 Quatech Inc.
//000B2A HOWTEL Co., Ltd.
//000B30 Beijing Gongye Science & Technology Co., Ltd
//000AF2 NeoAxiom Corp.
//000AF5 Airgo Networks, Inc.
//000AF0 SHIN-OH ELECTRONICS CO., LTD.R&D
//000AF4 Cisco Systems, Inc
//000AEE GCD Hard- & Software GmbH
//000AD8 IPCserv Technology Corp.
//000AD7 Origin ELECTRIC CO., LTD.
//000B38 Knürr GmbH
//000B32 VORMETRIC, INC.
//000B07 Voxpath Networks
//000B04 Volktek Corporation
//000AF9 HiConnect, Inc.
//000B1F I CON Computer Co.
//000B13 ZETRON INC
//000B10", "11wave Technonlogy Co., Ltd
//000AE9 AirVast Technology Inc.
//000B2B HOSTNET CORPORATION
//000B02 Dallmeier electronic
//000ACD Sunrich Technology Limited
//000ACC Winnow Networks, Inc.
//000ACF PROVIDEO Multimedia Co. Ltd.
//000AD1 MWS
//000A7D Valo, Inc.
//000A7F Teradon Industries, Inc
//000A81 TEIMA Audiotex S.L.
//000A87 Integrated Micromachines Inc.
//000A77 Bluewire Technologies LLC
//000A8C Guardware Systems Ltd.
//000A96 MEWTEL TECHNOLOGY INC.
//000A82 TATSUTA SYSTEM ELECTRONICS CO., LTD.
//000AD3 INITECH Co., Ltd
//000AC8 ZPSYS CO., LTD. (Planning&Management)
//000AC6 Overture Networks.
//000AAB Toyota Technical Development Corporation
//000AB4 ETIC Telecommunications
//000A7A Kyoritsu Electric Co., Ltd.
//000A9C Server Technology, Inc.
//000A75 Caterpillar, Inc
//000A12 Azylex Technology, Inc
//000A13 Honeywell Video Systems
//000A09 TaraCom Integrated Products, Inc.
//000A41 Cisco Systems, Inc
//000A36 Synelec Telecom Multimedia
//000A48 Albatron Technology
//000A3E EADS Telecom
//000A59 HW server
//000A54 Laguna Hills, Inc.
//000A4F Brain Boxes Limited
//000A52 AsiaRF Ltd.
//000A02 ANNSO CO., LTD.
//000A65 GentechMedia.co., ltd.
//000A22 Amperion Inc
//000A1C Bridge Information Co., Ltd.
//000A32 Xsido Corporation
//000A2B Etherstuff
//000A42 Cisco Systems, Inc
//000A38 Apani Networks
//0009A8 Eastmode Pte Ltd
//0009AA Data Comm for Business, Inc.
//0009A4 HARTEC Corporation
//0009A6 Ignis Optics, Inc.
//0009A7 Bang & Olufsen A/S
//0009C8 SINAGAWA TSUSHIN KEISOU SERVICE
//0009B7 Cisco Systems, Inc
//0009B2 L&F Inc.
//0009F3, "WELL Communication Corp.
//0009EF, "Vocera Communications
//0009C4 Medicore Co., Ltd
//0009D9, "Neoscale Systems, Inc
//0009D0, "Solacom Technologies Inc.
//0009CC Moog GmbH
//000A00 Mediatek Corp.
//0009F0, "Shimizu Technology Inc.
//0009E4, "K Tech Infosystem Inc.
//000972, "Securebase, Inc
//000978, "AIJI System Co., Ltd.
//000973, "Lenten Technology Co., Ltd.
//000975, "fSONA Communications Corporation
//000977, "Brunner Elektronik AG
//000969, "Meret Optical Communications
//000942, "Wireless Technologies, Inc
//000945, "Palmmicro Communications Inc
//00093E, "C&I Technologies
//000940, "AGFEO GmbH & Co.KG
//00097F, "Vsecure 2000 LTD.
//000980, "Power Zenith Inc.
//0009A0 Microtechno Corporation
//00099B Western Telematic Inc.
//000990, "ACKSYS Communications & systems
//000953, "Linkage System Integration Co.Ltd.
//00094C Communication Weaver Co., Ltd.
//00096E, "GIANT ELECTRONICS LTD.
//00096C Imedia Semiconductor Corp.
//00095F, "Telebyte, Inc.
//00098A EqualLogic Inc
//0008F9, "Artesyn Embedded Technologies
//0008F4, "Bluetake Technology Co., Ltd.
//0008F7, "Hitachi Ltd, Semiconductor & Integrated Circuits Gr
//000920, "EpoX COMPUTER CO., LTD.
//000922, "TST Biometrics GmbH
//000916, "Listman Home Technologies, Inc.
//000911, "Cisco Systems, Inc
//000912, "Cisco Systems, Inc
//000908, "VTech Technology Corp.
//00090B MTL", "Instruments PLC
//00093B HYUNDAI NETWORKS INC.
//000934, "Dream-Multimedia-Tv GmbH
//000931, "Future Internet, Inc.
//0008F5, "YESTECHNOLOGY Co., Ltd.
//0008EC Optical Zonu Corporation
//0008E6, "Littlefeet
//000930, "AeroConcierge Inc.
//00091E, "Firstech Technology Corp.
//0008E2, "Cisco Systems, Inc
//000905, "iTEC Technologies Ltd.
//0008A5 Peninsula Systems Inc.
//0008A2 ADI Engineering, Inc.
//000898, "Gigabit Optics Corporation
//00089B ICP Electronics Inc.
//00089C Elecs Industry Co., Ltd.
//00089D, "UHD-Elektronik
//0008CF Nippon Koei Power Systems Co., Ltd.
//0008CB Zeta Broadband Inc.
//0008D3, "Hercules Technologies S.A.S.
//0008D0, "Musashi Engineering Co., LTD.
//0008BA Erskine Systems Ltd
//0008B5 TAI GUEN ENTERPRISE CO., LTD
//0008B7 HIT Incorporated
//0008A9 SangSang Technology, Inc.
//0008C8 Soneticom, Inc.
//0008C4 Hikari Co., Ltd.
//00088F, "ADVANCED DIGITAL TECHNOLOGY
//00088B Tropic Networks Inc.
//00086B MIPSYS
//00087F, "SPAUN electronic GmbH & Co.KG
//000886, "Hansung Teliann, Inc.
//000858, "Novatechnology Inc.
//000850, "Arizona Instrument Corp.
//00085B Hanbit Electronics Co., Ltd.
//00082B Wooksung Electronics, Inc.
//00082E, "Multitone Electronics PLC
//0007ED, "Altera Corporation
//0007F1, "TeraBurst Networks Inc.
//0007F2, "IOA Corporation
//0007EA Massana, Inc.
//0007F0, "LogiSync LLC
//0007E7, "FreeWave Technologies
//0007D6, "Commil Ltd.
//0007D7, "Caporis Networks AG
//0007D4, "Zhejiang Yutong Network Communication Co Ltd.
//0007CE Cabletime Limited
//0007D3, "SPGPrints B.V.
//000813, "Diskbank, Inc.
//00080F, "Proximion Fiber Optics AB
//000812, "GM-2 Corporation
//00080B Birka BPA Informationssystem AB
//00080A Espera-Werke GmbH
//0007E3, "Navcom Technology, Inc.
//0007E1, "WIS Communications Co.Ltd.
//0007E0, "Palm Inc.
//0007FA ITT Co., Ltd.
//0007F6, "Qqest Software Systems
//0007FB Giga Stream UMTS Technologies GmbH
//00085D, "Mitel Corporation
//000855, "NASA-Goddard Space Flight Center
//00085A IntiGate Inc.
//000817, "EmergeCore Networks LLC
//000815, "CATS Co., Ltd.
//000818, "Pixelworks, Inc.
//00082A Powerwallz Network Security
//0007AC Eolring
//0007AA Quantum Data Inc.
//0007A4 GN Netcom Ltd.
//00079D, "Musashi Co., Ltd.
//00079F, "Action Digital Inc.
//00047C Skidata AG
//0007BE DataLogic SpA
//0007AF Red Lion Controls, LP
//000767, "Yuxing Electronics Company Limited
//00075B Gibson Guitars
//000762, "Group Sense Limited
//000784, "Cisco Systems, Inc
//000776, "Federal APD
//00077A Infoware System Co., Ltd.
//000790, "Tri-M Technologies (s) Limited
//00078D, "NetEngines Ltd.
//00078A Mentor Data System Inc.
//000792, "Sütron Electronic GmbH
//0007B2 Transaccess S.A.
//0007AD Pentacon GmbH Foto-und Feinwerktechnik
//0007D0, "Automat Engenharia de Automação Ltda.
//00076A NEXTEYE Co., Ltd.
//0006E6, "DongYang Telecom Co., Ltd.
//0006DC Syabas Technology (Amquest)
//00070C SVA-Intrusion.com Co. Ltd.
//00070F, "Fujant, Inc.
//000714, "Brightcom
//0006F3, "AcceLight Networks
//0006D2, "Tundra Semiconductor Corp.
//0006D8, "Maple Optical Systems
//0006CF Thales Avionics In-Flight Systems, LLC
//0006FE Ambrado, Inc
//0006E7, "Bit Blitz Communications Inc.
//0006ED, "Inara Networks
//0006DB ICHIPS Co., Ltd.
//000727, "Zi Corporation (HK) Ltd.
//00072E, "North Node AB
//000699, "Vida Design Co.
//00068D, "SEPATON, Inc.
//0006A3 Bitran Corporation
//00069F, "Kuokoa Networks
//0006A2 Microtune, Inc.
//0006A6 Artistic Licence Engineering Ltd
//0006B8 Bandspeed Pty Ltd
//0006BB ATI Technologies Inc.
//0006BD BNTECHNOLOGY Co., Ltd.
//0006C3 Schindler Elevator Ltd.
//0006AA VT Miltope
//000657, "Market Central, Inc.
//000697, "R & D Center
//00069A e & Tel
//00067D, "Takasago Ltd.
//000671, "Softing AG
//000672, "Netezza
//00066A InfiniCon Systems, Inc.
//000661, "NIA Home Technologies Corp.
//0006B2 Linxtek Co.
//0006B6 Nir-Or Israel Ltd.
//000684, "Biacore AB
//000682, "Convedia
//0005E3, "LightSand Communications, Inc.
//0005ED, "Technikum Joanneum GmbH
//0005EF, "ADOIR Digital Technology
//000600, "Toshiba Teli Corporation
//00066B Sysmex Corporation
//00055A Power Dsine Ltd.
//000653, "Cisco Systems, Inc
//00064F, "PRO-NETS Technology Corporation
//000612, "Accusys, Inc.
//000609, "Crossport Systems
//000616, "Tel Net Co., Ltd.
//00060D, "Wave7 Optics
//00064A Honeywell Co., Ltd. (KOREA)
//00063F, "Everex Communications Inc.
//00063D, "Microwave Data Systems Inc.
//000639, "Newtec
//00062F, "Pivotech Systems Inc.
//000636, "Jedai Broadband Networks
//000651, "Aspen Networks Inc.
//00065C Malachite Technologies, Inc.
//000642, "Genetel Systems Inc.
//0005E9, "Unicess Network, Inc.
//0005E6, "Egenera, Inc.
//00061E, "Maxan Systems
//000622, "Chung Fu Chen Yeh Enterprise Corp.
//00CBBD Cambridge Broadband Networks Ltd.
//000588, "Sensoria Corp.
//00058D, "Lynx Photonic Networks, Inc.
//00058A Netcom Co., Ltd.
//000591, "Active Silicon Ltd
//000593, "Grammar Engine Inc.
//0005C7 I/F-COM A/S
//0005CC Sumtel Communications, Inc.
//0005CF Thunder River Technologies, Inc.
//0005C6 Triz Communications
//0005D6, "L-3 Linkabit
//0005DA Apex Automationstechnik
//0005A1 Zenocom
//0005A9 Princeton Networks, Inc.
//0005AF InnoScan Computing A/S
//0005A6 Extron Electronics
//0005A0 MOBILINE Kft.
//000584, "AbsoluteValue Systems, Inc.
//00058F, "CLCsoft co.
//0005BB Myspace AB
//000517, "Shellcomm, Inc.
//00051C Xnet Technology Corp.
//0004F9, "Xtera Communications, Inc.
//0004FA NBS Technologies Inc.
//000541, "Advanced Systems Co., Ltd.
//000545, "Internet Photonics
//00053A Willowglen Services Pte Ltd
//000531, "Cisco Systems, Inc
//000539, "A Brand New World in Sweden AB
//00052A Ikegami Tsushinki Co., Ltd.
//00052D, "Zoltrix International Limited
//000525, "Puretek Industrial Co., Ltd.
//000558, "Synchronous, Inc.
//000550, "Vcomms Connect Limited
//000512, "Zebra Technologies Inc
//000503, "ICONAG
//00057A Overture Networks
//000564, "Tsinghua Bitway Co., Ltd.
//0004F8, "QUALICABLE TV Industria E Com., Ltda
//0004F5, "SnowShore Networks, Inc.
//0004F2, "Polycom
//0004F3, "FS FORTH-SYSTEME GmbH
//0004ED, "Billion Electric Co., Ltd.
//0004E7, "Lightpointe Communications, Inc
//0004E6, "Banyan Network Private Limited
//0004DE Cisco Systems, Inc
//0004A2 L.S.I.Japan Co., Ltd.
//00049B Cisco Systems, Inc
//000499, "Chino Corporation
//00048E, "Ohm Tech Labs, Inc.
//0004A6 SAF Tehnika Ltd.
//0004A8 Broadmax Technologies, Inc.
//0004A1 Pathway Connectivity
//0004CE Patria Ailon
//0004C7 NetMount
//00048D, "Teo Technologies, Inc
//000490, "Optical Access
//0004E1, "Infinior Microsystems
//0004C2 Magnipix, Inc.
//000486, "ITTC, University of Kansas
//00048B Poscon Corporation
//000484, "Amann GmbH
//000478, "G.Star Technology Corporation
//00047A AXXESSIT ASA
//00046A Navini Networks
//00046B Palm Wireless, Inc.
//000472, "Telelynx, Inc.
//000464, "Pulse-Link Inc
//000465, "i.s.t isdn-support technik GmbH
//00045E, "PolyTrax Information Technology AG
//000411, "Inkra Networks, Inc.
//000410, "Spinnaker Networks, Inc.
//000412, "WaveSmith Networks, Inc.
//000442, "NACT
//000445, "LMS Skalar Instruments GmbH
//00044E, "Cisco Systems, Inc
//000452, "RocketLogix, Inc.
//000427, "Cisco Systems, Inc
//000420, "Slim Devices, Inc.
//00043D, "INDEL AG
//00043B Lava Computer Mfg., Inc.
//000431, "GlobalStreams, Inc.
//0003C4 Tomra Systems ASA
//0003C5 Mobotix AG
//0003BF Centerpoint Broadband Technologies, Inc.
//0003B9 Hualong Telecom Co., Ltd.
//0003F9, "Pleiades Communications, Inc.
//0003FE Cisco Systems, Inc
//0003F5, "Chip2Chip
//000391, "Advanced Digital Broadcast, Ltd.
//0003AC Fronius Schweissmaschinen
//000399, "Dongju Informations & Communications Co., Ltd.
//0003FD Cisco Systems, Inc
//0003BA Oracle Corporation
//0003AF Paragea Communications
//00030B Hunter Technology, Inc.
//0003C9 TECOM Co., Ltd.
//0003C1 Packet Dynamics Ltd
//0003DE OTC Wireless
//000328, "Mace Group, Inc.
//00032B GAI Datenfunksysteme GmbH
//00032C ABB Switzerland Ltd
//000323, "Cornet Technology, Inc.
//000380, "SSH Communications Security Corp.
//000382, "A-One Co., Ltd.
//00037A Taiyo Yuden Co., Ltd.
//000375, "NetMedia, Inc.
//00035A Photron Limited
//000353, "Mitac, Inc.
//000356, "Wincor Nixdorf International GmbH
//00034F, "Sur-Gard Security
//00037B IDEC IZUMI Corporation
//000367, "Jasmine Networks, Inc.
//00036A Mainnet, Ltd.
//00036B Cisco Systems, Inc
//00036C Cisco Systems, Inc
//00038F, "Weinschel Corporation
//000384, "AETA
//000387, "Blaze Network Products
//000381, "Ingenico International
//000340, "Floware Wireless Systems, Ltd.
//0001EC Ericsson Group
//000333, "Digitel Co., Ltd.
//000338, "Oak Technology
//000339, "Eurologic Systems, Ltd.
//000331, "Cisco Systems, Inc
//000330, "Imagenics, Co., Ltd.
//00034A RIAS Corporation
//0002CF ZyGate Communications, Inc.
//0002D1, "Vivotek, Inc.
//0002C2 Net Vision Telecom
//0002B6 Acrosser Technology Co., Ltd.
//0002B1 Anritsu, Ltd.
//0002AD HOYA Corporation
//0002AE Scannex Electronics Ltd.
//000304, "Pacific Broadband Communications
//000301, "EXFO
//0002FD Cisco Systems, Inc
//000300, "Barracuda Networks, Inc.
//0002BD Bionet Co., Ltd.
//0002BE Totsu Engineering, Inc.
//0002B9 Cisco Systems, Inc
//0002BA Cisco Systems, Inc
//0002F9, "MIMOS Berhad
//0002F3, "Media Serve Co., Ltd.
//0002EA Focus Enhancements
//000313, "Access Media SPA
//000310, "E-Globaledge Corporation
//00030A Argus Technologies
//00031E, "Optranet, Inc.
//000315, "Cidco Incorporated
//000319, "Infineon AG
//0002E7, "CAB GmbH & Co KG
//0002DF Net Com Systems, Inc.
//0002DB NETSEC
//00024B Cisco Systems, Inc
//00024D, "Mannesman Dematic Colby Pty. Ltd.
//000250, "Geyser Networks, Inc.
//000248, "Pilz GmbH & Co.
//00024C SiByte, Inc.
//00025A Catena Networks
//00026E, "NeGeN Access, Inc.
//000270, "Crewave Co., Ltd.
//00023B Ericsson
//000239, "Visicom
//000233, "Mantra Communications, Inc.
//0002A2 Hilscher GmbH
//000254, "WorldGate
//00029A Storage Apps
//00028F, "Globetek, Inc.
//000287, "Adapcom
//000281, "Madge Ltd.
//000263, "UPS Manufacturing SRL
//000240, "Seedek Co., Ltd.
//0001F3, "QPS, Inc.
//0001E4, "Sitera, Inc.
//0001E3, "Siemens AG
//0001EB C-COM Corporation
//0001F2, "Mark of the Unicorn, Inc.
//0001D9, "Sigma, Inc.
//0001C5 Simpler Networks
//0001C9 Cisco Systems, Inc
//00021B Kollmorgen-Servotronix
//00021E, "SIMTEL S.R.L.
//000221, "DSP Application, Ltd.
//0001F7, "Image Display Systems, Inc.
//000200, "Net & Sys Co., Ltd.
//0001C4 NeoWave, Inc.
//0001C1 Vitesse Semiconductor Corporation
//0001D8, "Teltronics, Inc.
//000205, "Hitachi Denshi, Ltd.
//000215, "Cotas Computer Technology A/B
//00022A Asound Electronic
//00018C Mega Vision
//00018F, "Kenetec, Inc.
//00017B Heidelberger Druckmaschinen AG
//00019C JDS Uniphase Inc.
//0001A3 GENESYS LOGIC, INC.
//000182, "DICA TECHNOLOGIES AG
//000189, "Refraction Technology, Inc.
//000193, "Hanbyul Telecom Co., Ltd.
//0030F5, "Wild Lab. Ltd.
//00015D, "Oracle Corporation
//000173, "AMCC
//00016C FOXCONN
//000175, "Radiant Communications Corp.
//0001AF Artesyn Embedded Technologies
//00018A ROI COMPUTER AG
//000192, "Texas Digital Systems
//00015C CADANT INC.
//000169, "Celestix Networks Pte Ltd.
//00016B LightChip, Inc.
//0001B6 SAEJIN T&M Co., Ltd.
//0001AB Main Street Networks
//000145, "WINSYSTEMS, INC.
//000137, "IT Farm Corporation
//00013C TIW SYSTEMS
//000133, "KYOWA Electronic Instruments C
//0001A5 Nextcomm, Inc.
//000190, "SMK-M
//00014C Berkeley Process Control
//000143, "Cisco Systems, Inc
//00014B Ennovate Networks, Inc.
//00013D, "RiscStation Ltd.
//000120, "OSCILLOQUARTZ S.A.
//003046, "Controlled Electronic Manageme
//003098, "Global Converging Technologies
//00300D, "MMC Technology, Inc.
//003075, "ADTECH
//00B069 Honewell Oy
//00B0C2 Cisco Systems, Inc
//00B03B HiQ Networks
//000127, "OPEN Networks Pty Ltd
//00010E, "Bri-Link Technologies Co., Ltd
//003037, "Packard Bell Nec Services
//003057, "QTelNet, Inc.
//0030FC Terawave Communications, Inc.
//00B086 LocSoft Limited
//0030A2 Lightner Engineering
//003042, "DeTeWe-Deutsche Telephonwerke
//00B0C7 Tellabs Operations, Inc.
//00B02A ORSYS GmbH
//000104, "DVICO Co., Ltd.
//000106, "Tews Datentechnik GmbH
//000109, "Nagano Japan Radio Co., Ltd.
//00029C", "3COM
//00B019 UTC CCS
//00306F, "SEYEON TECH. CO., LTD.
//00303D, "IVA CORPORATION
//0030F4, "STARDOT TECHNOLOGIES
//003052, "ELASTIC NETWORKS
//003019, "Cisco Systems, Inc
//003076, "Akamba Corporation
//0030EC BORGARDT
//0030F3, "At Work Computers
//0030CC Tenor Networks, Inc.
//0030B0 Convergenet Technologies
//0030EB TURBONET COMMUNICATIONS, INC.
//0030A1 WEBGATE Inc.
//00306A PENTA MEDIA CO., LTD.
//003086, "Transistor Devices, Inc.
//003044, "CradlePoint, Inc
//0030C2 COMONE
//003053, "Basler AG
//0030D2, "WIN TECHNOLOGIES, CO., LTD.
//003059, "KONTRON COMPACT COMPUTERS AG
//003097, "AB Regin
//00305F, "Hasselblad
//0030DC RIGHTECH CORPORATION
//003025, "CHECKOUT COMPUTER SYSTEMS, LTD
//003012, "DIGITAL ENGINEERING LTD.
//0030C6 CONTROL SOLUTIONS, INC.
//0030D6, "MSC VERTRIEBS GMBH
//003041, "SAEJIN T & M CO., LTD.
//00308C Quantum Corporation
//0030E3, "SEDONA NETWORKS CORP.
//0030BF MULTIDATA GMBH
//00D00F, "SPEECH DESIGN GMBH
//003058, "API MOTION
//003034, "SET ENGINEERING
//00304A Fraunhofer IPMS
//00308D, "Pinnacle Systems, Inc.
//0030A6 VIANET TECHNOLOGIES, LTD.
//00D0BF PIVOTAL TECHNOLOGIES
//00303C ONNTO CORP.
//003024, "Cisco Systems, Inc
//0030F6, "SECURELOGIX CORPORATION
//00D02F, "VLSI TECHNOLOGY INC.
//0030D8, "SITEK
//003016, "ISHIDA CO., LTD.
//00D0B1, "OMEGA ELECTRONICS SA
//00D016, "SCM MICROSYSTEMS, INC.
//00D043, "ZONAL RETAIL DATA SYSTEMS
//00D0C1 HARMONIC DATA SYSTEMS, LTD.
//00D0AC Commscope, Inc
//00D07C KOYO ELECTRONICS INC. CO., LTD.
//00D0BC Cisco Systems, Inc
//00D0CB DASAN CO., LTD.
//00D019, "DAINIPPON SCREEN CORPORATE
//00D035, "BEHAVIOR TECH. COMPUTER CORP.
//00D0DB MCQUAY INTERNATIONAL
//00D070, "LONG WELL ELECTRONICS CORP.
//00D029, "WAKEFERN FOOD CORPORATION
//00D0C3 VIVID TECHNOLOGY PTE, LTD.
//00D013, "PRIMEX AEROSPACE COMPANY
//00D0A3 VOCAL DATA, INC.
//00D07E, "KEYCORP LTD.
//00D020, "AIM SYSTEM, INC.
//00D0C8 Prevas A/S
//005017, "RSR S.R.L.
//005065, "TDK-Lambda Corporation
//0050B9 XITRON TECHNOLOGIES, INC.
//00506B SPX-ATEG
//00D076, "Bank of America
//00D051, "O2 MICRO, INC.
//00D0BB Cisco Systems, Inc
//00D06E, "TRENDVIEW RECORDERS LTD.
//00D05C KATHREIN TechnoTrend GmbH
//00D0EA NEXTONE COMMUNICATIONS, INC.
//00D064, "MULTITEL
//00D05E, "STRATABEAM TECHNOLOGY, INC.
//00D0AA CHASE COMMUNICATIONS
//00D05D, "INTELLIWORXX, INC.
//00D0A1 OSKAR VIERLING GMBH + CO.KG
//00D006, "Cisco Systems, Inc
//00D02A Voxent Systems Ltd.
//00D08F, "ARDENT TECHNOLOGIES, INC.
//00D0FA Thales e-Security Ltd.
//00D0EB LIGHTERA NETWORKS, INC.
//0050A1 CARLO GAVAZZI, INC.
//00D0C0 Cisco Systems, Inc
//00D068, "IWILL CORPORATION
//005029, "1394 PRINTER WORKING GROUP
//005081, "MURATA MACHINERY, LTD.
//0050AC MAPLE COMPUTER CORPORATION
//005049, "Arbor Networks Inc
//00500D, "SATORI ELECTORIC CO., LTD.
//0050A3 TransMedia Communications, Inc.
//0050A4 IO TECH, INC.
//00505C TUNDO CORPORATION
//0050B3 VOICEBOARD CORPORATION
//00508C RSI SYSTEMS
//0050E1, "NS TECH ELECTRONICS SDN BHD
//0050DE SIGNUM SYSTEMS CORP.
//005075, "KESTREL SOLUTIONS
//0050ED, "ANDA NETWORKS
//005096, "SALIX TECHNOLOGIES, INC.
//005012, "CBL - GMBH
//0050F2, "MICROSOFT CORP.
//00504A ELTECO A.S.
//0050C1 GEMFLEX NETWORKS, LTD.
//0050CF VANLINK COMMUNICATION TECHNOLOGY RESEARCH INSTITUTE
//005024, "NAVIC SYSTEMS, INC.
//0090BD OMNIA COMMUNICATIONS, INC.
//0090B4 WILLOWBROOK TECHNOLOGIES
//009003, "APLIO
//009031, "MYSTICOM, LTD.
//00909D, "NovaTech Process Solutions, LLC
//0090DD MIHARU COMMUNICATIONS Inc
//009028, "NIPPON SIGNAL CO., LTD.
//00907D, "Lake Communications
//0090C9 DPAC Technologies
//00507B MERLOT COMMUNICATIONS
//0050CD DIGIANSWER A/S
//00502D, "ACCEL, INC.
//00503A DATONG ELECTRONICS LTD.
//005087, "TERASAKI ELECTRIC CO., LTD.
//005026, "COSYSTEMS, INC.
//00902C DATA & CONTROL EQUIPMENT LTD.
//00901D, "PEC (NZ) LTD.
//009097, "Sycamore Networks
//009025, "BAE Systems Australia (Electronic Systems) Pty Ltd
//00904C Epigram, Inc.
//009084, "ATECH SYSTEM
//00906A TURNSTONE SYSTEMS, INC.
//009087, "ITIS
//009051, "ULTIMATE TECHNOLOGY CORP.
//009026, "ADVANCED SWITCHING COMMUNICATIONS, INC.
//0090D3, "GIESECKE & DEVRIENT GmbH
//009067, "WalkAbout Computers, Inc.
//00902A COMMUNICATION DEVICES, INC.
//00900D, "Overland Storage Inc.
//0090CF NORTEL
//009072, "SIMRAD AS
//00902F, "NETCORE SYSTEMS, INC.
//009098, "SBC DESIGNS, INC.
//009045, "Marconi Communications
//009036, "ens, inc.
//00908B Tattile SRL
//009044, "ASSURED DIGITAL, INC.
//009091, "DigitalScape, Inc.
//00907E, "VETRONIX CORP.
//009050, "Teleste Corporation
//00904D, "SPEC S.A.
//0090FD CopperCom, Inc.
//009039, "SHASTA NETWORKS
//0090FC NETWORK COMPUTING DEVICES
//009014, "ROTORK INSTRUMENTS, LTD.
//00908D, "VICKERS ELECTRONICS SYSTEMS
//009042, "ECCS, Inc.
//009033, "INNOVAPHONE AG
//009002, "ALLGON AB
//0010D4, "STORAGE COMPUTER CORPORATION
//000629, "IBM Corp
//0010A9 ADHOC TECHNOLOGIES
//00108A TeraLogic, Inc.
//001024, "NAGOYA ELECTRIC WORKS CO., LTD
//0010D6, "Exelis
//001048, "HTRC AUTOMATION, INC.
//001097, "WinNet Metropolitan Communications Systems, Inc.
//001085, "POLARIS COMMUNICATIONS, INC.
//00100C ITO CO., LTD.
//001006, "Thales Contact Solutions Ltd.
//009009, "I Controls, Inc.
//00908E, "Nortel Networks Broadband Access
//00907C DIGITALCAST, INC.
//0090D2, "ARTEL VIDEO SYSTEMS
//0001FE DIGITAL EQUIPMENT CORPORATION
//0090BE IBC/INTEGRATED BUSINESS COMPUTERS
//00103C IC ENSEMBLE, INC.
//001019, "SIRONA DENTAL SYSTEMS GmbH & Co.KG
//0090DE CARDKEY SYSTEMS, INC.
//00906B APPLIED RESOURCES, INC.
//00107F, "CRESTRON ELECTRONICS, INC.
//0010E2, "ArrayComm, Inc.
//0010D2, "NITTO TSUSHINKI CO., LTD
//0010D9, "IBM JAPAN, FUJISAWA MT+D
//009066, "Troika Networks, Inc.
//001094, "Performance Analysis Broadband, Spirent plc
//001050, "RION CO., LTD.
//00109C M-SYSTEM CO., LTD.
//0010CE VOLAMP, LTD.
//0010B2 COACTIVE AESTHETICS
//00105F, "ZODIAC DATA SYSTEMS
//00103E, "NETSCHOOLS CORPORATION
//0010CB FACIT K.K.
//0010E0, "Oracle Corporation
//00107C P-COM, INC.
//0010BD THE TELECOMMUNICATION TECHNOLOGY COMMITTEE (TTC)
//001008, "VIENNA SYSTEMS CORPORATION
//0010D1, "Top Layer Networks, Inc.
//00106A DIGITAL MICROWAVE CORPORATION
//00106F, "TRENTON TECHNOLOGY INC.
//001034, "GNP Computers
//001044, "InnoLabs Corporation
//0010A1 KENDIN SEMICONDUCTOR, INC.
//0010A8 RELIANCE COMPUTER CORP.
//00106E, "TADIRAN COM. LTD.
//00109A NETLINE
//001089, "WebSonic
//0010E6, "APPLIED INTELLIGENT SYSTEMS, INC.
//00103B HIPPI NETWORKING FORUM
//00E0B7 PI GROUP, LTD.
//00E083, "JATO TECHNOLOGIES, INC.
//00E072, "LYNK
//00E0AD EES TECHNOLOGY, LTD.
//00E094, "OSAI SRL
//00E032, "MISYS FINANCIAL SYSTEMS, LTD.
//00E0C0 SEIWA ELECTRIC MFG. CO., LTD.
//00E0D1, "TELSIS LIMITED
//00E0F0, "ABLER TECHNOLOGY, INC.
//00E002, "CROSSROADS SYSTEMS, INC.
//00E0D6, "COMPUTER & COMMUNICATION RESEARCH LAB.
//00E074, "TIERNAN COMMUNICATIONS, INC.
//00E0D9, "TAZMO CO., LTD.
//00E055, "INGENIERIA ELECTRONICA COMERCIAL INELCOM S.A.
//00E0B4 TECHNO SCOPE CO., LTD.
//00E071, "EPIS MICROCOMPUTER
//00E066, "ProMax Systems, Inc.
//00E093, "ACKFIN NETWORKS
//00E042, "Pacom Systems Ltd.
//00E0EB DIGICOM SYSTEMS, INCORPORATED
//00E01C Cradlepoint, Inc
//00E027, "DUX, INC.
//00E04B JUMP INDUSTRIELLE COMPUTERTECHNIK GmbH
//00E097, "CARRIER ACCESS CORPORATION
//00E089, "ION Networks, Inc.
//00E070, "DH TECHNOLOGY
//00E05C PHC Corporation
//00E024, "GADZOOX NETWORKS
//00605B IntraServer Technology, Inc.
//0060D7, "ECOLE POLYTECHNIQUE FEDERALE DE LAUSANNE (EPFL)
//00E0BA BERGHOF AUTOMATIONSTECHNIK GmbH
//00E021, "FREEGATE CORP.
//00E05B WEST END SYSTEMS CORP.
//00E044, "LSICS CORPORATION
//00E0CA BEST DATA PRODUCTS
//00E0A7 IPC INFORMATION SYSTEMS, INC.
//00E062, "HOST ENGINEERING
//00E0CE ARN
//00E05F, "e-Net, Inc.
//00E01F, "AVIDIA Systems, Inc.
//00E0D0, "NETSPEED, INC.
//00E060, "SHERWOOD
//00E06A KAPSCH AG
//00E001, "STRAND LIGHTING LIMITED
//00E0D8, "LANBit Computer, Inc.
//00E0E7 RAYTHEON E-SYSTEMS, INC.
//00E03C AdvanSys
//00E073, "NATIONAL AMUSEMENT NETWORK, INC.
//006066, "LACROIX Trafic
//0060F4, "ADVANCED COMPUTER SOLUTIONS, Inc.
//006060, "Data Innovations North America
//006035, "DALLAS SEMICONDUCTOR, INC.
//006007, "ACRES GAMING, INC.
//006058, "COPPER MOUNTAIN COMMUNICATIONS, INC.
//0060FB PACKETEER, INC.
//0060C1 WaveSpan Corporation
//00603C HAGIWARA SYS-COM CO., LTD.
//00607D, "SENTIENT NETWORKS INC.
//006019, "Roche Diagnostics
//006059, "TECHNICAL COMMUNICATIONS CORP.
//006003, "TERAOKA WEIGH SYSTEM PTE, LTD.
//00607A DVS GMBH
//0060F3, "Performance Analysis Broadband, Spirent plc
//00607C WaveAccess, Ltd.
//0060A0 SWITCHED NETWORK TECHNOLOGIES, INC.
//006017, "TOKIMEC INC.
//006026, "VIKING Modular Solutions
//00606E, "DAVICOM SEMICONDUCTOR, INC.
//0060C7 AMATI COMMUNICATIONS CORP.
//1000E8, "NATIONAL SEMICONDUCTOR
//006073, "REDCREEK COMMUNICATIONS, INC.
//0060FD NetICs, Inc.
//0060CB HITACHI ZOSEN CORPORATION
//0060C8 KUKA WELDING SYSTEMS & ROBOTS
//006023, "PERICOM SEMICONDUCTOR CORP.
//006063, "PSION DACOM PLC.
//006031, "HRK SYSTEMS
//00600E, "WAVENET INTERNATIONAL, INC.
//0060A3 CONTINUUM TECHNOLOGY CORP.
//00603D, "3CX
//0060ED, "RICARDO TEST AUTOMATION LTD.
//006012, "POWER COMPUTING CORPORATION
//00604D, "MMC NETWORKS, INC.
//0060F7, "DATAFUSION SYSTEMS
//006020, "PIVOTAL NETWORKING, INC.
//0060C0 Nera Networks AS
//006077, "PRISA NETWORKS
//006094, "IBM Corp
//0060AB LARSCOM INCORPORATED
//0060DD MYRICOM, INC.
//006046, "VMETRO, INC.
//006068, "Dialogic Corporation
//00605A CELCORE, INC.
//006095, "ACCU-TIME SYSTEMS, INC.
//00608A CITADEL COMPUTER
//006093, "VARIAN
//00A03F COMPUTER SOCIETY MICROPROCESSOR & MICROPROCESSOR STANDARDS C
//00A02D", "1394 Trade Association
//00A07C TONYANG NYLON CO., LTD.
//00A09A NIHON KOHDEN AMERICA
//00A093 B/E AEROSPACE, Inc.
//00A078 Marconi Communications
//00A0BF WIRELESS DATA GROUP MOTOROLA
//00A05F BTG Electronics Design BV
//00A0CD DR. JOHANNES HEIDENHAIN GmbH
//00A0DA INTEGRATED SYSTEMS Technology, Inc.
//00A02A TRANCELL SYSTEMS
//00A01C NASCENT NETWORKS CORPORATION
//00A08F DESKNET SYSTEMS, INC.
//00A0CC LITE-ON COMMUNICATIONS, INC.
//00A0E6 DIALOGIC CORPORATION
//00A04A NISSHIN ELECTRIC CO., LTD.
//00A035 CYLINK CORPORATION
//00A03D OPTO-22
//00A056 MICROPROSS
//00A0E1 WESTPORT RESEARCH ASSOCIATES, INC.
//00A0B7 CORDANT, INC.
//00A026 TELDAT, S.A.
//00A023 APPLIED CREATIVE TECHNOLOGY, INC.
//00A089 XPOINT TECHNOLOGIES, INC.
//00A007 APEXX TECHNOLOGY, INC.
//00A047 INTEGRATED FITNESS CORP.
//00A032 GES SINGAPORE PTE. LTD.
//00A0E3 XKL SYSTEMS CORP.
//00A014 CSIR
//00A015 WYLE
//00A06A Verilink Corporation
//00A018 CREATIVE CONTROLLERS, INC.
//00A0FE BOSTON TECHNOLOGY, INC.
//00A0EB Encore Networks, Inc.
//00A07D SEEQ TECHNOLOGY, INC.
//00A0D9 CONVEX COMPUTER CORPORATION
//00A070 COASTCOM
//0020DE JAPAN DIGITAL LABORAT'Y CO.LTD
//00200B OCTAGON SYSTEMS CORP.
//002094, "CUBIX CORPORATION
//0020F7, "CYBERDATA CORPORATION
//0020D7, "JAPAN MINICOMPUTER SYSTEMS CO., Ltd.
//0020C3 COUNTER SOLUTIONS LTD.
//002047, "STEINBRECHER CORP.
//0020D5, "VIPA GMBH
//00201A MRV Communications, Inc.
//0020F2, "Oracle Corporation
//0020B8 PRIME OPTION, INC.
//0020AD LINQ SYSTEMS
//00207D, "ADVANCED COMPUTER APPLICATIONS
//00202F, "ZETA COMMUNICATIONS, LTD.
//00209A THE 3DO COMPANY
//002062, "SCORPION LOGIC, LTD.
//002081, "TITAN ELECTRONICS
//0020D9, "PANASONIC TECHNOLOGIES, INC./MIECO-US
//00206F, "FLOWPOINT CORPORATION
//002020, "MEGATRON COMPUTER INDUSTRIES PTY, LTD.
//00201B NORTHERN TELECOM/NETWORK
//0020F3, "RAYNET CORPORATION
//002090, "ADVANCED COMPRESSION TECHNOLOGY, INC.
//0020C0 PULSE ELECTRONICS, INC.
//00207E, "FINECOM CO., LTD.
//00204E, "NETWORK SECURITY SYSTEMS, INC.
//0020CA DIGITAL OCEAN
//002095, "RIVA ELECTRONICS
//0020FB OCTEL COMMUNICATIONS CORP.
//002070, "HYNET, LTD.
//0020BE LAN ACCESS CORP.
//00203F, "JUKI CORPORATION
//0020A9 WHITE HORSE INDUSTRIAL
//002096, "Invensys
//00204A PRONET GMBH
//0020FF SYMMETRICAL TECHNOLOGIES
//002044, "GENITECH PTY LTD
//0020EF, "USC CORPORATION
//002030, "ANALOG & DIGITAL SYSTEMS
//0020AC INTERFLEX DATENSYSTEME GMBH
//0020D8, "Nortel Networks
//002066, "GENERAL MAGIC, INC.
//002001, "DSP SOLUTIONS, INC.
//0020BF AEHR TEST SYSTEMS
//002053, "HUNTSVILLE MICROSYSTEMS, INC.
//0020A1 DOVATRON
//00C02F OKUMA CORPORATION
//00C01E LA FRANCAISE DES JEUX
//00C0E1 SONIC SOLUTIONS
//002036, "BMC SOFTWARE
//0020F8, "CARRERA COMPUTERS, INC.
//00C065 SCOPE COMMUNICATIONS, INC.
//00C079 FONSYS CO., LTD.
//00C00F QUANTUM SOFTWARE SYSTEMS LTD.
//00C087 UUNET TECHNOLOGIES, INC.
//00C006 NIPPON AVIONICS CO., LTD.
//00C0A4 UNIGRAF OY
//00C029 Nexans Deutschland GmbH - ANS
//00C0FA CANARY COMMUNICATIONS, INC.
//00C03A MEN-MIKRO ELEKTRONIK GMBH
//00C040 ECCI
//00C01C INTERLINK COMMUNICATIONS LTD.
//00C042 DATALUX CORP.
//00C071 AREANEX COMMUNICATIONS, INC.
//00C044 EMCOM CORPORATION
//00C0E6 Verilink Corporation
//00C096 TAMURA CORPORATION
//00C04E COMTROL CORPORATION
//00C03F STORES AUTOMATED SYSTEMS, INC.
//00C036 RAYTECH ELECTRONIC CORP.
//00C0A2 INTERMEDIUM A/S
//00C053 Aspect Software Inc.
//00C0CC TELESCIENCES CO SYSTEMS, INC.
//00C0CE CEI SYSTEMS & ENGINEERING PTE
//00404F, "SPACE & NAVAL WARFARE SYSTEMS
//00408F, "WM-DATA MINFO AB
//0040D7, "STUDIO GEN INC.
//004057, "LOCKHEED - SANDERS
//004017, "Silex Technology America
//00C0D9 QUINTE NETWORK CONFIDENTIALITY
//00C0B1 GENIUS NET CO.
//00C0D2 SYNTELLECT, INC.
//00C07E KUBOTA CORPORATION ELECTRONIC
//00C0DD QLogic Corporation
//00C01B SOCKET COMMUNICATIONS, INC.
//00406F, "SYNC RESEARCH INC.
//0040F3, "NETCOR
//00404B MAPLE COMPUTER SYSTEMS
//004033, "ADDTRON TECHNOLOGY CO., LTD.
//00C08E NETWORK INFORMATION TECHNOLOGY
//00C0C7 SPARKTRUM MICROSYSTEMS, INC.
//00C0C4 COMPUTER OPERATIONAL
//00C012 NETSPAN CORPORATION
//0040AD SMA REGELSYSTEME GMBH
//00406D, "LANCO, INC.
//0040CD TERA MICROSYSTEMS, INC.
//0040F5, "OEM ENGINES
//004039, "OPTEC DAIICHI DENKO CO., LTD.
//004079, "JUKO MANUFACTURE COMPANY, LTD.
//00C020 ARCO ELECTRONIC, CONTROL LTD.
//00C0E7 FIBERDATA AB
//00C05F FINE-PAL COMPANY LIMITED
//0040AE DELTA CONTROLS, INC.
//0040F6, "KATRON COMPUTERS INC.
//004086, "MICHELS & KLEBERHOFF COMPUTER
//004092, "ASP COMPUTER PRODUCTS, INC.
//004068, "EXTENDED SYSTEMS
//004078, "WEARNES AUTOMATION PTE LTD
//0040F4, "CAMEO COMMUNICATIONS, INC.
//0040B4 NEXTCOM K.K.
//0040B0 BYTEX CORPORATION, ENGINEERING
//0080D9, "EMK Elektronik GmbH & Co.KG
//004059, "YOSHIDA KOGYO K.K.
//004095, "R.P.T.INTERGROUPS INT'L LTD.
//004035, "OPCOM
//00405C FUTURE SYSTEMS, INC.
//004061, "DATATECH ENTERPRISES CO., LTD.
//00008C Alloy Computer Products (Australia) Pty Ltd
//0040B9 MACQ ELECTRONIQUE SA
//0040BB GOLDSTAR CABLE CO., LTD.
//0040B1 CODONICS INC.
//0040F8, "SYSTEMHAUS DISCOM
//0040D2, "PAGINE CORPORATION
//004024, "COMPAC INC.
//0040E9, "ACCORD SYSTEMS, INC.
//004003, "Emerson Process Management Power & Water Solutions, Inc.
//004090, "ANSEL COMMUNICATIONS
//0040C5 MICOM COMMUNICATIONS INC.
//004020, "CommScope Inc
//004048, "SMD INFORMATICA S.A.
//00407C QUME CORPORATION
//00407F, "FLIR Systems
//00402D, "HARRIS ADACOM CORPORATION
//0080A6 REPUBLIC TECHNOLOGY, INC.
//0040DE Elsag Datamat spa
//0040C9 NCUBE
//008032, "ACCESS CO., LTD.
//0080CF EMBEDDED PERFORMANCE INC.
//008090, "MICROTEK INTERNATIONAL, INC.
//004044, "QNIX COMPUTER CO., LTD.
//0080C4 DOCUMENT TECHNOLOGIES, INC.
//00805B CONDOR SYSTEMS, INC.
//008043, "NETWORLD, INC.
//0040DF DIGALOG SYSTEMS, INC.
//004009, "TACHIBANA TECTRON CO., LTD.
//0040A0 GOLDSTAR CO., LTD.
//0040FC IBR COMPUTER TECHNIK GMBH
//0080AF ALLUMER CO., LTD.
//008084, "THE CLOUD INC.
//0080F3, "SUN ELECTRONICS CORP.
//008099, "Eaton Industries GmbH
//00808D, "WESTCOAST TECHNOLOGY B.V.
//0080BE ARIES RESEARCH
//008015, "SEIKO SYSTEMS, INC.
//0080D2, "SHINNIHONDENKO CO., LTD.
//008089, "TECNETICS (PTY) LTD.
//00806F, "ONELAN LTD.
//008081, "KENDALL SQUARE RESEARCH CORP.
//00809C LUXCOM, INC.
//008065, "CYBERGRAPHIC SYSTEMS PTY LTD.
//008019, "DAYNA COMMUNICATIONS, INC.
//008050, "ZIATECH CORPORATION
//0080A4 LIBERTY ELECTRONICS
//0080CD MICRONICS COMPUTER, INC.
//008003, "HYTEC ELECTRONICS LTD.
//008052, "TECHNICALLY ELITE CONCEPTS
//00805D, "CANSTAR
//00804F, "DAIKIN INDUSTRIES, LTD.
//008005, "CACTUS COMPUTER INC.
//00806D, "CENTURY SYSTEMS CORP.
//008094, "ALFA LAVAL AUTOMATION AB
//000041, "ICE CORPORATION
//000086, "MEGAHERTZ CORPORATION
//000092, "COGENT DATA TECHNOLOGIES
//000058, "RACORE COMPUTER PRODUCTS INC.
//008074, "FISHER CONTROLS
//008030, "NEXUS ELECTRONICS
//000055, "COMMISSARIAT A L`ENERGIE ATOM.
//0080C9 ALBERTA MICROELECTRONIC CENTRE
//00800C VIDECOM LIMITED
//00807D, "EQUINOX SYSTEMS INC.
//008063, "Hirschmann Automation and Control GmbH
//0080EE THOMSON CSF
//00808E, "RADSTONE TECHNOLOGY
//008096, "HUMAN DESIGNED SYSTEMS, INC.
//0080DA Bruel & Kjaer Sound & Vibration Measurement A/S
//00803E, "SYNERNETICS
//0080CE BROADCAST TELEVISION SYSTEMS
//00801A BELL ATLANTIC
//0080DE GIPSI S.A.
//008002, "SATELCOM (UK) LTD
//008064, "WYSE TECHNOLOGY LLC
//008048, "COMPEX INCORPORATED
//008085, "H-THREE SYSTEMS CORPORATION
//00804C CONTEC CO., LTD.
//00808F, "C.ITOH ELECTRONICS, INC.
//000052, "Intrusion.com, Inc.
//0080FF SOC. DE TELEINFORMATIQUE RTC
//0000F7, "YOUTH KEEP ENTERPRISE CO LTD
//0000C7 ARIX CORPORATION
//0000D1, "ADAPTEC INCORPORATED
//000016, "DU PONT PIXEL SYSTEMS", "", " .
//0000E1, "GRID SYSTEMS
//000081, "Bay Networks
//000029, "IMC NETWORKS CORP.
//00000A OMRON TATEISI ELECTRONICS CO.
//00000D, "FIBRONICS LTD.
//000024, "CONNECT AS
//000067, "SOFT* RITE, INC.
//0000D2, "SBE, INC.
//000037, "OXFORD METRICS LIMITED
//0000FB RECHNER ZUR KOMMUNIKATION
//0000E2, "ACER TECHNOLOGIES CORP.
//0000BA SIIG, INC.
//00002A TRW - SEDD/INP
//00002C AUTOTOTE LIMITED
//000083, "TADPOLE TECHNOLOGY PLC
//0000F3, "GANDALF DATA LIMITED
//0000B0 RND-RAD NETWORK DEVICES
//0000CF HAYES MICROCOMPUTER PRODUCTS
//000056, "DR.B.STRUCK
//00006C Private
//0000A9 NETWORK SYSTEMS CORP.
//0000EF, "KTI
//000025, "RAMTEK CORP.
//0000AF Canberra Industries, Inc.
//000076, "ABEKAS VIDEO SYSTEM
//080055, "STANFORD TELECOMM. INC.
//080053, "MIDDLE EAST TECH.UNIVERSITY
//08008E, "Tandem Computers
//080084, "TOMEN ELECTRONICS CORP.
//080085, "ELXSI
//080082, "VERITAS SOFTWARE
//080080, "AES DATA INC.
//080077, "TSL COMMUNICATIONS LTD.
//080074, "CASIO COMPUTER CO.LTD.
//08006E, "MASSCOMP
//080068, "RIDGE COMPUTERS
//080063, "PLESSEY
//08007B SANYO ELECTRIC CO. LTD.
//08007C VITALINK COMMUNICATIONS CORP.
//0000DF BELL & HOWELL PUB SYS DIV
//0000F9, "QUOTRON SYSTEMS INC.
//080060, "INDUSTRIAL NETWORKING INC.
//08004C HYDRA COMPUTER SYSTEMS INC.
//080047, "SEQUENT COMPUTER SYSTEMS INC.
//08004A BANYAN SYSTEMS INC.
//080044, "DAVID SYSTEMS INC.
//080041, "RACAL-MILGO INFORMATION SYS..
//080037, "FUJI-XEROX CO. LTD.
//080035, "MICROFIVE CORPORATION
//080032, "TIGAN INCORPORATED
//08008D, "XYVISION INC.
//080015, "STC BUSINESS SYSTEMS
//080042, "JAPAN MACNICS CORP.
//080066, "AGFA CORPORATION
//080004, "CROMEMCO INCORPORATED
//0001C8 CONRAD CORP.
//08003F, "FRED KOSCHARA ENTERPRISES
//08000B UNISYS CORPORATION
//00DD01 UNGERMANN-BASS INC.
//00DD06 UNGERMANN-BASS INC.
//AA0003 DIGITAL EQUIPMENT CORPORATION
//000000, "XEROX CORPORATION
//080021, "3M COMPANY
//02BB01 OCTOTHORPE CORP.
//08008A PerfTech, Inc.
//00003E, "SIMPACT
//00DD02 UNGERMANN-BASS INC.
//00DD04 UNGERMANN-BASS INC.
//026086, "LOGIC REPLACEMENT TECH.LTD.
//080030, "CERN
//74DA88 TP-LINK TECHNOLOGIES CO., LTD.
//CC32E5 TP-LINK TECHNOLOGIES CO., LTD.
//1C3BF3 TP-LINK TECHNOLOGIES CO., LTD.
//3C86D1 vivo Mobile Communication Co., Ltd.
//301B97 Lierda Science & Technology Group Co., Ltd
//2CD2E3 Guangzhou Aoshi Electronic Co., Ltd
//5859C2 Aerohive Networks Inc.
//1459C3 Creative Chips GmbH
//A0D86F ARGO AI, LLC
//E4671E", "SHEN ZHEN NUO XIN CHENG TECHNOLOGY co., Ltd.
//682719, "Microchip Technology Inc.
//24C17A BEIJING IACTIVE NETWORK CO., LTD
//1C9C8C Juniper Networks
//A4C939", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//34D772, "Xiamen Yudian Automation Technology Co., Ltd
//C0DCDA", "Samsung Electronics Co., Ltd
//04B429 Samsung Electronics Co., Ltd
//48794D, "Samsung Electronics Co., Ltd
//44F971, "SHENZHEN MERCURY COMMUNICATION TECHNOLOGIES CO., LTD.
//18F9C4 BAE Systems
//60ABD2 Bose Corporation
//F0EF86", "Google, Inc.
//E4C0CC China Mobile Group Device Co., Ltd.
//5CB13E Sagemcom Broadband SAS
//F4E5F2 HUAWEI TECHNOLOGIES CO., LTD
//541310, "HUAWEI TECHNOLOGIES CO., LTD
//8CE5EF HUAWEI TECHNOLOGIES CO., LTD
//A4CD23", "Shenzhenshi Xinzhongxin", "Co., Ltd
//B83A5A", "Aruba, a Hewlett Packard Enterprise Company
//E4AAEA", "Liteon Technology Corporation
//A0946A", "Shenzhen XGTEC Technology Co,.Ltd.
//1C2AA3 Shenzhen HongRui Optical Technology Co., Ltd.
//388E7A AUTOIT
//4C710C Cisco Systems, Inc
//4C710D Cisco Systems, Inc
//9C31C3 BSkyB Ltd
//6C24A6 vivo Mobile Communication Co., Ltd.
//9C5F5A GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//E447B3", "zte corporation
//FCDB21 SAMSARA NETWORKS INC
//607771, "Texas Instruments
//D8CF89 Beijing DoSee Science and Technology Co., Ltd.
//04AAE1 BEIJING MICROVISION TECHNOLOGY CO., LTD
//44DC4E ITEL MOBILE LIMITED
//382A19 Technica Engineering GmbH
//74D654, "GINT
//B4E8C9", "XADA Technologies
//7C210E Cisco Systems, Inc
//942DDC Samsung Electronics Co., Ltd
//54F294, "Huawei Device Co., Ltd.
//245AB5 Samsung Electronics Co., Ltd
//C0D2DD", "Samsung Electronics Co., Ltd
//AC1E92", "Samsung Electronics Co., LTD
//0068EB HP Inc.
//7CB37B Qingdao Intelligent&Precise Electronics Co., Ltd.
//484C86 Huawei Device Co., Ltd.
//88123D, "Suzhou Aquila Solutions Inc.
//48210B PEGATRON CORPORATION
//A01C8D", "HUAWEI TECHNOLOGIES CO., LTD
//7C310E Cisco Systems, Inc
//F4DEAF", "HUAWEI TECHNOLOGIES CO., LTD
//60123C HUAWEI TECHNOLOGIES CO., LTD
//48A5E7 Nintendo Co., Ltd
//082CB6 Apple, Inc.
//F84E73 Apple, Inc.
//B4265D Taicang T&W Electronics
//F07807 Apple, Inc.
//3CCD36 Apple, Inc.
//D4B709 zte corporation
//38144E, "Fiberhome Telecommunication Technologies Co., LTD
//5C80B6 Intel Corporate
//F8E4E3", "Intel Corporate
//ACBD0B Leimac Ltd.
//E0CCF8 Xiaomi Communications Co Ltd
//98524A Technicolor CH USA Inc.
//84C5A6 Intel Corporate
//3868A4 Samsung Electronics Co., LTD
//B4A5AC", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD
//1C784E China Mobile Iot Limited company
//843E79, "Shenzhen Belon Technology CO., LTD
//B81904", "Nokia Shanghai Bell Co., Ltd.
//F4A59D Huawei Device Co., Ltd.
//E0F442 Huawei Device Co., Ltd.
//F0C42F Huawei Device Co., Ltd.
//C0B47D Huawei Device Co., Ltd.
//444687, "Realme Chongqing MobileTelecommunications Corp Ltd
//E82689", "Aruba, a Hewlett Packard Enterprise Company
//20F375, "ARRIS Group, Inc.
//84BB69 ARRIS Group, Inc.
//105FD4 Tendyron Corporation
//8CE38E Kioxia Corporation
//A0B439", "Cisco Systems, Inc
//A4B439", "Cisco Systems, Inc
//001038, "Micro Research Ltd.
//E81B4B amnimo Inc.
//CCF411 Google, Inc.
//9C2DCF Shishi Tongyun Technology(Chengdu) Co., Ltd.
//9424B8 GREE ELECTRIC APPLIANCES, INC.OF ZHUHAI
//0433C2 Intel Corporate
//C803F5", "Ruckus Wireless
//000D0A Barco Projection Systems NV
//C467D1", "HUAWEI TECHNOLOGIES CO., LTD
//9C8ACB Juniper Networks
//C8C465", "HUAWEI TECHNOLOGIES CO., LTD
//1C4363 HUAWEI TECHNOLOGIES CO., LTD
//94292F, "New H3C Technologies Co., Ltd
//D49AA0", "VNPT TECHNOLOGY
//F80FF9 Google, Inc.
//8C5AC1 Huawei Device Co., Ltd.
//A85AE0 Huawei Device Co., Ltd.
//A4B61E Huawei Device Co., Ltd.
//"C4FE5B", "GUANGDONG OPPO MOBILE TELECOMMUNICATIONS CORP., LTD",
//C03937", "GREE ELECTRIC APPLIANCES, INC.OF ZHUHAI"},
//B44C3B Zhejiang Dahua Technology Co., Ltd."},
//40A2DB Amazon Technologies Inc."},
//4C6C13 IoT Company Solucoes Tecnologicas Ltda"},
//A885D7 Sangfor Technologies Inc."},
//444ADB Apple, Inc."},
//84F883, "Luminar Technologies"},
//9CA513 Samsung Electronics Co., Ltd"},
//1039E9, "Juniper Networks"},
//309048, "Apple, Inc."},
//D41F0C JAI Manufacturing"},
//C8FA84", "Trusonus corp."},
//C402E1 Khwahish Technologies Private Limited"},
//F85B3B", "ASKEY COMPUTER CORP"},
//786DEB GE Lighting"},
//88E9A4 Hewlett Packard Enterprise"},
//2863BD APTIV SERVICES US, LLC"},
//1C721D Dell Inc."},
//F41C95 BEIJING YUNYI TIMES TECHNOLOGY CO,.LTD"},
//A0687E", "ARRIS Group, Inc."},
//A8705D ARRIS Group, Inc."},
//546503, "Quectel Wireless Solutions Co., Ltd."},
//9C9789", "1MORE"},
//1C05B7 Chongqing Trantor Technology Co., Ltd."},
//000EF3, "Smartlabs, Inc."},
//A043B0 Hangzhou BroadLink Technology Co., Ltd"},
//74ACB9 Ubiquiti Networks Inc."},
//F492BF Ubiquiti Networks Inc."},
//D8C561 CommFront Communications Pte Ltd"},
//0C29EF Dell Inc."},
//60D89C HMD Global Oy"},
//F82E8E Nanjing Kechen Electric Co., Ltd."},
//B4C9B9 Sichuan AI-Link Technology Co., Ltd."},
//F0463B Comcast Cable Corporation"},
//68D79A Ubiquiti Networks Inc."},
//1C63BF SHENZHEN BROADTEL TELECOM CO., LTD"},
//AC3651", "Jiangsu Hengtong Terahertz Technology Co., Ltd."},
//684A76 eero inc."},
//688FC9 Zhuolian (Shenzhen) Communication Co., Ltd"},
//F08175", "Sagemcom Broadband SAS"},"},
//D84732", "TP-LINK TECHNOLOGIES CO., LTD."},
//2864B0 Huawei Device Co., Ltd."},
//04F169, "Huawei Device Co., Ltd."},
//5021EC Huawei Device Co., Ltd."},
//8C683A HUAWEI TECHNOLOGIES CO., LTD"},
//B46E08", "HUAWEI TECHNOLOGIES CO., LTD"},
//005E0C HMD Global Oy"},
//B48107 SHENZHEN CHUANGWEI-RGB ELECTRONICS CO., LTD"},
//706655, "AzureWave Technology Inc."},
//C858C0 Intel Corporate"},
//647C34 Ubee Interactive Co., Limited"},
//6C38A1 Ubee Interactive Co., Limited"},
//78530D, "Shenzhen Skyworth", "Digital Technology", "CO., Ltd"},
//0C48C6 CELESTICA INC."},
//A42985 Sichuan AI-Link Technology Co., Ltd."},
