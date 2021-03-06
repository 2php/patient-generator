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
 * Date: 2016-3-12
 */

using System.Xml.Serialization;

namespace PatientGenerator.Randomizer.Common
{
	/// <summary>
	/// Represents a given name and gender pair.
	/// </summary>
	public class GivenNameGenderPair
	{
		/// <summary>
		/// Gets or sets the gender code.
		/// </summary>
		/// <value>The gender code.</value>
		[XmlAttribute("gender")]
		public string GenderCode { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		[XmlText]
		public string Name { get; set; }
	}
}