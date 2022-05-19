﻿using ProjectBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Aplication.Map
{
    public static class EnumMap
    {
		public static operationTypeModel Map(this string operationType)
		{

			if (operationType == "buy")
			{
				return operationTypeModel.buy;
			}
			else if (operationType == "sell")
			{
				return operationTypeModel.sell;
			}
			else throw new InvalidOperationException($"Cannot convert type {nameof(operationTypeModel)} to buy or sell");

		}
	}
}
