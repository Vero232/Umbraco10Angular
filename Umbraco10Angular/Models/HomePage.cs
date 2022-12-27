using System.ComponentModel;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Entities;

namespace Umbraco10Angular.Models
{
    public class HomePage : Umbraco.Cms.Core.Models.IContent
    {
     //   public int Id { get; set; }
        public string Name { get; set; }
        public int? TemplateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Published { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PublishedState PublishedState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Edited { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PublishedVersionId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Blueprint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? PublishTemplateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? PublishName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? PublisherId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? PublishDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ContentCultureInfosCollection? PublishCultureInfos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<string> PublishedCultures => throw new NotImplementedException();

        public IEnumerable<string>? EditedCultures { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ContentTypeId => throw new NotImplementedException();

        public ISimpleContentType ContentType => throw new NotImplementedException();

        public int WriterId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VersionId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ContentCultureInfosCollection? CultureInfos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<string> AvailableCultures => throw new NotImplementedException();

        public IPropertyCollection Properties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CreatorId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ParentId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SortOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Trashed => throw new NotImplementedException();

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid Key { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeleteDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool HasIdentity => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;

        public object DeepClone()
        {
            throw new NotImplementedException();
        }

        public IContent DeepCloneWithResetIdentities()
        {
            throw new NotImplementedException();
        }

        public void DisableChangeTracking()
        {
            throw new NotImplementedException();
        }

        public void EnableChangeTracking()
        {
            throw new NotImplementedException();
        }

        public string? GetCultureName(string? culture)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetDirtyProperties()
        {
            throw new NotImplementedException();
        }

        public DateTime? GetPublishDate(string culture)
        {
            throw new NotImplementedException();
        }

        public string? GetPublishName(string? culture)
        {
            throw new NotImplementedException();
        }

        public DateTime? GetUpdateDate(string culture)
        {
            throw new NotImplementedException();
        }

        public object? GetValue(string propertyTypeAlias, string? culture = null, string? segment = null, bool published = false)
        {
            throw new NotImplementedException();
        }

        public TValue? GetValue<TValue>(string propertyTypeAlias, string? culture = null, string? segment = null, bool published = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetWereDirtyProperties()
        {
            throw new NotImplementedException();
        }

        public bool HasProperty(string propertyTypeAlias)
        {
            throw new NotImplementedException();
        }

        public bool IsCultureAvailable(string culture)
        {
            throw new NotImplementedException();
        }

        public bool IsCultureEdited(string culture)
        {
            throw new NotImplementedException();
        }

        public bool IsCulturePublished(string culture)
        {
            throw new NotImplementedException();
        }

        public bool IsDirty()
        {
            throw new NotImplementedException();
        }

        public bool IsPropertyDirty(string propName)
        {
            throw new NotImplementedException();
        }

        public void ResetDirtyProperties(bool rememberDirty)
        {
            throw new NotImplementedException();
        }

        public void ResetDirtyProperties()
        {
            throw new NotImplementedException();
        }

        public void ResetIdentity()
        {
            throw new NotImplementedException();
        }

        public void ResetWereDirtyProperties()
        {
            throw new NotImplementedException();
        }

        public void SetCultureName(string? value, string? culture)
        {
            throw new NotImplementedException();
        }

        public void SetParent(ITreeEntity? parent)
        {
            throw new NotImplementedException();
        }

        public void SetValue(string propertyTypeAlias, object? value, string? culture = null, string? segment = null)
        {
            throw new NotImplementedException();
        }

        public bool WasDirty()
        {
            throw new NotImplementedException();
        }

        public bool WasPropertyDirty(string propertyName)
        {
            throw new NotImplementedException();
        }
    }
}
