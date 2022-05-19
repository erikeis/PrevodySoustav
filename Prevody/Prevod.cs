using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevody
{
    public class Prevod
    {
        public static int BinDec(string bin)
        {
            int dec = 0;
            int hodnota = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '1') dec += hodnota;
                hodnota *= 2;

            }

            return dec;
        }

        public static string DecBin(int dec)
        {
            string bin = string.Empty;
            int zbytek;
            while (dec > 1)
            {
                zbytek = dec % 2;
                bin = zbytek + bin;
                dec /= 2;
            }
            bin = dec + bin;

            return bin;
        }

        public static int HexDec(string hex)
        {
            int dec = 0;
            int cislo;
            int hodnota = 1;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(hex[i]))
                {
                    cislo = int.Parse(hex[i].ToString());
                    dec += cislo * hodnota;
                }
                else
                {
                    switch (hex[i])
                    {
                        case 'A':
                            dec += 10 * hodnota;
                            break;
                        case 'B':
                            dec += 11 * hodnota;
                            break;
                        case 'C':
                            dec += 12 * hodnota;
                            break;
                        case 'D':
                            dec += 13 * hodnota;
                            break;
                        case 'E':
                            dec += 14 * hodnota;
                            break;
                        case 'F':
                            dec += 15 * hodnota;
                            break;
                        default:
                            break;
                    }
                }
                hodnota = hodnota * 16;
            }
            return dec;
        }

        public static string DecHex(int dec)
        {
            string hex = string.Empty;
            int zbytek;
            while (dec > 0)
            {
                zbytek = dec % 16;
                if (zbytek < 10)
                {
                    hex = hex.Insert(0, zbytek.ToString());
                }
                else
                {
                    switch (zbytek)
                    {
                        case 10:
                            hex = hex.Insert(0, "A");
                            break;
                        case 11:
                            hex = hex.Insert(0, "B");
                            break;
                        case 12:
                            hex = hex.Insert(0, "C");
                            break;
                        case 13:
                            hex = hex.Insert(0, "D");
                            break;
                        case 14:
                            hex = hex.Insert(0, "E");
                            break;
                        case 15:
                            hex = hex.Insert(0, "F");
                            break;
                        default:
                            break;
                    }
                }
                dec /= 16;
            }
            return hex;
        }

        public static string BinHex(string bin)
        {
            string hex = "", subString;
            int hodnota = 1, hodnotaDec = 0;


            while (bin.Length % 4 != 0) bin = bin.Insert(0, "0");
            while (bin.Length > 0)
            {
                subString = bin.Substring(0, 4);
                for (int i = subString.Length - 1; i >= 0; i--)
                {
                    if (subString[i] == '1') hodnotaDec += hodnota;
                    hodnota *= 2;
                }

                if (hodnotaDec < 10) hex += hodnotaDec.ToString();
                else
                {
                    switch (hodnotaDec)
                    {
                        case 10:
                            hex += "A";
                            break;
                        case 11:
                            hex += "B";
                            break;
                        case 12:
                            hex += "C";
                            break;
                        case 13:
                            hex += "D";
                            break;
                        case 14:
                            hex += "E";
                            break;
                        case 15:
                            hex += "F";
                            break;
                        default:
                            break;
                    }
                }
                hodnotaDec = 0;
                hodnota = 1;
                bin = bin.Remove(0, 4);
            }
            return hex;
        }
        public static string HexBin(string hex)
        {
            string bin = string.Empty;
            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '1':
                        bin += "0001";
                        break;
                    case '2':
                        bin += "0010";
                        break;
                    case '3':
                        bin += "0011";
                        break;
                    case '4':
                        bin += "0100";
                        break;
                    case '5':
                        bin += "0101";
                        break;
                    case '6':
                        bin += "0110";
                        break;
                    case '7':
                        bin += "0111";
                        break;
                    case '8':
                        bin += "1000";
                        break;
                    case '9':
                        bin += "1001";
                        break;
                    case 'A':
                        bin += "1010";
                        break;
                    case 'B':
                        bin += "1011";
                        break;
                    case 'C':
                        bin += "1100";
                        break;
                    case 'D':
                        bin += "1101";
                        break;
                    case 'E':
                        bin += "1110";
                        break;
                    case 'F':
                        bin += "1111";
                        break;
                    default:
                        break;
                }
            }

            return bin;
        }
    }
}
