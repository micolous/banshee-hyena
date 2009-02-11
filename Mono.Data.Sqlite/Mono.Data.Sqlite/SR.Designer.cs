//
// Mono.Data.Sqlite.SR.Designer.cs
//
// Author(s):
//   Robert Simpson (robert@blackcastlesoft.com)
//
// Adapted and modified for the Mono Project by
//   Marek Habersack (grendello@gmail.com)
//
//
// Copyright (C) 2006 Novell, Inc (http://www.novell.com)
// Copyright (C) 2007 Marek Habersack
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if NET_2_0
namespace Mono.Data.Sqlite {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SR", typeof(SR).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;DocumentElement&gt;
        ///  &lt;DataTypes&gt;
        ///    &lt;TypeName&gt;smallint&lt;/TypeName&gt;
        ///    &lt;ProviderDbType&gt;10&lt;/ProviderDbType&gt;
        ///    &lt;ColumnSize&gt;5&lt;/ColumnSize&gt;
        ///    &lt;DataType&gt;System.Int16&lt;/DataType&gt;
        ///    &lt;CreateFormat&gt;smallint&lt;/CreateFormat&gt;
        ///    &lt;IsAutoIncrementable&gt;false&lt;/IsAutoIncrementable&gt;
        ///    &lt;IsCaseSensitive&gt;false&lt;/IsCaseSensitive&gt;
        ///    &lt;IsFixedLength&gt;true&lt;/IsFixedLength&gt;
        ///    &lt;IsFixedPrecisionScale&gt;true&lt;/IsFixedPrecisionScale&gt;
        ///    &lt;IsLong&gt;false&lt;/IsLong&gt;
        ///    &lt;IsNullable&gt;true&lt;/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DataTypes {
            get {
                return ResourceManager.GetString("DataTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALL,ALTER,AND,AS,AUTOINCREMENT,BETWEEN,BY,CASE,CHECK,COLLATE,COMMIT,CONSTRAINT,CREATE,CROSS,DEFAULT,DEFERRABLE,DELETE,DISTINCT,DROP,ELSE,ESCAPE,EXCEPT,FOREIGN,FROM,FULL,GROUP,HAVING,IN,INDEX,INNER,INSERT,INTERSECT,INTO,IS,ISNULL,JOIN,LEFT,LIMIT,NATURAL,NOT,NOTNULL,NULL,ON,OR,ORDER,OUTER,PRIMARY,REFERENCES,RIGHT,ROLLBACK,SELECT,SET,TABLE,THEN,TO,TRANSACTION,UNION,UNIQUE,UPDATE,USING,VALUES,WHEN,WHERE.
        /// </summary>
        internal static string Keywords {
            get {
                return ResourceManager.GetString("Keywords", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;DocumentElement&gt;
        ///  &lt;MetaDataCollections&gt;
        ///    &lt;CollectionName&gt;MetaDataCollections&lt;/CollectionName&gt;
        ///    &lt;NumberOfRestrictions&gt;0&lt;/NumberOfRestrictions&gt;
        ///    &lt;NumberOfIdentifierParts&gt;0&lt;/NumberOfIdentifierParts&gt;
        ///  &lt;/MetaDataCollections&gt;
        ///  &lt;MetaDataCollections&gt;
        ///    &lt;CollectionName&gt;DataSourceInformation&lt;/CollectionName&gt;
        ///    &lt;NumberOfRestrictions&gt;0&lt;/NumberOfRestrictions&gt;
        ///    &lt;NumberOfIdentifierParts&gt;0&lt;/NumberOfIdentifierParts&gt;
        ///  &lt;/MetaDataCollections&gt;
        ///  &lt;MetaDataC [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MetaDataCollections {
            get {
                return ResourceManager.GetString("MetaDataCollections", resourceCulture);
            }
        }
    }
}
#endif