using System.Runtime.Serialization;

namespace Griz.Core.Models
{
  [DataContract]
  public class Address : IAddress
  {
    public Address()
    {
    }

    public Address(IAddress address)
    {
      if (address == null) return;

      AddressName = address.AddressName;
      Street = address.Street;
      City = address.City;
      State = address.State;
      ZipCode = address.ZipCode;
    }

    [DataMember(Name = "name")] public string AddressName { get; set; }
    [DataMember(Name = "street")] public string Street { get; set; }
    [DataMember(Name = "city")] public string City { get; set; }
    [DataMember(Name = "state")] public string State { get; set; }
    [DataMember(Name = "postal_code")] public string ZipCode { get; set; }
  }
}
