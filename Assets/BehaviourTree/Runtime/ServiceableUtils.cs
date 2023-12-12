using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using MbsCore.Extensions.Runtime;

namespace MbsCore.BehaviourTree.Runtime
{
    public static class ServiceableUtils
    {
        public static bool TryGetServiceable<T>(this IEnumerable<T> source, Type type, out T serviceable)
                where T : IServiceable
        {
            serviceable = default;
            int smallestWeight = int.MaxValue;
            bool found = false;
            foreach (var item in source)
            {
                if (!item.ServicedType.IsAssignableFrom(type))
                {
                    continue;
                }

                int weight = item.ServicedType.Comparison(type);
                if (weight <= smallestWeight)
                {
                    smallestWeight = weight;
                    serviceable = item;
                    found = true;
                }
            }

            return found;
        }
    }
}