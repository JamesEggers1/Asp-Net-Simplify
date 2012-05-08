using System;
using System.Collections;
using System.Web.UI;

namespace Simplify.Core
{
    public class SimplifyPageParserFilter : PageParserFilter
    {
        private string _viewBaseType;
        private DirectiveType _directiveType = DirectiveType.Unknown;
        private bool _viewTypeControlAdded;

        public override void PreprocessDirective(string directiveName, IDictionary attributes) {
            base.PreprocessDirective(directiveName, attributes);

            string defaultBaseType = null;
            
            switch (directiveName) {
                case "page":
                    _directiveType = DirectiveType.Page;
                    defaultBaseType = typeof(BasePage).FullName;
                    break;
                case "control":
                    _directiveType = DirectiveType.UserControl;
                    defaultBaseType = typeof(UserControl).FullName;
                    break;
                case "master":
                    _directiveType = DirectiveType.Master;
                    defaultBaseType = typeof(MasterPage).FullName;
                    break;
            }

            if (_directiveType == DirectiveType.Unknown) {
                return;
            }

            var inherits = (string)attributes["inherits"];
            if (!String.IsNullOrEmpty(inherits)) {
                if (IsGenericTypeString(inherits)) {
                    attributes["inherits"] = defaultBaseType;
                    _viewBaseType = inherits;
                }
            }
        }

        private static bool IsGenericTypeString(string typeName) {
            return typeName.IndexOfAny(new char[] { '<', '(' }) >= 0;
        }

        public override void ParseComplete(ControlBuilder rootBuilder) {
            base.ParseComplete(rootBuilder);

            SimplifyPageControlBuilder pageBuilder = rootBuilder as SimplifyPageControlBuilder;
            if (pageBuilder != null)
            {
                pageBuilder.PageBaseType = _viewBaseType;
            }
        }

        public override bool AllowCode {
            get {
                return true;
            }
        }

        public override bool AllowBaseType(Type baseType) {
            return true;
        }

        public override bool AllowControl(Type controlType, ControlBuilder builder) {
            return true;
        }

        public override bool AllowVirtualReference(string referenceVirtualPath, VirtualReferenceType referenceType) {
            return true;
        }

        public override bool AllowServerSideInclude(string includeVirtualPath) {
            return true;
        }

        public override int NumberOfControlsAllowed {
            get {
                return -1;
            }
        }

        public override int NumberOfDirectDependenciesAllowed {
            get {
                return -1;
            }
        }

        public override int TotalNumberOfDependenciesAllowed {
            get {
                return -1;
            }
        }

        private enum DirectiveType {
            Unknown,
            Page,
            UserControl,
            Master,
        }
    }
}