using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCNotifier
{
    static class PillsInfoClass
    {
        private static string _text;
        public static string Text { get { return _text; } set { _text = value; } }
        public static void SetPill(string PillName)
        {
<<<<<<< HEAD
            Text = $"You have to consume {PillName}";
=======
            Text = $"You need to consume a thing called {PillName}"; 
>>>>>>> fbb046831dd3d9248d5e68ac0287e4fdea22f602
        }  
    }
}
