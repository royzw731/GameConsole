using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class UserMenu : MenuScreen
    {
        public UserMenu():base("WELCOME TO USER MENU") {

            base.Add("ChangeNameScreen",new MainMenu());
        
        
        }
    
    
    
   


    }
}
