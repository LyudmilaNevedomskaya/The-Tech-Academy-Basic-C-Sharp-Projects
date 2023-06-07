using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Use polymorphism to create an object of type IQuittable and call the Quit() method on it
    interface IQuittable
    {
        void Quit(Person person);
    }
}
