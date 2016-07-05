﻿namespace Atata
{
    public class FindByAttributeAttribute : TermFindAttribute
    {
        public FindByAttributeAttribute(string attributeName, TermCase termCase)
            : this(attributeName, null, termCase: termCase)
        {
        }

        public FindByAttributeAttribute(string attributeName, TermMatch match, TermCase termCase = TermCase.Inherit)
            : this(attributeName, null, match, termCase)
        {
        }

        public FindByAttributeAttribute(string attributeName, TermMatch match, params string[] values)
            : this(attributeName, values, match)
        {
        }

        public FindByAttributeAttribute(string attributeName, params string[] values)
            : this(attributeName, values, termCase: TermCase.Inherit)
        {
        }

        private FindByAttributeAttribute(string attributeName, string[] values = null, TermMatch match = TermMatch.Inherit, TermCase termCase = TermCase.Inherit)
            : base(values, match, termCase)
        {
            AttributeName = attributeName.CheckNotNullOrWhitespace("attributeName");
        }

        public string AttributeName { get; private set; }

        protected override TermCase DefaultCase
        {
            get { return TermCase.Title; }
        }

        public override IComponentScopeLocateStrategy CreateStrategy(UIComponentMetadata metadata)
        {
            return new FindByAttributeStrategy(AttributeName);
        }
    }
}