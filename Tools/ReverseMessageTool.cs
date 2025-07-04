using System;
using System.ComponentModel;
using ModelContextProtocol.Server;

namespace McpWebServer.Tools;

[McpServerToolType]
public class ReverseMessageTool
{
    // use Logger if needed
    private readonly ILogger<ReverseMessageTool> _logger;
    public ReverseMessageTool(ILogger<ReverseMessageTool> logger)
    {
        _logger = logger;
    }

    [McpServerTool, Description("Echoes back message in reverse.")]
    public string ReverseMessage(
        [Description("The message or string that will be reversed")] string message
    )
    {
        string reversedMessage = new string(message.ToCharArray().Reverse().ToArray());
        _logger.LogInformation("******* Reversed message: {ReversedMessage}", reversedMessage);
        return $"ReverseMessage Tool response: {reversedMessage}";
    }
}
