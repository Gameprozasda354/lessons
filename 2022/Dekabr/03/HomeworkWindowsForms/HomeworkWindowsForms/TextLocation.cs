using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWindowsForms
{
    public static class TextLocation
    {
        private static int _topPosition = 0;
        public static bool IsFirstMessage = true;
        public static int TopPosition {
            get
            {
                if (IsFirstMessage)
                {
                    IsFirstMessage = false;
                    return 0;
                }
                _topPosition += 35;
                return _topPosition;
            }
            private set
            {

            }
        } 
    }
}
