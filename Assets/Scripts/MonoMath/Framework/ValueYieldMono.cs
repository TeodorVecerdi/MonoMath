/// <summary>
/// Unity serialized version of the generic ValueYieldMono&lt;TReturn&gt;.
/// <br/>Use this for inspector references to classes that derive from ValueYieldMono generics.
/// </summary>
public abstract class ValueYieldMono : UnityEngine.MonoBehaviour, IValueYield {
    public abstract object Value();
}

/// <summary>
/// MonoBehaviour that returns a custom value based on parameters.
/// <br/>For a Unity inspector serialized version of this class use <see cref="ValueYieldMono"/>.
/// </summary>
/// <typeparam name="TReturn">Return type of MonoBehaviour</typeparam>
public abstract class ValueYieldMono<TReturn> : ValueYieldMono, IValueYield<TReturn> {
    
    /// <summary>
    /// Returns an object of type TReturn. This is the value that other classes will use when referencing this ValueYieldMono.
    /// </summary>
    public abstract TReturn TRetValue();
    public override object Value() {
        return TRetValue();
    }
}