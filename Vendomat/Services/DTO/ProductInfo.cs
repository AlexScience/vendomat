using Vendomat.Models;

namespace Vendomat.Services.DTO;

public sealed record ProductInfo(Product Product, int AvailableCount);