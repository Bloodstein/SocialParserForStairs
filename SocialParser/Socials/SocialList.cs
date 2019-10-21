using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialParser.Socials
{
    class SocialList
    {
        readonly ISite[] Sites = new ISite[] {
            new VK(),
            new OK(),
            new Facebook()
        };
    }
}
