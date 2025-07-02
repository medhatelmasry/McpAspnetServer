var builder = WebApplication.CreateBuilder(args);

// Register MCP server and discover tools from the current assembly
builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithToolsFromAssembly();

var app = builder.Build();

// no need
// app.MapGet("/", () => "Hello World!");

// Add MCP middleware
app.MapMcp();

app.Run();

// http://localhost:5010/sse
