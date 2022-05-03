using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace app_buldstory.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Parameters
    {
        [JsonConstructor]
        public Parameters(
            [JsonProperty("dataset")] string dataset,
            [JsonProperty("rows")] int rows,
            [JsonProperty("start")] int start,
            [JsonProperty("facet")] List<string> facet,
            [JsonProperty("format")] string format,
            [JsonProperty("timezone")] string timezone
        )
        {
            this.Dataset = dataset;
            this.Rows = rows;
            this.Start = start;
            this.Facet = facet;
            this.Format = format;
            this.Timezone = timezone;
        }

        [JsonProperty("dataset")]
        public string Dataset { get; }

        [JsonProperty("rows")]
        public int Rows { get; }

        [JsonProperty("start")]
        public int Start { get; }

        [JsonProperty("facet")]
        public IReadOnlyList<string> Facet { get; }

        [JsonProperty("format")]
        public string Format { get; }

        [JsonProperty("timezone")]
        public string Timezone { get; }
    }

    public class Fields
    {
        [JsonConstructor]
        public Fields(
            [JsonProperty("recordid")] string recordid,
            [JsonProperty("historique")] string historique,
            [JsonProperty("commune")] string commune,
            [JsonProperty("appellation_courante")] string appellationCourante,
            [JsonProperty("coordonnees")] string coordonnees,
            [JsonProperty("code_departement")] string codeDepartement,
            [JsonProperty("reference")] string reference,
            [JsonProperty("departement")] string departement,
            [JsonProperty("contact")] string contact,
            [JsonProperty("date_de_protection")] string dateDeProtection,
            [JsonProperty("coordonnees_finales")] List<double> coordonneesFinales,
            [JsonProperty("insee")] string insee,
            [JsonProperty("longitude")] string longitude,
            [JsonProperty("coordonnees_ban")] string coordonneesBan,
            [JsonProperty("ancienne_region")] string ancienneRegion,
            [JsonProperty("latitude")] string latitude,
            [JsonProperty("precision_sur_la_protection")] string precisionSurLaProtection,
            [JsonProperty("commune_1")] string commune1,
            [JsonProperty("dmaj")] string dmaj,
            [JsonProperty("siecle")] string siecle,
            [JsonProperty("region")] string region,
            [JsonProperty("statut")] string statut,
            [JsonProperty("adresse")] string adresse,
            [JsonProperty("adresse_1")] string adresse1,
            [JsonProperty("auteur")] string auteur
        )
        {
            this.Recordid = recordid;
            this.Historique = historique;
            this.Commune = commune;
            this.AppellationCourante = appellationCourante;
            this.Coordonnees = coordonnees;
            this.CodeDepartement = codeDepartement;
            this.Reference = reference;
            this.Departement = departement;
            this.Contact = contact;
            this.DateDeProtection = dateDeProtection;
            this.CoordonneesFinales = coordonneesFinales;
            this.Insee = insee;
            this.Longitude = longitude;
            this.CoordonneesBan = coordonneesBan;
            this.AncienneRegion = ancienneRegion;
            this.Latitude = latitude;
            this.PrecisionSurLaProtection = precisionSurLaProtection;
            this.Commune1 = commune1;
            this.Dmaj = dmaj;
            this.Siecle = siecle;
            this.Region = region;
            this.Statut = statut;
            this.Adresse = adresse;
            this.Adresse1 = adresse1;
            this.Auteur = auteur;
        }

        [JsonProperty("recordid")]
        public string Recordid { get; }

        [JsonProperty("historique")]
        public string Historique { get; }

        [JsonProperty("commune")]
        public string Commune { get; }

        [JsonProperty("appellation_courante")]
        public string AppellationCourante { get; }

        [JsonProperty("coordonnees")]
        public string Coordonnees { get; }

        [JsonProperty("code_departement")]
        public string CodeDepartement { get; }

        [JsonProperty("reference")]
        public string Reference { get; }

        [JsonProperty("departement")]
        public string Departement { get; }

        [JsonProperty("contact")]
        public string Contact { get; }

        [JsonProperty("date_de_protection")]
        public string DateDeProtection { get; }

        [JsonProperty("coordonnees_finales")]
        public IReadOnlyList<double> CoordonneesFinales { get; }

        [JsonProperty("insee")]
        public string Insee { get; }

        [JsonProperty("longitude")]
        public string Longitude { get; }

        [JsonProperty("coordonnees_ban")]
        public string CoordonneesBan { get; }

        [JsonProperty("ancienne_region")]
        public string AncienneRegion { get; }

        [JsonProperty("latitude")]
        public string Latitude { get; }

        [JsonProperty("precision_sur_la_protection")]
        public string PrecisionSurLaProtection { get; }

        [JsonProperty("commune_1")]
        public string Commune1 { get; }

        [JsonProperty("dmaj")]
        public string Dmaj { get; }

        [JsonProperty("siecle")]
        public string Siecle { get; }

        [JsonProperty("region")]
        public string Region { get; }

        [JsonProperty("statut")]
        public string Statut { get; }

        [JsonProperty("adresse")]
        public string Adresse { get; }

        [JsonProperty("adresse_1")]
        public string Adresse1 { get; }

        [JsonProperty("auteur")]
        public string Auteur { get; }
    }

    public class Geometry
    {
        [JsonConstructor]
        public Geometry(
            [JsonProperty("type")] string type,
            [JsonProperty("coordinates")] List<double> coordinates
        )
        {
            this.Type = type;
            this.Coordinates = coordinates;
        }

        [JsonProperty("type")]
        public string Type { get; }

        [JsonProperty("coordinates")]
        public IReadOnlyList<double> Coordinates { get; }
    }

    public class Record
    {
        [JsonConstructor]
        public Record(
            [JsonProperty("datasetid")] string datasetid,
            [JsonProperty("recordid")] string recordid,
            [JsonProperty("fields")] Fields fields,
            [JsonProperty("geometry")] Geometry geometry,
            [JsonProperty("record_timestamp")] DateTime recordTimestamp
        )
        {
            this.Datasetid = datasetid;
            this.Recordid = recordid;
            this.Fields = fields;
            this.Geometry = geometry;
            this.RecordTimestamp = recordTimestamp;
        }

        [JsonProperty("datasetid")]
        public string Datasetid { get; }

        [JsonProperty("recordid")]
        public string Recordid { get; }

        [JsonProperty("fields")]
        public Fields Fields { get; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; }

        [JsonProperty("record_timestamp")]
        public DateTime RecordTimestamp { get; }
    }

    public class Facet
    {
        [JsonConstructor]
        public Facet(
            [JsonProperty("name")] string name,
            [JsonProperty("count")] int count,
            [JsonProperty("state")] string state,
            [JsonProperty("path")] string path
        )
        {
            this.Name = name;
            this.Count = count;
            this.State = state;
            this.Path = path;
        }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("count")]
        public int Count { get; }

        [JsonProperty("state")]
        public string State { get; }

        [JsonProperty("path")]
        public string Path { get; }
    }

    public class FacetGroup
    {
        [JsonConstructor]
        public FacetGroup(
            [JsonProperty("name")] string name,
            [JsonProperty("facets")] List<Facet> facets
        )
        {
            this.Name = name;
            this.Facets = facets;
        }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("facets")]
        public IReadOnlyList<Facet> Facets { get; }
    }

    public class MonumentHistory
    {
        [JsonConstructor]
        public MonumentHistory(
            [JsonProperty("nhits")] int nhits,
            [JsonProperty("parameters")] Parameters parameters,
            [JsonProperty("records")] List<Record> records,
            [JsonProperty("facet_groups")] List<FacetGroup> facetGroups
        )
        {
            this.Nhits = nhits;
            this.Parameters = parameters;
            this.Records = records;
            this.FacetGroups = facetGroups;
        }

        [JsonProperty("nhits")]
        public int Nhits { get; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; }

        [JsonProperty("records")]
        public IReadOnlyList<Record> Records { get; }

        [JsonProperty("facet_groups")]
        public IReadOnlyList<FacetGroup> FacetGroups { get; }
    }



}