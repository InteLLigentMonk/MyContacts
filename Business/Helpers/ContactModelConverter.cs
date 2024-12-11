using Business.Interfaces;
using Business.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

// This converter is built with the help o Github Copilot.
// It is used to serialize and deserialize the IContactModel interface.
// The converter checks if the object is a BusinessContactModel or a PrivateContactModel.
public class ContactModelConverter : JsonConverter<IContactModel>
{
    public override IContactModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            JsonElement root = doc.RootElement;
            if (root.TryGetProperty("Company", out _) || root.TryGetProperty("ContactName", out _) || root.TryGetProperty("OrganisationNumber", out _))
            {
                return JsonSerializer.Deserialize<BusinessContactModel>(root.GetRawText(), options);
            }
            else if (root.TryGetProperty("FirstName", out _) || root.TryGetProperty("LastName", out _) || root.TryGetProperty("SocialSecurityNumber", out _))
            {
                return JsonSerializer.Deserialize<PrivateContactModel>(root.GetRawText(), options);
            }
            else
            {
                throw new JsonException("Unknown contact type.");
            }
        }
    }

    public override void Write(Utf8JsonWriter writer, IContactModel value, JsonSerializerOptions options)
    {
        if (value is BusinessContactModel businessContact)
        {
            JsonSerializer.Serialize(writer, businessContact, options);
        }
        else if (value is PrivateContactModel privateContact)
        {
            JsonSerializer.Serialize(writer, privateContact, options);
        }
        else
        {
            throw new JsonException("Unknown contact type.");

        }
    }
}
