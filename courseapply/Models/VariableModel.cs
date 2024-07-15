using System.ComponentModel.DataAnnotations;

namespace courseapply.Models
{
    public class VariableModel
    {
        [Key]
        public int Id { get; set; } = 0;

        public string? email { get; set; } = string.Empty;
        public string? adi { get; set; } = string.Empty;
        public string? soyadi { get; set; } = string.Empty;
        public int? yasi { get; set; }  = 0;
        public DateTime? kayitOlduguTarih { get; set; } = DateTime.Now;
        public string? kursSecimi { get; set; } = string.Empty;
    }
    
}
