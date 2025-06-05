namespace AlquilaFacilPlatform.Locals.Interfaces.REST.Resources;

public record CreateLocalResource(
    string District,
    string Street,
    string LocalName,
    string Country,
    string City,
    int Price,
    string PhotoUrl,
    string DescriptionMessage,
    int LocalCategoryId,
    int UserId,
    string Features,
    int Capacity,
    double? NoiseLevel,         // ← nuevo (opcional, puede ser null)
    bool SmokeDetection,        // ← nuevo
    string RestrictedArea       // ← nuevo (puede ser null o vacío)
);
