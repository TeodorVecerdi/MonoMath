public interface IOperator<TValue, TReturn> : IValueYield<TReturn> {
    TValue TVal { get; }
    TReturn Calc(TValue tVal);
}

public interface IOperator<TValue1, TValue2, TReturn>  : IValueYield<TReturn> {
    TValue1 TVal1 { get; }
    TValue2 TVal2 { get; }
    TReturn Calc(TValue1 tVal1, TValue2 tVal2);
}

public interface IOperator<TValue1, TValue2, TValue3, TReturn> : IValueYield<TReturn> {
    TValue1 TVal1 { get; }
    TValue2 TVal2 { get; }
    TValue3 TVal3 { get; }
    TReturn Calc(TValue1 tVal1, TValue2 tVal2, TValue3 tVal3);
}