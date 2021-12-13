using Microsoft.Extensions.Configuration;
using moduit.Base.Exceptions;

namespace moduit.Base
{
    public class Feature : IFeature
    {
        private readonly IConfiguration _configuration;

        public Feature(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetFeatureConfig(string feature)
        {
            var featureValue = _configuration[$"Features:{feature}"];
            if (string.IsNullOrWhiteSpace(featureValue))
                throw new FeatureNotFoundException("Feature not Found");

            return featureValue;
        }
    }
}
