﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Device.Gpio;
using System.Threading;
using Iot.Device.LiquidLevel;

using LiquidLevelSwitch sensor = new(23, PinValue.Low);
while (true)
{
    // read liquid level switch
    Console.WriteLine($"Detected: {sensor.IsLiquidPresent()}");
    Console.WriteLine();

    Thread.Sleep(1000);
}
