using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    interface IMathPerformedService
    {
        void OnMathPerformed(object sender, MathPerformedEventArgs args);
    }
}
