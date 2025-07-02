using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ModelContextProtocol.Server;

namespace McpWebServer;

[McpServerToolType]
public class GreetingTool
{
    public GreetingTool()
    {
    }
    [McpServerTool, Description("Says Hello to a user")]
    public static string Echo(string username)
    {
        return $"Hello {username}, from GreetingTool";
    }
}
