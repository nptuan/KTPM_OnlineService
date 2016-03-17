using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineService
{
    public abstract class UserType
    {
        protected int _maxDownload { get; set; }
        protected int _usedDownload { get; set; }

        public virtual bool isCanDownload()
        {
            return false;
        }
        public virtual bool AllowConection(uint Request)
        {
            return false;
        }
    }
}