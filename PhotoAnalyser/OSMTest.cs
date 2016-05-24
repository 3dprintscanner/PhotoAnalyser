using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using OsmSharp.Osm;
using OsmSharp.Osm.Xml.Streams;

namespace PhotoAnalyser
{
    public class OSMTest
    {
        public WaysRoutes GetData()
        {
            var waysQuery = "ways(51.18881185379808,4.370841979980469,51.244939510768184,4.454612731933594);out;";
            var nodesQuery = "nodes(51.18881185379808,4.370841979980469,51.244939510768184,4.454612731933594);out;";

            // create and execute the webrequest.
            // get the data
            //var text = new StreamReader(requestStream).ReadToEnd();
            //File.WriteAllText(@"C:\test\relation.xml", text);
            var waysStream = GetOsmStream(waysQuery);

            var nodesStream = GetOsmStream(nodesQuery);
            // use an XML data processor source.

            var ways = DeserializeOsm(waysStream);
            // get the ways in an area

            var nodes = DeserializeOsm(nodesStream);

            // pull the data from the stream and deserialize XML.
            var wayEntities = new List<OsmGeo>(ways);

            var nodesEntities = new List<OsmGeo>(nodes);

            return new WaysRoutes() {Ways = wayEntities, Nodes = nodesEntities};
        }

        private List<OsmGeo> DeserializeOsm(Stream stream)
        {
            var source = new XmlOsmStreamSource(stream);


            // pull the data from the stream and deserialize XML.
            var osmEntities = new List<OsmGeo>(source);

            return osmEntities;
        }

        public Stream GetOsmStream(string query)
        {
            var request = WebRequest.Create(
                "http://overpass-api.de/api/interpreter?data=" + query);
            request.Method = "GET";
            return request.GetResponse().GetResponseStream();

        }
    }

    public class WaysRoutes
    {
        public IEnumerable<OsmGeo> Ways { get; set; }
        public IEnumerable<OsmGeo> Nodes{ get; set; }
    }
}