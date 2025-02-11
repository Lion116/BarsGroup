﻿namespace ConsoleApp4;
/// <summary>
/// Предоставляет возможность обработать запрос.
/// </summary>
public interface IRequestHandler
{
    /// <summary>
    /// Обработать запрос.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    /// <param name="arguments">Аргументы запроса.</param>
    /// <returns>Результат выполнения запроса.</returns>
    string HandleRequest(string message, string[] arguments);
}


/// <summary>
/// Тестовый обработчик запросов.
/// </summary>
public class DummyRequestHandler : IRequestHandler
{
    /// <inheritdoc />
    public string HandleRequest(string message, string[] arguments)
    {
        // Притворяемся, что делаем что то.
        Thread.Sleep(10_000);
        if (message.Contains("упади"))
        {
            throw new Exception("Я упал, как сам просил");
        }

        return Guid.NewGuid().ToString("D");
    }
}