using System;
using System.ComponentModel;
using ModelContextProtocol.Server;

namespace McpWebServer.Tools;

[McpServerToolType]
public class MultiplyNumbersTool
{
    [McpServerTool, Description("A tool that shows paramater usage by asking for two numbers and multiplying them together")]
    public static string Multiply(
        [Description("The first number")] double number1,
        [Description("The second number")] double number2
    )
    {
        var result = number1 * number2;
        return $"MultiplyNumbersTool response: {result}";
    }
}
