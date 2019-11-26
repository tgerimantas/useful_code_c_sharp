﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassificationAlgorithms.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClassificationAlgorithms.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to K Nearest Neighbors- classification algorithm
        ///
        ///Features:
        ///+Read data file. You can read cvs file type data. 
        ///
        ///-K element input - program takes k nearest neighbors data objects which is near to test object  
        ///and decides which class will be set to the test data.
        ///
        ///-Select rows input - you can select which column data you will use to learn a algorithm
        ///by typing column numbers 1,2...n. Each number need to be separated with commas.
        ///
        ///-Class column input - you select which column(number) is class type col [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InfoKNN {
            get {
                return ResourceManager.GetString("InfoKNN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NaiveBayes- classification algorithm
        ///
        ///Features:
        ///+Read data file. You can read cvs file type data. 
        ///
        ///-Select rows input - you can select which column data you will use to learn a algorithm
        ///by typing column numbers 1,2...n. Each number need to be separated with commas.
        ///
        ///-Class column input - you select which column(number) is class type column. The program selects all class types.
        ///
        ///-New object input - you can test a algorithm with own test data. 
        ///You input data which is separated with commas (you n [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InfoNaiveBayes {
            get {
                return ResourceManager.GetString("InfoNaiveBayes", resourceCulture);
            }
        }
    }
}