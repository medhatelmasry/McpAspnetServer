using System;
using System.ComponentModel;
using ModelContextProtocol.Server;

namespace McpWebServer.Tools;

[McpServerToolType]
public class ReverseMessageTool
{
    [McpServerTool, Description("Echoes back message in reverse.")]
    public static string ReverseMessage(
        [Description("The message or string that will be reversed")] string message
    )
    {
        string reversedMessage = new string(message.ToCharArray().Reverse().ToArray());
        return $"ReverseMessageTool response: {reversedMessage}";
    }
}
