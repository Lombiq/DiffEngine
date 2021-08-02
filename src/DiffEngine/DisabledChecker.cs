using System;
using DiffEngine;

static class DisabledChecker
{
    public static bool IsDisable()
    {
        var variable = EnvironmentEx.GetEnvironmentVariable(DiffEnvironmentKeys.Disabled);
        return string.Equals(variable, "true", StringComparison.OrdinalIgnoreCase) ||
               BuildServerDetector.Detected ||
               ContinuousTestingDetector.Detected;
    }
}