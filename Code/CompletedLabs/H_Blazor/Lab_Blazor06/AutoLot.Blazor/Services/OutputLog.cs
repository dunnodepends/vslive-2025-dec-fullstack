// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor - OutputLog.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/08
// ==================================

namespace AutoLot.Blazor.Services;

public class OutputLog
{
    public List<string> Messages { get; } = [];
    public void LogMessage(string message) => Messages.Add(message);
}
