using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Core
{
    abstract public class BaseModel
    {
        abstract public void CharInfo(string name);

        abstract public void Battle();

        abstract public void Move();

        abstract public void Farm();

        abstract public void Speak();

        abstract public void Heal();
    }


}
