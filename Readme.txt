1. Two tables

    (1) Supplier
    
    (2) Furniture



dotnet aspnet-codegenerator controller -name SupplierController -m Supplier -dc AppDbContext --useDefaultLayout --referenceScriptLibraries
dotnet aspnet-codegenerator controller -name ProductController -m Product -dc AppDbContext --useDefaultLayout --referenceScriptLibraries
dotnet aspnet-codegenerator controller -name ContactController -m Contact -dc AppDbContext --useDefaultLayout --referenceScriptLibraries 






