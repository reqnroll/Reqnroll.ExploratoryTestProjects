using System.CodeDom;
using Reqnroll.Generator;
using Reqnroll.Generator.UnitTestConverter;

namespace CustomPlugins.TagDecoratorGeneratorPlugin.ReqnrollPlugin;
public class StaApartmentStateTagDecorator : ITestMethodTagDecorator
{
    public static readonly string TAG_NAME = "staApartmentState";
    private readonly ITagFilterMatcher _tagFilterMatcher;

    public StaApartmentStateTagDecorator(ITagFilterMatcher tagFilterMatcher)
    {
        _tagFilterMatcher = tagFilterMatcher;
    }

    public bool CanDecorateFrom(string tagName, TestClassGenerationContext generationContext, CodeMemberMethod testMethod)
    {
        return _tagFilterMatcher.Match(TAG_NAME, tagName);
    }

    public void DecorateFrom(string tagName, TestClassGenerationContext generationContext, CodeMemberMethod testMethod)
    {
        var attribute = new CodeAttributeDeclaration(
            "NUnit.Framework.ApartmentAttribute",
            new CodeAttributeArgument(
                new CodeFieldReferenceExpression(
                    new CodeTypeReferenceExpression(typeof(System.Threading.ApartmentState)),
                    "STA")));

        testMethod.CustomAttributes.Add(attribute);
    }

    public int Priority => 0;
    public bool RemoveProcessedTags => false;
    public bool ApplyOtherDecoratorsForProcessedTags => false;
}
