#Notes
#128 Bit 10 Round
#192 Bit 12 Round
#256 Bit 14 Round
#Mine Maybe 16 Round
#/05/2021 Deadline
#---------------------------------------------Lib---------------------------------------------------------------
import math
#---------------------------------------------GLOBAL-VARIABLES---------------------------------------------------
plain = "" #plaintext
plainkey = "Thats my Kung FuThats my Kung Fu" #key before expantion
plainkey1 = ""
cypher = "" #cyphertext
key = []
bigkey = []
mixgrid = [[2,3,1,1],[1,2,3,1],[1,1,2,3],[3,1,1,2]]
invmixgrid = [[14,11,13,9],[9,14,11,13],[13,9,14,11],[11,13,9,14]]
rcon = ["01","02","04","08","10","20","40","80","1B","36"]
multi2 = ["00","02","04","06","08","0A","0C","0E","10","12","14","16","18","1A","1C","1E","20","22","24","26","28","2A","2C","2E","30","32","34","36","38","3A","3C","3E","40","42","44","46","48","4A","4C","4E","50","52","54","56","58","5A","5C","5E","60","62","64","66","68","6A","6C","6E","70","72","74","76","78","7A","7C","7E","80","82","84","86","88","8A","8C","8E","90","92","94","96","98","9A","9C","9E","A0","A2","A4","A6","A8","AA","AC","AE","B0","B2","B4","B6","B8","BA","BC","BE","C0","C2","C4","C6","C8","CA","CC","CE","D0","D2","D4","D6","D8","DA","DC","DE","E0","E2","E4","E6","E8","EA","EC","EE","F0","F2","F4","F6","F8","FA","FC","FE","1B","19","1F","1D","13","11","17","15","0B","09","0F","0D","03","01","07","05","3B","39","3F","3D","33","31","37","35","2B","29","2F","2D","23","21","27","25","5B","59","5F","5D","53","51","57","55","4B","49","4F","4D","43","41","47","45","7B","79","7F","7D","73","71","77","75","6B","69","6F","6D","63","61","67","65","9B","99","9F","9D","93","91","97","95","8B","89","8F","8D","83","81","87","85","BB","B9","BF","BD","B3","B1","B7","B5","AB","A9","AF","AD","A3","A1","A7","A5","DB","D9","DF","DD","D3","D1","D7","D5","CB","C9","CF","CD","C3","C1","C7","C5","FB","F9","FF","FD","F3","F1","F7","F5","EB","E9","EF","ED","E3","E1","E7","E5"]
multi3 = ["00","03","06","05","0C","0F","0A","09","18","1B","1E","1D","14","17","12","11","30","33","36","35","3C","3F","3A","39","28","2B","2E","2D","24","27","22","21","60","63","66","65","6C","6F","6A","69","78","7B","7E","7D","74","77","72","71","50","53","56","55","5C","5F","5A","59","48","4B","4E","4D","44","47","42","41","C0","C3","C6","C5","CC","CF","CA","C9","D8","DB","DE","DD","D4","D7","D2","D1","F0","F3","F6","F5","FC","FF","FA","F9","E8","EB","EE","ED","E4","E7","E2","E1","A0","A3","A6","A5","AC","AF","AA","A9","B8","BB","BE","BD","B4","B7","B2","B1","90","93","96","95","9C","9F","9A","99","88","8B","8E","8D","84","87","82","81","9B","98","9D","9E","97","94","91","92","83","80","85","86","8F","8C","89","8A","AB","A8","AD","AE","A7","A4","A1","A2","B3","B0","B5","B6","BF","BC","B9","BA","FB","F8","FD","FE","F7","F4","F1","F2","E3","E0","E5","E6","EF","EC","E9","EA","CB","C8","CD","CE","C7","C4","C1","C2","D3","D0","D5","D6","DF","DC","D9","DA","5B","58","5D","5E","57","54","51","52","43","40","45","46","4F","4C","49","4A","6B","68","6D","6E","67","64","61","62","73","70","75","76","7F","7C","79","7A","3B","38","3D","3E","37","34","31","32","23","20","25","26","2F","2C","29","2A","0B","08","0D","0E","07","04","01","02","13","10","15","16","1F","1C","19","1A"]
multi9 = ["00","09","12","1B","24","2D","36","3F","48","41","5A","53","6C","65","7E","77","90","99","82","8B","B4","BD","A6","AF","D8","D1","CA","C3","FC","F5","EE","E7","3B","32","29","20","1F","16","0D","04","73","7A","61","68","57","5E","45","4C","AB","A2","B9","B0","8F","86","9D","94","E3","EA","F1","F8","C7","CE","D5","DC","76","7F","64","6D","52","5B","40","49","3E","37","2C","25","1A","13","08","01","E6","EF","F4","FD","C2","CB","D0","D9","AE","A7","BC","B5","8A","83","98","91","4D","44","5F","56","69","60","7B","72","05","0C","17","1E","21","28","33","3A","DD","D4","CF","C6","F9","F0","EB","E2","95","9C","87","8E","B1","B8","A3","AA","EC","E5","FE","F7","C8","C1","DA","D3","A4","AD","B6","BF","80","89","92","9B","7C","75","6E","67","58","51","4A","43","34","3D","26","2F","10","19","02","0B","D7","DE","C5","CC","F3","FA","E1","E8","9F","96","8D","84","BB","B2","A9","A0","47","4E","55","5C","63","6A","71","78","0F","06","1D","14","2B","22","39","30","9A","93","88","81","BE","B7","AC","A5","D2","DB","C0","C9","F6","FF","E4","ED","0A","03","18","11","2E","27","3C","35","42","4B","50","59","66","6F","74","7D","A1","A8","B3","BA","85","8C","97","9E","E9","E0","FB","F2","CD","C4","DF","D6","31","38","23","2A","15","1C","07","0E","79","70","6B","62","5D","54","4F","46"]
multi11 = ["00","0B","16","1D","2C","27","3A","31","58","53","4E","45","74","7F","62","69","B0","BB","A6","AD","9C","97","8A","81","E8","E3","FE","F5","C4","CF","D2","D9","7B","70","6D","66","57","5C","41","4A","23","28","35","3E","0F","04","19","12","CB","C0","DD","D6","E7","EC","F1","FA","93","98","85","8E","BF","B4","A9","A2","F6","FD","E0","EB","DA","D1","CC","C7","AE","A5","B8","B3","82","89","94","9F","46","4D","50","5B","6A","61","7C","77","1E","15","08","03","32","39","24","2F","8D","86","9B","90","A1","AA","B7","BC","D5","DE","C3","C8","F9","F2","EF","E4","3D","36","2B","20","11","1A","07","0C","65","6E","73","78","49","42","5F","54","F7","FC","E1","EA","DB","D0","CD","C6","AF","A4","B9","B2","83","88","95","9E","47","4C","51","5A","6B","60","7D","76","1F","14","09","02","33","38","25","2E","8C","87","9A","91","A0","AB","B6","BD","D4","DF","C2","C9","F8","F3","EE","E5","3C","37","2A","21","10","1B","06","0D","64","6F","72","79","48","43","5E","55","01","0A","17","1C","2D","26","3B","30","59","52","4F","44","75","7E","63","68","B1","BA","A7","AC","9D","96","8B","80","E9","E2","FF","F4","C5","CE","D3","D8","7A","71","6C","67","56","5D","40","4B","22","29","34","3F","0E","05","18","13","CA","C1","DC","D7","E6","ED","F0","FB","92","99","84","8F","BE","B5","A8","A3"]
multi13 = ["00","0D","1A","17","34","39","2E","23","68","65","72","7F","5C","51","46","4B","D0","DD","CA","C7","E4","E9","FE","F3","B8","B5","A2","AF","8C","81","96","9B","BB","B6","A1","AC","8F","82","95","98","D3","DE","C9","C4","E7","EA","FD","F0","6B","66","71","7C","5F","52","45","48","03","0E","19","14","37","3A","2D","20","6D","60","77","7A","59","54","43","4E","05","08","1F","12","31","3C","2B","26","BD","B0","A7","AA","89","84","93","9E","D5","D8","CF","C2","E1","EC","FB","F6","D6","DB","CC","C1","E2","EF","F8","F5","BE","B3","A4","A9","8A","87","90","9D","06","0B","1C","11","32","3F","28","25","6E","63","74","79","5A","57","40","4D","DA","D7","C0","CD","EE","E3","F4","F9","B2","BF","A8","A5","86","8B","9C","91","0A","07","10","1D","3E","33","24","29","62","6F","78","75","56","5B","4C","41","61","6C","7B","76","55","58","4F","42","09","04","13","1E","3D","30","27","2A","B1","BC","AB","A6","85","88","9F","92","D9","D4","C3","CE","ED","E0","F7","FA","B7","BA","AD","A0","83","8E","99","94","DF","D2","C5","C8","EB","E6","F1","FC","67","6A","7D","70","53","5E","49","44","0F","02","15","18","3B","36","21","2C","0C","01","16","1B","38","35","22","2F","64","69","7E","73","50","5D","4A","47","DC","D1","C6","CB","E8","E5","F2","FF","B4","B9","AE","A3","80","8D","9A","97"]
multi14 = ["00","0E","1C","12","38","36","24","2A","70","7E","6C","62","48","46","54","5A","E0","EE","FC","F2","D8","D6","C4","CA","90","9E","8C","82","A8","A6","B4","BA","DB","D5","C7","C9","E3","ED","FF","F1","AB","A5","B7","B9","93","9D","8F","81","3B","35","27","29","03","0D","1F","11","4B","45","57","59","73","7D","6F","61","AD","A3","B1","BF","95","9B","89","87","DD","D3","C1","CF","E5","EB","F9","F7","4D","43","51","5F","75","7B","69","67","3D","33","21","2F","05","0B","19","17","76","78","6A","64","4E","40","52","5C","06","08","1A","14","3E","30","22","2C","96","98","8A","84","AE","A0","B2","BC","E6","E8","FA","F4","DE","D0","C2","CC","41","4F","5D","53","79","77","65","6B","31","3F","2D","23","09","07","15","1B","A1","AF","BD","B3","99","97","85","8B","D1","DF","CD","C3","E9","E7","F5","FB","9A","94","86","88","A2","AC","BE","B0","EA","E4","F6","F8","D2","DC","CE","C0","7A","74","66","68","42","4C","5E","50","0A","04","16","18","32","3C","2E","20","EC","E2","F0","FE","D4","DA","C8","C6","9C","92","80","8E","A4","AA","B8","B6","0C","02","10","1E","34","3A","28","26","7C","72","60","6E","44","4A","58","56","37","39","2B","25","0F","01","13","1D","47","49","5B","55","7F","71","63","6D","D7","D9","CB","C5","EF","E1","F3","FD","A7","A9","BB","B5","9F","91","83","8D"]
convhex = [["0","0000"],["1","0001"],["2","0010"],["3","0011"],["4","0100"],["5","0101"],["6","0110"],["7","0111"],["8","1000"],["9","1001"],["A","1010"],["B","1011"],["C","1100"],["D","1101"],["E","1110"],["F","1111"]] #a table to convert hex to bin quickly
convdec = [["0",0],["1",1],["2",2],["3",3],["4",4],["5",5],["6",6],["7",7],["8",8],["9",9],["A",10],["B",11],["C",12],["D",13],["E",14],["F",15]]
sbox = [["63","7C","77","7B","F2","6B","6F","C5","30","01","67","2B","FE","D7","AB","76"],["CA","82","C9","7D","FA","59","47","F0","AD","D4","A2","AF","9C","A4","72","C0"],["B7","FD","93","26","36","3F","F7","CC","34","A5","E5","F1","71","D8","31","15"],["04","C7","23","C3","18","96","05","9A","07","12","80","E2","EB","27","B2","75"],["09","83","2C","1A","1B","6E","5A","A0","52","3B","D6","B3","29","E3","2F","84"],["53","D1","00","ED","20","FC","B1","5B","6A","CB","BE","39","4A","4C","58","CF"],["D0","EF","AA","FB","43","4D","33","85","45","F9","02","7F","50","3C","9F","A8"],["51","A3","40","8F","92","9D","38","F5","BC","B6","DA","21","10","FF","F3","D2"],["CD","0C","13","EC","5F","97","44","17","C4","A7","7E","3D","64","5D","19","73"],["60","81","4F","DC","22","2A","90","88","46","EE","B8","14","DE","5E","0B","DB"],["E0","32","3A","0A","49","06","24","5C","C2","D3","AC","62","91","95","E4","79"],["E7","C8","37","6D","8D","D5","4E","A9","6C","56","F4","EA","65","7A","AE","08"],["BA","78","25","2E","1C","A6","B4","C6","E8","DD","74","1F","4B","BD","8B","8A"],["70","3E","B5","66","48","03","F6","0E","61","35","57","B9","86","C1","1D","9E"],["E1","F8","98","11","69","D9","8E","94","9B","1E","87","E9","CE","55","28","DF"],["8C","A1","89","0D","BF","E6","42","68","41","99","2D","0F","B0","54","BB","16"]]
invsbox = [["52","09","6A","D5","30","36","A5","38","BF","40","A3","9E","81","F3","D7","FB"],["7C","E3","39","82","9B","2F","FF","87","34","8E","43","44","C4","DE","E9","CB"],["54","7B","94","32","A6","C2","23","3D","EE","4C","95","0B","42","FA","C3","4E"],["08","2E","A1","66","28","D9","24","B2","76","5B","A2","49","6D","8B","D1","25"],["72","F8","F6","64","86","68","98","16","D4","A4","5C","CC","5D","65","B6","92"],["6C","70","48","50","FD","ED","B9","DA","5E","15","46","57","A7","8D","9D","84"],["90","D8","AB","00","8C","BC","D3","0A","F7","E4","58","05","B8","B3","45","06"],["D0","2C","1E","8F","CA","3F","0F","02","C1","AF","BD","03","01","13","8A","6B"],["3A","91","11","41","4F","67","DC","EA","97","F2","CF","CE","F0","B4","E6","73"],["96","AC","74","22","E7","AD","35","85","E2","F9","37","E8","1C","75","DF","6E"],["47","F1","1A","71","1D","29","C5","89","6F","B7","62","0E","AA","18","BE","1B"],["FC","56","3E","4B","C6","D2","79","20","9A","DB","C0","FE","78","CD","5A","F4"],["1F","DD","A8","33","88","07","C7","31","B1","12","10","59","27","80","EC","5F"],["60","51","7F","A9","19","B5","4A","0D","2D","E5","7A","9F","93","C9","9C","EF"],["A0","E0","3B","4D","AE","2A","F5","B0","C8","EB","BB","3C","83","53","99","61"],["17","2B","04","7E","BA","77","D6","26","E1","69","14","63","55","21","0C","7D"]]
#---------------------------------------------CLASSES------------------------------------------------------------
class block:
    def __init__(self,size = 128): #set up 4x4 array
        self.data = [["","","",""],["","","",""],["","","",""],["","","",""]]
        self.size = size
    def display(self): # print the 4x4 display to screen (debugging)
        print("-------------")
        for i in range(0,4):
            print("|" + self.data[i][0] + "|" + self.data[i][1] + "|" + self.data[i][2] + "|" + self.data[i][3] + "|")
            print("-------------")
    def getbincell(self,x,y): #get the binary value of a single cell
        val = self.data[x][y]
        ret = ""
        for i in range(0,16):
            if val[0] == convhex[i][0]:
                ret+=convhex[i][1]
        for i in range(0,16):
            if val[1] == convhex[i][0]:
                ret+=convhex[i][1]
        return ret
    def getraw(self): # get the binary value of the entier block
        val = ""
        ret = ""
        for x in range(0,4):
            for y in range(0,4):
                val = self.data[x][y]
                for b in range(0,2):
                    for i in range(0,16):
                        if val[b] == convhex[i][0]:
                            ret+=convhex[i][1]
        return ret
    def hexset(self,hexin):
        count=0
        for x in range(0,4):
            for y in range(0,4):
                self.data[y][x] = hexin[count] + hexin[count+1]
                count+=2

class bigblock:
    def __init__(self,size = 128): #set up 4x4 array
        self.data = [["","","","","","","","","","","","","","","",""],["","","","","","","","","","","","","","","",""],["","","","","","","","","","","","","","","",""],["","","","","","","","","","","","","","","",""]]

#---------------------------------------------FUNCTIONS----------------------------------------------------------

def modstr(string,pos,repl):#modify a single char in a string by index
    newstr = "" #new string
    for i in range(0,len(string)):#for each char
        if i == pos:#if at index
            newstr += repl#add replacement char
        else:
            newstr += string[i]#add normal char
    return newstr



def getCord(text):#Turns A 2 Diget Hex Value Into Decimal Coordinates
    cord = [0,0]
    for i in range(0,2):
        num = text[i]        
        if (num == "A"):
            cord[i] = 10
        elif (num == "B"):
            cord[i] = 11
        elif (num == "C"):
            cord[i] = 12
        elif (num == "D"):
            cord[i] = 13
        elif (num == "E"):
            cord[i] = 14
        elif (num == "F"):
            cord[i] = 15
        else:
            cord[i] = int(num)
    return cord

def mod2Add4(numbers):#  format ["FF","FF","FF","FF"]
    binaryval = ["","","",""] #binary format of above ["11111111","11111111","11111111","11111111"]
    for i in range(0,4):#for each byte
        no = ""
        for b in range(0,2):#for each 4bit
            for c in range(0,16):#for each letter in hex
                if numbers[i][b] == convhex[c][0]: #if same as lookup
                    binaryval[i]+=convhex[c][1]#set binary val
    current = binaryval[0] #set curretnt value to first value
    for i in range(1,4): # for each value starting with [1]
        add = binaryval[i]#current [i] value to xor
        for b in range(0,8): #for each binary value
            if (int(current[b]) + int(add[b]) <2): # if it adds to less than 2
                calc = str(int(current[b]) + int(add[b]))# add
                current = modstr(current,b,calc)# replace bit with added value
            else:
                current = modstr(current,b,"0")#replace bit with 0
        if (i==3):#on the last round
            no1 = "" #1st hex letter
            no2 = ""#2nd hex letter
            ret = ""#to return
            for c in range (0,8):#for each binary value
                if (c<4):#for each hex char
                    no1 += current[c]#add to no1
                else:
                    no2 += current[c]#add to no2
            for d in range (0,16):#for each letter in hex
                if no1 == convhex[d][1]:#if same as hex lookup
                    no1 = convhex[d][0] #set letter
                if no2 == convhex[d][1]:#if same as hex lookup
                    no2 = convhex[d][0] #set letter
            ret = no1 + no2 #set to return
            return ret #return xored value
    
            
        
            



def SubBytes(block_data,crypttype):#Substitute Cells For SBOX
    for x in range (0,4):
        for y in range (0,4):
            current = block_data.data[x][y] #Get Each Cell
            cord = getCord(current) # Get Its Coordinates In SBOX
            if (crypttype == "E"): # If Encrypting
                block_data.data[x][y] = sbox[cord[0]][cord[1]] # Return SBOX Value To Cell
            elif (crypttype == "D"):#If Decrypting
                block_data.data[x][y] = invsbox[cord[0]][cord[1]]  # Return SBOX Value To Cell          
    return 0 #Return Success

def ShiftRows(block_data,crypttype): #Shift Rows Across
    temp_block=[["00","00","00","00"],["00","00","00","00"],["00","00","00","00"],["00","00","00","00"]]#temp empty block
    temp_block[0] = block_data.data[0] # set the first row of the empty block to the first row of the current block
    for y in range(0,4):
        for x in range(0,4): # for each cell
            if (crypttype == "E"): # if encrypting
                if (x+y<=3): # if within range 0-3
                    temp_block[y][x]=block_data.data[y][x+y]# shift cell by y e.g. further down the block more it moves across
                else:
                    temp_block[y][x]=block_data.data[y][(x+y)-4]# shift cell with correction for out of range
            elif (crypttype == "D"):# if decrypting
                if (x-y >=0):# if within range 0-3
                    temp_block[y][x]=block_data.data[y][x-y]# shift cell by y e.g. further down the block more it moves across
                else:
                    temp_block[y][x]=block_data.data[y][(x-y)+4]# shift cell with correction for out of range
    block_data.data=temp_block# set current block to the results
    return 0

def getDecimal(hexa):
    index = 0
    for b in range(0,2):
        for c in range(0,16):
            if (hexa[b]==convdec[c][0]):
                if (b == 0):
                    index += 16*convdec[c][1]
                else:
                    index += convdec[c][1]
    return index
               

def MixColumns(block_data,crypttype):
    blocknew = [["","","",""],["","","",""],["","","",""],["","","",""]] # empty block
    Cval = ["","","",""] # Colum values
    Gval = [0,0,0,0] # Given Value
    for y in range(0,4):
        for x in range(0,4):
            if (crypttype == "E"): # If encrypting
                Gval = mixgrid[y] # Get the row from mixgrid
            elif (crypttype == "D"): # If decrypting
                Gval = invmixgrid[y] # Get the row from inverted mixgrid
            for i in range (0,4): # For Each Cell within the column
                val = block_data.data[i][x] # Current cell
                index = getDecimal(val) # get the decimal value for the cell
                if (Gval[i] == 1): # for x1
                    Cval[i] = val # set cval value to the cell
                elif (Gval[i] == 2): # for x2
                    Cval[i] = multi2[index] # set cval value to one from the lookup table multi2
                elif (Gval[i] == 3): # for x3
                    Cval[i] = multi3[index] # set cval value to one from the lookup table multi3
                elif (Gval[i] == 9): # for x9
                    Cval[i] = multi9[index] # set cval value to one from the lookup table multi9
                elif (Gval[i] == 11): # for x11
                    Cval[i] = multi11[index] # set cval value to one from the lookup table multi11
                elif (Gval[i] == 13): # for x13
                    Cval[i] = multi13[index] # set cval value to one from the lookup table multi13
                elif (Gval[i] == 14): # for x14
                    Cval[i] = multi14[index] # set cval value to one from the lookup table multi14
            new = mod2Add4(Cval) #xor values and set as new
            blocknew[y][x] = new # set newblock cell to new
    block_data.data = blocknew # set current block to the blocknew

def CharToHex(letter):
    first = math.floor((ord(letter)) /16)
    seccond = (ord(letter))%16
    coor = [first,seccond]
    toret = ""
    for i in range(0,2):
        for b in range(0,16):
            if (coor[i] == convdec[b][1]):
                toret+=convdec[b][0]
    return toret


def AddRoundKey(block_data,block_key):
    newblock = [["","","",""],["","","",""],["","","",""],["","","",""]]# new empty block
    for x in range(0,4):
        for y in range (0,4): #for each cell
            newblock[x][y] = mod2Add4([block_data.data[x][y],block_key.data[x][y],"00","00"])# set newblock cell to exor of two cells from key and data
    block_data.data = newblock# set current block to newblock




#--------------------------------------Key-Expand--------------------------------------------------------------

def XorRcon(c,r): #xors the first cell with the round rcon value
    c[0] = mod2Add4([rcon[r],c[0],"00","00"])
    return c

def RotWord(c): #rearanges the cells
    return [c[1],c[2],c[3],c[0]]

def SubWord(c):
    for x in range (0,4):
        current = c[x] #Get Each Cell
        cord = getCord(current) # Get Its Coordinates In SBOX
        c[x] = sbox[cord[0]][cord[1]] # Return SBOX Value To Cell
    return c

def g(c,r): #runs rotword subword and xorrcon on a column
    v0 = RotWord(c)
    v1 = SubWord(v0)
    v2 = XorRcon(v1,r)   
    return v2

def SettupKey0(key,size,hexmode):#format first key
    if (size == 128):#if 128-bit
        newblock = [["2B", "28", "AB", "09"],["7E", "AE", "F7", "CF"],["15", "D2", "15", "4F"],["16", "A6", "88", "3C"]]
        if hexmode:#if input is in hex
            count=0#counter
            for x in range(0,4):
                for y in range(0,4):#for each cell
                    newblock[y][x] = key[count] + key[count+1]#add 2 hex chars to cell
                    count+=2#increment count
        else:#if input is string
            c = -1#counter
            for y in range(0,4):
                for x in range(0,4):#for each cell
                    c += 1#increment count
                    letter = key[c]#get the current letter in the string
                    newblock[x][y] = CharToHex(letter)#convert letter to hexadecimal and set cell
        key0 = block()#create new key
        key0.data = newblock#set its data
        return key0#return the new key block
    if (size == 192):
        newblock = [["8E", "DA", "C8", "80", "62", "52"],["73", "0E", "10", "90", "F8", "2C"],["B0", "64", "F3", "79", "EA", "6B"],["F7", "52", "2B", "E5", "D2", "7B"]]
        if hexmode:
            count=0
            for x in range(0,6):
                for y in range(0,4):
                    newblock[y][x] = key[count] + key[count+1]
                    count+=2
        else:
            c = -1
            for y in range(0,4):
                for x in range(0,6):
                    c += 1
                    letter = key[c]
                    newblock[x][y] = CharToHex(letter)
        
        key0 = block()
        key0.data = newblock
        return key0
    if (size == 256):
        newblock = [["60","15","2B","85","1F","3B","2D","09"],["3D","CA","73","7D","35","61","98","14"],["EB","71","AE","77","2C","08","10","DF"],["10","BE","F0","81","07","D7","A3","F4"]]
        if hexmode:
            count=0
            for x in range(0,8):
                for y in range(0,4):
                    newblock[y][x] = key[count] + key[count+1]
                    count+=2
        else:
            c = -1
            for y in range(0,4):
                for x in range(0,8):
                    c += 1
                    letter = key[c]
                    newblock[x][y] = CharToHex(letter)
        key0 = block()
        key0.data = newblock
        return key0
    if (size == 384):
        newblock = [["","","","","","","","","","","",""],["","","","","","","","","","","",""],["","","","","","","","","","","",""],["","","","","","","","","","","",""]]
        if hexmode:
            count=0
            for x in range(0,12):
                for y in range(0,4):
                    newblock[y][x] = key[count] + key[count+1]
                    count+=2
        else:
            c = -1
            for y in range(0,4):
                for x in range(0,12):
                    c += 1
                    letter = key[c]
                    newblock[x][y] = CharToHex(letter)
        key0 = block()
        key0.data = newblock
        return key0
    if (size == 512):
        newblock = [["","","","","","","","","","","","","","","",""],["","","","","","","","","","","","","","","",""],["","","","","","","","","","","","","","","",""],["","","","","","","","","","","","","","","",""]]
        if hexmode:
            count=0
            for x in range(0,16):
                for y in range(0,4):
                    newblock[y][x] = key[count] + key[count+1]
                    count+=2
        else:
            c = -1
            for y in range(0,4):
                for x in range(0,16):
                    c += 1
                    letter = key[c]
                    newblock[x][y] = CharToHex(letter)
        key0 = block()
        key0.data = newblock
        return key0

def XorCollum(c1,c2):
    r0 = mod2Add4([c1[0],c2[0],"00","00"])
    r1 = mod2Add4([c1[1],c2[1],"00","00"])
    r2 = mod2Add4([c1[2],c2[2],"00","00"])
    r3 = mod2Add4([c1[3],c2[3],"00","00"])
    return [r0,r1,r2,r3]

def KeyExpand(keydata, Size,hexmode):
    key0 = SettupKey0(keydata,Size,hexmode) #sets up first key block off user input
    if (Size == 128): #if 128 bit encryption
        key.append(key0) #append the first key to key list
    else: #if above 128 bit encryption
        bigkey.append(key0)#append the first key to key list
    #128 Bit
    if (Size == 128):
        for i in range(0,10):#for each round of encryption
            lastkey = key[i]#the previous key block
            newkey = block()# make a new key block
            w0 = [lastkey.data[0][0],lastkey.data[1][0],lastkey.data[2][0],lastkey.data[3][0]]#column 0
            w1 = [lastkey.data[0][1],lastkey.data[1][1],lastkey.data[2][1],lastkey.data[3][1]]#column 1
            w2 = [lastkey.data[0][2],lastkey.data[1][2],lastkey.data[2][2],lastkey.data[3][2]]#column 2
            w3 = [lastkey.data[0][3],lastkey.data[1][3],lastkey.data[2][3],lastkey.data[3][3]]#column 3
            gval = g(w3,i)#run function g on the last column
            w4 = XorCollum(w0,gval)#column 0 in the new block = xor column 0 and gval
            w5 = XorCollum(w4,w1)#column 1 in the new block = xor column 0(new) and gval
            w6 = XorCollum(w5,w2)#column 2 in the new block = xor column 1(new) and gval
            w7 = XorCollum(w6,w3)#column 3 in the new block = xor column 2(new) and gval
            new = [w4,w5,w6,w7]# add new columns to make a new block
            for x in range(0,4):
                for y in range(0,4):# for each cell
                    newkey.data[x][y] = new[y][x]# set the cell to the new value
            key.append(newkey)#append the key
    # 192
    elif (Size == 192):
        for i in range(0,8):#for each round of encryption
            lastkey = bigkey[i]#the previous key block
            newkey = bigblock()# make a new key block
            w0 = [lastkey.data[0][0],lastkey.data[1][0],lastkey.data[2][0],lastkey.data[3][0]]#column 0
            w1 = [lastkey.data[0][1],lastkey.data[1][1],lastkey.data[2][1],lastkey.data[3][1]]#column 1
            w2 = [lastkey.data[0][2],lastkey.data[1][2],lastkey.data[2][2],lastkey.data[3][2]]#column 2
            w3 = [lastkey.data[0][3],lastkey.data[1][3],lastkey.data[2][3],lastkey.data[3][3]]#column 3
            w4 = [lastkey.data[0][4],lastkey.data[1][4],lastkey.data[2][4],lastkey.data[3][4]]#column 4
            w5 = [lastkey.data[0][5],lastkey.data[1][5],lastkey.data[2][5],lastkey.data[3][5]]#column 5
            gval = g(w5,i)#run function g on the last column
            w6 = XorCollum(w0,gval)#column 0 in the new block = xor column 0 and gval
            w7 = XorCollum(w6,w1)#column 1 in the new block = xor column 0(new) and gval
            w8 = XorCollum(w7,w2)#column 2 in the new block = xor column 1(new) and gval
            w9 = XorCollum(w8,w3)#column 3 in the new block = xor column 2(new) and gval
            w10 = XorCollum(w9,w4)#column 4 in the new block = xor column 3(new) and gval
            w11 = XorCollum(w10,w5)#column 5 in the new block = xor column 4(new) and gval
            new = [w6,w7,w8,w9,w10,w11]#add new columns to make a new block
            for x in range(0,4):
                for y in range(0,6):#for each cell
                    newkey.data[x][y] = new[y][x]# set the cell to the new value
            newkey.size = 192#set size
            bigkey.append(newkey)#append the key
    elif (Size == 256):
        newkey = block()# make a new key block
        newkey2 = block()# make a new key block
        key0 = bigkey[0]#key 0
        w0 = [key0.data[0][0],key0.data[1][0],key0.data[2][0],key0.data[3][0]]#get all columns
        w1 = [key0.data[0][1],key0.data[1][1],key0.data[2][1],key0.data[3][1]]
        w2 = [key0.data[0][2],key0.data[1][2],key0.data[2][2],key0.data[3][2]]
        w3 = [key0.data[0][3],key0.data[1][3],key0.data[2][3],key0.data[3][3]]
        w4 = [key0.data[0][4],key0.data[1][4],key0.data[2][4],key0.data[3][4]]
        w5 = [key0.data[0][5],key0.data[1][5],key0.data[2][5],key0.data[3][5]]
        w6 = [key0.data[0][6],key0.data[1][6],key0.data[2][6],key0.data[3][6]]
        w7 = [key0.data[0][7],key0.data[1][7],key0.data[2][7],key0.data[3][7]]
        new = [w0,w1,w2,w3]#seperate into 2 regular blocks
        new2 = [w4,w5,w6,w7]
        for x in range(0,4):
            for y in range(0,4):
                newkey.data[x][y] = new[y][x]
                newkey2.data[x][y] = new2[y][x]#set the values into the new keys
        
        key.append(newkey)#append the keys
        key.append(newkey2)
        for i in range(0,7):#for each round of encryption
            lastkey = bigkey[i]#the previous key block
            newkey = block()#new block
            newkey2 = block()#new block
            newkey3 = bigblock()#new big block
            w0 = [lastkey.data[0][0],lastkey.data[1][0],lastkey.data[2][0],lastkey.data[3][0]]#get all columns
            w1 = [lastkey.data[0][1],lastkey.data[1][1],lastkey.data[2][1],lastkey.data[3][1]]
            w2 = [lastkey.data[0][2],lastkey.data[1][2],lastkey.data[2][2],lastkey.data[3][2]]
            w3 = [lastkey.data[0][3],lastkey.data[1][3],lastkey.data[2][3],lastkey.data[3][3]]
            w4 = [lastkey.data[0][4],lastkey.data[1][4],lastkey.data[2][4],lastkey.data[3][4]]
            w5 = [lastkey.data[0][5],lastkey.data[1][5],lastkey.data[2][5],lastkey.data[3][5]]
            w6 = [lastkey.data[0][6],lastkey.data[1][6],lastkey.data[2][6],lastkey.data[3][6]]
            w7 = [lastkey.data[0][7],lastkey.data[1][7],lastkey.data[2][7],lastkey.data[3][7]]
            gval = g(w7,i)#run function g on the last column
            w8 = XorCollum(w0,gval)# xor first column of previous key with gval
            w9 = XorCollum(w8,w1) #xor columns from previous key with last column
            w10 = XorCollum(w9,w2)
            w11 = XorCollum(w10,w3)
            w11 = SubWord(w11) #Subword on 4th column
            w12 = XorCollum(w11,w4)
            w13 = XorCollum(w12,w5)
            w14 = XorCollum(w13,w6)
            w15 = XorCollum(w14,w7)
            w11 = XorCollum(w10,w3)#reset column
            new = [w8,w9,w10,w11]#set values in block
            new2 = [w12,w13,w14,w15]#set values in block
            new3 = [w8,w9,w10,w11,w12,w13,w14,w15] #set one big block
            for x in range(0,4):
                for y in range(0,8):
                    newkey3.data[x][y] = new3[y][x]#set cells
            for x in range(0,4):
                for y in range(0,4):
                    newkey.data[x][y] = new[y][x]#set cells
                    newkey2.data[x][y] = new2[y][x]#set cells
            newkey.size = 128 #set sizes
            newkey2.size = 128
            newkey3.size = 256
            key.append(newkey)#append keys
            key.append(newkey2)
            bigkey.append(newkey3)
    elif (Size == 384):
        newkey = block()#make new blocks
        newkey2 = block()
        newkey3 = block()
        key0 = bigkey[0]
        w0 = [key0.data[0][0],key0.data[1][0],key0.data[2][0],key0.data[3][0]]#get all columns
        w1 = [key0.data[0][1],key0.data[1][1],key0.data[2][1],key0.data[3][1]]
        w2 = [key0.data[0][2],key0.data[1][2],key0.data[2][2],key0.data[3][2]]
        w3 = [key0.data[0][3],key0.data[1][3],key0.data[2][3],key0.data[3][3]]
        w4 = [key0.data[0][4],key0.data[1][4],key0.data[2][4],key0.data[3][4]]
        w5 = [key0.data[0][5],key0.data[1][5],key0.data[2][5],key0.data[3][5]]
        w6 = [key0.data[0][6],key0.data[1][6],key0.data[2][6],key0.data[3][6]]
        w7 = [key0.data[0][7],key0.data[1][7],key0.data[2][7],key0.data[3][7]]
        w8 = [key0.data[0][8],key0.data[1][8],key0.data[2][8],key0.data[3][8]]
        w9 = [key0.data[0][9],key0.data[1][9],key0.data[2][9],key0.data[3][9]]
        w10 = [key0.data[0][10],key0.data[1][10],key0.data[2][10],key0.data[3][10]]
        w11 = [key0.data[0][11],key0.data[1][11],key0.data[2][11],key0.data[3][11]]
        new = [w0,w1,w2,w3]#set data
        new2 = [w4,w5,w6,w7]
        new3 = [w8,w9,w10,w11]
        for x in range(0,4):
            for y in range(0,4):
                newkey.data[x][y] = new[y][x]#set cells
                newkey2.data[x][y] = new2[y][x]
                newkey3.data[x][y] = new3[y][x]
        
        key.append(newkey)#append keys
        key.append(newkey2)
        key.append(newkey3)
        for i in range(0,6):#for each round (previously key0)
            lastkey = bigkey[i]#last key
            newkey = block()#new key blocks
            newkey2 = block()
            newkey3 = block()
            newkey4 = bigblock()
            w0 = [lastkey.data[0][0],lastkey.data[1][0],lastkey.data[2][0],lastkey.data[3][0]]#get columns
            w1 = [lastkey.data[0][1],lastkey.data[1][1],lastkey.data[2][1],lastkey.data[3][1]]
            w2 = [lastkey.data[0][2],lastkey.data[1][2],lastkey.data[2][2],lastkey.data[3][2]]
            w3 = [lastkey.data[0][3],lastkey.data[1][3],lastkey.data[2][3],lastkey.data[3][3]]
            w4 = [lastkey.data[0][4],lastkey.data[1][4],lastkey.data[2][4],lastkey.data[3][4]]
            w5 = [lastkey.data[0][5],lastkey.data[1][5],lastkey.data[2][5],lastkey.data[3][5]]
            w6 = [lastkey.data[0][6],lastkey.data[1][6],lastkey.data[2][6],lastkey.data[3][6]]
            w7 = [lastkey.data[0][7],lastkey.data[1][7],lastkey.data[2][7],lastkey.data[3][7]]
            w8 = [lastkey.data[0][8],lastkey.data[1][8],lastkey.data[2][8],lastkey.data[3][8]]
            w9 = [lastkey.data[0][9],lastkey.data[1][9],lastkey.data[2][9],lastkey.data[3][9]]
            w10 = [lastkey.data[0][10],lastkey.data[1][10],lastkey.data[2][10],lastkey.data[3][10]]
            w11 = [lastkey.data[0][11],lastkey.data[1][11],lastkey.data[2][11],lastkey.data[3][11]]
            gval = g(w11,i)#run function g on the last column
            w12 = XorCollum(w0,gval)# xor first column of previous key with gval
            w13 = XorCollum(w12,w1)#xor columns from previous key with last column
            w14 = XorCollum(w13,w2)
            w15 = XorCollum(w14,w3)
            w15 = SubWord(w15)#Subword on 4th column
            w16 = XorCollum(w15,w4)
            w17 = XorCollum(w16,w5)
            w18 = XorCollum(w17,w6)
            w19 = XorCollum(w18,w7)
            w19 = SubWord(w19)#Subword on 8th column
            w20 = XorCollum(w19,w8)
            w21 = XorCollum(w20,w9)
            w22 = XorCollum(w21,w10)
            w23 = XorCollum(w22,w11)
            w15 = XorCollum(w14,w3)#reset column
            w19 = XorCollum(w18,w7)#reset column
            new = [w12,w13,w14,w15]#set data
            new2 = [w16,w17,w18,w19]
            new3 = [w20,w21,w22,w23]
            new4 = [w12,w13,w14,w15,w16,w17,w18,w19,w20,w21,w22,w23]
            for x in range(0,4):
                for y in range(0,12):
                    newkey4.data[x][y] = new4[y][x]#set cells
            for x in range(0,4):
                for y in range(0,4):
                    newkey.data[x][y] = new[y][x]#set cells
                    newkey2.data[x][y] = new2[y][x]
                    newkey3.data[x][y] = new3[y][x]
            newkey.size = 128#set size
            newkey2.size = 128
            newkey3.size = 128
            newkey4.size = 384
            key.append(newkey)#append keys
            key.append(newkey2)
            key.append(newkey3)
            bigkey.append(newkey4)

    elif (Size == 512):
        newkey = block()#new key blocks
        newkey2 = block()
        newkey3 = block()
        newkey5 = block()
        key0 = bigkey[0]
        w0 = [key0.data[0][0],key0.data[1][0],key0.data[2][0],key0.data[3][0]]#get columns
        w1 = [key0.data[0][1],key0.data[1][1],key0.data[2][1],key0.data[3][1]]
        w2 = [key0.data[0][2],key0.data[1][2],key0.data[2][2],key0.data[3][2]]
        w3 = [key0.data[0][3],key0.data[1][3],key0.data[2][3],key0.data[3][3]]
        w4 = [key0.data[0][4],key0.data[1][4],key0.data[2][4],key0.data[3][4]]
        w5 = [key0.data[0][5],key0.data[1][5],key0.data[2][5],key0.data[3][5]]
        w6 = [key0.data[0][6],key0.data[1][6],key0.data[2][6],key0.data[3][6]]
        w7 = [key0.data[0][7],key0.data[1][7],key0.data[2][7],key0.data[3][7]]
        w8 = [key0.data[0][8],key0.data[1][8],key0.data[2][8],key0.data[3][8]]
        w9 = [key0.data[0][9],key0.data[1][9],key0.data[2][9],key0.data[3][9]]
        w10 = [key0.data[0][10],key0.data[1][10],key0.data[2][10],key0.data[3][10]]
        w11 = [key0.data[0][11],key0.data[1][11],key0.data[2][11],key0.data[3][11]]
        w12 = [key0.data[0][12],key0.data[1][12],key0.data[2][12],key0.data[3][12]]
        w13 = [key0.data[0][13],key0.data[1][13],key0.data[2][13],key0.data[3][13]]
        w14 = [key0.data[0][14],key0.data[1][14],key0.data[2][14],key0.data[3][14]]
        w15 = [key0.data[0][15],key0.data[1][15],key0.data[2][15],key0.data[3][15]]
        new = [w0,w1,w2,w3]#set data
        new2 = [w4,w5,w6,w7]
        new3 = [w8,w9,w10,w11]
        new5 = [w12,w3,w14,w15]
        for x in range(0,4):
            for y in range(0,4):
                newkey.data[x][y] = new[y][x]#set cells
                newkey2.data[x][y] = new2[y][x]
                newkey3.data[x][y] = new3[y][x]
                newkey5.data[x][y] = new5[y][x]
        key.append(newkey)#append keys
        key.append(newkey2)
        key.append(newkey3)
        key.append(newkey5)
        for i in range(0,6):#for each round(previously key0)
            lastkey = bigkey[i]#last key
            newkey = block()#new key blocks
            newkey2 = block()
            newkey3 = block()
            newkey5 = block()
            newkey4 = bigblock()
            w0 = [lastkey.data[0][0],lastkey.data[1][0],lastkey.data[2][0],lastkey.data[3][0]]#get columns
            w1 = [lastkey.data[0][1],lastkey.data[1][1],lastkey.data[2][1],lastkey.data[3][1]]
            w2 = [lastkey.data[0][2],lastkey.data[1][2],lastkey.data[2][2],lastkey.data[3][2]]
            w3 = [lastkey.data[0][3],lastkey.data[1][3],lastkey.data[2][3],lastkey.data[3][3]]
            w4 = [lastkey.data[0][4],lastkey.data[1][4],lastkey.data[2][4],lastkey.data[3][4]]
            w5 = [lastkey.data[0][5],lastkey.data[1][5],lastkey.data[2][5],lastkey.data[3][5]]
            w6 = [lastkey.data[0][6],lastkey.data[1][6],lastkey.data[2][6],lastkey.data[3][6]]
            w7 = [lastkey.data[0][7],lastkey.data[1][7],lastkey.data[2][7],lastkey.data[3][7]]
            w8 = [lastkey.data[0][8],lastkey.data[1][8],lastkey.data[2][8],lastkey.data[3][8]]
            w9 = [lastkey.data[0][9],lastkey.data[1][9],lastkey.data[2][9],lastkey.data[3][9]]
            w10 = [lastkey.data[0][10],lastkey.data[1][10],lastkey.data[2][10],lastkey.data[3][10]]
            w11 = [lastkey.data[0][11],lastkey.data[1][11],lastkey.data[2][11],lastkey.data[3][11]]
            w12 = [key0.data[0][12],key0.data[1][12],key0.data[2][12],key0.data[3][12]]
            w13 = [key0.data[0][13],key0.data[1][13],key0.data[2][13],key0.data[3][13]]
            w14 = [key0.data[0][14],key0.data[1][14],key0.data[2][14],key0.data[3][14]]
            w15 = [key0.data[0][15],key0.data[1][15],key0.data[2][15],key0.data[3][15]]
            gval = g(w15,i)#run function g on the last column
            w16 = XorCollum(w0,gval)# xor first column of previous key with gval
            w17 = XorCollum(w16,w1)#xor columns from previous key with last column
            w18 = XorCollum(w17,w2)
            w19 = XorCollum(w18,w3)
            w19 = SubWord(w19)#Subword on 4th column
            w20 = XorCollum(w19,w4)
            w21 = XorCollum(w20,w5)
            w22 = XorCollum(w21,w6)
            w23 = XorCollum(w22,w7)
            w23 = SubWord(w23)#Subword on 8th column
            w24 = XorCollum(w23,w8)
            w25 = XorCollum(w24,w9)
            w26 = XorCollum(w25,w10)
            w27 = XorCollum(w26,w11)
            w27 = SubWord(w27)#Subword on 12th column
            w28 = XorCollum(w27,w8)
            w29 = XorCollum(w28,w9)
            w30 = XorCollum(w29,w10)
            w31 = XorCollum(w30,w11)
            #--------------------
            w27 = XorCollum(w26,w11)#reset column
            w23 = XorCollum(w14,w3)#reset column
            w19 = XorCollum(w18,w7)#reset column
            new = [w16,w17,w18,w19]#set data
            new2 = [w20,w21,w22,w23]
            new3 = [w24,w25,w26,w27]
            new5 = [w28,w29,w30,w31]
            new4 = [w16,w17,w18,w19,w20,w21,w22,w23,w24,w25,w26,w27,w28,w29,w30,w31]
            for x in range(0,4):
                for y in range(0,12):
                    newkey4.data[x][y] = new4[y][x]#set cells
            for x in range(0,4):
                for y in range(0,4):
                    newkey.data[x][y] = new[y][x]#set cells
                    newkey2.data[x][y] = new2[y][x]
                    newkey3.data[x][y] = new3[y][x]
                    newkey5.data[x][y] = new5[y][x]
            newkey.size = 128#set size
            newkey2.size = 128
            newkey3.size = 128
            newkey4.size = 384
            newkey5.size = 128
            key.append(newkey)#append keys
            key.append(newkey2)
            key.append(newkey3)
            key.append(newkey5)
            bigkey.append(newkey4)
        
    if (Size == 192): #Fixing 6 Column Block To 4 Column
        for i in range(0,len(bigkey)):#for all 192 bit keys
            currentkey = bigkey[i] # the current selected key
            newkey  = block()#new regular block
            newkey2  = block()#new regular block
            newkey.size = 192#set 192 bit
            newkey2.size = 192#set 192 bit
            if(i%2 == 1):# if i is an odd number
                lastkey = bigkey[i-1]#the previous key
                w0 = [lastkey.data[0][4],lastkey.data[1][4],lastkey.data[2][4],lastkey.data[3][4]]#get last 2 columns from the privious key
                w1 = [lastkey.data[0][5],lastkey.data[1][5],lastkey.data[2][5],lastkey.data[3][5]]
                w2 = [currentkey.data[0][0],currentkey.data[1][0],currentkey.data[2][0],currentkey.data[3][0]]# 6 colums from this key
                w3 = [currentkey.data[0][1],currentkey.data[1][1],currentkey.data[2][1],currentkey.data[3][1]]
                w4 = [currentkey.data[0][2],currentkey.data[1][2],currentkey.data[2][2],currentkey.data[3][2]]
                w5 = [currentkey.data[0][3],currentkey.data[1][3],currentkey.data[2][3],currentkey.data[3][3]]
                w6 = [currentkey.data[0][4],currentkey.data[1][4],currentkey.data[2][4],currentkey.data[3][4]]
                w7 = [currentkey.data[0][5],currentkey.data[1][5],currentkey.data[2][5],currentkey.data[3][5]]
                new = [w0,w1,w2,w3]#set regular block
                new2 = [w4,w5,w6,w7]#set regular block
                for x in range(0,4):
                    for y in range(0,4):#for each cell
                        newkey.data[x][y] = new[y][x]#set data from new
                        newkey2.data[x][y]=new2[y][x]#set data from new
                            
                key.append(newkey)#append normal key
                key.append(newkey2)#append normal key
            else:#if i is even
                w0 = [currentkey.data[0][0],currentkey.data[1][0],currentkey.data[2][0],currentkey.data[3][0]]#get the first 4 columns from block
                w1 = [currentkey.data[0][1],currentkey.data[1][1],currentkey.data[2][1],currentkey.data[3][1]]
                w2 = [currentkey.data[0][2],currentkey.data[1][2],currentkey.data[2][2],currentkey.data[3][2]]
                w3 = [currentkey.data[0][3],currentkey.data[1][3],currentkey.data[2][3],currentkey.data[3][3]]
                newkey.size = 128
                new = [w0,w1,w2,w3]#set new as data
                for x in range(0,4):
                    for y in range(0,4):#for each cell
                        newkey.data[x][y] = new[y][x]# set data
                key.append(newkey)#append key
 
def printkeys():
    for i in range(0,len(key)):
        print("Key: "+str(i))
        key[i].display()
                
def KeyInterlace(keydata,keydata2,Size,hexmode):
    KeyExpand(keydata,Size,True)
    tempkey1=key.copy()
    key.clear()
    KeyExpand(keydata2,Size,True)
    tempkey2=key.copy()
    key.clear()
    for i in range(0,28):
        key.append(tempkey1[i])
        key.append(tempkey2[i])
            
def getblockstring(keydata):
    outstring = ""
    for x in range(0,4):
        for y in range(0,4):
            outstring += keydata.data[y][x]
    return outstring
        




#--------------------------------------MAIN-RUN-ZONE--------------------------------------------------------------
def start():
    rounds = 10
    bit = 128
    print("Select Option:\n\r1.128Bit\n\r2.192Bit\n\r3.256Bit\n\r4.384Bit\n\r5.512Bit\n\r6.1024Bit(Interlaced)")
    answer = input()
    if (answer == "1"):
        rounds = 10
        bit = 128
    elif (answer == "2"):
        rounds = 12
        bit = 192
    elif (answer == "3"):
        rounds = 14
        bit = 256
    elif (answer == "4"):
        rounds = 16
        bit = 384
    elif (answer == "5"):
        rounds = 18
        bit = 512
    elif (answer == "6"):
        rounds = 24
        bit = 512
    else:
        print("Invalid Answer")
        start()
        return(0)
        ##################################################
    print("Hex Plaintext: ",end = "")
    plain = input()
    plain = plain.upper()
    print("Hex Key: ",end="")
    plainkey = input()
    plainkey = plainkey.upper()
    if(answer == "6"):
        print("Hex Key 2: ",end="")
        plainkey2 = input()
        plainkey2 = plainkey.upper()
    print("Raw Data: ")
    test = block()
    test.hexset(plain)
    test.display()
    print("Key: " + plainkey)
    if(answer == "6"):
        print("Key 2: " + plainkey2)
        print("2x",end=" ")
    print(str(bit)+" Bit")
    ##################################################
    if (int(answer) <= 5):
        KeyExpand(plainkey,bit,True)
    elif(int(answer) > 5):
        KeyInterlace(plainkey,plainkey2,bit,True)
    ##################################################
    AddRoundKey(test,key[0])
    for i in range(1,rounds):
        SubBytes(test,"E")
        ShiftRows(test,"E")
        MixColumns(test,"E")
        AddRoundKey(test,key[i])
    SubBytes(test,"E")
    ShiftRows(test,"E")
    AddRoundKey(test,key[rounds])
    test.display()
    print("Raw Data: " + getblockstring(test))
    print("Decrypt")
    AddRoundKey(test,key[rounds])
    ShiftRows(test,"D")
    SubBytes(test,"D")
    for i in range(rounds-1,0,-1):
        AddRoundKey(test,key[i])
        MixColumns(test,"D")
        ShiftRows(test,"D")
        SubBytes(test,"D")
    AddRoundKey(test,key[0])
    test.display()
    print("Restart y/n:",end=" ")
    shouldend = input()
    if (shouldend == "y"):
        print("-"*60)
        key.clear()
        bigkey.clear()
        start()
        
    

#---------------------------------------------START-AREA-----------------------------------------------------------
start()
