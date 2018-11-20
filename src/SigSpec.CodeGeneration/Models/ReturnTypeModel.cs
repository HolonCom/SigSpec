﻿using NJsonSchema;
using NJsonSchema.CodeGeneration;
using SigSpec.Core;

namespace SigSpec.CodeGeneration.Models
{
    public class ReturnTypeModel
    {
        private readonly string _name;
        private readonly JsonSchema4 _parameter;
        private readonly TypeResolverBase _resolver;

        public ReturnTypeModel(string name, JsonSchema4 parameter, TypeResolverBase resolver)
        {
            _name = name;
            _parameter = parameter;
            _resolver = resolver;
        }

        public string Name => _name;

        public string Type => _resolver.Resolve(_parameter.ActualTypeSchema, _parameter.IsNullable(SchemaType.JsonSchema), _name);
    }
}