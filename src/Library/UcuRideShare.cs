using System.Collections.Generic;
namespace Library;

public sealed class UcuRideShare
{
    public static readonly UcuRideShare Instance = new();
    public readonly List<User> users = new List<User>();
    private UcuRideShare()
    {}
}