﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCouch.Testing {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class JsonTestData {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal JsonTestData() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MyCouch.Testing.JsonTestData", typeof(JsonTestData).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;total_rows&quot;: 4,
        ///    &quot;offset&quot;: 0,
        ///    &quot;rows&quot;: [
        ///        {
        ///            &quot;id&quot;: &quot;1&quot;,
        ///            &quot;key&quot;: &quot;Fake artist 1&quot;,
        ///            &quot;value&quot;: [
        ///                {
        ///                    &quot;name&quot;: &quot;Greatest fakes #1&quot;
        ///                }
        ///            ]
        ///        },
        ///        {
        ///            &quot;id&quot;: &quot;2&quot;,
        ///            &quot;key&quot;: &quot;Fake artist 2&quot;,
        ///            &quot;value&quot;: [
        ///                {
        ///                    &quot;name&quot;: &quot;Greatest fakes #2.1&quot;
        ///                },
        ///                {
        ///                    &quot;name&quot;: &quot;Greatest f [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ViewQueryAlbums {
            get {
                return ResourceManager.GetString("ViewQueryAlbums", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;total_rows&quot;: 3,
        ///    &quot;offset&quot;: 0,
        ///    &quot;rows&quot;: [
        ///        {
        ///            &quot;id&quot;: &quot;1&quot;,
        ///            &quot;key&quot;: &quot;1&quot;,
        ///            &quot;value&quot;: {
        ///                &quot;rev&quot;: &quot;43-4886b6a3da60a647adea18b1c6c81cd5&quot;
        ///            }
        ///        },
        ///        {
        ///            &quot;id&quot;: &quot;2&quot;,
        ///            &quot;key&quot;: &quot;2&quot;,
        ///            &quot;value&quot;: {
        ///                &quot;rev&quot;: &quot;42-e7620ba0ea71c48f6a11bacee4999d79&quot;
        ///            }
        ///        }
        ///    ]
        ///}.
        /// </summary>
        public static string ViewQueryAllDocsResult {
            get {
                return ResourceManager.GetString("ViewQueryAllDocsResult", resourceCulture);
            }
        }
    }
}
