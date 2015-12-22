using System;

namespace DDDSharp.Domaining.Metadata
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class JsonSchemaEmbeddedResoueceAttribute : Attribute
    {
        public JsonSchemaEmbeddedResoueceAttribute(string embeddedResourceName)
        {
            if (string.IsNullOrEmpty(embeddedResourceName))
                throw new ArgumentNullException(nameof(embeddedResourceName));

            this.EmbeddedResourceName = embeddedResourceName;
        }

        public string EmbeddedResourceName { get; set; }
    }
}
