﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.Abstract
{
    public abstract class AEntity
    {
        [Key]
        public int ID { get; set; }
    }
}
