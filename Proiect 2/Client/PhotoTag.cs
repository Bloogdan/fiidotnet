﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace ModelWCF
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Tag", Namespace = "http://schemas.datacontract.org/2004/07/ModelWCF", IsReference = true)]
    public partial class Tag : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string NameField;

        private List<ModelWCF.Photo> PhotosField;

        private int TagIdField;

        private string TypeField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<ModelWCF.Photo> Photos
        {
            get
            {
                return this.PhotosField;
            }
            set
            {
                this.PhotosField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TagId
        {
            get
            {
                return this.TagIdField;
            }
            set
            {
                this.TagIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Photo", Namespace = "http://schemas.datacontract.org/2004/07/ModelWCF", IsReference = true)]
    public partial class Photo : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.DateTime CreatedAtField;

        private bool DeletedField;

        private string PathField;

        private int PhotoIdField;

        private List<ModelWCF.Tag> TagsField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhotoId
        {
            get
            {
                return this.PhotoIdField;
            }
            set
            {
                this.PhotoIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<ModelWCF.Tag> Tags
        {
            get
            {
                return this.TagsField;
            }
            set
            {
                this.TagsField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IPhotoTag")]
public interface IPhotoTag
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/AddTag", ReplyAction = "http://tempuri.org/IPhotoTag/AddTagResponse")]
    int AddTag(ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/AddTag", ReplyAction = "http://tempuri.org/IPhotoTag/AddTagResponse")]
    System.Threading.Tasks.Task<int> AddTagAsync(ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/AddPhoto", ReplyAction = "http://tempuri.org/IPhotoTag/AddPhotoResponse")]
    int AddPhoto(ModelWCF.Photo photo);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/AddPhoto", ReplyAction = "http://tempuri.org/IPhotoTag/AddPhotoResponse")]
    System.Threading.Tasks.Task<int> AddPhotoAsync(ModelWCF.Photo photo);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/AddTagToPhoto", ReplyAction = "http://tempuri.org/IPhotoTag/AddTagToPhotoResponse")]
    int AddTagToPhoto(ModelWCF.Photo photo, ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/AddTagToPhoto", ReplyAction = "http://tempuri.org/IPhotoTag/AddTagToPhotoResponse")]
    System.Threading.Tasks.Task<int> AddTagToPhotoAsync(ModelWCF.Photo photo, ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetTag", ReplyAction = "http://tempuri.org/IPhotoTag/GetTagResponse")]
    ModelWCF.Tag GetTag(ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetTag", ReplyAction = "http://tempuri.org/IPhotoTag/GetTagResponse")]
    System.Threading.Tasks.Task<ModelWCF.Tag> GetTagAsync(ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetAllTags", ReplyAction = "http://tempuri.org/IPhotoTag/GetAllTagsResponse")]
    List<ModelWCF.Tag> GetAllTags();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetAllTags", ReplyAction = "http://tempuri.org/IPhotoTag/GetAllTagsResponse")]
    System.Threading.Tasks.Task<List<ModelWCF.Tag>> GetAllTagsAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetTagsOfType", ReplyAction = "http://tempuri.org/IPhotoTag/GetTagsOfTypeResponse")]
    List<ModelWCF.Tag> GetTagsOfType(string tagType);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetTagsOfType", ReplyAction = "http://tempuri.org/IPhotoTag/GetTagsOfTypeResponse")]
    System.Threading.Tasks.Task<List<ModelWCF.Tag>> GetTagsOfTypeAsync(string tagType);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetTagsOfPhoto", ReplyAction = "http://tempuri.org/IPhotoTag/GetTagsOfPhotoResponse")]
    List<ModelWCF.Tag> GetTagsOfPhoto(ModelWCF.Photo photo);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetTagsOfPhoto", ReplyAction = "http://tempuri.org/IPhotoTag/GetTagsOfPhotoResponse")]
    System.Threading.Tasks.Task<List<ModelWCF.Tag>> GetTagsOfPhotoAsync(ModelWCF.Photo photo);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetAllPhotos", ReplyAction = "http://tempuri.org/IPhotoTag/GetAllPhotosResponse")]
    List<ModelWCF.Photo> GetAllPhotos();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetAllPhotos", ReplyAction = "http://tempuri.org/IPhotoTag/GetAllPhotosResponse")]
    System.Threading.Tasks.Task<List<ModelWCF.Photo>> GetAllPhotosAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetPhotosWithTags", ReplyAction = "http://tempuri.org/IPhotoTag/GetPhotosWithTagsResponse")]
    List<ModelWCF.Photo> GetPhotosWithTags(List<ModelWCF.Tag> tags);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetPhotosWithTags", ReplyAction = "http://tempuri.org/IPhotoTag/GetPhotosWithTagsResponse")]
    System.Threading.Tasks.Task<List<ModelWCF.Photo>> GetPhotosWithTagsAsync(List<ModelWCF.Tag> tags);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetPhotoByPath", ReplyAction = "http://tempuri.org/IPhotoTag/GetPhotoByPathResponse")]
    ModelWCF.Photo GetPhotoByPath(string path);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/GetPhotoByPath", ReplyAction = "http://tempuri.org/IPhotoTag/GetPhotoByPathResponse")]
    System.Threading.Tasks.Task<ModelWCF.Photo> GetPhotoByPathAsync(string path);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/UpdatePhotoPath", ReplyAction = "http://tempuri.org/IPhotoTag/UpdatePhotoPathResponse")]
    int UpdatePhotoPath(string oldPath, string newPath);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/UpdatePhotoPath", ReplyAction = "http://tempuri.org/IPhotoTag/UpdatePhotoPathResponse")]
    System.Threading.Tasks.Task<int> UpdatePhotoPathAsync(string oldPath, string newPath);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/DeleteTag", ReplyAction = "http://tempuri.org/IPhotoTag/DeleteTagResponse")]
    int DeleteTag(ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/DeleteTag", ReplyAction = "http://tempuri.org/IPhotoTag/DeleteTagResponse")]
    System.Threading.Tasks.Task<int> DeleteTagAsync(ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/DeletePhoto", ReplyAction = "http://tempuri.org/IPhotoTag/DeletePhotoResponse")]
    int DeletePhoto(ModelWCF.Photo photo);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/DeletePhoto", ReplyAction = "http://tempuri.org/IPhotoTag/DeletePhotoResponse")]
    System.Threading.Tasks.Task<int> DeletePhotoAsync(ModelWCF.Photo photo);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/DeleteTagFromPhoto", ReplyAction = "http://tempuri.org/IPhotoTag/DeleteTagFromPhotoResponse")]
    void DeleteTagFromPhoto(ModelWCF.Photo photo, ModelWCF.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPhotoTag/DeleteTagFromPhoto", ReplyAction = "http://tempuri.org/IPhotoTag/DeleteTagFromPhotoResponse")]
    System.Threading.Tasks.Task DeleteTagFromPhotoAsync(ModelWCF.Photo photo, ModelWCF.Tag tag);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPhotoTagChannel : IPhotoTag, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PhotoTagClient : System.ServiceModel.ClientBase<IPhotoTag>, IPhotoTag
{

    public PhotoTagClient()
    {
    }

    public PhotoTagClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public PhotoTagClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public PhotoTagClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public PhotoTagClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public int AddTag(ModelWCF.Tag tag)
    {
        return base.Channel.AddTag(tag);
    }

    public System.Threading.Tasks.Task<int> AddTagAsync(ModelWCF.Tag tag)
    {
        return base.Channel.AddTagAsync(tag);
    }

    public int AddPhoto(ModelWCF.Photo photo)
    {
        return base.Channel.AddPhoto(photo);
    }

    public System.Threading.Tasks.Task<int> AddPhotoAsync(ModelWCF.Photo photo)
    {
        return base.Channel.AddPhotoAsync(photo);
    }

    public int AddTagToPhoto(ModelWCF.Photo photo, ModelWCF.Tag tag)
    {
        return base.Channel.AddTagToPhoto(photo, tag);
    }

    public System.Threading.Tasks.Task<int> AddTagToPhotoAsync(ModelWCF.Photo photo, ModelWCF.Tag tag)
    {
        return base.Channel.AddTagToPhotoAsync(photo, tag);
    }

    public ModelWCF.Tag GetTag(ModelWCF.Tag tag)
    {
        return base.Channel.GetTag(tag);
    }

    public System.Threading.Tasks.Task<ModelWCF.Tag> GetTagAsync(ModelWCF.Tag tag)
    {
        return base.Channel.GetTagAsync(tag);
    }

    public List<ModelWCF.Tag> GetAllTags()
    {
        return base.Channel.GetAllTags();
    }

    public System.Threading.Tasks.Task<List<ModelWCF.Tag>> GetAllTagsAsync()
    {
        return base.Channel.GetAllTagsAsync();
    }

    public List<ModelWCF.Tag> GetTagsOfType(string tagType)
    {
        return base.Channel.GetTagsOfType(tagType);
    }

    public System.Threading.Tasks.Task<List<ModelWCF.Tag>> GetTagsOfTypeAsync(string tagType)
    {
        return base.Channel.GetTagsOfTypeAsync(tagType);
    }

    public List<ModelWCF.Tag> GetTagsOfPhoto(ModelWCF.Photo photo)
    {
        return base.Channel.GetTagsOfPhoto(photo);
    }

    public System.Threading.Tasks.Task<List<ModelWCF.Tag>> GetTagsOfPhotoAsync(ModelWCF.Photo photo)
    {
        return base.Channel.GetTagsOfPhotoAsync(photo);
    }

    public List<ModelWCF.Photo> GetAllPhotos()
    {
        return base.Channel.GetAllPhotos();
    }

    public System.Threading.Tasks.Task<List<ModelWCF.Photo>> GetAllPhotosAsync()
    {
        return base.Channel.GetAllPhotosAsync();
    }

    public List<ModelWCF.Photo> GetPhotosWithTags(List<ModelWCF.Tag> tags)
    {
        return base.Channel.GetPhotosWithTags(tags);
    }

    public System.Threading.Tasks.Task<List<ModelWCF.Photo>> GetPhotosWithTagsAsync(List<ModelWCF.Tag> tags)
    {
        return base.Channel.GetPhotosWithTagsAsync(tags);
    }

    public ModelWCF.Photo GetPhotoByPath(string path)
    {
        return base.Channel.GetPhotoByPath(path);
    }

    public System.Threading.Tasks.Task<ModelWCF.Photo> GetPhotoByPathAsync(string path)
    {
        return base.Channel.GetPhotoByPathAsync(path);
    }

    public int UpdatePhotoPath(string oldPath, string newPath)
    {
        return base.Channel.UpdatePhotoPath(oldPath, newPath);
    }

    public System.Threading.Tasks.Task<int> UpdatePhotoPathAsync(string oldPath, string newPath)
    {
        return base.Channel.UpdatePhotoPathAsync(oldPath, newPath);
    }

    public int DeleteTag(ModelWCF.Tag tag)
    {
        return base.Channel.DeleteTag(tag);
    }

    public System.Threading.Tasks.Task<int> DeleteTagAsync(ModelWCF.Tag tag)
    {
        return base.Channel.DeleteTagAsync(tag);
    }

    public int DeletePhoto(ModelWCF.Photo photo)
    {
        return base.Channel.DeletePhoto(photo);
    }

    public System.Threading.Tasks.Task<int> DeletePhotoAsync(ModelWCF.Photo photo)
    {
        return base.Channel.DeletePhotoAsync(photo);
    }

    public void DeleteTagFromPhoto(ModelWCF.Photo photo, ModelWCF.Tag tag)
    {
        base.Channel.DeleteTagFromPhoto(photo, tag);
    }

    public System.Threading.Tasks.Task DeleteTagFromPhotoAsync(ModelWCF.Photo photo, ModelWCF.Tag tag)
    {
        return base.Channel.DeleteTagFromPhotoAsync(photo, tag);
    }
}
