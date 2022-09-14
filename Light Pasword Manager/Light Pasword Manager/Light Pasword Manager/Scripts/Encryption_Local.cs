using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Pasword_Manager.Scripts
{
    public class Encryption_Local
    {
        private char AA = Convert.ToChar(84);
        private char AD = Convert.ToChar(83);
        private char AF = Convert.ToChar(85);
        private char AG = Convert.ToChar(120);
        private char AK = Convert.ToChar(119);
        private char AN = Convert.ToChar(103);
        private char AS = Convert.ToChar(102);
        private char AV = Convert.ToChar(101);
        private char AX = Convert.ToChar(38);
        private char AZ = Convert.ToChar(39);
        // D Colum
        private char DA = Convert.ToChar(40);
        private char DD = Convert.ToChar(124);
        private char DF = Convert.ToChar(123);
        private char DG = Convert.ToChar(58);
        private char DK = Convert.ToChar(59);
        private char DN = Convert.ToChar(60);
        private char DS = Convert.ToChar(93);
        private char DV = Convert.ToChar(94);
        private char DX = Convert.ToChar(92);
        private char DZ = Convert.ToChar(75);
        // F Colum
        private char FA = Convert.ToChar(76);
        private char FD = Convert.ToChar(114);
        private char FF = Convert.ToChar(113);
        private char FG = Convert.ToChar(112);
        private char FK = Convert.ToChar(48);
        private char FN = Convert.ToChar(49);
        private char FS = Convert.ToChar(50);
        private char FV = Convert.ToChar(33);
        private char FX = Convert.ToChar(34);
        private char FZ = Convert.ToChar(69);
        // G Colum
        private char GA = Convert.ToChar(70);
        private char GD = Convert.ToChar(71);
        private char GF = Convert.ToChar(54);
        private char GG = Convert.ToChar(55);
        private char GK = Convert.ToChar(90);
        private char GN = Convert.ToChar(91);
        private char GS = Convert.ToChar(89);
        private char GV = Convert.ToChar(126);
        private char GX = Convert.ToChar(126);
        private char GZ = Convert.ToChar(125);
        // K Colum
        private char KA = Convert.ToChar(108);
        private char KD = Convert.ToChar(107);
        private char KF = Convert.ToChar(106);
        private char KG = Convert.ToChar(44);
        private char KK = Convert.ToChar(45);
        private char KN = Convert.ToChar(78);
        private char KS = Convert.ToChar(79);
        private char KV = Convert.ToChar(77);
        private char KX = Convert.ToChar(63);
        private char KZ = Convert.ToChar(64);
        // N Colum
        private char NA = Convert.ToChar(100);
        private char ND = Convert.ToChar(99);
        private char NF = Convert.ToChar(98);
        private char NG = Convert.ToChar(81);
        private char NK = Convert.ToChar(80);
        private char NN = Convert.ToChar(82);
        private char NS = Convert.ToChar(121);
        private char NV = Convert.ToChar(118);
        private char NX = Convert.ToChar(117);
        private char NZ = Convert.ToChar(51);
        // S Colum
        private char SA = Convert.ToChar(52);
        private char SD = Convert.ToChar(36);
        private char SF = Convert.ToChar(37);
        private char SG = Convert.ToChar(41);
        private char SK = Convert.ToChar(72);
        private char SN = Convert.ToChar(73);
        private char SS = Convert.ToChar(68);
        private char SV = Convert.ToChar(115);
        private char SX = Convert.ToChar(111);
        private char SZ = Convert.ToChar(96);
        // V Colum
        private char VA = Convert.ToChar(95);
        private char VD = Convert.ToChar(97);
        private char VF = Convert.ToChar(126);
        private char VG = Convert.ToChar(126);
        private char VK = Convert.ToChar(126);
        private char VN = Convert.ToChar(109);
        private char VS = Convert.ToChar(105);
        private char VV = Convert.ToChar(46);
        private char VX = Convert.ToChar(43);
        private char VZ = Convert.ToChar(47);
        // X Colum
        private char XA = Convert.ToChar(67);
        private char XD = Convert.ToChar(74);
        private char XF = Convert.ToChar(66);
        private char XG = Convert.ToChar(61);
        private char XK = Convert.ToChar(62);
        private char XN = Convert.ToChar(110);
        private char XS = Convert.ToChar(104);
        private char XV = Convert.ToChar(88);
        private char XX = Convert.ToChar(35);
        private char XZ = Convert.ToChar(42);
        // Z Colum
        private char ZA = Convert.ToChar(32);
        private char ZD = Convert.ToChar(126);
        private char ZF = Convert.ToChar(122);
        private char ZG = Convert.ToChar(57);
        private char ZK = Convert.ToChar(56);
        private char ZN = Convert.ToChar(65);
        private char ZS = Convert.ToChar(53);
        private char ZV = Convert.ToChar(86);
        private char ZX = Convert.ToChar(87);
        private char ZZ = Convert.ToChar(116);
        // Twist Values
        private int CA = -1;
        private int CD = 0;
        private int CF = 3;
        private int CG = 0;
        private int CK = 1;
        private int CN = 1;
        private int CS = -3;
        private int CV = -1;
        private int CX = -3;
        private int CZ = 1;
        private int RA = 3;
        private int RD = 0;
        private int RF = 1;
        private int RG = -3;
        private int RK = 1;
        private int RN = 0;
        private int RS = 3;
        private int RV = 0;
        private int RX = 3;
        private int RZ = 1;


        public string oEncrypton(string Data, bool Mode)//mode true = encrypt else decyrpt
        {
                if (Mode)
                {
                    return Encrypt(Data);
                }
                else
                {
                    return Decrypt(Data);
                }            
        }
        private string Decrypt(string Input)
        {
            char AAr = AA;
            char ADr = AD;
            char AFr = AF;
            char AGr = AG;
            char AKr = AK;
            char ANr = AN;
            char ASr = AS;
            char AVr = AV;
            char AXr = AX;
            char AZr = AZ;
            // D Colum
            char DAr = DA;
            char DDr = DD;
            char DFr = DF;
            char DGr = DG;
            char DKr = DK;
            char DNr = DN;
            char DSr = DS;
            char DVr = DV;
            char DXr = DX;
            char DZr = DZ;
            // F Colum
            char FAr = FA;
            char FDr = FD;
            char FFr = FF;
            char FGr = FG;
            char FKr = FK;
            char FNr = FN;
            char FSr = FS;
            char FVr = FV;
            char FXr = FX;
            char FZr = FZ;
            // G Colum
            char GAr = GA;
            char GDr = GD;
            char GFr = GF;
            char GGr = GG;
            char GKr = GK;
            char GNr = GN;
            char GSr = GS;
            char GVr = GV;
            char GXr = GX;
            char GZr = GZ;
            // K Colum
            char KAr = KA;
            char KDr = KD;
            char KFr = KF;
            char KGr = KG;
            char KKr = KK;
            char KNr = KN;
            char KSr = KS;
            char KVr = KV;
            char KXr = KX;
            char KZr = KZ;
            // N Colum
            char NAr = NA;
            char NDr = ND;
            char NFr = NF;
            char NGr = NG;
            char NKr = NK;
            char NNr = NN;
            char NSr = NS;
            char NVr = NV;
            char NXr = NX;
            char NZr = NZ;
            // S Colum
            char SAr = SA;
            char SDr = SD;
            char SFr = SF;
            char SGr = SG;
            char SKr = SK;
            char SNr = SN;
            char SSr = SS;
            char SVr = SV;
            char SXr = SX;
            char SZr = SZ;
            // V Colum
            char VAr = VA;
            char VDr = VD;
            char VFr = VF;
            char VGr = VG;
            char VKr = VK;
            char VNr = VN;
            char VSr = VS;
            char VVr = VV;
            char VXr = VX;
            char VZr = VZ;
            // X Colum
            char XAr = XA;
            char XDr = XD;
            char XFr = XF;
            char XGr = XG;
            char XKr = XK;
            char XNr = XN;
            char XSr = XS;
            char XVr = XV;
            char XXr = XX;
            char XZr = XZ;
            // Z Colum
            char ZAr = ZA;
            char ZDr = ZD;
            char ZFr = ZF;
            char ZGr = ZG;
            char ZKr = ZK;
            char ZNr = ZN;
            char ZSr = ZS;
            char ZVr = ZV;
            char ZXr = ZX;
            char ZZr = ZZ;
            string Done = "";
            for (int i = 0; i < Input.Length; i = i + 2)
            {
                /*
                 *
                 *Get Char
                 * 
                 */

                // a
                if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AA")
                {
                    Done = Done + AAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AD")
                {
                    Done = Done + ADr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AF")
                {
                    Done = Done + AFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AG")
                {
                    Done = Done + AGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AK")
                {
                    Done = Done + AKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AN")
                {
                    Done = Done + ANr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AS")
                {
                    Done = Done + ASr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AV")
                {
                    Done = Done + AVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AX")
                {
                    Done = Done + AXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "AZ")
                {
                    Done = Done + AZr.ToString();
                }                //d
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DA")
                {
                    Done = Done + DAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DD")
                {
                    Done = Done + DDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DF")
                {
                    Done = Done + DFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DG")
                {
                    Done = Done + DGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DK")
                {
                    Done = Done + DKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DN")
                {
                    Done = Done + DNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DS")
                {
                    Done = Done + DSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DV")
                {
                    Done = Done + DVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DX")
                {
                    Done = Done + DXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "DZ")
                {
                    Done = Done + DZr.ToString();
                }                //f
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FA")
                {
                    Done = Done + FAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FD")
                {
                    Done = Done + FDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FF")
                {
                    Done = Done + FFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FG")
                {
                    Done = Done + FGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FK")
                {
                    Done = Done + FKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FN")
                {
                    Done = Done + FNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FS")
                {
                    Done = Done + FSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FV")
                {
                    Done = Done + FVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FX")
                {
                    Done = Done + FXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "FZ")
                {
                    Done = Done + FZr.ToString();
                }                //g
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GA")
                {
                    Done = Done + GAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GD")
                {
                    Done = Done + GDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GF")
                {
                    Done = Done + GFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GG")
                {
                    Done = Done + GGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GK")
                {
                    Done = Done + GKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GN")
                {
                    Done = Done + GNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GS")
                {
                    Done = Done + GSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GV")
                {
                    Done = Done + GVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GX")
                {
                    Done = Done + GXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "GZ")
                {
                    Done = Done + GZr.ToString();
                }                //k
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KA")
                {
                    Done = Done + KAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KD")
                {
                    Done = Done + KDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KF")
                {
                    Done = Done + KFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KG")
                {
                    Done = Done + KGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KK")
                {
                    Done = Done + KKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KN")
                {
                    Done = Done + KNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KS")
                {
                    Done = Done + KSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KV")
                {
                    Done = Done + KVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KX")
                {
                    Done = Done + KXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "KZ")
                {
                    Done = Done + KZr.ToString();
                }                                 //n
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NA")
                {
                    Done = Done + NAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ND")
                {
                    Done = Done + NDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NF")
                {
                    Done = Done + NFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NG")
                {
                    Done = Done + NGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NK")
                {
                    Done = Done + NKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NN")
                {
                    Done = Done + NNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NS")
                {
                    Done = Done + NSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NV")
                {
                    Done = Done + NVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NX")
                {
                    Done = Done + NXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "NZ")
                {
                    Done = Done + NZr.ToString();
                }                //s
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SA")
                {
                    Done = Done + SAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SD")
                {
                    Done = Done + SDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SF")
                {
                    Done = Done + SFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SG")
                {
                    Done = Done + SGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SK")
                {
                    Done = Done + SKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SN")
                {
                    Done = Done + SNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SS")
                {
                    Done = Done + SSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SV")
                {
                    Done = Done + SVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SX")
                {
                    Done = Done + SXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "SZ")
                {
                    Done = Done + SZr.ToString();
                }                //v
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VA")
                {
                    Done = Done + VAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VD")
                {
                    Done = Done + VDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VF")
                {
                    Done = Done + VFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VG")
                {
                    Done = Done + VGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VK")
                {
                    Done = Done + VKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VN")
                {
                    Done = Done + VNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VS")
                {
                    Done = Done + VSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VV")
                {
                    Done = Done + VVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VX")
                {
                    Done = Done + VXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "VZ")
                {
                    Done = Done + VZr.ToString();
                }                //x
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XA")
                {
                    Done = Done + XAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XD")
                {
                    Done = Done + XDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XF")
                {
                    Done = Done + XFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XG")
                {
                    Done = Done + XGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XK")
                {
                    Done = Done + XKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XN")
                {
                    Done = Done + XNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XS")
                {
                    Done = Done + XSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XV")
                {
                    Done = Done + XVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XX")
                {
                    Done = Done + XXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "XZ")
                {
                    Done = Done + XZr.ToString();
                }                //z
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZA")
                {
                    Done = Done + ZAr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZD")
                {
                    Done = Done + ZDr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZF")
                {
                    Done = Done + ZFr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZG")
                {
                    Done = Done + ZGr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZK")
                {
                    Done = Done + ZKr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZN")
                {
                    Done = Done + ZNr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZS")
                {
                    Done = Done + ZSr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZV")
                {
                    Done = Done + ZVr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZX")
                {
                    Done = Done + ZXr.ToString();
                }
                else if (Convert.ToString(Input[i].ToString() + Input[i + 1].ToString()) == "ZZ")
                {
                    Done = Done + ZZr.ToString();
                }

                /*
                 * 
                 * Roll
                 * 
                 */


                //CA
                if (CA == 1)
                {
                    char AAt = AAr;
                    char ADt = ADr;
                    char AFt = AFr;
                    char AGt = AGr;
                    char AKt = AKr;
                    char ANt = ANr;
                    char ASt = ASr;
                    char AVt = AVr;
                    char AXt = AXr;
                    char AZt = AZr;
                    AAr = AZt;
                    ADr = AAt;
                    AFr = ADt;
                    AGr = AFt;
                    AKr = AGt;
                    ANr = AKt;
                    ASr = ANt;
                    AVr = ASt;
                    AXr = AVt;
                    AZr = AXt;
                }
                else if (CA == -1)
                {
                    char AAt = AAr;
                    char ADt = ADr;
                    char AFt = AFr;
                    char AGt = AGr;
                    char AKt = AKr;
                    char ANt = ANr;
                    char ASt = ASr;
                    char AVt = AVr;
                    char AXt = AXr;
                    char AZt = AZr;
                    AAr = ADt;
                    ADr = AFt;
                    AFr = AGt;
                    AGr = AKt;
                    AKr = ANt;
                    ANr = ASt;
                    ASr = AVt;
                    AVr = AXt;
                    AXr = AZt;
                    AZr = AAt;
                }

                else if (CA == -3)
                {
                    char AAt = AAr;
                    char ADt = ADr;
                    char AFt = AFr;
                    char AGt = AGr;
                    char AKt = AKr;
                    char ANt = ANr;
                    char ASt = ASr;
                    char AVt = AVr;
                    char AXt = AXr;
                    char AZt = AZr;
                    AAr = AGt;
                    ADr = AKt;
                    AFr = ANt;
                    AGr = ASt;
                    AKr = AVt;
                    ANr = AXt;
                    ASr = AZt;
                    AVr = AAt;
                    AXr = ADt;
                    AZr = AFt;
                }

                else if (CA == 3)
                {
                    char AAt = AAr;
                    char ADt = ADr;
                    char AFt = AFr;
                    char AGt = AGr;
                    char AKt = AKr;
                    char ANt = ANr;
                    char ASt = ASr;
                    char AVt = AVr;
                    char AXt = AXr;
                    char AZt = AZr;
                    AAr = AVt;
                    ADr = AXt;
                    AFr = AZt;
                    AGr = AAt;
                    AKr = ADt;
                    ANr = AFt;
                    ASr = AGt;
                    AVr = AKt;
                    AXr = ANt;
                    AZr = ASt;
                }


                //CD                
                if (CD == 1)
                {
                    char DAt = DAr;
                    char DDt = DDr;
                    char DFt = DFr;
                    char DGt = DGr;
                    char DKt = DKr;
                    char DNt = DNr;
                    char DSt = DSr;
                    char DVt = DVr;
                    char DXt = DXr;
                    char DZt = DZr;
                    DAr = DZt;
                    DDr = DAt;
                    DFr = DDt;
                    DGr = DFt;
                    DKr = DGt;
                    DNr = DKt;
                    DSr = DNt;
                    DVr = DSt;
                    DXr = DVt;
                    DZr = DXt;
                }
                else if (CD == -1)
                {
                    char DAt = DAr;
                    char DDt = DDr;
                    char DFt = DFr;
                    char DGt = DGr;
                    char DKt = DKr;
                    char DNt = DNr;
                    char DSt = DSr;
                    char DVt = DVr;
                    char DXt = DXr;
                    char DZt = DZr;
                    DAr = DDt;
                    DDr = DFt;
                    DFr = DGt;
                    DGr = DKt;
                    DKr = DNt;
                    DNr = DSt;
                    DSr = DVt;
                    DVr = DXt;
                    DXr = DZt;
                    DZr = DAt;
                }

                else if (CD == -3)
                {
                    char DAt = DAr;
                    char DDt = DDr;
                    char DFt = DFr;
                    char DGt = DGr;
                    char DKt = DKr;
                    char DNt = DNr;
                    char DSt = DSr;
                    char DVt = DVr;
                    char DXt = DXr;
                    char DZt = DZr;
                    DAr = DGt;
                    DDr = DKt;
                    DFr = DNt;
                    DGr = DSt;
                    DKr = DVt;
                    DNr = DXt;
                    DSr = DZt;
                    DVr = DAt;
                    DXr = DDt;
                    DZr = DFt;
                }

                else if (CD == 3)
                {
                    char DAt = DAr;
                    char DDt = DDr;
                    char DFt = DFr;
                    char DGt = DGr;
                    char DKt = DKr;
                    char DNt = DNr;
                    char DSt = DSr;
                    char DVt = DVr;
                    char DXt = DXr;
                    char DZt = DZr;
                    DAr = DVt;
                    DDr = DXt;
                    DFr = DZt;
                    DGr = DAt;
                    DKr = DDt;
                    DNr = DFt;
                    DSr = DGt;
                    DVr = DKt;
                    DXr = DNt;
                    DZr = DSt;
                }


                //CF               
                if (CF == 1)
                {
                    char FAt = FAr;
                    char FDt = FDr;
                    char FFt = FFr;
                    char FGt = FGr;
                    char FKt = FKr;
                    char FNt = FNr;
                    char FSt = FSr;
                    char FVt = FVr;
                    char FXt = FXr;
                    char FZt = FZr;
                    FAr = FZt;
                    FDr = FAt;
                    FFr = FDt;
                    FGr = FFt;
                    FKr = FGt;
                    FNr = FKt;
                    FSr = FNt;
                    FVr = FSt;
                    FXr = FVt;
                    FZr = FXt;
                }
                else if (CF == -1)
                {
                    char FAt = FAr;
                    char FDt = FDr;
                    char FFt = FFr;
                    char FGt = FGr;
                    char FKt = FKr;
                    char FNt = FNr;
                    char FSt = FSr;
                    char FVt = FVr;
                    char FXt = FXr;
                    char FZt = FZr;
                    FAr = FDt;
                    FDr = FFt;
                    FFr = FGt;
                    FGr = FKt;
                    FKr = FNt;
                    FNr = FSt;
                    FSr = FVt;
                    FVr = FXt;
                    FXr = FZt;
                    FZr = FAt;
                }

                else if (CF == -3)
                {
                    char FAt = FAr;
                    char FDt = FDr;
                    char FFt = FFr;
                    char FGt = FGr;
                    char FKt = FKr;
                    char FNt = FNr;
                    char FSt = FSr;
                    char FVt = FVr;
                    char FXt = FXr;
                    char FZt = FZr;
                    FAr = FGt;
                    FDr = FKt;
                    FFr = FNt;
                    FGr = FSt;
                    FKr = FVt;
                    FNr = FXt;
                    FSr = FZt;
                    FVr = FAt;
                    FXr = FDt;
                    FZr = FFt;
                }

                else if (CF == 3)
                {
                    char FAt = FAr;
                    char FDt = FDr;
                    char FFt = FFr;
                    char FGt = FGr;
                    char FKt = FKr;
                    char FNt = FNr;
                    char FSt = FSr;
                    char FVt = FVr;
                    char FXt = FXr;
                    char FZt = FZr;
                    FAr = FVt;
                    FDr = FXt;
                    FFr = FZt;
                    FGr = FAt;
                    FKr = FDt;
                    FNr = FFt;
                    FSr = FGt;
                    FVr = FKt;
                    FXr = FNt;
                    FZr = FSt;
                }

                //CG               
                if (CG == 1)
                {
                    char GAt = GAr;
                    char GDt = GDr;
                    char GFt = GFr;
                    char GGt = GGr;
                    char GKt = GKr;
                    char GNt = GNr;
                    char GSt = GSr;
                    char GVt = GVr;
                    char GXt = GXr;
                    char GZt = GZr;
                    GAr = GZt;
                    GDr = GAt;
                    GFr = GDt;
                    GGr = GFt;
                    GKr = GGt;
                    GNr = GKt;
                    GSr = GNt;
                    GVr = GSt;
                    GXr = GVt;
                    GZr = GXt;
                }
                else if (CG == -1)
                {
                    char GAt = GAr;
                    char GDt = GDr;
                    char GFt = GFr;
                    char GGt = GGr;
                    char GKt = GKr;
                    char GNt = GNr;
                    char GSt = GSr;
                    char GVt = GVr;
                    char GXt = GXr;
                    char GZt = GZr;
                    GAr = GDt;
                    GDr = GFt;
                    GFr = GGt;
                    GGr = GKt;
                    GKr = GNt;
                    GNr = GSt;
                    GSr = GVt;
                    GVr = GXt;
                    GXr = GZt;
                    GZr = GAt;
                }

                else if (CG == -3)
                {
                    char GAt = GAr;
                    char GDt = GDr;
                    char GFt = GFr;
                    char GGt = GGr;
                    char GKt = GKr;
                    char GNt = GNr;
                    char GSt = GSr;
                    char GVt = GVr;
                    char GXt = GXr;
                    char GZt = GZr;
                    GAr = GGt;
                    GDr = GKt;
                    GFr = GNt;
                    GGr = GSt;
                    GKr = GVt;
                    GNr = GXt;
                    GSr = GZt;
                    GVr = GAt;
                    GXr = GDt;
                    GZr = GFt;
                }

                else if (CG == 3)
                {
                    char GAt = GAr;
                    char GDt = GDr;
                    char GFt = GFr;
                    char GGt = GGr;
                    char GKt = GKr;
                    char GNt = GNr;
                    char GSt = GSr;
                    char GVt = GVr;
                    char GXt = GXr;
                    char GZt = GZr;
                    GAr = GVt;
                    GDr = GXt;
                    GFr = GZt;
                    GGr = GAt;
                    GKr = GDt;
                    GNr = GFt;
                    GSr = GGt;
                    GVr = GKt;
                    GXr = GNt;
                    GZr = GSt;
                }

                //CK               
                if (CK == 1)
                {
                    char KAt = KAr;
                    char KDt = KDr;
                    char KFt = KFr;
                    char KGt = KGr;
                    char KKt = KKr;
                    char KNt = KNr;
                    char KSt = KSr;
                    char KVt = KVr;
                    char KXt = KXr;
                    char KZt = KZr;
                    KAr = KZt;
                    KDr = KAt;
                    KFr = KDt;
                    KGr = KFt;
                    KKr = KGt;
                    KNr = KKt;
                    KSr = KNt;
                    KVr = KSt;
                    KXr = KVt;
                    KZr = KXt;
                }
                else if (CK == -1)
                {
                    char KAt = KAr;
                    char KDt = KDr;
                    char KFt = KFr;
                    char KGt = KGr;
                    char KKt = KKr;
                    char KNt = KNr;
                    char KSt = KSr;
                    char KVt = KVr;
                    char KXt = KXr;
                    char KZt = KZr;
                    KAr = KDt;
                    KDr = KFt;
                    KFr = KGt;
                    KGr = KKt;
                    KKr = KNt;
                    KNr = KSt;
                    KSr = KVt;
                    KVr = KXt;
                    KXr = KZt;
                    KZr = KAt;
                }

                else if (CK == -3)
                {
                    char KAt = KAr;
                    char KDt = KDr;
                    char KFt = KFr;
                    char KGt = KGr;
                    char KKt = KKr;
                    char KNt = KNr;
                    char KSt = KSr;
                    char KVt = KVr;
                    char KXt = KXr;
                    char KZt = KZr;
                    KAr = KGt;
                    KDr = KKt;
                    KFr = KNt;
                    KGr = KSt;
                    KKr = KVt;
                    KNr = KXt;
                    KSr = KZt;
                    KVr = KAt;
                    KXr = KDt;
                    KZr = KFt;
                }

                else if (CK == 3)
                {
                    char KAt = KAr;
                    char KDt = KDr;
                    char KFt = KFr;
                    char KGt = KGr;
                    char KKt = KKr;
                    char KNt = KNr;
                    char KSt = KSr;
                    char KVt = KVr;
                    char KXt = KXr;
                    char KZt = KZr;
                    KAr = KVt;
                    KDr = KXt;
                    KFr = KZt;
                    KGr = KAt;
                    KKr = KDt;
                    KNr = KFt;
                    KSr = KGt;
                    KVr = KKt;
                    KXr = KNt;
                    KZr = KSt;
                }

                //CN               
                if (CN == 1)
                {
                    char NAt = NAr;
                    char NDt = NDr;
                    char NFt = NFr;
                    char NGt = NGr;
                    char NKt = NKr;
                    char NNt = NNr;
                    char NSt = NSr;
                    char NVt = NVr;
                    char NXt = NXr;
                    char NZt = NZr;
                    NAr = NZt;
                    NDr = NAt;
                    NFr = NDt;
                    NGr = NFt;
                    NKr = NGt;
                    NNr = NKt;
                    NSr = NNt;
                    NVr = NSt;
                    NXr = NVt;
                    NZr = NXt;
                }
                else if (CN == -1)
                {
                    char NAt = NAr;
                    char NDt = NDr;
                    char NFt = NFr;
                    char NGt = NGr;
                    char NKt = NKr;
                    char NNt = NNr;
                    char NSt = NSr;
                    char NVt = NVr;
                    char NXt = NXr;
                    char NZt = NZr;
                    NAr = NDt;
                    NDr = NFt;
                    NFr = NGt;
                    NGr = NKt;
                    NKr = NNt;
                    NNr = NSt;
                    NSr = NVt;
                    NVr = NXt;
                    NXr = NZt;
                    NZr = NAt;
                }

                else if (CN == -3)
                {
                    char NAt = NAr;
                    char NDt = NDr;
                    char NFt = NFr;
                    char NGt = NGr;
                    char NKt = NKr;
                    char NNt = NNr;
                    char NSt = NSr;
                    char NVt = NVr;
                    char NXt = NXr;
                    char NZt = NZr;
                    NAr = NGt;
                    NDr = NKt;
                    NFr = NNt;
                    NGr = NSt;
                    NKr = NVt;
                    NNr = NXt;
                    NSr = NZt;
                    NVr = NAt;
                    NXr = NDt;
                    NZr = NFt;
                }

                else if (CN == 3)
                {
                    char NAt = NAr;
                    char NDt = NDr;
                    char NFt = NFr;
                    char NGt = NGr;
                    char NKt = NKr;
                    char NNt = NNr;
                    char NSt = NSr;
                    char NVt = NVr;
                    char NXt = NXr;
                    char NZt = NZr;
                    NAr = NVt;
                    NDr = NXt;
                    NFr = NZt;
                    NGr = NAt;
                    NKr = NDt;
                    NNr = NFt;
                    NSr = NGt;
                    NVr = NKt;
                    NXr = NNt;
                    NZr = NSt;
                }

                //CS               
                if (CS == 1)
                {
                    char SAt = SAr;
                    char SDt = SDr;
                    char SFt = SFr;
                    char SGt = SGr;
                    char SKt = SKr;
                    char SNt = SNr;
                    char SSt = SSr;
                    char SVt = SVr;
                    char SXt = SXr;
                    char SZt = SZr;
                    SAr = SZt;
                    SDr = SAt;
                    SFr = SDt;
                    SGr = SFt;
                    SKr = SGt;
                    SNr = SKt;
                    SSr = SNt;
                    SVr = SSt;
                    SXr = SVt;
                    SZr = SXt;
                }
                else if (CS == -1)
                {
                    char SAt = SAr;
                    char SDt = SDr;
                    char SFt = SFr;
                    char SGt = SGr;
                    char SKt = SKr;
                    char SNt = SNr;
                    char SSt = SSr;
                    char SVt = SVr;
                    char SXt = SXr;
                    char SZt = SZr;
                    SAr = SDt;
                    SDr = SFt;
                    SFr = SGt;
                    SGr = SKt;
                    SKr = SNt;
                    SNr = SSt;
                    SSr = SVt;
                    SVr = SXt;
                    SXr = SZt;
                    SZr = SAt;
                }

                else if (CS == -3)
                {
                    char SAt = SAr;
                    char SDt = SDr;
                    char SFt = SFr;
                    char SGt = SGr;
                    char SKt = SKr;
                    char SNt = SNr;
                    char SSt = SSr;
                    char SVt = SVr;
                    char SXt = SXr;
                    char SZt = SZr;
                    SAr = SGt;
                    SDr = SKt;
                    SFr = SNt;
                    SGr = SSt;
                    SKr = SVt;
                    SNr = SXt;
                    SSr = SZt;
                    SVr = SAt;
                    SXr = SDt;
                    SZr = SFt;
                }

                else if (CS == 3)
                {
                    char SAt = SAr;
                    char SDt = SDr;
                    char SFt = SFr;
                    char SGt = SGr;
                    char SKt = SKr;
                    char SNt = SNr;
                    char SSt = SSr;
                    char SVt = SVr;
                    char SXt = SXr;
                    char SZt = SZr;
                    SAr = SVt;
                    SDr = SXt;
                    SFr = SZt;
                    SGr = SAt;
                    SKr = SDt;
                    SNr = SFt;
                    SSr = SGt;
                    SVr = SKt;
                    SXr = SNt;
                    SZr = SSt;
                }

                //CV               
                if (CV == 1)
                {
                    char VAt = VAr;
                    char VDt = VDr;
                    char VFt = VFr;
                    char VGt = VGr;
                    char VKt = VKr;
                    char VNt = VNr;
                    char VSt = VSr;
                    char VVt = VVr;
                    char VXt = VXr;
                    char VZt = VZr;
                    VAr = VZt;
                    VDr = VAt;
                    VFr = VDt;
                    VGr = VFt;
                    VKr = VGt;
                    VNr = VKt;
                    VSr = VNt;
                    VVr = VSt;
                    VXr = VVt;
                    VZr = VXt;
                }
                else if (CV == -1)
                {
                    char VAt = VAr;
                    char VDt = VDr;
                    char VFt = VFr;
                    char VGt = VGr;
                    char VKt = VKr;
                    char VNt = VNr;
                    char VSt = VSr;
                    char VVt = VVr;
                    char VXt = VXr;
                    char VZt = VZr;
                    VAr = VDt;
                    VDr = VFt;
                    VFr = VGt;
                    VGr = VKt;
                    VKr = VNt;
                    VNr = VSt;
                    VSr = VVt;
                    VVr = VXt;
                    VXr = VZt;
                    VZr = VAt;
                }

                else if (CV == -3)
                {
                    char VAt = VAr;
                    char VDt = VDr;
                    char VFt = VFr;
                    char VGt = VGr;
                    char VKt = VKr;
                    char VNt = VNr;
                    char VSt = VSr;
                    char VVt = VVr;
                    char VXt = VXr;
                    char VZt = VZr;
                    VAr = VGt;
                    VDr = VKt;
                    VFr = VNt;
                    VGr = VSt;
                    VKr = VVt;
                    VNr = VXt;
                    VSr = VZt;
                    VVr = VAt;
                    VXr = VDt;
                    VZr = VFt;
                }

                else if (CV == 3)
                {
                    char VAt = VAr;
                    char VDt = VDr;
                    char VFt = VFr;
                    char VGt = VGr;
                    char VKt = VKr;
                    char VNt = VNr;
                    char VSt = VSr;
                    char VVt = VVr;
                    char VXt = VXr;
                    char VZt = VZr;
                    VAr = VVt;
                    VDr = VXt;
                    VFr = VZt;
                    VGr = VAt;
                    VKr = VDt;
                    VNr = VFt;
                    VSr = VGt;
                    VVr = VKt;
                    VXr = VNt;
                    VZr = VSt;
                }

                //CX               
                if (CX == 1)
                {
                    char XAt = XAr;
                    char XDt = XDr;
                    char XFt = XFr;
                    char XGt = XGr;
                    char XKt = XKr;
                    char XNt = XNr;
                    char XSt = XSr;
                    char XVt = XVr;
                    char XXt = XXr;
                    char XZt = XZr;
                    XAr = XZt;
                    XDr = XAt;
                    XFr = XDt;
                    XGr = XFt;
                    XKr = XGt;
                    XNr = XKt;
                    XSr = XNt;
                    XVr = XSt;
                    XXr = XVt;
                    XZr = XXt;
                }
                else if (CX == -1)
                {
                    char XAt = XAr;
                    char XDt = XDr;
                    char XFt = XFr;
                    char XGt = XGr;
                    char XKt = XKr;
                    char XNt = XNr;
                    char XSt = XSr;
                    char XVt = XVr;
                    char XXt = XXr;
                    char XZt = XZr;
                    XAr = XDt;
                    XDr = XFt;
                    XFr = XGt;
                    XGr = XKt;
                    XKr = XNt;
                    XNr = XSt;
                    XSr = XVt;
                    XVr = XXt;
                    XXr = XZt;
                    XZr = XAt;
                }

                else if (CX == -3)
                {
                    char XAt = XAr;
                    char XDt = XDr;
                    char XFt = XFr;
                    char XGt = XGr;
                    char XKt = XKr;
                    char XNt = XNr;
                    char XSt = XSr;
                    char XVt = XVr;
                    char XXt = XXr;
                    char XZt = XZr;
                    XAr = XGt;
                    XDr = XKt;
                    XFr = XNt;
                    XGr = XSt;
                    XKr = XVt;
                    XNr = XXt;
                    XSr = XZt;
                    XVr = XAt;
                    XXr = XDt;
                    XZr = XFt;
                }

                else if (CX == 3)
                {
                    char XAt = XAr;
                    char XDt = XDr;
                    char XFt = XFr;
                    char XGt = XGr;
                    char XKt = XKr;
                    char XNt = XNr;
                    char XSt = XSr;
                    char XVt = XVr;
                    char XXt = XXr;
                    char XZt = XZr;
                    XAr = XVt;
                    XDr = XXt;
                    XFr = XZt;
                    XGr = XAt;
                    XKr = XDt;
                    XNr = XFt;
                    XSr = XGt;
                    XVr = XKt;
                    XXr = XNt;
                    XZr = XSt;
                }

                //CZ               
                if (CZ == 1)
                {
                    char ZAt = ZAr;
                    char ZDt = ZDr;
                    char ZFt = ZFr;
                    char ZGt = ZGr;
                    char ZKt = ZKr;
                    char ZNt = ZNr;
                    char ZSt = ZSr;
                    char ZVt = ZVr;
                    char ZXt = ZXr;
                    char ZZt = ZZr;
                    ZAr = ZZt;
                    ZDr = ZAt;
                    ZFr = ZDt;
                    ZGr = ZFt;
                    ZKr = ZGt;
                    ZNr = ZKt;
                    ZSr = ZNt;
                    ZVr = ZSt;
                    ZXr = ZVt;
                    ZZr = ZXt;
                }
                else if (CZ == -1)
                {
                    char ZAt = ZAr;
                    char ZDt = ZDr;
                    char ZFt = ZFr;
                    char ZGt = ZGr;
                    char ZKt = ZKr;
                    char ZNt = ZNr;
                    char ZSt = ZSr;
                    char ZVt = ZVr;
                    char ZXt = ZXr;
                    char ZZt = ZZr;
                    ZAr = ZDt;
                    ZDr = ZFt;
                    ZFr = ZGt;
                    ZGr = ZKt;
                    ZKr = ZNt;
                    ZNr = ZSt;
                    ZSr = ZVt;
                    ZVr = ZXt;
                    ZXr = ZZt;
                    ZZr = ZAt;
                }

                else if (CZ == -3)
                {
                    char ZAt = ZAr;
                    char ZDt = ZDr;
                    char ZFt = ZFr;
                    char ZGt = ZGr;
                    char ZKt = ZKr;
                    char ZNt = ZNr;
                    char ZSt = ZSr;
                    char ZVt = ZVr;
                    char ZXt = ZXr;
                    char ZZt = ZZr;
                    ZAr = ZGt;
                    ZDr = ZKt;
                    ZFr = ZNt;
                    ZGr = ZSt;
                    ZKr = ZVt;
                    ZNr = ZXt;
                    ZSr = ZZt;
                    ZVr = ZAt;
                    ZXr = ZDt;
                    ZZr = ZFt;
                }

                else if (CZ == 3)
                {
                    char ZAt = ZAr;
                    char ZDt = ZDr;
                    char ZFt = ZFr;
                    char ZGt = ZGr;
                    char ZKt = ZKr;
                    char ZNt = ZNr;
                    char ZSt = ZSr;
                    char ZVt = ZVr;
                    char ZXt = ZXr;
                    char ZZt = ZZr;
                    ZAr = ZVt;
                    ZDr = ZXt;
                    ZFr = ZZt;
                    ZGr = ZAt;
                    ZKr = ZDt;
                    ZNr = ZFt;
                    ZSr = ZGt;
                    ZVr = ZKt;
                    ZXr = ZNt;
                    ZZr = ZSt;
                }

                //RA
                if (RA == 1)
                {
                    char AAt = AAr;
                    char DAt = DAr;
                    char FAt = FAr;
                    char GAt = GAr;
                    char KAt = KAr;
                    char NAt = NAr;
                    char SAt = SAr;
                    char VAt = VAr;
                    char XAt = XAr;
                    char ZAt = ZAr;
                    AAr = ZAt;
                    DAr = AAt;
                    FAr = DAt;
                    GAr = FAt;
                    KAr = GAt;
                    NAr = KAt;
                    SAr = NAt;
                    VAr = SAt;
                    XAr = VAt;
                    ZAr = XAt;
                }
                else if (RA == -1)
                {
                    char AAt = AAr;
                    char DAt = DAr;
                    char FAt = FAr;
                    char GAt = GAr;
                    char KAt = KAr;
                    char NAt = NAr;
                    char SAt = SAr;
                    char VAt = VAr;
                    char XAt = XAr;
                    char ZAt = ZAr;
                    AAr = DAt;
                    DAr = FAt;
                    FAr = GAt;
                    GAr = KAt;
                    KAr = NAt;
                    NAr = SAt;
                    SAr = VAt;
                    VAr = XAt;
                    XAr = ZAt;
                    ZAr = AAt;
                }
                else if (RA == -3)
                {
                    char AAt = AAr;
                    char DAt = DAr;
                    char FAt = FAr;
                    char GAt = GAr;
                    char KAt = KAr;
                    char NAt = NAr;
                    char SAt = SAr;
                    char VAt = VAr;
                    char XAt = XAr;
                    char ZAt = ZAr;
                    AAr = GAt;
                    DAr = KAt;
                    FAr = NAt;
                    GAr = SAt;
                    KAr = VAt;
                    NAr = XAt;
                    SAr = ZAt;
                    VAr = AAt;
                    XAr = DAt;
                    ZAr = FAt;
                }
                else if (RA == -3)
                {
                    char AAt = AAr;
                    char DAt = DAr;
                    char FAt = FAr;
                    char GAt = GAr;
                    char KAt = KAr;
                    char NAt = NAr;
                    char SAt = SAr;
                    char VAt = VAr;
                    char XAt = XAr;
                    char ZAt = ZAr;
                    AAr = VAt;
                    DAr = XAt;
                    FAr = ZAt;
                    GAr = AAt;
                    KAr = DAt;
                    NAr = FAt;
                    SAr = GAt;
                    VAr = KAt;
                    XAr = NAt;
                    ZAr = SAt;
                }

                //RD
                if (RD == 1)
                {
                    char ADt = ADr;
                    char DDt = DDr;
                    char FDt = FDr;
                    char GDt = GDr;
                    char KDt = KDr;
                    char NDt = NDr;
                    char SDt = SDr;
                    char VDt = VDr;
                    char XDt = XDr;
                    char ZDt = ZDr;
                    ADr = ZDt;
                    DDr = ADt;
                    FDr = DDt;
                    GDr = FDt;
                    KDr = GDt;
                    NDr = KDt;
                    SDr = NDt;
                    VDr = SDt;
                    XDr = VDt;
                    ZDr = XDt;
                }
                else if (RD == -1)
                {
                    char ADt = ADr;
                    char DDt = DDr;
                    char FDt = FDr;
                    char GDt = GDr;
                    char KDt = KDr;
                    char NDt = NDr;
                    char SDt = SDr;
                    char VDt = VDr;
                    char XDt = XDr;
                    char ZDt = ZDr;
                    ADr = DDt;
                    DDr = FDt;
                    FDr = GDt;
                    GDr = KDt;
                    KDr = NDt;
                    NDr = SDt;
                    SDr = VDt;
                    VDr = XDt;
                    XDr = ZDt;
                    ZDr = ADt;
                }
                else if (RD == -3)
                {
                    char ADt = ADr;
                    char DDt = DDr;
                    char FDt = FDr;
                    char GDt = GDr;
                    char KDt = KDr;
                    char NDt = NDr;
                    char SDt = SDr;
                    char VDt = VDr;
                    char XDt = XDr;
                    char ZDt = ZDr;
                    ADr = GDt;
                    DDr = KDt;
                    FDr = NDt;
                    GDr = SDt;
                    KDr = VDt;
                    NDr = XDt;
                    SDr = ZDt;
                    VDr = ADt;
                    XDr = DDt;
                    ZDr = FDt;
                }
                else if (RD == -3)
                {
                    char ADt = ADr;
                    char DDt = DDr;
                    char FDt = FDr;
                    char GDt = GDr;
                    char KDt = KDr;
                    char NDt = NDr;
                    char SDt = SDr;
                    char VDt = VDr;
                    char XDt = XDr;
                    char ZDt = ZDr;
                    ADr = VDt;
                    DDr = XDt;
                    FDr = ZDt;
                    GDr = ADt;
                    KDr = DDt;
                    NDr = FDt;
                    SDr = GDt;
                    VDr = KDt;
                    XDr = NDt;
                    ZDr = SDt;
                }

                //RF
                if (RF == 1)
                {
                    char AFt = AFr;
                    char DFt = DFr;
                    char FFt = FFr;
                    char GFt = GFr;
                    char KFt = KFr;
                    char NFt = NFr;
                    char SFt = SFr;
                    char VFt = VFr;
                    char XFt = XFr;
                    char ZFt = ZFr;
                    AFr = ZFt;
                    DFr = AFt;
                    FFr = DFt;
                    GFr = FFt;
                    KFr = GFt;
                    NFr = KFt;
                    SFr = NFt;
                    VFr = SFt;
                    XFr = VFt;
                    ZFr = XFt;
                }
                else if (RF == -1)
                {
                    char AFt = AFr;
                    char DFt = DFr;
                    char FFt = FFr;
                    char GFt = GFr;
                    char KFt = KFr;
                    char NFt = NFr;
                    char SFt = SFr;
                    char VFt = VFr;
                    char XFt = XFr;
                    char ZFt = ZFr;
                    AFr = DFt;
                    DFr = FFt;
                    FFr = GFt;
                    GFr = KFt;
                    KFr = NFt;
                    NFr = SFt;
                    SFr = VFt;
                    VFr = XFt;
                    XFr = ZFt;
                    ZFr = AFt;
                }
                else if (RF == -3)
                {
                    char AFt = AFr;
                    char DFt = DFr;
                    char FFt = FFr;
                    char GFt = GFr;
                    char KFt = KFr;
                    char NFt = NFr;
                    char SFt = SFr;
                    char VFt = VFr;
                    char XFt = XFr;
                    char ZFt = ZFr;
                    AFr = GFt;
                    DFr = KFt;
                    FFr = NFt;
                    GFr = SFt;
                    KFr = VFt;
                    NFr = XFt;
                    SFr = ZFt;
                    VFr = AFt;
                    XFr = DFt;
                    ZFr = FFt;
                }
                else if (RF == -3)
                {
                    char AFt = AFr;
                    char DFt = DFr;
                    char FFt = FFr;
                    char GFt = GFr;
                    char KFt = KFr;
                    char NFt = NFr;
                    char SFt = SFr;
                    char VFt = VFr;
                    char XFt = XFr;
                    char ZFt = ZFr;
                    AFr = VFt;
                    DFr = XFt;
                    FFr = ZFt;
                    GFr = AFt;
                    KFr = DFt;
                    NFr = FFt;
                    SFr = GFt;
                    VFr = KFt;
                    XFr = NFt;
                    ZFr = SFt;
                }

                //RG
                if (RG == 1)
                {
                    char AGt = AGr;
                    char DGt = DGr;
                    char FGt = FGr;
                    char GGt = GGr;
                    char KGt = KGr;
                    char NGt = NGr;
                    char SGt = SGr;
                    char VGt = VGr;
                    char XGt = XGr;
                    char ZGt = ZGr;
                    AGr = ZGt;
                    DGr = AGt;
                    FGr = DGt;
                    GGr = FGt;
                    KGr = GGt;
                    NGr = KGt;
                    SGr = NGt;
                    VGr = SGt;
                    XGr = VGt;
                    ZGr = XGt;
                }
                else if (RG == -1)
                {
                    char AGt = AGr;
                    char DGt = DGr;
                    char FGt = FGr;
                    char GGt = GGr;
                    char KGt = KGr;
                    char NGt = NGr;
                    char SGt = SGr;
                    char VGt = VGr;
                    char XGt = XGr;
                    char ZGt = ZGr;
                    AGr = DGt;
                    DGr = FGt;
                    FGr = GGt;
                    GGr = KGt;
                    KGr = NGt;
                    NGr = SGt;
                    SGr = VGt;
                    VGr = XGt;
                    XGr = ZGt;
                    ZGr = AGt;
                }
                else if (RG == -3)
                {
                    char AGt = AGr;
                    char DGt = DGr;
                    char FGt = FGr;
                    char GGt = GGr;
                    char KGt = KGr;
                    char NGt = NGr;
                    char SGt = SGr;
                    char VGt = VGr;
                    char XGt = XGr;
                    char ZGt = ZGr;
                    AGr = GGt;
                    DGr = KGt;
                    FGr = NGt;
                    GGr = SGt;
                    KGr = VGt;
                    NGr = XGt;
                    SGr = ZGt;
                    VGr = AGt;
                    XGr = DGt;
                    ZGr = FGt;
                }
                else if (RG == -3)
                {
                    char AGt = AGr;
                    char DGt = DGr;
                    char FGt = FGr;
                    char GGt = GGr;
                    char KGt = KGr;
                    char NGt = NGr;
                    char SGt = SGr;
                    char VGt = VGr;
                    char XGt = XGr;
                    char ZGt = ZGr;
                    AGr = VGt;
                    DGr = XGt;
                    FGr = ZGt;
                    GGr = AGt;
                    KGr = DGt;
                    NGr = FGt;
                    SGr = GGt;
                    VGr = KGt;
                    XGr = NGt;
                    ZGr = SGt;
                }

                //RK
                if (RK == 1)
                {
                    char AKt = AKr;
                    char DKt = DKr;
                    char FKt = FKr;
                    char GKt = GKr;
                    char KKt = KKr;
                    char NKt = NKr;
                    char SKt = SKr;
                    char VKt = VKr;
                    char XKt = XKr;
                    char ZKt = ZKr;
                    AKr = ZKt;
                    DKr = AKt;
                    FKr = DKt;
                    GKr = FKt;
                    KKr = GKt;
                    NKr = KKt;
                    SKr = NKt;
                    VKr = SKt;
                    XKr = VKt;
                    ZKr = XKt;
                }
                else if (RK == -1)
                {
                    char AKt = AKr;
                    char DKt = DKr;
                    char FKt = FKr;
                    char GKt = GKr;
                    char KKt = KKr;
                    char NKt = NKr;
                    char SKt = SKr;
                    char VKt = VKr;
                    char XKt = XKr;
                    char ZKt = ZKr;
                    AKr = DKt;
                    DKr = FKt;
                    FKr = GKt;
                    GKr = KKt;
                    KKr = NKt;
                    NKr = SKt;
                    SKr = VKt;
                    VKr = XKt;
                    XKr = ZKt;
                    ZKr = AKt;
                }
                else if (RK == -3)
                {
                    char AKt = AKr;
                    char DKt = DKr;
                    char FKt = FKr;
                    char GKt = GKr;
                    char KKt = KKr;
                    char NKt = NKr;
                    char SKt = SKr;
                    char VKt = VKr;
                    char XKt = XKr;
                    char ZKt = ZKr;
                    AKr = GKt;
                    DKr = KKt;
                    FKr = NKt;
                    GKr = SKt;
                    KKr = VKt;
                    NKr = XKt;
                    SKr = ZKt;
                    VKr = AKt;
                    XKr = DKt;
                    ZKr = FKt;
                }
                else if (RK == -3)
                {
                    char AKt = AKr;
                    char DKt = DKr;
                    char FKt = FKr;
                    char GKt = GKr;
                    char KKt = KKr;
                    char NKt = NKr;
                    char SKt = SKr;
                    char VKt = VKr;
                    char XKt = XKr;
                    char ZKt = ZKr;
                    AKr = VKt;
                    DKr = XKt;
                    FKr = ZKt;
                    GKr = AKt;
                    KKr = DKt;
                    NKr = FKt;
                    SKr = GKt;
                    VKr = KKt;
                    XKr = NKt;
                    ZKr = SKt;
                }

                //RN
                if (RN == 1)
                {
                    char ANt = ANr;
                    char DNt = DNr;
                    char FNt = FNr;
                    char GNt = GNr;
                    char KNt = KNr;
                    char NNt = NNr;
                    char SNt = SNr;
                    char VNt = VNr;
                    char XNt = XNr;
                    char ZNt = ZNr;
                    ANr = ZNt;
                    DNr = ANt;
                    FNr = DNt;
                    GNr = FNt;
                    KNr = GNt;
                    NNr = KNt;
                    SNr = NNt;
                    VNr = SNt;
                    XNr = VNt;
                    ZNr = XNt;
                }
                else if (RN == -1)
                {
                    char ANt = ANr;
                    char DNt = DNr;
                    char FNt = FNr;
                    char GNt = GNr;
                    char KNt = KNr;
                    char NNt = NNr;
                    char SNt = SNr;
                    char VNt = VNr;
                    char XNt = XNr;
                    char ZNt = ZNr;
                    ANr = DNt;
                    DNr = FNt;
                    FNr = GNt;
                    GNr = KNt;
                    KNr = NNt;
                    NNr = SNt;
                    SNr = VNt;
                    VNr = XNt;
                    XNr = ZNt;
                    ZNr = ANt;
                }
                else if (RN == -3)
                {
                    char ANt = ANr;
                    char DNt = DNr;
                    char FNt = FNr;
                    char GNt = GNr;
                    char KNt = KNr;
                    char NNt = NNr;
                    char SNt = SNr;
                    char VNt = VNr;
                    char XNt = XNr;
                    char ZNt = ZNr;
                    ANr = GNt;
                    DNr = KNt;
                    FNr = NNt;
                    GNr = SNt;
                    KNr = VNt;
                    NNr = XNt;
                    SNr = ZNt;
                    VNr = ANt;
                    XNr = DNt;
                    ZNr = FNt;
                }
                else if (RN == -3)
                {
                    char ANt = ANr;
                    char DNt = DNr;
                    char FNt = FNr;
                    char GNt = GNr;
                    char KNt = KNr;
                    char NNt = NNr;
                    char SNt = SNr;
                    char VNt = VNr;
                    char XNt = XNr;
                    char ZNt = ZNr;
                    ANr = VNt;
                    DNr = XNt;
                    FNr = ZNt;
                    GNr = ANt;
                    KNr = DNt;
                    NNr = FNt;
                    SNr = GNt;
                    VNr = KNt;
                    XNr = NNt;
                    ZNr = SNt;
                }

                //RS
                if (RS == 1)
                {
                    char ASt = ASr;
                    char DSt = DSr;
                    char FSt = FSr;
                    char GSt = GSr;
                    char KSt = KSr;
                    char NSt = NSr;
                    char SSt = SSr;
                    char VSt = VSr;
                    char XSt = XSr;
                    char ZSt = ZSr;
                    ASr = ZSt;
                    DSr = ASt;
                    FSr = DSt;
                    GSr = FSt;
                    KSr = GSt;
                    NSr = KSt;
                    SSr = NSt;
                    VSr = SSt;
                    XSr = VSt;
                    ZSr = XSt;
                }
                else if (RS == -1)
                {
                    char ASt = ASr;
                    char DSt = DSr;
                    char FSt = FSr;
                    char GSt = GSr;
                    char KSt = KSr;
                    char NSt = NSr;
                    char SSt = SSr;
                    char VSt = VSr;
                    char XSt = XSr;
                    char ZSt = ZSr;
                    ASr = DSt;
                    DSr = FSt;
                    FSr = GSt;
                    GSr = KSt;
                    KSr = NSt;
                    NSr = SSt;
                    SSr = VSt;
                    VSr = XSt;
                    XSr = ZSt;
                    ZSr = ASt;
                }
                else if (RS == -3)
                {
                    char ASt = ASr;
                    char DSt = DSr;
                    char FSt = FSr;
                    char GSt = GSr;
                    char KSt = KSr;
                    char NSt = NSr;
                    char SSt = SSr;
                    char VSt = VSr;
                    char XSt = XSr;
                    char ZSt = ZSr;
                    ASr = GSt;
                    DSr = KSt;
                    FSr = NSt;
                    GSr = SSt;
                    KSr = VSt;
                    NSr = XSt;
                    SSr = ZSt;
                    VSr = ASt;
                    XSr = DSt;
                    ZSr = FSt;
                }
                else if (RS == -3)
                {
                    char ASt = ASr;
                    char DSt = DSr;
                    char FSt = FSr;
                    char GSt = GSr;
                    char KSt = KSr;
                    char NSt = NSr;
                    char SSt = SSr;
                    char VSt = VSr;
                    char XSt = XSr;
                    char ZSt = ZSr;
                    ASr = VSt;
                    DSr = XSt;
                    FSr = ZSt;
                    GSr = ASt;
                    KSr = DSt;
                    NSr = FSt;
                    SSr = GSt;
                    VSr = KSt;
                    XSr = NSt;
                    ZSr = SSt;
                }

                //RV
                if (RV == 1)
                {
                    char AVt = AVr;
                    char DVt = DVr;
                    char FVt = FVr;
                    char GVt = GVr;
                    char KVt = KVr;
                    char NVt = NVr;
                    char SVt = SVr;
                    char VVt = VVr;
                    char XVt = XVr;
                    char ZVt = ZVr;
                    AVr = ZVt;
                    DVr = AVt;
                    FVr = DVt;
                    GVr = FVt;
                    KVr = GVt;
                    NVr = KVt;
                    SVr = NVt;
                    VVr = SVt;
                    XVr = VVt;
                    ZVr = XVt;
                }
                else if (RV == -1)
                {
                    char AVt = AVr;
                    char DVt = DVr;
                    char FVt = FVr;
                    char GVt = GVr;
                    char KVt = KVr;
                    char NVt = NVr;
                    char SVt = SVr;
                    char VVt = VVr;
                    char XVt = XVr;
                    char ZVt = ZVr;
                    AVr = DVt;
                    DVr = FVt;
                    FVr = GVt;
                    GVr = KVt;
                    KVr = NVt;
                    NVr = SVt;
                    SVr = VVt;
                    VVr = XVt;
                    XVr = ZVt;
                    ZVr = AVt;
                }
                else if (RV == -3)
                {
                    char AVt = AVr;
                    char DVt = DVr;
                    char FVt = FVr;
                    char GVt = GVr;
                    char KVt = KVr;
                    char NVt = NVr;
                    char SVt = SVr;
                    char VVt = VVr;
                    char XVt = XVr;
                    char ZVt = ZVr;
                    AVr = GVt;
                    DVr = KVt;
                    FVr = NVt;
                    GVr = SVt;
                    KVr = VVt;
                    NVr = XVt;
                    SVr = ZVt;
                    VVr = AVt;
                    XVr = DVt;
                    ZVr = FVt;
                }
                else if (RV == -3)
                {
                    char AVt = AVr;
                    char DVt = DVr;
                    char FVt = FVr;
                    char GVt = GVr;
                    char KVt = KVr;
                    char NVt = NVr;
                    char SVt = SVr;
                    char VVt = VVr;
                    char XVt = XVr;
                    char ZVt = ZVr;
                    AVr = VVt;
                    DVr = XVt;
                    FVr = ZVt;
                    GVr = AVt;
                    KVr = DVt;
                    NVr = FVt;
                    SVr = GVt;
                    VVr = KVt;
                    XVr = NVt;
                    ZVr = SVt;
                }

                //RX
                if (RX == 1)
                {
                    char AXt = AXr;
                    char DXt = DXr;
                    char FXt = FXr;
                    char GXt = GXr;
                    char KXt = KXr;
                    char NXt = NXr;
                    char SXt = SXr;
                    char VXt = VXr;
                    char XXt = XXr;
                    char ZXt = ZXr;
                    AXr = ZXt;
                    DXr = AXt;
                    FXr = DXt;
                    GXr = FXt;
                    KXr = GXt;
                    NXr = KXt;
                    SXr = NXt;
                    VXr = SXt;
                    XXr = VXt;
                    ZXr = XXt;
                }
                else if (RX == -1)
                {
                    char AXt = AXr;
                    char DXt = DXr;
                    char FXt = FXr;
                    char GXt = GXr;
                    char KXt = KXr;
                    char NXt = NXr;
                    char SXt = SXr;
                    char VXt = VXr;
                    char XXt = XXr;
                    char ZXt = ZXr;
                    AXr = DXt;
                    DXr = FXt;
                    FXr = GXt;
                    GXr = KXt;
                    KXr = NXt;
                    NXr = SXt;
                    SXr = VXt;
                    VXr = XXt;
                    XXr = ZXt;
                    ZXr = AXt;
                }
                else if (RX == -3)
                {
                    char AXt = AXr;
                    char DXt = DXr;
                    char FXt = FXr;
                    char GXt = GXr;
                    char KXt = KXr;
                    char NXt = NXr;
                    char SXt = SXr;
                    char VXt = VXr;
                    char XXt = XXr;
                    char ZXt = ZXr;
                    AXr = GXt;
                    DXr = KXt;
                    FXr = NXt;
                    GXr = SXt;
                    KXr = VXt;
                    NXr = XXt;
                    SXr = ZXt;
                    VXr = AXt;
                    XXr = DXt;
                    ZXr = FXt;
                }
                else if (RX == -3)
                {
                    char AXt = AXr;
                    char DXt = DXr;
                    char FXt = FXr;
                    char GXt = GXr;
                    char KXt = KXr;
                    char NXt = NXr;
                    char SXt = SXr;
                    char VXt = VXr;
                    char XXt = XXr;
                    char ZXt = ZXr;
                    AXr = VXt;
                    DXr = XXt;
                    FXr = ZXt;
                    GXr = AXt;
                    KXr = DXt;
                    NXr = FXt;
                    SXr = GXt;
                    VXr = KXt;
                    XXr = NXt;
                    ZXr = SXt;
                }

                //RZ
                if (RZ == 1)
                {
                    char AZt = AZr;
                    char DZt = DZr;
                    char FZt = FZr;
                    char GZt = GZr;
                    char KZt = KZr;
                    char NZt = NZr;
                    char SZt = SZr;
                    char VZt = VZr;
                    char XZt = XZr;
                    char ZZt = ZZr;
                    AZr = ZZt;
                    DZr = AZt;
                    FZr = DZt;
                    GZr = FZt;
                    KZr = GZt;
                    NZr = KZt;
                    SZr = NZt;
                    VZr = SZt;
                    XZr = VZt;
                    ZZr = XZt;
                }
                else if (RZ == -1)
                {
                    char AZt = AZr;
                    char DZt = DZr;
                    char FZt = FZr;
                    char GZt = GZr;
                    char KZt = KZr;
                    char NZt = NZr;
                    char SZt = SZr;
                    char VZt = VZr;
                    char XZt = XZr;
                    char ZZt = ZZr;
                    AZr = DZt;
                    DZr = FZt;
                    FZr = GZt;
                    GZr = KZt;
                    KZr = NZt;
                    NZr = SZt;
                    SZr = VZt;
                    VZr = XZt;
                    XZr = ZZt;
                    ZZr = AZt;
                }
                else if (RZ == -3)
                {
                    char AZt = AZr;
                    char DZt = DZr;
                    char FZt = FZr;
                    char GZt = GZr;
                    char KZt = KZr;
                    char NZt = NZr;
                    char SZt = SZr;
                    char VZt = VZr;
                    char XZt = XZr;
                    char ZZt = ZZr;
                    AZr = GZt;
                    DZr = KZt;
                    FZr = NZt;
                    GZr = SZt;
                    KZr = VZt;
                    NZr = XZt;
                    SZr = ZZt;
                    VZr = AZt;
                    XZr = DZt;
                    ZZr = FZt;
                }
                else if (RZ == -3)
                {
                    char AZt = AZr;
                    char DZt = DZr;
                    char FZt = FZr;
                    char GZt = GZr;
                    char KZt = KZr;
                    char NZt = NZr;
                    char SZt = SZr;
                    char VZt = VZr;
                    char XZt = XZr;
                    char ZZt = ZZr;
                    AZr = VZt;
                    DZr = XZt;
                    FZr = ZZt;
                    GZr = AZt;
                    KZr = DZt;
                    NZr = FZt;
                    SZr = GZt;
                    VZr = KZt;
                    XZr = NZt;
                    ZZr = SZt;
                }

            }
            return Done;
        }

        private string Encrypt(string Input)
        {
            char AAr = AA;
            char ADr = AD;
            char AFr = AF;
            char AGr = AG;
            char AKr = AK;
            char ANr = AN;
            char ASr = AS;
            char AVr = AV;
            char AXr = AX;
            char AZr = AZ;
            // D Colum
            char DAr = DA;
            char DDr = DD;
            char DFr = DF;
            char DGr = DG;
            char DKr = DK;
            char DNr = DN;
            char DSr = DS;
            char DVr = DV;
            char DXr = DX;
            char DZr = DZ;
            // F Colum
            char FAr = FA;
            char FDr = FD;
            char FFr = FF;
            char FGr = FG;
            char FKr = FK;
            char FNr = FN;
            char FSr = FS;
            char FVr = FV;
            char FXr = FX;
            char FZr = FZ;
            // G Colum
            char GAr = GA;
            char GDr = GD;
            char GFr = GF;
            char GGr = GG;
            char GKr = GK;
            char GNr = GN;
            char GSr = GS;
            char GVr = GV;
            char GXr = GX;
            char GZr = GZ;
            // K Colum
            char KAr = KA;
            char KDr = KD;
            char KFr = KF;
            char KGr = KG;
            char KKr = KK;
            char KNr = KN;
            char KSr = KS;
            char KVr = KV;
            char KXr = KX;
            char KZr = KZ;
            // N Colum
            char NAr = NA;
            char NDr = ND;
            char NFr = NF;
            char NGr = NG;
            char NKr = NK;
            char NNr = NN;
            char NSr = NS;
            char NVr = NV;
            char NXr = NX;
            char NZr = NZ;
            // S Colum
            char SAr = SA;
            char SDr = SD;
            char SFr = SF;
            char SGr = SG;
            char SKr = SK;
            char SNr = SN;
            char SSr = SS;
            char SVr = SV;
            char SXr = SX;
            char SZr = SZ;
            // V Colum
            char VAr = VA;
            char VDr = VD;
            char VFr = VF;
            char VGr = VG;
            char VKr = VK;
            char VNr = VN;
            char VSr = VS;
            char VVr = VV;
            char VXr = VX;
            char VZr = VZ;
            // X Colum
            char XAr = XA;
            char XDr = XD;
            char XFr = XF;
            char XGr = XG;
            char XKr = XK;
            char XNr = XN;
            char XSr = XS;
            char XVr = XV;
            char XXr = XX;
            char XZr = XZ;
            // Z Colum
            char ZAr = ZA;
            char ZDr = ZD;
            char ZFr = ZF;
            char ZGr = ZG;
            char ZKr = ZK;
            char ZNr = ZN;
            char ZSr = ZS;
            char ZVr = ZV;
            char ZXr = ZX;
            char ZZr = ZZ;
            string Done = "";
            for (int i = 0; i < Input.Length; i++)
            {
                /*
                 *
                 *Get Char
                 * 
                 */

                // a
                if (Input[i] == AAr)
                {
                    Done = Done + "AA";
                }
                else if (Input[i] == ADr)
                {
                    Done = Done + "AD";
                }
                else if (Input[i] == AFr)
                {
                    Done = Done + "AF";
                }
                else if (Input[i] == AGr)
                {
                    Done = Done + "AG";
                }
                else if (Input[i] == AKr)
                {
                    Done = Done + "AK";
                }
                else if (Input[i] == ANr)
                {
                    Done = Done + "AN";
                }
                else if (Input[i] == ASr)
                {
                    Done = Done + "AS";
                }
                else if (Input[i] == AVr)
                {
                    Done = Done + "AV";
                }
                else if (Input[i] == AXr)
                {
                    Done = Done + "AX";
                }
                else if (Input[i] == AZr)
                {
                    Done = Done + "AZ";
                }                //d
                else if (Input[i] == DAr)
                {
                    Done = Done + "DA";
                }
                else if (Input[i] == DDr)
                {
                    Done = Done + "DD";
                }
                else if (Input[i] == DFr)
                {
                    Done = Done + "DF";
                }
                else if (Input[i] == DGr)
                {
                    Done = Done + "DG";
                }
                else if (Input[i] == DKr)
                {
                    Done = Done + "DK";
                }
                else if (Input[i] == DNr)
                {
                    Done = Done + "DN";
                }
                else if (Input[i] == DSr)
                {
                    Done = Done + "DS";
                }
                else if (Input[i] == DVr)
                {
                    Done = Done + "DV";
                }
                else if (Input[i] == DXr)
                {
                    Done = Done + "DX";
                }
                else if (Input[i] == DZr)
                {
                    Done = Done + "DZ";
                }                //f
                else if (Input[i] == FAr)
                {
                    Done = Done + "FA";
                }
                else if (Input[i] == FDr)
                {
                    Done = Done + "FD";
                }
                else if (Input[i] == FFr)
                {
                    Done = Done + "FF";
                }
                else if (Input[i] == FGr)
                {
                    Done = Done + "FG";
                }
                else if (Input[i] == FKr)
                {
                    Done = Done + "FK";
                }
                else if (Input[i] == FNr)
                {
                    Done = Done + "FN";
                }
                else if (Input[i] == FSr)
                {
                    Done = Done + "FS";
                }
                else if (Input[i] == FVr)
                {
                    Done = Done + "FV";
                }
                else if (Input[i] == FXr)
                {
                    Done = Done + "FX";
                }
                else if (Input[i] == FZr)
                {
                    Done = Done + "FZ";
                }                //g
                else if (Input[i] == GAr)
                {
                    Done = Done + "GA";
                }
                else if (Input[i] == GDr)
                {
                    Done = Done + "GD";
                }
                else if (Input[i] == GFr)
                {
                    Done = Done + "GF";
                }
                else if (Input[i] == GGr)
                {
                    Done = Done + "GG";
                }
                else if (Input[i] == GKr)
                {
                    Done = Done + "GK";
                }
                else if (Input[i] == GNr)
                {
                    Done = Done + "GN";
                }
                else if (Input[i] == GSr)
                {
                    Done = Done + "GS";
                }
                else if (Input[i] == GVr)
                {
                    Done = Done + "GV";
                }
                else if (Input[i] == GXr)
                {
                    Done = Done + "GX";
                }
                else if (Input[i] == GZr)
                {
                    Done = Done + "GZ";
                }                //k
                else if (Input[i] == KAr)
                {
                    Done = Done + "KA";
                }
                else if (Input[i] == KDr)
                {
                    Done = Done + "KD";
                }
                else if (Input[i] == KFr)
                {
                    Done = Done + "KF";
                }
                else if (Input[i] == KGr)
                {
                    Done = Done + "KG";
                }
                else if (Input[i] == KKr)
                {
                    Done = Done + "KK";
                }
                else if (Input[i] == KNr)
                {
                    Done = Done + "KN";
                }
                else if (Input[i] == KSr)
                {
                    Done = Done + "KS";
                }
                else if (Input[i] == KVr)
                {
                    Done = Done + "KV";
                }
                else if (Input[i] == KXr)
                {
                    Done = Done + "KX";
                }
                else if (Input[i] == KZr)
                {
                    Done = Done + "KZ";
                }                                 //n
                else if (Input[i] == NAr)
                {
                    Done = Done + "NA";
                }
                else if (Input[i] == NDr)
                {
                    Done = Done + "ND";
                }
                else if (Input[i] == NFr)
                {
                    Done = Done + "NF";
                }
                else if (Input[i] == NGr)
                {
                    Done = Done + "NG";
                }
                else if (Input[i] == NKr)
                {
                    Done = Done + "NK";
                }
                else if (Input[i] == NNr)
                {
                    Done = Done + "NN";
                }
                else if (Input[i] == NSr)
                {
                    Done = Done + "NS";
                }
                else if (Input[i] == NVr)
                {
                    Done = Done + "NV";
                }
                else if (Input[i] == NXr)
                {
                    Done = Done + "NX";
                }
                else if (Input[i] == NZr)
                {
                    Done = Done + "NZ";
                }                //s
                else if (Input[i] == SAr)
                {
                    Done = Done + "SA";
                }
                else if (Input[i] == SDr)
                {
                    Done = Done + "SD";
                }
                else if (Input[i] == SFr)
                {
                    Done = Done + "SF";
                }
                else if (Input[i] == SGr)
                {
                    Done = Done + "SG";
                }
                else if (Input[i] == SKr)
                {
                    Done = Done + "SK";
                }
                else if (Input[i] == SNr)
                {
                    Done = Done + "SN";
                }
                else if (Input[i] == SSr)
                {
                    Done = Done + "SS";
                }
                else if (Input[i] == SVr)
                {
                    Done = Done + "SV";
                }
                else if (Input[i] == SXr)
                {
                    Done = Done + "SX";
                }
                else if (Input[i] == SZr)
                {
                    Done = Done + "SZ";
                }                //v
                else if (Input[i] == VAr)
                {
                    Done = Done + "VA";
                }
                else if (Input[i] == VDr)
                {
                    Done = Done + "VD";
                }
                else if (Input[i] == VFr)
                {
                    Done = Done + "VF";
                }
                else if (Input[i] == VGr)
                {
                    Done = Done + "VG";
                }
                else if (Input[i] == VKr)
                {
                    Done = Done + "VK";
                }
                else if (Input[i] == VNr)
                {
                    Done = Done + "VN";
                }
                else if (Input[i] == VSr)
                {
                    Done = Done + "VS";
                }
                else if (Input[i] == VVr)
                {
                    Done = Done + "VV";
                }
                else if (Input[i] == VXr)
                {
                    Done = Done + "VX";
                }
                else if (Input[i] == VZr)
                {
                    Done = Done + "VZ";
                }                //x
                else if (Input[i] == XAr)
                {
                    Done = Done + "XA";
                }
                else if (Input[i] == XDr)
                {
                    Done = Done + "XD";
                }
                else if (Input[i] == XFr)
                {
                    Done = Done + "XF";
                }
                else if (Input[i] == XGr)
                {
                    Done = Done + "XG";
                }
                else if (Input[i] == XKr)
                {
                    Done = Done + "XK";
                }
                else if (Input[i] == XNr)
                {
                    Done = Done + "XN";
                }
                else if (Input[i] == XSr)
                {
                    Done = Done + "XS";
                }
                else if (Input[i] == XVr)
                {
                    Done = Done + "XV";
                }
                else if (Input[i] == XXr)
                {
                    Done = Done + "XX";
                }
                else if (Input[i] == XZr)
                {
                    Done = Done + "XZ";
                }                //z
                else if (Input[i] == ZAr)
                {
                    Done = Done + "ZA";
                }
                else if (Input[i] == ZDr)
                {
                    Done = Done + "ZD";
                }
                else if (Input[i] == ZFr)
                {
                    Done = Done + "ZF";
                }
                else if (Input[i] == ZGr)
                {
                    Done = Done + "ZG";
                }
                else if (Input[i] == ZKr)
                {
                    Done = Done + "ZK";
                }
                else if (Input[i] == ZNr)
                {
                    Done = Done + "ZN";
                }
                else if (Input[i] == ZSr)
                {
                    Done = Done + "ZS";
                }
                else if (Input[i] == ZVr)
                {
                    Done = Done + "ZV";
                }
                else if (Input[i] == ZXr)
                {
                    Done = Done + "ZX";
                }
                else if (Input[i] == ZZr)
                {
                    Done = Done + "ZZ";
                }

                /*
                 * 
                 * Roll
                 * 
                 */


                //CA
                if (CA == 1)
                {
                    char AAt = AAr;
                    char ADt = ADr;
                    char AFt = AFr;
                    char AGt = AGr;
                    char AKt = AKr;
                    char ANt = ANr;
                    char ASt = ASr;
                    char AVt = AVr;
                    char AXt = AXr;
                    char AZt = AZr;
                    AAr = AZt;
                    ADr = AAt;
                    AFr = ADt;
                    AGr = AFt;
                    AKr = AGt;
                    ANr = AKt;
                    ASr = ANt;
                    AVr = ASt;
                    AXr = AVt;
                    AZr = AXt;
                }
                else if (CA == -1)
                {
                    char AAt = AAr;
                    char ADt = ADr;
                    char AFt = AFr;
                    char AGt = AGr;
                    char AKt = AKr;
                    char ANt = ANr;
                    char ASt = ASr;
                    char AVt = AVr;
                    char AXt = AXr;
                    char AZt = AZr;
                    AAr = ADt;
                    ADr = AFt;
                    AFr = AGt;
                    AGr = AKt;
                    AKr = ANt;
                    ANr = ASt;
                    ASr = AVt;
                    AVr = AXt;
                    AXr = AZt;
                    AZr = AAt;
                }

                else if (CA == -3)
                {
                    char AAt = AAr;
                    char ADt = ADr;
                    char AFt = AFr;
                    char AGt = AGr;
                    char AKt = AKr;
                    char ANt = ANr;
                    char ASt = ASr;
                    char AVt = AVr;
                    char AXt = AXr;
                    char AZt = AZr;
                    AAr = AGt;
                    ADr = AKt;
                    AFr = ANt;
                    AGr = ASt;
                    AKr = AVt;
                    ANr = AXt;
                    ASr = AZt;
                    AVr = AAt;
                    AXr = ADt;
                    AZr = AFt;
                }

                else if (CA == 3)
                {
                    char AAt = AAr;
                    char ADt = ADr;
                    char AFt = AFr;
                    char AGt = AGr;
                    char AKt = AKr;
                    char ANt = ANr;
                    char ASt = ASr;
                    char AVt = AVr;
                    char AXt = AXr;
                    char AZt = AZr;
                    AAr = AVt;
                    ADr = AXt;
                    AFr = AZt;
                    AGr = AAt;
                    AKr = ADt;
                    ANr = AFt;
                    ASr = AGt;
                    AVr = AKt;
                    AXr = ANt;
                    AZr = ASt;
                }


                //CD                
                if (CD == 1)
                {
                    char DAt = DAr;
                    char DDt = DDr;
                    char DFt = DFr;
                    char DGt = DGr;
                    char DKt = DKr;
                    char DNt = DNr;
                    char DSt = DSr;
                    char DVt = DVr;
                    char DXt = DXr;
                    char DZt = DZr;
                    DAr = DZt;
                    DDr = DAt;
                    DFr = DDt;
                    DGr = DFt;
                    DKr = DGt;
                    DNr = DKt;
                    DSr = DNt;
                    DVr = DSt;
                    DXr = DVt;
                    DZr = DXt;
                }
                else if (CD == -1)
                {
                    char DAt = DAr;
                    char DDt = DDr;
                    char DFt = DFr;
                    char DGt = DGr;
                    char DKt = DKr;
                    char DNt = DNr;
                    char DSt = DSr;
                    char DVt = DVr;
                    char DXt = DXr;
                    char DZt = DZr;
                    DAr = DDt;
                    DDr = DFt;
                    DFr = DGt;
                    DGr = DKt;
                    DKr = DNt;
                    DNr = DSt;
                    DSr = DVt;
                    DVr = DXt;
                    DXr = DZt;
                    DZr = DAt;
                }

                else if (CD == -3)
                {
                    char DAt = DAr;
                    char DDt = DDr;
                    char DFt = DFr;
                    char DGt = DGr;
                    char DKt = DKr;
                    char DNt = DNr;
                    char DSt = DSr;
                    char DVt = DVr;
                    char DXt = DXr;
                    char DZt = DZr;
                    DAr = DGt;
                    DDr = DKt;
                    DFr = DNt;
                    DGr = DSt;
                    DKr = DVt;
                    DNr = DXt;
                    DSr = DZt;
                    DVr = DAt;
                    DXr = DDt;
                    DZr = DFt;
                }

                else if (CD == 3)
                {
                    char DAt = DAr;
                    char DDt = DDr;
                    char DFt = DFr;
                    char DGt = DGr;
                    char DKt = DKr;
                    char DNt = DNr;
                    char DSt = DSr;
                    char DVt = DVr;
                    char DXt = DXr;
                    char DZt = DZr;
                    DAr = DVt;
                    DDr = DXt;
                    DFr = DZt;
                    DGr = DAt;
                    DKr = DDt;
                    DNr = DFt;
                    DSr = DGt;
                    DVr = DKt;
                    DXr = DNt;
                    DZr = DSt;
                }


                //CF               
                if (CF == 1)
                {
                    char FAt = FAr;
                    char FDt = FDr;
                    char FFt = FFr;
                    char FGt = FGr;
                    char FKt = FKr;
                    char FNt = FNr;
                    char FSt = FSr;
                    char FVt = FVr;
                    char FXt = FXr;
                    char FZt = FZr;
                    FAr = FZt;
                    FDr = FAt;
                    FFr = FDt;
                    FGr = FFt;
                    FKr = FGt;
                    FNr = FKt;
                    FSr = FNt;
                    FVr = FSt;
                    FXr = FVt;
                    FZr = FXt;
                }
                else if (CF == -1)
                {
                    char FAt = FAr;
                    char FDt = FDr;
                    char FFt = FFr;
                    char FGt = FGr;
                    char FKt = FKr;
                    char FNt = FNr;
                    char FSt = FSr;
                    char FVt = FVr;
                    char FXt = FXr;
                    char FZt = FZr;
                    FAr = FDt;
                    FDr = FFt;
                    FFr = FGt;
                    FGr = FKt;
                    FKr = FNt;
                    FNr = FSt;
                    FSr = FVt;
                    FVr = FXt;
                    FXr = FZt;
                    FZr = FAt;
                }

                else if (CF == -3)
                {
                    char FAt = FAr;
                    char FDt = FDr;
                    char FFt = FFr;
                    char FGt = FGr;
                    char FKt = FKr;
                    char FNt = FNr;
                    char FSt = FSr;
                    char FVt = FVr;
                    char FXt = FXr;
                    char FZt = FZr;
                    FAr = FGt;
                    FDr = FKt;
                    FFr = FNt;
                    FGr = FSt;
                    FKr = FVt;
                    FNr = FXt;
                    FSr = FZt;
                    FVr = FAt;
                    FXr = FDt;
                    FZr = FFt;
                }

                else if (CF == 3)
                {
                    char FAt = FAr;
                    char FDt = FDr;
                    char FFt = FFr;
                    char FGt = FGr;
                    char FKt = FKr;
                    char FNt = FNr;
                    char FSt = FSr;
                    char FVt = FVr;
                    char FXt = FXr;
                    char FZt = FZr;
                    FAr = FVt;
                    FDr = FXt;
                    FFr = FZt;
                    FGr = FAt;
                    FKr = FDt;
                    FNr = FFt;
                    FSr = FGt;
                    FVr = FKt;
                    FXr = FNt;
                    FZr = FSt;
                }

                //CG               
                if (CG == 1)
                {
                    char GAt = GAr;
                    char GDt = GDr;
                    char GFt = GFr;
                    char GGt = GGr;
                    char GKt = GKr;
                    char GNt = GNr;
                    char GSt = GSr;
                    char GVt = GVr;
                    char GXt = GXr;
                    char GZt = GZr;
                    GAr = GZt;
                    GDr = GAt;
                    GFr = GDt;
                    GGr = GFt;
                    GKr = GGt;
                    GNr = GKt;
                    GSr = GNt;
                    GVr = GSt;
                    GXr = GVt;
                    GZr = GXt;
                }
                else if (CG == -1)
                {
                    char GAt = GAr;
                    char GDt = GDr;
                    char GFt = GFr;
                    char GGt = GGr;
                    char GKt = GKr;
                    char GNt = GNr;
                    char GSt = GSr;
                    char GVt = GVr;
                    char GXt = GXr;
                    char GZt = GZr;
                    GAr = GDt;
                    GDr = GFt;
                    GFr = GGt;
                    GGr = GKt;
                    GKr = GNt;
                    GNr = GSt;
                    GSr = GVt;
                    GVr = GXt;
                    GXr = GZt;
                    GZr = GAt;
                }

                else if (CG == -3)
                {
                    char GAt = GAr;
                    char GDt = GDr;
                    char GFt = GFr;
                    char GGt = GGr;
                    char GKt = GKr;
                    char GNt = GNr;
                    char GSt = GSr;
                    char GVt = GVr;
                    char GXt = GXr;
                    char GZt = GZr;
                    GAr = GGt;
                    GDr = GKt;
                    GFr = GNt;
                    GGr = GSt;
                    GKr = GVt;
                    GNr = GXt;
                    GSr = GZt;
                    GVr = GAt;
                    GXr = GDt;
                    GZr = GFt;
                }

                else if (CG == 3)
                {
                    char GAt = GAr;
                    char GDt = GDr;
                    char GFt = GFr;
                    char GGt = GGr;
                    char GKt = GKr;
                    char GNt = GNr;
                    char GSt = GSr;
                    char GVt = GVr;
                    char GXt = GXr;
                    char GZt = GZr;
                    GAr = GVt;
                    GDr = GXt;
                    GFr = GZt;
                    GGr = GAt;
                    GKr = GDt;
                    GNr = GFt;
                    GSr = GGt;
                    GVr = GKt;
                    GXr = GNt;
                    GZr = GSt;
                }

                //CK               
                if (CK == 1)
                {
                    char KAt = KAr;
                    char KDt = KDr;
                    char KFt = KFr;
                    char KGt = KGr;
                    char KKt = KKr;
                    char KNt = KNr;
                    char KSt = KSr;
                    char KVt = KVr;
                    char KXt = KXr;
                    char KZt = KZr;
                    KAr = KZt;
                    KDr = KAt;
                    KFr = KDt;
                    KGr = KFt;
                    KKr = KGt;
                    KNr = KKt;
                    KSr = KNt;
                    KVr = KSt;
                    KXr = KVt;
                    KZr = KXt;
                }
                else if (CK == -1)
                {
                    char KAt = KAr;
                    char KDt = KDr;
                    char KFt = KFr;
                    char KGt = KGr;
                    char KKt = KKr;
                    char KNt = KNr;
                    char KSt = KSr;
                    char KVt = KVr;
                    char KXt = KXr;
                    char KZt = KZr;
                    KAr = KDt;
                    KDr = KFt;
                    KFr = KGt;
                    KGr = KKt;
                    KKr = KNt;
                    KNr = KSt;
                    KSr = KVt;
                    KVr = KXt;
                    KXr = KZt;
                    KZr = KAt;
                }

                else if (CK == -3)
                {
                    char KAt = KAr;
                    char KDt = KDr;
                    char KFt = KFr;
                    char KGt = KGr;
                    char KKt = KKr;
                    char KNt = KNr;
                    char KSt = KSr;
                    char KVt = KVr;
                    char KXt = KXr;
                    char KZt = KZr;
                    KAr = KGt;
                    KDr = KKt;
                    KFr = KNt;
                    KGr = KSt;
                    KKr = KVt;
                    KNr = KXt;
                    KSr = KZt;
                    KVr = KAt;
                    KXr = KDt;
                    KZr = KFt;
                }

                else if (CK == 3)
                {
                    char KAt = KAr;
                    char KDt = KDr;
                    char KFt = KFr;
                    char KGt = KGr;
                    char KKt = KKr;
                    char KNt = KNr;
                    char KSt = KSr;
                    char KVt = KVr;
                    char KXt = KXr;
                    char KZt = KZr;
                    KAr = KVt;
                    KDr = KXt;
                    KFr = KZt;
                    KGr = KAt;
                    KKr = KDt;
                    KNr = KFt;
                    KSr = KGt;
                    KVr = KKt;
                    KXr = KNt;
                    KZr = KSt;
                }

                //CN               
                if (CN == 1)
                {
                    char NAt = NAr;
                    char NDt = NDr;
                    char NFt = NFr;
                    char NGt = NGr;
                    char NKt = NKr;
                    char NNt = NNr;
                    char NSt = NSr;
                    char NVt = NVr;
                    char NXt = NXr;
                    char NZt = NZr;
                    NAr = NZt;
                    NDr = NAt;
                    NFr = NDt;
                    NGr = NFt;
                    NKr = NGt;
                    NNr = NKt;
                    NSr = NNt;
                    NVr = NSt;
                    NXr = NVt;
                    NZr = NXt;
                }
                else if (CN == -1)
                {
                    char NAt = NAr;
                    char NDt = NDr;
                    char NFt = NFr;
                    char NGt = NGr;
                    char NKt = NKr;
                    char NNt = NNr;
                    char NSt = NSr;
                    char NVt = NVr;
                    char NXt = NXr;
                    char NZt = NZr;
                    NAr = NDt;
                    NDr = NFt;
                    NFr = NGt;
                    NGr = NKt;
                    NKr = NNt;
                    NNr = NSt;
                    NSr = NVt;
                    NVr = NXt;
                    NXr = NZt;
                    NZr = NAt;
                }

                else if (CN == -3)
                {
                    char NAt = NAr;
                    char NDt = NDr;
                    char NFt = NFr;
                    char NGt = NGr;
                    char NKt = NKr;
                    char NNt = NNr;
                    char NSt = NSr;
                    char NVt = NVr;
                    char NXt = NXr;
                    char NZt = NZr;
                    NAr = NGt;
                    NDr = NKt;
                    NFr = NNt;
                    NGr = NSt;
                    NKr = NVt;
                    NNr = NXt;
                    NSr = NZt;
                    NVr = NAt;
                    NXr = NDt;
                    NZr = NFt;
                }

                else if (CN == 3)
                {
                    char NAt = NAr;
                    char NDt = NDr;
                    char NFt = NFr;
                    char NGt = NGr;
                    char NKt = NKr;
                    char NNt = NNr;
                    char NSt = NSr;
                    char NVt = NVr;
                    char NXt = NXr;
                    char NZt = NZr;
                    NAr = NVt;
                    NDr = NXt;
                    NFr = NZt;
                    NGr = NAt;
                    NKr = NDt;
                    NNr = NFt;
                    NSr = NGt;
                    NVr = NKt;
                    NXr = NNt;
                    NZr = NSt;
                }

                //CS               
                if (CS == 1)
                {
                    char SAt = SAr;
                    char SDt = SDr;
                    char SFt = SFr;
                    char SGt = SGr;
                    char SKt = SKr;
                    char SNt = SNr;
                    char SSt = SSr;
                    char SVt = SVr;
                    char SXt = SXr;
                    char SZt = SZr;
                    SAr = SZt;
                    SDr = SAt;
                    SFr = SDt;
                    SGr = SFt;
                    SKr = SGt;
                    SNr = SKt;
                    SSr = SNt;
                    SVr = SSt;
                    SXr = SVt;
                    SZr = SXt;
                }
                else if (CS == -1)
                {
                    char SAt = SAr;
                    char SDt = SDr;
                    char SFt = SFr;
                    char SGt = SGr;
                    char SKt = SKr;
                    char SNt = SNr;
                    char SSt = SSr;
                    char SVt = SVr;
                    char SXt = SXr;
                    char SZt = SZr;
                    SAr = SDt;
                    SDr = SFt;
                    SFr = SGt;
                    SGr = SKt;
                    SKr = SNt;
                    SNr = SSt;
                    SSr = SVt;
                    SVr = SXt;
                    SXr = SZt;
                    SZr = SAt;
                }

                else if (CS == -3)
                {
                    char SAt = SAr;
                    char SDt = SDr;
                    char SFt = SFr;
                    char SGt = SGr;
                    char SKt = SKr;
                    char SNt = SNr;
                    char SSt = SSr;
                    char SVt = SVr;
                    char SXt = SXr;
                    char SZt = SZr;
                    SAr = SGt;
                    SDr = SKt;
                    SFr = SNt;
                    SGr = SSt;
                    SKr = SVt;
                    SNr = SXt;
                    SSr = SZt;
                    SVr = SAt;
                    SXr = SDt;
                    SZr = SFt;
                }

                else if (CS == 3)
                {
                    char SAt = SAr;
                    char SDt = SDr;
                    char SFt = SFr;
                    char SGt = SGr;
                    char SKt = SKr;
                    char SNt = SNr;
                    char SSt = SSr;
                    char SVt = SVr;
                    char SXt = SXr;
                    char SZt = SZr;
                    SAr = SVt;
                    SDr = SXt;
                    SFr = SZt;
                    SGr = SAt;
                    SKr = SDt;
                    SNr = SFt;
                    SSr = SGt;
                    SVr = SKt;
                    SXr = SNt;
                    SZr = SSt;
                }

                //CV               
                if (CV == 1)
                {
                    char VAt = VAr;
                    char VDt = VDr;
                    char VFt = VFr;
                    char VGt = VGr;
                    char VKt = VKr;
                    char VNt = VNr;
                    char VSt = VSr;
                    char VVt = VVr;
                    char VXt = VXr;
                    char VZt = VZr;
                    VAr = VZt;
                    VDr = VAt;
                    VFr = VDt;
                    VGr = VFt;
                    VKr = VGt;
                    VNr = VKt;
                    VSr = VNt;
                    VVr = VSt;
                    VXr = VVt;
                    VZr = VXt;
                }
                else if (CV == -1)
                {
                    char VAt = VAr;
                    char VDt = VDr;
                    char VFt = VFr;
                    char VGt = VGr;
                    char VKt = VKr;
                    char VNt = VNr;
                    char VSt = VSr;
                    char VVt = VVr;
                    char VXt = VXr;
                    char VZt = VZr;
                    VAr = VDt;
                    VDr = VFt;
                    VFr = VGt;
                    VGr = VKt;
                    VKr = VNt;
                    VNr = VSt;
                    VSr = VVt;
                    VVr = VXt;
                    VXr = VZt;
                    VZr = VAt;
                }

                else if (CV == -3)
                {
                    char VAt = VAr;
                    char VDt = VDr;
                    char VFt = VFr;
                    char VGt = VGr;
                    char VKt = VKr;
                    char VNt = VNr;
                    char VSt = VSr;
                    char VVt = VVr;
                    char VXt = VXr;
                    char VZt = VZr;
                    VAr = VGt;
                    VDr = VKt;
                    VFr = VNt;
                    VGr = VSt;
                    VKr = VVt;
                    VNr = VXt;
                    VSr = VZt;
                    VVr = VAt;
                    VXr = VDt;
                    VZr = VFt;
                }

                else if (CV == 3)
                {
                    char VAt = VAr;
                    char VDt = VDr;
                    char VFt = VFr;
                    char VGt = VGr;
                    char VKt = VKr;
                    char VNt = VNr;
                    char VSt = VSr;
                    char VVt = VVr;
                    char VXt = VXr;
                    char VZt = VZr;
                    VAr = VVt;
                    VDr = VXt;
                    VFr = VZt;
                    VGr = VAt;
                    VKr = VDt;
                    VNr = VFt;
                    VSr = VGt;
                    VVr = VKt;
                    VXr = VNt;
                    VZr = VSt;
                }

                //CX               
                if (CX == 1)
                {
                    char XAt = XAr;
                    char XDt = XDr;
                    char XFt = XFr;
                    char XGt = XGr;
                    char XKt = XKr;
                    char XNt = XNr;
                    char XSt = XSr;
                    char XVt = XVr;
                    char XXt = XXr;
                    char XZt = XZr;
                    XAr = XZt;
                    XDr = XAt;
                    XFr = XDt;
                    XGr = XFt;
                    XKr = XGt;
                    XNr = XKt;
                    XSr = XNt;
                    XVr = XSt;
                    XXr = XVt;
                    XZr = XXt;
                }
                else if (CX == -1)
                {
                    char XAt = XAr;
                    char XDt = XDr;
                    char XFt = XFr;
                    char XGt = XGr;
                    char XKt = XKr;
                    char XNt = XNr;
                    char XSt = XSr;
                    char XVt = XVr;
                    char XXt = XXr;
                    char XZt = XZr;
                    XAr = XDt;
                    XDr = XFt;
                    XFr = XGt;
                    XGr = XKt;
                    XKr = XNt;
                    XNr = XSt;
                    XSr = XVt;
                    XVr = XXt;
                    XXr = XZt;
                    XZr = XAt;
                }

                else if (CX == -3)
                {
                    char XAt = XAr;
                    char XDt = XDr;
                    char XFt = XFr;
                    char XGt = XGr;
                    char XKt = XKr;
                    char XNt = XNr;
                    char XSt = XSr;
                    char XVt = XVr;
                    char XXt = XXr;
                    char XZt = XZr;
                    XAr = XGt;
                    XDr = XKt;
                    XFr = XNt;
                    XGr = XSt;
                    XKr = XVt;
                    XNr = XXt;
                    XSr = XZt;
                    XVr = XAt;
                    XXr = XDt;
                    XZr = XFt;
                }

                else if (CX == 3)
                {
                    char XAt = XAr;
                    char XDt = XDr;
                    char XFt = XFr;
                    char XGt = XGr;
                    char XKt = XKr;
                    char XNt = XNr;
                    char XSt = XSr;
                    char XVt = XVr;
                    char XXt = XXr;
                    char XZt = XZr;
                    XAr = XVt;
                    XDr = XXt;
                    XFr = XZt;
                    XGr = XAt;
                    XKr = XDt;
                    XNr = XFt;
                    XSr = XGt;
                    XVr = XKt;
                    XXr = XNt;
                    XZr = XSt;
                }

                //CZ               
                if (CZ == 1)
                {
                    char ZAt = ZAr;
                    char ZDt = ZDr;
                    char ZFt = ZFr;
                    char ZGt = ZGr;
                    char ZKt = ZKr;
                    char ZNt = ZNr;
                    char ZSt = ZSr;
                    char ZVt = ZVr;
                    char ZXt = ZXr;
                    char ZZt = ZZr;
                    ZAr = ZZt;
                    ZDr = ZAt;
                    ZFr = ZDt;
                    ZGr = ZFt;
                    ZKr = ZGt;
                    ZNr = ZKt;
                    ZSr = ZNt;
                    ZVr = ZSt;
                    ZXr = ZVt;
                    ZZr = ZXt;
                }
                else if (CZ == -1)
                {
                    char ZAt = ZAr;
                    char ZDt = ZDr;
                    char ZFt = ZFr;
                    char ZGt = ZGr;
                    char ZKt = ZKr;
                    char ZNt = ZNr;
                    char ZSt = ZSr;
                    char ZVt = ZVr;
                    char ZXt = ZXr;
                    char ZZt = ZZr;
                    ZAr = ZDt;
                    ZDr = ZFt;
                    ZFr = ZGt;
                    ZGr = ZKt;
                    ZKr = ZNt;
                    ZNr = ZSt;
                    ZSr = ZVt;
                    ZVr = ZXt;
                    ZXr = ZZt;
                    ZZr = ZAt;
                }

                else if (CZ == -3)
                {
                    char ZAt = ZAr;
                    char ZDt = ZDr;
                    char ZFt = ZFr;
                    char ZGt = ZGr;
                    char ZKt = ZKr;
                    char ZNt = ZNr;
                    char ZSt = ZSr;
                    char ZVt = ZVr;
                    char ZXt = ZXr;
                    char ZZt = ZZr;
                    ZAr = ZGt;
                    ZDr = ZKt;
                    ZFr = ZNt;
                    ZGr = ZSt;
                    ZKr = ZVt;
                    ZNr = ZXt;
                    ZSr = ZZt;
                    ZVr = ZAt;
                    ZXr = ZDt;
                    ZZr = ZFt;
                }

                else if (CZ == 3)
                {
                    char ZAt = ZAr;
                    char ZDt = ZDr;
                    char ZFt = ZFr;
                    char ZGt = ZGr;
                    char ZKt = ZKr;
                    char ZNt = ZNr;
                    char ZSt = ZSr;
                    char ZVt = ZVr;
                    char ZXt = ZXr;
                    char ZZt = ZZr;
                    ZAr = ZVt;
                    ZDr = ZXt;
                    ZFr = ZZt;
                    ZGr = ZAt;
                    ZKr = ZDt;
                    ZNr = ZFt;
                    ZSr = ZGt;
                    ZVr = ZKt;
                    ZXr = ZNt;
                    ZZr = ZSt;
                }

                //RA
                if (RA == 1)
                {
                    char AAt = AAr;
                    char DAt = DAr;
                    char FAt = FAr;
                    char GAt = GAr;
                    char KAt = KAr;
                    char NAt = NAr;
                    char SAt = SAr;
                    char VAt = VAr;
                    char XAt = XAr;
                    char ZAt = ZAr;
                    AAr = ZAt;
                    DAr = AAt;
                    FAr = DAt;
                    GAr = FAt;
                    KAr = GAt;
                    NAr = KAt;
                    SAr = NAt;
                    VAr = SAt;
                    XAr = VAt;
                    ZAr = XAt;
                }
                else if (RA == -1)
                {
                    char AAt = AAr;
                    char DAt = DAr;
                    char FAt = FAr;
                    char GAt = GAr;
                    char KAt = KAr;
                    char NAt = NAr;
                    char SAt = SAr;
                    char VAt = VAr;
                    char XAt = XAr;
                    char ZAt = ZAr;
                    AAr = DAt;
                    DAr = FAt;
                    FAr = GAt;
                    GAr = KAt;
                    KAr = NAt;
                    NAr = SAt;
                    SAr = VAt;
                    VAr = XAt;
                    XAr = ZAt;
                    ZAr = AAt;
                }
                else if (RA == -3)
                {
                    char AAt = AAr;
                    char DAt = DAr;
                    char FAt = FAr;
                    char GAt = GAr;
                    char KAt = KAr;
                    char NAt = NAr;
                    char SAt = SAr;
                    char VAt = VAr;
                    char XAt = XAr;
                    char ZAt = ZAr;
                    AAr = GAt;
                    DAr = KAt;
                    FAr = NAt;
                    GAr = SAt;
                    KAr = VAt;
                    NAr = XAt;
                    SAr = ZAt;
                    VAr = AAt;
                    XAr = DAt;
                    ZAr = FAt;
                }
                else if (RA == -3)
                {
                    char AAt = AAr;
                    char DAt = DAr;
                    char FAt = FAr;
                    char GAt = GAr;
                    char KAt = KAr;
                    char NAt = NAr;
                    char SAt = SAr;
                    char VAt = VAr;
                    char XAt = XAr;
                    char ZAt = ZAr;
                    AAr = VAt;
                    DAr = XAt;
                    FAr = ZAt;
                    GAr = AAt;
                    KAr = DAt;
                    NAr = FAt;
                    SAr = GAt;
                    VAr = KAt;
                    XAr = NAt;
                    ZAr = SAt;
                }

                //RD
                if (RD == 1)
                {
                    char ADt = ADr;
                    char DDt = DDr;
                    char FDt = FDr;
                    char GDt = GDr;
                    char KDt = KDr;
                    char NDt = NDr;
                    char SDt = SDr;
                    char VDt = VDr;
                    char XDt = XDr;
                    char ZDt = ZDr;
                    ADr = ZDt;
                    DDr = ADt;
                    FDr = DDt;
                    GDr = FDt;
                    KDr = GDt;
                    NDr = KDt;
                    SDr = NDt;
                    VDr = SDt;
                    XDr = VDt;
                    ZDr = XDt;
                }
                else if (RD == -1)
                {
                    char ADt = ADr;
                    char DDt = DDr;
                    char FDt = FDr;
                    char GDt = GDr;
                    char KDt = KDr;
                    char NDt = NDr;
                    char SDt = SDr;
                    char VDt = VDr;
                    char XDt = XDr;
                    char ZDt = ZDr;
                    ADr = DDt;
                    DDr = FDt;
                    FDr = GDt;
                    GDr = KDt;
                    KDr = NDt;
                    NDr = SDt;
                    SDr = VDt;
                    VDr = XDt;
                    XDr = ZDt;
                    ZDr = ADt;
                }
                else if (RD == -3)
                {
                    char ADt = ADr;
                    char DDt = DDr;
                    char FDt = FDr;
                    char GDt = GDr;
                    char KDt = KDr;
                    char NDt = NDr;
                    char SDt = SDr;
                    char VDt = VDr;
                    char XDt = XDr;
                    char ZDt = ZDr;
                    ADr = GDt;
                    DDr = KDt;
                    FDr = NDt;
                    GDr = SDt;
                    KDr = VDt;
                    NDr = XDt;
                    SDr = ZDt;
                    VDr = ADt;
                    XDr = DDt;
                    ZDr = FDt;
                }
                else if (RD == -3)
                {
                    char ADt = ADr;
                    char DDt = DDr;
                    char FDt = FDr;
                    char GDt = GDr;
                    char KDt = KDr;
                    char NDt = NDr;
                    char SDt = SDr;
                    char VDt = VDr;
                    char XDt = XDr;
                    char ZDt = ZDr;
                    ADr = VDt;
                    DDr = XDt;
                    FDr = ZDt;
                    GDr = ADt;
                    KDr = DDt;
                    NDr = FDt;
                    SDr = GDt;
                    VDr = KDt;
                    XDr = NDt;
                    ZDr = SDt;
                }

                //RF
                if (RF == 1)
                {
                    char AFt = AFr;
                    char DFt = DFr;
                    char FFt = FFr;
                    char GFt = GFr;
                    char KFt = KFr;
                    char NFt = NFr;
                    char SFt = SFr;
                    char VFt = VFr;
                    char XFt = XFr;
                    char ZFt = ZFr;
                    AFr = ZFt;
                    DFr = AFt;
                    FFr = DFt;
                    GFr = FFt;
                    KFr = GFt;
                    NFr = KFt;
                    SFr = NFt;
                    VFr = SFt;
                    XFr = VFt;
                    ZFr = XFt;
                }
                else if (RF == -1)
                {
                    char AFt = AFr;
                    char DFt = DFr;
                    char FFt = FFr;
                    char GFt = GFr;
                    char KFt = KFr;
                    char NFt = NFr;
                    char SFt = SFr;
                    char VFt = VFr;
                    char XFt = XFr;
                    char ZFt = ZFr;
                    AFr = DFt;
                    DFr = FFt;
                    FFr = GFt;
                    GFr = KFt;
                    KFr = NFt;
                    NFr = SFt;
                    SFr = VFt;
                    VFr = XFt;
                    XFr = ZFt;
                    ZFr = AFt;
                }
                else if (RF == -3)
                {
                    char AFt = AFr;
                    char DFt = DFr;
                    char FFt = FFr;
                    char GFt = GFr;
                    char KFt = KFr;
                    char NFt = NFr;
                    char SFt = SFr;
                    char VFt = VFr;
                    char XFt = XFr;
                    char ZFt = ZFr;
                    AFr = GFt;
                    DFr = KFt;
                    FFr = NFt;
                    GFr = SFt;
                    KFr = VFt;
                    NFr = XFt;
                    SFr = ZFt;
                    VFr = AFt;
                    XFr = DFt;
                    ZFr = FFt;
                }
                else if (RF == -3)
                {
                    char AFt = AFr;
                    char DFt = DFr;
                    char FFt = FFr;
                    char GFt = GFr;
                    char KFt = KFr;
                    char NFt = NFr;
                    char SFt = SFr;
                    char VFt = VFr;
                    char XFt = XFr;
                    char ZFt = ZFr;
                    AFr = VFt;
                    DFr = XFt;
                    FFr = ZFt;
                    GFr = AFt;
                    KFr = DFt;
                    NFr = FFt;
                    SFr = GFt;
                    VFr = KFt;
                    XFr = NFt;
                    ZFr = SFt;
                }

                //RG
                if (RG == 1)
                {
                    char AGt = AGr;
                    char DGt = DGr;
                    char FGt = FGr;
                    char GGt = GGr;
                    char KGt = KGr;
                    char NGt = NGr;
                    char SGt = SGr;
                    char VGt = VGr;
                    char XGt = XGr;
                    char ZGt = ZGr;
                    AGr = ZGt;
                    DGr = AGt;
                    FGr = DGt;
                    GGr = FGt;
                    KGr = GGt;
                    NGr = KGt;
                    SGr = NGt;
                    VGr = SGt;
                    XGr = VGt;
                    ZGr = XGt;
                }
                else if (RG == -1)
                {
                    char AGt = AGr;
                    char DGt = DGr;
                    char FGt = FGr;
                    char GGt = GGr;
                    char KGt = KGr;
                    char NGt = NGr;
                    char SGt = SGr;
                    char VGt = VGr;
                    char XGt = XGr;
                    char ZGt = ZGr;
                    AGr = DGt;
                    DGr = FGt;
                    FGr = GGt;
                    GGr = KGt;
                    KGr = NGt;
                    NGr = SGt;
                    SGr = VGt;
                    VGr = XGt;
                    XGr = ZGt;
                    ZGr = AGt;
                }
                else if (RG == -3)
                {
                    char AGt = AGr;
                    char DGt = DGr;
                    char FGt = FGr;
                    char GGt = GGr;
                    char KGt = KGr;
                    char NGt = NGr;
                    char SGt = SGr;
                    char VGt = VGr;
                    char XGt = XGr;
                    char ZGt = ZGr;
                    AGr = GGt;
                    DGr = KGt;
                    FGr = NGt;
                    GGr = SGt;
                    KGr = VGt;
                    NGr = XGt;
                    SGr = ZGt;
                    VGr = AGt;
                    XGr = DGt;
                    ZGr = FGt;
                }
                else if (RG == -3)
                {
                    char AGt = AGr;
                    char DGt = DGr;
                    char FGt = FGr;
                    char GGt = GGr;
                    char KGt = KGr;
                    char NGt = NGr;
                    char SGt = SGr;
                    char VGt = VGr;
                    char XGt = XGr;
                    char ZGt = ZGr;
                    AGr = VGt;
                    DGr = XGt;
                    FGr = ZGt;
                    GGr = AGt;
                    KGr = DGt;
                    NGr = FGt;
                    SGr = GGt;
                    VGr = KGt;
                    XGr = NGt;
                    ZGr = SGt;
                }

                //RK
                if (RK == 1)
                {
                    char AKt = AKr;
                    char DKt = DKr;
                    char FKt = FKr;
                    char GKt = GKr;
                    char KKt = KKr;
                    char NKt = NKr;
                    char SKt = SKr;
                    char VKt = VKr;
                    char XKt = XKr;
                    char ZKt = ZKr;
                    AKr = ZKt;
                    DKr = AKt;
                    FKr = DKt;
                    GKr = FKt;
                    KKr = GKt;
                    NKr = KKt;
                    SKr = NKt;
                    VKr = SKt;
                    XKr = VKt;
                    ZKr = XKt;
                }
                else if (RK == -1)
                {
                    char AKt = AKr;
                    char DKt = DKr;
                    char FKt = FKr;
                    char GKt = GKr;
                    char KKt = KKr;
                    char NKt = NKr;
                    char SKt = SKr;
                    char VKt = VKr;
                    char XKt = XKr;
                    char ZKt = ZKr;
                    AKr = DKt;
                    DKr = FKt;
                    FKr = GKt;
                    GKr = KKt;
                    KKr = NKt;
                    NKr = SKt;
                    SKr = VKt;
                    VKr = XKt;
                    XKr = ZKt;
                    ZKr = AKt;
                }
                else if (RK == -3)
                {
                    char AKt = AKr;
                    char DKt = DKr;
                    char FKt = FKr;
                    char GKt = GKr;
                    char KKt = KKr;
                    char NKt = NKr;
                    char SKt = SKr;
                    char VKt = VKr;
                    char XKt = XKr;
                    char ZKt = ZKr;
                    AKr = GKt;
                    DKr = KKt;
                    FKr = NKt;
                    GKr = SKt;
                    KKr = VKt;
                    NKr = XKt;
                    SKr = ZKt;
                    VKr = AKt;
                    XKr = DKt;
                    ZKr = FKt;
                }
                else if (RK == -3)
                {
                    char AKt = AKr;
                    char DKt = DKr;
                    char FKt = FKr;
                    char GKt = GKr;
                    char KKt = KKr;
                    char NKt = NKr;
                    char SKt = SKr;
                    char VKt = VKr;
                    char XKt = XKr;
                    char ZKt = ZKr;
                    AKr = VKt;
                    DKr = XKt;
                    FKr = ZKt;
                    GKr = AKt;
                    KKr = DKt;
                    NKr = FKt;
                    SKr = GKt;
                    VKr = KKt;
                    XKr = NKt;
                    ZKr = SKt;
                }

                //RN
                if (RN == 1)
                {
                    char ANt = ANr;
                    char DNt = DNr;
                    char FNt = FNr;
                    char GNt = GNr;
                    char KNt = KNr;
                    char NNt = NNr;
                    char SNt = SNr;
                    char VNt = VNr;
                    char XNt = XNr;
                    char ZNt = ZNr;
                    ANr = ZNt;
                    DNr = ANt;
                    FNr = DNt;
                    GNr = FNt;
                    KNr = GNt;
                    NNr = KNt;
                    SNr = NNt;
                    VNr = SNt;
                    XNr = VNt;
                    ZNr = XNt;
                }
                else if (RN == -1)
                {
                    char ANt = ANr;
                    char DNt = DNr;
                    char FNt = FNr;
                    char GNt = GNr;
                    char KNt = KNr;
                    char NNt = NNr;
                    char SNt = SNr;
                    char VNt = VNr;
                    char XNt = XNr;
                    char ZNt = ZNr;
                    ANr = DNt;
                    DNr = FNt;
                    FNr = GNt;
                    GNr = KNt;
                    KNr = NNt;
                    NNr = SNt;
                    SNr = VNt;
                    VNr = XNt;
                    XNr = ZNt;
                    ZNr = ANt;
                }
                else if (RN == -3)
                {
                    char ANt = ANr;
                    char DNt = DNr;
                    char FNt = FNr;
                    char GNt = GNr;
                    char KNt = KNr;
                    char NNt = NNr;
                    char SNt = SNr;
                    char VNt = VNr;
                    char XNt = XNr;
                    char ZNt = ZNr;
                    ANr = GNt;
                    DNr = KNt;
                    FNr = NNt;
                    GNr = SNt;
                    KNr = VNt;
                    NNr = XNt;
                    SNr = ZNt;
                    VNr = ANt;
                    XNr = DNt;
                    ZNr = FNt;
                }
                else if (RN == -3)
                {
                    char ANt = ANr;
                    char DNt = DNr;
                    char FNt = FNr;
                    char GNt = GNr;
                    char KNt = KNr;
                    char NNt = NNr;
                    char SNt = SNr;
                    char VNt = VNr;
                    char XNt = XNr;
                    char ZNt = ZNr;
                    ANr = VNt;
                    DNr = XNt;
                    FNr = ZNt;
                    GNr = ANt;
                    KNr = DNt;
                    NNr = FNt;
                    SNr = GNt;
                    VNr = KNt;
                    XNr = NNt;
                    ZNr = SNt;
                }

                //RS
                if (RS == 1)
                {
                    char ASt = ASr;
                    char DSt = DSr;
                    char FSt = FSr;
                    char GSt = GSr;
                    char KSt = KSr;
                    char NSt = NSr;
                    char SSt = SSr;
                    char VSt = VSr;
                    char XSt = XSr;
                    char ZSt = ZSr;
                    ASr = ZSt;
                    DSr = ASt;
                    FSr = DSt;
                    GSr = FSt;
                    KSr = GSt;
                    NSr = KSt;
                    SSr = NSt;
                    VSr = SSt;
                    XSr = VSt;
                    ZSr = XSt;
                }
                else if (RS == -1)
                {
                    char ASt = ASr;
                    char DSt = DSr;
                    char FSt = FSr;
                    char GSt = GSr;
                    char KSt = KSr;
                    char NSt = NSr;
                    char SSt = SSr;
                    char VSt = VSr;
                    char XSt = XSr;
                    char ZSt = ZSr;
                    ASr = DSt;
                    DSr = FSt;
                    FSr = GSt;
                    GSr = KSt;
                    KSr = NSt;
                    NSr = SSt;
                    SSr = VSt;
                    VSr = XSt;
                    XSr = ZSt;
                    ZSr = ASt;
                }
                else if (RS == -3)
                {
                    char ASt = ASr;
                    char DSt = DSr;
                    char FSt = FSr;
                    char GSt = GSr;
                    char KSt = KSr;
                    char NSt = NSr;
                    char SSt = SSr;
                    char VSt = VSr;
                    char XSt = XSr;
                    char ZSt = ZSr;
                    ASr = GSt;
                    DSr = KSt;
                    FSr = NSt;
                    GSr = SSt;
                    KSr = VSt;
                    NSr = XSt;
                    SSr = ZSt;
                    VSr = ASt;
                    XSr = DSt;
                    ZSr = FSt;
                }
                else if (RS == -3)
                {
                    char ASt = ASr;
                    char DSt = DSr;
                    char FSt = FSr;
                    char GSt = GSr;
                    char KSt = KSr;
                    char NSt = NSr;
                    char SSt = SSr;
                    char VSt = VSr;
                    char XSt = XSr;
                    char ZSt = ZSr;
                    ASr = VSt;
                    DSr = XSt;
                    FSr = ZSt;
                    GSr = ASt;
                    KSr = DSt;
                    NSr = FSt;
                    SSr = GSt;
                    VSr = KSt;
                    XSr = NSt;
                    ZSr = SSt;
                }

                //RV
                if (RV == 1)
                {
                    char AVt = AVr;
                    char DVt = DVr;
                    char FVt = FVr;
                    char GVt = GVr;
                    char KVt = KVr;
                    char NVt = NVr;
                    char SVt = SVr;
                    char VVt = VVr;
                    char XVt = XVr;
                    char ZVt = ZVr;
                    AVr = ZVt;
                    DVr = AVt;
                    FVr = DVt;
                    GVr = FVt;
                    KVr = GVt;
                    NVr = KVt;
                    SVr = NVt;
                    VVr = SVt;
                    XVr = VVt;
                    ZVr = XVt;
                }
                else if (RV == -1)
                {
                    char AVt = AVr;
                    char DVt = DVr;
                    char FVt = FVr;
                    char GVt = GVr;
                    char KVt = KVr;
                    char NVt = NVr;
                    char SVt = SVr;
                    char VVt = VVr;
                    char XVt = XVr;
                    char ZVt = ZVr;
                    AVr = DVt;
                    DVr = FVt;
                    FVr = GVt;
                    GVr = KVt;
                    KVr = NVt;
                    NVr = SVt;
                    SVr = VVt;
                    VVr = XVt;
                    XVr = ZVt;
                    ZVr = AVt;
                }
                else if (RV == -3)
                {
                    char AVt = AVr;
                    char DVt = DVr;
                    char FVt = FVr;
                    char GVt = GVr;
                    char KVt = KVr;
                    char NVt = NVr;
                    char SVt = SVr;
                    char VVt = VVr;
                    char XVt = XVr;
                    char ZVt = ZVr;
                    AVr = GVt;
                    DVr = KVt;
                    FVr = NVt;
                    GVr = SVt;
                    KVr = VVt;
                    NVr = XVt;
                    SVr = ZVt;
                    VVr = AVt;
                    XVr = DVt;
                    ZVr = FVt;
                }
                else if (RV == -3)
                {
                    char AVt = AVr;
                    char DVt = DVr;
                    char FVt = FVr;
                    char GVt = GVr;
                    char KVt = KVr;
                    char NVt = NVr;
                    char SVt = SVr;
                    char VVt = VVr;
                    char XVt = XVr;
                    char ZVt = ZVr;
                    AVr = VVt;
                    DVr = XVt;
                    FVr = ZVt;
                    GVr = AVt;
                    KVr = DVt;
                    NVr = FVt;
                    SVr = GVt;
                    VVr = KVt;
                    XVr = NVt;
                    ZVr = SVt;
                }

                //RX
                if (RX == 1)
                {
                    char AXt = AXr;
                    char DXt = DXr;
                    char FXt = FXr;
                    char GXt = GXr;
                    char KXt = KXr;
                    char NXt = NXr;
                    char SXt = SXr;
                    char VXt = VXr;
                    char XXt = XXr;
                    char ZXt = ZXr;
                    AXr = ZXt;
                    DXr = AXt;
                    FXr = DXt;
                    GXr = FXt;
                    KXr = GXt;
                    NXr = KXt;
                    SXr = NXt;
                    VXr = SXt;
                    XXr = VXt;
                    ZXr = XXt;
                }
                else if (RX == -1)
                {
                    char AXt = AXr;
                    char DXt = DXr;
                    char FXt = FXr;
                    char GXt = GXr;
                    char KXt = KXr;
                    char NXt = NXr;
                    char SXt = SXr;
                    char VXt = VXr;
                    char XXt = XXr;
                    char ZXt = ZXr;
                    AXr = DXt;
                    DXr = FXt;
                    FXr = GXt;
                    GXr = KXt;
                    KXr = NXt;
                    NXr = SXt;
                    SXr = VXt;
                    VXr = XXt;
                    XXr = ZXt;
                    ZXr = AXt;
                }
                else if (RX == -3)
                {
                    char AXt = AXr;
                    char DXt = DXr;
                    char FXt = FXr;
                    char GXt = GXr;
                    char KXt = KXr;
                    char NXt = NXr;
                    char SXt = SXr;
                    char VXt = VXr;
                    char XXt = XXr;
                    char ZXt = ZXr;
                    AXr = GXt;
                    DXr = KXt;
                    FXr = NXt;
                    GXr = SXt;
                    KXr = VXt;
                    NXr = XXt;
                    SXr = ZXt;
                    VXr = AXt;
                    XXr = DXt;
                    ZXr = FXt;
                }
                else if (RX == -3)
                {
                    char AXt = AXr;
                    char DXt = DXr;
                    char FXt = FXr;
                    char GXt = GXr;
                    char KXt = KXr;
                    char NXt = NXr;
                    char SXt = SXr;
                    char VXt = VXr;
                    char XXt = XXr;
                    char ZXt = ZXr;
                    AXr = VXt;
                    DXr = XXt;
                    FXr = ZXt;
                    GXr = AXt;
                    KXr = DXt;
                    NXr = FXt;
                    SXr = GXt;
                    VXr = KXt;
                    XXr = NXt;
                    ZXr = SXt;
                }

                //RZ
                if (RZ == 1)
                {
                    char AZt = AZr;
                    char DZt = DZr;
                    char FZt = FZr;
                    char GZt = GZr;
                    char KZt = KZr;
                    char NZt = NZr;
                    char SZt = SZr;
                    char VZt = VZr;
                    char XZt = XZr;
                    char ZZt = ZZr;
                    AZr = ZZt;
                    DZr = AZt;
                    FZr = DZt;
                    GZr = FZt;
                    KZr = GZt;
                    NZr = KZt;
                    SZr = NZt;
                    VZr = SZt;
                    XZr = VZt;
                    ZZr = XZt;
                }
                else if (RZ == -1)
                {
                    char AZt = AZr;
                    char DZt = DZr;
                    char FZt = FZr;
                    char GZt = GZr;
                    char KZt = KZr;
                    char NZt = NZr;
                    char SZt = SZr;
                    char VZt = VZr;
                    char XZt = XZr;
                    char ZZt = ZZr;
                    AZr = DZt;
                    DZr = FZt;
                    FZr = GZt;
                    GZr = KZt;
                    KZr = NZt;
                    NZr = SZt;
                    SZr = VZt;
                    VZr = XZt;
                    XZr = ZZt;
                    ZZr = AZt;
                }
                else if (RZ == -3)
                {
                    char AZt = AZr;
                    char DZt = DZr;
                    char FZt = FZr;
                    char GZt = GZr;
                    char KZt = KZr;
                    char NZt = NZr;
                    char SZt = SZr;
                    char VZt = VZr;
                    char XZt = XZr;
                    char ZZt = ZZr;
                    AZr = GZt;
                    DZr = KZt;
                    FZr = NZt;
                    GZr = SZt;
                    KZr = VZt;
                    NZr = XZt;
                    SZr = ZZt;
                    VZr = AZt;
                    XZr = DZt;
                    ZZr = FZt;
                }
                else if (RZ == -3)
                {
                    char AZt = AZr;
                    char DZt = DZr;
                    char FZt = FZr;
                    char GZt = GZr;
                    char KZt = KZr;
                    char NZt = NZr;
                    char SZt = SZr;
                    char VZt = VZr;
                    char XZt = XZr;
                    char ZZt = ZZr;
                    AZr = VZt;
                    DZr = XZt;
                    FZr = ZZt;
                    GZr = AZt;
                    KZr = DZt;
                    NZr = FZt;
                    SZr = GZt;
                    VZr = KZt;
                    XZr = NZt;
                    ZZr = SZt;
                }

            }
            return Done;
        }





        }
}
