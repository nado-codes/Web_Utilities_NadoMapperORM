﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NadoMapper.SqlProvider;

namespace NadoMapper.Conventions
{
    public class IgnoreDateAddedDuringUpdatePropertyConvention : PropertyConventionBase
    {
        public IgnoreDateAddedDuringUpdatePropertyConvention()
        {
            PropertyName = "DateAdded";
            CRUDType = CRUDType.Update;
        }
    }
}