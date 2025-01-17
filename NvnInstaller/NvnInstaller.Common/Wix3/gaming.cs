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
namespace Wix3.Gaming {

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/GamingExtension")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/GamingExtension", IsNullable = false)]
  public partial class Game {

    private object[] itemsField;

    private string idField;

    private string gdfResourceFileField;

    private string executableFileField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PlayTask", typeof(PlayTask))]
    [System.Xml.Serialization.XmlElementAttribute("SupportTask", typeof(SupportTask))]
    public object[] Items {
      get {
        return this.itemsField;
      }
      set {
        this.itemsField = value;
      }
    }

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
    public string GdfResourceFile {
      get {
        return this.gdfResourceFileField;
      }
      set {
        this.gdfResourceFileField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ExecutableFile {
      get {
        return this.executableFileField;
      }
      set {
        this.executableFileField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/GamingExtension")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/GamingExtension", IsNullable = false)]
  public partial class PlayTask {

    private string nameField;

    private string argumentsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
      get {
        return this.nameField;
      }
      set {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Arguments {
      get {
        return this.argumentsField;
      }
      set {
        this.argumentsField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/GamingExtension")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/GamingExtension", IsNullable = false)]
  public partial class SupportTask {

    private string nameField;

    private string addressField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
      get {
        return this.nameField;
      }
      set {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Address {
      get {
        return this.addressField;
      }
      set {
        this.addressField = value;
      }
    }
  }
}