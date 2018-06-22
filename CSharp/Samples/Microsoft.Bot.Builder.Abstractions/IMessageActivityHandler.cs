﻿namespace Microsoft.Bot.Builder.Abstractions
{
    using System.Threading.Tasks;

    public interface IMessageActivityHandler
    {
        Task HandleMessageAsync(ITurnContext turnContext);
    }
}