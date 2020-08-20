using System;
using System.Reflection;

namespace  HongMouer.RestClient.Implementation.Analysis
{
    internal partial class PropertyModel
    {
        public PropertyInfo PropertyInfo { get; }

        public string Name => this.PropertyInfo.Name;

        public bool IsNullable => !this.PropertyInfo.PropertyType.GetTypeInfo().IsValueType ||
            Nullable.GetUnderlyingType(this.PropertyInfo.PropertyType) != null;

        public PropertyModel(PropertyInfo propertyInfo)
        {
            this.PropertyInfo = propertyInfo;
        }

        public bool IsDeclaredOn(TypeModel typeModel) => this.PropertyInfo.DeclaringType == typeModel.Type;
    }
}