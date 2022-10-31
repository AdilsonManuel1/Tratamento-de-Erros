[System.Serializable]
public class MyClassExceptionException : Exception
{
    public MyClassExceptionException() { }
    public MyClassExceptionException(string message) : base(message) { }
    public MyClassExceptionException(string message, System.Exception inner) : base(message, inner) { }
    protected MyClassExceptionException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    public string? MyPropy { get; set; }
} 
