using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ConfigEditorApi.src;


namespace ConfigEditorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigsController : ControllerBase
    {
        
        // GET: api/<ConfigsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Functions functions = new src.Functions();
            return functions.GetAllFileName();
        }

        // GET api/<ConfigsController>/name
        [HttpGet("{configName}")]
        public IActionResult Get(string configName)
        {
            Functions functions = new src.Functions();
            if (configName == "config_crop_passport")
            {
                ConfigCropPassport configCropPassport = JsonConvert
                                                            .DeserializeObject<src.ConfigCropPassport>
                                                            (functions.GetConfigText(configName));
                return Ok(configCropPassport);
            }
            if (configName == "config_recognized_field")
            {
                ConfigRecognizedField configRecognizedField = JsonConvert
                                                                  .DeserializeObject<src.ConfigRecognizedField>
                                                                  (functions.GetConfigText(configName));
                return Ok(configRecognizedField);
            }
            return NotFound();
        }

        // PUT api/<ConfigsController>/name
        [HttpPut("config_crop_passport")]
        public IActionResult Put(ConfigCropPassport configCropPassport)
        {
            string request;
            if (configCropPassport == null)
                return BadRequest();
            Functions functions = new src.Functions();
            request = functions.WriteConfig(configCropPassport, "config_crop_passport");
            if (request == "File not exists!")
                return NotFound(request);
            return Ok(request);

        }
        [HttpPut("config_recognized_field")]
        public IActionResult Put(ConfigRecognizedField configRecognizedField)
        {
            string request;
            if (configRecognizedField == null)
                return BadRequest();
            Functions functions = new src.Functions();
            request = functions.WriteConfig(configRecognizedField, "config_recognized_field");
            if (request == "File not exists!")
                return NotFound(request);
            return Ok(request);
        }

    }
}
