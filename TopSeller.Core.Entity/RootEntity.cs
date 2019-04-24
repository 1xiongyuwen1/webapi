﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace TopSeller.Core.Entity
{
   public class RootEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
    }
}
