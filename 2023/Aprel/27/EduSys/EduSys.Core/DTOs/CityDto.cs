﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Core.DTOs
{
    public class CityDto : BaseDto
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
