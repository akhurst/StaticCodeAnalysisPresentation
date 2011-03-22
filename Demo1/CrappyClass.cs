using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1
{
    public class CrappyClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", 
            "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string",
            Justification = "Im doing a demo.")]
        public bool MethodWithTerribleComplexity(string welcomeString)
        {
            try
            {

                if (welcomeString[0] == 'h' || welcomeString[0] == 'H')
                    if (welcomeString[1] == 'e' || welcomeString[1] == 'E' || welcomeString[1] == '3')
                        if (welcomeString[2] == 'l' || welcomeString[2] == 'L')
                            if (welcomeString[3] == 'l' || welcomeString[3] == 'L')
                                if (welcomeString[4] == 'o' || welcomeString[4] == 'O' || welcomeString[4] == '0')
                                    if (welcomeString[5] == ' ')
                                        if (welcomeString[6] == 'w' || welcomeString[6] == 'W')
                                            if (welcomeString[7] == 'o' || welcomeString[7] == 'O' || welcomeString[7] == '0' || welcomeString[7] == 'U' || welcomeString[7] == 'u')
                                                if (welcomeString[8] == 'r' || welcomeString[8] == 'R')
                                                    if (welcomeString[9] == 'l' || welcomeString[9] == 'L')
                                                        if (welcomeString[10] == 'd' || welcomeString[10] == 'D')
                                                            return true;
                                                        else
                                                            return false;
                                                    else
                                                        return false;
                                                else
                                                    return false;
                                            else
                                                return false;
                                        else
                                            return false;
                                    else
                                        return false;
                                else
                                    return false;
                            else
                                return false;
                        else
                            return false;
                    else
                        return false;
                else
                    return false;
            }
            catch (IndexOutOfRangeException e)
            {
                throw e;
            }
        }
    }
}
