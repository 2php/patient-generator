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
 * Date: 2016-2-27
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientGenerator.Persistence.Model
{
	public class Address
	{
		public Address()
		{
		}

		[Required]
		public AddressUse AddressUse { get; set; }

		/// <summary>
		/// The city of the patient's address.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// The country of the patient's address.
		/// </summary>
		public string Country { get; set; }

		[Required]
		public DateTime CreationTimestamp { get; set; }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("PersonId")]
		public virtual Person Person { get; set; }

		public int PersonId { get; set; }

		/// <summary>
		/// The State/Province of the patient's address.
		/// </summary>
		public string StateProvince { get; set; }

		/// <summary>
		/// The street address of the patient.
		/// </summary>
		public string StreetAddress { get; set; }

		/// <summary>
		/// The Zip/Postal Code of the patient's address.
		/// </summary>
		public string ZipPostalCode { get; set; }
	}
}