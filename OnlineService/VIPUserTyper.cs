using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineService
{
    public class VIPUserType : UserType
    {
        public VIPUserType()
        {
            _maxDownload = -1;
            _usedDownload = 0;
        }
        public override bool isCanDownload()
        {
            return true;
        }
        public override bool AllowConection(uint Request)
        {
            if (Request <= 20)
                return true;
            return false;
        }
    }
}