using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ModelContextProtocol.Server;

namespace McpWebServer.Tools;

[McpServerToolType]
public class GreetingTool
{
    public GreetingTool()
    {
    }
    [McpServerTool, Description("Says Hello to a user")]
    public static string Echo([Description("The user name")] string username)
    {
        return $"GreetingTool response: Hello {username}";
    }
}
