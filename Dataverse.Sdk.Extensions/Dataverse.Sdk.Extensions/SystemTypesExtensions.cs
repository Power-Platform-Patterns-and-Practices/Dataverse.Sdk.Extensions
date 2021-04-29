using Microsoft.Xrm.Sdk;
using System;

namespace Dataverse.Sdk.Extensions
{
    public static class SystemTypesExtensions
    {
        /// <summary>
        /// Returns a reference to an entity based on an unique identifier
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="entityLogicalName">Logical name of the entity to reference</param>
        /// <returns>Reference to the entity with provided id</returns>
        public static EntityReference ToEntityReference(this Guid id, string entityLogicalName)
        {
            return new EntityReference(entityLogicalName, id);
        }

        /// <summary>
        /// Returns a reference to an entity based on an unique identifier
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="entityLogicalName">Logical name of the entity to reference</param>
        /// <returns>Reference to the entity with provided id</returns>
        public static EntityReference ToEntityReference<T>(this Guid id) where T : Entity
        {
            var entityLogicalName = typeof(T).GetField("EntityLogicalName").GetRawConstantValue().ToString();

            return new EntityReference(entityLogicalName, id);
        }
    }
}