using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapMeeDesktop.MVC.Controllers
{
    public interface InterfaceSignIn
    {
        public bool login(string email, string password);
    }
}
