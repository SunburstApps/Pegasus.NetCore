﻿// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace Weave.Compiler
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Weave.Expressions;

    internal abstract class TemplateWalker
    {
        public virtual void WalkBodyElement(BodyElement bodyElement)
        {
            this.WalkElements(bodyElement.Body);
        }

        public virtual void WalkBranch(Branch branch)
        {
            this.WalkElements(branch.Body);
        }

        public virtual void WalkCodeElement(CodeElement codeElement)
        {
        }

        public virtual void WalkEachElement(EachElement eachElement)
        {
            this.WalkElements(eachElement.EachBody.Body);

            if (eachElement.DelimitBody != null)
            {
                this.WalkElements(eachElement.DelimitBody.Body);
            }

            if (eachElement.NoneBody != null)
            {
                this.WalkElements(eachElement.NoneBody.Body);
            }
        }

        public virtual void WalkEchoTag(EchoTag echoTag)
        {
        }

        public virtual void WalkElement(Element element)
        {
            BodyElement bodyElement;
            CodeElement codeElement;
            EachElement eachElement;
            EchoTag echoTag;
            IfElement ifElement;
            IndentationElement indentationElement;
            NewLineElement newLineElement;
            RenderElement renderElement;
            TextElement textElement;
            WrapIfElement wrapIfElement;

            if ((bodyElement = element as BodyElement) != null)
            {
                this.WalkBodyElement(bodyElement);
            }
            else if ((codeElement = element as CodeElement) != null)
            {
                this.WalkCodeElement(codeElement);
            }
            else if ((eachElement = element as EachElement) != null)
            {
                this.WalkEachElement(eachElement);
            }
            else if ((echoTag = element as EchoTag) != null)
            {
                this.WalkEchoTag(echoTag);
            }
            else if ((ifElement = element as IfElement) != null)
            {
                this.WalkIfElement(ifElement);
            }
            else if ((indentationElement = element as IndentationElement) != null)
            {
                this.WalkIndentationElement(indentationElement);
            }
            else if ((newLineElement = element as NewLineElement) != null)
            {
                this.WalkNewLineElement(newLineElement);
            }
            else if ((renderElement = element as RenderElement) != null)
            {
                this.WalkRenderElement(renderElement);
            }
            else if ((textElement = element as TextElement) != null)
            {
                this.WalkTextElement(textElement);
            }
            else if ((wrapIfElement = element as WrapIfElement) != null)
            {
                this.WalkWrapIfElement(wrapIfElement);
            }
            else
            {
                throw new NotImplementedException(string.Format(CultureInfo.CurrentCulture, "Unimplemented element '{0}'.", element.GetType().Name));
            }
        }

        public virtual void WalkElements(IEnumerable<Element> elements)
        {
            foreach (var element in elements)
            {
                this.WalkElement(element);
            }
        }

        public virtual void WalkIfElement(IfElement ifElement)
        {
            foreach (var branch in ifElement.Branches)
            {
                this.WalkBranch(branch);
            }
        }

        public virtual void WalkIndentationElement(IndentationElement indentationElement)
        {
        }

        public virtual void WalkNewLineElement(NewLineElement newLineElement)
        {
        }

        public virtual void WalkRenderElement(RenderElement renderElement)
        {
        }

        public virtual void WalkTemplate(Template template)
        {
            this.WalkElements(template.Elements);
        }

        public virtual void WalkTextElement(TextElement textElement)
        {
        }

        public virtual void WalkWrapIfElement(WrapIfElement wrapIfElement)
        {
            this.WalkElements(wrapIfElement.Before);
            this.WalkElement(wrapIfElement.Body);
            this.WalkElements(wrapIfElement.After);
        }
    }
}
