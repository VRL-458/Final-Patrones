﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
