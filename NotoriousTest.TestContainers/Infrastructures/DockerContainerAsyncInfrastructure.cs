﻿using DotNet.Testcontainers.Containers;
using NotoriousTest.Common.Infrastructures.Async;

namespace NotoriousTest.TestContainers
{

    public abstract class DockerContainerAsyncInfrastructure<TContainer> : AsyncInfrastructure where TContainer : IContainer
    {
        protected DockerContainerAsyncInfrastructure(bool initialize = false) : base(initialize) { }

        protected TContainer Container { get; init; }

        public override async Task Destroy()
        {
            await Container.StopAsync();
        }

        public override async Task Initialize()
        {
            await Container.StartAsync();
        }
    }

    public abstract class ConfiguredDockerContainerAsyncInfrastructure<TContainer, TConfiguration> : AsyncConfiguredInfrastructure<TConfiguration>
        where TContainer : IContainer
        where TConfiguration : new()
    {

        protected TContainer Container { get; init; }
        protected ConfiguredDockerContainerAsyncInfrastructure(bool initialize = false) : base(initialize) { }


        public override async Task Destroy()
        {
            await Container.StopAsync();
        }

        public override async Task Initialize()
        {
            await Container.StartAsync();
        }
    }

    public abstract class ConfiguredDockerContainerAsyncInfrastructure<TContainer> : ConfiguredDockerContainerAsyncInfrastructure<TContainer, Dictionary<string, string>> where TContainer : IContainer
    {
    }
}
