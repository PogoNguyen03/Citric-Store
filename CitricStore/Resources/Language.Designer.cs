﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CitricStore.Resources
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]

    public class Language {
        

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Language()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]

        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {

                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CitricStore.Resources.Language", typeof(Language).Assembly);
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
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Câu hỏi thường gặp.
        /// </summary>
        public static string FrequentlyAskedQuestions
        {
            get
            {
                return ResourceManager.GetString("FrequentlyAskedQuestions", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Đăng Nhập.
        /// </summary>
        public static string Login {
            get {
                return ResourceManager.GetString("Login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Đăng Xuất.
        /// </summary>
        public static string LogOut {
            get {
                return ResourceManager.GetString("LogOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Member.
        /// </summary>
        public static string Member {
            get {
                return ResourceManager.GetString("Member", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Xem Thông Tin.
        /// </summary>
        public static string PersonalInformation {
            get {
                return ResourceManager.GetString("PersonalInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Đơn Hàng Đã Mua.
        /// </summary>
        public static string PurchasedOrders {
            get {
                return ResourceManager.GetString("PurchasedOrders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tìm kiếm ứng dụng....
        /// </summary>
        public static string SearchInStore
        {
            get
            {
                return ResourceManager.GetString("SearchInStore", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Cửa hàng.
        /// </summary>
        public static string Store
        {
            get
            {
                return ResourceManager.GetString("Store", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Hỗ trợ.
        /// </summary>
        public static string Support
        {
            get
            {
                return ResourceManager.GetString("Support", resourceCulture);
            }

        }
    }
}
