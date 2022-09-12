    class Compiler
    {
        static void Main(string[] args)
        {
        File.WriteAllText("Output.txt", compile(File.ReadAllLines(args[0])));
        }

        static string compile(string[] code)
        {
            string output = "";
            foreach (string line in code)
            {
                string lineC = line.Replace(" ", "").ToLower();
                switch (lineC.Substring(0,3))
                {
                case "nop": //No operation
                    output += "00";
                    break;
                case "jmp": //jmp to specified address
                    output += "1" + lineC.Substring(3,1);
                    break;
                case "jmz": //jump if registers equal to zero
                    output += "2" + lineC.Substring(3, 1);
                    break;
                case "jmc": //jump if an overflow occured
                    output += "3" + lineC.Substring(3, 1);
                    break;
                case "lda": //load value from program or memory to register A ('#' for program, '$' for memory)
                    if (lineC.Substring(3, 1) == "#") output += "4" + lineC.Substring(4, 1);
                    else if (lineC.Substring(3, 1) == "$") output += "5" + lineC.Substring(4,1);
                    else output += "4" + lineC.Substring(3, 1);
                    break;
                case "ldb": //load value from program or memory to register A ('#' for program, '$' for memory)
                    if (lineC.Substring(3, 1) == "#") output += "6" + lineC.Substring(4, 1);
                    else if (lineC.Substring(3, 1) == "$") output += "7" + lineC.Substring(4, 1);
                    else output += "6" + lineC.Substring(3, 1);
                    break;
                case "str": //store output of reg A+B to memory address
                    if (lineC.Substring(3, 1) == "$") output += "8" + lineC.Substring(4, 1);
                    else output += "8" + lineC.Substring(3, 1);
                    break;
                case "jmb": //switch program bank, Will only activate on other jump conditions
                    if (lineC.Substring(3, 1) == "#") output += "f" + lineC.Substring(4, 1);
                    else output += "f" + lineC.Substring(3, 1);
                    break;
                default:
                    break;
                }
            output += " ";
            }
            
            return output;
        }
    }