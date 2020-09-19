using System.ComponentModel.DataAnnotations;

namespace ConfigEditorApi.src
{

    public class ConfigRecognizedField
    {
        [Required]
        public ConfigRecognizedFieldItem[] Items { get; set; }
    }

    public class ConfigRecognizedFieldItem
    {
        [Required]
        public string Route { get; set; }
        [Required]
        public string ComplectType { get; set; }
        [Required]
        public string OrderAddress { get; set; }
        [Required]
        public string OrderInput { get; set; }
    }

}
