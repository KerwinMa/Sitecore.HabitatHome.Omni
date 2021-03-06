﻿using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;

namespace Sitecore.HabitatHome.Fitness.Personalization.Services
{
    public interface IEventDataService
    {
        IEnumerable<Item> GetAll(Database database);
    }
}