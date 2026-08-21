using System.Diagnostics;

namespace Prestamax.Api.Common.Middleware;

/// <summary>
/// Registra información relacionada con las solicitudes HTTP.
/// </summary>
public sealed class RequestLoggingMiddleware(
    RequestDelegate next,
    ILogger<RequestLoggingMiddleware> logger)
{
    /// <summary>
    /// Procesa la solicitud HTTP y registra su resultado y duración.
    /// </summary>
    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();
        var traceId = context.TraceIdentifier;

        logger.LogInformation(
            "Request started. TraceId: {TraceId}, Method: {Method}, Path: {Path}",
            traceId,
            context.Request.Method,
            context.Request.Path);

        try
        {
            await next(context);
        }
        finally
        {
            stopwatch.Stop();

            logger.LogInformation(
                "Request completed. TraceId: {TraceId}, Method: {Method}, Path: {Path}, StatusCode: {StatusCode}, DurationMs: {DurationMs}",
                traceId,
                context.Request.Method,
                context.Request.Path,
                context.Response.StatusCode,
                stopwatch.ElapsedMilliseconds);
        }
    }
}