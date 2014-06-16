﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Markup {

    private HeaderFile[] headerField;
    
    private Topic topicField;
    
    private Comment[] commentField;
    
    private ViewPoint[] viewpointsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("File", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public HeaderFile[] Header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Topic Topic {
        get {
            return this.topicField;
        }
        set {
            this.topicField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Comment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Comment[] Comment {
        get {
            return this.commentField;
        }
        set {
            this.commentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Viewpoints", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ViewPoint[] Viewpoints {
        get {
            return this.viewpointsField;
        }
        set {
            this.viewpointsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class HeaderFile {
    
    private string filenameField;
    
    private System.DateTime dateField;
    
    private bool dateFieldSpecified;
    
    private string referenceField;
    
    private string ifcProjectField;
    
    private string ifcSpatialStructureElementField;
    
    private bool isExternalField;
    
    public HeaderFile() {
        this.isExternalField = true;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Filename {
        get {
            return this.filenameField;
        }
        set {
            this.filenameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime Date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DateSpecified {
        get {
            return this.dateFieldSpecified;
        }
        set {
            this.dateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IfcProject {
        get {
            return this.ifcProjectField;
        }
        set {
            this.ifcProjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IfcSpatialStructureElement {
        get {
            return this.ifcSpatialStructureElementField;
        }
        set {
            this.ifcSpatialStructureElementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool isExternal {
        get {
            return this.isExternalField;
        }
        set {
            this.isExternalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ViewPoint {
    
    private string viewpointField;
    
    private string snapshotField;
    
    private ViewPointComments[] commentsField;
    
    private string guidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Viewpoint {
        get {
            return this.viewpointField;
        }
        set {
            this.viewpointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Snapshot {
        get {
            return this.snapshotField;
        }
        set {
            this.snapshotField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Comments", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ViewPointComments[] Comments {
        get {
            return this.commentsField;
        }
        set {
            this.commentsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Guid {
        get {
            return this.guidField;
        }
        set {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class ViewPointComments {
    
    private string guidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Guid {
        get {
            return this.guidField;
        }
        set {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Comment {
    
    private string verbalStatusField;
    
    private string statusField;
    
    private System.DateTime dateField;
    
    private string authorField;
    
    private string comment1Field;
    
    private CommentTopic topicField;
    
    private System.DateTime modifiedDateField;
    
    private bool modifiedDateFieldSpecified;
    
    private string priorityField;
    
    private string guidField;
    
    public Comment() {
        this.statusField = "Unknown";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string VerbalStatus {
        get {
            return this.verbalStatusField;
        }
        set {
            this.verbalStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime Date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Author {
        get {
            return this.authorField;
        }
        set {
            this.authorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Comment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Comment1 {
        get {
            return this.comment1Field;
        }
        set {
            this.comment1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CommentTopic Topic {
        get {
            return this.topicField;
        }
        set {
            this.topicField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime ModifiedDate {
        get {
            return this.modifiedDateField;
        }
        set {
            this.modifiedDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ModifiedDateSpecified {
        get {
            return this.modifiedDateFieldSpecified;
        }
        set {
            this.modifiedDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Priority {
        get {
            return this.priorityField;
        }
        set {
            this.priorityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Guid {
        get {
            return this.guidField;
        }
        set {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CommentTopic {
    
    private string guidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Guid {
        get {
            return this.guidField;
        }
        set {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class BimSnippet {
    
    private string referenceField;
    
    private string referenceSchemaField;
    
    private string snippetTypeField;
    
    private bool isExternalField;
    
    public BimSnippet() {
        this.isExternalField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ReferenceSchema {
        get {
            return this.referenceSchemaField;
        }
        set {
            this.referenceSchemaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SnippetType {
        get {
            return this.snippetTypeField;
        }
        set {
            this.snippetTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isExternal {
        get {
            return this.isExternalField;
        }
        set {
            this.isExternalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Topic {
    
    private string referenceLinkField;
    
    private string titleField;
    
    private string indexField;
    
    private string[] labelField;
    
    private System.DateTime creationDateField;
    
    private bool creationDateFieldSpecified;
    
    private System.DateTime modifiedDateField;
    
    private bool modifiedDateFieldSpecified;
    
    private string assignedToField;
    
    private BimSnippet bimSnippetField;
    
    private TopicDocumentReference[] documentReferenceField;
    
    private TopicRelatedTopics[] relatedTopicsField;
    
    private string guidField;
    
    private string topicTypeField;
    
    private string topicStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ReferenceLink {
        get {
            return this.referenceLinkField;
        }
        set {
            this.referenceLinkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string Index {
        get {
            return this.indexField;
        }
        set {
            this.indexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Label", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string[] Label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime CreationDate {
        get {
            return this.creationDateField;
        }
        set {
            this.creationDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CreationDateSpecified {
        get {
            return this.creationDateFieldSpecified;
        }
        set {
            this.creationDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime ModifiedDate {
        get {
            return this.modifiedDateField;
        }
        set {
            this.modifiedDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ModifiedDateSpecified {
        get {
            return this.modifiedDateFieldSpecified;
        }
        set {
            this.modifiedDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string AssignedTo {
        get {
            return this.assignedToField;
        }
        set {
            this.assignedToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BimSnippet BimSnippet {
        get {
            return this.bimSnippetField;
        }
        set {
            this.bimSnippetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TopicDocumentReference[] DocumentReference {
        get {
            return this.documentReferenceField;
        }
        set {
            this.documentReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RelatedTopics", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TopicRelatedTopics[] RelatedTopics {
        get {
            return this.relatedTopicsField;
        }
        set {
            this.relatedTopicsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Guid {
        get {
            return this.guidField;
        }
        set {
            this.guidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TopicType {
        get {
            return this.topicTypeField;
        }
        set {
            this.topicTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TopicStatus {
        get {
            return this.topicStatusField;
        }
        set {
            this.topicStatusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TopicDocumentReference {
    
    private string referencedDocumentField;
    
    private string descriptionField;
    
    private string guidField;
    
    private bool isExternalField;
    
    public TopicDocumentReference() {
        this.isExternalField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ReferencedDocument {
        get {
            return this.referencedDocumentField;
        }
        set {
            this.referencedDocumentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Guid {
        get {
            return this.guidField;
        }
        set {
            this.guidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isExternal {
        get {
            return this.isExternalField;
        }
        set {
            this.isExternalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TopicRelatedTopics {
    
    private string guidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Guid {
        get {
            return this.guidField;
        }
        set {
            this.guidField = value;
        }
    }
}
