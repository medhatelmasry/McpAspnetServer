using System;
using System.ComponentModel;
using ModelContextProtocol.Server;

namespace McpWebServer.Tools;

[McpServerToolType]
public class MultiplyNumbersTool
{
    private readonly ILogger<MultiplyNumbersTool> _logger;
    public MultiplyNumbersTool(ILogger<MultiplyNumbersTool> logger)
    {
        _logger = logger;
    }

    [McpServerTool, Description("A tool that shows paramater usage by asking for two numbers and multiplying them together")]
    public string Multiply(
        [Description("First number")] int number1,
        [Description("Second number")] int number2
    )
    {
        var result = number1 * number2;
        _logger.LogInformation("******* Multiplication result: {result}", result);
        return $"Multiply Tool response: {result}";
    }
}
