﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
namespace SimpleIdServer.IdServer.ExternalEvents
{
    public class RemoveUserSuccessEvent : IExternalEvent
    {
        public string EventName => nameof(RemoveUserSuccessEvent);
        public string Realm { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
