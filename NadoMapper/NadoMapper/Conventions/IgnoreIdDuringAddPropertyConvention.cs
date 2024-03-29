﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NadoMapper.SqlProvider;

namespace NadoMapper.Conventions
{
    public class IgnoreIdDuringAddPropertyConvention : PropertyConventionBase
    {
        public IgnoreIdDuringAddPropertyConvention()
        {
            PropertyName = "Id";
            CRUDType = CRUDType.Create;
        }
    }
}