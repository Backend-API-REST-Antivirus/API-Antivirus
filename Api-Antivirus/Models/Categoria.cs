using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Categoria
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required string Nombre { get; set; }
    public required string Descripcion { get; set; }
}