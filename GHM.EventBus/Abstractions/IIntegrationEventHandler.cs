﻿using System.Threading.Tasks;
using GHM.EventBus.Events;

namespace GHM.EventBus.Abstractions
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
        where TIntegrationEvent : IntegrationEvent
    {
        //Task Handle(TIntegrationEvent @event);

        Task Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandler
    {
    }
}
