﻿/*
 * Copyright 2016-2017 Mohawk College of Applied Arts and Technology
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

using System.Xml.Serialization;

namespace PatientGenerator.HL7v2.Configuration
{
	/// <summary>
	/// Reprsents a low level endpoint.
	/// </summary>
	[XmlRoot("endpoint")]
	public class LlpEndpoint
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LlpEndpoint"/> class.
		/// </summary>
		public LlpEndpoint()
		{
		}

		/// <summary>
		/// Gets or sets the address.
		/// </summary>
		/// <value>The address.</value>
		[XmlAttribute("address")]
		public string Address { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		[XmlAttribute("name")]
		public string Name { get; set; }

		/// <summary>
		/// Returns the name and address of the endpoint.
		/// </summary>
		/// <returns>Returns the name and address of the endpoint.</returns>
		public override string ToString()
		{
			return Name + " " + Address;
		}
	}
}