﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppTemplateConversionUnitUpdateDto
    {

        public int Id { get; set; }
        public int AppUnitIdSince { get; set; }
        public int AppUnitIdUntil { get; set; }
        public int AppVariableId { get; set; }
        public string Description { get; set; }
        public decimal? Value { get; set; }
        public string Formula { get; set; }
        public string FormulaValue { get; set; }
        public bool? SumValue { get; set; }
        public int? OrderCalculate { get; set; }
        public string Code { get; set; }

    }
}
