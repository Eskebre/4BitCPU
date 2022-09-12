using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BitCPU
{
    internal class CPU4
    {
        public byte[,] programMemory;
        public byte[] ram;
        public byte programCounter;
        public byte bank;
        public byte regA;
        public byte regB;
        
        
        public void init()
        {
            programMemory = new byte[256,2];
            ram = new byte[16];
            programCounter = 0;
            bank = 0;
            regA = 0;
            regB = 0;
            
        }

        public void loadProgram(string strProgram)
        {
            char[] chrProgram = strProgram.ToCharArray();
            for (int i = 0; i < chrProgram.Length/2; i++)
            {
                programMemory[i,0] = byte.Parse(chrProgram[i*2].ToString(), System.Globalization.NumberStyles.HexNumber);
                programMemory[i,1] = byte.Parse(chrProgram[(i*2)+1].ToString(), System.Globalization.NumberStyles.HexNumber);
            }
            
        }

        public void tick()
        {
            executeInstruction(programMemory[programCounter,0], programMemory[programCounter, 1]);
            programCounter++;
        }

        public void executeInstruction(byte instruction,byte data)
        {
            switch (instruction) {
                case 0x00: //Noop
                    break;
                case 0x01: //Jump - jmp
                    programCounter = (byte)((bank * 0x10) + data -1);
                    break;
                case 0x02: //Jump if Zero - jmz
                    if ((regA +regB) == 0)
                    {
                        programCounter = (byte)((bank * 0x10) + data - 1);
                    }
                    break;
                    
                case 0x03: //Jump if OverFlow - jmc
                    if ((regA + regB) > 0x0f)
                    {
                        programCounter = (byte)((bank * 0x10) + data - 1);
                    }
                    break;
                case 0x04: //Instruction to RegA - lda
                    regA = data;
                  break;
                case 0x05: //Memory to RegA - lda $
                    regA = ram[data];
                    break;
                case 0x06: //Instruction to RegB - ldb
                    regB = data;
                    break;
                case 0x07: //Memory to RegB - ldb $
                    regB = ram[data];
                    break;
                case 0x08: //Output to ram - str
                    ram[data] = (byte)((regA+regB)%0x10);
                    break;

                case 0x0f: //switch bank on next jump - jmb
                    bank = data;
                    break;
            }
        }

    }
}
