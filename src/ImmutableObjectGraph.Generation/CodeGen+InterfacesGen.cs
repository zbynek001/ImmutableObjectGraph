﻿namespace ImmutableObjectGraph.Generation
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    //using System.Data.Entity.Design.PluralizationServices;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.CodeAnalysis.Text;
    using Validation;
    using LookupTableHelper = RecursiveTypeExtensions.LookupTable<IRecursiveType, IRecursiveParentWithLookupTable<IRecursiveType>>;

    public partial class CodeGen
    {
        protected class InterfacesGen : FeatureGenerator
        {
            public InterfacesGen(CodeGen generator)
                : base(generator)
            {
            }

            public override bool IsApplicable
            {
                get { return this.generator.options.DefineInterface; }
            }

            protected override BaseTypeSyntax[] AdditionalApplyToBaseTypes
            {
                get
                {
                    return new BaseTypeSyntax[] { SyntaxFactory.SimpleBaseType(
                        SyntaxFactory.IdentifierName("I" + this.generator.applyTo.Identifier.Text)) };
                }
            }

            protected override void GenerateCore()
            {
                var iface = SyntaxFactory.InterfaceDeclaration(
                    "I" + this.generator.applyTo.Identifier.Text)
                    .AddModifiers(GetModifiersForAccessibility(this.generator.applyToSymbol))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PartialKeyword))
                    .WithMembers(
                        SyntaxFactory.List<MemberDeclarationSyntax>(
                            //from field in this.generator.applyToMetaType.LocalFields
                            from field in this.generator.applyToMetaType.Ancestors.Where(i => !i.Options.DefineInterface).Reverse().SelectMany(i => i.LocalFields).Union(this.generator.applyToMetaType.LocalFields)
                            select SyntaxFactory.PropertyDeclaration(
                                GetFullyQualifiedSymbolName(field.Type),
                                field.Name.ToPascalCase())
                                .To(i =>
                                    field.IsObsolete ?
                                        i.AddAttributeLists(
                                            SyntaxFactory.AttributeList().AddAttributes(field.GetObsoleteAttribute())
                                            ) : i)
                                .WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.SingletonList(
                                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                        .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)))))));

                //if (this.generator.applyToMetaType.HasAncestor)
                //{
                //    iface = iface.WithBaseList(SyntaxFactory.BaseList(
                //        SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(SyntaxFactory.SimpleBaseType(
                //            SyntaxFactory.IdentifierName("I" + this.generator.applyToMetaType.Ancestor.TypeSymbol.Name)))));
                //}
                {
                    var mt = this.generator.applyToMetaType;
                    while (mt.HasAncestor)
                    {
                        mt = mt.Ancestor;
                        if (mt.Options.DefineInterface)
                        {
                            iface = iface.WithBaseList(SyntaxFactory.BaseList(
                                SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(SyntaxFactory.SimpleBaseType(
                                    SyntaxFactory.IdentifierName("I" + mt.TypeSymbol.Name)))));
                            break;
                        }
                    }
                }

                this.siblingMembers.Add(iface);
            }
        }
    }
}
