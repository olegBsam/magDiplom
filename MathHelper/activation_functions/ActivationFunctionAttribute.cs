using System;

namespace MathHelper.Function
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ActivationFunctionAttribute : Attribute
    {
        public string functionName;
        public string labelName;

        public ActivationFunctionAttribute(string functionName, string labelName)
        {
            this.labelName = labelName;
            this.functionName = functionName;
        }
    }
}
