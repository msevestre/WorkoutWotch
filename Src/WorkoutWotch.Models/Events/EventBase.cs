﻿namespace WorkoutWotch.Models.Events
{
    using WorkoutWotch.Utility;

    public abstract class EventBase : IEvent
    {
        private readonly ExecutionContext executionContext;

        protected EventBase(ExecutionContext executionContext)
        {
            Ensure.ArgumentNotNull(executionContext, nameof(executionContext));
            this.executionContext = executionContext;
        }

        public ExecutionContext ExecutionContext => this.executionContext;
    }
}