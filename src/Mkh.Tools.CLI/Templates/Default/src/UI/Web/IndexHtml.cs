﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 17.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\MyProject\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\IndexHtml.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class IndexHtml : IndexHtmlBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("<!DOCTYPE html>\r\n<html lang=\"zh\">\r\n  <head>\r\n    <meta charset=\"UTF-8\" />\r\n    <l" +
                    "ink rel=\"icon\" href=\"./assets/mkh/favicon.ico\" />\r\n    <meta name=\"viewport\" con" +
                    "tent=\"width=device-width, initial-scale=1.0\" />\r\n    <title></title>\r\n    <style" +
                    ">\r\n      html,\r\n      body {\r\n        margin: 0;\r\n        padding: 0;\r\n        f" +
                    "ont-family: -apple-system, system-ui, Segoe UI, Roboto, Ubuntu, Cantarell, Noto " +
                    "Sans, sans-serif, BlinkMacSystemFont, \'Helvetica Neue\', \'PingFang SC\', \'Hiragino" +
                    " Sans GB\', \'Microsoft YaHei\',\r\n          Arial;\r\n        font-size: 14px;\r\n     " +
                    "   height: 100%;\r\n      }\r\n\r\n      *,\r\n      ::after,\r\n      ::before {\r\n       " +
                    " box-sizing: border-box;\r\n      }\r\n\r\n      ul {\r\n        padding: 0;\r\n        ma" +
                    "rgin: 0;\r\n        list-style: none;\r\n      }\r\n\r\n      a {\r\n        text-decorati" +
                    "on: none;\r\n      }\r\n      h1,\r\n      h2,\r\n      h3,\r\n      h4,\r\n      h5,\r\n     " +
                    " h6,\r\n      pre,\r\n      code {\r\n        margin: 0;\r\n        padding: 0;\r\n      }" +
                    "\r\n\r\n      .m-loader {\r\n        position: absolute;\r\n        top: 0;\r\n        lef" +
                    "t: 0;\r\n        width: 100%;\r\n        height: 100%;\r\n        background-color: #f" +
                    "ff;\r\n      }\r\n\r\n      .m-loader .m-loader_main {\r\n        position: absolute;\r\n " +
                    "       top: 50%;\r\n        left: 50%;\r\n        width: 172px;\r\n        height: 128" +
                    "px;\r\n        margin: 0;\r\n        -webkit-transform: translate(-50%, -50%);\r\n    " +
                    "    transform: translate(-50%, -50%);\r\n      }\r\n\r\n      .m-loader_square {\r\n    " +
                    "    position: relative;\r\n      }\r\n\r\n      .m-loader_square:nth-child(1) {\r\n     " +
                    "   margin-left: 0px;\r\n      }\r\n\r\n      .m-loader_square:nth-child(2) {\r\n        " +
                    "margin-left: 44px;\r\n      }\r\n\r\n      .m-loader_square:nth-child(3) {\r\n        ma" +
                    "rgin-left: 88px;\r\n      }\r\n\r\n      .m-loader_square:nth-child(4) {\r\n        marg" +
                    "in-left: 132px;\r\n      }\r\n\r\n      .m-loader_square span {\r\n        position: abs" +
                    "olute;\r\n        top: 0px;\r\n        left: 20px;\r\n        height: 36px;\r\n        w" +
                    "idth: 36px;\r\n        border-radius: 2px;\r\n        background-color: #409eff;\r\n  " +
                    "    }\r\n\r\n      .m-loader_square span:nth-child(1) {\r\n        top: 0px;\r\n      }\r" +
                    "\n\r\n      .m-loader_square span:nth-child(2) {\r\n        top: 44px;\r\n      }\r\n\r\n  " +
                    "    .m-loader_square span:nth-child(3) {\r\n        top: 88px;\r\n      }\r\n\r\n      ." +
                    "m-loader_square:nth-child(1) span {\r\n        -webkit-animation: animsquare1 2s i" +
                    "nfinite ease-in;\r\n        animation: animsquare1 2s infinite ease-in;\r\n      }\r\n" +
                    "\r\n      .m-loader_square:nth-child(2) span {\r\n        -webkit-animation: animsqu" +
                    "are2 2s infinite ease-in;\r\n        animation: animsquare2 2s infinite ease-in;\r\n" +
                    "      }\r\n\r\n      .m-loader_square:nth-child(3) span {\r\n        -webkit-animation" +
                    ": animsquare3 2s infinite ease-in;\r\n        animation: animsquare3 2s infinite e" +
                    "ase-in;\r\n      }\r\n\r\n      .m-loader_square:nth-child(4) span {\r\n        -webkit-" +
                    "animation: animsquare4 2s infinite ease-in;\r\n        animation: animsquare4 2s i" +
                    "nfinite ease-in;\r\n      }\r\n\r\n      .m-loader_square span:nth-child(1) {\r\n       " +
                    " -webkit-animation-delay: 0s;\r\n        animation-delay: 0s;\r\n      }\r\n\r\n      .m" +
                    "-loader_square span:nth-child(2) {\r\n        -webkit-animation-delay: 0.15s;\r\n   " +
                    "     animation-delay: 0.15s;\r\n      }\r\n\r\n      .m-loader_square span:nth-child(3" +
                    ") {\r\n        -webkit-animation-delay: 0.3s;\r\n        animation-delay: 0.3s;\r\n   " +
                    "   }\r\n\r\n      @-webkit-keyframes animsquare1 {\r\n        0%,\r\n        5%,\r\n      " +
                    "  95%,\r\n        100% {\r\n          -webkit-transform: translate(0px, 0px) rotate(" +
                    "0deg);\r\n          transform: translate(0px, 0px) rotate(0deg);\r\n        }\r\n     " +
                    "   30%,\r\n        70% {\r\n          -webkit-transform: translate(-40px, 0px) rotat" +
                    "e(-90deg);\r\n          transform: translate(-40px, 0px) rotate(-90deg);\r\n        " +
                    "}\r\n      }\r\n      @keyframes animsquare1 {\r\n        0%,\r\n        5%,\r\n        95" +
                    "%,\r\n        100% {\r\n          -webkit-transform: translate(0px, 0px) rotate(0deg" +
                    ");\r\n          transform: translate(0px, 0px) rotate(0deg);\r\n        }\r\n        3" +
                    "0%,\r\n        70% {\r\n          -webkit-transform: translate(-40px, 0px) rotate(-9" +
                    "0deg);\r\n          transform: translate(-40px, 0px) rotate(-90deg);\r\n        }\r\n " +
                    "     }\r\n      @-webkit-keyframes animsquare2 {\r\n        0%,\r\n        10%,\r\n     " +
                    "   90%,\r\n        100% {\r\n          -webkit-transform: translate(0px, 0px) rotate" +
                    "(0deg);\r\n          transform: translate(0px, 0px) rotate(0deg);\r\n        }\r\n    " +
                    "    35%,\r\n        65% {\r\n          -webkit-transform: translate(-40px, 0px) rota" +
                    "te(-90deg);\r\n          transform: translate(-40px, 0px) rotate(-90deg);\r\n       " +
                    " }\r\n      }\r\n      @keyframes animsquare2 {\r\n        0%,\r\n        10%,\r\n        " +
                    "90%,\r\n        100% {\r\n          -webkit-transform: translate(0px, 0px) rotate(0d" +
                    "eg);\r\n          transform: translate(0px, 0px) rotate(0deg);\r\n        }\r\n       " +
                    " 35%,\r\n        65% {\r\n          -webkit-transform: translate(-40px, 0px) rotate(" +
                    "-90deg);\r\n          transform: translate(-40px, 0px) rotate(-90deg);\r\n        }\r" +
                    "\n      }\r\n      @-webkit-keyframes animsquare3 {\r\n        0%,\r\n        15%,\r\n   " +
                    "     85%,\r\n        100% {\r\n          -webkit-transform: translate(0px, 0px) rota" +
                    "te(0deg);\r\n          transform: translate(0px, 0px) rotate(0deg);\r\n        }\r\n  " +
                    "      40%,\r\n        60% {\r\n          -webkit-transform: translate(-40px, 0px) ro" +
                    "tate(-90deg);\r\n          transform: translate(-40px, 0px) rotate(-90deg);\r\n     " +
                    "   }\r\n      }\r\n      @keyframes animsquare3 {\r\n        0%,\r\n        15%,\r\n      " +
                    "  85%,\r\n        100% {\r\n          -webkit-transform: translate(0px, 0px) rotate(" +
                    "0deg);\r\n          transform: translate(0px, 0px) rotate(0deg);\r\n        }\r\n     " +
                    "   40%,\r\n        60% {\r\n          -webkit-transform: translate(-40px, 0px) rotat" +
                    "e(-90deg);\r\n          transform: translate(-40px, 0px) rotate(-90deg);\r\n        " +
                    "}\r\n      }\r\n      @-webkit-keyframes animsquare4 {\r\n        0%,\r\n        20%,\r\n " +
                    "       80%,\r\n        100% {\r\n          -webkit-transform: translate(0px, 0px) ro" +
                    "tate(0deg);\r\n          transform: translate(0px, 0px) rotate(0deg);\r\n        }\r\n" +
                    "        45%,\r\n        55% {\r\n          -webkit-transform: translate(-40px, 0px) " +
                    "rotate(-90deg);\r\n          transform: translate(-40px, 0px) rotate(-90deg);\r\n   " +
                    "     }\r\n      }\r\n      @keyframes animsquare4 {\r\n        0%,\r\n        20%,\r\n    " +
                    "    80%,\r\n        100% {\r\n          -webkit-transform: translate(0px, 0px) rotat" +
                    "e(0deg);\r\n          transform: translate(0px, 0px) rotate(0deg);\r\n        }\r\n   " +
                    "     45%,\r\n        55% {\r\n          -webkit-transform: translate(-40px, 0px) rot" +
                    "ate(-90deg);\r\n          transform: translate(-40px, 0px) rotate(-90deg);\r\n      " +
                    "  }\r\n      }\r\n\r\n      .m-copyright {\r\n        position: absolute;\r\n        left:" +
                    " 0;\r\n        bottom: 20px;\r\n        width: 100%;\r\n        text-align: center;\r\n " +
                    "     }\r\n\r\n      .m-copyright_logo {\r\n        position: relative;\r\n        top: 1" +
                    "0px;\r\n        width: 30px;\r\n      }\r\n    </style>\r\n  </head>\r\n  <body>\r\n    <div" +
                    " id=\"app\" style=\"display: none\">\r\n      <div class=\"m-loader\">\r\n        <div cla" +
                    "ss=\"m-loader_main\">\r\n          <div class=\"m-loader_square\"><span></span><span><" +
                    "/span><span></span></div>\r\n          <div class=\"m-loader_square\"><span></span><" +
                    "span></span><span></span></div>\r\n          <div class=\"m-loader_square\"><span></" +
                    "span><span></span><span></span></div>\r\n          <div class=\"m-loader_square\"><s" +
                    "pan></span><span></span><span></span></div>\r\n        </div>\r\n      </div>\r\n     " +
                    " <div class=\"m-copyright\">\r\n        <img class=\"m-copyright_logo\" src=\"<%= logo " +
                    "%>\" />\r\n        <span><%= copyright %></span>\r\n      </div>\r\n    </div>\r\n    <sc" +
                    "ript type=\"module\" src=\"./src/main.ts\"></script>\r\n  </body>\r\n</html>\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class IndexHtmlBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
