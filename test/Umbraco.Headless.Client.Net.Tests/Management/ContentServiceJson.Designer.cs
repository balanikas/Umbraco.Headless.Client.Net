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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ContentServiceJson {

        private static System.Resources.ResourceManager resourceMan;

        private static System.Globalization.CultureInfo resourceCulture;

        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ContentServiceJson() {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Umbraco.Headless.Client.Net.Tests.Management.ContentServiceJson", typeof(ContentServiceJson).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        internal static string Create {
            get {
                return ResourceManager.GetString("Create", resourceCulture);
            }
        }

        internal static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }

        internal static string ById {
            get {
                return ResourceManager.GetString("ById", resourceCulture);
            }
        }

        internal static string AtRoot {
            get {
                return ResourceManager.GetString("AtRoot", resourceCulture);
            }
        }

        internal static string Children {
            get {
                return ResourceManager.GetString("Children", resourceCulture);
            }
        }

        internal static string Publish {
            get {
                return ResourceManager.GetString("Publish", resourceCulture);
            }
        }

        internal static string Unpublish {
            get {
                return ResourceManager.GetString("Unpublish", resourceCulture);
            }
        }
    }
}
