using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineService
{
    enum Type
    {
        VIPUserType,
        NormalUserType
    }
    public class User
    {
        private string _name { get; set; }
        private string _userID { get; set; }        
        private Type _typeUser = Type.NormalUserType;
        private UserType _type = new NormalUserType(50);

        public User(string Name, string UserID)
        {
            _name = Name;
            _userID = UserID;
        }
        public bool isCanDownload()
        {
            return _type.isCanDownload();
        }
        public bool AllowConection(uint Request)
        {
            return _type.AllowConection(Request);
        }            
        public void Upgrade()
        {
            if (_typeUser == Type.NormalUserType)
            {
                _typeUser = Type.VIPUserType;
                _type = new VIPUserType();
            }
        }
        public void Downgrade()
        {
            if (_typeUser == Type.VIPUserType)
            {
                _typeUser = Type.NormalUserType;
                _type = new NormalUserType(50);
            }
        }
    }
}