using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapMeeDesktop.MVC.Models;

namespace TapMeeDesktop.MVC.Controllers
{
    public interface InterfaceSignUp
    {
        public bool emailExist(string s);
        public bool usernameExist(string s);
        public bool register(User model);
    }
}
