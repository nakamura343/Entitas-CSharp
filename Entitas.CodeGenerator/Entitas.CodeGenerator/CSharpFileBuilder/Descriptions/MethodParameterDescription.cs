﻿namespace Entitas.CodeGenerator {
    public class MethodParameterDescription {
        public string type { get { return _type; } }
        public string name { get { return _name; } }
        public string keyword { get { return _keyword; } }
        public string defaultValue { get { return _defaultValue; } }

        readonly string _type;
        readonly string _name;
        string _keyword;
        string _defaultValue;

        public MethodParameterDescription(string type, string name) {
            _type = type;
            _name = name;
        }

        public MethodParameterDescription SetKeyword(string keyword) {
            _keyword = keyword;
            return this;
        }

        public MethodParameterDescription SetDefaultValue(string defaultValue) {
            _defaultValue = defaultValue;
            return this;
        }
    }
}
