using System.ComponentModel.DataAnnotations.Schema;

namespace RedstoneArchive.Abstractions.Data.Models;

[Table("schematic")]
public class Schematic
{
    public int SchematicId { get; set; }
    public byte[] Data { get; set; } = default!;
}
