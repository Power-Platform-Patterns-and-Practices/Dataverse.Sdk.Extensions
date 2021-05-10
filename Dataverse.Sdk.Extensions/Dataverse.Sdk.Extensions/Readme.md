List of extensions class and methods

- [EntityExtensions](https://github.com/Power-Platform-Patterns-and-Practices/Dataverse.Sdk.Extensions/blob/main/Dataverse.Sdk.Extensions/Dataverse.Sdk.Extensions/EntityExtensions.cs) : 
    - AddParty : Add activity party to an activity table row
    - AddParties : Add activity parties to an activity table row
    - ContainsNullValue : Check if specified columns are present in a table row with null value (ie. if they have been emptied)
    - ContainsValue : Check if specified columns are present in a table row with not null value (ie. if they have been set)
    - GetAliasedValue : Get value of an attribute from a linked entity
    - Clone : Clone a row
    - SetParty : Set activity party to an activity table row (ie. empty then add activity party)
    - SetParties : Add activity parties to an activity table row (ie. empty then add activity parties)

- [IOrganizationServiceExtensions](https://github.com/Power-Platform-Patterns-and-Practices/Dataverse.Sdk.Extensions/blob/main/Dataverse.Sdk.Extensions/Dataverse.Sdk.Extensions/IOrganizationServiceExtensions.cs):
    -  CreateFromInitialization : Creates a table row from another table row using standard columns mapping
    -  Delete : Deletes a row by its reference
    -  Delete : Deletes a row directly
    -  Delete : Deletes a row using its alternate key(s)
    -  GetCurrentUserRoles : Gets the list of current user affected roles
    -  GetEnvironmentVariable : Retrieves an Environment variable value
    -  GetEnvironmentVariables : Retrieves multiple Environment variables values
    -  Upsert : Creates or Updates a row, depending if it already exists in the targeted environment

- [SystemTypesExtensions](https://github.com/Power-Platform-Patterns-and-Practices/Dataverse.Sdk.Extensions/blob/main/Dataverse.Sdk.Extensions/Dataverse.Sdk.Extensions/SystemTypesExtensions.cs) :
    -  ToEntityReference : Returns a reference to an entity based on an unique identifier

