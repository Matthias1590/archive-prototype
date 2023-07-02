using System.ComponentModel.DataAnnotations.Schema;

namespace RedstoneArchive.Abstractions.Data.Models;

[Table("post")]
public class Post
{
    public int PostId { get; set; }
    public Schematic Schematic { get; set; } = default!;
}
