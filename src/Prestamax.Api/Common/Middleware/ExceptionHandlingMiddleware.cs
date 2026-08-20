using System.Text.Json;
using Prestamax.Api.Common.Responses;

namespace Prestamax.Api.Common.Middleware;

/// <summary>
/// Gestiona las excepciones no controladas durante el procesamiento de solicitudes HTTP.
/// </summary>
public sealed class ExceptionHandlingMiddleware(
    RequestDelegate next,
    ILogger<ExceptionHandlingMiddleware> logger)
{
    /// <summary>
    /// Procesa la solicitud HTTP y captura las excepciones no controladas.
    /// </summary>
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            var traceId = context.TraceIdentifier;

            logger.LogError(
                exception,
                "Unhandled exception. TraceId: {TraceId}",
                traceId);

            await HandleExceptionAsync(context, traceId);
        }
    }

    /// <summary>
    /// Genera la respuesta estándar para una excepción no controlada.
    /// </summary>
    private static async Task HandleExceptionAsync(
        HttpContext context,
        string traceId)
    {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Response.ContentType = "application/json";

        var response = new ErrorResponse(
            "INTERNAL_ERROR",
            "Ocurrió un error interno.",
            traceId);

        await context.Response.WriteAsJsonAsync(response);
    }
}