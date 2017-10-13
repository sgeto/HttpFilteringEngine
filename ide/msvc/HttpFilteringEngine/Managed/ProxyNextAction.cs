﻿/*
* Copyright © 2017 Jesse Nicholson
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace HttpFilteringEngine.Managed
{
    public enum ProxyNextAction
    {
        AllowAndIgnoreContent = 0,
        AllowButRequestContentInspection = 1,
        DropConnection = 2,
        AllowAndIgnoreContentAndResponse = 3
    };
}
