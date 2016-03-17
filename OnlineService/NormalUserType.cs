using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineService
{
    public class NormalUserType : UserType
    {
        public NormalUserType(int MaxDownload)
        {
            _maxDownload = MaxDownload;
            _usedDownload = 0;
        }
        public override bool isCanDownload()
        {
            if ( _usedDownload < _maxDownload)
            {
                _usedDownload++;
                return true;
            }
            return false;
        }
        public override bool AllowConection(uint Request)
        {
            if (Request <= 1)
                return true;
            return false;
        }
    }
}