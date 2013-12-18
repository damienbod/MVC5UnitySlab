namespace MVC5UnitySlab.Business.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class UnityIoCContainerControlledAttribute : System.Attribute
    {
        public double version;

        public UnityIoCContainerControlledAttribute()
        {
            version = 1.0;
        }
    }
}
