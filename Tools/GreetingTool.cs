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
    private readonly ILogger<GreetingTool> _logger;
    public GreetingTool(ILogger<GreetingTool> logger)
    {
        _logger = logger;
    }

    [McpServerTool, Description("Says Hello to a user")]
    public string Echo([Description("The user name")] string username)
    {
        var result = $"Hello {username}";
        _logger.LogInformation("******* Greeting result: {result}", result);
        return $"Echo Tool response: {result}";
    }
}
