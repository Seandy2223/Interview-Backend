using Microsoft.AspNetCore.Mvc;
using moduit.Base;
using moduit.Base.Enum;
using moduit.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moduit.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModuitTestController : ControllerBase
    {
        private readonly IRESTService _rest;

        public ModuitTestController(IRESTService rest)
        {
            _rest = rest;
        }

        [HttpGet]
        public string Get()
        {
            return "try using https://localhost:44377/ModuitTest/GetQuestions{number}";
        }

        [HttpGet]
        [Route("GetQuestionsOne")]
        public async Task<string> GetQuestionsOne()
        {
            var result = await _rest.REST("backend/question/one", RequestEnum.GET);
            if (result != null)
            {
                var response = await _rest.ConvertResponseToEntity<ModelOne>(result);
                if (response.id != 0)
                {
                    return JsonConvert.SerializeObject(response);
                }
            }

            return null;
        }

        [HttpGet]
        [Route("GetQuestionsTwo")]
        public async Task<string> GetQuestionsTwo()
        {
            var result = await _rest.REST("backend/question/two", RequestEnum.GET);
            if (result != null)
            {
                var response = await _rest.ConvertResponseToEntity<List<ModelTwo>>(result);
                if (response.Count != 0)
                {
                    return JsonConvert.SerializeObject(response.Where(m => (m.description.Contains("Ergonomics") || m.title.Contains("Ergonomics")) && (m.tags != null && m.tags.Contains("Sports"))).OrderByDescending(m => m.id).TakeLast(3).Select(m => m).ToList());
                }
            }

            return null;
        }

        [HttpGet]
        [Route("GetQuestionsThree")]
        public async Task<string> GetQuestionsThree()
        {
            var responseResult = new List<ModelTwo>();
            var result = await _rest.REST("backend/question/three", RequestEnum.GET);
            if (result != null)
            {
                var data = await _rest.ConvertResponseToEntity<List<ModelThree>>(result);
                foreach (var item in data)
                {
                    var model = new ModelTwo();
                    model.id = item.Id;
                    model.category = item.Category;
                    model.createdAt = item.createdAt;
                    model.tags = item.Tags;

                    if (item.items != null)
                        foreach (var obj in item.items)
                        {
                            var duplicate = model;
                            duplicate.description = obj.description;
                            duplicate.title = obj.Title;
                            duplicate.footer = obj.footer;
                            responseResult.Add(duplicate);
                        }
                    else
                        responseResult.Add(model);
                }
            }

            return JsonConvert.SerializeObject(responseResult);
        }
    }
}
