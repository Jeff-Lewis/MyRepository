﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSearch.Data;

namespace XSearch.DAL
{
    public class ObjMappingMap : EntityTypeConfiguration<ObjMapping>
    {
        public ObjMappingMap()
        {
            HasKey(t => t.Id);
        }
    }
}