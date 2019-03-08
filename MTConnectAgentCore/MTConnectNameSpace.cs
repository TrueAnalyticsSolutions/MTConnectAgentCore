

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MTConnectAgentCore {
  public static class MTConnectNameSpace {
    private static string mtcVersion = "1.1";
    private static string mtcUrn = "urn:mtconnect.org:MTConnect";
    private static string mtcHttp = "http://mtconnect.org/schemas/MTConnect";
    public static XNamespace mtcUrnError {
      get{
        return mtcUrnErrorString;// mtcUrn + "Error:" + mtcVersion;
      }
    }
    public static XNamespace mtcUrnStreams {
      get{
        return mtcUrnStreamsString;// mtcUrn + "Streams:" + mtcVersion;
      }
    }//; = "urn:mtconnect.org:MTConnectStreams:1.2";
    public static XNamespace mtcUrnDevices {
      get{
        return mtcUrnDevicesString;// mtcUrn + "Devices:" + mtcVersion;
      }
    }
    public static string mtcUrnErrorString {
      get {
        return mtcUrn + "Error:" + mtcVersion;
      }
    }
    public static string mtcUrnStreamsString {
      get {
        return mtcUrn + "Streams:" + mtcVersion;
      }
    }
    public static string mtcUrnDevicesString {
      get {
        return mtcUrn + "Devices:" + mtcVersion;
      }
    }

    public static XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";

    //used in namespacemanager

    public static String mtcDevicesXsd{
      get{
        return mtcHttp + "Devices:" + mtcVersion + ".xsd";
      }
    }// = "urn:mtconnect.org:MTConnectDevices:1.2";
    public static String mtcStreamsXsd {
      get{
        return mtcHttp + "Streams:" + mtcVersion + ".xsd";
      }
    //= "urn:mtconnect.org:MTConnectStreams:1.2";
    }
    public static String mtcErrorXsd {
      get{
        return mtcHttp + "Error:" + mtcVersion + ".xsd";
      }
    //= "urn:mtconnect.org:MTConnectError:1.2";
    }

    public static String mtConnectPrefix = "mt";

    //public static string mtSchemaUriDevices =  "urn:mtconnect.org:MTConnectDevices:1.2 ";
  }
}
