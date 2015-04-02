﻿using StructureMap;

namespace Service.IoC
{
    public static class IoCFactory
    {
        private static Container container;

        private static readonly object @lock = new object();

        public static Container GetContainer()
        {
            if (container == null)
                lock (@lock)
                    if (container == null)
                        container = new Container(new ControllerRegistry());

            return container;
        }
    }
}