﻿using System;

namespace EF.CommonComponents
{
    public class ExistentRegException : Exception
    {
        public ExistentRegException() { }

        public override string Message => "El ID indicado ya se encuentra en uso";

    }
}
