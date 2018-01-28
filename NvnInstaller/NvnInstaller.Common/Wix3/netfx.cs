﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace Wix3.Netfx {

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/NetFxExtension")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/NetFxExtension", IsNullable = false)]
  public partial class NativeImage {

    private string idField;

    private string appBaseDirectoryField;

    private string assemblyApplicationField;

    private YesNoType debugField;

    private bool debugFieldSpecified;

    private YesNoType dependenciesField;

    private bool dependenciesFieldSpecified;

    private NativeImagePlatform platformField;

    private bool platformFieldSpecified;

    private NativeImagePriority priorityField;

    private bool priorityFieldSpecified;

    private YesNoType profileField;

    private bool profileFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AppBaseDirectory {
      get {
        return this.appBaseDirectoryField;
      }
      set {
        this.appBaseDirectoryField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AssemblyApplication {
      get {
        return this.assemblyApplicationField;
      }
      set {
        this.assemblyApplicationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNoType Debug {
      get {
        return this.debugField;
      }
      set {
        this.debugField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DebugSpecified {
      get {
        return this.debugFieldSpecified;
      }
      set {
        this.debugFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNoType Dependencies {
      get {
        return this.dependenciesField;
      }
      set {
        this.dependenciesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DependenciesSpecified {
      get {
        return this.dependenciesFieldSpecified;
      }
      set {
        this.dependenciesFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NativeImagePlatform Platform {
      get {
        return this.platformField;
      }
      set {
        this.platformField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PlatformSpecified {
      get {
        return this.platformFieldSpecified;
      }
      set {
        this.platformFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NativeImagePriority Priority {
      get {
        return this.priorityField;
      }
      set {
        this.priorityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PrioritySpecified {
      get {
        return this.priorityFieldSpecified;
      }
      set {
        this.priorityFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNoType Profile {
      get {
        return this.profileField;
      }
      set {
        this.profileField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ProfileSpecified {
      get {
        return this.profileFieldSpecified;
      }
      set {
        this.profileFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/wix/NetFxExtension")]
  public enum YesNoType {

    /// <remarks/>
    no,

    /// <remarks/>
    yes,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/NetFxExtension")]
  public enum NativeImagePlatform {

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("32bit")]
    Item32bit,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("64bit")]
    Item64bit,

    /// <remarks/>
    all,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/NetFxExtension")]
  public enum NativeImagePriority {

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
  }
}