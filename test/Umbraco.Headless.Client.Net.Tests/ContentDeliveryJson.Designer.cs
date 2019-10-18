﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umbraco.Headless.Client.Net.Tests {
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ContentDeliveryJson {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ContentDeliveryJson() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Umbraco.Headless.Client.Net.Tests.ContentDeliveryJson", typeof(ContentDeliveryJson).Assembly);
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
        ///   Looks up a localized string similar to {
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/72346384-fc5e-4a6e-a07d-559eec11dcea/ancestors&quot;
        ///        },
        ///        &quot;content&quot;: [
        ///            {
        ///                &quot;href&quot;: &quot;https://cdn.umbraco.io/content/1d770f10-d1ca-4a26-9d68-071e2c9f7ac1&quot;
        ///            },
        ///            {
        ///                &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1&quot;
        ///            }
        ///        ]
        ///    },
        ///    &quot;_embedded&quot;: {
        ///        &quot;content&quot;: [
        ///            {
        ///                &quot;_creatorNam [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetAncestors {
            get {
                return ResourceManager.GetString("GetAncestors", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;_creatorName&quot;: &quot;Morten Christensen&quot;,
        ///    &quot;_url&quot;: &quot;/home/products/unicorn/&quot;,
        ///    &quot;_writerName&quot;: &quot;Administrator&quot;,
        ///    &quot;_hasChildren&quot;: false,
        ///    &quot;_level&quot;: 3,
        ///    &quot;_createDate&quot;: &quot;2019-09-13T12:36:11.217Z&quot;,
        ///    &quot;_id&quot;: &quot;4e96411a-b8e1-435f-9322-2faee30ef5f2&quot;,
        ///    &quot;_updateDate&quot;: &quot;2019-09-13T12:36:25.233Z&quot;,
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/4e96411a-b8e1-435f-9322-2faee30ef5f2&quot;
        ///        },
        ///        &quot;photos&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/media [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetByUrlHomeProductsUnicorn {
            get {
                return ResourceManager.GetString("GetByUrlHomeProductsUnicorn", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;_totalItems&quot;: 5,
        ///    &quot;_totalPages&quot;: 1,
        ///    &quot;_page&quot;: 1,
        ///    &quot;_pageSize&quot;: 10,
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1/children?page=1&quot;
        ///        },
        ///        &quot;page&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/{id}/children{?page,pageSize}&quot;,
        ///            &quot;templated&quot;: true
        ///        },
        ///        &quot;root&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content&quot;
        ///        },
        ///        &quot;content&quot;: [
        ///            {
        ///                &quot;h [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetChildrenByParentId {
            get {
                return ResourceManager.GetString("GetChildrenByParentId", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;_totalItems&quot;: 8,
        ///    &quot;_totalPages&quot;: 1,
        ///    &quot;_page&quot;: 1,
        ///    &quot;_pageSize&quot;: 10,
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ec4aafcc-0c25-4f25-a8fe-705bfae1d324/children?page=1&quot;
        ///        },
        ///        &quot;page&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/{id}/children{?page,pageSize}&quot;,
        ///            &quot;templated&quot;: true
        ///        },
        ///        &quot;root&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content&quot;
        ///        },
        ///        &quot;content&quot;: [
        ///            {
        ///                &quot;h [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetChildrenOfProducts {
            get {
                return ResourceManager.GetString("GetChildrenOfProducts", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;_creatorName&quot;: &quot;Morten Christensen&quot;,
        ///    &quot;_url&quot;: &quot;/home/&quot;,
        ///    &quot;_writerName&quot;: &quot;Administrator&quot;,
        ///    &quot;_hasChildren&quot;: true,
        ///    &quot;_level&quot;: 1,
        ///    &quot;_createDate&quot;: &quot;2019-09-13T12:36:10.927Z&quot;,
        ///    &quot;_id&quot;: &quot;ca4249ed-2b23-4337-b522-63cabe5587d1&quot;,
        ///    &quot;_updateDate&quot;: &quot;2019-09-13T12:36:24.763Z&quot;,
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1&quot;
        ///        },
        ///        &quot;heroctalink&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/cont [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetContentById {
            get {
                return ResourceManager.GetString("GetContentById", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;_totalItems&quot;: 23,
        ///    &quot;_totalPages&quot;: 3,
        ///    &quot;_page&quot;: 1,
        ///    &quot;_pageSize&quot;: 10,
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1/descendants?page=1&quot;
        ///        },
        ///        &quot;next&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1/descendants?page=2&quot;
        ///        },
        ///        &quot;page&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/{id}/descendants{?page,pageSize}&quot;,
        ///            &quot;templated&quot;: true
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetDescendantsPageOne {
            get {
                return ResourceManager.GetString("GetDescendantsPageOne", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;_totalItems&quot;: 23,
        ///    &quot;_totalPages&quot;: 3,
        ///    &quot;_page&quot;: 3,
        ///    &quot;_pageSize&quot;: 10,
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1/descendants?page=3&quot;
        ///        },
        ///        &quot;prev&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1/descendants?page=2&quot;
        ///        },
        ///        &quot;page&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/{id}/descendants{?page,pageSize}&quot;,
        ///            &quot;templated&quot;: true
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetDescendantsPageThree {
            get {
                return ResourceManager.GetString("GetDescendantsPageThree", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;_totalItems&quot;: 23,
        ///    &quot;_totalPages&quot;: 3,
        ///    &quot;_page&quot;: 2,
        ///    &quot;_pageSize&quot;: 10,
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1/descendants?page=2&quot;
        ///        },
        ///        &quot;prev&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1/descendants?page=1&quot;
        ///        },
        ///        &quot;next&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/ca4249ed-2b23-4337-b522-63cabe5587d1/descendants?page=3&quot;
        ///        } [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetDescendantsPageTwo {
            get {
                return ResourceManager.GetString("GetDescendantsPageTwo", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;_links&quot;: {
        ///        &quot;self&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content&quot;
        ///        },
        ///        &quot;ancestors&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/{id}/ancestors&quot;,
        ///            &quot;templated&quot;: true
        ///        },
        ///        &quot;children&quot;: {
        ///            &quot;href&quot;: &quot;https://cdn.umbraco.io/content/{id}/children{?page,pageSize}&quot;,
        ///            &quot;templated&quot;: true
        ///        },
        ///        &quot;content&quot;: [
        ///            {
        ///                &quot;href&quot;: &quot;https://cdn.umbraco.io/content/{id}{?depth}&quot;,
        ///                &quot;templated [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetRoot {
            get {
                return ResourceManager.GetString("GetRoot", resourceCulture);
            }
        }

        internal static string GetByType {
            get {
                return ResourceManager.GetString("GetByType", resourceCulture);
            }
        }
    }
}
