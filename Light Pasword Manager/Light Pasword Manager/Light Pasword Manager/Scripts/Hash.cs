using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Pasword_Manager.Scripts
{
    public class Hash
    {
        public double HashMe(string input)
        {
            List<double> PosVal = new List<double>();
            List<double> CharVal = new List<double>();
            double tosend = 0;
            //PosVal Start
            PosVal.Add(59471);//1
            PosVal.Add(55927);//2
            PosVal.Add(60649);//3
            PosVal.Add(63853);//4
            PosVal.Add(59999);//5
            PosVal.Add(66653);//6
            PosVal.Add(61129);//7
            PosVal.Add(54917);//8
            PosVal.Add(11897);//9
            PosVal.Add(52163);//10
            PosVal.Add(52879);//11
            PosVal.Add(20857);//12
            PosVal.Add(58549);//13
            PosVal.Add(14153);//14
            PosVal.Add(65173);//15
            PosVal.Add(42323);//16
            PosVal.Add(55163);//17
            PosVal.Add(11321);//18
            PosVal.Add(54319);//19
            PosVal.Add(61507);//20
            PosVal.Add(55411);//21
            //PosVal End
            //CharVal Start
            CharVal.Add(40597);//32
            CharVal.Add(66047);//33
            CharVal.Add(23473);//34
            CharVal.Add(60169);//35
            CharVal.Add(49411);//36
            CharVal.Add(29537);//37
            CharVal.Add(63337);//38
            CharVal.Add(66863);//39
            CharVal.Add(13721);//40
            CharVal.Add(51031);//41
            CharVal.Add(43987);//42
            CharVal.Add(63397);//43
            CharVal.Add(65707);//44
            CharVal.Add(41177);//45
            CharVal.Add(60083);//46
            CharVal.Add(37783);//47
            CharVal.Add(63521);//48
            CharVal.Add(55639);//49
            CharVal.Add(14437);//50
            CharVal.Add(52769);//51
            CharVal.Add(48541);//52
            CharVal.Add(65551);//53
            CharVal.Add(39619);//54
            CharVal.Add(63599);//55
            CharVal.Add(33997);//56
            CharVal.Add(62477);//57
            CharVal.Add(30293);//58
            CharVal.Add(67339);//59
            CharVal.Add(47441);//60
            CharVal.Add(66449);//61
            CharVal.Add(47137);//62
            CharVal.Add(12703);//63
            CharVal.Add(48989);//64
            CharVal.Add(46027);//65
            CharVal.Add(53479);//66
            CharVal.Add(36541);//67
            CharVal.Add(53719);//68
            CharVal.Add(39079);//69
            CharVal.Add(48271);//70
            CharVal.Add(53279);//71
            CharVal.Add(39989);//72
            CharVal.Add(49037);//73
            CharVal.Add(48779);//74
            CharVal.Add(63691);//75
            CharVal.Add(51239);//76
            CharVal.Add(67121);//77
            CharVal.Add(49339);//78
            CharVal.Add(33049);//79
            CharVal.Add(48647);//80
            CharVal.Add(51169);//81
            CharVal.Add(57781);//82
            CharVal.Add(28759);//83
            CharVal.Add(52289);//84
            CharVal.Add(10211);//85
            CharVal.Add(54497);//86
            CharVal.Add(47981);//87
            CharVal.Add(66569);//88
            CharVal.Add(57059);//89
            CharVal.Add(53161);//90
            CharVal.Add(51551);//91
            CharVal.Add(12329);//92
            CharVal.Add(54583);//93
            CharVal.Add(52859);//94
            CharVal.Add(51599);//95
            CharVal.Add(65957);//96
            CharVal.Add(58217);//97
            CharVal.Add(59207);//98
            CharVal.Add(26687);//99
            CharVal.Add(55817);//100
            CharVal.Add(53819);//101
            CharVal.Add(56359);//102
            CharVal.Add(14741);//103
            CharVal.Add(57457);//104
            CharVal.Add(55501);//105
            CharVal.Add(66161);//106
            CharVal.Add(59957);//107
            CharVal.Add(51973);//108
            CharVal.Add(64283);//109
            CharVal.Add(10799);//110
            CharVal.Add(58943);//111
            CharVal.Add(46411);//112
            CharVal.Add(58027);//113
            CharVal.Add(45343);//114
            CharVal.Add(57713);//115
            CharVal.Add(47381);//116
            CharVal.Add(44777);//117
            CharVal.Add(53267);//118
            CharVal.Add(17987);//119
            CharVal.Add(58313);//120
            CharVal.Add(51853);//121
            CharVal.Add(58997);//122
            CharVal.Add(62969);//123
            CharVal.Add(57259);//124
            CharVal.Add(45833);//125
            CharVal.Add(56773);//126            
            //CharVal End
            if (input != null && input.Length > 0 && input.Length <= 21)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    tosend = tosend + (CharVal[Convert.ToInt32(input[i]) - 32] * PosVal[i]);
                }
            }
            else
            {
                return 0;
            }
            return tosend;
        }
    }
}
