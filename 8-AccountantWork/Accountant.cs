using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AccountantWork
{
    public static class Accountant
    {
        public static bool AskForBonus(Positions a, int hours)
        {
            switch (a)
            {
                case Positions.Junior:
                    {
                        if (hours > (int)Positions.Junior)
                            return true;
                        else
                            return false;
                    }
                case Positions.Middle:
                    {
                        if (hours > (int)Positions.Middle)
                            return true;
                        else
                            return false;
                    }
                case Positions.Senior:
                    {
                        if (hours > (int)Positions.Senior)
                            return true;
                        else
                            return false;
                    }
                case Positions.TeamLead:
                    {
                        if (hours > (int)Positions.TeamLead)
                            return true;
                        else
                            return false;
                    }
                default:
                    return false;
            }
        }
    }
}
