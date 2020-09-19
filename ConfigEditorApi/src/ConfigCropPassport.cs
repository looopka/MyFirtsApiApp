using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigEditorApi.src
{

    public class ConfigCropPassport
    {
        [Required]
        public ConfigCropPassportItem[] Items { get; set; }
    }

    public class ConfigCropPassportItem
    {
        [Required]
        public string Route { get; set; }
        [Required]
        public string ComplectType { get; set; }
        [Required]
        public string OrderCrop { get; set; }
    }


}
