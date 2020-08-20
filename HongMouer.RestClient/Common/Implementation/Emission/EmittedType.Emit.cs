using System;

namespace  HongMouer.RestClient.Implementation.Emission
{
    internal class EmittedType
    {
        public Type Type { get; }

        public EmittedType(Type type) => this.Type = type;
    }
}