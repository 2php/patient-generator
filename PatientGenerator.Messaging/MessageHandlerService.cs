﻿/*
 * Copyright 2016-2016 Mohawk College of Applied Arts and Technology
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: Nityan
 * Date: 2016-2-15
 */
using MARC.HI.EHRS.SVC.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientGenerator.Messaging
{
	public class MessageHandlerService : IMessageHandlerService
	{
		private IServiceProvider context;

		public IServiceProvider Context
		{
			get
			{
				return this.context;
			}

			set
			{
				this.context = value;
			}
		}

		public bool Start()
		{
			Trace.TraceInformation("Message handler started");
			return true;
		}

		public bool Stop()
		{
			Trace.TraceInformation("Message handler stopped");
			return true;
		}
	}
}