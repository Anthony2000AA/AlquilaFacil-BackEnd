namespace AlquilaFacilPlatform.Locals.Domain.Model.Commands;

public record CreateLocalCommand(
    string District,
    string Street,
    string LocalType,
    string Country,
    string City,
    int Price,
    string PhotoUrl,
    string DescriptionMessage,
    int LocalCategoryId,
    int UserId,
    string Features,
    int Capacity,
    double? NoiseLevel,         // ← nuevo: opcional, puede ser null
    bool SmokeDetection,        // ← nuevo
    string RestrictedArea       // ← nuevo: puede ser null o vacío
);
