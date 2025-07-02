using System.Net;
using System.Text.Json;
using TaskTracker.BLL.Dto;

namespace TaskTracker.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (EntityNotFoundException ex)
        {
            await HandleExceptionAsync(
                context,
                ex.Message,
                exception: ex,
                HttpStatusCode.NotFound);
        }
        catch (InvalidRequestException ex)
        {
            await HandleExceptionAsync(
                context,
                ex.Message,
                exception: ex,
                HttpStatusCode.BadRequest);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(
                context,
                "InternalError",
                exception: ex,
                HttpStatusCode.InternalServerError);
        }
        
    }

    private async Task HandleExceptionAsync(
        HttpContext context,
        string message,
        Exception exception,
        HttpStatusCode statusCode)
    {
        _logger.LogError(exception, message);
        context.Response.StatusCode = (int)statusCode;
        context.Response.ContentType = "application/json";

        ErrorDto errorDto = new()
        {
            Message = message,
            StatusCode = (int)statusCode
        };
        
        string result = JsonSerializer.Serialize(errorDto);
        
        await context.Response.WriteAsync(result);
    }
}