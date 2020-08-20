using System.Reflection;

namespace  HongMouer.RestClient.Implementation.Analysis
{
    internal partial class ParameterModel
    {
        public ParameterInfo ParameterInfo { get; }

        public string Name => this.ParameterInfo.Name;

        public ParameterModel(ParameterInfo parameterInfo)
        {
            this.ParameterInfo = parameterInfo;
        }
    }
}