﻿namespace Unicorn.Core.Infrastructure.SDK.ServiceCommunication.Http.MethodAttributes;

[AttributeUsage(AttributeTargets.Method)]
public abstract class UnicornHttpAttribute : Attribute
{
    protected UnicornHttpAttribute(string pathTemplate) => PathTemplate = pathTemplate;

    public string PathTemplate { get; }
}
