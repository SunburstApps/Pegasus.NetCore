// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.2.1.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace
    #line 1 "_config.weave"
           Weave.Compiler
    #line default
{
    using System;
    using System.IO;
    using
        #line 2 "_config.weave"
       Weave.Expressions
        #line default
        ;

    partial class
    Templates
    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.2.1.0")]
        public
        void
        RenderRenderElement
            (
            #line 1 "RenderElement.weave"
       RenderElement
            #line default
            model, TextWriter writer, string indentation = null)
        {
            var __encode = new Func<object, string>(
                #line 4 "_config.weave"
        ToLiteral
                #line default
                );
            var __originalIndentation = indentation = indentation ?? string.Empty;
            var __temp0 = indentation;
            #line 3 "RenderElement.weave"
   var newModel = this.CreateVariable("model"); 
            #line default
            indentation = __temp0;
            writer.Write(indentation);
            writer.Write("var ");
            writer.Write(
                #line 4 "RenderElement.weave"
        newModel 
                #line default
                );
            writer.Write(" =");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            var __model0 =
                #line 5 "RenderElement.weave"
                  model.Expression
                #line default
                ;
            RenderCode(__model0, writer, indentation);
            writer.Write(indentation);
            writer.Write(";");
            writer.WriteLine();
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write(
                #line 7 "RenderElement.weave"
    model.Method.Value 
                #line default
                );
            writer.Write("(");
            writer.Write(
                #line 7 "RenderElement.weave"
                              newModel 
                #line default
                );
            writer.Write(", writer, indentation);");
            writer.WriteLine();
        }
    }
}