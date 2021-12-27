using System.Xml.Serialization;

namespace OSM.Models
{
    namespace Xml2CSharp
    {
        [XmlRoot(ElementName = "bounds")]
		public class Bounds
		{
			[XmlAttribute(AttributeName = "minlat")]
			public string Minlat { get; set; } = null!;
			[XmlAttribute(AttributeName = "minlon")]
			public string Minlon { get; set; } = null!;
			[XmlAttribute(AttributeName = "maxlat")]
			public string Maxlat { get; set; } = null!;
			[XmlAttribute(AttributeName = "maxlon")]
			public string Maxlon { get; set; } = null!;
		}

		[XmlRoot(ElementName = "tag")]
		public class Tag
		{
			[XmlAttribute(AttributeName = "k")]
			public string Key { get; set; } = null!;
			[XmlAttribute(AttributeName = "v")]
			public string Value { get; set; } = null!;
		}

		[XmlRoot(ElementName = "node")]
		public class Node
		{
			[XmlElement(ElementName = "tag")]
			public List<Tag> Tag { get; set; } = null!;
			[XmlAttribute(AttributeName = "id")]
			public string Id { get; set; } = null!;
			[XmlAttribute(AttributeName = "visible")]
			public string Visible { get; set; } = null!;
			[XmlAttribute(AttributeName = "version")]
			public string Version { get; set; } = null!;
			[XmlAttribute(AttributeName = "changeset")]
			public string Changeset { get; set; } = null!;
			[XmlAttribute(AttributeName = "timestamp")]
			public string Timestamp { get; set; } = null!;
			[XmlAttribute(AttributeName = "user")]
			public string User { get; set; } = null!;
			[XmlAttribute(AttributeName = "uid")]
			public string Uid { get; set; } = null!;
			[XmlAttribute(AttributeName = "lat")]
			public string Latitude { get; set; } = null!;
			[XmlAttribute(AttributeName = "lon")]
			public string Longitude { get; set; } = null!;
		}

		[XmlRoot(ElementName = "nd")]
		public class Nd
		{
			[XmlAttribute(AttributeName = "ref")]
			public string Ref { get; set; } = null!;
		}

		[XmlRoot(ElementName = "way")]
		public class Way
		{
			[XmlElement(ElementName = "nd")]
			public List<Nd> Nd { get; set; } = null!;
			[XmlElement(ElementName = "tag")]
			public List<Tag> Tag { get; set; } = null!;
			[XmlAttribute(AttributeName = "id")]
			public string Id { get; set; } = null!;
			[XmlAttribute(AttributeName = "visible")]
			public string Visible { get; set; } = null!;
			[XmlAttribute(AttributeName = "version")]
			public string Version { get; set; } = null!;
			[XmlAttribute(AttributeName = "changeset")]
			public string Changeset { get; set; } = null!;
			[XmlAttribute(AttributeName = "timestamp")]
			public string Timestamp { get; set; } = null!;
			[XmlAttribute(AttributeName = "user")]
			public string User { get; set; } = null!;
			[XmlAttribute(AttributeName = "uid")]
			public string Uid { get; set; } = null!;
		}

		[XmlRoot(ElementName = "member")]
		public class Member
		{
			[XmlAttribute(AttributeName = "type")]
			public string Type { get; set; } = null!;
			[XmlAttribute(AttributeName = "ref")]
			public string Ref { get; set; } = null!;
			[XmlAttribute(AttributeName = "role")]
			public string Role { get; set; } = null!;
		}

		[XmlRoot(ElementName = "relation")]
		public class Relation
		{
			[XmlElement(ElementName = "member")]
			public List<Member> Member { get; set; } = null!;
			[XmlElement(ElementName = "tag")]
			public List<Tag> Tag { get; set; } = null!;
			[XmlAttribute(AttributeName = "id")]
			public string Id { get; set; } = null!;
			[XmlAttribute(AttributeName = "visible")]
			public string Visible { get; set; } = null!;
			[XmlAttribute(AttributeName = "version")]
			public string Version { get; set; } = null!;
			[XmlAttribute(AttributeName = "changeset")]
			public string Changeset { get; set; } = null!;
			[XmlAttribute(AttributeName = "timestamp")]
			public string Timestamp { get; set; } = null!;
			[XmlAttribute(AttributeName = "user")]
			public string User { get; set; } = null!;
			[XmlAttribute(AttributeName = "uid")]
			public string Uid { get; set; } = null!;
		}

		[XmlRoot(ElementName = "osm")]
		public class Osm
		{
			[XmlElement(ElementName = "bounds")]
			public Bounds Bounds { get; set; } = null!;
			[XmlElement(ElementName = "node")]
			public List<Node> Node { get; set; } = null!;
			[XmlElement(ElementName = "way")]
			public Way Way { get; set; } = null!;
			[XmlElement(ElementName = "relation")]
			public Relation Relation { get; set; } = null!;
			[XmlAttribute(AttributeName = "version")]
			public string Version { get; set; } = null!;
			[XmlAttribute(AttributeName = "generator")]
			public string Generator { get; set; } = null!;
			[XmlAttribute(AttributeName = "copyright")]
			public string Copyright { get; set; } = null!;
			[XmlAttribute(AttributeName = "attribution")]
			public string Attribution { get; set; } = null!;
			[XmlAttribute(AttributeName = "license")]
			public string License { get; set; } = null!;
		}

	}
}
