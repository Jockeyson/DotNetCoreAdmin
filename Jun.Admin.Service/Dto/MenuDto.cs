﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jun.Admin.Service.Dto
{
    public class MenuDto
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int Number { get; set; }

        public string ParentID { get; set; }

        public string ParentName { get; set; }

        public string Remark { get; set; }

        public string CreateTime { get; set; }

        public MenuDto ParentMenu { get; set; }
    }
}
