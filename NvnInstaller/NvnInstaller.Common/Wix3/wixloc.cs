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
namespace Wix3.Localization {

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/2006/localization")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/2006/localization", IsNullable = false)]
  public partial class WixLocalization {

    private String[] stringField;

    private string codepageField;

    private string cultureField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("String")]
    public String[] String {
      get {
        return this.stringField;
      }
      set {
        this.stringField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Codepage {
      get {
        return this.codepageField;
      }
      set {
        this.codepageField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Culture {
      get {
        return this.cultureField;
      }
      set {
        this.cultureField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/2006/localization")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/2006/localization", IsNullable = false)]
  public partial class String {

    private string idField;

    private LocalizationYesNoType overridableField;

    private bool overridableFieldSpecified;

    private LocalizationYesNoType localizableField;

    private bool localizableFieldSpecified;

    private string[] textField;

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
    public LocalizationYesNoType Overridable {
      get {
        return this.overridableField;
      }
      set {
        this.overridableField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OverridableSpecified {
      get {
        return this.overridableFieldSpecified;
      }
      set {
        this.overridableFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LocalizationYesNoType Localizable {
      get {
        return this.localizableField;
      }
      set {
        this.localizableField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LocalizableSpecified {
      get {
        return this.localizableFieldSpecified;
      }
      set {
        this.localizableFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
      get {
        return this.textField;
      }
      set {
        this.textField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/wix/2006/localization")]
  public enum LocalizationYesNoType {

    /// <remarks/>
    no,

    /// <remarks/>
    yes,
  }
}