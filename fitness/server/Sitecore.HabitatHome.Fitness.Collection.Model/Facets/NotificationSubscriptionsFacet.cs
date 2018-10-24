﻿using Sitecore.XConnect;
using System;
using System.Collections.Generic;

namespace Sitecore.HabitatHome.Fitness.Collection.Model.Facets
{
    [Serializable]
    public class NotificationSubscriptionsFacet : Facet
    {
        public static string DefaultKey = "NotificationSubscriptions";

        public List<string> Values { get; set; }
    }
}