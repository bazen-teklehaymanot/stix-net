using StixNet.Base;

namespace StixNet.Sdos;

public class Location : STIXObject
{
    // name, description, latitude, longitude, precision, region, country, administrative_area, 
    // city, street_address, postal_code

    public string? Name { get; set; }
    public string? Description { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Precision { get; set; }
    public string? Region { get; set; } // open-vocab
    public string? Country { get; set; }
    public string? AdministrativeArea { get; set; }
    public string? City { get; set; }
    public string? StreetAddress { get; set; }
    public string? PostalCode { get; set; }
}
