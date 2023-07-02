using System.ComponentModel.DataAnnotations.Schema;

namespace RedstoneArchive.Abstractions.Data.Models;

[Table("comment")]
public class Comment
{
    public int CommentId { get; set; }
    public DateTime PostedAt { get; set; }
    public string Content { get; set; } = default!;
    public Post Post { get; set; } = default!;
}
