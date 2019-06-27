using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using Diary.CQRS.CommandHandlers;
using Diary.CQRS.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Diary.CQRS.Utils
{
    public class StructureMapCommandHandlerFactory : ICommandHandlerFactory
    {
        /// <summary>
        /// 获取相对应的ICommandHandler实现类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ICommandHandler<T> GetHandler<T>() where T : Command
        {
            var handlers = GetHandlerTypes<T>().ToList();
            var servies = new ServiceCollection();
            var provider = servies.BuildServiceProvider();
            var t = typeof(T);
            var test = provider.GetService(t);
            return handlers.Select(handler =>
            {
                var d = provider.GetService(handler);
                return (ICommandHandler<T>)d;
            }).FirstOrDefault();
            // var cmdHandler = handlers.Select(handler => ).FirstOrDefault();
            // var cmdHandler = handlers.Select(handler =>
            //     (ICommandHandler<T>)ObjectFactory.GetInstance(handler)).FirstOrDefault();

            // return cmdHandler;
            // return null;
        }

        private IEnumerable<Type> GetHandlerTypes<T>() where T : Command
        {
            var handlers = typeof(ICommandHandler<>).Assembly.GetExportedTypes()
                .Where(x => x.GetInterfaces()
                    .Any(a => a.IsGenericType && a.GetGenericTypeDefinition() == typeof(ICommandHandler<>)))
                    .Where(h => h.GetInterfaces()
                        .Any(ii => ii.GetGenericArguments()
                            .Any(aa => aa == typeof(T)))).ToList();
            return handlers;
        }

    }
}