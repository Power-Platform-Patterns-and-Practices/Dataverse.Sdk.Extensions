using Microsoft.Xrm.Sdk;

namespace Dataverse.Sdk.Extensions
{
    public static class EntityReferenceExtensions
    {
        /// <summary>
        /// Returns the Name and Id of an entity reference in a format "Name (id)" (default) if it has a name, and "(id)" if it has no name.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="formatNonEmptyName">The format to use when displaying the name and id.  {0} is the name of the entity reference, {1} is the Guid and {2} is the logical name.</param>
        /// <param name="formatEmptyName">The format to use when displaying the name id.  {0} is the name of the entity reference, {1} is the Guid and {2} is the logical name.</param>
        /// <param name="nullFormat">The value to use when the entity reference is null..</param>
        /// <returns></returns>
        public static string GetNameId(this EntityReference entity, string formatNonEmptyName = "{0} ({1})", string formatEmptyName = "{1}", string nullFormat = "null")
        {
            if (entity == null)
            {
                return nullFormat;
            }

            return string.IsNullOrWhiteSpace(entity.Name)
                ? string.Format(formatEmptyName, entity.Name, entity.Id, entity.LogicalName)
                : string.Format(formatNonEmptyName, entity.Name, entity.Id, entity.LogicalName);
        }
    }
}
