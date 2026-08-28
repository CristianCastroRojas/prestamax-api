using Prestamax.Api.Common.Responses;
using Prestamax.Application.Common.Exceptions;

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

            await HandleExceptionAsync(
                context,
                exception,
                traceId);
        }
    }

    /// <summary>
    /// Genera la respuesta estándar para una excepción no controlada.
    /// </summary>
    private static async Task HandleExceptionAsync(
        HttpContext context,
        Exception exception,
        string traceId)
    {
        var (statusCode, errorResponse) = exception switch
        {
            NotFoundException notFoundException =>
                (
                    StatusCodes.Status404NotFound,
                    new ErrorResponse(
                        notFoundException.Code,
                        notFoundException.Message,
                        traceId)
                ),

            ConfigurationException configurationException =>
                (
                    StatusCodes.Status500InternalServerError,
                    new ErrorResponse(
                        configurationException.Code,
                        configurationException.Message,
                        traceId)
                ),

            _ =>
                (
                    StatusCodes.Status500InternalServerError,
                    new ErrorResponse(
                        "INTERNAL_ERROR",
                        "Ocurrió un error interno.",
                        traceId)
                )
        };

        context.Response.StatusCode = statusCode;
        context.Response.ContentType = "application/json";

        await context.Response.WriteAsJsonAsync(
            errorResponse);
    }
}