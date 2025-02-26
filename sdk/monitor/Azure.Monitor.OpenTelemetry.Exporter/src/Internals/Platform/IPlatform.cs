﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Runtime.InteropServices;

namespace Azure.Monitor.OpenTelemetry.Exporter.Internals.Platform
{
    internal interface IPlatform
    {
        /// <summary>
        /// Returns null if the key is not found.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string? GetEnvironmentVariable(string name);

        public IDictionary GetEnvironmentVariables();

        public bool IsOSPlatform(OSPlatform osPlatform);

        public string GetOSPlatformName();

        public bool CreateDirectory(string path);
    }
}
