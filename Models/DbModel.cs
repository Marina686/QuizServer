
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizServer.Models
{
    [Table("dbs_c01")]
    public class DbModel
    {
        [Key]
        public double Num { get; set; }

        public string Text { get; set; }

        [RegularExpression("^(x\\?|v\\?|\\?|x|v)$", ErrorMessage = "Invalid answer value")]
        public string Answer { get; set; }

        [JsonProperty(PropertyName = "extra_note")]
        public string Note { get; set; }

        public string ExtraNote { get; set; }

        public string Source { get; set; }
    }
}
