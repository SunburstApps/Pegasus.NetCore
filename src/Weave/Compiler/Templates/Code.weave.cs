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
        RenderCode
            (
            #line 1 "Code.weave"
       object
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
            #line 3 "Code.weave"
   var span = model as SourceSpan; 
            #line default
            indentation = __temp0;
            if (
                #line 4 "Code.weave"
     span != null
                #line default
                )
            {
                writer.Write(indentation);
                writer.Write("#line ");
                writer.Write(
                    #line 5 "Code.weave"
              span.Start.Line 
                    #line default
                    );
                writer.Write(" \"");
                writer.Write(
                    #line 5 "Code.weave"
                                      Path.GetFileName(span.Start.FileName) 
                    #line default
                    );
                writer.Write("\"");
                var __temp1 = indentation;
                #line 5 "Code.weave"
                                                                                  writer.WriteLine(); 
                #line default
                indentation = __temp1;
                writer.Write(
                    #line 5 "Code.weave"
                                                                                                            new string(' ', span.Start.Column - 1) 
                    #line default
                    );
                writer.Write(
                    #line 5 "Code.weave"
                                                                                                                                                         span.Value 
                    #line default
                    );
                writer.WriteLine();
                writer.Write(indentation);
                writer.Write("#line default");
                writer.WriteLine();
            }
            else
            {
                var __temp2 = indentation;
                #line 8 "Code.weave"
       var value = model.ToString(); 
                #line default
                indentation = __temp2;
                if (
                    #line 9 "Code.weave"
         !string.IsNullOrEmpty(value) 
                    #line default
                    )
                {
                    writer.Write(indentation);
                    writer.Write(
                        #line 10 "Code.weave"
            value 
                        #line default
                        );
                    writer.WriteLine();
                }
            }
        }
    }
}