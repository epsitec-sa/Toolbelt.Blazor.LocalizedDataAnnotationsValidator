﻿// This source code is fork from https://github.com/dotnet/corefx/blob/master/src/System.ComponentModel.Annotations/src/System/ComponentModel/DataAnnotations/ValidationAttributeStore.cs
// The .NET Foundation licenses the original file of this forked file to you under the MIT license.
// See the LICENSE file for the original file of this forked file: https://github.com/dotnet/corefx/blob/master/LICENSE.TXT

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Toolbelt.Blazor.Forms.Internals.ValidationAttributeStores
{
    internal class StoreItem
    {
        internal IEnumerable<ValidationAttribute> ValidationAttributes { get; }

        internal DisplayAttribute DisplayAttribute { get; }

        internal StoreItem(IEnumerable<Attribute> attributes)
        {
            this.ValidationAttributes = attributes.OfType<ValidationAttribute>();
            this.DisplayAttribute = attributes.OfType<DisplayAttribute>().SingleOrDefault();
        }
    }
}
