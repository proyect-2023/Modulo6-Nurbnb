﻿using Restaurant.SharedKernel.Core;

namespace Restaurant.SharedKernel.Rules;

public class StringNotNullOrEmptyRule : IBussinessRule
{
    private readonly string _value;

    public StringNotNullOrEmptyRule(string value)
    {
        _value = value;
    }

    public string Message => "string cannot be null";

    public bool IsValid()
    {
        return !string.IsNullOrEmpty(_value);
    }
}
