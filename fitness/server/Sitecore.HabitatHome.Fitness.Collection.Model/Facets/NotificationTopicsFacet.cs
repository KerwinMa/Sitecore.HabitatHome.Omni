﻿using Sitecore.XConnect;
using System;
using System.Collections.Generic;

namespace Sitecore.HabitatHome.Fitness.Collection.Model.Facets
{
    [Serializable]
    public class NotificationTopicsFacet : Facet
    {
        public static string DefaultKey = "NotificationTopics";

        public List<string> Values { get; set; }
    }
}