using NUnit;
using NUnit.Engine;
using NUnit.Engine.Extensibility;

namespace Extension
{
    [Extension(Description = "Engine Extension", EngineVersion = "3.5")]
    public class CustomTestEventListener : ITestEventListener
    {
        public void OnTestEvent(string report)
        {
            var xmlNode = XmlHelper.CreateXmlNode(report);

            switch (xmlNode.Name)
            {
                case "start-run":
                    {
                        Logging.Write("Run started...");
                        break;
                    }
                case "test-run":
                    {
                        Logging.Write("Run finished.");
                        break;
                    }
                case "start-test":
                    {
                        Logging.Write($"Test '{xmlNode.GetAttribute("name")}' started...");
                        break;
                    }
                case "test-case":
                    {
                        Logging.Write($"Test '{xmlNode.GetAttribute("name")}' finished with result '{xmlNode.GetAttribute("result")}'");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
