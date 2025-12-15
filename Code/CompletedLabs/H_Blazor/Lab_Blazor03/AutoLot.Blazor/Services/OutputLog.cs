// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - OutputLog.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Services;

public class OutputLog
{
    public List<string> Messages { get; } = [];
    public void LogMessage(string message) => Messages.Add(message);
}
