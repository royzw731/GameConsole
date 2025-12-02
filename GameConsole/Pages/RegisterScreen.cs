using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class RegisterScreen : Screen
    {
        public RegisterScreen() : base("REGISTER PAGE")
        {
        }

        public override void Show()
        {
            base.Show();

            CenterText("Enter Your Desired Details");
        }
    }
}
