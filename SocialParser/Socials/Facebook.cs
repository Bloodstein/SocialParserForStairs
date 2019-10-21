using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialParser.Socials
{
    class Facebook : ISite
    {
        public string URL
        {
            get
            {
                return "https://facebook.com/";
            }
        }
    }
}
