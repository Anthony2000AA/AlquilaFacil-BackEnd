namespace AlquilaFacilPlatform.Locals.Interfaces.REST.Resources;

public record LocalResource(
    int Id,
    string StreetAddress,
    string LocalName,
    string CityPlace,
    int NightPrice,
    string PhotoUrl,
    string DescriptionMessage,
    int LocalCategoryId,
    int UserId,
    string Features,
    int Capacity,
    double? NoiseLevel,         // Nuevo: opcional, puede ser null
    bool SmokeDetection,        // Nuevo
    string RestrictedArea       // Nuevo: puede ser null o vacío
    );