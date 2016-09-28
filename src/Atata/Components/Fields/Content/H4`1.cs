﻿namespace Atata
{
    /// <summary>
    /// Represents the &lt;h4&gt; heading tag.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition("h4", ComponentTypeName = "<h4> heading", IgnoreNameEndings = "Header,Heading")]
    [ControlFinding(typeof(FindFirstAttribute))]
    public class H4<TOwner> : Content<string, TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
