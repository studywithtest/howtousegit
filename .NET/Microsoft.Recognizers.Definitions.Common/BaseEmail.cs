//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Base-Email.yaml
//     - Language: NULL
//     - ClassName: BaseEmail
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions
{
	using System;
	using System.Collections.Generic;

	public static class BaseEmail
	{
		public const string EmailRegex = @"(([-a-zA-Z0-9_\+\.]+)@([-a-zA-Z\d\.]+)\.([a-zA-Z\.]{2,6}))";
		public const string IPv4Regex = @"(?<ipv4>(\d{1,3}\.){3}\d{1,3})";
		public const string NormalSuffixRegex = @"(([0-9A-Za-z][-]*[0-9A-Za-z]*\.)+(?<tld>[a-zA-Z][\-a-zA-Z]{0,22}[a-zA-Z]))";
		public const string EmailPrefix = @"(?("")("".+?(?<!\\)"")|(([0-9A-Za-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^\{\}\|~\w])*)(?<=[0-9A-Za-z])))";
		public static readonly string EmailSuffix = $@"(?(\[)(\[{IPv4Regex}\])|{NormalSuffixRegex})";
		public static readonly string EmailRegex2 = $@"(({EmailPrefix})@({EmailSuffix}))";
	}
}