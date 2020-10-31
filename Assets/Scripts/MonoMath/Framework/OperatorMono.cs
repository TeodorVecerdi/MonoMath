using System;

/// <summary>
/// Unity serialized version of the generic OperatorMono&lt;TValue, TReturn&gt;.
/// <br/>Use this for inspector references to classes that derive from OperatorMono generics.
/// </summary>
public abstract class OperatorMono : ValueYieldMono { }

/// <summary>
/// MonoBehaviour that performs a unary operation on an object of type TValue and returns an object of type TReturn.
/// <br/>For a Unity inspector serialized version of this class use <see cref="OperatorMono"/>.
/// </summary>
/// <typeparam name="TValue">Parameter type</typeparam>
/// <typeparam name="TReturn">Return type</typeparam>
public abstract class OperatorMono<TValue, TReturn> : OperatorMono, IOperator<TValue, TReturn> {
    public abstract TValue TVal { get; }
    public abstract TReturn Calc(TValue tVal);

    public TReturn TRetValue() {
        return Calc(TVal);
    }

    public override object Value() {
        return TRetValue();
    }
}

/// <summary>
/// MonoBehaviour that performs a binary operation using an object of type TValue1 and an object of TValue2 and returns an object of type TReturn.
/// <br/>For a Unity inspector serialized version of this class use <see cref="OperatorMono"/>.
/// </summary>
/// <typeparam name="TValue1">First parameter type</typeparam>
/// <typeparam name="TValue2">Second parameter type</typeparam>
/// <typeparam name="TReturn">Return type</typeparam>
public abstract class OperatorMono<TValue1, TValue2, TReturn> : OperatorMono, IOperator<TValue1, TValue2, TReturn> {
    public abstract TValue1 TVal1 { get; }
    public abstract TValue2 TVal2 { get; }
    public abstract TReturn Calc(TValue1 tVal1, TValue2 tVal2);

    public TReturn TRetValue() {
        return Calc(TVal1, TVal2);
    }

    public override object Value() {
        return TRetValue();
    }
}

/// <summary>
/// MonoBehaviour that performs an operation using 3 objects of type TValue1, TValue2, and TValue3 and returns an object of type TReturn.
/// <br/>For a Unity inspector serialized version of this class use <see cref="OperatorMono"/>.
/// </summary>
/// <typeparam name="TValue1">First parameter type</typeparam>
/// <typeparam name="TValue2">Second parameter type</typeparam>
/// <typeparam name="TValue3">Third parameter type</typeparam>
/// <typeparam name="TReturn">Return type</typeparam>
public abstract class OperatorMono<TValue1, TValue2, TValue3, TReturn> : OperatorMono, IOperator<TValue1, TValue2, TValue3, TReturn> {
    public abstract TValue1 TVal1 { get; }
    public abstract TValue2 TVal2 { get; }
    public abstract TValue3 TVal3 { get; }
    public abstract TReturn Calc(TValue1 tVal1, TValue2 tVal2, TValue3 tVal3);

    public TReturn TRetValue() {
        return Calc(TVal1, TVal2, TVal3);
    }

    public override object Value() {
        return TRetValue();
    }
}