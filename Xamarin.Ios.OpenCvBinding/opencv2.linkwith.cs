using System;
using ObjCRuntime;

[assembly: LinkWith ("opencv2.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator
    | LinkTarget.Arm64 | LinkTarget.Simulator64
    , ForceLoad = true)]
