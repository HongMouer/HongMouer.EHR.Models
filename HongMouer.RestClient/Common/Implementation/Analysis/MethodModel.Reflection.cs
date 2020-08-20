using System;
using System.Reflection;

namespace  HongMouer.RestClient.Implementation.Analysis
{
    internal partial class MethodModel
    {
        public MethodInfo MethodInfo { get; }

        public MethodModel(MethodInfo methodInfo)
        {
            this.MethodInfo = methodInfo;
        }

        public bool IsDeclaredOn(TypeModel typeModel) => this.MethodInfo.DeclaringType == typeModel.Type;
    }
}