public interface IValueYield {
    object Value();
}

public interface IValueYield<TReturn> {
    TReturn TRetValue();
}

