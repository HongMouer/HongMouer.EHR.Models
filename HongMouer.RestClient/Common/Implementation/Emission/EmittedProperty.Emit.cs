using System.Reflection.Emit;
using  HongMouer.RestClient.Implementation.Analysis;

namespace  HongMouer.RestClient.Implementation.Emission
{
    internal partial class EmittedProperty
    {
        public FieldBuilder FieldBuilder { get; }
     
        public EmittedProperty(PropertyModel propertyModel, FieldBuilder fieldBuilder)
        {
            this.PropertyModel = propertyModel;
            this.FieldBuilder = fieldBuilder;
        }
    }
}