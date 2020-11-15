using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio.Domain.Model
{
    [Table("tbSubscribe")]
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        [Column("name")]
        [Required(ErrorMessage = "O Nome deve ser preenchido"),MinLength(3, ErrorMessage = "O campo Nome, deve ter no mínimo 3 caracteres."),MaxLength(ErrorMessage = "O Nome deve ter entre 3 e 250 caracteres.")]
        public string Name { get; set; }
        [Column("email")]
        [Required(ErrorMessage = "O E-mail deve ser preenchido"), DataType(dataType: DataType.EmailAddress,ErrorMessage = "O E-mail não é válido."), MaxLength(ErrorMessage = "O Email deve ter máximo 250 caracteres.")]
        public string Email { get; set; }
        [Column("dt_create")]
        [Required, DataType(DataType.DateTime)]
        public DateTime DtCreate { get; set; }
    }
}
