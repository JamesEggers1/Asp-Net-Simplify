using System.CodeDom;
using System.Web.UI;

namespace Simplify
{
    public class SimplifyPageControlBuilder : FileLevelPageControlBuilder
    {
        public string PageBaseType { get; set; }

        public override void ProcessGeneratedCode(
            CodeCompileUnit codeCompileUnit,
            CodeTypeDeclaration baseType,
            CodeTypeDeclaration derivedType,
            CodeMemberMethod buildMethod,
            CodeMemberMethod dataBindingMethod)
        {
            if (PageBaseType != null)
            {
                derivedType.BaseTypes[0] = new CodeTypeReference(PageBaseType);
            }
        }
    }
}